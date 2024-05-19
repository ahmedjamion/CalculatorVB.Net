Public Class Form1
    Dim FirstNum As Decimal
    Dim SecondNum As Decimal
    Dim Operation As Integer
    Dim OperationSelected As Boolean = False
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ButtonOne_Click(sender As Object, e As EventArgs) Handles ButtonOne.Click
        If Display.Text <> "0" Then
            Display.Text += "1"
        Else
            Display.Text = "1"
        End If
    End Sub

    Private Sub ButtonTwo_Click(sender As Object, e As EventArgs) Handles ButtonTwo.Click
        If Display.Text <> "0" Then
            Display.Text += "2"
        Else
            Display.Text = "2"
        End If
    End Sub

    Private Sub ButtonThree_Click(sender As Object, e As EventArgs) Handles ButtonThree.Click
        If Display.Text <> "0" Then
            Display.Text += "3"
        Else
            Display.Text = "3"
        End If
    End Sub

    Private Sub ButtonFour_Click(sender As Object, e As EventArgs) Handles ButtonFour.Click
        If Display.Text <> "0" Then
            Display.Text += "4"
        Else
            Display.Text = "4"
        End If
    End Sub

    Private Sub ButtonFive_Click(sender As Object, e As EventArgs) Handles ButtonFive.Click
        If Display.Text <> "0" Then
            Display.Text += "5"
        Else
            Display.Text = "5"
        End If
    End Sub

    Private Sub ButtonSix_Click(sender As Object, e As EventArgs) Handles ButtonSix.Click
        If Display.Text <> "0" Then
            Display.Text += "6"
        Else
            Display.Text = "6"
        End If
    End Sub

    Private Sub ButtonSeven_Click(sender As Object, e As EventArgs) Handles ButtonSeven.Click
        If Display.Text <> "0" Then
            Display.Text += "7"
        Else
            Display.Text = "7"
        End If
    End Sub

    Private Sub ButtonEight_Click(sender As Object, e As EventArgs) Handles ButtonEight.Click
        If Display.Text <> "0" Then
            Display.Text += "8"
        Else
            Display.Text = "8"
        End If
    End Sub

    Private Sub ButtonNine_Click(sender As Object, e As EventArgs) Handles ButtonNine.Click
        If Display.Text <> "0" Then
            Display.Text += "9"
        Else
            Display.Text = "9"
        End If
    End Sub

    Private Sub ButtonZero_Click(sender As Object, e As EventArgs) Handles ButtonZero.Click
        If Display.Text <> "0" Then
            Display.Text += "0"
        End If
    End Sub

    Private Sub ButtonPoint_Click(sender As Object, e As EventArgs) Handles ButtonPoint.Click
        If Not Display.Text.Contains("."c) Then
            Display.Text += "."
        End If
    End Sub

    Private Sub ButtonAdd_Click(sender As Object, e As EventArgs) Handles ButtonAdd.Click
        FirstNum = Display.Text
        Display.Text = "0"
        OperationSelected = True
        Operation = 1 ' addition
    End Sub

    Private Sub ButtonSubtract_Click(sender As Object, e As EventArgs) Handles ButtonSubtract.Click
        FirstNum = Display.Text
        Display.Text = "0"
        OperationSelected = True
        Operation = 2 ' subtraction
    End Sub

    Private Sub ButtonMultiply_Click(sender As Object, e As EventArgs) Handles ButtonMultiply.Click
        FirstNum = Display.Text
        Display.Text = "0"
        OperationSelected = True
        Operation = 3 ' multiplication
    End Sub

    Private Sub ButtonDivide_Click(sender As Object, e As EventArgs) Handles ButtonDivide.Click
        FirstNum = Display.Text
        Display.Text = "0"
        OperationSelected = True
        Operation = 4 ' division
    End Sub

    Private Sub ButtonEquals_Click(sender As Object, e As EventArgs) Handles ButtonEquals.Click
        If OperationSelected = True Then
            SecondNum = Display.Text
            If Operation = 1 Then
                Display.Text = FirstNum + SecondNum
            ElseIf Operation = 2 Then
                Display.Text = FirstNum - SecondNum
            ElseIf Operation = 3 Then
                Display.Text = FirstNum * SecondNum
            ElseIf Operation = 4 Then
                If SecondNum = 0 Then
                    Display.Text = "Error!"
                Else
                    Display.Text = FirstNum / SecondNum
                End If
            End If
        End If
    End Sub

    Private Sub ButtonClear_Click(sender As Object, e As EventArgs) Handles ButtonClear.Click
        If Display.Text <> "0" Then
            Display.Text = "0"
        End If
    End Sub
End Class
