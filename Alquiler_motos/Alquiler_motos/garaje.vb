Public Class garaje
    Private Sub garaje_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Alquiler_motosDataSet_garaje.garaje' Puede moverla o quitarla según sea necesario.
        Me.GarajeTableAdapter.Fill(Me.Alquiler_motosDataSet_garaje.garaje)

    End Sub
End Class