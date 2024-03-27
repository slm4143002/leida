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
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.groupBoxTC.SuspendLayout();
            this.groupBoxIF.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelFN
            // 
            this.labelFN.AutoSize = true;
            this.labelFN.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFN.Location = new System.Drawing.Point(16, 16);
            this.labelFN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFN.Name = "labelFN";
            this.labelFN.Size = new System.Drawing.Size(52, 19);
            this.labelFN.TabIndex = 0;
            this.labelFN.Text = "频点数:";
            // 
            // labelStartF
            // 
            this.labelStartF.AutoSize = true;
            this.labelStartF.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStartF.Location = new System.Drawing.Point(16, 51);
            this.labelStartF.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelStartF.Name = "labelStartF";
            this.labelStartF.Size = new System.Drawing.Size(93, 19);
            this.labelStartF.TabIndex = 1;
            this.labelStartF.Text = "起始频率(Hz):";
            // 
            // labelStopF
            // 
            this.labelStopF.AutoSize = true;
            this.labelStopF.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStopF.Location = new System.Drawing.Point(349, 51);
            this.labelStopF.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelStopF.Name = "labelStopF";
            this.labelStopF.Size = new System.Drawing.Size(93, 19);
            this.labelStopF.TabIndex = 2;
            this.labelStopF.Text = "终止频率(Hz):";
            // 
            // labelFile
            // 
            this.labelFile.AutoSize = true;
            this.labelFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFile.Location = new System.Drawing.Point(16, 171);
            this.labelFile.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFile.Name = "labelFile";
            this.labelFile.Size = new System.Drawing.Size(58, 17);
            this.labelFile.TabIndex = 4;
            this.labelFile.Text = "文件名:";
            // 
            // textBoxFN
            // 
            this.textBoxFN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFN.Location = new System.Drawing.Point(172, 13);
            this.textBoxFN.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxFN.Name = "textBoxFN";
            this.textBoxFN.Size = new System.Drawing.Size(107, 23);
            this.textBoxFN.TabIndex = 5;
            this.textBoxFN.Text = "50";
            // 
            // textBoxStartF
            // 
            this.textBoxStartF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxStartF.Location = new System.Drawing.Point(172, 51);
            this.textBoxStartF.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxStartF.Name = "textBoxStartF";
            this.textBoxStartF.Size = new System.Drawing.Size(107, 30);
            this.textBoxStartF.TabIndex = 6;
            this.textBoxStartF.Text = "1e8";
            // 
            // textBoxStopF
            // 
            this.textBoxStopF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxStopF.Location = new System.Drawing.Point(516, 51);
            this.textBoxStopF.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxStopF.Name = "textBoxStopF";
            this.textBoxStopF.Size = new System.Drawing.Size(108, 30);
            this.textBoxStopF.TabIndex = 7;
            this.textBoxStopF.Text = "1e9";
            // 
            // textBoxFile
            // 
            this.textBoxFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFile.Location = new System.Drawing.Point(155, 167);
            this.textBoxFile.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxFile.Name = "textBoxFile";
            this.textBoxFile.Size = new System.Drawing.Size(489, 34);
            this.textBoxFile.TabIndex = 20;
            this.textBoxFile.Text = "test01.dat";
            // 
            // groupBoxTC
            // 
            this.groupBoxTC.Controls.Add(this.radioButtonTC2);
            this.groupBoxTC.Controls.Add(this.radioButtonTC1);
            this.groupBoxTC.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxTC.Location = new System.Drawing.Point(312, 91);
            this.groupBoxTC.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBoxTC.Name = "groupBoxTC";
            this.groupBoxTC.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBoxTC.Size = new System.Drawing.Size(161, 59);
            this.groupBoxTC.TabIndex = 10;
            this.groupBoxTC.TabStop = false;
            this.groupBoxTC.Text = "采集通道";
            // 
            // radioButtonTC2
            // 
            this.radioButtonTC2.AutoSize = true;
            this.radioButtonTC2.Checked = true;
            this.radioButtonTC2.Location = new System.Drawing.Point(89, 18);
            this.radioButtonTC2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.radioButtonTC2.Name = "radioButtonTC2";
            this.radioButtonTC2.Size = new System.Drawing.Size(54, 23);
            this.radioButtonTC2.TabIndex = 1;
            this.radioButtonTC2.TabStop = true;
            this.radioButtonTC2.Text = "S21";
            this.radioButtonTC2.UseVisualStyleBackColor = true;
            // 
            // radioButtonTC1
            // 
            this.radioButtonTC1.AutoSize = true;
            this.radioButtonTC1.Location = new System.Drawing.Point(8, 20);
            this.radioButtonTC1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.radioButtonTC1.Name = "radioButtonTC1";
            this.radioButtonTC1.Size = new System.Drawing.Size(54, 23);
            this.radioButtonTC1.TabIndex = 0;
            this.radioButtonTC1.Text = "S11";
            this.radioButtonTC1.UseVisualStyleBackColor = true;
            // 
            // buttonDone
            // 
            this.buttonDone.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDone.Location = new System.Drawing.Point(457, 240);
            this.buttonDone.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonDone.Name = "buttonDone";
            this.buttonDone.Size = new System.Drawing.Size(144, 29);
            this.buttonDone.TabIndex = 11;
            this.buttonDone.Text = "确认";
            this.buttonDone.UseVisualStyleBackColor = true;
            this.buttonDone.Click += new System.EventHandler(this.buttonDone_Click);
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBrowse.Location = new System.Drawing.Point(685, 167);
            this.buttonBrowse.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(100, 29);
            this.buttonBrowse.TabIndex = 12;
            this.buttonBrowse.Text = "浏览";
            this.buttonBrowse.UseVisualStyleBackColor = true;
            this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClose.Location = new System.Drawing.Point(641, 240);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(144, 29);
            this.buttonClose.TabIndex = 13;
            this.buttonClose.Text = "关闭";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // groupBoxIF
            // 
            this.groupBoxIF.Controls.Add(this.radioButtonIF3);
            this.groupBoxIF.Controls.Add(this.radioButtonIF2);
            this.groupBoxIF.Controls.Add(this.radioButtonIF1);
            this.groupBoxIF.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxIF.Location = new System.Drawing.Point(15, 91);
            this.groupBoxIF.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBoxIF.Name = "groupBoxIF";
            this.groupBoxIF.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBoxIF.Size = new System.Drawing.Size(280, 59);
            this.groupBoxIF.TabIndex = 14;
            this.groupBoxIF.TabStop = false;
            this.groupBoxIF.Text = "中频带宽(Hz):";
            // 
            // radioButtonIF3
            // 
            this.radioButtonIF3.AutoSize = true;
            this.radioButtonIF3.Checked = true;
            this.radioButtonIF3.Location = new System.Drawing.Point(200, 22);
            this.radioButtonIF3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.radioButtonIF3.Name = "radioButtonIF3";
            this.radioButtonIF3.Size = new System.Drawing.Size(62, 23);
            this.radioButtonIF3.TabIndex = 15;
            this.radioButtonIF3.TabStop = true;
            this.radioButtonIF3.Text = "3000";
            this.radioButtonIF3.UseVisualStyleBackColor = true;
            // 
            // radioButtonIF2
            // 
            this.radioButtonIF2.AutoSize = true;
            this.radioButtonIF2.Location = new System.Drawing.Point(99, 22);
            this.radioButtonIF2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.radioButtonIF2.Name = "radioButtonIF2";
            this.radioButtonIF2.Size = new System.Drawing.Size(62, 23);
            this.radioButtonIF2.TabIndex = 1;
            this.radioButtonIF2.Text = "1000";
            this.radioButtonIF2.UseVisualStyleBackColor = true;
            // 
            // radioButtonIF1
            // 
            this.radioButtonIF1.AutoSize = true;
            this.radioButtonIF1.Location = new System.Drawing.Point(12, 24);
            this.radioButtonIF1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.radioButtonIF1.Name = "radioButtonIF1";
            this.radioButtonIF1.Size = new System.Drawing.Size(54, 23);
            this.radioButtonIF1.TabIndex = 0;
            this.radioButtonIF1.Text = "300";
            this.radioButtonIF1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 245);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 19);
            this.label1.TabIndex = 15;
            this.label1.Text = "电缆长度";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(172, 240);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(107, 30);
            this.textBox1.TabIndex = 16;
            this.textBox1.Text = "50";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(312, 242);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(75, 21);
            this.radioButton1.TabIndex = 21;
            this.radioButton1.Text = "TOMO";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // setupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 340);
            this.Controls.Add(this.radioButton1);
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
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "setupForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Parameter Setup";
            this.groupBoxTC.ResumeLayout(false);
            this.groupBoxTC.PerformLayout();
            this.groupBoxIF.ResumeLayout(false);
            this.groupBoxIF.PerformLayout();
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
        private System.Windows.Forms.RadioButton radioButton1;
    }
}