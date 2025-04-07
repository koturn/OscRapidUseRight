SOLUTION_NAME = VRCDesktopTool
SOLUTION_FILE = $(SOLUTION_NAME).sln
MAIN_PROJECT_FILE = $(SOLUTION_NAME)\$(SOLUTION_NAME).csproj
PROJECT_OUTPUTS = $(SOLUTION_NAME)\bin $(SOLUTION_NAME)\obj
ARTIFACTS_BASEDIR = Artifacts
ARTIFACTS_SUBDIR_BASENAME = $(SOLUTION_NAME)
ARTIFACTS_BASENAME = $(SOLUTION_NAME)
BUILD_CONFIG = Release
BUILD_PLATFORM = "Any CPU"
TARGET = nfw48
RM = del /F /Q


all: build

build:
	msbuild /nologo /m /t:restore /p:Configuration=$(BUILD_CONFIG);Platform=$(BUILD_PLATFORM) $(SOLUTION_FILE)
	msbuild /nologo /m /p:Configuration=$(BUILD_CONFIG);Platform=$(BUILD_PLATFORM) $(SOLUTION_FILE)

deploy: deploy-$(TARGET)

deploy-$(TARGET):
	mkdir $(ARTIFACTS_BASEDIR)\$(ARTIFACTS_SUBDIR_BASENAME)-$(TARGET)
	xcopy /d /y $(SOLUTION_NAME)\bin\$(BUILD_CONFIG) $(ARTIFACTS_BASEDIR)\$(ARTIFACTS_SUBDIR_BASENAME)-$(TARGET)
	$(RM) $(ARTIFACTS_BASEDIR)\$(ARTIFACTS_SUBDIR_BASENAME)-$(TARGET)\*.pdb $(ARTIFACTS_BASEDIR)\$(ARTIFACTS_SUBDIR_BASENAME)-$(TARGET)\*.xml
	$(RM) $(ARTIFACTS_BASENAME)-$(TARGET).zip 2>NUL
	set OLDCD=$(CD)
	cd $(ARTIFACTS_BASEDIR)
	powershell Compress-Archive -Path $(ARTIFACTS_SUBDIR_BASENAME)-$(TARGET) -DestinationPath ..\$(ARTIFACTS_BASENAME)-$(TARGET).zip
	cd $(OLDCD)

clean:
	$(RM) $(PROJECT_OUTPUTS)

distclean:
	$(RM) $(PROJECT_OUTPUTS) $(ARTIFACTS_BASEDIR) $(ARTIFACTS_BASENAME)-*.zip 2>NUL
