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
            menuStrip1 = new MenuStrip();
            formuláriosToolStripMenuItem = new ToolStripMenuItem();
            cadastrarAlunosToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { formuláriosToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // formuláriosToolStripMenuItem
            // 
            formuláriosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cadastrarAlunosToolStripMenuItem });
            formuláriosToolStripMenuItem.Name = "formuláriosToolStripMenuItem";
            formuláriosToolStripMenuItem.Size = new Size(82, 20);
            formuláriosToolStripMenuItem.Text = "Formulários";
            // 
            // cadastrarAlunosToolStripMenuItem
            // 
            cadastrarAlunosToolStripMenuItem.Name = "cadastrarAlunosToolStripMenuItem";
            cadastrarAlunosToolStripMenuItem.Size = new Size(180, 22);
            cadastrarAlunosToolStripMenuItem.Text = "Cadastrar Alunos";
            cadastrarAlunosToolStripMenuItem.Click += cadastrarAlunosToolStripMenuItem_Click;
            // 
            // frmMenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "frmMenuPrincipal";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem formuláriosToolStripMenuItem;
        private ToolStripMenuItem cadastrarAlunosToolStripMenuItem;
    }
}