; ============================================
; INSTALADOR LIGA ZAMACA - VERSION SIMPLIFICADA
; ============================================

#define MyAppName "Liga Zamaca"
#define MyAppVersion "1.0"
#define MyAppPublisher "Daniel Hernanando"
#define MyAppExeName "LigaZamaca.exe"

[Setup]
AppId={{A1B2C3D4-E5F6-7890-ABCD-EF1234567890}
AppName={#MyAppName}
AppVersion={#MyAppVersion}
AppPublisher={#MyAppPublisher}
DefaultDirName={autopf}\{#MyAppName}
DefaultGroupName={#MyAppName}
OutputDir=Instalador
OutputBaseFilename=LigaZamaca_Setup_v1.0
SetupIconFile=Recursos/liga_zamaca.ico
Compression=lzma2
SolidCompression=yes
WizardStyle=modern
UninstallDisplayName={#MyAppName}
PrivilegesRequired=admin

[Languages]
Name: "spanish"; MessagesFile: "compiler:Languages\Spanish.isl"

[Tasks]
Name: "desktopicon"; Description: "Crear acceso directo en el Escritorio"; GroupDescription: "Iconos adicionales:"

[Files]
Source: "bin\Release\LigaZamaca.exe"; DestDir: "{app}"; Flags: ignoreversion
Source: "bin\Release\LigaZamaca.exe.config"; DestDir: "{app}"; Flags: ignoreversion
Source: "bin\Release\*.dll"; DestDir: "{app}"; Flags: ignoreversion skipifsourcedoesntexist
Source: "bin\Release\*.rpt"; DestDir: "{app}"; Flags: ignoreversion skipifsourcedoesntexist
Source: "Informes\*.rpt"; DestDir: "{app}\Informes"; Flags: ignoreversion skipifsourcedoesntexist
Source: "ManualUsuario_LigaZamaca.pdf"; DestDir: "{app}"; Flags: ignoreversion skipifsourcedoesntexist
Source: "Documentation.chm"; DestDir: "{app}"; Flags: ignoreversion skipifsourcedoesntexist
Source: "icono_liga_zamaca.ico"; DestDir: "{app}"; Flags: ignoreversion skipifsourcedoesntexist
Source: "SQL\*.sql"; DestDir: "{app}\SQL"; Flags: ignoreversion skipifsourcedoesntexist

[Icons]
Name: "{group}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"
Name: "{group}\Manual de Usuario"; Filename: "{app}\ManualUsuario_LigaZamaca.pdf"
Name: "{group}\Desinstalar {#MyAppName}"; Filename: "{uninstallexe}"
Name: "{autodesktop}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"; Tasks: desktopicon

[Run]
Filename: "{app}\{#MyAppExeName}"; Description: "Ejecutar Liga Zamaca"; Flags: nowait postinstall skipifsilent
