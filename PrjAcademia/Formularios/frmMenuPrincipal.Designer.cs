namespace PrjAcademia
{
    partial class frmMenuPrincipal
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
            menuFormularios = new MenuStrip();
            formuláriosToolStripMenuItem = new ToolStripMenuItem();
            cadastrarAlunosToolStripMenuItem = new ToolStripMenuItem();
            editarAlunoToolStripMenuItem = new ToolStripMenuItem();
            menuFormularios.SuspendLayout();
            SuspendLayout();
            // 
            // menuFormularios
            // 
            menuFormularios.Items.AddRange(new ToolStripItem[] { formuláriosToolStripMenuItem });
            menuFormularios.Location = new Point(0, 0);
            menuFormularios.Name = "menuFormularios";
            menuFormularios.Size = new Size(800, 24);
            menuFormularios.TabIndex = 0;
            menuFormularios.Text = "menuStrip1";
            // 
            // formuláriosToolStripMenuItem
            // 
            formuláriosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cadastrarAlunosToolStripMenuItem, editarAlunoToolStripMenuItem });
            formuláriosToolStripMenuItem.Name = "formuláriosToolStripMenuItem";
            formuláriosToolStripMenuItem.Size = new Size(82, 20);
            formuláriosToolStripMenuItem.Text = "Formulários";
            // 
            // cadastrarAlunosToolStripMenuItem
            // 
            cadastrarAlunosToolStripMenuItem.Name = "cadastrarAlunosToolStripMenuItem";
            cadastrarAlunosToolStripMenuItem.Size = new Size(180, 22);
            cadastrarAlunosToolStripMenuItem.Text = "Cadastrar Aluno";
            cadastrarAlunosToolStripMenuItem.Click += cadastrarAlunosToolStripMenuItem_Click;
            // 
            // editarAlunoToolStripMenuItem
            // 
            editarAlunoToolStripMenuItem.Name = "editarAlunoToolStripMenuItem";
            editarAlunoToolStripMenuItem.Size = new Size(180, 22);
            editarAlunoToolStripMenuItem.Text = "Editar Aluno";
            editarAlunoToolStripMenuItem.Click += editarAlunoToolStripMenuItem_Click;
            // 
            // frmMenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuFormularios);
            IsMdiContainer = true;
            MainMenuStrip = menuFormularios;
            Name = "frmMenuPrincipal";
            Text = "Form1";
            menuFormularios.ResumeLayout(false);
            menuFormularios.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuFormularios;
        private ToolStripMenuItem formuláriosToolStripMenuItem;
        private ToolStripMenuItem cadastrarAlunosToolStripMenuItem;
        private ToolStripMenuItem editarAlunoToolStripMenuItem;
    }
}