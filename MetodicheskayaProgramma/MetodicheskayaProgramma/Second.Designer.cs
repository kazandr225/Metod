
namespace MetodicheskayaProgramma
{
    partial class Second
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
            this.NextBtn_Second = new System.Windows.Forms.Button();
            this.ExitBtn_Second = new System.Windows.Forms.Button();
            this.BackBtn_Second = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.RightBtn_Second = new System.Windows.Forms.Button();
            this.LeftBtn_Second = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // NextBtn_Second
            // 
            this.NextBtn_Second.Location = new System.Drawing.Point(788, 462);
            this.NextBtn_Second.Name = "NextBtn_Second";
            this.NextBtn_Second.Size = new System.Drawing.Size(82, 29);
            this.NextBtn_Second.TabIndex = 1;
            this.NextBtn_Second.Text = "Далее";
            this.NextBtn_Second.UseVisualStyleBackColor = true;
            this.NextBtn_Second.Click += new System.EventHandler(this.NextBtn_Second_Click);
            // 
            // ExitBtn_Second
            // 
            this.ExitBtn_Second.Location = new System.Drawing.Point(788, 12);
            this.ExitBtn_Second.Name = "ExitBtn_Second";
            this.ExitBtn_Second.Size = new System.Drawing.Size(82, 29);
            this.ExitBtn_Second.TabIndex = 2;
            this.ExitBtn_Second.Text = "Выход";
            this.ExitBtn_Second.UseVisualStyleBackColor = true;
            this.ExitBtn_Second.Click += new System.EventHandler(this.ExitBtn_Second_Click);
            // 
            // BackBtn_Second
            // 
            this.BackBtn_Second.Location = new System.Drawing.Point(12, 12);
            this.BackBtn_Second.Name = "BackBtn_Second";
            this.BackBtn_Second.Size = new System.Drawing.Size(82, 29);
            this.BackBtn_Second.TabIndex = 1;
            this.BackBtn_Second.Text = "Назад";
            this.BackBtn_Second.UseVisualStyleBackColor = true;
            this.BackBtn_Second.Click += new System.EventHandler(this.BackBtn_Second_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(153, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(593, 379);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // RightBtn_Second
            // 
            this.RightBtn_Second.Location = new System.Drawing.Point(470, 397);
            this.RightBtn_Second.Name = "RightBtn_Second";
            this.RightBtn_Second.Size = new System.Drawing.Size(67, 31);
            this.RightBtn_Second.TabIndex = 4;
            this.RightBtn_Second.Text = "=>";
            this.RightBtn_Second.UseVisualStyleBackColor = true;
            this.RightBtn_Second.Click += new System.EventHandler(this.RightBtn_Second_Click);
            // 
            // LeftBtn_Second
            // 
            this.LeftBtn_Second.Location = new System.Drawing.Point(389, 397);
            this.LeftBtn_Second.Name = "LeftBtn_Second";
            this.LeftBtn_Second.Size = new System.Drawing.Size(67, 31);
            this.LeftBtn_Second.TabIndex = 4;
            this.LeftBtn_Second.Text = "<=";
            this.LeftBtn_Second.UseVisualStyleBackColor = true;
            this.LeftBtn_Second.Click += new System.EventHandler(this.LeftBtn_Second_Click);
            // 
            // Second
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 503);
            this.Controls.Add(this.LeftBtn_Second);
            this.Controls.Add(this.RightBtn_Second);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BackBtn_Second);
            this.Controls.Add(this.NextBtn_Second);
            this.Controls.Add(this.ExitBtn_Second);
            this.Name = "Second";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Теоритический блок";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button NextBtn_Second;
        private System.Windows.Forms.Button ExitBtn_Second;
        private System.Windows.Forms.Button BackBtn_Second;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button RightBtn_Second;
        private System.Windows.Forms.Button LeftBtn_Second;
    }
}