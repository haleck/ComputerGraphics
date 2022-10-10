namespace Computer_Graphics
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
            this.button1 = new System.Windows.Forms.Button();
            this.MoveRightBtn = new System.Windows.Forms.Button();
            this.MoveLeftBtn = new System.Windows.Forms.Button();
            this.MoveUpBtn = new System.Windows.Forms.Button();
            this.MoveDownBtn = new System.Windows.Forms.Button();
            this.RotateValue = new System.Windows.Forms.TextBox();
            this.RotateBtn = new System.Windows.Forms.Button();
            this.ScaleValueX = new System.Windows.Forms.TextBox();
            this.ScaleBtnX = new System.Windows.Forms.Button();
            this.ScaleValueY = new System.Windows.Forms.TextBox();
            this.ScaleBtnY = new System.Windows.Forms.Button();
            this.ReflectionBtnX = new System.Windows.Forms.Button();
            this.ReflectionBtnY = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(12, 593);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MoveRightBtn
            // 
            this.MoveRightBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MoveRightBtn.Location = new System.Drawing.Point(1002, 410);
            this.MoveRightBtn.Name = "MoveRightBtn";
            this.MoveRightBtn.Size = new System.Drawing.Size(30, 30);
            this.MoveRightBtn.TabIndex = 1;
            this.MoveRightBtn.Text = "→";
            this.MoveRightBtn.UseVisualStyleBackColor = true;
            this.MoveRightBtn.Click += new System.EventHandler(this.MoveRightBtn_Click);
            // 
            // MoveLeftBtn
            // 
            this.MoveLeftBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MoveLeftBtn.Location = new System.Drawing.Point(930, 410);
            this.MoveLeftBtn.Name = "MoveLeftBtn";
            this.MoveLeftBtn.Size = new System.Drawing.Size(30, 30);
            this.MoveLeftBtn.TabIndex = 2;
            this.MoveLeftBtn.Text = "←";
            this.MoveLeftBtn.UseVisualStyleBackColor = true;
            this.MoveLeftBtn.Click += new System.EventHandler(this.MoveLeftBtn_Click);
            // 
            // MoveUpBtn
            // 
            this.MoveUpBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MoveUpBtn.Location = new System.Drawing.Point(966, 374);
            this.MoveUpBtn.Name = "MoveUpBtn";
            this.MoveUpBtn.Size = new System.Drawing.Size(30, 30);
            this.MoveUpBtn.TabIndex = 3;
            this.MoveUpBtn.Text = "↑";
            this.MoveUpBtn.UseVisualStyleBackColor = true;
            this.MoveUpBtn.Click += new System.EventHandler(this.MoveUpBtn_Click);
            // 
            // MoveDownBtn
            // 
            this.MoveDownBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MoveDownBtn.Location = new System.Drawing.Point(966, 410);
            this.MoveDownBtn.Name = "MoveDownBtn";
            this.MoveDownBtn.Size = new System.Drawing.Size(30, 30);
            this.MoveDownBtn.TabIndex = 4;
            this.MoveDownBtn.Text = "↓";
            this.MoveDownBtn.UseVisualStyleBackColor = true;
            this.MoveDownBtn.Click += new System.EventHandler(this.MoveDownBtn_Click);
            // 
            // RotateValue
            // 
            this.RotateValue.Location = new System.Drawing.Point(860, 540);
            this.RotateValue.Name = "RotateValue";
            this.RotateValue.Size = new System.Drawing.Size(100, 23);
            this.RotateValue.TabIndex = 5;
            // 
            // RotateBtn
            // 
            this.RotateBtn.Location = new System.Drawing.Point(966, 540);
            this.RotateBtn.Name = "RotateBtn";
            this.RotateBtn.Size = new System.Drawing.Size(75, 23);
            this.RotateBtn.TabIndex = 6;
            this.RotateBtn.Text = "Rotate";
            this.RotateBtn.UseVisualStyleBackColor = true;
            this.RotateBtn.Click += new System.EventHandler(this.RotateBtn_Click);
            // 
            // ScaleValueX
            // 
            this.ScaleValueX.Location = new System.Drawing.Point(860, 482);
            this.ScaleValueX.Name = "ScaleValueX";
            this.ScaleValueX.Size = new System.Drawing.Size(100, 23);
            this.ScaleValueX.TabIndex = 7;
            // 
            // ScaleBtnX
            // 
            this.ScaleBtnX.Location = new System.Drawing.Point(966, 482);
            this.ScaleBtnX.Name = "ScaleBtnX";
            this.ScaleBtnX.Size = new System.Drawing.Size(75, 23);
            this.ScaleBtnX.TabIndex = 8;
            this.ScaleBtnX.Text = "Scale X";
            this.ScaleBtnX.UseVisualStyleBackColor = true;
            this.ScaleBtnX.Click += new System.EventHandler(this.ScaleBtnX_Click);
            // 
            // ScaleValueY
            // 
            this.ScaleValueY.Location = new System.Drawing.Point(860, 511);
            this.ScaleValueY.Name = "ScaleValueY";
            this.ScaleValueY.Size = new System.Drawing.Size(100, 23);
            this.ScaleValueY.TabIndex = 9;
            // 
            // ScaleBtnY
            // 
            this.ScaleBtnY.Location = new System.Drawing.Point(966, 511);
            this.ScaleBtnY.Name = "ScaleBtnY";
            this.ScaleBtnY.Size = new System.Drawing.Size(75, 23);
            this.ScaleBtnY.TabIndex = 10;
            this.ScaleBtnY.Text = "Scale Y";
            this.ScaleBtnY.UseVisualStyleBackColor = true;
            this.ScaleBtnY.Click += new System.EventHandler(this.ScaleBtnY_Click);
            // 
            // ReflectionBtnX
            // 
            this.ReflectionBtnX.Location = new System.Drawing.Point(860, 569);
            this.ReflectionBtnX.Name = "ReflectionBtnX";
            this.ReflectionBtnX.Size = new System.Drawing.Size(90, 23);
            this.ReflectionBtnX.TabIndex = 11;
            this.ReflectionBtnX.Text = "X Reflection";
            this.ReflectionBtnX.UseVisualStyleBackColor = true;
            this.ReflectionBtnX.Click += new System.EventHandler(this.ReflectionBtnX_Click);
            // 
            // ReflectionBtnY
            // 
            this.ReflectionBtnY.Location = new System.Drawing.Point(951, 569);
            this.ReflectionBtnY.Name = "ReflectionBtnY";
            this.ReflectionBtnY.Size = new System.Drawing.Size(90, 23);
            this.ReflectionBtnY.TabIndex = 12;
            this.ReflectionBtnY.Text = "Y Reflection";
            this.ReflectionBtnY.UseVisualStyleBackColor = true;
            this.ReflectionBtnY.Click += new System.EventHandler(this.ReflectionBtnY_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 628);
            this.Controls.Add(this.ReflectionBtnY);
            this.Controls.Add(this.ReflectionBtnX);
            this.Controls.Add(this.ScaleBtnY);
            this.Controls.Add(this.ScaleValueY);
            this.Controls.Add(this.ScaleBtnX);
            this.Controls.Add(this.ScaleValueX);
            this.Controls.Add(this.RotateBtn);
            this.Controls.Add(this.RotateValue);
            this.Controls.Add(this.MoveDownBtn);
            this.Controls.Add(this.MoveUpBtn);
            this.Controls.Add(this.MoveLeftBtn);
            this.Controls.Add(this.MoveRightBtn);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this.button1_Click);
            this.Click += new System.EventHandler(this.button1_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private Button MoveRightBtn;
        private Button MoveLeftBtn;
        private Button MoveUpBtn;
        private Button MoveDownBtn;
        private TextBox RotateValue;
        private Button RotateBtn;
        private TextBox ScaleValueX;
        private Button ScaleBtnX;
        private TextBox ScaleValueY;
        private Button ScaleBtnY;
        private Button ReflectionBtnX;
        private Button ReflectionBtnY;
    }
}