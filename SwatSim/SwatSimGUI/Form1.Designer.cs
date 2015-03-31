namespace SwatSimGUI
{
    partial class Form1
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
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainStatusStrip = new System.Windows.Forms.StatusStrip();
            this.MainToolStrip = new System.Windows.Forms.ToolStrip();
            this.ParentPanel = new System.Windows.Forms.SplitContainer();
            this.ToolPanel = new System.Windows.Forms.SplitContainer();
            this.Toolbox = new System.Windows.Forms.ListView();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.elementHost1 = new System.Windows.Forms.Integration.ElementHost();
            this.MainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ParentPanel)).BeginInit();
            this.ParentPanel.Panel1.SuspendLayout();
            this.ParentPanel.Panel2.SuspendLayout();
            this.ParentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ToolPanel)).BeginInit();
            this.ToolPanel.Panel1.SuspendLayout();
            this.ToolPanel.Panel2.SuspendLayout();
            this.ToolPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenu
            // 
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(1007, 24);
            this.MainMenu.TabIndex = 0;
            this.MainMenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // MainStatusStrip
            // 
            this.MainStatusStrip.Location = new System.Drawing.Point(0, 717);
            this.MainStatusStrip.Name = "MainStatusStrip";
            this.MainStatusStrip.Size = new System.Drawing.Size(1007, 22);
            this.MainStatusStrip.TabIndex = 1;
            this.MainStatusStrip.Text = "statusStrip1";
            // 
            // MainToolStrip
            // 
            this.MainToolStrip.Location = new System.Drawing.Point(0, 24);
            this.MainToolStrip.Name = "MainToolStrip";
            this.MainToolStrip.Size = new System.Drawing.Size(1007, 25);
            this.MainToolStrip.TabIndex = 2;
            this.MainToolStrip.Text = "toolStrip1";
            // 
            // ParentPanel
            // 
            this.ParentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ParentPanel.Location = new System.Drawing.Point(0, 49);
            this.ParentPanel.Name = "ParentPanel";
            // 
            // ParentPanel.Panel1
            // 
            this.ParentPanel.Panel1.Controls.Add(this.elementHost1);
            // 
            // ParentPanel.Panel2
            // 
            this.ParentPanel.Panel2.Controls.Add(this.ToolPanel);
            this.ParentPanel.Size = new System.Drawing.Size(1007, 668);
            this.ParentPanel.SplitterDistance = 683;
            this.ParentPanel.TabIndex = 3;
            // 
            // ToolPanel
            // 
            this.ToolPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ToolPanel.Location = new System.Drawing.Point(0, 0);
            this.ToolPanel.Name = "ToolPanel";
            this.ToolPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // ToolPanel.Panel1
            // 
            this.ToolPanel.Panel1.Controls.Add(this.Toolbox);
            // 
            // ToolPanel.Panel2
            // 
            this.ToolPanel.Panel2.Controls.Add(this.flowLayoutPanel1);
            this.ToolPanel.Size = new System.Drawing.Size(320, 668);
            this.ToolPanel.SplitterDistance = 316;
            this.ToolPanel.TabIndex = 0;
            // 
            // Toolbox
            // 
            this.Toolbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Toolbox.Location = new System.Drawing.Point(0, 0);
            this.Toolbox.Name = "Toolbox";
            this.Toolbox.Size = new System.Drawing.Size(320, 316);
            this.Toolbox.TabIndex = 0;
            this.Toolbox.UseCompatibleStateImageBehavior = false;
            this.Toolbox.View = System.Windows.Forms.View.Tile;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(320, 348);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // elementHost1
            // 
            this.elementHost1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.elementHost1.Location = new System.Drawing.Point(0, 0);
            this.elementHost1.Name = "elementHost1";
            this.elementHost1.Size = new System.Drawing.Size(683, 668);
            this.elementHost1.TabIndex = 0;
            this.elementHost1.Text = "elementHost1";
            this.elementHost1.Child = null;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 739);
            this.Controls.Add(this.ParentPanel);
            this.Controls.Add(this.MainToolStrip);
            this.Controls.Add(this.MainStatusStrip);
            this.Controls.Add(this.MainMenu);
            this.MainMenuStrip = this.MainMenu;
            this.Name = "Form1";
            this.Text = "Form1";
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.ParentPanel.Panel1.ResumeLayout(false);
            this.ParentPanel.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ParentPanel)).EndInit();
            this.ParentPanel.ResumeLayout(false);
            this.ToolPanel.Panel1.ResumeLayout(false);
            this.ToolPanel.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ToolPanel)).EndInit();
            this.ToolPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.StatusStrip MainStatusStrip;
        private System.Windows.Forms.ToolStrip MainToolStrip;
        private System.Windows.Forms.SplitContainer ParentPanel;
        private System.Windows.Forms.SplitContainer ToolPanel;
        private System.Windows.Forms.ListView Toolbox;
        private System.Windows.Forms.Integration.ElementHost elementHost1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}

