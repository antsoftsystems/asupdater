Imports System.Windows.Forms
Imports System.Net
Imports System.Xml
Imports System.Text
Imports System.Text.RegularExpressions
Imports System.Security.Cryptography
Imports System.ComponentModel
Imports System.Drawing
Module mMain
    Public sPath As String 'local da aplicação
    Public sTitulo As String
    Public sTitle As String
    Public sVerReg As String
    Public sVerRegSimp As String
    Public sVerUpdate As FileVersionInfo = FileVersionInfo.GetVersionInfo(Application.ExecutablePath)
    Public sSerial As String
    Public sUserName As String
    Public sVersion As String
    Public mailSent As Boolean = False
    Public PicUpdateImg As System.Drawing.Image
    Public PicAboutImg As System.Drawing.Image
    Public LibUpdate As New Updater

    Public Sub MainLib()

        If Application.StartupPath.EndsWith("\") Then
            sPath = Application.StartupPath
        Else
            sPath = Application.StartupPath & "\"
        End If
        PicUpdateImg = My.Resources.ASSUpdater
        PicAboutImg = My.Resources.ASSUpdaterAbout
        With My.Application.Info
            sTitle = .ProductName.ToString & " v" & .Version.Major & "." & .Version.Minor
            sTitulo = .ProductName
            sVerRegSimp = .Version.Major.ToString & ".0"
            sVerReg = String.Format("{0}.{1}", .Version.Major.ToString, .Version.Minor.ToString)
            sVersion = String.Format("Versão {0}", My.Application.Info.Version.ToString)
        End With
    End Sub

    Public Function UrlExist(ByVal sUrl As String) As Boolean
        Dim fileUrl As Uri = New Uri(sUrl)
        Dim req As System.Net.WebRequest
        req = System.Net.WebRequest.Create(sUrl)
        Dim resp As System.Net.WebResponse
        Try
            resp = req.GetResponse()
            resp.Close()
            req = Nothing
            Return (True)
        Catch ex As Exception
            req = Nothing
            Return False
        End Try
    End Function

    Public Function GotInternet() As Boolean
        Try
            Return My.Computer.Network.IsAvailable
        Catch weberrt As WebException
            Return False
        Catch except As Exception
            Return False
        End Try
    End Function

    Public Function CreateHash(ByVal sString As String, Optional iSize As Integer = 50) As String
        Dim SCryStr As String = "AntSoft10072017"
        Using md5Hash As MD5 = MD5.Create()
            Dim hash As String = GetMd5Hash(md5Hash, sString & SCryStr)
            hash = Left(hash, iSize)
            Return UCase(hash)
        End Using
    End Function
    Public Function CreateHashPure(ByVal sString As String, Optional iSize As Integer = 50) As String
        Using md5Hash As MD5 = MD5.Create()
            Dim hash As String = GetMd5Hash(md5Hash, sString)
            hash = Left(hash, iSize)
            Return LCase(hash)
        End Using
    End Function

    Public Function GetMd5Hash(ByVal md5Hash As MD5, ByVal input As String) As String

        ' Convert the input string to a byte array and compute the hash.
        Dim data As Byte() = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input))

        ' Create a new Stringbuilder to collect the bytes
        ' and create a string.
        Dim sBuilder As New StringBuilder()

        ' Loop through each byte of the hashed data 
        ' and format each one as a hexadecimal string.
        Dim i As Integer
        For i = 0 To data.Length - 1
            sBuilder.Append(data(i).ToString("x2"))
        Next i

        ' Return the hexadecimal string.
        Return sBuilder.ToString()

    End Function 'GetMd5Hash

End Module
