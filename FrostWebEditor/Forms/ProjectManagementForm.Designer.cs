namespace FrostWebEditor
{
    partial class ProjectManagementForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProjectManagementForm));
            this.label1 = new System.Windows.Forms.Label();
            this.projectsView = new System.Windows.Forms.FlowLayoutPanel();
            this.close = new System.Windows.Forms.Button();
            this.newproject = new System.Windows.Forms.Button();
            this.loadproject = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Frost Web Editor";
            // 
            // projectsView
            // 
            this.projectsView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.projectsView.BackColor = System.Drawing.Color.Transparent;
            this.projectsView.Location = new System.Drawing.Point(18, 43);
            this.projectsView.Name = "projectsView";
            this.projectsView.Size = new System.Drawing.Size(770, 395);
            this.projectsView.TabIndex = 1;
            // 
            // close
            // 
            this.close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.close.BackColor = System.Drawing.Color.Transparent;
            this.close.FlatAppearance.BorderSize = 0;
            this.close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close.Location = new System.Drawing.Point(762, 9);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(26, 23);
            this.close.TabIndex = 2;
            this.close.Text = "X";
            this.close.UseVisualStyleBackColor = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // newproject
            // 
            this.newproject.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.newproject.BackColor = System.Drawing.Color.Gray;
            this.newproject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newproject.Location = new System.Drawing.Point(236, 18);
            this.newproject.Name = "newproject";
            this.newproject.Size = new System.Drawing.Size(77, 23);
            this.newproject.TabIndex = 3;
            this.newproject.Text = "New Project";
            this.newproject.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.newproject.UseVisualStyleBackColor = false;
            this.newproject.Click += new System.EventHandler(this.newproject_Click);
            // 
            // loadproject
            // 
            this.loadproject.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.loadproject.BackColor = System.Drawing.Color.Gray;
            this.loadproject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loadproject.Location = new System.Drawing.Point(319, 18);
            this.loadproject.Name = "loadproject";
            this.loadproject.Size = new System.Drawing.Size(77, 23);
            this.loadproject.TabIndex = 4;
            this.loadproject.Text = "Load Project";
            this.loadproject.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.loadproject.UseVisualStyleBackColor = false;
            // 
            // ProjectManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.loadproject);
            this.Controls.Add(this.newproject);
            this.Controls.Add(this.close);
            this.Controls.Add(this.projectsView);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProjectManagement";
            this.Text = "Frost Web Editor - Project Management";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel projectsView;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Button newproject;
        private System.Windows.Forms.Button loadproject;
    }
}

