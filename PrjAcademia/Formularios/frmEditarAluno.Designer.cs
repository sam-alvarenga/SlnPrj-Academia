namespace PrjAcademia.Formularios
{
    partial class frmEditarAluno
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
            txtAltura = new TextBox();
            txtPeso = new TextBox();
            txtEmail = new TextBox();
            mtbTelefone = new MaskedTextBox();
            txtEndereco = new TextBox();
            dtpDataDeNascimento = new DateTimePicker();
            txtNomeAluno = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnExcluir = new Button();
            btnEditar = new Button();
            label10 = new Label();
            txtCodigoALuno = new TextBox();
            btnBuscar = new Button();
            SuspendLayout();
            // 
            // txtAltura
            // 
            txtAltura.Location = new Point(198, 309);
            txtAltura.Name = "txtAltura";
            txtAltura.Size = new Size(100, 23);
            txtAltura.TabIndex = 32;
            // 
            // txtPeso
            // 
            txtPeso.Location = new Point(198, 269);
            txtPeso.Name = "txtPeso";
            txtPeso.Size = new Size(100, 23);
            txtPeso.TabIndex = 31;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(198, 229);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(289, 23);
            txtEmail.TabIndex = 29;
            // 
            // mtbTelefone
            // 
            mtbTelefone.Location = new Point(640, 184);
            mtbTelefone.Mask = "(99)99999-9999";
            mtbTelefone.Name = "mtbTelefone";
            mtbTelefone.Size = new Size(100, 23);
            mtbTelefone.TabIndex = 28;
            // 
            // txtEndereco
            // 
            txtEndereco.Location = new Point(198, 189);
            txtEndereco.Name = "txtEndereco";
            txtEndereco.Size = new Size(289, 23);
            txtEndereco.TabIndex = 27;
            // 
            // dtpDataDeNascimento
            // 
            dtpDataDeNascimento.Format = DateTimePickerFormat.Short;
            dtpDataDeNascimento.Location = new Point(640, 146);
            dtpDataDeNascimento.Name = "dtpDataDeNascimento";
            dtpDataDeNascimento.Size = new Size(100, 23);
            dtpDataDeNascimento.TabIndex = 26;
            // 
            // txtNomeAluno
            // 
            txtNomeAluno.Location = new Point(198, 149);
            txtNomeAluno.Name = "txtNomeAluno";
            txtNomeAluno.Size = new Size(289, 23);
            txtNomeAluno.TabIndex = 25;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(75, 310);
            label9.Name = "label9";
            label9.Size = new Size(50, 17);
            label9.TabIndex = 24;
            label9.Text = "Altura:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(75, 270);
            label8.Name = "label8";
            label8.Size = new Size(41, 17);
            label8.TabIndex = 23;
            label8.Text = "Peso:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(75, 230);
            label6.Name = "label6";
            label6.Size = new Size(51, 17);
            label6.TabIndex = 21;
            label6.Text = "E-mail:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(501, 188);
            label5.Name = "label5";
            label5.Size = new Size(65, 17);
            label5.TabIndex = 20;
            label5.Text = "Telefone:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(75, 190);
            label4.Name = "label4";
            label4.Size = new Size(68, 17);
            label4.TabIndex = 19;
            label4.Text = "Endereço:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(501, 150);
            label3.Name = "label3";
            label3.Size = new Size(137, 17);
            label3.TabIndex = 18;
            label3.Text = "Data de Nascimento:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(75, 150);
            label2.Name = "label2";
            label2.Size = new Size(113, 17);
            label2.TabIndex = 17;
            label2.Text = "Nome Completo:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(311, 31);
            label1.Name = "label1";
            label1.Size = new Size(176, 37);
            label1.TabIndex = 33;
            label1.Text = "Editar Aluno";
            // 
            // btnExcluir
            // 
            btnExcluir.BackColor = Color.White;
            btnExcluir.FlatStyle = FlatStyle.System;
            btnExcluir.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnExcluir.ForeColor = Color.Black;
            btnExcluir.Location = new Point(472, 370);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(134, 28);
            btnExcluir.TabIndex = 35;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = false;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.White;
            btnEditar.FlatStyle = FlatStyle.System;
            btnEditar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnEditar.ForeColor = Color.Black;
            btnEditar.Location = new Point(215, 370);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(134, 28);
            btnEditar.TabIndex = 34;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(75, 110);
            label10.Name = "label10";
            label10.Size = new Size(117, 17);
            label10.TabIndex = 36;
            label10.Text = "Código do Aluno:";
            // 
            // txtCodigoALuno
            // 
            txtCodigoALuno.Location = new Point(198, 109);
            txtCodigoALuno.Name = "txtCodigoALuno";
            txtCodigoALuno.Size = new Size(100, 23);
            txtCodigoALuno.TabIndex = 37;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.White;
            btnBuscar.FlatStyle = FlatStyle.System;
            btnBuscar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnBuscar.ForeColor = Color.Black;
            btnBuscar.Location = new Point(323, 109);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(58, 23);
            btnBuscar.TabIndex = 38;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // frmEditarAluno
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBuscar);
            Controls.Add(txtCodigoALuno);
            Controls.Add(label10);
            Controls.Add(btnExcluir);
            Controls.Add(btnEditar);
            Controls.Add(label1);
            Controls.Add(txtAltura);
            Controls.Add(txtPeso);
            Controls.Add(txtEmail);
            Controls.Add(mtbTelefone);
            Controls.Add(txtEndereco);
            Controls.Add(dtpDataDeNascimento);
            Controls.Add(txtNomeAluno);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Name = "frmEditarAluno";
            Text = "frmEditarAluno";
            Load += frmEditarAluno_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtAltura;
        private TextBox txtPeso;
        private TextBox txtEmail;
        private MaskedTextBox mtbTelefone;
        private TextBox txtEndereco;
        private DateTimePicker dtpDataDeNascimento;
        private TextBox txtNomeAluno;
        private Label label9;
        private Label label8;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnExcluir;
        private Button btnEditar;
        private Label label10;
        private TextBox txtCodigoALuno;
        private Button btnBuscar;
    }
}