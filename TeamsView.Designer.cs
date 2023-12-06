
namespace Valorant_Datahub
{
    partial class TeamsView
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.updatebtn = new System.Windows.Forms.Button();
            this.deletebtn = new System.Windows.Forms.Button();
            this.insert_btn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mplayedtxt = new System.Windows.Forms.TextBox();
            this.mwontxt = new System.Windows.Forms.TextBox();
            this.picklbl = new System.Windows.Forms.Label();
            this.namelbl = new System.Windows.Forms.Label();
            this.nametxt = new System.Windows.Forms.TextBox();
            this.idtxt = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.team_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.team_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matches_won = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matches_played = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tournaments_won = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tournaments_played = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tplayedtxt = new System.Windows.Forms.TextBox();
            this.twontxt = new System.Windows.Forms.TextBox();
            this.rollback_btn = new System.Windows.Forms.Button();
            this.commit_btn = new System.Windows.Forms.Button();
            this.refreshbtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.querytb = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // updatebtn
            // 
            this.updatebtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.updatebtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.updatebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updatebtn.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatebtn.Location = new System.Drawing.Point(718, 539);
            this.updatebtn.Name = "updatebtn";
            this.updatebtn.Size = new System.Drawing.Size(193, 51);
            this.updatebtn.TabIndex = 72;
            this.updatebtn.Text = "Update";
            this.updatebtn.UseVisualStyleBackColor = false;
            this.updatebtn.Click += new System.EventHandler(this.updatebtn_Click);
            // 
            // deletebtn
            // 
            this.deletebtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.deletebtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.deletebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deletebtn.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletebtn.Location = new System.Drawing.Point(400, 539);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Size = new System.Drawing.Size(193, 51);
            this.deletebtn.TabIndex = 71;
            this.deletebtn.Text = "Delete";
            this.deletebtn.UseVisualStyleBackColor = false;
            this.deletebtn.Click += new System.EventHandler(this.deletebtn_Click);
            // 
            // insert_btn
            // 
            this.insert_btn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.insert_btn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.insert_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.insert_btn.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insert_btn.Location = new System.Drawing.Point(98, 539);
            this.insert_btn.Name = "insert_btn";
            this.insert_btn.Size = new System.Drawing.Size(193, 51);
            this.insert_btn.TabIndex = 70;
            this.insert_btn.Text = "Insert";
            this.insert_btn.UseVisualStyleBackColor = false;
            this.insert_btn.Click += new System.EventHandler(this.insert_btn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(478, 434);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 20);
            this.label4.TabIndex = 69;
            this.label4.Text = "Matches Played:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(319, 434);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 20);
            this.label3.TabIndex = 68;
            this.label3.Text = "Matches Won:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(562, 434);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 67;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // mplayedtxt
            // 
            this.mplayedtxt.BackColor = System.Drawing.Color.White;
            this.mplayedtxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mplayedtxt.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mplayedtxt.Location = new System.Drawing.Point(473, 468);
            this.mplayedtxt.Name = "mplayedtxt";
            this.mplayedtxt.Size = new System.Drawing.Size(117, 28);
            this.mplayedtxt.TabIndex = 66;
            // 
            // mwontxt
            // 
            this.mwontxt.BackColor = System.Drawing.Color.White;
            this.mwontxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mwontxt.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mwontxt.Location = new System.Drawing.Point(323, 468);
            this.mwontxt.Name = "mwontxt";
            this.mwontxt.Size = new System.Drawing.Size(95, 28);
            this.mwontxt.TabIndex = 65;
            // 
            // picklbl
            // 
            this.picklbl.AutoSize = true;
            this.picklbl.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.picklbl.Location = new System.Drawing.Point(142, 434);
            this.picklbl.Name = "picklbl";
            this.picklbl.Size = new System.Drawing.Size(118, 20);
            this.picklbl.TabIndex = 64;
            this.picklbl.Text = "Team Name:";
            // 
            // namelbl
            // 
            this.namelbl.AutoSize = true;
            this.namelbl.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namelbl.Location = new System.Drawing.Point(34, 434);
            this.namelbl.Name = "namelbl";
            this.namelbl.Size = new System.Drawing.Size(89, 20);
            this.namelbl.TabIndex = 63;
            this.namelbl.Text = "Team ID:";
            // 
            // nametxt
            // 
            this.nametxt.BackColor = System.Drawing.Color.White;
            this.nametxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nametxt.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nametxt.Location = new System.Drawing.Point(146, 468);
            this.nametxt.Name = "nametxt";
            this.nametxt.Size = new System.Drawing.Size(153, 28);
            this.nametxt.TabIndex = 62;
            // 
            // idtxt
            // 
            this.idtxt.BackColor = System.Drawing.Color.White;
            this.idtxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.idtxt.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idtxt.Location = new System.Drawing.Point(38, 468);
            this.idtxt.Name = "idtxt";
            this.idtxt.Size = new System.Drawing.Size(62, 28);
            this.idtxt.TabIndex = 61;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.team_id,
            this.team_name,
            this.matches_won,
            this.matches_played,
            this.tournaments_won,
            this.tournaments_played});
            this.dataGridView1.Location = new System.Drawing.Point(38, 53);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(963, 358);
            this.dataGridView1.TabIndex = 60;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // team_id
            // 
            this.team_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.team_id.HeaderText = "Team ID";
            this.team_id.MinimumWidth = 6;
            this.team_id.Name = "team_id";
            this.team_id.Width = 82;
            // 
            // team_name
            // 
            this.team_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.team_name.HeaderText = "Team Name";
            this.team_name.MinimumWidth = 6;
            this.team_name.Name = "team_name";
            // 
            // matches_won
            // 
            this.matches_won.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.matches_won.HeaderText = "Matches Won";
            this.matches_won.MinimumWidth = 6;
            this.matches_won.Name = "matches_won";
            this.matches_won.Width = 109;
            // 
            // matches_played
            // 
            this.matches_played.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.matches_played.HeaderText = "Matches Played";
            this.matches_played.MinimumWidth = 6;
            this.matches_played.Name = "matches_played";
            this.matches_played.Width = 122;
            // 
            // tournaments_won
            // 
            this.tournaments_won.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.tournaments_won.HeaderText = "Tournaments Won";
            this.tournaments_won.MinimumWidth = 6;
            this.tournaments_won.Name = "tournaments_won";
            this.tournaments_won.Width = 134;
            // 
            // tournaments_played
            // 
            this.tournaments_played.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tournaments_played.HeaderText = "Tournaments Played";
            this.tournaments_played.MinimumWidth = 6;
            this.tournaments_played.Name = "tournaments_played";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(822, 434);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 20);
            this.label1.TabIndex = 77;
            this.label1.Text = "Tournaments Played:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(644, 434);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(171, 20);
            this.label5.TabIndex = 76;
            this.label5.Text = "Tournaments Won:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(823, 414);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 16);
            this.label6.TabIndex = 75;
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // tplayedtxt
            // 
            this.tplayedtxt.BackColor = System.Drawing.Color.White;
            this.tplayedtxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tplayedtxt.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tplayedtxt.Location = new System.Drawing.Point(826, 468);
            this.tplayedtxt.Name = "tplayedtxt";
            this.tplayedtxt.Size = new System.Drawing.Size(175, 28);
            this.tplayedtxt.TabIndex = 74;
            // 
            // twontxt
            // 
            this.twontxt.BackColor = System.Drawing.Color.White;
            this.twontxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.twontxt.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.twontxt.Location = new System.Drawing.Point(648, 468);
            this.twontxt.Name = "twontxt";
            this.twontxt.Size = new System.Drawing.Size(151, 28);
            this.twontxt.TabIndex = 73;
            // 
            // rollback_btn
            // 
            this.rollback_btn.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.rollback_btn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.rollback_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rollback_btn.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rollback_btn.Location = new System.Drawing.Point(400, 620);
            this.rollback_btn.Name = "rollback_btn";
            this.rollback_btn.Size = new System.Drawing.Size(193, 51);
            this.rollback_btn.TabIndex = 110;
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
            this.commit_btn.Location = new System.Drawing.Point(98, 620);
            this.commit_btn.Name = "commit_btn";
            this.commit_btn.Size = new System.Drawing.Size(193, 51);
            this.commit_btn.TabIndex = 109;
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
            this.refreshbtn.Location = new System.Drawing.Point(718, 620);
            this.refreshbtn.Name = "refreshbtn";
            this.refreshbtn.Size = new System.Drawing.Size(193, 51);
            this.refreshbtn.TabIndex = 111;
            this.refreshbtn.Text = "Refresh";
            this.refreshbtn.UseVisualStyleBackColor = false;
            this.refreshbtn.Click += new System.EventHandler(this.refreshbtn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(35, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 16);
            this.label7.TabIndex = 113;
            this.label7.Text = "Enter query here:";
            // 
            // querytb
            // 
            this.querytb.Location = new System.Drawing.Point(173, 9);
            this.querytb.Name = "querytb";
            this.querytb.Size = new System.Drawing.Size(828, 22);
            this.querytb.TabIndex = 112;
            this.querytb.Text = "select * from maps where ";
            this.querytb.TextChanged += new System.EventHandler(this.querytb_TextChanged);
            this.querytb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.querytb_KeyPress);
            // 
            // TeamsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 702);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.querytb);
            this.Controls.Add(this.refreshbtn);
            this.Controls.Add(this.rollback_btn);
            this.Controls.Add(this.commit_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tplayedtxt);
            this.Controls.Add(this.twontxt);
            this.Controls.Add(this.updatebtn);
            this.Controls.Add(this.deletebtn);
            this.Controls.Add(this.insert_btn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mplayedtxt);
            this.Controls.Add(this.mwontxt);
            this.Controls.Add(this.picklbl);
            this.Controls.Add(this.namelbl);
            this.Controls.Add(this.nametxt);
            this.Controls.Add(this.idtxt);
            this.Controls.Add(this.dataGridView1);
            this.Name = "TeamsView";
            this.Text = "TeamsView";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TeamsView_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button updatebtn;
        private System.Windows.Forms.Button deletebtn;
        private System.Windows.Forms.Button insert_btn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox mplayedtxt;
        private System.Windows.Forms.TextBox mwontxt;
        private System.Windows.Forms.Label picklbl;
        private System.Windows.Forms.Label namelbl;
        private System.Windows.Forms.TextBox nametxt;
        private System.Windows.Forms.TextBox idtxt;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tplayedtxt;
        private System.Windows.Forms.TextBox twontxt;
        private System.Windows.Forms.DataGridViewTextBoxColumn team_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn team_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn matches_won;
        private System.Windows.Forms.DataGridViewTextBoxColumn matches_played;
        private System.Windows.Forms.DataGridViewTextBoxColumn tournaments_won;
        private System.Windows.Forms.DataGridViewTextBoxColumn tournaments_played;
        private System.Windows.Forms.Button rollback_btn;
        private System.Windows.Forms.Button commit_btn;
        private System.Windows.Forms.Button refreshbtn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox querytb;
    }
}