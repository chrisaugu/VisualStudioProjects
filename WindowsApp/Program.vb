Imports System

Module Program
    'Sub Main(args As String())
    'Console.WriteLine("Hello World!")
    'Console.WriteLine(vbCrLf + "What is your name? ")
    'Dim name = Console.ReadLine()
    'Dim currentDate = DateTime.Now
    'Console.WriteLine($"{vbCrLf}Hello, {name}, on {currentDate:d} at {currentDate:t}!")
    'Console.Write(vbCrLf + "Press any key to exit... ")
    'Console.ReadKey(True)
    'End Sub
    Public num1 As Integer
    Public num2 As Integer
    Public answer As Integer
    'Sub Main()
    '    Console.WriteLine("Type a number and press Enter")
    '    num1 = Console.ReadLine()
    '    Console.WriteLine("Type another number to add to it and press Enter")
    '    num2 = Console.ReadLine()
    '    answer = num1 + num2
    '    Console.WriteLine("The answer is " & answer)
    'Console.ReadLine()
    'End Sub

    Private fBold As New Font("Arial", FontStyle.Bold)
    Private fNormal As New Font("Arial", FontStyle.Regular)

    Private Sub BoldCheckbox_Checked(
                                    ByVal sender As System.Object,
                                    ByVal e As System.Windows.RoutedEventArgs)
        Handles BoldCheckbox.Checked
        If BoldCheckbox.IsChecked = True Then
            TextToBeBold.FontWeight = FontWeights.Bold
        Else
            TextToBeBold.FontWeight = FontWeights.Normal
        End If
    End Sub

End Module
