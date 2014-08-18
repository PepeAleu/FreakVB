<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AltaUniverso
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
        Me.Button3 = New System.Windows.Forms.Button
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.PanelLineaH = New System.Windows.Forms.Panel
        Me.PanelLineaV = New System.Windows.Forms.Panel
        Me.TextBoxNombre = New System.Windows.Forms.TextBox
        Me.ComboBoxTipo = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Button3.Location = New System.Drawing.Point(325, 143)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(145, 33)
        Me.Button3.TabIndex = 48
        Me.Button3.Text = "Adelante"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label10.Location = New System.Drawing.Point(102, -2)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(370, 58)
        Me.Label10.TabIndex = 46
        Me.Label10.Text = "Alta de Universo"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.Control
        Me.Label3.Location = New System.Drawing.Point(43, 96)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 25)
        Me.Label3.TabIndex = 34
        Me.Label3.Text = "Tipo"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(13, 71)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 25)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "Nombre"
        '
        'PanelLineaH
        '
        Me.PanelLineaH.BackColor = System.Drawing.Color.LightGray
        Me.PanelLineaH.Location = New System.Drawing.Point(-54, 56)
        Me.PanelLineaH.Name = "PanelLineaH"
        Me.PanelLineaH.Size = New System.Drawing.Size(810, 1)
        Me.PanelLineaH.TabIndex = 30
        '
        'PanelLineaV
        '
        Me.PanelLineaV.BackColor = System.Drawing.Color.LightGray
        Me.PanelLineaV.Location = New System.Drawing.Point(101, -8)
        Me.PanelLineaV.Name = "PanelLineaV"
        Me.PanelLineaV.Size = New System.Drawing.Size(1, 505)
        Me.PanelLineaV.TabIndex = 29
        '
        'TextBoxNombre
        '
        Me.TextBoxNombre.Location = New System.Drawing.Point(110, 76)
        Me.TextBoxNombre.Name = "TextBoxNombre"
        Me.TextBoxNombre.Size = New System.Drawing.Size(237, 20)
        Me.TextBoxNombre.TabIndex = 32
        '
        'ComboBoxTipo
        '
        Me.ComboBoxTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxTipo.FormattingEnabled = True
        Me.ComboBoxTipo.Location = New System.Drawing.Point(110, 103)
        Me.ComboBoxTipo.Name = "ComboBoxTipo"
        Me.ComboBoxTipo.Size = New System.Drawing.Size(237, 21)
        Me.ComboBoxTipo.TabIndex = 49
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.IndianRed
        Me.Label2.Location = New System.Drawing.Point(353, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 33)
        Me.Label2.TabIndex = 50
        Me.Label2.Text = "*"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.IndianRed
        Me.Label4.Location = New System.Drawing.Point(353, 103)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 33)
        Me.Label4.TabIndex = 51
        Me.Label4.Text = "*"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.IndianRed
        Me.Label5.Location = New System.Drawing.Point(248, 187)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(32, 33)
        Me.Label5.TabIndex = 52
        Me.Label5.Text = "*"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(109, 193)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(146, 13)
        Me.Label6.TabIndex = 53
        Me.Label6.Text = "Los campos con este simbolo"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(272, 193)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 13)
        Me.Label7.TabIndex = 54
        Me.Label7.Text = "son obligatorios"
        '
        'AltaUniverso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(601, 215)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ComboBoxTipo)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBoxNombre)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PanelLineaH)
        Me.Controls.Add(Me.PanelLineaV)
        Me.Name = "AltaUniverso"
        Me.Text = "AltaUniverso"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PanelLineaH As System.Windows.Forms.Panel
    Friend WithEvents PanelLineaV As System.Windows.Forms.Panel
    Friend WithEvents TextBoxNombre As System.Windows.Forms.TextBox
    Friend WithEvents ComboBoxTipo As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
End Class
