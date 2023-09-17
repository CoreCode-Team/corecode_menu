
namespace corecode_menu.Forms
{
    partial class FormProduct
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
            this.pictureButtonApp = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureButtonApp)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureButtonApp
            // 
            this.pictureButtonApp.BackColor = System.Drawing.Color.Navy;
            this.pictureButtonApp.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureButtonApp.Location = new System.Drawing.Point(0, 0);
            this.pictureButtonApp.Name = "pictureButtonApp";
            this.pictureButtonApp.Size = new System.Drawing.Size(836, 58);
            this.pictureButtonApp.TabIndex = 0;
            this.pictureButtonApp.TabStop = false;
            // 
            // FormProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(836, 489);
            this.Controls.Add(this.pictureButtonApp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormProduct";
            this.Text = "Product";
            ((System.ComponentModel.ISupportInitialize)(this.pictureButtonApp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureButtonApp;
    }
}