﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class libros
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtcodigo = New System.Windows.Forms.TextBox()
        Me.txttitulo = New System.Windows.Forms.TextBox()
        Me.txtautor = New System.Windows.Forms.TextBox()
        Me.txtgenero = New System.Windows.Forms.TextBox()
        Me.txtaño = New System.Windows.Forms.TextBox()
        Me.txtvaloracion = New System.Windows.Forms.TextBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(52, 339)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "guardar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(49, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "codigo "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(51, 107)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "titulo"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(49, 149)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "autor "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(49, 195)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "genero"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(49, 241)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(25, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "año"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(49, 284)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "valoracion "
        '
        'txtcodigo
        '
        Me.txtcodigo.Location = New System.Drawing.Point(52, 85)
        Me.txtcodigo.Name = "txtcodigo"
        Me.txtcodigo.Size = New System.Drawing.Size(100, 20)
        Me.txtcodigo.TabIndex = 7
        '
        'txttitulo
        '
        Me.txttitulo.Location = New System.Drawing.Point(52, 126)
        Me.txttitulo.Name = "txttitulo"
        Me.txttitulo.Size = New System.Drawing.Size(100, 20)
        Me.txttitulo.TabIndex = 8
        '
        'txtautor
        '
        Me.txtautor.Location = New System.Drawing.Point(52, 172)
        Me.txtautor.Name = "txtautor"
        Me.txtautor.Size = New System.Drawing.Size(100, 20)
        Me.txtautor.TabIndex = 9
        '
        'txtgenero
        '
        Me.txtgenero.Location = New System.Drawing.Point(52, 211)
        Me.txtgenero.Name = "txtgenero"
        Me.txtgenero.Size = New System.Drawing.Size(100, 20)
        Me.txtgenero.TabIndex = 10
        '
        'txtaño
        '
        Me.txtaño.Location = New System.Drawing.Point(52, 261)
        Me.txtaño.Name = "txtaño"
        Me.txtaño.Size = New System.Drawing.Size(100, 20)
        Me.txtaño.TabIndex = 11
        '
        'txtvaloracion
        '
        Me.txtvaloracion.Location = New System.Drawing.Point(52, 313)
        Me.txtvaloracion.Name = "txtvaloracion"
        Me.txtvaloracion.Size = New System.Drawing.Size(100, 20)
        Me.txtvaloracion.TabIndex = 12
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(158, 68)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(630, 303)
        Me.ListBox1.TabIndex = 13
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(390, 39)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 14
        Me.Button2.Text = "mostrar libros"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'libros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.txtvaloracion)
        Me.Controls.Add(Me.txtaño)
        Me.Controls.Add(Me.txtgenero)
        Me.Controls.Add(Me.txtautor)
        Me.Controls.Add(Me.txttitulo)
        Me.Controls.Add(Me.txtcodigo)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "libros"
        Me.Text = "genero"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtcodigo As TextBox
    Friend WithEvents txttitulo As TextBox
    Friend WithEvents txtautor As TextBox
    Friend WithEvents txtgenero As TextBox
    Friend WithEvents txtaño As TextBox
    Friend WithEvents txtvaloracion As TextBox
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Button2 As Button
End Class
