Public Class login


    Private Sub btnaceptar_Click(sender As Object, e As EventArgs) Handles btn_aceptar.Click
        'Data Source = DESKTOP-AHI2VUU;Initial Catalog=Alquiler_motos;Integrated Security=True
        '. para no escribir el nombre del servidor
        'catalog: nombre de la base de datos

        If (txtpassword.Text.Equals("1234") And txtuser.Text.ToLower.Equals("admin")) Then
            menu_principal.Show()
            Me.Close()
        Else
            MessageBox.Show("Clave o Usuario incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        menu_principal.Close()
    End Sub

End Class