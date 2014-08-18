<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AltaBitacora
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AltaBitacora))
        Me.Button3 = New System.Windows.Forms.Button
        Me.LabelTitulo = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.PanelLineaH = New System.Windows.Forms.Panel
        Me.PanelLineaV = New System.Windows.Forms.Panel
        Me.Label14 = New System.Windows.Forms.Label
        Me.ComboBoxAve = New System.Windows.Forms.ComboBox
        Me.ComboBoxMon = New System.Windows.Forms.ComboBox
        Me.ComboBoxPer = New System.Windows.Forms.ComboBox
        Me.ComboBoxIdAve = New System.Windows.Forms.ComboBox
        Me.ComboBoxIdPer = New System.Windows.Forms.ComboBox
        Me.ComboBoxIdMon = New System.Windows.Forms.ComboBox
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.RadioButtonFracaso = New System.Windows.Forms.RadioButton
        Me.RadioButtonNormal = New System.Windows.Forms.RadioButton
        Me.RadioButtonEpico = New System.Windows.Forms.RadioButton
        Me.PictureBoxMon = New System.Windows.Forms.PictureBox
        Me.PictureBoxPer = New System.Windows.Forms.PictureBox
        Me.PictureBoxAve = New System.Windows.Forms.PictureBox
        CType(Me.PictureBoxMon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxPer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxAve, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Button3.Location = New System.Drawing.Point(626, 253)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(145, 33)
        Me.Button3.TabIndex = 56
        Me.Button3.Text = "Adelante"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'LabelTitulo
        '
        Me.LabelTitulo.AutoSize = True
        Me.LabelTitulo.Font = New System.Drawing.Font("Tahoma", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTitulo.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.LabelTitulo.Location = New System.Drawing.Point(161, 32)
        Me.LabelTitulo.Name = "LabelTitulo"
        Me.LabelTitulo.Size = New System.Drawing.Size(357, 58)
        Me.LabelTitulo.TabIndex = 55
        Me.LabelTitulo.Text = "Alta de bitacora"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.Control
        Me.Label3.Location = New System.Drawing.Point(53, 147)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(103, 25)
        Me.Label3.TabIndex = 54
        Me.Label3.Text = "Personaje"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(60, 108)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 25)
        Me.Label1.TabIndex = 52
        Me.Label1.Text = "Aventura"
        '
        'PanelLineaH
        '
        Me.PanelLineaH.BackColor = System.Drawing.Color.LightGray
        Me.PanelLineaH.Location = New System.Drawing.Point(1, 90)
        Me.PanelLineaH.Name = "PanelLineaH"
        Me.PanelLineaH.Size = New System.Drawing.Size(810, 1)
        Me.PanelLineaH.TabIndex = 51
        '
        'PanelLineaV
        '
        Me.PanelLineaV.BackColor = System.Drawing.Color.LightGray
        Me.PanelLineaV.Location = New System.Drawing.Point(158, -247)
        Me.PanelLineaV.Name = "PanelLineaV"
        Me.PanelLineaV.Size = New System.Drawing.Size(1, 505)
        Me.PanelLineaV.TabIndex = 50
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.Control
        Me.Label14.Location = New System.Drawing.Point(58, 184)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(98, 25)
        Me.Label14.TabIndex = 75
        Me.Label14.Text = "Monstruo"
        '
        'ComboBoxAve
        '
        Me.ComboBoxAve.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxAve.FormattingEnabled = True
        Me.ComboBoxAve.Location = New System.Drawing.Point(237, 112)
        Me.ComboBoxAve.Name = "ComboBoxAve"
        Me.ComboBoxAve.Size = New System.Drawing.Size(243, 21)
        Me.ComboBoxAve.TabIndex = 79
        '
        'ComboBoxMon
        '
        Me.ComboBoxMon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxMon.FormattingEnabled = True
        Me.ComboBoxMon.Location = New System.Drawing.Point(237, 188)
        Me.ComboBoxMon.Name = "ComboBoxMon"
        Me.ComboBoxMon.Size = New System.Drawing.Size(243, 21)
        Me.ComboBoxMon.TabIndex = 80
        '
        'ComboBoxPer
        '
        Me.ComboBoxPer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxPer.FormattingEnabled = True
        Me.ComboBoxPer.Location = New System.Drawing.Point(237, 151)
        Me.ComboBoxPer.Name = "ComboBoxPer"
        Me.ComboBoxPer.Size = New System.Drawing.Size(243, 21)
        Me.ComboBoxPer.TabIndex = 81
        '
        'ComboBoxIdAve
        '
        Me.ComboBoxIdAve.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxIdAve.FormattingEnabled = True
        Me.ComboBoxIdAve.Location = New System.Drawing.Point(171, 112)
        Me.ComboBoxIdAve.Name = "ComboBoxIdAve"
        Me.ComboBoxIdAve.Size = New System.Drawing.Size(60, 21)
        Me.ComboBoxIdAve.TabIndex = 82
        '
        'ComboBoxIdPer
        '
        Me.ComboBoxIdPer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxIdPer.FormattingEnabled = True
        Me.ComboBoxIdPer.Location = New System.Drawing.Point(171, 151)
        Me.ComboBoxIdPer.Name = "ComboBoxIdPer"
        Me.ComboBoxIdPer.Size = New System.Drawing.Size(60, 21)
        Me.ComboBoxIdPer.TabIndex = 83
        '
        'ComboBoxIdMon
        '
        Me.ComboBoxIdMon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxIdMon.FormattingEnabled = True
        Me.ComboBoxIdMon.Location = New System.Drawing.Point(171, 188)
        Me.ComboBoxIdMon.Name = "ComboBoxIdMon"
        Me.ComboBoxIdMon.Size = New System.Drawing.Size(60, 21)
        Me.ComboBoxIdMon.TabIndex = 84
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "DD/MM/YYYY"
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(171, 227)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 85
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(93, 222)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 25)
        Me.Label2.TabIndex = 86
        Me.Label2.Text = "fecha"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.Control
        Me.Label4.Location = New System.Drawing.Point(93, 256)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 25)
        Me.Label4.TabIndex = 87
        Me.Label4.Text = "Modo"
        '
        'RadioButtonFracaso
        '
        Me.RadioButtonFracaso.AutoSize = True
        Me.RadioButtonFracaso.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButtonFracaso.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.RadioButtonFracaso.Location = New System.Drawing.Point(171, 254)
        Me.RadioButtonFracaso.Name = "RadioButtonFracaso"
        Me.RadioButtonFracaso.Size = New System.Drawing.Size(92, 27)
        Me.RadioButtonFracaso.TabIndex = 88
        Me.RadioButtonFracaso.TabStop = True
        Me.RadioButtonFracaso.Tag = "Fracaso"
        Me.RadioButtonFracaso.Text = "Fracaso"
        Me.RadioButtonFracaso.UseVisualStyleBackColor = True
        '
        'RadioButtonNormal
        '
        Me.RadioButtonNormal.AutoSize = True
        Me.RadioButtonNormal.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButtonNormal.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.RadioButtonNormal.Location = New System.Drawing.Point(269, 256)
        Me.RadioButtonNormal.Name = "RadioButtonNormal"
        Me.RadioButtonNormal.Size = New System.Drawing.Size(88, 27)
        Me.RadioButtonNormal.TabIndex = 89
        Me.RadioButtonNormal.TabStop = True
        Me.RadioButtonNormal.Tag = "Normal"
        Me.RadioButtonNormal.Text = "Normal"
        Me.RadioButtonNormal.UseVisualStyleBackColor = True
        '
        'RadioButtonEpico
        '
        Me.RadioButtonEpico.AutoSize = True
        Me.RadioButtonEpico.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButtonEpico.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.RadioButtonEpico.Location = New System.Drawing.Point(363, 256)
        Me.RadioButtonEpico.Name = "RadioButtonEpico"
        Me.RadioButtonEpico.Size = New System.Drawing.Size(73, 27)
        Me.RadioButtonEpico.TabIndex = 90
        Me.RadioButtonEpico.TabStop = True
        Me.RadioButtonEpico.Tag = "Epico"
        Me.RadioButtonEpico.Text = "Epico"
        Me.RadioButtonEpico.UseVisualStyleBackColor = True
        '
        'PictureBoxMon
        '
        Me.PictureBoxMon.BackgroundImage = CType(resources.GetObject("PictureBoxMon.BackgroundImage"), System.Drawing.Image)
        Me.PictureBoxMon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBoxMon.Location = New System.Drawing.Point(583, 302)
        Me.PictureBoxMon.Name = "PictureBoxMon"
        Me.PictureBoxMon.Size = New System.Drawing.Size(200, 200)
        Me.PictureBoxMon.TabIndex = 78
        Me.PictureBoxMon.TabStop = False
        '
        'PictureBoxPer
        '
        Me.PictureBoxPer.BackgroundImage = CType(resources.GetObject("PictureBoxPer.BackgroundImage"), System.Drawing.Image)
        Me.PictureBoxPer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBoxPer.Location = New System.Drawing.Point(377, 302)
        Me.PictureBoxPer.Name = "PictureBoxPer"
        Me.PictureBoxPer.Size = New System.Drawing.Size(200, 200)
        Me.PictureBoxPer.TabIndex = 77
        Me.PictureBoxPer.TabStop = False
        '
        'PictureBoxAve
        '
        Me.PictureBoxAve.BackgroundImage = CType(resources.GetObject("PictureBoxAve.BackgroundImage"), System.Drawing.Image)
        Me.PictureBoxAve.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBoxAve.Location = New System.Drawing.Point(171, 302)
        Me.PictureBoxAve.Name = "PictureBoxAve"
        Me.PictureBoxAve.Size = New System.Drawing.Size(200, 200)
        Me.PictureBoxAve.TabIndex = 76
        Me.PictureBoxAve.TabStop = False
        '
        'AltaBitacora
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(808, 514)
        Me.Controls.Add(Me.RadioButtonEpico)
        Me.Controls.Add(Me.RadioButtonNormal)
        Me.Controls.Add(Me.RadioButtonFracaso)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.ComboBoxIdMon)
        Me.Controls.Add(Me.ComboBoxIdPer)
        Me.Controls.Add(Me.ComboBoxIdAve)
        Me.Controls.Add(Me.ComboBoxPer)
        Me.Controls.Add(Me.ComboBoxMon)
        Me.Controls.Add(Me.ComboBoxAve)
        Me.Controls.Add(Me.PictureBoxMon)
        Me.Controls.Add(Me.PictureBoxPer)
        Me.Controls.Add(Me.PictureBoxAve)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.LabelTitulo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PanelLineaH)
        Me.Controls.Add(Me.PanelLineaV)
        Me.Controls.Add(Me.Button3)
        Me.Name = "AltaBitacora"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AltaBitacora"
        CType(Me.PictureBoxMon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxPer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxAve, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents LabelTitulo As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PanelLineaH As System.Windows.Forms.Panel
    Friend WithEvents PanelLineaV As System.Windows.Forms.Panel
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents PictureBoxAve As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBoxPer As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBoxMon As System.Windows.Forms.PictureBox
    Friend WithEvents ComboBoxAve As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBoxMon As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBoxPer As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBoxIdAve As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBoxIdPer As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBoxIdMon As System.Windows.Forms.ComboBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents RadioButtonFracaso As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonNormal As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonEpico As System.Windows.Forms.RadioButton
End Class
