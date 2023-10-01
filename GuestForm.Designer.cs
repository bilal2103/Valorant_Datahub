namespace Valorant_Datahub
{
    partial class GuestForm
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
            this.weaponary_btn = new System.Windows.Forms.Button();
            this.Agents_btn = new System.Windows.Forms.Button();
            this.Maps_btn = new System.Windows.Forms.Button();
            this.Tournament_btn = new System.Windows.Forms.Button();
            this.Leaderboards_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // weaponary_btn
            // 
            this.weaponary_btn.Location = new System.Drawing.Point(93, 95);
            this.weaponary_btn.Name = "weaponary_btn";
            this.weaponary_btn.Size = new System.Drawing.Size(152, 55);
            this.weaponary_btn.TabIndex = 0;
            this.weaponary_btn.Text = "Weaponary";
            this.weaponary_btn.UseVisualStyleBackColor = true;
            this.weaponary_btn.Click += new System.EventHandler(this.weaponary_btn_Click);
            // 
            // Agents_btn
            // 
            this.Agents_btn.Location = new System.Drawing.Point(93, 189);
            this.Agents_btn.Name = "Agents_btn";
            this.Agents_btn.Size = new System.Drawing.Size(152, 55);
            this.Agents_btn.TabIndex = 1;
            this.Agents_btn.Text = "Agents";
            this.Agents_btn.UseVisualStyleBackColor = true;
            this.Agents_btn.Click += new System.EventHandler(this.Agents_Click);
            // 
            // Maps_btn
            // 
            this.Maps_btn.Location = new System.Drawing.Point(93, 285);
            this.Maps_btn.Name = "Maps_btn";
            this.Maps_btn.Size = new System.Drawing.Size(152, 55);
            this.Maps_btn.TabIndex = 2;
            this.Maps_btn.Text = "Maps";
            this.Maps_btn.UseVisualStyleBackColor = true;
            this.Maps_btn.Click += new System.EventHandler(this.Maps_btn_Click);
            // 
            // Tournament_btn
            // 
            this.Tournament_btn.Location = new System.Drawing.Point(322, 189);
            this.Tournament_btn.Name = "Tournament_btn";
            this.Tournament_btn.Size = new System.Drawing.Size(152, 55);
            this.Tournament_btn.TabIndex = 3;
            this.Tournament_btn.Text = "Tournaments";
            this.Tournament_btn.UseVisualStyleBackColor = true;
            this.Tournament_btn.Click += new System.EventHandler(this.Tournaments_Click);
            // 
            // Leaderboards_btn
            // 
            this.Leaderboards_btn.Location = new System.Drawing.Point(322, 95);
            this.Leaderboards_btn.Name = "Leaderboards_btn";
            this.Leaderboards_btn.Size = new System.Drawing.Size(152, 55);
            this.Leaderboards_btn.TabIndex = 4;
            this.Leaderboards_btn.Text = "Leaderboard";
            this.Leaderboards_btn.UseVisualStyleBackColor = true;
            this.Leaderboards_btn.Click += new System.EventHandler(this.Leaderboards_btn_Click);
            // 
            // GuestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Leaderboards_btn);
            this.Controls.Add(this.Tournament_btn);
            this.Controls.Add(this.Maps_btn);
            this.Controls.Add(this.Agents_btn);
            this.Controls.Add(this.weaponary_btn);
            this.Name = "GuestForm";
            this.Text = "GuestForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GuestForm_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button weaponary_btn;
        private System.Windows.Forms.Button Agents_btn;
        private System.Windows.Forms.Button Maps_btn;
        private System.Windows.Forms.Button Tournament_btn;
        private System.Windows.Forms.Button Leaderboards_btn;
    }
}