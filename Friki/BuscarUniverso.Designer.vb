<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BuscarUniverso
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
        Me.ComboBoxTipo = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.TextBoxUni = New System.Windows.Forms.TextBox
        Me.DataGridViewUni = New System.Windows.Forms.DataGridView
        Me.PictureBoxUni = New System.Windows.Forms.PictureBox
        CType(Me.DataGridViewUni, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxUni, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Button4.Location = New System.Drawing.Point(758, 73)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(306, 40)
        Me.Button4.TabIndex = 43
        Me.Button4.Text = "Modificar"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Button3.Location = New System.Drawing.Point(758, 119)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(306, 40)
        Me.Button3.TabIndex = 42
        Me.Button3.Text = "Borrar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Button1.Location = New System.Drawing.Point(758, 165)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(306, 40)
        Me.Button1.TabIndex = 41
        Me.Button1.Text = "Detalle"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Button2.Location = New System.Drawing.Point(758, 27)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(306, 40)
        Me.Button2.TabIndex = 40
        Me.Button2.Text = "Alta"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(228, 58)
        Me.Label1.TabIndex = 53
        Me.Label1.Text = "Universos"
        '
        'ComboBoxTipo
        '
        Me.ComboBoxTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxTipo.FormattingEnabled = True
        Me.ComboBoxTipo.Location = New System.Drawing.Point(144, 182)
        Me.ComboBoxTipo.Name = "ComboBoxTipo"
        Me.ComboBoxTipo.Size = New System.Drawing.Size(201, 21)
        Me.ComboBoxTipo.TabIndex = 51
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(133, 154)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 25)
        Me.Label2.TabIndex = 44
        Me.Label2.Text = "Tipo"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(133, 91)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 25)
        Me.Label4.TabIndex = 46
        Me.Label4.Text = "Nombre"
        '
        'TextBoxUni
        '
        Me.TextBoxUni.Location = New System.Drawing.Point(144, 119)
        Me.TextBoxUni.Name = "TextBoxUni"
        Me.TextBoxUni.Size = New System.Drawing.Size(201, 20)
        Me.TextBoxUni.TabIndex = 47
        '
        'DataGridViewUni
        '
        Me.DataGridViewUni.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewUni.Location = New System.Drawing.Point(22, 251)
        Me.DataGridViewUni.MultiSelect = False
        Me.DataGridViewUni.Name = "DataGridViewUni"
        Me.DataGridViewUni.ReadOnly = True
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlLight
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewUni.RowHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewUni.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewUni.Size = New System.Drawing.Size(1042, 399)
        Me.DataGridViewUni.TabIndex = 54
        '
        'PictureBoxUni
        '
        Me.PictureBoxUni.Location = New System.Drawing.Point(460, 27)
        Me.PictureBoxUni.Name = "PictureBoxUni"
        Me.PictureBoxUni.Size = New System.Drawing.Size(200, 200)
        Me.PictureBoxUni.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxUni.TabIndex = 55
        Me.PictureBoxUni.TabStop = False
        '
        'BuscarUniverso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1084, 662)
        Me.Controls.Add(Me.PictureBoxUni)
        Me.Controls.Add(Me.DataGridViewUni)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBoxTipo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBoxUni)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button2)
        Me.Name = "BuscarUniverso"
        Me.Text = "BuscarUniverso"
        CType(Me.DataGridViewUni, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxUni, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ComboBoxTipo As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextBoxUni As System.Windows.Forms.TextBox
    Friend WithEvents DataGridViewUni As System.Windows.Forms.DataGridView
    Friend WithEvents PictureBoxUni As System.Windows.Forms.PictureBox
End Class
