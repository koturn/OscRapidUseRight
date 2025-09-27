#if NET7_0_OR_GREATER
#    define SUPPORT_LIBRARY_IMPORT
#endif  // NET7_0_OR_GREATER

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Security;
using OscRapidUseRight.Internals;


namespace OscRapidUseRight.Win32.GlobalHotKeys
{
    /// <summary>
    /// Hot Key Manager.
    /// </summary>
    /// <remarks>
    /// ctor: Initialize target window handle.
    /// </remarks>
    /// <param name="hWnd">Target window handle.</param>
#if SUPPORT_LIBRARY_IMPORT
    public partial class GlobalHotKeyManager(IntPtr hWnd) : IDisposable
#else
    public class GlobalHotKeyManager(IntPtr hWnd) : IDisposable
#endif  // SUPPORT_LIBRARY_IMPORT
    {
        /// <summary>
        /// Message ID of Hot Key.
        /// </summary>
        public const int MessageId = 0x0312;

        /// <summary>
        /// A flag property which indicates this instance is disposed or not.
        /// </summary>
        public bool IsDisposed { get; private set; } = false;
        /// <summary>
        /// Registered IDs.
        /// </summary>
        public IReadOnlyCollection<int> RegisteredIds => _registerdIdSet;

        /// <summary>
        /// Target window handle.
        /// </summary>
        private readonly IntPtr _hWnd = hWnd;
        /// <summary>
        /// The set of registered hot key IDs.
        /// </summary>
        private readonly HashSet<int> _registerdIdSet = [];

        /// <summary>
        /// Defines a system-wide hot key.
        /// </summary>
        /// <param name="key">The virtual-key code of the hot key. See Virtual Key Codes.</param>
        /// <returns>Registered hotkey ID.</returns>
        public int Register(Keys key)
        {
            return Register(ModifierKeys.None, key);
        }

        /// <summary>
        /// Defines a system-wide hot key.
        /// </summary>
        /// <param name="modKey">The keys that must be pressed in combination with the key specified by the uVirtKey parameter
        /// in order to generate the <see cref="MessageId"/> message.</param>
        /// <param name="key">The virtual-key code of the hot key. See Virtual Key Codes.</param>
        /// <returns>true when succeeded to register hotkey, otherwise false.</returns>
        public int Register(ModifierKeys modKey, Keys key)
        {
            if (TryRegister(modKey, key, out var hotKeyId))
            {
                return hotKeyId;
            }
            else
            {
                ThrowHelper.ThrowLastWin32Exception(nameof(SafeNativeMethods.RegisterHotKey) + " failed");
                return -1;
            }
        }

        /// <summary>
        /// Defines a system-wide hot key.
        /// </summary>
        /// <param name="key">The virtual-key code of the hot key. See Virtual Key Codes.</param>
        /// <param name="id">Hot Key ID.</param>
        /// <returns>true when succeeded to register hotkey, otherwise false.</returns>
        public bool TryRegister(Keys key, out int id)
        {
            return TryRegister(ModifierKeys.None, key, out id);
        }

        /// <summary>
        /// Defines a system-wide hot key.
        /// </summary>
        /// <param name="modKey">The keys that must be pressed in combination with the key specified by the uVirtKey parameter
        /// in order to generate the <see cref="MessageId"/> message.</param>
        /// <param name="key">The virtual-key code of the hot key. See Virtual Key Codes.</param>
        /// <param name="hotKeyId">Hot Key ID.</param>
        /// <returns>true when succeeded to register hotkey, otherwise false.</returns>
        public bool TryRegister(ModifierKeys modKey, Keys key, out int hotKeyId)
        {
            hotKeyId = -1;

            var hWnd = _hWnd;
            var idSet = _registerdIdSet;
            for (int id = 0x0000; id <= 0xbfff; id++)
            {
                if (idSet.Contains(id))
                {
                    continue;
                }
                if (SafeNativeMethods.RegisterHotKey(hWnd, id, modKey, key))
                {
                    hotKeyId = id;
                    idSet.Add(id);
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Frees a hot key previously registered by the calling thread.
        /// </summary>
        /// <param name="id">The identifier of the hot key to be freed.</param>
        public void Unregister(int id)
        {
            if (!TryUnregister(id))
            {
                ThrowHelper.ThrowLastWin32Exception(nameof(SafeNativeMethods.UnregisterHotKey) + " failed");
            }
        }

        /// <summary>
        /// Frees a hot key previously registered by the calling thread.
        /// </summary>
        /// <param name="id">The identifier of the hot key to be freed.</param>
        public bool TryUnregister(int id)
        {
            var result = SafeNativeMethods.UnregisterHotKey(_hWnd, id);
            if (result)
            {
                _registerdIdSet.Remove(id);
            }
            return result;
        }

        /// <summary>
        /// Frees all hot keys previously registered by the calling thread.
        /// </summary>
        /// <exception cref="Win32Exception">Thrown when any of registered hot keys is failed to unregister.</exception>
        public void UnregisterAll()
        {
            var hWnd = _hWnd;
            foreach (var id in _registerdIdSet)
            {
                if (!SafeNativeMethods.UnregisterHotKey(hWnd, id))
                {
                    ThrowHelper.ThrowLastWin32Exception(nameof(SafeNativeMethods.UnregisterHotKey) + " failed");
                }
            }
            _registerdIdSet.Clear();
        }

        /// <summary>
        /// Release all resources used by the <see cref="GlobalHotKeyManager"/> object.
        /// </summary>
        public void Dispose()
        {
            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
            Dispose(true);
            GC.SuppressFinalize(this);
        }


        /// <summary>
        /// Release resources.
        /// </summary>
        /// <param name="disposing"><c>true</c> to release both managed and unmanaged resources;
        /// <c>false</c> to release only unmanaged resources.</param>
        protected virtual void Dispose(bool disposing)
        {
            if (IsDisposed)
            {
                return;
            }

            if (disposing)
            {
                // Do nothing.
            }

            UnregisterAll();
        }

        /// <summary>
        /// Release unmanaged resources.
        /// </summary>
        ~GlobalHotKeyManager()
        {
            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
            Dispose(false);
        }

        /// <summary>
        /// Provides native methods.
        /// </summary>
        [SuppressUnmanagedCodeSecurity]
#if SUPPORT_LIBRARY_IMPORT
        internal static partial class SafeNativeMethods
#else
        internal static class SafeNativeMethods
#endif  // SUPPORT_LIBRARY_IMPORT
        {
            /// <summary>
            /// Defines a system-wide hot key.
            /// </summary>
            /// <param name="hWnd">A handle to the window that will receive WM_HOTKEY messages generated by the hot key.
            /// If this parameter is <see cref="IntPtr.Zero"/>, WM_HOTKEY messages are posted to the message queue of the calling thread and must be processed in the message loop.</param>
            /// <param name="id">The identifier of the hot key.
            /// If the <paramref name="hWnd"/> parameter is <see cref="IntPtr.Zero"/>, then the hot key is associated with the current thread rather than with a particular window.
            /// If a hot key already exists with the same hWnd and hotKeyId parameters, see Remarks for the action taken.</param>
            /// <param name="modKey">The keys that must be pressed in combination with the key specified by the uVirtKey parameter in order to generate the WM_HOTKEY message.
            /// The fsModifiers parameter can be a combination of the <see cref="ModifierKeys"/> values.</param>
            /// <param name="key">The virtual-key code of the hot key. See Virtual Key Codes.</param>
            /// <returns>
            /// <para>If the function succeeds, the return value is true.</para>
            /// <para>If the function fails, the return value is false.
            /// To get extended error information, call <see cref="Marshal.GetLastWin32Error"/>.</para>
            /// </returns>
            /// <remarks>
            /// <para><seealso href="https://learn.microsoft.com/en-us/windows/win32/api/winuser/nf-winuser-registerhotkey"/></para>
            /// <para>When a key is pressed, the system looks for a match against all hot keys.
            /// Upon finding a match, the system posts the WM_HOTKEY message to the message queue of the window with which the hot key is associated.
            /// If the hot key is not associated with a window, then the WM_HOTKEY message is posted to the thread associated with the hot key.</para>
            /// <para>This function cannot associate a hot key with a window created by another thread.</para>
            /// <para><see cref="RegisterHotKey(IntPtr, int, ModifierKeys, Keys)"/> fails if the keystrokes specified for the hot key have already been registered by another hot key.</para>
            /// <para>If a hot key already exists with the same <paramref name="hWnd"/> and hotKeyId parameters, it is maintained along with the new hot key.
            /// The application must explicitly call <see cref="UnregisterHotKey(IntPtr, int)"/> to unregister the old hot key.</para>
            /// <para>Windows Server 2003: If a hot key already exists with the same hWnd and hotKeyId parameters, it is replaced by the new hot key.</para>
            /// <para>The F12 key is reserved for use by the debugger at all times, so it should not be registered as a hot key.
            /// Even when you are not debugging an application, F12 is reserved in case a kernel-mode debugger or a just-in-time debugger is resident.</para>
            /// <para>An application must specify an hotKeyId value in the range 0x0000 through 0xBFFF.
            /// A shared DLL must specify a value in the range 0xC000 through 0xFFFF (the range returned by the GlobalAddAtom function).
            /// To avoid conflicts with hot-key identifiers defined by other shared DLLs, a DLL should use the GlobalAddAtom function to obtain the hot-key identifier.</para>
            /// </remarks>
#if SUPPORT_LIBRARY_IMPORT
            [LibraryImport("user32.dll", EntryPoint = nameof(RegisterHotKey), SetLastError = true)]
            [return: MarshalAs(UnmanagedType.Bool)]
            public static partial bool RegisterHotKey(IntPtr hWnd, int id, ModifierKeys modKey, Keys key);
#else
            [DllImport("user32.dll", EntryPoint = nameof(RegisterHotKey), ExactSpelling = true, SetLastError = true)]
            [return: MarshalAs(UnmanagedType.Bool)]
            public static extern bool RegisterHotKey(IntPtr hWnd, int id, ModifierKeys modKey, Keys key);
#endif  // SUPPORT_LIBRARY_IMPORT

            /// <summary>
            /// Frees a hot key previously registered by the calling thread.
            /// </summary>
            /// <param name="hWnd">A handle to the window associated with the hot key to be freed.
            /// This parameter should be <see cref="IntPtr.Zero"/> if the hot key is not associated with a window.</param>
            /// <param name="id">The identifier of the hot key to be freed.</param>
            /// <returns>
            /// <para>If the function succeeds, the return value is nonzero.</para>
            /// <para>If the function fails, the return value is zero. To get extended error information, call <see cref="Marshal.GetLastWin32Error"/>.</para>
            /// </returns>
#if SUPPORT_LIBRARY_IMPORT
            [LibraryImport("user32.dll", EntryPoint = nameof(UnregisterHotKey), SetLastError = true)]
            [return: MarshalAs(UnmanagedType.Bool)]
            public static partial bool UnregisterHotKey(IntPtr hWnd, int id);
#else
            [DllImport("user32.dll", EntryPoint = nameof(UnregisterHotKey), ExactSpelling = true, SetLastError = true)]
            [return: MarshalAs(UnmanagedType.Bool)]
            public static extern bool UnregisterHotKey(IntPtr hWnd, int id);
#endif  // SUPPORT_LIBRARY_IMPORT
        }
    }
}
