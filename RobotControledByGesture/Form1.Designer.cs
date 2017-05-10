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
            this.infoLabel = new System.Windows.Forms.Label();
            this.testConectionBox = new System.Windows.Forms.GroupBox();
            this.beepButton = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.blobHeightNumeric = new System.Windows.Forms.NumericUpDown();
            this.blobWidthNumeric = new System.Windows.Forms.NumericUpDown();
            this.robotSettingsBox = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.runTurnNumeric = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.turningSpeedNumeric = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.maxSpeedNumeric = new System.Windows.Forms.NumericUpDown();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.leftRightNumeric = new System.Windows.Forms.NumericUpDown();
            this.runStopNumeric = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radiusNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RNumeric)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.testConectionBox.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.blobHeightNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blobWidthNumeric)).BeginInit();
            this.robotSettingsBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.runTurnNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.turningSpeedNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxSpeedNumeric)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.leftRightNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.runStopNumeric)).BeginInit();
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
            this.groupBox1.Location = new System.Drawing.Point(338, 96);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 108);
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
            this.label6.Text = "Skin :: RGB(186, 187, 209), 180";
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
            180,
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
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.infoLabel.Location = new System.Drawing.Point(174, 282);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(80, 31);
            this.infoLabel.TabIndex = 10;
            this.infoLabel.Text = "INFO";
            // 
            // testConectionBox
            // 
            this.testConectionBox.Controls.Add(this.beepButton);
            this.testConectionBox.Location = new System.Drawing.Point(544, 12);
            this.testConectionBox.Name = "testConectionBox";
            this.testConectionBox.Size = new System.Drawing.Size(108, 49);
            this.testConectionBox.TabIndex = 11;
            this.testConectionBox.TabStop = false;
            this.testConectionBox.Text = "Test Conection";
            this.testConectionBox.Visible = false;
            // 
            // beepButton
            // 
            this.beepButton.Location = new System.Drawing.Point(15, 19);
            this.beepButton.Name = "beepButton";
            this.beepButton.Size = new System.Drawing.Size(75, 23);
            this.beepButton.TabIndex = 0;
            this.beepButton.Text = "Beep";
            this.beepButton.UseVisualStyleBackColor = true;
            this.beepButton.Click += new System.EventHandler(this.beepButton_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.blobHeightNumeric);
            this.groupBox5.Controls.Add(this.blobWidthNumeric);
            this.groupBox5.Location = new System.Drawing.Point(338, 210);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(115, 69);
            this.groupBox5.TabIndex = 12;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Blob min size (picture: 320; 240)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(57, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Height";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Width";
            // 
            // blobHeightNumeric
            // 
            this.blobHeightNumeric.Location = new System.Drawing.Point(54, 46);
            this.blobHeightNumeric.Maximum = new decimal(new int[] {
            240,
            0,
            0,
            0});
            this.blobHeightNumeric.Name = "blobHeightNumeric";
            this.blobHeightNumeric.Size = new System.Drawing.Size(42, 20);
            this.blobHeightNumeric.TabIndex = 2;
            this.blobHeightNumeric.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // blobWidthNumeric
            // 
            this.blobWidthNumeric.Location = new System.Drawing.Point(6, 46);
            this.blobWidthNumeric.Maximum = new decimal(new int[] {
            320,
            0,
            0,
            0});
            this.blobWidthNumeric.Name = "blobWidthNumeric";
            this.blobWidthNumeric.Size = new System.Drawing.Size(42, 20);
            this.blobWidthNumeric.TabIndex = 1;
            this.blobWidthNumeric.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // robotSettingsBox
            // 
            this.robotSettingsBox.Controls.Add(this.label11);
            this.robotSettingsBox.Controls.Add(this.runTurnNumeric);
            this.robotSettingsBox.Controls.Add(this.label10);
            this.robotSettingsBox.Controls.Add(this.turningSpeedNumeric);
            this.robotSettingsBox.Controls.Add(this.label9);
            this.robotSettingsBox.Controls.Add(this.maxSpeedNumeric);
            this.robotSettingsBox.Location = new System.Drawing.Point(544, 67);
            this.robotSettingsBox.Name = "robotSettingsBox";
            this.robotSettingsBox.Size = new System.Drawing.Size(108, 137);
            this.robotSettingsBox.TabIndex = 13;
            this.robotSettingsBox.TabStop = false;
            this.robotSettingsBox.Text = "Robot Speed Settings";
            this.robotSettingsBox.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(56, 31);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 13);
            this.label11.TabIndex = 5;
            this.label11.Text = "Turn";
            // 
            // runTurnNumeric
            // 
            this.runTurnNumeric.Location = new System.Drawing.Point(59, 47);
            this.runTurnNumeric.Name = "runTurnNumeric";
            this.runTurnNumeric.Size = new System.Drawing.Size(40, 20);
            this.runTurnNumeric.TabIndex = 4;
            this.runTurnNumeric.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 70);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "Stop + Turn";
            // 
            // turningSpeedNumeric
            // 
            this.turningSpeedNumeric.Location = new System.Drawing.Point(9, 86);
            this.turningSpeedNumeric.Name = "turningSpeedNumeric";
            this.turningSpeedNumeric.Size = new System.Drawing.Size(40, 20);
            this.turningSpeedNumeric.TabIndex = 2;
            this.turningSpeedNumeric.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 31);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Run     +";
            // 
            // maxSpeedNumeric
            // 
            this.maxSpeedNumeric.Location = new System.Drawing.Point(9, 47);
            this.maxSpeedNumeric.Name = "maxSpeedNumeric";
            this.maxSpeedNumeric.Size = new System.Drawing.Size(41, 20);
            this.maxSpeedNumeric.TabIndex = 0;
            this.maxSpeedNumeric.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.leftRightNumeric);
            this.groupBox4.Controls.Add(this.runStopNumeric);
            this.groupBox4.Location = new System.Drawing.Point(457, 211);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(141, 68);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Run/Stop Left/Right";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(76, 21);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 13);
            this.label12.TabIndex = 8;
            this.label12.Text = "Left/Right";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(11, 21);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(54, 13);
            this.label13.TabIndex = 7;
            this.label13.Text = "Run/Stop";
            // 
            // leftRightNumeric
            // 
            this.leftRightNumeric.Location = new System.Drawing.Point(79, 37);
            this.leftRightNumeric.Maximum = new decimal(new int[] {
            240,
            0,
            0,
            0});
            this.leftRightNumeric.Name = "leftRightNumeric";
            this.leftRightNumeric.Size = new System.Drawing.Size(42, 20);
            this.leftRightNumeric.TabIndex = 6;
            this.leftRightNumeric.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // runStopNumeric
            // 
            this.runStopNumeric.Location = new System.Drawing.Point(14, 37);
            this.runStopNumeric.Maximum = new decimal(new int[] {
            320,
            0,
            0,
            0});
            this.runStopNumeric.Name = "runStopNumeric";
            this.runStopNumeric.Size = new System.Drawing.Size(42, 20);
            this.runStopNumeric.TabIndex = 5;
            this.runStopNumeric.Value = new decimal(new int[] {
            150,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 315);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.robotSettingsBox);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.testConectionBox);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Insis - Robot controled by gesture";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radiusNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RNumeric)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.testConectionBox.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.blobHeightNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blobWidthNumeric)).EndInit();
            this.robotSettingsBox.ResumeLayout(false);
            this.robotSettingsBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.runTurnNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.turningSpeedNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxSpeedNumeric)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.leftRightNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.runStopNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.ComboBox comboBox1;
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
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.GroupBox testConectionBox;
        private System.Windows.Forms.Button beepButton;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.NumericUpDown blobHeightNumeric;
        private System.Windows.Forms.NumericUpDown blobWidthNumeric;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox robotSettingsBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown maxSpeedNumeric;
        private System.Windows.Forms.NumericUpDown turningSpeedNumeric;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown runTurnNumeric;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown leftRightNumeric;
        private System.Windows.Forms.NumericUpDown runStopNumeric;
    }
}

