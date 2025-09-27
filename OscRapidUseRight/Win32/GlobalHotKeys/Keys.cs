#pragma warning disable IDE0079 // Remove unnecessary suppression
#pragma warning disable CA1069 // Enums values should not be duplicated


namespace OscRapidUseRight.Win32.GlobalHotKeys
{
    /// <summary>
    /// Specifies key codes and modifiers.
    /// </summary>
    public enum Keys
    {
        /// <summary>
        /// The bit mask to extract a key code from a key value.
        /// </summary>
        KeyCode = 0x0000ffff,
        /// <summary>
        /// The bit mask to extract modifiers from a key value.
        /// </summary>
        Modifiers = unchecked((int)0xffff0000),
        /// <summary>
        /// No key pressed.
        /// </summary>
        None = 0x00,
        /// <summary>
        /// The left mouse button.
        /// </summary>
        LButton = 0x01,
        /// <summary>
        /// The right mouse button.
        /// </summary>
        RButton = 0x02,
        /// <summary>
        /// The CANCEL key.
        /// </summary>
        Cancel = 0x03,
        /// <summary>
        /// The middle mouse button (three-button mouse).
        /// </summary>
        MButton = 0x04,
        /// <summary>
        /// The first x mouse button (five-button mouse).
        /// </summary>
        XButton1 = 0x05,
        /// <summary>
        /// The second x mouse button (five-button mouse).
        /// </summary>
        XButton2 = 0x06,
        /// <summary>
        /// The BACKSPACE key.
        /// </summary>
        Back = 0x08,
        /// <summary>
        /// The TAB key.
        /// </summary>
        Tab = 0x09,
        /// <summary>
        /// The CLEAR key.
        /// </summary>
        LineFeed = 0x0a,
        /// <summary>
        /// The CLEAR key.
        /// </summary>
        Clear = 0x0c,
        /// <summary>
        /// The RETURN key.
        /// </summary>
        Return = 0x0d,
        /// <summary>
        /// The ENTER key.
        /// </summary>
        Enter = Return,
        /// <summary>
        /// The SHIFT key.
        /// </summary>
        ShiftKey = 0x10,
        /// <summary>
        /// The CTRL key.
        /// </summary>
        ControlKey = 0x11,
        /// <summary>
        /// The ALT key.
        /// </summary>
        Menu = 0x12,
        /// <summary>
        /// The PAUSE key.
        /// </summary>
        Pause = 0x13,
        /// <summary>
        /// The CAPS LOCK key.
        /// </summary>
        Capital = 0x14,
        /// <summary>
        /// The CAPS LOCK key.
        /// </summary>
        CapsLock = 0x14,
        /// <summary>
        /// The IME Kana mode key.
        /// </summary>
        KanaMode = 0x15,
        /// <summary>
        /// The IME Hanguel mode key.
        /// </summary>
        HanguelMode = 0x15,
        /// <summary>
        /// The IME Hangul mode key.
        /// </summary>
        HangulMode = 0x15,
        /// <summary>
        /// The IME Junja mode key.
        /// </summary>
        JunjaMode = 0x17,
        /// <summary>
        /// The IME Final mode key.
        /// </summary>
        FinalMode = 0x18,
        /// <summary>
        /// The IME Hanja mode key.
        /// </summary>
        HanjaMode = 0x19,
        /// <summary>
        /// The IME Kanji mode key.
        /// </summary>
        KanjiMode = 0x19,
        /// <summary>
        /// The ESC key.
        /// </summary>
        Escape = 0x1b,
        /// <summary>
        /// The IME Convert key.
        /// </summary>
        IMEConvert = 0x1c,
        /// <summary>
        /// The IME NonConvert key.
        /// </summary>
        IMENonconvert = 0x1d,
        /// <summary>
        /// The IME Accept key.
        /// </summary>
        IMEAccept = 0x1e,
        /// <summary>
        /// The IME Accept key.
        /// </summary>
        IMEAceept = IMEAccept,
        /// <summary>
        /// The IME Mode change request.
        /// </summary>
        IMEModeChange = 0x1f,
        /// <summary>
        /// The SPACEBAR key.
        /// </summary>
        Space = 0x20,
        /// <summary>
        /// The PAGE UP key.
        /// </summary>
        Prior = 0x21,
        /// <summary>
        /// The PAGE UP key.
        /// </summary>
        PageUp = Prior,
        /// <summary>
        /// The PAGE DOWN key.
        /// </summary>
        Next = 0x22,
        /// <summary>
        /// The PAGE DOWN key.
        /// </summary>
        PageDown = Next,
        /// <summary>
        /// The END key.
        /// </summary>
        End = 0x23,
        /// <summary>
        /// The HOME key.
        /// </summary>
        Home = 0x24,
        /// <summary>
        /// The LEFT ARROW key.
        /// </summary>
        Left = 0x25,
        /// <summary>
        /// The UP ARROW key.
        /// </summary>
        Up = 0x26,
        /// <summary>
        /// The RIGHT ARROW key.
        /// </summary>
        Right = 0x27,
        /// <summary>
        /// The DOWN ARROW key.
        /// </summary>
        Down = 0x28,
        /// <summary>
        /// The SELECT key.
        /// </summary>
        Select = 0x29,
        /// <summary>
        /// The PRINT key.
        /// </summary>
        Print = 0x2a,
        /// <summary>
        /// The EXECUTE key.
        /// </summary>
        Execute = 0x2b,
        /// <summary>
        /// The PRINT SCREEN key.
        /// </summary>
        Snapshot = 0x2c,
        /// <summary>
        /// The PRINT SCREEN key.
        /// </summary>
        PrintScreen = Snapshot,
        /// <summary>
        /// The INS key.
        /// </summary>
        Insert = 0x2d,
        /// <summary>
        /// The DEL key.
        /// </summary>
        Delete = 0x2e,
        /// <summary>
        /// The HELP key.
        /// </summary>
        Help = 0x2f,
        /// <summary>
        /// The 0 key.
        /// </summary>
        D0 = 0x30, // 0
        /// <summary>
        /// The 1 key.
        /// </summary>
        D1 = 0x31, // 1
        /// <summary>
        /// The 2 key.
        /// </summary>
        D2 = 0x32, // 2
        /// <summary>
        /// The 3 key.
        /// </summary>
        D3 = 0x33, // 3
        /// <summary>
        /// The 4 key.
        /// </summary>
        D4 = 0x34, // 4
        /// <summary>
        /// The 5 key.
        /// </summary>
        D5 = 0x35, // 5
        /// <summary>
        /// The 6 key.
        /// </summary>
        D6 = 0x36, // 6
        /// <summary>
        /// The 7 key.
        /// </summary>
        D7 = 0x37, // 7
        /// <summary>
        /// The 8 key.
        /// </summary>
        D8 = 0x38, // 8
        /// <summary>
        /// The 9 key.
        /// </summary>
        D9 = 0x39, // 9
        /// <summary>
        /// The A key.
        /// </summary>
        A = 0x41,
        /// <summary>
        /// The B key.
        /// </summary>
        B = 0x42,
        /// <summary>
        /// The C key.
        /// </summary>
        C = 0x43,
        /// <summary>
        /// The D key.
        /// </summary>
        D = 0x44,
        /// <summary>
        /// The E key.
        /// </summary>
        E = 0x45,
        /// <summary>
        /// The F key.
        /// </summary>
        F = 0x46,
        /// <summary>
        /// The G key.
        /// </summary>
        G = 0x47,
        /// <summary>
        /// The H key.
        /// </summary>
        H = 0x48,
        /// <summary>
        /// The I key.
        /// </summary>
        I = 0x49,
        /// <summary>
        /// The J key.
        /// </summary>
        J = 0x4a,
        /// <summary>
        /// The K key.
        /// </summary>
        K = 0x4b,
        /// <summary>
        /// The L key.
        /// </summary>
        L = 0x4c,
        /// <summary>
        /// The M key.
        /// </summary>
        M = 0x4d,
        /// <summary>
        /// The N key.
        /// </summary>
        N = 0x4e,
        /// <summary>
        /// The O key.
        /// </summary>
        O = 0x4f,
        /// <summary>
        /// The P key.
        /// </summary>
        P = 0x50,
        /// <summary>
        /// The Q key.
        /// </summary>
        Q = 0x51,
        /// <summary>
        /// The R key.
        /// </summary>
        R = 0x52,
        /// <summary>
        /// The S key.
        /// </summary>
        S = 0x53,
        /// <summary>
        /// The T key.
        /// </summary>
        T = 0x54,
        /// <summary>
        /// The U key.
        /// </summary>
        U = 0x55,
        /// <summary>
        /// The V key.
        /// </summary>
        V = 0x56,
        /// <summary>
        /// The W key.
        /// </summary>
        W = 0x57,
        /// <summary>
        /// The X key.
        /// </summary>
        X = 0x58,
        /// <summary>
        /// The Y key.
        /// </summary>
        Y = 0x59,
        /// <summary>
        /// The Z key.
        /// </summary>
        Z = 0x5a,
        /// <summary>
        /// The left Windows logo key (Microsoft Natural Keyboard).
        /// </summary>
        LWin = 0x5b,
        /// <summary>
        /// The right Windows logo key (Microsoft Natural Keyboard).
        /// </summary>
        RWin = 0x5c,
        /// <summary>
        /// The Application key (Microsoft Natural Keyboard).
        /// </summary>
        Apps = 0x5d,
        /// <summary>
        /// The Computer Sleep key.
        /// </summary>
        Sleep = 0x5f,
        /// <summary>
        /// The 0 key on the numeric keypad.
        /// </summary>
        NumPad0 = 0x60,
        /// <summary>
        /// The 1 key on the numeric keypad.
        /// </summary>
        NumPad1 = 0x61,
        /// <summary>
        /// The 2 key on the numeric keypad.
        /// </summary>
        NumPad2 = 0x62,
        /// <summary>
        /// The 3 key on the numeric keypad.
        /// </summary>
        NumPad3 = 0x63,
        /// <summary>
        /// The 4 key on the numeric keypad.
        /// </summary>
        NumPad4 = 0x64,
        /// <summary>
        /// The 5 key on the numeric keypad.
        /// </summary>
        NumPad5 = 0x65,
        /// <summary>
        /// The 6 key on the numeric keypad.
        /// </summary>
        NumPad6 = 0x66,
        /// <summary>
        /// The 7 key on the numeric keypad.
        /// </summary>
        NumPad7 = 0x67,
        /// <summary>
        /// The 8 key on the numeric keypad.
        /// </summary>
        NumPad8 = 0x68,
        /// <summary>
        /// The 9 key on the numeric keypad.
        /// </summary>
        NumPad9 = 0x69,
        /// <summary>
        /// The Multiply key.
        /// </summary>
        Multiply = 0x6a,
        /// <summary>
        /// The Add key.
        /// </summary>
        Add = 0x6b,
        /// <summary>
        /// The Separator key.
        /// </summary>
        Separator = 0x6c,
        /// <summary>
        /// The Subtract key.
        /// </summary>
        Subtract = 0x6d,
        /// <summary>
        /// The Decimal key.
        /// </summary>
        Decimal = 0x6e,
        /// <summary>
        /// The Divide key.
        /// </summary>
        Divide = 0x6f,
        /// <summary>
        /// The F1 key.
        /// </summary>
        F1 = 0x70,
        /// <summary>
        /// The F2 key.
        /// </summary>
        F2 = 0x71,
        /// <summary>
        /// The F3 key.
        /// </summary>
        F3 = 0x72,
        /// <summary>
        /// The F4 key.
        /// </summary>
        F4 = 0x73,
        /// <summary>
        /// The F5 key.
        /// </summary>
        F5 = 0x74,
        /// <summary>
        /// The F6 key.
        /// </summary>
        F6 = 0x75,
        /// <summary>
        /// The F7 key.
        /// </summary>
        F7 = 0x76,
        /// <summary>
        /// The F8 key.
        /// </summary>
        F8 = 0x77,
        /// <summary>
        /// The F9 key.
        /// </summary>
        F9 = 0x78,
        /// <summary>
        /// The F10 key.
        /// </summary>
        F10 = 0x79,
        /// <summary>
        /// The F11 key.
        /// </summary>
        F11 = 0x7a,
        /// <summary>
        /// The F12 key.
        /// </summary>
        F12 = 0x7b,
        /// <summary>
        /// The F13 key.
        /// </summary>
        F13 = 0x7c,
        /// <summary>
        /// The F14 key.
        /// </summary>
        F14 = 0x7d,
        /// <summary>
        /// The F15 key.
        /// </summary>
        F15 = 0x7e,
        /// <summary>
        /// The F16 key.
        /// </summary>
        F16 = 0x7f,
        /// <summary>
        /// The F17 key.
        /// </summary>
        F17 = 0x80,
        /// <summary>
        /// The F18 key.
        /// </summary>
        F18 = 0x81,
        /// <summary>
        /// The F19 key.
        /// </summary>
        F19 = 0x82,
        /// <summary>
        /// The F20 key.
        /// </summary>
        F20 = 0x83,
        /// <summary>
        /// The F21 key.
        /// </summary>
        F21 = 0x84,
        /// <summary>
        /// The F22 key.
        /// </summary>
        F22 = 0x85,
        /// <summary>
        /// The F23 key.
        /// </summary>
        F23 = 0x86,
        /// <summary>
        /// The F24 key.
        /// </summary>
        F24 = 0x87,
        /// <summary>
        /// The NUM LOCK key.
        /// </summary>
        NumLock = 0x90,
        /// <summary>
        /// The SCROLL LOCK key.
        /// </summary>
        Scroll = 0x91,
        /// <summary>
        /// The left SHIFT key.
        /// </summary>
        LShiftKey = 0xa0,
        /// <summary>
        /// The right SHIFT key.
        /// </summary>
        RShiftKey = 0xa1,
        /// <summary>
        /// The left CTRL key.
        /// </summary>
        LControlKey = 0xa2,
        /// <summary>
        /// The right CTRL key.
        /// </summary>
        RControlKey = 0xa3,
        /// <summary>
        /// The left ALT key.
        /// </summary>
        LMenu = 0xa4,
        /// <summary>
        /// The right ALT key.
        /// </summary>
        RMenu = 0xa5,
        /// <summary>
        /// The Browser Back key.
        /// </summary>
        BrowserBack = 0xa6,
        /// <summary>
        /// The Browser Forward key.
        /// </summary>
        BrowserForward = 0xa7,
        /// <summary>
        /// The Browser Refresh key.
        /// </summary>
        BrowserRefresh = 0xa8,
        /// <summary>
        /// The Browser Stop key.
        /// </summary>
        BrowserStop = 0xa9,
        /// <summary>
        /// The Browser Search key.
        /// </summary>
        BrowserSearch = 0xaa,
        /// <summary>
        /// The Browser Favorites key.
        /// </summary>
        BrowserFavorites = 0xab,
        /// <summary>
        /// The Browser Home key.
        /// </summary>
        BrowserHome = 0xac,
        /// <summary>
        /// The Volume Mute key.
        /// </summary>
        VolumeMute = 0xad,
        /// <summary>
        /// The Volume Down key.
        /// </summary>
        VolumeDown = 0xae,
        /// <summary>
        /// The Volume Up key.
        /// </summary>
        VolumeUp = 0xaf,
        /// <summary>
        /// The Media Next Track key.
        /// </summary>
        MediaNextTrack = 0xb0,
        /// <summary>
        /// The Media Previous Track key.
        /// </summary>
        MediaPreviousTrack = 0xb1,
        /// <summary>
        /// The Media Stop key.
        /// </summary>
        MediaStop = 0xb2,
        /// <summary>
        /// The Media Play Pause key.
        /// </summary>
        MediaPlayPause = 0xb3,
        /// <summary>
        /// The Launch Mail key.
        /// </summary>
        LaunchMail = 0xb4,
        /// <summary>
        /// The Select Media key.
        /// </summary>
        SelectMedia = 0xb5,
        /// <summary>
        /// The Launch Application1 key.
        /// </summary>
        LaunchApplication1 = 0xb6,
        /// <summary>
        /// The Launch Application2 key.
        /// </summary>
        LaunchApplication2 = 0xb7,
        /// <summary>
        /// The Oem Semicolon key.
        /// </summary>
        OemSemicolon = 0xba,
        /// <summary>
        /// The Oem 1 key.
        /// </summary>
        Oem1 = OemSemicolon,
        /// <summary>
        /// The Oem plus key.
        /// </summary>
        Oemplus = 0xbb,
        /// <summary>
        /// The Oem comma key.
        /// </summary>
        Oemcomma = 0xbc,
        /// <summary>
        /// The Oem Minus key.
        /// </summary>
        OemMinus = 0xbd,
        /// <summary>
        /// The Oem Period key.
        /// </summary>
        OemPeriod = 0xbe,
        /// <summary>
        /// The Oem Question key.
        /// </summary>
        OemQuestion = 0xbf,
        /// <summary>
        /// The Oem 2 key.
        /// </summary>
        Oem2 = OemQuestion,
        /// <summary>
        /// The Oem 3 key.
        /// </summary>
        Oem3 = 0xc0,
        /// <summary>
        /// The Oem tilde key.
        /// </summary>
        Oemtilde = Oem3,
        /// <summary>
        /// The Oem Open Brackets key.
        /// </summary>
        OemOpenBrackets = 0xdb,
        /// <summary>
        /// The Oem 4 key.
        /// </summary>
        Oem4 = OemOpenBrackets,
        /// <summary>
        /// The Oem Pipe key.
        /// </summary>
        OemPipe = 0xdc,
        /// <summary>
        /// The Oem 5 key.
        /// </summary>
        Oem5 = OemPipe,
        /// <summary>
        /// The Oem Close Brackets key.
        /// </summary>
        OemCloseBrackets = 0xdd,
        /// <summary>
        /// The Oem 6 key.
        /// </summary>
        Oem6 = OemCloseBrackets,
        /// <summary>
        /// The Oem 7 key.
        /// </summary>
        Oem7 = 0xde,
        /// <summary>
        /// The Oem Quotes key.
        /// </summary>
        OemQuotes = Oem7,
        /// <summary>
        /// The Oem8 key.
        /// </summary>
        Oem8 = 0xdf,
        /// <summary>
        /// The Oem 102 key.
        /// </summary>
        Oem102 = 0xe2,
        /// <summary>
        /// The Oem Backslash key.
        /// </summary>
        OemBackslash = Oem102,
        /// <summary>
        /// The PROCESS KEY key.
        /// </summary>
        ProcessKey = 0xe5,
        /// <summary>
        /// The Packet KEY key.
        /// </summary>
        Packet = 0xe7,
        /// <summary>
        /// The ATTN key.
        /// </summary>
        Attn = 0xf6,
        /// <summary>
        /// The CRSEL key.
        /// </summary>
        Crsel = 0xf7,
        /// <summary>
        /// The EXSEL key.
        /// </summary>
        Exsel = 0xf8,
        /// <summary>
        /// The ERASE EOF key.
        /// </summary>
        EraseEof = 0xf9,
        /// <summary>
        /// The PLAY key.
        /// </summary>
        Play = 0xfa,
        /// <summary>
        /// The ZOOM key.
        /// </summary>
        Zoom = 0xfb,
        /// <summary>
        /// A constant reserved for future use.
        /// </summary>
        NoName = 0xfc,
        /// <summary>
        /// The PA1 key.
        /// </summary>
        Pa1 = 0xfd,
        /// <summary>
        /// The CLEAR key.
        /// </summary>
        OemClear = 0xfe,
        /// <summary>
        /// The SHIFT modifier key.
        /// </summary>
        Shift = 0x00010000,
        /// <summary>
        /// The  CTRL modifier key.
        /// </summary>
        Control = 0x00020000,
        /// <summary>
        /// The ALT modifier key.
        /// </summary>
        Alt = 0x00040000,
    }
}
