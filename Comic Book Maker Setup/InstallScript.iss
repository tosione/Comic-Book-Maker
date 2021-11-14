; Defines
#define MyAppName "Comic Book Maker"
#define MyAppVersion "1.2"
#define MyAppPublisher ""
#define MyAppURL "https://github.com/tosione/Comic-Book-Maker"
#define MyAppExeName "Comic Book Maker.exe"
#define MySolutionFolder "C:\Users\Gabriel\source\repos\Comic Book Maker"

[Setup]
; NOTE: The value of AppId uniquely identifies this application. Do not use the same AppId value in installers for other applications.
AppId=Comic Book Maker
AppName={#MyAppName}
AppVersion={#MyAppVersion}
AppVerName={#MyAppName} v{#MyAppVersion}
AppPublisherURL={#MyAppURL}
DefaultDirName={autopf64}\{#MyAppName}
DisableProgramGroupPage=yes
; Uncomment the following line to run in non administrative install mode (install for current user only.)
;PrivilegesRequired=lowest
SetupIconFile={#MySolutionFolder}\Images\cbm 16-32-48-256.ico
OutputBaseFilename={#MyAppName} Setup v{#MyAppVersion}
Compression=lzma2
SolidCompression=yes
WizardStyle=modern
UninstallDisplayIcon={app}\{#MyAppExeName}
ArchitecturesAllowed=x64
WizardImageFile={#MySolutionFolder}\Images\cbm inno setup.bmp

[Languages]
Name: "english"; MessagesFile: "compiler:Default.isl"

[Tasks]
Name: desktopicon; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked
Name: sendto; Description: "{cm:CreateSendToIcon}"; GroupDescription: "{cm:AdditionalIcons}"

[Files]
Source: "{#MySolutionFolder}\Comic Book Maker\bin\Release\{#MyAppExeName}"; DestDir: "{app}"; Flags: ignoreversion
Source: "{#MySolutionFolder}\Comic Book Maker\bin\Release\Comic Book Maker.exe.config"; DestDir: "{app}"; Flags: ignoreversion
Source: "{#MySolutionFolder}\7-zip\7z.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "{#MySolutionFolder}\7-zip\7z.exe"; DestDir: "{app}"; Flags: ignoreversion
Source: "{#MySolutionFolder}\README.md"; DestDir: "{app}"; Flags: ignoreversion

[Icons]
Name: "{autoprograms}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"
Name: "{autodesktop}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"; Tasks: desktopicon
Name: "{usersendto}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}";  Tasks: sendto

[Run]
Filename: "{app}\{#MyAppExeName}"; Description: "{cm:LaunchProgram,{#StringChange(MyAppName, '&', '&&')}}"; Flags: nowait postinstall skipifsilent unchecked

[CustomMessages]
CreateSendToIcon=Create a shortcut in the SendTo menu (Can be done from inside the program later)

[Messages]
BeveledLabel=Installer created with Inno Setup 6.2.0 (jrsoftware.org)