Public Class Form1

    Dim filePath As String = "C:\TestFolder\test.txt"
    Dim randomNumber As Integer

    Private Sub readRandomSentence()

        Dim lineCount = System.IO.File.ReadAllLines(filePath).Length
        Using MyReader As New Microsoft.VisualBasic.
                      FileIO.TextFieldParser(filePath)
            MyReader.TextFieldType = FileIO.FieldType.Delimited
            MyReader.SetDelimiters("|")

            Dim rand As New Random()
            randomNumber = rand.Next(lineCount) + 1
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

    Private Sub readLastAddedSentence()

        Dim lineCount = System.IO.File.ReadAllLines(filePath).Length
        Using MyReader As New Microsoft.VisualBasic.
                      FileIO.TextFieldParser(filePath)
            MyReader.TextFieldType = FileIO.FieldType.Delimited
            MyReader.SetDelimiters("|")

            Dim currentLineNumber As Integer = 1
            Dim currentRow As String()

            While Not currentLineNumber = lineCount
                Try
                    currentRow = MyReader.ReadFields()
                    If lineCount = currentLineNumber Then
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
        btnSimpan.Visible = False
        readRandomSentence()
    End Sub

    Private Sub btnRandom_Click(sender As Object, e As EventArgs) Handles btnRandom.Click
        btnSimpan.Visible = False
        readRandomSentence()
    End Sub

    Private Sub TentangKataLeenToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles TentangKataLeenToolStripMenuItem.Click
        Dim aboutBoxForm As New AboutBox1()

        ' Tampilkan AboutBox sebagai dialog
        aboutBoxForm.ShowDialog()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnUbahKatalis1.Click
        deleteAndAddSentence(txtInspirasi.Text, txtLatarBelakang.Text, txtKelanjutan.Text)
    End Sub

    Private Sub addSentence(text1 As String, text2 As String, text3 As String)
        Try
            Dim newLine As String = String.Join("|", {text1, text2, text3})
            Dim lines As List(Of String) = System.IO.File.ReadAllLines(filePath).ToList
            lines.Add(newLine)
            System.IO.File.WriteAllLines(filePath, lines)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        readLastAddedSentence()
    End Sub

    Private Sub deleteAndAddSentence(text1 As String, text2 As String, text3 As String)
        'MsgBox(String.Format("{0} {1} {2} {3}", randomNumber, text1, text2, text3))
        Try
            Dim newLine As String = String.Join("|", {text1, text2, text3})
            'MsgBox(newLine)
            Dim lines As List(Of String) = System.IO.File.ReadAllLines(filePath).ToList
            lines.RemoveAt(randomNumber - 1) ' index starts at 0 
            lines.Add(newLine)
            System.IO.File.WriteAllLines(filePath, lines)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        readLastAddedSentence()
    End Sub

    Private Sub txtUbahKatalis2_Click(sender As Object, e As EventArgs) Handles btnUbahKatalis2.Click
        deleteAndAddSentence(txtInspirasi.Text, txtLatarBelakang.Text, txtKelanjutan.Text)
    End Sub

    Private Sub txtUbahKatalis3_Click(sender As Object, e As EventArgs) Handles btnUbahKatalis3.Click
        deleteAndAddSentence(txtInspirasi.Text, txtLatarBelakang.Text, txtKelanjutan.Text)
    End Sub

    Private Sub BuatKatalisBaruToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BuatKatalisBaruToolStripMenuItem.Click
        txtInspirasi.Text = ""
        txtLatarBelakang.Text = ""
        txtKelanjutan.Text = ""
        btnUbahKatalis1.Visible = False
        btnUbahKatalis2.Visible = False
        btnUbahKatalis3.Visible = False

        btnSimpan.Visible = True
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click

        If String.IsNullOrWhiteSpace(txtInspirasi.Text) Then
            MessageBox.Show("Inspirasi Tidak Boleh Kosong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            addSentence(txtInspirasi.Text, txtLatarBelakang.Text, txtKelanjutan.Text)
            btnSimpan.Visible = False
            btnUbahKatalis1.Visible = True
            btnUbahKatalis2.Visible = True
            btnUbahKatalis3.Visible = True
        End If

    End Sub

    Private Sub KeluarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KeluarToolStripMenuItem.Click
        Application.Exit()
    End Sub
End Class
