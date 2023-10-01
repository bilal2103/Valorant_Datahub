﻿namespace Valorant_Datahub
{
    partial class Agent
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
            this.name_tb = new System.Windows.Forms.TextBox();
            this.category_tb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tier_tb = new System.Windows.Forms.TextBox();
            this.pick_tb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.weapon_tb = new System.Windows.Forms.TextBox();
            this.win_tb = new System.Windows.Forms.TextBox();
            this.agent_picture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.agent_picture)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name: ";
            // 
            // name_tb
            // 
            this.name_tb.Location = new System.Drawing.Point(223, 65);
            this.name_tb.Name = "name_tb";
            this.name_tb.ReadOnly = true;
            this.name_tb.Size = new System.Drawing.Size(100, 22);
            this.name_tb.TabIndex = 1;
            // 
            // category_tb
            // 
            this.category_tb.Location = new System.Drawing.Point(223, 124);
            this.category_tb.Name = "category_tb";
            this.category_tb.ReadOnly = true;
            this.category_tb.Size = new System.Drawing.Size(100, 22);
            this.category_tb.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 265);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Pick Percentage";
            // 
            // tier_tb
            // 
            this.tier_tb.Location = new System.Drawing.Point(223, 194);
            this.tier_tb.Name = "tier_tb";
            this.tier_tb.ReadOnly = true;
            this.tier_tb.Size = new System.Drawing.Size(100, 22);
            this.tier_tb.TabIndex = 5;
            // 
            // pick_tb
            // 
            this.pick_tb.Location = new System.Drawing.Point(223, 259);
            this.pick_tb.Name = "pick_tb";
            this.pick_tb.ReadOnly = true;
            this.pick_tb.Size = new System.Drawing.Size(100, 22);
            this.pick_tb.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = " Category";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 265);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 16);
            this.label5.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 341);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Win Percentage";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(42, 406);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 16);
            this.label7.TabIndex = 9;
            this.label7.Text = "Ideal Weapon";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(42, 200);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 16);
            this.label8.TabIndex = 8;
            this.label8.Text = "Tier";
            // 
            // weapon_tb
            // 
            this.weapon_tb.Location = new System.Drawing.Point(223, 400);
            this.weapon_tb.Name = "weapon_tb";
            this.weapon_tb.ReadOnly = true;
            this.weapon_tb.Size = new System.Drawing.Size(100, 22);
            this.weapon_tb.TabIndex = 13;
            // 
            // win_tb
            // 
            this.win_tb.Location = new System.Drawing.Point(223, 335);
            this.win_tb.Name = "win_tb";
            this.win_tb.ReadOnly = true;
            this.win_tb.Size = new System.Drawing.Size(100, 22);
            this.win_tb.TabIndex = 12;
            // 
            // agent_picture
            // 
            this.agent_picture.Location = new System.Drawing.Point(740, 12);
            this.agent_picture.Name = "agent_picture";
            this.agent_picture.Size = new System.Drawing.Size(428, 711);
            this.agent_picture.TabIndex = 14;
            this.agent_picture.TabStop = false;
            // 
            // Agent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 735);
            this.Controls.Add(this.agent_picture);
            this.Controls.Add(this.weapon_tb);
            this.Controls.Add(this.win_tb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pick_tb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tier_tb);
            this.Controls.Add(this.category_tb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.name_tb);
            this.Controls.Add(this.label1);
            this.Name = "Agent";
            this.Text = "Agent";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Agent_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.agent_picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox name_tb;
        private System.Windows.Forms.TextBox category_tb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tier_tb;
        private System.Windows.Forms.TextBox pick_tb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox weapon_tb;
        private System.Windows.Forms.TextBox win_tb;
        private System.Windows.Forms.PictureBox agent_picture;
    }
}