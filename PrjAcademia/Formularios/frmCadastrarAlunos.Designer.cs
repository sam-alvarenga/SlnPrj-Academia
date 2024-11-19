namespace PrjAcademia.Formularios
{
    partial class frmCadastrarAlunos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastrarAlunos));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            txtNomeAluno = new TextBox();
            dtpDataDeNascimento = new DateTimePicker();
            txtEndereco = new TextBox();
            mtbTelefone = new MaskedTextBox();
            txtEmail = new TextBox();
            dtpDataMatricula = new DateTimePicker();
            txtPeso = new TextBox();
            txtAltura = new TextBox();
            btnCadastrar = new Button();
            dgvDadosAlunos = new DataGridView();
            btnMostrar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvDadosAlunos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(297, 34);
            label1.Name = "label1";
            label1.Size = new Size(266, 37);
            label1.TabIndex = 0;
            label1.Text = "Cadastro de Alunos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(41, 117);
            label2.Name = "label2";
            label2.Size = new Size(113, 17);
            label2.TabIndex = 1;
            label2.Text = "Nome Completo:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(485, 121);
            label3.Name = "label3";
            label3.Size = new Size(137, 17);
            label3.TabIndex = 2;
            label3.Text = "Data de Nascimento:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(41, 156);
            label4.Name = "label4";
            label4.Size = new Size(68, 17);
            label4.TabIndex = 3;
            label4.Text = "Endereço:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(485, 156);
            label5.Name = "label5";
            label5.Size = new Size(65, 17);
            label5.TabIndex = 4;
            label5.Text = "Telefone:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(41, 195);
            label6.Name = "label6";
            label6.Size = new Size(51, 17);
            label6.TabIndex = 5;
            label6.Text = "E-mail:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(485, 197);
            label7.Name = "label7";
            label7.Size = new Size(122, 17);
            label7.TabIndex = 6;
            label7.Text = "Data de matrícula:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(41, 233);
            label8.Name = "label8";
            label8.Size = new Size(41, 17);
            label8.TabIndex = 7;
            label8.Text = "Peso:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(41, 270);
            label9.Name = "label9";
            label9.Size = new Size(50, 17);
            label9.TabIndex = 8;
            label9.Text = "Altura:";
            // 
            // txtNomeAluno
            // 
            txtNomeAluno.Location = new Point(180, 116);
            txtNomeAluno.Name = "txtNomeAluno";
            txtNomeAluno.Size = new Size(289, 23);
            txtNomeAluno.TabIndex = 9;
            // 
            // dtpDataDeNascimento
            // 
            dtpDataDeNascimento.Format = DateTimePickerFormat.Short;
            dtpDataDeNascimento.Location = new Point(624, 117);
            dtpDataDeNascimento.Name = "dtpDataDeNascimento";
            dtpDataDeNascimento.Size = new Size(100, 23);
            dtpDataDeNascimento.TabIndex = 10;
            dtpDataDeNascimento.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // txtEndereco
            // 
            txtEndereco.Location = new Point(180, 156);
            txtEndereco.Name = "txtEndereco";
            txtEndereco.Size = new Size(289, 23);
            txtEndereco.TabIndex = 11;
            // 
            // mtbTelefone
            // 
            mtbTelefone.Location = new Point(624, 152);
            mtbTelefone.Mask = "(99)99999-9999";
            mtbTelefone.Name = "mtbTelefone";
            mtbTelefone.Size = new Size(100, 23);
            mtbTelefone.TabIndex = 12;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(180, 196);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(289, 23);
            txtEmail.TabIndex = 13;
            // 
            // dtpDataMatricula
            // 
            dtpDataMatricula.Format = DateTimePickerFormat.Short;
            dtpDataMatricula.Location = new Point(624, 193);
            dtpDataMatricula.Name = "dtpDataMatricula";
            dtpDataMatricula.Size = new Size(100, 23);
            dtpDataMatricula.TabIndex = 14;
            // 
            // txtPeso
            // 
            txtPeso.Location = new Point(180, 235);
            txtPeso.Name = "txtPeso";
            txtPeso.Size = new Size(100, 23);
            txtPeso.TabIndex = 15;
            // 
            // txtAltura
            // 
            txtAltura.Location = new Point(180, 269);
            txtAltura.Name = "txtAltura";
            txtAltura.Size = new Size(100, 23);
            txtAltura.TabIndex = 16;
            // 
            // btnCadastrar
            // 
            btnCadastrar.BackColor = Color.White;
            btnCadastrar.FlatStyle = FlatStyle.System;
            btnCadastrar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnCadastrar.ForeColor = Color.Black;
            btnCadastrar.Location = new Point(214, 462);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(134, 28);
            btnCadastrar.TabIndex = 17;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = false;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // dgvDadosAlunos
            // 
            dgvDadosAlunos.BackgroundColor = SystemColors.ButtonHighlight;
            dgvDadosAlunos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDadosAlunos.Location = new Point(180, 319);
            dgvDadosAlunos.Name = "dgvDadosAlunos";
            dgvDadosAlunos.RowTemplate.Height = 25;
            dgvDadosAlunos.Size = new Size(544, 111);
            dgvDadosAlunos.TabIndex = 18;
            // 
            // btnMostrar
            // 
            btnMostrar.BackColor = Color.White;
            btnMostrar.FlatStyle = FlatStyle.System;
            btnMostrar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnMostrar.ForeColor = Color.Black;
            btnMostrar.Location = new Point(505, 462);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(134, 28);
            btnMostrar.TabIndex = 19;
            btnMostrar.Text = "Mostrar";
            btnMostrar.UseVisualStyleBackColor = false;
            btnMostrar.Click += btnMostrar_Click;
            // 
            // frmCadastrarAlunos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(800, 502);
            Controls.Add(btnMostrar);
            Controls.Add(dgvDadosAlunos);
            Controls.Add(btnCadastrar);
            Controls.Add(txtAltura);
            Controls.Add(txtPeso);
            Controls.Add(dtpDataMatricula);
            Controls.Add(txtEmail);
            Controls.Add(mtbTelefone);
            Controls.Add(txtEndereco);
            Controls.Add(dtpDataDeNascimento);
            Controls.Add(txtNomeAluno);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmCadastrarAlunos";
            Text = "Cadastrar Aluno";
            Load += frmCadastrarAlunos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDadosAlunos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox txtNomeAluno;
        private DateTimePicker dtpDataDeNascimento;
        private TextBox txtEndereco;
        private MaskedTextBox mtbTelefone;
        private TextBox txtEmail;
        private DateTimePicker dtpDataMatricula;
        private TextBox txtPeso;
        private TextBox txtAltura;
        private Button btnCadastrar;
        private DataGridView dgvDadosAlunos;
        private Button btnMostrar;
    }
}