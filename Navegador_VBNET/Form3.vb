Imports System
Imports System.IO
Imports System.Collections

Public Class Form3

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim allements As HtmlElementCollection = WebBrowser1.Document.All

        Dim teste As String

        For Each merda As HtmlElement In allements

            ListBox1.Items.Add(merda.GetAttribute("src"))
        Next
        ''https://www.youtube.com/watch?v=xYPbtXCV--c
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '  WebBrowser1.Navigate("www.youtube.com")

        ''Dim objReader As New StreamReader("C:\Users\JRCWRXG\Desktop\face.txt")
        ''Dim sLine As String = ""
        Dim arrText As New ArrayList()


        ''Do
        ''    sLine = objReader.ReadLine()
        ''    If Not sLine Is Nothing Then
        ''        arrText.Add(sLine)
        ''    End If
        ''Loop Until sLine Is Nothing
        ''objReader.Close()

        ''For Each sLine In arrText
        ''    ''Console.WriteLine(sLine)
        ''Next
        ' ''     Console.ReadLine()


        Using MyReader As New Microsoft.VisualBasic.
                       FileIO.TextFieldParser(
                         "C:\Users\JRCWRXG\Desktop\face.txt")
            MyReader.TextFieldType = FileIO.FieldType.Delimited
            MyReader.SetDelimiters(",")
            Dim currentRow As String()
            Dim valor As String
            Dim i As Integer = 0

            While Not MyReader.EndOfData
                Try
                    currentRow = MyReader.ReadFields()
                    Dim currentField As String
                    For Each currentField In currentRow

                        'https://docs.microsoft.com/pt-br/dotnet/visual-basic/developing-apps/programming/drives-directories-files/how-to-read-from-comma-delimited-text-files

                        i = i + 1
                        valor = currentField.Substring(0, 15)

                        arrText.Add(valor)


                        '    ListBox1.Items.Add(valor)

                        '                        System.Diagnostics.Process.Start("https://www.facebook.com/" + valor)

                        ''MsgBox(valor)

                        'If i = 10 Then

                        '    Stop
                        '    i = 0
                        'End If
                    Next



                    Label1.Text = Convert.ToString(i)


                Catch ex As Microsoft.VisualBasic.
                            FileIO.MalformedLineException
                    MsgBox("Line " & ex.Message &
                    "is not valid and will be skipped.")
                End Try
            End While
        End Using




    End Sub
End Class