<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BuscarEscenario
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
        Me.ComboBoxMayorque2 = New System.Windows.Forms.ComboBox
        Me.ComboBoxMayorque = New System.Windows.Forms.ComboBox
        Me.RadioButtonNo = New System.Windows.Forms.RadioButton
        Me.RadioButtonSi = New System.Windows.Forms.RadioButton
        Me.Label5 = New System.Windows.Forms.Label
        Me.TextBoxEsc = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.NumericUpDownMaxPoblacion = New System.Windows.Forms.NumericUpDown
        Me.Label3 = New System.Windows.Forms.Label
        Me.NumericUpDownPoblacion = New System.Windows.Forms.NumericUpDown
        Me.Label2 = New System.Windows.Forms.Label
        Me.DataGridViewEsc = New System.Windows.Forms.DataGridView
        Me.Label1 = New System.Windows.Forms.Label
        Me.PictureBoxEsc = New System.Windows.Forms.PictureBox
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        CType(Me.NumericUpDownMaxPoblacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDownPoblacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridViewEsc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxEsc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ComboBoxMayorque2
        '
        Me.ComboBoxMayorque2.FormattingEnabled = True
        Me.ComboBoxMayorque2.Items.AddRange(New Object() {"--", "Igual a", "Mayor que", "Menor que"})
        Me.ComboBoxMayorque2.Location = New System.Drawing.Point(277, 154)
        Me.ComboBoxMayorque2.Name = "ComboBoxMayorque2"
        Me.ComboBoxMayorque2.Size = New System.Drawing.Size(108, 21)
        Me.ComboBoxMayorque2.TabIndex = 26
        '
        'ComboBoxMayorque
        '
        Me.ComboBoxMayorque.FormattingEnabled = True
        Me.ComboBoxMayorque.Items.AddRange(New Object() {"--", "Igual a", "Mayor que", "Menor que"})
        Me.ComboBoxMayorque.Location = New System.Drawing.Point(277, 96)
        Me.ComboBoxMayorque.Name = "ComboBoxMayorque"
        Me.ComboBoxMayorque.Size = New System.Drawing.Size(108, 21)
        Me.ComboBoxMayorque.TabIndex = 25
        '
        'RadioButtonNo
        '
        Me.RadioButtonNo.AutoSize = True
        Me.RadioButtonNo.BackColor = System.Drawing.Color.Transparent
        Me.RadioButtonNo.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButtonNo.ForeColor = System.Drawing.Color.White
        Me.RadioButtonNo.Location = New System.Drawing.Point(96, 155)
        Me.RadioButtonNo.Name = "RadioButtonNo"
        Me.RadioButtonNo.Size = New System.Drawing.Size(51, 27)
        Me.RadioButtonNo.TabIndex = 13
        Me.RadioButtonNo.TabStop = True
        Me.RadioButtonNo.Text = "No"
        Me.RadioButtonNo.UseVisualStyleBackColor = False
        '
        'RadioButtonSi
        '
        Me.RadioButtonSi.AutoSize = True
        Me.RadioButtonSi.BackColor = System.Drawing.Color.Transparent
        Me.RadioButtonSi.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButtonSi.ForeColor = System.Drawing.Color.White
        Me.RadioButtonSi.Location = New System.Drawing.Point(47, 155)
        Me.RadioButtonSi.Name = "RadioButtonSi"
        Me.RadioButtonSi.Size = New System.Drawing.Size(43, 27)
        Me.RadioButtonSi.TabIndex = 12
        Me.RadioButtonSi.TabStop = True
        Me.RadioButtonSi.Text = "Sí"
        Me.RadioButtonSi.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(42, 127)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(119, 25)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Es Planeta?"
        '
        'TextBoxEsc
        '
        Me.TextBoxEsc.Location = New System.Drawing.Point(53, 97)
        Me.TextBoxEsc.Name = "TextBoxEsc"
        Me.TextBoxEsc.Size = New System.Drawing.Size(201, 20)
        Me.TextBoxEsc.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(42, 69)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 25)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Nombre"
        '
        'NumericUpDownMaxPoblacion
        '
        Me.NumericUpDownMaxPoblacion.Location = New System.Drawing.Point(396, 155)
        Me.NumericUpDownMaxPoblacion.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.NumericUpDownMaxPoblacion.Name = "NumericUpDownMaxPoblacion"
        Me.NumericUpDownMaxPoblacion.Size = New System.Drawing.Size(82, 20)
        Me.NumericUpDownMaxPoblacion.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(266, 127)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(179, 25)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Máxima población"
        '
        'NumericUpDownPoblacion
        '
        Me.NumericUpDownPoblacion.Location = New System.Drawing.Point(396, 97)
        Me.NumericUpDownPoblacion.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.NumericUpDownPoblacion.Name = "NumericUpDownPoblacion"
        Me.NumericUpDownPoblacion.Size = New System.Drawing.Size(82, 20)
        Me.NumericUpDownPoblacion.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(266, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 25)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Población"
        '
        'DataGridViewEsc
        '
        Me.DataGridViewEsc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewEsc.Location = New System.Drawing.Point(18, 251)
        Me.DataGridViewEsc.MultiSelect = False
        Me.DataGridViewEsc.Name = "DataGridViewEsc"
        Me.DataGridViewEsc.ReadOnly = True
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlLight
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewEsc.RowHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewEsc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewEsc.Size = New System.Drawing.Size(1042, 399)
        Me.DataGridViewEsc.TabIndex = 27
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.Label1.Location = New System.Drawing.Point(6, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(247, 58)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "Escenarios"
        '
        'PictureBoxEsc
        '
        Me.PictureBoxEsc.Location = New System.Drawing.Point(510, 26)
        Me.PictureBoxEsc.Name = "PictureBoxEsc"
        Me.PictureBoxEsc.Size = New System.Drawing.Size(200, 200)
        Me.PictureBoxEsc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxEsc.TabIndex = 29
        Me.PictureBoxEsc.TabStop = False
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Button2.Location = New System.Drawing.Point(739, 39)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(306, 40)
        Me.Button2.TabIndex = 31
        Me.Button2.Text = "Alta"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Button1.Location = New System.Drawing.Point(739, 177)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(306, 40)
        Me.Button1.TabIndex = 32
        Me.Button1.Text = "Detalle"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Button3.Location = New System.Drawing.Point(739, 131)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(306, 40)
        Me.Button3.TabIndex = 33
        Me.Button3.Text = "Borrar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Button4.Location = New System.Drawing.Point(739, 85)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(306, 40)
        Me.Button4.TabIndex = 34
        Me.Button4.Text = "Modificar"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'BuscarEscenario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1084, 662)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.PictureBoxEsc)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridViewEsc)
        Me.Controls.Add(Me.ComboBoxMayorque2)
        Me.Controls.Add(Me.ComboBoxMayorque)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.NumericUpDownPoblacion)
        Me.Controls.Add(Me.RadioButtonNo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.RadioButtonSi)
        Me.Controls.Add(Me.NumericUpDownMaxPoblacion)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBoxEsc)
        Me.Name = "BuscarEscenario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BuscarEscenario"
        CType(Me.NumericUpDownMaxPoblacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDownPoblacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridViewEsc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxEsc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ComboBoxMayorque2 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBoxMayorque As System.Windows.Forms.ComboBox
    Friend WithEvents RadioButtonNo As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonSi As System.Windows.Forms.RadioButton
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TextBoxEsc As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents NumericUpDownMaxPoblacion As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents NumericUpDownPoblacion As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DataGridViewEsc As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBoxEsc As System.Windows.Forms.PictureBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
End Class
