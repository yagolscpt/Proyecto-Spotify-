<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class peliculas
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
        Me.btnagregarpeliculas = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtcodigo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txttitulo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtautor = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtgenero = New System.Windows.Forms.TextBox()
        Me.txtactores = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtaño = New System.Windows.Forms.TextBox()
        Me.txtvaloracion = New System.Windows.Forms.TextBox()
        Me.valoración = New System.Windows.Forms.Label()
        Me.btnguardarpeliculas = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnagregarpeliculas
        '
        Me.btnagregarpeliculas.Location = New System.Drawing.Point(286, 134)
        Me.btnagregarpeliculas.Name = "btnagregarpeliculas"
        Me.btnagregarpeliculas.Size = New System.Drawing.Size(75, 23)
        Me.btnagregarpeliculas.TabIndex = 0
        Me.btnagregarpeliculas.Text = "Agregar peliculas"
        Me.btnagregarpeliculas.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(42, 81)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Codigo"
        Me.Label1.Visible = False
        '
        'txtcodigo
        '
        Me.txtcodigo.Location = New System.Drawing.Point(45, 97)
        Me.txtcodigo.Name = "txtcodigo"
        Me.txtcodigo.Size = New System.Drawing.Size(100, 20)
        Me.txtcodigo.TabIndex = 2
        Me.txtcodigo.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(42, 120)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Titulo"
        Me.Label2.Visible = False
        '
        'txttitulo
        '
        Me.txttitulo.Location = New System.Drawing.Point(45, 136)
        Me.txttitulo.Name = "txttitulo"
        Me.txttitulo.Size = New System.Drawing.Size(100, 20)
        Me.txttitulo.TabIndex = 4
        Me.txttitulo.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(49, 159)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Autor"
        Me.Label3.Visible = False
        '
        'txtautor
        '
        Me.txtautor.Location = New System.Drawing.Point(45, 175)
        Me.txtautor.Name = "txtautor"
        Me.txtautor.Size = New System.Drawing.Size(100, 20)
        Me.txtautor.TabIndex = 6
        Me.txtautor.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(50, 198)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Género"
        Me.Label4.Visible = False
        '
        'txtgenero
        '
        Me.txtgenero.Location = New System.Drawing.Point(45, 214)
        Me.txtgenero.Name = "txtgenero"
        Me.txtgenero.Size = New System.Drawing.Size(100, 20)
        Me.txtgenero.TabIndex = 8
        Me.txtgenero.Visible = False
        '
        'txtactores
        '
        Me.txtactores.Location = New System.Drawing.Point(45, 255)
        Me.txtactores.Name = "txtactores"
        Me.txtactores.Size = New System.Drawing.Size(100, 20)
        Me.txtactores.TabIndex = 9
        Me.txtactores.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(50, 239)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Actores"
        Me.Label5.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(50, 278)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(26, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Año"
        Me.Label6.Visible = False
        '
        'txtaño
        '
        Me.txtaño.Location = New System.Drawing.Point(45, 294)
        Me.txtaño.Name = "txtaño"
        Me.txtaño.Size = New System.Drawing.Size(100, 20)
        Me.txtaño.TabIndex = 12
        Me.txtaño.Visible = False
        '
        'txtvaloracion
        '
        Me.txtvaloracion.Location = New System.Drawing.Point(45, 337)
        Me.txtvaloracion.Name = "txtvaloracion"
        Me.txtvaloracion.Size = New System.Drawing.Size(100, 20)
        Me.txtvaloracion.TabIndex = 13
        Me.txtvaloracion.Visible = False
        '
        'valoración
        '
        Me.valoración.AutoSize = True
        Me.valoración.Location = New System.Drawing.Point(49, 321)
        Me.valoración.Name = "valoración"
        Me.valoración.Size = New System.Drawing.Size(57, 13)
        Me.valoración.TabIndex = 14
        Me.valoración.Text = "Valoración"
        Me.valoración.Visible = False
        '
        'btnguardarpeliculas
        '
        Me.btnguardarpeliculas.Location = New System.Drawing.Point(45, 363)
        Me.btnguardarpeliculas.Name = "btnguardarpeliculas"
        Me.btnguardarpeliculas.Size = New System.Drawing.Size(75, 23)
        Me.btnguardarpeliculas.TabIndex = 15
        Me.btnguardarpeliculas.Text = "Guardar película"
        Me.btnguardarpeliculas.UseVisualStyleBackColor = True
        Me.btnguardarpeliculas.Visible = False
        '
        'peliculas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnguardarpeliculas)
        Me.Controls.Add(Me.valoración)
        Me.Controls.Add(Me.txtvaloracion)
        Me.Controls.Add(Me.txtaño)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtactores)
        Me.Controls.Add(Me.txtgenero)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtautor)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txttitulo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtcodigo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnagregarpeliculas)
        Me.Name = "peliculas"
        Me.Text = "peliculas"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnagregarpeliculas As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtcodigo As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txttitulo As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtautor As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtgenero As TextBox
    Friend WithEvents txtactores As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtaño As TextBox
    Friend WithEvents txtvaloracion As TextBox
    Friend WithEvents valoración As Label
    Friend WithEvents btnguardarpeliculas As Button
End Class
