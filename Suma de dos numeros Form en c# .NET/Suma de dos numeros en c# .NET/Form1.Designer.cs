namespace Suma_de_dos_numeros_en_c__.NET
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnSumar = new Button();
            txtNumero1 = new TextBox();
            txtNumero2 = new TextBox();
            txtResultado = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // btnSumar
            // 
            btnSumar.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSumar.Location = new Point(115, 68);
            btnSumar.Name = "btnSumar";
            btnSumar.Size = new Size(125, 53);
            btnSumar.TabIndex = 0;
            btnSumar.Text = "Sumar";
            btnSumar.UseVisualStyleBackColor = true;
            btnSumar.Click += btnSumar_Click;
            // 
            // txtNumero1
            // 
            txtNumero1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNumero1.Location = new Point(329, 68);
            txtNumero1.Name = "txtNumero1";
            txtNumero1.Size = new Size(150, 35);
            txtNumero1.TabIndex = 1;
            // 
            // txtNumero2
            // 
            txtNumero2.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNumero2.Location = new Point(329, 164);
            txtNumero2.Name = "txtNumero2";
            txtNumero2.Size = new Size(150, 35);
            txtNumero2.TabIndex = 2;
            // 
            // txtResultado
            // 
            txtResultado.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtResultado.Location = new Point(329, 269);
            txtResultado.Name = "txtResultado";
            txtResultado.Size = new Size(150, 35);
            txtResultado.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(329, 38);
            label1.Name = "label1";
            label1.Size = new Size(216, 27);
            label1.TabIndex = 4;
            label1.Text = "Ingresa un numero";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(329, 134);
            label2.Name = "label2";
            label2.Size = new Size(216, 27);
            label2.TabIndex = 5;
            label2.Text = "Ingresa un numero";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(329, 239);
            label3.Name = "label3";
            label3.Size = new Size(121, 27);
            label3.TabIndex = 6;
            label3.Text = "Resultado";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtResultado);
            Controls.Add(txtNumero2);
            Controls.Add(txtNumero1);
            Controls.Add(btnSumar);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSumar;
        private TextBox txtNumero1;
        private TextBox txtNumero2;
        private TextBox txtResultado;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}