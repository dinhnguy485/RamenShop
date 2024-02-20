namespace RamenShop
{
    partial class RamenShop
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
            this.ramenLabel = new System.Windows.Forms.Label();
            this.classicInput = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.bobaLabel = new System.Windows.Forms.Label();
            this.banhmiLabel = new System.Windows.Forms.Label();
            this.shopLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ramenLabel
            // 
            this.ramenLabel.AutoSize = true;
            this.ramenLabel.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ramenLabel.Location = new System.Drawing.Point(21, 94);
            this.ramenLabel.Name = "ramenLabel";
            this.ramenLabel.Size = new System.Drawing.Size(82, 19);
            this.ramenLabel.TabIndex = 0;
            this.ramenLabel.Text = "Ramen 🍜";
            // 
            // classicInput
            // 
            this.classicInput.Location = new System.Drawing.Point(119, 95);
            this.classicInput.Name = "classicInput";
            this.classicInput.Size = new System.Drawing.Size(68, 20);
            this.classicInput.TabIndex = 1;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(119, 175);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(68, 20);
            this.maskedTextBox1.TabIndex = 3;
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Location = new System.Drawing.Point(119, 137);
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(68, 20);
            this.maskedTextBox2.TabIndex = 5;
            // 
            // bobaLabel
            // 
            this.bobaLabel.AutoSize = true;
            this.bobaLabel.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bobaLabel.Location = new System.Drawing.Point(21, 136);
            this.bobaLabel.Name = "bobaLabel";
            this.bobaLabel.Size = new System.Drawing.Size(67, 19);
            this.bobaLabel.TabIndex = 4;
            this.bobaLabel.Text = "Boba 🍛";
            // 
            // banhmiLabel
            // 
            this.banhmiLabel.AutoSize = true;
            this.banhmiLabel.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.banhmiLabel.Location = new System.Drawing.Point(21, 174);
            this.banhmiLabel.Name = "banhmiLabel";
            this.banhmiLabel.Size = new System.Drawing.Size(92, 19);
            this.banhmiLabel.TabIndex = 6;
            this.banhmiLabel.Text = "Banh Mi 🥖";
            // 
            // shopLabel
            // 
            this.shopLabel.BackColor = System.Drawing.Color.OliveDrab;
            this.shopLabel.Font = new System.Drawing.Font("Cambria Math", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shopLabel.Location = new System.Drawing.Point(-9, -2);
            this.shopLabel.Name = "shopLabel";
            this.shopLabel.Size = new System.Drawing.Size(591, 77);
            this.shopLabel.TabIndex = 7;
            this.shopLabel.Text = "🥡🍛ASIAN CUISINE 🍲🍘";
            this.shopLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RamenShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(582, 419);
            this.Controls.Add(this.shopLabel);
            this.Controls.Add(this.banhmiLabel);
            this.Controls.Add(this.maskedTextBox2);
            this.Controls.Add(this.bobaLabel);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.classicInput);
            this.Controls.Add(this.ramenLabel);
            this.Name = "RamenShop";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.RamenShop_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ramenLabel;
        private System.Windows.Forms.MaskedTextBox classicInput;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.Label bobaLabel;
        private System.Windows.Forms.Label banhmiLabel;
        private System.Windows.Forms.Label shopLabel;
    }
}

