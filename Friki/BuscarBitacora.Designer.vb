<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BuscarBitacora
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
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.DataGridViewBit = New System.Windows.Forms.DataGridView
        Me.Button4 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Label7 = New System.Windows.Forms.Label
        Me.TextBoxPersonaje = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.TextBoxAventura = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.TextBoxMonstruo = New System.Windows.Forms.TextBox
        Me.RadioButtonEpico = New System.Windows.Forms.RadioButton
        Me.RadioButtonNormal = New System.Windows.Forms.RadioButton
        Me.RadioButtonFracaso = New System.Windows.Forms.RadioButton
        Me.Label4 = New System.Windows.Forms.Label
        Me.RadioButton1 = New System.Windows.Forms.RadioButton
        CType(Me.DataGridViewBit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridViewBit
        '
        Me.DataGridViewBit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewBit.Location = New System.Drawing.Point(23, 251)
        Me.DataGridViewBit.MultiSelect = False
        Me.DataGridViewBit.Name = "DataGridViewBit"
        Me.DataGridViewBit.ReadOnly = True
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.ControlLight
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewBit.RowHeadersDefaultCellStyle = DataGridViewCellStyle10
        Me.DataGridViewBit.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewBit.Size = New System.Drawing.Size(1042, 399)
        Me.DataGridViewBit.TabIndex = 53
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Button4.Location = New System.Drawing.Point(719, 85)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(306, 40)
        Me.Button4.TabIndex = 57
        Me.Button4.Text = "Modificar"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Button3.Location = New System.Drawing.Point(719, 131)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(306, 40)
        Me.Button3.TabIndex = 56
        Me.Button3.Text = "Borrar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Button1.Location = New System.Drawing.Point(719, 177)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(306, 40)
        Me.Button1.TabIndex = 55
        Me.Button1.Text = "Detalle"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Button2.Location = New System.Drawing.Point(719, 39)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(306, 40)
        Me.Button2.TabIndex = 54
        Me.Button2.Text = "Alta"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.Control
        Me.Label7.Location = New System.Drawing.Point(29, 96)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(103, 25)
        Me.Label7.TabIndex = 64
        Me.Label7.Text = "Personaje"
        '
        'TextBoxPersonaje
        '
        Me.TextBoxPersonaje.Location = New System.Drawing.Point(138, 101)
        Me.TextBoxPersonaje.Name = "TextBoxPersonaje"
        Me.TextBoxPersonaje.Size = New System.Drawing.Size(161, 20)
        Me.TextBoxPersonaje.TabIndex = 62
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.Label1.Location = New System.Drawing.Point(3, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(195, 58)
        Me.Label1.TabIndex = 61
        Me.Label1.Text = "Bitácora"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(36, 121)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 25)
        Me.Label2.TabIndex = 66
        Me.Label2.Text = "Aventura"
        '
        'TextBoxAventura
        '
        Me.TextBoxAventura.Location = New System.Drawing.Point(138, 126)
        Me.TextBoxAventura.Name = "TextBoxAventura"
        Me.TextBoxAventura.Size = New System.Drawing.Size(161, 20)
        Me.TextBoxAventura.TabIndex = 65
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.Control
        Me.Label3.Location = New System.Drawing.Point(29, 146)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 25)
        Me.Label3.TabIndex = 68
        Me.Label3.Text = "Monstruo"
        '
        'TextBoxMonstruo
        '
        Me.TextBoxMonstruo.Location = New System.Drawing.Point(138, 151)
        Me.TextBoxMonstruo.Name = "TextBoxMonstruo"
        Me.TextBoxMonstruo.Size = New System.Drawing.Size(161, 20)
        Me.TextBoxMonstruo.TabIndex = 67
        '
        'RadioButtonEpico
        '
        Me.RadioButtonEpico.AutoSize = True
        Me.RadioButtonEpico.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButtonEpico.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.RadioButtonEpico.Location = New System.Drawing.Point(612, 103)
        Me.RadioButtonEpico.Name = "RadioButtonEpico"
        Me.RadioButtonEpico.Size = New System.Drawing.Size(73, 27)
        Me.RadioButtonEpico.TabIndex = 94
        Me.RadioButtonEpico.TabStop = True
        Me.RadioButtonEpico.Tag = "Epico"
        Me.RadioButtonEpico.Text = "Epico"
        Me.RadioButtonEpico.UseVisualStyleBackColor = True
        '
        'RadioButtonNormal
        '
        Me.RadioButtonNormal.AutoSize = True
        Me.RadioButtonNormal.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButtonNormal.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.RadioButtonNormal.Location = New System.Drawing.Point(518, 103)
        Me.RadioButtonNormal.Name = "RadioButtonNormal"
        Me.RadioButtonNormal.Size = New System.Drawing.Size(88, 27)
        Me.RadioButtonNormal.TabIndex = 93
        Me.RadioButtonNormal.TabStop = True
        Me.RadioButtonNormal.Tag = "Normal"
        Me.RadioButtonNormal.Text = "Normal"
        Me.RadioButtonNormal.UseVisualStyleBackColor = True
        '
        'RadioButtonFracaso
        '
        Me.RadioButtonFracaso.AutoSize = True
        Me.RadioButtonFracaso.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButtonFracaso.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.RadioButtonFracaso.Location = New System.Drawing.Point(420, 101)
        Me.RadioButtonFracaso.Name = "RadioButtonFracaso"
        Me.RadioButtonFracaso.Size = New System.Drawing.Size(92, 27)
        Me.RadioButtonFracaso.TabIndex = 92
        Me.RadioButtonFracaso.TabStop = True
        Me.RadioButtonFracaso.Tag = "Fracaso"
        Me.RadioButtonFracaso.Text = "Fracaso"
        Me.RadioButtonFracaso.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.Control
        Me.Label4.Location = New System.Drawing.Point(352, 101)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 25)
        Me.Label4.TabIndex = 96
        Me.Label4.Text = "Modo"
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.RadioButton1.Location = New System.Drawing.Point(420, 124)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(70, 27)
        Me.RadioButton1.TabIndex = 97
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Tag = ""
        Me.RadioButton1.Text = "Todo"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'BuscarBitacora
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1084, 662)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.RadioButtonEpico)
        Me.Controls.Add(Me.RadioButtonNormal)
        Me.Controls.Add(Me.RadioButtonFracaso)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBoxMonstruo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBoxAventura)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TextBoxPersonaje)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.DataGridViewBit)
        Me.Name = "BuscarBitacora"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BuscarBitacora"
        CType(Me.DataGridViewBit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridViewBit As System.Windows.Forms.DataGridView
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TextBoxPersonaje As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBoxAventura As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBoxMonstruo As System.Windows.Forms.TextBox
    Friend WithEvents RadioButtonEpico As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonNormal As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonFracaso As System.Windows.Forms.RadioButton
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
End Class
