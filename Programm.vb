Imports System.IO
Imports System.Text
Public Class Programm
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
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents ImageList3 As System.Windows.Forms.ImageList
    Friend WithEvents NotifyIcon2 As System.Windows.Forms.NotifyIcon
    Friend WithEvents NotifyIcon1 As System.Windows.Forms.NotifyIcon
    Friend WithEvents ImageList2 As System.Windows.Forms.ImageList
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents MainMenu1 As System.Windows.Forms.MainMenu
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem8 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem9 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem10 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem13 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem11 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem12 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem34 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem28 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem35 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem32 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem27 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem38 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem39 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem36 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem33 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem16 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem17 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem19 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem18 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem20 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem22 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem21 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem30 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem29 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem4 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem5 As System.Windows.Forms.MenuItem
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents StatusBar1 As System.Windows.Forms.StatusBar
    Friend WithEvents StatusBarPanel1 As System.Windows.Forms.StatusBarPanel
    Friend WithEvents StatusBarPanel2 As System.Windows.Forms.StatusBarPanel
    Friend WithEvents StatusBarPanel3 As System.Windows.Forms.StatusBarPanel
    Friend WithEvents ToolBar1 As System.Windows.Forms.ToolBar
    Friend WithEvents ToolBarButton1 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton2 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton3 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton4 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton5 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton10 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton11 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton12 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton6 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton7 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton8 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton9 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton13 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton14 As System.Windows.Forms.ToolBarButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents TreeView1 As System.Windows.Forms.TreeView
    Friend WithEvents Splitter3 As System.Windows.Forms.Splitter
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents Splitter2 As System.Windows.Forms.Splitter
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents Splitter1 As System.Windows.Forms.Splitter
    Friend WithEvents ToolBar2 As System.Windows.Forms.ToolBar
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents ToolBarButton15 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton16 As System.Windows.Forms.ToolBarButton
    Friend WithEvents MenuItem14 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem15 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem23 As System.Windows.Forms.MenuItem
    Friend WithEvents ContextMenuFolder As System.Windows.Forms.ContextMenu
    Friend WithEvents ToolBarButton17 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ContextMenuFiles As System.Windows.Forms.ContextMenu
    Friend WithEvents MenuItem24 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem25 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem26 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem40 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem41 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem7 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem37 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem42 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem43 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem44 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem45 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem6 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem31 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem46 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem47 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem48 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem49 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem50 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem51 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem52 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem53 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem54 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem55 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem56 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem57 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem58 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem59 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem60 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem61 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem62 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem63 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem64 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem65 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem66 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem67 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem68 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem69 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem70 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem71 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem72 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem73 As System.Windows.Forms.MenuItem
    Friend WithEvents OleDbSelectCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbInsertCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbUpdateCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbDeleteCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbConnection1 As System.Data.OleDb.OleDbConnection
    Friend WithEvents OleDbDataAdapter1 As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents DataSet41 As PageEditor.DataSet4
    Friend WithEvents DataSet51 As PageEditor.DataSet5
    Friend WithEvents ContextMenuTREE As System.Windows.Forms.ContextMenu
    Friend WithEvents MenuItem74 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem75 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem76 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem77 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem78 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem79 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem80 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem81 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem82 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem83 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem84 As System.Windows.Forms.MenuItem
    Friend WithEvents ToolBarButton18 As System.Windows.Forms.ToolBarButton
    Friend WithEvents MenuItem85 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem86 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem87 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem88 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem89 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem91 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem92 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem93 As System.Windows.Forms.MenuItem
    Friend WithEvents ContextMenuCloseFiles As System.Windows.Forms.ContextMenu
    Friend WithEvents MenuItem94 As System.Windows.Forms.MenuItem
    Friend WithEvents StatusBarPanel4 As System.Windows.Forms.StatusBarPanel
    Friend WithEvents MenuItem95 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem96 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem97 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem98 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem99 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem100 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem101 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem102 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem103 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem104 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem105 As System.Windows.Forms.MenuItem
    Friend WithEvents ToolBarButton19 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton20 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ContextMenuSQL As System.Windows.Forms.ContextMenu
    Friend WithEvents MenuItem106 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem107 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem108 As System.Windows.Forms.MenuItem
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TreeView2 As System.Windows.Forms.TreeView
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents DataSet131 As PageEditor.DataSet13
    Friend WithEvents ContextMenuFindTREE As System.Windows.Forms.ContextMenu
    Friend WithEvents MenuItem109 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem111 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem110 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem112 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem90 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem113 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem114 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem115 As System.Windows.Forms.MenuItem
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Programm))
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.ImageList3 = New System.Windows.Forms.ImageList(Me.components)
        Me.NotifyIcon2 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.ImageList2 = New System.Windows.Forms.ImageList(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog
        Me.MainMenu1 = New System.Windows.Forms.MainMenu
        Me.MenuItem1 = New System.Windows.Forms.MenuItem
        Me.MenuItem113 = New System.Windows.Forms.MenuItem
        Me.MenuItem95 = New System.Windows.Forms.MenuItem
        Me.MenuItem2 = New System.Windows.Forms.MenuItem
        Me.MenuItem92 = New System.Windows.Forms.MenuItem
        Me.MenuItem91 = New System.Windows.Forms.MenuItem
        Me.MenuItem93 = New System.Windows.Forms.MenuItem
        Me.MenuItem43 = New System.Windows.Forms.MenuItem
        Me.MenuItem115 = New System.Windows.Forms.MenuItem
        Me.MenuItem7 = New System.Windows.Forms.MenuItem
        Me.MenuItem41 = New System.Windows.Forms.MenuItem
        Me.MenuItem110 = New System.Windows.Forms.MenuItem
        Me.MenuItem40 = New System.Windows.Forms.MenuItem
        Me.MenuItem8 = New System.Windows.Forms.MenuItem
        Me.MenuItem88 = New System.Windows.Forms.MenuItem
        Me.MenuItem89 = New System.Windows.Forms.MenuItem
        Me.MenuItem9 = New System.Windows.Forms.MenuItem
        Me.MenuItem90 = New System.Windows.Forms.MenuItem
        Me.MenuItem10 = New System.Windows.Forms.MenuItem
        Me.MenuItem42 = New System.Windows.Forms.MenuItem
        Me.MenuItem112 = New System.Windows.Forms.MenuItem
        Me.MenuItem37 = New System.Windows.Forms.MenuItem
        Me.MenuItem87 = New System.Windows.Forms.MenuItem
        Me.MenuItem13 = New System.Windows.Forms.MenuItem
        Me.MenuItem85 = New System.Windows.Forms.MenuItem
        Me.MenuItem86 = New System.Windows.Forms.MenuItem
        Me.MenuItem11 = New System.Windows.Forms.MenuItem
        Me.MenuItem12 = New System.Windows.Forms.MenuItem
        Me.MenuItem96 = New System.Windows.Forms.MenuItem
        Me.MenuItem97 = New System.Windows.Forms.MenuItem
        Me.MenuItem98 = New System.Windows.Forms.MenuItem
        Me.MenuItem99 = New System.Windows.Forms.MenuItem
        Me.MenuItem100 = New System.Windows.Forms.MenuItem
        Me.MenuItem101 = New System.Windows.Forms.MenuItem
        Me.MenuItem102 = New System.Windows.Forms.MenuItem
        Me.MenuItem105 = New System.Windows.Forms.MenuItem
        Me.MenuItem103 = New System.Windows.Forms.MenuItem
        Me.MenuItem104 = New System.Windows.Forms.MenuItem
        Me.MenuItem34 = New System.Windows.Forms.MenuItem
        Me.MenuItem28 = New System.Windows.Forms.MenuItem
        Me.MenuItem35 = New System.Windows.Forms.MenuItem
        Me.MenuItem32 = New System.Windows.Forms.MenuItem
        Me.MenuItem27 = New System.Windows.Forms.MenuItem
        Me.MenuItem38 = New System.Windows.Forms.MenuItem
        Me.MenuItem39 = New System.Windows.Forms.MenuItem
        Me.MenuItem36 = New System.Windows.Forms.MenuItem
        Me.MenuItem33 = New System.Windows.Forms.MenuItem
        Me.MenuItem44 = New System.Windows.Forms.MenuItem
        Me.MenuItem45 = New System.Windows.Forms.MenuItem
        Me.MenuItem16 = New System.Windows.Forms.MenuItem
        Me.MenuItem17 = New System.Windows.Forms.MenuItem
        Me.MenuItem19 = New System.Windows.Forms.MenuItem
        Me.MenuItem18 = New System.Windows.Forms.MenuItem
        Me.MenuItem20 = New System.Windows.Forms.MenuItem
        Me.MenuItem22 = New System.Windows.Forms.MenuItem
        Me.MenuItem21 = New System.Windows.Forms.MenuItem
        Me.MenuItem30 = New System.Windows.Forms.MenuItem
        Me.MenuItem29 = New System.Windows.Forms.MenuItem
        Me.MenuItem3 = New System.Windows.Forms.MenuItem
        Me.MenuItem6 = New System.Windows.Forms.MenuItem
        Me.MenuItem31 = New System.Windows.Forms.MenuItem
        Me.MenuItem46 = New System.Windows.Forms.MenuItem
        Me.MenuItem47 = New System.Windows.Forms.MenuItem
        Me.MenuItem48 = New System.Windows.Forms.MenuItem
        Me.MenuItem49 = New System.Windows.Forms.MenuItem
        Me.MenuItem50 = New System.Windows.Forms.MenuItem
        Me.MenuItem73 = New System.Windows.Forms.MenuItem
        Me.MenuItem72 = New System.Windows.Forms.MenuItem
        Me.MenuItem51 = New System.Windows.Forms.MenuItem
        Me.MenuItem52 = New System.Windows.Forms.MenuItem
        Me.MenuItem53 = New System.Windows.Forms.MenuItem
        Me.MenuItem54 = New System.Windows.Forms.MenuItem
        Me.MenuItem55 = New System.Windows.Forms.MenuItem
        Me.MenuItem56 = New System.Windows.Forms.MenuItem
        Me.MenuItem57 = New System.Windows.Forms.MenuItem
        Me.MenuItem58 = New System.Windows.Forms.MenuItem
        Me.MenuItem114 = New System.Windows.Forms.MenuItem
        Me.MenuItem59 = New System.Windows.Forms.MenuItem
        Me.MenuItem60 = New System.Windows.Forms.MenuItem
        Me.MenuItem61 = New System.Windows.Forms.MenuItem
        Me.MenuItem62 = New System.Windows.Forms.MenuItem
        Me.MenuItem63 = New System.Windows.Forms.MenuItem
        Me.MenuItem64 = New System.Windows.Forms.MenuItem
        Me.MenuItem65 = New System.Windows.Forms.MenuItem
        Me.MenuItem66 = New System.Windows.Forms.MenuItem
        Me.MenuItem67 = New System.Windows.Forms.MenuItem
        Me.MenuItem68 = New System.Windows.Forms.MenuItem
        Me.MenuItem69 = New System.Windows.Forms.MenuItem
        Me.MenuItem70 = New System.Windows.Forms.MenuItem
        Me.MenuItem71 = New System.Windows.Forms.MenuItem
        Me.MenuItem4 = New System.Windows.Forms.MenuItem
        Me.MenuItem5 = New System.Windows.Forms.MenuItem
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.StatusBar1 = New System.Windows.Forms.StatusBar
        Me.StatusBarPanel1 = New System.Windows.Forms.StatusBarPanel
        Me.StatusBarPanel2 = New System.Windows.Forms.StatusBarPanel
        Me.StatusBarPanel4 = New System.Windows.Forms.StatusBarPanel
        Me.StatusBarPanel3 = New System.Windows.Forms.StatusBarPanel
        Me.ToolBar1 = New System.Windows.Forms.ToolBar
        Me.ToolBarButton1 = New System.Windows.Forms.ToolBarButton
        Me.ToolBarButton2 = New System.Windows.Forms.ToolBarButton
        Me.ToolBarButton3 = New System.Windows.Forms.ToolBarButton
        Me.ToolBarButton4 = New System.Windows.Forms.ToolBarButton
        Me.ToolBarButton5 = New System.Windows.Forms.ToolBarButton
        Me.ToolBarButton10 = New System.Windows.Forms.ToolBarButton
        Me.ToolBarButton11 = New System.Windows.Forms.ToolBarButton
        Me.ToolBarButton12 = New System.Windows.Forms.ToolBarButton
        Me.ToolBarButton6 = New System.Windows.Forms.ToolBarButton
        Me.ToolBarButton7 = New System.Windows.Forms.ToolBarButton
        Me.ToolBarButton8 = New System.Windows.Forms.ToolBarButton
        Me.ToolBarButton9 = New System.Windows.Forms.ToolBarButton
        Me.ToolBarButton13 = New System.Windows.Forms.ToolBarButton
        Me.ToolBarButton14 = New System.Windows.Forms.ToolBarButton
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Panel7 = New System.Windows.Forms.Panel
        Me.ToolBar2 = New System.Windows.Forms.ToolBar
        Me.ToolBarButton15 = New System.Windows.Forms.ToolBarButton
        Me.ToolBarButton16 = New System.Windows.Forms.ToolBarButton
        Me.ContextMenuFolder = New System.Windows.Forms.ContextMenu
        Me.MenuItem14 = New System.Windows.Forms.MenuItem
        Me.MenuItem15 = New System.Windows.Forms.MenuItem
        Me.MenuItem23 = New System.Windows.Forms.MenuItem
        Me.ToolBarButton18 = New System.Windows.Forms.ToolBarButton
        Me.ToolBarButton17 = New System.Windows.Forms.ToolBarButton
        Me.ContextMenuFiles = New System.Windows.Forms.ContextMenu
        Me.MenuItem24 = New System.Windows.Forms.MenuItem
        Me.MenuItem25 = New System.Windows.Forms.MenuItem
        Me.MenuItem26 = New System.Windows.Forms.MenuItem
        Me.ToolBarButton19 = New System.Windows.Forms.ToolBarButton
        Me.ToolBarButton20 = New System.Windows.Forms.ToolBarButton
        Me.ContextMenuSQL = New System.Windows.Forms.ContextMenu
        Me.MenuItem106 = New System.Windows.Forms.MenuItem
        Me.MenuItem107 = New System.Windows.Forms.MenuItem
        Me.MenuItem108 = New System.Windows.Forms.MenuItem
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.TreeView1 = New System.Windows.Forms.TreeView
        Me.ContextMenuTREE = New System.Windows.Forms.ContextMenu
        Me.MenuItem83 = New System.Windows.Forms.MenuItem
        Me.MenuItem84 = New System.Windows.Forms.MenuItem
        Me.MenuItem79 = New System.Windows.Forms.MenuItem
        Me.MenuItem78 = New System.Windows.Forms.MenuItem
        Me.MenuItem80 = New System.Windows.Forms.MenuItem
        Me.MenuItem77 = New System.Windows.Forms.MenuItem
        Me.MenuItem74 = New System.Windows.Forms.MenuItem
        Me.MenuItem75 = New System.Windows.Forms.MenuItem
        Me.MenuItem76 = New System.Windows.Forms.MenuItem
        Me.MenuItem81 = New System.Windows.Forms.MenuItem
        Me.MenuItem82 = New System.Windows.Forms.MenuItem
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.Button1 = New System.Windows.Forms.Button
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.TreeView2 = New System.Windows.Forms.TreeView
        Me.ContextMenuFindTREE = New System.Windows.Forms.ContextMenu
        Me.MenuItem111 = New System.Windows.Forms.MenuItem
        Me.MenuItem109 = New System.Windows.Forms.MenuItem
        Me.Splitter3 = New System.Windows.Forms.Splitter
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox
        Me.Splitter2 = New System.Windows.Forms.Splitter
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.Label1 = New System.Windows.Forms.Label
        Me.ListBox1 = New System.Windows.Forms.ListBox
        Me.ContextMenuCloseFiles = New System.Windows.Forms.ContextMenu
        Me.MenuItem94 = New System.Windows.Forms.MenuItem
        Me.Splitter1 = New System.Windows.Forms.Splitter
        Me.OleDbSelectCommand1 = New System.Data.OleDb.OleDbCommand
        Me.OleDbConnection1 = New System.Data.OleDb.OleDbConnection
        Me.OleDbInsertCommand1 = New System.Data.OleDb.OleDbCommand
        Me.OleDbUpdateCommand1 = New System.Data.OleDb.OleDbCommand
        Me.OleDbDeleteCommand1 = New System.Data.OleDb.OleDbCommand
        Me.OleDbDataAdapter1 = New System.Data.OleDb.OleDbDataAdapter
        Me.DataSet41 = New PageEditor.DataSet4
        Me.DataSet51 = New PageEditor.DataSet5
        Me.DataSet131 = New PageEditor.DataSet13
        CType(Me.StatusBarPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StatusBarPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StatusBarPanel4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StatusBarPanel3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.DataSet41, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet51, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet131, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.Filter = "*.html,*.htm|*.html;*.htm|*.css|*.css|*.js|*.js|*.php|*.php|*.*|*.*"
        '
        'ImageList3
        '
        Me.ImageList3.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit
        Me.ImageList3.ImageSize = New System.Drawing.Size(24, 20)
        Me.ImageList3.ImageStream = CType(resources.GetObject("ImageList3.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList3.TransparentColor = System.Drawing.Color.Transparent
        '
        'NotifyIcon2
        '
        Me.NotifyIcon2.Icon = CType(resources.GetObject("NotifyIcon2.Icon"), System.Drawing.Icon)
        Me.NotifyIcon2.Text = "NotifyIcon2"
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "NotifyIcon1"
        '
        'ImageList2
        '
        Me.ImageList2.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit
        Me.ImageList2.ImageSize = New System.Drawing.Size(24, 20)
        Me.ImageList2.ImageStream = CType(resources.GetObject("ImageList2.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList2.TransparentColor = System.Drawing.Color.Transparent
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.Filter = "*.html,*.htm|*.html;*.htm|*.css|*.css|*.js|*.js|*.php|*.php|*.*|*.*"
        '
        'MainMenu1
        '
        Me.MainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem1, Me.MenuItem96, Me.MenuItem34, Me.MenuItem16, Me.MenuItem3, Me.MenuItem52, Me.MenuItem4})
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 0
        Me.MenuItem1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem113, Me.MenuItem95, Me.MenuItem43, Me.MenuItem115, Me.MenuItem7, Me.MenuItem41, Me.MenuItem110, Me.MenuItem40, Me.MenuItem8, Me.MenuItem88, Me.MenuItem89, Me.MenuItem9, Me.MenuItem90, Me.MenuItem10, Me.MenuItem42, Me.MenuItem112, Me.MenuItem37, Me.MenuItem87, Me.MenuItem13, Me.MenuItem85, Me.MenuItem86, Me.MenuItem11, Me.MenuItem12})
        Me.MenuItem1.Text = "&Файл."
        '
        'MenuItem113
        '
        Me.MenuItem113.Index = 0
        Me.MenuItem113.Text = "Создать."
        Me.MenuItem113.Visible = False
        '
        'MenuItem95
        '
        Me.MenuItem95.Index = 1
        Me.MenuItem95.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem2, Me.MenuItem92, Me.MenuItem91, Me.MenuItem93})
        Me.MenuItem95.Text = "Создать файл:"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 0
        Me.MenuItem2.Text = "Создать файл (ASCII)"
        '
        'MenuItem92
        '
        Me.MenuItem92.Index = 1
        Me.MenuItem92.Text = "Создать файл. (ASCII)"
        Me.MenuItem92.Visible = False
        '
        'MenuItem91
        '
        Me.MenuItem91.Index = 2
        Me.MenuItem91.Text = "Создать файл (UTF-8)"
        '
        'MenuItem93
        '
        Me.MenuItem93.Index = 3
        Me.MenuItem93.Text = "Создать файл (UTF-8 without BOM)"
        '
        'MenuItem43
        '
        Me.MenuItem43.Index = 2
        Me.MenuItem43.Text = "-"
        '
        'MenuItem115
        '
        Me.MenuItem115.Index = 3
        Me.MenuItem115.Text = "Открыть файл."
        '
        'MenuItem7
        '
        Me.MenuItem7.Index = 4
        Me.MenuItem7.Text = "Открыть файл (ASCII)"
        '
        'MenuItem41
        '
        Me.MenuItem41.Index = 5
        Me.MenuItem41.Text = "Открыть файл (UTF-8)"
        '
        'MenuItem110
        '
        Me.MenuItem110.Index = 6
        Me.MenuItem110.Text = "Открыть файл (UTF-8 without BOM)"
        '
        'MenuItem40
        '
        Me.MenuItem40.Index = 7
        Me.MenuItem40.Text = "Открыть файл (ASCII)"
        Me.MenuItem40.Visible = False
        '
        'MenuItem8
        '
        Me.MenuItem8.Index = 8
        Me.MenuItem8.Text = "-"
        '
        'MenuItem88
        '
        Me.MenuItem88.Index = 9
        Me.MenuItem88.Text = "Сохранить файл. (UTF-8)"
        Me.MenuItem88.Visible = False
        '
        'MenuItem89
        '
        Me.MenuItem89.Index = 10
        Me.MenuItem89.Text = "Сохранить файл. (ASCII)"
        Me.MenuItem89.Visible = False
        '
        'MenuItem9
        '
        Me.MenuItem9.Index = 11
        Me.MenuItem9.Text = "Сохранить файл."
        '
        'MenuItem90
        '
        Me.MenuItem90.Index = 12
        Me.MenuItem90.Text = "-"
        '
        'MenuItem10
        '
        Me.MenuItem10.Index = 13
        Me.MenuItem10.Text = "Сохранить файл как (ASCII)"
        '
        'MenuItem42
        '
        Me.MenuItem42.Index = 14
        Me.MenuItem42.Text = "Cохранить файл как (UTF-8)"
        '
        'MenuItem112
        '
        Me.MenuItem112.Index = 15
        Me.MenuItem112.Text = "Сохранить файл как (UTF-8 without BOM)"
        '
        'MenuItem37
        '
        Me.MenuItem37.Index = 16
        Me.MenuItem37.Text = "Cохранить файл как ASCII"
        Me.MenuItem37.Visible = False
        '
        'MenuItem87
        '
        Me.MenuItem87.Index = 17
        Me.MenuItem87.Text = "-"
        '
        'MenuItem13
        '
        Me.MenuItem13.Index = 18
        Me.MenuItem13.Text = "Сохранить всё..."
        '
        'MenuItem85
        '
        Me.MenuItem85.Index = 19
        Me.MenuItem85.Text = "Сохранить всё... (UTF-8)"
        Me.MenuItem85.Visible = False
        '
        'MenuItem86
        '
        Me.MenuItem86.Index = 20
        Me.MenuItem86.Text = "Сохранить всё... (ASCII)"
        Me.MenuItem86.Visible = False
        '
        'MenuItem11
        '
        Me.MenuItem11.Index = 21
        Me.MenuItem11.Text = "-"
        '
        'MenuItem12
        '
        Me.MenuItem12.Index = 22
        Me.MenuItem12.Text = "Выход."
        '
        'MenuItem96
        '
        Me.MenuItem96.Index = 1
        Me.MenuItem96.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem97, Me.MenuItem98, Me.MenuItem99, Me.MenuItem100, Me.MenuItem101, Me.MenuItem102, Me.MenuItem105, Me.MenuItem103, Me.MenuItem104})
        Me.MenuItem96.Text = "&Правка."
        '
        'MenuItem97
        '
        Me.MenuItem97.Index = 0
        Me.MenuItem97.Text = "Отменить     Ctrl+Z"
        '
        'MenuItem98
        '
        Me.MenuItem98.Index = 1
        Me.MenuItem98.Text = "-"
        '
        'MenuItem99
        '
        Me.MenuItem99.Index = 2
        Me.MenuItem99.Text = "Вырезать     Ctrl+X"
        '
        'MenuItem100
        '
        Me.MenuItem100.Index = 3
        Me.MenuItem100.Text = "Копировать Ctrl+C"
        '
        'MenuItem101
        '
        Me.MenuItem101.Index = 4
        Me.MenuItem101.Text = "Вставить      Ctrl+V"
        '
        'MenuItem102
        '
        Me.MenuItem102.Index = 5
        Me.MenuItem102.Text = "Удалить       Del"
        '
        'MenuItem105
        '
        Me.MenuItem105.Index = 6
        Me.MenuItem105.Text = "-"
        '
        'MenuItem103
        '
        Me.MenuItem103.Index = 7
        Me.MenuItem103.Text = "Очистить."
        '
        'MenuItem104
        '
        Me.MenuItem104.Index = 8
        Me.MenuItem104.Text = "Выделить всё"
        '
        'MenuItem34
        '
        Me.MenuItem34.Index = 2
        Me.MenuItem34.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem28, Me.MenuItem35, Me.MenuItem32, Me.MenuItem27, Me.MenuItem38, Me.MenuItem39, Me.MenuItem36, Me.MenuItem33, Me.MenuItem44, Me.MenuItem45})
        Me.MenuItem34.Text = "&Выполнить."
        '
        'MenuItem28
        '
        Me.MenuItem28.Index = 0
        Me.MenuItem28.Text = "Выполнить."
        '
        'MenuItem35
        '
        Me.MenuItem35.Index = 1
        Me.MenuItem35.Text = "Выполнить страницу в браузере IExplorer."
        '
        'MenuItem32
        '
        Me.MenuItem32.Index = 2
        Me.MenuItem32.Text = "Выполнить страницу в браузере Opera."
        '
        'MenuItem27
        '
        Me.MenuItem27.Index = 3
        Me.MenuItem27.Text = "Выполнить страницу в браузере FireFox."
        '
        'MenuItem38
        '
        Me.MenuItem38.Index = 4
        Me.MenuItem38.Text = "Выполнить страницу в браузере Chrome"
        '
        'MenuItem39
        '
        Me.MenuItem39.Index = 5
        Me.MenuItem39.Text = "Выполнить страницу в браузере Safari"
        '
        'MenuItem36
        '
        Me.MenuItem36.Index = 6
        Me.MenuItem36.Text = "-"
        '
        'MenuItem33
        '
        Me.MenuItem33.Index = 7
        Me.MenuItem33.Text = "Выполнить страницу на локальном хосте."
        '
        'MenuItem44
        '
        Me.MenuItem44.Index = 8
        Me.MenuItem44.Text = "-"
        Me.MenuItem44.Visible = False
        '
        'MenuItem45
        '
        Me.MenuItem45.Index = 9
        Me.MenuItem45.Text = "Выполнить валидацию. validator.w3.org"
        Me.MenuItem45.Visible = False
        '
        'MenuItem16
        '
        Me.MenuItem16.Index = 3
        Me.MenuItem16.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem17, Me.MenuItem19, Me.MenuItem18, Me.MenuItem20, Me.MenuItem22, Me.MenuItem21, Me.MenuItem30, Me.MenuItem29})
        Me.MenuItem16.Text = "Сервер &Denwer."
        '
        'MenuItem17
        '
        Me.MenuItem17.Index = 0
        Me.MenuItem17.Text = "Старт сервера."
        '
        'MenuItem19
        '
        Me.MenuItem19.Index = 1
        Me.MenuItem19.Text = "Стоп сервер."
        '
        'MenuItem18
        '
        Me.MenuItem18.Index = 2
        Me.MenuItem18.Text = "Перезапуск сервера."
        '
        'MenuItem20
        '
        Me.MenuItem20.Index = 3
        Me.MenuItem20.Text = "-"
        '
        'MenuItem22
        '
        Me.MenuItem22.Index = 4
        Me.MenuItem22.Text = "localhost"
        '
        'MenuItem21
        '
        Me.MenuItem21.Index = 5
        Me.MenuItem21.Text = "phpMyAdmin"
        '
        'MenuItem30
        '
        Me.MenuItem30.Index = 6
        Me.MenuItem30.Text = "-"
        '
        'MenuItem29
        '
        Me.MenuItem29.Index = 7
        Me.MenuItem29.Text = "Выполнить страницу на локальном хосте."
        '
        'MenuItem3
        '
        Me.MenuItem3.Index = 4
        Me.MenuItem3.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem6, Me.MenuItem31, Me.MenuItem46, Me.MenuItem47, Me.MenuItem48, Me.MenuItem49, Me.MenuItem50, Me.MenuItem73, Me.MenuItem72, Me.MenuItem51})
        Me.MenuItem3.Text = "&Сервис."
        '
        'MenuItem6
        '
        Me.MenuItem6.Index = 0
        Me.MenuItem6.Text = "Paint."
        '
        'MenuItem31
        '
        Me.MenuItem31.Index = 1
        Me.MenuItem31.Text = "Wordpad."
        '
        'MenuItem46
        '
        Me.MenuItem46.Index = 2
        Me.MenuItem46.Text = "Блокнот."
        '
        'MenuItem47
        '
        Me.MenuItem47.Index = 3
        Me.MenuItem47.Text = "Проводник."
        '
        'MenuItem48
        '
        Me.MenuItem48.Index = 4
        Me.MenuItem48.Text = "Калькулятор."
        '
        'MenuItem49
        '
        Me.MenuItem49.Index = 5
        Me.MenuItem49.Text = "Командная строка."
        '
        'MenuItem50
        '
        Me.MenuItem50.Index = 6
        Me.MenuItem50.Text = "-"
        '
        'MenuItem73
        '
        Me.MenuItem73.Index = 7
        Me.MenuItem73.Text = "FTP Клиент"
        '
        'MenuItem72
        '
        Me.MenuItem72.Index = 8
        Me.MenuItem72.Text = "-"
        '
        'MenuItem51
        '
        Me.MenuItem51.Index = 9
        Me.MenuItem51.Text = "Настройки."
        '
        'MenuItem52
        '
        Me.MenuItem52.Index = 5
        Me.MenuItem52.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem53, Me.MenuItem54, Me.MenuItem55, Me.MenuItem56, Me.MenuItem57, Me.MenuItem58, Me.MenuItem114, Me.MenuItem59, Me.MenuItem60, Me.MenuItem61, Me.MenuItem62, Me.MenuItem63, Me.MenuItem64, Me.MenuItem65, Me.MenuItem66, Me.MenuItem67, Me.MenuItem68, Me.MenuItem69, Me.MenuItem70, Me.MenuItem71})
        Me.MenuItem52.Text = "Сс&ылки."
        '
        'MenuItem53
        '
        Me.MenuItem53.Index = 0
        Me.MenuItem53.Text = "SpravkaWeb.Ru"
        '
        'MenuItem54
        '
        Me.MenuItem54.Index = 1
        Me.MenuItem54.Text = "-"
        '
        'MenuItem55
        '
        Me.MenuItem55.Index = 2
        Me.MenuItem55.Text = "jQuery"
        '
        'MenuItem56
        '
        Me.MenuItem56.Index = 3
        Me.MenuItem56.Text = "-"
        '
        'MenuItem57
        '
        Me.MenuItem57.Index = 4
        Me.MenuItem57.Text = "WordPress"
        '
        'MenuItem58
        '
        Me.MenuItem58.Index = 5
        Me.MenuItem58.Text = "WordPress по Русски"
        '
        'MenuItem114
        '
        Me.MenuItem114.Index = 6
        Me.MenuItem114.Text = "WordPress по Русски"
        '
        'MenuItem59
        '
        Me.MenuItem59.Index = 7
        Me.MenuItem59.Text = "-"
        '
        'MenuItem60
        '
        Me.MenuItem60.Index = 8
        Me.MenuItem60.Text = "Joomla!"
        '
        'MenuItem61
        '
        Me.MenuItem61.Index = 9
        Me.MenuItem61.Text = "Joomla! по Русски"
        '
        'MenuItem62
        '
        Me.MenuItem62.Index = 10
        Me.MenuItem62.Text = "-"
        '
        'MenuItem63
        '
        Me.MenuItem63.Index = 11
        Me.MenuItem63.Text = "Apache"
        '
        'MenuItem64
        '
        Me.MenuItem64.Index = 12
        Me.MenuItem64.Text = "PHP"
        '
        'MenuItem65
        '
        Me.MenuItem65.Index = 13
        Me.MenuItem65.Text = "MySQL"
        '
        'MenuItem66
        '
        Me.MenuItem66.Index = 14
        Me.MenuItem66.Text = "Denwer локальный сервер"
        '
        'MenuItem67
        '
        Me.MenuItem67.Index = 15
        Me.MenuItem67.Text = "-"
        '
        'MenuItem68
        '
        Me.MenuItem68.Index = 16
        Me.MenuItem68.Text = "CSS Validation Service"
        '
        'MenuItem69
        '
        Me.MenuItem69.Index = 17
        Me.MenuItem69.Text = "W3C CSS Markup Validation Service"
        '
        'MenuItem70
        '
        Me.MenuItem70.Index = 18
        Me.MenuItem70.Text = "-"
        '
        'MenuItem71
        '
        Me.MenuItem71.Index = 19
        Me.MenuItem71.Text = "Catfish Studio"
        '
        'MenuItem4
        '
        Me.MenuItem4.Index = 6
        Me.MenuItem4.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem5})
        Me.MenuItem4.Text = "Сп&равка."
        '
        'MenuItem5
        '
        Me.MenuItem5.Index = 0
        Me.MenuItem5.Text = "О программе."
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(24, 20)
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'StatusBar1
        '
        Me.StatusBar1.Location = New System.Drawing.Point(0, 529)
        Me.StatusBar1.Name = "StatusBar1"
        Me.StatusBar1.Panels.AddRange(New System.Windows.Forms.StatusBarPanel() {Me.StatusBarPanel1, Me.StatusBarPanel2, Me.StatusBarPanel4, Me.StatusBarPanel3})
        Me.StatusBar1.ShowPanels = True
        Me.StatusBar1.Size = New System.Drawing.Size(792, 16)
        Me.StatusBar1.TabIndex = 3
        Me.StatusBar1.Text = "StatusBar1"
        '
        'StatusBarPanel1
        '
        Me.StatusBarPanel1.BorderStyle = System.Windows.Forms.StatusBarPanelBorderStyle.Raised
        Me.StatusBarPanel1.Text = "Copyright © 2013 Somov Evgen."
        Me.StatusBarPanel1.Width = 170
        '
        'StatusBarPanel2
        '
        Me.StatusBarPanel2.Width = 150
        '
        'StatusBarPanel4
        '
        Me.StatusBarPanel4.Width = 150
        '
        'StatusBarPanel3
        '
        Me.StatusBarPanel3.Text = "..."
        Me.StatusBarPanel3.Width = 800
        '
        'ToolBar1
        '
        Me.ToolBar1.Appearance = System.Windows.Forms.ToolBarAppearance.Flat
        Me.ToolBar1.Buttons.AddRange(New System.Windows.Forms.ToolBarButton() {Me.ToolBarButton1, Me.ToolBarButton2, Me.ToolBarButton3, Me.ToolBarButton4, Me.ToolBarButton5, Me.ToolBarButton10, Me.ToolBarButton11, Me.ToolBarButton12, Me.ToolBarButton6, Me.ToolBarButton7, Me.ToolBarButton8, Me.ToolBarButton9, Me.ToolBarButton13, Me.ToolBarButton14})
        Me.ToolBar1.ButtonSize = New System.Drawing.Size(31, 36)
        Me.ToolBar1.DropDownArrows = True
        Me.ToolBar1.ImageList = Me.ImageList2
        Me.ToolBar1.Location = New System.Drawing.Point(0, 0)
        Me.ToolBar1.Name = "ToolBar1"
        Me.ToolBar1.ShowToolTips = True
        Me.ToolBar1.Size = New System.Drawing.Size(792, 32)
        Me.ToolBar1.TabIndex = 8
        '
        'ToolBarButton1
        '
        Me.ToolBarButton1.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
        '
        'ToolBarButton2
        '
        Me.ToolBarButton2.ImageIndex = 0
        Me.ToolBarButton2.ToolTipText = "Старт."
        '
        'ToolBarButton3
        '
        Me.ToolBarButton3.ImageIndex = 1
        Me.ToolBarButton3.ToolTipText = "Стоп."
        '
        'ToolBarButton4
        '
        Me.ToolBarButton4.ImageIndex = 2
        Me.ToolBarButton4.ToolTipText = "Перезапуск."
        '
        'ToolBarButton5
        '
        Me.ToolBarButton5.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
        '
        'ToolBarButton10
        '
        Me.ToolBarButton10.ImageIndex = 12
        Me.ToolBarButton10.ToolTipText = "Сохранить файл."
        '
        'ToolBarButton11
        '
        Me.ToolBarButton11.ImageIndex = 13
        Me.ToolBarButton11.ToolTipText = "Сохранить всё..."
        '
        'ToolBarButton12
        '
        Me.ToolBarButton12.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
        '
        'ToolBarButton6
        '
        Me.ToolBarButton6.ImageIndex = 6
        Me.ToolBarButton6.ToolTipText = "Создать файл. (UTF-8 without BOM)"
        '
        'ToolBarButton7
        '
        Me.ToolBarButton7.ImageIndex = 3
        Me.ToolBarButton7.ToolTipText = "Открыть файл."
        '
        'ToolBarButton8
        '
        Me.ToolBarButton8.ImageIndex = 15
        Me.ToolBarButton8.ToolTipText = "FTP Клиент."
        '
        'ToolBarButton9
        '
        Me.ToolBarButton9.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
        '
        'ToolBarButton13
        '
        Me.ToolBarButton13.ImageIndex = 14
        Me.ToolBarButton13.ToolTipText = "Настройки."
        '
        'ToolBarButton14
        '
        Me.ToolBarButton14.ImageIndex = 5
        Me.ToolBarButton14.ToolTipText = "О программе."
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Splitter2)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(528, 32)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(264, 497)
        Me.Panel1.TabIndex = 9
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.Panel7)
        Me.Panel3.Controls.Add(Me.Splitter3)
        Me.Panel3.Controls.Add(Me.Panel5)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 203)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(264, 294)
        Me.Panel3.TabIndex = 2
        '
        'Panel7
        '
        Me.Panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel7.Controls.Add(Me.ToolBar2)
        Me.Panel7.Controls.Add(Me.TabControl1)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel7.Location = New System.Drawing.Point(0, 0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(262, 217)
        Me.Panel7.TabIndex = 2
        '
        'ToolBar2
        '
        Me.ToolBar2.Appearance = System.Windows.Forms.ToolBarAppearance.Flat
        Me.ToolBar2.Buttons.AddRange(New System.Windows.Forms.ToolBarButton() {Me.ToolBarButton15, Me.ToolBarButton16, Me.ToolBarButton18, Me.ToolBarButton17, Me.ToolBarButton19, Me.ToolBarButton20})
        Me.ToolBar2.ButtonSize = New System.Drawing.Size(24, 24)
        Me.ToolBar2.DropDownArrows = True
        Me.ToolBar2.ImageList = Me.ImageList2
        Me.ToolBar2.Location = New System.Drawing.Point(0, 0)
        Me.ToolBar2.Name = "ToolBar2"
        Me.ToolBar2.ShowToolTips = True
        Me.ToolBar2.Size = New System.Drawing.Size(260, 32)
        Me.ToolBar2.TabIndex = 1
        '
        'ToolBarButton15
        '
        Me.ToolBarButton15.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
        '
        'ToolBarButton16
        '
        Me.ToolBarButton16.DropDownMenu = Me.ContextMenuFolder
        Me.ToolBarButton16.ImageIndex = 4
        Me.ToolBarButton16.Style = System.Windows.Forms.ToolBarButtonStyle.DropDownButton
        '
        'ContextMenuFolder
        '
        Me.ContextMenuFolder.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem14, Me.MenuItem15, Me.MenuItem23})
        '
        'MenuItem14
        '
        Me.MenuItem14.Index = 0
        Me.MenuItem14.Text = "Создать папка."
        '
        'MenuItem15
        '
        Me.MenuItem15.Index = 1
        Me.MenuItem15.Text = "Переименовать папку"
        '
        'MenuItem23
        '
        Me.MenuItem23.Index = 2
        Me.MenuItem23.Text = "Удалить папку."
        '
        'ToolBarButton18
        '
        Me.ToolBarButton18.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
        '
        'ToolBarButton17
        '
        Me.ToolBarButton17.DropDownMenu = Me.ContextMenuFiles
        Me.ToolBarButton17.ImageIndex = 6
        Me.ToolBarButton17.Style = System.Windows.Forms.ToolBarButtonStyle.DropDownButton
        '
        'ContextMenuFiles
        '
        Me.ContextMenuFiles.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem24, Me.MenuItem25, Me.MenuItem26})
        '
        'MenuItem24
        '
        Me.MenuItem24.Index = 0
        Me.MenuItem24.Text = "Создать запись."
        '
        'MenuItem25
        '
        Me.MenuItem25.Index = 1
        Me.MenuItem25.Text = "Открыть запись."
        '
        'MenuItem26
        '
        Me.MenuItem26.Index = 2
        Me.MenuItem26.Text = "Удалить запись."
        '
        'ToolBarButton19
        '
        Me.ToolBarButton19.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
        '
        'ToolBarButton20
        '
        Me.ToolBarButton20.DropDownMenu = Me.ContextMenuSQL
        Me.ToolBarButton20.ImageIndex = 16
        Me.ToolBarButton20.Style = System.Windows.Forms.ToolBarButtonStyle.DropDownButton
        '
        'ContextMenuSQL
        '
        Me.ContextMenuSQL.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem106, Me.MenuItem107, Me.MenuItem108})
        '
        'MenuItem106
        '
        Me.MenuItem106.Checked = True
        Me.MenuItem106.Index = 0
        Me.MenuItem106.Text = "По алфавиту (возрастание)"
        '
        'MenuItem107
        '
        Me.MenuItem107.Index = 1
        Me.MenuItem107.Text = "По алфавиту (убывание)"
        '
        'MenuItem108
        '
        Me.MenuItem108.Index = 2
        Me.MenuItem108.Text = "По порядку"
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.ItemSize = New System.Drawing.Size(58, 21)
        Me.TabControl1.Location = New System.Drawing.Point(0, 32)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(258, 184)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.TreeView1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(250, 155)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Справочник."
        '
        'TreeView1
        '
        Me.TreeView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TreeView1.ContextMenu = Me.ContextMenuTREE
        Me.TreeView1.ImageIndex = 2
        Me.TreeView1.ImageList = Me.ImageList3
        Me.TreeView1.Indent = 27
        Me.TreeView1.ItemHeight = 20
        Me.TreeView1.Location = New System.Drawing.Point(0, 0)
        Me.TreeView1.Name = "TreeView1"
        Me.TreeView1.Size = New System.Drawing.Size(250, 156)
        Me.TreeView1.TabIndex = 2
        '
        'ContextMenuTREE
        '
        Me.ContextMenuTREE.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem83, Me.MenuItem84, Me.MenuItem79, Me.MenuItem78, Me.MenuItem80, Me.MenuItem77, Me.MenuItem74, Me.MenuItem75, Me.MenuItem76, Me.MenuItem81, Me.MenuItem82})
        '
        'MenuItem83
        '
        Me.MenuItem83.Index = 0
        Me.MenuItem83.Text = "Выбрать."
        '
        'MenuItem84
        '
        Me.MenuItem84.Index = 1
        Me.MenuItem84.Text = "-"
        '
        'MenuItem79
        '
        Me.MenuItem79.Index = 2
        Me.MenuItem79.Text = "Открыть запись."
        '
        'MenuItem78
        '
        Me.MenuItem78.Index = 3
        Me.MenuItem78.Text = "Создать запись."
        '
        'MenuItem80
        '
        Me.MenuItem80.Index = 4
        Me.MenuItem80.Text = "Удалить запись."
        '
        'MenuItem77
        '
        Me.MenuItem77.Index = 5
        Me.MenuItem77.Text = "-"
        '
        'MenuItem74
        '
        Me.MenuItem74.Index = 6
        Me.MenuItem74.Text = "Создать папка."
        '
        'MenuItem75
        '
        Me.MenuItem75.Index = 7
        Me.MenuItem75.Text = "Переименовать папку"
        '
        'MenuItem76
        '
        Me.MenuItem76.Index = 8
        Me.MenuItem76.Text = "Удалить папку."
        '
        'MenuItem81
        '
        Me.MenuItem81.Index = 9
        Me.MenuItem81.Text = "-"
        '
        'MenuItem82
        '
        Me.MenuItem82.Index = 10
        Me.MenuItem82.Text = "Обновить."
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Button1)
        Me.TabPage2.Controls.Add(Me.TextBox1)
        Me.TabPage2.Controls.Add(Me.TreeView2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(250, 155)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Поиск."
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(176, 6)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(64, 23)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "Поиск"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.Location = New System.Drawing.Point(0, 8)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(168, 20)
        Me.TextBox1.TabIndex = 1
        Me.TextBox1.Text = ""
        '
        'TreeView2
        '
        Me.TreeView2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TreeView2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TreeView2.ContextMenu = Me.ContextMenuFindTREE
        Me.TreeView2.ImageIndex = 2
        Me.TreeView2.ImageList = Me.ImageList3
        Me.TreeView2.Location = New System.Drawing.Point(0, 32)
        Me.TreeView2.Name = "TreeView2"
        Me.TreeView2.SelectedImageIndex = 2
        Me.TreeView2.Size = New System.Drawing.Size(250, 120)
        Me.TreeView2.TabIndex = 0
        '
        'ContextMenuFindTREE
        '
        Me.ContextMenuFindTREE.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem111, Me.MenuItem109})
        '
        'MenuItem111
        '
        Me.MenuItem111.Index = 0
        Me.MenuItem111.Text = "Открыть запись."
        '
        'MenuItem109
        '
        Me.MenuItem109.Index = 1
        Me.MenuItem109.Text = "Выбрать."
        '
        'Splitter3
        '
        Me.Splitter3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Splitter3.Location = New System.Drawing.Point(0, 217)
        Me.Splitter3.Name = "Splitter3"
        Me.Splitter3.Size = New System.Drawing.Size(262, 3)
        Me.Splitter3.TabIndex = 1
        Me.Splitter3.TabStop = False
        '
        'Panel5
        '
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Controls.Add(Me.RichTextBox1)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel5.Location = New System.Drawing.Point(0, 220)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(262, 72)
        Me.Panel5.TabIndex = 0
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RichTextBox1.BackColor = System.Drawing.SystemColors.Control
        Me.RichTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox1.Location = New System.Drawing.Point(8, 8)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.ReadOnly = True
        Me.RichTextBox1.Size = New System.Drawing.Size(248, 56)
        Me.RichTextBox1.TabIndex = 0
        Me.RichTextBox1.Text = "Описание:"
        '
        'Splitter2
        '
        Me.Splitter2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Splitter2.Location = New System.Drawing.Point(0, 200)
        Me.Splitter2.Name = "Splitter2"
        Me.Splitter2.Size = New System.Drawing.Size(264, 3)
        Me.Splitter2.TabIndex = 1
        Me.Splitter2.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Controls.Add(Me.ListBox1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(264, 200)
        Me.Panel2.TabIndex = 0
        '
        'Panel4
        '
        Me.Panel4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel4.BackColor = System.Drawing.Color.White
        Me.Panel4.BackgroundImage = CType(resources.GetObject("Panel4.BackgroundImage"), System.Drawing.Image)
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.Label1)
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(264, 24)
        Me.Panel4.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(0, -5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(258, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Файлы:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ListBox1
        '
        Me.ListBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListBox1.ContextMenu = Me.ContextMenuCloseFiles
        Me.ListBox1.Location = New System.Drawing.Point(4, 32)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(252, 156)
        Me.ListBox1.TabIndex = 0
        '
        'ContextMenuCloseFiles
        '
        Me.ContextMenuCloseFiles.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem94})
        '
        'MenuItem94
        '
        Me.MenuItem94.Index = 0
        Me.MenuItem94.Text = "Закрыть файл."
        '
        'Splitter1
        '
        Me.Splitter1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Splitter1.Location = New System.Drawing.Point(525, 32)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(3, 497)
        Me.Splitter1.TabIndex = 10
        Me.Splitter1.TabStop = False
        '
        'OleDbSelectCommand1
        '
        Me.OleDbSelectCommand1.CommandText = "SELECT ДатаПоследнегоСохранения, ПапкаИдентификатор, СодержаниеФайла, Строка, Тип" & _
        "Объекта, ФайлВПапке, ФайлИдентификатор FROM Хранилище"
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
        Me.OleDbInsertCommand1.CommandText = "INSERT INTO Хранилище(ДатаПоследнегоСохранения, ПапкаИдентификатор, СодержаниеФай" & _
        "ла, ТипОбъекта, ФайлВПапке, ФайлИдентификатор) VALUES (?, ?, ?, ?, ?, ?)"
        Me.OleDbInsertCommand1.Connection = Me.OleDbConnection1
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("ДатаПоследнегоСохранения", System.Data.OleDb.OleDbType.DBDate, 0, "ДатаПоследнегоСохранения"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("ПапкаИдентификатор", System.Data.OleDb.OleDbType.VarWChar, 255, "ПапкаИдентификатор"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("СодержаниеФайла", System.Data.OleDb.OleDbType.VarWChar, 0, "СодержаниеФайла"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("ТипОбъекта", System.Data.OleDb.OleDbType.VarWChar, 255, "ТипОбъекта"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("ФайлВПапке", System.Data.OleDb.OleDbType.VarWChar, 255, "ФайлВПапке"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("ФайлИдентификатор", System.Data.OleDb.OleDbType.VarWChar, 255, "ФайлИдентификатор"))
        '
        'OleDbUpdateCommand1
        '
        Me.OleDbUpdateCommand1.CommandText = "UPDATE Хранилище SET ДатаПоследнегоСохранения = ?, ПапкаИдентификатор = ?, Содерж" & _
        "аниеФайла = ?, ТипОбъекта = ?, ФайлВПапке = ?, ФайлИдентификатор = ? WHERE (Стро" & _
        "ка = ?) AND (ДатаПоследнегоСохранения = ? OR ? IS NULL AND ДатаПоследнегоСохране" & _
        "ния IS NULL) AND (ПапкаИдентификатор = ? OR ? IS NULL AND ПапкаИдентификатор IS " & _
        "NULL) AND (ТипОбъекта = ? OR ? IS NULL AND ТипОбъекта IS NULL) AND (ФайлВПапке =" & _
        " ? OR ? IS NULL AND ФайлВПапке IS NULL) AND (ФайлИдентификатор = ? OR ? IS NULL " & _
        "AND ФайлИдентификатор IS NULL)"
        Me.OleDbUpdateCommand1.Connection = Me.OleDbConnection1
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("ДатаПоследнегоСохранения", System.Data.OleDb.OleDbType.DBDate, 0, "ДатаПоследнегоСохранения"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("ПапкаИдентификатор", System.Data.OleDb.OleDbType.VarWChar, 255, "ПапкаИдентификатор"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("СодержаниеФайла", System.Data.OleDb.OleDbType.VarWChar, 0, "СодержаниеФайла"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("ТипОбъекта", System.Data.OleDb.OleDbType.VarWChar, 255, "ТипОбъекта"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("ФайлВПапке", System.Data.OleDb.OleDbType.VarWChar, 255, "ФайлВПапке"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("ФайлИдентификатор", System.Data.OleDb.OleDbType.VarWChar, 255, "ФайлИдентификатор"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Строка", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Строка", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ДатаПоследнегоСохранения", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ДатаПоследнегоСохранения", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ДатаПоследнегоСохранения1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ДатаПоследнегоСохранения", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ПапкаИдентификатор", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ПапкаИдентификатор", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ПапкаИдентификатор1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ПапкаИдентификатор", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ТипОбъекта", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ТипОбъекта", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ТипОбъекта1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ТипОбъекта", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ФайлВПапке", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ФайлВПапке", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ФайлВПапке1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ФайлВПапке", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ФайлИдентификатор", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ФайлИдентификатор", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ФайлИдентификатор1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ФайлИдентификатор", System.Data.DataRowVersion.Original, Nothing))
        '
        'OleDbDeleteCommand1
        '
        Me.OleDbDeleteCommand1.CommandText = "DELETE FROM Хранилище WHERE (Строка = ?) AND (ДатаПоследнегоСохранения = ? OR ? I" & _
        "S NULL AND ДатаПоследнегоСохранения IS NULL) AND (ПапкаИдентификатор = ? OR ? IS" & _
        " NULL AND ПапкаИдентификатор IS NULL) AND (ТипОбъекта = ? OR ? IS NULL AND ТипОб" & _
        "ъекта IS NULL) AND (ФайлВПапке = ? OR ? IS NULL AND ФайлВПапке IS NULL) AND (Фай" & _
        "лИдентификатор = ? OR ? IS NULL AND ФайлИдентификатор IS NULL)"
        Me.OleDbDeleteCommand1.Connection = Me.OleDbConnection1
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Строка", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Строка", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ДатаПоследнегоСохранения", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ДатаПоследнегоСохранения", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ДатаПоследнегоСохранения1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ДатаПоследнегоСохранения", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ПапкаИдентификатор", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ПапкаИдентификатор", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ПапкаИдентификатор1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ПапкаИдентификатор", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ТипОбъекта", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ТипОбъекта", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ТипОбъекта1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ТипОбъекта", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ФайлВПапке", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ФайлВПапке", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ФайлВПапке1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ФайлВПапке", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ФайлИдентификатор", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ФайлИдентификатор", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ФайлИдентификатор1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ФайлИдентификатор", System.Data.DataRowVersion.Original, Nothing))
        '
        'OleDbDataAdapter1
        '
        Me.OleDbDataAdapter1.DeleteCommand = Me.OleDbDeleteCommand1
        Me.OleDbDataAdapter1.InsertCommand = Me.OleDbInsertCommand1
        Me.OleDbDataAdapter1.SelectCommand = Me.OleDbSelectCommand1
        Me.OleDbDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Хранилище", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("ДатаПоследнегоСохранения", "ДатаПоследнегоСохранения"), New System.Data.Common.DataColumnMapping("ПапкаИдентификатор", "ПапкаИдентификатор"), New System.Data.Common.DataColumnMapping("СодержаниеФайла", "СодержаниеФайла"), New System.Data.Common.DataColumnMapping("Строка", "Строка"), New System.Data.Common.DataColumnMapping("ТипОбъекта", "ТипОбъекта"), New System.Data.Common.DataColumnMapping("ФайлВПапке", "ФайлВПапке"), New System.Data.Common.DataColumnMapping("ФайлИдентификатор", "ФайлИдентификатор")})})
        Me.OleDbDataAdapter1.UpdateCommand = Me.OleDbUpdateCommand1
        '
        'DataSet41
        '
        Me.DataSet41.DataSetName = "DataSet4"
        Me.DataSet41.Locale = New System.Globalization.CultureInfo("ru-RU")
        '
        'DataSet51
        '
        Me.DataSet51.DataSetName = "DataSet5"
        Me.DataSet51.Locale = New System.Globalization.CultureInfo("ru-RU")
        '
        'DataSet131
        '
        Me.DataSet131.DataSetName = "DataSet13"
        Me.DataSet131.Locale = New System.Globalization.CultureInfo("ru-RU")
        '
        'Programm
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(792, 545)
        Me.Controls.Add(Me.Splitter1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ToolBar1)
        Me.Controls.Add(Me.StatusBar1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.Menu = Me.MainMenu1
        Me.Name = "Programm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Page Edition 1.0.3"
        CType(Me.StatusBarPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StatusBarPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StatusBarPanel4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StatusBarPanel3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        CType(Me.DataSet41, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet51, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet131, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Programm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TREE_UPDATE()
    End Sub

    Public Sub TREE_UPDATE()
        Try
            OleDbConnection1.ConnectionString = ModuleBase.StringConnection
            OleDbConnection1.Open()

            DataSet41.Clear()
            DataSet51.Clear()

            Dim CommandSQL As String

            If (MenuItem106.Checked = True) Then CommandSQL = "SELECT ДатаПоследнегоСохранения, ПапкаИдентификатор, СодержаниеФайла, Строка, ТипОбъекта, ФайлВПапке, ФайлИдентификатор FROM Хранилище ORDER BY ПапкаИдентификатор ASC"
            If (MenuItem107.Checked = True) Then CommandSQL = "SELECT ДатаПоследнегоСохранения, ПапкаИдентификатор, СодержаниеФайла, Строка, ТипОбъекта, ФайлВПапке, ФайлИдентификатор FROM Хранилище ORDER BY ПапкаИдентификатор DESC"
            If (MenuItem108.Checked = True) Then CommandSQL = "SELECT ДатаПоследнегоСохранения, ПапкаИдентификатор, СодержаниеФайла, Строка, ТипОбъекта, ФайлВПапке, ФайлИдентификатор FROM Хранилище ORDER BY Строка ASC"

            OleDbDataAdapter1.SelectCommand.CommandText = CommandSQL
            OleDbDataAdapter1.Fill(DataSet41, "Хранилище")

            CommandSQL = "SELECT ДатаПоследнегоСохранения, ПапкаИдентификатор, СодержаниеФайла, Строка, ТипОбъекта, ФайлВПапке, ФайлИдентификатор FROM Хранилище ORDER BY Строка ASC"
            OleDbDataAdapter1.SelectCommand.CommandText = CommandSQL
            OleDbDataAdapter1.Fill(DataSet51, "Хранилище")

            'загрузка дерева
            Dim NameGr As String
            Dim ActionGr, ActionEl As Integer
            Dim NextGr As Boolean = False
            TreeView1.Nodes.Clear()
            For i As Integer = 0 To DataSet41.Хранилище.Rows.Count - 1
                If (DataSet41.Хранилище.Item(i)("ТипОбъекта") = "Группа") Then
                    NameGr = DataSet41.Хранилище.Item(i)("ПапкаИдентификатор")
                    TreeView1.Nodes.Add(NameGr)
                    TreeView1.Nodes.Item(ActionGr).ImageIndex = 0
                    TreeView1.Nodes.Item(ActionGr).SelectedImageIndex = 1
                    ActionGr = ActionGr + 1
                    NextGr = True
                End If

                If (NextGr = True) Then
                    ActionEl = 0
                    For iEl As Integer = 0 To DataSet51.Хранилище.Rows.Count - 1
                        If (DataSet51.Хранилище.Item(iEl)("ТипОбъекта") = "Элемент") Then
                            If (DataSet51.Хранилище.Item(iEl)("ФайлВПапке") = NameGr) And (DataSet51.Хранилище.Item(iEl)("ТипОбъекта") = "Элемент") Then
                                TreeView1.Nodes.Item(ActionGr - 1).Nodes.Add(DataSet51.Хранилище.Item(iEl)("ФайлИдентификатор"))
                                TreeView1.Nodes.Item(ActionGr - 1).Nodes.Item(ActionEl).ImageIndex = 2
                                TreeView1.Nodes.Item(ActionGr - 1).Nodes.Item(ActionEl).SelectedImageIndex = 2
                                ActionEl = ActionEl + 1
                            End If
                        End If
                    Next
                    NextGr = False
                End If
            Next
            OleDbConnection1.Close()
            TreeView1.Select()
        Catch ex As Exception
            'MsgBox(ex.ToString, MsgBoxStyle.OKOnly, "Произошла ошибка!")
        End Try
    End Sub




    Public Sub ReloadLB()
        ListBox1.Items.Clear()
        For iAddLB As Integer = 1 To 100
            If (ModulePE.BaseFile(iAddLB) <> "") Then
                ListBox1.Items.Add(ModulePE.FileModule(iAddLB).MyFileName + " [" + iAddLB.ToString + "]")
            End If
        Next
        If (ListBox1.Items.Count = 0) Then
            StatusBarPanel4.Text = ""
        End If
    End Sub

    Private Sub MenuItem14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem14.Click
        Try
            Dim NewFolder As String
            Dim PoliticNewFolder As Boolean = False
            NewFolder = InputBox("Введите имя новой папки.", "Новая папка", "")
            If NewFolder <> "" Then
                'Проверка уникальности имени папки
                For i As Integer = 0 To DataSet41.Хранилище.Count - 1
                    If (DataSet41.Хранилище.Item(i)("ТипОбъекта") = "Группа") Then
                        If (DataSet41.Хранилище.Item(i)("ПапкаИдентификатор") = NewFolder) Then
                            PoliticNewFolder = True
                            MsgBox("Имя папки не уникально!!! Введите другое имя папки.", MsgBoxStyle.OKOnly, "Сообщение:")
                        End If
                    End If
                Next
                If (PoliticNewFolder = False) Then
                    OleDbConnection1.ConnectionString = ModuleBase.StringConnection
                    OleDbConnection1.Open()
                    Dim DT As DataTable = DataSet41.Хранилище
                    Dim row As DataRow
                    row = DT.NewRow
                    row("ТипОбъекта") = "Группа"
                    row("ПапкаИдентификатор") = NewFolder.ToString
                    row("СодержаниеФайла") = ""
                    row("ДатаПоследнегоСохранения") = Date.Today
                    row("ФайлИдентификатор") = ""
                    row("ФайлВПапке") = ""
                    DT.Rows.Add(row)
                    OleDbDataAdapter1.Update(DataSet41, "Хранилище")
                    OleDbConnection1.Close()
                    TREE_UPDATE()
                End If
            End If
        Catch ex As Exception
            'MsgBox(ex.ToString, MsgBoxStyle.OKOnly, "Произошла ошибка!")
        End Try
    End Sub

    Private Sub MenuItem15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem15.Click
        'Изменить
        Try
            For iTest As Integer = 0 To DataSet41.Хранилище.Count - 1
                If (DataSet41.Хранилище.Item(iTest)("ТипОбъекта") = "Группа") Then
                    If (DataSet41.Хранилище.Item(iTest)("ПапкаИдентификатор") = StatusBarPanel2.Text) Then
                        If (DataSet41.Хранилище.Item(iTest)("ТипОбъекта") = "Группа") Then
                            Dim NewFolder As String
                            Dim EditFolder As String
                            Dim PoliticNewFolder As Boolean = False
                            Dim FindEditFolder As Boolean = False
                            EditFolder = TreeView1.SelectedNode.Text
                            NewFolder = InputBox("Введите новое имя папки.", "Редактировать папку : [" + EditFolder + "]", EditFolder)
                            If NewFolder <> "" Then
                                'Проверка уникальности имени папки
                                For i As Integer = 0 To DataSet41.Хранилище.Count - 1
                                    If (DataSet41.Хранилище.Item(i)("ТипОбъекта") = "Группа") Then
                                        If (DataSet41.Хранилище.Item(i)("ПапкаИдентификатор") = NewFolder) Then
                                            PoliticNewFolder = True
                                            MsgBox("Имя папки не уникально!!! Введите другое имя папки.", MsgBoxStyle.OKOnly, "Сообщение:")
                                        End If
                                    End If
                                    If (DataSet41.Хранилище.Item(i)("ТипОбъекта") = "Группа") Then
                                        If (DataSet41.Хранилище.Item(i)("ПапкаИдентификатор") = EditFolder) Then
                                            FindEditFolder = True
                                        End If
                                    End If
                                Next
                                If (PoliticNewFolder = False) Then
                                    If (FindEditFolder = True) Then
                                        OleDbConnection1.Open()
                                        For iEdit As Integer = 0 To DataSet41.Хранилище.Count - 1
                                            If (DataSet41.Хранилище.Item(iEdit)("ТипОбъекта") = "Группа") Then
                                                If (DataSet41.Хранилище.Item(iEdit)("ТипОбъекта") = "Группа") And (DataSet41.Хранилище.Item(iEdit)("ПапкаИдентификатор") = EditFolder) Then
                                                    DataSet41.Хранилище.Item(iEdit)("ПапкаИдентификатор") = NewFolder
                                                End If
                                            End If
                                            If (DataSet41.Хранилище.Item(iEdit)("ТипОбъекта") = "Элемент") Then
                                                If (DataSet41.Хранилище.Item(iEdit)("ТипОбъекта") = "Элемент") And (DataSet41.Хранилище.Item(iEdit)("ФайлВПапке") = EditFolder) Then
                                                    DataSet41.Хранилище.Item(iEdit)("ФайлВПапке") = NewFolder
                                                End If
                                            End If
                                        Next
                                        OleDbDataAdapter1.Update(DataSet41, "Хранилище")
                                        OleDbConnection1.Close()
                                        TREE_UPDATE()
                                        MsgBox("Папка успешно переименованна.", MsgBoxStyle.OKOnly, "Сообщение:")
                                    Else
                                        MsgBox("Ошибка!!! " + "[" + EditFolder + "] не является папкой!", MsgBoxStyle.OKOnly, "Сообщение:")
                                    End If
                                End If
                            End If
                            Exit For
                        End If
                    End If
                End If
            Next
        Catch ex As Exception
            'MsgBox(ex.ToString, MsgBoxStyle.OKOnly, "Произошла ошибка!")
        End Try
    End Sub

    Private Sub MenuItem23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem23.Click
        'Удаление
        Try
            Dim DelFolder As String
            Dim FindEditFolder As Boolean = False
            DelFolder = TreeView1.SelectedNode.Text
            If (MsgBox("Вы увирены что хотите удалить папку [" + DelFolder + "] и её содержимое?", MsgBoxStyle.YesNo, "Вопрос: ") = MsgBoxResult.Yes) Then
                For i As Integer = 0 To DataSet41.Хранилище.Count - 1
                    If (DataSet41.Хранилище.Item(i)("ТипОбъекта") = "Группа") Then
                        If (DataSet41.Хранилище.Item(i)("ТипОбъекта") = "Группа") And (DataSet41.Хранилище.Item(i)("ПапкаИдентификатор") = DelFolder) Then
                            FindEditFolder = True
                        End If
                    End If
                Next
                If (FindEditFolder = True) Then
                    OleDbConnection1.Open()
                    For iDelEl As Integer = 0 To DataSet41.Хранилище.Count - 1
                        If (DataSet41.Хранилище.Item(iDelEl)("ТипОбъекта") = "Элемент") Then
                            If (DataSet41.Хранилище.Item(iDelEl)("ТипОбъекта") = "Элемент") And (DataSet41.Хранилище.Item(iDelEl)("ФайлВПапке") = DelFolder) Then
                                DataSet41.Хранилище.Item(iDelEl).Delete()
                            End If
                        End If
                    Next
                    For iDelFolder As Integer = 0 To DataSet51.Хранилище.Count - 1
                        If (DataSet51.Хранилище.Item(iDelFolder)("ТипОбъекта") = "Группа") Then
                            If (DataSet51.Хранилище.Item(iDelFolder)("ТипОбъекта") = "Группа") And (DataSet51.Хранилище.Item(iDelFolder)("ПапкаИдентификатор") = DelFolder) Then
                                DataSet51.Хранилище.Item(iDelFolder).Delete()
                            End If
                        End If
                    Next
                    OleDbDataAdapter1.Update(DataSet41, "Хранилище")
                    OleDbDataAdapter1.Update(DataSet51, "Хранилище")
                    OleDbConnection1.Close()
                    TREE_UPDATE()
                    MsgBox("Удаление прошло успешно.", MsgBoxStyle.OKOnly, "Сообщение:")
                Else
                    MsgBox("Ошибка!!! " + "[" + DelFolder + "] не является папкой!", MsgBoxStyle.OKOnly, "Сообщение:")
                End If
            End If
        Catch ex As Exception
            'MsgBox(ex.ToString, MsgBoxStyle.OKOnly, "Произошла ошибка!")
        End Try
    End Sub

    Private Sub TreeView1_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TreeView1.AfterSelect
        Try
            StatusBarPanel2.Text = TreeView1.SelectedNode.Text
            For i As Integer = 0 To DataSet41.Хранилище.Count - 1
                If (DataSet41.Хранилище.Item(i)("ТипОбъекта") = "Группа") Then
                    If (DataSet41.Хранилище.Item(i)("ПапкаИдентификатор") = StatusBarPanel2.Text) Then
                        RichTextBox1.Text = "Описание:"
                        Exit For
                    End If
                End If
                If (DataSet41.Хранилище.Item(i)("ТипОбъекта") = "Элемент") Then
                    If (DataSet41.Хранилище.Item(i)("ФайлИдентификатор") = StatusBarPanel2.Text) Then
                        RichTextBox1.Text = DataSet41.Хранилище.Item(i)("СодержаниеФайла")
                        Exit For
                    End If
                End If
            Next
        Catch ex As Exception
            'MsgBox(ex.ToString, MsgBoxStyle.OKOnly, "Произошла ошибка!")
        End Try
    End Sub

    Private Sub MenuItem24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem24.Click
        'Создать новую запись
        Dim NewLive As New NewEditForm
        Dim PoliticFolder As Boolean = False
        NewLive.MdiParent = ModulePE.ProgrammPE.ActiveForm

        For i As Integer = 0 To DataSet41.Хранилище.Rows.Count - 1
            If (DataSet41.Хранилище.Item(i)("ТипОбъекта") = "Группа") Then
                If (DataSet41.Хранилище.Item(i)("ПапкаИдентификатор") = StatusBarPanel2.Text) Then
                    PoliticFolder = True
                    Exit For
                End If
            End If
        Next
        If (PoliticFolder = True) Then
            NewLive.ActionFolder = StatusBarPanel2.Text
            NewLive.Text = "Новая запись"
            NewLive.Show()
        Else
            MsgBox("Папка не выбрана!!!" + System.Environment.NewLine + "Выберите папку в которой нужно создать запись!", MsgBoxStyle.OKOnly, "Сообщение:")
        End If

    End Sub

    Private Sub MenuItem25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem25.Click
        'Редактировать запись запись
        Dim EditLive As New NewEditForm
        Dim PoliticFolder As Boolean = False
        EditLive.MdiParent = ModulePE.ProgrammPE.ActiveForm

        For i As Integer = 0 To DataSet41.Хранилище.Rows.Count - 1
            If (DataSet41.Хранилище.Item(i)("ТипОбъекта") = "Группа") Then
                If (DataSet41.Хранилище.Item(i)("ПапкаИдентификатор") = StatusBarPanel2.Text) Then
                    PoliticFolder = True 'Значит выбрана группа
                    Exit For
                End If
            End If
        Next
        If (PoliticFolder = False) Then
            EditLive.ActionFiles = StatusBarPanel2.Text
            EditLive.Text = StatusBarPanel2.Text
            EditLive.Show()
        End If

    End Sub

    Private Sub MenuItem12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem12.Click
        End
    End Sub

    Private Sub Programm_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        End
    End Sub

    Private Sub MenuItem26_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem26.Click
        'Удалить
        Try
            Dim DelModule As Boolean = False
            If (MsgBox("Вы увирены что хотите удалить запись [" + StatusBarPanel2.Text + "]?", MsgBoxStyle.YesNo, "Вопрос: ") = MsgBoxResult.Yes) Then
                For i As Integer = 0 To DataSet41.Хранилище.Count - 1
                    If (DataSet41.Хранилище.Item(i)("ТипОбъекта") = "Элемент") Then
                        If (DataSet41.Хранилище.Item(i)("ТипОбъекта") = "Элемент") And (DataSet41.Хранилище.Item(i)("ФайлИдентификатор") = StatusBarPanel2.Text) Then
                            OleDbConnection1.Open()
                            DataSet41.Хранилище.Item(i).Delete()
                            OleDbDataAdapter1.Update(DataSet41, "Хранилище")
                            OleDbConnection1.Close()
                            DelModule = True
                            Exit For
                        End If
                    End If
                Next
                If (DelModule = True) Then
                    TREE_UPDATE()
                    MsgBox("Удаление прошло успешно.", MsgBoxStyle.OKOnly, "Сообщение:")
                Else
                    MsgBox("Ошибка!!! " + "Запись [" + StatusBarPanel2.Text + "] невозможно удалить, так как это папка!", MsgBoxStyle.OKOnly, "Сообщение:")
                End If
            End If
        Catch ex As Exception
            'MsgBox(ex.ToString, MsgBoxStyle.OKOnly, "Произошла ошибка!")
        End Try
    End Sub

    Private Sub ToolBar2_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles ToolBar2.ButtonClick
        Select Case ToolBar2.Buttons.IndexOf(e.Button)
            Case 1
                Try
                    Dim NewFolder As String
                    Dim PoliticNewFolder As Boolean = False
                    NewFolder = InputBox("Введите имя новой папки.", "Новая папка", "")
                    If NewFolder <> "" Then
                        'Проверка уникальности имени папки
                        For i As Integer = 0 To DataSet41.Хранилище.Count - 1
                            If (DataSet41.Хранилище.Item(i)("ТипОбъекта") = "Группа") Then
                                If (DataSet41.Хранилище.Item(i)("ПапкаИдентификатор") = NewFolder) Then
                                    PoliticNewFolder = True
                                    MsgBox("Имя папки не уникально!!! Введите другое имя папки.", MsgBoxStyle.OKOnly, "Сообщение:")
                                End If
                            End If
                        Next
                        If (PoliticNewFolder = False) Then
                            OleDbConnection1.ConnectionString = ModuleBase.StringConnection
                            OleDbConnection1.Open()
                            Dim DT As DataTable = DataSet41.Хранилище
                            Dim row As DataRow
                            row = DT.NewRow
                            row("ТипОбъекта") = "Группа"
                            row("ПапкаИдентификатор") = NewFolder.ToString
                            row("СодержаниеФайла") = ""
                            row("ДатаПоследнегоСохранения") = Date.Today
                            row("ФайлИдентификатор") = ""
                            row("ФайлВПапке") = ""
                            DT.Rows.Add(row)
                            OleDbDataAdapter1.Update(DataSet41, "Хранилище")
                            OleDbConnection1.Close()
                            TREE_UPDATE()
                        End If
                    End If
                Catch ex As Exception
                    'MsgBox(ex.ToString, MsgBoxStyle.OKOnly, "Произошла ошибка!")
                End Try
            Case 3
                'Создать новую запись
                Dim NewLive As New NewEditForm
                Dim PoliticFolder As Boolean = False
                NewLive.MdiParent = ModulePE.ProgrammPE.ActiveForm

                For i As Integer = 0 To DataSet41.Хранилище.Rows.Count - 1
                    If (DataSet41.Хранилище.Item(i)("ТипОбъекта") = "Группа") Then
                        If (DataSet41.Хранилище.Item(i)("ПапкаИдентификатор") = StatusBarPanel2.Text) Then
                            PoliticFolder = True
                            Exit For
                        End If
                    End If
                Next
                If (PoliticFolder = True) Then
                    NewLive.ActionFolder = StatusBarPanel2.Text
                    NewLive.Text = "Новая запись"
                    NewLive.Show()
                Else
                    MsgBox("Папка не выбрана!!!" + System.Environment.NewLine + "Выберите папку в которой нужно создать запись!", MsgBoxStyle.OKOnly, "Сообщение:")
                End If
            Case 5
                TREE_UPDATE()
        End Select
    End Sub

    Private Sub MenuItem74_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem74.Click
        Try
            Dim NewFolder As String
            Dim PoliticNewFolder As Boolean = False
            NewFolder = InputBox("Введите имя новой папки.", "Новая папка", "")
            If NewFolder <> "" Then
                'Проверка уникальности имени папки
                For i As Integer = 0 To DataSet41.Хранилище.Count - 1
                    If (DataSet41.Хранилище.Item(i)("ТипОбъекта") = "Группа") Then
                        If (DataSet41.Хранилище.Item(i)("ПапкаИдентификатор") = NewFolder) Then
                            PoliticNewFolder = True
                            MsgBox("Имя папки не уникально!!! Введите другое имя папки.", MsgBoxStyle.OKOnly, "Сообщение:")
                        End If
                    End If
                Next
                If (PoliticNewFolder = False) Then
                    OleDbConnection1.ConnectionString = ModuleBase.StringConnection
                    OleDbConnection1.Open()
                    Dim DT As DataTable = DataSet41.Хранилище
                    Dim row As DataRow
                    row = DT.NewRow
                    row("ТипОбъекта") = "Группа"
                    row("ПапкаИдентификатор") = NewFolder.ToString
                    row("СодержаниеФайла") = ""
                    row("ДатаПоследнегоСохранения") = Date.Today
                    row("ФайлИдентификатор") = ""
                    row("ФайлВПапке") = ""
                    DT.Rows.Add(row)
                    OleDbDataAdapter1.Update(DataSet41, "Хранилище")
                    OleDbConnection1.Close()
                    TREE_UPDATE()
                End If
            End If
        Catch ex As Exception
            'MsgBox(ex.ToString, MsgBoxStyle.OKOnly, "Произошла ошибка!")
        End Try
    End Sub

    Private Sub MenuItem75_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem75.Click
        'Изменить
        Try
            For iTest As Integer = 0 To DataSet41.Хранилище.Count - 1
                If (DataSet41.Хранилище.Item(iTest)("ТипОбъекта") = "Группа") Then
                    If (DataSet41.Хранилище.Item(iTest)("ПапкаИдентификатор") = StatusBarPanel2.Text) Then
                        If (DataSet41.Хранилище.Item(iTest)("ТипОбъекта") = "Группа") Then
                            Dim NewFolder As String
                            Dim EditFolder As String
                            Dim PoliticNewFolder As Boolean = False
                            Dim FindEditFolder As Boolean = False
                            EditFolder = TreeView1.SelectedNode.Text
                            NewFolder = InputBox("Введите новое имя папки.", "Редактировать папку : [" + EditFolder + "]", EditFolder)
                            If NewFolder <> "" Then
                                'Проверка уникальности имени папки
                                For i As Integer = 0 To DataSet41.Хранилище.Count - 1
                                    If (DataSet41.Хранилище.Item(i)("ТипОбъекта") = "Группа") Then
                                        If (DataSet41.Хранилище.Item(i)("ПапкаИдентификатор") = NewFolder) Then
                                            PoliticNewFolder = True
                                            MsgBox("Имя папки не уникально!!! Введите другое имя папки.", MsgBoxStyle.OKOnly, "Сообщение:")
                                        End If
                                    End If
                                    If (DataSet41.Хранилище.Item(i)("ТипОбъекта") = "Группа") Then
                                        If (DataSet41.Хранилище.Item(i)("ПапкаИдентификатор") = EditFolder) Then
                                            FindEditFolder = True
                                        End If
                                    End If
                                Next
                                If (PoliticNewFolder = False) Then
                                    If (FindEditFolder = True) Then
                                        OleDbConnection1.Open()
                                        For iEdit As Integer = 0 To DataSet41.Хранилище.Count - 1
                                            If (DataSet41.Хранилище.Item(iEdit)("ТипОбъекта") = "Группа") Then
                                                If (DataSet41.Хранилище.Item(iEdit)("ТипОбъекта") = "Группа") And (DataSet41.Хранилище.Item(iEdit)("ПапкаИдентификатор") = EditFolder) Then
                                                    DataSet41.Хранилище.Item(iEdit)("ПапкаИдентификатор") = NewFolder
                                                End If
                                            End If
                                            If (DataSet41.Хранилище.Item(iEdit)("ТипОбъекта") = "Элемент") Then
                                                If (DataSet41.Хранилище.Item(iEdit)("ТипОбъекта") = "Элемент") And (DataSet41.Хранилище.Item(iEdit)("ФайлВПапке") = EditFolder) Then
                                                    DataSet41.Хранилище.Item(iEdit)("ФайлВПапке") = NewFolder
                                                End If
                                            End If
                                        Next
                                        OleDbDataAdapter1.Update(DataSet41, "Хранилище")
                                        OleDbConnection1.Close()
                                        TREE_UPDATE()
                                        MsgBox("Папка успешно переименованна.", MsgBoxStyle.OKOnly, "Сообщение:")
                                    Else
                                        MsgBox("Ошибка!!! " + "[" + EditFolder + "] не является папкой!", MsgBoxStyle.OKOnly, "Сообщение:")
                                    End If
                                End If
                            End If
                            Exit For
                        End If
                    End If
                End If
            Next
        Catch ex As Exception
            'MsgBox(ex.ToString, MsgBoxStyle.OKOnly, "Произошла ошибка!")
        End Try
    End Sub

    Private Sub MenuItem76_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem76.Click
        'Удаление
        Try
            Dim DelFolder As String
            Dim FindEditFolder As Boolean = False
            DelFolder = TreeView1.SelectedNode.Text
            If (MsgBox("Вы увирены что хотите удалить папку [" + DelFolder + "] и её содержимое?", MsgBoxStyle.YesNo, "Вопрос: ") = MsgBoxResult.Yes) Then
                For i As Integer = 0 To DataSet41.Хранилище.Count - 1
                    If (DataSet41.Хранилище.Item(i)("ТипОбъекта") = "Группа") Then
                        If (DataSet41.Хранилище.Item(i)("ТипОбъекта") = "Группа") And (DataSet41.Хранилище.Item(i)("ПапкаИдентификатор") = DelFolder) Then
                            FindEditFolder = True
                        End If
                    End If
                Next
                If (FindEditFolder = True) Then
                    OleDbConnection1.Open()
                    For iDelEl As Integer = 0 To DataSet41.Хранилище.Count - 1
                        If (DataSet41.Хранилище.Item(iDelEl)("ТипОбъекта") = "Элемент") Then
                            If (DataSet41.Хранилище.Item(iDelEl)("ТипОбъекта") = "Элемент") And (DataSet41.Хранилище.Item(iDelEl)("ФайлВПапке") = DelFolder) Then
                                DataSet41.Хранилище.Item(iDelEl).Delete()
                            End If
                        End If
                    Next
                    For iDelFolder As Integer = 0 To DataSet51.Хранилище.Count - 1
                        If (DataSet51.Хранилище.Item(iDelFolder)("ТипОбъекта") = "Группа") Then
                            If (DataSet51.Хранилище.Item(iDelFolder)("ТипОбъекта") = "Группа") And (DataSet51.Хранилище.Item(iDelFolder)("ПапкаИдентификатор") = DelFolder) Then
                                DataSet51.Хранилище.Item(iDelFolder).Delete()
                            End If
                        End If
                    Next
                    OleDbDataAdapter1.Update(DataSet41, "Хранилище")
                    OleDbDataAdapter1.Update(DataSet51, "Хранилище")
                    OleDbConnection1.Close()
                    TREE_UPDATE()
                    MsgBox("Удаление прошло успешно.", MsgBoxStyle.OKOnly, "Сообщение:")
                Else
                    MsgBox("Ошибка!!! " + "[" + DelFolder + "] не является папкой!", MsgBoxStyle.OKOnly, "Сообщение:")
                End If
            End If
        Catch ex As Exception
            'MsgBox(ex.ToString, MsgBoxStyle.OKOnly, "Произошла ошибка!")
        End Try
    End Sub

    Private Sub MenuItem78_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem78.Click
        'Создать новую запись
        Dim NewLive As New NewEditForm
        Dim PoliticFolder As Boolean = False
        NewLive.MdiParent = ModulePE.ProgrammPE.ActiveForm

        For i As Integer = 0 To DataSet41.Хранилище.Rows.Count - 1
            If (DataSet41.Хранилище.Item(i)("ТипОбъекта") = "Группа") Then
                If (DataSet41.Хранилище.Item(i)("ПапкаИдентификатор") = StatusBarPanel2.Text) Then
                    PoliticFolder = True
                    Exit For
                End If
            End If
        Next
        If (PoliticFolder = True) Then
            NewLive.ActionFolder = StatusBarPanel2.Text
            NewLive.Text = "Новая запись"
            NewLive.Show()
        Else
            MsgBox("Папка не выбрана!!!" + System.Environment.NewLine + "Выберите папку в которой нужно создать запись!", MsgBoxStyle.OKOnly, "Сообщение:")
        End If
    End Sub

    Private Sub MenuItem79_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem79.Click
        'Редактировать запись запись
        Dim EditLive As New NewEditForm
        Dim PoliticFolder As Boolean = False
        EditLive.MdiParent = ModulePE.ProgrammPE.ActiveForm

        For i As Integer = 0 To DataSet41.Хранилище.Rows.Count - 1
            If (DataSet41.Хранилище.Item(i)("ТипОбъекта") = "Группа") Then
                If (DataSet41.Хранилище.Item(i)("ПапкаИдентификатор") = StatusBarPanel2.Text) Then
                    PoliticFolder = True 'Значит выбрана группа
                    Exit For
                End If
            End If
        Next
        If (PoliticFolder = False) Then
            EditLive.ActionFiles = StatusBarPanel2.Text
            EditLive.Text = StatusBarPanel2.Text
            EditLive.Show()
        End If
    End Sub

    Private Sub MenuItem80_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem80.Click
        'Удалить
        Try
            Dim DelModule As Boolean = False
            If (MsgBox("Вы увирены что хотите удалить запись [" + StatusBarPanel2.Text + "]?", MsgBoxStyle.YesNo, "Вопрос: ") = MsgBoxResult.Yes) Then
                For i As Integer = 0 To DataSet41.Хранилище.Count - 1
                    If (DataSet41.Хранилище.Item(i)("ТипОбъекта") = "Элемент") Then
                        If (DataSet41.Хранилище.Item(i)("ТипОбъекта") = "Элемент") And (DataSet41.Хранилище.Item(i)("ФайлИдентификатор") = StatusBarPanel2.Text) Then
                            OleDbConnection1.Open()
                            DataSet41.Хранилище.Item(i).Delete()
                            OleDbDataAdapter1.Update(DataSet41, "Хранилище")
                            OleDbConnection1.Close()
                            DelModule = True
                            Exit For
                        End If
                    End If
                Next
                If (DelModule = True) Then
                    TREE_UPDATE()
                    MsgBox("Удаление прошло успешно.", MsgBoxStyle.OKOnly, "Сообщение:")
                Else
                    MsgBox("Ошибка!!! " + "Запись [" + StatusBarPanel2.Text + "] невозможно удалить, так как это папка!", MsgBoxStyle.OKOnly, "Сообщение:")
                End If
            End If
        Catch ex As Exception
            'MsgBox(ex.ToString, MsgBoxStyle.OKOnly, "Произошла ошибка!")
        End Try
    End Sub

    Private Sub MenuItem82_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem82.Click
        TREE_UPDATE()
    End Sub

    Private Sub MenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem2.Click
        'Создать файл по умолчанию ASCII
        If (SaveFileDialog1.ShowDialog = DialogResult.OK) Then
            LoadFilesBase(SaveFileDialog1.FileName, "Создать по умолчанию")
        End If
    End Sub

    Public Sub LoadFilesBase(ByVal FileNameAndPath As String, ByVal OpenOrCreate As String)
        Try
            Dim FileNameCreate As String
            Dim iIndex, iStartDel, iEndDel As Integer
            iIndex = FileNameAndPath.Length - 1
            For iFN As Integer = 0 To FileNameAndPath.Length - 1
                If (FileNameAndPath.Chars(iIndex) = "\") Then
                    iStartDel = 0
                    iEndDel = FileNameAndPath.Length - iFN
                    FileNameCreate = FileNameAndPath.Remove(iStartDel, iEndDel)
                    Exit For
                Else
                    iIndex = iIndex - 1
                End If
            Next
            For iSerchFreeFile As Integer = 1 To 100
                If (ModulePE.BaseFile(iSerchFreeFile) = "") Then
                    ModulePE.LoadFM(iSerchFreeFile)
                    ModulePE.FileModule(iSerchFreeFile).MdiParent = ModulePE.ProgrammPE.ActiveForm
                    ModulePE.FileModule(iSerchFreeFile).MyFileName = FileNameCreate
                    ModulePE.FileModule(iSerchFreeFile).MyPath = FileNameAndPath
                    ModulePE.FileModule(iSerchFreeFile).MyID = iSerchFreeFile
                    ModulePE.FileModule(iSerchFreeFile).OpenOrCreate = OpenOrCreate
                    ModulePE.FileModule(iSerchFreeFile).Text = FileNameCreate
                    ModulePE.FileModule(iSerchFreeFile).Label1.Text = TestFile(FileNameCreate)
                    ModulePE.FileModule(iSerchFreeFile).StatusBarPanel3.Text = FileNameAndPath
                    If (OpenOrCreate = "Создать по умолчанию") Then 'ASCII
                        ModulePE.FileModule(iSerchFreeFile).StatusBarPanel1.Text = "ascii"
                        ModulePE.FileModule(iSerchFreeFile).RichTextBox1.SaveFile(FileNameAndPath, RichTextBoxStreamType.PlainText)
                    End If
                    If (OpenOrCreate = "Создать UTF-8") Then 'UTF-8
                        ModulePE.FileModule(iSerchFreeFile).StatusBarPanel1.Text = "utf-8"
                        Dim writer As StreamWriter = New StreamWriter(FileNameAndPath, False, Encoding.UTF8)
                        writer.Write("")
                        writer.Close()
                    End If
                    If (OpenOrCreate = "Создать ASCII") Then 'ASCII
                        ModulePE.FileModule(iSerchFreeFile).StatusBarPanel1.Text = "ascii"
                        Dim writer As StreamWriter = New StreamWriter(FileNameAndPath, False, Encoding.ASCII)
                        writer.Write("")
                        writer.Close()
                    End If
                    If (OpenOrCreate = "Создать UTF-8 WINTOUT BOM") Then 'UTF-8 without BOM
                        ModulePE.FileModule(iSerchFreeFile).StatusBarPanel1.Text = "utf-8 wintout BOM"
                        Dim utf8WithoutBom As New System.Text.UTF8Encoding(False)
                        Dim writer As StreamWriter = New StreamWriter(SaveFileDialog1.FileName, False, utf8WithoutBom)
                        writer.Write("")
                        writer.Close()
                    End If
                    If (OpenOrCreate = "Открыть по умолчанию") Then 'ASCII
                        ModulePE.FileModule(iSerchFreeFile).StatusBarPanel1.Text = "ascii"
                        ModulePE.FileModule(iSerchFreeFile).RichTextBox1.LoadFile(FileNameAndPath, RichTextBoxStreamType.PlainText)
                    End If
                    If (OpenOrCreate = "Открыть UTF-8") Then 'UTF-8
                        ModulePE.FileModule(iSerchFreeFile).StatusBarPanel1.Text = "utf-8"
                        Dim sr As StreamReader = New StreamReader(FileNameAndPath, System.Text.Encoding.UTF8)
                        ModulePE.FileModule(iSerchFreeFile).RichTextBox1.Clear()
                        ModulePE.FileModule(iSerchFreeFile).RichTextBox1.LoadFile(sr.BaseStream, RichTextBoxStreamType.PlainText)
                        sr.Close()
                    End If
                    If (OpenOrCreate = "Открыть UTF-8 WINTOUT BOM") Then 'UTF-8 WINTOUT BOM
                        ModulePE.FileModule(iSerchFreeFile).StatusBarPanel1.Text = "utf-8 wintout BOM"
                        Dim utf8WithoutBom As New System.Text.UTF8Encoding(False)
                        Dim sr As StreamReader = New StreamReader(FileNameAndPath, utf8WithoutBom)
                        ModulePE.FileModule(iSerchFreeFile).RichTextBox1.Clear()
                        While sr.Peek() > -1
                            ModulePE.FileModule(iSerchFreeFile).RichTextBox1.Text = ModulePE.FileModule(iSerchFreeFile).RichTextBox1.Text + sr.ReadLine + System.Environment.NewLine
                        End While
                        sr.Close()
                    End If
                    If (OpenOrCreate = "Открыть ASCII") Then 'ASCII
                        ModulePE.FileModule(iSerchFreeFile).StatusBarPanel1.Text = "ascii"
                        Dim sr As StreamReader = New StreamReader(FileNameAndPath, System.Text.Encoding.ASCII)
                        ModulePE.FileModule(iSerchFreeFile).RichTextBox1.Clear()
                        ModulePE.FileModule(iSerchFreeFile).RichTextBox1.LoadFile(sr.BaseStream, RichTextBoxStreamType.PlainText)
                        sr.Close()
                    End If
                    ModulePE.FileModule(iSerchFreeFile).StatusBarPanel4.Text = FileNameCreate
                    ModulePE.FileModule(iSerchFreeFile).Show()
                    ListBox1.Items.Add(FileNameCreate + " [" + iSerchFreeFile.ToString + "]")
                    ModulePE.BaseFile(iSerchFreeFile) = FileNameCreate + " [" + iSerchFreeFile.ToString + "]"
                    Exit For
                End If
            Next
        Catch ex As Exception

        End Try
    End Sub

    Public Function TestFile(ByVal FileNameOpenAuto As String) As String
        Dim TypeFile As String
        Dim OpenFileName As String
        For i As Integer = 0 To FileNameOpenAuto.Length - 1
            'определяем тип файла
            If (FileNameOpenAuto.Chars(FileNameOpenAuto.Length - 1 - i) = ".") Then
                TypeFile = FileNameOpenAuto.Remove(0, FileNameOpenAuto.Length - i)
            End If
            If (FileNameOpenAuto.Chars(FileNameOpenAuto.Length - 1 - i) = "\") Then
                OpenFileName = FileNameOpenAuto.Remove(0, FileNameOpenAuto.Length - i)
                Exit For
            End If
        Next
        If (TypeFile = "html" Or TypeFile = "htm" Or TypeFile = "HTML" Or TypeFile = "HTM") Then
            Return "HTML SCRIPT"
        Else
            If (TypeFile = "css" Or TypeFile = "CSS") Then
                Return "CSS SCRIPT"
            Else
                If (TypeFile = "js" Or TypeFile = "JS") Then
                    Return "JS SCRIPT"
                Else
                    If (TypeFile = "php" Or TypeFile = "PHP") Then
                        Return "PHP SCRIPT"
                    Else
                        Return "SCRIPT"
                    End If
                End If
            End If
        End If

    End Function

    Private Sub MenuItem91_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem91.Click
        'Создать файл UTF-8
        If (SaveFileDialog1.ShowDialog = DialogResult.OK) Then
            LoadFilesBase(SaveFileDialog1.FileName, "Создать UTF-8")
        End If
    End Sub

    Private Sub MenuItem92_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem92.Click
        'Создать файл ASCII
        If (SaveFileDialog1.ShowDialog = DialogResult.OK) Then
            LoadFilesBase(SaveFileDialog1.FileName, "Создать ASCII")
        End If
    End Sub

    Private Sub MenuItem93_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem93.Click
        'Создать файл UTF-8 without BOM
        If (SaveFileDialog1.ShowDialog = DialogResult.OK) Then
            'Dim utf8WithoutBom As New System.Text.UTF8Encoding(False)

            'Dim writer As StreamWriter = New StreamWriter(SaveFileDialog1.FileName, False, utf8WithoutBom)
            'writer.Write("<title>Проверка</title>")
            'writer.Close()

            'Dim sink As New StreamWriter(SaveFileDialog1.FileName, False, utf8WithoutBom)
            'sink.WriteLine("<title>Проверка</title>")
            'sink.Close()

            LoadFilesBase(SaveFileDialog1.FileName, "Создать UTF-8 WINTOUT BOM")
        End If
    End Sub

    Private Sub MenuItem7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem7.Click
        'Открыть файл по умолчанию ASCII
        If (OpenFileDialog1.ShowDialog = DialogResult.OK) Then
            LoadFilesBase(OpenFileDialog1.FileName, "Открыть по умолчанию")
        End If
    End Sub

    Private Sub MenuItem41_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem41.Click
        'Открыть файл UTF-8
        If (OpenFileDialog1.ShowDialog = DialogResult.OK) Then
            LoadFilesBase(OpenFileDialog1.FileName, "Открыть UTF-8")
        End If
    End Sub

    Private Sub MenuItem40_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem40.Click
        'Открыть файл ASCII
        If (OpenFileDialog1.ShowDialog = DialogResult.OK) Then
            LoadFilesBase(OpenFileDialog1.FileName, "Открыть ASCII")
        End If
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
        For iFindFile As Integer = 1 To 100
            If (ModulePE.BaseFile(iFindFile) = ListBox1.Items.Item(ListBox1.SelectedIndex)) Then
                ModulePE.FileModule(iFindFile).Focus()
                ModulePE.FileModule(iFindFile).WindowState = FormWindowState.Normal
                Exit For
            End If
        Next
    End Sub

    Private Sub MenuItem94_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem94.Click
        Try
            For iFindFile As Integer = 0 To 100
                If (ModulePE.BaseFile(iFindFile) = ListBox1.Items.Item(ListBox1.SelectedIndex)) Then
                    ModulePE.FileModule(iFindFile).Close()
                    Exit For
                End If
            Next
        Catch ex As Exception
            'MsgBox(ex.ToString, MsgBoxStyle.OKOnly, "Произошла ошибка!")
        End Try
    End Sub

    Private Sub MenuItem83_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem83.Click
        'Вставить
        For iFindFile As Integer = 0 To 100
            If (ModulePE.BaseFile(iFindFile) = ModulePE.ProgrammPE.StatusBarPanel4.Text) Then
                ModulePE.FileModule(iFindFile).FormatText(ModulePE.ProgrammPE.StatusBarPanel2.Text)
                Exit For
            End If
        Next
    End Sub

    Private Sub MenuItem9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem9.Click
        'Сохранить активный файл
        Try
            For iFindFile As Integer = 0 To 100
                If (ModulePE.BaseFile(iFindFile) = ModulePE.ProgrammPE.StatusBarPanel4.Text) Then
                    'Если кодировка ASCII
                    If (ModulePE.FileModule(iFindFile).StatusBarPanel1.Text = "ascii") Then
                        ModulePE.FileModule(iFindFile).RichTextBox1.SaveFile(ModulePE.FileModule(iFindFile).MyPath, RichTextBoxStreamType.PlainText)
                        ModulePE.FileModule(iFindFile).Icon = NotifyIcon1.Icon
                        ModulePE.FileModule(iFindFile).StatusBarPanel1.Text = "ascii"
                    End If
                    'Если кодировка UTF-8
                    If (ModulePE.FileModule(iFindFile).StatusBarPanel1.Text = "utf-8") Then
                        Dim writer As StreamWriter = New StreamWriter(ModulePE.FileModule(iFindFile).MyPath, False, Encoding.UTF8)
                        writer.Write(ModulePE.FileModule(iFindFile).RichTextBox1.Text)
                        writer.Close()
                        ModulePE.FileModule(iFindFile).Icon = NotifyIcon1.Icon
                        ModulePE.FileModule(iFindFile).StatusBarPanel1.Text = "utf-8"
                    End If
                    'Если кодировка UTF-8 Without BOM
                    If (ModulePE.FileModule(iFindFile).StatusBarPanel1.Text = "utf-8 wintout BOM") Then
                        Dim utf8WithoutBom As New System.Text.UTF8Encoding(False)
                        Dim writer As StreamWriter = New StreamWriter(ModulePE.FileModule(iFindFile).MyPath, False, utf8WithoutBom)
                        writer.Write(ModulePE.FileModule(iFindFile).RichTextBox1.Text)
                        writer.Close()
                        ModulePE.FileModule(iFindFile).Icon = NotifyIcon1.Icon
                        ModulePE.FileModule(iFindFile).StatusBarPanel1.Text = "utf-8 wintout BOM"
                    End If
                    Exit For
                End If
            Next
        Catch ex As Exception

        End Try
    End Sub

    Private Sub MenuItem88_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem88.Click
        'Сохранить активный файл (UTF-8)
        For iFindFile As Integer = 0 To 100
            If (ModulePE.BaseFile(iFindFile) = ModulePE.ProgrammPE.StatusBarPanel4.Text) Then
                Dim writer As StreamWriter = New StreamWriter(ModulePE.FileModule(iFindFile).MyPath, False, Encoding.UTF8)
                writer.Write(ModulePE.FileModule(iFindFile).RichTextBox1.Text)
                writer.Close()
                ModulePE.FileModule(iFindFile).Icon = NotifyIcon1.Icon
                ModulePE.FileModule(iFindFile).StatusBarPanel1.Text = "utf-8"
                Exit For
            End If
        Next
    End Sub

    Private Sub MenuItem89_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem89.Click
        'Сохранить активный файл (ASCII)
        For iFindFile As Integer = 0 To 100
            If (ModulePE.BaseFile(iFindFile) = ModulePE.ProgrammPE.StatusBarPanel4.Text) Then
                Dim writer As StreamWriter = New StreamWriter(ModulePE.FileModule(iFindFile).MyPath, False, Encoding.ASCII)
                writer.Write(ModulePE.FileModule(iFindFile).RichTextBox1.Text)
                writer.Close()
                ModulePE.FileModule(iFindFile).Icon = NotifyIcon1.Icon
                ModulePE.FileModule(iFindFile).StatusBarPanel1.Text = "ascii"
                Exit For
            End If
        Next
    End Sub

    Private Sub MenuItem10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem10.Click
        'Сохранить активный файл как (по умолчанию ASCII)
        Try
            If (SaveFileDialog1.ShowDialog = DialogResult.OK) Then
                For iFindFile As Integer = 0 To 100
                    If (ModulePE.BaseFile(iFindFile) = ModulePE.ProgrammPE.StatusBarPanel4.Text) Then

                        Dim FileNameCreate As String
                        Dim FileNameAndPath As String = SaveFileDialog1.FileName
                        Dim iIndex, iStartDel, iEndDel As Integer
                        iIndex = FileNameAndPath.Length - 1
                        For iFN As Integer = 0 To FileNameAndPath.Length - 1
                            If (FileNameAndPath.Chars(iIndex) = "\") Then
                                iStartDel = 0
                                iEndDel = FileNameAndPath.Length - iFN
                                FileNameCreate = FileNameAndPath.Remove(iStartDel, iEndDel)
                                Exit For
                            Else
                                iIndex = iIndex - 1
                            End If
                        Next
                        ModulePE.BaseFile(iFindFile) = FileNameCreate + " [" + iFindFile.ToString + "]"
                        ModulePE.FileModule(iFindFile).MyFileName = FileNameCreate
                        ModulePE.FileModule(iFindFile).MyPath = FileNameAndPath
                        ModulePE.FileModule(iFindFile).Text = FileNameCreate
                        ModulePE.FileModule(iFindFile).Label1.Text = TestFile(FileNameCreate)
                        ModulePE.FileModule(iFindFile).StatusBarPanel3.Text = FileNameAndPath

                        ModulePE.FileModule(iFindFile).RichTextBox1.SaveFile(ModulePE.FileModule(iFindFile).MyPath, RichTextBoxStreamType.PlainText)
                        ModulePE.FileModule(iFindFile).Icon = NotifyIcon1.Icon
                        ModulePE.FileModule(iFindFile).StatusBarPanel1.Text = "ascii"
                        ReloadLB()
                        Exit For
                    End If
                Next
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub MenuItem42_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem42.Click
        'Сохранить активный файл как (UFT-8)
        Try
            If (SaveFileDialog1.ShowDialog = DialogResult.OK) Then
                For iFindFile As Integer = 0 To 100
                    If (ModulePE.BaseFile(iFindFile) = ModulePE.ProgrammPE.StatusBarPanel4.Text) Then

                        Dim FileNameCreate As String
                        Dim FileNameAndPath As String = SaveFileDialog1.FileName
                        Dim iIndex, iStartDel, iEndDel As Integer
                        iIndex = FileNameAndPath.Length - 1
                        For iFN As Integer = 0 To FileNameAndPath.Length - 1
                            If (FileNameAndPath.Chars(iIndex) = "\") Then
                                iStartDel = 0
                                iEndDel = FileNameAndPath.Length - iFN
                                FileNameCreate = FileNameAndPath.Remove(iStartDel, iEndDel)
                                Exit For
                            Else
                                iIndex = iIndex - 1
                            End If
                        Next
                        ModulePE.BaseFile(iFindFile) = FileNameCreate + " [" + iFindFile.ToString + "]"
                        ModulePE.FileModule(iFindFile).MyFileName = FileNameCreate
                        ModulePE.FileModule(iFindFile).MyPath = FileNameAndPath
                        ModulePE.FileModule(iFindFile).Text = FileNameCreate
                        ModulePE.FileModule(iFindFile).Label1.Text = TestFile(FileNameCreate)
                        ModulePE.FileModule(iFindFile).StatusBarPanel3.Text = FileNameAndPath

                        Dim writer As StreamWriter = New StreamWriter(ModulePE.FileModule(iFindFile).MyPath, False, Encoding.UTF8)
                        writer.Write(ModulePE.FileModule(iFindFile).RichTextBox1.Text)
                        writer.Close()

                        ModulePE.FileModule(iFindFile).Icon = NotifyIcon1.Icon
                        ModulePE.FileModule(iFindFile).StatusBarPanel1.Text = "utf-8"
                        ReloadLB()
                        Exit For
                    End If
                Next
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub MenuItem37_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem37.Click
        'Сохранить активный файл как (UFT-8)
        If (SaveFileDialog1.ShowDialog = DialogResult.OK) Then
            For iFindFile As Integer = 0 To 100
                If (ModulePE.BaseFile(iFindFile) = ModulePE.ProgrammPE.StatusBarPanel4.Text) Then

                    Dim FileNameCreate As String
                    Dim FileNameAndPath As String = SaveFileDialog1.FileName
                    Dim iIndex, iStartDel, iEndDel As Integer
                    iIndex = FileNameAndPath.Length - 1
                    For iFN As Integer = 0 To FileNameAndPath.Length - 1
                        If (FileNameAndPath.Chars(iIndex) = "\") Then
                            iStartDel = 0
                            iEndDel = FileNameAndPath.Length - iFN
                            FileNameCreate = FileNameAndPath.Remove(iStartDel, iEndDel)
                            Exit For
                        Else
                            iIndex = iIndex - 1
                        End If
                    Next
                    ModulePE.BaseFile(iFindFile) = FileNameCreate + " [" + iFindFile.ToString + "]"
                    ModulePE.FileModule(iFindFile).MyFileName = FileNameCreate
                    ModulePE.FileModule(iFindFile).MyPath = FileNameAndPath
                    ModulePE.FileModule(iFindFile).Text = FileNameCreate
                    ModulePE.FileModule(iFindFile).Label1.Text = TestFile(FileNameCreate)
                    ModulePE.FileModule(iFindFile).StatusBarPanel3.Text = FileNameAndPath

                    Dim writer As StreamWriter = New StreamWriter(ModulePE.FileModule(iFindFile).MyPath, False, Encoding.ASCII)
                    writer.Write(ModulePE.FileModule(iFindFile).RichTextBox1.Text)
                    writer.Close()

                    ModulePE.FileModule(iFindFile).Icon = NotifyIcon1.Icon
                    ModulePE.FileModule(iFindFile).StatusBarPanel1.Text = "ascii"
                    ReloadLB()
                    Exit For
                End If
            Next
        End If
    End Sub

    Private Sub MenuItem13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem13.Click
        'Сохранить все открытые файлы
        Try
            For iLBSave As Integer = 0 To ListBox1.Items.Count - 1
                For iFindFile As Integer = 1 To 100
                    If (ModulePE.BaseFile(iFindFile) = ListBox1.Items.Item(iLBSave)) Then
                        'Если кодировка ASCII
                        If (ModulePE.FileModule(iFindFile).StatusBarPanel1.Text = "ascii") Then
                            ModulePE.FileModule(iFindFile).RichTextBox1.SaveFile(ModulePE.FileModule(iFindFile).MyPath, RichTextBoxStreamType.PlainText)
                            ModulePE.FileModule(iFindFile).Icon = NotifyIcon1.Icon
                            ModulePE.FileModule(iFindFile).StatusBarPanel1.Text = "ascii"
                        End If
                        'Если кодировка UTF-8
                        If (ModulePE.FileModule(iFindFile).StatusBarPanel1.Text = "utf-8") Then
                            Dim writer As StreamWriter = New StreamWriter(ModulePE.FileModule(iFindFile).MyPath, False, Encoding.UTF8)
                            writer.Write(ModulePE.FileModule(iFindFile).RichTextBox1.Text)
                            writer.Close()
                            ModulePE.FileModule(iFindFile).Icon = NotifyIcon1.Icon
                            ModulePE.FileModule(iFindFile).StatusBarPanel1.Text = "utf-8"
                        End If
                        'Если кодировка UTF-8 Without BOM
                        If (ModulePE.FileModule(iFindFile).StatusBarPanel1.Text = "utf-8 wintout BOM") Then
                            Dim utf8WithoutBom As New System.Text.UTF8Encoding(False)
                            Dim writer As StreamWriter = New StreamWriter(ModulePE.FileModule(iFindFile).MyPath, False, utf8WithoutBom)
                            writer.Write(ModulePE.FileModule(iFindFile).RichTextBox1.Text)
                            writer.Close()
                            ModulePE.FileModule(iFindFile).Icon = NotifyIcon1.Icon
                            ModulePE.FileModule(iFindFile).StatusBarPanel1.Text = "utf-8 wintout BOM"
                        End If
                    End If
                Next
            Next
        Catch ex As Exception

        End Try
    End Sub

    Private Sub MenuItem85_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem85.Click
        'Сохранить все открытые файлы (UTF-8)
        For iLBSave As Integer = 0 To ListBox1.Items.Count - 1
            For iFindFile As Integer = 1 To 100
                If (ModulePE.BaseFile(iFindFile) = ListBox1.Items.Item(iLBSave)) Then
                    Dim writer As StreamWriter = New StreamWriter(ModulePE.FileModule(iFindFile).MyPath, False, Encoding.UTF8)
                    writer.Write(ModulePE.FileModule(iFindFile).RichTextBox1.Text)
                    writer.Close()

                    ModulePE.FileModule(iFindFile).StatusBarPanel1.Text = "utf-8"
                    ModulePE.FileModule(iFindFile).Icon = NotifyIcon1.Icon
                End If
            Next
        Next
    End Sub

    Private Sub MenuItem86_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem86.Click
        'Сохранить все открытые файлы (ASCII)
        For iLBSave As Integer = 0 To ListBox1.Items.Count - 1
            For iFindFile As Integer = 1 To 100
                If (ModulePE.BaseFile(iFindFile) = ListBox1.Items.Item(iLBSave)) Then
                    Dim writer As StreamWriter = New StreamWriter(ModulePE.FileModule(iFindFile).MyPath, False, Encoding.ASCII)
                    writer.Write(ModulePE.FileModule(iFindFile).RichTextBox1.Text)
                    writer.Close()

                    ModulePE.FileModule(iFindFile).StatusBarPanel1.Text = "ascii"
                    ModulePE.FileModule(iFindFile).Icon = NotifyIcon1.Icon
                End If
            Next
        Next
    End Sub

    Private Sub MenuItem51_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem51.Click
        Try
            If (ModulePE.SettingsShow = False) Then
                Dim SettingProg As New Settings
                SettingProg.MdiParent = ModulePE.ProgrammPE.ActiveForm
                SettingProg.Show()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub MenuItem73_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem73.Click
        If (ModulePE.FTPShow = False) Then
            Dim FTP As New FTPClient
            FTP.MdiParent = ModulePE.ProgrammPE.ActiveForm
            FTP.Show()
        End If
    End Sub

    Private Sub MenuItem28_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem28.Click
        Try
            For iFindFile As Integer = 0 To 100
                If (ModulePE.BaseFile(iFindFile) = ModulePE.ProgrammPE.StatusBarPanel4.Text) Then
                    System.Diagnostics.Process.Start(ModulePE.FileModule(iFindFile).MyPath)
                    Exit For
                End If
            Next
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.OKOnly, "Произошла ошибка!")
        End Try
    End Sub

    Private Sub MenuItem35_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem35.Click
        Try
            For iFindFile As Integer = 0 To 100
                If (ModulePE.BaseFile(iFindFile) = ModulePE.ProgrammPE.StatusBarPanel4.Text) Then
                    System.Diagnostics.Process.Start(ModulePE.IExplorer, ModulePE.FileModule(iFindFile).MyPath)
                    Exit For
                End If
            Next
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.OKOnly, "Произошла ошибка!")
        End Try
    End Sub

    Private Sub MenuItem32_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem32.Click
        Try
            For iFindFile As Integer = 0 To 100
                If (ModulePE.BaseFile(iFindFile) = ModulePE.ProgrammPE.StatusBarPanel4.Text) Then
                    System.Diagnostics.Process.Start(ModulePE.Opera, ModulePE.FileModule(iFindFile).MyPath)
                    Exit For
                End If
            Next
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.OKOnly, "Произошла ошибка!")
        End Try
    End Sub

    Private Sub MenuItem27_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem27.Click
        Try
            For iFindFile As Integer = 0 To 100
                If (ModulePE.BaseFile(iFindFile) = ModulePE.ProgrammPE.StatusBarPanel4.Text) Then
                    System.Diagnostics.Process.Start(ModulePE.FireFox, ModulePE.FileModule(iFindFile).MyPath)
                    Exit For
                End If
            Next
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.OKOnly, "Произошла ошибка!")
        End Try
    End Sub

    Private Sub MenuItem38_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem38.Click
        Try
            For iFindFile As Integer = 0 To 100
                If (ModulePE.BaseFile(iFindFile) = ModulePE.ProgrammPE.StatusBarPanel4.Text) Then
                    System.Diagnostics.Process.Start(ModulePE.Chrome, ModulePE.FileModule(iFindFile).MyPath)
                    Exit For
                End If
            Next
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.OKOnly, "Произошла ошибка!")
        End Try
    End Sub

    Private Sub MenuItem39_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem39.Click
        Try
            For iFindFile As Integer = 0 To 100
                If (ModulePE.BaseFile(iFindFile) = ModulePE.ProgrammPE.StatusBarPanel4.Text) Then
                    System.Diagnostics.Process.Start(ModulePE.Safari, ModulePE.FileModule(iFindFile).MyPath)
                    Exit For
                End If
            Next
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.OKOnly, "Произошла ошибка!")
        End Try
    End Sub

    Private Sub MenuItem33_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem33.Click
        Try
            For iFindFile As Integer = 0 To 100
                If (ModulePE.BaseFile(iFindFile) = ModulePE.ProgrammPE.StatusBarPanel4.Text) Then

                    Dim FileNameCreate As String
                    FileNameCreate = ModulePE.FileModule(iFindFile).StatusBarPanel4.Text

                    Dim PathLocalhost As String
                    PathLocalhost = InputBox("Введите путь к вашему блогу", "Хост Denwer", ModulePE.DENWER_host + FileNameCreate)
                    If (PathLocalhost <> "") Then System.Diagnostics.Process.Start(PathLocalhost)

                    Exit For
                End If
            Next
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.OKOnly, "Произошла ошибка!")
        End Try
    End Sub

    Private Sub MenuItem45_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem45.Click

    End Sub

    Private Sub MenuItem17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem17.Click
        Try
            System.Diagnostics.Process.Start(ModulePE.DENWER_Path + "\denwer\Run.exe")
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.OKOnly, "Произошла ошибка!")
        End Try
    End Sub

    Private Sub MenuItem19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem19.Click
        Try
            System.Diagnostics.Process.Start(ModulePE.DENWER_Path + "\denwer\Stop.exe")
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.OKOnly, "Произошла ошибка!")
        End Try
    End Sub

    Private Sub MenuItem18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem18.Click
        Try
            System.Diagnostics.Process.Start(ModulePE.DENWER_Path + "\denwer\Restart.exe")
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.OKOnly, "Произошла ошибка!")
        End Try
    End Sub

    Private Sub MenuItem22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem22.Click
        Try
            System.Diagnostics.Process.Start(ModulePE.DENWER_host)
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.OKOnly, "Произошла ошибка!")
        End Try
    End Sub

    Private Sub MenuItem21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem21.Click
        Try
            System.Diagnostics.Process.Start(ModulePE.DENWER_MyPhpAdmin)
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.OKOnly, "Произошла ошибка!")
        End Try
    End Sub

    Private Sub MenuItem29_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem29.Click
        Try
            For iFindFile As Integer = 0 To 100
                If (ModulePE.BaseFile(iFindFile) = ModulePE.ProgrammPE.StatusBarPanel4.Text) Then

                    Dim FileNameCreate As String
                    Dim iIndex, iStartDel, iEndDel As Integer
                    iIndex = StatusBarPanel4.Text.Length - 1
                    For iFN As Integer = 0 To ModulePE.FileModule(iFindFile).MyPath.Length - 1
                        If (ModulePE.FileModule(iFindFile).MyPath.Chars(iIndex) = "\") Then
                            iStartDel = 0
                            iEndDel = ModulePE.FileModule(iFindFile).MyPath.Length - iFN
                            FileNameCreate = ModulePE.FileModule(iFindFile).MyPath.Remove(iStartDel, iEndDel)
                            Exit For
                        Else
                            iIndex = iIndex - 1
                        End If
                    Next

                    Dim PathLocalhost As String
                    PathLocalhost = InputBox("Введите путь к вашему блогу", "Хост Denwer", ModulePE.DENWER_host + FileNameCreate)
                    If (PathLocalhost <> "") Then System.Diagnostics.Process.Start(PathLocalhost)

                    Exit For
                End If
            Next
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.OKOnly, "Произошла ошибка!")
        End Try
    End Sub

    Private Sub MenuItem6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem6.Click
        Try
            System.Diagnostics.Process.Start("mspaint.exe")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub MenuItem31_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem31.Click
        Try
            System.Diagnostics.Process.Start("wordpad.exe")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub MenuItem46_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem46.Click
        Try
            System.Diagnostics.Process.Start("notepad.exe")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub MenuItem47_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem47.Click
        'проводник
        System.Diagnostics.Process.Start("explorer.exe")
    End Sub

    Private Sub MenuItem48_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem48.Click
        Try
            System.Diagnostics.Process.Start("calc.exe")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub MenuItem49_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem49.Click
        Try
            System.Diagnostics.Process.Start("cmd.exe")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub MenuItem53_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem53.Click
        Try
            System.Diagnostics.Process.Start("http://www.spravkaweb.ru/")
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.OKOnly, "Произошла ошибка!")
        End Try
    End Sub

    Private Sub MenuItem55_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem55.Click
        Try
            System.Diagnostics.Process.Start("http://jquery.com/")
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.OKOnly, "Произошла ошибка!")
        End Try
    End Sub

    Private Sub MenuItem57_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem57.Click
        Try
            System.Diagnostics.Process.Start("http://wordpress.org/")
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.OKOnly, "Произошла ошибка!")
        End Try
    End Sub

    Private Sub MenuItem58_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem58.Click
        Try
            System.Diagnostics.Process.Start("http://ru.wordpress.org/")
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.OKOnly, "Произошла ошибка!")
        End Try
    End Sub

    Private Sub MenuItem60_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem60.Click
        Try
            System.Diagnostics.Process.Start("http://www.joomla.org/")
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.OKOnly, "Произошла ошибка!")
        End Try
    End Sub

    Private Sub MenuItem61_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem61.Click
        Try
            System.Diagnostics.Process.Start("http://joomlaportal.ru/")
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.OKOnly, "Произошла ошибка!")
        End Try
    End Sub

    Private Sub MenuItem63_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem63.Click
        Try
            System.Diagnostics.Process.Start("http://httpd.apache.org/")
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.OKOnly, "Произошла ошибка!")
        End Try
    End Sub

    Private Sub MenuItem64_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem64.Click
        Try
            System.Diagnostics.Process.Start("http://php.net")
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.OKOnly, "Произошла ошибка!")
        End Try
    End Sub

    Private Sub MenuItem65_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem65.Click
        Try
            System.Diagnostics.Process.Start("http://www.mysql.com/")
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.OKOnly, "Произошла ошибка!")
        End Try
    End Sub

    Private Sub MenuItem66_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem66.Click
        Try
            System.Diagnostics.Process.Start("http://www.denwer.ru/")
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.OKOnly, "Произошла ошибка!")
        End Try
    End Sub

    Private Sub MenuItem68_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem68.Click
        Try
            System.Diagnostics.Process.Start("http://jigsaw.w3.org/css-validator/")
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.OKOnly, "Произошла ошибка!")
        End Try
    End Sub

    Private Sub MenuItem69_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem69.Click
        Try
            System.Diagnostics.Process.Start("http://validator.w3.org")
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.OKOnly, "Произошла ошибка!")
        End Try
    End Sub

    Private Sub MenuItem71_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem71.Click
        Try
            System.Diagnostics.Process.Start("http://catfish.ltd.ua")
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.OKOnly, "Произошла ошибка!")
        End Try
    End Sub

    Private Sub MenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem5.Click
        Try
            If (ModulePE.AboutShow = False) Then
                Dim Ab As New About
                Ab.Show()
            End If
        Catch ex As Exception
            'MsgBox(ex.ToString, MsgBoxStyle.OKOnly, "Произошла ошибка!")
        End Try
    End Sub

    Private Sub ToolBar1_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles ToolBar1.ButtonClick
        Try
            Select Case ToolBar1.Buttons.IndexOf(e.Button)
                Case 0

                Case 1
                    Try
                        System.Diagnostics.Process.Start(ModulePE.DENWER_Path + "\denwer\Run.exe")
                    Catch ex As Exception
                        MsgBox(ex.ToString, MsgBoxStyle.OKOnly, "Произошла ошибка!")
                    End Try
                Case 2
                    Try
                        System.Diagnostics.Process.Start(ModulePE.DENWER_Path + "\denwer\Stop.exe")
                    Catch ex As Exception
                        MsgBox(ex.ToString, MsgBoxStyle.OKOnly, "Произошла ошибка!")
                    End Try
                Case 3
                    Try
                        System.Diagnostics.Process.Start(ModulePE.DENWER_Path + "\denwer\Restart.exe")
                    Catch ex As Exception
                        MsgBox(ex.ToString, MsgBoxStyle.OKOnly, "Произошла ошибка!")
                    End Try
                Case 4

                Case 5
                    'Сохранить активный файл
                    Try
                        For iFindFile As Integer = 0 To 100
                            If (ModulePE.BaseFile(iFindFile) = ModulePE.ProgrammPE.StatusBarPanel4.Text) Then
                                'Если кодировка ASCII
                                If (ModulePE.FileModule(iFindFile).StatusBarPanel1.Text = "ascii") Then
                                    ModulePE.FileModule(iFindFile).RichTextBox1.SaveFile(ModulePE.FileModule(iFindFile).MyPath, RichTextBoxStreamType.PlainText)
                                    ModulePE.FileModule(iFindFile).Icon = NotifyIcon1.Icon
                                    ModulePE.FileModule(iFindFile).StatusBarPanel1.Text = "ascii"
                                End If
                                'Если кодировка UTF-8
                                If (ModulePE.FileModule(iFindFile).StatusBarPanel1.Text = "utf-8") Then
                                    Dim writer As StreamWriter = New StreamWriter(ModulePE.FileModule(iFindFile).MyPath, False, Encoding.UTF8)
                                    writer.Write(ModulePE.FileModule(iFindFile).RichTextBox1.Text)
                                    writer.Close()
                                    ModulePE.FileModule(iFindFile).Icon = NotifyIcon1.Icon
                                    ModulePE.FileModule(iFindFile).StatusBarPanel1.Text = "utf-8"
                                End If
                                'Если кодировка UTF-8 Without BOM
                                If (ModulePE.FileModule(iFindFile).StatusBarPanel1.Text = "utf-8 wintout BOM") Then
                                    Dim utf8WithoutBom As New System.Text.UTF8Encoding(False)
                                    Dim writer As StreamWriter = New StreamWriter(ModulePE.FileModule(iFindFile).MyPath, False, utf8WithoutBom)
                                    writer.Write(ModulePE.FileModule(iFindFile).RichTextBox1.Text)
                                    writer.Close()
                                    ModulePE.FileModule(iFindFile).Icon = NotifyIcon1.Icon
                                    ModulePE.FileModule(iFindFile).StatusBarPanel1.Text = "utf-8 wintout BOM"
                                End If
                                Exit For
                            End If
                        Next
                    Catch ex As Exception

                    End Try
                Case 6
                    'Сохранить все открытые файлы
                    Try
                        For iLBSave As Integer = 0 To ListBox1.Items.Count - 1
                            For iFindFile As Integer = 1 To 100
                                If (ModulePE.BaseFile(iFindFile) = ListBox1.Items.Item(iLBSave)) Then
                                    'Если кодировка ASCII
                                    If (ModulePE.FileModule(iFindFile).StatusBarPanel1.Text = "ascii") Then
                                        ModulePE.FileModule(iFindFile).RichTextBox1.SaveFile(ModulePE.FileModule(iFindFile).MyPath, RichTextBoxStreamType.PlainText)
                                        ModulePE.FileModule(iFindFile).Icon = NotifyIcon1.Icon
                                        ModulePE.FileModule(iFindFile).StatusBarPanel1.Text = "ascii"
                                    End If
                                    'Если кодировка UTF-8
                                    If (ModulePE.FileModule(iFindFile).StatusBarPanel1.Text = "utf-8") Then
                                        Dim writer As StreamWriter = New StreamWriter(ModulePE.FileModule(iFindFile).MyPath, False, Encoding.UTF8)
                                        writer.Write(ModulePE.FileModule(iFindFile).RichTextBox1.Text)
                                        writer.Close()
                                        ModulePE.FileModule(iFindFile).Icon = NotifyIcon1.Icon
                                        ModulePE.FileModule(iFindFile).StatusBarPanel1.Text = "utf-8"
                                    End If
                                    'Если кодировка UTF-8 Without BOM
                                    If (ModulePE.FileModule(iFindFile).StatusBarPanel1.Text = "utf-8 wintout BOM") Then
                                        Dim utf8WithoutBom As New System.Text.UTF8Encoding(False)
                                        Dim writer As StreamWriter = New StreamWriter(ModulePE.FileModule(iFindFile).MyPath, False, utf8WithoutBom)
                                        writer.Write(ModulePE.FileModule(iFindFile).RichTextBox1.Text)
                                        writer.Close()
                                        ModulePE.FileModule(iFindFile).Icon = NotifyIcon1.Icon
                                        ModulePE.FileModule(iFindFile).StatusBarPanel1.Text = "utf-8 wintout BOM"
                                    End If
                                End If
                            Next
                        Next
                    Catch ex As Exception

                    End Try
                Case 7

                Case 8
                    'Создать файл UTF-8 WINTOUT BOM
                    If (SaveFileDialog1.ShowDialog = DialogResult.OK) Then
                        LoadFilesBase(SaveFileDialog1.FileName, "Создать UTF-8 WINTOUT BOM")
                    End If
                Case 9
                    'Открыть файл
                    If (OpenFileDialog1.ShowDialog = DialogResult.OK) Then

                        Dim strLine As New String(" ", 11)
                        FileOpen(1, OpenFileDialog1.FileName, OpenMode.Binary)
                        FileGet(1, strLine)
                        FileClose(1)

                        Dim buffer() As Byte
                        Dim options As IsTextUnicodeFlags
                        Dim result As Boolean
                        buffer = System.Text.Encoding.Unicode.GetBytes(strLine)
                        options = IsTextUnicodeFlags.UnicodeMask
                        result = IsTextUnicode(buffer, buffer.Length, options)

                        If (result = True) And (options = 2) Then
                            'Файл формата UTF8
                            LoadFilesBase(OpenFileDialog1.FileName, "Открыть UTF-8")
                        Else
                            If (result = True) And (options = 6) Then
                                'Файл формата ASCII или UTF8 without BOM
                                LoadFilesBase(OpenFileDialog1.FileName, "Открыть UTF-8 WINTOUT BOM")
                            Else
                                LoadFilesBase(OpenFileDialog1.FileName, "Открыть по умолчанию")
                            End If
                        End If

                    End If
                Case 10
                        If (ModulePE.FTPShow = False) Then
                            Dim FTP As New FTPClient
                            FTP.MdiParent = ModulePE.ProgrammPE.ActiveForm
                            FTP.Show()
                        End If
                Case 11
                Case 12
                        If (ModulePE.SettingsShow = False) Then
                            Dim SettingProg As New Settings
                            SettingProg.MdiParent = ModulePE.ProgrammPE.ActiveForm
                            SettingProg.Show()
                        End If
                Case 13
                        If (ModulePE.AboutShow = False) Then
                            Dim Ab As New About
                            Ab.MdiParent = ModulePE.ProgrammPE
                            Ab.Show()
                        End If
            End Select
        Catch ex As Exception
            'MsgBox(ex.ToString, MsgBoxStyle.OKOnly, "Произошла ошибка!")
        End Try
    End Sub

    Private Sub MenuItem97_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem97.Click
        For iFindFile As Integer = 0 To 100
            If (ModulePE.BaseFile(iFindFile) = ModulePE.ProgrammPE.StatusBarPanel4.Text) Then
                ModulePE.FileModule(iFindFile).RichTextBox1.Undo()
                Exit For
            End If
        Next
    End Sub

    Private Sub MenuItem99_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem99.Click
        For iFindFile As Integer = 0 To 100
            If (ModulePE.BaseFile(iFindFile) = ModulePE.ProgrammPE.StatusBarPanel4.Text) Then
                ModulePE.FileModule(iFindFile).RichTextBox1.Cut()
                Exit For
            End If
        Next
    End Sub

    Private Sub MenuItem100_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem100.Click
        For iFindFile As Integer = 0 To 100
            If (ModulePE.BaseFile(iFindFile) = ModulePE.ProgrammPE.StatusBarPanel4.Text) Then
                ModulePE.FileModule(iFindFile).RichTextBox1.Copy()
                Exit For
            End If
        Next
    End Sub

    Private Sub MenuItem101_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem101.Click
        For iFindFile As Integer = 0 To 100
            If (ModulePE.BaseFile(iFindFile) = ModulePE.ProgrammPE.StatusBarPanel4.Text) Then
                ModulePE.FileModule(iFindFile).RichTextBox1.Paste()
                ModulePE.FileModule(iFindFile).RichTextBox1.Font = ModulePE.FontModule
                ModulePE.FileModule(iFindFile).RichTextBox1.SelectionColor = Color.Black
                Exit For
            End If
        Next
    End Sub

    Private Sub MenuItem102_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem102.Click
        For iFindFile As Integer = 0 To 100
            If (ModulePE.BaseFile(iFindFile) = ModulePE.ProgrammPE.StatusBarPanel4.Text) Then
                Clipboard.SetDataObject("")
                ModulePE.FileModule(iFindFile).RichTextBox1.Paste()
                ModulePE.FileModule(iFindFile).RichTextBox1.Font = ModulePE.FontModule
                ModulePE.FileModule(iFindFile).RichTextBox1.SelectionColor = Color.Black
                Exit For
            End If
        Next
    End Sub

    Private Sub MenuItem103_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem103.Click
        For iFindFile As Integer = 0 To 100
            If (ModulePE.BaseFile(iFindFile) = ModulePE.ProgrammPE.StatusBarPanel4.Text) Then
                ModulePE.FileModule(iFindFile).RichTextBox1.Clear()
                Exit For
            End If
        Next
    End Sub

    Private Sub MenuItem104_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem104.Click
        For iFindFile As Integer = 0 To 100
            If (ModulePE.BaseFile(iFindFile) = ModulePE.ProgrammPE.StatusBarPanel4.Text) Then
                ModulePE.FileModule(iFindFile).RichTextBox1.SelectAll()
                Exit For
            End If
        Next
    End Sub

    Private Sub MenuItem106_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem106.Click
        MenuItem106.Checked = True
        MenuItem107.Checked = False
        MenuItem108.Checked = False
        TREE_UPDATE()
    End Sub

    Private Sub MenuItem107_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem107.Click
        MenuItem107.Checked = True
        MenuItem106.Checked = False
        MenuItem108.Checked = False
        TREE_UPDATE()
    End Sub

    Private Sub MenuItem108_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem108.Click
        MenuItem108.Checked = True
        MenuItem107.Checked = False
        MenuItem106.Checked = False
        TREE_UPDATE()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            OleDbConnection1.ConnectionString = ModuleBase.StringConnection
            OleDbConnection1.Open()

            DataSet131.Clear()


            Dim CommandSQL As String

            CommandSQL = "SELECT ДатаПоследнегоСохранения, ПапкаИдентификатор, СодержаниеФайла, Строка, ТипОбъекта, ФайлВПапке, ФайлИдентификатор FROM Хранилище WHERE ФайлИдентификатор LIKE '%" + TextBox1.Text + "%' ORDER BY ФайлИдентификатор ASC"

            OleDbDataAdapter1.SelectCommand.CommandText = CommandSQL
            OleDbDataAdapter1.Fill(DataSet131, "Хранилище")


            'загрузка дерева
            Dim NameGr As String
            TreeView2.Nodes.Clear()
            For i As Integer = 0 To DataSet131.Хранилище.Rows.Count - 1
                If (DataSet131.Хранилище.Item(i)("ТипОбъекта") = "Элемент") Then
                    NameGr = DataSet131.Хранилище.Item(i)("ФайлИдентификатор")
                    TreeView2.Nodes.Add(NameGr)
                    TreeView2.Nodes.Item(i).ImageIndex = 2
                    TreeView2.Nodes.Item(i).SelectedImageIndex = 2
                End If
            Next
            OleDbConnection1.Close()
            TreeView1.Select()
        Catch ex As Exception
            'MsgBox(ex.ToString, MsgBoxStyle.OKOnly, "Произошла ошибка!")
        End Try
    End Sub

    Private Sub TreeView2_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TreeView2.AfterSelect
        Try
            StatusBarPanel2.Text = TreeView2.SelectedNode.Text
            For i As Integer = 0 To DataSet41.Хранилище.Count - 1
                If (DataSet41.Хранилище.Item(i)("ТипОбъекта") = "Группа") Then
                    If (DataSet41.Хранилище.Item(i)("ПапкаИдентификатор") = StatusBarPanel2.Text) Then
                        RichTextBox1.Text = "Описание:"
                        Exit For
                    End If
                End If
                If (DataSet41.Хранилище.Item(i)("ТипОбъекта") = "Элемент") Then
                    If (DataSet41.Хранилище.Item(i)("ФайлИдентификатор") = StatusBarPanel2.Text) Then
                        RichTextBox1.Text = DataSet41.Хранилище.Item(i)("СодержаниеФайла")
                        Exit For
                    End If
                End If
            Next
        Catch ex As Exception
            'MsgBox(ex.ToString, MsgBoxStyle.OKOnly, "Произошла ошибка!")
        End Try
    End Sub

    Private Sub MenuItem109_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem109.Click
        'Вставить
        For iFindFile As Integer = 0 To 100
            If (ModulePE.BaseFile(iFindFile) = ModulePE.ProgrammPE.StatusBarPanel4.Text) Then
                ModulePE.FileModule(iFindFile).FormatText(ModulePE.ProgrammPE.StatusBarPanel2.Text)
                Exit For
            End If
        Next
    End Sub

    Private Sub MenuItem111_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem111.Click
        'Редактировать запись запись
        Dim EditLive As New NewEditForm
        Dim PoliticFolder As Boolean = False
        EditLive.MdiParent = ModulePE.ProgrammPE.ActiveForm

        For i As Integer = 0 To DataSet41.Хранилище.Rows.Count - 1
            If (DataSet41.Хранилище.Item(i)("ТипОбъекта") = "Группа") Then
                If (DataSet41.Хранилище.Item(i)("ПапкаИдентификатор") = StatusBarPanel2.Text) Then
                    PoliticFolder = True 'Значит выбрана группа
                    Exit For
                End If
            End If
        Next
        If (PoliticFolder = False) Then
            EditLive.ActionFiles = StatusBarPanel2.Text
            EditLive.Text = StatusBarPanel2.Text
            EditLive.Show()
        End If
    End Sub

    Private Sub MenuItem110_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem110.Click
        'Открыть файл UTF-8 without BOM
        If (OpenFileDialog1.ShowDialog = DialogResult.OK) Then
            LoadFilesBase(OpenFileDialog1.FileName, "Открыть UTF-8 WINTOUT BOM")
        End If
    End Sub

    Private Sub MenuItem112_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem112.Click
        'Сохранить активный файл как (UFT-8 without BOM)
        Try
            If (SaveFileDialog1.ShowDialog = DialogResult.OK) Then
                For iFindFile As Integer = 0 To 100
                    If (ModulePE.BaseFile(iFindFile) = ModulePE.ProgrammPE.StatusBarPanel4.Text) Then

                        Dim FileNameCreate As String
                        Dim FileNameAndPath As String = SaveFileDialog1.FileName
                        Dim iIndex, iStartDel, iEndDel As Integer
                        iIndex = FileNameAndPath.Length - 1
                        For iFN As Integer = 0 To FileNameAndPath.Length - 1
                            If (FileNameAndPath.Chars(iIndex) = "\") Then
                                iStartDel = 0
                                iEndDel = FileNameAndPath.Length - iFN
                                FileNameCreate = FileNameAndPath.Remove(iStartDel, iEndDel)
                                Exit For
                            Else
                                iIndex = iIndex - 1
                            End If
                        Next
                        ModulePE.BaseFile(iFindFile) = FileNameCreate + " [" + iFindFile.ToString + "]"
                        ModulePE.FileModule(iFindFile).MyFileName = FileNameCreate
                        ModulePE.FileModule(iFindFile).MyPath = FileNameAndPath
                        ModulePE.FileModule(iFindFile).Text = FileNameCreate
                        ModulePE.FileModule(iFindFile).Label1.Text = TestFile(FileNameCreate)
                        ModulePE.FileModule(iFindFile).StatusBarPanel3.Text = FileNameAndPath

                        Dim utf8WithoutBom As New System.Text.UTF8Encoding(False)
                        Dim writer As StreamWriter = New StreamWriter(ModulePE.FileModule(iFindFile).MyPath, False, utf8WithoutBom)
                        writer.Write(ModulePE.FileModule(iFindFile).RichTextBox1.Text)
                        writer.Close()

                        ModulePE.FileModule(iFindFile).Icon = NotifyIcon1.Icon
                        ModulePE.FileModule(iFindFile).StatusBarPanel1.Text = "utf-8 wintout BOM"
                        ReloadLB()
                        Exit For
                    End If
                Next
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub TreeView2_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles TreeView2.DoubleClick
        'Редактировать запись запись
        Dim EditLive As New NewEditForm
        Dim PoliticFolder As Boolean = False
        EditLive.MdiParent = ModulePE.ProgrammPE.ActiveForm

        For i As Integer = 0 To DataSet41.Хранилище.Rows.Count - 1
            If (DataSet41.Хранилище.Item(i)("ТипОбъекта") = "Группа") Then
                If (DataSet41.Хранилище.Item(i)("ПапкаИдентификатор") = StatusBarPanel2.Text) Then
                    PoliticFolder = True 'Значит выбрана группа
                    Exit For
                End If
            End If
        Next
        If (PoliticFolder = False) Then
            EditLive.ActionFiles = StatusBarPanel2.Text
            EditLive.Text = StatusBarPanel2.Text
            EditLive.Show()
        End If
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If (e.KeyChar.GetHashCode = 851981) Then
            Try
                OleDbConnection1.ConnectionString = ModuleBase.StringConnection
                OleDbConnection1.Open()

                DataSet131.Clear()


                Dim CommandSQL As String

                CommandSQL = "SELECT ДатаПоследнегоСохранения, ПапкаИдентификатор, СодержаниеФайла, Строка, ТипОбъекта, ФайлВПапке, ФайлИдентификатор FROM Хранилище WHERE ФайлИдентификатор LIKE '%" + TextBox1.Text + "%' ORDER BY ФайлИдентификатор ASC"

                OleDbDataAdapter1.SelectCommand.CommandText = CommandSQL
                OleDbDataAdapter1.Fill(DataSet131, "Хранилище")


                'загрузка дерева
                Dim NameGr As String
                TreeView2.Nodes.Clear()
                For i As Integer = 0 To DataSet131.Хранилище.Rows.Count - 1
                    If (DataSet131.Хранилище.Item(i)("ТипОбъекта") = "Элемент") Then
                        NameGr = DataSet131.Хранилище.Item(i)("ФайлИдентификатор")
                        TreeView2.Nodes.Add(NameGr)
                        TreeView2.Nodes.Item(i).ImageIndex = 2
                        TreeView2.Nodes.Item(i).SelectedImageIndex = 2
                    End If
                Next
                OleDbConnection1.Close()
                TreeView1.Select()
            Catch ex As Exception
                'MsgBox(ex.ToString, MsgBoxStyle.OKOnly, "Произошла ошибка!")
            End Try
        End If
    End Sub

    Private Sub MenuItem113_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem113.Click
        'Создать пустой документ
        Try
            For iSerchFreeFile As Integer = 1 To 100
                If (ModulePE.BaseFile(iSerchFreeFile) = "") Then
                    ModulePE.LoadFM(iSerchFreeFile)
                    ModulePE.FileModule(iSerchFreeFile).MdiParent = ModulePE.ProgrammPE.ActiveForm
                    'ModulePE.FileModule(iSerchFreeFile).MyFileName = FileNameCreate
                    'ModulePE.FileModule(iSerchFreeFile).MyPath = FileNameAndPath
                    ModulePE.FileModule(iSerchFreeFile).MyID = iSerchFreeFile
                    'ModulePE.FileModule(iSerchFreeFile).OpenOrCreate = OpenOrCreate
                    'ModulePE.FileModule(iSerchFreeFile).Text = FileNameCreate
                    ModulePE.FileModule(iSerchFreeFile).Label1.Text = "" 'TestFile(FileNameCreate)
                    'ModulePE.FileModule(iSerchFreeFile).StatusBarPanel3.Text = FileNameAndPath
                    
                    ModulePE.FileModule(iSerchFreeFile).Show()
                    ListBox1.Items.Add("[" + iSerchFreeFile.ToString + "]")
                    ModulePE.BaseFile(iSerchFreeFile) = "[" + iSerchFreeFile.ToString + "]"
                    Exit For
                End If
            Next
        Catch ex As Exception

        End Try
    End Sub

    Private Sub MenuItem114_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem114.Click
        Try
            System.Diagnostics.Process.Start("http://mywordpress.ru/")
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.OKOnly, "Произошла ошибка!")
        End Try
    End Sub


    Public Enum IsTextUnicodeFlags As Integer
        Ascii16 = &H1
        ReverseAscii16 = &H10

        Statistics = &H2
        ReverseStatistics = &H20

        Controls = &H4
        ReverseControls = &H40

        Signature = &H8
        ReverseSignature = &H80

        IllegalChars = &H100
        OddLength = &H200
        DbcsLeadbyte = &H400

        NullBytes = &H1000

        UnicodeMask = &HF
        ReverseMask = &HF0
        NotUnicodeMask = &HF00
        NotAsciiMask = &HF000

    End Enum
    Declare Auto Function IsTextUnicode Lib "Advapi32" (ByVal buffer() As Byte, ByVal length As Integer, ByRef options As IsTextUnicodeFlags) As Boolean

    Private Sub MenuItem115_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem115.Click
        'Открыть файл
        If (OpenFileDialog1.ShowDialog = DialogResult.OK) Then

            Dim strLine As New String(" ", 11)
            FileOpen(1, OpenFileDialog1.FileName, OpenMode.Binary)
            FileGet(1, strLine)
            FileClose(1)

            Dim buffer() As Byte
            Dim options As IsTextUnicodeFlags
            Dim result As Boolean
            buffer = System.Text.Encoding.Unicode.GetBytes(strLine)
            options = IsTextUnicodeFlags.UnicodeMask
            result = IsTextUnicode(buffer, buffer.Length, options)

            If (result = True) And (options = 2) Then
                'Файл формата UTF8
                LoadFilesBase(OpenFileDialog1.FileName, "Открыть UTF-8")
            Else
                If (result = True) And (options = 6) Then
                    'Файл формата ASCII или UTF8 without BOM
                    LoadFilesBase(OpenFileDialog1.FileName, "Открыть UTF-8 WINTOUT BOM")
                Else
                    LoadFilesBase(OpenFileDialog1.FileName, "Открыть по умолчанию")
                End If
            End If

        End If
    End Sub
End Class
