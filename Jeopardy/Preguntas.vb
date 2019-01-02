Imports System.ComponentModel

Public Class Preguntas
    Private Sub btnPuntos_Click(sender As Object, e As EventArgs) Handles btnPuntos.Click
        FPuntaje.Show()
        Me.Close()
    End Sub

    Private Sub btnCorrecto_Click(sender As Object, e As EventArgs) Handles btnCorrecto.Click
        lblArregloPuntos(intEquipoenTurno).Text += intPuntosEnJuego
        intPuntosEnJuego = 0
        btnIncorrecto.Enabled = False
        btnPuntos.Enabled = True
    End Sub

    Private Sub Preguntas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'MsgBox("in\" & strRuta)
        If System.IO.File.Exists("in\" & strRuta) = True Then
            Dim objReader As New System.IO.StreamReader("in\" & strRuta)
            lblPregunta.Text = objReader.ReadToEnd
            objReader.Close()
        Else
            lblPregunta.Text = "No se encontro la pregunta"
        End If
    End Sub

    Private Sub btnMostrarRespuesta_Click(sender As Object, e As EventArgs) Handles btnMostrarRespuesta.Click
        If System.IO.File.Exists("out\" & strRuta) = True Then
            Dim objReader As New System.IO.StreamReader("out\" & strRuta)
            lblRespuesta.Text = objReader.ReadToEnd
            objReader.Close()
        Else
            lblRespuesta.Text = "No se encontro la respuesta"
        End If
        btnCorrecto.Visible = True
        btnIncorrecto.Visible = True
    End Sub

    Private Sub btnIncorrecto_Click(sender As Object, e As EventArgs) Handles btnIncorrecto.Click
        btnPuntos.Enabled = True
        btnCorrecto.Enabled = False
    End Sub
End Class