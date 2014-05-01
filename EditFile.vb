Imports System.IO
Imports System.Text
Public Class EditFile
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
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton3 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton4 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton5 As System.Windows.Forms.RadioButton
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents StatusBar1 As System.Windows.Forms.StatusBar
    Friend WithEvents StatusBarPanel1 As System.Windows.Forms.StatusBarPanel
    Friend WithEvents StatusBarPanel2 As System.Windows.Forms.StatusBarPanel
    Friend WithEvents StatusBarPanel3 As System.Windows.Forms.StatusBarPanel
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents RadioButton6 As System.Windows.Forms.RadioButton
    Friend WithEvents RichTextBox2 As System.Windows.Forms.RichTextBox
    Friend WithEvents ImageList2 As System.Windows.Forms.ImageList
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents FontDialog1 As System.Windows.Forms.FontDialog
    Friend WithEvents ColorDialog1 As System.Windows.Forms.ColorDialog
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents ContextMenu1 As System.Windows.Forms.ContextMenu
    Friend WithEvents MenuItem61 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem62 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem63 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem64 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem65 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem66 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem135 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem134 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem71 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem87 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem89 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem88 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem133 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem90 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem91 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem92 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem93 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem98 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem94 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem95 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem96 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem202 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem234 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem203 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem204 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem205 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem206 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem207 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem79 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem80 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem81 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem82 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem72 As System.Windows.Forms.MenuItem
    Friend WithEvents RadioButton7 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton8 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton9 As System.Windows.Forms.RadioButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
    Friend WithEvents StatusBarPanel4 As System.Windows.Forms.StatusBarPanel
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(EditFile))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label2 = New System.Windows.Forms.Label
        Me.ImageList2 = New System.Windows.Forms.ImageList(Me.components)
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.RadioButton6 = New System.Windows.Forms.RadioButton
        Me.RadioButton5 = New System.Windows.Forms.RadioButton
        Me.RadioButton4 = New System.Windows.Forms.RadioButton
        Me.RadioButton3 = New System.Windows.Forms.RadioButton
        Me.RadioButton2 = New System.Windows.Forms.RadioButton
        Me.RadioButton1 = New System.Windows.Forms.RadioButton
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.StatusBar1 = New System.Windows.Forms.StatusBar
        Me.StatusBarPanel1 = New System.Windows.Forms.StatusBarPanel
        Me.StatusBarPanel2 = New System.Windows.Forms.StatusBarPanel
        Me.StatusBarPanel3 = New System.Windows.Forms.StatusBarPanel
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox
        Me.ContextMenu1 = New System.Windows.Forms.ContextMenu
        Me.MenuItem61 = New System.Windows.Forms.MenuItem
        Me.MenuItem62 = New System.Windows.Forms.MenuItem
        Me.MenuItem63 = New System.Windows.Forms.MenuItem
        Me.MenuItem64 = New System.Windows.Forms.MenuItem
        Me.MenuItem65 = New System.Windows.Forms.MenuItem
        Me.MenuItem66 = New System.Windows.Forms.MenuItem
        Me.MenuItem135 = New System.Windows.Forms.MenuItem
        Me.MenuItem134 = New System.Windows.Forms.MenuItem
        Me.MenuItem71 = New System.Windows.Forms.MenuItem
        Me.MenuItem87 = New System.Windows.Forms.MenuItem
        Me.MenuItem89 = New System.Windows.Forms.MenuItem
        Me.MenuItem88 = New System.Windows.Forms.MenuItem
        Me.MenuItem133 = New System.Windows.Forms.MenuItem
        Me.MenuItem90 = New System.Windows.Forms.MenuItem
        Me.MenuItem91 = New System.Windows.Forms.MenuItem
        Me.MenuItem92 = New System.Windows.Forms.MenuItem
        Me.MenuItem93 = New System.Windows.Forms.MenuItem
        Me.MenuItem98 = New System.Windows.Forms.MenuItem
        Me.MenuItem94 = New System.Windows.Forms.MenuItem
        Me.MenuItem95 = New System.Windows.Forms.MenuItem
        Me.MenuItem96 = New System.Windows.Forms.MenuItem
        Me.MenuItem202 = New System.Windows.Forms.MenuItem
        Me.MenuItem234 = New System.Windows.Forms.MenuItem
        Me.MenuItem203 = New System.Windows.Forms.MenuItem
        Me.MenuItem204 = New System.Windows.Forms.MenuItem
        Me.MenuItem205 = New System.Windows.Forms.MenuItem
        Me.MenuItem206 = New System.Windows.Forms.MenuItem
        Me.MenuItem207 = New System.Windows.Forms.MenuItem
        Me.MenuItem1 = New System.Windows.Forms.MenuItem
        Me.MenuItem2 = New System.Windows.Forms.MenuItem
        Me.MenuItem3 = New System.Windows.Forms.MenuItem
        Me.MenuItem79 = New System.Windows.Forms.MenuItem
        Me.MenuItem80 = New System.Windows.Forms.MenuItem
        Me.MenuItem81 = New System.Windows.Forms.MenuItem
        Me.MenuItem82 = New System.Windows.Forms.MenuItem
        Me.MenuItem72 = New System.Windows.Forms.MenuItem
        Me.Panel6 = New System.Windows.Forms.Panel
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.ListBox1 = New System.Windows.Forms.ListBox
        Me.RichTextBox2 = New System.Windows.Forms.RichTextBox
        Me.FontDialog1 = New System.Windows.Forms.FontDialog
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.RadioButton7 = New System.Windows.Forms.RadioButton
        Me.RadioButton8 = New System.Windows.Forms.RadioButton
        Me.RadioButton9 = New System.Windows.Forms.RadioButton
        Me.StatusBarPanel4 = New System.Windows.Forms.StatusBarPanel
        Me.Panel1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.StatusBarPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StatusBarPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StatusBarPanel3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        CType(Me.StatusBarPanel4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(464, 48)
        Me.Panel1.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label2.ImageIndex = 12
        Me.Label2.ImageList = Me.ImageList2
        Me.Label2.Location = New System.Drawing.Point(8, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 32)
        Me.Label2.TabIndex = 14
        Me.ToolTip1.SetToolTip(Me.Label2, "Сохранить файл.")
        '
        'ImageList2
        '
        Me.ImageList2.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit
        Me.ImageList2.ImageSize = New System.Drawing.Size(24, 20)
        Me.ImageList2.ImageStream = CType(resources.GetObject("ImageList2.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList2.TransparentColor = System.Drawing.Color.Transparent
        '
        'Label11
        '
        Me.Label11.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label11.ImageIndex = 17
        Me.Label11.ImageList = Me.ImageList2
        Me.Label11.Location = New System.Drawing.Point(48, 7)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(32, 32)
        Me.Label11.TabIndex = 12
        Me.ToolTip1.SetToolTip(Me.Label11, "Выполнить.")
        '
        'Label3
        '
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label3.Image = CType(resources.GetObject("Label3.Image"), System.Drawing.Image)
        Me.Label3.Location = New System.Drawing.Point(88, 7)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 32)
        Me.Label3.TabIndex = 13
        Me.ToolTip1.SetToolTip(Me.Label3, "Цветовая гамма.")
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Image = CType(resources.GetObject("Label1.Image"), System.Drawing.Image)
        Me.Label1.Location = New System.Drawing.Point(280, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(184, 48)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Страница"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'RadioButton6
        '
        Me.RadioButton6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.RadioButton6.Location = New System.Drawing.Point(192, 336)
        Me.RadioButton6.Name = "RadioButton6"
        Me.RadioButton6.Size = New System.Drawing.Size(80, 24)
        Me.RadioButton6.TabIndex = 6
        Me.RadioButton6.Text = "js и jQuery"
        '
        'RadioButton5
        '
        Me.RadioButton5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadioButton5.Location = New System.Drawing.Point(416, 336)
        Me.RadioButton5.Name = "RadioButton5"
        Me.RadioButton5.Size = New System.Drawing.Size(48, 24)
        Me.RadioButton5.TabIndex = 5
        Me.RadioButton5.Text = "Все"
        '
        'RadioButton4
        '
        Me.RadioButton4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.RadioButton4.Location = New System.Drawing.Point(136, 336)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(56, 24)
        Me.RadioButton4.TabIndex = 4
        Me.RadioButton4.Text = "jQuery"
        '
        'RadioButton3
        '
        Me.RadioButton3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.RadioButton3.Location = New System.Drawing.Point(96, 336)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(40, 24)
        Me.RadioButton3.TabIndex = 3
        Me.RadioButton3.Text = "js"
        '
        'RadioButton2
        '
        Me.RadioButton2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.RadioButton2.Location = New System.Drawing.Point(48, 336)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(48, 24)
        Me.RadioButton2.TabIndex = 2
        Me.RadioButton2.Text = "css"
        '
        'RadioButton1
        '
        Me.RadioButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.RadioButton1.Location = New System.Drawing.Point(0, 336)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(48, 24)
        Me.RadioButton1.TabIndex = 1
        Me.RadioButton1.Text = "html"
        '
        'Panel4
        '
        Me.Panel4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel4.BackColor = System.Drawing.Color.White
        Me.Panel4.Controls.Add(Me.TextBox1)
        Me.Panel4.Controls.Add(Me.Button1)
        Me.Panel4.Location = New System.Drawing.Point(0, 48)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(464, 32)
        Me.Panel4.TabIndex = 18
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.Location = New System.Drawing.Point(2, 5)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(392, 20)
        Me.TextBox1.TabIndex = 12
        Me.TextBox1.Text = ""
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(399, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(64, 23)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "Поиск"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'StatusBar1
        '
        Me.StatusBar1.Location = New System.Drawing.Point(0, 358)
        Me.StatusBar1.Name = "StatusBar1"
        Me.StatusBar1.Panels.AddRange(New System.Windows.Forms.StatusBarPanel() {Me.StatusBarPanel1, Me.StatusBarPanel2, Me.StatusBarPanel3, Me.StatusBarPanel4})
        Me.StatusBar1.ShowPanels = True
        Me.StatusBar1.Size = New System.Drawing.Size(464, 16)
        Me.StatusBar1.TabIndex = 19
        Me.StatusBar1.Text = "StatusBar1"
        '
        'StatusBarPanel1
        '
        Me.StatusBarPanel1.BorderStyle = System.Windows.Forms.StatusBarPanelBorderStyle.Raised
        Me.StatusBarPanel1.Icon = CType(resources.GetObject("StatusBarPanel1.Icon"), System.Drawing.Icon)
        Me.StatusBarPanel1.Text = "..."
        Me.StatusBarPanel1.Width = 120
        '
        'StatusBarPanel2
        '
        Me.StatusBarPanel2.Text = "Строка: "
        '
        'StatusBarPanel3
        '
        Me.StatusBarPanel3.Text = "..."
        Me.StatusBarPanel3.Width = 1000
        '
        'RichTextBox1
        '
        Me.RichTextBox1.AcceptsTab = True
        Me.RichTextBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RichTextBox1.ContextMenu = Me.ContextMenu1
        Me.RichTextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.RichTextBox1.Location = New System.Drawing.Point(0, 80)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth
        Me.RichTextBox1.Size = New System.Drawing.Size(464, 256)
        Me.RichTextBox1.TabIndex = 20
        Me.RichTextBox1.Text = ""
        Me.RichTextBox1.WordWrap = False
        '
        'ContextMenu1
        '
        Me.ContextMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem61, Me.MenuItem62, Me.MenuItem63, Me.MenuItem64, Me.MenuItem65, Me.MenuItem66, Me.MenuItem135, Me.MenuItem134, Me.MenuItem71, Me.MenuItem87, Me.MenuItem79, Me.MenuItem80, Me.MenuItem81, Me.MenuItem82, Me.MenuItem72})
        '
        'MenuItem61
        '
        Me.MenuItem61.Index = 0
        Me.MenuItem61.Text = "Отменить     Ctrl+Z"
        '
        'MenuItem62
        '
        Me.MenuItem62.Index = 1
        Me.MenuItem62.Text = "-"
        '
        'MenuItem63
        '
        Me.MenuItem63.Index = 2
        Me.MenuItem63.Text = "Вырезать     Ctrl+X"
        '
        'MenuItem64
        '
        Me.MenuItem64.Index = 3
        Me.MenuItem64.Text = "Копировать Ctrl+C"
        '
        'MenuItem65
        '
        Me.MenuItem65.Index = 4
        Me.MenuItem65.Text = "Вставить      Ctrl+V"
        '
        'MenuItem66
        '
        Me.MenuItem66.Index = 5
        Me.MenuItem66.Text = "Удалить       Del"
        '
        'MenuItem135
        '
        Me.MenuItem135.Index = 6
        Me.MenuItem135.Text = "Очистить."
        '
        'MenuItem134
        '
        Me.MenuItem134.Index = 7
        Me.MenuItem134.Text = "Выделить всё"
        '
        'MenuItem71
        '
        Me.MenuItem71.Index = 8
        Me.MenuItem71.Text = "-"
        '
        'MenuItem87
        '
        Me.MenuItem87.Index = 9
        Me.MenuItem87.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem89, Me.MenuItem88, Me.MenuItem133, Me.MenuItem90, Me.MenuItem91, Me.MenuItem92, Me.MenuItem93, Me.MenuItem98, Me.MenuItem94, Me.MenuItem95, Me.MenuItem96, Me.MenuItem202, Me.MenuItem234, Me.MenuItem203, Me.MenuItem204, Me.MenuItem205, Me.MenuItem206, Me.MenuItem207, Me.MenuItem1, Me.MenuItem2, Me.MenuItem3})
        Me.MenuItem87.Text = "Конструкция языка:"
        '
        'MenuItem89
        '
        Me.MenuItem89.Index = 0
        Me.MenuItem89.Text = "$"
        '
        'MenuItem88
        '
        Me.MenuItem88.Index = 1
        Me.MenuItem88.Text = "var"
        '
        'MenuItem133
        '
        Me.MenuItem133.Index = 2
        Me.MenuItem133.Text = "Dim as"
        Me.MenuItem133.Visible = False
        '
        'MenuItem90
        '
        Me.MenuItem90.Index = 3
        Me.MenuItem90.Text = "if( ){ }else{ }"
        '
        'MenuItem91
        '
        Me.MenuItem91.Index = 4
        Me.MenuItem91.Text = "while( ){ }"
        '
        'MenuItem92
        '
        Me.MenuItem92.Index = 5
        Me.MenuItem92.Text = "do{ }while( )"
        '
        'MenuItem93
        '
        Me.MenuItem93.Index = 6
        Me.MenuItem93.Text = "for($i=0,$j=10; $i<$j; $i++){ }"
        '
        'MenuItem98
        '
        Me.MenuItem98.Index = 7
        Me.MenuItem98.Text = "for(var i=0; i<=10; i++){ }"
        '
        'MenuItem94
        '
        Me.MenuItem94.Index = 8
        Me.MenuItem94.Text = "switch( ){case: break; default:}"
        '
        'MenuItem95
        '
        Me.MenuItem95.Index = 9
        Me.MenuItem95.Text = "function( ){ }"
        '
        'MenuItem96
        '
        Me.MenuItem96.Index = 10
        Me.MenuItem96.Text = "-"
        '
        'MenuItem202
        '
        Me.MenuItem202.Index = 11
        Me.MenuItem202.Text = "$('')"
        '
        'MenuItem234
        '
        Me.MenuItem234.Index = 12
        Me.MenuItem234.Text = "$(this)"
        '
        'MenuItem203
        '
        Me.MenuItem203.Index = 13
        Me.MenuItem203.Text = "$(document).ready(function(){});//конец ready"
        '
        'MenuItem204
        '
        Me.MenuItem204.Index = 14
        Me.MenuItem204.Text = "$(function(){});//конец ready"
        '
        'MenuItem205
        '
        Me.MenuItem205.Index = 15
        Me.MenuItem205.Text = "jquery('')"
        '
        'MenuItem206
        '
        Me.MenuItem206.Index = 16
        Me.MenuItem206.Text = "jquery(document).ready(function(){});//конец ready"
        '
        'MenuItem207
        '
        Me.MenuItem207.Index = 17
        Me.MenuItem207.Text = "jquery(function(){});//конец ready"
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 18
        Me.MenuItem1.Text = "-"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 19
        Me.MenuItem2.Text = "<script type=""text/javascript"" src=""""></script>"
        '
        'MenuItem3
        '
        Me.MenuItem3.Index = 20
        Me.MenuItem3.Text = "<link type=""text/css"" rel=""stylesheet"" href="""">"
        '
        'MenuItem79
        '
        Me.MenuItem79.Index = 10
        Me.MenuItem79.Text = "Форматировать."
        '
        'MenuItem80
        '
        Me.MenuItem80.Index = 11
        Me.MenuItem80.Text = "Шрифт текста."
        '
        'MenuItem81
        '
        Me.MenuItem81.Index = 12
        Me.MenuItem81.Text = "Цвет текста"
        '
        'MenuItem82
        '
        Me.MenuItem82.Index = 13
        Me.MenuItem82.Text = "-"
        '
        'MenuItem72
        '
        Me.MenuItem72.Index = 14
        Me.MenuItem72.Text = "HTML Цветовая гамма."
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.TextBox2)
        Me.Panel6.Controls.Add(Me.ListBox1)
        Me.Panel6.Location = New System.Drawing.Point(112, 232)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(200, 104)
        Me.Panel6.TabIndex = 21
        Me.Panel6.Visible = False
        '
        'TextBox2
        '
        Me.TextBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox2.Location = New System.Drawing.Point(0, 0)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(200, 20)
        Me.TextBox2.TabIndex = 1
        Me.TextBox2.Text = ""
        '
        'ListBox1
        '
        Me.ListBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ListBox1.Location = New System.Drawing.Point(0, 21)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(200, 80)
        Me.ListBox1.TabIndex = 0
        '
        'RichTextBox2
        '
        Me.RichTextBox2.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(192, Byte))
        Me.RichTextBox2.Location = New System.Drawing.Point(48, 96)
        Me.RichTextBox2.Name = "RichTextBox2"
        Me.RichTextBox2.TabIndex = 22
        Me.RichTextBox2.Text = "RichTextBox2"
        '
        'RadioButton7
        '
        Me.RadioButton7.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.RadioButton7.Location = New System.Drawing.Point(272, 336)
        Me.RadioButton7.Name = "RadioButton7"
        Me.RadioButton7.Size = New System.Drawing.Size(48, 24)
        Me.RadioButton7.TabIndex = 23
        Me.RadioButton7.Text = "php"
        '
        'RadioButton8
        '
        Me.RadioButton8.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.RadioButton8.Location = New System.Drawing.Point(320, 336)
        Me.RadioButton8.Name = "RadioButton8"
        Me.RadioButton8.Size = New System.Drawing.Size(56, 24)
        Me.RadioButton8.TabIndex = 24
        Me.RadioButton8.Text = "perl"
        '
        'RadioButton9
        '
        Me.RadioButton9.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.RadioButton9.Location = New System.Drawing.Point(376, 336)
        Me.RadioButton9.Name = "RadioButton9"
        Me.RadioButton9.Size = New System.Drawing.Size(40, 24)
        Me.RadioButton9.TabIndex = 25
        Me.RadioButton9.Text = "sql"
        '
        'StatusBarPanel4
        '
        Me.StatusBarPanel4.Text = "StatusBarPanel4"
        '
        'EditFile
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(464, 374)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.StatusBar1)
        Me.Controls.Add(Me.RadioButton9)
        Me.Controls.Add(Me.RadioButton8)
        Me.Controls.Add(Me.RadioButton7)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.RichTextBox2)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.RadioButton3)
        Me.Controls.Add(Me.RadioButton4)
        Me.Controls.Add(Me.RadioButton6)
        Me.Controls.Add(Me.RadioButton5)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "EditFile"
        Me.Text = "EditFile"
        Me.Panel1.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        CType(Me.StatusBarPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StatusBarPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StatusBarPanel3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        CType(Me.StatusBarPanel4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public MyFileName As String
    Public MyPath As String
    Public OpenOrCreate As String
    Public MyID As Integer
    Public ActivateFormat As Boolean = False
    Dim ListFocus As Boolean = False
    Private Sub EditFile_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Определяем тип основного языка скрипта
        If (Label1.Text = "HTML SCRIPT") Then
            RadioButton1.Checked = True
        End If
        If (Label1.Text = "CSS SCRIPT") Then
            RadioButton2.Checked = True
        End If
        If (Label1.Text = "JS SCRIPT") Then
            RadioButton6.Checked = True
        End If
        If (Label1.Text = "PHP SCRIPT") Then
            RadioButton7.Checked = True
        End If
        If (Label1.Text = "SCRIPT") Then
            'RadioButton5.Checked = True
        End If
        RichTextBox1.Font = ModulePE.FontModule
        RichTextBox2.Font = ModulePE.FontModule
        FontDialog1.Font = ModulePE.FontModule
        If (ModulePE.ActionModuleFormat = True) Then
            If (Label1.Text = "HTML SCRIPT") Then
                ModuleFormatVersionHTML()
            Else
                If (Label1.Text = "PHP SCRIPT") Then
                    'ModuleFormatVersionPHP()
                    ModuleFormatVersion1_1_8()
                Else
                    If (Label1.Text = "SCRIPT") Then
                        If (MsgBox("Документ не определён, открыть как текстовый?", MsgBoxStyle.YesNo, "Вопрос:") = MsgBoxResult.No) Then
                            RadioButton5.Checked = True
                            ModuleFormatVersion1_1_8()
                        End If
                    Else
                        ModuleFormatVersion1_1_8()
                    End If
                End If
            End If
        End If
            'LOAD_OPERATORS()
    End Sub

    Private Sub EditFile_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        ModulePE.BaseFile(MyID) = ""
        ModulePE.ProgrammPE.ReloadLB()
    End Sub

    Public Sub FormatTextHTML(ByVal AddText As String)
        Dim FormatYesNo As Boolean = False
        For iAddChar As Integer = 0 To AddText.Length - 1

            If (AddText.Chars(iAddChar) = "0") Then
                RichTextBox1.SelectionColor = Color.FromArgb(ModulePE.Color01)
                FormatYesNo = True
                Clipboard.SetDataObject(AddText.Chars(iAddChar).ToString)
                RichTextBox1.Paste()
            End If
            If (AddText.Chars(iAddChar) = "1") Then
                RichTextBox1.SelectionColor = Color.FromArgb(ModulePE.Color01)
                FormatYesNo = True
                Clipboard.SetDataObject(AddText.Chars(iAddChar).ToString)
                RichTextBox1.Paste()
            End If
            If (AddText.Chars(iAddChar) = "2") Then
                RichTextBox1.SelectionColor = Color.FromArgb(ModulePE.Color01)
                FormatYesNo = True
                Clipboard.SetDataObject(AddText.Chars(iAddChar).ToString)
                RichTextBox1.Paste()
            End If
            If (AddText.Chars(iAddChar) = "3") Then
                RichTextBox1.SelectionColor = Color.FromArgb(ModulePE.Color01)
                FormatYesNo = True
                Clipboard.SetDataObject(AddText.Chars(iAddChar).ToString)
                RichTextBox1.Paste()
            End If
            If (AddText.Chars(iAddChar) = "4") Then
                RichTextBox1.SelectionColor = Color.FromArgb(ModulePE.Color01)
                FormatYesNo = True
                Clipboard.SetDataObject(AddText.Chars(iAddChar).ToString)
                RichTextBox1.Paste()
            End If
            If (AddText.Chars(iAddChar) = "5") Then
                RichTextBox1.SelectionColor = Color.FromArgb(ModulePE.Color01)
                FormatYesNo = True
                Clipboard.SetDataObject(AddText.Chars(iAddChar).ToString)
                RichTextBox1.Paste()
            End If
            If (AddText.Chars(iAddChar) = "6") Then
                RichTextBox1.SelectionColor = Color.FromArgb(ModulePE.Color01)
                FormatYesNo = True
                Clipboard.SetDataObject(AddText.Chars(iAddChar).ToString)
                RichTextBox1.Paste()
            End If
            If (AddText.Chars(iAddChar) = "7") Then
                RichTextBox1.SelectionColor = Color.FromArgb(ModulePE.Color01)
                FormatYesNo = True
                Clipboard.SetDataObject(AddText.Chars(iAddChar).ToString)
                RichTextBox1.Paste()
            End If
            If (AddText.Chars(iAddChar) = "8") Then
                RichTextBox1.SelectionColor = Color.FromArgb(ModulePE.Color01)
                FormatYesNo = True
                Clipboard.SetDataObject(AddText.Chars(iAddChar).ToString)
                RichTextBox1.Paste()
            End If
            If (AddText.Chars(iAddChar) = "9") Then
                RichTextBox1.SelectionColor = Color.FromArgb(ModulePE.Color01)
                FormatYesNo = True
                Clipboard.SetDataObject(AddText.Chars(iAddChar).ToString)
                RichTextBox1.Paste()
            End If
            If (AddText.Chars(iAddChar) = "(") Then
                RichTextBox1.SelectionColor = Color.FromArgb(ModulePE.Color02)
                FormatYesNo = True
                Clipboard.SetDataObject(AddText.Chars(iAddChar).ToString)
                RichTextBox1.Paste()
            End If
            If (AddText.Chars(iAddChar) = "!") Then
                RichTextBox1.SelectionColor = Color.FromArgb(ModulePE.Color03)
                FormatYesNo = True
                Clipboard.SetDataObject(AddText.Chars(iAddChar).ToString)
                RichTextBox1.Paste()
            End If
            If (AddText.Chars(iAddChar) = "@") Then
                RichTextBox1.SelectionColor = Color.FromArgb(ModulePE.Color04)
                FormatYesNo = True
                Clipboard.SetDataObject(AddText.Chars(iAddChar).ToString)
                RichTextBox1.Paste()
            End If
            If (AddText.Chars(iAddChar) = "#") Then
                RichTextBox1.SelectionColor = Color.FromArgb(ModulePE.Color05)
                FormatYesNo = True
                Clipboard.SetDataObject(AddText.Chars(iAddChar).ToString)
                RichTextBox1.Paste()
            End If
            If (AddText.Chars(iAddChar) = "$") Then
                RichTextBox1.SelectionColor = Color.FromArgb(ModulePE.Color06)
                FormatYesNo = True
                Clipboard.SetDataObject(AddText.Chars(iAddChar).ToString)
                RichTextBox1.Paste()
            End If
            If (AddText.Chars(iAddChar) = "%") Then
                RichTextBox1.SelectionColor = Color.FromArgb(ModulePE.Color07)
                FormatYesNo = True
                Clipboard.SetDataObject(AddText.Chars(iAddChar).ToString)
                RichTextBox1.Paste()
            End If
            If (AddText.Chars(iAddChar) = "^") Then
                RichTextBox1.SelectionColor = Color.FromArgb(ModulePE.Color08)
                FormatYesNo = True
                Clipboard.SetDataObject(AddText.Chars(iAddChar).ToString)
                RichTextBox1.Paste()
            End If
            If (AddText.Chars(iAddChar) = "&") Then
                RichTextBox1.SelectionColor = Color.FromArgb(ModulePE.Color09)
                FormatYesNo = True
                Clipboard.SetDataObject(AddText.Chars(iAddChar).ToString)
                RichTextBox1.Paste()
            End If
            If (AddText.Chars(iAddChar) = ")") Then
                RichTextBox1.SelectionColor = Color.FromArgb(ModulePE.Color10)
                FormatYesNo = True
                Clipboard.SetDataObject(AddText.Chars(iAddChar).ToString)
                RichTextBox1.Paste()
            End If
            If (AddText.Chars(iAddChar) = "*") Then
                RichTextBox1.SelectionColor = Color.FromArgb(ModulePE.Color11)
                FormatYesNo = True
                Clipboard.SetDataObject(AddText.Chars(iAddChar).ToString)
                RichTextBox1.Paste()
            End If
            If (AddText.Chars(iAddChar) = "-") Then
                RichTextBox1.SelectionColor = Color.FromArgb(ModulePE.Color12)
                FormatYesNo = True
                Clipboard.SetDataObject(AddText.Chars(iAddChar).ToString)
                RichTextBox1.Paste()
            End If
            If (AddText.Chars(iAddChar) = "_") Then
                RichTextBox1.SelectionColor = Color.FromArgb(ModulePE.Color13)
                FormatYesNo = True
                Clipboard.SetDataObject(AddText.Chars(iAddChar).ToString)
                RichTextBox1.Paste()
            End If
            If (AddText.Chars(iAddChar) = "=") Then
                RichTextBox1.SelectionColor = Color.FromArgb(ModulePE.Color14)
                FormatYesNo = True
                Clipboard.SetDataObject(AddText.Chars(iAddChar).ToString)
                RichTextBox1.Paste()
            End If
            If (AddText.Chars(iAddChar) = "+") Then
                RichTextBox1.SelectionColor = Color.FromArgb(ModulePE.Color15)
                FormatYesNo = True
                Clipboard.SetDataObject(AddText.Chars(iAddChar).ToString)
                RichTextBox1.Paste()
            End If
            If (AddText.Chars(iAddChar) = "|") Then
                RichTextBox1.SelectionColor = Color.FromArgb(ModulePE.Color16)
                FormatYesNo = True
                Clipboard.SetDataObject(AddText.Chars(iAddChar).ToString)
                RichTextBox1.Paste()
            End If
            If (AddText.Chars(iAddChar) = "?") Then
                RichTextBox1.SelectionColor = Color.FromArgb(ModulePE.Color17)
                FormatYesNo = True
                Clipboard.SetDataObject(AddText.Chars(iAddChar).ToString)
                RichTextBox1.Paste()
            End If
            If (AddText.Chars(iAddChar) = "{") Then
                RichTextBox1.SelectionColor = Color.FromArgb(ModulePE.Color18)
                FormatYesNo = True
                Clipboard.SetDataObject(AddText.Chars(iAddChar).ToString)
                RichTextBox1.Paste()
            End If
            If (AddText.Chars(iAddChar) = "[") Then
                RichTextBox1.SelectionColor = Color.FromArgb(ModulePE.Color19)
                FormatYesNo = True
                Clipboard.SetDataObject(AddText.Chars(iAddChar).ToString)
                RichTextBox1.Paste()
            End If
            If (AddText.Chars(iAddChar) = ";") Then
                RichTextBox1.SelectionColor = Color.FromArgb(ModulePE.Color20)
                FormatYesNo = True
                Clipboard.SetDataObject(AddText.Chars(iAddChar).ToString)
                RichTextBox1.Paste()
            End If
            If (AddText.Chars(iAddChar) = "'") Then
                RichTextBox1.SelectionColor = Color.FromArgb(ModulePE.Color21)
                FormatYesNo = True
                Clipboard.SetDataObject(AddText.Chars(iAddChar).ToString)
                RichTextBox1.Paste()
            End If
            If (AddText.Chars(iAddChar) = "\") Then
                RichTextBox1.SelectionColor = Color.FromArgb(ModulePE.Color22)
                FormatYesNo = True
                Clipboard.SetDataObject(AddText.Chars(iAddChar).ToString)
                RichTextBox1.Paste()
            End If
            If (AddText.Chars(iAddChar) = "<") Then
                RichTextBox1.SelectionColor = Color.FromArgb(200, 0, 0)
                FormatYesNo = True
                Clipboard.SetDataObject(AddText.Chars(iAddChar).ToString)
                RichTextBox1.Paste()
            End If
            If (AddText.Chars(iAddChar) = ",") Then
                RichTextBox1.SelectionColor = Color.FromArgb(ModulePE.Color24)
                FormatYesNo = True
                Clipboard.SetDataObject(AddText.Chars(iAddChar).ToString)
                RichTextBox1.Paste()
            End If
            If (AddText.Chars(iAddChar) = "}") Then
                RichTextBox1.SelectionColor = Color.FromArgb(ModulePE.Color25)
                FormatYesNo = True
                Clipboard.SetDataObject(AddText.Chars(iAddChar).ToString)
                RichTextBox1.Paste()
            End If
            If (AddText.Chars(iAddChar) = "]") Then
                RichTextBox1.SelectionColor = Color.FromArgb(ModulePE.Color26)
                FormatYesNo = True
                Clipboard.SetDataObject(AddText.Chars(iAddChar).ToString)
                RichTextBox1.Paste()
            End If
            If (AddText.Chars(iAddChar) = ":") Then
                RichTextBox1.SelectionColor = Color.FromArgb(ModulePE.Color27)
                FormatYesNo = True
                Clipboard.SetDataObject(AddText.Chars(iAddChar).ToString)
                RichTextBox1.Paste()
            End If
            If (AddText.Chars(iAddChar) = """") Then
                RichTextBox1.SelectionColor = Color.FromArgb(ModulePE.Color28)
                FormatYesNo = True
                Clipboard.SetDataObject(AddText.Chars(iAddChar).ToString)
                RichTextBox1.Paste()
            End If
            If (AddText.Chars(iAddChar) = "/") Then
                RichTextBox1.SelectionColor = Color.FromArgb(ModulePE.Color29)
                FormatYesNo = True
                Clipboard.SetDataObject(AddText.Chars(iAddChar).ToString)
                RichTextBox1.Paste()
            End If
            If (AddText.Chars(iAddChar) = ">") Then
                RichTextBox1.SelectionColor = Color.FromArgb(200, 0, 0)
                FormatYesNo = True
                Clipboard.SetDataObject(AddText.Chars(iAddChar).ToString)
                RichTextBox1.Paste()
            End If
            If (AddText.Chars(iAddChar) = ".") Then
                RichTextBox1.SelectionColor = Color.FromArgb(ModulePE.Color31)
                FormatYesNo = True
                Clipboard.SetDataObject(AddText.Chars(iAddChar).ToString)
                RichTextBox1.Paste()
            End If

            If (FormatYesNo = False) Then
                RichTextBox1.SelectionColor = Color.FromArgb(0, 0, 255)
                Clipboard.SetDataObject(AddText.Chars(iAddChar).ToString)
                RichTextBox1.Paste()
                FormatYesNo = False
            Else
                FormatYesNo = False
            End If
        Next
        RichTextBox1.SelectionColor = Color.Black
    End Sub

    Public Sub FormatText(ByVal AddText As String)
        Dim FormatYesNo As Boolean = False
        For iAddChar As Integer = 0 To AddText.Length - 1

            If (AddText.Chars(iAddChar) = "0") Then
                RichTextBox1.SelectionColor = Color.FromArgb(ModulePE.Color01)
                FormatYesNo = True
                Clipboard.SetDataObject(AddText.Chars(iAddChar).ToString)
                RichTextBox1.Paste()
            End If
            If (AddText.Chars(iAddChar) = "1") Then
                RichTextBox1.SelectionColor = Color.FromArgb(ModulePE.Color01)
                FormatYesNo = True
                Clipboard.SetDataObject(AddText.Chars(iAddChar).ToString)
                RichTextBox1.Paste()
            End If
            If (AddText.Chars(iAddChar) = "2") Then
                RichTextBox1.SelectionColor = Color.FromArgb(ModulePE.Color01)
                FormatYesNo = True
                Clipboard.SetDataObject(AddText.Chars(iAddChar).ToString)
                RichTextBox1.Paste()
            End If
            If (AddText.Chars(iAddChar) = "3") Then
                RichTextBox1.SelectionColor = Color.FromArgb(ModulePE.Color01)
                FormatYesNo = True
                Clipboard.SetDataObject(AddText.Chars(iAddChar).ToString)
                RichTextBox1.Paste()
            End If
            If (AddText.Chars(iAddChar) = "4") Then
                RichTextBox1.SelectionColor = Color.FromArgb(ModulePE.Color01)
                FormatYesNo = True
                Clipboard.SetDataObject(AddText.Chars(iAddChar).ToString)
                RichTextBox1.Paste()
            End If
            If (AddText.Chars(iAddChar) = "5") Then
                RichTextBox1.SelectionColor = Color.FromArgb(ModulePE.Color01)
                FormatYesNo = True
                Clipboard.SetDataObject(AddText.Chars(iAddChar).ToString)
                RichTextBox1.Paste()
            End If
            If (AddText.Chars(iAddChar) = "6") Then
                RichTextBox1.SelectionColor = Color.FromArgb(ModulePE.Color01)
                FormatYesNo = True
                Clipboard.SetDataObject(AddText.Chars(iAddChar).ToString)
                RichTextBox1.Paste()
            End If
            If (AddText.Chars(iAddChar) = "7") Then
                RichTextBox1.SelectionColor = Color.FromArgb(ModulePE.Color01)
                FormatYesNo = True
                Clipboard.SetDataObject(AddText.Chars(iAddChar).ToString)
                RichTextBox1.Paste()
            End If
            If (AddText.Chars(iAddChar) = "8") Then
                RichTextBox1.SelectionColor = Color.FromArgb(ModulePE.Color01)
                FormatYesNo = True
                Clipboard.SetDataObject(AddText.Chars(iAddChar).ToString)
                RichTextBox1.Paste()
            End If
            If (AddText.Chars(iAddChar) = "9") Then
                RichTextBox1.SelectionColor = Color.FromArgb(ModulePE.Color01)
                FormatYesNo = True
                Clipboard.SetDataObject(AddText.Chars(iAddChar).ToString)
                RichTextBox1.Paste()
            End If
            If (AddText.Chars(iAddChar) = "(") Then
                RichTextBox1.SelectionColor = Color.FromArgb(ModulePE.Color02)
                FormatYesNo = True
                Clipboard.SetDataObject(AddText.Chars(iAddChar).ToString)
                RichTextBox1.Paste()
            End If
            If (AddText.Chars(iAddChar) = "!") Then
                RichTextBox1.SelectionColor = Color.FromArgb(ModulePE.Color03)
                FormatYesNo = True
                Clipboard.SetDataObject(AddText.Chars(iAddChar).ToString)
                RichTextBox1.Paste()
            End If
            If (AddText.Chars(iAddChar) = "@") Then
                RichTextBox1.SelectionColor = Color.FromArgb(ModulePE.Color04)
                FormatYesNo = True
                Clipboard.SetDataObject(AddText.Chars(iAddChar).ToString)
                RichTextBox1.Paste()
            End If
            If (AddText.Chars(iAddChar) = "#") Then
                RichTextBox1.SelectionColor = Color.FromArgb(ModulePE.Color05)
                FormatYesNo = True
                Clipboard.SetDataObject(AddText.Chars(iAddChar).ToString)
                RichTextBox1.Paste()
            End If
            If (AddText.Chars(iAddChar) = "$") Then
                RichTextBox1.SelectionColor = Color.FromArgb(ModulePE.Color06)
                FormatYesNo = True
                Clipboard.SetDataObject(AddText.Chars(iAddChar).ToString)
                RichTextBox1.Paste()
            End If
            If (AddText.Chars(iAddChar) = "%") Then
                RichTextBox1.SelectionColor = Color.FromArgb(ModulePE.Color07)
                FormatYesNo = True
                Clipboard.SetDataObject(AddText.Chars(iAddChar).ToString)
                RichTextBox1.Paste()
            End If
            If (AddText.Chars(iAddChar) = "^") Then
                RichTextBox1.SelectionColor = Color.FromArgb(ModulePE.Color08)
                FormatYesNo = True
                Clipboard.SetDataObject(AddText.Chars(iAddChar).ToString)
                RichTextBox1.Paste()
            End If
            If (AddText.Chars(iAddChar) = "&") Then
                RichTextBox1.SelectionColor = Color.FromArgb(ModulePE.Color09)
                FormatYesNo = True
                Clipboard.SetDataObject(AddText.Chars(iAddChar).ToString)
                RichTextBox1.Paste()
            End If
            If (AddText.Chars(iAddChar) = ")") Then
                RichTextBox1.SelectionColor = Color.FromArgb(ModulePE.Color10)
                FormatYesNo = True
                Clipboard.SetDataObject(AddText.Chars(iAddChar).ToString)
                RichTextBox1.Paste()
            End If
            If (AddText.Chars(iAddChar) = "*") Then
                RichTextBox1.SelectionColor = Color.FromArgb(ModulePE.Color11)
                FormatYesNo = True
                Clipboard.SetDataObject(AddText.Chars(iAddChar).ToString)
                RichTextBox1.Paste()
            End If
            If (AddText.Chars(iAddChar) = "-") Then
                RichTextBox1.SelectionColor = Color.FromArgb(ModulePE.Color12)
                FormatYesNo = True
                Clipboard.SetDataObject(AddText.Chars(iAddChar).ToString)
                RichTextBox1.Paste()
            End If
            If (AddText.Chars(iAddChar) = "_") Then
                RichTextBox1.SelectionColor = Color.FromArgb(ModulePE.Color13)
                FormatYesNo = True
                Clipboard.SetDataObject(AddText.Chars(iAddChar).ToString)
                RichTextBox1.Paste()
            End If
            If (AddText.Chars(iAddChar) = "=") Then
                RichTextBox1.SelectionColor = Color.FromArgb(ModulePE.Color14)
                FormatYesNo = True
                Clipboard.SetDataObject(AddText.Chars(iAddChar).ToString)
                RichTextBox1.Paste()
            End If
            If (AddText.Chars(iAddChar) = "+") Then
                RichTextBox1.SelectionColor = Color.FromArgb(ModulePE.Color15)
                FormatYesNo = True
                Clipboard.SetDataObject(AddText.Chars(iAddChar).ToString)
                RichTextBox1.Paste()
            End If
            If (AddText.Chars(iAddChar) = "|") Then
                RichTextBox1.SelectionColor = Color.FromArgb(ModulePE.Color16)
                FormatYesNo = True
                Clipboard.SetDataObject(AddText.Chars(iAddChar).ToString)
                RichTextBox1.Paste()
            End If
            If (AddText.Chars(iAddChar) = "?") Then
                RichTextBox1.SelectionColor = Color.FromArgb(ModulePE.Color17)
                FormatYesNo = True
                Clipboard.SetDataObject(AddText.Chars(iAddChar).ToString)
                RichTextBox1.Paste()
            End If
            If (AddText.Chars(iAddChar) = "{") Then
                RichTextBox1.SelectionColor = Color.FromArgb(ModulePE.Color18)
                FormatYesNo = True
                Clipboard.SetDataObject(AddText.Chars(iAddChar).ToString)
                RichTextBox1.Paste()
            End If
            If (AddText.Chars(iAddChar) = "[") Then
                RichTextBox1.SelectionColor = Color.FromArgb(ModulePE.Color19)
                FormatYesNo = True
                Clipboard.SetDataObject(AddText.Chars(iAddChar).ToString)
                RichTextBox1.Paste()
            End If
            If (AddText.Chars(iAddChar) = ";") Then
                RichTextBox1.SelectionColor = Color.FromArgb(ModulePE.Color20)
                FormatYesNo = True
                Clipboard.SetDataObject(AddText.Chars(iAddChar).ToString)
                RichTextBox1.Paste()
            End If
            If (AddText.Chars(iAddChar) = "'") Then
                RichTextBox1.SelectionColor = Color.FromArgb(ModulePE.Color21)
                FormatYesNo = True
                Clipboard.SetDataObject(AddText.Chars(iAddChar).ToString)
                RichTextBox1.Paste()
            End If
            If (AddText.Chars(iAddChar) = "\") Then
                RichTextBox1.SelectionColor = Color.FromArgb(ModulePE.Color22)
                FormatYesNo = True
                Clipboard.SetDataObject(AddText.Chars(iAddChar).ToString)
                RichTextBox1.Paste()
            End If
            If (AddText.Chars(iAddChar) = "<") Then
                RichTextBox1.SelectionColor = Color.FromArgb(ModulePE.Color23)
                FormatYesNo = True
                Clipboard.SetDataObject(AddText.Chars(iAddChar).ToString)
                RichTextBox1.Paste()
            End If
            If (AddText.Chars(iAddChar) = ",") Then
                RichTextBox1.SelectionColor = Color.FromArgb(ModulePE.Color24)
                FormatYesNo = True
                Clipboard.SetDataObject(AddText.Chars(iAddChar).ToString)
                RichTextBox1.Paste()
            End If
            If (AddText.Chars(iAddChar) = "}") Then
                RichTextBox1.SelectionColor = Color.FromArgb(ModulePE.Color25)
                FormatYesNo = True
                Clipboard.SetDataObject(AddText.Chars(iAddChar).ToString)
                RichTextBox1.Paste()
            End If
            If (AddText.Chars(iAddChar) = "]") Then
                RichTextBox1.SelectionColor = Color.FromArgb(ModulePE.Color26)
                FormatYesNo = True
                Clipboard.SetDataObject(AddText.Chars(iAddChar).ToString)
                RichTextBox1.Paste()
            End If
            If (AddText.Chars(iAddChar) = ":") Then
                RichTextBox1.SelectionColor = Color.FromArgb(ModulePE.Color27)
                FormatYesNo = True
                Clipboard.SetDataObject(AddText.Chars(iAddChar).ToString)
                RichTextBox1.Paste()
            End If
            If (AddText.Chars(iAddChar) = """") Then
                RichTextBox1.SelectionColor = Color.FromArgb(ModulePE.Color28)
                FormatYesNo = True
                Clipboard.SetDataObject(AddText.Chars(iAddChar).ToString)
                RichTextBox1.Paste()
            End If
            If (AddText.Chars(iAddChar) = "/") Then
                RichTextBox1.SelectionColor = Color.FromArgb(ModulePE.Color29)
                FormatYesNo = True
                Clipboard.SetDataObject(AddText.Chars(iAddChar).ToString)
                RichTextBox1.Paste()
            End If
            If (AddText.Chars(iAddChar) = ">") Then
                RichTextBox1.SelectionColor = Color.FromArgb(ModulePE.Color30)
                FormatYesNo = True
                Clipboard.SetDataObject(AddText.Chars(iAddChar).ToString)
                RichTextBox1.Paste()
            End If
            If (AddText.Chars(iAddChar) = ".") Then
                RichTextBox1.SelectionColor = Color.FromArgb(ModulePE.Color31)
                FormatYesNo = True
                Clipboard.SetDataObject(AddText.Chars(iAddChar).ToString)
                RichTextBox1.Paste()
            End If

            If (FormatYesNo = False) Then
                RichTextBox1.SelectionColor = Color.Black
                Clipboard.SetDataObject(AddText.Chars(iAddChar).ToString)
                RichTextBox1.Paste()
                FormatYesNo = False
            Else
                FormatYesNo = False
            End If
        Next
        RichTextBox1.SelectionColor = Color.Black
    End Sub

    Public Sub LOAD_OPERATORS()
        Try
            Dim Proces As New Processed
            Proces.MdiParent = ModulePE.ProgrammPE.ActiveForm
            Proces.Show()
            Proces.Update()
            ListBox1.Items.Clear()
            '--------------------------------------------------
            If (RadioButton5.Checked = True) Then 'ВСЕ ОПЕРАТОРЫ
                Dim OpenFileList As File
                If OpenFileList.Exists(ModuleBase.MyProgramDirectory + "\Resource\Operators.txt") = True Then
                    RichTextBox2.LoadFile(ModuleBase.MyProgramDirectory + "\Resource\Operators.txt", RichTextBoxStreamType.PlainText)

                    Dim STROKA As String
                    For i As Integer = 0 To RichTextBox2.Lines.Length - 1 'колличество строк
                        ListBox1.Items.Add(RichTextBox2.Lines.GetValue(i)) 'получаем строку
                    Next
                    RichTextBox2.Clear()
                Else
                    MsgBox("ОШИБКА: Программа не смогла найти файл " + ModuleBase.MyProgramDirectory + "\Resource\Operators.txt", MsgBoxStyle.OKOnly, "Сообщение:")
                End If
            End If
            '--------------------------------------------------
            If (RadioButton1.Checked = True) Then 'HTML
                Dim OpenFileList As File
                If OpenFileList.Exists(ModuleBase.MyProgramDirectory + "\Resource\HTMLOperators.txt") = True Then
                    RichTextBox2.LoadFile(ModuleBase.MyProgramDirectory + "\Resource\HTMLOperators.txt", RichTextBoxStreamType.PlainText)

                    Dim STROKA As String
                    For i As Integer = 0 To RichTextBox2.Lines.Length - 1 'колличество строк
                        ListBox1.Items.Add(RichTextBox2.Lines.GetValue(i)) 'получаем строку
                    Next
                    RichTextBox2.Clear()
                Else
                    MsgBox("ОШИБКА: Программа не смогла найти файл " + ModuleBase.MyProgramDirectory + "\Resource\HTMLOperators.txt", MsgBoxStyle.OKOnly, "Сообщение:")
                End If
            End If
            '--------------------------------------------------
            If (RadioButton2.Checked = True) Then 'CSS
                Dim OpenFileList As File
                If OpenFileList.Exists(ModuleBase.MyProgramDirectory + "\Resource\CSSOperators.txt") = True Then
                    RichTextBox2.LoadFile(ModuleBase.MyProgramDirectory + "\Resource\CSSOperators.txt", RichTextBoxStreamType.PlainText)

                    Dim STROKA As String
                    For i As Integer = 0 To RichTextBox2.Lines.Length - 1 'колличество строк
                        ListBox1.Items.Add(RichTextBox2.Lines.GetValue(i)) 'получаем строку
                    Next
                    RichTextBox2.Clear()
                Else
                    MsgBox("ОШИБКА: Программа не смогла найти файл " + ModuleBase.MyProgramDirectory + "\Resource\CSSOperators.txt", MsgBoxStyle.OKOnly, "Сообщение:")
                End If
            End If
            '--------------------------------------------------
            If (RadioButton3.Checked = True) Then 'JAVASCRIPT
                Dim OpenFileList As File
                If OpenFileList.Exists(ModuleBase.MyProgramDirectory + "\Resource\JAVASCRIPTOperators.txt") = True Then
                    RichTextBox2.LoadFile(ModuleBase.MyProgramDirectory + "\Resource\JAVASCRIPTOperators.txt", RichTextBoxStreamType.PlainText)

                    Dim STROKA As String
                    For i As Integer = 0 To RichTextBox2.Lines.Length - 1 'колличество строк
                        ListBox1.Items.Add(RichTextBox2.Lines.GetValue(i)) 'получаем строку
                    Next
                    RichTextBox2.Clear()
                Else
                    MsgBox("ОШИБКА: Программа не смогла найти файл " + ModuleBase.MyProgramDirectory + "\Resource\JAVASCRIPTOperators.txt", MsgBoxStyle.OKOnly, "Сообщение:")
                End If
            End If
            '--------------------------------------------------
            '--------------------------------------------------
            If (RadioButton4.Checked = True) Then 'JQUERY
                Dim OpenFileList As File
                If OpenFileList.Exists(ModuleBase.MyProgramDirectory + "\Resource\JQUERYOperators.txt") = True Then
                    RichTextBox2.LoadFile(ModuleBase.MyProgramDirectory + "\Resource\JQUERYOperators.txt", RichTextBoxStreamType.PlainText)

                    Dim STROKA As String
                    For i As Integer = 0 To RichTextBox2.Lines.Length - 1 'колличество строк
                        ListBox1.Items.Add(RichTextBox2.Lines.GetValue(i)) 'получаем строку
                    Next
                    RichTextBox2.Clear()
                Else
                    MsgBox("ОШИБКА: Программа не смогла найти файл " + ModuleBase.MyProgramDirectory + "\Resource\JQUERYOperators.txt", MsgBoxStyle.OKOnly, "Сообщение:")
                End If
            End If
            '--------------------------------------------------
            '--------------------------------------------------
            If (RadioButton6.Checked = True) Then 'JAVASCRIPT & JQUERY
                Dim OpenFileList As File
                If OpenFileList.Exists(ModuleBase.MyProgramDirectory + "\Resource\JQUERY_JAVASCRIPTOperators.txt") = True Then
                    RichTextBox2.LoadFile(ModuleBase.MyProgramDirectory + "\Resource\JQUERY_JAVASCRIPTOperators.txt", RichTextBoxStreamType.PlainText)

                    Dim STROKA As String
                    For i As Integer = 0 To RichTextBox2.Lines.Length - 1 'колличество строк
                        ListBox1.Items.Add(RichTextBox2.Lines.GetValue(i)) 'получаем строку
                    Next
                    RichTextBox2.Clear()
                Else
                    MsgBox("ОШИБКА: Программа не смогла найти файл " + ModuleBase.MyProgramDirectory + "\Resource\JQUERY_JAVASCRIPTOperators.txt", MsgBoxStyle.OKOnly, "Сообщение:")
                End If
            End If
            '--------------------------------------------------
            '--------------------------------------------------
            If (RadioButton7.Checked = True) Then 'PHP
                Dim OpenFileList As File
                If OpenFileList.Exists(ModuleBase.MyProgramDirectory + "\Resource\PHPOperators.txt") = True Then
                    RichTextBox2.LoadFile(ModuleBase.MyProgramDirectory + "\Resource\PHPOperators.txt", RichTextBoxStreamType.PlainText)

                    Dim STROKA As String
                    For i As Integer = 0 To RichTextBox2.Lines.Length - 1 'колличество строк
                        ListBox1.Items.Add(RichTextBox2.Lines.GetValue(i)) 'получаем строку
                    Next
                    RichTextBox2.Clear()
                Else
                    MsgBox("ОШИБКА: Программа не смогла найти файл " + ModuleBase.MyProgramDirectory + "\Resource\PHPOperators.txt", MsgBoxStyle.OKOnly, "Сообщение:")
                End If
            End If
            '--------------------------------------------------
            '--------------------------------------------------
            If (RadioButton8.Checked = True) Then 'PERL
                Dim OpenFileList As File
                If OpenFileList.Exists(ModuleBase.MyProgramDirectory + "\Resource\PERLOperators.txt") = True Then
                    RichTextBox2.LoadFile(ModuleBase.MyProgramDirectory + "\Resource\PERLOperators.txt", RichTextBoxStreamType.PlainText)

                    Dim STROKA As String
                    For i As Integer = 0 To RichTextBox2.Lines.Length - 1 'колличество строк
                        ListBox1.Items.Add(RichTextBox2.Lines.GetValue(i)) 'получаем строку
                    Next
                    RichTextBox2.Clear()
                Else
                    MsgBox("ОШИБКА: Программа не смогла найти файл " + ModuleBase.MyProgramDirectory + "\Resource\PERLOperators.txt", MsgBoxStyle.OKOnly, "Сообщение:")
                End If
            End If
            '--------------------------------------------------
            '--------------------------------------------------
            If (RadioButton9.Checked = True) Then 'SQL
                Dim OpenFileList As File
                If OpenFileList.Exists(ModuleBase.MyProgramDirectory + "\Resource\SQLOperators.txt") = True Then
                    RichTextBox2.LoadFile(ModuleBase.MyProgramDirectory + "\Resource\SQLOperators.txt", RichTextBoxStreamType.PlainText)

                    Dim STROKA As String
                    For i As Integer = 0 To RichTextBox2.Lines.Length - 1 'колличество строк
                        ListBox1.Items.Add(RichTextBox2.Lines.GetValue(i)) 'получаем строку
                    Next
                    RichTextBox2.Clear()
                Else
                    MsgBox("ОШИБКА: Программа не смогла найти файл " + ModuleBase.MyProgramDirectory + "\Resource\SQLOperators.txt", MsgBoxStyle.OKOnly, "Сообщение:")
                End If
            End If
            '--------------------------------------------------
            Proces.Close()
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.OKOnly, "Произошла ошибка!")
        End Try
    End Sub

    Public Sub ModuleFormatVersionHTML()
        Dim Proces As New Processed
        Proces.MdiParent = ModulePE.ProgrammPE.ActiveForm
        Proces.Show()
        ModulePE.ProgrammPE.Update()
        Proces.Update()

        RichTextBox2.Clear()
        RichTextBox2.Text = RichTextBox1.Text
        Dim strRTF As String = RichTextBox2.Rtf
        RichTextBox1.Rtf = ""
        RichTextBox1.Clear()

        Dim iCTableStart As Integer = strRTF.IndexOf("}")
        strRTF = strRTF.Insert(iCTableStart + 1, "{\colortbl ;\red200\green0\blue0;\red0\green0\blue255;\red0\green0\blue0;}")
        ' cf1 = красный  
        ' cf2 = Синий
        ' cf3 = черный


        Dim AllChar As Integer = strRTF.Length - 1
        Dim i As Integer = 0
        Dim Open As Boolean = False
        Dim OpenK As Boolean = False

        While i < AllChar

            If (strRTF.Chars(i) = "<") Then
                strRTF = strRTF.Insert(i, "\cf1 ")
                i += 5
                AllChar += 5
                strRTF = strRTF.Insert(i + 1, "\cf2 ")
                AllChar += 5
                Open = True
            End If
            If (strRTF.Chars(i) = ">") Then
                strRTF = strRTF.Insert(i, "\cf1 ")
                i += 5
                AllChar += 5
                strRTF = strRTF.Insert(i + 1, "\cf3 ")
                AllChar += 5
                Open = False
            End If
            If (strRTF.Chars(i) = """") And (OpenK = False) Then
                strRTF = strRTF.Insert(i, "\cf1 ")
                i += 5
                AllChar += 5
                strRTF = strRTF.Insert(i + 1, "\cf3 ")
                AllChar += 5
                OpenK = True
            Else
                If (strRTF.Chars(i) = """") And (OpenK = True) Then
                    strRTF = strRTF.Insert(i, "\cf1 ")
                    i += 5
                    AllChar += 5
                    strRTF = strRTF.Insert(i + 1, "\cf2 ")
                    AllChar += 5
                    OpenK = False
                End If
            End If

            If (Open = False) Then
                If (strRTF.Chars(i) = "/") Then
                    strRTF = strRTF.Insert(i, "\cf1 ")
                    i += 5
                    AllChar += 5
                    strRTF = strRTF.Insert(i + 1, "\cf3 ")
                    AllChar += 5
                End If
                If (strRTF.Chars(i) = "?") Then
                    strRTF = strRTF.Insert(i, "\cf1 ")
                    i += 5
                    AllChar += 5
                    strRTF = strRTF.Insert(i + 1, "\cf3 ")
                    AllChar += 5
                End If
                If (strRTF.Chars(i) = "(") Or (strRTF.Chars(i) = ")") Then
                    strRTF = strRTF.Insert(i, "\cf1 ")
                    i += 5
                    AllChar += 5
                    strRTF = strRTF.Insert(i + 1, "\cf3 ")
                    AllChar += 5
                End If
                If (strRTF.Chars(i) = """") Or (strRTF.Chars(i) = "#") Then
                    strRTF = strRTF.Insert(i, "\cf1 ")
                    i += 5
                    AllChar += 5
                    strRTF = strRTF.Insert(i + 1, "\cf3 ")
                    AllChar += 5
                End If
                If (strRTF.Chars(i) = "$") Or (strRTF.Chars(i) = "=") Then
                    strRTF = strRTF.Insert(i, "\cf1 ")
                    i += 5
                    AllChar += 5
                    strRTF = strRTF.Insert(i + 1, "\cf3 ")
                    AllChar += 5
                End If
                If (strRTF.Chars(i) = "*") Or (strRTF.Chars(i) = "&") Then
                    strRTF = strRTF.Insert(i, "\cf1 ")
                    i += 5
                    AllChar += 5
                    strRTF = strRTF.Insert(i + 1, "\cf3 ")
                    AllChar += 5
                End If
            End If

            i += 1

        End While
        Proces.Close()
        RichTextBox1.Rtf = strRTF

        RichTextBox1.SelectionStart = 0
        RichTextBox1.SelectionLength = 0
        RichTextBox1.SelectionColor = Color.Black
    End Sub

    Public Sub ModuleFormatVersionPHP()
        Dim Proces As New Processed
        Proces.MdiParent = ModulePE.ProgrammPE.ActiveForm
        Proces.Show()
        ModulePE.ProgrammPE.Update()
        Proces.Update()

        RichTextBox2.Clear()
        RichTextBox2.Text = RichTextBox1.Text
        Dim strRTF As String = RichTextBox2.Rtf
        RichTextBox1.Rtf = ""
        RichTextBox1.Clear()

        Dim iCTableStart As Integer = strRTF.IndexOf("}")
        strRTF = strRTF.Insert(iCTableStart + 1, "{\colortbl ;\red200\green0\blue0;\red0\green0\blue255;\red0\green0\blue0;}")
        ' cf1 = красный  
        ' cf2 = Синий
        ' cf3 = черный


        Dim AllChar As Integer = strRTF.Length - 1
        Dim i As Integer = 0
        Dim Open As Boolean = False
        Dim OpenK As Boolean = False

        While i < AllChar

            If (strRTF.Chars(i) = "<") Then
                strRTF = strRTF.Insert(i, "\cf1 ")
                i += 5
                AllChar += 5
                strRTF = strRTF.Insert(i + 1, "\cf2 ")
                AllChar += 5
                Open = True
            End If
            If (strRTF.Chars(i) = ">") Then
                strRTF = strRTF.Insert(i, "\cf1 ")
                i += 5
                AllChar += 5
                strRTF = strRTF.Insert(i + 1, "\cf3 ")
                AllChar += 5
                Open = False
            End If
            If (strRTF.Chars(i) = """") And (OpenK = False) Then
                strRTF = strRTF.Insert(i, "\cf1 ")
                i += 5
                AllChar += 5
                strRTF = strRTF.Insert(i + 1, "\cf3 ")
                AllChar += 5
                OpenK = True
            Else
                If (strRTF.Chars(i) = """") And (OpenK = True) Then
                    strRTF = strRTF.Insert(i, "\cf1 ")
                    i += 5
                    AllChar += 5
                    strRTF = strRTF.Insert(i + 1, "\cf2 ")
                    AllChar += 5
                    OpenK = False
                End If
            End If
            If (strRTF.Chars(i) = "?") Then
                strRTF = strRTF.Insert(i, "\cf1 ")
                i += 5
                AllChar += 5
                strRTF = strRTF.Insert(i + 1, "\cf3 ")
                AllChar += 5
            End If

            If (Open = False) Then
                If (strRTF.Chars(i) = "/") Then
                    strRTF = strRTF.Insert(i, "\cf1 ")
                    i += 5
                    AllChar += 5
                    strRTF = strRTF.Insert(i + 1, "\cf3 ")
                    AllChar += 5
                End If
                If (strRTF.Chars(i) = "?") Then
                    strRTF = strRTF.Insert(i, "\cf1 ")
                    i += 5
                    AllChar += 5
                    strRTF = strRTF.Insert(i + 1, "\cf3 ")
                    AllChar += 5
                End If
                If (strRTF.Chars(i) = "(") Or (strRTF.Chars(i) = ")") Then
                    strRTF = strRTF.Insert(i, "\cf1 ")
                    i += 5
                    AllChar += 5
                    strRTF = strRTF.Insert(i + 1, "\cf3 ")
                    AllChar += 5
                End If
                If (strRTF.Chars(i) = """") Or (strRTF.Chars(i) = "#") Then
                    strRTF = strRTF.Insert(i, "\cf1 ")
                    i += 5
                    AllChar += 5
                    strRTF = strRTF.Insert(i + 1, "\cf3 ")
                    AllChar += 5
                End If
                If (strRTF.Chars(i) = "$") Or (strRTF.Chars(i) = "=") Then
                    strRTF = strRTF.Insert(i, "\cf1 ")
                    i += 5
                    AllChar += 5
                    strRTF = strRTF.Insert(i + 1, "\cf3 ")
                    AllChar += 5
                End If
                If (strRTF.Chars(i) = "*") Or (strRTF.Chars(i) = "&") Then
                    strRTF = strRTF.Insert(i, "\cf1 ")
                    i += 5
                    AllChar += 5
                    strRTF = strRTF.Insert(i + 1, "\cf3 ")
                    AllChar += 5
                End If
            End If

            i += 1

        End While
        Proces.Close()
        RichTextBox1.Rtf = strRTF

        RichTextBox1.SelectionStart = 0
        RichTextBox1.SelectionLength = 0
        RichTextBox1.SelectionColor = Color.Black
    End Sub

    Public Sub ModuleFormatVersion1_1_8()
        Dim Proces As New Processed
        Proces.MdiParent = ModulePE.ProgrammPE.ActiveForm
        Proces.Show()
        ModulePE.ProgrammPE.Update()
        Proces.Update()

        RichTextBox2.Clear()
        RichTextBox2.Text = RichTextBox1.Text
        Dim strRTF As String = RichTextBox2.Rtf
        RichTextBox1.Rtf = ""
        RichTextBox1.Clear()

        Dim iCTableStart As Integer = strRTF.IndexOf("}")
        'strRTF = strRTF.Insert(iCTableStart + 1, "{\colortbl ;\red255\green0\blue0;\red0\green0\blue0;\red0\green0\blue0;}")
        strRTF = strRTF.Insert(iCTableStart + 1, "{\colortbl ;\red200\green0\blue0;\red0\green128\blue0;\red0\green0\blue0;}")
        ' cf1 = красный  
        ' cf2 = черный
        ' cf3 = черный


        Dim AllChar As Integer = strRTF.Length - 1
        Dim i As Integer = 0
        While i < AllChar

            If (strRTF.Chars(i) = "<") Then
                strRTF = strRTF.Insert(i, "\cf1 ")
                i += 5
                AllChar += 5
                strRTF = strRTF.Insert(i + 1, "\cf3 ")
                AllChar += 5
            End If
            If (strRTF.Chars(i) = ">") Then
                strRTF = strRTF.Insert(i, "\cf1 ")
                i += 5
                AllChar += 5
                strRTF = strRTF.Insert(i + 1, "\cf3 ")
                AllChar += 5
            End If
            If (strRTF.Chars(i) = "/") And (strRTF.Chars(i + 1) <> "*") Then
                strRTF = strRTF.Insert(i, "\cf1 ")
                i += 5
                AllChar += 5
                strRTF = strRTF.Insert(i + 1, "\cf3 ")
                AllChar += 5
            End If
            If (strRTF.Chars(i) = "?") Then
                strRTF = strRTF.Insert(i, "\cf1 ")
                i += 5
                AllChar += 5
                strRTF = strRTF.Insert(i + 1, "\cf3 ")
                AllChar += 5
            End If
            If (strRTF.Chars(i) = "(") Or (strRTF.Chars(i) = ")") Then
                strRTF = strRTF.Insert(i, "\cf1 ")
                i += 5
                AllChar += 5
                strRTF = strRTF.Insert(i + 1, "\cf3 ")
                AllChar += 5
            End If
            If (strRTF.Chars(i) = """") Or (strRTF.Chars(i) = "#") Then
                strRTF = strRTF.Insert(i, "\cf1 ")
                i += 5
                AllChar += 5
                strRTF = strRTF.Insert(i + 1, "\cf3 ")
                AllChar += 5
            End If
            If (strRTF.Chars(i) = "$") Or (strRTF.Chars(i) = "=") Then
                strRTF = strRTF.Insert(i, "\cf1 ")
                i += 5
                AllChar += 5
                strRTF = strRTF.Insert(i + 1, "\cf3 ")
                AllChar += 5
            End If
            If (strRTF.Chars(i) = "&") Then
                strRTF = strRTF.Insert(i, "\cf1 ")
                i += 5
                AllChar += 5
                strRTF = strRTF.Insert(i + 1, "\cf3 ")
                AllChar += 5
            End If
            If (strRTF.Chars(i) = "*") And (strRTF.Chars(i + 1) = "/") Then
                strRTF = strRTF.Insert(i, "\cf1 ")
                i += 5
                AllChar += 5
                strRTF = strRTF.Insert(i + 1, "\cf3 ")
                AllChar += 5
            End If
            If (strRTF.Chars(i) = "/") And (strRTF.Chars(i + 1) = "*") Then
                strRTF = strRTF.Insert(i, "\cf2 ")
                i += 5
                AllChar += 5
                strRTF = strRTF.Insert(i + 1, "\cf2 ")
                AllChar += 5
            End If
            If (strRTF.Chars(i) = "*") And (strRTF.Chars(i + 1) = "/") Then
                strRTF = strRTF.Insert(i, "\cf2 ")
                i += 5
                AllChar += 5
                strRTF = strRTF.Insert(i + 2, "\cf3 ")
                AllChar += 5
            End If
            i += 1

        End While
        Proces.Close()
        RichTextBox1.Rtf = strRTF

        RichTextBox1.SelectionStart = 0
        RichTextBox1.SelectionLength = 0
        RichTextBox1.SelectionColor = Color.Black
    End Sub

    Private Sub EditFile_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        ModulePE.ProgrammPE.StatusBarPanel4.Text = MyFileName + " [" + MyID.ToString + "]"
    End Sub

    Private Sub RichTextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RichTextBox1.TextChanged
        Try
            Dim nStr, nChar As Integer
            nStr = RichTextBox1.GetLineFromCharIndex(RichTextBox1.SelectionStart) + 1
            StatusBarPanel2.Text = "Строка : " + nStr.ToString
            Me.Icon = ModulePE.ProgrammPE.NotifyIcon2.Icon
        Catch ex As Exception
            'MsgBox(ex.ToString, MsgBoxStyle.OKOnly, "Произошла ошибка!")
        End Try
    End Sub

    Private Sub RichTextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles RichTextBox1.KeyPress
        Try
            Me.Icon = ModulePE.ProgrammPE.NotifyIcon2.Icon
            If (e.KeyChar.GetHashCode = 851981) Then
                Dim nStr, nChar As Integer
                nStr = RichTextBox1.GetLineFromCharIndex(RichTextBox1.SelectionStart) + 1
                StatusBarPanel2.Text = "Строка : " + nStr.ToString
            End If
        Catch ex As Exception
            'MsgBox(ex.ToString, MsgBoxStyle.OKOnly, "Произошла ошибка!")
        End Try
    End Sub


    Private Sub RichTextBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles RichTextBox1.KeyDown
        Try
            If (e.Control = True) And (e.KeyValue = 32) Then
                Dim WindowH, WindowW, smallWinH, smallWinW As Integer
                WindowH = Me.Height
                WindowW = Me.Width
                smallWinH = RichTextBox1.GetPositionFromCharIndex(RichTextBox1.SelectionStart).Y + 150 + Panel6.Height
                smallWinW = RichTextBox1.GetPositionFromCharIndex(RichTextBox1.SelectionStart).X + Panel6.Width
                If (WindowH < smallWinH) Then
                    If (WindowW < smallWinW) Then 'Право - Низ
                        TextBox2.Left = 0
                        TextBox2.Top = 81
                        ListBox1.Left = 0
                        ListBox1.Top = 0
                        Panel6.Left = RichTextBox1.GetPositionFromCharIndex(RichTextBox1.SelectionStart).X - 200
                        Panel6.Top = RichTextBox1.GetPositionFromCharIndex(RichTextBox1.SelectionStart).Y
                        TextBox2.RightToLeft = RightToLeft.Yes
                        Panel6.Visible = True
                        TextBox2.Focus()
                    Else 'Лево - Низ
                        TextBox2.Left = 0
                        TextBox2.Top = 81
                        ListBox1.Left = 0
                        ListBox1.Top = 0
                        Panel6.Left = RichTextBox1.GetPositionFromCharIndex(RichTextBox1.SelectionStart).X
                        Panel6.Top = RichTextBox1.GetPositionFromCharIndex(RichTextBox1.SelectionStart).Y
                        TextBox2.RightToLeft = RightToLeft.No
                        Panel6.Visible = True
                        TextBox2.Focus()
                    End If
                Else
                    If (WindowW < smallWinW) Then 'Право - Вверх
                        TextBox2.Left = 0
                        TextBox2.Top = 0
                        ListBox1.Left = 0
                        ListBox1.Top = 21
                        Panel6.Left = RichTextBox1.GetPositionFromCharIndex(RichTextBox1.SelectionStart).X - 200
                        Panel6.Top = RichTextBox1.GetPositionFromCharIndex(RichTextBox1.SelectionStart).Y + 80
                        TextBox2.RightToLeft = RightToLeft.Yes
                        Panel6.Visible = True
                        TextBox2.Focus()
                    Else 'Лево - Вверх
                        TextBox2.Left = 0
                        TextBox2.Top = 0
                        ListBox1.Left = 0
                        ListBox1.Top = 21
                        Panel6.Left = RichTextBox1.GetPositionFromCharIndex(RichTextBox1.SelectionStart).X
                        Panel6.Top = RichTextBox1.GetPositionFromCharIndex(RichTextBox1.SelectionStart).Y + 80
                        TextBox2.RightToLeft = RightToLeft.No
                        Panel6.Visible = True
                        TextBox2.Focus()
                    End If
                End If

            End If
            If (e.KeyData = Keys.Escape) Then 'закрытие без выбора
                Panel6.Visible = False
                ListBox1.SelectedIndex = 0
                TextBox2.Text = ""
                'RichTextBox1.SelectionStart = RichTextBox1.SelectionStart - 1
                'RichTextBox1.SelectionLength = 1
                ListFocus = False
                RichTextBox1.Focus()
            End If
            If (e.KeyValue > 64) And (e.KeyValue <> 67) And (e.KeyValue <> 86) And (e.KeyValue <> 88) And (e.KeyValue < 91) Then 'символы черным цветом
                RichTextBox1.SelectionColor = Color.Black
            End If
            If (e.KeyData = Keys.Enter) Then
                'ВЫДИЛЕНИЕ СПЕЦСИМВОЛОВ ЦВЕТОМ
                Dim BeginOperator, EndOperator As Integer
                EndOperator = RichTextBox1.SelectionStart
                BeginOperator = EndOperator - 1
                RichTextBox1.SelectionStart = BeginOperator
                RichTextBox1.SelectionLength = 1

                If (RichTextBox1.SelectedText = "0") Then
                    RichTextBox1.SelectionColor = Color.FromArgb(ModulePE.Color01)
                End If
                If (RichTextBox1.SelectedText = "1") Then
                    RichTextBox1.SelectionColor = Color.FromArgb(ModulePE.Color01)
                End If
                If (RichTextBox1.SelectedText = "2") Then
                    RichTextBox1.SelectionColor = Color.FromArgb(ModulePE.Color01)
                End If
                If (RichTextBox1.SelectedText = "3") Then
                    RichTextBox1.SelectionColor = Color.FromArgb(ModulePE.Color01)
                End If
                If (RichTextBox1.SelectedText = "4") Then
                    RichTextBox1.SelectionColor = Color.FromArgb(ModulePE.Color01)
                End If
                If (RichTextBox1.SelectedText = "5") Then
                    RichTextBox1.SelectionColor = Color.FromArgb(ModulePE.Color01)
                End If
                If (RichTextBox1.SelectedText = "6") Then
                    RichTextBox1.SelectionColor = Color.FromArgb(ModulePE.Color01)
                End If
                If (RichTextBox1.SelectedText = "7") Then
                    RichTextBox1.SelectionColor = Color.FromArgb(ModulePE.Color01)
                End If
                If (RichTextBox1.SelectedText = "8") Then
                    RichTextBox1.SelectionColor = Color.FromArgb(ModulePE.Color01)
                End If
                If (RichTextBox1.SelectedText = "9") Then
                    RichTextBox1.SelectionColor = Color.FromArgb(ModulePE.Color01)
                End If
                If (RichTextBox1.SelectedText = "(") Then
                    RichTextBox1.SelectionColor = Color.FromArgb(ModulePE.Color02)
                End If
                If (RichTextBox1.SelectedText = "!") Then
                    RichTextBox1.SelectionColor = Color.FromArgb(ModulePE.Color03)
                End If
                If (RichTextBox1.SelectedText = "@") Then
                    RichTextBox1.SelectionColor = Color.FromArgb(ModulePE.Color04)
                End If
                If (RichTextBox1.SelectedText = "#") Then
                    RichTextBox1.SelectionColor = Color.FromArgb(ModulePE.Color05)
                End If
                If (RichTextBox1.SelectedText = "$") Then
                    RichTextBox1.SelectionColor = Color.FromArgb(ModulePE.Color06)
                End If
                If (RichTextBox1.SelectedText = "%") Then
                    RichTextBox1.SelectionColor = Color.FromArgb(ModulePE.Color07)
                End If
                If (RichTextBox1.SelectedText = "^") Then
                    RichTextBox1.SelectionColor = Color.FromArgb(ModulePE.Color08)
                End If
                If (RichTextBox1.SelectedText = "&") Then
                    RichTextBox1.SelectionColor = Color.FromArgb(ModulePE.Color09)
                End If
                If (RichTextBox1.SelectedText = ")") Then
                    RichTextBox1.SelectionColor = Color.FromArgb(ModulePE.Color10)
                End If
                If (RichTextBox1.SelectedText = "*") Then
                    RichTextBox1.SelectionColor = Color.FromArgb(ModulePE.Color11)
                End If
                If (RichTextBox1.SelectedText = "-") Then
                    RichTextBox1.SelectionColor = Color.FromArgb(ModulePE.Color12)
                End If
                If (RichTextBox1.SelectedText = "_") Then
                    RichTextBox1.SelectionColor = Color.FromArgb(ModulePE.Color13)
                End If
                If (RichTextBox1.SelectedText = "=") Then
                    RichTextBox1.SelectionColor = Color.FromArgb(ModulePE.Color14)
                End If
                If (RichTextBox1.SelectedText = "+") Then
                    RichTextBox1.SelectionColor = Color.FromArgb(ModulePE.Color15)
                End If
                If (RichTextBox1.SelectedText = "|") Then
                    RichTextBox1.SelectionColor = Color.FromArgb(ModulePE.Color16)
                End If
                If (RichTextBox1.SelectedText = "?") Then
                    RichTextBox1.SelectionColor = Color.FromArgb(ModulePE.Color17)
                End If
                If (RichTextBox1.SelectedText = "{") Then
                    RichTextBox1.SelectionColor = Color.FromArgb(ModulePE.Color18)
                End If
                If (RichTextBox1.SelectedText = "[") Then
                    RichTextBox1.SelectionColor = Color.FromArgb(ModulePE.Color19)
                End If
                If (RichTextBox1.SelectedText = ";") Then
                    RichTextBox1.SelectionColor = Color.FromArgb(ModulePE.Color20)
                End If
                If (RichTextBox1.SelectedText = "'") Then
                    RichTextBox1.SelectionColor = Color.FromArgb(ModulePE.Color21)
                End If
                If (RichTextBox1.SelectedText = "\") Then
                    RichTextBox1.SelectionColor = Color.FromArgb(ModulePE.Color22)
                End If
                If (RichTextBox1.SelectedText = "<") Then
                    RichTextBox1.SelectionColor = Color.FromArgb(ModulePE.Color23)
                End If
                If (RichTextBox1.SelectedText = ",") Then
                    RichTextBox1.SelectionColor = Color.FromArgb(ModulePE.Color24)
                End If
                If (RichTextBox1.SelectedText = "}") Then
                    RichTextBox1.SelectionColor = Color.FromArgb(ModulePE.Color25)
                End If
                If (RichTextBox1.SelectedText = "]") Then
                    RichTextBox1.SelectionColor = Color.FromArgb(ModulePE.Color26)
                End If
                If (RichTextBox1.SelectedText = ":") Then
                    RichTextBox1.SelectionColor = Color.FromArgb(ModulePE.Color27)
                End If
                If (RichTextBox1.SelectedText = """") Then
                    RichTextBox1.SelectionColor = Color.FromArgb(ModulePE.Color28)
                End If
                If (RichTextBox1.SelectedText = "/") Then
                    RichTextBox1.SelectionColor = Color.FromArgb(ModulePE.Color29)
                End If
                If (RichTextBox1.SelectedText = ">") Then
                    RichTextBox1.SelectionColor = Color.FromArgb(ModulePE.Color30)
                End If
                If (RichTextBox1.SelectedText = ".") Then
                    RichTextBox1.SelectionColor = Color.FromArgb(ModulePE.Color31)
                End If
                If (RichTextBox1.SelectedText = " ") Then
                    RichTextBox1.SelectionColor = Color.Black
                End If

                RichTextBox1.SelectionStart = EndOperator
                RichTextBox1.SelectionLength = 0
                RichTextBox1.SelectionColor = Color.Black
                '---------------------------------------
            Else
                If (e.KeyData = Keys.Space) Then 'пробел
                    RichTextBox1.SelectionColor = Color.Black
                End If
                'RichTextBox1.SelectionColor = Color.Black
            End If
        Catch ex As Exception
            'MsgBox(ex.ToString, MsgBoxStyle.OKOnly, "Произошла ошибка!")
        End Try
    End Sub

    Private Sub RichTextBox1_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles RichTextBox1.KeyUp
        Try
            If (e.KeyData <> Keys.Delete) Or (e.KeyData <> Keys.Shift) Then
                If (e.KeyValue > 95) And (e.KeyValue < 112) Or (e.KeyValue = 48) Or (e.KeyValue = 49) Or (e.KeyValue = 50) Or (e.KeyValue = 51) Or (e.KeyValue = 52) Or (e.KeyValue = 53) Or (e.KeyValue = 54) Or (e.KeyValue = 55) Or (e.KeyValue = 56) Or (e.KeyValue = 57) Or (e.KeyValue = 189) Or (e.KeyValue = 187) Or (e.KeyValue = 219) Or (e.KeyValue = 221) Or (e.KeyValue = 186) Or (e.KeyValue = 222) Or (e.KeyValue = 220) Or (e.KeyValue = 188) Or (e.KeyValue = 190) Or (e.KeyValue = 191) Then
                    'ВЫДИЛЕНИЕ СПЕЦСИМВОЛОВ ЦВЕТОМ
                    Dim BeginOperator, EndOperator As Integer
                    EndOperator = RichTextBox1.SelectionStart
                    BeginOperator = EndOperator - 1
                    RichTextBox1.SelectionStart = BeginOperator
                    RichTextBox1.SelectionLength = 1

                    RichTextBox1.SelectionColor = Color.Black
                    RichTextBox1.SelectionColor = Color.Black
                    RichTextBox1.SelectionColor = Color.Black
                    If (RichTextBox1.SelectedText = "0") Then
                        RichTextBox1.SelectionColor = Color.FromArgb(ModulePE.Color01)
                    End If
                    If (RichTextBox1.SelectedText = "1") Then
                        RichTextBox1.SelectionColor = Color.FromArgb(ModulePE.Color01)
                    End If
                    If (RichTextBox1.SelectedText = "2") Then
                        RichTextBox1.SelectionColor = Color.FromArgb(ModulePE.Color01)
                    End If
                    If (RichTextBox1.SelectedText = "3") Then
                        RichTextBox1.SelectionColor = Color.FromArgb(ModulePE.Color01)
                    End If
                    If (RichTextBox1.SelectedText = "4") Then
                        RichTextBox1.SelectionColor = Color.FromArgb(ModulePE.Color01)
                    End If
                    If (RichTextBox1.SelectedText = "5") Then
                        RichTextBox1.SelectionColor = Color.FromArgb(ModulePE.Color01)
                    End If
                    If (RichTextBox1.SelectedText = "6") Then
                        RichTextBox1.SelectionColor = Color.FromArgb(ModulePE.Color01)
                    End If
                    If (RichTextBox1.SelectedText = "7") Then
                        RichTextBox1.SelectionColor = Color.FromArgb(ModulePE.Color01)
                    End If
                    If (RichTextBox1.SelectedText = "8") Then
                        RichTextBox1.SelectionColor = Color.FromArgb(ModulePE.Color01)
                    End If
                    If (RichTextBox1.SelectedText = "9") Then
                        RichTextBox1.SelectionColor = Color.FromArgb(ModulePE.Color01)
                    End If
                    If (RichTextBox1.SelectedText = "(") Then
                        RichTextBox1.SelectionColor = Color.FromArgb(ModulePE.Color02)
                    End If
                    If (RichTextBox1.SelectedText = "!") Then
                        RichTextBox1.SelectionColor = Color.FromArgb(ModulePE.Color03)
                    End If
                    If (RichTextBox1.SelectedText = "@") Then
                        RichTextBox1.SelectionColor = Color.FromArgb(ModulePE.Color04)
                    End If
                    If (RichTextBox1.SelectedText = "#") Then
                        RichTextBox1.SelectionColor = Color.FromArgb(ModulePE.Color05)
                    End If
                    If (RichTextBox1.SelectedText = "$") Then
                        RichTextBox1.SelectionColor = Color.FromArgb(ModulePE.Color06)
                    End If
                    If (RichTextBox1.SelectedText = "%") Then
                        RichTextBox1.SelectionColor = Color.FromArgb(ModulePE.Color07)
                    End If
                    If (RichTextBox1.SelectedText = "^") Then
                        RichTextBox1.SelectionColor = Color.FromArgb(ModulePE.Color08)
                    End If
                    If (RichTextBox1.SelectedText = "&") Then
                        RichTextBox1.SelectionColor = Color.FromArgb(ModulePE.Color09)
                    End If
                    If (RichTextBox1.SelectedText = ")") Then
                        RichTextBox1.SelectionColor = Color.FromArgb(ModulePE.Color10)
                    End If
                    If (RichTextBox1.SelectedText = "*") Then
                        RichTextBox1.SelectionColor = Color.FromArgb(ModulePE.Color11)
                    End If
                    If (RichTextBox1.SelectedText = "-") Then
                        RichTextBox1.SelectionColor = Color.FromArgb(ModulePE.Color12)
                    End If
                    If (RichTextBox1.SelectedText = "_") Then
                        RichTextBox1.SelectionColor = Color.FromArgb(ModulePE.Color13)
                    End If
                    If (RichTextBox1.SelectedText = "=") Then
                        RichTextBox1.SelectionColor = Color.FromArgb(ModulePE.Color14)
                    End If
                    If (RichTextBox1.SelectedText = "+") Then
                        RichTextBox1.SelectionColor = Color.FromArgb(ModulePE.Color15)
                    End If
                    If (RichTextBox1.SelectedText = "|") Then
                        RichTextBox1.SelectionColor = Color.FromArgb(ModulePE.Color16)
                    End If
                    If (RichTextBox1.SelectedText = "?") Then
                        RichTextBox1.SelectionColor = Color.FromArgb(ModulePE.Color17)
                    End If
                    If (RichTextBox1.SelectedText = "{") Then
                        RichTextBox1.SelectionColor = Color.FromArgb(ModulePE.Color18)
                    End If
                    If (RichTextBox1.SelectedText = "[") Then
                        RichTextBox1.SelectionColor = Color.FromArgb(ModulePE.Color19)
                    End If
                    If (RichTextBox1.SelectedText = ";") Then
                        RichTextBox1.SelectionColor = Color.FromArgb(ModulePE.Color20)
                    End If
                    If (RichTextBox1.SelectedText = "'") Then
                        RichTextBox1.SelectionColor = Color.FromArgb(ModulePE.Color21)
                    End If
                    If (RichTextBox1.SelectedText = "\") Then
                        RichTextBox1.SelectionColor = Color.FromArgb(ModulePE.Color22)
                    End If
                    If (RichTextBox1.SelectedText = "<") Then
                        RichTextBox1.SelectionColor = Color.FromArgb(ModulePE.Color23)
                    End If
                    If (RichTextBox1.SelectedText = ",") Then
                        RichTextBox1.SelectionColor = Color.FromArgb(ModulePE.Color24)
                    End If
                    If (RichTextBox1.SelectedText = "}") Then
                        RichTextBox1.SelectionColor = Color.FromArgb(ModulePE.Color25)
                    End If
                    If (RichTextBox1.SelectedText = "]") Then
                        RichTextBox1.SelectionColor = Color.FromArgb(ModulePE.Color26)
                    End If
                    If (RichTextBox1.SelectedText = ":") Then
                        RichTextBox1.SelectionColor = Color.FromArgb(ModulePE.Color27)
                    End If
                    If (RichTextBox1.SelectedText = """") Then
                        RichTextBox1.SelectionColor = Color.FromArgb(ModulePE.Color28)
                    End If
                    If (RichTextBox1.SelectedText = "/") Then
                        RichTextBox1.SelectionColor = Color.FromArgb(ModulePE.Color29)
                    End If
                    If (RichTextBox1.SelectedText = ">") Then
                        RichTextBox1.SelectionColor = Color.FromArgb(ModulePE.Color30)
                    End If
                    If (RichTextBox1.SelectedText = ".") Then
                        RichTextBox1.SelectionColor = Color.FromArgb(ModulePE.Color31)
                    End If
                    If (RichTextBox1.SelectedText = " ") Then
                        RichTextBox1.SelectionColor = Color.Black
                    End If

                    RichTextBox1.SelectionStart = EndOperator
                    RichTextBox1.SelectionLength = 0
                    RichTextBox1.SelectionColor = Color.Black
                    '---------------------------------------
                End If
            End If
            Dim nStr, nChar As Integer
            nStr = RichTextBox1.GetLineFromCharIndex(RichTextBox1.SelectionStart) + 1
            StatusBarPanel2.Text = "Строка : " + nStr.ToString
        Catch ex As Exception
            'MsgBox(ex.ToString, MsgBoxStyle.OKOnly, "Произошла ошибка!")
        End Try
    End Sub

    Private Sub RichTextBox1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles RichTextBox1.MouseMove
        Try
            Dim nStr, nChar As Integer
            nStr = RichTextBox1.GetLineFromCharIndex(RichTextBox1.SelectionStart) + 1
            StatusBarPanel2.Text = "Строка : " + nStr.ToString
            Label3.BorderStyle = BorderStyle.None
            Label11.BorderStyle = BorderStyle.None
            Label2.BorderStyle = BorderStyle.None
            ModulePE.ProgrammPE.StatusBarPanel4.Text = MyFileName + " [" + MyID.ToString + "]"
        Catch ex As Exception
            'MsgBox(ex.ToString, MsgBoxStyle.OKOnly, "Произошла ошибка!")
        End Try
    End Sub

    Dim FindIndex As Integer = 0
    Dim FindText As String
    Dim FindLast As Integer = 0
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            If (FindText <> TextBox1.Text) Then
                FindIndex = 0
                FindLast = 0
                FindText = TextBox1.Text
            End If
            If (RichTextBox1.Find(TextBox1.Text, FindIndex, RichTextBox1.TextLength - 1, RichTextBoxFinds.None)) Then
                RichTextBox1.Select()
                FindIndex = RichTextBox1.SelectionStart + RichTextBox1.SelectionLength
                If (FindLast = RichTextBox1.SelectionStart) Then
                    MsgBox("Поиск завершен.", MsgBoxStyle.OKOnly, "Сообщение:")
                    FindIndex = 0
                    FindLast = 0
                    FindText = TextBox1.Text
                Else
                    FindLast = RichTextBox1.SelectionStart
                End If
            End If
        Catch ex As Exception
            'MsgBox(ex.ToString, MsgBoxStyle.OKOnly, "Произошла ошибка!")
        End Try
    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged
        'Ввод текста

    End Sub

    Private Sub TextBox2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox2.KeyDown
        Try
            If (e.KeyData = Keys.Escape) Then 'закрытие без выбора
                Panel6.Visible = False
                TextBox2.Text = ""
                ListBox1.SelectedIndex = 0
                RichTextBox1.SelectionStart = RichTextBox1.SelectionStart - 1
                RichTextBox1.SelectionLength = 1
                RichTextBox1.Focus()
            End If
            If (e.KeyData = Keys.Down) Or (e.KeyData = Keys.Up) Or (e.KeyData = Keys.PageUp) Or (e.KeyData = Keys.PageDown) Then 'переход к списку выбора
                ListFocus = True
                ListBox1.Focus()
            End If
            If (e.KeyData = Keys.Enter) Then
                If (ListBox1.SelectedIndex < 0) Then
                    RichTextBox1.SelectionStart = RichTextBox1.SelectionStart - 1
                    RichTextBox1.SelectionLength = 1
                    If (RadioButton1.Checked = True) Then
                        FormatTextHTML(TextBox2.Text)
                    Else
                        FormatText(TextBox2.Text)
                    End If
                    Panel6.Visible = False
                    ListBox1.SelectedIndex = 0
                    TextBox2.Text = ""
                    RichTextBox1.Focus()
                Else
                    RichTextBox1.SelectionStart = RichTextBox1.SelectionStart - 1
                    RichTextBox1.SelectionLength = 1
                    FormatText(ListBox1.Items.Item(ListBox1.SelectedIndex))
                    Panel6.Visible = False
                    ListBox1.SelectedIndex = 0
                    TextBox2.Text = ""
                    RichTextBox1.Focus()
                End If

            End If
        Catch ex As Exception 'В СЛУЧАЕ ОШИБКИ
            RichTextBox1.SelectionStart = RichTextBox1.SelectionStart - 1
            RichTextBox1.SelectionLength = 1
            FormatText(ListBox1.Items.Item(ListBox1.SelectedIndex))
            Panel6.Visible = False
            ListBox1.SelectedIndex = 0
            TextBox2.Text = ""
            RichTextBox1.Focus()
        End Try
    End Sub

    Private Sub TextBox2_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox2.KeyUp
        If (e.KeyCode <> 16 And e.KeyCode <> 17) Then 'игнорировать SHIFT
            Dim Find As String
            Dim CountChar As Integer
            Dim InputOperator As String
            CountChar = TextBox2.TextLength

            For i As Integer = 0 To ListBox1.Items.Count - 1

                Find = ListBox1.Items.Item(i)
                If (Find.Length >= CountChar) Then
                    For j As Integer = 0 To CountChar - 1 'Find.Length - 1
                        InputOperator = InputOperator + Find.Chars(j)
                    Next
                End If

                Me.Update()
                Panel6.Update()
                ListBox1.Update()
                If (TextBox2.Text = InputOperator) Then 'если находит
                    ListBox1.SelectedIndex = i
                    Me.Update()
                    Panel6.Update()
                    ListBox1.Update()
                    Exit For
                Else
                    InputOperator = ""
                End If
            Next
        End If
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
        'при выборе значения
        If (ListFocus = True) Then
            TextBox2.Text = ListBox1.Items.Item(ListBox1.SelectedIndex)
        End If
    End Sub

    Private Sub ListBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ListBox1.KeyDown
        If (e.KeyData = Keys.Escape) Then
            ListFocus = False
            TextBox2.Focus()
        End If
        If (e.KeyData = Keys.Enter) Then
            RichTextBox1.SelectionStart = RichTextBox1.SelectionStart - 1
            RichTextBox1.SelectionLength = 1
            If (RadioButton1.Checked = True) Then
                FormatTextHTML(ListBox1.Items.Item(ListBox1.SelectedIndex))
            Else
                FormatText(ListBox1.Items.Item(ListBox1.SelectedIndex))
            End If
            Panel6.Visible = False
            ListBox1.SelectedIndex = 0
            TextBox2.Text = ""
            ListFocus = False
            RichTextBox1.Focus()
        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        LOAD_OPERATORS()
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        LOAD_OPERATORS()
    End Sub

    Private Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton3.CheckedChanged
        LOAD_OPERATORS()
    End Sub

    Private Sub RadioButton4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton4.CheckedChanged
        LOAD_OPERATORS()
    End Sub

    Private Sub RadioButton6_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton6.CheckedChanged
        LOAD_OPERATORS()
    End Sub

    Private Sub RadioButton5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton5.CheckedChanged
        LOAD_OPERATORS()
    End Sub

    Private Sub Label11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label11.Click
        Try
            System.Diagnostics.Process.Start(StatusBarPanel3.Text)
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.OKOnly, "Произошла ошибка!")
        End Try
    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click
        If (ColorDialog1.ShowDialog = DialogResult.OK) Then
            Dim clr As Color = ColorDialog1.Color
            Dim HexColor As String
            HexColor = String.Format("#{0:X2}{1:X2}{2:X2}", clr.R, clr.G, clr.B)
            Clipboard.SetDataObject(HexColor)
            RichTextBox1.SelectionColor = Color.Black
            RichTextBox1.Paste()
        End If
    End Sub

    Private Sub Label11_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label11.MouseMove
        Try
            Label11.BorderStyle = BorderStyle.FixedSingle
            Label3.BorderStyle = BorderStyle.None
            Label2.BorderStyle = BorderStyle.None
        Catch ex As Exception
            'MsgBox(ex.ToString, MsgBoxStyle.OKOnly, "Произошла ошибка!")
        End Try
    End Sub

    Private Sub Label11_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label11.MouseLeave
        Try
            Label11.BorderStyle = BorderStyle.None
        Catch ex As Exception
            'MsgBox(ex.ToString, MsgBoxStyle.OKOnly, "Произошла ошибка!")
        End Try
    End Sub

    Private Sub Label3_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label3.MouseMove
        Try
            Label3.BorderStyle = BorderStyle.FixedSingle
            Label11.BorderStyle = BorderStyle.None
            Label2.BorderStyle = BorderStyle.None
        Catch ex As Exception
            'MsgBox(ex.ToString, MsgBoxStyle.OKOnly, "Произошла ошибка!")
        End Try
    End Sub

    Private Sub Label3_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label3.MouseLeave
        Try
            Label3.BorderStyle = BorderStyle.None
        Catch ex As Exception
            'MsgBox(ex.ToString, MsgBoxStyle.OKOnly, "Произошла ошибка!")
        End Try
    End Sub

    Private Sub MenuItem61_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem61.Click
        RichTextBox1.Undo()
    End Sub

    Private Sub MenuItem63_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem63.Click
        RichTextBox1.Cut()
    End Sub

    Private Sub MenuItem64_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem64.Click
        RichTextBox1.Copy()
    End Sub

    Private Sub MenuItem65_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem65.Click
        RichTextBox1.Paste()
        RichTextBox1.Font = ModulePE.FontModule
        RichTextBox1.SelectionColor = Color.Black
    End Sub

    Private Sub MenuItem66_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem66.Click
        Clipboard.SetDataObject("")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Black
    End Sub

    Private Sub MenuItem135_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem135.Click
        RichTextBox1.Clear()
    End Sub

    Private Sub MenuItem134_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem134.Click
        RichTextBox1.SelectAll()
    End Sub

    Private Sub MenuItem79_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem79.Click
        If (RadioButton1.Checked = True) Then
            ModuleFormatVersionHTML()
        Else
            If (RadioButton7.Checked = True) Then
                'ModuleFormatVersionPHP()
                ModuleFormatVersion1_1_8()
            Else
                ModuleFormatVersion1_1_8()
            End If
        End If
    End Sub

    Private Sub MenuItem80_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem80.Click
        If (FontDialog1.ShowDialog = DialogResult.OK) Then
            RichTextBox1.Font = FontDialog1.Font
        End If
    End Sub

    Private Sub MenuItem81_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem81.Click
        If (ColorDialog1.ShowDialog = DialogResult.OK) Then
            RichTextBox1.SelectionColor = ColorDialog1.Color
        End If
    End Sub

    Private Sub MenuItem72_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem72.Click
        If (ColorDialog1.ShowDialog = DialogResult.OK) Then
            'MsgBox(ColorDialog1.Color.ToArgb().ToString("X"))
            Dim clr As Color = ColorDialog1.Color
            Dim HexColor As String
            HexColor = String.Format("#{0:X2}{1:X2}{2:X2}", clr.R, clr.G, clr.B)
            Clipboard.SetDataObject(HexColor)
            RichTextBox1.SelectionColor = Color.Black
            RichTextBox1.Paste()
        End If
    End Sub

    Private Sub MenuItem89_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem89.Click
        FormatText("$")
    End Sub

    Private Sub MenuItem88_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem88.Click
        FormatText("var")
    End Sub

    Private Sub MenuItem133_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem133.Click
        FormatText("Dim as")
    End Sub

    Private Sub MenuItem90_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem90.Click
        FormatText("if(){}else{}")
    End Sub

    Private Sub MenuItem91_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem91.Click
        FormatText("while(){}")
    End Sub

    Private Sub MenuItem92_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem92.Click
        FormatText("do{}while()")
    End Sub

    Private Sub MenuItem93_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem93.Click
        FormatText("for($i=0,$j=10; $i<$j; $i++){}")
    End Sub

    Private Sub MenuItem98_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem98.Click
        FormatText("for(var i=0; i<=10; i++){}")
    End Sub

    Private Sub MenuItem94_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem94.Click
        FormatText("switch(){case: break; default:}")
    End Sub

    Private Sub MenuItem95_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem95.Click
        FormatText("function(){}")
    End Sub

    Private Sub MenuItem202_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem202.Click
        FormatText("$('')")
    End Sub

    Private Sub MenuItem234_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem234.Click
        FormatText("$(this)")
    End Sub

    Private Sub MenuItem203_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem203.Click
        FormatText("$(document).ready(function(){});//конец ready")
    End Sub

    Private Sub MenuItem204_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem204.Click
        FormatText("$(function(){});//конец ready")
    End Sub

    Private Sub MenuItem205_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem205.Click
        FormatText("jquery('')")
    End Sub

    Private Sub MenuItem206_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem206.Click
        FormatText("jquery(document).ready(function(){});//конец ready")
    End Sub

    Private Sub MenuItem207_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem207.Click
        FormatText("jquery(function(){});//конец ready")
    End Sub

    Private Sub Panel1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseMove
        'ModulePE.ProgrammPE.StatusBarPanel4.Text = MyFileName + " [" + MyID.ToString + "]"
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If (e.KeyChar.GetHashCode = 851981) Then
            Try
                If (FindText <> TextBox1.Text) Then
                    FindIndex = 0
                    FindLast = 0
                    FindText = TextBox1.Text
                End If
                If (RichTextBox1.Find(TextBox1.Text, FindIndex, RichTextBox1.TextLength - 1, RichTextBoxFinds.None)) Then
                    RichTextBox1.Select()
                    FindIndex = RichTextBox1.SelectionStart + RichTextBox1.SelectionLength
                    If (FindLast = RichTextBox1.SelectionStart) Then
                        MsgBox("Поиск завершен.", MsgBoxStyle.OKOnly, "Сообщение:")
                        FindIndex = 0
                        FindLast = 0
                        FindText = TextBox1.Text
                    Else
                        FindLast = RichTextBox1.SelectionStart
                    End If
                End If
            Catch ex As Exception
                'MsgBox(ex.ToString, MsgBoxStyle.OKOnly, "Произошла ошибка!")
            End Try
        End If
    End Sub

    Private Sub RadioButton7_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton7.CheckedChanged
        LOAD_OPERATORS()
    End Sub

    Private Sub RadioButton8_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton8.CheckedChanged
        LOAD_OPERATORS()
    End Sub

    Private Sub RadioButton9_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton9.CheckedChanged
        LOAD_OPERATORS()
    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click
        'Если кодировка ASCII
        If (StatusBarPanel1.Text = "ascii") Then
            RichTextBox1.SaveFile(MyPath, RichTextBoxStreamType.PlainText)
            Me.Icon = ModulePE.ProgrammPE.NotifyIcon1.Icon
            StatusBarPanel1.Text = "ascii"
        End If
        'Если кодировка UTF-8
        If (StatusBarPanel1.Text = "utf-8") Then
            Dim writer As StreamWriter = New StreamWriter(MyPath, False, Encoding.UTF8)
            writer.Write(RichTextBox1.Text)
            writer.Close()
            Me.Icon = ModulePE.ProgrammPE.NotifyIcon1.Icon
            StatusBarPanel1.Text = "utf-8"
        End If
        'Если кодировка UTF-8 Without BOM
        If (StatusBarPanel1.Text = "utf-8 wintout BOM") Then
            Dim utf8WithoutBom As New System.Text.UTF8Encoding(False)
            Dim writer As StreamWriter = New StreamWriter(MyPath, False, utf8WithoutBom)
            writer.Write(RichTextBox1.Text)
            writer.Close()
            Me.Icon = ModulePE.ProgrammPE.NotifyIcon1.Icon
            StatusBarPanel1.Text = "utf-8 wintout BOM"
        End If
    End Sub

    Private Sub Label2_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label2.MouseMove
        Try
            Label3.BorderStyle = BorderStyle.None
            Label11.BorderStyle = BorderStyle.None
            Label2.BorderStyle = BorderStyle.FixedSingle
        Catch ex As Exception
            'MsgBox(ex.ToString, MsgBoxStyle.OKOnly, "Произошла ошибка!")
        End Try
    End Sub

    Private Sub Label2_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label2.MouseLeave
        Try
            Label2.BorderStyle = BorderStyle.None
        Catch ex As Exception
            'MsgBox(ex.ToString, MsgBoxStyle.OKOnly, "Произошла ошибка!")
        End Try
    End Sub

    Private Sub MenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem2.Click
        FormatTextHTML("<script type=" + """" + "text/javascript" + """" + " src=" + """" + """" + "></script>")
    End Sub

    Private Sub MenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem3.Click
        FormatTextHTML("<link type=" + """" + "text/css" + """" + " rel=" + """" + "stylesheet" + """" + " href=" + """" + """" + ">")
    End Sub
End Class
