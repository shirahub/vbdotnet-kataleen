Public Class Form1

    Private Sub readRandomSentence()
        Dim filePath As String = "C:\TestFolder\test.txt"
        Dim lineCount = System.IO.File.ReadAllLines(filePath).Length
        Using MyReader As New Microsoft.VisualBasic.
                      FileIO.TextFieldParser(filePath)
            MyReader.TextFieldType = FileIO.FieldType.Delimited
            MyReader.SetDelimiters("|")

            Dim rand As New Random()
            Dim randomNumber As Integer = rand.Next(lineCount) + 1
            Dim currentLineNumber As Integer = 1
            Dim currentRow As String()

            While currentLineNumber <= randomNumber
                Try
                    currentRow = MyReader.ReadFields()
                    If randomNumber = currentLineNumber Then
                        txtInspirasi.Text = currentRow(0)
                        txtLatarBelakang.Text = currentRow(1)
                        txtKelanjutan.Text = currentRow(2)
                    End If
                    currentLineNumber += 1
                Catch ex As Microsoft.VisualBasic.
                            FileIO.MalformedLineException
                    MsgBox("Line " & ex.Message &
                    "is not valid and will be skipped.")
                End Try
            End While
        End Using
    End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        readRandomSentence()
    End Sub

    Private Sub btnRandom_Click(sender As Object, e As EventArgs) Handles btnRandom.Click
        readRandomSentence()
    End Sub

    Private Sub TentangKataLeenToolStripMenuItem_Click(sender As Object, e As EventArgs)
        'Dim aboutBoxForm As New AboutBox1()

        ' Tampilkan AboutBox sebagai dialog
        'aboutBoxForm.ShowDialog()
    End Sub

End Class
