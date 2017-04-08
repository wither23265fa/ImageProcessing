namespace imageProcess
{
    partial class mainForm
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.loadButton = new System.Windows.Forms.Button();
            this.fileDialog = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.pictureBoxAfter = new System.Windows.Forms.PictureBox();
            this.grayButton = new System.Windows.Forms.Button();
            this.binButton = new System.Windows.Forms.Button();
            this.trackTextBox = new System.Windows.Forms.TextBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.trackBar = new System.Windows.Forms.TrackBar();
            this.stoneButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.redButton = new System.Windows.Forms.Button();
            this.bgButton = new System.Windows.Forms.Button();
            this.colorBox = new System.Windows.Forms.PictureBox();
            this.masaicButton = new System.Windows.Forms.Button();
            this.colorLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAfter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorBox)).BeginInit();
            this.SuspendLayout();
            // 
            // loadButton
            // 
            this.loadButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadButton.Location = new System.Drawing.Point(115, 298);
            this.loadButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(83, 30);
            this.loadButton.TabIndex = 0;
            this.loadButton.Text = "讀取";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // fileDialog
            // 
            this.fileDialog.FileName = "fileDialog";
            // 
            // pictureBox
            // 
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox.Location = new System.Drawing.Point(27, 8);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(268, 268);
            this.pictureBox.TabIndex = 1;
            this.pictureBox.TabStop = false;
            this.pictureBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.img_MouseClick);
            // 
            // pictureBoxAfter
            // 
            this.pictureBoxAfter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxAfter.Location = new System.Drawing.Point(317, 8);
            this.pictureBoxAfter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBoxAfter.Name = "pictureBoxAfter";
            this.pictureBoxAfter.Size = new System.Drawing.Size(368, 368);
            this.pictureBoxAfter.TabIndex = 2;
            this.pictureBoxAfter.TabStop = false;
            // 
            // grayButton
            // 
            this.grayButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grayButton.Location = new System.Drawing.Point(701, 111);
            this.grayButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grayButton.Name = "grayButton";
            this.grayButton.Size = new System.Drawing.Size(69, 30);
            this.grayButton.TabIndex = 3;
            this.grayButton.Text = "灰階";
            this.grayButton.UseVisualStyleBackColor = true;
            this.grayButton.Click += new System.EventHandler(this.grayButton_Click);
            // 
            // binButton
            // 
            this.binButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.binButton.Location = new System.Drawing.Point(733, 27);
            this.binButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.binButton.Name = "binButton";
            this.binButton.Size = new System.Drawing.Size(114, 30);
            this.binButton.TabIndex = 4;
            this.binButton.Text = "二值化";
            this.binButton.UseVisualStyleBackColor = true;
            this.binButton.Click += new System.EventHandler(this.binButton_Click);
            // 
            // trackTextBox
            // 
            this.trackTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trackTextBox.Location = new System.Drawing.Point(701, 35);
            this.trackTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.trackTextBox.Name = "trackTextBox";
            this.trackTextBox.Size = new System.Drawing.Size(29, 21);
            this.trackTextBox.TabIndex = 6;
            this.trackTextBox.Text = "0";
            this.trackTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(2, 387);
            this.splitter1.TabIndex = 7;
            this.splitter1.TabStop = false;
            // 
            // trackBar
            // 
            this.trackBar.Location = new System.Drawing.Point(701, 61);
            this.trackBar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.trackBar.Maximum = 255;
            this.trackBar.Name = "trackBar";
            this.trackBar.Size = new System.Drawing.Size(145, 45);
            this.trackBar.TabIndex = 10;
            this.trackBar.ValueChanged += new System.EventHandler(this.trackBar_ValueChanged);
            // 
            // stoneButton
            // 
            this.stoneButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stoneButton.Location = new System.Drawing.Point(777, 161);
            this.stoneButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.stoneButton.Name = "stoneButton";
            this.stoneButton.Size = new System.Drawing.Size(69, 30);
            this.stoneButton.TabIndex = 11;
            this.stoneButton.Text = "浮雕";
            this.stoneButton.UseVisualStyleBackColor = true;
            this.stoneButton.Click += new System.EventHandler(this.stoneButton_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(701, 161);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(69, 30);
            this.button1.TabIndex = 12;
            this.button1.Text = "負片";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.negativeButton_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(701, 211);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(69, 30);
            this.button2.TabIndex = 13;
            this.button2.Text = "模糊";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.gaussButton_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(777, 211);
            this.button3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(69, 30);
            this.button3.TabIndex = 14;
            this.button3.Text = "銳化";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.laplasButton_Click);
            // 
            // redButton
            // 
            this.redButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.redButton.Location = new System.Drawing.Point(777, 111);
            this.redButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.redButton.Name = "redButton";
            this.redButton.Size = new System.Drawing.Size(69, 30);
            this.redButton.TabIndex = 15;
            this.redButton.Text = "保留色";
            this.redButton.UseVisualStyleBackColor = true;
            this.redButton.Click += new System.EventHandler(this.redButton_Click);
            // 
            // bgButton
            // 
            this.bgButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bgButton.Location = new System.Drawing.Point(777, 259);
            this.bgButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bgButton.Name = "bgButton";
            this.bgButton.Size = new System.Drawing.Size(69, 30);
            this.bgButton.TabIndex = 16;
            this.bgButton.Text = "去背";
            this.bgButton.UseVisualStyleBackColor = true;
            this.bgButton.Click += new System.EventHandler(this.bgButton_Click);
            // 
            // colorBox
            // 
            this.colorBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.colorBox.Location = new System.Drawing.Point(831, 298);
            this.colorBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.colorBox.Name = "colorBox";
            this.colorBox.Size = new System.Drawing.Size(17, 19);
            this.colorBox.TabIndex = 17;
            this.colorBox.TabStop = false;
            // 
            // masaicButton
            // 
            this.masaicButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.masaicButton.Location = new System.Drawing.Point(701, 259);
            this.masaicButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.masaicButton.Name = "masaicButton";
            this.masaicButton.Size = new System.Drawing.Size(69, 30);
            this.masaicButton.TabIndex = 18;
            this.masaicButton.Text = "馬賽克";
            this.masaicButton.UseVisualStyleBackColor = true;
            this.masaicButton.Click += new System.EventHandler(this.masaicButton_Click);
            // 
            // colorLabel
            // 
            this.colorLabel.AutoSize = true;
            this.colorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colorLabel.Location = new System.Drawing.Point(773, 301);
            this.colorLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.colorLabel.Name = "colorLabel";
            this.colorLabel.Size = new System.Drawing.Size(61, 13);
            this.colorLabel.TabIndex = 19;
            this.colorLabel.Text = "去背顏色 :";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(857, 387);
            this.Controls.Add(this.colorLabel);
            this.Controls.Add(this.masaicButton);
            this.Controls.Add(this.colorBox);
            this.Controls.Add(this.bgButton);
            this.Controls.Add(this.redButton);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.stoneButton);
            this.Controls.Add(this.trackBar);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.trackTextBox);
            this.Controls.Add(this.binButton);
            this.Controls.Add(this.grayButton);
            this.Controls.Add(this.pictureBoxAfter);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.loadButton);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "mainForm";
            this.Text = "imageProcess";
            this.Load += new System.EventHandler(this.mainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAfter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.OpenFileDialog fileDialog;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.PictureBox pictureBoxAfter;
        private System.Windows.Forms.Button grayButton;
        private System.Windows.Forms.Button binButton;
        private System.Windows.Forms.TextBox trackTextBox;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.TrackBar trackBar;
        private System.Windows.Forms.Button stoneButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button redButton;
        private System.Windows.Forms.Button bgButton;
        private System.Windows.Forms.PictureBox colorBox;
        private System.Windows.Forms.Button masaicButton;
        private System.Windows.Forms.Label colorLabel;
    }
}

