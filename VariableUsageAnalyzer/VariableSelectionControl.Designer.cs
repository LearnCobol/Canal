﻿namespace VariableUsageAnalyzer
{
    partial class VariableSelectionControl
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
        private void InitializeComponent()
        {
            this.VariableSelectionTreeView = new VariableUsageAnalyzer.VariableTreeView();
            this.SuspendLayout();
            // 
            // VariableSelectionTreeView
            // 
            this.VariableSelectionTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.VariableSelectionTreeView.Location = new System.Drawing.Point(6, 6);
            this.VariableSelectionTreeView.Name = "VariableSelectionTreeView";
            this.VariableSelectionTreeView.Size = new System.Drawing.Size(508, 646);
            this.VariableSelectionTreeView.TabIndex = 0;
            // 
            // VariableSelectionControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.VariableSelectionTreeView);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "VariableSelectionControl";
            this.Padding = new System.Windows.Forms.Padding(6);
            this.Size = new System.Drawing.Size(520, 658);
            this.ResumeLayout(false);

        }

        #endregion

        public VariableTreeView VariableSelectionTreeView;
    }
}
