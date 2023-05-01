Option Infer Off
Option Explicit On
Option Strict On

'Name: Capstone 7
'Purpose: Alt Wheel of Fortune
'Programmer: Anthony Badillo 4/24/23


Imports System.Data.SqlTypes

Public Class Form1

    Dim Random As Integer
    Dim Number2 As Integer


    Private Sub btnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click

        'Dim Value As Integer
        'Value = Int((25 * Rnd() + 1))

        'If Value = 0 Then
        '    SqlMoney = 10000
        'ElseIf Value <= 1 And Value >= 5 Then
        'End If

        'Label1.Text = Value.ToString


        Timer1.Enabled = True
        Random = CInt((25 * Rnd() + 1))




    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        Number2 += 1
        If Number2 = 10 Then
            PictureBox1.Image = My.Resources.Chart_1
        ElseIf Number2 = 20 Then
            PictureBox1.Image = My.Resources.Chart_2
        ElseIf Number2 = 30 Then
            PictureBox1.Image = My.Resources.Chart_3
        ElseIf Number2 = 40 Then
            PictureBox1.Image = My.Resources.Chart_4
        ElseIf Number2 = 50 Then
            PictureBox1.Image = My.Resources.Chart_5
        ElseIf Number2 = 60 Then
            PictureBox1.Image = My.Resources.Chart_6
        ElseIf Number2 = 70 Then
            PictureBox1.Image = My.Resources.chart_7
        ElseIf Number2 = 80 Then
            PictureBox1.Image = My.Resources.Chart_8
        ElseIf Number2 = 90 Then
            PictureBox1.Image = My.Resources.chart_9
        ElseIf Number2 = 100 Then
            PictureBox1.Image = My.Resources.chart_10
        ElseIf Number2 = 110 Then
            PictureBox1.Image = My.Resources.Chart_11
        ElseIf Number2 = 120 Then
            PictureBox1.Image = My.Resources.Chart_12
        ElseIf Number2 = 130 Then
            PictureBox1.Image = My.Resources.Chart_13
        ElseIf Number2 = 140 Then
            PictureBox1.Image = My.Resources.Chart_14
        ElseIf Number2 = 150 Then
            PictureBox1.Image = My.Resources.chart_15
        ElseIf Number2 = 160 Then
            PictureBox1.Image = My.Resources.chart_16
        ElseIf Number2 = 170 Then
            PictureBox1.Image = My.Resources.chart_17
        ElseIf Number2 = 180 Then
            PictureBox1.Image = My.Resources.chart_18
        ElseIf Number2 = 190 Then
            PictureBox1.Image = My.Resources.Chart_19
        ElseIf Number2 = 200 Then
            PictureBox1.Image = My.Resources.chart_20
        ElseIf Number2 = 210 Then
            PictureBox1.Image = My.Resources.chart_21
        ElseIf Number2 = 220 Then
            PictureBox1.Image = My.Resources.chart_22
        ElseIf Number2 = 230 Then
            PictureBox1.Image = My.Resources.chart_23
        ElseIf Number2 = 240 Then
            PictureBox1.Image = My.Resources.chart_24
        ElseIf Number2 = 250 Then
            PictureBox1.Image = My.Resources.chart_25
        ElseIf Number2 = 300 Then
            PictureBox1.Image = My.Resources.chart_26
        End If
    End Sub
End Class
