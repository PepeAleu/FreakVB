<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BuscarAventura
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.Button4 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.DataGridViewAve = New System.Windows.Forms.DataGridView
        Me.TextBoxDescripcion = New System.Windows.Forms.TextBox
        Me.TextBoxNombreAventura = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        CType(Me.DataGridViewAve, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Button4.Location = New System.Drawing.Point(638, 71)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(306, 40)
        Me.Button4.TabIndex = 39
        Me.Button4.Text = "Modificar"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Button3.Location = New System.Drawing.Point(638, 117)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(306, 40)
        Me.Button3.TabIndex = 38
        Me.Button3.Text = "Borrar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Button1.Location = New System.Drawing.Point(638, 163)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(306, 40)
        Me.Button1.TabIndex = 37
        Me.Button1.Text = "Detalle"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Button2.Location = New System.Drawing.Point(638, 25)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(306, 40)
        Me.Button2.TabIndex = 36
        Me.Button2.Text = "Alta"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.Label1.Location = New System.Drawing.Point(1, -1)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(236, 58)
        Me.Label1.TabIndex = 51
        Me.Label1.Text = "Aventuras"
        '
        'DataGridViewAve
        '
        Me.DataGridViewAve.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewAve.Location = New System.Drawing.Point(22, 251)
        Me.DataGridViewAve.MultiSelect = False
        Me.DataGridViewAve.Name = "DataGridViewAve"
        Me.DataGridViewAve.ReadOnly = True
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlLight
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewAve.RowHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewAve.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewAve.Size = New System.Drawing.Size(1042, 399)
        Me.DataGridViewAve.TabIndex = 52
        '
        'TextBoxDescripcion
        '
        Me.TextBoxDescripcion.Location = New System.Drawing.Point(179, 124)
        Me.TextBoxDescripcion.Multiline = True
        Me.TextBoxDescripcion.Name = "TextBoxDescripcion"
        Me.TextBoxDescripcion.Size = New System.Drawing.Size(347, 91)
        Me.TextBoxDescripcion.TabIndex = 55
        '
        'TextBoxNombreAventura
        '
        Me.TextBoxNombreAventura.Location = New System.Drawing.Point(179, 91)
        Me.TextBoxNombreAventura.Name = "TextBoxNombreAventura"
        Me.TextBoxNombreAventura.Size = New System.Drawing.Size(347, 20)
        Me.TextBoxNombreAventura.TabIndex = 54
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.Control
        Me.Label8.Location = New System.Drawing.Point(54, 119)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(119, 25)
        Me.Label8.TabIndex = 60
        Me.Label8.Text = "Descripción"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.Control
        Me.Label7.Location = New System.Drawing.Point(87, 86)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(86, 25)
        Me.Label7.TabIndex = 59
        Me.Label7.Text = "Nombre"
        '
        'BuscarAventura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1084, 662)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TextBoxDescripcion)
        Me.Controls.Add(Me.TextBoxNombreAventura)
        Me.Controls.Add(Me.DataGridViewAve)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button2)
        Me.Name = "BuscarAventura"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BuscarAventura"
        CType(Me.DataGridViewAve, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DataGridViewAve As System.Windows.Forms.DataGridView
    Friend WithEvents TextBoxDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxNombreAventura As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
End Class
