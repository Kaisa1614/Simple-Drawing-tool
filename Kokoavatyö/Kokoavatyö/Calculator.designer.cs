namespace calculator2
{
    partial class calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(calculator));
            this.button_7 = new System.Windows.Forms.Button();
            this.button_8 = new System.Windows.Forms.Button();
            this.button_9 = new System.Windows.Forms.Button();
            this.button_devide = new System.Windows.Forms.Button();
            this.button_ce = new System.Windows.Forms.Button();
            this.button_c = new System.Windows.Forms.Button();
            this.button_multiply = new System.Windows.Forms.Button();
            this.button_6 = new System.Windows.Forms.Button();
            this.button_5 = new System.Windows.Forms.Button();
            this.button_4 = new System.Windows.Forms.Button();
            this.button_minus = new System.Windows.Forms.Button();
            this.button_3 = new System.Windows.Forms.Button();
            this.button_2 = new System.Windows.Forms.Button();
            this.button_1 = new System.Windows.Forms.Button();
            this.button_enter = new System.Windows.Forms.Button();
            this.button_plus = new System.Windows.Forms.Button();
            this.textBox_result = new System.Windows.Forms.TextBox();
            this.labelCurrentOperation = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_7
            // 
            this.button_7.BackColor = System.Drawing.Color.White;
            this.button_7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_7.Location = new System.Drawing.Point(12, 110);
            this.button_7.Name = "button_7";
            this.button_7.Size = new System.Drawing.Size(50, 50);
            this.button_7.TabIndex = 0;
            this.button_7.Text = "7";
            this.button_7.UseVisualStyleBackColor = false;
            this.button_7.Click += new System.EventHandler(this.button_click);
            // 
            // button_8
            // 
            this.button_8.BackColor = System.Drawing.Color.White;
            this.button_8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_8.Location = new System.Drawing.Point(68, 110);
            this.button_8.Name = "button_8";
            this.button_8.Size = new System.Drawing.Size(50, 50);
            this.button_8.TabIndex = 1;
            this.button_8.Text = "8";
            this.button_8.UseVisualStyleBackColor = false;
            this.button_8.Click += new System.EventHandler(this.button_click);
            // 
            // button_9
            // 
            this.button_9.BackColor = System.Drawing.Color.White;
            this.button_9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_9.Location = new System.Drawing.Point(124, 110);
            this.button_9.Name = "button_9";
            this.button_9.Size = new System.Drawing.Size(50, 50);
            this.button_9.TabIndex = 2;
            this.button_9.Text = "9";
            this.button_9.UseVisualStyleBackColor = false;
            this.button_9.Click += new System.EventHandler(this.button_click);
            // 
            // button_devide
            // 
            this.button_devide.BackColor = System.Drawing.Color.White;
            this.button_devide.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_devide.Location = new System.Drawing.Point(180, 110);
            this.button_devide.Name = "button_devide";
            this.button_devide.Size = new System.Drawing.Size(50, 50);
            this.button_devide.TabIndex = 3;
            this.button_devide.Text = "/";
            this.button_devide.UseVisualStyleBackColor = false;
            this.button_devide.Click += new System.EventHandler(this.operator_click);
            // 
            // button_ce
            // 
            this.button_ce.BackColor = System.Drawing.Color.White;
            this.button_ce.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ce.Location = new System.Drawing.Point(17, 289);
            this.button_ce.Name = "button_ce";
            this.button_ce.Size = new System.Drawing.Size(68, 50);
            this.button_ce.TabIndex = 4;
            this.button_ce.Text = "CE";
            this.button_ce.UseVisualStyleBackColor = false;
            this.button_ce.Click += new System.EventHandler(this.button_ce_Click);
            // 
            // button_c
            // 
            this.button_c.BackColor = System.Drawing.Color.White;
            this.button_c.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_c.Location = new System.Drawing.Point(91, 289);
            this.button_c.Name = "button_c";
            this.button_c.Size = new System.Drawing.Size(68, 50);
            this.button_c.TabIndex = 9;
            this.button_c.Text = "C";
            this.button_c.UseVisualStyleBackColor = false;
            this.button_c.Click += new System.EventHandler(this.button_c_Click);
            // 
            // button_multiply
            // 
            this.button_multiply.BackColor = System.Drawing.Color.White;
            this.button_multiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_multiply.Location = new System.Drawing.Point(236, 166);
            this.button_multiply.Name = "button_multiply";
            this.button_multiply.Size = new System.Drawing.Size(50, 50);
            this.button_multiply.TabIndex = 8;
            this.button_multiply.Text = "*";
            this.button_multiply.UseVisualStyleBackColor = false;
            this.button_multiply.Click += new System.EventHandler(this.operator_click);
            // 
            // button_6
            // 
            this.button_6.BackColor = System.Drawing.Color.White;
            this.button_6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_6.Location = new System.Drawing.Point(124, 166);
            this.button_6.Name = "button_6";
            this.button_6.Size = new System.Drawing.Size(50, 50);
            this.button_6.TabIndex = 7;
            this.button_6.Text = "6";
            this.button_6.UseVisualStyleBackColor = false;
            this.button_6.Click += new System.EventHandler(this.button_click);
            // 
            // button_5
            // 
            this.button_5.BackColor = System.Drawing.Color.White;
            this.button_5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_5.Location = new System.Drawing.Point(68, 166);
            this.button_5.Name = "button_5";
            this.button_5.Size = new System.Drawing.Size(50, 50);
            this.button_5.TabIndex = 6;
            this.button_5.Text = "5";
            this.button_5.UseVisualStyleBackColor = false;
            this.button_5.Click += new System.EventHandler(this.button_click);
            // 
            // button_4
            // 
            this.button_4.BackColor = System.Drawing.Color.White;
            this.button_4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_4.Location = new System.Drawing.Point(12, 166);
            this.button_4.Name = "button_4";
            this.button_4.Size = new System.Drawing.Size(50, 50);
            this.button_4.TabIndex = 5;
            this.button_4.Text = "4";
            this.button_4.UseVisualStyleBackColor = false;
            this.button_4.Click += new System.EventHandler(this.button_click);
            // 
            // button_minus
            // 
            this.button_minus.BackColor = System.Drawing.Color.White;
            this.button_minus.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_minus.Location = new System.Drawing.Point(180, 166);
            this.button_minus.Name = "button_minus";
            this.button_minus.Size = new System.Drawing.Size(50, 50);
            this.button_minus.TabIndex = 13;
            this.button_minus.Text = "-";
            this.button_minus.UseVisualStyleBackColor = false;
            this.button_minus.Click += new System.EventHandler(this.operator_click);
            // 
            // button_3
            // 
            this.button_3.BackColor = System.Drawing.Color.White;
            this.button_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_3.Location = new System.Drawing.Point(124, 222);
            this.button_3.Name = "button_3";
            this.button_3.Size = new System.Drawing.Size(50, 50);
            this.button_3.TabIndex = 12;
            this.button_3.Text = "3";
            this.button_3.UseVisualStyleBackColor = false;
            this.button_3.Click += new System.EventHandler(this.button_click);
            // 
            // button_2
            // 
            this.button_2.BackColor = System.Drawing.Color.White;
            this.button_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_2.Location = new System.Drawing.Point(68, 222);
            this.button_2.Name = "button_2";
            this.button_2.Size = new System.Drawing.Size(50, 50);
            this.button_2.TabIndex = 11;
            this.button_2.Text = "2";
            this.button_2.UseVisualStyleBackColor = false;
            this.button_2.Click += new System.EventHandler(this.button_click);
            // 
            // button_1
            // 
            this.button_1.BackColor = System.Drawing.Color.White;
            this.button_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_1.Location = new System.Drawing.Point(12, 222);
            this.button_1.Name = "button_1";
            this.button_1.Size = new System.Drawing.Size(50, 50);
            this.button_1.TabIndex = 10;
            this.button_1.Text = "1";
            this.button_1.UseVisualStyleBackColor = false;
            this.button_1.Click += new System.EventHandler(this.button_click);
            // 
            // button_enter
            // 
            this.button_enter.BackColor = System.Drawing.Color.White;
            this.button_enter.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_enter.Location = new System.Drawing.Point(180, 222);
            this.button_enter.Name = "button_enter";
            this.button_enter.Size = new System.Drawing.Size(106, 117);
            this.button_enter.TabIndex = 19;
            this.button_enter.Text = "=";
            this.button_enter.UseVisualStyleBackColor = false;
            this.button_enter.Click += new System.EventHandler(this.button_enter_Click);
            // 
            // button_plus
            // 
            this.button_plus.BackColor = System.Drawing.Color.White;
            this.button_plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_plus.Location = new System.Drawing.Point(236, 110);
            this.button_plus.Name = "button_plus";
            this.button_plus.Size = new System.Drawing.Size(50, 50);
            this.button_plus.TabIndex = 18;
            this.button_plus.Text = "+";
            this.button_plus.UseVisualStyleBackColor = false;
            this.button_plus.Click += new System.EventHandler(this.operator_click);
            // 
            // textBox_result
            // 
            this.textBox_result.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_result.Location = new System.Drawing.Point(12, 70);
            this.textBox_result.Name = "textBox_result";
            this.textBox_result.Size = new System.Drawing.Size(274, 34);
            this.textBox_result.TabIndex = 20;
            this.textBox_result.Text = "0";
            this.textBox_result.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelCurrentOperation
            // 
            this.labelCurrentOperation.AutoSize = true;
            this.labelCurrentOperation.BackColor = System.Drawing.SystemColors.Window;
            this.labelCurrentOperation.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCurrentOperation.Location = new System.Drawing.Point(12, 38);
            this.labelCurrentOperation.Name = "labelCurrentOperation";
            this.labelCurrentOperation.Size = new System.Drawing.Size(0, 29);
            this.labelCurrentOperation.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(302, 351);
            this.Controls.Add(this.labelCurrentOperation);
            this.Controls.Add(this.textBox_result);
            this.Controls.Add(this.button_enter);
            this.Controls.Add(this.button_plus);
            this.Controls.Add(this.button_minus);
            this.Controls.Add(this.button_3);
            this.Controls.Add(this.button_2);
            this.Controls.Add(this.button_1);
            this.Controls.Add(this.button_c);
            this.Controls.Add(this.button_multiply);
            this.Controls.Add(this.button_6);
            this.Controls.Add(this.button_5);
            this.Controls.Add(this.button_4);
            this.Controls.Add(this.button_ce);
            this.Controls.Add(this.button_devide);
            this.Controls.Add(this.button_9);
            this.Controls.Add(this.button_8);
            this.Controls.Add(this.button_7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_7;
        private System.Windows.Forms.Button button_8;
        private System.Windows.Forms.Button button_9;
        private System.Windows.Forms.Button button_devide;
        private System.Windows.Forms.Button button_ce;
        private System.Windows.Forms.Button button_c;
        private System.Windows.Forms.Button button_multiply;
        private System.Windows.Forms.Button button_6;
        private System.Windows.Forms.Button button_5;
        private System.Windows.Forms.Button button_4;
        private System.Windows.Forms.Button button_minus;
        private System.Windows.Forms.Button button_3;
        private System.Windows.Forms.Button button_2;
        private System.Windows.Forms.Button button_1;
        private System.Windows.Forms.Button button_enter;
        private System.Windows.Forms.Button button_plus;
        private System.Windows.Forms.TextBox textBox_result;
        private System.Windows.Forms.Label labelCurrentOperation;
    }
}

