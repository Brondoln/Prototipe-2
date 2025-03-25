Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Public Class Form2

    Dim Conexion As New SqlConnection("Data Source=LAPTOP-ORQKT1U1\SQLEXPRESS;Initial Catalog=Boxes;Integrated Security=True;Encrypt=False")
    Public Property ValorCapturado As String
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Sub Escaneo()

        Dim DA As New SqlDataAdapter("Mostrar", Conexion)
        Dim DS As New DataSet
        DA.Fill(DS, "Cajas")

        ' Si hay datos, agrega la columna "Valor Capturado" y llena las filas
        If DS.Tables("Cajas").Rows.Count > 0 Then
            ' Agregar columna para el valor capturado
            Dim DT As DataTable = DS.Tables("Cajas")
            DT.Columns.Add("ValorCapturado", GetType(String))

            ' Agregar el valor capturado en cada fila
            For Each row As DataRow In DT.Rows
                row("ValorCapturado") = ValorCapturado ' Asigna el valor desde la propiedad
            Next

            ' Reordenar columnas si es necesario
            DT.Columns("ValorCapturado").SetOrdinal(0) ' Mueve la columna "ValorCapturado" al inicio

            ' Asigna el DataTable al DataGridView
            Me.DataGridView1.DataSource = DT
        Else
            MessageBox.Show("No se encontraron datos para mostrar.")
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
                ' Agregar la columna "Valor Capturado" y llenarla con el valor
                DT.Columns.Add("Numero de parte", GetType(String))

                For Each row As DataRow In DT.Rows
                    row("Numero de parte") = ValorCapturado
                Next

                DT.Columns("Numero de parte").SetOrdinal(0)
                DataGridView1.DataSource = DT
            Else
                MessageBox.Show("No se encontraron registros para el secuenciado.")
            End If

            Conexion.Close()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub



    Private Sub DataGridView1_Click(sender As Object, e As EventArgs) Handles DataGridView1.Click

    End Sub
    Dim listaCajas As New List(Of String)

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles btnNpallet.Click
        If MsgBox("Desea eliminar esta caja del registro actual de pallet?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Pallet") = MsgBoxResult.Yes Then

            Dim DT As New DataTable
            Dim CMD As New SqlCommand("spBorrarSecuenciado", Conexion)
            CMD.CommandType = CommandType.StoredProcedure
            With CMD
                .Parameters.AddWithValue("@Secuenciado", Me.txtSecuenciado.Text)
            End With
            Dim Da As New SqlDataAdapter(CMD)
            Da.Fill(DT)
            Me.DataGridView1.DataSource = DT

            MsgBox("La caja fue borrada", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Pallet")

        End If
        Conexion.Close()
    End Sub

    Private Sub btnSalir_Click_1(sender As Object, e As EventArgs) Handles btnSalir.Click
        If MsgBox("Desea salir?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Pallet") = MsgBoxResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub Guna2Button1_Click_1(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        If listaCajas.Count = 0 Then
            MessageBox.Show("No hay cajas escaneadas para confirmar")
            Exit Sub
        End If
        Dim resultado As String = "Códigos registrados:" & vbCrLf & vbCrLf

        For Each codigo As String In listaCajas
            resultado &= "- " & codigo & vbCrLf
        Next

        MessageBox.Show(resultado, "Confirmación")

        listaCajas.Clear()
        DataGridView1.Rows.Clear()
    End Sub

    Private Sub Guna2HtmlLabel1_Click(sender As Object, e As EventArgs) Handles Guna2HtmlLabel1.Click

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class