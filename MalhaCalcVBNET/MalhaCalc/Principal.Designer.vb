<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Principal
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Principal))
        Me.ComboBox_material = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBox_largura = New System.Windows.Forms.TextBox()
        Me.TextBox_comprimento = New System.Windows.Forms.TextBox()
        Me.TextBox_rho1 = New System.Windows.Forms.TextBox()
        Me.TextBox_d1 = New System.Windows.Forms.TextBox()
        Me.TextBox_rho2 = New System.Windows.Forms.TextBox()
        Me.TextBox_N = New System.Windows.Forms.TextBox()
        Me.TextBox_correnteMalha = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ComboBox_condutor = New System.Windows.Forms.ComboBox()
        Me.TextBox_tempoCurto = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.SobreToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsideraçõesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AutorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TextBox_tempMax = New System.Windows.Forms.TextBox()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.TextBox_tempAmbiente = New System.Windows.Forms.TextBox()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox_distCond = New System.Windows.Forms.TextBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.TextBox_hmalha = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox_rminMalha = New System.Windows.Forms.TextBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.TextBox_hastes = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label_Ks1 = New System.Windows.Forms.Label()
        Me.Label_Ki1 = New System.Windows.Forms.Label()
        Me.Label_Km1 = New System.Windows.Forms.Label()
        Me.Label_Ks = New System.Windows.Forms.Label()
        Me.Label_Ki = New System.Windows.Forms.Label()
        Me.Label_Km = New System.Windows.Forms.Label()
        Me.Label_secaoCabo = New System.Windows.Forms.Label()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.Label_comprimentoHastes = New System.Windows.Forms.Label()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.Label_comprimentoCabos = New System.Windows.Forms.Label()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.Label_GPR = New System.Windows.Forms.Label()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.Label_gastoCabos = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label_resistenciaMalha = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label_tensaoToqueMaxMalha = New System.Windows.Forms.Label()
        Me.Label_tensaoPassoMaxMalha = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label_rhoA = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label_beta = New System.Windows.Forms.Label()
        Me.Label_alpha = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label_tensaoPassoMax = New System.Windows.Forms.Label()
        Me.Label_tensaoToqueMax = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label_Cs1 = New System.Windows.Forms.Label()
        Me.Label_Cs = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ComboBox_material
        '
        Me.ComboBox_material.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_material.FormattingEnabled = True
        Me.ComboBox_material.Items.AddRange(New Object() {"Pantano", "Lodo", "Humus", "Areia Argilosa", "Areia Silicosa", "Brita", "Calcareo", "Granito"})
        Me.ComboBox_material.Location = New System.Drawing.Point(9, 260)
        Me.ComboBox_material.Name = "ComboBox_material"
        Me.ComboBox_material.Size = New System.Drawing.Size(135, 21)
        Me.ComboBox_material.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(49, 244)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Material"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(30, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Largura [m]"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(158, 30)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Comprimento [m]"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(49, 56)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "ρ1 [Ω]"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(203, 56)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(36, 13)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "d1 [m]"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(19, 82)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(67, 13)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "ρ2 (terra) [Ω]"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(224, 82)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(15, 13)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "N"
        '
        'TextBox_largura
        '
        Me.TextBox_largura.Location = New System.Drawing.Point(92, 27)
        Me.TextBox_largura.Name = "TextBox_largura"
        Me.TextBox_largura.Size = New System.Drawing.Size(40, 20)
        Me.TextBox_largura.TabIndex = 10
        '
        'TextBox_comprimento
        '
        Me.TextBox_comprimento.Location = New System.Drawing.Point(245, 27)
        Me.TextBox_comprimento.Name = "TextBox_comprimento"
        Me.TextBox_comprimento.Size = New System.Drawing.Size(40, 20)
        Me.TextBox_comprimento.TabIndex = 11
        '
        'TextBox_rho1
        '
        Me.TextBox_rho1.Location = New System.Drawing.Point(92, 53)
        Me.TextBox_rho1.Name = "TextBox_rho1"
        Me.TextBox_rho1.Size = New System.Drawing.Size(40, 20)
        Me.TextBox_rho1.TabIndex = 12
        '
        'TextBox_d1
        '
        Me.TextBox_d1.Location = New System.Drawing.Point(245, 53)
        Me.TextBox_d1.Name = "TextBox_d1"
        Me.TextBox_d1.Size = New System.Drawing.Size(40, 20)
        Me.TextBox_d1.TabIndex = 13
        '
        'TextBox_rho2
        '
        Me.TextBox_rho2.Location = New System.Drawing.Point(92, 79)
        Me.TextBox_rho2.Name = "TextBox_rho2"
        Me.TextBox_rho2.Size = New System.Drawing.Size(40, 20)
        Me.TextBox_rho2.TabIndex = 14
        '
        'TextBox_N
        '
        Me.TextBox_N.Location = New System.Drawing.Point(245, 79)
        Me.TextBox_N.Name = "TextBox_N"
        Me.TextBox_N.Size = New System.Drawing.Size(40, 20)
        Me.TextBox_N.TabIndex = 15
        '
        'TextBox_correnteMalha
        '
        Me.TextBox_correnteMalha.Location = New System.Drawing.Point(92, 105)
        Me.TextBox_correnteMalha.Name = "TextBox_correnteMalha"
        Me.TextBox_correnteMalha.Size = New System.Drawing.Size(40, 20)
        Me.TextBox_correnteMalha.TabIndex = 17
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(30, 108)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(60, 13)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "I(malha) [A]"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(215, 244)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(50, 13)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "Condutor"
        '
        'ComboBox_condutor
        '
        Me.ComboBox_condutor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_condutor.FormattingEnabled = True
        Me.ComboBox_condutor.Items.AddRange(New Object() {"Cobre mole", "Cobre comercial", "Cobre com alma de aço", "Alumínio com alma de aço", "Aço 1020", "Aço inoxidável", "Zinco", "Aço inoxidável 304"})
        Me.ComboBox_condutor.Location = New System.Drawing.Point(171, 260)
        Me.ComboBox_condutor.Name = "ComboBox_condutor"
        Me.ComboBox_condutor.Size = New System.Drawing.Size(138, 21)
        Me.ComboBox_condutor.TabIndex = 18
        '
        'TextBox_tempoCurto
        '
        Me.TextBox_tempoCurto.Location = New System.Drawing.Point(245, 105)
        Me.TextBox_tempoCurto.Name = "TextBox_tempoCurto"
        Me.TextBox_tempoCurto.Size = New System.Drawing.Size(40, 20)
        Me.TextBox_tempoCurto.TabIndex = 21
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(172, 108)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(67, 13)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "T curto [seg]"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SobreToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1008, 24)
        Me.MenuStrip1.TabIndex = 22
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'SobreToolStripMenuItem
        '
        Me.SobreToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConsideraçõesToolStripMenuItem, Me.AutorToolStripMenuItem})
        Me.SobreToolStripMenuItem.Name = "SobreToolStripMenuItem"
        Me.SobreToolStripMenuItem.Size = New System.Drawing.Size(49, 20)
        Me.SobreToolStripMenuItem.Text = "Sobre"
        '
        'ConsideraçõesToolStripMenuItem
        '
        Me.ConsideraçõesToolStripMenuItem.Name = "ConsideraçõesToolStripMenuItem"
        Me.ConsideraçõesToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.ConsideraçõesToolStripMenuItem.Text = "Considerações"
        '
        'AutorToolStripMenuItem
        '
        Me.AutorToolStripMenuItem.Name = "AutorToolStripMenuItem"
        Me.AutorToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.AutorToolStripMenuItem.Text = "Autor"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.TextBox_tempMax)
        Me.GroupBox1.Controls.Add(Me.Label41)
        Me.GroupBox1.Controls.Add(Me.TextBox_tempAmbiente)
        Me.GroupBox1.Controls.Add(Me.Label42)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.TextBox_distCond)
        Me.GroupBox1.Controls.Add(Me.Label29)
        Me.GroupBox1.Controls.Add(Me.TextBox_hmalha)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TextBox_rminMalha)
        Me.GroupBox1.Controls.Add(Me.Label30)
        Me.GroupBox1.Controls.Add(Me.TextBox_hastes)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.ComboBox_material)
        Me.GroupBox1.Controls.Add(Me.TextBox_tempoCurto)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.ComboBox_condutor)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.TextBox_correnteMalha)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.TextBox_N)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.TextBox_rho2)
        Me.GroupBox1.Controls.Add(Me.TextBox_largura)
        Me.GroupBox1.Controls.Add(Me.TextBox_d1)
        Me.GroupBox1.Controls.Add(Me.TextBox_comprimento)
        Me.GroupBox1.Controls.Add(Me.TextBox_rho1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 27)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(334, 423)
        Me.GroupBox1.TabIndex = 23
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Dados de entrada"
        '
        'TextBox_tempMax
        '
        Me.TextBox_tempMax.Location = New System.Drawing.Point(245, 183)
        Me.TextBox_tempMax.Name = "TextBox_tempMax"
        Me.TextBox_tempMax.Size = New System.Drawing.Size(40, 20)
        Me.TextBox_tempMax.TabIndex = 34
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.Location = New System.Drawing.Point(183, 186)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(56, 13)
        Me.Label41.TabIndex = 33
        Me.Label41.Text = "T max [°C]"
        '
        'TextBox_tempAmbiente
        '
        Me.TextBox_tempAmbiente.Location = New System.Drawing.Point(93, 183)
        Me.TextBox_tempAmbiente.Name = "TextBox_tempAmbiente"
        Me.TextBox_tempAmbiente.Size = New System.Drawing.Size(40, 20)
        Me.TextBox_tempAmbiente.TabIndex = 32
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Location = New System.Drawing.Point(7, 186)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(80, 13)
        Me.Label42.TabIndex = 31
        Me.Label42.Text = "T ambiente [°C]"
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.Location = New System.Drawing.Point(206, 390)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 27
        Me.Button2.Text = "Reset"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button1.Location = New System.Drawing.Point(49, 390)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 25
        Me.Button1.Text = "Calcular"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox_distCond
        '
        Me.TextBox_distCond.Location = New System.Drawing.Point(244, 157)
        Me.TextBox_distCond.Name = "TextBox_distCond"
        Me.TextBox_distCond.Size = New System.Drawing.Size(40, 20)
        Me.TextBox_distCond.TabIndex = 30
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(170, 160)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(69, 13)
        Me.Label29.TabIndex = 29
        Me.Label29.Text = "Dist cond [m]"
        '
        'TextBox_hmalha
        '
        Me.TextBox_hmalha.Location = New System.Drawing.Point(245, 131)
        Me.TextBox_hmalha.Name = "TextBox_hmalha"
        Me.TextBox_hmalha.Size = New System.Drawing.Size(40, 20)
        Me.TextBox_hmalha.TabIndex = 25
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(179, 134)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Hmalha [m]"
        '
        'TextBox_rminMalha
        '
        Me.TextBox_rminMalha.Location = New System.Drawing.Point(92, 157)
        Me.TextBox_rminMalha.Name = "TextBox_rminMalha"
        Me.TextBox_rminMalha.Size = New System.Drawing.Size(40, 20)
        Me.TextBox_rminMalha.TabIndex = 28
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(6, 160)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(83, 13)
        Me.Label30.TabIndex = 27
        Me.Label30.Text = "Rmin(malha) [Ω]"
        '
        'TextBox_hastes
        '
        Me.TextBox_hastes.Location = New System.Drawing.Point(92, 131)
        Me.TextBox_hastes.Name = "TextBox_hastes"
        Me.TextBox_hastes.Size = New System.Drawing.Size(40, 20)
        Me.TextBox_hastes.TabIndex = 23
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(46, 134)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(40, 13)
        Me.Label12.TabIndex = 22
        Me.Label12.Text = "Hastes"
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(352, 27)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(644, 423)
        Me.TabControl1.TabIndex = 26
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Label_Cs1)
        Me.TabPage1.Controls.Add(Me.Label_Cs)
        Me.TabPage1.Controls.Add(Me.Label_Ks1)
        Me.TabPage1.Controls.Add(Me.Label_Ki1)
        Me.TabPage1.Controls.Add(Me.Label_Km1)
        Me.TabPage1.Controls.Add(Me.Label_Ks)
        Me.TabPage1.Controls.Add(Me.Label_Ki)
        Me.TabPage1.Controls.Add(Me.Label_Km)
        Me.TabPage1.Controls.Add(Me.Label_secaoCabo)
        Me.TabPage1.Controls.Add(Me.Label40)
        Me.TabPage1.Controls.Add(Me.Label_comprimentoHastes)
        Me.TabPage1.Controls.Add(Me.Label39)
        Me.TabPage1.Controls.Add(Me.Label_comprimentoCabos)
        Me.TabPage1.Controls.Add(Me.Label37)
        Me.TabPage1.Controls.Add(Me.Label_GPR)
        Me.TabPage1.Controls.Add(Me.Label36)
        Me.TabPage1.Controls.Add(Me.Label_gastoCabos)
        Me.TabPage1.Controls.Add(Me.Label32)
        Me.TabPage1.Controls.Add(Me.Label_resistenciaMalha)
        Me.TabPage1.Controls.Add(Me.Label28)
        Me.TabPage1.Controls.Add(Me.Label_tensaoToqueMaxMalha)
        Me.TabPage1.Controls.Add(Me.Label_tensaoPassoMaxMalha)
        Me.TabPage1.Controls.Add(Me.Label25)
        Me.TabPage1.Controls.Add(Me.Label26)
        Me.TabPage1.Controls.Add(Me.Label_rhoA)
        Me.TabPage1.Controls.Add(Me.Label22)
        Me.TabPage1.Controls.Add(Me.Label_beta)
        Me.TabPage1.Controls.Add(Me.Label_alpha)
        Me.TabPage1.Controls.Add(Me.Label18)
        Me.TabPage1.Controls.Add(Me.Label17)
        Me.TabPage1.Controls.Add(Me.Label_tensaoPassoMax)
        Me.TabPage1.Controls.Add(Me.Label_tensaoToqueMax)
        Me.TabPage1.Controls.Add(Me.Label14)
        Me.TabPage1.Controls.Add(Me.Label13)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(636, 397)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Resultados"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Label_Ks1
        '
        Me.Label_Ks1.AutoSize = True
        Me.Label_Ks1.Location = New System.Drawing.Point(378, 315)
        Me.Label_Ks1.Name = "Label_Ks1"
        Me.Label_Ks1.Size = New System.Drawing.Size(13, 13)
        Me.Label_Ks1.TabIndex = 70
        Me.Label_Ks1.Text = "--"
        '
        'Label_Ki1
        '
        Me.Label_Ki1.AutoSize = True
        Me.Label_Ki1.Location = New System.Drawing.Point(213, 315)
        Me.Label_Ki1.Name = "Label_Ki1"
        Me.Label_Ki1.Size = New System.Drawing.Size(13, 13)
        Me.Label_Ki1.TabIndex = 69
        Me.Label_Ki1.Text = "--"
        '
        'Label_Km1
        '
        Me.Label_Km1.AutoSize = True
        Me.Label_Km1.Location = New System.Drawing.Point(58, 315)
        Me.Label_Km1.Name = "Label_Km1"
        Me.Label_Km1.Size = New System.Drawing.Size(13, 13)
        Me.Label_Km1.TabIndex = 68
        Me.Label_Km1.Text = "--"
        '
        'Label_Ks
        '
        Me.Label_Ks.AutoSize = True
        Me.Label_Ks.Location = New System.Drawing.Point(347, 315)
        Me.Label_Ks.Name = "Label_Ks"
        Me.Label_Ks.Size = New System.Drawing.Size(25, 13)
        Me.Label_Ks.TabIndex = 67
        Me.Label_Ks.Text = "Ks: "
        '
        'Label_Ki
        '
        Me.Label_Ki.AutoSize = True
        Me.Label_Ki.Location = New System.Drawing.Point(185, 315)
        Me.Label_Ki.Name = "Label_Ki"
        Me.Label_Ki.Size = New System.Drawing.Size(22, 13)
        Me.Label_Ki.TabIndex = 66
        Me.Label_Ki.Text = "Ki: "
        '
        'Label_Km
        '
        Me.Label_Km.AutoSize = True
        Me.Label_Km.Location = New System.Drawing.Point(24, 315)
        Me.Label_Km.Name = "Label_Km"
        Me.Label_Km.Size = New System.Drawing.Size(28, 13)
        Me.Label_Km.TabIndex = 65
        Me.Label_Km.Text = "Km: "
        '
        'Label_secaoCabo
        '
        Me.Label_secaoCabo.AutoSize = True
        Me.Label_secaoCabo.Location = New System.Drawing.Point(110, 164)
        Me.Label_secaoCabo.Name = "Label_secaoCabo"
        Me.Label_secaoCabo.Size = New System.Drawing.Size(13, 13)
        Me.Label_secaoCabo.TabIndex = 64
        Me.Label_secaoCabo.Text = "--"
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Location = New System.Drawing.Point(21, 161)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(83, 13)
        Me.Label40.TabIndex = 63
        Me.Label40.Text = "Seção do cabo:"
        '
        'Label_comprimentoHastes
        '
        Me.Label_comprimentoHastes.AutoSize = True
        Me.Label_comprimentoHastes.Location = New System.Drawing.Point(197, 238)
        Me.Label_comprimentoHastes.Name = "Label_comprimentoHastes"
        Me.Label_comprimentoHastes.Size = New System.Drawing.Size(13, 13)
        Me.Label_comprimentoHastes.TabIndex = 62
        Me.Label_comprimentoHastes.Text = "--"
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Location = New System.Drawing.Point(141, 238)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(50, 13)
        Me.Label39.TabIndex = 61
        Me.Label39.Text = "Lhastes: "
        '
        'Label_comprimentoCabos
        '
        Me.Label_comprimentoCabos.AutoSize = True
        Me.Label_comprimentoCabos.Location = New System.Drawing.Point(75, 238)
        Me.Label_comprimentoCabos.Name = "Label_comprimentoCabos"
        Me.Label_comprimentoCabos.Size = New System.Drawing.Size(13, 13)
        Me.Label_comprimentoCabos.TabIndex = 60
        Me.Label_comprimentoCabos.Text = "--"
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Location = New System.Drawing.Point(21, 238)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(48, 13)
        Me.Label37.TabIndex = 59
        Me.Label37.Text = "Lcabos: "
        '
        'Label_GPR
        '
        Me.Label_GPR.AutoSize = True
        Me.Label_GPR.Location = New System.Drawing.Point(389, 201)
        Me.Label_GPR.Name = "Label_GPR"
        Me.Label_GPR.Size = New System.Drawing.Size(13, 13)
        Me.Label_GPR.TabIndex = 58
        Me.Label_GPR.Text = "--"
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Location = New System.Drawing.Point(347, 201)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(36, 13)
        Me.Label36.TabIndex = 57
        Me.Label36.Text = "GPR :"
        '
        'Label_gastoCabos
        '
        Me.Label_gastoCabos.AutoSize = True
        Me.Label_gastoCabos.Location = New System.Drawing.Point(135, 12)
        Me.Label_gastoCabos.Name = "Label_gastoCabos"
        Me.Label_gastoCabos.Size = New System.Drawing.Size(13, 13)
        Me.Label_gastoCabos.TabIndex = 56
        Me.Label_gastoCabos.Text = "--"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(21, 12)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(108, 13)
        Me.Label32.TabIndex = 55
        Me.Label32.Text = "Gasto total de cabos:"
        '
        'Label_resistenciaMalha
        '
        Me.Label_resistenciaMalha.AutoSize = True
        Me.Label_resistenciaMalha.Location = New System.Drawing.Point(139, 136)
        Me.Label_resistenciaMalha.Name = "Label_resistenciaMalha"
        Me.Label_resistenciaMalha.Size = New System.Drawing.Size(13, 13)
        Me.Label_resistenciaMalha.TabIndex = 54
        Me.Label_resistenciaMalha.Text = "--"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(21, 136)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(114, 13)
        Me.Label28.TabIndex = 53
        Me.Label28.Text = "Resistência da malha: "
        '
        'Label_tensaoToqueMaxMalha
        '
        Me.Label_tensaoToqueMaxMalha.AutoSize = True
        Me.Label_tensaoToqueMaxMalha.Location = New System.Drawing.Point(211, 90)
        Me.Label_tensaoToqueMaxMalha.Name = "Label_tensaoToqueMaxMalha"
        Me.Label_tensaoToqueMaxMalha.Size = New System.Drawing.Size(13, 13)
        Me.Label_tensaoToqueMaxMalha.TabIndex = 52
        Me.Label_tensaoToqueMaxMalha.Text = "--"
        '
        'Label_tensaoPassoMaxMalha
        '
        Me.Label_tensaoPassoMaxMalha.AutoSize = True
        Me.Label_tensaoPassoMaxMalha.Location = New System.Drawing.Point(211, 114)
        Me.Label_tensaoPassoMaxMalha.Name = "Label_tensaoPassoMaxMalha"
        Me.Label_tensaoPassoMaxMalha.Size = New System.Drawing.Size(13, 13)
        Me.Label_tensaoPassoMaxMalha.TabIndex = 51
        Me.Label_tensaoPassoMaxMalha.Text = "--"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(21, 114)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(184, 13)
        Me.Label25.TabIndex = 50
        Me.Label25.Text = "Potencial de passo máximo na malha:"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(21, 90)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(186, 13)
        Me.Label26.TabIndex = 49
        Me.Label26.Text = "Potencial de toque máximo na malha: "
        '
        'Label_rhoA
        '
        Me.Label_rhoA.AutoSize = True
        Me.Label_rhoA.Location = New System.Drawing.Point(251, 201)
        Me.Label_rhoA.Name = "Label_rhoA"
        Me.Label_rhoA.Size = New System.Drawing.Size(13, 13)
        Me.Label_rhoA.TabIndex = 48
        Me.Label_rhoA.Text = "--"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(224, 201)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(25, 13)
        Me.Label22.TabIndex = 47
        Me.Label22.Text = "ρa :"
        '
        'Label_beta
        '
        Me.Label_beta.AutoSize = True
        Me.Label_beta.Location = New System.Drawing.Point(141, 201)
        Me.Label_beta.Name = "Label_beta"
        Me.Label_beta.Size = New System.Drawing.Size(13, 13)
        Me.Label_beta.TabIndex = 46
        Me.Label_beta.Text = "--"
        '
        'Label_alpha
        '
        Me.Label_alpha.AutoSize = True
        Me.Label_alpha.Location = New System.Drawing.Point(37, 201)
        Me.Label_alpha.Name = "Label_alpha"
        Me.Label_alpha.Size = New System.Drawing.Size(13, 13)
        Me.Label_alpha.TabIndex = 45
        Me.Label_alpha.Text = "--"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(125, 201)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(19, 13)
        Me.Label18.TabIndex = 44
        Me.Label18.Text = "β :"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(21, 201)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(17, 13)
        Me.Label17.TabIndex = 43
        Me.Label17.Text = "α:"
        '
        'Label_tensaoPassoMax
        '
        Me.Label_tensaoPassoMax.AutoSize = True
        Me.Label_tensaoPassoMax.Location = New System.Drawing.Point(165, 62)
        Me.Label_tensaoPassoMax.Name = "Label_tensaoPassoMax"
        Me.Label_tensaoPassoMax.Size = New System.Drawing.Size(13, 13)
        Me.Label_tensaoPassoMax.TabIndex = 42
        Me.Label_tensaoPassoMax.Text = "--"
        '
        'Label_tensaoToqueMax
        '
        Me.Label_tensaoToqueMax.AutoSize = True
        Me.Label_tensaoToqueMax.Location = New System.Drawing.Point(167, 38)
        Me.Label_tensaoToqueMax.Name = "Label_tensaoToqueMax"
        Me.Label_tensaoToqueMax.Size = New System.Drawing.Size(13, 13)
        Me.Label_tensaoToqueMax.TabIndex = 41
        Me.Label_tensaoToqueMax.Text = "--"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(21, 62)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(138, 13)
        Me.Label14.TabIndex = 40
        Me.Label14.Text = "Potencial de passo máximo:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(21, 38)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(140, 13)
        Me.Label13.TabIndex = 39
        Me.Label13.Text = "Potencial de toque máximo: "
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.PictureBox1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(636, 397)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Malha"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Location = New System.Drawing.Point(6, 8)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(624, 383)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label_Cs1
        '
        Me.Label_Cs1.AutoSize = True
        Me.Label_Cs1.Location = New System.Drawing.Point(526, 315)
        Me.Label_Cs1.Name = "Label_Cs1"
        Me.Label_Cs1.Size = New System.Drawing.Size(13, 13)
        Me.Label_Cs1.TabIndex = 72
        Me.Label_Cs1.Text = "--"
        '
        'Label_Cs
        '
        Me.Label_Cs.AutoSize = True
        Me.Label_Cs.Location = New System.Drawing.Point(495, 315)
        Me.Label_Cs.Name = "Label_Cs"
        Me.Label_Cs.Size = New System.Drawing.Size(25, 13)
        Me.Label_Cs.TabIndex = 71
        Me.Label_Cs.Text = "Cs: "
        '
        'Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 462)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Principal"
        Me.Text = "Malha Calc - Versão 0.3b"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ComboBox_material As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TextBox_largura As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_comprimento As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_rho1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_d1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_rho2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_N As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_correnteMalha As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents ComboBox_condutor As System.Windows.Forms.ComboBox
    Friend WithEvents TextBox_tempoCurto As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents SobreToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConsideraçõesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox_hmalha As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox_hastes As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TextBox_rminMalha As System.Windows.Forms.TextBox
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label_gastoCabos As System.Windows.Forms.Label
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents Label_resistenciaMalha As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label_tensaoToqueMaxMalha As System.Windows.Forms.Label
    Friend WithEvents Label_tensaoPassoMaxMalha As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label_rhoA As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label_beta As System.Windows.Forms.Label
    Friend WithEvents Label_alpha As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label_tensaoPassoMax As System.Windows.Forms.Label
    Friend WithEvents Label_tensaoToqueMax As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents TextBox_distCond As System.Windows.Forms.TextBox
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label_GPR As System.Windows.Forms.Label
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label_comprimentoHastes As System.Windows.Forms.Label
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents Label_comprimentoCabos As System.Windows.Forms.Label
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents AutorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label_secaoCabo As System.Windows.Forms.Label
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents TextBox_tempMax As System.Windows.Forms.TextBox
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents TextBox_tempAmbiente As System.Windows.Forms.TextBox
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents Label_Ks1 As System.Windows.Forms.Label
    Friend WithEvents Label_Ki1 As System.Windows.Forms.Label
    Friend WithEvents Label_Km1 As System.Windows.Forms.Label
    Friend WithEvents Label_Ks As System.Windows.Forms.Label
    Friend WithEvents Label_Ki As System.Windows.Forms.Label
    Friend WithEvents Label_Km As System.Windows.Forms.Label
    Friend WithEvents Label_Cs1 As System.Windows.Forms.Label
    Friend WithEvents Label_Cs As System.Windows.Forms.Label

End Class
