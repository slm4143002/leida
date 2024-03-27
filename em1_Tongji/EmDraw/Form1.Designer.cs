namespace EmDraw
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonDrawFromFile = new System.Windows.Forms.Button();
            this.textBoxUpper = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxLower = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxFlip = new System.Windows.Forms.TextBox();
            this.buttonCollect = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxWidth = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.labelTotalCount = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonDrawFromFile
            // 
            this.buttonDrawFromFile.Location = new System.Drawing.Point(810, 321);
            this.buttonDrawFromFile.Name = "buttonDrawFromFile";
            this.buttonDrawFromFile.Size = new System.Drawing.Size(114, 23);
            this.buttonDrawFromFile.TabIndex = 0;
            this.buttonDrawFromFile.Text = "Draw From File";
            this.buttonDrawFromFile.UseVisualStyleBackColor = true;
            this.buttonDrawFromFile.Click += new System.EventHandler(this.buttonDrawFromFile_Click);
            // 
            // textBoxUpper
            // 
            this.textBoxUpper.Location = new System.Drawing.Point(863, 162);
            this.textBoxUpper.Name = "textBoxUpper";
            this.textBoxUpper.Size = new System.Drawing.Size(61, 20);
            this.textBoxUpper.TabIndex = 1;
            this.textBoxUpper.Text = "0.6";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(790, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Upper Cutoff";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(790, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Lower Cutoff";
            // 
            // textBoxLower
            // 
            this.textBoxLower.Location = new System.Drawing.Point(863, 199);
            this.textBoxLower.Name = "textBoxLower";
            this.textBoxLower.Size = new System.Drawing.Size(61, 20);
            this.textBoxLower.TabIndex = 3;
            this.textBoxLower.Text = "0.4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(807, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Flip Line";
            // 
            // textBoxFlip
            // 
            this.textBoxFlip.Location = new System.Drawing.Point(863, 236);
            this.textBoxFlip.Name = "textBoxFlip";
            this.textBoxFlip.Size = new System.Drawing.Size(61, 20);
            this.textBoxFlip.TabIndex = 5;
            this.textBoxFlip.Text = "100";
            // 
            // buttonCollect
            // 
            this.buttonCollect.Location = new System.Drawing.Point(619, 324);
            this.buttonCollect.Name = "buttonCollect";
            this.buttonCollect.Size = new System.Drawing.Size(114, 23);
            this.buttonCollect.TabIndex = 7;
            this.buttonCollect.Text = "Start Collect";
            this.buttonCollect.UseVisualStyleBackColor = true;
            this.buttonCollect.Click += new System.EventHandler(this.buttonCollect_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(799, 275);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Line Width";
            // 
            // textBoxWidth
            // 
            this.textBoxWidth.Location = new System.Drawing.Point(863, 272);
            this.textBoxWidth.Name = "textBoxWidth";
            this.textBoxWidth.Size = new System.Drawing.Size(61, 20);
            this.textBoxWidth.TabIndex = 8;
            this.textBoxWidth.Text = "4";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(619, 369);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Stop Collect";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(810, 62);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Setup";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(769, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Total Data Count";
            // 
            // labelTotalCount
            // 
            this.labelTotalCount.AutoSize = true;
            this.labelTotalCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.labelTotalCount.Location = new System.Drawing.Point(884, 21);
            this.labelTotalCount.Name = "labelTotalCount";
            this.labelTotalCount.Size = new System.Drawing.Size(43, 13);
            this.labelTotalCount.TabIndex = 13;
            this.labelTotalCount.Text = "000000";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 514);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Depth(cm)";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(99, 514);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(61, 20);
            this.textBox1.TabIndex = 15;
            this.textBox1.Text = "200";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(877, 570);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(62, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 594);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.labelTotalCount);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxWidth);
            this.Controls.Add(this.buttonCollect);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxFlip);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxLower);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxUpper);
            this.Controls.Add(this.buttonDrawFromFile);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDrawFromFile;
        private System.Windows.Forms.TextBox textBoxUpper;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxLower;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxFlip;
        private System.Windows.Forms.Button buttonCollect;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxWidth;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelTotalCount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

