namespace Sistema_de_Cadastro
    {
    partial class CadastrarContato
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
            btCadastrar = new Button();
            label1 = new Label();
            edNome = new TextBox();
            edCPF = new TextBox();
            label2 = new Label();
            edTelefone = new TextBox();
            label3 = new Label();
            cbSexo = new ComboBox();
            label4 = new Label();
            button1 = new Button();
            dtpDataNasc = new DateTimePicker();
            SuspendLayout();
            // 
            // btCadastrar
            // 
            btCadastrar.Location = new Point(12 , 267);
            btCadastrar.Name = "btCadastrar";
            btCadastrar.Size = new Size(87 , 25);
            btCadastrar.TabIndex = 0;
            btCadastrar.Text = "Cadastrar";
            btCadastrar.UseVisualStyleBackColor = true;
            btCadastrar.Click += btCadastrar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12 , 19);
            label1.Name = "label1";
            label1.Size = new Size(45 , 15);
            label1.TabIndex = 1;
            label1.Text = "NOME:";
            // 
            // edNome
            // 
            edNome.Location = new Point(12 , 37);
            edNome.Name = "edNome";
            edNome.Size = new Size(200 , 23);
            edNome.TabIndex = 2;
            // 
            // edCPF
            // 
            edCPF.Location = new Point(12 , 85);
            edCPF.Name = "edCPF";
            edCPF.Size = new Size(200 , 23);
            edCPF.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12 , 67);
            label2.Name = "label2";
            label2.Size = new Size(31 , 15);
            label2.TabIndex = 3;
            label2.Text = "CPF:";
            // 
            // edTelefone
            // 
            edTelefone.Location = new Point(12 , 136);
            edTelefone.Name = "edTelefone";
            edTelefone.Size = new Size(200 , 23);
            edTelefone.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12 , 118);
            label3.Name = "label3";
            label3.Size = new Size(64 , 15);
            label3.TabIndex = 5;
            label3.Text = "TELEFONE:";
            // 
            // cbSexo
            // 
            cbSexo.FormattingEnabled = true;
            cbSexo.Location = new Point(12 , 188);
            cbSexo.Name = "cbSexo";
            cbSexo.Size = new Size(200 , 23);
            cbSexo.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12 , 170);
            label4.Name = "label4";
            label4.Size = new Size(38 , 15);
            label4.TabIndex = 8;
            label4.Text = "SEXO:";
            // 
            // button1
            // 
            button1.Location = new Point(105 , 267);
            button1.Name = "button1";
            button1.Size = new Size(87 , 25);
            button1.TabIndex = 9;
            button1.Text = "Exibir";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dtpDataNasc
            // 
            dtpDataNasc.Location = new Point(12 , 227);
            dtpDataNasc.Name = "dtpDataNasc";
            dtpDataNasc.Size = new Size(200 , 23);
            dtpDataNasc.TabIndex = 10;
            // 
            // CadastrarContato
            // 
            AutoScaleDimensions = new SizeF(7F , 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(402 , 311);
            Controls.Add(dtpDataNasc);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(cbSexo);
            Controls.Add(edTelefone);
            Controls.Add(label3);
            Controls.Add(edCPF);
            Controls.Add(label2);
            Controls.Add(edNome);
            Controls.Add(label1);
            Controls.Add(btCadastrar);
            Name = "CadastrarContato";
            Text = "CadastrarContato";
            Load += CadastrarContato_Load;
            ResumeLayout(false);
            PerformLayout();
            }

        #endregion

        private Button btCadastrar;
        private Label label1;
        private TextBox edNome;
        private TextBox edCPF;
        private Label label2;
        private TextBox edTelefone;
        private Label label3;
        private ComboBox cbSexo;
        private Label label4;
        private Button button1;
        private DateTimePicker dtpDataNasc;
        }
    }