<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DetallesUniverso
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
        Me.universo = New System.Windows.Forms.PictureBox
        Me.nombre = New System.Windows.Forms.Label
        Me.LabelTitulo = New System.Windows.Forms.Label
        Me.LabelNombre = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.LabelTipo = New System.Windows.Forms.Label
        Me.PictureBoxTipo = New System.Windows.Forms.PictureBox
        Me.Label3 = New System.Windows.Forms.Label
        CType(Me.universo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxTipo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'universo
        '
        Me.universo.Location = New System.Drawing.Point(23, 73)
        Me.universo.Name = "universo"
        Me.universo.Size = New System.Drawing.Size(300, 300)
        Me.universo.TabIndex = 70
        Me.universo.TabStop = False
        '
        'nombre
        '
        Me.nombre.AutoSize = True
        Me.nombre.Font = New System.Drawing.Font("Tahoma", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nombre.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.nombre.Location = New System.Drawing.Point(430, -1)
        Me.nombre.Name = "nombre"
        Me.nombre.Size = New System.Drawing.Size(211, 58)
        Me.nombre.TabIndex = 69
        Me.nombre.Text = "aventura"
        '
        'LabelTitulo
        '
        Me.LabelTitulo.AutoSize = True
        Me.LabelTitulo.Font = New System.Drawing.Font("Tahoma", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTitulo.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.LabelTitulo.Location = New System.Drawing.Point(-1, -1)
        Me.LabelTitulo.Name = "LabelTitulo"
        Me.LabelTitulo.Size = New System.Drawing.Size(442, 58)
        Me.LabelTitulo.TabIndex = 68
        Me.LabelTitulo.Text = "Detalle del universo"
        '
        'LabelNombre
        '
        Me.LabelNombre.AutoSize = True
        Me.LabelNombre.BackColor = System.Drawing.Color.Transparent
        Me.LabelNombre.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelNombre.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.LabelNombre.Location = New System.Drawing.Point(435, 123)
        Me.LabelNombre.Name = "LabelNombre"
        Me.LabelNombre.Size = New System.Drawing.Size(87, 25)
        Me.LabelNombre.TabIndex = 117
        Me.LabelNombre.Text = "Agilidad"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(329, 123)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 25)
        Me.Label1.TabIndex = 126
        Me.Label1.Text = "Nombre"
        '
        'LabelTipo
        '
        Me.LabelTipo.AutoSize = True
        Me.LabelTipo.BackColor = System.Drawing.Color.Transparent
        Me.LabelTipo.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTipo.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.LabelTipo.Location = New System.Drawing.Point(496, 180)
        Me.LabelTipo.Name = "LabelTipo"
        Me.LabelTipo.Size = New System.Drawing.Size(87, 25)
        Me.LabelTipo.TabIndex = 127
        Me.LabelTipo.Text = "Agilidad"
        '
        'PictureBoxTipo
        '
        Me.PictureBoxTipo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBoxTipo.Location = New System.Drawing.Point(440, 169)
        Me.PictureBoxTipo.Name = "PictureBoxTipo"
        Me.PictureBoxTipo.Size = New System.Drawing.Size(50, 50)
        Me.PictureBoxTipo.TabIndex = 128
        Me.PictureBoxTipo.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(329, 180)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 25)
        Me.Label3.TabIndex = 129
        Me.Label3.Text = "Tipo"
        '
        'DetallesUniverso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(787, 436)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PictureBoxTipo)
        Me.Controls.Add(Me.LabelTipo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LabelNombre)
        Me.Controls.Add(Me.universo)
        Me.Controls.Add(Me.nombre)
        Me.Controls.Add(Me.LabelTitulo)
        Me.Name = "DetallesUniverso"
        Me.Text = "DetallesUniverso"
        CType(Me.universo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxTipo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents universo As System.Windows.Forms.PictureBox
    Friend WithEvents nombre As System.Windows.Forms.Label
    Friend WithEvents LabelTitulo As System.Windows.Forms.Label
    Friend WithEvents LabelNombre As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LabelTipo As System.Windows.Forms.Label
    Friend WithEvents PictureBoxTipo As System.Windows.Forms.PictureBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
