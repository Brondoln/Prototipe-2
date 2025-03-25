Imports System.Data.SqlClient

Public Class Form1
    Dim Conexion As New SqlConnection("Data Source=LAPTOP-ORQKT1U1\SQLEXPRESS;Initial Catalog=Boxes;Integrated Security=True;Encrypt=False")

    Dim listaCajas As New List(Of String)

    Public ReadOnly Property ValorCapturado As String
        Get
            Return txtCaptura.Text
        End Get
    End Property

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtCaptura.Focus()
    End Sub

    Private Sub BtnSalir_Click_1(sender As Object, e As EventArgs) Handles BtnSalir.Click
        If MsgBox("¿Desea cerrar el formulario?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Usuario") = MsgBoxResult.Yes Then
            Me.Close()
        End If
    End Sub



    Private Sub txtSecuenciado_TextChanged(sender As Object, e As EventArgs) Handles txtSecuenciado.TextChanged
        If txtSecuenciado.Text.Length > 9 Then
            BuscarSecuenciado()
        End If
    End Sub

    Private Sub BuscarSecuenciado()
        Try
            Conexion.Open()

            Dim DA As New SqlDataAdapter("spBuscar", Conexion)
            DA.SelectCommand.CommandType = CommandType.StoredProcedure
            DA.SelectCommand.Parameters.AddWithValue("@Secuenciado", txtSecuenciado.Text)

            Dim DT As New DataTable
            DA.Fill(DT)

            If DT.Rows.Count > 0 Then
                DT.Columns.Add("Número de parte", GetType(String))
                For Each row As DataRow In DT.Rows
                    row("Número de parte") = ValorCapturado
                Next
                DT.Columns("Número de parte").SetOrdinal(0)
                DataGridView1.DataSource = DT

                If Not listaCajas.Contains(txtSecuenciado.Text) Then
                    listaCajas.Add(txtSecuenciado.Text)
                End If
            Else
                MessageBox.Show("No se encontraron registros para el secuenciado.")
            End If

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            Conexion.Close()
        End Try
        txtSecuenciado.Clear()
    End Sub

    Private Sub btnConfirmarEscaneo_Click(sender As Object, e As EventArgs) Handles btnConfirmarEscaneo.Click
        If listaCajas.Count = 0 Then
            MessageBox.Show("No hay cajas escaneadas para confirmar")
            Return
        End If

        Dim resumen As String = "Códigos registrados:" & vbCrLf & vbCrLf
        For Each codigo In listaCajas
            resumen &= "- " & codigo & vbCrLf
        Next
        MessageBox.Show(resumen, "Confirmación")

        listaCajas.Clear()
        DataGridView1.Rows.Clear()
    End Sub

    Private Sub btnBorrarEscaneo_Click(sender As Object, e As EventArgs) Handles btnBorrarEscaneo.Click
        If MsgBox("¿Desea eliminar esta caja del registro actual de pallet?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmación") = MsgBoxResult.Yes Then
            Try
                Conexion.Open()
                Dim CMD As New SqlCommand("spBorrarSecuenciado", Conexion)
                CMD.CommandType = CommandType.StoredProcedure
                CMD.Parameters.AddWithValue("@Secuenciado", txtSecuenciado.Text)
                CMD.ExecuteNonQuery()
                MessageBox.Show("La caja fue borrada correctamente.")
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            Finally
                Conexion.Close()
                txtSecuenciado.Clear()
            End Try
        End If
    End Sub

    Private Sub btnSalirEscaneo_Click(sender As Object, e As EventArgs) Handles btnSalirEscaneo.Click
        If MsgBox("¿Desea salir?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmación") = MsgBoxResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub txtCaptura_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtNPalle_TextChanged(sender As Object, e As EventArgs) Handles txtNPallet.TextChanged

    End Sub

    Private Sub txtCaptura_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCaptura.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtNPallet.Focus()
            e.SuppressKeyPress = True
        End If
    End Sub
End Class
