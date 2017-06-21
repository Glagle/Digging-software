
Public Class Form1
    Dim ID(40) As Integer
    Dim time_count As Single = 30
    Dim count As Integer = 41       '总人数

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For i = 0 To 40
            ID(i) = i
        Next

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim AllText As String
        Dim a_CHT() As String

        Dim person As Integer


        Randomize()                              '必要代码，不然的话每次随机生成都是一样的数
        person = Int(Rnd() * (count - 1 - 0 + 1)) + 0   '其中m>n生成n~m间（包括n，m）的随机整数


        AllText = My.Computer.FileSystem.ReadAllText(Application.StartupPath() & "\data\name.txt ")
        a_CHT = AllText.Split(vbCrLf)     '将文本按行分割成字符串数组a_CHT（）


        '显示人名及题目内容
        If count > 0 Then
            TextBox1.Text = a_CHT(ID(person))
        End If

        If count = 0 Then
            TextBox1.Text = "GAME 0VER"

        End If

        If count > 0 Then

            '抽到的人不再抽
            Dim tmp As Integer = 0
            tmp = ID(person)
            ID(person) = ID(count - 1)
            ID(count - 1) = tmp
            count = count - 1

        End If

        time_count = 30
        TextBox2.Text = Format(time_count, "###0.0")

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim AllText_TI_1 As String
        Dim a_CHT_TI_1() As String

        Dim TI_1 As Integer
        Randomize()                              '必要代码，不然的话每次随机生成都是一样的数
        TI_1 = Int(Rnd() * (55 - 0 + 1)) + 0   '其中m>n生成n~m间（包括n，m）的随机整数

        AllText_TI_1 = My.Computer.FileSystem.ReadAllText(Application.StartupPath() & "\data\TI_1.txt ")
        a_CHT_TI_1 = AllText_TI_1.Split(vbCrLf)     '将文本按行分割成字符串数组a_CHT（）

        RichTextBox1.Text = Replace(Replace(a_CHT_TI_1(TI_1), vbCr, ""), vbLf, "")

        RichTextBox2.Text = ""
        RichTextBox3.Text = ""

        Timer1.Interval = 500
        Timer1.Enabled = True

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim AllText_TI_2 As String
        Dim a_CHT_TI_2() As String

        Dim TI_2 As Integer
        Randomize()                              '必要代码，不然的话每次随机生成都是一样的数
        TI_2 = Int(Rnd() * (34 - 0 + 1)) + 0   '其中m>n生成n~m间（包括n，m）的随机整数

        AllText_TI_2 = My.Computer.FileSystem.ReadAllText(Application.StartupPath() & "\data\TI_2.txt ")
        a_CHT_TI_2 = AllText_TI_2.Split(vbCrLf)     '将文本按行分割成字符串数组a_CHT（）

        RichTextBox2.Text = Replace(Replace(a_CHT_TI_2(TI_2), vbCr, ""), vbLf, "")

        RichTextBox1.Text = ""
        RichTextBox3.Text = ""

        Timer1.Interval = 500
        Timer1.Enabled = True

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        Dim AllText_TI_3 As String
        Dim a_CHT_TI_3() As String

        Dim TI_3 As Integer
        Randomize()                              '必要代码，不然的话每次随机生成都是一样的数
        TI_3 = Int(Rnd() * (77 - 0 + 1)) + 0   '其中m>n生成n~m间（包括n，m）的随机整数

        AllText_TI_3 = My.Computer.FileSystem.ReadAllText(Application.StartupPath() & "\data\TI_3.txt ")
        a_CHT_TI_3 = AllText_TI_3.Split(vbCrLf)     '将文本按行分割成字符串数组a_CHT（）

        RichTextBox3.Text = Replace(Replace(a_CHT_TI_3(TI_3), vbCr, ""), vbLf, "")

        RichTextBox1.Text = ""
        RichTextBox2.Text = ""

        Timer1.Interval = 500
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        time_count = time_count - 0.5
        TextBox2.Text = Format(time_count, "###0.0")

        If (time_count = 0) Then
            Timer1.Enabled = False
        End If


    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click


        Timer1.Enabled = False


    End Sub
End Class
