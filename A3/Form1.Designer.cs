
namespace A3
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
            this.drawingArea = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnCalculateCurveLenght = new System.Windows.Forms.Button();
            this.lblX = new System.Windows.Forms.Label();
            this.lblY = new System.Windows.Forms.Label();
            this.lblCurveLenght = new System.Windows.Forms.Label();
            this.lblTest = new System.Windows.Forms.Label();
            this.comboBox_PointColor = new System.Windows.Forms.ComboBox();
            this.comboBox_LineColor = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.drawingArea)).BeginInit();
            this.SuspendLayout();
            // 
            // drawingArea
            // 
            this.drawingArea.Location = new System.Drawing.Point(3, 1);
            this.drawingArea.Name = "drawingArea";
            this.drawingArea.Size = new System.Drawing.Size(548, 616);
            this.drawingArea.TabIndex = 0;
            this.drawingArea.TabStop = false;
            this.drawingArea.Click += new System.EventHandler(this.drawingArea_Click);
            this.drawingArea.Paint += new System.Windows.Forms.PaintEventHandler(this.drawingArea_Paint);
            this.drawingArea.MouseClick += new System.Windows.Forms.MouseEventHandler(this.drawingArea_MouseClick);
            this.drawingArea.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Tomato;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(763, 637);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(97, 37);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnCalculateCurveLenght
            // 
            this.btnCalculateCurveLenght.BackColor = System.Drawing.Color.Moccasin;
            this.btnCalculateCurveLenght.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculateCurveLenght.Location = new System.Drawing.Point(638, 194);
            this.btnCalculateCurveLenght.Name = "btnCalculateCurveLenght";
            this.btnCalculateCurveLenght.Size = new System.Drawing.Size(141, 62);
            this.btnCalculateCurveLenght.TabIndex = 2;
            this.btnCalculateCurveLenght.Text = "Calculate Curve Lenght";
            this.btnCalculateCurveLenght.UseVisualStyleBackColor = false;
            this.btnCalculateCurveLenght.Click += new System.EventHandler(this.btnCalculateCurveLenght_Click);
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblX.Location = new System.Drawing.Point(610, 44);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(0, 29);
            this.lblX.TabIndex = 3;
            this.lblX.Click += new System.EventHandler(this.labelX_Click);
            // 
            // lblY
            // 
            this.lblY.AutoSize = true;
            this.lblY.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblY.Location = new System.Drawing.Point(610, 96);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(0, 29);
            this.lblY.TabIndex = 4;
            // 
            // lblCurveLenght
            // 
            this.lblCurveLenght.AutoSize = true;
            this.lblCurveLenght.BackColor = System.Drawing.SystemColors.Control;
            this.lblCurveLenght.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurveLenght.Location = new System.Drawing.Point(649, 304);
            this.lblCurveLenght.Name = "lblCurveLenght";
            this.lblCurveLenght.Size = new System.Drawing.Size(0, 29);
            this.lblCurveLenght.TabIndex = 6;
            // 
            // lblTest
            // 
            this.lblTest.AutoSize = true;
            this.lblTest.Location = new System.Drawing.Point(574, 394);
            this.lblTest.Name = "lblTest";
            this.lblTest.Size = new System.Drawing.Size(0, 17);
            this.lblTest.TabIndex = 7;
            // 
            // comboBox_PointColor
            // 
            this.comboBox_PointColor.FormattingEnabled = true;
            this.comboBox_PointColor.Items.AddRange(new object[] {
            "Blue",
            "Black",
            "Red"});
            this.comboBox_PointColor.Location = new System.Drawing.Point(776, 388);
            this.comboBox_PointColor.Name = "comboBox_PointColor";
            this.comboBox_PointColor.Size = new System.Drawing.Size(128, 24);
            this.comboBox_PointColor.TabIndex = 8;
            this.comboBox_PointColor.SelectedIndexChanged += new System.EventHandler(this.comboBox_PointColor_SelectedIndexChanged);
            // 
            // comboBox_LineColor
            // 
            this.comboBox_LineColor.FormattingEnabled = true;
            this.comboBox_LineColor.Items.AddRange(new object[] {
            "Blue",
            "Black",
            "Red"});
            this.comboBox_LineColor.Location = new System.Drawing.Point(776, 475);
            this.comboBox_LineColor.Name = "comboBox_LineColor";
            this.comboBox_LineColor.Size = new System.Drawing.Size(128, 24);
            this.comboBox_LineColor.TabIndex = 9;
            this.comboBox_LineColor.SelectedIndexChanged += new System.EventHandler(this.comboBox_LineColor_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(557, 387);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Change Point Color :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(552, 471);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "Change Line Color :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(916, 695);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_LineColor);
            this.Controls.Add(this.comboBox_PointColor);
            this.Controls.Add(this.lblTest);
            this.Controls.Add(this.lblCurveLenght);
            this.Controls.Add(this.lblY);
            this.Controls.Add(this.lblX);
            this.Controls.Add(this.btnCalculateCurveLenght);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.drawingArea);
            this.Name = "Form1";
            this.Text = "Drawing Area";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.drawingArea)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox drawingArea;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnCalculateCurveLenght;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Label lblY;
        private System.Windows.Forms.Label lblCurveLenght;
        private System.Windows.Forms.Label lblTest;
        private System.Windows.Forms.ComboBox comboBox_PointColor;
        private System.Windows.Forms.ComboBox comboBox_LineColor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

