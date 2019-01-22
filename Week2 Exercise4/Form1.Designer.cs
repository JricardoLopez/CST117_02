namespace Exercise2Tryparse
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
            this.processbutton1 = new System.Windows.Forms.Button();
            this.secondsTextBox1 = new System.Windows.Forms.TextBox();
            this.outputlabel1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // processbutton1
            // 
            this.processbutton1.Location = new System.Drawing.Point(168, 291);
            this.processbutton1.Name = "processbutton1";
            this.processbutton1.Size = new System.Drawing.Size(134, 79);
            this.processbutton1.TabIndex = 0;
            this.processbutton1.Text = "Process";
            this.processbutton1.UseVisualStyleBackColor = true;
            this.processbutton1.Click += new System.EventHandler(this.processbutton1_Click);
            // 
            // secondsTextBox1
            // 
            this.secondsTextBox1.Location = new System.Drawing.Point(426, 59);
            this.secondsTextBox1.Name = "secondsTextBox1";
            this.secondsTextBox1.Size = new System.Drawing.Size(187, 20);
            this.secondsTextBox1.TabIndex = 1;
            this.secondsTextBox1.TextChanged += new System.EventHandler(this.secondsTextBox1_TextChanged);
            // 
            // outputlabel1
            // 
            this.outputlabel1.AutoSize = true;
            this.outputlabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputlabel1.Location = new System.Drawing.Point(164, 140);
            this.outputlabel1.Name = "outputlabel1";
            this.outputlabel1.Size = new System.Drawing.Size(133, 24);
            this.outputlabel1.TabIndex = 2;
            this.outputlabel1.Text = "OUTPUT BOX";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(314, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "ENTER THE TIME IN SECONDS";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.outputlabel1);
            this.Controls.Add(this.secondsTextBox1);
            this.Controls.Add(this.processbutton1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button processbutton1;
        private System.Windows.Forms.TextBox secondsTextBox1;
        private System.Windows.Forms.Label outputlabel1;
        private System.Windows.Forms.Label label1;
    }
}

