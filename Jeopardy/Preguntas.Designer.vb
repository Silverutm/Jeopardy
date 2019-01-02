<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Preguntas
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnPuntos = New System.Windows.Forms.Button()
        Me.btnCorrecto = New System.Windows.Forms.Button()
        Me.btnMostrarRespuesta = New System.Windows.Forms.Button()
        Me.lblPregunta = New System.Windows.Forms.Label()
        Me.lblRespuesta = New System.Windows.Forms.Label()
        Me.btnIncorrecto = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnPuntos
        '
        Me.btnPuntos.Enabled = False
        Me.btnPuntos.Location = New System.Drawing.Point(123, 457)
        Me.btnPuntos.Name = "btnPuntos"
        Me.btnPuntos.Size = New System.Drawing.Size(122, 23)
        Me.btnPuntos.TabIndex = 0
        Me.btnPuntos.Text = "Ir a Puntuacion"
        Me.btnPuntos.UseVisualStyleBackColor = True
        '
        'btnCorrecto
        '
        Me.btnCorrecto.Location = New System.Drawing.Point(170, 398)
        Me.btnCorrecto.Name = "btnCorrecto"
        Me.btnCorrecto.Size = New System.Drawing.Size(75, 23)
        Me.btnCorrecto.TabIndex = 1
        Me.btnCorrecto.Text = "Correcto"
        Me.btnCorrecto.UseVisualStyleBackColor = True
        Me.btnCorrecto.Visible = False
        '
        'btnMostrarRespuesta
        '
        Me.btnMostrarRespuesta.Location = New System.Drawing.Point(57, 182)
        Me.btnMostrarRespuesta.Name = "btnMostrarRespuesta"
        Me.btnMostrarRespuesta.Size = New System.Drawing.Size(89, 43)
        Me.btnMostrarRespuesta.TabIndex = 2
        Me.btnMostrarRespuesta.Text = "Mostrar Respuesta"
        Me.btnMostrarRespuesta.UseVisualStyleBackColor = True
        '
        'lblPregunta
        '
        Me.lblPregunta.AutoSize = True
        Me.lblPregunta.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPregunta.Location = New System.Drawing.Point(54, 68)
        Me.lblPregunta.Name = "lblPregunta"
        Me.lblPregunta.Size = New System.Drawing.Size(99, 25)
        Me.lblPregunta.TabIndex = 3
        Me.lblPregunta.Text = "Pregunta"
        '
        'lblRespuesta
        '
        Me.lblRespuesta.AutoSize = True
        Me.lblRespuesta.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRespuesta.Location = New System.Drawing.Point(64, 237)
        Me.lblRespuesta.Name = "lblRespuesta"
        Me.lblRespuesta.Size = New System.Drawing.Size(0, 25)
        Me.lblRespuesta.TabIndex = 4
        '
        'btnIncorrecto
        '
        Me.btnIncorrecto.Location = New System.Drawing.Point(87, 398)
        Me.btnIncorrecto.Name = "btnIncorrecto"
        Me.btnIncorrecto.Size = New System.Drawing.Size(75, 23)
        Me.btnIncorrecto.TabIndex = 5
        Me.btnIncorrecto.Text = "Incorrecto"
        Me.btnIncorrecto.UseVisualStyleBackColor = True
        Me.btnIncorrecto.Visible = False
        '
        'Preguntas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(386, 543)
        Me.Controls.Add(Me.btnIncorrecto)
        Me.Controls.Add(Me.lblRespuesta)
        Me.Controls.Add(Me.lblPregunta)
        Me.Controls.Add(Me.btnMostrarRespuesta)
        Me.Controls.Add(Me.btnCorrecto)
        Me.Controls.Add(Me.btnPuntos)
        Me.Name = "Preguntas"
        Me.Text = "Preguntas"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnPuntos As Button
    Friend WithEvents btnCorrecto As Button
    Friend WithEvents btnMostrarRespuesta As Button
    Friend WithEvents lblPregunta As Label
    Friend WithEvents lblRespuesta As Label
    Friend WithEvents btnIncorrecto As Button
End Class
