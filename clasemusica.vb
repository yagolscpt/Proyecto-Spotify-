Public Class clasemusica
    Public codigo As Integer
    Private titulo As String
    Private grupo As String
    Private genero As String
    Private album As String
    Private autor As String
    Private año As Integer
    Private valoracion As Double

    Public Sub setalbum(album As String)
        Me.album = album
    End Sub
    Public Sub setaño(año As Integer)
        Me.año = año
    End Sub
    Public Sub setvaloracion(valoracion As Double)
        Me.valoracion = valoracion
    End Sub
    Public Sub setgrupo(grupo As String)
        Me.grupo = grupo
    End Sub
    Public Sub setautor(autor As String)
        Me.autor = autor
    End Sub
    Public Sub setcodigo(codigo As String)
        Me.codigo = codigo

    End Sub
    Public Sub settitulo(titulo As String)
        Me.titulo = titulo


    End Sub
    Public Sub setgenero(genero As String)
        Me.genero = genero

    End Sub
    Public Overrides Function ToString() As String
        Return ("codigo: " & codigo & " " & "titulo: " & titulo & " " & "grupo:" & grupo & " " & "genero:" & genero & " " & "album:" & album & " " & "año:" & año & " " & "valoracion:" & valoracion)

    End Function
End Class
