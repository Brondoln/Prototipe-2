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
        ' Reiniciar el Timer cada vez que cambia el texto
        TimerEscaneo.Stop()
        If txtSecuenciado.Text.Length >= 10 And txtSecuenciado.Text.Length <= 12 Then
            TimerEscaneo.Start() ' Esperar unos milisegundos antes de ejecutar BuscarSecuenciado
        End If
    End Sub

    Private Sub TimerEscaneo_Tick(sender As Object, e As EventArgs) Handles TimerEscaneo.Tick
        ' Detener el Timer para evitar ejecuciones repetidas
        TimerEscaneo.Stop()

        ' Llamar al método solo después de validar la longitud
        If txtSecuenciado.Text.Length >= 10 And txtSecuenciado.Text.Length <= 12 Then
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
                ' Agregar la columna "Número de parte" si no existe aún en la tabla actual
                If Not DT.Columns.Contains("Número de parte") Then
                    DT.Columns.Add("Número de parte", GetType(String))
                End If

                ' Añadir el valor capturado en la nueva columna
                For Each row As DataRow In DT.Rows
                    row("Número de parte") = ValorCapturado
                Next

                ' Asegurar que la columna "Número de parte" esté en la primera posición
                DT.Columns("Número de parte").SetOrdinal(0)

                ' Combinar los datos nuevos con los existentes en el DataGridView
                Dim dtExistente As DataTable = CType(DataGridView1.DataSource, DataTable)
                If dtExistente IsNot Nothing Then
                    For Each row As DataRow In DT.Rows
                        dtExistente.ImportRow(row) ' Importa las filas del nuevo DataTable
                    Next
                    DataGridView1.DataSource = dtExistente
                Else
                    DataGridView1.DataSource = DT ' Si está vacío, asignar directamente
                End If

                ' Agregar el código escaneado a la lista si no está ya
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

        ' Limpiar el campo de texto después del escaneo
        txtSecuenciado.Clear()
    End Sub


    Private Sub btnConfirmarEscaneo_Click(sender As Object, e As EventArgs) Handles btnConfirmarEscaneo.Click

    End Sub

    Private Sub btnBorrarEscaneo_Click(sender As Object, e As EventArgs) Handles btnBorrarEscaneo.Click

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

    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click

    End Sub
End Class
