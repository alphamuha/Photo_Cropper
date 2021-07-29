
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
            this.TargetImg = new System.Windows.Forms.PictureBox();
            this.btnSaveImage = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.image1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TargetImg)).BeginInit();
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
            this.image1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.image1.TabIndex = 1;
            this.image1.TabStop = false;
            this.image1.Paint += new System.Windows.Forms.PaintEventHandler(this.image1_Paint);
            this.image1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.image1_MouseDown);
            this.image1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.image1_MouseMove);
            this.image1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.image1_MouseUp);
            // 
            // TargetImg
            // 
            this.TargetImg.Location = new System.Drawing.Point(145, 84);
            this.TargetImg.Name = "TargetImg";
            this.TargetImg.Size = new System.Drawing.Size(469, 247);
            this.TargetImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.TargetImg.TabIndex = 2;
            this.TargetImg.TabStop = false;
            // 
            // btnSaveImage
            // 
            this.btnSaveImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSaveImage.ForeColor = System.Drawing.Color.Black;
            this.btnSaveImage.Location = new System.Drawing.Point(317, 337);
            this.btnSaveImage.Name = "btnSaveImage";
            this.btnSaveImage.Size = new System.Drawing.Size(133, 44);
            this.btnSaveImage.TabIndex = 3;
            this.btnSaveImage.Text = "Save Image";
            this.btnSaveImage.UseVisualStyleBackColor = true;
            this.btnSaveImage.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSaveImage);
            this.Controls.Add(this.TargetImg);
            this.Controls.Add(this.image1);
            this.Controls.Add(this.btnUploadPhoto);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.image1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TargetImg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUploadPhoto;
        private System.Windows.Forms.PictureBox image1;
        private System.Windows.Forms.PictureBox TargetImg;
        private System.Windows.Forms.Button btnSaveImage;
    }
}

