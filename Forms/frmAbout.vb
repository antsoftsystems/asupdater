Public Class FrmAbout

    Private Sub FrmAbout_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PicAbout.Image = PicAboutImg

        wbDescription.DocumentText = My.Resources.HTMLStart &
            "<h4 class='text-center'>" & LibUpdate.LibName & "</h4>" &
            "<p>Versão " & String.Format("{0} <br/><small>Code Compile:<br/> {1,10}</small>", LibUpdate.LibVersion, LibUpdate.CodeCompiled) & "</p>" &
            "<p>" & LibUpdate.LibCopyright & "</p>" &
            "<p>Descrição: " & LibUpdate.LibDescription & "</p>" &
            "<p><strong>Este software é de uso exclusivo para os software da AntSoft Systems On Demand</strong></p>" &
            "<p><strong>Advertência: Este software é protegido por leis de direitos autorais, no Brasil e no mundo.</strong></p>" &
            My.Resources.HTMLEnd
    End Sub
End Class