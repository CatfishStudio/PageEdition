Public Class FTPClient
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
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents ContextMenu3 As System.Windows.Forms.ContextMenu
    Friend WithEvents MenuItem4 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem5 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem6 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem7 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem8 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem9 As System.Windows.Forms.MenuItem
    Friend WithEvents ContextMenu1 As System.Windows.Forms.ContextMenu
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem10 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem11 As System.Windows.Forms.MenuItem
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents RichTextBox2 As System.Windows.Forms.RichTextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Splitter1 As System.Windows.Forms.Splitter
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents ListBox2 As System.Windows.Forms.ListBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents OleDbSelectCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbInsertCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbUpdateCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbDeleteCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbConnection1 As System.Data.OleDb.OleDbConnection
    Friend WithEvents OleDbDataAdapter1 As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents DataSet111 As PageEditor.DataSet11
    Friend WithEvents OleDbSelectCommand2 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbInsertCommand2 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbUpdateCommand2 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbDeleteCommand2 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbDataAdapter2 As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents DataSet121 As PageEditor.DataSet12
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FTPClient))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label1 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.ListBox1 = New System.Windows.Forms.ListBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.Button4 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.RichTextBox2 = New System.Windows.Forms.RichTextBox
        Me.ContextMenu3 = New System.Windows.Forms.ContextMenu
        Me.MenuItem4 = New System.Windows.Forms.MenuItem
        Me.MenuItem5 = New System.Windows.Forms.MenuItem
        Me.MenuItem6 = New System.Windows.Forms.MenuItem
        Me.MenuItem7 = New System.Windows.Forms.MenuItem
        Me.MenuItem8 = New System.Windows.Forms.MenuItem
        Me.MenuItem9 = New System.Windows.Forms.MenuItem
        Me.Label10 = New System.Windows.Forms.Label
        Me.TextBox5 = New System.Windows.Forms.TextBox
        Me.TextBox6 = New System.Windows.Forms.TextBox
        Me.TextBox7 = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Splitter1 = New System.Windows.Forms.Splitter
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.ListBox2 = New System.Windows.Forms.ListBox
        Me.ContextMenu1 = New System.Windows.Forms.ContextMenu
        Me.MenuItem1 = New System.Windows.Forms.MenuItem
        Me.MenuItem3 = New System.Windows.Forms.MenuItem
        Me.MenuItem2 = New System.Windows.Forms.MenuItem
        Me.MenuItem10 = New System.Windows.Forms.MenuItem
        Me.MenuItem11 = New System.Windows.Forms.MenuItem
        Me.OleDbSelectCommand1 = New System.Data.OleDb.OleDbCommand
        Me.OleDbConnection1 = New System.Data.OleDb.OleDbConnection
        Me.OleDbInsertCommand1 = New System.Data.OleDb.OleDbCommand
        Me.OleDbUpdateCommand1 = New System.Data.OleDb.OleDbCommand
        Me.OleDbDeleteCommand1 = New System.Data.OleDb.OleDbCommand
        Me.OleDbDataAdapter1 = New System.Data.OleDb.OleDbDataAdapter
        Me.DataSet111 = New PageEditor.DataSet11
        Me.OleDbSelectCommand2 = New System.Data.OleDb.OleDbCommand
        Me.OleDbInsertCommand2 = New System.Data.OleDb.OleDbCommand
        Me.OleDbUpdateCommand2 = New System.Data.OleDb.OleDbCommand
        Me.OleDbDeleteCommand2 = New System.Data.OleDb.OleDbCommand
        Me.OleDbDataAdapter2 = New System.Data.OleDb.OleDbDataAdapter
        Me.DataSet121 = New PageEditor.DataSet12
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataSet111, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet121, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(408, 56)
        Me.Panel1.TabIndex = 13
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Image = CType(resources.GetObject("Label1.Image"), System.Drawing.Image)
        Me.Label1.Location = New System.Drawing.Point(224, -2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(184, 56)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "FTP Client"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(8, -8)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(64, 80)
        Me.PictureBox1.TabIndex = 13
        Me.PictureBox1.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.ListBox1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(384, 216)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Перечень доступных серверов:"
        '
        'ListBox1
        '
        Me.ListBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListBox1.Location = New System.Drawing.Point(8, 16)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(368, 147)
        Me.ListBox1.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label3.Location = New System.Drawing.Point(8, 168)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(128, 16)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Строка подключения:"
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.Location = New System.Drawing.Point(8, 184)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(368, 20)
        Me.TextBox1.TabIndex = 16
        Me.TextBox1.Text = "ftp://"
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.BackColor = System.Drawing.Color.White
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Location = New System.Drawing.Point(320, 320)
        Me.Button2.Name = "Button2"
        Me.Button2.TabIndex = 30
        Me.Button2.Text = "Отмена."
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(208, 320)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(104, 23)
        Me.Button1.TabIndex = 29
        Me.Button1.Text = "Соединиться."
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(0, 56)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(408, 264)
        Me.TabControl1.TabIndex = 31
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(400, 235)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Подключение."
        '
        'TabPage2
        '
        Me.TabPage2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TabPage2.Controls.Add(Me.Button4)
        Me.TabPage2.Controls.Add(Me.Button3)
        Me.TabPage2.Controls.Add(Me.TextBox2)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.RichTextBox2)
        Me.TabPage2.Controls.Add(Me.Label10)
        Me.TabPage2.Controls.Add(Me.TextBox5)
        Me.TabPage2.Controls.Add(Me.TextBox6)
        Me.TabPage2.Controls.Add(Me.TextBox7)
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Controls.Add(Me.Label8)
        Me.TabPage2.Controls.Add(Me.Label9)
        Me.TabPage2.Controls.Add(Me.Splitter1)
        Me.TabPage2.Controls.Add(Me.GroupBox2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(400, 235)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Информационная база."
        '
        'Button4
        '
        Me.Button4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button4.BackColor = System.Drawing.Color.White
        Me.Button4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button4.Location = New System.Drawing.Point(166, 206)
        Me.Button4.Name = "Button4"
        Me.Button4.TabIndex = 60
        Me.Button4.Text = "Отмена."
        '
        'Button3
        '
        Me.Button3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button3.BackColor = System.Drawing.Color.White
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Location = New System.Drawing.Point(70, 206)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(88, 23)
        Me.Button3.TabIndex = 59
        Me.Button3.Text = "Сохранить."
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TextBox2
        '
        Me.TextBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox2.Location = New System.Drawing.Point(108, 8)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(130, 20)
        Me.TextBox2.TabIndex = 58
        Me.TextBox2.Text = ""
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(20, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(112, 16)
        Me.Label4.TabIndex = 57
        Me.Label4.Text = "Наименование:"
        '
        'RichTextBox2
        '
        Me.RichTextBox2.AcceptsTab = True
        Me.RichTextBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RichTextBox2.ContextMenu = Me.ContextMenu3
        Me.RichTextBox2.Location = New System.Drawing.Point(4, 136)
        Me.RichTextBox2.Name = "RichTextBox2"
        Me.RichTextBox2.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth
        Me.RichTextBox2.Size = New System.Drawing.Size(234, 62)
        Me.RichTextBox2.TabIndex = 56
        Me.RichTextBox2.Text = ""
        Me.RichTextBox2.WordWrap = False
        '
        'ContextMenu3
        '
        Me.ContextMenu3.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem4, Me.MenuItem5, Me.MenuItem6, Me.MenuItem7, Me.MenuItem8, Me.MenuItem9})
        '
        'MenuItem4
        '
        Me.MenuItem4.Index = 0
        Me.MenuItem4.Text = "Отменить     Ctrl+Z"
        '
        'MenuItem5
        '
        Me.MenuItem5.Index = 1
        Me.MenuItem5.Text = "-"
        '
        'MenuItem6
        '
        Me.MenuItem6.Index = 2
        Me.MenuItem6.Text = "Вырезать     Ctrl+X"
        '
        'MenuItem7
        '
        Me.MenuItem7.Index = 3
        Me.MenuItem7.Text = "Копировать Ctrl+C"
        '
        'MenuItem8
        '
        Me.MenuItem8.Index = 4
        Me.MenuItem8.Text = "Вставить      Ctrl+V"
        '
        'MenuItem9
        '
        Me.MenuItem9.Index = 5
        Me.MenuItem9.Text = "Удалить       Del"
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(4, 120)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(100, 16)
        Me.Label10.TabIndex = 55
        Me.Label10.Text = "Информация:"
        '
        'TextBox5
        '
        Me.TextBox5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox5.Location = New System.Drawing.Point(108, 88)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(130, 20)
        Me.TextBox5.TabIndex = 54
        Me.TextBox5.Text = ""
        '
        'TextBox6
        '
        Me.TextBox6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox6.Location = New System.Drawing.Point(108, 64)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(130, 20)
        Me.TextBox6.TabIndex = 53
        Me.TextBox6.Text = ""
        '
        'TextBox7
        '
        Me.TextBox7.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox7.Location = New System.Drawing.Point(108, 40)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(130, 20)
        Me.TextBox7.TabIndex = 52
        Me.TextBox7.Text = ""
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(28, 96)
        Me.Label7.Name = "Label7"
        Me.Label7.TabIndex = 51
        Me.Label7.Text = "Сервер [:порт]:"
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(60, 72)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(100, 16)
        Me.Label8.TabIndex = 50
        Me.Label8.Text = "Пароль:"
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(4, 48)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(112, 16)
        Me.Label9.TabIndex = 49
        Me.Label9.Text = "Имя пользователя:"
        '
        'Splitter1
        '
        Me.Splitter1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Splitter1.Location = New System.Drawing.Point(243, 0)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(3, 233)
        Me.Splitter1.TabIndex = 48
        Me.Splitter1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ListBox2)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Right
        Me.GroupBox2.Location = New System.Drawing.Point(246, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(152, 233)
        Me.GroupBox2.TabIndex = 47
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Содержание"
        '
        'ListBox2
        '
        Me.ListBox2.ContextMenu = Me.ContextMenu1
        Me.ListBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListBox2.Location = New System.Drawing.Point(3, 16)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(146, 212)
        Me.ListBox2.TabIndex = 0
        '
        'ContextMenu1
        '
        Me.ContextMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem1, Me.MenuItem3, Me.MenuItem2, Me.MenuItem10, Me.MenuItem11})
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 0
        Me.MenuItem1.Text = "Новая запись"
        '
        'MenuItem3
        '
        Me.MenuItem3.Index = 1
        Me.MenuItem3.Text = "Удалить запись"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 2
        Me.MenuItem2.Text = "Изменить запись"
        '
        'MenuItem10
        '
        Me.MenuItem10.Index = 3
        Me.MenuItem10.Text = "-"
        '
        'MenuItem11
        '
        Me.MenuItem11.Index = 4
        Me.MenuItem11.Text = "Обновить."
        '
        'OleDbSelectCommand1
        '
        Me.OleDbSelectCommand1.CommandText = "SELECT id, ИмяПользователя, ИмяСоединения, Информация, Пароль, СерверИПорт FROM F" & _
        "TP"
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
        Me.OleDbInsertCommand1.CommandText = "INSERT INTO FTP(ИмяПользователя, ИмяСоединения, Информация, Пароль, СерверИПорт) " & _
        "VALUES (?, ?, ?, ?, ?)"
        Me.OleDbInsertCommand1.Connection = Me.OleDbConnection1
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("ИмяПользователя", System.Data.OleDb.OleDbType.VarWChar, 255, "ИмяПользователя"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("ИмяСоединения", System.Data.OleDb.OleDbType.VarWChar, 255, "ИмяСоединения"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Информация", System.Data.OleDb.OleDbType.VarWChar, 0, "Информация"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Пароль", System.Data.OleDb.OleDbType.VarWChar, 255, "Пароль"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("СерверИПорт", System.Data.OleDb.OleDbType.VarWChar, 255, "СерверИПорт"))
        '
        'OleDbUpdateCommand1
        '
        Me.OleDbUpdateCommand1.CommandText = "UPDATE FTP SET ИмяПользователя = ?, ИмяСоединения = ?, Информация = ?, Пароль = ?" & _
        ", СерверИПорт = ? WHERE (id = ?) AND (ИмяПользователя = ? OR ? IS NULL AND ИмяПо" & _
        "льзователя IS NULL) AND (ИмяСоединения = ? OR ? IS NULL AND ИмяСоединения IS NUL" & _
        "L) AND (Пароль = ? OR ? IS NULL AND Пароль IS NULL) AND (СерверИПорт = ? OR ? IS" & _
        " NULL AND СерверИПорт IS NULL)"
        Me.OleDbUpdateCommand1.Connection = Me.OleDbConnection1
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("ИмяПользователя", System.Data.OleDb.OleDbType.VarWChar, 255, "ИмяПользователя"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("ИмяСоединения", System.Data.OleDb.OleDbType.VarWChar, 255, "ИмяСоединения"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Информация", System.Data.OleDb.OleDbType.VarWChar, 0, "Информация"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Пароль", System.Data.OleDb.OleDbType.VarWChar, 255, "Пароль"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("СерверИПорт", System.Data.OleDb.OleDbType.VarWChar, 255, "СерверИПорт"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_id", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ИмяПользователя", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ИмяПользователя", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ИмяПользователя1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ИмяПользователя", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ИмяСоединения", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ИмяСоединения", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ИмяСоединения1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ИмяСоединения", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Пароль", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Пароль", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Пароль1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Пароль", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_СерверИПорт", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "СерверИПорт", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_СерверИПорт1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "СерверИПорт", System.Data.DataRowVersion.Original, Nothing))
        '
        'OleDbDeleteCommand1
        '
        Me.OleDbDeleteCommand1.CommandText = "DELETE FROM FTP WHERE (id = ?) AND (ИмяПользователя = ? OR ? IS NULL AND ИмяПольз" & _
        "ователя IS NULL) AND (ИмяСоединения = ? OR ? IS NULL AND ИмяСоединения IS NULL) " & _
        "AND (Пароль = ? OR ? IS NULL AND Пароль IS NULL) AND (СерверИПорт = ? OR ? IS NU" & _
        "LL AND СерверИПорт IS NULL)"
        Me.OleDbDeleteCommand1.Connection = Me.OleDbConnection1
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_id", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ИмяПользователя", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ИмяПользователя", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ИмяПользователя1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ИмяПользователя", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ИмяСоединения", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ИмяСоединения", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ИмяСоединения1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ИмяСоединения", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Пароль", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Пароль", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Пароль1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Пароль", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_СерверИПорт", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "СерверИПорт", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_СерверИПорт1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "СерверИПорт", System.Data.DataRowVersion.Original, Nothing))
        '
        'OleDbDataAdapter1
        '
        Me.OleDbDataAdapter1.DeleteCommand = Me.OleDbDeleteCommand1
        Me.OleDbDataAdapter1.InsertCommand = Me.OleDbInsertCommand1
        Me.OleDbDataAdapter1.SelectCommand = Me.OleDbSelectCommand1
        Me.OleDbDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "FTP", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id", "id"), New System.Data.Common.DataColumnMapping("ИмяПользователя", "ИмяПользователя"), New System.Data.Common.DataColumnMapping("ИмяСоединения", "ИмяСоединения"), New System.Data.Common.DataColumnMapping("Информация", "Информация"), New System.Data.Common.DataColumnMapping("Пароль", "Пароль"), New System.Data.Common.DataColumnMapping("СерверИПорт", "СерверИПорт")})})
        Me.OleDbDataAdapter1.UpdateCommand = Me.OleDbUpdateCommand1
        '
        'DataSet111
        '
        Me.DataSet111.DataSetName = "DataSet11"
        Me.DataSet111.Locale = New System.Globalization.CultureInfo("ru-RU")
        '
        'OleDbSelectCommand2
        '
        Me.OleDbSelectCommand2.CommandText = "SELECT id, ИмяПользователя, ИмяСоединения, Информация, Пароль, СерверИПорт FROM F" & _
        "TP"
        Me.OleDbSelectCommand2.Connection = Me.OleDbConnection1
        '
        'OleDbInsertCommand2
        '
        Me.OleDbInsertCommand2.CommandText = "INSERT INTO FTP(ИмяПользователя, ИмяСоединения, Информация, Пароль, СерверИПорт) " & _
        "VALUES (?, ?, ?, ?, ?)"
        Me.OleDbInsertCommand2.Connection = Me.OleDbConnection1
        Me.OleDbInsertCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("ИмяПользователя", System.Data.OleDb.OleDbType.VarWChar, 255, "ИмяПользователя"))
        Me.OleDbInsertCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("ИмяСоединения", System.Data.OleDb.OleDbType.VarWChar, 255, "ИмяСоединения"))
        Me.OleDbInsertCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Информация", System.Data.OleDb.OleDbType.VarWChar, 0, "Информация"))
        Me.OleDbInsertCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Пароль", System.Data.OleDb.OleDbType.VarWChar, 255, "Пароль"))
        Me.OleDbInsertCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("СерверИПорт", System.Data.OleDb.OleDbType.VarWChar, 255, "СерверИПорт"))
        '
        'OleDbUpdateCommand2
        '
        Me.OleDbUpdateCommand2.CommandText = "UPDATE FTP SET ИмяПользователя = ?, ИмяСоединения = ?, Информация = ?, Пароль = ?" & _
        ", СерверИПорт = ? WHERE (id = ?) AND (ИмяПользователя = ? OR ? IS NULL AND ИмяПо" & _
        "льзователя IS NULL) AND (ИмяСоединения = ? OR ? IS NULL AND ИмяСоединения IS NUL" & _
        "L) AND (Пароль = ? OR ? IS NULL AND Пароль IS NULL) AND (СерверИПорт = ? OR ? IS" & _
        " NULL AND СерверИПорт IS NULL)"
        Me.OleDbUpdateCommand2.Connection = Me.OleDbConnection1
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("ИмяПользователя", System.Data.OleDb.OleDbType.VarWChar, 255, "ИмяПользователя"))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("ИмяСоединения", System.Data.OleDb.OleDbType.VarWChar, 255, "ИмяСоединения"))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Информация", System.Data.OleDb.OleDbType.VarWChar, 0, "Информация"))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Пароль", System.Data.OleDb.OleDbType.VarWChar, 255, "Пароль"))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("СерверИПорт", System.Data.OleDb.OleDbType.VarWChar, 255, "СерверИПорт"))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_id", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ИмяПользователя", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ИмяПользователя", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ИмяПользователя1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ИмяПользователя", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ИмяСоединения", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ИмяСоединения", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ИмяСоединения1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ИмяСоединения", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Пароль", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Пароль", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Пароль1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Пароль", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_СерверИПорт", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "СерверИПорт", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_СерверИПорт1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "СерверИПорт", System.Data.DataRowVersion.Original, Nothing))
        '
        'OleDbDeleteCommand2
        '
        Me.OleDbDeleteCommand2.CommandText = "DELETE FROM FTP WHERE (id = ?) AND (ИмяПользователя = ? OR ? IS NULL AND ИмяПольз" & _
        "ователя IS NULL) AND (ИмяСоединения = ? OR ? IS NULL AND ИмяСоединения IS NULL) " & _
        "AND (Пароль = ? OR ? IS NULL AND Пароль IS NULL) AND (СерверИПорт = ? OR ? IS NU" & _
        "LL AND СерверИПорт IS NULL)"
        Me.OleDbDeleteCommand2.Connection = Me.OleDbConnection1
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_id", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ИмяПользователя", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ИмяПользователя", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ИмяПользователя1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ИмяПользователя", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ИмяСоединения", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ИмяСоединения", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ИмяСоединения1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ИмяСоединения", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Пароль", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Пароль", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Пароль1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Пароль", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_СерверИПорт", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "СерверИПорт", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_СерверИПорт1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "СерверИПорт", System.Data.DataRowVersion.Original, Nothing))
        '
        'OleDbDataAdapter2
        '
        Me.OleDbDataAdapter2.DeleteCommand = Me.OleDbDeleteCommand2
        Me.OleDbDataAdapter2.InsertCommand = Me.OleDbInsertCommand2
        Me.OleDbDataAdapter2.SelectCommand = Me.OleDbSelectCommand2
        Me.OleDbDataAdapter2.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "FTP", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id", "id"), New System.Data.Common.DataColumnMapping("ИмяПользователя", "ИмяПользователя"), New System.Data.Common.DataColumnMapping("ИмяСоединения", "ИмяСоединения"), New System.Data.Common.DataColumnMapping("Информация", "Информация"), New System.Data.Common.DataColumnMapping("Пароль", "Пароль"), New System.Data.Common.DataColumnMapping("СерверИПорт", "СерверИПорт")})})
        Me.OleDbDataAdapter2.UpdateCommand = Me.OleDbUpdateCommand2
        '
        'DataSet121
        '
        Me.DataSet121.DataSetName = "DataSet12"
        Me.DataSet121.Locale = New System.Globalization.CultureInfo("ru-RU")
        '
        'FTPClient
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(408, 350)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FTPClient"
        Me.Text = "FTP Клиент"
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DataSet111, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet121, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub FTPClient_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ModulePE.FTPShow = True
        OleDbConnection1.ConnectionString = ModuleBase.StringConnection
        OleDbConnection1.Open()
        DataSet111.Clear()
        OleDbDataAdapter1.Fill(DataSet111, "FTP")
        For i As Integer = 0 To DataSet111.FTP.Rows.Count - 1
            ListBox1.Items.Add(DataSet111.FTP.Item(i)("ИмяСоединения"))
            ListBox2.Items.Add(DataSet111.FTP.Item(i)("ИмяСоединения"))
        Next
        OleDbConnection1.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Close()
    End Sub

    Private Sub FTPClient_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        ModulePE.FTPShow = False
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'FTP через проводник
        System.Diagnostics.Process.Start("explorer.exe", TextBox1.Text)
    End Sub

    Dim BaseAction As String = "новая запись"
    Private Sub MenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem1.Click
        TextBox2.Text = ""
        TextBox7.Text = ""
        TextBox6.Text = ""
        TextBox5.Text = ""
        RichTextBox2.Text = ""
        BaseAction = "новая запись"
        DataSet121.Clear()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        TextBox2.Text = ""
        TextBox7.Text = ""
        TextBox6.Text = ""
        TextBox5.Text = ""
        RichTextBox2.Text = ""
        BaseAction = "новая запись"
        DataSet121.Clear()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If (BaseAction = "новая запись") Then
            For i As Integer = 0 To DataSet111.FTP.Count - 1
                If (DataSet111.FTP.Item(i)("ИмяСоединения") = TextBox2.Text) Then
                    MsgBox("Имя данного соединения не уникально! Введите другое.", MsgBoxStyle.OKOnly, "Сообщение:")
                    Exit Sub
                End If
            Next

            OleDbConnection1.Open()
            DataSet121.Clear()
            OleDbDataAdapter2.Fill(DataSet121, "FTP")

            Dim DT As DataTable = DataSet121.FTP
            Dim row As DataRow
            row = DT.NewRow
            row("ИмяСоединения") = TextBox2.Text
            row("ИмяПользователя") = TextBox7.Text
            row("Пароль") = TextBox6.Text
            row("СерверИПорт") = TextBox5.Text
            row("Информация") = RichTextBox2.Text
            DT.Rows.Add(row)
            OleDbDataAdapter2.Update(DataSet121, "FTP")
            '..
            ListBox1.Items.Clear()
            ListBox2.Items.Clear()
            DataSet111.Clear()
            OleDbDataAdapter1.Fill(DataSet111, "FTP")
            For i As Integer = 0 To DataSet111.FTP.Rows.Count - 1
                ListBox1.Items.Add(DataSet111.FTP.Item(i)("ИмяСоединения"))
                ListBox2.Items.Add(DataSet111.FTP.Item(i)("ИмяСоединения"))
            Next
            OleDbConnection1.Close()
            TextBox2.Text = ""
            TextBox7.Text = ""
            TextBox6.Text = ""
            TextBox5.Text = ""
            RichTextBox2.Text = ""
            BaseAction = "новая запись"
            MsgBox("Сохранение прошло успешно." + System.Environment.NewLine + "Запись будет автоматически закрыта.", MsgBoxStyle.OKOnly, "Сообщение:")
        Else
            If (BaseAction = "изменить запись") Then
                OleDbConnection1.Open()

                DataSet121.FTP.Item(0)("ИмяСоединения") = TextBox2.Text
                DataSet121.FTP.Item(0)("ИмяПользователя") = TextBox7.Text
                DataSet121.FTP.Item(0)("Пароль") = TextBox6.Text
                DataSet121.FTP.Item(0)("СерверИПорт") = TextBox5.Text
                DataSet121.FTP.Item(0)("Информация") = RichTextBox2.Text
                OleDbDataAdapter2.Update(DataSet121, "FTP")
                '..
                ListBox1.Items.Clear()
                ListBox2.Items.Clear()
                DataSet111.Clear()
                OleDbDataAdapter1.Fill(DataSet111, "FTP")
                For i As Integer = 0 To DataSet111.FTP.Rows.Count - 1
                    ListBox1.Items.Add(DataSet111.FTP.Item(i)("ИмяСоединения"))
                    ListBox2.Items.Add(DataSet111.FTP.Item(i)("ИмяСоединения"))
                Next
                OleDbConnection1.Close()
            End If
        End If
    End Sub

    Private Sub MenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem2.Click
        OleDbConnection1.Open()
        DataSet121.Clear()
        OleDbDataAdapter2.SelectCommand.CommandText = "SELECT id, ИмяПользователя, ИмяСоединения, Информация, Пароль, СерверИПорт FROM FTP WHERE (ИмяСоединения = '" + ListBox2.SelectedItem + "')"
        OleDbDataAdapter2.Fill(DataSet121, "FTP")

        TextBox2.Text = DataSet121.FTP.Item(0)("ИмяСоединения")
        TextBox7.Text = DataSet121.FTP.Item(0)("ИмяПользователя")
        TextBox6.Text = DataSet121.FTP.Item(0)("Пароль")
        TextBox5.Text = DataSet121.FTP.Item(0)("СерверИПорт")
        RichTextBox2.Text = DataSet121.FTP.Item(0)("Информация")
        BaseAction = "изменить запись"
        OleDbConnection1.Close()
    End Sub

    Private Sub MenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem3.Click
        If (ListBox2.SelectedItem <> "") Then
            If (MsgBox("Удалить запись безвозвратно?", MsgBoxStyle.OKCancel, "Вопрос:") = MsgBoxResult.OK) Then
                OleDbConnection1.Open()
                DataSet121.Clear()
                OleDbDataAdapter2.SelectCommand.CommandText = "SELECT id, ИмяПользователя, ИмяСоединения, Информация, Пароль, СерверИПорт FROM FTP WHERE (ИмяСоединения = '" + ListBox2.SelectedItem + "')"
                OleDbDataAdapter2.Fill(DataSet121, "FTP")
                DataSet121.FTP.Item(0).Delete()
                OleDbDataAdapter2.Update(DataSet121, "FTP")
                '...
                ListBox1.Items.Clear()
                ListBox2.Items.Clear()
                DataSet111.Clear()
                OleDbDataAdapter1.Fill(DataSet111, "FTP")
                For i As Integer = 0 To DataSet111.FTP.Rows.Count - 1
                    ListBox1.Items.Add(DataSet111.FTP.Item(i)("ИмяСоединения"))
                    ListBox2.Items.Add(DataSet111.FTP.Item(i)("ИмяСоединения"))
                Next
                OleDbConnection1.Close()
                TextBox2.Text = ""
                TextBox7.Text = ""
                TextBox6.Text = ""
                TextBox5.Text = ""
                RichTextBox2.Text = ""
                BaseAction = "новая запись"
            End If
        Else
            MsgBox("Вы не выбрали запись для удаления!", MsgBoxStyle.OKOnly, "Сообщение:")
        End If
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
        Dim Name, User, Pass, Server As String
        For i As Integer = 0 To DataSet111.FTP.Count - 1
            If (DataSet111.FTP.Item(i)("ИмяСоединения") = ListBox1.SelectedItem) Then
                Name = DataSet111.FTP.Item(i)("ИмяСоединения")
                User = DataSet111.FTP.Item(i)("ИмяПользователя")
                Pass = DataSet111.FTP.Item(i)("Пароль")
                Server = DataSet111.FTP.Item(i)("СерверИПорт")
                Exit For
            End If
        Next
        TextBox1.Text = "ftp://" & User & ":" & Pass & "@" & Server
    End Sub

    Private Sub MenuItem11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem11.Click
        OleDbConnection1.Open()
        DataSet111.Clear()
        OleDbDataAdapter1.Fill(DataSet111, "FTP")
        For i As Integer = 0 To DataSet111.FTP.Rows.Count - 1
            ListBox1.Items.Add(DataSet111.FTP.Item(i)("ИмяСоединения"))
            ListBox2.Items.Add(DataSet111.FTP.Item(i)("ИмяСоединения"))
        Next
        OleDbConnection1.Close()
    End Sub

    Private Sub MenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem4.Click
        RichTextBox2.Undo()
    End Sub

    Private Sub MenuItem6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem6.Click
        RichTextBox2.Cut()
    End Sub

    Private Sub MenuItem7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem7.Click
        RichTextBox2.Copy()
    End Sub

    Private Sub MenuItem8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem8.Click
        RichTextBox2.Paste()
        RichTextBox2.SelectionColor = Color.Black
    End Sub

    Private Sub MenuItem9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem9.Click
        Clipboard.SetDataObject("")
        RichTextBox2.Paste()
        RichTextBox2.SelectionColor = Color.Black
    End Sub
End Class
