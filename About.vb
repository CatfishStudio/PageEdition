Public Class About
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
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(About))
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(0, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(344, 16)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Portions Copyright © Microsoft Corporation. All Rights Reserved."
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(0, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(296, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "© Somov Evgen, 2013"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(472, 48)
        Me.Panel1.TabIndex = 5
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(0, 48)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(470, 296)
        Me.TabControl1.TabIndex = 6
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.White
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(462, 267)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Общее"
        '
        'Label5
        '
        Me.Label5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.Location = New System.Drawing.Point(7, 40)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(448, 32)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Так же данное программное средство содержит компоненты авторские права которых пр" & _
        "енадлежать © Microsoft Corporation."
        '
        'Label4
        '
        Me.Label4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.Location = New System.Drawing.Point(8, 8)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(448, 32)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Данное программное средство является абсолютно бесплатным и любое распростронение" & _
        " кроме бесплатного запрещено."
        '
        'Label1
        '
        Me.Label1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(8, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(400, 109)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Версия программы 1.0.3  (26.03.2013)"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.RichTextBox1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(462, 267)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Лицензия Freeware"
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RichTextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.RichTextBox1.Location = New System.Drawing.Point(0, 0)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(464, 264)
        Me.RichTextBox1.TabIndex = 1
        Me.RichTextBox1.Text = "ОСНОВНЫЕ ПУНКТЫ ЛИЦЕНЗИИ FREEWARE." & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(10) & "Воспользовавшись данным программным средством" & _
        " вы тем самым принимаете условия данной лицензией." & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(10) & "ЛИЦЕНЗИОННОЕ СОГЛАШЕНИЕ." & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(10) & "1." & _
        " Эта программа защищена национальными законами и международными соглашениями об " & _
        "авторском праве. Исключительные права на использование этой программой принадлеж" & _
        "ат ее автору." & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(10) & "2. Программой и ее компонентами можно пользоваться бесплатно, нео" & _
        "граниченное время." & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(10) & "3. Использование компонентов данного программного обеспечени" & _
        "я в других программах запрещено без разрешения правообладателей/авторов этих ком" & _
        "понентов." & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(10) & "Запрещено коммерческое распространение программы. (За распространение" & _
        " программы запрещено брать деньги)." & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(10) & "4. Программа поставляется ""как есть"". " & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(10) & "5. " & _
        "Программа может включаться в состав платных сборников, помещаться на сайтах, отл" & _
        "ичных от сайта правообладателя только с разрешения правообладателя." & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(10) & "ОГРАНИЧЕНИ" & _
        "Е ГАРАНТИЙНЫХ ОБЯЗАТЕЛЬСТВ." & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(10) & "1. Программа может содержать ошибки. Правообладател" & _
        "ь не несет ответственность за возможные ошибки программы." & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(10) & "2. Правообладатель не" & _
        " гарантирует, что функции, содержащиеся в программе, будут удовлетворять заявлен" & _
        "ным требованиям или что работа программы не прервется из-за ошибки." & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(10) & "3. Правообл" & _
        "адатель намеренно отказывается от всех письменно заявленных и предполагаемых по-" & _
        "умолчанию гарантийных обязательств, включая ограничения в применении гарантийных" & _
        " обязательств после определенного срока и годности продукта к продаже." & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(10) & "4. Ни пр" & _
        "и каких обстоятельствах правообладатель не несет обязательств перед пользователе" & _
        "м за любой вред, физический или коммерческий, нанесенный данной программой, вклю" & _
        "чая упущенную прибыль, потерю данных, ущерб репутации или другой побочный или ко" & _
        "свенный вред, произошедший из-за использования или неспособности использования д" & _
        "анной программы. Также не принимаются иски на любые другие имущественные требова" & _
        "ния пользователя программы." & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(10) & "COPYRIGHT" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(10) & "1. Все исключительные авторские права н" & _
        "а программу принадлежат правообладателю." & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(10) & "2. Программу нельзя дизассемблировать," & _
        " менять что-либо в ней и дополнять ее новыми функциями." & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(10) & "3. При распространении " & _
        "программы обязательно указывается имя правообладателя, его контактная информация" & _
        " и сайт правообладателя." & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(10) & "КОНТРОЛЬ НАД СОБЛЮДЕНИЕМ ОБЯЗАТЕЛЬСТВ." & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(10) & "1. Это лиценз" & _
        "ионное соглашение соответствует национальным законам об авторском праве. Данное " & _
        "соглашение основано на новой редакции этих законов, что отменяет все остальные д" & _
        "оговоренности и соглашения, ранее применяемые по отношению к данному продукту." & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(10) & _
        "2. Все спорные вопросы решаются по взаимной договоренности сторон, а если соглаш" & _
        "ения не было достигнуто, то в судах общей юрисдикции." & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(10) & "КОНТАКТНАЯ ИНФОРМАЦИЯ" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(10) & "А" & _
        "втор: Сомов Евгений Павлович" & Microsoft.VisualBasic.ChrW(10) & "Адрес: Украина, г. Луганск" & Microsoft.VisualBasic.ChrW(10) & "Email: info@catfish.ltd." & _
        "ua" & Microsoft.VisualBasic.ChrW(10) & "Сайт: catfish.ltd.ua"
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.SystemColors.Control
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Location = New System.Drawing.Point(0, 350)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(472, 32)
        Me.Panel2.TabIndex = 7
        '
        'About
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(472, 382)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "About"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "О программе."
        Me.TopMost = True
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub About_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'ModuleCabinet.AboutShow = True
    End Sub

    Private Sub About_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        'ModuleCabinet.AboutShow = False
    End Sub
End Class
