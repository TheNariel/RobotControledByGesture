namespace RobotControledByGesture
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.startButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tresholdNumeric = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.radiusNumeric = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BNumeric = new System.Windows.Forms.NumericUpDown();
            this.GNumeric = new System.Windows.Forms.NumericUpDown();
            this.RNumeric = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.robotCheckBox = new System.Windows.Forms.CheckBox();
            this.connectButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comPortCombo = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.infoLabel = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.beepButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tresholdNumeric)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radiusNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RNumeric)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(320, 240);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(12, 285);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 3;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Visible = false;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.Location = new System.Drawing.Point(93, 285);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(75, 23);
            this.stopButton.TabIndex = 4;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Visible = false;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 258);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(320, 21);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // tresholdNumeric
            // 
            this.tresholdNumeric.Location = new System.Drawing.Point(9, 19);
            this.tresholdNumeric.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.tresholdNumeric.Name = "tresholdNumeric";
            this.tresholdNumeric.Size = new System.Drawing.Size(61, 20);
            this.tresholdNumeric.TabIndex = 6;
            this.tresholdNumeric.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.radiusNumeric);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.BNumeric);
            this.groupBox1.Controls.Add(this.GNumeric);
            this.groupBox1.Controls.Add(this.RNumeric);
            this.groupBox1.Location = new System.Drawing.Point(338, 99);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 125);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "EuclideanColorFiltering";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(159, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Skin :: RGB(186, 187, 209), 120";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(149, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Radius";
            // 
            // radiusNumeric
            // 
            this.radiusNumeric.Location = new System.Drawing.Point(152, 35);
            this.radiusNumeric.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.radiusNumeric.Name = "radiusNumeric";
            this.radiusNumeric.Size = new System.Drawing.Size(42, 20);
            this.radiusNumeric.TabIndex = 9;
            this.radiusNumeric.Value = new decimal(new int[] {
            120,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(101, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "B";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "G";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "R";
            // 
            // BNumeric
            // 
            this.BNumeric.Location = new System.Drawing.Point(104, 35);
            this.BNumeric.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.BNumeric.Name = "BNumeric";
            this.BNumeric.Size = new System.Drawing.Size(42, 20);
            this.BNumeric.TabIndex = 2;
            this.BNumeric.Value = new decimal(new int[] {
            209,
            0,
            0,
            0});
            // 
            // GNumeric
            // 
            this.GNumeric.Location = new System.Drawing.Point(56, 35);
            this.GNumeric.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.GNumeric.Name = "GNumeric";
            this.GNumeric.Size = new System.Drawing.Size(42, 20);
            this.GNumeric.TabIndex = 1;
            this.GNumeric.Value = new decimal(new int[] {
            187,
            0,
            0,
            0});
            // 
            // RNumeric
            // 
            this.RNumeric.Location = new System.Drawing.Point(9, 35);
            this.RNumeric.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.RNumeric.Name = "RNumeric";
            this.RNumeric.Size = new System.Drawing.Size(42, 20);
            this.RNumeric.TabIndex = 0;
            this.RNumeric.Value = new decimal(new int[] {
            186,
            0,
            0,
            0});
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.robotCheckBox);
            this.groupBox2.Controls.Add(this.connectButton);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.comPortCombo);
            this.groupBox2.Location = new System.Drawing.Point(338, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 81);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Robot Connection";
            // 
            // robotCheckBox
            // 
            this.robotCheckBox.AutoSize = true;
            this.robotCheckBox.Location = new System.Drawing.Point(6, 52);
            this.robotCheckBox.Name = "robotCheckBox";
            this.robotCheckBox.Size = new System.Drawing.Size(92, 17);
            this.robotCheckBox.TabIndex = 9;
            this.robotCheckBox.Text = "talk with robot";
            this.robotCheckBox.UseVisualStyleBackColor = true;
            this.robotCheckBox.Visible = false;
            this.robotCheckBox.CheckedChanged += new System.EventHandler(this.robotCheckBox_CheckedChanged);
            // 
            // connectButton
            // 
            this.connectButton.Location = new System.Drawing.Point(119, 46);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(75, 23);
            this.connectButton.TabIndex = 10;
            this.connectButton.Text = "Connect";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Visible = false;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "COM PORT";
            // 
            // comPortCombo
            // 
            this.comPortCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comPortCombo.FormattingEnabled = true;
            this.comPortCombo.Location = new System.Drawing.Point(73, 19);
            this.comPortCombo.Name = "comPortCombo";
            this.comPortCombo.Size = new System.Drawing.Size(121, 21);
            this.comPortCombo.TabIndex = 9;
            this.comPortCombo.SelectedIndexChanged += new System.EventHandler(this.comPortCombo_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tresholdNumeric);
            this.groupBox3.Location = new System.Drawing.Point(338, 230);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(83, 49);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Treshold";
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.infoLabel.Location = new System.Drawing.Point(341, 282);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(80, 31);
            this.infoLabel.TabIndex = 10;
            this.infoLabel.Text = "INFO";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.beepButton);
            this.groupBox4.Location = new System.Drawing.Point(427, 230);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(111, 49);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Test Conection";
            // 
            // beepButton
            // 
            this.beepButton.Location = new System.Drawing.Point(15, 19);
            this.beepButton.Name = "beepButton";
            this.beepButton.Size = new System.Drawing.Size(75, 23);
            this.beepButton.TabIndex = 0;
            this.beepButton.Text = "Beep";
            this.beepButton.UseVisualStyleBackColor = true;
            this.beepButton.Visible = false;
            this.beepButton.Click += new System.EventHandler(this.beepButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 317);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Webcam Capture";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tresholdNumeric)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radiusNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RNumeric)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.NumericUpDown tresholdNumeric;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comPortCombo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown BNumeric;
        private System.Windows.Forms.NumericUpDown GNumeric;
        private System.Windows.Forms.NumericUpDown RNumeric;
        private System.Windows.Forms.CheckBox robotCheckBox;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown radiusNumeric;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button beepButton;
    }
}

