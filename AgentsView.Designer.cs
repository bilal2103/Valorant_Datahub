
namespace Valorant_Datahub
{
    partial class AgentsView
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pick_pct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.win_pct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.suited_weapon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ultimate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.voiced_by = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nametxt = new System.Windows.Forms.TextBox();
            this.picktxt = new System.Windows.Forms.TextBox();
            this.wintxt = new System.Windows.Forms.TextBox();
            this.namelbl = new System.Windows.Forms.Label();
            this.picklbl = new System.Windows.Forms.Label();
            this.winlbl = new System.Windows.Forms.Label();
            this.tiertxt = new System.Windows.Forms.TextBox();
            this.roletxt = new System.Windows.Forms.TextBox();
            this.weapontxt = new System.Windows.Forms.TextBox();
            this.ultimatetxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.desctxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.voicetxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.insert_btn = new System.Windows.Forms.Button();
            this.deletebtn = new System.Windows.Forms.Button();
            this.updatebtn = new System.Windows.Forms.Button();
            this.rollback_btn = new System.Windows.Forms.Button();
            this.commit_btn = new System.Windows.Forms.Button();
            this.refreshbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.pick_pct,
            this.win_pct,
            this.tier,
            this.role,
            this.suited_weapon,
            this.ultimate,
            this.voiced_by,
            this.description});
            this.dataGridView1.Location = new System.Drawing.Point(35, 66);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1127, 349);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.name.HeaderText = "Name";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            this.name.Width = 73;
            // 
            // pick_pct
            // 
            this.pick_pct.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.pick_pct.HeaderText = "Pick Percentage";
            this.pick_pct.MinimumWidth = 6;
            this.pick_pct.Name = "pick_pct";
            this.pick_pct.Width = 124;
            // 
            // win_pct
            // 
            this.win_pct.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.win_pct.HeaderText = "Win Percentage";
            this.win_pct.MinimumWidth = 6;
            this.win_pct.Name = "win_pct";
            this.win_pct.Width = 121;
            // 
            // tier
            // 
            this.tier.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.tier.HeaderText = "Tier";
            this.tier.MinimumWidth = 6;
            this.tier.Name = "tier";
            this.tier.Width = 60;
            // 
            // role
            // 
            this.role.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.role.HeaderText = "Role";
            this.role.MinimumWidth = 6;
            this.role.Name = "role";
            this.role.Width = 65;
            // 
            // suited_weapon
            // 
            this.suited_weapon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.suited_weapon.HeaderText = "Suited Weapon";
            this.suited_weapon.MinimumWidth = 6;
            this.suited_weapon.Name = "suited_weapon";
            this.suited_weapon.Width = 119;
            // 
            // ultimate
            // 
            this.ultimate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ultimate.HeaderText = "Ultimate";
            this.ultimate.MinimumWidth = 6;
            this.ultimate.Name = "ultimate";
            this.ultimate.Width = 85;
            // 
            // voiced_by
            // 
            this.voiced_by.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.voiced_by.HeaderText = "Voiced By";
            this.voiced_by.MinimumWidth = 6;
            this.voiced_by.Name = "voiced_by";
            this.voiced_by.Width = 91;
            // 
            // description
            // 
            this.description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.description.HeaderText = "Description";
            this.description.MinimumWidth = 6;
            this.description.Name = "description";
            this.description.Width = 104;
            // 
            // nametxt
            // 
            this.nametxt.BackColor = System.Drawing.Color.White;
            this.nametxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nametxt.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nametxt.Location = new System.Drawing.Point(45, 477);
            this.nametxt.Name = "nametxt";
            this.nametxt.Size = new System.Drawing.Size(141, 28);
            this.nametxt.TabIndex = 1;
            // 
            // picktxt
            // 
            this.picktxt.BackColor = System.Drawing.Color.White;
            this.picktxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picktxt.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.picktxt.Location = new System.Drawing.Point(212, 477);
            this.picktxt.Name = "picktxt";
            this.picktxt.Size = new System.Drawing.Size(100, 28);
            this.picktxt.TabIndex = 3;
            // 
            // wintxt
            // 
            this.wintxt.BackColor = System.Drawing.Color.White;
            this.wintxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.wintxt.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wintxt.Location = new System.Drawing.Point(370, 477);
            this.wintxt.Name = "wintxt";
            this.wintxt.Size = new System.Drawing.Size(100, 28);
            this.wintxt.TabIndex = 4;
            // 
            // namelbl
            // 
            this.namelbl.AutoSize = true;
            this.namelbl.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namelbl.Location = new System.Drawing.Point(41, 447);
            this.namelbl.Name = "namelbl";
            this.namelbl.Size = new System.Drawing.Size(67, 20);
            this.namelbl.TabIndex = 5;
            this.namelbl.Text = "Name:";
            // 
            // picklbl
            // 
            this.picklbl.AutoSize = true;
            this.picklbl.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.picklbl.Location = new System.Drawing.Point(208, 447);
            this.picklbl.Name = "picklbl";
            this.picklbl.Size = new System.Drawing.Size(84, 20);
            this.picklbl.TabIndex = 6;
            this.picklbl.Text = "Pick pct:";
            // 
            // winlbl
            // 
            this.winlbl.AutoSize = true;
            this.winlbl.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.winlbl.Location = new System.Drawing.Point(366, 447);
            this.winlbl.Name = "winlbl";
            this.winlbl.Size = new System.Drawing.Size(83, 20);
            this.winlbl.TabIndex = 7;
            this.winlbl.Text = "Win pct:";
            // 
            // tiertxt
            // 
            this.tiertxt.BackColor = System.Drawing.Color.White;
            this.tiertxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tiertxt.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tiertxt.Location = new System.Drawing.Point(517, 477);
            this.tiertxt.Name = "tiertxt";
            this.tiertxt.Size = new System.Drawing.Size(100, 28);
            this.tiertxt.TabIndex = 8;
            // 
            // roletxt
            // 
            this.roletxt.BackColor = System.Drawing.Color.White;
            this.roletxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.roletxt.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roletxt.Location = new System.Drawing.Point(683, 477);
            this.roletxt.Name = "roletxt";
            this.roletxt.Size = new System.Drawing.Size(138, 28);
            this.roletxt.TabIndex = 9;
            // 
            // weapontxt
            // 
            this.weapontxt.BackColor = System.Drawing.Color.White;
            this.weapontxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.weapontxt.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weapontxt.Location = new System.Drawing.Point(878, 477);
            this.weapontxt.Name = "weapontxt";
            this.weapontxt.Size = new System.Drawing.Size(174, 28);
            this.weapontxt.TabIndex = 10;
            // 
            // ultimatetxt
            // 
            this.ultimatetxt.BackColor = System.Drawing.Color.White;
            this.ultimatetxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ultimatetxt.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultimatetxt.Location = new System.Drawing.Point(683, 537);
            this.ultimatetxt.Name = "ultimatetxt";
            this.ultimatetxt.Size = new System.Drawing.Size(164, 28);
            this.ultimatetxt.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(513, 447);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Tier:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(679, 447);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Role:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(874, 447);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Suited Weapon:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(680, 511);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Ultimate:";
            // 
            // desctxt
            // 
            this.desctxt.BackColor = System.Drawing.Color.White;
            this.desctxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.desctxt.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desctxt.Location = new System.Drawing.Point(45, 537);
            this.desctxt.Name = "desctxt";
            this.desctxt.Size = new System.Drawing.Size(597, 28);
            this.desctxt.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(41, 508);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "Description:";
            // 
            // voicetxt
            // 
            this.voicetxt.BackColor = System.Drawing.Color.White;
            this.voicetxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.voicetxt.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.voicetxt.Location = new System.Drawing.Point(877, 534);
            this.voicetxt.Name = "voicetxt";
            this.voicetxt.Size = new System.Drawing.Size(209, 28);
            this.voicetxt.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(874, 508);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 20);
            this.label6.TabIndex = 19;
            this.label6.Text = "Voiced By:";
            // 
            // insert_btn
            // 
            this.insert_btn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.insert_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.insert_btn.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insert_btn.ForeColor = System.Drawing.Color.Black;
            this.insert_btn.Location = new System.Drawing.Point(212, 603);
            this.insert_btn.Name = "insert_btn";
            this.insert_btn.Size = new System.Drawing.Size(198, 54);
            this.insert_btn.TabIndex = 20;
            this.insert_btn.Text = "Insert";
            this.insert_btn.UseVisualStyleBackColor = true;
            this.insert_btn.Click += new System.EventHandler(this.insert_btn_Click);
            // 
            // deletebtn
            // 
            this.deletebtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.deletebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deletebtn.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletebtn.ForeColor = System.Drawing.Color.Black;
            this.deletebtn.Location = new System.Drawing.Point(490, 603);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Size = new System.Drawing.Size(202, 54);
            this.deletebtn.TabIndex = 21;
            this.deletebtn.Text = "Delete";
            this.deletebtn.UseVisualStyleBackColor = true;
            this.deletebtn.Click += new System.EventHandler(this.deletebtn_Click);
            // 
            // updatebtn
            // 
            this.updatebtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.updatebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updatebtn.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatebtn.ForeColor = System.Drawing.Color.Black;
            this.updatebtn.Location = new System.Drawing.Point(784, 603);
            this.updatebtn.Name = "updatebtn";
            this.updatebtn.Size = new System.Drawing.Size(194, 54);
            this.updatebtn.TabIndex = 22;
            this.updatebtn.Text = "Update";
            this.updatebtn.UseVisualStyleBackColor = true;
            this.updatebtn.Click += new System.EventHandler(this.updatebtn_Click);
            // 
            // rollback_btn
            // 
            this.rollback_btn.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.rollback_btn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.rollback_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rollback_btn.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rollback_btn.Location = new System.Drawing.Point(490, 694);
            this.rollback_btn.Name = "rollback_btn";
            this.rollback_btn.Size = new System.Drawing.Size(202, 54);
            this.rollback_btn.TabIndex = 100;
            this.rollback_btn.Text = "Rollback";
            this.rollback_btn.UseVisualStyleBackColor = false;
            this.rollback_btn.Click += new System.EventHandler(this.rollback_btn_Click);
            // 
            // commit_btn
            // 
            this.commit_btn.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.commit_btn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.commit_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.commit_btn.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.commit_btn.Location = new System.Drawing.Point(212, 696);
            this.commit_btn.Name = "commit_btn";
            this.commit_btn.Size = new System.Drawing.Size(202, 54);
            this.commit_btn.TabIndex = 99;
            this.commit_btn.Text = "Commit";
            this.commit_btn.UseVisualStyleBackColor = false;
            this.commit_btn.Click += new System.EventHandler(this.commit_btn_Click);
            // 
            // refreshbtn
            // 
            this.refreshbtn.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.refreshbtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.refreshbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refreshbtn.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshbtn.Location = new System.Drawing.Point(782, 694);
            this.refreshbtn.Name = "refreshbtn";
            this.refreshbtn.Size = new System.Drawing.Size(202, 54);
            this.refreshbtn.TabIndex = 112;
            this.refreshbtn.Text = "Refresh";
            this.refreshbtn.UseVisualStyleBackColor = false;
            this.refreshbtn.Click += new System.EventHandler(this.refreshbtn_Click);
            // 
            // AgentsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1171, 774);
            this.Controls.Add(this.refreshbtn);
            this.Controls.Add(this.rollback_btn);
            this.Controls.Add(this.commit_btn);
            this.Controls.Add(this.updatebtn);
            this.Controls.Add(this.deletebtn);
            this.Controls.Add(this.insert_btn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.voicetxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.desctxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ultimatetxt);
            this.Controls.Add(this.weapontxt);
            this.Controls.Add(this.roletxt);
            this.Controls.Add(this.tiertxt);
            this.Controls.Add(this.winlbl);
            this.Controls.Add(this.picklbl);
            this.Controls.Add(this.namelbl);
            this.Controls.Add(this.wintxt);
            this.Controls.Add(this.picktxt);
            this.Controls.Add(this.nametxt);
            this.Controls.Add(this.dataGridView1);
            this.Name = "AgentsView";
            this.Text = "AgentsView";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AgentsView_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox nametxt;
        private System.Windows.Forms.TextBox picktxt;
        private System.Windows.Forms.TextBox wintxt;
        private System.Windows.Forms.Label namelbl;
        private System.Windows.Forms.Label picklbl;
        private System.Windows.Forms.Label winlbl;
        private System.Windows.Forms.TextBox tiertxt;
        private System.Windows.Forms.TextBox roletxt;
        private System.Windows.Forms.TextBox weapontxt;
        private System.Windows.Forms.TextBox ultimatetxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox desctxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox voicetxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button insert_btn;
        private System.Windows.Forms.Button deletebtn;
        private System.Windows.Forms.Button updatebtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn pick_pct;
        private System.Windows.Forms.DataGridViewTextBoxColumn win_pct;
        private System.Windows.Forms.DataGridViewTextBoxColumn tier;
        private System.Windows.Forms.DataGridViewTextBoxColumn role;
        private System.Windows.Forms.DataGridViewTextBoxColumn suited_weapon;
        private System.Windows.Forms.DataGridViewTextBoxColumn ultimate;
        private System.Windows.Forms.DataGridViewTextBoxColumn voiced_by;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.Button rollback_btn;
        private System.Windows.Forms.Button commit_btn;
        private System.Windows.Forms.Button refreshbtn;
    }
}