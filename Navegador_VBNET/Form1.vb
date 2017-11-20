Public Class Form1

    Private Sub btnIrPara_Click(sender As Object, e As EventArgs) Handles btnIrPara.Click
        WebBrowser1.Navigate(txtUrl.Text)
    End Sub

    Private Sub btnVoltar_Click(sender As Object, e As EventArgs) Handles btnVoltar.Click
        WebBrowser1.GoBack()
    End Sub

    Private Sub btnAvançar_Click(sender As Object, e As EventArgs) Handles btnAvançar.Click
        WebBrowser1.GoForward()
    End Sub

    Private Sub btnAtualizar_Click(sender As Object, e As EventArgs) Handles btnAtualizar.Click
        WebBrowser1.Refresh()
    End Sub

    Private Sub btnPesquisar_Click(sender As Object, e As EventArgs) Handles btnPesquisar.Click
        WebBrowser1.GoSearch()
    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        WebBrowser1.GoHome()
    End Sub

    Private Sub WebBrowser1_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted
        txtUrl.Text = WebBrowser1.Url.ToString
        pgbar1.Visible = False
    End Sub

    Private Sub WebBrowser1_Navigating(sender As Object, e As WebBrowserNavigatingEventArgs) Handles WebBrowser1.Navigating
        pgbar1.Visible = True
        With pgbar1
            .Minimum = 0
            .Maximum = 100
            .Step = 5
        End With
        For i As Integer = 0 To 100 Step 5
            pgbar1.Value = i
            System.Threading.Thread.Sleep(25)
        Next
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
