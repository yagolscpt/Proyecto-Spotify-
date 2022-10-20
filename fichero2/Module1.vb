Option Strict On
Imports System.IO
Module Module1
    Dim ruta As String = Directory.GetCurrentDirectory() + "\usuarios.txt"
    Sub Escribir(ByRef ruta As String, ByRef registro As String)

        Dim escritor As StreamWriter = My.Computer.FileSystem.OpenTextFileWriter(ruta, True)
        escritor.WriteLine(registro)
        escritor.Close()
    End Sub
    Sub Main()


    End Sub

End Module
