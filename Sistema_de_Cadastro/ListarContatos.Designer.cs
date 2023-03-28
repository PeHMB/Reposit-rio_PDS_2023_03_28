namespace Sistema_de_Cadastro
{
    partial class ListarContatos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvContato = new DataGridView();
            edNome = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvContato).BeginInit();
            SuspendLayout();
            // 
            // dgvContato
            // 
            dgvContato.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvContato.Location = new Point(54, 98);
            dgvContato.Name = "dgvContato";
            dgvContato.RowTemplate.Height = 25;
            dgvContato.Size = new Size(674, 282);
            dgvContato.TabIndex = 0;
            // 
            // edNome
            // 
            edNome.Location = new Point(54, 45);
            edNome.Name = "edNome";
            edNome.Size = new Size(329, 23);
            edNome.TabIndex = 1;
            edNome.TextChanged += textBox1_TextChanged;
            // 
            // ListarContatos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(edNome);
            Controls.Add(dgvContato);
            Name = "ListarContatos";
            Text = "ListarContatos";
            Load += ListarContatos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvContato).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvContato;
        private ComboBox cdNome;
        private TextBox edNome;
    }
}