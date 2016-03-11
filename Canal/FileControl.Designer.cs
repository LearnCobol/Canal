﻿namespace Canal
{
    partial class FileControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        /// <param name="file"></param>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FileControl));
            this.treeView = new System.Windows.Forms.TreeView();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.searchWithRegEx = new System.Windows.Forms.CheckBox();
            this.ResolveCopysButton = new System.Windows.Forms.Button();
            this.TabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tocToolStrip = new System.Windows.Forms.ToolStrip();
            this.exportTocButton = new System.Windows.Forms.ToolStripButton();
            this.TocExpandAllButton = new System.Windows.Forms.ToolStripButton();
            this.TocCollapseAllButton = new System.Windows.Forms.ToolStripButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.performsToolStrip = new System.Windows.Forms.ToolStrip();
            this.performsCopyButton = new System.Windows.Forms.ToolStripButton();
            this.performsExpandAllButton = new System.Windows.Forms.ToolStripButton();
            this.performsCollapseAllButton = new System.Windows.Forms.ToolStripButton();
            this.performsTreeView = new System.Windows.Forms.TreeView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.variablesToolStrip = new System.Windows.Forms.ToolStrip();
            this.variablesCopyButton = new System.Windows.Forms.ToolStripButton();
            this.variablesExpandAllButton = new System.Windows.Forms.ToolStripButton();
            this.variablesCollapseAllButton = new System.Windows.Forms.ToolStripButton();
            this.variablesTreeView = new System.Windows.Forms.TreeView();
            this.proceduresTab = new System.Windows.Forms.TabPage();
            this.proceduresToolStrip = new System.Windows.Forms.ToolStrip();
            this.CopyProceduresButton = new System.Windows.Forms.ToolStripButton();
            this.proceduresExpandAllButton = new System.Windows.Forms.ToolStripButton();
            this.proceduresCollapseAllButton = new System.Windows.Forms.ToolStripButton();
            this.proceduresTreeView = new System.Windows.Forms.TreeView();
            this.codeBox = new Canal.CodeBox();
            this.TabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tocToolStrip.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.performsToolStrip.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.variablesToolStrip.SuspendLayout();
            this.proceduresTab.SuspendLayout();
            this.proceduresToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.codeBox)).BeginInit();
            this.SuspendLayout();
            // 
            // treeView
            // 
            this.treeView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treeView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.treeView.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeView.ItemHeight = 22;
            this.treeView.Location = new System.Drawing.Point(3, 30);
            this.treeView.Margin = new System.Windows.Forms.Padding(2);
            this.treeView.Name = "treeView";
            this.treeView.Size = new System.Drawing.Size(309, 496);
            this.treeView.TabIndex = 1;
            this.treeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView_AfterSelect);
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(3, 3);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(167, 20);
            this.searchBox.TabIndex = 2;
            this.searchBox.Text = "Search...";
            this.searchBox.WordWrap = false;
            this.searchBox.TextChanged += new System.EventHandler(this.seachBox_TextChanged);
            this.searchBox.Enter += new System.EventHandler(this.searchBox_Enter);
            this.searchBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.searchBox_KeyDown);
            this.searchBox.Leave += new System.EventHandler(this.searchBox_Leave);
            // 
            // searchWithRegEx
            // 
            this.searchWithRegEx.AutoSize = true;
            this.searchWithRegEx.Location = new System.Drawing.Point(177, 5);
            this.searchWithRegEx.Name = "searchWithRegEx";
            this.searchWithRegEx.Size = new System.Drawing.Size(58, 17);
            this.searchWithRegEx.TabIndex = 3;
            this.searchWithRegEx.Text = "RegEx";
            this.searchWithRegEx.UseVisualStyleBackColor = true;
            // 
            // ResolveCopysButton
            // 
            this.ResolveCopysButton.Location = new System.Drawing.Point(241, 0);
            this.ResolveCopysButton.Name = "ResolveCopysButton";
            this.ResolveCopysButton.Size = new System.Drawing.Size(92, 23);
            this.ResolveCopysButton.TabIndex = 4;
            this.ResolveCopysButton.Text = "Resolve COPYs";
            this.ResolveCopysButton.UseVisualStyleBackColor = true;
            this.ResolveCopysButton.Click += new System.EventHandler(this.ResolveCopysButton_Click);
            // 
            // TabControl
            // 
            this.TabControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TabControl.Controls.Add(this.tabPage1);
            this.TabControl.Controls.Add(this.tabPage2);
            this.TabControl.Controls.Add(this.tabPage3);
            this.TabControl.Controls.Add(this.proceduresTab);
            this.TabControl.Location = new System.Drawing.Point(501, 28);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(323, 555);
            this.TabControl.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tocToolStrip);
            this.tabPage1.Controls.Add(this.treeView);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(315, 529);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Table of Contents";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tocToolStrip
            // 
            this.tocToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tocToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportTocButton,
            this.TocExpandAllButton,
            this.TocCollapseAllButton});
            this.tocToolStrip.Location = new System.Drawing.Point(3, 3);
            this.tocToolStrip.Name = "tocToolStrip";
            this.tocToolStrip.Size = new System.Drawing.Size(309, 25);
            this.tocToolStrip.TabIndex = 2;
            this.tocToolStrip.Text = "toolStrip1";
            // 
            // exportTocButton
            // 
            this.exportTocButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.exportTocButton.Image = ((System.Drawing.Image)(resources.GetObject("exportTocButton.Image")));
            this.exportTocButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.exportTocButton.Name = "exportTocButton";
            this.exportTocButton.Size = new System.Drawing.Size(23, 22);
            this.exportTocButton.Text = "Copy";
            this.exportTocButton.Click += new System.EventHandler(this.ExportTocClick);
            // 
            // TocExpandAllButton
            // 
            this.TocExpandAllButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TocExpandAllButton.Image = ((System.Drawing.Image)(resources.GetObject("TocExpandAllButton.Image")));
            this.TocExpandAllButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TocExpandAllButton.Name = "TocExpandAllButton";
            this.TocExpandAllButton.Size = new System.Drawing.Size(23, 22);
            this.TocExpandAllButton.Text = "Expand all";
            this.TocExpandAllButton.Click += new System.EventHandler(this.TocExpandAllButton_Click);
            // 
            // TocCollapseAllButton
            // 
            this.TocCollapseAllButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TocCollapseAllButton.Image = ((System.Drawing.Image)(resources.GetObject("TocCollapseAllButton.Image")));
            this.TocCollapseAllButton.ImageTransparentColor = System.Drawing.Color.Black;
            this.TocCollapseAllButton.Name = "TocCollapseAllButton";
            this.TocCollapseAllButton.Size = new System.Drawing.Size(23, 22);
            this.TocCollapseAllButton.Text = "Collapse All";
            this.TocCollapseAllButton.Click += new System.EventHandler(this.TocCollapseAllButton_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.performsToolStrip);
            this.tabPage2.Controls.Add(this.performsTreeView);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(315, 529);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Performs";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // performsToolStrip
            // 
            this.performsToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.performsToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.performsCopyButton,
            this.performsExpandAllButton,
            this.performsCollapseAllButton});
            this.performsToolStrip.Location = new System.Drawing.Point(3, 3);
            this.performsToolStrip.Name = "performsToolStrip";
            this.performsToolStrip.Size = new System.Drawing.Size(309, 25);
            this.performsToolStrip.TabIndex = 3;
            this.performsToolStrip.Text = "toolStrip1";
            // 
            // performsCopyButton
            // 
            this.performsCopyButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.performsCopyButton.Image = ((System.Drawing.Image)(resources.GetObject("performsCopyButton.Image")));
            this.performsCopyButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.performsCopyButton.Name = "performsCopyButton";
            this.performsCopyButton.Size = new System.Drawing.Size(23, 22);
            this.performsCopyButton.Text = "Copy";
            this.performsCopyButton.Click += new System.EventHandler(this.performsCopyButton_Click);
            // 
            // performsExpandAllButton
            // 
            this.performsExpandAllButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.performsExpandAllButton.Image = ((System.Drawing.Image)(resources.GetObject("performsExpandAllButton.Image")));
            this.performsExpandAllButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.performsExpandAllButton.Name = "performsExpandAllButton";
            this.performsExpandAllButton.Size = new System.Drawing.Size(23, 22);
            this.performsExpandAllButton.Text = "Expand all";
            this.performsExpandAllButton.Click += new System.EventHandler(this.performsExpandAllButton_Click);
            // 
            // performsCollapseAllButton
            // 
            this.performsCollapseAllButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.performsCollapseAllButton.Image = ((System.Drawing.Image)(resources.GetObject("performsCollapseAllButton.Image")));
            this.performsCollapseAllButton.ImageTransparentColor = System.Drawing.Color.Black;
            this.performsCollapseAllButton.Name = "performsCollapseAllButton";
            this.performsCollapseAllButton.Size = new System.Drawing.Size(23, 22);
            this.performsCollapseAllButton.Text = "Collapse All";
            this.performsCollapseAllButton.Click += new System.EventHandler(this.performsCollapseAllButton_Click);
            // 
            // performsTreeView
            // 
            this.performsTreeView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.performsTreeView.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.performsTreeView.ItemHeight = 22;
            this.performsTreeView.Location = new System.Drawing.Point(3, 31);
            this.performsTreeView.Name = "performsTreeView";
            this.performsTreeView.Size = new System.Drawing.Size(309, 495);
            this.performsTreeView.TabIndex = 0;
            this.performsTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.performsTree_AfterSelect);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.variablesToolStrip);
            this.tabPage3.Controls.Add(this.variablesTreeView);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(315, 529);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Variables";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // variablesToolStrip
            // 
            this.variablesToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.variablesToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.variablesCopyButton,
            this.variablesExpandAllButton,
            this.variablesCollapseAllButton});
            this.variablesToolStrip.Location = new System.Drawing.Point(3, 3);
            this.variablesToolStrip.Name = "variablesToolStrip";
            this.variablesToolStrip.Size = new System.Drawing.Size(309, 25);
            this.variablesToolStrip.TabIndex = 3;
            this.variablesToolStrip.Text = "toolStrip1";
            // 
            // variablesCopyButton
            // 
            this.variablesCopyButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.variablesCopyButton.Image = ((System.Drawing.Image)(resources.GetObject("variablesCopyButton.Image")));
            this.variablesCopyButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.variablesCopyButton.Name = "variablesCopyButton";
            this.variablesCopyButton.Size = new System.Drawing.Size(23, 22);
            this.variablesCopyButton.Text = "Copy";
            this.variablesCopyButton.Click += new System.EventHandler(this.variablesCopyButton_Click);
            // 
            // variablesExpandAllButton
            // 
            this.variablesExpandAllButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.variablesExpandAllButton.Image = ((System.Drawing.Image)(resources.GetObject("variablesExpandAllButton.Image")));
            this.variablesExpandAllButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.variablesExpandAllButton.Name = "variablesExpandAllButton";
            this.variablesExpandAllButton.Size = new System.Drawing.Size(23, 22);
            this.variablesExpandAllButton.Text = "Expand all";
            this.variablesExpandAllButton.Click += new System.EventHandler(this.variablesExpandAllButton_Click);
            // 
            // variablesCollapseAllButton
            // 
            this.variablesCollapseAllButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.variablesCollapseAllButton.Image = ((System.Drawing.Image)(resources.GetObject("variablesCollapseAllButton.Image")));
            this.variablesCollapseAllButton.ImageTransparentColor = System.Drawing.Color.Black;
            this.variablesCollapseAllButton.Name = "variablesCollapseAllButton";
            this.variablesCollapseAllButton.Size = new System.Drawing.Size(23, 22);
            this.variablesCollapseAllButton.Text = "Collapse All";
            this.variablesCollapseAllButton.Click += new System.EventHandler(this.variablesCollapseAllButton_Click);
            // 
            // variablesTreeView
            // 
            this.variablesTreeView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.variablesTreeView.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.variablesTreeView.ItemHeight = 18;
            this.variablesTreeView.Location = new System.Drawing.Point(3, 31);
            this.variablesTreeView.Name = "variablesTreeView";
            this.variablesTreeView.Size = new System.Drawing.Size(309, 495);
            this.variablesTreeView.TabIndex = 0;
            this.variablesTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.variablesTreeView_AfterSelect);
            // 
            // proceduresTab
            // 
            this.proceduresTab.Controls.Add(this.proceduresToolStrip);
            this.proceduresTab.Controls.Add(this.proceduresTreeView);
            this.proceduresTab.Location = new System.Drawing.Point(4, 22);
            this.proceduresTab.Name = "proceduresTab";
            this.proceduresTab.Padding = new System.Windows.Forms.Padding(3);
            this.proceduresTab.Size = new System.Drawing.Size(315, 529);
            this.proceduresTab.TabIndex = 3;
            this.proceduresTab.Text = "Procedures";
            this.proceduresTab.UseVisualStyleBackColor = true;
            // 
            // proceduresToolStrip
            // 
            this.proceduresToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.proceduresToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CopyProceduresButton,
            this.proceduresExpandAllButton,
            this.proceduresCollapseAllButton});
            this.proceduresToolStrip.Location = new System.Drawing.Point(3, 3);
            this.proceduresToolStrip.Name = "proceduresToolStrip";
            this.proceduresToolStrip.Size = new System.Drawing.Size(309, 25);
            this.proceduresToolStrip.TabIndex = 1;
            this.proceduresToolStrip.Text = "toolStrip1";
            // 
            // CopyProceduresButton
            // 
            this.CopyProceduresButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.CopyProceduresButton.Image = ((System.Drawing.Image)(resources.GetObject("CopyProceduresButton.Image")));
            this.CopyProceduresButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CopyProceduresButton.Name = "CopyProceduresButton";
            this.CopyProceduresButton.Size = new System.Drawing.Size(23, 22);
            this.CopyProceduresButton.Text = "Copy";
            this.CopyProceduresButton.Click += new System.EventHandler(this.CopyProceduresClick);
            // 
            // proceduresExpandAllButton
            // 
            this.proceduresExpandAllButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.proceduresExpandAllButton.Image = ((System.Drawing.Image)(resources.GetObject("proceduresExpandAllButton.Image")));
            this.proceduresExpandAllButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.proceduresExpandAllButton.Name = "proceduresExpandAllButton";
            this.proceduresExpandAllButton.Size = new System.Drawing.Size(23, 22);
            this.proceduresExpandAllButton.Text = "Expand all";
            this.proceduresExpandAllButton.Click += new System.EventHandler(this.proceduresExpandAllButton_Click);
            // 
            // proceduresCollapseAllButton
            // 
            this.proceduresCollapseAllButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.proceduresCollapseAllButton.Image = ((System.Drawing.Image)(resources.GetObject("proceduresCollapseAllButton.Image")));
            this.proceduresCollapseAllButton.ImageTransparentColor = System.Drawing.Color.Black;
            this.proceduresCollapseAllButton.Name = "proceduresCollapseAllButton";
            this.proceduresCollapseAllButton.Size = new System.Drawing.Size(23, 22);
            this.proceduresCollapseAllButton.Text = "Collapse All";
            this.proceduresCollapseAllButton.Click += new System.EventHandler(this.proceduresCollapseAllButton_Click);
            // 
            // proceduresTreeView
            // 
            this.proceduresTreeView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.proceduresTreeView.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.proceduresTreeView.ItemHeight = 22;
            this.proceduresTreeView.Location = new System.Drawing.Point(3, 31);
            this.proceduresTreeView.Name = "proceduresTreeView";
            this.proceduresTreeView.Size = new System.Drawing.Size(309, 495);
            this.proceduresTreeView.TabIndex = 0;
            this.proceduresTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.proceduresTreeView_AfterSelect);
            // 
            // codeBox
            // 
            this.codeBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.codeBox.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.codeBox.AutoScrollMinSize = new System.Drawing.Size(25, 15);
            this.codeBox.BackBrush = null;
            this.codeBox.CharHeight = 15;
            this.codeBox.CharWidth = 7;
            this.codeBox.CobolFile = null;
            this.codeBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.codeBox.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.codeBox.Font = new System.Drawing.Font("Consolas", 9.75F);
            this.codeBox.Hotkeys = resources.GetString("codeBox.Hotkeys");
            this.codeBox.IsReplaceMode = false;
            this.codeBox.Location = new System.Drawing.Point(3, 28);
            this.codeBox.Margin = new System.Windows.Forms.Padding(2);
            this.codeBox.Name = "codeBox";
            this.codeBox.Paddings = new System.Windows.Forms.Padding(0);
            this.codeBox.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.codeBox.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("codeBox.ServiceColors")));
            this.codeBox.Size = new System.Drawing.Size(493, 553);
            this.codeBox.TabIndex = 0;
            this.codeBox.Zoom = 100;
            // 
            // FileControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TabControl);
            this.Controls.Add(this.ResolveCopysButton);
            this.Controls.Add(this.searchWithRegEx);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.codeBox);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FileControl";
            this.Size = new System.Drawing.Size(827, 583);
            this.TabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tocToolStrip.ResumeLayout(false);
            this.tocToolStrip.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.performsToolStrip.ResumeLayout(false);
            this.performsToolStrip.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.variablesToolStrip.ResumeLayout(false);
            this.variablesToolStrip.PerformLayout();
            this.proceduresTab.ResumeLayout(false);
            this.proceduresTab.PerformLayout();
            this.proceduresToolStrip.ResumeLayout(false);
            this.proceduresToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.codeBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TreeView treeView;
        private System.Windows.Forms.TextBox searchBox;
        private CodeBox codeBox;
        private System.Windows.Forms.CheckBox searchWithRegEx;
        private System.Windows.Forms.Button ResolveCopysButton;
        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TreeView performsTreeView;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TreeView variablesTreeView;
        private System.Windows.Forms.TabPage proceduresTab;
        private System.Windows.Forms.TreeView proceduresTreeView;
        private System.Windows.Forms.ToolStrip tocToolStrip;
        private System.Windows.Forms.ToolStripButton exportTocButton;
        private System.Windows.Forms.ToolStrip proceduresToolStrip;
        private System.Windows.Forms.ToolStripButton CopyProceduresButton;
        private System.Windows.Forms.ToolStripButton TocExpandAllButton;
        private System.Windows.Forms.ToolStripButton TocCollapseAllButton;
        private System.Windows.Forms.ToolStrip performsToolStrip;
        private System.Windows.Forms.ToolStripButton performsCopyButton;
        private System.Windows.Forms.ToolStripButton performsExpandAllButton;
        private System.Windows.Forms.ToolStripButton performsCollapseAllButton;
        private System.Windows.Forms.ToolStrip variablesToolStrip;
        private System.Windows.Forms.ToolStripButton variablesCopyButton;
        private System.Windows.Forms.ToolStripButton variablesExpandAllButton;
        private System.Windows.Forms.ToolStripButton variablesCollapseAllButton;
        private System.Windows.Forms.ToolStripButton proceduresExpandAllButton;
        private System.Windows.Forms.ToolStripButton proceduresCollapseAllButton;
    }
}
