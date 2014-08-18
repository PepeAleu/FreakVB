<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Duelo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Duelo))
        Me.ComboBoxPer1 = New System.Windows.Forms.ComboBox
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.personaje2 = New System.Windows.Forms.PictureBox
        Me.personaje1 = New System.Windows.Forms.PictureBox
        Me.ComboBoxIdPer1 = New System.Windows.Forms.ComboBox
        Me.ComboBoxIdPer2 = New System.Windows.Forms.ComboBox
        Me.ComboBoxPer2 = New System.Windows.Forms.ComboBox
        Me.DateTimePickerFecha = New System.Windows.Forms.DateTimePicker
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.PanelI2 = New System.Windows.Forms.Panel
        Me.PanelA2 = New System.Windows.Forms.Panel
        Me.Panelf2 = New System.Windows.Forms.Panel
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Paneli1 = New System.Windows.Forms.Panel
        Me.Panela1 = New System.Windows.Forms.Panel
        Me.Panelf1 = New System.Windows.Forms.Panel
        Me.ComboBoxIdAve = New System.Windows.Forms.ComboBox
        Me.ComboBoxAve = New System.Windows.Forms.ComboBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.LabelGanador = New System.Windows.Forms.Label
        Me.DataGridViewDuelos = New System.Windows.Forms.DataGridView
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.personaje2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.personaje1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridViewDuelos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ComboBoxPer1
        '
        Me.ComboBoxPer1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxPer1.FormattingEnabled = True
        Me.ComboBoxPer1.Location = New System.Drawing.Point(357, 44)
        Me.ComboBoxPer1.Name = "ComboBoxPer1"
        Me.ComboBoxPer1.Size = New System.Drawing.Size(241, 21)
        Me.ComboBoxPer1.TabIndex = 71
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(604, 189)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(40, 40)
        Me.PictureBox2.TabIndex = 70
        Me.PictureBox2.TabStop = False
        '
        'personaje2
        '
        Me.personaje2.Location = New System.Drawing.Point(650, 71)
        Me.personaje2.Name = "personaje2"
        Me.personaje2.Size = New System.Drawing.Size(300, 300)
        Me.personaje2.TabIndex = 69
        Me.personaje2.TabStop = False
        '
        'personaje1
        '
        Me.personaje1.Location = New System.Drawing.Point(298, 71)
        Me.personaje1.Name = "personaje1"
        Me.personaje1.Size = New System.Drawing.Size(300, 300)
        Me.personaje1.TabIndex = 68
        Me.personaje1.TabStop = False
        '
        'ComboBoxIdPer1
        '
        Me.ComboBoxIdPer1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxIdPer1.FormattingEnabled = True
        Me.ComboBoxIdPer1.Location = New System.Drawing.Point(298, 44)
        Me.ComboBoxIdPer1.Name = "ComboBoxIdPer1"
        Me.ComboBoxIdPer1.Size = New System.Drawing.Size(58, 21)
        Me.ComboBoxIdPer1.TabIndex = 73
        '
        'ComboBoxIdPer2
        '
        Me.ComboBoxIdPer2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxIdPer2.FormattingEnabled = True
        Me.ComboBoxIdPer2.Location = New System.Drawing.Point(650, 44)
        Me.ComboBoxIdPer2.Name = "ComboBoxIdPer2"
        Me.ComboBoxIdPer2.Size = New System.Drawing.Size(58, 21)
        Me.ComboBoxIdPer2.TabIndex = 75
        '
        'ComboBoxPer2
        '
        Me.ComboBoxPer2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxPer2.FormattingEnabled = True
        Me.ComboBoxPer2.Location = New System.Drawing.Point(709, 44)
        Me.ComboBoxPer2.Name = "ComboBoxPer2"
        Me.ComboBoxPer2.Size = New System.Drawing.Size(241, 21)
        Me.ComboBoxPer2.TabIndex = 74
        '
        'DateTimePickerFecha
        '
        Me.DateTimePickerFecha.CustomFormat = "DD/MM/YYYY"
        Me.DateTimePickerFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePickerFecha.Location = New System.Drawing.Point(12, 12)
        Me.DateTimePickerFecha.Name = "DateTimePickerFecha"
        Me.DateTimePickerFecha.Size = New System.Drawing.Size(254, 20)
        Me.DateTimePickerFecha.TabIndex = 76
        Me.DateTimePickerFecha.Value = New Date(2012, 3, 15, 0, 0, 0, 0)
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(999, 168)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(87, 25)
        Me.Label9.TabIndex = 121
        Me.Label9.Text = "Agilidad"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(965, 193)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(121, 25)
        Me.Label5.TabIndex = 120
        Me.Label5.Text = "Inteligencia"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(1012, 143)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 25)
        Me.Label2.TabIndex = 119
        Me.Label2.Text = "Fuerza"
        '
        'PanelI2
        '
        Me.PanelI2.Location = New System.Drawing.Point(1078, 199)
        Me.PanelI2.Name = "PanelI2"
        Me.PanelI2.Size = New System.Drawing.Size(151, 26)
        Me.PanelI2.TabIndex = 117
        '
        'PanelA2
        '
        Me.PanelA2.Location = New System.Drawing.Point(1078, 174)
        Me.PanelA2.Name = "PanelA2"
        Me.PanelA2.Size = New System.Drawing.Size(151, 26)
        Me.PanelA2.TabIndex = 118
        '
        'Panelf2
        '
        Me.Panelf2.Location = New System.Drawing.Point(1075, 151)
        Me.Panelf2.Name = "Panelf2"
        Me.Panelf2.Size = New System.Drawing.Size(151, 26)
        Me.Panelf2.TabIndex = 116
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(49, 168)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 25)
        Me.Label1.TabIndex = 127
        Me.Label1.Text = "Agilidad"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(15, 193)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(121, 25)
        Me.Label3.TabIndex = 126
        Me.Label3.Text = "Inteligencia"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(62, 143)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 25)
        Me.Label4.TabIndex = 125
        Me.Label4.Text = "Fuerza"
        '
        'Paneli1
        '
        Me.Paneli1.Location = New System.Drawing.Point(128, 199)
        Me.Paneli1.Name = "Paneli1"
        Me.Paneli1.Size = New System.Drawing.Size(151, 26)
        Me.Paneli1.TabIndex = 123
        '
        'Panela1
        '
        Me.Panela1.Location = New System.Drawing.Point(128, 174)
        Me.Panela1.Name = "Panela1"
        Me.Panela1.Size = New System.Drawing.Size(151, 26)
        Me.Panela1.TabIndex = 124
        '
        'Panelf1
        '
        Me.Panelf1.Location = New System.Drawing.Point(125, 151)
        Me.Panelf1.Name = "Panelf1"
        Me.Panelf1.Size = New System.Drawing.Size(151, 26)
        Me.Panelf1.TabIndex = 122
        '
        'ComboBoxIdAve
        '
        Me.ComboBoxIdAve.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxIdAve.FormattingEnabled = True
        Me.ComboBoxIdAve.Location = New System.Drawing.Point(8, 38)
        Me.ComboBoxIdAve.Name = "ComboBoxIdAve"
        Me.ComboBoxIdAve.Size = New System.Drawing.Size(58, 21)
        Me.ComboBoxIdAve.TabIndex = 129
        '
        'ComboBoxAve
        '
        Me.ComboBoxAve.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxAve.FormattingEnabled = True
        Me.ComboBoxAve.Location = New System.Drawing.Point(67, 38)
        Me.ComboBoxAve.Name = "ComboBoxAve"
        Me.ComboBoxAve.Size = New System.Drawing.Size(199, 21)
        Me.ComboBoxAve.TabIndex = 128
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Red
        Me.Button1.Location = New System.Drawing.Point(574, 389)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(98, 41)
        Me.Button1.TabIndex = 130
        Me.Button1.Text = "FIGHT!"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'LabelGanador
        '
        Me.LabelGanador.AutoSize = True
        Me.LabelGanador.BackColor = System.Drawing.Color.Transparent
        Me.LabelGanador.Font = New System.Drawing.Font("Tahoma", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelGanador.ForeColor = System.Drawing.Color.DarkGreen
        Me.LabelGanador.Location = New System.Drawing.Point(475, 433)
        Me.LabelGanador.Name = "LabelGanador"
        Me.LabelGanador.Size = New System.Drawing.Size(90, 39)
        Me.LabelGanador.TabIndex = 131
        Me.LabelGanador.Text = "Gana"
        '
        'DataGridViewDuelos
        '
        Me.DataGridViewDuelos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewDuelos.Location = New System.Drawing.Point(148, 475)
        Me.DataGridViewDuelos.Name = "DataGridViewDuelos"
        Me.DataGridViewDuelos.Size = New System.Drawing.Size(938, 216)
        Me.DataGridViewDuelos.TabIndex = 132
        '
        'Duelo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.IndianRed
        Me.ClientSize = New System.Drawing.Size(1233, 702)
        Me.Controls.Add(Me.DataGridViewDuelos)
        Me.Controls.Add(Me.LabelGanador)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ComboBoxIdAve)
        Me.Controls.Add(Me.ComboBoxAve)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Paneli1)
        Me.Controls.Add(Me.Panela1)
        Me.Controls.Add(Me.Panelf1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PanelI2)
        Me.Controls.Add(Me.PanelA2)
        Me.Controls.Add(Me.Panelf2)
        Me.Controls.Add(Me.DateTimePickerFecha)
        Me.Controls.Add(Me.ComboBoxIdPer2)
        Me.Controls.Add(Me.ComboBoxPer2)
        Me.Controls.Add(Me.ComboBoxIdPer1)
        Me.Controls.Add(Me.ComboBoxPer1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.personaje2)
        Me.Controls.Add(Me.personaje1)
        Me.Name = "Duelo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Duelo"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.personaje2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.personaje1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridViewDuelos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents personaje1 As System.Windows.Forms.PictureBox
    Friend WithEvents personaje2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents ComboBoxPer1 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBoxIdPer1 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBoxIdPer2 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBoxPer2 As System.Windows.Forms.ComboBox
    Friend WithEvents DateTimePickerFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PanelI2 As System.Windows.Forms.Panel
    Friend WithEvents PanelA2 As System.Windows.Forms.Panel
    Friend WithEvents Panelf2 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Paneli1 As System.Windows.Forms.Panel
    Friend WithEvents Panela1 As System.Windows.Forms.Panel
    Friend WithEvents Panelf1 As System.Windows.Forms.Panel
    Friend WithEvents ComboBoxIdAve As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBoxAve As System.Windows.Forms.ComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents LabelGanador As System.Windows.Forms.Label
    Friend WithEvents DataGridViewDuelos As System.Windows.Forms.DataGridView
End Class
