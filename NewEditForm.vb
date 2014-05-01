Public Class NewEditForm
    Inherits System.Windows.Forms.Form

#Region " ���, ������������� ��������� ������������� ���� Windows "

    Public Sub New()
        MyBase.New()

        '���� ����� ��������� ������������� ���� Windows.
        InitializeComponent()

        '�������� ��� ������������� ����� ������ InitializeComponent()

    End Sub

    '����� �������������� ����� Dispose ��� ������� ������ �����������.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    '��������� ������������� ���� Windows
    Private components As System.ComponentModel.IContainer

    '����������: ��������� ��������� ��������� ��� ������������ ���� Windows.
    '�� ����� �������� � ������������ ���� Windows.  
    '�� ��������� �� � ��������� ��������� ������.
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents OleDbSelectCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbInsertCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbUpdateCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbDeleteCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbConnection1 As System.Data.OleDb.OleDbConnection
    Friend WithEvents OleDbDataAdapter1 As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents DataSet61 As PageEditor.DataSet6
    Friend WithEvents DataSet71 As PageEditor.DataSet7
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents ContextMenu1 As System.Windows.Forms.ContextMenu
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem4 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem5 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem6 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem7 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem8 As System.Windows.Forms.MenuItem
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(NewEditForm))
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.Label16 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox
        Me.ContextMenu1 = New System.Windows.Forms.ContextMenu
        Me.MenuItem1 = New System.Windows.Forms.MenuItem
        Me.MenuItem2 = New System.Windows.Forms.MenuItem
        Me.MenuItem3 = New System.Windows.Forms.MenuItem
        Me.MenuItem4 = New System.Windows.Forms.MenuItem
        Me.MenuItem5 = New System.Windows.Forms.MenuItem
        Me.MenuItem6 = New System.Windows.Forms.MenuItem
        Me.MenuItem7 = New System.Windows.Forms.MenuItem
        Me.MenuItem8 = New System.Windows.Forms.MenuItem
        Me.OleDbSelectCommand1 = New System.Data.OleDb.OleDbCommand
        Me.OleDbConnection1 = New System.Data.OleDb.OleDbConnection
        Me.OleDbInsertCommand1 = New System.Data.OleDb.OleDbCommand
        Me.OleDbUpdateCommand1 = New System.Data.OleDb.OleDbCommand
        Me.OleDbDeleteCommand1 = New System.Data.OleDb.OleDbCommand
        Me.OleDbDataAdapter1 = New System.Data.OleDb.OleDbDataAdapter
        Me.DataSet61 = New PageEditor.DataSet6
        Me.DataSet71 = New PageEditor.DataSet7
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataSet61, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet71, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ComboBox1
        '
        Me.ComboBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBox1.Location = New System.Drawing.Point(120, 72)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(336, 21)
        Me.ComboBox1.TabIndex = 7
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.Location = New System.Drawing.Point(80, 48)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(376, 20)
        Me.TextBox1.TabIndex = 6
        Me.TextBox1.Text = ""
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(8, 80)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(128, 23)
        Me.Label11.TabIndex = 5
        Me.Label11.Text = "������������ �����:"
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(8, 56)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(100, 16)
        Me.Label10.TabIndex = 4
        Me.Label10.Text = "��� ������:"
        '
        'Label14
        '
        Me.Label14.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label14.Image = CType(resources.GetObject("Label14.Image"), System.Drawing.Image)
        Me.Label14.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label14.Location = New System.Drawing.Point(8, 8)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(113, 24)
        Me.Label14.TabIndex = 16
        Me.Label14.Text = "������� ����."
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label13
        '
        Me.Label13.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label13.Image = CType(resources.GetObject("Label13.Image"), System.Drawing.Image)
        Me.Label13.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label13.Location = New System.Drawing.Point(152, 8)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(126, 24)
        Me.Label13.TabIndex = 15
        Me.Label13.Text = "��������� � ����."
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label12
        '
        Me.Label12.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label12.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label12.Image = CType(resources.GetObject("Label12.Image"), System.Drawing.Image)
        Me.Label12.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label12.Location = New System.Drawing.Point(264, 296)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(120, 24)
        Me.Label12.TabIndex = 14
        Me.Label12.Text = "��������� � ����."
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label1.Location = New System.Drawing.Point(392, 296)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 24)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "������."
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label15
        '
        Me.Label15.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label15.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label15.Image = CType(resources.GetObject("Label15.Image"), System.Drawing.Image)
        Me.Label15.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label15.Location = New System.Drawing.Point(392, 104)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(64, 24)
        Me.Label15.TabIndex = 19
        Me.Label15.Text = "�����."
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TextBox2
        '
        Me.TextBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox2.Location = New System.Drawing.Point(8, 104)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(376, 20)
        Me.TextBox2.TabIndex = 18
        Me.TextBox2.Text = ""
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Panel5)
        Me.Panel1.Controls.Add(Me.Label16)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(464, 43)
        Me.Panel1.TabIndex = 20
        '
        'Panel5
        '
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Location = New System.Drawing.Point(136, 8)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1, 24)
        Me.Panel5.TabIndex = 7
        '
        'Label16
        '
        Me.Label16.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.White
        Me.Label16.Image = CType(resources.GetObject("Label16.Image"), System.Drawing.Image)
        Me.Label16.Location = New System.Drawing.Point(280, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(184, 48)
        Me.Label16.TabIndex = 0
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.RichTextBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 128)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(448, 160)
        Me.GroupBox1.TabIndex = 21
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "����������:"
        '
        'RichTextBox1
        '
        Me.RichTextBox1.AcceptsTab = True
        Me.RichTextBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RichTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox1.ContextMenu = Me.ContextMenu1
        Me.RichTextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.RichTextBox1.Location = New System.Drawing.Point(5, 16)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth
        Me.RichTextBox1.Size = New System.Drawing.Size(440, 140)
        Me.RichTextBox1.TabIndex = 0
        Me.RichTextBox1.Text = ""
        Me.RichTextBox1.WordWrap = False
        '
        'ContextMenu1
        '
        Me.ContextMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem1, Me.MenuItem2, Me.MenuItem3, Me.MenuItem4, Me.MenuItem5, Me.MenuItem6, Me.MenuItem7, Me.MenuItem8})
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 0
        Me.MenuItem1.Text = "��������     Ctrl+Z"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 1
        Me.MenuItem2.Text = "-"
        '
        'MenuItem3
        '
        Me.MenuItem3.Index = 2
        Me.MenuItem3.Text = "��������     Ctrl+X"
        '
        'MenuItem4
        '
        Me.MenuItem4.Index = 3
        Me.MenuItem4.Text = "���������� Ctrl+C"
        '
        'MenuItem5
        '
        Me.MenuItem5.Index = 4
        Me.MenuItem5.Text = "��������      Ctrl+V"
        '
        'MenuItem6
        '
        Me.MenuItem6.Index = 5
        Me.MenuItem6.Text = "�������       Del"
        '
        'MenuItem7
        '
        Me.MenuItem7.Index = 6
        Me.MenuItem7.Text = "��������."
        '
        'MenuItem8
        '
        Me.MenuItem8.Index = 7
        Me.MenuItem8.Text = "�������� ��"
        '
        'OleDbSelectCommand1
        '
        Me.OleDbSelectCommand1.CommandText = "SELECT ������������������������, ������������������, ���������������, ������, ���" & _
        "�������, ����������, ����������������� FROM ���������"
        Me.OleDbSelectCommand1.Connection = Me.OleDbConnection1
        '
        'OleDbConnection1
        '
        Me.OleDbConnection1.ConnectionString = "Jet OLEDB:Global Partial Bulk Ops=2;Jet OLEDB:Registry Path=;Jet OLEDB:Database L" & _
        "ocking Mode=1;Data Source=""C:\����������������\VB NET\CATFISH\���������\PageEdit" & _
        "or\���� ������\resource.mdb"";Jet OLEDB:Engine Type=5;Provider=""Microsoft.Jet.OLE" & _
        "DB.4.0"";Jet OLEDB:System database=;Jet OLEDB:SFP=False;persist security info=Fal" & _
        "se;Extended Properties=;Mode=ReadWrite;Jet OLEDB:Encrypt Database=False;Jet OLED" & _
        "B:Create System Database=False;Jet OLEDB:Don't Copy Locale on Compact=False;Jet " & _
        "OLEDB:Compact Without Replica Repair=False;User ID=Admin;Jet OLEDB:Global Bulk T" & _
        "ransactions=1"
        '
        'OleDbInsertCommand1
        '
        Me.OleDbInsertCommand1.CommandText = "INSERT INTO ���������(������������������������, ������������������, �������������" & _
        "��, ����������, ����������, �����������������) VALUES (?, ?, ?, ?, ?, ?)"
        Me.OleDbInsertCommand1.Connection = Me.OleDbConnection1
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("������������������������", System.Data.OleDb.OleDbType.DBDate, 0, "������������������������"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("������������������", System.Data.OleDb.OleDbType.VarWChar, 255, "������������������"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("���������������", System.Data.OleDb.OleDbType.VarWChar, 0, "���������������"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("����������", System.Data.OleDb.OleDbType.VarWChar, 255, "����������"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("����������", System.Data.OleDb.OleDbType.VarWChar, 255, "����������"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("�����������������", System.Data.OleDb.OleDbType.VarWChar, 255, "�����������������"))
        '
        'OleDbUpdateCommand1
        '
        Me.OleDbUpdateCommand1.CommandText = "UPDATE ��������� SET ������������������������ = ?, ������������������ = ?, ������" & _
        "��������� = ?, ���������� = ?, ���������� = ?, ����������������� = ? WHERE (����" & _
        "�� = ?) AND (������������������������ = ? OR ? IS NULL AND ���������������������" & _
        "��� IS NULL) AND (������������������ = ? OR ? IS NULL AND ������������������ IS " & _
        "NULL) AND (���������� = ? OR ? IS NULL AND ���������� IS NULL) AND (���������� =" & _
        " ? OR ? IS NULL AND ���������� IS NULL) AND (����������������� = ? OR ? IS NULL " & _
        "AND ����������������� IS NULL)"
        Me.OleDbUpdateCommand1.Connection = Me.OleDbConnection1
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("������������������������", System.Data.OleDb.OleDbType.DBDate, 0, "������������������������"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("������������������", System.Data.OleDb.OleDbType.VarWChar, 255, "������������������"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("���������������", System.Data.OleDb.OleDbType.VarWChar, 0, "���������������"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("����������", System.Data.OleDb.OleDbType.VarWChar, 255, "����������"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("����������", System.Data.OleDb.OleDbType.VarWChar, 255, "����������"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("�����������������", System.Data.OleDb.OleDbType.VarWChar, 255, "�����������������"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_������", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "������", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_������������������������", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "������������������������", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_������������������������1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "������������������������", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_������������������", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "������������������", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_������������������1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "������������������", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_����������", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "����������", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_����������1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "����������", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_����������", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "����������", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_����������1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "����������", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_�����������������", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "�����������������", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_�����������������1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "�����������������", System.Data.DataRowVersion.Original, Nothing))
        '
        'OleDbDeleteCommand1
        '
        Me.OleDbDeleteCommand1.CommandText = "DELETE FROM ��������� WHERE (������ = ?) AND (������������������������ = ? OR ? I" & _
        "S NULL AND ������������������������ IS NULL) AND (������������������ = ? OR ? IS" & _
        " NULL AND ������������������ IS NULL) AND (���������� = ? OR ? IS NULL AND �����" & _
        "����� IS NULL) AND (���������� = ? OR ? IS NULL AND ���������� IS NULL) AND (���" & _
        "�������������� = ? OR ? IS NULL AND ����������������� IS NULL)"
        Me.OleDbDeleteCommand1.Connection = Me.OleDbConnection1
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_������", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "������", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_������������������������", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "������������������������", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_������������������������1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "������������������������", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_������������������", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "������������������", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_������������������1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "������������������", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_����������", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "����������", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_����������1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "����������", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_����������", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "����������", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_����������1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "����������", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_�����������������", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "�����������������", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_�����������������1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "�����������������", System.Data.DataRowVersion.Original, Nothing))
        '
        'OleDbDataAdapter1
        '
        Me.OleDbDataAdapter1.DeleteCommand = Me.OleDbDeleteCommand1
        Me.OleDbDataAdapter1.InsertCommand = Me.OleDbInsertCommand1
        Me.OleDbDataAdapter1.SelectCommand = Me.OleDbSelectCommand1
        Me.OleDbDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "���������", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("������������������������", "������������������������"), New System.Data.Common.DataColumnMapping("������������������", "������������������"), New System.Data.Common.DataColumnMapping("���������������", "���������������"), New System.Data.Common.DataColumnMapping("������", "������"), New System.Data.Common.DataColumnMapping("����������", "����������"), New System.Data.Common.DataColumnMapping("����������", "����������"), New System.Data.Common.DataColumnMapping("�����������������", "�����������������")})})
        Me.OleDbDataAdapter1.UpdateCommand = Me.OleDbUpdateCommand1
        '
        'DataSet61
        '
        Me.DataSet61.DataSetName = "DataSet6"
        Me.DataSet61.Locale = New System.Globalization.CultureInfo("ru-RU")
        '
        'DataSet71
        '
        Me.DataSet71.DataSetName = "DataSet7"
        Me.DataSet71.Locale = New System.Globalization.CultureInfo("ru-RU")
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.Filter = "*.txt|*.txt|*.*|*.*"
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.Filter = "*.txt|*.txt|*.*|*.*"
        '
        'NewEditForm
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(464, 326)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "NewEditForm"
        Me.Text = "..."
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DataSet61, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet71, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public ActionFolder As String
    Public ActionFiles As String
    Dim ActionID As Integer
    Private Sub NewEditForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        OleDbConnection1.ConnectionString = ModuleBase.StringConnection
        OleDbConnection1.Open()

        If (Me.Text = "����� ������") Then
            ComboBox1.Text = ""
            ComboBox1.Items.Clear()
            RichTextBox1.Clear()
            OleDbDataAdapter1.Fill(DataSet61, "���������")
            For i As Integer = 0 To DataSet61.���������.Rows.Count - 1
                If (DataSet61.���������.Item(i)("����������") = "������") Then
                    ComboBox1.Items.Add(DataSet61.���������.Item(i)("������������������"))
                End If
            Next
            ComboBox1.Text = ActionFolder
        Else '������������� ������
            ComboBox1.Text = ""
            ComboBox1.Items.Clear()
            RichTextBox1.Clear()
            OleDbDataAdapter1.Fill(DataSet61, "���������")
            For i As Integer = 0 To DataSet61.���������.Rows.Count - 1
                If (DataSet61.���������.Item(i)("����������") = "������") Then
                    ComboBox1.Items.Add(DataSet61.���������.Item(i)("������������������"))
                End If
            Next
            Dim SQLComand As String
            SQLComand = "SELECT ������������������������, ������������������, ���������������, ������, ����������, ����������, ����������������� FROM ��������� WHERE (����������������� = '" + ActionFiles + "')"
            OleDbDataAdapter1.SelectCommand.CommandText = SQLComand
            OleDbDataAdapter1.Fill(DataSet71, "���������")
            TextBox1.Text = DataSet71.���������.Item(0)("�����������������")
            ComboBox1.Text = DataSet71.���������.Item(0)("����������")
            RichTextBox1.Text = DataSet71.���������.Item(0)("���������������")
            ActionID = DataSet71.���������.Item(0)("������")
        End If
        OleDbConnection1.Close()
        RichTextBox1.Font = ModulePE.FontModule
    End Sub

    Private Sub Label14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label14.Click
        '������� ����
        If (OpenFileDialog1.ShowDialog = DialogResult.OK) Then
            RichTextBox1.LoadFile(OpenFileDialog1.FileName, RichTextBoxStreamType.PlainText)
        End If
    End Sub

    Private Sub Label14_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label14.MouseMove
        Try
            Label14.BorderStyle = BorderStyle.FixedSingle
            Label13.BorderStyle = BorderStyle.None
            Label12.BorderStyle = BorderStyle.None
            Label15.BorderStyle = BorderStyle.None
            Label1.BorderStyle = BorderStyle.None
        Catch ex As Exception
            'MsgBox(ex.ToString, MsgBoxStyle.OKOnly, "��������� ������!")
        End Try
    End Sub

    Private Sub Label14_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label14.MouseLeave
        Try
            Label15.BorderStyle = BorderStyle.None
            Label14.BorderStyle = BorderStyle.None
            Label13.BorderStyle = BorderStyle.None
            Label12.BorderStyle = BorderStyle.None
            Label1.BorderStyle = BorderStyle.None
        Catch ex As Exception
            'MsgBox(ex.ToString, MsgBoxStyle.OKOnly, "��������� ������!")
        End Try
    End Sub

    Private Sub Label13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label13.Click
        '���������
        If (SaveFileDialog1.ShowDialog = DialogResult.OK) Then
            RichTextBox1.SaveFile(SaveFileDialog1.FileName, RichTextBoxStreamType.PlainText)
        End If
    End Sub

    Private Sub Label13_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label13.MouseMove
        Try
            Label13.BorderStyle = BorderStyle.FixedSingle
            Label14.BorderStyle = BorderStyle.None
            Label12.BorderStyle = BorderStyle.None
            Label15.BorderStyle = BorderStyle.None
            Label1.BorderStyle = BorderStyle.None
        Catch ex As Exception
            'MsgBox(ex.ToString, MsgBoxStyle.OKOnly, "��������� ������!")
        End Try
    End Sub

    Private Sub Label13_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label13.MouseLeave
        Try
            Label15.BorderStyle = BorderStyle.None
            Label14.BorderStyle = BorderStyle.None
            Label13.BorderStyle = BorderStyle.None
            Label12.BorderStyle = BorderStyle.None
            Label1.BorderStyle = BorderStyle.None
        Catch ex As Exception
            'MsgBox(ex.ToString, MsgBoxStyle.OKOnly, "��������� ������!")
        End Try
    End Sub

    Private Sub Label12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label12.Click
        '���������
        If (Me.Text = "����� ������") Then
            Dim NameModul As String
            Dim ModulePolitic As Boolean = True
            If (TextBox1.Text = "") Then
                NameModul = InputBox("������� ��� ������.", "����� ������:", "")
            Else
                NameModul = TextBox1.Text
            End If
            If (NameModul <> "") Then
                For iFindFile As Integer = 0 To DataSet61.���������.Count - 1
                    If (DataSet61.���������.Item(iFindFile)("����������") = "�������") Then
                        If (DataSet61.���������.Item(iFindFile)("�����������������") = NameModul) Then
                            ModulePolitic = False
                            MsgBox("������: ������ � ����� ������ ��� ����������!!!.", MsgBoxStyle.OKOnly, "���������:")
                            Label12.BorderStyle = BorderStyle.None
                        End If
                    End If
                Next
            Else
                ModulePolitic = False
                Label12.BorderStyle = BorderStyle.None
            End If
            '��������� ������
            If (ModulePolitic = True) Then
                OleDbConnection1.Open()
                Dim DT As DataTable = DataSet61.���������
                Dim row As DataRow
                row = DT.NewRow
                row("����������") = "�������"
                If (ComboBox1.Text <> "") Then
                    row("����������") = ComboBox1.Text
                Else
                    MsgBox("�� �� ������� ����� � ������� ����� ��������� ����.", MsgBoxStyle.OKOnly, "���������:")
                    Exit Sub
                End If
                row("�����������������") = NameModul
                row("���������������") = RichTextBox1.Text
                row("������������������������") = Date.Today.ToString
                DT.Rows.Add(row)
                OleDbDataAdapter1.Update(DataSet61, "���������")
                OleDbConnection1.Close()
                ModulePE.ProgrammPE.TREE_UPDATE()
                MsgBox("���������� ������ �������.", MsgBoxStyle.OKOnly, "���������:")
                Close()
            End If
        Else '���������� ����ͨ���� ������
            Dim FolderFind As Boolean = False
            Dim NameModul As String
            Dim ModulePolitic As Boolean = True
            For iFolder As Integer = 0 To ComboBox1.Items.Count - 1
                If (ComboBox1.Text = ComboBox1.Items.Item(iFolder)) Then FolderFind = True
            Next
            If (FolderFind = True) Then
                If (TextBox1.Text = "") Then
                    NameModul = InputBox("������� ��� ������.", "����� ��� ������:", "")
                Else
                    NameModul = TextBox1.Text
                End If
                If (NameModul <> "") Then '�������� ������������ ����� ������
                    For i As Integer = 0 To DataSet61.���������.Count - 1
                        If (DataSet61.���������.Item(i)("����������") = "�������") Then
                            If (DataSet61.���������.Item(i)("�����������������") = NameModul) And (DataSet61.���������.Item(i)("������") <> ActionID) Then
                                ModulePolitic = False
                                MsgBox("������: ������ � ����� ������ ��� ����������!!!.", MsgBoxStyle.OKOnly, "���������:")
                                Label12.BorderStyle = BorderStyle.None
                            End If
                        End If
                    Next
                Else
                    ModulePolitic = False
                    Label12.BorderStyle = BorderStyle.None
                End If
                '��������� ������
                If (ModulePolitic = True) Then
                    OleDbConnection1.Open()

                    DataSet71.���������.Item(0)("���������������") = RichTextBox1.Text
                    DataSet71.���������.Item(0)("�����������������") = NameModul
                    If (ComboBox1.Text <> "") Then
                        DataSet71.���������.Item(0)("����������") = ComboBox1.Text
                    Else
                        MsgBox("�� �� ������� ����� � ������� ����� ��������� ������.", MsgBoxStyle.OKOnly, "���������:")
                        Exit Sub
                    End If
                    DataSet71.���������.Item(0)("������������������������") = Date.Today.ToString

                    OleDbDataAdapter1.Update(DataSet71, "���������")
                    OleDbConnection1.Close()
                    ModulePE.ProgrammPE.TREE_UPDATE()
                    MsgBox("���������� ������ �������.", MsgBoxStyle.OKOnly, "���������:")
                End If
            End If
        End If
    End Sub

    Private Sub Label12_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label12.MouseMove
        Try
            Label12.BorderStyle = BorderStyle.FixedSingle
            Label14.BorderStyle = BorderStyle.None
            Label13.BorderStyle = BorderStyle.None
            Label15.BorderStyle = BorderStyle.None
            Label1.BorderStyle = BorderStyle.None
        Catch ex As Exception
            'MsgBox(ex.ToString, MsgBoxStyle.OKOnly, "��������� ������!")
        End Try
    End Sub

    Private Sub Label12_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label12.MouseLeave
        Try
            Label15.BorderStyle = BorderStyle.None
            Label14.BorderStyle = BorderStyle.None
            Label13.BorderStyle = BorderStyle.None
            Label12.BorderStyle = BorderStyle.None
            Label1.BorderStyle = BorderStyle.None
        Catch ex As Exception
            'MsgBox(ex.ToString, MsgBoxStyle.OKOnly, "��������� ������!")
        End Try
    End Sub

    Private Sub NewEditForm_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseMove
        Try
            Label15.BorderStyle = BorderStyle.None
            Label14.BorderStyle = BorderStyle.None
            Label13.BorderStyle = BorderStyle.None
            Label12.BorderStyle = BorderStyle.None
            Label1.BorderStyle = BorderStyle.None
        Catch ex As Exception
            'MsgBox(ex.ToString, MsgBoxStyle.OKOnly, "��������� ������!")
        End Try
    End Sub

    Dim FindIndex As Integer = 0
    Dim FindText As String
    Dim FindLast As Integer = 0
    Private Sub Label15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label15.Click
        '�����
        Try
            If (FindText <> TextBox2.Text) Then
                FindIndex = 0
                FindLast = 0
                FindText = TextBox2.Text
            End If
            If (RichTextBox1.Find(TextBox2.Text, FindIndex, RichTextBox1.TextLength - 1, RichTextBoxFinds.None)) Then
                RichTextBox1.Select()
                FindIndex = RichTextBox1.SelectionStart + RichTextBox1.SelectionLength
                If (FindLast = RichTextBox1.SelectionStart) Then
                    MsgBox("����� ��������.", MsgBoxStyle.OKOnly, "���������:")
                    FindIndex = 0
                    FindLast = 0
                    FindText = TextBox2.Text
                Else
                    FindLast = RichTextBox1.SelectionStart
                End If
            End If
        Catch ex As Exception
            'MsgBox(ex.ToString, MsgBoxStyle.OKOnly, "��������� ������!")
        End Try
    End Sub

    Private Sub Label15_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label15.MouseMove
        Try
            Label15.BorderStyle = BorderStyle.FixedSingle
            Label14.BorderStyle = BorderStyle.None
            Label12.BorderStyle = BorderStyle.None
            Label13.BorderStyle = BorderStyle.None
            Label1.BorderStyle = BorderStyle.None
        Catch ex As Exception
            'MsgBox(ex.ToString, MsgBoxStyle.OKOnly, "��������� ������!")
        End Try
    End Sub

    Private Sub Label15_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label15.MouseLeave
        Try
            Label15.BorderStyle = BorderStyle.None
            Label14.BorderStyle = BorderStyle.None
            Label13.BorderStyle = BorderStyle.None
            Label12.BorderStyle = BorderStyle.None
            Label1.BorderStyle = BorderStyle.None
        Catch ex As Exception
            'MsgBox(ex.ToString, MsgBoxStyle.OKOnly, "��������� ������!")
        End Try
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click
        Close()
    End Sub

    Private Sub Label1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label1.MouseMove
        Try
            Label1.BorderStyle = BorderStyle.FixedSingle
            Label14.BorderStyle = BorderStyle.None
            Label12.BorderStyle = BorderStyle.None
            Label13.BorderStyle = BorderStyle.None
            Label15.BorderStyle = BorderStyle.None
        Catch ex As Exception
            'MsgBox(ex.ToString, MsgBoxStyle.OKOnly, "��������� ������!")
        End Try
    End Sub

    Private Sub Label1_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label1.MouseLeave
        Try
            Label15.BorderStyle = BorderStyle.None
            Label14.BorderStyle = BorderStyle.None
            Label13.BorderStyle = BorderStyle.None
            Label12.BorderStyle = BorderStyle.None
            Label1.BorderStyle = BorderStyle.None
        Catch ex As Exception
            'MsgBox(ex.ToString, MsgBoxStyle.OKOnly, "��������� ������!")
        End Try
    End Sub

    
    Private Sub MenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem1.Click
        RichTextBox1.Undo()
    End Sub

    Private Sub MenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem3.Click
        RichTextBox1.Cut()
    End Sub

    Private Sub MenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem4.Click
        RichTextBox1.Copy()
    End Sub

    Private Sub MenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem5.Click
        RichTextBox1.Paste()
        RichTextBox1.Font = ModulePE.FontModule
        RichTextBox1.SelectionColor = Color.Black
    End Sub

    Private Sub MenuItem6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem6.Click
        Clipboard.SetDataObject("")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Black
    End Sub

    Private Sub MenuItem7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem7.Click
        RichTextBox1.Clear()
    End Sub

    Private Sub MenuItem8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem8.Click
        RichTextBox1.SelectAll()
    End Sub

    Private Sub TextBox2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox2.KeyPress
        If (e.KeyChar.GetHashCode = 851981) Then
            '�����
            Try
                If (FindText <> TextBox2.Text) Then
                    FindIndex = 0
                    FindLast = 0
                    FindText = TextBox2.Text
                End If
                If (RichTextBox1.Find(TextBox2.Text, FindIndex, RichTextBox1.TextLength - 1, RichTextBoxFinds.None)) Then
                    RichTextBox1.Select()
                    FindIndex = RichTextBox1.SelectionStart + RichTextBox1.SelectionLength
                    If (FindLast = RichTextBox1.SelectionStart) Then
                        MsgBox("����� ��������.", MsgBoxStyle.OKOnly, "���������:")
                        FindIndex = 0
                        FindLast = 0
                        FindText = TextBox2.Text
                    Else
                        FindLast = RichTextBox1.SelectionStart
                    End If
                End If
            Catch ex As Exception
                'MsgBox(ex.ToString, MsgBoxStyle.OKOnly, "��������� ������!")
            End Try
        End If
    End Sub
End Class
