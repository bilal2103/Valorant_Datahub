
namespace Valorant_Datahub
{
    partial class AdminWindow
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
            this.agentsbtn = new System.Windows.Forms.Button();
            this.mapsbtn = new System.Windows.Forms.Button();
            this.weaponrybtn = new System.Windows.Forms.Button();
            this.playersbtn = new System.Windows.Forms.Button();
            this.locationbtn = new System.Windows.Forms.Button();
            this.teamsbtn = new System.Windows.Forms.Button();
            this.matchesbtn = new System.Windows.Forms.Button();
            this.tournamentsbtn = new System.Windows.Forms.Button();
            this.THbtn = new System.Windows.Forms.Button();
            this.solobtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // agentsbtn
            // 
            this.agentsbtn.Location = new System.Drawing.Point(74, 98);
            this.agentsbtn.Name = "agentsbtn";
            this.agentsbtn.Size = new System.Drawing.Size(157, 55);
            this.agentsbtn.TabIndex = 2;
            this.agentsbtn.Text = "Agents";
            this.agentsbtn.UseVisualStyleBackColor = true;
            this.agentsbtn.Click += new System.EventHandler(this.agentsbtn_Click);
            // 
            // mapsbtn
            // 
            this.mapsbtn.Location = new System.Drawing.Point(74, 261);
            this.mapsbtn.Name = "mapsbtn";
            this.mapsbtn.Size = new System.Drawing.Size(157, 55);
            this.mapsbtn.TabIndex = 3;
            this.mapsbtn.Text = "Maps";
            this.mapsbtn.UseVisualStyleBackColor = true;
            this.mapsbtn.Click += new System.EventHandler(this.mapsbtn_Click);
            // 
            // weaponrybtn
            // 
            this.weaponrybtn.Location = new System.Drawing.Point(74, 345);
            this.weaponrybtn.Name = "weaponrybtn";
            this.weaponrybtn.Size = new System.Drawing.Size(157, 55);
            this.weaponrybtn.TabIndex = 4;
            this.weaponrybtn.Text = "Weaponry";
            this.weaponrybtn.UseVisualStyleBackColor = true;
            this.weaponrybtn.Click += new System.EventHandler(this.weaponrybtn_Click);
            // 
            // playersbtn
            // 
            this.playersbtn.Location = new System.Drawing.Point(74, 179);
            this.playersbtn.Name = "playersbtn";
            this.playersbtn.Size = new System.Drawing.Size(157, 55);
            this.playersbtn.TabIndex = 5;
            this.playersbtn.Text = "Players";
            this.playersbtn.UseVisualStyleBackColor = true;
            this.playersbtn.Click += new System.EventHandler(this.playersbtn_Click);
            // 
            // locationbtn
            // 
            this.locationbtn.Location = new System.Drawing.Point(296, 98);
            this.locationbtn.Name = "locationbtn";
            this.locationbtn.Size = new System.Drawing.Size(157, 55);
            this.locationbtn.TabIndex = 6;
            this.locationbtn.Text = "Locations";
            this.locationbtn.UseVisualStyleBackColor = true;
            this.locationbtn.Click += new System.EventHandler(this.locationbtn_Click);
            // 
            // teamsbtn
            // 
            this.teamsbtn.Location = new System.Drawing.Point(296, 179);
            this.teamsbtn.Name = "teamsbtn";
            this.teamsbtn.Size = new System.Drawing.Size(157, 55);
            this.teamsbtn.TabIndex = 7;
            this.teamsbtn.Text = "Teams";
            this.teamsbtn.UseVisualStyleBackColor = true;
            this.teamsbtn.Click += new System.EventHandler(this.teamsbtn_Click);
            // 
            // matchesbtn
            // 
            this.matchesbtn.Location = new System.Drawing.Point(296, 261);
            this.matchesbtn.Name = "matchesbtn";
            this.matchesbtn.Size = new System.Drawing.Size(157, 55);
            this.matchesbtn.TabIndex = 8;
            this.matchesbtn.Text = "Matches";
            this.matchesbtn.UseVisualStyleBackColor = true;
            this.matchesbtn.Click += new System.EventHandler(this.matchesbtn_Click);
            // 
            // tournamentsbtn
            // 
            this.tournamentsbtn.Location = new System.Drawing.Point(296, 345);
            this.tournamentsbtn.Name = "tournamentsbtn";
            this.tournamentsbtn.Size = new System.Drawing.Size(157, 55);
            this.tournamentsbtn.TabIndex = 9;
            this.tournamentsbtn.Text = "Tournaments";
            this.tournamentsbtn.UseVisualStyleBackColor = true;
            this.tournamentsbtn.Click += new System.EventHandler(this.tournamentsbtn_Click);
            // 
            // THbtn
            // 
            this.THbtn.Location = new System.Drawing.Point(507, 98);
            this.THbtn.Name = "THbtn";
            this.THbtn.Size = new System.Drawing.Size(157, 55);
            this.THbtn.TabIndex = 10;
            this.THbtn.Text = "Tournaments History";
            this.THbtn.UseVisualStyleBackColor = true;
            this.THbtn.Click += new System.EventHandler(this.THbtn_Click);
            // 
            // solobtn
            // 
            this.solobtn.Location = new System.Drawing.Point(507, 179);
            this.solobtn.Name = "solobtn";
            this.solobtn.Size = new System.Drawing.Size(157, 55);
            this.solobtn.TabIndex = 11;
            this.solobtn.Text = "Solo Matches";
            this.solobtn.UseVisualStyleBackColor = true;
            this.solobtn.Click += new System.EventHandler(this.solobtn_Click);
            // 
            // AdminWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.solobtn);
            this.Controls.Add(this.THbtn);
            this.Controls.Add(this.tournamentsbtn);
            this.Controls.Add(this.matchesbtn);
            this.Controls.Add(this.teamsbtn);
            this.Controls.Add(this.locationbtn);
            this.Controls.Add(this.playersbtn);
            this.Controls.Add(this.weaponrybtn);
            this.Controls.Add(this.mapsbtn);
            this.Controls.Add(this.agentsbtn);
            this.Name = "AdminWindow";
            this.Text = "Admin";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button agentsbtn;
        private System.Windows.Forms.Button mapsbtn;
        private System.Windows.Forms.Button weaponrybtn;
        private System.Windows.Forms.Button playersbtn;
        private System.Windows.Forms.Button locationbtn;
        private System.Windows.Forms.Button teamsbtn;
        private System.Windows.Forms.Button matchesbtn;
        private System.Windows.Forms.Button tournamentsbtn;
        private System.Windows.Forms.Button THbtn;
        private System.Windows.Forms.Button solobtn;
    }
}