<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DetallesEscenario
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
        Me.nombre = New System.Windows.Forms.Label
        Me.escenario = New System.Windows.Forms.PictureBox
        Me.LabelTitulo = New System.Windows.Forms.Label
        Me.padre = New System.Windows.Forms.PictureBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.PictureBoxuni = New System.Windows.Forms.PictureBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.poblacion = New System.Windows.Forms.Label
        Me.maxima = New System.Windows.Forms.Label
        Me.esplaneta = New System.Windows.Forms.Label
        CType(Me.escenario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.padre, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxuni, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'nombre
        '
        Me.nombre.AutoSize = True
        Me.nombre.Font = New System.Drawing.Font("Tahoma", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nombre.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.nombre.Location = New System.Drawing.Point(456, 0)
        Me.nombre.Name = "nombre"
        Me.nombre.Size = New System.Drawing.Size(211, 58)
        Me.nombre.TabIndex = 61
        Me.nombre.Text = "aventura"
        '
        'escenario
        '
        Me.escenario.Location = New System.Drawing.Point(10, 212)
        Me.escenario.Name = "escenario"
        Me.escenario.Size = New System.Drawing.Size(300, 300)
        Me.escenario.TabIndex = 60
        Me.escenario.TabStop = False
        '
        'LabelTitulo
        '
        Me.LabelTitulo.AutoSize = True
        Me.LabelTitulo.Font = New System.Drawing.Font("Tahoma", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTitulo.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.LabelTitulo.Location = New System.Drawing.Point(0, 0)
        Me.LabelTitulo.Name = "LabelTitulo"
        Me.LabelTitulo.Size = New System.Drawing.Size(478, 58)
        Me.LabelTitulo.TabIndex = 59
        Me.LabelTitulo.Text = "Detalle del escenario "
        '
        'padre
        '
        Me.padre.Location = New System.Drawing.Point(316, 212)
        Me.padre.Name = "padre"
        Me.padre.Size = New System.Drawing.Size(300, 300)
        Me.padre.TabIndex = 65
        Me.padre.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(313, 196)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(124, 13)
        Me.Label1.TabIndex = 66
        Me.Label1.Text = "Foto del escenario padre"
        '
        'PictureBoxuni
        '
        Me.PictureBoxuni.Location = New System.Drawing.Point(622, 212)
        Me.PictureBoxuni.Name = "PictureBoxuni"
        Me.PictureBoxuni.Size = New System.Drawing.Size(300, 300)
        Me.PictureBoxuni.TabIndex = 68
        Me.PictureBoxuni.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(619, 196)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(156, 13)
        Me.Label2.TabIndex = 69
        Me.Label2.Text = "Foto del universo perteneciente"
        '
        'poblacion
        '
        Me.poblacion.AutoSize = True
        Me.poblacion.BackColor = System.Drawing.Color.Transparent
        Me.poblacion.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.poblacion.ForeColor = System.Drawing.Color.White
        Me.poblacion.Location = New System.Drawing.Point(23, 79)
        Me.poblacion.Name = "poblacion"
        Me.poblacion.Size = New System.Drawing.Size(101, 25)
        Me.poblacion.TabIndex = 70
        Me.poblacion.Text = "Población"
        '
        'maxima
        '
        Me.maxima.AutoSize = True
        Me.maxima.BackColor = System.Drawing.Color.Transparent
        Me.maxima.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.maxima.ForeColor = System.Drawing.Color.White
        Me.maxima.Location = New System.Drawing.Point(23, 116)
        Me.maxima.Name = "maxima"
        Me.maxima.Size = New System.Drawing.Size(179, 25)
        Me.maxima.TabIndex = 71
        Me.maxima.Text = "Máxima población"
        '
        'esplaneta
        '
        Me.esplaneta.AutoSize = True
        Me.esplaneta.BackColor = System.Drawing.Color.Transparent
        Me.esplaneta.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.esplaneta.ForeColor = System.Drawing.Color.White
        Me.esplaneta.Location = New System.Drawing.Point(23, 152)
        Me.esplaneta.Name = "esplaneta"
        Me.esplaneta.Size = New System.Drawing.Size(119, 25)
        Me.esplaneta.TabIndex = 72
        Me.esplaneta.Text = "Es Planeta?"
        '
        'DetallesEscenario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(936, 524)
        Me.Controls.Add(Me.poblacion)
        Me.Controls.Add(Me.maxima)
        Me.Controls.Add(Me.esplaneta)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBoxuni)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.padre)
        Me.Controls.Add(Me.nombre)
        Me.Controls.Add(Me.escenario)
        Me.Controls.Add(Me.LabelTitulo)
        Me.Name = "DetallesEscenario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DetallesEscenario"
        CType(Me.escenario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.padre, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxuni, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents nombre As System.Windows.Forms.Label
    Friend WithEvents escenario As System.Windows.Forms.PictureBox
    Friend WithEvents LabelTitulo As System.Windows.Forms.Label
    Friend WithEvents padre As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBoxuni As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents poblacion As System.Windows.Forms.Label
    Friend WithEvents maxima As System.Windows.Forms.Label
    Friend WithEvents esplaneta As System.Windows.Forms.Label
End Class
