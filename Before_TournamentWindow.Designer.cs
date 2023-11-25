namespace Valorant_Datahub
{
    partial class Before_TournamentWindow
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.alternate_btn = new System.Windows.Forms.Button();
            this.search_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(72, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Tournament ID: ";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Black;
            this.textBox1.Location = new System.Drawing.Point(344, 187);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(243, 29);
            this.textBox1.TabIndex = 1;
            // 
            // alternate_btn
            // 
            this.alternate_btn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.alternate_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.alternate_btn.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alternate_btn.ForeColor = System.Drawing.Color.Black;
            this.alternate_btn.Location = new System.Drawing.Point(387, 289);
            this.alternate_btn.Name = "alternate_btn";
            this.alternate_btn.Size = new System.Drawing.Size(190, 69);
            this.alternate_btn.TabIndex = 2;
            this.alternate_btn.Text = "Looking for something else?";
            this.alternate_btn.UseVisualStyleBackColor = true;
            this.alternate_btn.Click += new System.EventHandler(this.alternate_btn_Click);
            // 
            // search_btn
            // 
            this.search_btn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.search_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.search_btn.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_btn.ForeColor = System.Drawing.Color.Black;
            this.search_btn.Location = new System.Drawing.Point(126, 289);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(171, 69);
            this.search_btn.TabIndex = 3;
            this.search_btn.Text = "View Details";
            this.search_btn.UseVisualStyleBackColor = true;
            this.search_btn.Click += new System.EventHandler(this.search_btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(12, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(643, 28);
            this.label2.TabIndex = 4;
            this.label2.Text = "View data on tournaments played in valorant\'s history";
            // 
            // Before_TournamentWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.search_btn);
            this.Controls.Add(this.alternate_btn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Before_TournamentWindow";
            this.Text = "Before_TournamentWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button alternate_btn;
        private System.Windows.Forms.Button search_btn;
        private System.Windows.Forms.Label label2;
    }
}