namespace PRL.Forms
{
    partial class FormQLTong
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
            panel1 = new Panel();
            menuStrip1 = new MenuStrip();
            chiTiếtSảnPhẩmToolStripMenuItem = new ToolStripMenuItem();
            sảnPhẩmToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 28);
            panel1.Name = "panel1";
            panel1.Size = new Size(1466, 635);
            panel1.TabIndex = 3;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { chiTiếtSảnPhẩmToolStripMenuItem, sảnPhẩmToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1466, 28);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // chiTiếtSảnPhẩmToolStripMenuItem
            // 
            chiTiếtSảnPhẩmToolStripMenuItem.Name = "chiTiếtSảnPhẩmToolStripMenuItem";
            chiTiếtSảnPhẩmToolStripMenuItem.Size = new Size(136, 24);
            chiTiếtSảnPhẩmToolStripMenuItem.Text = "Chi tiết sản phẩm";
            chiTiếtSảnPhẩmToolStripMenuItem.Click += chiTiếtSảnPhẩmToolStripMenuItem_Click_1;
            // 
            // sảnPhẩmToolStripMenuItem
            // 
            sảnPhẩmToolStripMenuItem.Name = "sảnPhẩmToolStripMenuItem";
            sảnPhẩmToolStripMenuItem.Size = new Size(87, 24);
            sảnPhẩmToolStripMenuItem.Text = "Sản phẩm";
            sảnPhẩmToolStripMenuItem.Click += sảnPhẩmToolStripMenuItem_Click_1;
            // 
            // FormQLTong
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1466, 663);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            Name = "FormQLTong";
            Text = "FormQLTong";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem chiTiếtSảnPhẩmToolStripMenuItem;
        private ToolStripMenuItem sảnPhẩmToolStripMenuItem;
    }
}