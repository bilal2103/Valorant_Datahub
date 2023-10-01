namespace Valorant_Datahub
{
    partial class UserForm
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
            this.Leaderboards_btn = new System.Windows.Forms.Button();
            this.Tournament_btn = new System.Windows.Forms.Button();
            this.Maps_btn = new System.Windows.Forms.Button();
            this.Agents_btn = new System.Windows.Forms.Button();
            this.weaponary_btn = new System.Windows.Forms.Button();
            this.personal_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Leaderboards_btn
            // 
            this.Leaderboards_btn.Location = new System.Drawing.Point(439, 103);
            this.Leaderboards_btn.Name = "Leaderboards_btn";
            this.Leaderboards_btn.Size = new System.Drawing.Size(152, 55);
            this.Leaderboards_btn.TabIndex = 9;
            this.Leaderboards_btn.Text = "Leaderboard";
            this.Leaderboards_btn.UseVisualStyleBackColor = true;
            this.Leaderboards_btn.Click += new System.EventHandler(this.Leaderboards_btn_Click);
            // 
            // Tournament_btn
            // 
            this.Tournament_btn.Location = new System.Drawing.Point(439, 197);
            this.Tournament_btn.Name = "Tournament_btn";
            this.Tournament_btn.Size = new System.Drawing.Size(152, 55);
            this.Tournament_btn.TabIndex = 8;
            this.Tournament_btn.Text = "Tournaments";
            this.Tournament_btn.UseVisualStyleBackColor = true;
            this.Tournament_btn.Click += new System.EventHandler(this.Tournament_btn_Click);
            // 
            // Maps_btn
            // 
            this.Maps_btn.Location = new System.Drawing.Point(210, 293);
            this.Maps_btn.Name = "Maps_btn";
            this.Maps_btn.Size = new System.Drawing.Size(152, 55);
            this.Maps_btn.TabIndex = 7;
            this.Maps_btn.Text = "Maps";
            this.Maps_btn.UseVisualStyleBackColor = true;
            this.Maps_btn.Click += new System.EventHandler(this.Maps_btn_Click);
            // 
            // Agents_btn
            // 
            this.Agents_btn.Location = new System.Drawing.Point(210, 197);
            this.Agents_btn.Name = "Agents_btn";
            this.Agents_btn.Size = new System.Drawing.Size(152, 55);
            this.Agents_btn.TabIndex = 6;
            this.Agents_btn.Text = "Agents";
            this.Agents_btn.UseVisualStyleBackColor = true;
            this.Agents_btn.Click += new System.EventHandler(this.Agents_btn_Click);
            // 
            // weaponary_btn
            // 
            this.weaponary_btn.Location = new System.Drawing.Point(210, 103);
            this.weaponary_btn.Name = "weaponary_btn";
            this.weaponary_btn.Size = new System.Drawing.Size(152, 55);
            this.weaponary_btn.TabIndex = 5;
            this.weaponary_btn.Text = "Weaponary";
            this.weaponary_btn.UseVisualStyleBackColor = true;
            this.weaponary_btn.Click += new System.EventHandler(this.weaponary_btn_Click);
            // 
            // personal_btn
            // 
            this.personal_btn.Location = new System.Drawing.Point(439, 293);
            this.personal_btn.Name = "personal_btn";
            this.personal_btn.Size = new System.Drawing.Size(152, 55);
            this.personal_btn.TabIndex = 10;
            this.personal_btn.Text = "Personal Stats";
            this.personal_btn.UseVisualStyleBackColor = true;
            this.personal_btn.Click += new System.EventHandler(this.personal_btn_Click);
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.personal_btn);
            this.Controls.Add(this.Leaderboards_btn);
            this.Controls.Add(this.Tournament_btn);
            this.Controls.Add(this.Maps_btn);
            this.Controls.Add(this.Agents_btn);
            this.Controls.Add(this.weaponary_btn);
            this.Name = "UserForm";
            this.Text = "UserForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UserForm_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Leaderboards_btn;
        private System.Windows.Forms.Button Tournament_btn;
        private System.Windows.Forms.Button Maps_btn;
        private System.Windows.Forms.Button Agents_btn;
        private System.Windows.Forms.Button weaponary_btn;
        private System.Windows.Forms.Button personal_btn;
    }
}