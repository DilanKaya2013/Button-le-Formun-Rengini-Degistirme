namespace örn01
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
            this.btnKırmızı = new System.Windows.Forms.Button();
            this.btnMor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnKırmızı
            // 
            this.btnKırmızı.BackColor = System.Drawing.Color.Red;
            this.btnKırmızı.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKırmızı.ForeColor = System.Drawing.Color.White;
            this.btnKırmızı.Location = new System.Drawing.Point(103, 45);
            this.btnKırmızı.Name = "btnKırmızı";
            this.btnKırmızı.Size = new System.Drawing.Size(125, 68);
            this.btnKırmızı.TabIndex = 0;
            this.btnKırmızı.Text = "kırmızı";
            this.btnKırmızı.UseVisualStyleBackColor = false;
            this.btnKırmızı.Click += new System.EventHandler(this.btnKırmızı_Click);
            // 
            // btnMor
            // 
            this.btnMor.BackColor = System.Drawing.Color.DarkViolet;
            this.btnMor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMor.ForeColor = System.Drawing.Color.White;
            this.btnMor.Location = new System.Drawing.Point(274, 45);
            this.btnMor.Name = "btnMor";
            this.btnMor.Size = new System.Drawing.Size(125, 68);
            this.btnMor.TabIndex = 1;
            this.btnMor.Text = "Mor";
            this.btnMor.UseVisualStyleBackColor = false;
            this.btnMor.Click += new System.EventHandler(this.btnMor_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMor);
            this.Controls.Add(this.btnKırmızı);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnKırmızı;
        private System.Windows.Forms.Button btnMor;
    }
}

