Public Class Form1

    Dim inputs(,) As Boolean = {
        {False, False, False, False},
        {False, False, False, True},
        {False, False, True, False},
        {False, False, True, True},
        {False, True, False, False},
        {False, True, False, True},
        {False, True, True, False},
        {False, True, True, True},
        {True, False, False, False},
        {True, False, False, True}
    }
    Dim second As Int32 = -1

    Dim A As Boolean
    Dim B As Boolean
    Dim C As Boolean
    Dim D As Boolean

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        second += 1

        A = inputs(second, 0)
        B = inputs(second, 1)
        C = inputs(second, 2)
        D = inputs(second, 3)

        Button1.BackColor = Color.Red
        Button7.BackColor = Color.White
        Button17.BackColor = Color.White

        If (Not B) Or D Or C Then
            Button2.BackColor = Color.Red
            Button3.BackColor = Color.Red
            Button23.BackColor = Color.Red
        Else
            Button2.BackColor = Color.White
            Button3.BackColor = Color.White
            Button23.BackColor = Color.White
        End If

        If (Not D) Or C Or B Or A Then
            Button4.BackColor = Color.Red
        Else
            Button4.BackColor = Color.White
        End If

        If C Or A Or ((Not B) And (Not D)) Or (B And D) Then
            Button5.BackColor = Color.Red
        Else
            Button5.BackColor = Color.White
        End If

        If A Or ((Not C) And (Not D)) Or (B And (Not C)) Or (B And (Not D)) Then
            Button6.BackColor = Color.Red
        Else
            Button6.BackColor = Color.White
        End If

        If (Not A) And (Not B) And (Not C) And D Then
            Button8.BackColor = Color.Red
        Else
            Button8.BackColor = Color.White
        End If

        If (B And (Not C) And (Not D)) Or (B And C And D) Then
            Button9.BackColor = Color.Red
        Else
            Button9.BackColor = Color.White
        End If

        If A Or ((Not B) And (Not D)) Or ((Not B) And C) Then
            Button10.BackColor = Color.Red
        Else
            Button10.BackColor = Color.White
        End If

        If (Not D) Or A Or ((Not B) And C) Or (B And (Not C)) Then
            Button11.BackColor = Color.Red
            Button15.BackColor = Color.Red
        Else
            Button11.BackColor = Color.White
            Button15.BackColor = Color.White
        End If

        If A Or ((Not B) And C) Or (C And (Not D)) Or (B And (Not C)) Then
            Button12.BackColor = Color.Red
            Button14.BackColor = Color.Red
        Else
            Button12.BackColor = Color.White
            Button14.BackColor = Color.White
        End If

        If D Or C Or B Or A Then
            Button13.BackColor = Color.Red
        Else
            Button13.BackColor = Color.White
        End If

        If ((Not B) And (Not D)) Or (C And (Not D)) Then
            Button16.BackColor = Color.Red
        Else
            Button16.BackColor = Color.White
        End If

        If (B And C And D) Or ((Not A) And (Not B) And (Not C) And D) Then
            Button18.BackColor = Color.Red
        Else
            Button18.BackColor = Color.White
        End If

        If (B And (Not C) And (Not D)) Then
            Button19.BackColor = Color.Red
        Else
            Button19.BackColor = Color.White
        End If

        If A Or ((Not B) And (Not C) And (Not D)) Or ((Not B) And C And D) Or (B And (Not C) And D) Or (B And C And (Not D)) Then
            Button20.BackColor = Color.Red
        Else
            Button20.BackColor = Color.White
        End If

        If (Not B) Or ((Not C) And D) Or (C And (Not D)) Then
            Button21.BackColor = Color.Red
            Button22.BackColor = Color.Red
            Button25.BackColor = Color.Red
        Else
            Button21.BackColor = Color.White
            Button22.BackColor = Color.White
            Button25.BackColor = Color.White
        End If

        If (Not B) Or (Not C) Or (Not D) Then
            Button24.BackColor = Color.Red
        Else
            Button24.BackColor = Color.White
        End If

        If second = 9 Then
            second = -1
        End If
    End Sub
End Class
