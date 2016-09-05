Public Class Form4

    Private Sub ReadFilePoints()

        Using FSavePoints As New Microsoft.VisualBasic.
            FileIO.TextFieldParser(My.Computer.FileSystem.CurrentDirectory & "\SavePoints.save")

            FSavePoints.TextFieldType = FileIO.FieldType.Delimited
            FSavePoints.SetDelimiters(vbTab)

            Dim TextFPoints = {FSavePoints.ReadFields(), FSavePoints.ReadFields(), FSavePoints.ReadFields(), _
                FSavePoints.ReadFields(), FSavePoints.ReadFields(), FSavePoints.ReadFields(), _
                FSavePoints.ReadFields(), FSavePoints.ReadFields(), FSavePoints.ReadFields(), FSavePoints.ReadFields()}

            Dim TableStTextBox1 = {TextBox1, TextBox2, TextBox3, TextBox4, TextBox5, _
                                   TextBox6, TextBox7, TextBox8, TextBox9, TextBox10}
            Dim TableStLabel2 = {Label2_1, Label2_2, Label2_3, Label2_4, Label2_5, _
                                 Label2_6, Label2_7, Label2_8, Label2_9, Label2_10}
            Dim TableStLabel3 = {Label3_1, Label3_2, Label3_3, Label3_4, Label3_5, _
                                 Label3_6, Label3_7, Label3_8, Label3_9, Label3_10}
            Dim TableStLabel4 = {Label4_1, Label4_2, Label4_3, Label4_4, Label4_5, _
                                 Label4_6, Label4_7, Label4_8, Label4_9, Label4_10}
            Dim TableStLabel6 = {Label6_1, Label6_2, Label6_3, Label6_4, Label6_5, _
                                 Label6_6, Label6_7, Label6_8, Label6_9, Label6_10}
            Dim i, j As Integer

            While i <= 9 And j <= 9
                If Points > TextFPoints(i)(1) And ptb = False Then
                    TableStTextBox1(i).ForeColor = Color.GreenYellow
                    TableStTextBox1(i).ReadOnly = False
                    TableStTextBox1(i).TabStop = True
                    TableStLabel2(i).Text = Points
                    TableStLabel2(i).ForeColor = Color.GreenYellow
                    TableStLabel3(i).Text = GeneralT
                    TableStLabel3(i).ForeColor = Color.GreenYellow
                    TableStLabel4(i).Text = GeneralCl
                    TableStLabel4(i).ForeColor = Color.GreenYellow
                    TableStLabel6(i).Text = Slojnost
                    TableStLabel6(i).ForeColor = Color.GreenYellow
                    ptb = True
                    i += 1
                Else
                    TableStTextBox1(i).Text = TextFPoints(j)(0)
                    TableStLabel2(i).Text = TextFPoints(j)(1)
                    TableStLabel3(i).Text = TextFPoints(j)(2)
                    TableStLabel4(i).Text = TextFPoints(j)(3)
                    TableStLabel6(i).Text = TextFPoints(j)(4)
                    j += 1
                    i += 1
                End If
            End While

        End Using
    End Sub
    Private Sub SaveFile()
        If TextBox1.Text = "Введіть ваше ім'я" Or TextBox2.Text = "Введіть ваше ім'я" Or TextBox3.Text = "Введіть ваше ім'я" Or _
            TextBox4.Text = "Введіть ваше ім'я" Or TextBox5.Text = "Введіть ваше ім'я" Or TextBox6.Text = "Введіть ваше ім'я" Or _
            TextBox7.Text = "Введіть ваше ім'я" Or TextBox8.Text = "Введіть ваше ім'я" Or TextBox9.Text = "Введіть ваше ім'я" Or _
            TextBox10.Text = "Введіть ваше ім'я" Then
            MsgBox("Введіть ваше ім'я у полі результатів", vbOKOnly & vbCritical, "Заповніть поле")
        Else
            My.Computer.FileSystem.DeleteFile(My.Computer.FileSystem.CurrentDirectory & "\SavePoints.save")
            My.Computer.FileSystem.WriteAllText(My.Computer.FileSystem.CurrentDirectory & "\SavePoints.save", _
                        TextBox1.Text & vbTab & Label2_1.Text & vbTab & Label3_1.Text & vbTab & Label4_1.Text & vbTab & Label6_1.Text & vbCrLf & _
                        TextBox2.Text & vbTab & Label2_2.Text & vbTab & Label3_2.Text & vbTab & Label4_2.Text & vbTab & Label6_2.Text & vbCrLf & _
                        TextBox3.Text & vbTab & Label2_3.Text & vbTab & Label3_3.Text & vbTab & Label4_3.Text & vbTab & Label6_3.Text & vbCrLf & _
                        TextBox4.Text & vbTab & Label2_4.Text & vbTab & Label3_4.Text & vbTab & Label4_4.Text & vbTab & Label6_4.Text & vbCrLf & _
                        TextBox5.Text & vbTab & Label2_5.Text & vbTab & Label3_5.Text & vbTab & Label4_5.Text & vbTab & Label6_5.Text & vbCrLf & _
                        TextBox6.Text & vbTab & Label2_6.Text & vbTab & Label3_6.Text & vbTab & Label4_6.Text & vbTab & Label6_6.Text & vbCrLf & _
                        TextBox7.Text & vbTab & Label2_7.Text & vbTab & Label3_7.Text & vbTab & Label4_7.Text & vbTab & Label6_7.Text & vbCrLf & _
                        TextBox8.Text & vbTab & Label2_8.Text & vbTab & Label3_8.Text & vbTab & Label4_8.Text & vbTab & Label6_8.Text & vbCrLf & _
                        TextBox9.Text & vbTab & Label2_9.Text & vbTab & Label3_9.Text & vbTab & Label4_9.Text & vbTab & Label6_9.Text & vbCrLf & _
                        TextBox10.Text & vbTab & Label2_10.Text & vbTab & Label3_10.Text & vbTab & Label4_10.Text & vbTab & Label6_10.Text & vbCrLf, True)
        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        SaveFile()
        Me.Close()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        SaveFile()
        Form3.Close()
    End Sub
    Private Sub Form4_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If Form1Visible = False Then
            Form3.Show()
        End If
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form3.Show()
        Me.Close()
    End Sub
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ReadFilePoints()
    End Sub
End Class