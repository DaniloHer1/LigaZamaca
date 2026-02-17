; ============================================
; INSTALADOR LIGA ZAMACA
; Script de Inno Setup (CORREGIDO)
; Desarrollado por: Daniel
; Fecha: Febrero 2026
; ============================================

#define MyAppName "Liga Zamaca"
#define MyAppVersion "1.0"
#define MyAppPublisher "Daniel"
#define MyAppURL "https://github.com/tu-usuario/LigaZamaca"
#define MyAppExeName "LigaZamaca.exe"

[Setup]
AppId={{A1B2C3D4-E5F6-7890-ABCD-EF1234567890}
AppName={#MyAppName}
AppVersion={#MyAppVersion}
AppVerName={#MyAppName} {#MyAppVersion}
AppPublisher={#MyAppPublisher}
AppPublisherURL={#MyAppURL}
AppSupportURL={#MyAppURL}
AppUpdatesURL={#MyAppURL}

DefaultDirName={autopf}\{#MyAppName}
DefaultGroupName={#MyAppName}

OutputDir=Instalador
OutputBaseFilename=LigaZamaca_Setup_v1.0

; Icono del instalador - AJUSTA LA RUTA A TU ICONO
SetupIconFile=icono_liga_zamaca.ico

Compression=lzma2
SolidCompression=yes
WizardStyle=modern

UninstallDisplayIcon={app}\{#MyAppExeName}
UninstallDisplayName={#MyAppName}
PrivilegesRequired=admin

[Languages]
Name: "spanish"; MessagesFile: "compiler:Languages\Spanish.isl"
Name: "english"; MessagesFile: "compiler:Default.isl"

[Messages]
spanish.BeveledLabel=Liga Zamaca - Sistema de Gestión de Liga de Fútbol

[Tasks]
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: checked

[Files]
; Ejecutable principal
Source: "bin\Release\LigaZamaca.exe"; DestDir: "{app}"; Flags: ignoreversion

; Archivo de configuración
Source: "bin\Release\LigaZamaca.exe.config"; DestDir: "{app}"; Flags: ignoreversion

; Todas las DLLs
Source: "bin\Release\*.dll"; DestDir: "{app}"; Flags: ignoreversion skipifsourcedoesntexist

; Archivos de informes Crystal Reports
Source: "bin\Release\*.rpt"; DestDir: "{app}"; Flags: ignoreversion skipifsourcedoesntexist
Source: "Informes\*.rpt"; DestDir: "{app}\Informes"; Flags: ignoreversion skipifsourcedoesntexist

; Manual de usuario
Source: "ManualUsuario_LigaZamaca.pdf"; DestDir: "{app}"; Flags: ignoreversion skipifsourcedoesntexist
Source: "bin\Release\ManualUsuario_LigaZamaca.pdf"; DestDir: "{app}"; Flags: ignoreversion skipifsourcedoesntexist

; Documentación técnica CHM
Source: "Documentation.chm"; DestDir: "{app}"; Flags: ignoreversion skipifsourcedoesntexist
Source: "bin\Release\Documentation.chm"; DestDir: "{app}"; Flags: ignoreversion skipifsourcedoesntexist

; Icono
Source: "icono_liga_zamaca.ico"; DestDir: "{app}"; Flags: ignoreversion skipifsourcedoesntexist
Source: "Recursos\liga_zamaca.ico"; DestDir: "{app}"; Flags: ignoreversion skipifsourcedoesntexist

; Scripts SQL
Source: "SQL\*.sql"; DestDir: "{app}\SQL"; Flags: ignoreversion skipifsourcedoesntexist

[Icons]
; Menú Inicio
Name: "{group}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"; IconFilename: "{app}\icono_liga_zamaca.ico"
Name: "{group}\Manual de Usuario"; Filename: "{app}\ManualUsuario_LigaZamaca.pdf"
Name: "{group}\Documentación Técnica"; Filename: "{app}\Documentation.chm"
Name: "{group}\{cm:UninstallProgram,{#MyAppName}}"; Filename: "{uninstallexe}"

; Escritorio
Name: "{autodesktop}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"; IconFilename: "{app}\icono_liga_zamaca.ico"; Tasks: desktopicon

[Run]
Filename: "{app}\{#MyAppExeName}"; Description: "{cm:LaunchProgram,{#StringChange(MyAppName, '&', '&&')}}"; Flags: nowait postinstall skipifsilent

[Code]
function InitializeSetup(): Boolean;
begin
  Result := True;
end;

procedure CurStepChanged(CurStep: TSetupStep);
begin
  if CurStep = ssPostInstall then
  begin
    MsgBox('¡Liga Zamaca se ha instalado correctamente!' + #13#10 + #13#10 +
           'IMPORTANTE: Antes de usar la aplicación:' + #13#10 +
           '1. Tener SQL Server instalado y en ejecución' + #13#10 +
           '2. Crear la base de datos con el script SQL incluido' + #13#10 + #13#10 +
           'Scripts SQL en: ' + ExpandConstant('{app}') + '\SQL',
           mbInformation, MB_OK);
  end;
end;
