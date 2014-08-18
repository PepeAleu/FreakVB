<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AltaEscenario
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
        Me.PanelLineaV = New System.Windows.Forms.Panel
        Me.PanelLineaH = New System.Windows.Forms.Panel
        Me.Label1 = New System.Windows.Forms.Label
        Me.TextBoxNombreEscenario = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.NumericUpDownPoblacionMaxima = New System.Windows.Forms.NumericUpDown
        Me.NumericUpDownPoblacion = New System.Windows.Forms.NumericUpDown
        Me.RadioButton2 = New System.Windows.Forms.RadioButton
        Me.RadioButton1 = New System.Windows.Forms.RadioButton
        Me.Label7 = New System.Windows.Forms.Label
        Me.LabelTitulo = New System.Windows.Forms.Label
        Me.Button3 = New System.Windows.Forms.Button
        Me.ComboBoxuninombre = New System.Windows.Forms.ComboBox
        Me.ComboBoxiduni = New System.Windows.Forms.ComboBox
        Me.ComboBoxEscNombre = New System.Windows.Forms.ComboBox
        Me.ComboBoxIdEsc = New System.Windows.Forms.ComboBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        CType(Me.NumericUpDownPoblacionMaxima, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDownPoblacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelLineaV
        '
        Me.PanelLineaV.BackColor = System.Drawing.Color.LightGray
        Me.PanelLineaV.Location = New System.Drawing.Point(186, -3)
        Me.PanelLineaV.Name = "PanelLineaV"
        Me.PanelLineaV.Size = New System.Drawing.Size(1, 505)
        Me.PanelLineaV.TabIndex = 7
        '
        'PanelLineaH
        '
        Me.PanelLineaH.BackColor = System.Drawing.Color.LightGray
        Me.PanelLineaH.Location = New System.Drawing.Point(-7, 59)
        Me.PanelLineaH.Name = "PanelLineaH"
        Me.PanelLineaH.Size = New System.Drawing.Size(810, 1)
        Me.PanelLineaH.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(98, 74)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 25)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Nombre"
        '
        'TextBoxNombreEscenario
        '
        Me.TextBoxNombreEscenario.Location = New System.Drawing.Point(195, 79)
        Me.TextBoxNombreEscenario.Name = "TextBoxNombreEscenario"
        Me.TextBoxNombreEscenario.Size = New System.Drawing.Size(315, 20)
        Me.TextBoxNombreEscenario.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(83, 124)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 25)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Población"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.Control
        Me.Label3.Location = New System.Drawing.Point(3, 99)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(181, 25)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Población máxima"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.Control
        Me.Label4.Location = New System.Drawing.Point(65, 196)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(119, 25)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Es planeta?"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.Control
        Me.Label5.Location = New System.Drawing.Point(39, 149)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(145, 25)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Que escenario"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(78, 166)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(105, 25)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "pertenece"
        '
        'NumericUpDownPoblacionMaxima
        '
        Me.NumericUpDownPoblacionMaxima.Location = New System.Drawing.Point(195, 104)
        Me.NumericUpDownPoblacionMaxima.Maximum = New Decimal(New Integer() {-727379969, 232, 0, 0})
        Me.NumericUpDownPoblacionMaxima.Name = "NumericUpDownPoblacionMaxima"
        Me.NumericUpDownPoblacionMaxima.Size = New System.Drawing.Size(315, 20)
        Me.NumericUpDownPoblacionMaxima.TabIndex = 16
        '
        'NumericUpDownPoblacion
        '
        Me.NumericUpDownPoblacion.Location = New System.Drawing.Point(195, 129)
        Me.NumericUpDownPoblacion.Maximum = New Decimal(New Integer() {-727379969, 232, 0, 0})
        Me.NumericUpDownPoblacion.Name = "NumericUpDownPoblacion"
        Me.NumericUpDownPoblacion.Size = New System.Drawing.Size(315, 20)
        Me.NumericUpDownPoblacion.TabIndex = 17
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton2.ForeColor = System.Drawing.SystemColors.Control
        Me.RadioButton2.Location = New System.Drawing.Point(244, 196)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(51, 27)
        Me.RadioButton2.TabIndex = 20
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Tag = "0"
        Me.RadioButton2.Text = "No"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton1.ForeColor = System.Drawing.SystemColors.Control
        Me.RadioButton1.Location = New System.Drawing.Point(195, 196)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(43, 27)
        Me.RadioButton1.TabIndex = 19
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Tag = "1"
        Me.RadioButton1.Text = "Sí"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.Control
        Me.Label7.Location = New System.Drawing.Point(91, 221)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(92, 25)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "Universo"
        '
        'LabelTitulo
        '
        Me.LabelTitulo.AutoSize = True
        Me.LabelTitulo.Font = New System.Drawing.Font("Tahoma", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTitulo.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.LabelTitulo.Location = New System.Drawing.Point(189, 1)
        Me.LabelTitulo.Name = "LabelTitulo"
        Me.LabelTitulo.Size = New System.Drawing.Size(387, 58)
        Me.LabelTitulo.TabIndex = 25
        Me.LabelTitulo.Text = "Alta de escenario"
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Button3.Location = New System.Drawing.Point(568, 221)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(145, 33)
        Me.Button3.TabIndex = 27
        Me.Button3.Text = "Adelante"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'ComboBoxuninombre
        '
        Me.ComboBoxuninombre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxuninombre.FormattingEnabled = True
        Me.ComboBoxuninombre.Location = New System.Drawing.Point(253, 225)
        Me.ComboBoxuninombre.Name = "ComboBoxuninombre"
        Me.ComboBoxuninombre.Size = New System.Drawing.Size(257, 21)
        Me.ComboBoxuninombre.TabIndex = 31
        '
        'ComboBoxiduni
        '
        Me.ComboBoxiduni.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxiduni.FormattingEnabled = True
        Me.ComboBoxiduni.Location = New System.Drawing.Point(193, 225)
        Me.ComboBoxiduni.Name = "ComboBoxiduni"
        Me.ComboBoxiduni.Size = New System.Drawing.Size(58, 21)
        Me.ComboBoxiduni.TabIndex = 32
        '
        'ComboBoxEscNombre
        '
        Me.ComboBoxEscNombre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxEscNombre.FormattingEnabled = True
        Me.ComboBoxEscNombre.Location = New System.Drawing.Point(253, 166)
        Me.ComboBoxEscNombre.Name = "ComboBoxEscNombre"
        Me.ComboBoxEscNombre.Size = New System.Drawing.Size(257, 21)
        Me.ComboBoxEscNombre.TabIndex = 33
        '
        'ComboBoxIdEsc
        '
        Me.ComboBoxIdEsc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxIdEsc.FormattingEnabled = True
        Me.ComboBoxIdEsc.Location = New System.Drawing.Point(193, 166)
        Me.ComboBoxIdEsc.Name = "ComboBoxIdEsc"
        Me.ComboBoxIdEsc.Size = New System.Drawing.Size(58, 21)
        Me.ComboBoxIdEsc.TabIndex = 34
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(365, 305)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(80, 13)
        Me.Label8.TabIndex = 146
        Me.Label8.Text = "son obligatorios"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(202, 305)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(146, 13)
        Me.Label9.TabIndex = 145
        Me.Label9.Text = "Los campos con este simbolo"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.IndianRed
        Me.Label11.Location = New System.Drawing.Point(341, 299)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(32, 33)
        Me.Label11.TabIndex = 144
        Me.Label11.Text = "*"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.IndianRed
        Me.Label12.Location = New System.Drawing.Point(516, 72)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(32, 33)
        Me.Label12.TabIndex = 147
        Me.Label12.Text = "*"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.IndianRed
        Me.Label13.Location = New System.Drawing.Point(516, 99)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(32, 33)
        Me.Label13.TabIndex = 148
        Me.Label13.Text = "*"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Tahoma", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.IndianRed
        Me.Label14.Location = New System.Drawing.Point(516, 124)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(32, 33)
        Me.Label14.TabIndex = 149
        Me.Label14.Text = "*"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Tahoma", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.IndianRed
        Me.Label15.Location = New System.Drawing.Point(516, 215)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(32, 33)
        Me.Label15.TabIndex = 150
        Me.Label15.Text = "*"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Tahoma", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.IndianRed
        Me.Label16.Location = New System.Drawing.Point(301, 190)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(32, 33)
        Me.Label16.TabIndex = 151
        Me.Label16.Text = "*"
        '
        'AltaEscenario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(756, 326)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.ComboBoxIdEsc)
        Me.Controls.Add(Me.ComboBoxEscNombre)
        Me.Controls.Add(Me.ComboBoxiduni)
        Me.Controls.Add(Me.ComboBoxuninombre)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.LabelTitulo)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.NumericUpDownPoblacion)
        Me.Controls.Add(Me.NumericUpDownPoblacionMaxima)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBoxNombreEscenario)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PanelLineaH)
        Me.Controls.Add(Me.PanelLineaV)
        Me.Name = "AltaEscenario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AltaEscenario"
        CType(Me.NumericUpDownPoblacionMaxima, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDownPoblacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PanelLineaV As System.Windows.Forms.Panel
    Friend WithEvents PanelLineaH As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBoxNombreEscenario As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents NumericUpDownPoblacionMaxima As System.Windows.Forms.NumericUpDown
    Friend WithEvents NumericUpDownPoblacion As System.Windows.Forms.NumericUpDown
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents LabelTitulo As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents ComboBoxuninombre As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBoxiduni As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBoxEscNombre As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBoxIdEsc As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
End Class
