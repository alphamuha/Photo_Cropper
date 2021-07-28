
namespace Photo_Cropper
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
            this.btnUploadPhoto = new System.Windows.Forms.Button();
            this.image1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.image1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUploadPhoto
            // 
            this.btnUploadPhoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnUploadPhoto.ForeColor = System.Drawing.Color.Black;
            this.btnUploadPhoto.Location = new System.Drawing.Point(317, 171);
            this.btnUploadPhoto.Name = "btnUploadPhoto";
            this.btnUploadPhoto.Size = new System.Drawing.Size(124, 60);
            this.btnUploadPhoto.TabIndex = 0;
            this.btnUploadPhoto.Text = "Upload Photo";
            this.btnUploadPhoto.UseVisualStyleBackColor = true;
            this.btnUploadPhoto.Click += new System.EventHandler(this.btnUploadPhoto_Click);
            // 
            // image1
            // 
            this.image1.Location = new System.Drawing.Point(145, 84);
            this.image1.Name = "image1";
            this.image1.Size = new System.Drawing.Size(469, 247);
            this.image1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.image1.TabIndex = 1;
            this.image1.TabStop = false;
            this.image1.Paint += new System.Windows.Forms.PaintEventHandler(this.image1_Paint);
            this.image1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.image1_MouseDown);
            this.image1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.image1_MouseMove);
            this.image1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.image1_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.image1);
            this.Controls.Add(this.btnUploadPhoto);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.image1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUploadPhoto;
        private System.Windows.Forms.PictureBox image1;
    }
}

