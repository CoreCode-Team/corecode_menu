
namespace corecode_menu.Forms
{
    partial class FormMarketing
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
            this.pictureOnCoding = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureOnCoding)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureOnCoding
            // 
            this.pictureOnCoding.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureOnCoding.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureOnCoding.Image = global::corecode_menu.Properties.Resources.dc0d6a1e0f68161252236a1fbf0798ac;
            this.pictureOnCoding.Location = new System.Drawing.Point(0, 0);
            this.pictureOnCoding.Name = "pictureOnCoding";
            this.pictureOnCoding.Size = new System.Drawing.Size(800, 450);
            this.pictureOnCoding.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureOnCoding.TabIndex = 1;
            this.pictureOnCoding.TabStop = false;
            // 
            // FormMarketing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureOnCoding);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMarketing";
            this.Text = "Marketing";
            ((System.ComponentModel.ISupportInitialize)(this.pictureOnCoding)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureOnCoding;
    }
}