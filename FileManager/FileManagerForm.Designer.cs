
namespace FileManager
{
    partial class FileManagerForm
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
            this.components = new System.ComponentModel.Container();
            this.toolBar = new System.Windows.Forms.ToolStrip();
            this.viewDropDownButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.listViewButton = new System.Windows.Forms.ToolStripMenuItem();
            this.smallIconViewButton = new System.Windows.Forms.ToolStripMenuItem();
            this.tileViewButton = new System.Windows.Forms.ToolStripMenuItem();
            this.detailsViewButton = new System.Windows.Forms.ToolStripMenuItem();
            this.contentPanel = new System.Windows.Forms.Panel();
            this.fileViewSplitContainer = new System.Windows.Forms.SplitContainer();
            this.pathPanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pathBar = new System.Windows.Forms.TextBox();
            this.refreshButton = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.upButton = new System.Windows.Forms.PictureBox();
            this.forwardButton = new System.Windows.Forms.PictureBox();
            this.backButton = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.fileContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.directoryContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.open = new System.Windows.Forms.ToolStripMenuItem();
            this.openInNewWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.toolBar.SuspendLayout();
            this.contentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileViewSplitContainer)).BeginInit();
            this.fileViewSplitContainer.SuspendLayout();
            this.pathPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.refreshButton)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.upButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.forwardButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backButton)).BeginInit();
            this.directoryContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolBar
            // 
            this.toolBar.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolTip;
            this.toolBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewDropDownButton});
            this.toolBar.Location = new System.Drawing.Point(0, 0);
            this.toolBar.Name = "toolBar";
            this.toolBar.Size = new System.Drawing.Size(800, 25);
            this.toolBar.TabIndex = 0;
            this.toolBar.Text = "ToolBar";
            // 
            // viewDropDownButton
            // 
            this.viewDropDownButton.AccessibleName = "View";
            this.viewDropDownButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.viewDropDownButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listViewButton,
            this.smallIconViewButton,
            this.tileViewButton,
            this.detailsViewButton});
            this.viewDropDownButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.viewDropDownButton.Name = "viewDropDownButton";
            this.viewDropDownButton.Size = new System.Drawing.Size(45, 22);
            this.viewDropDownButton.Text = "View";
            this.viewDropDownButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            // 
            // listViewButton
            // 
            this.listViewButton.Name = "listViewButton";
            this.listViewButton.Size = new System.Drawing.Size(129, 22);
            this.listViewButton.Text = "List view";
            this.listViewButton.ToolTipText = "Display list view";
            // 
            // smallIconViewButton
            // 
            this.smallIconViewButton.Name = "smallIconViewButton";
            this.smallIconViewButton.Size = new System.Drawing.Size(129, 22);
            this.smallIconViewButton.Text = "Small icon";
            this.smallIconViewButton.ToolTipText = "Display small icon list";
            // 
            // tileViewButton
            // 
            this.tileViewButton.Name = "tileViewButton";
            this.tileViewButton.Size = new System.Drawing.Size(129, 22);
            this.tileViewButton.Text = "Tile";
            this.tileViewButton.ToolTipText = "Display tile list";
            // 
            // detailsViewButton
            // 
            this.detailsViewButton.Name = "detailsViewButton";
            this.detailsViewButton.Size = new System.Drawing.Size(129, 22);
            this.detailsViewButton.Text = "Details";
            this.detailsViewButton.ToolTipText = "Display details list";
            // 
            // contentPanel
            // 
            this.contentPanel.AutoSize = true;
            this.contentPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.contentPanel.Controls.Add(this.fileViewSplitContainer);
            this.contentPanel.Controls.Add(this.pathPanel);
            this.contentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentPanel.Location = new System.Drawing.Point(0, 25);
            this.contentPanel.Margin = new System.Windows.Forms.Padding(5);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.contentPanel.Size = new System.Drawing.Size(800, 425);
            this.contentPanel.TabIndex = 8;
            // 
            // fileViewSplitContainer
            // 
            this.fileViewSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fileViewSplitContainer.Location = new System.Drawing.Point(0, 31);
            this.fileViewSplitContainer.Name = "fileViewSplitContainer";
            this.fileViewSplitContainer.Size = new System.Drawing.Size(800, 394);
            this.fileViewSplitContainer.SplitterDistance = 266;
            this.fileViewSplitContainer.TabIndex = 8;
            // 
            // pathPanel
            // 
            this.pathPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pathPanel.Controls.Add(this.panel2);
            this.pathPanel.Controls.Add(this.panel1);
            this.pathPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.pathPanel.Location = new System.Drawing.Point(0, 5);
            this.pathPanel.Name = "pathPanel";
            this.pathPanel.Size = new System.Drawing.Size(800, 26);
            this.pathPanel.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pathBar);
            this.panel2.Controls.Add(this.refreshButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(82, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(716, 24);
            this.panel2.TabIndex = 6;
            // 
            // pathBar
            // 
            this.pathBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pathBar.Location = new System.Drawing.Point(0, 0);
            this.pathBar.Name = "pathBar";
            this.pathBar.Size = new System.Drawing.Size(685, 23);
            this.pathBar.TabIndex = 0;
            // 
            // refreshButton
            // 
            this.refreshButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.refreshButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.refreshButton.Image = global::FileManager.Properties.Resources.icons8_rotate_24;
            this.refreshButton.Location = new System.Drawing.Point(685, 0);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(31, 24);
            this.refreshButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.refreshButton.TabIndex = 14;
            this.refreshButton.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.upButton);
            this.panel1.Controls.Add(this.forwardButton);
            this.panel1.Controls.Add(this.backButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(82, 24);
            this.panel1.TabIndex = 5;
            // 
            // upButton
            // 
            this.upButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.upButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.upButton.Image = global::FileManager.Properties.Resources.icons8_up_24;
            this.upButton.Location = new System.Drawing.Point(52, 0);
            this.upButton.Name = "upButton";
            this.upButton.Size = new System.Drawing.Size(30, 24);
            this.upButton.TabIndex = 14;
            this.upButton.TabStop = false;
            // 
            // forwardButton
            // 
            this.forwardButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.forwardButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.forwardButton.Image = global::FileManager.Properties.Resources.icons8_right_24;
            this.forwardButton.Location = new System.Drawing.Point(26, 0);
            this.forwardButton.Name = "forwardButton";
            this.forwardButton.Size = new System.Drawing.Size(26, 24);
            this.forwardButton.TabIndex = 12;
            this.forwardButton.TabStop = false;
            // 
            // backButton
            // 
            this.backButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.backButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.backButton.Image = global::FileManager.Properties.Resources.icons8_left_24;
            this.backButton.Location = new System.Drawing.Point(0, 0);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(26, 24);
            this.backButton.TabIndex = 11;
            this.backButton.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.AutoSize = true;
            this.panel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(0, 24);
            this.panel3.TabIndex = 3;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // fileContextMenu
            // 
            this.fileContextMenu.AccessibleName = "";
            this.fileContextMenu.Name = "fileContextMenu";
            this.fileContextMenu.Size = new System.Drawing.Size(61, 4);
            // 
            // directoryContextMenu
            // 
            this.directoryContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.open,
            this.openInNewWindow});
            this.directoryContextMenu.Name = "directoryContextMenu";
            this.directoryContextMenu.Size = new System.Drawing.Size(187, 48);
            // 
            // open
            // 
            this.open.Name = "open";
            this.open.Size = new System.Drawing.Size(186, 22);
            this.open.Text = "Open folder";
            // 
            // openInNewWindow
            // 
            this.openInNewWindow.Name = "openInNewWindow";
            this.openInNewWindow.Size = new System.Drawing.Size(186, 22);
            this.openInNewWindow.Text = "Open in new window";
            // 
            // FileManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.contentPanel);
            this.Controls.Add(this.toolBar);
            this.Name = "FileManagerForm";
            this.Text = "FileManager";
            this.toolBar.ResumeLayout(false);
            this.toolBar.PerformLayout();
            this.contentPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fileViewSplitContainer)).EndInit();
            this.fileViewSplitContainer.ResumeLayout(false);
            this.pathPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.refreshButton)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.upButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.forwardButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backButton)).EndInit();
            this.directoryContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolBar;
        private System.Windows.Forms.ToolStripDropDownButton viewDropDownButton;
        private System.Windows.Forms.Panel contentPanel;
        private System.Windows.Forms.SplitContainer fileViewSplitContainer;
        private System.Windows.Forms.Panel pathPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox pathBar;
        private System.Windows.Forms.PictureBox backButton;
        private System.Windows.Forms.PictureBox forwardButton;
        private System.Windows.Forms.PictureBox upButton;
        private System.Windows.Forms.PictureBox refreshButton;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolStripMenuItem listViewButton;
        private System.Windows.Forms.ToolStripMenuItem detailsViewButton;
        private System.Windows.Forms.ToolStripMenuItem smallIconViewButton;
        private System.Windows.Forms.ToolStripMenuItem tileViewButton;
        private System.Windows.Forms.ToolStripMenuItem open;
        private System.Windows.Forms.ToolStripMenuItem openInNewWindow;
        internal System.Windows.Forms.ContextMenuStrip fileContextMenu;
        internal System.Windows.Forms.ContextMenuStrip directoryContextMenu;
    }

    
}

