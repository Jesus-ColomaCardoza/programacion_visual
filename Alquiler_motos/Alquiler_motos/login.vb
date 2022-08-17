Imports System.Data.SqlClient

Public Class login
    Public cn As SqlConnection
    Public comando As SqlCommand
    Public data As SqlDataReader

    Private Sub btnaceptar_Click(sender As Object, e As EventArgs) Handles btn_aceptar.Click
        Try
            cn.Open()
            comando = cn.CreateCommand()
            comando.CommandText = "select * from usuarios where nombre='" + txtuser.Text + "' and clave='" + txtpassword.Text + "'"
            data = comando.ExecuteReader()

            If (data.Read) Then

                MessageBox.Show("Bienvenido al Sistema", "Login", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                Me.Close()
                menu_principal.Show()

            Else
                MessageBox.Show("Error en Ingresar", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End If

            cn.Close()
        Catch ex As Exception

        End Try



    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        menu_principal.Close()
    End Sub

    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cn = New SqlConnection("Data Source = DESKTOP-AHI2VUU;Initial Catalog=Alquiler_motos;Integrated Security=True")

    End Sub
End Class