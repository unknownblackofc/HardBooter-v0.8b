<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.KillSniffing = New System.Windows.Forms.Timer(Me.components)
        Me.BoosterTheme1 = New Hard_Booter.BoosterTheme()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LogInLogButton1 = New Hard_Booter.LogInLogButton()
        Me.Senha = New Hard_Booter.LogInPassTextBox()
        Me.Usuarioo = New Hard_Booter.LogInUserTextBox()
        Me.BoosterRedButton1 = New Hard_Booter.BoosterRedButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.snifferstatus = New System.Windows.Forms.Label()
        Me.geoipstatus = New System.Windows.Forms.Label()
        Me.ddosstatus = New System.Windows.Forms.Label()
        Me.chatstatus = New System.Windows.Forms.Label()
        Me.databasestatus = New System.Windows.Forms.Label()
        Me.projectstatus = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.resposta2 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Labeltmnc = New System.Windows.Forms.Label()
        Me.BoosterTheme1.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'KillSniffing
        '
        Me.KillSniffing.Enabled = True
        Me.KillSniffing.Interval = 525
        '
        'BoosterTheme1
        '
        Me.BoosterTheme1.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.BoosterTheme1.BorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.BoosterTheme1.Colors = New Hard_Booter.Bloom(-1) {}
        Me.BoosterTheme1.Controls.Add(Me.Label3)
        Me.BoosterTheme1.Controls.Add(Me.LogInLogButton1)
        Me.BoosterTheme1.Controls.Add(Me.Senha)
        Me.BoosterTheme1.Controls.Add(Me.Usuarioo)
        Me.BoosterTheme1.Controls.Add(Me.BoosterRedButton1)
        Me.BoosterTheme1.Controls.Add(Me.Label1)
        Me.BoosterTheme1.Controls.Add(Me.PictureBox3)
        Me.BoosterTheme1.Controls.Add(Me.PictureBox2)
        Me.BoosterTheme1.Controls.Add(Me.PictureBox1)
        Me.BoosterTheme1.Controls.Add(Me.Label13)
        Me.BoosterTheme1.Controls.Add(Me.Label14)
        Me.BoosterTheme1.Controls.Add(Me.Label15)
        Me.BoosterTheme1.Controls.Add(Me.snifferstatus)
        Me.BoosterTheme1.Controls.Add(Me.geoipstatus)
        Me.BoosterTheme1.Controls.Add(Me.ddosstatus)
        Me.BoosterTheme1.Controls.Add(Me.chatstatus)
        Me.BoosterTheme1.Controls.Add(Me.databasestatus)
        Me.BoosterTheme1.Controls.Add(Me.projectstatus)
        Me.BoosterTheme1.Controls.Add(Me.Label6)
        Me.BoosterTheme1.Controls.Add(Me.Label5)
        Me.BoosterTheme1.Controls.Add(Me.Label4)
        Me.BoosterTheme1.Controls.Add(Me.resposta2)
        Me.BoosterTheme1.Controls.Add(Me.Label2)
        Me.BoosterTheme1.Controls.Add(Me.Labeltmnc)
        Me.BoosterTheme1.Customization = ""
        Me.BoosterTheme1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BoosterTheme1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BoosterTheme1.Image = Nothing
        Me.BoosterTheme1.Location = New System.Drawing.Point(0, 0)
        Me.BoosterTheme1.Movable = True
        Me.BoosterTheme1.Name = "BoosterTheme1"
        Me.BoosterTheme1.NoRounding = False
        Me.BoosterTheme1.Sizable = False
        Me.BoosterTheme1.Size = New System.Drawing.Size(483, 262)
        Me.BoosterTheme1.SmartBounds = True
        Me.BoosterTheme1.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.BoosterTheme1.TabIndex = 2
        Me.BoosterTheme1.Text = "#HardBooter v0.8b ~ Login área"
        Me.BoosterTheme1.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.BoosterTheme1.Transparent = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label3.Location = New System.Drawing.Point(166, 33)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(150, 15)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "~Status Dos Servidores~"
        '
        'LogInLogButton1
        '
        Me.LogInLogButton1.ArcColour = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.LogInLogButton1.ArrowBorderColour = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.LogInLogButton1.ArrowColour = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.LogInLogButton1.BackColor = System.Drawing.Color.Transparent
        Me.LogInLogButton1.BorderColour = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.LogInLogButton1.HoverColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.LogInLogButton1.Location = New System.Drawing.Point(403, 168)
        Me.LogInLogButton1.Name = "LogInLogButton1"
        Me.LogInLogButton1.NormalColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.LogInLogButton1.PressedColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.LogInLogButton1.Size = New System.Drawing.Size(50, 50)
        Me.LogInLogButton1.TabIndex = 25
        Me.LogInLogButton1.Text = "LogInLogButton1"
        '
        'Senha
        '
        Me.Senha.BackColor = System.Drawing.Color.Transparent
        Me.Senha.BackgroundColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Senha.BorderColour = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.Senha.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Senha.Location = New System.Drawing.Point(106, 199)
        Me.Senha.MaxLength = 32767
        Me.Senha.Multiline = False
        Me.Senha.Name = "Senha"
        Me.Senha.ReadOnly = False
        Me.Senha.Size = New System.Drawing.Size(307, 29)
        Me.Senha.TabIndex = 24
        Me.Senha.Text = "Password"
        Me.Senha.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Senha.TextColour = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Senha.UseSystemPasswordChar = True
        '
        'Usuarioo
        '
        Me.Usuarioo.BackColor = System.Drawing.Color.Transparent
        Me.Usuarioo.BackgroundColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.Usuarioo.BorderColour = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.Usuarioo.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Usuarioo.Location = New System.Drawing.Point(106, 159)
        Me.Usuarioo.MaxLength = 32767
        Me.Usuarioo.Multiline = False
        Me.Usuarioo.Name = "Usuarioo"
        Me.Usuarioo.ReadOnly = False
        Me.Usuarioo.Size = New System.Drawing.Size(307, 29)
        Me.Usuarioo.TabIndex = 23
        Me.Usuarioo.Text = "Usuário"
        Me.Usuarioo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Usuarioo.TextColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Usuarioo.UseSystemPasswordChar = False
        '
        'BoosterRedButton1
        '
        Me.BoosterRedButton1.BackColor = System.Drawing.Color.Transparent
        Me.BoosterRedButton1.Colors = New Hard_Booter.Bloom(-1) {}
        Me.BoosterRedButton1.Customization = ""
        Me.BoosterRedButton1.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.BoosterRedButton1.Image = Nothing
        Me.BoosterRedButton1.Location = New System.Drawing.Point(427, 0)
        Me.BoosterRedButton1.Name = "BoosterRedButton1"
        Me.BoosterRedButton1.NoRounding = False
        Me.BoosterRedButton1.Size = New System.Drawing.Size(56, 23)
        Me.BoosterRedButton1.TabIndex = 22
        Me.BoosterRedButton1.Text = "X"
        Me.BoosterRedButton1.Transparent = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(173, 20)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "RESPOSTA DO SERVIDOR"
        Me.Label1.Visible = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(459, 240)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(21, 19)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 20
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(391, 60)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(80, 84)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 19
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 60)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(80, 84)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 18
        Me.PictureBox1.TabStop = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Italic)
        Me.Label13.ForeColor = System.Drawing.Color.DarkCyan
        Me.Label13.Location = New System.Drawing.Point(283, 128)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(72, 15)
        Me.Label13.TabIndex = 17
        Me.Label13.Text = "Chat Status:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Italic)
        Me.Label14.ForeColor = System.Drawing.Color.DarkCyan
        Me.Label14.Location = New System.Drawing.Point(255, 94)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(98, 15)
        Me.Label14.TabIndex = 16
        Me.Label14.Text = "Database Status:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Italic)
        Me.Label15.ForeColor = System.Drawing.Color.DarkCyan
        Me.Label15.Location = New System.Drawing.Point(221, 62)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(81, 15)
        Me.Label15.TabIndex = 15
        Me.Label15.Text = "Project Status:"
        '
        'snifferstatus
        '
        Me.snifferstatus.AutoSize = True
        Me.snifferstatus.BackColor = System.Drawing.Color.Transparent
        Me.snifferstatus.ForeColor = System.Drawing.Color.Cyan
        Me.snifferstatus.Location = New System.Drawing.Point(179, 128)
        Me.snifferstatus.Name = "snifferstatus"
        Me.snifferstatus.Size = New System.Drawing.Size(30, 15)
        Me.snifferstatus.TabIndex = 14
        Me.snifferstatus.Text = "OFF"
        '
        'geoipstatus
        '
        Me.geoipstatus.AutoSize = True
        Me.geoipstatus.BackColor = System.Drawing.Color.Transparent
        Me.geoipstatus.ForeColor = System.Drawing.Color.Cyan
        Me.geoipstatus.Location = New System.Drawing.Point(178, 94)
        Me.geoipstatus.Name = "geoipstatus"
        Me.geoipstatus.Size = New System.Drawing.Size(30, 15)
        Me.geoipstatus.TabIndex = 13
        Me.geoipstatus.Text = "OFF"
        '
        'ddosstatus
        '
        Me.ddosstatus.AutoSize = True
        Me.ddosstatus.BackColor = System.Drawing.Color.Transparent
        Me.ddosstatus.ForeColor = System.Drawing.Color.Cyan
        Me.ddosstatus.Location = New System.Drawing.Point(177, 62)
        Me.ddosstatus.Name = "ddosstatus"
        Me.ddosstatus.Size = New System.Drawing.Size(30, 15)
        Me.ddosstatus.TabIndex = 12
        Me.ddosstatus.Text = "OFF"
        '
        'chatstatus
        '
        Me.chatstatus.AutoSize = True
        Me.chatstatus.BackColor = System.Drawing.Color.Transparent
        Me.chatstatus.ForeColor = System.Drawing.Color.Cyan
        Me.chatstatus.Location = New System.Drawing.Point(355, 128)
        Me.chatstatus.Name = "chatstatus"
        Me.chatstatus.Size = New System.Drawing.Size(30, 15)
        Me.chatstatus.TabIndex = 11
        Me.chatstatus.Text = "OFF"
        '
        'databasestatus
        '
        Me.databasestatus.AutoSize = True
        Me.databasestatus.BackColor = System.Drawing.Color.Transparent
        Me.databasestatus.ForeColor = System.Drawing.Color.Cyan
        Me.databasestatus.Location = New System.Drawing.Point(355, 94)
        Me.databasestatus.Name = "databasestatus"
        Me.databasestatus.Size = New System.Drawing.Size(30, 15)
        Me.databasestatus.TabIndex = 10
        Me.databasestatus.Text = "OFF"
        '
        'projectstatus
        '
        Me.projectstatus.AutoSize = True
        Me.projectstatus.BackColor = System.Drawing.Color.Transparent
        Me.projectstatus.ForeColor = System.Drawing.Color.Cyan
        Me.projectstatus.Location = New System.Drawing.Point(305, 62)
        Me.projectstatus.Name = "projectstatus"
        Me.projectstatus.Size = New System.Drawing.Size(80, 15)
        Me.projectstatus.TabIndex = 9
        Me.projectstatus.Text = "Non-Cracked"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Italic)
        Me.Label6.ForeColor = System.Drawing.Color.DarkCyan
        Me.Label6.Location = New System.Drawing.Point(98, 128)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 15)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Sniffer Status:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Italic)
        Me.Label5.ForeColor = System.Drawing.Color.DarkCyan
        Me.Label5.Location = New System.Drawing.Point(98, 94)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 15)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "GeoIP Status:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Italic)
        Me.Label4.ForeColor = System.Drawing.Color.DarkCyan
        Me.Label4.Location = New System.Drawing.Point(98, 62)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 15)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "DDoS Status:"
        '
        'resposta2
        '
        Me.resposta2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.resposta2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.resposta2.ForeColor = System.Drawing.Color.Lime
        Me.resposta2.Location = New System.Drawing.Point(2, 238)
        Me.resposta2.Name = "resposta2"
        Me.resposta2.Size = New System.Drawing.Size(479, 21)
        Me.resposta2.TabIndex = 5
        Me.resposta2.Text = "Aguardando comandos..."
        Me.resposta2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Italic)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(30, 201)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Password:"
        '
        'Labeltmnc
        '
        Me.Labeltmnc.AutoSize = True
        Me.Labeltmnc.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labeltmnc.ForeColor = System.Drawing.Color.White
        Me.Labeltmnc.Location = New System.Drawing.Point(56, 159)
        Me.Labeltmnc.Name = "Labeltmnc"
        Me.Labeltmnc.Size = New System.Drawing.Size(47, 20)
        Me.Labeltmnc.TabIndex = 3
        Me.Labeltmnc.Text = "Login:"
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(483, 262)
        Me.Controls.Add(Me.BoosterTheme1)
        Me.Cursor = System.Windows.Forms.Cursors.Cross
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Login"
        Me.Opacity = 0.99R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "#HardBooter v0.8b ~ Login área"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.BoosterTheme1.ResumeLayout(False)
        Me.BoosterTheme1.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Usuario As Hard_Booter.BoosterCheckBox
    Friend WithEvents BoosterTheme1 As Hard_Booter.BoosterTheme
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents snifferstatus As System.Windows.Forms.Label
    Friend WithEvents geoipstatus As System.Windows.Forms.Label
    Friend WithEvents ddosstatus As System.Windows.Forms.Label
    Friend WithEvents chatstatus As System.Windows.Forms.Label
    Friend WithEvents databasestatus As System.Windows.Forms.Label
    Friend WithEvents projectstatus As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents resposta2 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Labeltmnc As System.Windows.Forms.Label
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BoosterRedButton1 As Hard_Booter.BoosterRedButton
    Friend WithEvents Usuarioo As Hard_Booter.LogInUserTextBox
    Friend WithEvents LogInLogButton1 As Hard_Booter.LogInLogButton
    Friend WithEvents Senha As Hard_Booter.LogInPassTextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents KillSniffing As System.Windows.Forms.Timer
End Class
