<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BuscarPersonaje
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BuscarPersonaje))
        Me.Button4 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.ComboBoxRaza = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.DataGridViewPer = New System.Windows.Forms.DataGridView
        Me.Label1 = New System.Windows.Forms.Label
        Me.PictureBoxEsc = New System.Windows.Forms.PictureBox
        Me.ComboBoxClase = New System.Windows.Forms.ComboBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.PictureBox3 = New System.Windows.Forms.PictureBox
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.RadioButtonBueno = New System.Windows.Forms.RadioButton
        Me.RadioButtonNeutral = New System.Windows.Forms.RadioButton
        Me.RadioButtonMalvado = New System.Windows.Forms.RadioButton
        Me.Label8 = New System.Windows.Forms.Label
        Me.PictureBox5 = New System.Windows.Forms.PictureBox
        Me.PictureBox4 = New System.Windows.Forms.PictureBox
        Me.RadioButtonF = New System.Windows.Forms.RadioButton
        Me.RadioButtonV = New System.Windows.Forms.RadioButton
        Me.Label6 = New System.Windows.Forms.Label
        Me.TextBoxPer = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.PanelFuerza = New System.Windows.Forms.Panel
        Me.PanelAgilidad = New System.Windows.Forms.Panel
        Me.PanelInteligencia = New System.Windows.Forms.Panel
        Me.Button5 = New System.Windows.Forms.Button
        Me.Button6 = New System.Windows.Forms.Button
        Me.Button7 = New System.Windows.Forms.Button
        Me.Button8 = New System.Windows.Forms.Button
        Me.Button9 = New System.Windows.Forms.Button
        Me.Button10 = New System.Windows.Forms.Button
        Me.CheckBoxStats = New System.Windows.Forms.CheckBox
        CType(Me.DataGridViewPer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxEsc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Button4.Location = New System.Drawing.Point(766, 94)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(306, 40)
        Me.Button4.TabIndex = 78
        Me.Button4.Text = "Modificar"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Button3.Location = New System.Drawing.Point(766, 140)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(306, 40)
        Me.Button3.TabIndex = 77
        Me.Button3.Text = "Borrar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Button1.Location = New System.Drawing.Point(766, 186)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(306, 40)
        Me.Button1.TabIndex = 76
        Me.Button1.Text = "Detalle"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Button2.Location = New System.Drawing.Point(766, 48)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(306, 40)
        Me.Button2.TabIndex = 75
        Me.Button2.Text = "Alta"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'ComboBoxRaza
        '
        Me.ComboBoxRaza.FormattingEnabled = True
        Me.ComboBoxRaza.Location = New System.Drawing.Point(375, 94)
        Me.ComboBoxRaza.Name = "ComboBoxRaza"
        Me.ComboBoxRaza.Size = New System.Drawing.Size(179, 21)
        Me.ComboBoxRaza.TabIndex = 82
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(313, 90)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 25)
        Me.Label3.TabIndex = 81
        Me.Label3.Text = "Raza"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(272, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(256, 25)
        Me.Label4.TabIndex = 79
        Me.Label4.Text = "Nombre - Apellidos - Alias"
        '
        'DataGridViewPer
        '
        Me.DataGridViewPer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewPer.Location = New System.Drawing.Point(22, 247)
        Me.DataGridViewPer.MultiSelect = False
        Me.DataGridViewPer.Name = "DataGridViewPer"
        Me.DataGridViewPer.ReadOnly = True
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlLight
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewPer.RowHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewPer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewPer.Size = New System.Drawing.Size(1042, 399)
        Me.DataGridViewPer.TabIndex = 84
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.Label1.Location = New System.Drawing.Point(-6, -3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(252, 58)
        Me.Label1.TabIndex = 83
        Me.Label1.Text = "Personajes"
        '
        'PictureBoxEsc
        '
        Me.PictureBoxEsc.Location = New System.Drawing.Point(560, 26)
        Me.PictureBoxEsc.Name = "PictureBoxEsc"
        Me.PictureBoxEsc.Size = New System.Drawing.Size(200, 200)
        Me.PictureBoxEsc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxEsc.TabIndex = 74
        Me.PictureBoxEsc.TabStop = False
        '
        'ComboBoxClase
        '
        Me.ComboBoxClase.FormattingEnabled = True
        Me.ComboBoxClase.Location = New System.Drawing.Point(375, 125)
        Me.ComboBoxClase.Name = "ComboBoxClase"
        Me.ComboBoxClase.Size = New System.Drawing.Size(179, 21)
        Me.ComboBoxClase.TabIndex = 92
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(313, 121)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 25)
        Me.Label7.TabIndex = 91
        Me.Label7.Text = "Clase"
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(391, 189)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(50, 50)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox3.TabIndex = 99
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(242, 189)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(50, 50)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 98
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(101, 189)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(50, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 97
        Me.PictureBox1.TabStop = False
        '
        'RadioButtonBueno
        '
        Me.RadioButtonBueno.AutoSize = True
        Me.RadioButtonBueno.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButtonBueno.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.RadioButtonBueno.Location = New System.Drawing.Point(24, 200)
        Me.RadioButtonBueno.Name = "RadioButtonBueno"
        Me.RadioButtonBueno.Size = New System.Drawing.Size(81, 27)
        Me.RadioButtonBueno.TabIndex = 96
        Me.RadioButtonBueno.TabStop = True
        Me.RadioButtonBueno.Tag = "Bueno"
        Me.RadioButtonBueno.Text = "Bueno"
        Me.RadioButtonBueno.UseVisualStyleBackColor = True
        '
        'RadioButtonNeutral
        '
        Me.RadioButtonNeutral.AutoSize = True
        Me.RadioButtonNeutral.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButtonNeutral.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.RadioButtonNeutral.Location = New System.Drawing.Point(157, 200)
        Me.RadioButtonNeutral.Name = "RadioButtonNeutral"
        Me.RadioButtonNeutral.Size = New System.Drawing.Size(89, 27)
        Me.RadioButtonNeutral.TabIndex = 95
        Me.RadioButtonNeutral.TabStop = True
        Me.RadioButtonNeutral.Tag = "Neutral"
        Me.RadioButtonNeutral.Text = "Neutral"
        Me.RadioButtonNeutral.UseVisualStyleBackColor = True
        '
        'RadioButtonMalvado
        '
        Me.RadioButtonMalvado.AutoSize = True
        Me.RadioButtonMalvado.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButtonMalvado.ForeColor = System.Drawing.Color.DarkRed
        Me.RadioButtonMalvado.Location = New System.Drawing.Point(298, 200)
        Me.RadioButtonMalvado.Name = "RadioButtonMalvado"
        Me.RadioButtonMalvado.Size = New System.Drawing.Size(97, 27)
        Me.RadioButtonMalvado.TabIndex = 94
        Me.RadioButtonMalvado.TabStop = True
        Me.RadioButtonMalvado.Tag = "Malvado"
        Me.RadioButtonMalvado.Text = "Malvado"
        Me.RadioButtonMalvado.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.Control
        Me.Label8.Location = New System.Drawing.Point(12, 155)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(133, 25)
        Me.Label8.TabIndex = 93
        Me.Label8.Text = "Alineamiento"
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(447, 156)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(14, 19)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox5.TabIndex = 103
        Me.PictureBox5.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(385, 156)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(18, 19)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox4.TabIndex = 102
        Me.PictureBox4.TabStop = False
        '
        'RadioButtonF
        '
        Me.RadioButtonF.AutoSize = True
        Me.RadioButtonF.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButtonF.ForeColor = System.Drawing.SystemColors.Control
        Me.RadioButtonF.Location = New System.Drawing.Point(427, 162)
        Me.RadioButtonF.Name = "RadioButtonF"
        Me.RadioButtonF.Size = New System.Drawing.Size(14, 13)
        Me.RadioButtonF.TabIndex = 101
        Me.RadioButtonF.TabStop = True
        Me.RadioButtonF.Tag = "Femenino"
        Me.RadioButtonF.UseVisualStyleBackColor = True
        '
        'RadioButtonV
        '
        Me.RadioButtonV.AutoSize = True
        Me.RadioButtonV.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButtonV.ForeColor = System.Drawing.SystemColors.Control
        Me.RadioButtonV.Location = New System.Drawing.Point(366, 162)
        Me.RadioButtonV.Name = "RadioButtonV"
        Me.RadioButtonV.Size = New System.Drawing.Size(14, 13)
        Me.RadioButtonV.TabIndex = 100
        Me.RadioButtonV.TabStop = True
        Me.RadioButtonV.Tag = "Masculino"
        Me.RadioButtonV.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(296, 153)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 25)
        Me.Label6.TabIndex = 104
        Me.Label6.Text = "Sexo"
        '
        'TextBoxPer
        '
        Me.TextBoxPer.Location = New System.Drawing.Point(375, 55)
        Me.TextBoxPer.Name = "TextBoxPer"
        Me.TextBoxPer.Size = New System.Drawing.Size(179, 20)
        Me.TextBoxPer.TabIndex = 80
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(55, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 25)
        Me.Label2.TabIndex = 105
        Me.Label2.Text = "Fuerza"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(8, 121)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(121, 25)
        Me.Label5.TabIndex = 106
        Me.Label5.Text = "Inteligencia"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(42, 90)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(87, 25)
        Me.Label9.TabIndex = 107
        Me.Label9.Text = "Agilidad"
        '
        'PanelFuerza
        '
        Me.PanelFuerza.Location = New System.Drawing.Point(146, 58)
        Me.PanelFuerza.Name = "PanelFuerza"
        Me.PanelFuerza.Size = New System.Drawing.Size(151, 26)
        Me.PanelFuerza.TabIndex = 108
        '
        'PanelAgilidad
        '
        Me.PanelAgilidad.Location = New System.Drawing.Point(146, 90)
        Me.PanelAgilidad.Name = "PanelAgilidad"
        Me.PanelAgilidad.Size = New System.Drawing.Size(151, 26)
        Me.PanelAgilidad.TabIndex = 109
        '
        'PanelInteligencia
        '
        Me.PanelInteligencia.Location = New System.Drawing.Point(146, 122)
        Me.PanelInteligencia.Name = "PanelInteligencia"
        Me.PanelInteligencia.Size = New System.Drawing.Size(151, 26)
        Me.PanelInteligencia.TabIndex = 109
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(289, 59)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(23, 23)
        Me.Button5.TabIndex = 110
        Me.Button5.Text = "+"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(128, 59)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(23, 23)
        Me.Button6.TabIndex = 111
        Me.Button6.Text = "-"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(289, 123)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(23, 23)
        Me.Button7.TabIndex = 112
        Me.Button7.Text = "+"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(289, 90)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(23, 23)
        Me.Button8.TabIndex = 113
        Me.Button8.Text = "+"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(128, 123)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(23, 23)
        Me.Button9.TabIndex = 114
        Me.Button9.Text = "-"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button10
        '
        Me.Button10.Location = New System.Drawing.Point(128, 91)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(23, 23)
        Me.Button10.TabIndex = 115
        Me.Button10.Text = "-"
        Me.Button10.UseVisualStyleBackColor = True
        '
        'CheckBoxStats
        '
        Me.CheckBoxStats.AutoSize = True
        Me.CheckBoxStats.Location = New System.Drawing.Point(8, 59)
        Me.CheckBoxStats.Name = "CheckBoxStats"
        Me.CheckBoxStats.Size = New System.Drawing.Size(50, 17)
        Me.CheckBoxStats.TabIndex = 116
        Me.CheckBoxStats.Text = "Stats"
        Me.CheckBoxStats.UseVisualStyleBackColor = True
        '
        'BuscarPersonaje
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1084, 662)
        Me.Controls.Add(Me.CheckBoxStats)
        Me.Controls.Add(Me.Button10)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.PanelInteligencia)
        Me.Controls.Add(Me.PanelAgilidad)
        Me.Controls.Add(Me.PanelFuerza)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.RadioButtonF)
        Me.Controls.Add(Me.RadioButtonV)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.RadioButtonBueno)
        Me.Controls.Add(Me.RadioButtonNeutral)
        Me.Controls.Add(Me.RadioButtonMalvado)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.ComboBoxClase)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.DataGridViewPer)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBoxRaza)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBoxPer)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.PictureBoxEsc)
        Me.Name = "BuscarPersonaje"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BuscarPersonaje"
        CType(Me.DataGridViewPer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxEsc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents PictureBoxEsc As System.Windows.Forms.PictureBox
    Friend WithEvents ComboBoxRaza As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents DataGridViewPer As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ComboBoxClase As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents RadioButtonBueno As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonNeutral As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonMalvado As System.Windows.Forms.RadioButton
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents RadioButtonF As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonV As System.Windows.Forms.RadioButton
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TextBoxPer As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents PanelFuerza As System.Windows.Forms.Panel
    Friend WithEvents PanelAgilidad As System.Windows.Forms.Panel
    Friend WithEvents PanelInteligencia As System.Windows.Forms.Panel
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents Button10 As System.Windows.Forms.Button
    Friend WithEvents CheckBoxStats As System.Windows.Forms.CheckBox
End Class
