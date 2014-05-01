Public Class Start
    Inherits System.Windows.Forms.Form

#Region " Код, автоматически созданный конструктором форм Windows "

    Public Sub New()
        MyBase.New()

        'Этот вызов требуется конструктором форм Windows.
        InitializeComponent()

        'Добавьте код инициализации после вызова InitializeComponent()

    End Sub

    'Форма переопределяет метод Dispose для очистки списка компонентов.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Требуется конструктором форм Windows
    Private components As System.ComponentModel.IContainer

    'ПРИМЕЧАНИЕ: следующая процедура требуется для конструктора форм Windows.
    'Ее можно изменить в конструкторе форм Windows.  
    'Не изменяйте ее в редакторе исходного текста.
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents OleDbSelectCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbInsertCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbUpdateCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbDeleteCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbConnection1 As System.Data.OleDb.OleDbConnection
    Friend WithEvents OleDbDataAdapter1 As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents DataSet11 As PageEditor.DataSet1
    Friend WithEvents OleDbSelectCommand2 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbInsertCommand2 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbUpdateCommand2 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbDeleteCommand2 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbDataAdapter2 As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents DataSet21 As PageEditor.DataSet2
    Friend WithEvents OleDbSelectCommand3 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbInsertCommand3 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbUpdateCommand3 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbDeleteCommand3 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbDataAdapter3 As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents DataSet31 As PageEditor.DataSet3
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Start))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.OleDbSelectCommand1 = New System.Data.OleDb.OleDbCommand
        Me.OleDbConnection1 = New System.Data.OleDb.OleDbConnection
        Me.OleDbInsertCommand1 = New System.Data.OleDb.OleDbCommand
        Me.OleDbUpdateCommand1 = New System.Data.OleDb.OleDbCommand
        Me.OleDbDeleteCommand1 = New System.Data.OleDb.OleDbCommand
        Me.OleDbDataAdapter1 = New System.Data.OleDb.OleDbDataAdapter
        Me.DataSet11 = New PageEditor.DataSet1
        Me.OleDbSelectCommand2 = New System.Data.OleDb.OleDbCommand
        Me.OleDbInsertCommand2 = New System.Data.OleDb.OleDbCommand
        Me.OleDbUpdateCommand2 = New System.Data.OleDb.OleDbCommand
        Me.OleDbDeleteCommand2 = New System.Data.OleDb.OleDbCommand
        Me.OleDbDataAdapter2 = New System.Data.OleDb.OleDbDataAdapter
        Me.DataSet21 = New PageEditor.DataSet2
        Me.OleDbSelectCommand3 = New System.Data.OleDb.OleDbCommand
        Me.OleDbInsertCommand3 = New System.Data.OleDb.OleDbCommand
        Me.OleDbUpdateCommand3 = New System.Data.OleDb.OleDbCommand
        Me.OleDbDeleteCommand3 = New System.Data.OleDb.OleDbCommand
        Me.OleDbDataAdapter3 = New System.Data.OleDb.OleDbDataAdapter
        Me.DataSet31 = New PageEditor.DataSet3
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        CType(Me.DataSet11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet31, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(352, 246)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'OleDbSelectCommand1
        '
        Me.OleDbSelectCommand1.CommandText = "SELECT ИмяШрифта, РазмерШрифта, Строка, ФорматированиеМодуля FROM Настройки"
        Me.OleDbSelectCommand1.Connection = Me.OleDbConnection1
        '
        'OleDbConnection1
        '
        Me.OleDbConnection1.ConnectionString = "Jet OLEDB:Global Partial Bulk Ops=2;Jet OLEDB:Registry Path=;Jet OLEDB:Database L" & _
        "ocking Mode=1;Data Source=""C:\Программирование\VB NET\CATFISH\Исходники\PageEdit" & _
        "or\База данных\resource.mdb"";Jet OLEDB:Engine Type=5;Provider=""Microsoft.Jet.OLE" & _
        "DB.4.0"";Jet OLEDB:System database=;Jet OLEDB:SFP=False;persist security info=Fal" & _
        "se;Extended Properties=;Mode=ReadWrite;Jet OLEDB:Encrypt Database=False;Jet OLED" & _
        "B:Create System Database=False;Jet OLEDB:Don't Copy Locale on Compact=False;Jet " & _
        "OLEDB:Compact Without Replica Repair=False;User ID=Admin;Jet OLEDB:Global Bulk T" & _
        "ransactions=1"
        '
        'OleDbInsertCommand1
        '
        Me.OleDbInsertCommand1.CommandText = "INSERT INTO Настройки(ИмяШрифта, РазмерШрифта, ФорматированиеМодуля) VALUES (?, ?" & _
        ", ?)"
        Me.OleDbInsertCommand1.Connection = Me.OleDbConnection1
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("ИмяШрифта", System.Data.OleDb.OleDbType.VarWChar, 255, "ИмяШрифта"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("РазмерШрифта", System.Data.OleDb.OleDbType.VarWChar, 255, "РазмерШрифта"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("ФорматированиеМодуля", System.Data.OleDb.OleDbType.Integer, 0, "ФорматированиеМодуля"))
        '
        'OleDbUpdateCommand1
        '
        Me.OleDbUpdateCommand1.CommandText = "UPDATE Настройки SET ИмяШрифта = ?, РазмерШрифта = ?, ФорматированиеМодуля = ? WH" & _
        "ERE (Строка = ?) AND (ИмяШрифта = ? OR ? IS NULL AND ИмяШрифта IS NULL) AND (Раз" & _
        "мерШрифта = ? OR ? IS NULL AND РазмерШрифта IS NULL) AND (ФорматированиеМодуля =" & _
        " ? OR ? IS NULL AND ФорматированиеМодуля IS NULL)"
        Me.OleDbUpdateCommand1.Connection = Me.OleDbConnection1
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("ИмяШрифта", System.Data.OleDb.OleDbType.VarWChar, 255, "ИмяШрифта"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("РазмерШрифта", System.Data.OleDb.OleDbType.VarWChar, 255, "РазмерШрифта"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("ФорматированиеМодуля", System.Data.OleDb.OleDbType.Integer, 0, "ФорматированиеМодуля"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Строка", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Строка", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ИмяШрифта", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ИмяШрифта", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ИмяШрифта1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ИмяШрифта", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_РазмерШрифта", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "РазмерШрифта", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_РазмерШрифта1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "РазмерШрифта", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ФорматированиеМодуля", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ФорматированиеМодуля", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ФорматированиеМодуля1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ФорматированиеМодуля", System.Data.DataRowVersion.Original, Nothing))
        '
        'OleDbDeleteCommand1
        '
        Me.OleDbDeleteCommand1.CommandText = "DELETE FROM Настройки WHERE (Строка = ?) AND (ИмяШрифта = ? OR ? IS NULL AND ИмяШ" & _
        "рифта IS NULL) AND (РазмерШрифта = ? OR ? IS NULL AND РазмерШрифта IS NULL) AND " & _
        "(ФорматированиеМодуля = ? OR ? IS NULL AND ФорматированиеМодуля IS NULL)"
        Me.OleDbDeleteCommand1.Connection = Me.OleDbConnection1
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Строка", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Строка", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ИмяШрифта", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ИмяШрифта", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ИмяШрифта1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ИмяШрифта", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_РазмерШрифта", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "РазмерШрифта", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_РазмерШрифта1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "РазмерШрифта", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ФорматированиеМодуля", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ФорматированиеМодуля", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ФорматированиеМодуля1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ФорматированиеМодуля", System.Data.DataRowVersion.Original, Nothing))
        '
        'OleDbDataAdapter1
        '
        Me.OleDbDataAdapter1.DeleteCommand = Me.OleDbDeleteCommand1
        Me.OleDbDataAdapter1.InsertCommand = Me.OleDbInsertCommand1
        Me.OleDbDataAdapter1.SelectCommand = Me.OleDbSelectCommand1
        Me.OleDbDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Настройки", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("ИмяШрифта", "ИмяШрифта"), New System.Data.Common.DataColumnMapping("РазмерШрифта", "РазмерШрифта"), New System.Data.Common.DataColumnMapping("Строка", "Строка"), New System.Data.Common.DataColumnMapping("ФорматированиеМодуля", "ФорматированиеМодуля")})})
        Me.OleDbDataAdapter1.UpdateCommand = Me.OleDbUpdateCommand1
        '
        'DataSet11
        '
        Me.DataSet11.DataSetName = "DataSet1"
        Me.DataSet11.Locale = New System.Globalization.CultureInfo("ru-RU")
        '
        'OleDbSelectCommand2
        '
        Me.OleDbSelectCommand2.CommandText = "SELECT [id_строка], СпецСимвол, Цвет FROM СпецСимволы"
        Me.OleDbSelectCommand2.Connection = Me.OleDbConnection1
        '
        'OleDbInsertCommand2
        '
        Me.OleDbInsertCommand2.CommandText = "INSERT INTO СпецСимволы(СпецСимвол, Цвет) VALUES (?, ?)"
        Me.OleDbInsertCommand2.Connection = Me.OleDbConnection1
        Me.OleDbInsertCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("СпецСимвол", System.Data.OleDb.OleDbType.VarWChar, 255, "СпецСимвол"))
        Me.OleDbInsertCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Цвет", System.Data.OleDb.OleDbType.Integer, 0, "Цвет"))
        '
        'OleDbUpdateCommand2
        '
        Me.OleDbUpdateCommand2.CommandText = "UPDATE СпецСимволы SET СпецСимвол = ?, Цвет = ? WHERE ([id_строка] = ?) AND (Спец" & _
        "Символ = ? OR ? IS NULL AND СпецСимвол IS NULL) AND (Цвет = ? OR ? IS NULL AND Ц" & _
        "вет IS NULL)"
        Me.OleDbUpdateCommand2.Connection = Me.OleDbConnection1
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("СпецСимвол", System.Data.OleDb.OleDbType.VarWChar, 255, "СпецСимвол"))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Цвет", System.Data.OleDb.OleDbType.Integer, 0, "Цвет"))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_id_строка", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id_строка", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_СпецСимвол", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "СпецСимвол", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_СпецСимвол1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "СпецСимвол", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Цвет", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Цвет", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Цвет1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Цвет", System.Data.DataRowVersion.Original, Nothing))
        '
        'OleDbDeleteCommand2
        '
        Me.OleDbDeleteCommand2.CommandText = "DELETE FROM СпецСимволы WHERE ([id_строка] = ?) AND (СпецСимвол = ? OR ? IS NULL " & _
        "AND СпецСимвол IS NULL) AND (Цвет = ? OR ? IS NULL AND Цвет IS NULL)"
        Me.OleDbDeleteCommand2.Connection = Me.OleDbConnection1
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_id_строка", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id_строка", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_СпецСимвол", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "СпецСимвол", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_СпецСимвол1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "СпецСимвол", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Цвет", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Цвет", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Цвет1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Цвет", System.Data.DataRowVersion.Original, Nothing))
        '
        'OleDbDataAdapter2
        '
        Me.OleDbDataAdapter2.DeleteCommand = Me.OleDbDeleteCommand2
        Me.OleDbDataAdapter2.InsertCommand = Me.OleDbInsertCommand2
        Me.OleDbDataAdapter2.SelectCommand = Me.OleDbSelectCommand2
        Me.OleDbDataAdapter2.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "СпецСимволы", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id_строка", "id_строка"), New System.Data.Common.DataColumnMapping("СпецСимвол", "СпецСимвол"), New System.Data.Common.DataColumnMapping("Цвет", "Цвет")})})
        Me.OleDbDataAdapter2.UpdateCommand = Me.OleDbUpdateCommand2
        '
        'DataSet21
        '
        Me.DataSet21.DataSetName = "DataSet2"
        Me.DataSet21.Locale = New System.Globalization.CultureInfo("ru-RU")
        '
        'OleDbSelectCommand3
        '
        Me.OleDbSelectCommand3.CommandText = "SELECT Chrome, FireFox, [id_строка], IExplorer, Opera, phpMyAdminDenwer, Safari, " & _
        "ПутьDenwer, ХостDenwer FROM DENWER"
        Me.OleDbSelectCommand3.Connection = Me.OleDbConnection1
        '
        'OleDbInsertCommand3
        '
        Me.OleDbInsertCommand3.CommandText = "INSERT INTO DENWER(Chrome, FireFox, IExplorer, Opera, phpMyAdminDenwer, Safari, П" & _
        "утьDenwer, ХостDenwer) VALUES (?, ?, ?, ?, ?, ?, ?, ?)"
        Me.OleDbInsertCommand3.Connection = Me.OleDbConnection1
        Me.OleDbInsertCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Chrome", System.Data.OleDb.OleDbType.VarWChar, 255, "Chrome"))
        Me.OleDbInsertCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("FireFox", System.Data.OleDb.OleDbType.VarWChar, 255, "FireFox"))
        Me.OleDbInsertCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("IExplorer", System.Data.OleDb.OleDbType.VarWChar, 255, "IExplorer"))
        Me.OleDbInsertCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Opera", System.Data.OleDb.OleDbType.VarWChar, 255, "Opera"))
        Me.OleDbInsertCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("phpMyAdminDenwer", System.Data.OleDb.OleDbType.VarWChar, 255, "phpMyAdminDenwer"))
        Me.OleDbInsertCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Safari", System.Data.OleDb.OleDbType.VarWChar, 255, "Safari"))
        Me.OleDbInsertCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("ПутьDenwer", System.Data.OleDb.OleDbType.VarWChar, 255, "ПутьDenwer"))
        Me.OleDbInsertCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("ХостDenwer", System.Data.OleDb.OleDbType.VarWChar, 255, "ХостDenwer"))
        '
        'OleDbUpdateCommand3
        '
        Me.OleDbUpdateCommand3.CommandText = "UPDATE DENWER SET Chrome = ?, FireFox = ?, IExplorer = ?, Opera = ?, phpMyAdminDe" & _
        "nwer = ?, Safari = ?, ПутьDenwer = ?, ХостDenwer = ? WHERE ([id_строка] = ?) AND" & _
        " (Chrome = ? OR ? IS NULL AND Chrome IS NULL) AND (FireFox = ? OR ? IS NULL AND " & _
        "FireFox IS NULL) AND (IExplorer = ? OR ? IS NULL AND IExplorer IS NULL) AND (Ope" & _
        "ra = ? OR ? IS NULL AND Opera IS NULL) AND (Safari = ? OR ? IS NULL AND Safari I" & _
        "S NULL) AND (phpMyAdminDenwer = ? OR ? IS NULL AND phpMyAdminDenwer IS NULL) AND" & _
        " (ПутьDenwer = ? OR ? IS NULL AND ПутьDenwer IS NULL) AND (ХостDenwer = ? OR ? I" & _
        "S NULL AND ХостDenwer IS NULL)"
        Me.OleDbUpdateCommand3.Connection = Me.OleDbConnection1
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Chrome", System.Data.OleDb.OleDbType.VarWChar, 255, "Chrome"))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("FireFox", System.Data.OleDb.OleDbType.VarWChar, 255, "FireFox"))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("IExplorer", System.Data.OleDb.OleDbType.VarWChar, 255, "IExplorer"))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Opera", System.Data.OleDb.OleDbType.VarWChar, 255, "Opera"))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("phpMyAdminDenwer", System.Data.OleDb.OleDbType.VarWChar, 255, "phpMyAdminDenwer"))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Safari", System.Data.OleDb.OleDbType.VarWChar, 255, "Safari"))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("ПутьDenwer", System.Data.OleDb.OleDbType.VarWChar, 255, "ПутьDenwer"))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("ХостDenwer", System.Data.OleDb.OleDbType.VarWChar, 255, "ХостDenwer"))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_id_строка", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id_строка", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Chrome", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Chrome", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Chrome1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Chrome", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_FireFox", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FireFox", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_FireFox1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FireFox", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_IExplorer", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IExplorer", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_IExplorer1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IExplorer", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Opera", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Opera", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Opera1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Opera", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Safari", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Safari", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Safari1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Safari", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_phpMyAdminDenwer", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phpMyAdminDenwer", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_phpMyAdminDenwer1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phpMyAdminDenwer", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ПутьDenwer", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ПутьDenwer", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ПутьDenwer1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ПутьDenwer", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ХостDenwer", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ХостDenwer", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ХостDenwer1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ХостDenwer", System.Data.DataRowVersion.Original, Nothing))
        '
        'OleDbDeleteCommand3
        '
        Me.OleDbDeleteCommand3.CommandText = "DELETE FROM DENWER WHERE ([id_строка] = ?) AND (Chrome = ? OR ? IS NULL AND Chrom" & _
        "e IS NULL) AND (FireFox = ? OR ? IS NULL AND FireFox IS NULL) AND (IExplorer = ?" & _
        " OR ? IS NULL AND IExplorer IS NULL) AND (Opera = ? OR ? IS NULL AND Opera IS NU" & _
        "LL) AND (Safari = ? OR ? IS NULL AND Safari IS NULL) AND (phpMyAdminDenwer = ? O" & _
        "R ? IS NULL AND phpMyAdminDenwer IS NULL) AND (ПутьDenwer = ? OR ? IS NULL AND П" & _
        "утьDenwer IS NULL) AND (ХостDenwer = ? OR ? IS NULL AND ХостDenwer IS NULL)"
        Me.OleDbDeleteCommand3.Connection = Me.OleDbConnection1
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_id_строка", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id_строка", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Chrome", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Chrome", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Chrome1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Chrome", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_FireFox", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FireFox", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_FireFox1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FireFox", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_IExplorer", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IExplorer", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_IExplorer1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IExplorer", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Opera", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Opera", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Opera1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Opera", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Safari", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Safari", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Safari1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Safari", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_phpMyAdminDenwer", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phpMyAdminDenwer", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_phpMyAdminDenwer1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phpMyAdminDenwer", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ПутьDenwer", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ПутьDenwer", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ПутьDenwer1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ПутьDenwer", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ХостDenwer", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ХостDenwer", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ХостDenwer1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ХостDenwer", System.Data.DataRowVersion.Original, Nothing))
        '
        'OleDbDataAdapter3
        '
        Me.OleDbDataAdapter3.DeleteCommand = Me.OleDbDeleteCommand3
        Me.OleDbDataAdapter3.InsertCommand = Me.OleDbInsertCommand3
        Me.OleDbDataAdapter3.SelectCommand = Me.OleDbSelectCommand3
        Me.OleDbDataAdapter3.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "DENWER", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Chrome", "Chrome"), New System.Data.Common.DataColumnMapping("FireFox", "FireFox"), New System.Data.Common.DataColumnMapping("id_строка", "id_строка"), New System.Data.Common.DataColumnMapping("IExplorer", "IExplorer"), New System.Data.Common.DataColumnMapping("Opera", "Opera"), New System.Data.Common.DataColumnMapping("phpMyAdminDenwer", "phpMyAdminDenwer"), New System.Data.Common.DataColumnMapping("Safari", "Safari"), New System.Data.Common.DataColumnMapping("ПутьDenwer", "ПутьDenwer"), New System.Data.Common.DataColumnMapping("ХостDenwer", "ХостDenwer")})})
        Me.OleDbDataAdapter3.UpdateCommand = Me.OleDbUpdateCommand3
        '
        'DataSet31
        '
        Me.DataSet31.DataSetName = "DataSet3"
        Me.DataSet31.Locale = New System.Globalization.CultureInfo("ru-RU")
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.Color.Orange
        Me.Label3.Location = New System.Drawing.Point(8, 224)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(336, 16)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Portions Copyright © Microsoft Corporation. All Rights Reserved."
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.Color.Orange
        Me.Label2.Location = New System.Drawing.Point(8, 208)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(312, 16)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "© Somov Evgen, 2013"
        '
        'Start
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(352, 246)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Start"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Page Editor"
        CType(Me.DataSet11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet21, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet31, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Start_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ModuleBase.MyProgramDirectory = Environment.CurrentDirectory + "\"

        Me.Update()
        ModuleBase.PathBase = ModuleBase.MyProgramDirectory + "resource\resource.mdb"
        ModuleBase.StringConnection = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & ModuleBase.PathBase & ";Jet OLEDB:Database Password="

        OleDbConnection1.ConnectionString = ModuleBase.StringConnection
        OleDbConnection1.Open()
        '----------------------------------------------
        OleDbDataAdapter1.Fill(DataSet11, "Настройки")
        Dim NameF As String = DataSet11.Настройки.Item(0)("ИмяШрифта")
        Dim SizeF As Integer = DataSet11.Настройки.Item(0)("РазмерШрифта")
        Dim FormatM As Integer = DataSet11.Настройки.Item(0)("ФорматированиеМодуля")
        ModulePE.FontModule = New Font(NameF, SizeF, FontStyle.Regular)
        If (DataSet11.Настройки.Item(0)("ФорматированиеМодуля") = 1) Then
            ModulePE.ActionModuleFormat = True
        Else
            ModulePE.ActionModuleFormat = False
        End If
        '----------------------------------------------
        OleDbDataAdapter2.Fill(DataSet21, "СпецСимволы")
        ModulePE.Color01 = DataSet21.СпецСимволы.Item(0)("Цвет")
        ModulePE.Color02 = DataSet21.СпецСимволы.Item(1)("Цвет")
        ModulePE.Color03 = DataSet21.СпецСимволы.Item(2)("Цвет")
        ModulePE.Color04 = DataSet21.СпецСимволы.Item(3)("Цвет")
        ModulePE.Color05 = DataSet21.СпецСимволы.Item(4)("Цвет")
        ModulePE.Color06 = DataSet21.СпецСимволы.Item(5)("Цвет")
        ModulePE.Color07 = DataSet21.СпецСимволы.Item(6)("Цвет")
        ModulePE.Color08 = DataSet21.СпецСимволы.Item(7)("Цвет")
        ModulePE.Color09 = DataSet21.СпецСимволы.Item(8)("Цвет")
        ModulePE.Color10 = DataSet21.СпецСимволы.Item(9)("Цвет")
        ModulePE.Color11 = DataSet21.СпецСимволы.Item(10)("Цвет")
        ModulePE.Color12 = DataSet21.СпецСимволы.Item(11)("Цвет")
        ModulePE.Color13 = DataSet21.СпецСимволы.Item(12)("Цвет")
        ModulePE.Color14 = DataSet21.СпецСимволы.Item(13)("Цвет")
        ModulePE.Color15 = DataSet21.СпецСимволы.Item(14)("Цвет")
        ModulePE.Color16 = DataSet21.СпецСимволы.Item(15)("Цвет")
        ModulePE.Color17 = DataSet21.СпецСимволы.Item(16)("Цвет")
        ModulePE.Color18 = DataSet21.СпецСимволы.Item(17)("Цвет")
        ModulePE.Color19 = DataSet21.СпецСимволы.Item(18)("Цвет")
        ModulePE.Color20 = DataSet21.СпецСимволы.Item(19)("Цвет")
        ModulePE.Color21 = DataSet21.СпецСимволы.Item(20)("Цвет")
        ModulePE.Color22 = DataSet21.СпецСимволы.Item(21)("Цвет")
        ModulePE.Color23 = DataSet21.СпецСимволы.Item(22)("Цвет")
        ModulePE.Color24 = DataSet21.СпецСимволы.Item(23)("Цвет")
        ModulePE.Color25 = DataSet21.СпецСимволы.Item(24)("Цвет")
        ModulePE.Color26 = DataSet21.СпецСимволы.Item(25)("Цвет")
        ModulePE.Color27 = DataSet21.СпецСимволы.Item(26)("Цвет")
        ModulePE.Color28 = DataSet21.СпецСимволы.Item(27)("Цвет")
        ModulePE.Color29 = DataSet21.СпецСимволы.Item(28)("Цвет")
        ModulePE.Color30 = DataSet21.СпецСимволы.Item(29)("Цвет")
        ModulePE.Color31 = DataSet21.СпецСимволы.Item(30)("Цвет")
        '----------------------------------------------
        OleDbDataAdapter3.Fill(DataSet31, "DENWER")
        ModulePE.DENWER_Path = DataSet31.DENWER.Item(0)("ПутьDenwer")
        ModulePE.DENWER_host = DataSet31.DENWER.Item(0)("ХостDenwer")
        ModulePE.DENWER_MyPhpAdmin = DataSet31.DENWER.Item(0)("phpMyAdminDenwer")
        ModulePE.IExplorer = DataSet31.DENWER.Item(0)("IExplorer")
        ModulePE.Opera = DataSet31.DENWER.Item(0)("Opera")
        ModulePE.FireFox = DataSet31.DENWER.Item(0)("FireFox")
        ModulePE.Chrome = DataSet31.DENWER.Item(0)("Chrome")
        ModulePE.Safari = DataSet31.DENWER.Item(0)("Safari")
        '----------------------------------------------
        OleDbConnection1.Close()
        '----------------------------------------------
        'Открыть с помощью моей программы
        'If (Environment.GetCommandLineArgs.Length > 1) Then
        'ModulePE.FileOpenMyProgram = Environment.GetCommandLineArgs(1)
        'End If
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        Me.Visible = False
        ModulePE.LoadProgrammPE()
        ModulePE.ProgrammPE.Show()
        'If (ModulePE.FileOpenMyProgram <> "") Then
        'ModulePE.ProgrammPE.LoadFilesBase(FileOpenMyProgram, "Открыть UTF-8 WINTOUT BOM")
        'End If
    End Sub
End Class
