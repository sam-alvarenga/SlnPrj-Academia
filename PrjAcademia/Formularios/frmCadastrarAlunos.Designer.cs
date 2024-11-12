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
            textBox1 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            textBox2 = new TextBox();
            maskedTextBox1 = new MaskedTextBox();
            textBox3 = new TextBox();
            dateTimePicker2 = new DateTimePicker();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            btnCadastrar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(264, 33);
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
            label4.Location = new Point(41, 172);
            label4.Name = "label4";
            label4.Size = new Size(68, 17);
            label4.TabIndex = 3;
            label4.Text = "Endereço:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(485, 171);
            label5.Name = "label5";
            label5.Size = new Size(65, 17);
            label5.TabIndex = 4;
            label5.Text = "Telefone:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(41, 227);
            label6.Name = "label6";
            label6.Size = new Size(51, 17);
            label6.TabIndex = 5;
            label6.Text = "E-mail:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(485, 221);
            label7.Name = "label7";
            label7.Size = new Size(122, 17);
            label7.TabIndex = 6;
            label7.Text = "Data de matrícula:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(41, 282);
            label8.Name = "label8";
            label8.Size = new Size(41, 17);
            label8.TabIndex = 7;
            label8.Text = "Peso:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(41, 337);
            label9.Name = "label9";
            label9.Size = new Size(50, 17);
            label9.TabIndex = 8;
            label9.Text = "Altura:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(180, 116);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(289, 23);
            textBox1.TabIndex = 9;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(624, 117);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(100, 23);
            dateTimePicker1.TabIndex = 10;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(180, 172);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(289, 23);
            textBox2.TabIndex = 11;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(624, 167);
            maskedTextBox1.Mask = "(99)99999-9999";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(100, 23);
            maskedTextBox1.TabIndex = 12;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(180, 228);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(289, 23);
            textBox3.TabIndex = 13;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Format = DateTimePickerFormat.Short;
            dateTimePicker2.Location = new Point(624, 217);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(100, 23);
            dateTimePicker2.TabIndex = 14;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(180, 284);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 15;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(180, 340);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(100, 23);
            textBox5.TabIndex = 16;
            // 
            // btnCadastrar
            // 
            btnCadastrar.BackColor = Color.White;
            btnCadastrar.FlatStyle = FlatStyle.System;
            btnCadastrar.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnCadastrar.ForeColor = Color.Black;
            btnCadastrar.Location = new Point(381, 397);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(88, 28);
            btnCadastrar.TabIndex = 17;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = false;
            // 
            // frmCadastrarAlunos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCadastrar);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(dateTimePicker2);
            Controls.Add(textBox3);
            Controls.Add(maskedTextBox1);
            Controls.Add(textBox2);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBox1);
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
        private TextBox textBox1;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox2;
        private MaskedTextBox maskedTextBox1;
        private TextBox textBox3;
        private DateTimePicker dateTimePicker2;
        private TextBox textBox4;
        private TextBox textBox5;
        private Button btnCadastrar;
    }
}