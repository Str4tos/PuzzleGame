Public Class Form1
    
    Private Sub MapLoad()

        Dim ButtonMas2_1 = {Nothing, Button2_1, Button2_2, Button2_3, Button2_4, Button2_5, _
                                Button2_6, Button2_7, Button2_8, Button2_9}
        Dim PictureBoxMas2_1 = {Nothing, Form2.PictureBox2_1, Form2.PictureBox2_2, Form2.PictureBox2_3, Form2.PictureBox2_4, _
                    Form2.PictureBox2_5, Form2.PictureBox2_6, Form2.PictureBox2_7, Form2.PictureBox2_8, Form2.PictureBox2_9}
        Dim ButtonMas1_1 = {Nothing, Button1, Button2, Button3, Button4, Button5, _
                    Button6, Button7, Button8, Button9, Button10, Button11, _
                    Button12, Button13, Button14, Button15, Button16}
        Dim PictureBoxMas1_1 = {Nothing, Form2.PictureBox1, Form2.PictureBox2, Form2.PictureBox3, Form2.PictureBox4, Form2.PictureBox5, _
                    Form2.PictureBox6, Form2.PictureBox7, Form2.PictureBox8, Form2.PictureBox9, Form2.PictureBox10, _
                    Form2.PictureBox11, Form2.PictureBox12, Form2.PictureBox13, Form2.PictureBox14, Form2.PictureBox15, _
                    Form2.PictureBox16}

        If Form3.RadioButton1.Checked = True Then

            For i = 1 To 16
                ButtonMas1_1(i).Visible = False
                PictureBoxMas1_1(i).Visible = False
                If i <= 9 Then
                    ButtonMas2_1(i).Visible = True
                    PictureBoxMas2_1(i).Visible = True
                    ButtonMas2_1(i).BackgroundImage = PictureBoxMas2_1(i).Image
                End If
            Next

            Slojnost = "Легко"
            LabelLVL.Text = Slojnost
        Else

            For i = 1 To 16
                ButtonMas1_1(i).Visible = True
                PictureBoxMas1_1(i).Visible = True
                ButtonMas1_1(i).BackgroundImage = PictureBoxMas1_1(i).Image
                If i <= 9 Then
                    ButtonMas2_1(i).Visible = False
                    PictureBoxMas2_1(i).Visible = False
                End If
            Next

            If Form3.RadioButton2.Checked = True Then
                Slojnost = "Нормально"
                LabelLVL.Text = Slojnost
            ElseIf Form3.RadioButton3.Checked = True Then
                If Form3.CheckBox1.Checked = True Then
                    WinStatTime = 400
                End If
                If Form3.CheckBox2.Checked = True Then
                    WinStatClick = 250
                End If
                Slojnost = "Важко"
                LabelLVL.Text = Slojnost
            ElseIf Form3.RadioButton4.Checked = True Then
                If Form3.CheckBox1.Checked = True Then
                    WinStatTime = 200
                End If
                If Form3.CheckBox2.Checked = True Then
                    WinStatClick = 150
                End If
                Slojnost = "Дуже важко"
                LabelLVL.Text = Slojnost
            End If
        End If

    End Sub
    Private Sub Start()
        Dim i, j, RN As Integer
        Dim flag As Boolean
        Dim a(16) As String
        Dim b(16) As Bitmap
        Dim GeneralMap = {Nothing, _
                    New Bitmap(Form2.PictureBox1.Image), New Bitmap(Form2.PictureBox2.Image), _
                    New Bitmap(Form2.PictureBox3.Image), New Bitmap(Form2.PictureBox4.Image), _
                    New Bitmap(Form2.PictureBox5.Image), New Bitmap(Form2.PictureBox6.Image), _
                    New Bitmap(Form2.PictureBox7.Image), New Bitmap(Form2.PictureBox8.Image), _
                    New Bitmap(Form2.PictureBox9.Image), New Bitmap(Form2.PictureBox10.Image), _
                    New Bitmap(Form2.PictureBox11.Image), New Bitmap(Form2.PictureBox12.Image), _
                    New Bitmap(Form2.PictureBox13.Image), New Bitmap(Form2.PictureBox14.Image), _
                    New Bitmap(Form2.PictureBox15.Image), Nothing}
        Dim ButtonMas1_1 = {Nothing, Button1, Button2, Button3, Button4, Button5, _
                   Button6, Button7, Button8, Button9, Button10, Button11, _
                   Button12, Button13, Button14, Button15, Button16}

        GeneralCl = 0
        GeneralT = 0
        flag = False
        i = 1
        a(j) = Nothing

        Do While i <= 16
            Randomize()
            RN = CInt(Int((16 * Rnd()) + 1))

            For j = 1 To i
                If a(j) = Nothing Then
                Else
                    If (a(j) = Map(RN)) Then
                        flag = True
                        Exit For
                    End If
                End If
            Next j

            If flag = True Then
                flag = False
            Else
                a(i) = Map(RN)
                b(i) = GeneralMap(RN)

                i += 1
            End If
        Loop

        For i = 1 To 16
            ButtonMas1_1(i).Text = a(i)
            ButtonMas1_1(i).BackgroundImage = b(i)
        Next

    End Sub
    Private Sub Start3x3()
        Dim i, j, RN As Integer
        Dim flag As Boolean
        Dim a(9) As String
        Dim b(9) As Bitmap
        Dim GeneralMap3x3 = {Nothing, _
                    New Bitmap(Form2.PictureBox2_1.Image), New Bitmap(Form2.PictureBox2_2.Image), _
                    New Bitmap(Form2.PictureBox2_3.Image), New Bitmap(Form2.PictureBox2_4.Image), _
                    New Bitmap(Form2.PictureBox2_5.Image), New Bitmap(Form2.PictureBox2_6.Image), _
                    New Bitmap(Form2.PictureBox2_7.Image), New Bitmap(Form2.PictureBox2_8.Image), _
                    Nothing}
        Dim ButtonMas2_1 = {Nothing, Button2_1, Button2_2, Button2_3, Button2_4, Button2_5, _
                               Button2_6, Button2_7, Button2_8, Button2_9}

        GeneralCl = 0
        GeneralT = 0
        flag = False
        i = 1
        a(j) = Nothing

        Do While i <= 9
            Randomize()
            RN = CInt(Int((9 * Rnd()) + 1))

            For j = 1 To i
                If a(j) = Nothing Then
                Else
                    If (a(j) = Map3x3(RN)) Then
                        flag = True
                        Exit For
                    End If
                End If
            Next j

            If flag = True Then
                flag = False
            Else
                a(i) = Map3x3(RN)
                b(i) = GeneralMap3x3(RN)
                i += 1
            End If
        Loop

        For i = 1 To 9
            ButtonMas2_1(i).Text = a(i)
            ButtonMas2_1(i).BackgroundImage = b(i)
        Next

    End Sub
    Public Sub MapPolarPR()
        ChengPolar(Button13, Button1)
        ChengPolar(Button1, Button4)
        ChengPolar(Button4, Button16)
        ChengPolar(Button9, Button2)
        ChengPolar(Button2, Button12)
        ChengPolar(Button12, Button14)
        ChengPolar(Button5, Button3)
        ChengPolar(Button3, Button8)
        ChengPolar(Button8, Button15)
        ChengPolar(Button6, Button11)
        ChengPolar(Button6, Button7)
        ChengPolar(Button10, Button11)

        CheckWinStats()
        Label5.Text = "Виконано: " & ProcWin & "%"
        ProgressGame.Value = ProcWin
        GeneralTimer.Start()
    End Sub
    Private Sub IndexMap()
 
        If Form3.RadioButton1.Checked = False Then
            Dim ButtonMas1_1 = {Nothing, Button1, Button2, Button3, Button4, Button5, _
                    Button6, Button7, Button8, Button9, Button10, Button11, _
                    Button12, Button13, Button14, Button15, Button16}
            If ІндексиПлитокToolStripMenuItem.Checked = False Then
                For i = 1 To 16
                    ButtonMas1_1(i).Font = Label1.Font
                Next
                ІндексиПлитокToolStripMenuItem.Checked = True
                CheckIndex.Checked = True
            Else
                For i = 1 To 16
                    ButtonMas1_1(i).Font = Label2.Font
                Next
                ІндексиПлитокToolStripMenuItem.Checked = False
                CheckIndex.Checked = False
            End If
        Else
            Dim ButtonMas2_1 = {Nothing, Button2_1, Button2_2, Button2_3, Button2_4, Button2_5, _
                               Button2_6, Button2_7, Button2_8, Button2_9}
            If ІндексиПлитокToolStripMenuItem.Checked = False Then
                For i = 1 To 9
                    ButtonMas2_1(i).Font = Label1.Font
                Next
                ІндексиПлитокToolStripMenuItem.Checked = True
                CheckIndex.Checked = True
            Else
                For i = 1 To 9
                    ButtonMas2_1(i).Font = Label2.Font
                Next
                ІндексиПлитокToolStripMenuItem.Checked = False
                CheckIndex.Checked = False
            End If
        End If
    End Sub
    Private Sub CheckWinStats()
        Dim ButtonMas1_1 = {Nothing, Button1, Button2, Button3, Button4, Button5, _
                    Button6, Button7, Button8, Button9, Button10, Button11, _
                    Button12, Button13, Button14, Button15, Button16}
        ProcWin = 0
        For i = 1 To 15
            If ButtonMas1_1(i).Text = Map(i) Then
                ProcWin += 6.5
            End If
        Next

        If ProcWin = 97.5 Then
            If Form3.RadioButton2.Checked = True Then
                Points = 4000 - (GeneralT * 4) - (GeneralCl * 2)
            ElseIf Form3.RadioButton3.Checked = True Then
                Points = 4500 - (GeneralT * 4) - (GeneralCl * 2)
            ElseIf Form3.RadioButton4.Checked = True Then
                Points = 5500 - (GeneralT * 4) - (GeneralCl * 2)
            End If
            EngageWin()

        ElseIf Form3.RadioButton3.Checked = True Or Form3.RadioButton4.Checked = True Then
            If WinStatTime <= GeneralT And GeneralT > 0 Then
                EngageLose()
            ElseIf WinStatClick <= GeneralCl And GeneralCl > 0 Then
                EngageLose()
            End If
        End If

        If ProcWin = 84.5 And Button14.Text = "15" And Button15.Text = "14" Then
            ButtonChPolar.Visible = True
            GeneralTimer.Enabled = False
            Dim MapPolar = MsgBox("Неможливо скласти дану комбінацію розташування плиток." & vbNewLine & _
                   "Щоб продовжити гру треба повернути плитки, для цього натисніть кнопку ""Да"", або почніть гру спочатку натиснувши кнопку ""Нет""." & _
                   vbNewLine & """Отмена"" - вихід.", vbYesNoCancel, "Помилкова комбінація")
            If (MapPolar = Windows.Forms.DialogResult.Yes) Then
                MapPolarPR()
            ElseIf (MapPolar = Windows.Forms.DialogResult.No) Then
                ButtonChPolar.Visible = False
                StartGame()
            ElseIf (MapPolar = Windows.Forms.DialogResult.Cancel) Then
                Form3.Close()
            End If
        End If
    End Sub
    Private Sub CheckWinStats3x3()
        Dim ButtonMas2_1 = {Nothing, Button2_1, Button2_2, Button2_3, Button2_4, Button2_5, _
                               Button2_6, Button2_7, Button2_8, Button2_9}
        ProcWin = 0
        For i = 1 To 8
            If ButtonMas2_1(i).Text = Map3x3(i) Then
                ProcWin += 12.5
            End If
        Next

        If ProcWin = 100 Then
            Points = 3000 - (GeneralT * 4) - (GeneralCl * 2)
            EngageWin()
        End If

        If ProcWin = 75 And Button2_7.Text = "8" And Button2_8.Text = "7" Then
            MsgBox("Неможливо скласти дану комбінацію розташування плиток." & vbNewLine & _
                   "Спробуйте ще раз.", vbOKOnly, "Помилкова комбінація")
            StartGame()
        End If
    End Sub
    Private Sub EngageWin()
        GeneralTimer.Enabled = False
        CheckBox1.Visible = False
        ProgressGame.Value = 100
        Form4.Show()
        Me.Close()


    End Sub
    Private Sub EngageLose()
        GeneralTimer.Enabled = False
        MsgBox("Ви програли!" & vbNewLine & "Використано " & GeneralCl & " переміщень." & vbNewLine & "За " & GeneralT & " сек." & vbNewLine & "Отримано очок: " & Points, vbInformation, "Поразка!")

    End Sub
    Public Sub StartGame()
        If Form3.RadioButton1.Checked = False Then
            Start()
            CheckWinStats()
        Else
            Start3x3()
            CheckWinStats3x3()
        End If
        GeneralTimer.Enabled = True
        CheckBox1.Visible = True
        Label4.Visible = True
        Label5.Visible = True
        Label3.Visible = True
        LabelLVL.Visible = True
        ProgressGame.Visible = True
        Button17.Visible = False

        ПочатиГруToolStripMenuItem.Text = "Почати спочатку"

        Label4.Text = "Перемішень: " & GeneralCl
        Label5.Text = "Виконано: " & ProcWin & "%"
        ProgressGame.Value = ProcWin
    End Sub

    Private Sub Buttons_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click, Button2.Click, Button3.Click, Button4.Click, Button5.Click, Button6.Click, _
        Button7.Click, Button8.Click, Button9.Click, Button10.Click, Button11.Click, Button12.Click, _
        Button13.Click, Button14.Click, Button15.Click, Button16.Click

        If GeneralTimer.Enabled = True Then
            Select Case (sender.name)
                Case "Button1"
                    CheckButton(sender, Button2)
                    CheckButton(sender, Button5)
                Case "Button2"
                    CheckButton(sender, Button1)
                    CheckButton(sender, Button6)
                    CheckButton(sender, Button3)
                Case "Button3"
                    CheckButton(sender, Button2)
                    CheckButton(sender, Button7)
                    CheckButton(sender, Button4)
                Case "Button4"
                    CheckButton(sender, Button3)
                    CheckButton(sender, Button8)
                Case "Button5"
                    CheckButton(sender, Button1)
                    CheckButton(sender, Button6)
                    CheckButton(sender, Button9)
                Case "Button6"
                    CheckButton(sender, Button2)
                    CheckButton(sender, Button5)
                    CheckButton(sender, Button10)
                    CheckButton(sender, Button7)
                Case "Button7"
                    CheckButton(sender, Button3)
                    CheckButton(sender, Button6)
                    CheckButton(sender, Button8)
                    CheckButton(sender, Button11)
                Case "Button8"
                    CheckButton(sender, Button4)
                    CheckButton(sender, Button7)
                    CheckButton(sender, Button12)
                Case "Button9"
                    CheckButton(sender, Button5)
                    CheckButton(sender, Button10)
                    CheckButton(sender, Button13)
                Case "Button10"
                    CheckButton(sender, Button6)
                    CheckButton(sender, Button9)
                    CheckButton(sender, Button14)
                    CheckButton(sender, Button11)
                Case "Button11"
                    CheckButton(sender, Button7)
                    CheckButton(sender, Button10)
                    CheckButton(sender, Button15)
                    CheckButton(sender, Button12)
                Case "Button12"
                    CheckButton(sender, Button8)
                    CheckButton(sender, Button11)
                    CheckButton(sender, Button16)
                Case "Button13"
                    CheckButton(sender, Button9)
                    CheckButton(sender, Button14)
                Case "Button14"
                    CheckButton(sender, Button13)
                    CheckButton(sender, Button10)
                    CheckButton(sender, Button15)
                Case "Button15"
                    CheckButton(sender, Button14)
                    CheckButton(sender, Button16)
                    CheckButton(sender, Button11)
                Case "Button16"
                    CheckButton(sender, Button12)
                    CheckButton(sender, Button15)
            End Select

            Label4.Text = "Перемішень: " & GeneralCl
            CheckWinStats()
            ProgressGame.Value = ProcWin
            Label5.Text = "Виконано: " & ProcWin & "%"
        End If

    End Sub
    Private Sub Buttons3x3_Click(sender As Object, e As EventArgs) _
        Handles Button2_1.Click, Button2_2.Click, Button2_3.Click, Button2_4.Click, Button2_5.Click, _
        Button2_6.Click, Button2_7.Click, Button2_8.Click, Button2_9.Click

        If GeneralTimer.Enabled = True Then
            Select Case (sender.name)
                Case "Button2_1"
                    CheckButton(sender, Button2_2)
                    CheckButton(sender, Button2_4)
                Case "Button2_2"
                    CheckButton(sender, Button2_1)
                    CheckButton(sender, Button2_5)
                    CheckButton(sender, Button2_3)
                Case "Button2_3"
                    CheckButton(sender, Button2_2)
                    CheckButton(sender, Button2_6)
                Case "Button2_4"
                    CheckButton(sender, Button2_1)
                    CheckButton(sender, Button2_5)
                    CheckButton(sender, Button2_7)
                Case "Button2_5"
                    CheckButton(sender, Button2_2)
                    CheckButton(sender, Button2_6)
                    CheckButton(sender, Button2_4)
                    CheckButton(sender, Button2_8)
                Case "Button2_6"
                    CheckButton(sender, Button2_3)
                    CheckButton(sender, Button2_5)
                    CheckButton(sender, Button2_9)
                Case "Button2_7"
                    CheckButton(sender, Button2_4)
                    CheckButton(sender, Button2_8)
                Case "Button2_8"
                    CheckButton(sender, Button2_5)
                    CheckButton(sender, Button2_7)
                    CheckButton(sender, Button2_9)
                Case "Button2_9"
                    CheckButton(sender, Button2_8)
                    CheckButton(sender, Button2_6)
            End Select
            Label4.Text = "Перемішень: " & GeneralCl
            CheckWinStats3x3()
            ProgressGame.Value = ProcWin
            Label5.Text = "Виконано: " & ProcWin & "%"
        End If

    End Sub

    ' Чит удалить
    Private Sub Button1_KeyDown(sender As Object, e As KeyEventArgs) Handles Button1.KeyDown
        If e.KeyCode = Keys.Z Then
            Button1.BackgroundImage = Form2.PictureBox1.Image
            Button2.BackgroundImage = Form2.PictureBox2.Image
            Button3.BackgroundImage = Form2.PictureBox3.Image
            Button4.BackgroundImage = Form2.PictureBox4.Image
            Button5.BackgroundImage = Form2.PictureBox5.Image
            Button6.BackgroundImage = Form2.PictureBox6.Image
            Button7.BackgroundImage = Form2.PictureBox7.Image
            Button8.BackgroundImage = Form2.PictureBox8.Image
            Button9.BackgroundImage = Form2.PictureBox9.Image
            Button10.BackgroundImage = Form2.PictureBox10.Image
            Button11.BackgroundImage = Form2.PictureBox11.Image
            Button12.BackgroundImage = Form2.PictureBox12.Image
            Button13.BackgroundImage = Form2.PictureBox13.Image
            Button14.BackgroundImage = Form2.PictureBox14.Image
            Button15.BackgroundImage = Nothing
            Button16.BackgroundImage = Form2.PictureBox15.Image

            Button1.Text = "1"
            Button2.Text = "2"
            Button3.Text = "3"
            Button4.Text = "4"
            Button5.Text = "5"
            Button6.Text = "6"
            Button7.Text = "7"
            Button8.Text = "8"
            Button9.Text = "9"
            Button10.Text = "10"
            Button11.Text = "11"
            Button12.Text = "12"
            Button13.Text = "13"
            Button14.Text = "14"
            Button15.Text = " "
            Button16.Text = "15"
        End If
        'Call ReadFilePoints()

    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        GeneralTimer.Enabled = False
        Form1Visible = False

        'Form3.Show()
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MapLoad()
        Form1Visible = True
        Label4.Text = "Перемішень: " & GeneralCl
        Label3.Text = "Час: " & GeneralT & " сек."
        Label5.Text = "Виконано:"
    End Sub
    Private Sub GeneralTimer_Tick(sender As Object, e As EventArgs) Handles GeneralTimer.Tick
        GeneralT += 1
        Label3.Text = "Час: " & GeneralT & " сек."
    End Sub
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            GeneralTimer.Enabled = False
            PictureBox1.Visible = True
            CheckBox1.Text = "Продовжити"
        Else
            GeneralTimer.Enabled = True
            PictureBox1.Visible = False
            CheckBox1.Text = "Пауза"
        End If
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        Form3.Close()
    End Sub 
    Private Sub ПочатиГруToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles ПочатиГруToolStripMenuItem.Click
        Call StartGame()
    End Sub
    Private Sub ToolStripMenuItem1_Click_1(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        Form2.Show()
    End Sub
    Private Sub ІндексиПлитокToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles ІндексиПлитокToolStripMenuItem.Click
        Call IndexMap()

    End Sub
    Private Sub ЗмінитиМалюнокToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ЗмінитиМалюнокToolStripMenuItem.Click
        Form3.Show()
        Me.Close()


    End Sub   
    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        Call StartGame()

    End Sub
    Private Sub ButtonChengeMap_Click(sender As Object, e As EventArgs) Handles ButtonChengeMap.Click
        Form3.Show()
        Me.Close()
    End Sub
    Private Sub ButtonExit_Click(sender As Object, e As EventArgs) Handles ButtonExit.Click
        Form3.Close()
    End Sub
    Private Sub ButtonFullMap_Click(sender As Object, e As EventArgs) Handles ButtonFullMap.Click
        Form2.Show()
    End Sub
    Private Sub CheckIndex_CheckedChanged(sender As Object, e As EventArgs) Handles CheckIndex.CheckedChanged
        Call IndexMap()
    End Sub
    Private Sub ButtonChPolar_Click(sender As Object, e As EventArgs) Handles ButtonChPolar.Click
        MapPolarPR()
    End Sub
    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Points = 0
        Form4.Button1.Visible = False
        Form4.Button2.Visible = False
        Form4.Button3.Visible = False
        Form4.Label5_1.Visible = False
        Form4.Label5_2.Visible = True
        Form4.Show()

    End Sub
    Private Sub ToolStripButtonHelp_Click(sender As Object, e As EventArgs) Handles ToolStripButtonHelp.Click
        System.Diagnostics.Process.Start(My.Computer.FileSystem.CurrentDirectory & "\Help.hlp")
    End Sub

End Class
