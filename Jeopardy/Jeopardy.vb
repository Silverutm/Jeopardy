Imports System.ComponentModel

Public Class Jeopardy
    Private Sub btnRegresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        FPuntaje.Show()
        FJeopardy.Hide()
    End Sub

    Private Sub Jeopardy_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        End
    End Sub

    Private Sub Jeopardy_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblNombreEquipo.Text = txtArregloEquipos(intEquipoenTurno).Text
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        clicenbotones(btn1)
    End Sub

    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        clicenbotones(btn6)
    End Sub

    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        clicenbotones(btn5)
    End Sub

    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        clicenbotones(btn7)
    End Sub

    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        clicenbotones(btn8)
    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        clicenbotones(btn4)
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        clicenbotones(btn3)
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        clicenbotones(btn2)
    End Sub

    Private Sub btn12_Click(sender As Object, e As EventArgs) Handles btn12.Click
        clicenbotones(btn12)
    End Sub

    Private Sub btn11_Click(sender As Object, e As EventArgs) Handles btn11.Click
        clicenbotones(btn11)
    End Sub

    Private Sub btn10_Click(sender As Object, e As EventArgs) Handles btn10.Click
        clicenbotones(btn10)
    End Sub

    Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
        clicenbotones(btn9)
    End Sub

    Private Sub clicenbotones(ByRef btn As Button)
        intPuntosEnJuego = CInt(btn.Text)
        strRuta = btn.Tag & ".txt"
        btn.Enabled = False
        FJeopardy.Hide()
        Dim FPreguntas As New Preguntas
        FPreguntas.Show()
    End Sub
End Class