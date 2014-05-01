Module ModulePE
    Public FileOpenMyProgram As String
    '-------------------------------
    Public AboutShow As Boolean
    Public LicenseShow As Boolean
    Public SettingsShow As Boolean
    Public FTPShow As Boolean
    Public FontModule As Font
    Public ActionModuleFormat As Boolean
    Public ActionTopMost As Boolean
    '-------------------------------
    Public DENWER_Path As String
    Public DENWER_host As String
    Public DENWER_MyPhpAdmin As String
    Public IExplorer As String
    Public Opera As String
    Public FireFox As String
    Public Chrome As String
    Public Safari As String
    '-------------------------------
    Public Color01 As Integer
    Public Color02 As Integer
    Public Color03 As Integer
    Public Color04 As Integer
    Public Color05 As Integer
    Public Color06 As Integer
    Public Color07 As Integer
    Public Color08 As Integer
    Public Color09 As Integer
    Public Color10 As Integer
    Public Color11 As Integer
    Public Color12 As Integer
    Public Color13 As Integer
    Public Color14 As Integer
    Public Color15 As Integer
    Public Color16 As Integer
    Public Color17 As Integer
    Public Color18 As Integer
    Public Color19 As Integer
    Public Color20 As Integer
    Public Color21 As Integer
    Public Color22 As Integer
    Public Color23 As Integer
    Public Color24 As Integer
    Public Color25 As Integer
    Public Color26 As Integer
    Public Color27 As Integer
    Public Color28 As Integer
    Public Color29 As Integer
    Public Color30 As Integer
    Public Color31 As Integer

    Public BaseFile(100) As String
    Public FileModule(100) As EditFile
    Public Sub LoadFM(ByVal id As Integer)
        FileModule(id) = New EditFile
    End Sub

    Public LoadFiles As Processed
    Public Sub LoadLFiles()
        LoadFiles = New Processed
    End Sub

    Public ProgrammPE As Programm
    Public Sub LoadProgrammPE()
        ProgrammPE = New Programm
    End Sub
End Module
