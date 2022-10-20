Option Strict On
Public Class peliculas


    Dim listapeliculas As List(Of clase_peliculas) = New List(Of clase_peliculas)



    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles txttitulo.TextChanged

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtactores.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnagregarpeliculas.Click
        Label1.Visible = True
        Label2.Visible = True
        Label3.Visible = True
        Label4.Visible = True
        Label5.Visible = True
        Label6.Visible = True
        valoración.Visible = True
        txtactores.Visible = True
        txtautor.Visible = True
        txtaño.Visible = True
        txtcodigo.Visible = True
        txtgenero.Visible = True
        txttitulo.Visible = True
        txtvaloracion.Visible = True
        btnagregarpeliculas.Visible = False
        btnguardarpeliculas.Visible = True

    End Sub

    Private Sub btnguardarpeliculas_Click(sender As Object, e As EventArgs) Handles btnguardarpeliculas.Click
        Dim pelicula As clase_peliculas = New clase_peliculas

        listapeliculas.Add(pelicula)


    End Sub
End Class