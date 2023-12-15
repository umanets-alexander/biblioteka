namespace biblioteka
{
    partial class MessageForm
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labeltext = new System.Windows.Forms.Label();
            this.btn_yes = new System.Windows.Forms.Button();
            this.btn_no = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(13, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 128);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labeltext);
            this.panel1.Location = new System.Drawing.Point(149, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(289, 80);
            this.panel1.TabIndex = 1;
            // 
            // labeltext
            // 
            this.labeltext.AllowDrop = true;
            this.labeltext.AutoSize = true;
            this.labeltext.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labeltext.Location = new System.Drawing.Point(0, 0);
            this.labeltext.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labeltext.MaximumSize = new System.Drawing.Size(280, 0);
            this.labeltext.Name = "labeltext";
            this.labeltext.Size = new System.Drawing.Size(0, 16);
            this.labeltext.TabIndex = 0;
            // 
            // btn_yes
            // 
            this.btn_yes.Location = new System.Drawing.Point(348, 101);
            this.btn_yes.Margin = new System.Windows.Forms.Padding(4);
            this.btn_yes.Name = "btn_yes";
            this.btn_yes.Size = new System.Drawing.Size(40, 40);
            this.btn_yes.TabIndex = 1;
            this.btn_yes.UseVisualStyleBackColor = true;
            // 
            // btn_no
            // 
            this.btn_no.Location = new System.Drawing.Point(396, 101);
            this.btn_no.Margin = new System.Windows.Forms.Padding(4);
            this.btn_no.Name = "btn_no";
            this.btn_no.Size = new System.Drawing.Size(40, 40);
            this.btn_no.TabIndex = 2;
            this.btn_no.UseVisualStyleBackColor = true;
            this.btn_no.Click += new System.EventHandler(this.btn_no_Click);
            // 
            // MessageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 152);
            this.Controls.Add(this.btn_no);
            this.Controls.Add(this.btn_yes);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "MessageForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MessageForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_yes;
        private System.Windows.Forms.Button btn_no;
        private System.Windows.Forms.Label labeltext;
    }
}