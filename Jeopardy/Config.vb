Public Class Config
    Dim x As Integer = 10
    Dim asdf(10) As Button
    Dim intX, intY As Integer       'las posiciones de los textbox que creare
    Dim intnAnterior As Integer = 0     'es el valor anterior de n, para que no haga cosas de mas

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim btn1 As Button = New Button()
        btn1.Parent = Me
        btn1.Name = "btn1"
        btn1.Top = x
        btn1.Text = "Btn1"
        AddHandler btn1.Click, AddressOf HandleDynamicButtonClick
        x += 10
        asdf(0) = btn1
    End Sub

    Private Sub HandleDynamicButtonClick(ByVal sender As Object, ByVal e As EventArgs)
        Dim btn As Button = DirectCast(sender, Button)

        If btn.Name = "btn1" Then
            MessageBox.Show("Btn1 clicked")

        End If


        'Dim ClickedButton As Microsoft.Office.Tools.Word.Controls.Button =
        'btn.delete()
    End Sub

    Private Sub nudNumeroEquipos_ValueChanged(sender As Object, e As EventArgs) Handles nudNumeroEquipos.ValueChanged
        'If nudNumeroEquipos.Value = 1 Then
        'Exit Sub
        'End If
        Dim i As Integer

        intX = 180
        intY = 150
        n = nudNumeroEquipos.Value
        If intnAnterior < n Then
            For i = intnAnterior + 1 To n
                Dim txtEquipo As TextBox = New TextBox()
                txtEquipo.Parent = Me
                txtEquipo.Text = "Equipo " & i
                txtEquipo.Top = intY + (i - 1) * 30
                txtEquipo.Left = intX

                txtArregloEquipos(i) = txtEquipo
            Next
        Else
            For i = n + 1 To intnAnterior
                txtArregloEquipos(i).Visible = False
            Next
        End If

        intnAnterior = n
    End Sub

    Private Sub btnContinuar_Click(sender As Object, e As EventArgs) Handles btnContinuar.Click
        FPuntaje.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'asdf(0).Text = "hola"

    End Sub
End Class