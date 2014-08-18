<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DetallesPersonaje
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DetallesPersonaje))
        Me.personaje = New System.Windows.Forms.PictureBox
        Me.nombre = New System.Windows.Forms.Label
        Me.LabelTitulo = New System.Windows.Forms.Label
        Me.PanelInteligencia = New System.Windows.Forms.Panel
        Me.PanelAgilidad = New System.Windows.Forms.Panel
        Me.PanelFuerza = New System.Windows.Forms.Panel
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.LabelNombre = New System.Windows.Forms.Label
        Me.LabelAlias = New System.Windows.Forms.Label
        Me.LabelApe = New System.Windows.Forms.Label
        Me.LabelRaza = New System.Windows.Forms.Label
        Me.PictureBoxAli = New System.Windows.Forms.PictureBox
        Me.LabelAli = New System.Windows.Forms.Label
        Me.LabelClase = New System.Windows.Forms.Label
        Me.PictureBoxsexo = New System.Windows.Forms.PictureBox
        Me.Labelfecnac = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.PictureBoxUni = New System.Windows.Forms.PictureBox
        CType(Me.personaje, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxAli, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxsexo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxUni, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'personaje
        '
        Me.personaje.Location = New System.Drawing.Point(12, 85)
        Me.personaje.Name = "personaje"
        Me.personaje.Size = New System.Drawing.Size(300, 300)
        Me.personaje.TabIndex = 67
        Me.personaje.TabStop = False
        '
        'nombre
        '
        Me.nombre.AutoSize = True
        Me.nombre.Font = New System.Drawing.Font("Tahoma", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nombre.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.nombre.Location = New System.Drawing.Point(461, -4)
        Me.nombre.Name = "nombre"
        Me.nombre.Size = New System.Drawing.Size(211, 58)
        Me.nombre.TabIndex = 66
        Me.nombre.Text = "aventura"
        '
        'LabelTitulo
        '
        Me.LabelTitulo.AutoSize = True
        Me.LabelTitulo.Font = New System.Drawing.Font("Tahoma", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTitulo.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.LabelTitulo.Location = New System.Drawing.Point(-5, -4)
        Me.LabelTitulo.Name = "LabelTitulo"
        Me.LabelTitulo.Size = New System.Drawing.Size(471, 58)
        Me.LabelTitulo.TabIndex = 65
        Me.LabelTitulo.Text = "Detalle del personaje"
        '
        'PanelInteligencia
        '
        Me.PanelInteligencia.Location = New System.Drawing.Point(439, 387)
        Me.PanelInteligencia.Name = "PanelInteligencia"
        Me.PanelInteligencia.Size = New System.Drawing.Size(151, 26)
        Me.PanelInteligencia.TabIndex = 111
        '
        'PanelAgilidad
        '
        Me.PanelAgilidad.Location = New System.Drawing.Point(439, 362)
        Me.PanelAgilidad.Name = "PanelAgilidad"
        Me.PanelAgilidad.Size = New System.Drawing.Size(151, 26)
        Me.PanelAgilidad.TabIndex = 112
        '
        'PanelFuerza
        '
        Me.PanelFuerza.Location = New System.Drawing.Point(436, 339)
        Me.PanelFuerza.Name = "PanelFuerza"
        Me.PanelFuerza.Size = New System.Drawing.Size(151, 26)
        Me.PanelFuerza.TabIndex = 110
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(360, 356)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(87, 25)
        Me.Label9.TabIndex = 115
        Me.Label9.Text = "Agilidad"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(326, 381)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(121, 25)
        Me.Label5.TabIndex = 114
        Me.Label5.Text = "Inteligencia"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(373, 331)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 25)
        Me.Label2.TabIndex = 113
        Me.Label2.Text = "Fuerza"
        '
        'LabelNombre
        '
        Me.LabelNombre.AutoSize = True
        Me.LabelNombre.BackColor = System.Drawing.Color.Transparent
        Me.LabelNombre.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelNombre.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.LabelNombre.Location = New System.Drawing.Point(480, 85)
        Me.LabelNombre.Name = "LabelNombre"
        Me.LabelNombre.Size = New System.Drawing.Size(87, 25)
        Me.LabelNombre.TabIndex = 116
        Me.LabelNombre.Text = "Agilidad"
        '
        'LabelAlias
        '
        Me.LabelAlias.AutoSize = True
        Me.LabelAlias.BackColor = System.Drawing.Color.Transparent
        Me.LabelAlias.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelAlias.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.LabelAlias.Location = New System.Drawing.Point(480, 110)
        Me.LabelAlias.Name = "LabelAlias"
        Me.LabelAlias.Size = New System.Drawing.Size(87, 25)
        Me.LabelAlias.TabIndex = 117
        Me.LabelAlias.Text = "Agilidad"
        '
        'LabelApe
        '
        Me.LabelApe.AutoSize = True
        Me.LabelApe.BackColor = System.Drawing.Color.Transparent
        Me.LabelApe.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelApe.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.LabelApe.Location = New System.Drawing.Point(480, 135)
        Me.LabelApe.Name = "LabelApe"
        Me.LabelApe.Size = New System.Drawing.Size(87, 25)
        Me.LabelApe.TabIndex = 118
        Me.LabelApe.Text = "Agilidad"
        '
        'LabelRaza
        '
        Me.LabelRaza.AutoSize = True
        Me.LabelRaza.BackColor = System.Drawing.Color.Transparent
        Me.LabelRaza.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelRaza.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.LabelRaza.Location = New System.Drawing.Point(480, 160)
        Me.LabelRaza.Name = "LabelRaza"
        Me.LabelRaza.Size = New System.Drawing.Size(87, 25)
        Me.LabelRaza.TabIndex = 119
        Me.LabelRaza.Text = "Agilidad"
        '
        'PictureBoxAli
        '
        Me.PictureBoxAli.Location = New System.Drawing.Point(485, 188)
        Me.PictureBoxAli.Name = "PictureBoxAli"
        Me.PictureBoxAli.Size = New System.Drawing.Size(50, 50)
        Me.PictureBoxAli.TabIndex = 120
        Me.PictureBoxAli.TabStop = False
        '
        'LabelAli
        '
        Me.LabelAli.AutoSize = True
        Me.LabelAli.BackColor = System.Drawing.Color.Transparent
        Me.LabelAli.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelAli.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.LabelAli.Location = New System.Drawing.Point(541, 200)
        Me.LabelAli.Name = "LabelAli"
        Me.LabelAli.Size = New System.Drawing.Size(87, 25)
        Me.LabelAli.TabIndex = 121
        Me.LabelAli.Text = "Agilidad"
        '
        'LabelClase
        '
        Me.LabelClase.AutoSize = True
        Me.LabelClase.BackColor = System.Drawing.Color.Transparent
        Me.LabelClase.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelClase.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.LabelClase.Location = New System.Drawing.Point(480, 241)
        Me.LabelClase.Name = "LabelClase"
        Me.LabelClase.Size = New System.Drawing.Size(87, 25)
        Me.LabelClase.TabIndex = 122
        Me.LabelClase.Text = "Agilidad"
        '
        'PictureBoxsexo
        '
        Me.PictureBoxsexo.Image = CType(resources.GetObject("PictureBoxsexo.Image"), System.Drawing.Image)
        Me.PictureBoxsexo.Location = New System.Drawing.Point(485, 273)
        Me.PictureBoxsexo.Name = "PictureBoxsexo"
        Me.PictureBoxsexo.Size = New System.Drawing.Size(14, 19)
        Me.PictureBoxsexo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBoxsexo.TabIndex = 123
        Me.PictureBoxsexo.TabStop = False
        '
        'Labelfecnac
        '
        Me.Labelfecnac.AutoSize = True
        Me.Labelfecnac.BackColor = System.Drawing.Color.Transparent
        Me.Labelfecnac.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labelfecnac.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Labelfecnac.Location = New System.Drawing.Point(480, 297)
        Me.Labelfecnac.Name = "Labelfecnac"
        Me.Labelfecnac.Size = New System.Drawing.Size(87, 25)
        Me.Labelfecnac.TabIndex = 124
        Me.Labelfecnac.Text = "Agilidad"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(326, 85)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 25)
        Me.Label1.TabIndex = 125
        Me.Label1.Text = "Nombre"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(326, 110)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 25)
        Me.Label3.TabIndex = 126
        Me.Label3.Text = "Alias"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(326, 135)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 25)
        Me.Label4.TabIndex = 127
        Me.Label4.Text = "Apellidos"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(326, 160)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 25)
        Me.Label6.TabIndex = 128
        Me.Label6.Text = "Raza"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(326, 200)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(133, 25)
        Me.Label7.TabIndex = 129
        Me.Label7.Text = "Alineamiento"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(326, 242)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(61, 25)
        Me.Label8.TabIndex = 130
        Me.Label8.Text = "Clase"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(326, 270)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(56, 25)
        Me.Label10.TabIndex = 131
        Me.Label10.Text = "Sexo"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(326, 297)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(143, 25)
        Me.Label11.TabIndex = 132
        Me.Label11.Text = "Fecha de nac."
        '
        'PictureBoxUni
        '
        Me.PictureBoxUni.Location = New System.Drawing.Point(677, 85)
        Me.PictureBoxUni.Name = "PictureBoxUni"
        Me.PictureBoxUni.Size = New System.Drawing.Size(300, 300)
        Me.PictureBoxUni.TabIndex = 133
        Me.PictureBoxUni.TabStop = False
        '
        'DetallesPersonaje
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1002, 531)
        Me.Controls.Add(Me.PictureBoxUni)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Labelfecnac)
        Me.Controls.Add(Me.PictureBoxsexo)
        Me.Controls.Add(Me.LabelClase)
        Me.Controls.Add(Me.LabelAli)
        Me.Controls.Add(Me.PictureBoxAli)
        Me.Controls.Add(Me.LabelRaza)
        Me.Controls.Add(Me.LabelApe)
        Me.Controls.Add(Me.LabelAlias)
        Me.Controls.Add(Me.LabelNombre)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PanelInteligencia)
        Me.Controls.Add(Me.PanelAgilidad)
        Me.Controls.Add(Me.PanelFuerza)
        Me.Controls.Add(Me.personaje)
        Me.Controls.Add(Me.nombre)
        Me.Controls.Add(Me.LabelTitulo)
        Me.Name = "DetallesPersonaje"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DetallesPersonaje"
        CType(Me.personaje, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxAli, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxsexo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxUni, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents personaje As System.Windows.Forms.PictureBox
    Friend WithEvents nombre As System.Windows.Forms.Label
    Friend WithEvents LabelTitulo As System.Windows.Forms.Label
    Friend WithEvents PanelInteligencia As System.Windows.Forms.Panel
    Friend WithEvents PanelAgilidad As System.Windows.Forms.Panel
    Friend WithEvents PanelFuerza As System.Windows.Forms.Panel
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents LabelNombre As System.Windows.Forms.Label
    Friend WithEvents LabelAlias As System.Windows.Forms.Label
    Friend WithEvents LabelApe As System.Windows.Forms.Label
    Friend WithEvents LabelRaza As System.Windows.Forms.Label
    Friend WithEvents PictureBoxAli As System.Windows.Forms.PictureBox
    Friend WithEvents LabelAli As System.Windows.Forms.Label
    Friend WithEvents LabelClase As System.Windows.Forms.Label
    Friend WithEvents PictureBoxsexo As System.Windows.Forms.PictureBox
    Friend WithEvents Labelfecnac As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents PictureBoxUni As System.Windows.Forms.PictureBox
End Class
