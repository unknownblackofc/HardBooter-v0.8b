Imports System.Net
Imports System.Net.Sockets

Public Class SkypeArch


    Public Shared SOCKETS As New Socket(AddressFamily.InterNetwork, SocketType.Raw, ProtocolType.IP)
    Public Shared BYTE_DATA(4096) As Byte
    Public Shared MY_IP As IPAddress
    Public Shared STARTED As Boolean
    Public Shared SIZE_DIFF As Size
    Public Shared ALL_CONNECTIONS() As Net.NetworkInformation.NetworkInterface
    Public Shared FILTER_IPADD As New IPAddress(0)
    Public Shared FILTER_IP As Boolean

    Public Shared IP_FROM As IPAddress
    Public Shared IP_TO As IPAddress
    Public Shared DES_PORT As UInteger
    Public Shared SRC_PORT As UInteger

    Public Shared ListIP As Control = Booter.listResolverIP
    Public Shared Sub OnReceive(ByVal asyncresult As IAsyncResult)
        If STARTED = True Then
            Dim READ_LENGTH As UInteger = BitConverter.ToUInt16(Byteswap(BYTE_DATA, 0), 0)
            SRC_PORT = BitConverter.ToUInt16(Byteswap(BYTE_DATA, 22), 0)
            DES_PORT = BitConverter.ToUInt16(Byteswap(BYTE_DATA, 24), 0)

            IP_FROM = New IPAddress(BitConverter.ToUInt32(BYTE_DATA, 12))
            IP_TO = New IPAddress(BitConverter.ToUInt32(BYTE_DATA, 16))

            ListIP.Invoke(New MethodInvoker(AddressOf RESULT_UPDATE))
        End If
        SOCKETS.BeginReceive(BYTE_DATA, 0, BYTE_DATA.Length, SocketFlags.None, New AsyncCallback(AddressOf OnReceive), Nothing)
    End Sub

    Public Shared Sub RESULT_UPDATE()
        Dim IPV4 As String = Booter.txtArchIP.Text()

        If BYTE_DATA(9) = 17 And IP_FROM.ToString = IPV4 And DES_PORT = 80 And IP_TO.ToString.StartsWith("104") = False Then
            If ListIP.Text.Contains(IP_TO.ToString) = False Then
                If IP_TO.ToString.StartsWith("40.") Then
                    ListIP.Text += String.Format("{0}{1}", IP_TO.ToString, vbCrLf)
                    Booter.Comando.Text = "Extraimos um IP do Skype, verifique se está em algum grupo."
                    Booter.btnArchStart.Text = "Começar Sniffer"
                    STARTED = False
                ElseIf IP_TO.ToString.StartsWith("23.") Then
                    ListIP.Text += String.Format("{0}{1}", IP_TO.ToString, vbCrLf)
                    Booter.Comando.Text = "Extraimos um IP do Skype, verifique se está em algum grupo."
                    Booter.btnArchStart.Text = "Começar Sniffer"
                    STARTED = False
                Else
                    ListIP.Text += (String.Format("{0}{1}", IP_TO.ToString, vbCrLf))
                    Booter.Comando.Text = "IP capturado com sucesso! (" & IP_TO.ToString & ")"
                    Booter.btnArchStop.Visible = False
                    Booter.btnArchStart.Visible = True
                    Booter.btnArchStop.Enabled = False
                    Booter.btnArchStart.Enabled = True
                    Booter.btnArchStart.Text = "Começar Sniffer"
                    STARTED = False
                End If
            End If
        End If
    End Sub

    Public Shared Function Byteswap(ByVal bytez() As Byte, ByVal index As UInteger)
        Dim result(1) As Byte
        result(0) = bytez(index + 1)
        result(1) = bytez(index)
        Return result
    End Function

    Public Shared Sub BindSocket()
        Try
            SOCKETS.Bind(New IPEndPoint(MY_IP, Booter.numArchPort.Value))
            SOCKETS.SetSocketOption(SocketOptionLevel.IP, SocketOptionName.HeaderIncluded, True)
            Dim bytrue() As Byte = {1, 0, 0, 0}
            Dim byout() As Byte = {1, 0, 0, 0}
            SOCKETS.IOControl(IOControlCode.ReceiveAll, bytrue, byout)
            SOCKETS.Blocking = False
            ReDim BYTE_DATA(SOCKETS.ReceiveBufferSize)
            SOCKETS.BeginReceive(BYTE_DATA, 0, BYTE_DATA.Length, SocketFlags.None, New AsyncCallback(AddressOf OnReceive), Nothing)
        Catch ex As Exception
            Booter.Comando.Text = "O sniffer foi reiniciado com sucesso!"
        End Try
    End Sub
End Class