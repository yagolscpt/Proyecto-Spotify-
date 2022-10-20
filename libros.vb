Option Strict On
Imports System.IO
Public Class libros

    Dim peliculas(9900) As String
    Dim ruta As String = Directory.GetCurrentDirectory() + "\libros.txt"
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtgenero.TextChanged

    End Sub
    Sub Escribir(ByRef ruta As String, ByRef registro As String)

        Dim escritor As StreamWriter = My.Computer.FileSystem.OpenTextFileWriter(ruta, True)
        escritor.WriteLine(registro)
        escritor.Close()
    End Sub
    Public Sub VolcarFicheroAMatriz(ByRef ruta As String)

        Dim lector As StreamReader = My.Computer.FileSystem.OpenTextFileReader(Directory.GetCurrentDirectory() + "\usuarios.txt")
        Dim i As Integer = 0
        While Not lector.EndOfStream
            peliculas(i) = lector.ReadLine()
            i += 1
        End While
        lector.Close()

    End Sub
    Dim listalibros As List(Of claselibros) = New List(Of claselibros)

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim libro As claselibros = New claselibros
        libro.setcodigo(Convert.ToInt32(txtcodigo.Text))
        libro.settitulo(txttitulo.Text)
        libro.setautor(txtautor.Text)
        libro.setgenero(txtgenero.Text)

        libro.setaño(Convert.ToInt32(txtaño.Text))
        libro.setvaloracion(Convert.ToDouble(txtvaloracion.Text))
        listalibros.Add(libro)
        For i As Integer = 0 To listalibros.Count - 1 Step 1
            Escribir(ruta, libro.ToString)
        Next
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        For Each valor In listalibros
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