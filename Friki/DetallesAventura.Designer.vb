<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DetallesAventura
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
        Me.LabelTitulo = New System.Windows.Forms.Label
        Me.escenario = New System.Windows.Forms.PictureBox
        Me.nombre = New System.Windows.Forms.Label
        Me.descripcion = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        CType(Me.escenario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelTitulo
        '
        Me.LabelTitulo.AutoSize = True
        Me.LabelTitulo.Font = New System.Drawing.Font("Tahoma", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTitulo.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.LabelTitulo.Location = New System.Drawing.Point(3, 9)
        Me.LabelTitulo.Name = "LabelTitulo"
        Me.LabelTitulo.Size = New System.Drawing.Size(490, 58)
        Me.LabelTitulo.TabIndex = 56
        Me.LabelTitulo.Text = "Detalle de la aventura"
        '
        'escenario
        '
        Me.escenario.Location = New System.Drawing.Point(12, 82)
        Me.escenario.Name = "escenario"
        Me.escenario.Size = New System.Drawing.Size(300, 300)
        Me.escenario.TabIndex = 57
        Me.escenario.TabStop = False
        '
        'nombre
        '
        Me.nombre.AutoSize = True
        Me.nombre.Font = New System.Drawing.Font("Tahoma", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nombre.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.nombre.Location = New System.Drawing.Point(484, 9)
        Me.nombre.Name = "nombre"
        Me.nombre.Size = New System.Drawing.Size(211, 58)
        Me.nombre.TabIndex = 58
        Me.nombre.Text = "aventura"
        '
        'descripcion
        '
        Me.descripcion.Location = New System.Drawing.Point(335, 92)
        Me.descripcion.Multiline = True
        Me.descripcion.Name = "descripcion"
        Me.descripcion.Size = New System.Drawing.Size(656, 168)
        Me.descripcion.TabIndex = 59
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(165, 13)
        Me.Label1.TabIndex = 60
        Me.Label1.Text = "Foto del escenario de la aventura"
        '
        'DetallesAventura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1004, 403)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.descripcion)
        Me.Controls.Add(Me.nombre)
        Me.Controls.Add(Me.escenario)
        Me.Controls.Add(Me.LabelTitulo)
        Me.Name = "DetallesAventura"
        Me.Text = "DetallesAventura"
        CType(Me.escenario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelTitulo As System.Windows.Forms.Label
    Friend WithEvents escenario As System.Windows.Forms.PictureBox
    Friend WithEvents nombre As System.Windows.Forms.Label
    Friend WithEvents descripcion As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
