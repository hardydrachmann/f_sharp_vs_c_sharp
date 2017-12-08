namespace f_sharp_vs_c_sharp
{
    partial class GUI
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
            this.lbl_cLogic = new System.Windows.Forms.Label();
            this.lbl_fLogic = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_cLogic
            // 
            this.lbl_cLogic.AutoSize = true;
            this.lbl_cLogic.Location = new System.Drawing.Point(13, 13);
            this.lbl_cLogic.Name = "lbl_cLogic";
            this.lbl_cLogic.Size = new System.Drawing.Size(46, 17);
            this.lbl_cLogic.TabIndex = 0;
            this.lbl_cLogic.Text = "label1";
            // 
            // lbl_fLogic
            // 
            this.lbl_fLogic.AutoSize = true;
            this.lbl_fLogic.Location = new System.Drawing.Point(13, 34);
            this.lbl_fLogic.Name = "lbl_fLogic";
            this.lbl_fLogic.Size = new System.Drawing.Size(46, 17);
            this.lbl_fLogic.TabIndex = 1;
            this.lbl_fLogic.Text = "label2";
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.lbl_fLogic);
            this.Controls.Add(this.lbl_cLogic);
            this.Name = "GUI";
            this.Text = "GUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_cLogic;
        private System.Windows.Forms.Label lbl_fLogic;
    }
}