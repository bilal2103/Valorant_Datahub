
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
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tplayedtxt = new System.Windows.Forms.TextBox();
            this.twontxt = new System.Windows.Forms.TextBox();
            this.team_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.team_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matches_won = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matches_played = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tournaments_won = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tournaments_played = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // updatebtn
            // 
            this.updatebtn.Location = new System.Drawing.Point(710, 509);
            this.updatebtn.Name = "updatebtn";
            this.updatebtn.Size = new System.Drawing.Size(172, 46);
            this.updatebtn.TabIndex = 72;
            this.updatebtn.Text = "Update";
            this.updatebtn.UseVisualStyleBackColor = true;
            this.updatebtn.Click += new System.EventHandler(this.updatebtn_Click);
            // 
            // deletebtn
            // 
            this.deletebtn.Location = new System.Drawing.Point(392, 509);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Size = new System.Drawing.Size(172, 46);
            this.deletebtn.TabIndex = 71;
            this.deletebtn.Text = "Delete";
            this.deletebtn.UseVisualStyleBackColor = true;
            this.deletebtn.Click += new System.EventHandler(this.deletebtn_Click);
            // 
            // insert_btn
            // 
            this.insert_btn.Location = new System.Drawing.Point(90, 509);
            this.insert_btn.Name = "insert_btn";
            this.insert_btn.Size = new System.Drawing.Size(172, 46);
            this.insert_btn.TabIndex = 70;
            this.insert_btn.Text = "Insert";
            this.insert_btn.UseVisualStyleBackColor = true;
            this.insert_btn.Click += new System.EventHandler(this.insert_btn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(423, 434);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 16);
            this.label4.TabIndex = 69;
            this.label4.Text = "Matches Played:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(286, 434);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 16);
            this.label3.TabIndex = 68;
            this.label3.Text = "Matches Won:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(535, 434);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
            this.label2.TabIndex = 67;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // mplayedtxt
            // 
            this.mplayedtxt.Location = new System.Drawing.Point(418, 454);
            this.mplayedtxt.Name = "mplayedtxt";
            this.mplayedtxt.Size = new System.Drawing.Size(117, 22);
            this.mplayedtxt.TabIndex = 66;
            this.mplayedtxt.TextChanged += new System.EventHandler(this.mplayedtxt_TextChanged);
            // 
            // mwontxt
            // 
            this.mwontxt.Location = new System.Drawing.Point(289, 454);
            this.mwontxt.Name = "mwontxt";
            this.mwontxt.Size = new System.Drawing.Size(95, 22);
            this.mwontxt.TabIndex = 65;
            this.mwontxt.TextChanged += new System.EventHandler(this.mwontxt_TextChanged);
            // 
            // picklbl
            // 
            this.picklbl.AutoSize = true;
            this.picklbl.Location = new System.Drawing.Point(133, 434);
            this.picklbl.Name = "picklbl";
            this.picklbl.Size = new System.Drawing.Size(86, 16);
            this.picklbl.TabIndex = 64;
            this.picklbl.Text = "Team Name:";
            this.picklbl.Click += new System.EventHandler(this.picklbl_Click);
            // 
            // namelbl
            // 
            this.namelbl.AutoSize = true;
            this.namelbl.Location = new System.Drawing.Point(35, 434);
            this.namelbl.Name = "namelbl";
            this.namelbl.Size = new System.Drawing.Size(62, 16);
            this.namelbl.TabIndex = 63;
            this.namelbl.Text = "Team ID:";
            this.namelbl.Click += new System.EventHandler(this.namelbl_Click);
            // 
            // nametxt
            // 
            this.nametxt.Location = new System.Drawing.Point(136, 454);
            this.nametxt.Name = "nametxt";
            this.nametxt.Size = new System.Drawing.Size(124, 22);
            this.nametxt.TabIndex = 62;
            this.nametxt.TextChanged += new System.EventHandler(this.nametxt_TextChanged);
            // 
            // idtxt
            // 
            this.idtxt.Location = new System.Drawing.Point(38, 454);
            this.idtxt.Name = "idtxt";
            this.idtxt.Size = new System.Drawing.Size(62, 22);
            this.idtxt.TabIndex = 61;
            this.idtxt.TextChanged += new System.EventHandler(this.idtxt_TextChanged);
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
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(896, 358);
            this.dataGridView1.TabIndex = 60;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(724, 434);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 16);
            this.label1.TabIndex = 77;
            this.label1.Text = "Tournaments Played:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(561, 434);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 16);
            this.label5.TabIndex = 76;
            this.label5.Text = "Tournaments Won:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
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
            this.tplayedtxt.Location = new System.Drawing.Point(727, 454);
            this.tplayedtxt.Name = "tplayedtxt";
            this.tplayedtxt.Size = new System.Drawing.Size(140, 22);
            this.tplayedtxt.TabIndex = 74;
            this.tplayedtxt.TextChanged += new System.EventHandler(this.tplayedtxt_TextChanged);
            // 
            // twontxt
            // 
            this.twontxt.Location = new System.Drawing.Point(564, 454);
            this.twontxt.Name = "twontxt";
            this.twontxt.Size = new System.Drawing.Size(129, 22);
            this.twontxt.TabIndex = 73;
            this.twontxt.TextChanged += new System.EventHandler(this.twontxt_TextChanged);
            // 
            // team_id
            // 
            this.team_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.team_id.HeaderText = "Team ID";
            this.team_id.MinimumWidth = 6;
            this.team_id.Name = "team_id";
            this.team_id.Width = 88;
            // 
            // team_name
            // 
            this.team_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.team_name.HeaderText = "Team Name";
            this.team_name.MinimumWidth = 6;
            this.team_name.Name = "team_name";
            this.team_name.Width = 112;
            // 
            // matches_won
            // 
            this.matches_won.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.matches_won.HeaderText = "Matches Won";
            this.matches_won.MinimumWidth = 6;
            this.matches_won.Name = "matches_won";
            this.matches_won.Width = 118;
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
            this.tournaments_played.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.tournaments_played.HeaderText = "Tournaments Played";
            this.tournaments_played.MinimumWidth = 6;
            this.tournaments_played.Name = "tournaments_played";
            this.tournaments_played.Width = 147;
            // 
            // TeamsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 597);
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
    }
}