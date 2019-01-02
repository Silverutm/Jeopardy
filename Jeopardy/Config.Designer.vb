<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Config
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.lblNumerodeEquipos = New System.Windows.Forms.Label()
        Me.nudNumeroEquipos = New System.Windows.Forms.NumericUpDown()
        Me.btnContinuar = New System.Windows.Forms.Button()
        Me.lblNombresdeEquipos = New System.Windows.Forms.Label()
        CType(Me.nudNumeroEquipos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(456, 69)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(479, 122)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        Me.Button2.Visible = False
        '
        'lblNumerodeEquipos
        '
        Me.lblNumerodeEquipos.AutoSize = True
        Me.lblNumerodeEquipos.Location = New System.Drawing.Point(54, 94)
        Me.lblNumerodeEquipos.Name = "lblNumerodeEquipos"
        Me.lblNumerodeEquipos.Size = New System.Drawing.Size(100, 13)
        Me.lblNumerodeEquipos.TabIndex = 2
        Me.lblNumerodeEquipos.Text = "Numero de Equipos"
        '
        'nudNumeroEquipos
        '
        Me.nudNumeroEquipos.Location = New System.Drawing.Point(197, 94)
        Me.nudNumeroEquipos.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.nudNumeroEquipos.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudNumeroEquipos.Name = "nudNumeroEquipos"
        Me.nudNumeroEquipos.Size = New System.Drawing.Size(55, 20)
        Me.nudNumeroEquipos.TabIndex = 3
        Me.nudNumeroEquipos.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'btnContinuar
        '
        Me.btnContinuar.Location = New System.Drawing.Point(197, 466)
        Me.btnContinuar.Name = "btnContinuar"
        Me.btnContinuar.Size = New System.Drawing.Size(75, 23)
        Me.btnContinuar.TabIndex = 4
        Me.btnContinuar.Text = "Continuar"
        Me.btnContinuar.UseVisualStyleBackColor = True
        '
        'lblNombresdeEquipos
        '
        Me.lblNombresdeEquipos.AutoSize = True
        Me.lblNombresdeEquipos.Location = New System.Drawing.Point(54, 150)
        Me.lblNombresdeEquipos.Name = "lblNombresdeEquipos"
        Me.lblNombresdeEquipos.Size = New System.Drawing.Size(121, 13)
        Me.lblNombresdeEquipos.TabIndex = 5
        Me.lblNombresdeEquipos.Text = "Nombres de los Equipos"
        '
        'Config
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(386, 543)
        Me.Controls.Add(Me.lblNombresdeEquipos)
        Me.Controls.Add(Me.btnContinuar)
        Me.Controls.Add(Me.nudNumeroEquipos)
        Me.Controls.Add(Me.lblNumerodeEquipos)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Config"
        Me.Text = "Config"
        CType(Me.nudNumeroEquipos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents lblNumerodeEquipos As Label
    Friend WithEvents nudNumeroEquipos As NumericUpDown
    Friend WithEvents btnContinuar As Button
    Friend WithEvents lblNombresdeEquipos As Label
End Class
