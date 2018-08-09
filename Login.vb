Imports System.Net
Imports System.Management

Public Class Login
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
    Dim LinkServidor As String = "http://DATABASE AQUI/"
    Public DiasVIP As String
    Public HDVIP As String
    Private Sub Login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        WebRequest.Create("http://DATABASE AQUI/ddos.txt")
        ddosstatus.Text = New WebClient().DownloadString("http://DATABASE AQUI/ddos.txt")
        WebRequest.Create("http://DATABASE AQUI/geoip.txt")
        geoipstatus.Text = New WebClient().DownloadString("http://DATABASE AQUI/geoip.txt")
        WebRequest.Create("http://DATABASE AQUI/sniffer.txt")
        snifferstatus.Text = New WebClient().DownloadString("http://DATABASE AQUI/sniffer.txt")
        WebRequest.Create("http://DATABASE AQUI/database.txt")
        databasestatus.Text = New WebClient().DownloadString("http://DATABASE AQUI/database.txt")
        WebRequest.Create("http://DATABASE AQUI/chat.txt")
        chatstatus.Text = New WebClient().DownloadString("http://DATABASE AQUI/chat.txt")
        WebRequest.Create("http://DATABASE AQUI/project.txt")
        projectstatus.Text = New WebClient().DownloadString("http://DATABASE AQUI/project.txt")

    End Sub

    Private Sub LogInLogButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogInLogButton1.Click
        Dim Resposta As String =
GoAcesss.DownloadString(LinkServidor & "api aqui.php?&user=" &
Usuarioo.Text & "&pass=" & Senha.Text & "&hdi=" & AES_Encrypt(GetHDSerial(), 338))
        Label1.Text = Resposta
        If Resposta.Contains("Seeeeeeeeekkkkkkkkkkkkkkkzu") Then
            Dim Parte As Array
            Parte = Resposta.Split("|")
            If AES_Encrypt(GetHDSerial(), 338) = Parte(1).ToString.Replace(" ", "+") Then
                DiasVIP = Parte(2)
                HDVIP = Parte(1)
                resposta2.Text = "Logado com sucesso!"
                Me.Hide()
                Booter.ShowDialog()
            Else
                resposta2.Text = "Essa conta não foi registrada no seu PC!!"
                resposta2.ForeColor = Color.Red
            End If
        ElseIf Resposta.Contains("Acabou") Then
            resposta2.Text = "Seus dias VIP acabaram!"
            resposta2.ForeColor = Color.Red
        ElseIf Resposta.Contains("Nao Cadastrado") Then
            resposta2.Text = "Dados incorretos Ou, Esta conta não existe!"
            resposta2.ForeColor = Color.Red
        ElseIf Resposta.Contains("Banido") Then
            resposta2.Text = "Esta conta foi banida!"
            resposta2.ForeColor = Color.Red
        ElseIf Resposta.Contains("FecharAutomaticamente") Then
            End
        End If
    End Sub

    Private Sub BoosterRedButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BoosterRedButton1.Click
        End
    End Sub

    Private Sub KillSniffing_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KillSniffing.Tick
        For Each process As Process In process.GetProcessesByName("wireshark")
            process.Kill()
            End
        Next
    End Sub

    Private Sub BoosterTheme1_Click(sender As Object, e As EventArgs) Handles BoosterTheme1.Click

    End Sub
End Class