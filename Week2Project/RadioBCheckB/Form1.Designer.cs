namespace RadioBCheckB
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
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.redradioButton1 = new System.Windows.Forms.RadioButton();
            this.greenradioButton2 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.blueradioButton3 = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.changecolorbutton1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(46, 42);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(80, 17);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.UpdateLabel1);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(46, 94);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(80, 17);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "checkBox2";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // redradioButton1
            // 
            this.redradioButton1.AutoSize = true;
            this.redradioButton1.Location = new System.Drawing.Point(46, 164);
            this.redradioButton1.Name = "redradioButton1";
            this.redradioButton1.Size = new System.Drawing.Size(45, 17);
            this.redradioButton1.TabIndex = 2;
            this.redradioButton1.TabStop = true;
            this.redradioButton1.Text = "Red";
            this.redradioButton1.UseVisualStyleBackColor = true;
            // 
            // greenradioButton2
            // 
            this.greenradioButton2.AutoSize = true;
            this.greenradioButton2.Location = new System.Drawing.Point(46, 210);
            this.greenradioButton2.Name = "greenradioButton2";
            this.greenradioButton2.Size = new System.Drawing.Size(54, 17);
            this.greenradioButton2.TabIndex = 3;
            this.greenradioButton2.TabStop = true;
            this.greenradioButton2.Text = "Green";
            this.greenradioButton2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(231, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(231, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "label2";
            // 
            // blueradioButton3
            // 
            this.blueradioButton3.AutoSize = true;
            this.blueradioButton3.Location = new System.Drawing.Point(46, 260);
            this.blueradioButton3.Name = "blueradioButton3";
            this.blueradioButton3.Size = new System.Drawing.Size(46, 17);
            this.blueradioButton3.TabIndex = 6;
            this.blueradioButton3.TabStop = true;
            this.blueradioButton3.Text = "Blue";
            this.blueradioButton3.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(229, 141);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(208, 149);
            this.panel1.TabIndex = 0;
            // 
            // changecolorbutton1
            // 
            this.changecolorbutton1.Location = new System.Drawing.Point(61, 328);
            this.changecolorbutton1.Name = "changecolorbutton1";
            this.changecolorbutton1.Size = new System.Drawing.Size(139, 54);
            this.changecolorbutton1.TabIndex = 7;
            this.changecolorbutton1.Text = "Change Color";
            this.changecolorbutton1.UseVisualStyleBackColor = true;
            this.changecolorbutton1.Click += new System.EventHandler(this.changecolorbutton1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.changecolorbutton1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.blueradioButton3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.greenradioButton2);
            this.Controls.Add(this.redradioButton1);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.RadioButton redradioButton1;
        private System.Windows.Forms.RadioButton greenradioButton2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton blueradioButton3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button changecolorbutton1;
    }
}

