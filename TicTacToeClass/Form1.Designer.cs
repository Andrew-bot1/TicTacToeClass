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
            btnSingle = new Button();
            btnMulti = new Button();
            btnUpMid = new Button();
            btnUpRight = new Button();
            btnMidLeft = new Button();
            BtnLowLeft = new Button();
            btnLowMid = new Button();
            btnMid = new Button();
            btnMidRight = new Button();
            bntLowRight = new Button();
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
            // btnSingle
            // 
            btnSingle.Location = new Point(263, 340);
            btnSingle.Name = "btnSingle";
            btnSingle.Size = new Size(75, 23);
            btnSingle.TabIndex = 2;
            btnSingle.Text = "Single";
            btnSingle.UseVisualStyleBackColor = true;
            // 
            // btnMulti
            // 
            btnMulti.Location = new Point(408, 340);
            btnMulti.Name = "btnMulti";
            btnMulti.Size = new Size(75, 23);
            btnMulti.TabIndex = 3;
            btnMulti.Text = "Multi";
            btnMulti.UseVisualStyleBackColor = true;
            // 
            // btnUpMid
            // 
            btnUpMid.Location = new Point(335, 71);
            btnUpMid.Name = "btnUpMid";
            btnUpMid.Size = new Size(87, 74);
            btnUpMid.TabIndex = 5;
            btnUpMid.UseVisualStyleBackColor = true;
            // 
            // btnUpRight
            // 
            btnUpRight.Location = new Point(428, 71);
            btnUpRight.Name = "btnUpRight";
            btnUpRight.Size = new Size(87, 74);
            btnUpRight.TabIndex = 6;
            btnUpRight.UseVisualStyleBackColor = true;
            // 
            // btnMidLeft
            // 
            btnMidLeft.Location = new Point(242, 149);
            btnMidLeft.Name = "btnMidLeft";
            btnMidLeft.Size = new Size(87, 76);
            btnMidLeft.TabIndex = 7;
            btnMidLeft.UseVisualStyleBackColor = true;
            // 
            // BtnLowLeft
            // 
            BtnLowLeft.Location = new Point(242, 231);
            BtnLowLeft.Name = "BtnLowLeft";
            BtnLowLeft.Size = new Size(87, 76);
            BtnLowLeft.TabIndex = 8;
            BtnLowLeft.UseVisualStyleBackColor = true;
            // 
            // btnLowMid
            // 
            btnLowMid.Location = new Point(335, 231);
            btnLowMid.Name = "btnLowMid";
            btnLowMid.Size = new Size(87, 76);
            btnLowMid.TabIndex = 9;
            btnLowMid.UseVisualStyleBackColor = true;
            btnLowMid.Click += button5_Click;
            // 
            // btnMid
            // 
            btnMid.Location = new Point(335, 149);
            btnMid.Name = "btnMid";
            btnMid.Size = new Size(87, 76);
            btnMid.TabIndex = 10;
            btnMid.UseVisualStyleBackColor = true;
            // 
            // btnMidRight
            // 
            btnMidRight.Location = new Point(428, 149);
            btnMidRight.Name = "btnMidRight";
            btnMidRight.Size = new Size(87, 76);
            btnMidRight.TabIndex = 11;
            btnMidRight.UseVisualStyleBackColor = true;
            // 
            // bntLowRight
            // 
            bntLowRight.Location = new Point(428, 231);
            bntLowRight.Name = "bntLowRight";
            bntLowRight.Size = new Size(87, 76);
            bntLowRight.TabIndex = 12;
            bntLowRight.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(800, 450);
            Controls.Add(bntLowRight);
            Controls.Add(btnMidRight);
            Controls.Add(btnMid);
            Controls.Add(btnLowMid);
            Controls.Add(BtnLowLeft);
            Controls.Add(btnMidLeft);
            Controls.Add(btnUpRight);
            Controls.Add(btnUpMid);
            Controls.Add(btnMulti);
            Controls.Add(btnSingle);
            Controls.Add(btnUpLeft);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Button btnUpLeft;
        private Button btnSingle;
        private Button btnMulti;
        private Button btnUpMid;
        private Button btnUpRight;
        private Button btnMidLeft;
        private Button BtnLowLeft;
        private Button btnLowMid;
        private Button btnMid;
        private Button btnMidRight;
        private Button bntLowRight;
    }
}
