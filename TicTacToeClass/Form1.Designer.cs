namespace TicTacToeClass
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            btnUpLeft = new Button();
            btnUpMid = new Button();
            btnUpRight = new Button();
            btnMidLeft = new Button();
            btnLowLeft = new Button();
            btnLowMid = new Button();
            btnMid = new Button();
            btnMidRight = new Button();
            bntLowRight = new Button();
            radBtnSing = new RadioButton();
            radBtnMulti = new RadioButton();
            txtResult = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.download;
            pictureBox1.Location = new Point(179, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(400, 351);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btnUpLeft
            // 
            btnUpLeft.Location = new Point(242, 71);
            btnUpLeft.Name = "btnUpLeft";
            btnUpLeft.Size = new Size(87, 74);
            btnUpLeft.TabIndex = 1;
            btnUpLeft.UseVisualStyleBackColor = true;
            btnUpLeft.Click += btnUpLeft_Click;
            // 
            // btnUpMid
            // 
            btnUpMid.Location = new Point(335, 71);
            btnUpMid.Name = "btnUpMid";
            btnUpMid.Size = new Size(87, 74);
            btnUpMid.TabIndex = 5;
            btnUpMid.UseVisualStyleBackColor = true;
            btnUpMid.Click += btnUpMid_Click;
            // 
            // btnUpRight
            // 
            btnUpRight.Location = new Point(428, 71);
            btnUpRight.Name = "btnUpRight";
            btnUpRight.Size = new Size(87, 74);
            btnUpRight.TabIndex = 6;
            btnUpRight.UseVisualStyleBackColor = true;
            btnUpRight.Click += btnUpRight_Click;
            // 
            // btnMidLeft
            // 
            btnMidLeft.Location = new Point(242, 149);
            btnMidLeft.Name = "btnMidLeft";
            btnMidLeft.Size = new Size(87, 76);
            btnMidLeft.TabIndex = 7;
            btnMidLeft.UseVisualStyleBackColor = true;
            btnMidLeft.Click += btnMidLeft_Click;
            // 
            // btnLowLeft
            // 
            btnLowLeft.Location = new Point(242, 231);
            btnLowLeft.Name = "btnLowLeft";
            btnLowLeft.Size = new Size(87, 76);
            btnLowLeft.TabIndex = 8;
            btnLowLeft.UseVisualStyleBackColor = true;
            btnLowLeft.Click += btnLowLeft_Click;
            // 
            // btnLowMid
            // 
            btnLowMid.Location = new Point(335, 231);
            btnLowMid.Name = "btnLowMid";
            btnLowMid.Size = new Size(87, 76);
            btnLowMid.TabIndex = 9;
            btnLowMid.UseVisualStyleBackColor = true;
            btnLowMid.Click += btnLowMid_Click;
            // 
            // btnMid
            // 
            btnMid.Location = new Point(335, 149);
            btnMid.Name = "btnMid";
            btnMid.Size = new Size(87, 76);
            btnMid.TabIndex = 10;
            btnMid.UseVisualStyleBackColor = true;
            btnMid.Click += btnMid_Click;
            // 
            // btnMidRight
            // 
            btnMidRight.Location = new Point(428, 149);
            btnMidRight.Name = "btnMidRight";
            btnMidRight.Size = new Size(87, 76);
            btnMidRight.TabIndex = 11;
            btnMidRight.UseVisualStyleBackColor = true;
            btnMidRight.Click += btnMidRight_Click;
            // 
            // bntLowRight
            // 
            bntLowRight.Location = new Point(428, 231);
            bntLowRight.Name = "bntLowRight";
            bntLowRight.Size = new Size(87, 76);
            bntLowRight.TabIndex = 12;
            bntLowRight.UseVisualStyleBackColor = true;
            bntLowRight.Click += bntLowRight_Click;
            // 
            // radBtnSing
            // 
            radBtnSing.AutoSize = true;
            radBtnSing.Location = new Point(238, 344);
            radBtnSing.Name = "radBtnSing";
            radBtnSing.Size = new Size(87, 19);
            radBtnSing.TabIndex = 13;
            radBtnSing.TabStop = true;
            radBtnSing.Text = "Multi Game";
            radBtnSing.UseVisualStyleBackColor = true;
            radBtnSing.CheckedChanged += radBtnSing_CheckedChanged;
            // 
            // radBtnMulti
            // 
            radBtnMulti.AutoSize = true;
            radBtnMulti.Location = new Point(428, 344);
            radBtnMulti.Name = "radBtnMulti";
            radBtnMulti.Size = new Size(91, 19);
            radBtnMulti.TabIndex = 14;
            radBtnMulti.TabStop = true;
            radBtnMulti.Text = "Single Game";
            radBtnMulti.UseVisualStyleBackColor = true;
            radBtnMulti.CheckedChanged += radBtnMulti_CheckedChanged;
            // 
            // txtResult
            // 
            txtResult.Location = new Point(321, 386);
            txtResult.Name = "txtResult";
            txtResult.Size = new Size(113, 23);
            txtResult.TabIndex = 15;
            txtResult.TextChanged += txtResult_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(800, 450);
            Controls.Add(txtResult);
            Controls.Add(radBtnMulti);
            Controls.Add(radBtnSing);
            Controls.Add(bntLowRight);
            Controls.Add(btnMidRight);
            Controls.Add(btnMid);
            Controls.Add(btnLowMid);
            Controls.Add(btnLowLeft);
            Controls.Add(btnMidLeft);
            Controls.Add(btnUpRight);
            Controls.Add(btnUpMid);
            Controls.Add(btnUpLeft);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        public Button btnUpLeft;
        private Button btnSingle;
        private Button btnMulti;
        private Button btnUpMid;
        private Button btnUpRight;
        private Button btnMidLeft;
        private Button btnLowLeft;
        private Button btnLowMid;
        private Button btnMid;
        private Button btnMidRight;
        private Button bntLowRight;
        private RadioButton radBtnSing;
        private RadioButton radBtnMulti;
        private TextBox txtResult;
    }
}
