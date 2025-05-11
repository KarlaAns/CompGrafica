namespace WindowsFormsApp1
{
    partial class FrmHome
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.figurasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.triánguloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cuadradoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.círculoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trapecioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trapecioIsóscelesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.romboideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.heptágonoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.decágonoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pentágonoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.figurasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // figurasToolStripMenuItem
            // 
            this.figurasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.triánguloToolStripMenuItem,
            this.cuadradoToolStripMenuItem,
            this.círculoToolStripMenuItem,
            this.trapecioToolStripMenuItem,
            this.trapecioIsóscelesToolStripMenuItem,
            this.romboideToolStripMenuItem,
            this.heptágonoToolStripMenuItem,
            this.decágonoToolStripMenuItem,
            this.pentágonoToolStripMenuItem});
            this.figurasToolStripMenuItem.Name = "figurasToolStripMenuItem";
            this.figurasToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.figurasToolStripMenuItem.Text = "Figuras";
            // 
            // triánguloToolStripMenuItem
            // 
            this.triánguloToolStripMenuItem.Name = "triánguloToolStripMenuItem";
            this.triánguloToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.triánguloToolStripMenuItem.Text = "Triángulo";
            this.triánguloToolStripMenuItem.Click += new System.EventHandler(this.triánguloToolStripMenuItem_Click);
            // 
            // cuadradoToolStripMenuItem
            // 
            this.cuadradoToolStripMenuItem.Name = "cuadradoToolStripMenuItem";
            this.cuadradoToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.cuadradoToolStripMenuItem.Text = "Cuadrado";
            this.cuadradoToolStripMenuItem.Click += new System.EventHandler(this.cuadradoToolStripMenuItem_Click);
            // 
            // círculoToolStripMenuItem
            // 
            this.círculoToolStripMenuItem.Name = "círculoToolStripMenuItem";
            this.círculoToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.círculoToolStripMenuItem.Text = "Círculo";
            this.círculoToolStripMenuItem.Click += new System.EventHandler(this.círculoToolStripMenuItem_Click);
            // 
            // trapecioToolStripMenuItem
            // 
            this.trapecioToolStripMenuItem.Name = "trapecioToolStripMenuItem";
            this.trapecioToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.trapecioToolStripMenuItem.Text = "Trapecio";
            this.trapecioToolStripMenuItem.Click += new System.EventHandler(this.trapecioToolStripMenuItem_Click);
            // 
            // trapecioIsóscelesToolStripMenuItem
            // 
            this.trapecioIsóscelesToolStripMenuItem.Name = "trapecioIsóscelesToolStripMenuItem";
            this.trapecioIsóscelesToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.trapecioIsóscelesToolStripMenuItem.Text = "Trapecio (Isósceles)";
            this.trapecioIsóscelesToolStripMenuItem.Click += new System.EventHandler(this.trapecioIsóscelesToolStripMenuItem_Click);
            // 
            // romboideToolStripMenuItem
            // 
            this.romboideToolStripMenuItem.Name = "romboideToolStripMenuItem";
            this.romboideToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.romboideToolStripMenuItem.Text = "Romboide";
            this.romboideToolStripMenuItem.Click += new System.EventHandler(this.romboideToolStripMenuItem_Click);
            // 
            // heptágonoToolStripMenuItem
            // 
            this.heptágonoToolStripMenuItem.Name = "heptágonoToolStripMenuItem";
            this.heptágonoToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.heptágonoToolStripMenuItem.Text = "Heptágono";
            this.heptágonoToolStripMenuItem.Click += new System.EventHandler(this.heptágonoToolStripMenuItem_Click);
            // 
            // decágonoToolStripMenuItem
            // 
            this.decágonoToolStripMenuItem.Name = "decágonoToolStripMenuItem";
            this.decágonoToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.decágonoToolStripMenuItem.Text = "Decágono";
            this.decágonoToolStripMenuItem.Click += new System.EventHandler(this.decágonoToolStripMenuItem_Click);
            // 
            // pentágonoToolStripMenuItem
            // 
            this.pentágonoToolStripMenuItem.Name = "pentágonoToolStripMenuItem";
            this.pentágonoToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.pentágonoToolStripMenuItem.Text = "Pentágono";
            this.pentágonoToolStripMenuItem.Click += new System.EventHandler(this.pentágonoToolStripMenuItem_Click);
            // 
            // FrmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmHome";
            this.Text = "Home";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem figurasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem triánguloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cuadradoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem círculoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trapecioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trapecioIsóscelesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem romboideToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem heptágonoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem decágonoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pentágonoToolStripMenuItem;
    }
}

