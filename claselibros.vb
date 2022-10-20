Public Class claselibros
    Public codigo As Integer
    Private titulo As String

    Private genero As String

    Private autor As String
    Private año As Integer
    Private valoracion As Double
    Public Sub setcodigo(codigo As Integer)
        Me.codigo = codigo
    End Sub
    Public Sub setautor(autor As String)
        Me.autor = autor
    End Sub
    Public Sub settitulo(titulo As String)
        Me.titulo = titulo
    End Sub
    Public Sub setgenero(genero As String)
        Me.genero = genero

    End Sub
    Public Sub setaño(año As Integer)
        Me.año = año

    End Sub
    Public Sub setvaloracion(valoracion As Double)
        Me.valoracion = valoracion

    End Sub
    Public Overrides Function ToString() As String
        Return ("codigo " & codigo & " " & "titulo:" & titulo & " " & " autor:" & autor & " " & " genero:" & genero & "año: " & año & " " & "valoracion:" & valoracion)

    End Function
End Class
