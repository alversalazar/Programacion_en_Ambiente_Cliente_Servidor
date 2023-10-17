Public Class index
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim num1, num2, suma As Integer
            num1 = Convert.ToInt16(TextBox1.Text)
            num2 = Convert.ToInt16(TextBox2.Text)
            suma = num1 + num2
            TextBox3.Text = Convert.ToString(suma)
        Catch ex As FormatException
            TextBox3.Text = "Falta agregar números a los campos."
        End Try
    End Sub
End Class