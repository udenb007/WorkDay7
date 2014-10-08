Option Strict On

Public Class Form1

    Private Sub btnPopulation_Click(sender As Object, e As EventArgs) Handles btnPopulation.Click
        Dim population As Double
        Dim year As Integer

        population = 8000000000
        year = 2014

        Do
            population = population / 2
            year -= 50

        Loop Until population <= 6000000

        MessageBox.Show("the year was " & CStr(year))

    End Sub
End Class
