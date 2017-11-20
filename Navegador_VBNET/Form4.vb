
Public Class Form4

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        '' WebBrowser1.Navigate(TextBox1.Text)

        Login_Usu()
    End Sub


    Private Sub WebBrowser1_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted

        ' '' '' ''Dim PaginasElementos As HtmlElementCollection = WebBrowser1.Document.GetElementsByTagName("img")

        ' '' '' ''For Each elementos As HtmlElement In PaginasElementos

        ' '' '' ''    TextBox2.Text = TextBox2.Text & elementos.GetAttribute("src") & Environment.NewLine


        ' '' '' ''Next


        ''  Login_Usu()





        Login_Senha()


        If WebBrowser1.Document.Window.Frames.Count <> 0 Then
            fnInsertSecondPasswordFrame(WebBrowser1, "senha2aAutorizacao")
        End If






     

        '' ''Dim allImgTags As HtmlElementCollection = WebBrowser1.Document.GetElementsByTagName("input")




        '' ''For Each elem As HtmlElement In allImgTags
        '' ''    If elem.Name = "xxxx" Then
        '' ''        WebBrowser1.Document.GetElementById("username").SetAttribute("Value", 111)
        '' ''    ElseIf elem.Name = "senha" Then
        '' ''        'webBrowser1.Document.GetElementById("senha").SetAttribute("Value", strSenhaSite)
        '' ''        WebBrowser1.Document.GetElementById("senha").Focus()

        '' ''        WebBrowser1.Document.GetElementById("senha").SetAttribute("value", 1)

        '' ''    End If

        '' ''Next





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






            'For Each elem As HtmlElement In allImgTags
            '    If elem.Name = "xxxx" Then
            '        WebBrowser1.Document.GetElementById("username").SetAttribute("Value", 111)
            '    ElseIf elem.Name = "senha" Then
            '        'webBrowser1.Document.GetElementById("senha").SetAttribute("Value", strSenhaSite)
            '        WebBrowser1.Document.GetElementById("senha").Focus()

            '        WebBrowser1.Document.GetElementById("senha").SetAttribute("value", 1)

            '    End If

            'Next


        Catch ex As Exception

            MsgBox("merda", ex.Message)

        End Try

    End Function












    Public Function Login_Senha()

        Dim allImgTags As HtmlElementCollection = WebBrowser1.Document.GetElementsByTagName("input")

        Try

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



    Public Function fnInsertSecondPasswordFrame(ByRef wb As WebBrowser, ByVal controlName As String, Optional ByVal idSite As Integer = Nothing)

        fnInsertSecondPasswordFrame = Nothing

        Try
            For Each frame As HtmlWindow In wb.Document.Window.Frames

                If frame.Name = "mainFrame" Then
                    Dim doc As HtmlDocument = wb.Document.Window.Frames("mainFrame").Document
                    Dim elemCol As HtmlElementCollection = doc.GetElementsByTagName("input")

                    For Each elem As HtmlElement In elemCol
                        If elem.Name = controlName And elem.GetAttribute("Value") = "" Then
                            'alteracao necessria para resolver problema segunda senha, teve que simular a entrada de caracteres via teclado(sendkeys para alguns casos)

                            If idSite = 30 Then
                                '''  elem.SetAttribute("Valeu", strSenhaSite)
                            Else

                                elem.Focus()
                                '''    SendKeys.Send(strSenhaSite)

                            End If
                            Exit Function

                        End If
                    Next

                End If

            Next

        Catch ex As Exception

        End Try

    End Function


  
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class