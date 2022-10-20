
Option Strict On
Imports System.IO
Public Class musica
    Dim musica(9900) As String
    Dim ruta As String = Directory.GetCurrentDirectory() + "\musica.txt"
    Sub Escribir(ByRef ruta As String, ByRef registro As String)

        Dim escritor As StreamWriter = My.Computer.FileSystem.OpenTextFileWriter(ruta, True)
        escritor.WriteLine(registro)
        escritor.Close()
    End Sub
    Public Sub VolcarFicheroAMatriz(ByRef ruta As String)

        Dim lector As StreamReader = My.Computer.FileSystem.OpenTextFileReader(Directory.GetCurrentDirectory() + "\usuarios.txt")
        Dim i As Integer = 0
        While Not lector.EndOfStream
            musica(i) = lector.ReadLine()
            i += 1
        End While
        lector.Close()

    End Sub
    Dim listamusica As List(Of clasemusica) = New List(Of clasemusica)

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim musica As clasemusica = New clasemusica
        musica.setcodigo(txtcodigo.Text)
        musica.settitulo(txttitulo.Text)
        musica.setautor(txtautor.Text)
        musica.setgenero(txtgenero.Text)
        musica.setgrupo(txtgrupo.Text)
        musica.setaño(Convert.ToInt32(txtaño.Text))
        musica.setvaloracion(Convert.ToDouble(txtvaloracion.Text))
        listamusica.Add(musica)
        For i As Integer = 0 To listamusica.Count - 1 Step 1
            Escribir(ruta, musica.ToString)
        Next

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        For Each valor In listamusica
            ListBox1.Items.Add(valor)
        Next
        VolcarFicheroAMatriz(ruta)
        Dim lector As StreamReader = My.Computer.FileSystem.OpenTextFileReader(ruta)
        Dim contenido As String = lector.ReadToEnd()

        ListBox1.Items.Add(contenido)
        While Not lector.EndOfStream
            ListBox1.Items.Add(contenido & ".................................................")
        End While
        lector.Close()

    End Sub
End Class