
namespace sayisalLoto
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
            this.sayi1 = new System.Windows.Forms.Label();
            this.sayi2 = new System.Windows.Forms.Label();
            this.sayi3 = new System.Windows.Forms.Label();
            this.rnd1 = new System.Windows.Forms.TextBox();
            this.rnd2 = new System.Windows.Forms.TextBox();
            this.rnd3 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // sayi1
            // 
            this.sayi1.AutoSize = true;
            this.sayi1.Location = new System.Drawing.Point(44, 57);
            this.sayi1.Name = "sayi1";
            this.sayi1.Size = new System.Drawing.Size(46, 17);
            this.sayi1.TabIndex = 0;
            this.sayi1.Text = "label1";
            // 
            // sayi2
            // 
            this.sayi2.AutoSize = true;
            this.sayi2.Location = new System.Drawing.Point(153, 57);
            this.sayi2.Name = "sayi2";
            this.sayi2.Size = new System.Drawing.Size(46, 17);
            this.sayi2.TabIndex = 0;
            this.sayi2.Text = "label1";
            // 
            // sayi3
            // 
            this.sayi3.AutoSize = true;
            this.sayi3.Location = new System.Drawing.Point(240, 57);
            this.sayi3.Name = "sayi3";
            this.sayi3.Size = new System.Drawing.Size(46, 17);
            this.sayi3.TabIndex = 0;
            this.sayi3.Text = "label1";
            // 
            // rnd1
            // 
            this.rnd1.Location = new System.Drawing.Point(47, 91);
            this.rnd1.Name = "rnd1";
            this.rnd1.Size = new System.Drawing.Size(32, 22);
            this.rnd1.TabIndex = 1;
            // 
            // rnd2
            // 
            this.rnd2.Location = new System.Drawing.Point(156, 91);
            this.rnd2.Name = "rnd2";
            this.rnd2.Size = new System.Drawing.Size(32, 22);
            this.rnd2.TabIndex = 1;
            // 
            // rnd3
            // 
            this.rnd3.Location = new System.Drawing.Point(243, 91);
            this.rnd3.Name = "rnd3";
            this.rnd3.Size = new System.Drawing.Size(32, 22);
            this.rnd3.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(96, 143);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 30);
            this.button1.TabIndex = 2;
            this.button1.Text = "Karşılaştır";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 293);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rnd3);
            this.Controls.Add(this.rnd2);
            this.Controls.Add(this.rnd1);
            this.Controls.Add(this.sayi3);
            this.Controls.Add(this.sayi2);
            this.Controls.Add(this.sayi1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label sayi1;
        private System.Windows.Forms.Label sayi2;
        private System.Windows.Forms.Label sayi3;
        private System.Windows.Forms.TextBox rnd1;
        private System.Windows.Forms.TextBox rnd2;
        private System.Windows.Forms.TextBox rnd3;
        private System.Windows.Forms.Button button1;
    }
}

