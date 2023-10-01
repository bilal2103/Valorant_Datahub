namespace Valorant_Datahub
{
    partial class Maps
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.weapon_tb = new System.Windows.Forms.TextBox();
            this.location_tb = new System.Windows.Forms.TextBox();
            this.teleportation_tb = new System.Windows.Forms.TextBox();
            this.sites_tb = new System.Windows.Forms.TextBox();
            this.name_tb = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Teleportation: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 310);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ideal Weapon";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Location:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Spike Sites:";
            // 
            // weapon_tb
            // 
            this.weapon_tb.Location = new System.Drawing.Point(190, 304);
            this.weapon_tb.Name = "weapon_tb";
            this.weapon_tb.ReadOnly = true;
            this.weapon_tb.Size = new System.Drawing.Size(157, 22);
            this.weapon_tb.TabIndex = 21;
            // 
            // location_tb
            // 
            this.location_tb.Location = new System.Drawing.Point(190, 244);
            this.location_tb.Name = "location_tb";
            this.location_tb.ReadOnly = true;
            this.location_tb.Size = new System.Drawing.Size(157, 22);
            this.location_tb.TabIndex = 20;
            // 
            // teleportation_tb
            // 
            this.teleportation_tb.Location = new System.Drawing.Point(190, 184);
            this.teleportation_tb.Name = "teleportation_tb";
            this.teleportation_tb.ReadOnly = true;
            this.teleportation_tb.Size = new System.Drawing.Size(157, 22);
            this.teleportation_tb.TabIndex = 19;
            // 
            // sites_tb
            // 
            this.sites_tb.Location = new System.Drawing.Point(190, 124);
            this.sites_tb.Name = "sites_tb";
            this.sites_tb.ReadOnly = true;
            this.sites_tb.Size = new System.Drawing.Size(157, 22);
            this.sites_tb.TabIndex = 18;
            // 
            // name_tb
            // 
            this.name_tb.Location = new System.Drawing.Point(190, 64);
            this.name_tb.Name = "name_tb";
            this.name_tb.ReadOnly = true;
            this.name_tb.Size = new System.Drawing.Size(157, 22);
            this.name_tb.TabIndex = 17;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(543, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(612, 429);
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(543, 464);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(612, 232);
            this.richTextBox1.TabIndex = 23;
            this.richTextBox1.Text = "";
            // 
            // Maps
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1167, 744);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.weapon_tb);
            this.Controls.Add(this.location_tb);
            this.Controls.Add(this.teleportation_tb);
            this.Controls.Add(this.sites_tb);
            this.Controls.Add(this.name_tb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Maps";
            this.Text = "Maps";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Maps_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox weapon_tb;
        private System.Windows.Forms.TextBox location_tb;
        private System.Windows.Forms.TextBox teleportation_tb;
        private System.Windows.Forms.TextBox sites_tb;
        private System.Windows.Forms.TextBox name_tb;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}