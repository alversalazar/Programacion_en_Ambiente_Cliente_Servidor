namespace Form_Seleccion_Region_C_
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
            BtnMostrar = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // BtnMostrar
            // 
            BtnMostrar.BackColor = Color.Black;
            BtnMostrar.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BtnMostrar.ForeColor = Color.White;
            BtnMostrar.Location = new Point(616, 68);
            BtnMostrar.Name = "BtnMostrar";
            BtnMostrar.Size = new Size(149, 54);
            BtnMostrar.TabIndex = 0;
            BtnMostrar.Text = "Mostrar";
            BtnMostrar.UseVisualStyleBackColor = false;
            BtnMostrar.Click += BtnMostrar_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(159, 68);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(423, 268);
            dataGridView1.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(BtnMostrar);
            Name = "Form1";
            Text = "Seleccion Region C# Form";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button BtnMostrar;
        private DataGridView dataGridView1;
    }
}