Module Module1
    Public GeneralCl, GeneralT, WinStatTime, WinStatClick, Points, ChNextS As Integer
    Public ProcWin As Single
    Public Slojnost As String
    Public Form1Visible As Boolean = False
    Public ptb As Boolean = False
    Public Map = {Nothing, "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", " "}
    Public Map3x3 = {Nothing, "1", "2", "3", "4", "5", "6", "7", "8", " "}

    
    Sub CheckButton(ByRef Butt1 As Button, ByRef Butt2 As Button)
        If Butt2.Text = " " Then
            Butt2.BackgroundImage = Butt1.BackgroundImage
            Butt1.BackgroundImage = Nothing

            Butt2.Text = Butt1.Text
            Butt1.Text = " "

            GeneralCl += 1

        End If

    End Sub
    Sub ChengPolar(ByRef Butt1 As Button, ByRef butt2 As Button)
        Form2.Button1.Text = butt2.Text
        Form2.Button1.BackgroundImage = butt2.BackgroundImage
        butt2.Text = Butt1.Text
        butt2.BackgroundImage = Butt1.BackgroundImage
        Butt1.Text = Form2.Button1.Text
        Butt1.BackgroundImage = Form2.Button1.BackgroundImage

    End Sub
    
    
      
End Module
