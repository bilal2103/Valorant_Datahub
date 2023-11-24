
namespace Valorant_Datahub
{
    partial class MatchesView
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
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.maptxt = new System.Windows.Forms.TextBox();
            this.insert_btn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.winnertxt = new System.Windows.Forms.TextBox();
            this.team2txt = new System.Windows.Forms.TextBox();
            this.picklbl = new System.Windows.Forms.Label();
            this.namelbl = new System.Windows.Forms.Label();
            this.team1txt = new System.Windows.Forms.TextBox();
            this.idtxt = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.match_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.team1_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.team2_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.winner_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.map_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(560, 427);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 16);
            this.label5.TabIndex = 94;
            this.label5.Text = "Map Name:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(812, 407);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 16);
            this.label6.TabIndex = 93;
            // 
            // maptxt
            // 
            this.maptxt.Location = new System.Drawing.Point(557, 447);
            this.maptxt.Name = "maptxt";
            this.maptxt.Size = new System.Drawing.Size(163, 22);
            this.maptxt.TabIndex = 91;
            // 
            // insert_btn
            // 
            this.insert_btn.Location = new System.Drawing.Point(284, 507);
            this.insert_btn.Name = "insert_btn";
            this.insert_btn.Size = new System.Drawing.Size(172, 46);
            this.insert_btn.TabIndex = 88;
            this.insert_btn.Text = "Insert";
            this.insert_btn.UseVisualStyleBackColor = true;
            this.insert_btn.Click += new System.EventHandler(this.insert_btn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(415, 427);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 16);
            this.label4.TabIndex = 87;
            this.label4.Text = "Winner ID:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(524, 427);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
            this.label2.TabIndex = 85;
            // 
            // winnertxt
            // 
            this.winnertxt.Location = new System.Drawing.Point(415, 447);
            this.winnertxt.Name = "winnertxt";
            this.winnertxt.Size = new System.Drawing.Size(109, 22);
            this.winnertxt.TabIndex = 84;
            // 
            // team2txt
            // 
            this.team2txt.Location = new System.Drawing.Point(293, 447);
            this.team2txt.Name = "team2txt";
            this.team2txt.Size = new System.Drawing.Size(90, 22);
            this.team2txt.TabIndex = 83;
            // 
            // picklbl
            // 
            this.picklbl.AutoSize = true;
            this.picklbl.Location = new System.Drawing.Point(169, 427);
            this.picklbl.Name = "picklbl";
            this.picklbl.Size = new System.Drawing.Size(72, 16);
            this.picklbl.TabIndex = 82;
            this.picklbl.Text = "Team 1 ID:";
            // 
            // namelbl
            // 
            this.namelbl.AutoSize = true;
            this.namelbl.Location = new System.Drawing.Point(46, 427);
            this.namelbl.Name = "namelbl";
            this.namelbl.Size = new System.Drawing.Size(62, 16);
            this.namelbl.TabIndex = 81;
            this.namelbl.Text = "Match ID:";
            // 
            // team1txt
            // 
            this.team1txt.Location = new System.Drawing.Point(169, 447);
            this.team1txt.Name = "team1txt";
            this.team1txt.Size = new System.Drawing.Size(90, 22);
            this.team1txt.TabIndex = 80;
            // 
            // idtxt
            // 
            this.idtxt.Location = new System.Drawing.Point(46, 447);
            this.idtxt.Name = "idtxt";
            this.idtxt.Size = new System.Drawing.Size(90, 22);
            this.idtxt.TabIndex = 79;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.match_id,
            this.team1_id,
            this.team2_id,
            this.winner_id,
            this.map_name});
            this.dataGridView1.Location = new System.Drawing.Point(46, 46);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(674, 356);
            this.dataGridView1.TabIndex = 78;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // match_id
            // 
            this.match_id.HeaderText = "Match ID";
            this.match_id.MinimumWidth = 6;
            this.match_id.Name = "match_id";
            this.match_id.Width = 125;
            // 
            // team1_id
            // 
            this.team1_id.HeaderText = "Team 1";
            this.team1_id.MinimumWidth = 6;
            this.team1_id.Name = "team1_id";
            this.team1_id.Width = 125;
            // 
            // team2_id
            // 
            this.team2_id.HeaderText = "Team 2";
            this.team2_id.MinimumWidth = 6;
            this.team2_id.Name = "team2_id";
            this.team2_id.Width = 125;
            // 
            // winner_id
            // 
            this.winner_id.HeaderText = "Winner";
            this.winner_id.MinimumWidth = 6;
            this.winner_id.Name = "winner_id";
            this.winner_id.Width = 125;
            // 
            // map_name
            // 
            this.map_name.HeaderText = "Map Name";
            this.map_name.MinimumWidth = 6;
            this.map_name.Name = "map_name";
            this.map_name.Width = 125;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(293, 427);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 16);
            this.label7.TabIndex = 96;
            this.label7.Text = "Team 2 ID:";
            // 
            // MatchesView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 589);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.maptxt);
            this.Controls.Add(this.insert_btn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.winnertxt);
            this.Controls.Add(this.team2txt);
            this.Controls.Add(this.picklbl);
            this.Controls.Add(this.namelbl);
            this.Controls.Add(this.team1txt);
            this.Controls.Add(this.idtxt);
            this.Controls.Add(this.dataGridView1);
            this.Name = "MatchesView";
            this.Text = "MatchesView";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox maptxt;
        private System.Windows.Forms.Button insert_btn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox winnertxt;
        private System.Windows.Forms.TextBox team2txt;
        private System.Windows.Forms.Label picklbl;
        private System.Windows.Forms.Label namelbl;
        private System.Windows.Forms.TextBox team1txt;
        private System.Windows.Forms.TextBox idtxt;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn match_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn team1_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn team2_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn winner_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn map_name;
    }
}