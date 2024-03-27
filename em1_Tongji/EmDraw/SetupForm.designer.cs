namespace EmDraw
{
    partial class setupForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(setupForm));
            this.labelFN = new System.Windows.Forms.Label();
            this.labelStartF = new System.Windows.Forms.Label();
            this.labelStopF = new System.Windows.Forms.Label();
            this.labelFile = new System.Windows.Forms.Label();
            this.textBoxFN = new System.Windows.Forms.TextBox();
            this.textBoxStartF = new System.Windows.Forms.TextBox();
            this.textBoxStopF = new System.Windows.Forms.TextBox();
            this.textBoxFile = new System.Windows.Forms.TextBox();
            this.groupBoxTC = new System.Windows.Forms.GroupBox();
            this.radioButtonTC2 = new System.Windows.Forms.RadioButton();
            this.radioButtonTC1 = new System.Windows.Forms.RadioButton();
            this.buttonDone = new System.Windows.Forms.Button();
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.groupBoxIF = new System.Windows.Forms.GroupBox();
            this.radioButtonIF3 = new System.Windows.Forms.RadioButton();
            this.radioButtonIF2 = new System.Windows.Forms.RadioButton();
            this.radioButtonIF1 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBoxTC.SuspendLayout();
            this.groupBoxIF.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelFN
            // 
            this.labelFN.AutoSize = true;
            this.labelFN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFN.Location = new System.Drawing.Point(12, 14);
            this.labelFN.Name = "labelFN";
            this.labelFN.Size = new System.Drawing.Size(110, 13);
            this.labelFN.TabIndex = 0;
            this.labelFN.Text = "Frequncy Number:";
            // 
            // labelStartF
            // 
            this.labelStartF.AutoSize = true;
            this.labelStartF.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStartF.Location = new System.Drawing.Point(12, 44);
            this.labelStartF.Name = "labelStartF";
            this.labelStartF.Size = new System.Drawing.Size(94, 13);
            this.labelStartF.TabIndex = 1;
            this.labelStartF.Text = "Start Freguncy:";
            // 
            // labelStopF
            // 
            this.labelStopF.AutoSize = true;
            this.labelStopF.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStopF.Location = new System.Drawing.Point(262, 44);
            this.labelStopF.Name = "labelStopF";
            this.labelStopF.Size = new System.Drawing.Size(93, 13);
            this.labelStopF.TabIndex = 2;
            this.labelStopF.Text = "Stop Frequncy:";
            // 
            // labelFile
            // 
            this.labelFile.AutoSize = true;
            this.labelFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFile.Location = new System.Drawing.Point(12, 148);
            this.labelFile.Name = "labelFile";
            this.labelFile.Size = new System.Drawing.Size(98, 13);
            this.labelFile.TabIndex = 4;
            this.labelFile.Text = "Data File Name:";
            // 
            // textBoxFN
            // 
            this.textBoxFN.Location = new System.Drawing.Point(129, 11);
            this.textBoxFN.Name = "textBoxFN";
            this.textBoxFN.Size = new System.Drawing.Size(81, 20);
            this.textBoxFN.TabIndex = 5;
            this.textBoxFN.Text = "50";
            // 
            // textBoxStartF
            // 
            this.textBoxStartF.Location = new System.Drawing.Point(129, 44);
            this.textBoxStartF.Name = "textBoxStartF";
            this.textBoxStartF.Size = new System.Drawing.Size(81, 20);
            this.textBoxStartF.TabIndex = 6;
            this.textBoxStartF.Text = "1e8";
            // 
            // textBoxStopF
            // 
            this.textBoxStopF.Location = new System.Drawing.Point(387, 44);
            this.textBoxStopF.Name = "textBoxStopF";
            this.textBoxStopF.Size = new System.Drawing.Size(82, 20);
            this.textBoxStopF.TabIndex = 7;
            this.textBoxStopF.Text = "1e9";
            // 
            // textBoxFile
            // 
            this.textBoxFile.Location = new System.Drawing.Point(116, 145);
            this.textBoxFile.Name = "textBoxFile";
            this.textBoxFile.Size = new System.Drawing.Size(151, 20);
            this.textBoxFile.TabIndex = 9;
            this.textBoxFile.Text = "test01.dat";
            // 
            // groupBoxTC
            // 
            this.groupBoxTC.Controls.Add(this.radioButtonTC2);
            this.groupBoxTC.Controls.Add(this.radioButtonTC1);
            this.groupBoxTC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxTC.Location = new System.Drawing.Point(234, 79);
            this.groupBoxTC.Name = "groupBoxTC";
            this.groupBoxTC.Size = new System.Drawing.Size(121, 51);
            this.groupBoxTC.TabIndex = 10;
            this.groupBoxTC.TabStop = false;
            this.groupBoxTC.Text = "Test Channel";
            // 
            // radioButtonTC2
            // 
            this.radioButtonTC2.AutoSize = true;
            this.radioButtonTC2.Checked = true;
            this.radioButtonTC2.Location = new System.Drawing.Point(67, 16);
            this.radioButtonTC2.Name = "radioButtonTC2";
            this.radioButtonTC2.Size = new System.Drawing.Size(35, 14);
            this.radioButtonTC2.TabIndex = 1;
            this.radioButtonTC2.TabStop = true;
            this.radioButtonTC2.Text = "S21";
            this.radioButtonTC2.UseVisualStyleBackColor = true;
            // 
            // radioButtonTC1
            // 
            this.radioButtonTC1.AutoSize = true;
            this.radioButtonTC1.Location = new System.Drawing.Point(6, 17);
            this.radioButtonTC1.Name = "radioButtonTC1";
            this.radioButtonTC1.Size = new System.Drawing.Size(35, 14);
            this.radioButtonTC1.TabIndex = 0;
            this.radioButtonTC1.Text = "S11";
            this.radioButtonTC1.UseVisualStyleBackColor = true;
            // 
            // buttonDone
            // 
            this.buttonDone.Location = new System.Drawing.Point(394, 92);
            this.buttonDone.Name = "buttonDone";
            this.buttonDone.Size = new System.Drawing.Size(75, 25);
            this.buttonDone.TabIndex = 11;
            this.buttonDone.Text = "Done";
            this.buttonDone.UseVisualStyleBackColor = true;
            this.buttonDone.Click += new System.EventHandler(this.buttonDone_Click);
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.Location = new System.Drawing.Point(280, 142);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(75, 25);
            this.buttonBrowse.TabIndex = 12;
            this.buttonBrowse.Text = "Browse";
            this.buttonBrowse.UseVisualStyleBackColor = true;
            this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(394, 142);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 25);
            this.buttonClose.TabIndex = 13;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // groupBoxIF
            // 
            this.groupBoxIF.Controls.Add(this.radioButtonIF3);
            this.groupBoxIF.Controls.Add(this.radioButtonIF2);
            this.groupBoxIF.Controls.Add(this.radioButtonIF1);
            this.groupBoxIF.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxIF.Location = new System.Drawing.Point(11, 79);
            this.groupBoxIF.Name = "groupBoxIF";
            this.groupBoxIF.Size = new System.Drawing.Size(210, 51);
            this.groupBoxIF.TabIndex = 14;
            this.groupBoxIF.TabStop = false;
            this.groupBoxIF.Text = "IF Band Wide (Hz)";
            // 
            // radioButtonIF3
            // 
            this.radioButtonIF3.AutoSize = true;
            this.radioButtonIF3.Checked = true;
            this.radioButtonIF3.Location = new System.Drawing.Point(150, 19);
            this.radioButtonIF3.Name = "radioButtonIF3";
            this.radioButtonIF3.Size = new System.Drawing.Size(40, 14);
            this.radioButtonIF3.TabIndex = 15;
            this.radioButtonIF3.TabStop = true;
            this.radioButtonIF3.Text = "3000";
            this.radioButtonIF3.UseVisualStyleBackColor = true;
            // 
            // radioButtonIF2
            // 
            this.radioButtonIF2.AutoSize = true;
            this.radioButtonIF2.Location = new System.Drawing.Point(74, 19);
            this.radioButtonIF2.Name = "radioButtonIF2";
            this.radioButtonIF2.Size = new System.Drawing.Size(40, 14);
            this.radioButtonIF2.TabIndex = 1;
            this.radioButtonIF2.Text = "1000";
            this.radioButtonIF2.UseVisualStyleBackColor = true;
            // 
            // radioButtonIF1
            // 
            this.radioButtonIF1.AutoSize = true;
            this.radioButtonIF1.Location = new System.Drawing.Point(9, 21);
            this.radioButtonIF1.Name = "radioButtonIF1";
            this.radioButtonIF1.Size = new System.Drawing.Size(34, 14);
            this.radioButtonIF1.TabIndex = 0;
            this.radioButtonIF1.Text = "300";
            this.radioButtonIF1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 212);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Cable length";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(129, 208);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(81, 20);
            this.textBox1.TabIndex = 16;
            this.textBox1.Text = "50";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(431, 228);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(62, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // setupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 253);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBoxIF);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonBrowse);
            this.Controls.Add(this.buttonDone);
            this.Controls.Add(this.groupBoxTC);
            this.Controls.Add(this.textBoxFile);
            this.Controls.Add(this.textBoxStopF);
            this.Controls.Add(this.textBoxStartF);
            this.Controls.Add(this.textBoxFN);
            this.Controls.Add(this.labelFile);
            this.Controls.Add(this.labelStopF);
            this.Controls.Add(this.labelStartF);
            this.Controls.Add(this.labelFN);
            this.Name = "setupForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Parameter Setup";
            this.groupBoxTC.ResumeLayout(false);
            this.groupBoxTC.PerformLayout();
            this.groupBoxIF.ResumeLayout(false);
            this.groupBoxIF.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFN;
        private System.Windows.Forms.Label labelStartF;
        private System.Windows.Forms.Label labelStopF;
        private System.Windows.Forms.Label labelFile;
        private System.Windows.Forms.TextBox textBoxFN;
        private System.Windows.Forms.TextBox textBoxStartF;
        private System.Windows.Forms.TextBox textBoxStopF;
        private System.Windows.Forms.TextBox textBoxFile;
        private System.Windows.Forms.GroupBox groupBoxTC;
        private System.Windows.Forms.RadioButton radioButtonTC2;
        private System.Windows.Forms.RadioButton radioButtonTC1;
        private System.Windows.Forms.Button buttonDone;
        private System.Windows.Forms.Button buttonBrowse;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.GroupBox groupBoxIF;
        private System.Windows.Forms.RadioButton radioButtonIF3;
        private System.Windows.Forms.RadioButton radioButtonIF2;
        private System.Windows.Forms.RadioButton radioButtonIF1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}