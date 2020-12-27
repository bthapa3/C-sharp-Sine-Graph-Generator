namespace WindowsFormsApp7
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
            this.fromvalue = new System.Windows.Forms.TextBox();
            this.tovalue = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // fromvalue
            // 
            this.fromvalue.Location = new System.Drawing.Point(202, 17);
            this.fromvalue.Name = "fromvalue";
            this.fromvalue.Size = new System.Drawing.Size(125, 27);
            this.fromvalue.TabIndex = 0;
            this.fromvalue.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.fromvalue.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // tovalue
            // 
            this.tovalue.Location = new System.Drawing.Point(445, 17);
            this.tovalue.Name = "tovalue";
            this.tovalue.Size = new System.Drawing.Size(98, 27);
            this.tovalue.TabIndex = 1;
            this.tovalue.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.tovalue.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox2_KeyDown);
            this.tovalue.Resize += new System.EventHandler(this.Form1_Resize);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "From(In Degrees)";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(333, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "To(In Degrees)";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            this.label2.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1125, 762);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tovalue);
            this.Controls.Add(this.fromvalue);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox fromvalue;
        private System.Windows.Forms.TextBox tovalue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

