Imports System.Windows.Forms
Imports System.Reflection

Public Class Updater
    Private _versionapp As String
    Private _codeapp As String
    Private _nameapp As String
    Private sNewVersion As String, sDescUpdate As String, sDateUpdate As String

    Public Enum CheckResponse
        res_empty = 0
        res_noupdate = 1
        res_update = 2
        res_erro = 3
    End Enum

    Public Sub New()
        MainLib()
    End Sub

    Public Sub AppUpdate()
        Dim frm As New frmUpdateDesc 'frmUpdate
        frm.wbDescription.DocumentText = My.Resources.HTMLStart & "<h4>Uma nova versão está disponível para download</h4>" &
            "<p>Versão: " & sNewVersion & "<br/>" &
            "Data: " & sDateUpdate & "</p>" &
            "<div>Descrição: " & sDescUpdate & "</div>" &
            "<p>Deseja obter a nova versão agora?<br/>" &
            "Para iniciar o download, clique no botão Baixar!</p>" & My.Resources.HTMLEnd
        frm.ShowDialog()
    End Sub

    Public Sub CheckUpdate()
        Dim CheckUpdataRes As CheckResponse = CheckNewVerOnline()
        If CheckUpdataRes = CheckResponse.res_update Then 'check new update
            AppUpdate() 'show update form
        ElseIf CheckUpdataRes = CheckResponse.res_noupdate Then 'check new update
            MessageBox.Show("Seu software possui a versão mais recente e está atualizado!", sTitulo, MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf CheckUpdataRes = CheckResponse.res_empty Then 'check new update
            Exit Sub
        ElseIf CheckUpdataRes = CheckResponse.res_erro Then 'check new update
            MessageBox.Show("Não foi possível verificar se há atualização!", sTitulo, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Public Function CheckNewVerOnline() As CheckResponse
        Try
            If String.IsNullOrWhiteSpace(CodeApp) Then
                MessageBox.Show("É necessário especificar o código do aplicativo, para verificar se há atualização!", sTitle, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return CheckResponse.res_empty
            End If
            If String.IsNullOrWhiteSpace(VersionApp) Then
                MessageBox.Show("É necessário especificar a versão do aplicativo, para verificar se há atualização!", sTitle, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return CheckResponse.res_empty
            End If
            If String.IsNullOrWhiteSpace(NameApp) Then
                MessageBox.Show("É necessário especificar o nome do aplicativo, para verificar se há atualização!", sTitle, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return CheckResponse.res_empty
            End If
            Dim dwUpdate As New srUpdater.WebService
            dwUpdate.Timeout = 60000
            Dim dt As New DataSet
            dt = dwUpdate.GetUpdate(CodeApp)
            If dt IsNot Nothing AndAlso dt.Tables(0).Rows.Count > 0 Then
                GoTo InitialDld
            Else
                Return CheckResponse.res_erro
            End If
InitialDld:
            Dim StrVer As Version = New Version(dt.Tables(0).Rows(0).Item("versao"))
            Dim StrVerApp As Version = New Version(sVerUpdate.FileVersion.ToString)
            Dim sDate As String = dt.Tables(0).Rows(0).Item("data")
            Dim sFileDld As String = dt.Tables(0).Rows(0).Item("download")
            Dim sDescription As String = dt.Tables(0).Rows(0).Item("descricao").ToString.Replace(Environment.NewLine, vbNewLine).Replace("\n\r", vbNewLine)
            Dim VerCompare As Integer = StrVer.CompareTo(StrVerApp)
            If VerCompare > 0 Then
                sNewVersion = StrVer.ToString
                sDescUpdate = sDescription
                sDateUpdate = sDate
                LibUpdate.CodeApp = CodeApp
                LibUpdate.NameApp = NameApp
                LibUpdate.VersionApp = VersionApp
                Return CheckResponse.res_update
            Else
                Return CheckResponse.res_noupdate
            End If
        Catch ex As Exception
            MessageBox.Show("Erro: " & ex.Message & vbNewLine & vbNewLine & "Local de Origem: " & ex.StackTrace, sTitulo, MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Return CheckResponse.res_erro
        End Try
    End Function

    Public Function LibVersion() As String
        Dim assy As System.Reflection.Assembly = GetType(Updater).Assembly
        Dim assyName As String = assy.GetName().Name
        'AssemblyTitle
        Dim attr As Attribute = Attribute.GetCustomAttribute( _
              assy, GetType(AssemblyTitleAttribute))
        Dim adAttr As AssemblyTitleAttribute = _
                    CType(attr, AssemblyTitleAttribute)
        Return String.Format("{0}", GetType(Updater).Assembly.GetName().Version)
    End Function

    Public Function LibNameVersion() As String
        Dim assy As System.Reflection.Assembly = GetType(Updater).Assembly
        Dim assyName As String = assy.GetName().Name
        'AssemblyTitle
        Dim attr As Attribute = Attribute.GetCustomAttribute( _
              assy, GetType(AssemblyTitleAttribute))
        Dim adAttr As AssemblyTitleAttribute = _
                    CType(attr, AssemblyTitleAttribute)
        Return String.Format("{0} v{1}", adAttr.Title, GetType(Updater).Assembly.GetName().Version)
    End Function

    Public Function LibDescription() As String
        Dim assy As System.Reflection.Assembly = GetType(Updater).Assembly
        Dim assyName As String = assy.GetName().Name
        'AssemblyTitle
        Dim attr As Attribute = Attribute.GetCustomAttribute( _
              assy, GetType(AssemblyDescriptionAttribute))
        Dim adAttr As AssemblyDescriptionAttribute = _
                    CType(attr, AssemblyDescriptionAttribute)
        Return String.Format("{0}", adAttr.Description)
    End Function

    Public Function LibName() As String
        Dim assy As System.Reflection.Assembly = GetType(Updater).Assembly
        Dim assyName As String = assy.GetName().Name
        'AssemblyTitle
        Dim attr As Attribute = Attribute.GetCustomAttribute( _
              assy, GetType(AssemblyTitleAttribute))
        Dim adAttr As AssemblyTitleAttribute = _
                    CType(attr, AssemblyTitleAttribute)
        Return String.Format("{0}", adAttr.Title)
    End Function

    Public Function LibCopyright() As String
        Dim assy As System.Reflection.Assembly = GetType(Updater).Assembly
        Dim assyName As String = assy.GetName().Name
        'AssemblyTitle
        Dim attr As Attribute = Attribute.GetCustomAttribute( _
              assy, GetType(AssemblyCopyrightAttribute))
        Dim adAttr As AssemblyCopyrightAttribute = _
                    CType(attr, AssemblyCopyrightAttribute)
        Return String.Format("{0}", adAttr.Copyright)
    End Function

    Public Function CodeCompiled() As String
        Dim fileInfo As System.IO.FileInfo = New System.IO.FileInfo(Assembly.GetExecutingAssembly().Location)
        Dim sCodeDate As String = CreateHashPure(fileInfo.LastWriteTime.ToLongDateString).ToUpper
        Dim sDateFormat As String = Format(fileInfo.LastWriteTime, "yyyyMMdd")
        Return String.Format("{0}-{1}-{2}-{3}/{4}", sCodeDate.Substring(0, 8), sCodeDate.Substring(8, 8), sCodeDate.Substring(16, 8), sCodeDate.Substring(24), sDateFormat)
    End Function

    Public Property VersionApp() As String
        Get
            Return _versionapp
        End Get
        Set(value As String)
            _versionapp = value
        End Set
    End Property

    Public Property CodeApp() As String
        Get
            Return _codeapp
        End Get
        Set(value As String)
            _codeapp = value
        End Set
    End Property

    Public Property NameApp() As String
        Get
            Return _nameapp
        End Get
        Set(value As String)
            _nameapp = value
        End Set
    End Property

End Class
