<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DetallesMonstruo
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
        Me.LabelTitulo = New System.Windows.Forms.Label
        Me.monstruo = New System.Windows.Forms.PictureBox
        Me.poblacion = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.PictureBoxColor = New System.Windows.Forms.PictureBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Labeldificultad = New System.Windows.Forms.Label
        CType(Me.monstruo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxColor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'nombre
        '
        Me.nombre.AutoSize = True
        Me.nombre.Font = New System.Drawing.Font("Tahoma", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nombre.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.nombre.Location = New System.Drawing.Point(454, 0)
        Me.nombre.Name = "nombre"
        Me.nombre.Size = New System.Drawing.Size(211, 58)
        Me.nombre.TabIndex = 63
        Me.nombre.Text = "aventura"
        '
        'LabelTitulo
        '
        Me.LabelTitulo.AutoSize = True
        Me.LabelTitulo.Font = New System.Drawing.Font("Tahoma", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTitulo.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.LabelTitulo.Location = New System.Drawing.Point(-2, 0)
        Me.LabelTitulo.Name = "LabelTitulo"
        Me.LabelTitulo.Size = New System.Drawing.Size(464, 58)
        Me.LabelTitulo.TabIndex = 62
        Me.LabelTitulo.Text = "Detalle del monstruo"
        '
        'monstruo
        '
        Me.monstruo.Location = New System.Drawing.Point(12, 61)
        Me.monstruo.Name = "monstruo"
        Me.monstruo.Size = New System.Drawing.Size(300, 300)
        Me.monstruo.TabIndex = 64
        Me.monstruo.TabStop = False
        '
        'poblacion
        '
        Me.poblacion.AutoSize = True
        Me.poblacion.BackColor = System.Drawing.Color.Transparent
        Me.poblacion.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.poblacion.ForeColor = System.Drawing.Color.White
        Me.poblacion.Location = New System.Drawing.Point(358, 79)
        Me.poblacion.Name = "poblacion"
        Me.poblacion.Size = New System.Drawing.Size(60, 25)
        Me.poblacion.TabIndex = 71
        Me.poblacion.Text = "Color"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(318, 132)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 25)
        Me.Label1.TabIndex = 72
        Me.Label1.Text = "Dificultad"
        '
        'PictureBoxColor
        '
        Me.PictureBoxColor.Location = New System.Drawing.Point(424, 83)
        Me.PictureBoxColor.Name = "PictureBoxColor"
        Me.PictureBoxColor.Size = New System.Drawing.Size(20, 20)
        Me.PictureBoxColor.TabIndex = 73
        Me.PictureBoxColor.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(424, 114)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(60, 65)
        Me.PictureBox1.TabIndex = 74
        Me.PictureBox1.TabStop = False
        '
        'Labeldificultad
        '
        Me.Labeldificultad.AutoSize = True
        Me.Labeldificultad.BackColor = System.Drawing.Color.Transparent
        Me.Labeldificultad.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labeldificultad.ForeColor = System.Drawing.Color.White
        Me.Labeldificultad.Location = New System.Drawing.Point(492, 132)
        Me.Labeldificultad.Name = "Labeldificultad"
        Me.Labeldificultad.Size = New System.Drawing.Size(100, 25)
        Me.Labeldificultad.TabIndex = 75
        Me.Labeldificultad.Text = "Dificultad"
        '
        'DetallesMonstruo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(932, 383)
        Me.Controls.Add(Me.Labeldificultad)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBoxColor)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.poblacion)
        Me.Controls.Add(Me.monstruo)
        Me.Controls.Add(Me.nombre)
        Me.Controls.Add(Me.LabelTitulo)
        Me.Name = "DetallesMonstruo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DetallesMonstruo"
        CType(Me.monstruo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxColor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents nombre As System.Windows.Forms.Label
    Friend WithEvents LabelTitulo As System.Windows.Forms.Label
    Friend WithEvents monstruo As System.Windows.Forms.PictureBox
    Friend WithEvents poblacion As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBoxColor As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Labeldificultad As System.Windows.Forms.Label
End Class
