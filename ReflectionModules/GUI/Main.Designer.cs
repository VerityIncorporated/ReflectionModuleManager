
namespace ReflectionModules.GUI
{
    partial class Main
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
            this.categoryPanel = new System.Windows.Forms.Panel();
            this.modulesPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.derivedclassesLabel = new System.Windows.Forms.Label();
            this.derivedClassesPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // categoryPanel
            // 
            this.categoryPanel.Location = new System.Drawing.Point(17, 37);
            this.categoryPanel.Name = "categoryPanel";
            this.categoryPanel.Size = new System.Drawing.Size(192, 259);
            this.categoryPanel.TabIndex = 0;
            // 
            // modulesPanel
            // 
            this.modulesPanel.Location = new System.Drawing.Point(227, 37);
            this.modulesPanel.Name = "modulesPanel";
            this.modulesPanel.Size = new System.Drawing.Size(192, 259);
            this.modulesPanel.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Categories";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(300, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Modules";
            // 
            // derivedclassesLabel
            // 
            this.derivedclassesLabel.AutoSize = true;
            this.derivedclassesLabel.Location = new System.Drawing.Point(150, 311);
            this.derivedclassesLabel.Name = "derivedclassesLabel";
            this.derivedclassesLabel.Size = new System.Drawing.Size(136, 13);
            this.derivedclassesLabel.TabIndex = 5;
            this.derivedclassesLabel.Text = "Not Active Derived Classes";
            // 
            // derivedClassesPanel
            // 
            this.derivedClassesPanel.Location = new System.Drawing.Point(122, 328);
            this.derivedClassesPanel.Name = "derivedClassesPanel";
            this.derivedClassesPanel.Size = new System.Drawing.Size(192, 259);
            this.derivedClassesPanel.TabIndex = 4;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 603);
            this.Controls.Add(this.derivedclassesLabel);
            this.Controls.Add(this.derivedClassesPanel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.modulesPanel);
            this.Controls.Add(this.categoryPanel);
            this.Name = "Main";
            this.Text = "Reflection Modules GUI";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel categoryPanel;
        private System.Windows.Forms.Panel modulesPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label derivedclassesLabel;
        private System.Windows.Forms.Panel derivedClassesPanel;
    }
}