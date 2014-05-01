Public Class Settings
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
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents CheckBox3 As System.Windows.Forms.CheckBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox10 As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents TextBox9 As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TextBox8 As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents FontDialog1 As System.Windows.Forms.FontDialog
    Friend WithEvents ColorDialog1 As System.Windows.Forms.ColorDialog
    Friend WithEvents OleDbSelectCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbInsertCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbUpdateCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbDeleteCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbConnection1 As System.Data.OleDb.OleDbConnection
    Friend WithEvents OleDbDataAdapter1 As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents DataSet81 As PageEditor.DataSet8
    Friend WithEvents OleDbSelectCommand2 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbInsertCommand2 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbUpdateCommand2 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbDeleteCommand2 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbDataAdapter2 As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents DataSet91 As PageEditor.DataSet9
    Friend WithEvents OleDbSelectCommand3 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbInsertCommand3 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbUpdateCommand3 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbDeleteCommand3 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbDataAdapter3 As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents DataSet101 As PageEditor.DataSet10
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents Button10 As System.Windows.Forms.Button
    Friend WithEvents Button11 As System.Windows.Forms.Button
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents OpenFileDialog2 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents OpenFileDialog3 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents OpenFileDialog4 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents OpenFileDialog5 As System.Windows.Forms.OpenFileDialog
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Settings))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label1 = New System.Windows.Forms.Label
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.CheckBox3 = New System.Windows.Forms.CheckBox
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox
        Me.Button3 = New System.Windows.Forms.Button
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Button11 = New System.Windows.Forms.Button
        Me.Button10 = New System.Windows.Forms.Button
        Me.Button9 = New System.Windows.Forms.Button
        Me.Button8 = New System.Windows.Forms.Button
        Me.Button7 = New System.Windows.Forms.Button
        Me.TextBox10 = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.TextBox9 = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.TextBox8 = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.TextBox7 = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.TextBox6 = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Button6 = New System.Windows.Forms.Button
        Me.Button5 = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.TextBox5 = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.TextBox4 = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.TextBox3 = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.TabPage3 = New System.Windows.Forms.TabPage
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Label42 = New System.Windows.Forms.Label
        Me.Label41 = New System.Windows.Forms.Label
        Me.Label40 = New System.Windows.Forms.Label
        Me.Label39 = New System.Windows.Forms.Label
        Me.Label38 = New System.Windows.Forms.Label
        Me.Label37 = New System.Windows.Forms.Label
        Me.Label36 = New System.Windows.Forms.Label
        Me.Label35 = New System.Windows.Forms.Label
        Me.Label34 = New System.Windows.Forms.Label
        Me.Label33 = New System.Windows.Forms.Label
        Me.Label32 = New System.Windows.Forms.Label
        Me.Label31 = New System.Windows.Forms.Label
        Me.Label30 = New System.Windows.Forms.Label
        Me.Label29 = New System.Windows.Forms.Label
        Me.Label28 = New System.Windows.Forms.Label
        Me.Label27 = New System.Windows.Forms.Label
        Me.Label26 = New System.Windows.Forms.Label
        Me.Label25 = New System.Windows.Forms.Label
        Me.Label24 = New System.Windows.Forms.Label
        Me.Label23 = New System.Windows.Forms.Label
        Me.Label22 = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.FontDialog1 = New System.Windows.Forms.FontDialog
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog
        Me.OleDbSelectCommand1 = New System.Data.OleDb.OleDbCommand
        Me.OleDbConnection1 = New System.Data.OleDb.OleDbConnection
        Me.OleDbInsertCommand1 = New System.Data.OleDb.OleDbCommand
        Me.OleDbUpdateCommand1 = New System.Data.OleDb.OleDbCommand
        Me.OleDbDeleteCommand1 = New System.Data.OleDb.OleDbCommand
        Me.OleDbDataAdapter1 = New System.Data.OleDb.OleDbDataAdapter
        Me.DataSet81 = New PageEditor.DataSet8
        Me.OleDbSelectCommand2 = New System.Data.OleDb.OleDbCommand
        Me.OleDbInsertCommand2 = New System.Data.OleDb.OleDbCommand
        Me.OleDbUpdateCommand2 = New System.Data.OleDb.OleDbCommand
        Me.OleDbDeleteCommand2 = New System.Data.OleDb.OleDbCommand
        Me.OleDbDataAdapter2 = New System.Data.OleDb.OleDbDataAdapter
        Me.DataSet91 = New PageEditor.DataSet9
        Me.OleDbSelectCommand3 = New System.Data.OleDb.OleDbCommand
        Me.OleDbInsertCommand3 = New System.Data.OleDb.OleDbCommand
        Me.OleDbUpdateCommand3 = New System.Data.OleDb.OleDbCommand
        Me.OleDbDeleteCommand3 = New System.Data.OleDb.OleDbCommand
        Me.OleDbDataAdapter3 = New System.Data.OleDb.OleDbDataAdapter
        Me.DataSet101 = New PageEditor.DataSet10
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.OpenFileDialog2 = New System.Windows.Forms.OpenFileDialog
        Me.OpenFileDialog3 = New System.Windows.Forms.OpenFileDialog
        Me.OpenFileDialog4 = New System.Windows.Forms.OpenFileDialog
        Me.OpenFileDialog5 = New System.Windows.Forms.OpenFileDialog
        Me.Panel1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DataSet81, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet91, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet101, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(416, 48)
        Me.Panel1.TabIndex = 27
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Image = CType(resources.GetObject("Label1.Image"), System.Drawing.Image)
        Me.Label1.Location = New System.Drawing.Point(232, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(184, 48)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Настройки."
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.BackColor = System.Drawing.Color.White
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Location = New System.Drawing.Point(336, 344)
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
        Me.Button1.Location = New System.Drawing.Point(240, 344)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(88, 23)
        Me.Button1.TabIndex = 29
        Me.Button1.Text = "Сохранить"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(0, 48)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(416, 288)
        Me.TabControl1.TabIndex = 28
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.White
        Me.TabPage1.Controls.Add(Me.CheckBox3)
        Me.TabPage1.Controls.Add(Me.Panel2)
        Me.TabPage1.Controls.Add(Me.Button3)
        Me.TabPage1.Controls.Add(Me.TextBox2)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.TextBox1)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(408, 262)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Общие"
        '
        'CheckBox3
        '
        Me.CheckBox3.Location = New System.Drawing.Point(16, 96)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(296, 48)
        Me.CheckBox3.TabIndex = 22
        Me.CheckBox3.Text = "Форматировать модуль при открытии."
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.RichTextBox1)
        Me.Panel2.Location = New System.Drawing.Point(8, 152)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(320, 96)
        Me.Panel2.TabIndex = 17
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RichTextBox1.BackColor = System.Drawing.Color.White
        Me.RichTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.RichTextBox1.Location = New System.Drawing.Point(0, 8)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.ReadOnly = True
        Me.RichTextBox1.Size = New System.Drawing.Size(320, 80)
        Me.RichTextBox1.TabIndex = 16
        Me.RichTextBox1.Text = "" & Microsoft.VisualBasic.ChrW(10) & " -- Образец текста --"
        Me.RichTextBox1.WordWrap = False
        '
        'Button3
        '
        Me.Button3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button3.BackColor = System.Drawing.Color.White
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Location = New System.Drawing.Point(368, 16)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(32, 23)
        Me.Button3.TabIndex = 15
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TextBox2
        '
        Me.TextBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox2.Location = New System.Drawing.Point(56, 48)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(344, 20)
        Me.TextBox2.TabIndex = 3
        Me.TextBox2.Text = "0"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(8, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 23)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Размер:"
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.Location = New System.Drawing.Point(56, 16)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(312, 20)
        Me.TextBox1.TabIndex = 1
        Me.TextBox1.Text = ""
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(8, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 23)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Шрифт:"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.White
        Me.TabPage2.Controls.Add(Me.GroupBox2)
        Me.TabPage2.Controls.Add(Me.GroupBox1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(408, 262)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "DENWER"
        Me.TabPage2.Visible = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.Button11)
        Me.GroupBox2.Controls.Add(Me.Button10)
        Me.GroupBox2.Controls.Add(Me.Button9)
        Me.GroupBox2.Controls.Add(Me.Button8)
        Me.GroupBox2.Controls.Add(Me.Button7)
        Me.GroupBox2.Controls.Add(Me.TextBox10)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.TextBox9)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.TextBox8)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.TextBox7)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.TextBox6)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Location = New System.Drawing.Point(8, 112)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(392, 144)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Браузеры:"
        '
        'Button11
        '
        Me.Button11.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button11.BackColor = System.Drawing.Color.White
        Me.Button11.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button11.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button11.Image = CType(resources.GetObject("Button11.Image"), System.Drawing.Image)
        Me.Button11.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button11.Location = New System.Drawing.Point(352, 112)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(32, 23)
        Me.Button11.TabIndex = 20
        Me.Button11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Button10
        '
        Me.Button10.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button10.BackColor = System.Drawing.Color.White
        Me.Button10.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button10.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button10.Image = CType(resources.GetObject("Button10.Image"), System.Drawing.Image)
        Me.Button10.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button10.Location = New System.Drawing.Point(352, 88)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(32, 23)
        Me.Button10.TabIndex = 19
        Me.Button10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Button9
        '
        Me.Button9.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button9.BackColor = System.Drawing.Color.White
        Me.Button9.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button9.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button9.Image = CType(resources.GetObject("Button9.Image"), System.Drawing.Image)
        Me.Button9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button9.Location = New System.Drawing.Point(352, 64)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(32, 23)
        Me.Button9.TabIndex = 18
        Me.Button9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Button8
        '
        Me.Button8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button8.BackColor = System.Drawing.Color.White
        Me.Button8.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button8.Image = CType(resources.GetObject("Button8.Image"), System.Drawing.Image)
        Me.Button8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button8.Location = New System.Drawing.Point(352, 40)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(32, 23)
        Me.Button8.TabIndex = 17
        Me.Button8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Button7
        '
        Me.Button7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button7.BackColor = System.Drawing.Color.White
        Me.Button7.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button7.Image = CType(resources.GetObject("Button7.Image"), System.Drawing.Image)
        Me.Button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button7.Location = New System.Drawing.Point(352, 16)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(32, 23)
        Me.Button7.TabIndex = 16
        Me.Button7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TextBox10
        '
        Me.TextBox10.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox10.Location = New System.Drawing.Point(64, 112)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New System.Drawing.Size(288, 20)
        Me.TextBox10.TabIndex = 11
        Me.TextBox10.Text = ""
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(8, 120)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(56, 16)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "Safari"
        '
        'TextBox9
        '
        Me.TextBox9.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox9.Location = New System.Drawing.Point(64, 88)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(288, 20)
        Me.TextBox9.TabIndex = 9
        Me.TextBox9.Text = ""
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(8, 96)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(56, 16)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = "Chrome"
        '
        'TextBox8
        '
        Me.TextBox8.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox8.Location = New System.Drawing.Point(64, 64)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(288, 20)
        Me.TextBox8.TabIndex = 7
        Me.TextBox8.Text = ""
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(8, 72)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(56, 16)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "FireFox"
        '
        'TextBox7
        '
        Me.TextBox7.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox7.Location = New System.Drawing.Point(64, 40)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(288, 20)
        Me.TextBox7.TabIndex = 5
        Me.TextBox7.Text = ""
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(8, 48)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 16)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "Opera"
        '
        'TextBox6
        '
        Me.TextBox6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox6.Location = New System.Drawing.Point(64, 16)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(288, 20)
        Me.TextBox6.TabIndex = 3
        Me.TextBox6.Text = ""
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(8, 24)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 16)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "IExplorer"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.Button6)
        Me.GroupBox1.Controls.Add(Me.Button5)
        Me.GroupBox1.Controls.Add(Me.Button4)
        Me.GroupBox1.Controls.Add(Me.TextBox5)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.TextBox4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.TextBox3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(392, 96)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Denwer"
        '
        'Button6
        '
        Me.Button6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button6.BackColor = System.Drawing.Color.White
        Me.Button6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button6.Image = CType(resources.GetObject("Button6.Image"), System.Drawing.Image)
        Me.Button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button6.Location = New System.Drawing.Point(352, 64)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(32, 23)
        Me.Button6.TabIndex = 18
        Me.Button6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Button5
        '
        Me.Button5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button5.BackColor = System.Drawing.Color.White
        Me.Button5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button5.Image = CType(resources.GetObject("Button5.Image"), System.Drawing.Image)
        Me.Button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button5.Location = New System.Drawing.Point(352, 40)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(32, 23)
        Me.Button5.TabIndex = 17
        Me.Button5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Button4
        '
        Me.Button4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button4.BackColor = System.Drawing.Color.White
        Me.Button4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button4.Image = CType(resources.GetObject("Button4.Image"), System.Drawing.Image)
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.Location = New System.Drawing.Point(352, 16)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(32, 23)
        Me.Button4.TabIndex = 16
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TextBox5
        '
        Me.TextBox5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox5.Location = New System.Drawing.Point(120, 64)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(232, 20)
        Me.TextBox5.TabIndex = 5
        Me.TextBox5.Text = ""
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(8, 72)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(120, 16)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Администратор PHP"
        '
        'TextBox4
        '
        Me.TextBox4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox4.Location = New System.Drawing.Point(112, 40)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(240, 20)
        Me.TextBox4.TabIndex = 3
        Me.TextBox4.Text = ""
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(8, 48)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 16)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Локальный хост :"
        '
        'TextBox3
        '
        Me.TextBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox3.Location = New System.Drawing.Point(112, 16)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(240, 20)
        Me.TextBox3.TabIndex = 1
        Me.TextBox3.Text = ""
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(8, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 16)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Путь к программе:"
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.Color.White
        Me.TabPage3.Controls.Add(Me.GroupBox3)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(408, 262)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Цвет форматирования"
        Me.TabPage3.Visible = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.Label42)
        Me.GroupBox3.Controls.Add(Me.Label41)
        Me.GroupBox3.Controls.Add(Me.Label40)
        Me.GroupBox3.Controls.Add(Me.Label39)
        Me.GroupBox3.Controls.Add(Me.Label38)
        Me.GroupBox3.Controls.Add(Me.Label37)
        Me.GroupBox3.Controls.Add(Me.Label36)
        Me.GroupBox3.Controls.Add(Me.Label35)
        Me.GroupBox3.Controls.Add(Me.Label34)
        Me.GroupBox3.Controls.Add(Me.Label33)
        Me.GroupBox3.Controls.Add(Me.Label32)
        Me.GroupBox3.Controls.Add(Me.Label31)
        Me.GroupBox3.Controls.Add(Me.Label30)
        Me.GroupBox3.Controls.Add(Me.Label29)
        Me.GroupBox3.Controls.Add(Me.Label28)
        Me.GroupBox3.Controls.Add(Me.Label27)
        Me.GroupBox3.Controls.Add(Me.Label26)
        Me.GroupBox3.Controls.Add(Me.Label25)
        Me.GroupBox3.Controls.Add(Me.Label24)
        Me.GroupBox3.Controls.Add(Me.Label23)
        Me.GroupBox3.Controls.Add(Me.Label22)
        Me.GroupBox3.Controls.Add(Me.Label21)
        Me.GroupBox3.Controls.Add(Me.Label20)
        Me.GroupBox3.Controls.Add(Me.Label19)
        Me.GroupBox3.Controls.Add(Me.Label18)
        Me.GroupBox3.Controls.Add(Me.Label17)
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(392, 248)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Настройка цвета спец. символов:"
        '
        'Label42
        '
        Me.Label42.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label42.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label42.Location = New System.Drawing.Point(72, 216)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(40, 16)
        Me.Label42.TabIndex = 30
        Me.Label42.Text = "?"
        Me.Label42.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label41
        '
        Me.Label41.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label41.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label41.Location = New System.Drawing.Point(200, 192)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(40, 16)
        Me.Label41.TabIndex = 29
        Me.Label41.Text = "."
        Me.Label41.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label40
        '
        Me.Label40.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label40.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label40.Location = New System.Drawing.Point(136, 192)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(40, 16)
        Me.Label40.TabIndex = 28
        Me.Label40.Text = ","
        Me.Label40.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label39
        '
        Me.Label39.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label39.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label39.Location = New System.Drawing.Point(200, 168)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(40, 16)
        Me.Label39.TabIndex = 27
        Me.Label39.Text = ">"
        Me.Label39.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label38
        '
        Me.Label38.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label38.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label38.Location = New System.Drawing.Point(136, 168)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(40, 16)
        Me.Label38.TabIndex = 26
        Me.Label38.Text = "<"
        Me.Label38.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label37
        '
        Me.Label37.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label37.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label37.Location = New System.Drawing.Point(72, 192)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(40, 16)
        Me.Label37.TabIndex = 25
        Me.Label37.Text = "|"
        Me.Label37.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label36
        '
        Me.Label36.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label36.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label36.Location = New System.Drawing.Point(200, 144)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(40, 16)
        Me.Label36.TabIndex = 24
        Me.Label36.Text = "/"
        Me.Label36.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label35
        '
        Me.Label35.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label35.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label35.Location = New System.Drawing.Point(136, 144)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(40, 16)
        Me.Label35.TabIndex = 23
        Me.Label35.Text = "\"
        Me.Label35.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label34
        '
        Me.Label34.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label34.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label34.Location = New System.Drawing.Point(200, 120)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(40, 16)
        Me.Label34.TabIndex = 22
        Me.Label34.Text = """"
        Me.Label34.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label33
        '
        Me.Label33.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label33.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label33.Location = New System.Drawing.Point(136, 120)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(40, 16)
        Me.Label33.TabIndex = 21
        Me.Label33.Text = "'"
        Me.Label33.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label32
        '
        Me.Label32.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label32.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label32.Location = New System.Drawing.Point(200, 96)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(40, 16)
        Me.Label32.TabIndex = 20
        Me.Label32.Text = ":"
        Me.Label32.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label31
        '
        Me.Label31.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label31.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label31.Location = New System.Drawing.Point(136, 96)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(40, 16)
        Me.Label31.TabIndex = 19
        Me.Label31.Text = ";"
        Me.Label31.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label30
        '
        Me.Label30.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label30.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label30.Location = New System.Drawing.Point(200, 72)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(40, 16)
        Me.Label30.TabIndex = 18
        Me.Label30.Text = "]"
        Me.Label30.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label29
        '
        Me.Label29.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label29.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label29.Location = New System.Drawing.Point(136, 72)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(40, 16)
        Me.Label29.TabIndex = 17
        Me.Label29.Text = "["
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label28
        '
        Me.Label28.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label28.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label28.Location = New System.Drawing.Point(200, 48)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(40, 16)
        Me.Label28.TabIndex = 16
        Me.Label28.Text = "}"
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label27
        '
        Me.Label27.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label27.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label27.Location = New System.Drawing.Point(136, 48)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(40, 16)
        Me.Label27.TabIndex = 15
        Me.Label27.Text = "{"
        Me.Label27.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label26
        '
        Me.Label26.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label26.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label26.Location = New System.Drawing.Point(72, 168)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(40, 16)
        Me.Label26.TabIndex = 14
        Me.Label26.Text = "+"
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label25
        '
        Me.Label25.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label25.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label25.Location = New System.Drawing.Point(72, 144)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(40, 16)
        Me.Label25.TabIndex = 13
        Me.Label25.Text = "="
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label24
        '
        Me.Label24.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label24.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label24.Location = New System.Drawing.Point(72, 120)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(40, 16)
        Me.Label24.TabIndex = 12
        Me.Label24.Text = "_"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label23
        '
        Me.Label23.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label23.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label23.Location = New System.Drawing.Point(72, 96)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(40, 16)
        Me.Label23.TabIndex = 11
        Me.Label23.Text = "-"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label22
        '
        Me.Label22.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label22.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label22.Location = New System.Drawing.Point(72, 72)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(40, 16)
        Me.Label22.TabIndex = 10
        Me.Label22.Text = "*"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label21
        '
        Me.Label21.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label21.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label21.Location = New System.Drawing.Point(72, 48)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(40, 16)
        Me.Label21.TabIndex = 9
        Me.Label21.Text = ")"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label20
        '
        Me.Label20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label20.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label20.Location = New System.Drawing.Point(8, 216)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(40, 16)
        Me.Label20.TabIndex = 8
        Me.Label20.Text = "&&"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label19
        '
        Me.Label19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label19.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label19.Location = New System.Drawing.Point(8, 192)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(40, 16)
        Me.Label19.TabIndex = 7
        Me.Label19.Text = "^"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label18
        '
        Me.Label18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label18.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label18.Location = New System.Drawing.Point(8, 168)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(40, 16)
        Me.Label18.TabIndex = 6
        Me.Label18.Text = "%"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label17
        '
        Me.Label17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label17.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label17.Location = New System.Drawing.Point(8, 144)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(40, 16)
        Me.Label17.TabIndex = 5
        Me.Label17.Text = "$"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label16
        '
        Me.Label16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label16.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label16.Location = New System.Drawing.Point(8, 120)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(40, 16)
        Me.Label16.TabIndex = 4
        Me.Label16.Text = "#"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label15
        '
        Me.Label15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label15.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label15.Location = New System.Drawing.Point(8, 96)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(40, 16)
        Me.Label15.TabIndex = 3
        Me.Label15.Text = "@"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label14
        '
        Me.Label14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label14.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label14.Location = New System.Drawing.Point(8, 72)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(40, 16)
        Me.Label14.TabIndex = 2
        Me.Label14.Text = "!"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label13
        '
        Me.Label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label13.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label13.Location = New System.Drawing.Point(8, 48)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(40, 16)
        Me.Label13.TabIndex = 1
        Me.Label13.Text = "("
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label12
        '
        Me.Label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label12.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label12.Location = New System.Drawing.Point(8, 24)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(232, 16)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "0 1 2 3 4 5 6 7 8 9"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        'DataSet81
        '
        Me.DataSet81.DataSetName = "DataSet8"
        Me.DataSet81.Locale = New System.Globalization.CultureInfo("ru-RU")
        '
        'OleDbSelectCommand2
        '
        Me.OleDbSelectCommand2.CommandText = "SELECT Chrome, FireFox, [id_строка], IExplorer, Opera, phpMyAdminDenwer, Safari, " & _
        "ПутьDenwer, ХостDenwer FROM DENWER"
        Me.OleDbSelectCommand2.Connection = Me.OleDbConnection1
        '
        'OleDbInsertCommand2
        '
        Me.OleDbInsertCommand2.CommandText = "INSERT INTO DENWER(Chrome, FireFox, IExplorer, Opera, phpMyAdminDenwer, Safari, П" & _
        "утьDenwer, ХостDenwer) VALUES (?, ?, ?, ?, ?, ?, ?, ?)"
        Me.OleDbInsertCommand2.Connection = Me.OleDbConnection1
        Me.OleDbInsertCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Chrome", System.Data.OleDb.OleDbType.VarWChar, 255, "Chrome"))
        Me.OleDbInsertCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("FireFox", System.Data.OleDb.OleDbType.VarWChar, 255, "FireFox"))
        Me.OleDbInsertCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("IExplorer", System.Data.OleDb.OleDbType.VarWChar, 255, "IExplorer"))
        Me.OleDbInsertCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Opera", System.Data.OleDb.OleDbType.VarWChar, 255, "Opera"))
        Me.OleDbInsertCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("phpMyAdminDenwer", System.Data.OleDb.OleDbType.VarWChar, 255, "phpMyAdminDenwer"))
        Me.OleDbInsertCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Safari", System.Data.OleDb.OleDbType.VarWChar, 255, "Safari"))
        Me.OleDbInsertCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("ПутьDenwer", System.Data.OleDb.OleDbType.VarWChar, 255, "ПутьDenwer"))
        Me.OleDbInsertCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("ХостDenwer", System.Data.OleDb.OleDbType.VarWChar, 255, "ХостDenwer"))
        '
        'OleDbUpdateCommand2
        '
        Me.OleDbUpdateCommand2.CommandText = "UPDATE DENWER SET Chrome = ?, FireFox = ?, IExplorer = ?, Opera = ?, phpMyAdminDe" & _
        "nwer = ?, Safari = ?, ПутьDenwer = ?, ХостDenwer = ? WHERE ([id_строка] = ?) AND" & _
        " (Chrome = ? OR ? IS NULL AND Chrome IS NULL) AND (FireFox = ? OR ? IS NULL AND " & _
        "FireFox IS NULL) AND (IExplorer = ? OR ? IS NULL AND IExplorer IS NULL) AND (Ope" & _
        "ra = ? OR ? IS NULL AND Opera IS NULL) AND (Safari = ? OR ? IS NULL AND Safari I" & _
        "S NULL) AND (phpMyAdminDenwer = ? OR ? IS NULL AND phpMyAdminDenwer IS NULL) AND" & _
        " (ПутьDenwer = ? OR ? IS NULL AND ПутьDenwer IS NULL) AND (ХостDenwer = ? OR ? I" & _
        "S NULL AND ХостDenwer IS NULL)"
        Me.OleDbUpdateCommand2.Connection = Me.OleDbConnection1
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Chrome", System.Data.OleDb.OleDbType.VarWChar, 255, "Chrome"))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("FireFox", System.Data.OleDb.OleDbType.VarWChar, 255, "FireFox"))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("IExplorer", System.Data.OleDb.OleDbType.VarWChar, 255, "IExplorer"))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Opera", System.Data.OleDb.OleDbType.VarWChar, 255, "Opera"))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("phpMyAdminDenwer", System.Data.OleDb.OleDbType.VarWChar, 255, "phpMyAdminDenwer"))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Safari", System.Data.OleDb.OleDbType.VarWChar, 255, "Safari"))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("ПутьDenwer", System.Data.OleDb.OleDbType.VarWChar, 255, "ПутьDenwer"))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("ХостDenwer", System.Data.OleDb.OleDbType.VarWChar, 255, "ХостDenwer"))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_id_строка", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id_строка", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Chrome", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Chrome", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Chrome1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Chrome", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_FireFox", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FireFox", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_FireFox1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FireFox", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_IExplorer", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IExplorer", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_IExplorer1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IExplorer", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Opera", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Opera", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Opera1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Opera", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Safari", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Safari", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Safari1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Safari", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_phpMyAdminDenwer", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phpMyAdminDenwer", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_phpMyAdminDenwer1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phpMyAdminDenwer", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ПутьDenwer", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ПутьDenwer", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ПутьDenwer1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ПутьDenwer", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ХостDenwer", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ХостDenwer", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ХостDenwer1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ХостDenwer", System.Data.DataRowVersion.Original, Nothing))
        '
        'OleDbDeleteCommand2
        '
        Me.OleDbDeleteCommand2.CommandText = "DELETE FROM DENWER WHERE ([id_строка] = ?) AND (Chrome = ? OR ? IS NULL AND Chrom" & _
        "e IS NULL) AND (FireFox = ? OR ? IS NULL AND FireFox IS NULL) AND (IExplorer = ?" & _
        " OR ? IS NULL AND IExplorer IS NULL) AND (Opera = ? OR ? IS NULL AND Opera IS NU" & _
        "LL) AND (Safari = ? OR ? IS NULL AND Safari IS NULL) AND (phpMyAdminDenwer = ? O" & _
        "R ? IS NULL AND phpMyAdminDenwer IS NULL) AND (ПутьDenwer = ? OR ? IS NULL AND П" & _
        "утьDenwer IS NULL) AND (ХостDenwer = ? OR ? IS NULL AND ХостDenwer IS NULL)"
        Me.OleDbDeleteCommand2.Connection = Me.OleDbConnection1
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_id_строка", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id_строка", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Chrome", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Chrome", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Chrome1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Chrome", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_FireFox", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FireFox", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_FireFox1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FireFox", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_IExplorer", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IExplorer", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_IExplorer1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IExplorer", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Opera", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Opera", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Opera1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Opera", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Safari", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Safari", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Safari1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Safari", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_phpMyAdminDenwer", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phpMyAdminDenwer", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_phpMyAdminDenwer1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phpMyAdminDenwer", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ПутьDenwer", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ПутьDenwer", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ПутьDenwer1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ПутьDenwer", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ХостDenwer", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ХостDenwer", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ХостDenwer1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ХостDenwer", System.Data.DataRowVersion.Original, Nothing))
        '
        'OleDbDataAdapter2
        '
        Me.OleDbDataAdapter2.DeleteCommand = Me.OleDbDeleteCommand2
        Me.OleDbDataAdapter2.InsertCommand = Me.OleDbInsertCommand2
        Me.OleDbDataAdapter2.SelectCommand = Me.OleDbSelectCommand2
        Me.OleDbDataAdapter2.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "DENWER", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Chrome", "Chrome"), New System.Data.Common.DataColumnMapping("FireFox", "FireFox"), New System.Data.Common.DataColumnMapping("id_строка", "id_строка"), New System.Data.Common.DataColumnMapping("IExplorer", "IExplorer"), New System.Data.Common.DataColumnMapping("Opera", "Opera"), New System.Data.Common.DataColumnMapping("phpMyAdminDenwer", "phpMyAdminDenwer"), New System.Data.Common.DataColumnMapping("Safari", "Safari"), New System.Data.Common.DataColumnMapping("ПутьDenwer", "ПутьDenwer"), New System.Data.Common.DataColumnMapping("ХостDenwer", "ХостDenwer")})})
        Me.OleDbDataAdapter2.UpdateCommand = Me.OleDbUpdateCommand2
        '
        'DataSet91
        '
        Me.DataSet91.DataSetName = "DataSet9"
        Me.DataSet91.Locale = New System.Globalization.CultureInfo("ru-RU")
        '
        'OleDbSelectCommand3
        '
        Me.OleDbSelectCommand3.CommandText = "SELECT [id_строка], СпецСимвол, Цвет FROM СпецСимволы"
        Me.OleDbSelectCommand3.Connection = Me.OleDbConnection1
        '
        'OleDbInsertCommand3
        '
        Me.OleDbInsertCommand3.CommandText = "INSERT INTO СпецСимволы(СпецСимвол, Цвет) VALUES (?, ?)"
        Me.OleDbInsertCommand3.Connection = Me.OleDbConnection1
        Me.OleDbInsertCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("СпецСимвол", System.Data.OleDb.OleDbType.VarWChar, 255, "СпецСимвол"))
        Me.OleDbInsertCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Цвет", System.Data.OleDb.OleDbType.Integer, 0, "Цвет"))
        '
        'OleDbUpdateCommand3
        '
        Me.OleDbUpdateCommand3.CommandText = "UPDATE СпецСимволы SET СпецСимвол = ?, Цвет = ? WHERE ([id_строка] = ?) AND (Спец" & _
        "Символ = ? OR ? IS NULL AND СпецСимвол IS NULL) AND (Цвет = ? OR ? IS NULL AND Ц" & _
        "вет IS NULL)"
        Me.OleDbUpdateCommand3.Connection = Me.OleDbConnection1
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("СпецСимвол", System.Data.OleDb.OleDbType.VarWChar, 255, "СпецСимвол"))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Цвет", System.Data.OleDb.OleDbType.Integer, 0, "Цвет"))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_id_строка", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id_строка", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_СпецСимвол", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "СпецСимвол", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_СпецСимвол1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "СпецСимвол", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Цвет", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Цвет", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Цвет1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Цвет", System.Data.DataRowVersion.Original, Nothing))
        '
        'OleDbDeleteCommand3
        '
        Me.OleDbDeleteCommand3.CommandText = "DELETE FROM СпецСимволы WHERE ([id_строка] = ?) AND (СпецСимвол = ? OR ? IS NULL " & _
        "AND СпецСимвол IS NULL) AND (Цвет = ? OR ? IS NULL AND Цвет IS NULL)"
        Me.OleDbDeleteCommand3.Connection = Me.OleDbConnection1
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_id_строка", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id_строка", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_СпецСимвол", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "СпецСимвол", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_СпецСимвол1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "СпецСимвол", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Цвет", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Цвет", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Цвет1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Цвет", System.Data.DataRowVersion.Original, Nothing))
        '
        'OleDbDataAdapter3
        '
        Me.OleDbDataAdapter3.DeleteCommand = Me.OleDbDeleteCommand3
        Me.OleDbDataAdapter3.InsertCommand = Me.OleDbInsertCommand3
        Me.OleDbDataAdapter3.SelectCommand = Me.OleDbSelectCommand3
        Me.OleDbDataAdapter3.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "СпецСимволы", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id_строка", "id_строка"), New System.Data.Common.DataColumnMapping("СпецСимвол", "СпецСимвол"), New System.Data.Common.DataColumnMapping("Цвет", "Цвет")})})
        Me.OleDbDataAdapter3.UpdateCommand = Me.OleDbUpdateCommand3
        '
        'DataSet101
        '
        Me.DataSet101.DataSetName = "DataSet10"
        Me.DataSet101.Locale = New System.Globalization.CultureInfo("ru-RU")
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.Filter = "iexplore.exe|iexplore.exe|*.exe|*.exe"
        '
        'OpenFileDialog2
        '
        Me.OpenFileDialog2.Filter = "opera.exe|opera.exe|*.exe|*.exe"
        '
        'OpenFileDialog3
        '
        Me.OpenFileDialog3.Filter = "firefox.exe|firefox.exe|*.exe|*.exe"
        '
        'OpenFileDialog4
        '
        Me.OpenFileDialog4.Filter = "chrome.exe|chrome.exe|*.exe|*.exe"
        '
        'OpenFileDialog5
        '
        Me.OpenFileDialog5.Filter = "Safari.exe|Safari.exe|*.exe|*.exe"
        '
        'Settings
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(416, 374)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Settings"
        Me.Text = "Настройки"
        Me.Panel1.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.DataSet81, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet91, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet101, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Close()
    End Sub

    Private Sub Settings_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            ModulePE.SettingsShow = True
            OleDbConnection1.ConnectionString = ModuleBase.StringConnection
            OleDbConnection1.Open()
            OleDbDataAdapter1.Fill(DataSet81, "Настройки")
            TextBox1.Text = DataSet81.Настройки.Item(0)("ИмяШрифта")
            TextBox2.Text = DataSet81.Настройки.Item(0)("РазмерШрифта")
            If (DataSet81.Настройки.Item(0)("ФорматированиеМодуля") = 1) Then
                CheckBox3.Checked = True
            Else
                CheckBox3.Checked = False
            End If
            RichTextBox1.Font = ModulePE.FontModule
            '---------------------------------------
            OleDbDataAdapter2.Fill(DataSet91, "DENWER")
            TextBox3.Text = DataSet91.DENWER.Item(0)("ПутьDenwer")
            TextBox4.Text = DataSet91.DENWER.Item(0)("ХостDenwer")
            TextBox5.Text = DataSet91.DENWER.Item(0)("phpMyAdminDenwer")

            TextBox6.Text = DataSet91.DENWER.Item(0)("IExplorer")
            TextBox7.Text = DataSet91.DENWER.Item(0)("Opera")
            TextBox8.Text = DataSet91.DENWER.Item(0)("FireFox")
            TextBox9.Text = DataSet91.DENWER.Item(0)("Chrome")
            TextBox10.Text = DataSet91.DENWER.Item(0)("Safari")
            '---------------------------------------
            OleDbDataAdapter3.Fill(DataSet101, "СпецСимволы")
            Label12.Tag = DataSet101.СпецСимволы.Item(0)("Цвет")
            Label12.ForeColor = Color.FromArgb(Label12.Tag)
            Label13.Tag = DataSet101.СпецСимволы.Item(1)("Цвет")
            Label13.ForeColor = Color.FromArgb(Label13.Tag)
            Label14.Tag = DataSet101.СпецСимволы.Item(2)("Цвет")
            Label14.ForeColor = Color.FromArgb(Label14.Tag)
            Label15.Tag = DataSet101.СпецСимволы.Item(3)("Цвет")
            Label15.ForeColor = Color.FromArgb(Label15.Tag)
            Label16.Tag = DataSet101.СпецСимволы.Item(4)("Цвет")
            Label16.ForeColor = Color.FromArgb(Label16.Tag)
            Label17.Tag = DataSet101.СпецСимволы.Item(5)("Цвет")
            Label17.ForeColor = Color.FromArgb(Label17.Tag)
            Label18.Tag = DataSet101.СпецСимволы.Item(6)("Цвет")
            Label18.ForeColor = Color.FromArgb(Label18.Tag)
            Label19.Tag = DataSet101.СпецСимволы.Item(7)("Цвет")
            Label19.ForeColor = Color.FromArgb(Label19.Tag)
            Label20.Tag = DataSet101.СпецСимволы.Item(8)("Цвет")
            Label20.ForeColor = Color.FromArgb(Label20.Tag)
            Label21.Tag = DataSet101.СпецСимволы.Item(9)("Цвет")
            Label21.ForeColor = Color.FromArgb(Label21.Tag)
            Label22.Tag = DataSet101.СпецСимволы.Item(10)("Цвет")
            Label22.ForeColor = Color.FromArgb(Label22.Tag)
            Label23.Tag = DataSet101.СпецСимволы.Item(11)("Цвет")
            Label23.ForeColor = Color.FromArgb(Label23.Tag)
            Label24.Tag = DataSet101.СпецСимволы.Item(12)("Цвет")
            Label24.ForeColor = Color.FromArgb(Label24.Tag)
            Label25.Tag = DataSet101.СпецСимволы.Item(13)("Цвет")
            Label25.ForeColor = Color.FromArgb(Label25.Tag)
            Label26.Tag = DataSet101.СпецСимволы.Item(14)("Цвет")
            Label26.ForeColor = Color.FromArgb(Label26.Tag)
            Label37.Tag = DataSet101.СпецСимволы.Item(15)("Цвет")
            Label37.ForeColor = Color.FromArgb(Label37.Tag)
            Label42.Tag = DataSet101.СпецСимволы.Item(16)("Цвет")
            Label42.ForeColor = Color.FromArgb(Label42.Tag)
            Label27.Tag = DataSet101.СпецСимволы.Item(17)("Цвет")
            Label27.ForeColor = Color.FromArgb(Label27.Tag)
            Label29.Tag = DataSet101.СпецСимволы.Item(18)("Цвет")
            Label29.ForeColor = Color.FromArgb(Label29.Tag)
            Label31.Tag = DataSet101.СпецСимволы.Item(19)("Цвет")
            Label31.ForeColor = Color.FromArgb(Label31.Tag)
            Label33.Tag = DataSet101.СпецСимволы.Item(20)("Цвет")
            Label33.ForeColor = Color.FromArgb(Label33.Tag)
            Label35.Tag = DataSet101.СпецСимволы.Item(21)("Цвет")
            Label35.ForeColor = Color.FromArgb(Label35.Tag)
            Label38.Tag = DataSet101.СпецСимволы.Item(22)("Цвет")
            Label38.ForeColor = Color.FromArgb(Label38.Tag)
            Label40.Tag = DataSet101.СпецСимволы.Item(23)("Цвет")
            Label40.ForeColor = Color.FromArgb(Label40.Tag)
            Label28.Tag = DataSet101.СпецСимволы.Item(24)("Цвет")
            Label28.ForeColor = Color.FromArgb(Label28.Tag)
            Label30.Tag = DataSet101.СпецСимволы.Item(25)("Цвет")
            Label30.ForeColor = Color.FromArgb(Label30.Tag)
            Label32.Tag = DataSet101.СпецСимволы.Item(26)("Цвет")
            Label32.ForeColor = Color.FromArgb(Label32.Tag)
            Label34.Tag = DataSet101.СпецСимволы.Item(27)("Цвет")
            Label34.ForeColor = Color.FromArgb(Label34.Tag)
            Label36.Tag = DataSet101.СпецСимволы.Item(28)("Цвет")
            Label36.ForeColor = Color.FromArgb(Label36.Tag)
            Label39.Tag = DataSet101.СпецСимволы.Item(29)("Цвет")
            Label39.ForeColor = Color.FromArgb(Label39.Tag)
            Label41.Tag = DataSet101.СпецСимволы.Item(30)("Цвет")
            Label41.ForeColor = Color.FromArgb(Label41.Tag)
            OleDbConnection1.Close()
        Catch ex As Exception
            Close()
        End Try
    End Sub

    Private Sub Settings_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        Try
            ModulePE.SettingsShow = False
            OleDbConnection1.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            Dim SizeFont As Integer
            SizeFont = TextBox2.Text
            ModulePE.FontModule = New Font(TextBox1.Text, SizeFont, FontStyle.Regular)
            OleDbConnection1.Open()
            DataSet81.Настройки.Item(0)("ИмяШрифта") = TextBox1.Text
            DataSet81.Настройки.Item(0)("РазмерШрифта") = TextBox2.Text
            If CheckBox3.Checked = True Then
                DataSet81.Настройки.Item(0)("ФорматированиеМодуля") = 1
                ModulePE.ActionModuleFormat = True
                Me.TopMost = True
            Else
                DataSet81.Настройки.Item(0)("ФорматированиеМодуля") = 0
                ModulePE.ActionModuleFormat = False
                Me.TopMost = False
            End If
            OleDbDataAdapter1.Update(DataSet81, "Настройки")
            '----------------------------------------------
            DataSet91.DENWER.Item(0)("ПутьDenwer") = TextBox3.Text
            DataSet91.DENWER.Item(0)("ХостDenwer") = TextBox4.Text
            DataSet91.DENWER.Item(0)("phpMyAdminDenwer") = TextBox5.Text

            DataSet91.DENWER.Item(0)("IExplorer") = TextBox6.Text
            DataSet91.DENWER.Item(0)("Opera") = TextBox7.Text
            DataSet91.DENWER.Item(0)("FireFox") = TextBox8.Text
            DataSet91.DENWER.Item(0)("Chrome") = TextBox9.Text
            DataSet91.DENWER.Item(0)("Safari") = TextBox10.Text

            ModulePE.DENWER_Path = TextBox3.Text
            ModulePE.DENWER_host = TextBox4.Text
            ModulePE.DENWER_MyPhpAdmin = TextBox5.Text

            ModulePE.IExplorer = TextBox6.Text
            ModulePE.Opera = TextBox7.Text
            ModulePE.FireFox = TextBox8.Text
            ModulePE.Chrome = TextBox9.Text
            ModulePE.Safari = TextBox10.Text
            OleDbDataAdapter2.Update(DataSet91, "DENWER")
            '----------------------------------------------
            ModulePE.Color01 = Label12.Tag
            ModulePE.Color02 = Label13.Tag
            ModulePE.Color03 = Label14.Tag
            ModulePE.Color04 = Label15.Tag
            ModulePE.Color05 = Label16.Tag
            ModulePE.Color06 = Label17.Tag
            ModulePE.Color07 = Label18.Tag
            ModulePE.Color08 = Label19.Tag
            ModulePE.Color09 = Label20.Tag
            ModulePE.Color10 = Label21.Tag
            ModulePE.Color11 = Label22.Tag
            ModulePE.Color12 = Label23.Tag
            ModulePE.Color13 = Label24.Tag
            ModulePE.Color14 = Label25.Tag
            ModulePE.Color15 = Label26.Tag
            ModulePE.Color16 = Label37.Tag
            ModulePE.Color17 = Label42.Tag
            ModulePE.Color18 = Label27.Tag
            ModulePE.Color19 = Label29.Tag
            ModulePE.Color20 = Label31.Tag
            ModulePE.Color21 = Label33.Tag
            ModulePE.Color22 = Label35.Tag
            ModulePE.Color23 = Label38.Tag
            ModulePE.Color24 = Label40.Tag
            ModulePE.Color25 = Label28.Tag
            ModulePE.Color26 = Label30.Tag
            ModulePE.Color27 = Label32.Tag
            ModulePE.Color28 = Label34.Tag
            ModulePE.Color29 = Label36.Tag
            ModulePE.Color30 = Label39.Tag
            ModulePE.Color31 = Label41.Tag

            DataSet101.СпецСимволы.Item(0)("Цвет") = ModulePE.Color01
            DataSet101.СпецСимволы.Item(1)("Цвет") = ModulePE.Color02
            DataSet101.СпецСимволы.Item(2)("Цвет") = ModulePE.Color03
            DataSet101.СпецСимволы.Item(3)("Цвет") = ModulePE.Color04
            DataSet101.СпецСимволы.Item(4)("Цвет") = ModulePE.Color05
            DataSet101.СпецСимволы.Item(5)("Цвет") = ModulePE.Color06
            DataSet101.СпецСимволы.Item(6)("Цвет") = ModulePE.Color07
            DataSet101.СпецСимволы.Item(7)("Цвет") = ModulePE.Color08
            DataSet101.СпецСимволы.Item(8)("Цвет") = ModulePE.Color09
            DataSet101.СпецСимволы.Item(9)("Цвет") = ModulePE.Color10
            DataSet101.СпецСимволы.Item(10)("Цвет") = ModulePE.Color11
            DataSet101.СпецСимволы.Item(11)("Цвет") = ModulePE.Color12
            DataSet101.СпецСимволы.Item(12)("Цвет") = ModulePE.Color13
            DataSet101.СпецСимволы.Item(13)("Цвет") = ModulePE.Color14
            DataSet101.СпецСимволы.Item(14)("Цвет") = ModulePE.Color15
            DataSet101.СпецСимволы.Item(15)("Цвет") = ModulePE.Color16
            DataSet101.СпецСимволы.Item(16)("Цвет") = ModulePE.Color17
            DataSet101.СпецСимволы.Item(17)("Цвет") = ModulePE.Color18
            DataSet101.СпецСимволы.Item(18)("Цвет") = ModulePE.Color19
            DataSet101.СпецСимволы.Item(19)("Цвет") = ModulePE.Color20
            DataSet101.СпецСимволы.Item(20)("Цвет") = ModulePE.Color21
            DataSet101.СпецСимволы.Item(21)("Цвет") = ModulePE.Color22
            DataSet101.СпецСимволы.Item(22)("Цвет") = ModulePE.Color23
            DataSet101.СпецСимволы.Item(23)("Цвет") = ModulePE.Color24
            DataSet101.СпецСимволы.Item(24)("Цвет") = ModulePE.Color25
            DataSet101.СпецСимволы.Item(25)("Цвет") = ModulePE.Color26
            DataSet101.СпецСимволы.Item(26)("Цвет") = ModulePE.Color27
            DataSet101.СпецСимволы.Item(27)("Цвет") = ModulePE.Color28
            DataSet101.СпецСимволы.Item(28)("Цвет") = ModulePE.Color29
            DataSet101.СпецСимволы.Item(29)("Цвет") = ModulePE.Color30
            DataSet101.СпецСимволы.Item(30)("Цвет") = ModulePE.Color31
            OleDbDataAdapter3.Update(DataSet101, "СпецСимволы")
            '----------------------------------------------
            OleDbConnection1.Close()
            Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If (FontDialog1.ShowDialog = DialogResult.OK) Then
            TextBox1.Text = FontDialog1.Font.Name
            TextBox2.Text = FontDialog1.Font.Size
            RichTextBox1.Font = New Font(FontDialog1.Font.Name, FontDialog1.Font.Size, FontStyle.Regular)
        End If
    End Sub

    Private Sub Label12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label12.Click
        If (ColorDialog1.ShowDialog = DialogResult.OK) Then
            Label12.Tag = ColorDialog1.Color.ToArgb
            Label12.ForeColor = Color.FromArgb(Label12.Tag)
        End If
    End Sub

    Private Sub Label13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label13.Click
        If (ColorDialog1.ShowDialog = DialogResult.OK) Then
            Label13.Tag = ColorDialog1.Color.ToArgb
            Label13.ForeColor = Color.FromArgb(Label13.Tag)
        End If
    End Sub

    Private Sub Label14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label14.Click
        If (ColorDialog1.ShowDialog = DialogResult.OK) Then
            Label14.Tag = ColorDialog1.Color.ToArgb
            Label14.ForeColor = Color.FromArgb(Label14.Tag)
        End If
    End Sub

    Private Sub Label15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label15.Click
        If (ColorDialog1.ShowDialog = DialogResult.OK) Then
            Label15.Tag = ColorDialog1.Color.ToArgb
            Label15.ForeColor = Color.FromArgb(Label15.Tag)
        End If
    End Sub

    Private Sub Label16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label16.Click
        If (ColorDialog1.ShowDialog = DialogResult.OK) Then
            Label16.Tag = ColorDialog1.Color.ToArgb
            Label16.ForeColor = Color.FromArgb(Label16.Tag)
        End If
    End Sub

    Private Sub Label17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label17.Click
        If (ColorDialog1.ShowDialog = DialogResult.OK) Then
            Label17.Tag = ColorDialog1.Color.ToArgb
            Label17.ForeColor = Color.FromArgb(Label17.Tag)
        End If
    End Sub

    Private Sub Label18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label18.Click
        If (ColorDialog1.ShowDialog = DialogResult.OK) Then
            Label18.Tag = ColorDialog1.Color.ToArgb
            Label18.ForeColor = Color.FromArgb(Label18.Tag)
        End If
    End Sub

    Private Sub Label19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label19.Click
        If (ColorDialog1.ShowDialog = DialogResult.OK) Then
            Label19.Tag = ColorDialog1.Color.ToArgb
            Label19.ForeColor = Color.FromArgb(Label19.Tag)
        End If
    End Sub

    Private Sub Label20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label20.Click
        If (ColorDialog1.ShowDialog = DialogResult.OK) Then
            Label20.Tag = ColorDialog1.Color.ToArgb
            Label20.ForeColor = Color.FromArgb(Label20.Tag)
        End If
    End Sub

    Private Sub Label21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label21.Click
        If (ColorDialog1.ShowDialog = DialogResult.OK) Then
            Label21.Tag = ColorDialog1.Color.ToArgb
            Label21.ForeColor = Color.FromArgb(Label21.Tag)
        End If
    End Sub

    Private Sub Label22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label22.Click
        If (ColorDialog1.ShowDialog = DialogResult.OK) Then
            Label22.Tag = ColorDialog1.Color.ToArgb
            Label22.ForeColor = Color.FromArgb(Label22.Tag)
        End If
    End Sub

    Private Sub Label23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label23.Click
        If (ColorDialog1.ShowDialog = DialogResult.OK) Then
            Label23.Tag = ColorDialog1.Color.ToArgb
            Label23.ForeColor = Color.FromArgb(Label23.Tag)
        End If
    End Sub

    Private Sub Label24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label24.Click
        If (ColorDialog1.ShowDialog = DialogResult.OK) Then
            Label24.Tag = ColorDialog1.Color.ToArgb
            Label24.ForeColor = Color.FromArgb(Label24.Tag)
        End If
    End Sub

    Private Sub Label25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label25.Click
        If (ColorDialog1.ShowDialog = DialogResult.OK) Then
            Label25.Tag = ColorDialog1.Color.ToArgb
            Label25.ForeColor = Color.FromArgb(Label25.Tag)
        End If
    End Sub

    Private Sub Label26_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label26.Click
        If (ColorDialog1.ShowDialog = DialogResult.OK) Then
            Label26.Tag = ColorDialog1.Color.ToArgb
            Label26.ForeColor = Color.FromArgb(Label26.Tag)
        End If
    End Sub

    Private Sub Label37_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label37.Click
        If (ColorDialog1.ShowDialog = DialogResult.OK) Then
            Label37.Tag = ColorDialog1.Color.ToArgb
            Label37.ForeColor = Color.FromArgb(Label37.Tag)
        End If
    End Sub

    Private Sub Label42_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label42.Click
        If (ColorDialog1.ShowDialog = DialogResult.OK) Then
            Label42.Tag = ColorDialog1.Color.ToArgb
            Label42.ForeColor = Color.FromArgb(Label42.Tag)
        End If
    End Sub

    Private Sub Label27_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label27.Click
        If (ColorDialog1.ShowDialog = DialogResult.OK) Then
            Label27.Tag = ColorDialog1.Color.ToArgb
            Label27.ForeColor = Color.FromArgb(Label27.Tag)
        End If
    End Sub

    Private Sub Label29_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label29.Click
        If (ColorDialog1.ShowDialog = DialogResult.OK) Then
            Label29.Tag = ColorDialog1.Color.ToArgb
            Label29.ForeColor = Color.FromArgb(Label29.Tag)
        End If
    End Sub

    Private Sub Label31_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label31.Click
        If (ColorDialog1.ShowDialog = DialogResult.OK) Then
            Label31.Tag = ColorDialog1.Color.ToArgb
            Label31.ForeColor = Color.FromArgb(Label31.Tag)
        End If
    End Sub

    Private Sub Label33_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label33.Click
        If (ColorDialog1.ShowDialog = DialogResult.OK) Then
            Label33.Tag = ColorDialog1.Color.ToArgb
            Label33.ForeColor = Color.FromArgb(Label33.Tag)
        End If
    End Sub

    Private Sub Label35_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label35.Click
        If (ColorDialog1.ShowDialog = DialogResult.OK) Then
            Label35.Tag = ColorDialog1.Color.ToArgb
            Label35.ForeColor = Color.FromArgb(Label35.Tag)
        End If
    End Sub

    Private Sub Label38_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label38.Click
        If (ColorDialog1.ShowDialog = DialogResult.OK) Then
            Label38.Tag = ColorDialog1.Color.ToArgb
            Label38.ForeColor = Color.FromArgb(Label38.Tag)
        End If
    End Sub

    Private Sub Label40_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label40.Click
        If (ColorDialog1.ShowDialog = DialogResult.OK) Then
            Label40.Tag = ColorDialog1.Color.ToArgb
            Label40.ForeColor = Color.FromArgb(Label40.Tag)
        End If
    End Sub

    Private Sub Label28_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label28.Click
        If (ColorDialog1.ShowDialog = DialogResult.OK) Then
            Label28.Tag = ColorDialog1.Color.ToArgb
            Label28.ForeColor = Color.FromArgb(Label28.Tag)
        End If
    End Sub

    Private Sub Label30_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label30.Click
        If (ColorDialog1.ShowDialog = DialogResult.OK) Then
            Label30.Tag = ColorDialog1.Color.ToArgb
            Label30.ForeColor = Color.FromArgb(Label30.Tag)
        End If
    End Sub

    Private Sub Label32_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label32.Click
        If (ColorDialog1.ShowDialog = DialogResult.OK) Then
            Label32.Tag = ColorDialog1.Color.ToArgb
            Label32.ForeColor = Color.FromArgb(Label32.Tag)
        End If
    End Sub

    Private Sub Label34_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label34.Click
        If (ColorDialog1.ShowDialog = DialogResult.OK) Then
            Label34.Tag = ColorDialog1.Color.ToArgb
            Label34.ForeColor = Color.FromArgb(Label34.Tag)
        End If
    End Sub

    Private Sub Label36_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label36.Click
        If (ColorDialog1.ShowDialog = DialogResult.OK) Then
            Label36.Tag = ColorDialog1.Color.ToArgb
            Label36.ForeColor = Color.FromArgb(Label36.Tag)
        End If
    End Sub

    Private Sub Label39_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label39.Click
        If (ColorDialog1.ShowDialog = DialogResult.OK) Then
            Label39.Tag = ColorDialog1.Color.ToArgb
            Label39.ForeColor = Color.FromArgb(Label39.Tag)
        End If
    End Sub

    Private Sub Label41_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label41.Click
        If (ColorDialog1.ShowDialog = DialogResult.OK) Then
            Label41.Tag = ColorDialog1.Color.ToArgb
            Label41.ForeColor = Color.FromArgb(Label41.Tag)
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If (FolderBrowserDialog1.ShowDialog = DialogResult.OK) Then
            TextBox3.Text = FolderBrowserDialog1.SelectedPath
        End If
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        TextBox4.Text = "http://localhost/"
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        TextBox5.Text = "http://localhost/Tools/phpMyAdmin/"
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        If (OpenFileDialog1.ShowDialog = DialogResult.OK) Then
            TextBox6.Text = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        If (OpenFileDialog2.ShowDialog = DialogResult.OK) Then
            TextBox7.Text = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        If (OpenFileDialog3.ShowDialog = DialogResult.OK) Then
            TextBox8.Text = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        If (OpenFileDialog4.ShowDialog = DialogResult.OK) Then
            TextBox9.Text = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        If (OpenFileDialog5.ShowDialog = DialogResult.OK) Then
            TextBox10.Text = OpenFileDialog1.FileName
        End If
    End Sub
End Class
