
namespace uasCitra_MKB
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.labelMax3 = new System.Windows.Forms.Label();
            this.labelMax2 = new System.Windows.Forms.Label();
            this.labelMax1 = new System.Windows.Forms.Label();
            this.trackBarMax3 = new System.Windows.Forms.TrackBar();
            this.trackBarMax2 = new System.Windows.Forms.TrackBar();
            this.trackBarMax1 = new System.Windows.Forms.TrackBar();
            this.labelMin3 = new System.Windows.Forms.Label();
            this.labelMin2 = new System.Windows.Forms.Label();
            this.labelMin1 = new System.Windows.Forms.Label();
            this.trackBarMin3 = new System.Windows.Forms.TrackBar();
            this.trackBarMin2 = new System.Windows.Forms.TrackBar();
            this.trackBarMin1 = new System.Windows.Forms.TrackBar();
            this.videoSourcePlayer1 = new AForge.Controls.VideoSourcePlayer();
            this.pictureBox1 = new AForge.Controls.PictureBox();
            this.pictureBox2 = new AForge.Controls.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.histogram1 = new AForge.Controls.Histogram();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox3 = new AForge.Controls.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarMax3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarMax2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarMax1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarMin3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarMin2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarMin1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(12, 91);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 141);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Input Selection";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(46, 90);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Start Camera";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(46, 51);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Open File";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Location = new System.Drawing.Point(12, 257);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Camera Selection";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(33, 39);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioButton3);
            this.groupBox3.Controls.Add(this.radioButton2);
            this.groupBox3.Controls.Add(this.radioButton1);
            this.groupBox3.Location = new System.Drawing.Point(12, 390);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 139);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Filter Selection";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(6, 98);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(69, 21);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "YCbCr";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(6, 66);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(56, 21);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "HSL";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 34);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(59, 21);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "RGB";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button5);
            this.groupBox4.Controls.Add(this.button4);
            this.groupBox4.Controls.Add(this.button3);
            this.groupBox4.Location = new System.Drawing.Point(12, 535);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 157);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Control";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(46, 107);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 2;
            this.button5.Text = "Track";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(46, 38);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 1;
            this.button4.Text = "Reset";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(46, 72);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 0;
            this.button3.Text = "Close";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.labelMax3);
            this.groupBox5.Controls.Add(this.labelMax2);
            this.groupBox5.Controls.Add(this.labelMax1);
            this.groupBox5.Controls.Add(this.trackBarMax3);
            this.groupBox5.Controls.Add(this.trackBarMax2);
            this.groupBox5.Controls.Add(this.trackBarMax1);
            this.groupBox5.Controls.Add(this.labelMin3);
            this.groupBox5.Controls.Add(this.labelMin2);
            this.groupBox5.Controls.Add(this.labelMin1);
            this.groupBox5.Controls.Add(this.trackBarMin3);
            this.groupBox5.Controls.Add(this.trackBarMin2);
            this.groupBox5.Controls.Add(this.trackBarMin1);
            this.groupBox5.Location = new System.Drawing.Point(238, 424);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(437, 268);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Image Control Function";
            this.groupBox5.Enter += new System.EventHandler(this.groupBox5_Enter);
            // 
            // labelMax3
            // 
            this.labelMax3.AutoSize = true;
            this.labelMax3.Location = new System.Drawing.Point(251, 166);
            this.labelMax3.Name = "labelMax3";
            this.labelMax3.Size = new System.Drawing.Size(45, 17);
            this.labelMax3.TabIndex = 11;
            this.labelMax3.Text = "max 3";
            this.labelMax3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelMax2
            // 
            this.labelMax2.AutoSize = true;
            this.labelMax2.Location = new System.Drawing.Point(251, 96);
            this.labelMax2.Name = "labelMax2";
            this.labelMax2.Size = new System.Drawing.Size(45, 17);
            this.labelMax2.TabIndex = 10;
            this.labelMax2.Text = "max 2";
            this.labelMax2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelMax1
            // 
            this.labelMax1.AutoSize = true;
            this.labelMax1.Location = new System.Drawing.Point(251, 29);
            this.labelMax1.Name = "labelMax1";
            this.labelMax1.Size = new System.Drawing.Size(45, 17);
            this.labelMax1.TabIndex = 9;
            this.labelMax1.Text = "max 1";
            this.labelMax1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // trackBarMax3
            // 
            this.trackBarMax3.Location = new System.Drawing.Point(233, 183);
            this.trackBarMax3.Name = "trackBarMax3";
            this.trackBarMax3.Size = new System.Drawing.Size(198, 56);
            this.trackBarMax3.TabIndex = 8;
            this.trackBarMax3.Scroll += new System.EventHandler(this.trackBarMax3_Scroll);
            // 
            // trackBarMax2
            // 
            this.trackBarMax2.Location = new System.Drawing.Point(233, 116);
            this.trackBarMax2.Name = "trackBarMax2";
            this.trackBarMax2.Size = new System.Drawing.Size(198, 56);
            this.trackBarMax2.TabIndex = 7;
            this.trackBarMax2.Scroll += new System.EventHandler(this.trackBarMax2_Scroll);
            // 
            // trackBarMax1
            // 
            this.trackBarMax1.Location = new System.Drawing.Point(233, 49);
            this.trackBarMax1.Name = "trackBarMax1";
            this.trackBarMax1.Size = new System.Drawing.Size(198, 56);
            this.trackBarMax1.TabIndex = 6;
            this.trackBarMax1.Scroll += new System.EventHandler(this.trackBarMax1_Scroll);
            // 
            // labelMin3
            // 
            this.labelMin3.AutoSize = true;
            this.labelMin3.Location = new System.Drawing.Point(24, 166);
            this.labelMin3.Name = "labelMin3";
            this.labelMin3.Size = new System.Drawing.Size(42, 17);
            this.labelMin3.TabIndex = 5;
            this.labelMin3.Text = "min 3";
            this.labelMin3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelMin2
            // 
            this.labelMin2.AutoSize = true;
            this.labelMin2.Location = new System.Drawing.Point(24, 96);
            this.labelMin2.Name = "labelMin2";
            this.labelMin2.Size = new System.Drawing.Size(42, 17);
            this.labelMin2.TabIndex = 4;
            this.labelMin2.Text = "min 2";
            this.labelMin2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelMin1
            // 
            this.labelMin1.AutoSize = true;
            this.labelMin1.Location = new System.Drawing.Point(24, 29);
            this.labelMin1.Name = "labelMin1";
            this.labelMin1.Size = new System.Drawing.Size(38, 17);
            this.labelMin1.TabIndex = 3;
            this.labelMin1.Text = "min1";
            this.labelMin1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // trackBarMin3
            // 
            this.trackBarMin3.Location = new System.Drawing.Point(6, 183);
            this.trackBarMin3.Name = "trackBarMin3";
            this.trackBarMin3.Size = new System.Drawing.Size(198, 56);
            this.trackBarMin3.TabIndex = 2;
            this.trackBarMin3.Scroll += new System.EventHandler(this.trackBarMin3_Scroll);
            // 
            // trackBarMin2
            // 
            this.trackBarMin2.Location = new System.Drawing.Point(6, 116);
            this.trackBarMin2.Name = "trackBarMin2";
            this.trackBarMin2.Size = new System.Drawing.Size(198, 56);
            this.trackBarMin2.TabIndex = 1;
            this.trackBarMin2.Scroll += new System.EventHandler(this.trackBarMin2_Scroll);
            // 
            // trackBarMin1
            // 
            this.trackBarMin1.Location = new System.Drawing.Point(6, 49);
            this.trackBarMin1.Name = "trackBarMin1";
            this.trackBarMin1.Size = new System.Drawing.Size(198, 56);
            this.trackBarMin1.TabIndex = 0;
            this.trackBarMin1.Scroll += new System.EventHandler(this.trackBarMin1_Scroll);
            // 
            // videoSourcePlayer1
            // 
            this.videoSourcePlayer1.Location = new System.Drawing.Point(218, 91);
            this.videoSourcePlayer1.Name = "videoSourcePlayer1";
            this.videoSourcePlayer1.Size = new System.Drawing.Size(388, 266);
            this.videoSourcePlayer1.TabIndex = 5;
            this.videoSourcePlayer1.Text = "videoSourcePlayer1";
            this.videoSourcePlayer1.VideoSource = null;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = null;
            this.pictureBox1.Location = new System.Drawing.Point(612, 91);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(340, 266);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = null;
            this.pictureBox2.Location = new System.Drawing.Point(958, 91);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(340, 266);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(281, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Original Image";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(706, 71);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 17);
            this.label8.TabIndex = 13;
            this.label8.Text = "Detected Object";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1079, 71);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 17);
            this.label9.TabIndex = 14;
            this.label9.Text = "Tracked Object";
            // 
            // histogram1
            // 
            this.histogram1.Location = new System.Drawing.Point(709, 424);
            this.histogram1.Name = "histogram1";
            this.histogram1.Size = new System.Drawing.Size(766, 268);
            this.histogram1.TabIndex = 15;
            this.histogram1.Text = "histogram1";
            this.histogram1.Values = null;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(855, 404);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 17);
            this.label10.TabIndex = 12;
            this.label10.Text = "Histogram";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = null;
            this.pictureBox3.Location = new System.Drawing.Point(218, 63);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(388, 257);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 16;
            this.pictureBox3.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1489, 704);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.histogram1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.videoSourcePlayer1);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarMax3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarMax2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarMax1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarMin3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarMin2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarMin1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label labelMax3;
        private System.Windows.Forms.Label labelMax2;
        private System.Windows.Forms.Label labelMax1;
        private System.Windows.Forms.TrackBar trackBarMax3;
        private System.Windows.Forms.TrackBar trackBarMax2;
        private System.Windows.Forms.TrackBar trackBarMax1;
        private System.Windows.Forms.Label labelMin3;
        private System.Windows.Forms.Label labelMin2;
        private System.Windows.Forms.Label labelMin1;
        private System.Windows.Forms.TrackBar trackBarMin3;
        private System.Windows.Forms.TrackBar trackBarMin2;
        private System.Windows.Forms.TrackBar trackBarMin1;
        private AForge.Controls.VideoSourcePlayer videoSourcePlayer1;
        private AForge.Controls.PictureBox pictureBox1;
        private AForge.Controls.PictureBox pictureBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private AForge.Controls.Histogram histogram1;
        private System.Windows.Forms.Label label10;
        private AForge.Controls.PictureBox pictureBox3;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button5;
    }
}

