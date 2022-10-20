Option Strict On
Imports System.IO
Public Class Form1

    Dim registros(99) As String
    Dim ruta As String = Directory.GetCurrentDirectory() + "\usuarios.txt"
    Public Sub VolcarFicheroAMatriz(ByRef ruta As String)

        Dim lector As StreamReader = My.Computer.FileSystem.OpenTextFileReader(Directory.GetCurrentDirectory() + "\usuarios.txt")
        Dim i As Integer = 0
        While Not lector.EndOfStream
            registros(i) = lector.ReadLine()
            i += 1
        End While
        lector.Close()

    End Sub

    Sub Escribir(ByRef ruta As String, ByRef registro As String)

        Dim escritor As StreamWriter = My.Computer.FileSystem.OpenTextFileWriter(ruta, True)
        escritor.WriteLine(registro)
        escritor.Close()
    End Sub
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub btnloguearse_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        txtcontraseña.PasswordChar = Nothing
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        txtcontraseña.PasswordChar = ("*"c)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim id As String = txtidusuario.Text
        Dim contraseña As String = txtcontraseña.Text
        Dim correo As String = txtcorreo.Text
        Dim fechadenacimiento As String = DateTimePicker1.Text
        Escribir(ruta, id & "*" & contraseña & "?" & correo & ";" & fechadenacimiento)

    End Sub

    Private Sub btnregistrarse_Click(sender As Object, e As EventArgs) Handles btnregistrarse.Click
        Label3.Visible = True
        Label4.Visible = True
        txtcorreo.Visible = True
        DateTimePicker1.Visible = True
        Button3.Visible = True
    End Sub


    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        VolcarFicheroAMatriz(ruta)

        Dim entrar As Boolean = True





        For i As Integer = 0 To registros.Length - 1 Step 1

            If registros(i) = Nothing Then
                entrar = False
            End If



            If entrar = True Then

                Dim posicionas As Integer = registros(i).IndexOf("*")
                If registros(i).Substring(0, posicionas - 0) = txtidusuario.Text Then
                    Dim posicionint As Integer = registros(i).IndexOf("?")

                    If registros(i).Substring(posicionas + 1, posicionint - posicionas - 1) = txtcontraseña.Text Then
                        MessageBox.Show("Acceso permitido")
                        Form3.Show()
                        Me.Visible = False

                        Exit For
                    End If

                End If
            End If
        Next

    End Sub

    Private Sub Form1_KeyPress(sender As Object, e As KeyPressEventArgs)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtidusuario_TextChanged(sender As Object, e As EventArgs) Handles txtidusuario.TextChanged

    End Sub
End Class
