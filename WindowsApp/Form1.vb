Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MsgBox("Welcome to the JavaTpoint")
    End Sub

    Private Sub btnClickThis_Click(sender As Object, e As EventArgs) Handles btnClickThis.Click
        lblHelloWorld.Text = "Hello World!!"

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
    End Sub
End Class
