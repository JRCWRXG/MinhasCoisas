Public Class Form2

    Private Sub BtnIrPara_Click(sender As Object, e As EventArgs) Handles btnIrPara.Click
        ' WebBrowser1.Navigate("https://login.yahoo.com/")

        WebBrowser1.Navigate("https://econsigmb.papem.mar.mil.br/mb")

    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Try
            WebBrowser1.ScriptErrorsSuppressed = False

            WebBrowser1.Document.GetElementById("username").SetAttribute("value", txtUsuario.Text)
            '  WebBrowser1.Document.GetElementById("passwd").SetAttribute("value", txtSenha.Text)
            '   WebBrowser1.Document.GetElementById("signin").InvokeMember("click")

            '' WebBrowser1.Document.GetElementById("Entrar").InvokeMember("onclick")



        Catch ex As Exception
            MessageBox.Show("Erro : " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        'Dim PaginasElementos As HtmlElementCollection = WebBrowser1.Document.GetElementsByTagName("img")

        'For Each elementos As HtmlElement In PaginasElementos
        '    '' TextBox2.Text = TextBox2.Text & elementos.GetAttribute("src") & Environment.NewLine

        '    If elementos.Name = "Entrar" Then


        '        WebBrowser1.Document.GetElementById("ValidaLoginUserName").InvokeMember("onclick")

        '    End If
        'Next

        WebBrowser1.ScriptErrorsSuppressed = True

        WebBrowser1.Navigate("https://econsigmb.papem.mar.mil.br/mb")

        While WebBrowser1.ReadyState <> WebBrowserReadyState.Complete
            Application.DoEvents()
        End While

        WebBrowser1.Document.GetElementById("username").SetAttribute("value", 1)
        ''   WebBrowser1.Document.GetElementById("txtPassword").SetAttribute("value", "kieranw")

        Dim allImgTags As HtmlElementCollection = WebBrowser1.Document.GetElementsByTagName("input")
        '' Dim allImgTags As HtmlElementCollection = WebBrowser1.Document.All


        For Each img As HtmlElement In allImgTags
            If img.GetAttribute("src").Contains("/img/login/ok.gif") Then
                ' img.Focus()
                img.InvokeMember("click")
                '  Exit For




                ''MessageBox.Show("aguarde...")

                'ElseIf img.GetAttribute("src").Contains("ok.gif") Then
                '    img.InvokeMember("click")



            End If
        Next img

        Login_Senha()


        'System.Threading.Thread.Sleep(10000)









    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        WebBrowser1.ScriptErrorsSuppressed = True

        '  WebBrowser1.Navigate("https://econsigmb.papem.mar.mil.br/mb")

        While WebBrowser1.ReadyState <> WebBrowserReadyState.Complete
            Application.DoEvents()
        End While

        WebBrowser1.Document.GetElementById("senha").SetAttribute("value", 1)
        ''   WebBrowser1.Document.GetElementById("txtPassword").SetAttribute("value", "kieranw")

        ' '' ''Dim allImgTags As HtmlElementCollection = WebBrowser1.Document.GetElementsByTagName("input")
        ' '' '' '' Dim allImgTags As HtmlElementCollection = WebBrowser1.Document.All


        ' '' ''For Each img As HtmlElement In allImgTags
        ' '' ''    If img.GetAttribute("src").Contains("/img/login/ok.gif") Then
        ' '' ''        ' img.Focus()
        ' '' ''        img.InvokeMember("click")
        ' '' ''        '  Exit For




        ' '' ''        ''MessageBox.Show("aguarde...")

        ' '' ''        'ElseIf img.GetAttribute("src").Contains("ok.gif") Then
        ' '' ''        '    img.InvokeMember("click")



        ' '' ''    End If
        ' '' ''Next img


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Login_Usu()

       


    End Sub



    Public Function Login_Usu()


        Try


            WebBrowser1.ScriptErrorsSuppressed = True

            WebBrowser1.Navigate("https://econsigmb.papem.mar.mil.br/mb")

            While WebBrowser1.ReadyState <> WebBrowserReadyState.Complete
                Application.DoEvents()
            End While

            WebBrowser1.Document.GetElementById("username").SetAttribute("value", 1)
            ''   WebBrowser1.Document.GetElementById("txtPassword").SetAttribute("value", "kieranw")

            Dim allImgTags As HtmlElementCollection = WebBrowser1.Document.GetElementsByTagName("input")
            '' Dim allImgTags As HtmlElementCollection = WebBrowser1.Document.All


            ' '' '' ''For Each img As HtmlElement In allImgTags
            ' '' '' ''    If img.GetAttribute("src").Contains("/img/login/ok.gif") Then
            ' '' '' ''        ' img.Focus()
            ' '' '' ''        img.InvokeMember("click")
            ' '' '' ''        '  Exit For




            ' '' '' ''        ''MessageBox.Show("aguarde...")

            ' '' '' ''        'ElseIf img.GetAttribute("src").Contains("ok.gif") Then
            ' '' '' ''        '    img.InvokeMember("click")



            ' '' '' ''    End If
            ' '' '' ''Next img

            'System.Threading.Thread.Sleep(10000)

            '''   WebBrowser1.Document.GetElementById("senha").SetAttribute("value", 1)






            For Each elem As HtmlElement In allImgTags
                If elem.Name = "xxxx" Then
                    WebBrowser1.Document.GetElementById("username").SetAttribute("Value", 111)
                ElseIf elem.Name = "senha" Then
                    'webBrowser1.Document.GetElementById("senha").SetAttribute("Value", strSenhaSite)
                    WebBrowser1.Document.GetElementById("senha").Focus()

                    WebBrowser1.Document.GetElementById("senha").SetAttribute("value", 1)

                End If

            Next


        Catch ex As Exception

            MsgBox("merda", ex.Message)

        End Try

    End Function




    Public Function Login_Senha()


        Try

            System.Threading.Thread.Sleep(10000)

            WebBrowser1.ScriptErrorsSuppressed = True

            '  WebBrowser1.Navigate("https://econsigmb.papem.mar.mil.br/mb")

            While WebBrowser1.ReadyState <> WebBrowserReadyState.Complete
                Application.DoEvents()
            End While

            WebBrowser1.Document.GetElementById("senha").SetAttribute("value", 1)
            ''   WebBrowser1.Document.GetElementById("txtPassword").SetAttribute("value", "kieranw")

            ' '' ''Dim allImgTags As HtmlElementCollection = WebBrowser1.Document.GetElementsByTagName("input")
            ' '' '' '' Dim allImgTags As HtmlElementCollection = WebBrowser1.Document.All


            ' '' ''For Each img As HtmlElement In allImgTags
            ' '' ''    If img.GetAttribute("src").Contains("/img/login/ok.gif") Then
            ' '' ''        ' img.Focus()
            ' '' ''        img.InvokeMember("click")
            ' '' ''        '  Exit For




            ' '' ''        ''MessageBox.Show("aguarde...")

            ' '' ''        'ElseIf img.GetAttribute("src").Contains("ok.gif") Then
            ' '' ''        '    img.InvokeMember("click")



            ' '' ''    End If
            ' '' ''Next img


        Catch ex As Exception

            MsgBox("merda", ex.Message)

        End Try

    End Function



End Class