namespace WindowsFormsApplication5
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtplaintext = new System.Windows.Forms.TextBox();
            this.bttnEnkripto = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtciphertext = new System.Windows.Forms.TextBox();
            this.bttnDekripto = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtdekriptuar = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Plaintext";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtplaintext
            // 
            this.txtplaintext.Location = new System.Drawing.Point(15, 34);
            this.txtplaintext.Name = "txtplaintext";
            this.txtplaintext.Size = new System.Drawing.Size(143, 20);
            this.txtplaintext.TabIndex = 1;
            // 
            // bttnEnkripto
            // 
            this.bttnEnkripto.Location = new System.Drawing.Point(80, 71);
            this.bttnEnkripto.Name = "bttnEnkripto";
            this.bttnEnkripto.Size = new System.Drawing.Size(78, 28);
            this.bttnEnkripto.TabIndex = 2;
            this.bttnEnkripto.Text = "Enkripto";
            this.bttnEnkripto.UseVisualStyleBackColor = true;
            this.bttnEnkripto.Click += new System.EventHandler(this.bttnEnkripto_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ciphertext";
            // 
            // txtciphertext
            // 
            this.txtciphertext.Location = new System.Drawing.Point(15, 137);
            this.txtciphertext.Name = "txtciphertext";
            this.txtciphertext.Size = new System.Drawing.Size(143, 20);
            this.txtciphertext.TabIndex = 4;
            // 
            // bttnDekripto
            // 
            this.bttnDekripto.Location = new System.Drawing.Point(80, 177);
            this.bttnDekripto.Name = "bttnDekripto";
            this.bttnDekripto.Size = new System.Drawing.Size(78, 27);
            this.bttnDekripto.TabIndex = 5;
            this.bttnDekripto.Text = "Dekripto";
            this.bttnDekripto.UseVisualStyleBackColor = true;
            this.bttnDekripto.Click += new System.EventHandler(this.bttnDekripto_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Teksti Dekriptuar";
            // 
            // txtdekriptuar
            // 
            this.txtdekriptuar.Location = new System.Drawing.Point(15, 255);
            this.txtdekriptuar.Name = "txtdekriptuar";
            this.txtdekriptuar.Size = new System.Drawing.Size(143, 20);
            this.txtdekriptuar.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 312);
            this.Controls.Add(this.txtdekriptuar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bttnDekripto);
            this.Controls.Add(this.txtciphertext);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bttnEnkripto);
            this.Controls.Add(this.txtplaintext);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtplaintext;
        private System.Windows.Forms.Button bttnEnkripto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtciphertext;
        private System.Windows.Forms.Button bttnDekripto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtdekriptuar;
    }
}

