Imports System.ComponentModel

Public Class Puntaje
    Dim intX, intY As Integer
    Private Sub Puntaje_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        End
    End Sub

    Private Sub Puntaje_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim i As Integer
        intX = 80
        intY = 50
        For i = 1 To n
            'Nombres de los equipos
            Dim lblEquipo As Label = New Label()
            lblEquipo.Parent = Me
            lblEquipo.Text = txtArregloEquipos(i).Text
            lblEquipo.Top = intY + (i - 1) * 30
            lblEquipo.Left = intX

            'Puntos
            Dim lblPuntos As Label = New Label()
            lblPuntos.Parent = Me
            lblPuntos.Text = 0
            lblPuntos.Top = intY + (i - 1) * 30
            lblPuntos.Left = intX + 120
            lblArregloPuntos(i) = lblPuntos

            'Boton ir
            Dim btnBoton As Button = New Button()
            btnBoton.Parent = Me
            btnBoton.Name = CStr(i)
            btnBoton.Top = lblPuntos.Top - 5
            btnBoton.Left = intX - 30
            btnBoton.Width = 25
            btnBoton.Text = ">"
            AddHandler btnBoton.Click, AddressOf btnButtonClick
        Next
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        PasaraExcel()
    End Sub

    Private Sub btnButtonClick(ByVal sender As Object, ByVal e As EventArgs)
        Dim btn As Button = DirectCast(sender, Button)
        intEquipoenTurno = CInt(btn.Name)
        FJeopardy.Show()
        FPuntaje.Hide()
    End Sub
End Class
