namespace Valorant_Datahub
{
    partial class Tournament_Alternate
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.title_tb = new System.Windows.Forms.TextBox();
            this.prize_tb = new System.Windows.Forms.TextBox();
            this.location_tb = new System.Windows.Forms.TextBox();
            this.search_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.Control;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Location = new System.Drawing.Point(12, 23);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(278, 44);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "Fill Atleast One Of The Following:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter Prize Pool: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Enter Tournament\'s Title: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(226, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Enter Tournament\'s Hosting Location";
            // 
            // title_tb
            // 
            this.title_tb.Location = new System.Drawing.Point(279, 77);
            this.title_tb.Name = "title_tb";
            this.title_tb.Size = new System.Drawing.Size(239, 22);
            this.title_tb.TabIndex = 4;
            // 
            // prize_tb
            // 
            this.prize_tb.Location = new System.Drawing.Point(279, 134);
            this.prize_tb.Name = "prize_tb";
            this.prize_tb.Size = new System.Drawing.Size(239, 22);
            this.prize_tb.TabIndex = 5;
            // 
            // location_tb
            // 
            this.location_tb.Location = new System.Drawing.Point(279, 194);
            this.location_tb.Name = "location_tb";
            this.location_tb.Size = new System.Drawing.Size(239, 22);
            this.location_tb.TabIndex = 6;
            // 
            // search_btn
            // 
            this.search_btn.Location = new System.Drawing.Point(211, 270);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(170, 46);
            this.search_btn.TabIndex = 7;
            this.search_btn.Text = "Search";
            this.search_btn.UseVisualStyleBackColor = true;
            this.search_btn.Click += new System.EventHandler(this.search_btn_Click);
            // 
            // Tournament_Alternate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.search_btn);
            this.Controls.Add(this.location_tb);
            this.Controls.Add(this.prize_tb);
            this.Controls.Add(this.title_tb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Tournament_Alternate";
            this.Text = "Tournament_Alternate";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Tournament_Alternate_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox title_tb;
        private System.Windows.Forms.TextBox prize_tb;
        private System.Windows.Forms.TextBox location_tb;
        private System.Windows.Forms.Button search_btn;
    }
}