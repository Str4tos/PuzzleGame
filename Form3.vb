Public Class Form3
    Dim lvl As Integer
    Dim PictureBoxMas1 = {Nothing, Form2.PictureBox1, Form2.PictureBox2, Form2.PictureBox3, Form2.PictureBox4, Form2.PictureBox5, _
                        Form2.PictureBox6, Form2.PictureBox7, Form2.PictureBox8, Form2.PictureBox9, Form2.PictureBox10, _
                        Form2.PictureBox11, Form2.PictureBox12, Form2.PictureBox13, Form2.PictureBox14, Form2.PictureBox15, _
                        Form2.PictureBox16}
    Dim PictureBoxMas2 = {Nothing, Form2.PictureBox2_1, Form2.PictureBox2_2, Form2.PictureBox2_3, Form2.PictureBox2_4, _
                        Form2.PictureBox2_5, Form2.PictureBox2_6, Form2.PictureBox2_7, Form2.PictureBox2_8, Form2.PictureBox2_9}


    Private Sub Visible1()
        Label4.Visible = True
        Label5.Visible = True
        Label6.Visible = True
        Label3.Visible = True
        CheckBox1.Visible = True
        CheckBox2.Visible = True
        Label7.Visible = False
        Timer1.Enabled = False
    End Sub
    Private Sub CheckNextStep()
        ChNextS = 0
        If RadioButton1.Checked = False And RadioButton2.Checked = False And RadioButton3.Checked = False And RadioButton4.Checked = False Then
            MsgBox("Виберіть складність для продовження", vbCritical, "Помилка")
        ElseIf RadioButton3.Checked = True And CheckBox1.Checked = False And CheckBox2.Checked = False Or
            RadioButton4.Checked = True And CheckBox1.Checked = False And CheckBox2.Checked = False Then
            MsgBox("Виберіть хочаб одну вимогу", vbCritical, "Помилка")
        Else
            ChNextS = 1
        End If
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Select Case lvl
            Case 0
                Label7.ForeColor = Color.Gainsboro
            Case 1
                Label7.ForeColor = Color.GreenYellow
        End Select
        If lvl < 2 Then
            lvl += 1
        Else
            lvl = 0
        End If
    End Sub

    Private Sub Form3_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Dim ExitForm = MsgBox("Ви дійсно бажаєте вийти?", vbYesNo + vbQuestion, "Вихід")
        If (ExitForm = Windows.Forms.DialogResult.No) Then
            e.Cancel = True
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        CheckNextStep()
        If ChNextS = 1 Then

            If RadioButton1.Checked = True Then
                Dim Resources1_1 = {Nothing, My.Resources._1_1, My.Resources._1_2, My.Resources._1_3, _
                                    My.Resources._1_4, My.Resources._1_5, My.Resources._1_6, _
                                    My.Resources._1_7, My.Resources._1_8, My.Resources._1_9}
                For i = 1 To 9
                    PictureBoxMas2(i).image = New Bitmap(Resources1_1(i))
                Next
            Else
                Dim Resources1 = {Nothing, My.Resources._1, My.Resources._2, My.Resources._3, My.Resources._4, _
                                 My.Resources._5, My.Resources._6, My.Resources._7, My.Resources._8, _
                                 My.Resources._9, My.Resources._10, My.Resources._11, My.Resources._12, _
                                 My.Resources._13, My.Resources._14, My.Resources._15, My.Resources._16}
                For i = 1 To 16
                    PictureBoxMas1(i).image = New Bitmap(Resources1(i))
                Next
            End If
            Me.Hide()
            Form1.Show()

        End If
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        CheckNextStep()
        If ChNextS = 1 Then
            If RadioButton1.Checked = True Then
                Dim Resources1_1 = {Nothing, My.Resources._2_1, My.Resources._2_2, My.Resources._2_3, _
                                    My.Resources._2_4, My.Resources._2_5, My.Resources._2_6, _
                                    My.Resources._2_7, My.Resources._2_8, My.Resources._2_9}
                For i = 1 To 9
                    PictureBoxMas2(i).image = New Bitmap(Resources1_1(i))
                Next
            Else
                Dim Resources1 = {Nothing, My.Resources._21, My.Resources._22, My.Resources._23, My.Resources._24, _
                                 My.Resources._25, My.Resources._26, My.Resources._27, My.Resources._28, _
                                 My.Resources._29, My.Resources._210, My.Resources._211, My.Resources._212, _
                                 My.Resources._213, My.Resources._214, My.Resources._215, My.Resources._216}
                For i = 1 To 16
                    PictureBoxMas1(i).image = New Bitmap(Resources1(i))
                Next
            End If
            Me.Hide()
            Form1.Show()
        End If
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        CheckNextStep()
        If ChNextS = 1 Then
            If RadioButton1.Checked = True Then
                Dim Resources1_1 = {Nothing, My.Resources._3_1, My.Resources._3_2, My.Resources._3_3, _
                                    My.Resources._3_4, My.Resources._3_5, My.Resources._3_6, _
                                    My.Resources._3_7, My.Resources._3_8, My.Resources._3_9}
                For i = 1 To 9
                    PictureBoxMas2(i).image = New Bitmap(Resources1_1(i))
                Next
            Else
                Dim Resources1 = {Nothing, My.Resources._31, My.Resources._32, My.Resources._33, My.Resources._34, _
                                 My.Resources._35, My.Resources._36, My.Resources._37, My.Resources._38, _
                                 My.Resources._39, My.Resources._310, My.Resources._311, My.Resources._312, _
                                 My.Resources._313, My.Resources._314, My.Resources._315, My.Resources._316}
                For i = 1 To 16
                    PictureBoxMas1(i).image = New Bitmap(Resources1(i))
                Next
            End If
            Me.Hide()
            Form1.Show()
        End If
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        CheckNextStep()
        If ChNextS = 1 Then
            If RadioButton1.Checked = True Then
                Dim Resources1_1 = {Nothing, My.Resources._4_1, My.Resources._4_2, My.Resources._4_3, _
                                    My.Resources._4_4, My.Resources._4_5, My.Resources._4_6, _
                                    My.Resources._4_7, My.Resources._4_8, My.Resources._4_9}
                For i = 1 To 9
                    PictureBoxMas2(i).image = New Bitmap(Resources1_1(i))
                Next
            Else
                Dim Resources1 = {Nothing, My.Resources._41, My.Resources._42, My.Resources._43, My.Resources._44, _
                                 My.Resources._45, My.Resources._46, My.Resources._47, My.Resources._48, _
                                 My.Resources._49, My.Resources._410, My.Resources._411, My.Resources._412, _
                                 My.Resources._413, My.Resources._414, My.Resources._415, My.Resources._416}
                For i = 1 To 16
                    PictureBoxMas1(i).image = New Bitmap(Resources1(i))
                Next
            End If
            Me.Hide()
            Form1.Show()
        End If
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        CheckNextStep()
        If ChNextS = 1 Then
            If RadioButton1.Checked = True Then
                Dim Resources1_1 = {Nothing, My.Resources._8_1, My.Resources._8_2, My.Resources._8_3, _
                                    My.Resources._8_4, My.Resources._8_5, My.Resources._8_6, _
                                    My.Resources._8_7, My.Resources._8_8, My.Resources._8_9}
                For i = 1 To 9
                    PictureBoxMas2(i).image = New Bitmap(Resources1_1(i))
                Next
            Else
                Dim Resources1 = {Nothing, My.Resources._81, My.Resources._82, My.Resources._83, My.Resources._84, _
                                 My.Resources._85, My.Resources._86, My.Resources._87, My.Resources._88, _
                                 My.Resources._89, My.Resources._810, My.Resources._811, My.Resources._812, _
                                 My.Resources._813, My.Resources._814, My.Resources._815, My.Resources._816}
                For i = 1 To 16
                    PictureBoxMas1(i).image = New Bitmap(Resources1(i))
                Next
            End If
            Me.Hide()
            Form1.Show()
        End If
    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        CheckNextStep()
        If ChNextS = 1 Then
            If RadioButton1.Checked = True Then
                Dim Resources1_1 = {Nothing, My.Resources._6_1, My.Resources._6_2, My.Resources._6_3, _
                                    My.Resources._6_4, My.Resources._6_5, My.Resources._6_6, _
                                    My.Resources._6_7, My.Resources._6_8, My.Resources._6_9}
                For i = 1 To 9
                    PictureBoxMas2(i).image = New Bitmap(Resources1_1(i))
                Next
            Else
                Dim Resources1 = {Nothing, My.Resources._61, My.Resources._62, My.Resources._63, My.Resources._64, _
                                 My.Resources._65, My.Resources._66, My.Resources._67, My.Resources._68, _
                                 My.Resources._69, My.Resources._610, My.Resources._611, My.Resources._612, _
                                 My.Resources._613, My.Resources._614, My.Resources._615, My.Resources._616}
                For i = 1 To 16
                    PictureBoxMas1(i).image = New Bitmap(Resources1(i))
                Next
            End If
            Me.Hide()
            Form1.Show()
        End If
    End Sub
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        CheckNextStep()
        If ChNextS = 1 Then
            If RadioButton1.Checked = True Then
                Dim Resources1_1 = {Nothing, My.Resources._7_1, My.Resources._7_2, My.Resources._7_3, _
                                    My.Resources._7_4, My.Resources._7_5, My.Resources._7_6, _
                                    My.Resources._7_7, My.Resources._7_8, My.Resources._7_9}
                For i = 1 To 9
                    PictureBoxMas2(i).image = New Bitmap(Resources1_1(i))
                Next
            Else
                Dim Resources1 = {Nothing, My.Resources._71, My.Resources._72, My.Resources._73, My.Resources._74, _
                                 My.Resources._75, My.Resources._76, My.Resources._77, My.Resources._78, _
                                 My.Resources._79, My.Resources._710, My.Resources._711, My.Resources._712, _
                                 My.Resources._713, My.Resources._714, My.Resources._715, My.Resources._716}
                For i = 1 To 16
                    PictureBoxMas1(i).image = New Bitmap(Resources1(i))
                Next
            End If
            Me.Hide()
            Form1.Show()
        End If
    End Sub
    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        CheckNextStep()
        If ChNextS = 1 Then
            If RadioButton1.Checked = True Then
                Dim Resources1_1 = {Nothing, My.Resources._5_1, My.Resources._5_2, My.Resources._5_3, _
                                    My.Resources._5_4, My.Resources._5_5, My.Resources._5_6, _
                                    My.Resources._5_7, My.Resources._5_8, My.Resources._5_9}
                For i = 1 To 9
                    PictureBoxMas2(i).image = New Bitmap(Resources1_1(i))
                Next
            Else
                Dim Resources1 = {Nothing, My.Resources._51, My.Resources._52, My.Resources._53, My.Resources._54, _
                                 My.Resources._55, My.Resources._56, My.Resources._57, My.Resources._58, _
                                 My.Resources._59, My.Resources._510, My.Resources._511, My.Resources._512, _
                                 My.Resources._513, My.Resources._514, My.Resources._515, My.Resources._516}
                For i = 1 To 16
                    PictureBoxMas1(i).image = New Bitmap(Resources1(i))
                Next
            End If
            Me.Hide()
            Form1.Show()
        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        Visible1()
        CheckBox1.Text = "не обмежено"
        CheckBox2.Text = "не обмежено"
        Label6.Text = "Розмір: 3х3" & vbNewLine & "Максимально балів: 3000"
    End Sub
    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        Visible1()
        CheckBox1.Text = "не обмежено"
        CheckBox2.Text = "не обмежено"
        Label6.Text = "Розмір: 4х4" & vbNewLine & "Максимально балів: 4000"
    End Sub
    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        Visible1()
        CheckBox1.Text = "400 сек."
        CheckBox2.Text = "250"
        Label6.Text = "Розмір: 4х4" & vbNewLine & "Максимально балів: 4500"
    End Sub
    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        Visible1()
        CheckBox1.Text = "200 сек"
        CheckBox2.Text = "150"
        Label6.Text = "Розмір: 4х4" & vbNewLine & "Максимально балів: 5500"
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        System.Diagnostics.Process.Start(My.Computer.FileSystem.CurrentDirectory & "\Help.hlp")
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class