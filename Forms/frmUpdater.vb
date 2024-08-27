Imports System.Windows.Forms
Imports System.Data

Public Class frmUpdater
    Dim pastaTemporaria As String
    Dim wc As System.Net.WebClient
    Dim sFileExec As String
    Dim sNewVersion As String

    Private Sub BtnStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStart.Click
        pBar.Visible = True
        Application.DoEvents()
        If GotInternet() = False Then
            MessageBox.Show("Não é possível verificar atualização do software, pois não foi verificada conexão com a Internet!", sTitulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        Else
            UpdateService()
        End If
    End Sub

    Private Sub FrmUpdate_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        pBar.Visible = False
        lvwUpdate.Items.Clear()
    End Sub

    Private Sub FrmUpdate_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Show()
        If String.IsNullOrWhiteSpace(LibUpdate.NameApp) = False Then
            Text = String.Format("AntSoft Software Updater - {0} v{1}", LibUpdate.NameApp, LibUpdate.VersionApp)
        End If
        picUpdate.Image = PicUpdateImg
        ch1.Width = 410

        wc = New System.Net.WebClient()

    End Sub
    Public Sub UpdateService()
        lvwUpdate.Items.Clear()
        lvwUpdate.Items.Add("Iniciando a Atualização", 3)
        pastaTemporaria = System.IO.Path.GetTempPath()
        If pastaTemporaria.EndsWith("\") = False Then
            pastaTemporaria &= "\"
        End If
        Try
            AddHandler wc.DownloadProgressChanged, AddressOf OnDownloadProgressChanged
            AddHandler wc.DownloadFileCompleted, AddressOf OnFileDownloadCompleted
            AddTextlvw("Verificando por nova versão online...")
            Dim dwUpdate As New srUpdater.WebService
            dwUpdate.Timeout = 60000
            Dim dt As New DataSet
            dt = dwUpdate.GetUpdate(libUpdate.CodeApp)
            If dt IsNot Nothing AndAlso dt.Tables(0).Rows.Count > 0 Then
                AddTextlvw("Atualização válida encontrada...", 2)
            Else
                AddTextlvw("Atualização não verificada ou falha no processo!", 1)
                AddTextlvw("Tente novamente!", 1)
                Exit Sub
                pBar.Visible = False
            End If
            AddTextlvw("Iniciando a verificação da versão...")
            Dim StrVer As Version = New Version(dt.Tables(0).Rows(0).Item("versao"))
            Dim StrVerApp As Version = New Version(sVerUpdate.FileVersion.ToString)
            sNewVersion = dt.Tables(0).Rows(0).Item("versao")
            Dim sDate As String = dt.Tables(0).Rows(0).Item("data")
            Dim sFileDld As String = dt.Tables(0).Rows(0).Item("download")
            If sFileDld.Contains("http") = False Then sFileDld = "https://www.antsoft.com.br/software/" & sFileDld
            Dim sFileTmp As String = System.IO.Path.GetFileName(sFileDld)
            sFileExec = System.IO.Path.GetFileName(sFileDld)
            AddTextlvw("Versão atual: " & sVerUpdate.FileVersion, 5)
            AddTextlvw("Versão disponível para download: " & sNewVersion, 5)
            Dim VerCompare As Integer = StrVer.CompareTo(StrVerApp)
            If VerCompare > 0 Then
                AddTextlvw("Iniciando o download do arquivo de atualização.", 3)
                If System.IO.File.Exists(pastaTemporaria & sFileTmp) Then _
                    Kill(pastaTemporaria & sFileTmp)
                If UrlExist(sFileDld) = True Then
                    AddTextlvw("Baixando o arquivo de instalação...")
                    'My.Computer.Network.DownloadFile(sFileDld, pastaTemporaria & "\DivEs40setup_temp.exe", , , True)
                    wc.DownloadFileAsync(New Uri(sFileDld), pastaTemporaria & sFileTmp)
                Else
                    AddTextlvw("Arquivo de instalação não localizado!", 1)
                    pBar.Visible = False
                    Exit Sub
                End If
            Else
                AddTextlvw("Não há necessidade de atualização.", 4)
                pBar.Visible = False
                btnAbout.Enabled = True

            End If
            Clipboard.Clear()
            Clipboard.SetText(pastaTemporaria & sFileTmp)
        Catch ex As Exception
            MessageBox.Show("Não é possível realizar a atualização do software. Erro: " & vbNewLine & _
                            ex.Message, sTitulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ' Clipboard.SetText(ex.ToString)
            AddTextlvw("Erro ao tentar verificar atualização.", 1)
            pBar.Visible = False

        End Try
    End Sub
  
    Private Sub OnDownloadProgressChanged(ByVal sender As Object, ByVal e As System.Net.DownloadProgressChangedEventArgs)

        Dim totalSize As Long = e.TotalBytesToReceive
        Dim downloadedBytes As Long = e.BytesReceived
        Dim percentage As Integer = e.ProgressPercentage
        'Put your progress UI here, you can cancel download by uncommenting the line below
        'wc.CancelAsync()
        pBar.Style = ProgressBarStyle.Continuous
        pBar.Maximum = totalSize
        pBar.Value = downloadedBytes
    End Sub
    Private Sub OnFileDownloadCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.AsyncCompletedEventArgs)
        pastaTemporaria = System.IO.Path.GetTempPath()
        If e.Cancelled Then
            'Cancelled
        ElseIf e.Error IsNot Nothing Then
            MessageBox.Show("Ocorreu o seguinte erro: " & vbCrLf & e.Error.Message, sTitulo, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            pBar.Visible = False
        Else
            pBar.Value = 0
            MessageBox.Show("A nova versão foi obtida com sucesso. Clique no botão Instalar", sTitulo, MessageBoxButtons.OK, MessageBoxIcon.Information)
            btnSetup.Enabled = True
            btnStart.Enabled = False
            btnAbout.Enabled = True
        End If

    End Sub
    Public Sub AddTextlvw(ByVal sText As String, Optional ByVal iconIdx As Integer = 0)
        With lvwUpdate
            .Items.Add(sText, iconIdx)
            .Items(lvwUpdate.Items.Count - 1).Selected = True
        End With
    End Sub

    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        If wc.IsBusy Then
            wc.CancelAsync()
        End If
        Me.Close()
    End Sub



    Private Sub BtnSetup_Click(sender As Object, e As EventArgs) Handles btnSetup.Click
        MessageBox.Show("O programa será finalizado para dar início a instalação da nova versão '" & sNewVersion & "'.", sTitulo, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Process.Start(pastaTemporaria & "\" & sFileExec)
        Application.Exit()
    End Sub

    Private Sub BtnAbout_Click(sender As Object, e As EventArgs) Handles btnAbout.Click
        Dim frm As New frmAbout
        frm.ShowDialog(Me)
    End Sub
End Class