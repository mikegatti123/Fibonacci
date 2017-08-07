Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'For i As Integer = 5 To 100
        '    If i Mod 5 = 0 Then
        '        Debug.Write(i.ToString + " , ")
        '    End If

        'Next
        'Dim index As Integer = 0

        'While index <= 100
        '    If index Mod 5 = 0 Then
        '        Debug.Write(index.ToString + " ,")
        '    End If
        '    index += 1
        'End While
        Dim c As Integer = cube(3)
        MsgBox(c)

    End Sub
    Private Function cube(num) As Integer
        Return num * num * num
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Debug.Write(1)
        Dim LastNumber As Integer = 2
        Dim SLastNumber As Integer = 1
        Dim NextNumber As Integer
        Dim sum As Integer = 2
        While LastNumber <= 4000000
            NextNumber = LastNumber + SLastNumber
            SLastNumber = LastNumber
            LastNumber = NextNumber
            If LastNumber Mod 2 = 0 Then
                sum = sum + LastNumber
            End If
        End While
        MsgBox(sum)
    End Sub
End Class
