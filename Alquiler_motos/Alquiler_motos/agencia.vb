Public Class agencia
    Private Sub agencia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Alquiler_motosDataSet_agencia.agencia' Puede moverla o quitarla según sea necesario.
        Me.AgenciaTableAdapter.Fill(Me.Alquiler_motosDataSet_agencia.agencia)

    End Sub
End Class