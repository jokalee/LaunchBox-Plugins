﻿namespace SappPasRoot.Graph
{
    partial class S_Platform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(S_Platform));
            this.label1 = new System.Windows.Forms.Label();
            this.lvPlatforms = new System.Windows.Forms.ListView();
            this.colPlatformName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPath = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // lvPlatforms
            // 
            resources.ApplyResources(this.lvPlatforms, "lvPlatforms");
            this.lvPlatforms.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colPlatformName,
            this.colPath});
            this.lvPlatforms.FullRowSelect = true;
            this.lvPlatforms.MultiSelect = false;
            this.lvPlatforms.Name = "lvPlatforms";
            this.lvPlatforms.UseCompatibleStateImageBehavior = false;
            this.lvPlatforms.View = System.Windows.Forms.View.Details;
            this.lvPlatforms.SelectedIndexChanged += new System.EventHandler(this.lvPlatforms_SelectedIndexChanged);
            this.lvPlatforms.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lvPlatforms_MouseDoubleClick);
            // 
            // colPlatformName
            // 
            resources.ApplyResources(this.colPlatformName, "colPlatformName");
            // 
            // colPath
            // 
            resources.ApplyResources(this.colPath, "colPath");
            // 
            // S_Platform
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lvPlatforms);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "S_Platform";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lvPlatforms;
        private System.Windows.Forms.ColumnHeader colPlatformName;
        private System.Windows.Forms.ColumnHeader colPath;
    }
}