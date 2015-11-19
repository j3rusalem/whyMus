namespace WHY_MUSIC
{
    partial class ri
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
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Форма для мониторинга кнопок";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 45);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 38);
            this.button1.TabIndex = 1;
            this.button1.Text = "Check num lock state";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(154, 45);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(81, 37);
            this.button2.TabIndex = 3;
            this.button2.Text = "Check caps lock state";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(161, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 4;
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Location = new System.Drawing.Point(13, 137);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(79, 13);
            this.username.TabIndex = 5;
            this.username.Text = "*USER NAME*";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(16, 186);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(175, 21);
            this.richTextBox1.TabIndex = 6;
            this.richTextBox1.Text = "Bakhmut Roman as team lead;\nPaskhalnii Mihail;\nAnton Lushenko;\nPiorunskii Phillip" +
    ";\n";
            // 
            // ri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(282, 264);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.username);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "ri";
            this.Text = "sostoyanie";
            this.Load += new System.EventHandler(this.sostoyanie_Load);
            this.TextChanged += new System.EventHandler(this.sostoyanie_TextChanged);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.sostoyanie_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}