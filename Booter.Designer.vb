<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Booter
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Booter))
        Me.Tempo_Ataque = New System.Windows.Forms.Timer(Me.components)
        Me.DiminuirTrackBar = New System.Windows.Forms.Timer(Me.components)
        Me.Color = New System.Windows.Forms.Timer(Me.components)
        Me.xChat = New System.Windows.Forms.Timer(Me.components)
        Me.ChatB = New System.ComponentModel.BackgroundWorker()
        Me.KillSniffing = New System.Windows.Forms.Timer(Me.components)
        Me.BoosterTheme1 = New Hard_Booter.BoosterTheme()
        Me.Admin = New System.Windows.Forms.WebBrowser()
        Me.Chat = New System.Windows.Forms.WebBrowser()
        Me.WebBrowser40 = New System.Windows.Forms.WebBrowser()
        Me.WebBrowser39 = New System.Windows.Forms.WebBrowser()
        Me.WebBrowser38 = New System.Windows.Forms.WebBrowser()
        Me.WebBrowser37 = New System.Windows.Forms.WebBrowser()
        Me.WebBrowser36 = New System.Windows.Forms.WebBrowser()
        Me.WebBrowser35 = New System.Windows.Forms.WebBrowser()
        Me.WebBrowser34 = New System.Windows.Forms.WebBrowser()
        Me.WebBrowser33 = New System.Windows.Forms.WebBrowser()
        Me.WebBrowser32 = New System.Windows.Forms.WebBrowser()
        Me.WebBrowser31 = New System.Windows.Forms.WebBrowser()
        Me.WebBrowser30 = New System.Windows.Forms.WebBrowser()
        Me.WebBrowser29 = New System.Windows.Forms.WebBrowser()
        Me.WebBrowser28 = New System.Windows.Forms.WebBrowser()
        Me.WebBrowser27 = New System.Windows.Forms.WebBrowser()
        Me.WebBrowser26 = New System.Windows.Forms.WebBrowser()
        Me.WebBrowser25 = New System.Windows.Forms.WebBrowser()
        Me.WebBrowser24 = New System.Windows.Forms.WebBrowser()
        Me.WebBrowser23 = New System.Windows.Forms.WebBrowser()
        Me.WebBrowser22 = New System.Windows.Forms.WebBrowser()
        Me.WebBrowser21 = New System.Windows.Forms.WebBrowser()
        Me.WebBrowser20 = New System.Windows.Forms.WebBrowser()
        Me.WebBrowser19 = New System.Windows.Forms.WebBrowser()
        Me.WebBrowser18 = New System.Windows.Forms.WebBrowser()
        Me.WebBrowser17 = New System.Windows.Forms.WebBrowser()
        Me.WebBrowser16 = New System.Windows.Forms.WebBrowser()
        Me.WebBrowser15 = New System.Windows.Forms.WebBrowser()
        Me.WebBrowser14 = New System.Windows.Forms.WebBrowser()
        Me.WebBrowser13 = New System.Windows.Forms.WebBrowser()
        Me.WebBrowser12 = New System.Windows.Forms.WebBrowser()
        Me.WebBrowser11 = New System.Windows.Forms.WebBrowser()
        Me.WebBrowser10 = New System.Windows.Forms.WebBrowser()
        Me.WebBrowser9 = New System.Windows.Forms.WebBrowser()
        Me.WebBrowser8 = New System.Windows.Forms.WebBrowser()
        Me.WebBrowser7 = New System.Windows.Forms.WebBrowser()
        Me.WebBrowser6 = New System.Windows.Forms.WebBrowser()
        Me.WebBrowser5 = New System.Windows.Forms.WebBrowser()
        Me.WebBrowser4 = New System.Windows.Forms.WebBrowser()
        Me.WebBrowser3 = New System.Windows.Forms.WebBrowser()
        Me.WebBrowser2 = New System.Windows.Forms.WebBrowser()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.Logado = New System.Windows.Forms.Label()
        Me.Comando = New Hard_Booter.LogInStatusBar()
        Me.Minimizar = New Hard_Booter.BoosterRedButton()
        Me.Fechar = New Hard_Booter.BoosterRedButton()
        Me.LogInTabControl1 = New Hard_Booter.LogInTabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.DiasVIP = New System.Windows.Forms.Label()
        Me.BemV = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Tempo = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LogInComboBox1 = New Hard_Booter.LogInComboBox()
        Me.taimi = New Hard_Booter.LogInTrackBar()
        Me.IP = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PORTA = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BossterMixedButton3 = New Hard_Booter.BossterMixedButton()
        Me.BossterMixedButton2 = New Hard_Booter.BossterMixedButton()
        Me.Atacar = New Hard_Booter.BossterMixedButton()
        Me.PararAtaque = New Hard_Booter.BossterMixedButton()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.listResolverIP = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.NumArchPort = New System.Windows.Forms.NumericUpDown()
        Me.cbArchMethod = New Hard_Booter.LogInComboBox()
        Me.txtArchIP = New System.Windows.Forms.TextBox()
        Me.btnArchStart = New Hard_Booter.BoosterButton()
        Me.btnArchStop = New Hard_Booter.BoosterButton()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.BoosterButton2 = New Hard_Booter.BoosterButton()
        Me.BoosterButton1 = New Hard_Booter.BoosterButton()
        Me.Ipgeo = New System.Windows.Forms.TextBox()
        Me.geoinfo = New System.Windows.Forms.TextBox()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.Mensagem = New System.Windows.Forms.TextBox()
        Me.BoosterRedButton1 = New Hard_Booter.BoosterRedButton()
        Me.chaty = New System.Windows.Forms.TextBox()
        Me.TabPage6 = New System.Windows.Forms.TabPage()
        Me.AdminPanel = New System.Windows.Forms.Panel()
        Me.respostaadmin = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.BoosterControlpanel1 = New Hard_Booter.BoosterControlpanel()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.BoosterButton4 = New Hard_Booter.BoosterButton()
        Me.logCreatePass = New System.Windows.Forms.TextBox()
        Me.logCreate = New System.Windows.Forms.TextBox()
        Me.BoosterControlpanel2 = New Hard_Booter.BoosterControlpanel()
        Me.BoosterButton5 = New Hard_Booter.BoosterButton()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.logAdminButton = New Hard_Booter.BoosterButton()
        Me.logAdmin = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.passAdmin = New System.Windows.Forms.TextBox()
        Me.BoosterTheme1.SuspendLayout()
        Me.LogInTabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        CType(Me.NumArchPort, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage4.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        Me.TabPage6.SuspendLayout()
        Me.AdminPanel.SuspendLayout()
        Me.BoosterControlpanel1.SuspendLayout()
        Me.BoosterControlpanel2.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Tempo_Ataque
        '
        Me.Tempo_Ataque.Enabled = True
        Me.Tempo_Ataque.Interval = 1
        '
        'DiminuirTrackBar
        '
        Me.DiminuirTrackBar.Interval = 1000
        '
        'Color
        '
        Me.Color.Enabled = True
        '
        'xChat
        '
        Me.xChat.Enabled = True
        Me.xChat.Interval = 2000
        '
        'ChatB
        '
        '
        'KillSniffing
        '
        Me.KillSniffing.Enabled = True
        Me.KillSniffing.Interval = 525
        '
        'BoosterTheme1
        '
        Me.BoosterTheme1.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.BoosterTheme1.BorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.BoosterTheme1.Colors = New Hard_Booter.Bloom(-1) {}
        Me.BoosterTheme1.Controls.Add(Me.Admin)
        Me.BoosterTheme1.Controls.Add(Me.Chat)
        Me.BoosterTheme1.Controls.Add(Me.WebBrowser40)
        Me.BoosterTheme1.Controls.Add(Me.WebBrowser39)
        Me.BoosterTheme1.Controls.Add(Me.WebBrowser38)
        Me.BoosterTheme1.Controls.Add(Me.WebBrowser37)
        Me.BoosterTheme1.Controls.Add(Me.WebBrowser36)
        Me.BoosterTheme1.Controls.Add(Me.WebBrowser35)
        Me.BoosterTheme1.Controls.Add(Me.WebBrowser34)
        Me.BoosterTheme1.Controls.Add(Me.WebBrowser33)
        Me.BoosterTheme1.Controls.Add(Me.WebBrowser32)
        Me.BoosterTheme1.Controls.Add(Me.WebBrowser31)
        Me.BoosterTheme1.Controls.Add(Me.WebBrowser30)
        Me.BoosterTheme1.Controls.Add(Me.WebBrowser29)
        Me.BoosterTheme1.Controls.Add(Me.WebBrowser28)
        Me.BoosterTheme1.Controls.Add(Me.WebBrowser27)
        Me.BoosterTheme1.Controls.Add(Me.WebBrowser26)
        Me.BoosterTheme1.Controls.Add(Me.WebBrowser25)
        Me.BoosterTheme1.Controls.Add(Me.WebBrowser24)
        Me.BoosterTheme1.Controls.Add(Me.WebBrowser23)
        Me.BoosterTheme1.Controls.Add(Me.WebBrowser22)
        Me.BoosterTheme1.Controls.Add(Me.WebBrowser21)
        Me.BoosterTheme1.Controls.Add(Me.WebBrowser20)
        Me.BoosterTheme1.Controls.Add(Me.WebBrowser19)
        Me.BoosterTheme1.Controls.Add(Me.WebBrowser18)
        Me.BoosterTheme1.Controls.Add(Me.WebBrowser17)
        Me.BoosterTheme1.Controls.Add(Me.WebBrowser16)
        Me.BoosterTheme1.Controls.Add(Me.WebBrowser15)
        Me.BoosterTheme1.Controls.Add(Me.WebBrowser14)
        Me.BoosterTheme1.Controls.Add(Me.WebBrowser13)
        Me.BoosterTheme1.Controls.Add(Me.WebBrowser12)
        Me.BoosterTheme1.Controls.Add(Me.WebBrowser11)
        Me.BoosterTheme1.Controls.Add(Me.WebBrowser10)
        Me.BoosterTheme1.Controls.Add(Me.WebBrowser9)
        Me.BoosterTheme1.Controls.Add(Me.WebBrowser8)
        Me.BoosterTheme1.Controls.Add(Me.WebBrowser7)
        Me.BoosterTheme1.Controls.Add(Me.WebBrowser6)
        Me.BoosterTheme1.Controls.Add(Me.WebBrowser5)
        Me.BoosterTheme1.Controls.Add(Me.WebBrowser4)
        Me.BoosterTheme1.Controls.Add(Me.WebBrowser3)
        Me.BoosterTheme1.Controls.Add(Me.WebBrowser2)
        Me.BoosterTheme1.Controls.Add(Me.WebBrowser1)
        Me.BoosterTheme1.Controls.Add(Me.Logado)
        Me.BoosterTheme1.Controls.Add(Me.Comando)
        Me.BoosterTheme1.Controls.Add(Me.Minimizar)
        Me.BoosterTheme1.Controls.Add(Me.Fechar)
        Me.BoosterTheme1.Controls.Add(Me.LogInTabControl1)
        Me.BoosterTheme1.Customization = ""
        Me.BoosterTheme1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BoosterTheme1.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.BoosterTheme1.Image = Nothing
        Me.BoosterTheme1.Location = New System.Drawing.Point(0, 0)
        Me.BoosterTheme1.Movable = True
        Me.BoosterTheme1.Name = "BoosterTheme1"
        Me.BoosterTheme1.NoRounding = False
        Me.BoosterTheme1.Sizable = False
        Me.BoosterTheme1.Size = New System.Drawing.Size(768, 360)
        Me.BoosterTheme1.SmartBounds = True
        Me.BoosterTheme1.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.BoosterTheme1.TabIndex = 0
        Me.BoosterTheme1.Text = "HardBooter v0.8b ~ The revolution of DDoS  (Made by 1n0c3nt and Unkn0wnBL4CK)"
        Me.BoosterTheme1.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.BoosterTheme1.Transparent = False
        '
        'Admin
        '
        Me.Admin.Location = New System.Drawing.Point(0, 0)
        Me.Admin.MinimumSize = New System.Drawing.Size(20, 20)
        Me.Admin.Name = "Admin"
        Me.Admin.ScriptErrorsSuppressed = True
        Me.Admin.ScrollBarsEnabled = False
        Me.Admin.Size = New System.Drawing.Size(20, 20)
        Me.Admin.TabIndex = 78
        Me.Admin.Visible = False
        '
        'Chat
        '
        Me.Chat.Location = New System.Drawing.Point(0, 0)
        Me.Chat.MinimumSize = New System.Drawing.Size(20, 20)
        Me.Chat.Name = "Chat"
        Me.Chat.ScriptErrorsSuppressed = True
        Me.Chat.ScrollBarsEnabled = False
        Me.Chat.Size = New System.Drawing.Size(20, 20)
        Me.Chat.TabIndex = 69
        Me.Chat.Url = New System.Uri("CHAT AQUI", System.UriKind.Relative)
        Me.Chat.Visible = False
        '
        'WebBrowser40
        '
        Me.WebBrowser40.Location = New System.Drawing.Point(0, 0)
        Me.WebBrowser40.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser40.Name = "WebBrowser40"
        Me.WebBrowser40.ScriptErrorsSuppressed = True
        Me.WebBrowser40.ScrollBarsEnabled = False
        Me.WebBrowser40.Size = New System.Drawing.Size(20, 20)
        Me.WebBrowser40.TabIndex = 68
        Me.WebBrowser40.Visible = False
        '
        'WebBrowser39
        '
        Me.WebBrowser39.Location = New System.Drawing.Point(0, 0)
        Me.WebBrowser39.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser39.Name = "WebBrowser39"
        Me.WebBrowser39.ScriptErrorsSuppressed = True
        Me.WebBrowser39.ScrollBarsEnabled = False
        Me.WebBrowser39.Size = New System.Drawing.Size(20, 20)
        Me.WebBrowser39.TabIndex = 67
        Me.WebBrowser39.Visible = False
        '
        'WebBrowser38
        '
        Me.WebBrowser38.Location = New System.Drawing.Point(0, 0)
        Me.WebBrowser38.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser38.Name = "WebBrowser38"
        Me.WebBrowser38.ScriptErrorsSuppressed = True
        Me.WebBrowser38.ScrollBarsEnabled = False
        Me.WebBrowser38.Size = New System.Drawing.Size(20, 20)
        Me.WebBrowser38.TabIndex = 66
        Me.WebBrowser38.Visible = False
        '
        'WebBrowser37
        '
        Me.WebBrowser37.Location = New System.Drawing.Point(0, 0)
        Me.WebBrowser37.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser37.Name = "WebBrowser37"
        Me.WebBrowser37.ScriptErrorsSuppressed = True
        Me.WebBrowser37.ScrollBarsEnabled = False
        Me.WebBrowser37.Size = New System.Drawing.Size(20, 20)
        Me.WebBrowser37.TabIndex = 65
        Me.WebBrowser37.Visible = False
        '
        'WebBrowser36
        '
        Me.WebBrowser36.Location = New System.Drawing.Point(0, 0)
        Me.WebBrowser36.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser36.Name = "WebBrowser36"
        Me.WebBrowser36.ScriptErrorsSuppressed = True
        Me.WebBrowser36.ScrollBarsEnabled = False
        Me.WebBrowser36.Size = New System.Drawing.Size(20, 20)
        Me.WebBrowser36.TabIndex = 64
        Me.WebBrowser36.Visible = False
        '
        'WebBrowser35
        '
        Me.WebBrowser35.Location = New System.Drawing.Point(0, 0)
        Me.WebBrowser35.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser35.Name = "WebBrowser35"
        Me.WebBrowser35.ScriptErrorsSuppressed = True
        Me.WebBrowser35.ScrollBarsEnabled = False
        Me.WebBrowser35.Size = New System.Drawing.Size(20, 20)
        Me.WebBrowser35.TabIndex = 63
        Me.WebBrowser35.Visible = False
        '
        'WebBrowser34
        '
        Me.WebBrowser34.Location = New System.Drawing.Point(0, 0)
        Me.WebBrowser34.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser34.Name = "WebBrowser34"
        Me.WebBrowser34.ScriptErrorsSuppressed = True
        Me.WebBrowser34.ScrollBarsEnabled = False
        Me.WebBrowser34.Size = New System.Drawing.Size(20, 20)
        Me.WebBrowser34.TabIndex = 62
        Me.WebBrowser34.Visible = False
        '
        'WebBrowser33
        '
        Me.WebBrowser33.Location = New System.Drawing.Point(0, 0)
        Me.WebBrowser33.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser33.Name = "WebBrowser33"
        Me.WebBrowser33.ScriptErrorsSuppressed = True
        Me.WebBrowser33.ScrollBarsEnabled = False
        Me.WebBrowser33.Size = New System.Drawing.Size(20, 20)
        Me.WebBrowser33.TabIndex = 61
        Me.WebBrowser33.Visible = False
        '
        'WebBrowser32
        '
        Me.WebBrowser32.Location = New System.Drawing.Point(0, 0)
        Me.WebBrowser32.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser32.Name = "WebBrowser32"
        Me.WebBrowser32.ScriptErrorsSuppressed = True
        Me.WebBrowser32.ScrollBarsEnabled = False
        Me.WebBrowser32.Size = New System.Drawing.Size(20, 20)
        Me.WebBrowser32.TabIndex = 60
        Me.WebBrowser32.Visible = False
        '
        'WebBrowser31
        '
        Me.WebBrowser31.Location = New System.Drawing.Point(0, 0)
        Me.WebBrowser31.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser31.Name = "WebBrowser31"
        Me.WebBrowser31.ScriptErrorsSuppressed = True
        Me.WebBrowser31.ScrollBarsEnabled = False
        Me.WebBrowser31.Size = New System.Drawing.Size(20, 20)
        Me.WebBrowser31.TabIndex = 59
        Me.WebBrowser31.Visible = False
        '
        'WebBrowser30
        '
        Me.WebBrowser30.Location = New System.Drawing.Point(0, 0)
        Me.WebBrowser30.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser30.Name = "WebBrowser30"
        Me.WebBrowser30.ScriptErrorsSuppressed = True
        Me.WebBrowser30.ScrollBarsEnabled = False
        Me.WebBrowser30.Size = New System.Drawing.Size(20, 20)
        Me.WebBrowser30.TabIndex = 58
        Me.WebBrowser30.Visible = False
        '
        'WebBrowser29
        '
        Me.WebBrowser29.Location = New System.Drawing.Point(0, 0)
        Me.WebBrowser29.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser29.Name = "WebBrowser29"
        Me.WebBrowser29.ScriptErrorsSuppressed = True
        Me.WebBrowser29.ScrollBarsEnabled = False
        Me.WebBrowser29.Size = New System.Drawing.Size(20, 20)
        Me.WebBrowser29.TabIndex = 57
        Me.WebBrowser29.Visible = False
        '
        'WebBrowser28
        '
        Me.WebBrowser28.Location = New System.Drawing.Point(0, 0)
        Me.WebBrowser28.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser28.Name = "WebBrowser28"
        Me.WebBrowser28.ScriptErrorsSuppressed = True
        Me.WebBrowser28.ScrollBarsEnabled = False
        Me.WebBrowser28.Size = New System.Drawing.Size(20, 20)
        Me.WebBrowser28.TabIndex = 56
        Me.WebBrowser28.Visible = False
        '
        'WebBrowser27
        '
        Me.WebBrowser27.Location = New System.Drawing.Point(0, 0)
        Me.WebBrowser27.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser27.Name = "WebBrowser27"
        Me.WebBrowser27.ScriptErrorsSuppressed = True
        Me.WebBrowser27.ScrollBarsEnabled = False
        Me.WebBrowser27.Size = New System.Drawing.Size(20, 20)
        Me.WebBrowser27.TabIndex = 55
        Me.WebBrowser27.Visible = False
        '
        'WebBrowser26
        '
        Me.WebBrowser26.Location = New System.Drawing.Point(0, 0)
        Me.WebBrowser26.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser26.Name = "WebBrowser26"
        Me.WebBrowser26.ScriptErrorsSuppressed = True
        Me.WebBrowser26.ScrollBarsEnabled = False
        Me.WebBrowser26.Size = New System.Drawing.Size(20, 20)
        Me.WebBrowser26.TabIndex = 54
        Me.WebBrowser26.Visible = False
        '
        'WebBrowser25
        '
        Me.WebBrowser25.Location = New System.Drawing.Point(0, 0)
        Me.WebBrowser25.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser25.Name = "WebBrowser25"
        Me.WebBrowser25.ScriptErrorsSuppressed = True
        Me.WebBrowser25.ScrollBarsEnabled = False
        Me.WebBrowser25.Size = New System.Drawing.Size(20, 20)
        Me.WebBrowser25.TabIndex = 53
        Me.WebBrowser25.Visible = False
        '
        'WebBrowser24
        '
        Me.WebBrowser24.Location = New System.Drawing.Point(0, 0)
        Me.WebBrowser24.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser24.Name = "WebBrowser24"
        Me.WebBrowser24.ScriptErrorsSuppressed = True
        Me.WebBrowser24.ScrollBarsEnabled = False
        Me.WebBrowser24.Size = New System.Drawing.Size(20, 20)
        Me.WebBrowser24.TabIndex = 52
        Me.WebBrowser24.Visible = False
        '
        'WebBrowser23
        '
        Me.WebBrowser23.Location = New System.Drawing.Point(0, 0)
        Me.WebBrowser23.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser23.Name = "WebBrowser23"
        Me.WebBrowser23.ScriptErrorsSuppressed = True
        Me.WebBrowser23.ScrollBarsEnabled = False
        Me.WebBrowser23.Size = New System.Drawing.Size(20, 20)
        Me.WebBrowser23.TabIndex = 51
        Me.WebBrowser23.Visible = False
        '
        'WebBrowser22
        '
        Me.WebBrowser22.Location = New System.Drawing.Point(0, 0)
        Me.WebBrowser22.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser22.Name = "WebBrowser22"
        Me.WebBrowser22.ScriptErrorsSuppressed = True
        Me.WebBrowser22.ScrollBarsEnabled = False
        Me.WebBrowser22.Size = New System.Drawing.Size(20, 20)
        Me.WebBrowser22.TabIndex = 50
        Me.WebBrowser22.Visible = False
        '
        'WebBrowser21
        '
        Me.WebBrowser21.Location = New System.Drawing.Point(0, 0)
        Me.WebBrowser21.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser21.Name = "WebBrowser21"
        Me.WebBrowser21.ScriptErrorsSuppressed = True
        Me.WebBrowser21.ScrollBarsEnabled = False
        Me.WebBrowser21.Size = New System.Drawing.Size(20, 20)
        Me.WebBrowser21.TabIndex = 49
        Me.WebBrowser21.Visible = False
        '
        'WebBrowser20
        '
        Me.WebBrowser20.Location = New System.Drawing.Point(0, 0)
        Me.WebBrowser20.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser20.Name = "WebBrowser20"
        Me.WebBrowser20.ScriptErrorsSuppressed = True
        Me.WebBrowser20.ScrollBarsEnabled = False
        Me.WebBrowser20.Size = New System.Drawing.Size(20, 20)
        Me.WebBrowser20.TabIndex = 48
        Me.WebBrowser20.Visible = False
        '
        'WebBrowser19
        '
        Me.WebBrowser19.Location = New System.Drawing.Point(0, 0)
        Me.WebBrowser19.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser19.Name = "WebBrowser19"
        Me.WebBrowser19.ScriptErrorsSuppressed = True
        Me.WebBrowser19.ScrollBarsEnabled = False
        Me.WebBrowser19.Size = New System.Drawing.Size(20, 20)
        Me.WebBrowser19.TabIndex = 47
        Me.WebBrowser19.Visible = False
        '
        'WebBrowser18
        '
        Me.WebBrowser18.Location = New System.Drawing.Point(0, 0)
        Me.WebBrowser18.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser18.Name = "WebBrowser18"
        Me.WebBrowser18.ScriptErrorsSuppressed = True
        Me.WebBrowser18.ScrollBarsEnabled = False
        Me.WebBrowser18.Size = New System.Drawing.Size(20, 20)
        Me.WebBrowser18.TabIndex = 46
        Me.WebBrowser18.Visible = False
        '
        'WebBrowser17
        '
        Me.WebBrowser17.Location = New System.Drawing.Point(0, 0)
        Me.WebBrowser17.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser17.Name = "WebBrowser17"
        Me.WebBrowser17.ScriptErrorsSuppressed = True
        Me.WebBrowser17.ScrollBarsEnabled = False
        Me.WebBrowser17.Size = New System.Drawing.Size(20, 20)
        Me.WebBrowser17.TabIndex = 45
        Me.WebBrowser17.Visible = False
        '
        'WebBrowser16
        '
        Me.WebBrowser16.Location = New System.Drawing.Point(0, 0)
        Me.WebBrowser16.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser16.Name = "WebBrowser16"
        Me.WebBrowser16.ScriptErrorsSuppressed = True
        Me.WebBrowser16.ScrollBarsEnabled = False
        Me.WebBrowser16.Size = New System.Drawing.Size(20, 20)
        Me.WebBrowser16.TabIndex = 44
        Me.WebBrowser16.Visible = False
        '
        'WebBrowser15
        '
        Me.WebBrowser15.Location = New System.Drawing.Point(0, 0)
        Me.WebBrowser15.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser15.Name = "WebBrowser15"
        Me.WebBrowser15.ScriptErrorsSuppressed = True
        Me.WebBrowser15.ScrollBarsEnabled = False
        Me.WebBrowser15.Size = New System.Drawing.Size(20, 20)
        Me.WebBrowser15.TabIndex = 43
        Me.WebBrowser15.Visible = False
        '
        'WebBrowser14
        '
        Me.WebBrowser14.Location = New System.Drawing.Point(0, 0)
        Me.WebBrowser14.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser14.Name = "WebBrowser14"
        Me.WebBrowser14.ScriptErrorsSuppressed = True
        Me.WebBrowser14.ScrollBarsEnabled = False
        Me.WebBrowser14.Size = New System.Drawing.Size(20, 20)
        Me.WebBrowser14.TabIndex = 42
        Me.WebBrowser14.Visible = False
        '
        'WebBrowser13
        '
        Me.WebBrowser13.Location = New System.Drawing.Point(0, 0)
        Me.WebBrowser13.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser13.Name = "WebBrowser13"
        Me.WebBrowser13.ScriptErrorsSuppressed = True
        Me.WebBrowser13.ScrollBarsEnabled = False
        Me.WebBrowser13.Size = New System.Drawing.Size(20, 20)
        Me.WebBrowser13.TabIndex = 41
        Me.WebBrowser13.Visible = False
        '
        'WebBrowser12
        '
        Me.WebBrowser12.Location = New System.Drawing.Point(0, 0)
        Me.WebBrowser12.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser12.Name = "WebBrowser12"
        Me.WebBrowser12.ScriptErrorsSuppressed = True
        Me.WebBrowser12.ScrollBarsEnabled = False
        Me.WebBrowser12.Size = New System.Drawing.Size(20, 20)
        Me.WebBrowser12.TabIndex = 40
        Me.WebBrowser12.Visible = False
        '
        'WebBrowser11
        '
        Me.WebBrowser11.Location = New System.Drawing.Point(0, 0)
        Me.WebBrowser11.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser11.Name = "WebBrowser11"
        Me.WebBrowser11.ScriptErrorsSuppressed = True
        Me.WebBrowser11.ScrollBarsEnabled = False
        Me.WebBrowser11.Size = New System.Drawing.Size(20, 20)
        Me.WebBrowser11.TabIndex = 39
        Me.WebBrowser11.Visible = False
        '
        'WebBrowser10
        '
        Me.WebBrowser10.Location = New System.Drawing.Point(0, 0)
        Me.WebBrowser10.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser10.Name = "WebBrowser10"
        Me.WebBrowser10.ScriptErrorsSuppressed = True
        Me.WebBrowser10.ScrollBarsEnabled = False
        Me.WebBrowser10.Size = New System.Drawing.Size(20, 20)
        Me.WebBrowser10.TabIndex = 38
        Me.WebBrowser10.Visible = False
        '
        'WebBrowser9
        '
        Me.WebBrowser9.Location = New System.Drawing.Point(0, 0)
        Me.WebBrowser9.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser9.Name = "WebBrowser9"
        Me.WebBrowser9.ScriptErrorsSuppressed = True
        Me.WebBrowser9.ScrollBarsEnabled = False
        Me.WebBrowser9.Size = New System.Drawing.Size(20, 20)
        Me.WebBrowser9.TabIndex = 37
        Me.WebBrowser9.Visible = False
        '
        'WebBrowser8
        '
        Me.WebBrowser8.Location = New System.Drawing.Point(0, 0)
        Me.WebBrowser8.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser8.Name = "WebBrowser8"
        Me.WebBrowser8.ScriptErrorsSuppressed = True
        Me.WebBrowser8.ScrollBarsEnabled = False
        Me.WebBrowser8.Size = New System.Drawing.Size(20, 20)
        Me.WebBrowser8.TabIndex = 36
        Me.WebBrowser8.Visible = False
        '
        'WebBrowser7
        '
        Me.WebBrowser7.Location = New System.Drawing.Point(0, 0)
        Me.WebBrowser7.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser7.Name = "WebBrowser7"
        Me.WebBrowser7.ScriptErrorsSuppressed = True
        Me.WebBrowser7.ScrollBarsEnabled = False
        Me.WebBrowser7.Size = New System.Drawing.Size(20, 20)
        Me.WebBrowser7.TabIndex = 35
        Me.WebBrowser7.Visible = False
        '
        'WebBrowser6
        '
        Me.WebBrowser6.Location = New System.Drawing.Point(0, 0)
        Me.WebBrowser6.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser6.Name = "WebBrowser6"
        Me.WebBrowser6.ScriptErrorsSuppressed = True
        Me.WebBrowser6.ScrollBarsEnabled = False
        Me.WebBrowser6.Size = New System.Drawing.Size(20, 20)
        Me.WebBrowser6.TabIndex = 34
        Me.WebBrowser6.Visible = False
        '
        'WebBrowser5
        '
        Me.WebBrowser5.Location = New System.Drawing.Point(0, 0)
        Me.WebBrowser5.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser5.Name = "WebBrowser5"
        Me.WebBrowser5.ScriptErrorsSuppressed = True
        Me.WebBrowser5.ScrollBarsEnabled = False
        Me.WebBrowser5.Size = New System.Drawing.Size(20, 20)
        Me.WebBrowser5.TabIndex = 33
        Me.WebBrowser5.Visible = False
        '
        'WebBrowser4
        '
        Me.WebBrowser4.Location = New System.Drawing.Point(0, 0)
        Me.WebBrowser4.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser4.Name = "WebBrowser4"
        Me.WebBrowser4.ScriptErrorsSuppressed = True
        Me.WebBrowser4.ScrollBarsEnabled = False
        Me.WebBrowser4.Size = New System.Drawing.Size(20, 20)
        Me.WebBrowser4.TabIndex = 32
        Me.WebBrowser4.Visible = False
        '
        'WebBrowser3
        '
        Me.WebBrowser3.Location = New System.Drawing.Point(0, 0)
        Me.WebBrowser3.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser3.Name = "WebBrowser3"
        Me.WebBrowser3.ScriptErrorsSuppressed = True
        Me.WebBrowser3.ScrollBarsEnabled = False
        Me.WebBrowser3.Size = New System.Drawing.Size(20, 20)
        Me.WebBrowser3.TabIndex = 31
        Me.WebBrowser3.Visible = False
        '
        'WebBrowser2
        '
        Me.WebBrowser2.Location = New System.Drawing.Point(0, 0)
        Me.WebBrowser2.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser2.Name = "WebBrowser2"
        Me.WebBrowser2.ScriptErrorsSuppressed = True
        Me.WebBrowser2.ScrollBarsEnabled = False
        Me.WebBrowser2.Size = New System.Drawing.Size(20, 20)
        Me.WebBrowser2.TabIndex = 30
        Me.WebBrowser2.Visible = False
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Location = New System.Drawing.Point(0, 0)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.ScriptErrorsSuppressed = True
        Me.WebBrowser1.ScrollBarsEnabled = False
        Me.WebBrowser1.Size = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.TabIndex = 29
        Me.WebBrowser1.Visible = False
        '
        'Logado
        '
        Me.Logado.BackColor = System.Drawing.Color.Transparent
        Me.Logado.Font = New System.Drawing.Font("Arial", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Logado.ForeColor = System.Drawing.Color.Cyan
        Me.Logado.Location = New System.Drawing.Point(3, 33)
        Me.Logado.Name = "Logado"
        Me.Logado.Size = New System.Drawing.Size(758, 15)
        Me.Logado.TabIndex = 27
        Me.Logado.Text = "~ Logado como:  ~"
        Me.Logado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Comando
        '
        Me.Comando.Alignment = Hard_Booter.LogInStatusBar.Alignments.Left
        Me.Comando.BaseColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.Comando.BorderColour = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.Comando.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Comando.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Comando.ForeColor = System.Drawing.Color.White
        Me.Comando.LinesToShow = Hard_Booter.LogInStatusBar.LinesCount.One
        Me.Comando.Location = New System.Drawing.Point(0, 337)
        Me.Comando.Name = "Comando"
        Me.Comando.RectangleColor = System.Drawing.Color.Cyan
        Me.Comando.ShowBorder = True
        Me.Comando.ShowLine = True
        Me.Comando.Size = New System.Drawing.Size(768, 23)
        Me.Comando.TabIndex = 25
        Me.Comando.Text = "Aguardando comandos.."
        Me.Comando.TextColour = System.Drawing.Color.White
        '
        'Minimizar
        '
        Me.Minimizar.BackColor = System.Drawing.Color.Transparent
        Me.Minimizar.Colors = New Hard_Booter.Bloom(-1) {}
        Me.Minimizar.Customization = ""
        Me.Minimizar.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.Minimizar.Image = Nothing
        Me.Minimizar.Location = New System.Drawing.Point(673, 0)
        Me.Minimizar.Name = "Minimizar"
        Me.Minimizar.NoRounding = False
        Me.Minimizar.Size = New System.Drawing.Size(40, 23)
        Me.Minimizar.TabIndex = 24
        Me.Minimizar.Text = "-"
        Me.Minimizar.Transparent = True
        '
        'Fechar
        '
        Me.Fechar.BackColor = System.Drawing.Color.Transparent
        Me.Fechar.Colors = New Hard_Booter.Bloom(-1) {}
        Me.Fechar.Customization = ""
        Me.Fechar.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.Fechar.Image = Nothing
        Me.Fechar.Location = New System.Drawing.Point(712, 0)
        Me.Fechar.Name = "Fechar"
        Me.Fechar.NoRounding = False
        Me.Fechar.Size = New System.Drawing.Size(56, 23)
        Me.Fechar.TabIndex = 23
        Me.Fechar.Text = "X"
        Me.Fechar.Transparent = True
        '
        'LogInTabControl1
        '
        Me.LogInTabControl1.ActiveColour = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.LogInTabControl1.BackTabColour = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.LogInTabControl1.BaseColour = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.LogInTabControl1.BorderColour = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.LogInTabControl1.Controls.Add(Me.TabPage1)
        Me.LogInTabControl1.Controls.Add(Me.TabPage2)
        Me.LogInTabControl1.Controls.Add(Me.TabPage3)
        Me.LogInTabControl1.Controls.Add(Me.TabPage4)
        Me.LogInTabControl1.Controls.Add(Me.TabPage5)
        Me.LogInTabControl1.Controls.Add(Me.TabPage6)
        Me.LogInTabControl1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.LogInTabControl1.HorizontalLineColour = System.Drawing.Color.Aqua
        Me.LogInTabControl1.ItemSize = New System.Drawing.Size(240, 32)
        Me.LogInTabControl1.Location = New System.Drawing.Point(3, 56)
        Me.LogInTabControl1.Name = "LogInTabControl1"
        Me.LogInTabControl1.SelectedIndex = 0
        Me.LogInTabControl1.Size = New System.Drawing.Size(762, 279)
        Me.LogInTabControl1.TabIndex = 0
        Me.LogInTabControl1.TextColour = System.Drawing.Color.White
        Me.LogInTabControl1.UpLineColour = System.Drawing.Color.Aqua
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.TabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TabPage1.Controls.Add(Me.DiasVIP)
        Me.TabPage1.Controls.Add(Me.BemV)
        Me.TabPage1.Location = New System.Drawing.Point(4, 36)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(754, 239)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Bem-Vindo(a)"
        '
        'DiasVIP
        '
        Me.DiasVIP.BackColor = System.Drawing.Color.Transparent
        Me.DiasVIP.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DiasVIP.ForeColor = System.Drawing.Color.Cyan
        Me.DiasVIP.Location = New System.Drawing.Point(6, 109)
        Me.DiasVIP.Name = "DiasVIP"
        Me.DiasVIP.Size = New System.Drawing.Size(740, 37)
        Me.DiasVIP.TabIndex = 1
        Me.DiasVIP.Text = "Dias VIP Restantes: ?"
        Me.DiasVIP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BemV
        '
        Me.BemV.BackColor = System.Drawing.Color.Transparent
        Me.BemV.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BemV.ForeColor = System.Drawing.Color.White
        Me.BemV.Location = New System.Drawing.Point(6, 71)
        Me.BemV.Name = "BemV"
        Me.BemV.Size = New System.Drawing.Size(740, 39)
        Me.BemV.TabIndex = 0
        Me.BemV.Text = "~ Seja Bem Vindo(a) Ao HardBooter Nick ~"
        Me.BemV.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.TabPage2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TabPage2.Controls.Add(Me.PictureBox1)
        Me.TabPage2.Controls.Add(Me.Panel1)
        Me.TabPage2.Controls.Add(Me.BossterMixedButton3)
        Me.TabPage2.Controls.Add(Me.BossterMixedButton2)
        Me.TabPage2.Controls.Add(Me.Atacar)
        Me.TabPage2.Controls.Add(Me.PararAtaque)
        Me.TabPage2.Location = New System.Drawing.Point(4, 36)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(754, 239)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Attack Hub"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(36, 126)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(120, 91)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 39
        Me.PictureBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Tempo)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.LogInComboBox1)
        Me.Panel1.Controls.Add(Me.taimi)
        Me.Panel1.Controls.Add(Me.IP)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.PORTA)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(177, 31)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(541, 178)
        Me.Panel1.TabIndex = 34
        '
        'Tempo
        '
        Me.Tempo.AutoSize = True
        Me.Tempo.Location = New System.Drawing.Point(481, 84)
        Me.Tempo.Name = "Tempo"
        Me.Tempo.Size = New System.Drawing.Size(0, 19)
        Me.Tempo.TabIndex = 36
        Me.Tempo.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(150, 122)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 19)
        Me.Label4.TabIndex = 35
        Me.Label4.Text = "Method:"
        '
        'LogInComboBox1
        '
        Me.LogInComboBox1.ArrowColour = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.LogInComboBox1.BackColor = System.Drawing.Color.Transparent
        Me.LogInComboBox1.BaseColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.LogInComboBox1.BorderColour = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.LogInComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.LogInComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.LogInComboBox1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.LogInComboBox1.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LogInComboBox1.FormattingEnabled = True
        Me.LogInComboBox1.Items.AddRange(New Object() {"UDP Amplification"})
        Me.LogInComboBox1.LineColour = System.Drawing.Color.DarkViolet
        Me.LogInComboBox1.Location = New System.Drawing.Point(217, 120)
        Me.LogInComboBox1.Name = "LogInComboBox1"
        Me.LogInComboBox1.Size = New System.Drawing.Size(172, 26)
        Me.LogInComboBox1.SqaureColour = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.LogInComboBox1.SqaureHoverColour = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.LogInComboBox1.StartIndex = 0
        Me.LogInComboBox1.TabIndex = 34
        '
        'taimi
        '
        Me.taimi.BackColor = System.Drawing.Color.Transparent
        Me.taimi.BarBaseColour = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.taimi.BorderColour = System.Drawing.Color.Transparent
        Me.taimi.Location = New System.Drawing.Point(46, 88)
        Me.taimi.Maximum = 145
        Me.taimi.Name = "taimi"
        Me.taimi.Size = New System.Drawing.Size(447, 23)
        Me.taimi.StripAmountColour = System.Drawing.Color.DarkViolet
        Me.taimi.StripColour = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.taimi.TabIndex = 33
        Me.taimi.Text = "LogInTrackBar1"
        Me.taimi.TextColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.taimi.Value = 45
        '
        'IP
        '
        Me.IP.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.IP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.IP.ForeColor = System.Drawing.Color.White
        Me.IP.Location = New System.Drawing.Point(148, 36)
        Me.IP.Name = "IP"
        Me.IP.Size = New System.Drawing.Size(153, 25)
        Me.IP.TabIndex = 28
        Me.IP.Text = "0.0.0.0"
        Me.IP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(249, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 19)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "Time:"
        '
        'PORTA
        '
        Me.PORTA.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.PORTA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PORTA.ForeColor = System.Drawing.Color.White
        Me.PORTA.Location = New System.Drawing.Point(360, 36)
        Me.PORTA.Name = "PORTA"
        Me.PORTA.Size = New System.Drawing.Size(77, 25)
        Me.PORTA.TabIndex = 29
        Me.PORTA.Text = "80"
        Me.PORTA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(317, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 19)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "Port:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(101, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 19)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Host:"
        '
        'BossterMixedButton3
        '
        Me.BossterMixedButton3.BackColor = System.Drawing.Color.Transparent
        Me.BossterMixedButton3.Colors = New Hard_Booter.Bloom(-1) {}
        Me.BossterMixedButton3.Customization = ""
        Me.BossterMixedButton3.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.BossterMixedButton3.Image = Nothing
        Me.BossterMixedButton3.Location = New System.Drawing.Point(34, 87)
        Me.BossterMixedButton3.Name = "BossterMixedButton3"
        Me.BossterMixedButton3.NoRounding = False
        Me.BossterMixedButton3.Size = New System.Drawing.Size(125, 24)
        Me.BossterMixedButton3.TabIndex = 2
        Me.BossterMixedButton3.Text = "Ping"
        Me.BossterMixedButton3.Transparent = True
        '
        'BossterMixedButton2
        '
        Me.BossterMixedButton2.BackColor = System.Drawing.Color.Transparent
        Me.BossterMixedButton2.Colors = New Hard_Booter.Bloom(-1) {}
        Me.BossterMixedButton2.Customization = ""
        Me.BossterMixedButton2.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.BossterMixedButton2.Image = Nothing
        Me.BossterMixedButton2.Location = New System.Drawing.Point(34, 59)
        Me.BossterMixedButton2.Name = "BossterMixedButton2"
        Me.BossterMixedButton2.NoRounding = False
        Me.BossterMixedButton2.Size = New System.Drawing.Size(125, 24)
        Me.BossterMixedButton2.TabIndex = 1
        Me.BossterMixedButton2.Text = "Track"
        Me.BossterMixedButton2.Transparent = True
        '
        'Atacar
        '
        Me.Atacar.BackColor = System.Drawing.Color.Transparent
        Me.Atacar.Colors = New Hard_Booter.Bloom(-1) {}
        Me.Atacar.Customization = ""
        Me.Atacar.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.Atacar.Image = Nothing
        Me.Atacar.Location = New System.Drawing.Point(34, 31)
        Me.Atacar.Name = "Atacar"
        Me.Atacar.NoRounding = False
        Me.Atacar.Size = New System.Drawing.Size(125, 24)
        Me.Atacar.TabIndex = 0
        Me.Atacar.Text = "Boot Now"
        Me.Atacar.Transparent = True
        '
        'PararAtaque
        '
        Me.PararAtaque.BackColor = System.Drawing.Color.Transparent
        Me.PararAtaque.Colors = New Hard_Booter.Bloom(-1) {}
        Me.PararAtaque.Customization = ""
        Me.PararAtaque.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.PararAtaque.Image = Nothing
        Me.PararAtaque.Location = New System.Drawing.Point(34, 31)
        Me.PararAtaque.Name = "PararAtaque"
        Me.PararAtaque.NoRounding = False
        Me.PararAtaque.Size = New System.Drawing.Size(125, 24)
        Me.PararAtaque.TabIndex = 38
        Me.PararAtaque.Text = "Stop Boot"
        Me.PararAtaque.Transparent = True
        Me.PararAtaque.Visible = False
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.TabPage3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TabPage3.Controls.Add(Me.listResolverIP)
        Me.TabPage3.Controls.Add(Me.Label7)
        Me.TabPage3.Controls.Add(Me.Label6)
        Me.TabPage3.Controls.Add(Me.Label5)
        Me.TabPage3.Controls.Add(Me.NumArchPort)
        Me.TabPage3.Controls.Add(Me.cbArchMethod)
        Me.TabPage3.Controls.Add(Me.txtArchIP)
        Me.TabPage3.Controls.Add(Me.btnArchStart)
        Me.TabPage3.Controls.Add(Me.btnArchStop)
        Me.TabPage3.Location = New System.Drawing.Point(4, 36)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(754, 239)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Skype Sniffer"
        '
        'listResolverIP
        '
        Me.listResolverIP.ForeColor = System.Drawing.Color.White
        Me.listResolverIP.Location = New System.Drawing.Point(6, 210)
        Me.listResolverIP.Name = "listResolverIP"
        Me.listResolverIP.Size = New System.Drawing.Size(740, 19)
        Me.listResolverIP.TabIndex = 40
        Me.listResolverIP.Text = "Endereço IP:"
        Me.listResolverIP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(318, 115)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(117, 19)
        Me.Label7.TabIndex = 39
        Me.Label7.Text = "Network Adapter:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(338, 63)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(77, 19)
        Me.Label6.TabIndex = 38
        Me.Label6.Text = "Skype Port:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(327, 11)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(99, 19)
        Me.Label5.TabIndex = 37
        Me.Label5.Text = "Endereço IPv4:"
        '
        'NumArchPort
        '
        Me.NumArchPort.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.NumArchPort.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NumArchPort.ForeColor = System.Drawing.Color.White
        Me.NumArchPort.Location = New System.Drawing.Point(194, 85)
        Me.NumArchPort.Maximum = New Decimal(New Integer() {1316134911, 2328, 0, 0})
        Me.NumArchPort.Name = "NumArchPort"
        Me.NumArchPort.Size = New System.Drawing.Size(364, 25)
        Me.NumArchPort.TabIndex = 36
        Me.NumArchPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.NumArchPort.Value = New Decimal(New Integer() {6667, 0, 0, 0})
        '
        'cbArchMethod
        '
        Me.cbArchMethod.ArrowColour = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.cbArchMethod.BackColor = System.Drawing.Color.Transparent
        Me.cbArchMethod.BaseColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.cbArchMethod.BorderColour = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.cbArchMethod.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbArchMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbArchMethod.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cbArchMethod.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbArchMethod.FormattingEnabled = True
        Me.cbArchMethod.Items.AddRange(New Object() {"--Selecione um adaptador de rede--"})
        Me.cbArchMethod.LineColour = System.Drawing.Color.Cyan
        Me.cbArchMethod.Location = New System.Drawing.Point(194, 137)
        Me.cbArchMethod.Name = "cbArchMethod"
        Me.cbArchMethod.Size = New System.Drawing.Size(364, 26)
        Me.cbArchMethod.SqaureColour = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.cbArchMethod.SqaureHoverColour = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.cbArchMethod.StartIndex = 0
        Me.cbArchMethod.TabIndex = 35
        '
        'txtArchIP
        '
        Me.txtArchIP.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.txtArchIP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtArchIP.ForeColor = System.Drawing.Color.White
        Me.txtArchIP.Location = New System.Drawing.Point(194, 33)
        Me.txtArchIP.Name = "txtArchIP"
        Me.txtArchIP.Size = New System.Drawing.Size(364, 25)
        Me.txtArchIP.TabIndex = 29
        Me.txtArchIP.Text = "0.0.0.0"
        Me.txtArchIP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnArchStart
        '
        Me.btnArchStart.ArcColour = System.Drawing.Color.Empty
        Me.btnArchStart.ArrowBorderColour = System.Drawing.Color.Empty
        Me.btnArchStart.ArrowColour = System.Drawing.Color.Empty
        Me.btnArchStart.BackColor = System.Drawing.Color.Transparent
        Me.btnArchStart.BorderColour = System.Drawing.Color.Empty
        Me.btnArchStart.Colors = New Hard_Booter.Bloom(-1) {}
        Me.btnArchStart.Customization = ""
        Me.btnArchStart.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.btnArchStart.HoverColour = System.Drawing.Color.Empty
        Me.btnArchStart.Image = Nothing
        Me.btnArchStart.Location = New System.Drawing.Point(194, 169)
        Me.btnArchStart.Name = "btnArchStart"
        Me.btnArchStart.NormalColour = System.Drawing.Color.Empty
        Me.btnArchStart.NoRounding = False
        Me.btnArchStart.PressedColour = System.Drawing.Color.Empty
        Me.btnArchStart.Size = New System.Drawing.Size(364, 38)
        Me.btnArchStart.TabIndex = 0
        Me.btnArchStart.Text = "Começar Sniffer"
        Me.btnArchStart.Transparent = True
        '
        'btnArchStop
        '
        Me.btnArchStop.ArcColour = System.Drawing.Color.Empty
        Me.btnArchStop.ArrowBorderColour = System.Drawing.Color.Empty
        Me.btnArchStop.ArrowColour = System.Drawing.Color.Empty
        Me.btnArchStop.BackColor = System.Drawing.Color.Transparent
        Me.btnArchStop.BorderColour = System.Drawing.Color.Empty
        Me.btnArchStop.Colors = New Hard_Booter.Bloom(-1) {}
        Me.btnArchStop.Customization = ""
        Me.btnArchStop.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.btnArchStop.HoverColour = System.Drawing.Color.Empty
        Me.btnArchStop.Image = Nothing
        Me.btnArchStop.Location = New System.Drawing.Point(194, 169)
        Me.btnArchStop.Name = "btnArchStop"
        Me.btnArchStop.NormalColour = System.Drawing.Color.Empty
        Me.btnArchStop.NoRounding = False
        Me.btnArchStop.PressedColour = System.Drawing.Color.Empty
        Me.btnArchStop.Size = New System.Drawing.Size(364, 38)
        Me.btnArchStop.TabIndex = 1
        Me.btnArchStop.Text = "Parar Sniffer"
        Me.btnArchStop.Transparent = True
        Me.btnArchStop.Visible = False
        '
        'TabPage4
        '
        Me.TabPage4.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.TabPage4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TabPage4.Controls.Add(Me.BoosterButton2)
        Me.TabPage4.Controls.Add(Me.BoosterButton1)
        Me.TabPage4.Controls.Add(Me.Ipgeo)
        Me.TabPage4.Controls.Add(Me.geoinfo)
        Me.TabPage4.Location = New System.Drawing.Point(4, 36)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(754, 239)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "GeoIP"
        '
        'BoosterButton2
        '
        Me.BoosterButton2.ArcColour = System.Drawing.Color.Empty
        Me.BoosterButton2.ArrowBorderColour = System.Drawing.Color.Empty
        Me.BoosterButton2.ArrowColour = System.Drawing.Color.Empty
        Me.BoosterButton2.BackColor = System.Drawing.Color.Transparent
        Me.BoosterButton2.BorderColour = System.Drawing.Color.Empty
        Me.BoosterButton2.Colors = New Hard_Booter.Bloom(-1) {}
        Me.BoosterButton2.Customization = ""
        Me.BoosterButton2.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.BoosterButton2.HoverColour = System.Drawing.Color.Empty
        Me.BoosterButton2.Image = Nothing
        Me.BoosterButton2.Location = New System.Drawing.Point(563, 6)
        Me.BoosterButton2.Name = "BoosterButton2"
        Me.BoosterButton2.NormalColour = System.Drawing.Color.Empty
        Me.BoosterButton2.NoRounding = False
        Me.BoosterButton2.PressedColour = System.Drawing.Color.Empty
        Me.BoosterButton2.Size = New System.Drawing.Size(59, 25)
        Me.BoosterButton2.TabIndex = 32
        Me.BoosterButton2.Text = "Copy"
        Me.BoosterButton2.Transparent = True
        '
        'BoosterButton1
        '
        Me.BoosterButton1.ArcColour = System.Drawing.Color.Empty
        Me.BoosterButton1.ArrowBorderColour = System.Drawing.Color.Empty
        Me.BoosterButton1.ArrowColour = System.Drawing.Color.Empty
        Me.BoosterButton1.BackColor = System.Drawing.Color.Transparent
        Me.BoosterButton1.BorderColour = System.Drawing.Color.Empty
        Me.BoosterButton1.Colors = New Hard_Booter.Bloom(-1) {}
        Me.BoosterButton1.Customization = ""
        Me.BoosterButton1.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.BoosterButton1.HoverColour = System.Drawing.Color.Empty
        Me.BoosterButton1.Image = Nothing
        Me.BoosterButton1.Location = New System.Drawing.Point(628, 6)
        Me.BoosterButton1.Name = "BoosterButton1"
        Me.BoosterButton1.NormalColour = System.Drawing.Color.Empty
        Me.BoosterButton1.NoRounding = False
        Me.BoosterButton1.PressedColour = System.Drawing.Color.Empty
        Me.BoosterButton1.Size = New System.Drawing.Size(118, 25)
        Me.BoosterButton1.TabIndex = 31
        Me.BoosterButton1.Text = "Get Information"
        Me.BoosterButton1.Transparent = True
        '
        'Ipgeo
        '
        Me.Ipgeo.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.Ipgeo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Ipgeo.ForeColor = System.Drawing.Color.White
        Me.Ipgeo.Location = New System.Drawing.Point(6, 6)
        Me.Ipgeo.Name = "Ipgeo"
        Me.Ipgeo.Size = New System.Drawing.Size(551, 25)
        Me.Ipgeo.TabIndex = 30
        Me.Ipgeo.Text = "0.0.0.0"
        Me.Ipgeo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'geoinfo
        '
        Me.geoinfo.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.geoinfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.geoinfo.ForeColor = System.Drawing.Color.White
        Me.geoinfo.Location = New System.Drawing.Point(6, 37)
        Me.geoinfo.Multiline = True
        Me.geoinfo.Name = "geoinfo"
        Me.geoinfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.geoinfo.Size = New System.Drawing.Size(740, 194)
        Me.geoinfo.TabIndex = 29
        Me.geoinfo.Text = resources.GetString("geoinfo.Text")
        Me.geoinfo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TabPage5
        '
        Me.TabPage5.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.TabPage5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TabPage5.Controls.Add(Me.Mensagem)
        Me.TabPage5.Controls.Add(Me.BoosterRedButton1)
        Me.TabPage5.Controls.Add(Me.chaty)
        Me.TabPage5.Location = New System.Drawing.Point(4, 36)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(754, 239)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "Chat"
        '
        'Mensagem
        '
        Me.Mensagem.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.Mensagem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Mensagem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.Mensagem.Location = New System.Drawing.Point(6, 206)
        Me.Mensagem.Name = "Mensagem"
        Me.Mensagem.Size = New System.Drawing.Size(653, 25)
        Me.Mensagem.TabIndex = 33
        Me.Mensagem.Text = "Type your message here..."
        '
        'BoosterRedButton1
        '
        Me.BoosterRedButton1.BackColor = System.Drawing.Color.Transparent
        Me.BoosterRedButton1.Colors = New Hard_Booter.Bloom(-1) {}
        Me.BoosterRedButton1.Customization = ""
        Me.BoosterRedButton1.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.BoosterRedButton1.Image = Nothing
        Me.BoosterRedButton1.Location = New System.Drawing.Point(665, 206)
        Me.BoosterRedButton1.Name = "BoosterRedButton1"
        Me.BoosterRedButton1.NoRounding = False
        Me.BoosterRedButton1.Size = New System.Drawing.Size(81, 25)
        Me.BoosterRedButton1.TabIndex = 32
        Me.BoosterRedButton1.Text = "Send >"
        Me.BoosterRedButton1.Transparent = True
        '
        'chaty
        '
        Me.chaty.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.chaty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.chaty.ForeColor = System.Drawing.Color.Cyan
        Me.chaty.Location = New System.Drawing.Point(6, 6)
        Me.chaty.Multiline = True
        Me.chaty.Name = "chaty"
        Me.chaty.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.chaty.Size = New System.Drawing.Size(740, 194)
        Me.chaty.TabIndex = 29
        Me.chaty.Text = "~ HardBooter Chat ~"
        '
        'TabPage6
        '
        Me.TabPage6.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.TabPage6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TabPage6.Controls.Add(Me.AdminPanel)
        Me.TabPage6.Controls.Add(Me.PictureBox4)
        Me.TabPage6.Controls.Add(Me.Panel2)
        Me.TabPage6.Location = New System.Drawing.Point(4, 36)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage6.Size = New System.Drawing.Size(754, 239)
        Me.TabPage6.TabIndex = 5
        Me.TabPage6.Text = "Painel Admin"
        '
        'AdminPanel
        '
        Me.AdminPanel.Controls.Add(Me.respostaadmin)
        Me.AdminPanel.Controls.Add(Me.Label10)
        Me.AdminPanel.Controls.Add(Me.BoosterControlpanel1)
        Me.AdminPanel.Controls.Add(Me.BoosterControlpanel2)
        Me.AdminPanel.Enabled = False
        Me.AdminPanel.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.AdminPanel.Location = New System.Drawing.Point(6, 6)
        Me.AdminPanel.Name = "AdminPanel"
        Me.AdminPanel.Size = New System.Drawing.Size(740, 225)
        Me.AdminPanel.TabIndex = 76
        Me.AdminPanel.Visible = False
        '
        'respostaadmin
        '
        Me.respostaadmin.AutoSize = True
        Me.respostaadmin.Location = New System.Drawing.Point(725, -4)
        Me.respostaadmin.Name = "respostaadmin"
        Me.respostaadmin.Size = New System.Drawing.Size(18, 19)
        Me.respostaadmin.TabIndex = 77
        Me.respostaadmin.Text = "..."
        Me.respostaadmin.Visible = False
        '
        'Label10
        '
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(3, 1)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(734, 21)
        Me.Label10.TabIndex = 70
        Me.Label10.Text = "~ Painel admininstrativo do HardBooter, Seja bem-vindo Nick ~"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BoosterControlpanel1
        '
        Me.BoosterControlpanel1.BackColor = System.Drawing.Color.Transparent
        Me.BoosterControlpanel1.BorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.BoosterControlpanel1.Colors = New Hard_Booter.Bloom(-1) {}
        Me.BoosterControlpanel1.Controls.Add(Me.Label12)
        Me.BoosterControlpanel1.Controls.Add(Me.BoosterButton4)
        Me.BoosterControlpanel1.Controls.Add(Me.logCreatePass)
        Me.BoosterControlpanel1.Controls.Add(Me.logCreate)
        Me.BoosterControlpanel1.Customization = ""
        Me.BoosterControlpanel1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.BoosterControlpanel1.Image = Nothing
        Me.BoosterControlpanel1.Location = New System.Drawing.Point(13, 30)
        Me.BoosterControlpanel1.Movable = True
        Me.BoosterControlpanel1.Name = "BoosterControlpanel1"
        Me.BoosterControlpanel1.NoRounding = False
        Me.BoosterControlpanel1.Sizable = True
        Me.BoosterControlpanel1.Size = New System.Drawing.Size(349, 185)
        Me.BoosterControlpanel1.SmartBounds = True
        Me.BoosterControlpanel1.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.BoosterControlpanel1.TabIndex = 0
        Me.BoosterControlpanel1.Text = "#Create Account"
        Me.BoosterControlpanel1.TransparencyKey = System.Drawing.Color.Empty
        Me.BoosterControlpanel1.Transparent = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(108, 41)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(133, 19)
        Me.Label12.TabIndex = 80
        Me.Label12.Text = "~ Dados da conta ~"
        '
        'BoosterButton4
        '
        Me.BoosterButton4.ArcColour = System.Drawing.Color.Empty
        Me.BoosterButton4.ArrowBorderColour = System.Drawing.Color.Empty
        Me.BoosterButton4.ArrowColour = System.Drawing.Color.Empty
        Me.BoosterButton4.BackColor = System.Drawing.Color.Transparent
        Me.BoosterButton4.BorderColour = System.Drawing.Color.Empty
        Me.BoosterButton4.Colors = New Hard_Booter.Bloom(-1) {}
        Me.BoosterButton4.Customization = ""
        Me.BoosterButton4.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.BoosterButton4.HoverColour = System.Drawing.Color.Empty
        Me.BoosterButton4.Image = Nothing
        Me.BoosterButton4.Location = New System.Drawing.Point(68, 137)
        Me.BoosterButton4.Name = "BoosterButton4"
        Me.BoosterButton4.NormalColour = System.Drawing.Color.Empty
        Me.BoosterButton4.NoRounding = False
        Me.BoosterButton4.PressedColour = System.Drawing.Color.Empty
        Me.BoosterButton4.Size = New System.Drawing.Size(212, 28)
        Me.BoosterButton4.TabIndex = 77
        Me.BoosterButton4.Text = "Create account"
        Me.BoosterButton4.Transparent = True
        '
        'logCreatePass
        '
        Me.logCreatePass.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.logCreatePass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.logCreatePass.ForeColor = System.Drawing.Color.Cyan
        Me.logCreatePass.Location = New System.Drawing.Point(68, 106)
        Me.logCreatePass.Name = "logCreatePass"
        Me.logCreatePass.Size = New System.Drawing.Size(212, 25)
        Me.logCreatePass.TabIndex = 30
        Me.logCreatePass.Text = "Password"
        Me.logCreatePass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.logCreatePass.UseSystemPasswordChar = True
        '
        'logCreate
        '
        Me.logCreate.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.logCreate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.logCreate.ForeColor = System.Drawing.Color.Cyan
        Me.logCreate.Location = New System.Drawing.Point(68, 69)
        Me.logCreate.Name = "logCreate"
        Me.logCreate.Size = New System.Drawing.Size(212, 25)
        Me.logCreate.TabIndex = 29
        Me.logCreate.Text = "Login"
        Me.logCreate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BoosterControlpanel2
        '
        Me.BoosterControlpanel2.BackColor = System.Drawing.Color.Transparent
        Me.BoosterControlpanel2.BorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.BoosterControlpanel2.Colors = New Hard_Booter.Bloom(-1) {}
        Me.BoosterControlpanel2.Controls.Add(Me.BoosterButton5)
        Me.BoosterControlpanel2.Customization = ""
        Me.BoosterControlpanel2.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.BoosterControlpanel2.Image = Nothing
        Me.BoosterControlpanel2.Location = New System.Drawing.Point(378, 30)
        Me.BoosterControlpanel2.Movable = True
        Me.BoosterControlpanel2.Name = "BoosterControlpanel2"
        Me.BoosterControlpanel2.NoRounding = False
        Me.BoosterControlpanel2.Sizable = True
        Me.BoosterControlpanel2.Size = New System.Drawing.Size(349, 185)
        Me.BoosterControlpanel2.SmartBounds = True
        Me.BoosterControlpanel2.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.BoosterControlpanel2.TabIndex = 1
        Me.BoosterControlpanel2.Text = "#Killl Attacks"
        Me.BoosterControlpanel2.TransparencyKey = System.Drawing.Color.Empty
        Me.BoosterControlpanel2.Transparent = True
        '
        'BoosterButton5
        '
        Me.BoosterButton5.ArcColour = System.Drawing.Color.Empty
        Me.BoosterButton5.ArrowBorderColour = System.Drawing.Color.Empty
        Me.BoosterButton5.ArrowColour = System.Drawing.Color.Empty
        Me.BoosterButton5.BackColor = System.Drawing.Color.Transparent
        Me.BoosterButton5.BorderColour = System.Drawing.Color.Empty
        Me.BoosterButton5.Colors = New Hard_Booter.Bloom(-1) {}
        Me.BoosterButton5.Customization = ""
        Me.BoosterButton5.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BoosterButton5.HoverColour = System.Drawing.Color.Empty
        Me.BoosterButton5.Image = Nothing
        Me.BoosterButton5.Location = New System.Drawing.Point(24, 78)
        Me.BoosterButton5.Name = "BoosterButton5"
        Me.BoosterButton5.NormalColour = System.Drawing.Color.Empty
        Me.BoosterButton5.NoRounding = False
        Me.BoosterButton5.PressedColour = System.Drawing.Color.Empty
        Me.BoosterButton5.Size = New System.Drawing.Size(300, 48)
        Me.BoosterButton5.TabIndex = 78
        Me.BoosterButton5.Text = "Finalizar todos os ataques"
        Me.BoosterButton5.Transparent = True
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(-1, 6)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(137, 98)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox4.TabIndex = 75
        Me.PictureBox4.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.logAdminButton)
        Me.Panel2.Controls.Add(Me.logAdmin)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.passAdmin)
        Me.Panel2.Location = New System.Drawing.Point(170, 25)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(413, 187)
        Me.Panel2.TabIndex = 77
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(182, 21)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(46, 19)
        Me.Label8.TabIndex = 73
        Me.Label8.Text = "Login:"
        '
        'logAdminButton
        '
        Me.logAdminButton.ArcColour = System.Drawing.Color.Empty
        Me.logAdminButton.ArrowBorderColour = System.Drawing.Color.Empty
        Me.logAdminButton.ArrowColour = System.Drawing.Color.Empty
        Me.logAdminButton.BackColor = System.Drawing.Color.Transparent
        Me.logAdminButton.BorderColour = System.Drawing.Color.Empty
        Me.logAdminButton.Colors = New Hard_Booter.Bloom(-1) {}
        Me.logAdminButton.Customization = ""
        Me.logAdminButton.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.logAdminButton.HoverColour = System.Drawing.Color.Empty
        Me.logAdminButton.Image = Nothing
        Me.logAdminButton.Location = New System.Drawing.Point(70, 130)
        Me.logAdminButton.Name = "logAdminButton"
        Me.logAdminButton.NormalColour = System.Drawing.Color.Empty
        Me.logAdminButton.NoRounding = False
        Me.logAdminButton.PressedColour = System.Drawing.Color.Empty
        Me.logAdminButton.Size = New System.Drawing.Size(271, 34)
        Me.logAdminButton.TabIndex = 70
        Me.logAdminButton.Text = "Acessar painel admin"
        Me.logAdminButton.Transparent = True
        '
        'logAdmin
        '
        Me.logAdmin.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.logAdmin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.logAdmin.ForeColor = System.Drawing.Color.White
        Me.logAdmin.Location = New System.Drawing.Point(70, 43)
        Me.logAdmin.Name = "logAdmin"
        Me.logAdmin.Size = New System.Drawing.Size(271, 25)
        Me.logAdmin.TabIndex = 71
        Me.logAdmin.Text = "Admin Login"
        Me.logAdmin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(170, 77)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(70, 19)
        Me.Label9.TabIndex = 74
        Me.Label9.Text = "Password:"
        '
        'passAdmin
        '
        Me.passAdmin.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.passAdmin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.passAdmin.ForeColor = System.Drawing.Color.White
        Me.passAdmin.Location = New System.Drawing.Point(70, 99)
        Me.passAdmin.Name = "passAdmin"
        Me.passAdmin.Size = New System.Drawing.Size(271, 25)
        Me.passAdmin.TabIndex = 72
        Me.passAdmin.Text = "password123"
        Me.passAdmin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.passAdmin.UseSystemPasswordChar = True
        '
        'Booter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(768, 360)
        Me.Controls.Add(Me.BoosterTheme1)
        Me.Cursor = System.Windows.Forms.Cursors.Cross
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Booter"
        Me.Opacity = 0.99R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "#HardBooter v0.8b ~ The revolution of DDoS"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.BoosterTheme1.ResumeLayout(False)
        Me.LogInTabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.NumArchPort, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        Me.TabPage5.ResumeLayout(False)
        Me.TabPage5.PerformLayout()
        Me.TabPage6.ResumeLayout(False)
        Me.AdminPanel.ResumeLayout(False)
        Me.AdminPanel.PerformLayout()
        Me.BoosterControlpanel1.ResumeLayout(False)
        Me.BoosterControlpanel1.PerformLayout()
        Me.BoosterControlpanel2.ResumeLayout(False)
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BoosterTheme1 As Hard_Booter.BoosterTheme
    Friend WithEvents LogInTabControl1 As Hard_Booter.LogInTabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents Comando As Hard_Booter.LogInStatusBar
    Friend WithEvents Minimizar As Hard_Booter.BoosterRedButton
    Friend WithEvents Fechar As Hard_Booter.BoosterRedButton
    Friend WithEvents DiasVIP As System.Windows.Forms.Label
    Friend WithEvents BemV As System.Windows.Forms.Label
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage5 As System.Windows.Forms.TabPage
    Friend WithEvents Logado As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents taimi As Hard_Booter.LogInTrackBar
    Friend WithEvents IP As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents PORTA As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BossterMixedButton3 As Hard_Booter.BossterMixedButton
    Friend WithEvents BossterMixedButton2 As Hard_Booter.BossterMixedButton
    Friend WithEvents Atacar As Hard_Booter.BossterMixedButton
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents LogInComboBox1 As Hard_Booter.LogInComboBox
    Friend WithEvents WebBrowser40 As System.Windows.Forms.WebBrowser
    Friend WithEvents WebBrowser39 As System.Windows.Forms.WebBrowser
    Friend WithEvents WebBrowser38 As System.Windows.Forms.WebBrowser
    Friend WithEvents WebBrowser37 As System.Windows.Forms.WebBrowser
    Friend WithEvents WebBrowser36 As System.Windows.Forms.WebBrowser
    Friend WithEvents WebBrowser35 As System.Windows.Forms.WebBrowser
    Friend WithEvents WebBrowser34 As System.Windows.Forms.WebBrowser
    Friend WithEvents WebBrowser33 As System.Windows.Forms.WebBrowser
    Friend WithEvents WebBrowser32 As System.Windows.Forms.WebBrowser
    Friend WithEvents WebBrowser31 As System.Windows.Forms.WebBrowser
    Friend WithEvents WebBrowser30 As System.Windows.Forms.WebBrowser
    Friend WithEvents WebBrowser29 As System.Windows.Forms.WebBrowser
    Friend WithEvents WebBrowser28 As System.Windows.Forms.WebBrowser
    Friend WithEvents WebBrowser27 As System.Windows.Forms.WebBrowser
    Friend WithEvents WebBrowser26 As System.Windows.Forms.WebBrowser
    Friend WithEvents WebBrowser25 As System.Windows.Forms.WebBrowser
    Friend WithEvents WebBrowser24 As System.Windows.Forms.WebBrowser
    Friend WithEvents WebBrowser23 As System.Windows.Forms.WebBrowser
    Friend WithEvents WebBrowser22 As System.Windows.Forms.WebBrowser
    Friend WithEvents WebBrowser21 As System.Windows.Forms.WebBrowser
    Friend WithEvents WebBrowser20 As System.Windows.Forms.WebBrowser
    Friend WithEvents WebBrowser19 As System.Windows.Forms.WebBrowser
    Friend WithEvents WebBrowser18 As System.Windows.Forms.WebBrowser
    Friend WithEvents WebBrowser17 As System.Windows.Forms.WebBrowser
    Friend WithEvents WebBrowser16 As System.Windows.Forms.WebBrowser
    Friend WithEvents WebBrowser15 As System.Windows.Forms.WebBrowser
    Friend WithEvents WebBrowser14 As System.Windows.Forms.WebBrowser
    Friend WithEvents WebBrowser13 As System.Windows.Forms.WebBrowser
    Friend WithEvents WebBrowser12 As System.Windows.Forms.WebBrowser
    Friend WithEvents WebBrowser11 As System.Windows.Forms.WebBrowser
    Friend WithEvents WebBrowser10 As System.Windows.Forms.WebBrowser
    Friend WithEvents WebBrowser9 As System.Windows.Forms.WebBrowser
    Friend WithEvents WebBrowser8 As System.Windows.Forms.WebBrowser
    Friend WithEvents WebBrowser7 As System.Windows.Forms.WebBrowser
    Friend WithEvents WebBrowser6 As System.Windows.Forms.WebBrowser
    Friend WithEvents WebBrowser5 As System.Windows.Forms.WebBrowser
    Friend WithEvents WebBrowser4 As System.Windows.Forms.WebBrowser
    Friend WithEvents WebBrowser3 As System.Windows.Forms.WebBrowser
    Friend WithEvents WebBrowser2 As System.Windows.Forms.WebBrowser
    Friend WithEvents WebBrowser1 As System.Windows.Forms.WebBrowser
    Friend WithEvents TabPage6 As System.Windows.Forms.TabPage
    Friend WithEvents Tempo As System.Windows.Forms.Label
    Friend WithEvents Tempo_Ataque As System.Windows.Forms.Timer
    Friend WithEvents DiminuirTrackBar As System.Windows.Forms.Timer
    Friend WithEvents BoosterButton1 As Hard_Booter.BoosterButton
    Friend WithEvents Ipgeo As System.Windows.Forms.TextBox
    Friend WithEvents geoinfo As System.Windows.Forms.TextBox
    Friend WithEvents Color As System.Windows.Forms.Timer
    Friend WithEvents BoosterButton2 As Hard_Booter.BoosterButton
    Friend WithEvents btnArchStart As Hard_Booter.BoosterButton
    Friend WithEvents btnArchStop As Hard_Booter.BoosterButton
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents NumArchPort As System.Windows.Forms.NumericUpDown
    Friend WithEvents cbArchMethod As Hard_Booter.LogInComboBox
    Friend WithEvents txtArchIP As System.Windows.Forms.TextBox
    Friend WithEvents listResolverIP As System.Windows.Forms.Label
    Friend WithEvents Chat As System.Windows.Forms.WebBrowser
    Friend WithEvents Mensagem As System.Windows.Forms.TextBox
    Friend WithEvents BoosterRedButton1 As Hard_Booter.BoosterRedButton
    Friend WithEvents chaty As System.Windows.Forms.TextBox
    Friend WithEvents xChat As System.Windows.Forms.Timer
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents passAdmin As System.Windows.Forms.TextBox
    Friend WithEvents logAdmin As System.Windows.Forms.TextBox
    Friend WithEvents logAdminButton As Hard_Booter.BoosterButton
    Friend WithEvents AdminPanel As System.Windows.Forms.Panel
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents BoosterControlpanel1 As Hard_Booter.BoosterControlpanel
    Friend WithEvents BoosterButton4 As Hard_Booter.BoosterButton
    Friend WithEvents logCreatePass As System.Windows.Forms.TextBox
    Friend WithEvents logCreate As System.Windows.Forms.TextBox
    Friend WithEvents Admin As System.Windows.Forms.WebBrowser
    Friend WithEvents BoosterControlpanel2 As Hard_Booter.BoosterControlpanel
    Friend WithEvents BoosterButton5 As Hard_Booter.BoosterButton
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents respostaadmin As System.Windows.Forms.Label
    Friend WithEvents ChatB As System.ComponentModel.BackgroundWorker
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents PararAtaque As Hard_Booter.BossterMixedButton
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents KillSniffing As System.Windows.Forms.Timer
End Class
