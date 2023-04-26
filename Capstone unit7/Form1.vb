Option Infer Off
Option Explicit On

'Name: Capstone 7
'Purpose: Alt Wheel of Fortune
'Programmer: Anthony Badillo 4/24/23


Imports System.Data.SqlTypes

Public Class Form1
    'Dim Selected As String
    Private Sub btnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click

        Dim Value As Integer
        Value = Int((25 * Rnd() + 1))

        If Value = 0 Then
            SqlMoney = 10000
        ElseIf Value <= 1 And Value >= 5 Then
        End If

        Label1.Text = value.ToString

        'value = TabIndex

        'For value As Integer = 0 To 24

        'Next

        'lblPlayer1.Text = value.ToString

    End Sub
End Class
