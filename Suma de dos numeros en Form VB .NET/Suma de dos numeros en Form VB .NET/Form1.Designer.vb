<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        btnSumar = New Button()
        txtNumero1 = New TextBox()
        txtNumero2 = New TextBox()
        txtResultado = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        SuspendLayout()
        ' 
        ' btnSumar
        ' 
        btnSumar.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btnSumar.Location = New Point(94, 55)
        btnSumar.Name = "btnSumar"
        btnSumar.Size = New Size(112, 34)
        btnSumar.TabIndex = 0
        btnSumar.Text = "Sumar"
        btnSumar.UseVisualStyleBackColor = True
        ' 
        ' txtNumero1
        ' 
        txtNumero1.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point)
        txtNumero1.Location = New Point(332, 101)
        txtNumero1.Name = "txtNumero1"
        txtNumero1.Size = New Size(150, 35)
        txtNumero1.TabIndex = 1
        ' 
        ' txtNumero2
        ' 
        txtNumero2.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point)
        txtNumero2.Location = New Point(332, 189)
        txtNumero2.Name = "txtNumero2"
        txtNumero2.Size = New Size(150, 35)
        txtNumero2.TabIndex = 2
        ' 
        ' txtResultado
        ' 
        txtResultado.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point)
        txtResultado.Location = New Point(332, 279)
        txtResultado.Name = "txtResultado"
        txtResultado.Size = New Size(150, 35)
        txtResultado.TabIndex = 3
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(330, 55)
        Label1.Name = "Label1"
        Label1.Size = New Size(216, 27)
        Label1.TabIndex = 4
        Label1.Text = "Ingresa un numero"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(332, 150)
        Label2.Name = "Label2"
        Label2.Size = New Size(216, 27)
        Label2.TabIndex = 5
        Label2.Text = "Ingresa un numero"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(330, 241)
        Label3.Name = "Label3"
        Label3.Size = New Size(121, 27)
        Label3.TabIndex = 6
        Label3.Text = "Resultado"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txtResultado)
        Controls.Add(txtNumero2)
        Controls.Add(txtNumero1)
        Controls.Add(btnSumar)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnSumar As Button
    Friend WithEvents txtNumero1 As TextBox
    Friend WithEvents txtNumero2 As TextBox
    Friend WithEvents txtResultado As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
