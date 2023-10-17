Public Class Form1
    Private Sub btnSumar_Click(sender As Object, e As EventArgs) Handles btnSumar.Click
        Try
            Dim numero1 As Double = Double.Parse(txtNumero1.Text)
            Dim numero2 As Double = Double.Parse(txtNumero2.Text)

            Dim resultado As Double = numero1 + numero2

            txtResultado.Text = resultado.ToString()
        Catch ex As FormatException
            MessageBox.Show("Por favor, ingresa números válidos en los campos 1 y 2.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
