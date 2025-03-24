Public Class Form1
    Private Sub BtnSalir_Click(sender As Object, e As EventArgs)
        If MsgBox("Desea cerrer el formulario?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Usuario") = MsgBoxResult.Yes Then
            Me.Close()
        End If
    End Sub
    Public ReadOnly Property ValorCapturado As String
        Get
            Return TextBox2.Text ' Cambia txtCaptura al nombre real de tu TextBox
        End Get
    End Property
    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs)
        Dim frm2 As New Form2()
        frm2.ValorCapturado = Me.ValorCapturado
        frm2.Show()

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub btnRegistrar_Click_1(sender As Object, e As EventArgs) Handles btnRegistrar.Click

    End Sub

    Private Sub Guna2HtmlLabel1_Click(sender As Object, e As EventArgs) Handles Guna2HtmlLabel1.Click

    End Sub
End Class
