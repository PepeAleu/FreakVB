<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AltaAventura
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.ComboBoxEscenarioAlta = New System.Windows.Forms.ComboBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.TextBoxNombreAventuraAlta = New System.Windows.Forms.TextBox
        Me.PanelLineaV = New System.Windows.Forms.Panel
        Me.PanelLineaH = New System.Windows.Forms.Panel
        Me.Label8 = New System.Windows.Forms.Label
        Me.LabelTitulo = New System.Windows.Forms.Label
        Me.Button3 = New System.Windows.Forms.Button
        Me.TextBoxDescripcionAlta = New System.Windows.Forms.TextBox
        Me.ComboBoxIdAlta = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(9, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(243, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Escenario de la aventura"
        '
        'ComboBoxEscenarioAlta
        '
        Me.ComboBoxEscenarioAlta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxEscenarioAlta.FormattingEnabled = True
        Me.ComboBoxEscenarioAlta.Location = New System.Drawing.Point(323, 64)
        Me.ComboBoxEscenarioAlta.Name = "ComboBoxEscenarioAlta"
        Me.ComboBoxEscenarioAlta.Size = New System.Drawing.Size(288, 21)
        Me.ComboBoxEscenarioAlta.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.Control
        Me.Label7.Location = New System.Drawing.Point(166, 95)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(86, 25)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Nombre"
        '
        'TextBoxNombreAventuraAlta
        '
        Me.TextBoxNombreAventuraAlta.Location = New System.Drawing.Point(264, 100)
        Me.TextBoxNombreAventuraAlta.Name = "TextBoxNombreAventuraAlta"
        Me.TextBoxNombreAventuraAlta.Size = New System.Drawing.Size(347, 20)
        Me.TextBoxNombreAventuraAlta.TabIndex = 5
        '
        'PanelLineaV
        '
        Me.PanelLineaV.BackColor = System.Drawing.SystemColors.Control
        Me.PanelLineaV.Location = New System.Drawing.Point(254, -12)
        Me.PanelLineaV.Name = "PanelLineaV"
        Me.PanelLineaV.Size = New System.Drawing.Size(1, 505)
        Me.PanelLineaV.TabIndex = 6
        '
        'PanelLineaH
        '
        Me.PanelLineaH.BackColor = System.Drawing.SystemColors.Control
        Me.PanelLineaH.Location = New System.Drawing.Point(-3, 49)
        Me.PanelLineaH.Name = "PanelLineaH"
        Me.PanelLineaH.Size = New System.Drawing.Size(810, 1)
        Me.PanelLineaH.TabIndex = 7
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.Control
        Me.Label8.Location = New System.Drawing.Point(133, 127)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(119, 25)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Descripción"
        '
        'LabelTitulo
        '
        Me.LabelTitulo.AutoSize = True
        Me.LabelTitulo.Font = New System.Drawing.Font("Tahoma", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTitulo.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.LabelTitulo.Location = New System.Drawing.Point(257, 4)
        Me.LabelTitulo.Name = "LabelTitulo"
        Me.LabelTitulo.Size = New System.Drawing.Size(272, 42)
        Me.LabelTitulo.TabIndex = 10
        Me.LabelTitulo.Text = "Alta de aventura"
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Button3.Location = New System.Drawing.Point(628, 185)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(145, 33)
        Me.Button3.TabIndex = 11
        Me.Button3.Text = "Adelante"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'TextBoxDescripcionAlta
        '
        Me.TextBoxDescripcionAlta.Location = New System.Drawing.Point(264, 132)
        Me.TextBoxDescripcionAlta.Name = "TextBoxDescripcionAlta"
        Me.TextBoxDescripcionAlta.Size = New System.Drawing.Size(347, 20)
        Me.TextBoxDescripcionAlta.TabIndex = 9
        '
        'ComboBoxIdAlta
        '
        Me.ComboBoxIdAlta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxIdAlta.FormattingEnabled = True
        Me.ComboBoxIdAlta.Location = New System.Drawing.Point(264, 64)
        Me.ComboBoxIdAlta.Name = "ComboBoxIdAlta"
        Me.ComboBoxIdAlta.Size = New System.Drawing.Size(57, 21)
        Me.ComboBoxIdAlta.TabIndex = 25
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(422, 235)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 13)
        Me.Label2.TabIndex = 57
        Me.Label2.Text = "son obligatorios"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(259, 235)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(146, 13)
        Me.Label6.TabIndex = 56
        Me.Label6.Text = "Los campos con este simbolo"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.IndianRed
        Me.Label5.Location = New System.Drawing.Point(398, 229)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(32, 33)
        Me.Label5.TabIndex = 55
        Me.Label5.Text = "*"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.IndianRed
        Me.Label3.Location = New System.Drawing.Point(617, 60)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 33)
        Me.Label3.TabIndex = 58
        Me.Label3.Text = "*"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.IndianRed
        Me.Label4.Location = New System.Drawing.Point(617, 96)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 33)
        Me.Label4.TabIndex = 59
        Me.Label4.Text = "*"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.IndianRed
        Me.Label10.Location = New System.Drawing.Point(617, 127)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(32, 33)
        Me.Label10.TabIndex = 60
        Me.Label10.Text = "*"
        '
        'AltaAventura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(785, 252)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.ComboBoxIdAlta)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.LabelTitulo)
        Me.Controls.Add(Me.TextBoxDescripcionAlta)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.PanelLineaH)
        Me.Controls.Add(Me.PanelLineaV)
        Me.Controls.Add(Me.TextBoxNombreAventuraAlta)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.ComboBoxEscenarioAlta)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.Color.Black
        Me.Name = "AltaAventura"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ComboBoxEscenarioAlta As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TextBoxNombreAventuraAlta As System.Windows.Forms.TextBox
    Friend WithEvents PanelLineaV As System.Windows.Forms.Panel
    Friend WithEvents PanelLineaH As System.Windows.Forms.Panel
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents LabelTitulo As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents TextBoxDescripcionAlta As System.Windows.Forms.TextBox
    Friend WithEvents ComboBoxIdAlta As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label

End Class
