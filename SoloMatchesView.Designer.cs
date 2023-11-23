
namespace Valorant_Datahub
{
    partial class SoloMatchesView
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
            this.insert_btn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pidtxt = new System.Windows.Forms.TextBox();
            this.maptxt = new System.Windows.Forms.TextBox();
            this.agenttxt = new System.Windows.Forms.TextBox();
            this.resulttxt = new System.Windows.Forms.TextBox();
            this.winlbl = new System.Windows.Forms.Label();
            this.picklbl = new System.Windows.Forms.Label();
            this.namelbl = new System.Windows.Forms.Label();
            this.deathstxt = new System.Windows.Forms.TextBox();
            this.killstxt = new System.Windows.Forms.TextBox();
            this.midtxt = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.match_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kills = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deaths = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.result = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.agent_played = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.map_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.player_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // insert_btn
            // 
            this.insert_btn.Location = new System.Drawing.Point(331, 515);
            this.insert_btn.Name = "insert_btn";
            this.insert_btn.Size = new System.Drawing.Size(188, 46);
            this.insert_btn.TabIndex = 42;
            this.insert_btn.Text = "Insert";
            this.insert_btn.UseVisualStyleBackColor = true;
            this.insert_btn.Click += new System.EventHandler(this.insert_btn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(744, 422);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 37;
            this.label4.Text = "Player ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(592, 422);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 17);
            this.label3.TabIndex = 36;
            this.label3.Text = "Map Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(461, 422);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 17);
            this.label2.TabIndex = 35;
            this.label2.Text = "Agent Played:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(334, 422);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 34;
            this.label1.Text = "Result:";
            // 
            // pidtxt
            // 
            this.pidtxt.Location = new System.Drawing.Point(740, 442);
            this.pidtxt.Name = "pidtxt";
            this.pidtxt.Size = new System.Drawing.Size(100, 22);
            this.pidtxt.TabIndex = 33;
            // 
            // maptxt
            // 
            this.maptxt.Location = new System.Drawing.Point(588, 442);
            this.maptxt.Name = "maptxt";
            this.maptxt.Size = new System.Drawing.Size(127, 22);
            this.maptxt.TabIndex = 32;
            // 
            // agenttxt
            // 
            this.agenttxt.Location = new System.Drawing.Point(458, 442);
            this.agenttxt.Name = "agenttxt";
            this.agenttxt.Size = new System.Drawing.Size(100, 22);
            this.agenttxt.TabIndex = 31;
            // 
            // resulttxt
            // 
            this.resulttxt.Location = new System.Drawing.Point(331, 442);
            this.resulttxt.Name = "resulttxt";
            this.resulttxt.Size = new System.Drawing.Size(100, 22);
            this.resulttxt.TabIndex = 30;
            // 
            // winlbl
            // 
            this.winlbl.AutoSize = true;
            this.winlbl.Location = new System.Drawing.Point(244, 422);
            this.winlbl.Name = "winlbl";
            this.winlbl.Size = new System.Drawing.Size(57, 17);
            this.winlbl.TabIndex = 29;
            this.winlbl.Text = "Deaths:";
            // 
            // picklbl
            // 
            this.picklbl.AutoSize = true;
            this.picklbl.Location = new System.Drawing.Point(162, 422);
            this.picklbl.Name = "picklbl";
            this.picklbl.Size = new System.Drawing.Size(37, 17);
            this.picklbl.TabIndex = 28;
            this.picklbl.Text = "Kills:";
            // 
            // namelbl
            // 
            this.namelbl.AutoSize = true;
            this.namelbl.Location = new System.Drawing.Point(42, 422);
            this.namelbl.Name = "namelbl";
            this.namelbl.Size = new System.Drawing.Size(67, 17);
            this.namelbl.TabIndex = 27;
            this.namelbl.Text = "Match ID:";
            // 
            // deathstxt
            // 
            this.deathstxt.Location = new System.Drawing.Point(241, 442);
            this.deathstxt.Name = "deathstxt";
            this.deathstxt.Size = new System.Drawing.Size(60, 22);
            this.deathstxt.TabIndex = 26;
            // 
            // killstxt
            // 
            this.killstxt.Location = new System.Drawing.Point(159, 442);
            this.killstxt.Name = "killstxt";
            this.killstxt.Size = new System.Drawing.Size(58, 22);
            this.killstxt.TabIndex = 25;
            // 
            // midtxt
            // 
            this.midtxt.Location = new System.Drawing.Point(38, 442);
            this.midtxt.Name = "midtxt";
            this.midtxt.Size = new System.Drawing.Size(100, 22);
            this.midtxt.TabIndex = 24;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.match_id,
            this.kills,
            this.deaths,
            this.result,
            this.agent_played,
            this.map_name,
            this.player_id});
            this.dataGridView1.Location = new System.Drawing.Point(38, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(802, 356);
            this.dataGridView1.TabIndex = 23;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // match_id
            // 
            this.match_id.HeaderText = "Match ID";
            this.match_id.MinimumWidth = 6;
            this.match_id.Name = "match_id";
            this.match_id.Width = 125;
            // 
            // kills
            // 
            this.kills.HeaderText = "Kills";
            this.kills.MinimumWidth = 6;
            this.kills.Name = "kills";
            this.kills.Width = 125;
            // 
            // deaths
            // 
            this.deaths.HeaderText = "Deaths";
            this.deaths.MinimumWidth = 6;
            this.deaths.Name = "deaths";
            this.deaths.Width = 125;
            // 
            // result
            // 
            this.result.HeaderText = "Result";
            this.result.MinimumWidth = 6;
            this.result.Name = "result";
            this.result.Width = 125;
            // 
            // agent_played
            // 
            this.agent_played.HeaderText = "Agent Played";
            this.agent_played.MinimumWidth = 6;
            this.agent_played.Name = "agent_played";
            this.agent_played.Width = 125;
            // 
            // map_name
            // 
            this.map_name.HeaderText = "Map Name";
            this.map_name.MinimumWidth = 6;
            this.map_name.Name = "map_name";
            this.map_name.Width = 125;
            // 
            // player_id
            // 
            this.player_id.HeaderText = "Player ID";
            this.player_id.MinimumWidth = 6;
            this.player_id.Name = "player_id";
            this.player_id.Width = 125;
            // 
            // SoloMatchesView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 614);
            this.Controls.Add(this.insert_btn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pidtxt);
            this.Controls.Add(this.maptxt);
            this.Controls.Add(this.agenttxt);
            this.Controls.Add(this.resulttxt);
            this.Controls.Add(this.winlbl);
            this.Controls.Add(this.picklbl);
            this.Controls.Add(this.namelbl);
            this.Controls.Add(this.deathstxt);
            this.Controls.Add(this.killstxt);
            this.Controls.Add(this.midtxt);
            this.Controls.Add(this.dataGridView1);
            this.Name = "SoloMatchesView";
            this.Text = "SoloMatchesView";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button insert_btn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox pidtxt;
        private System.Windows.Forms.TextBox maptxt;
        private System.Windows.Forms.TextBox agenttxt;
        private System.Windows.Forms.TextBox resulttxt;
        private System.Windows.Forms.Label winlbl;
        private System.Windows.Forms.Label picklbl;
        private System.Windows.Forms.Label namelbl;
        private System.Windows.Forms.TextBox deathstxt;
        private System.Windows.Forms.TextBox killstxt;
        private System.Windows.Forms.TextBox midtxt;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn match_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn kills;
        private System.Windows.Forms.DataGridViewTextBoxColumn deaths;
        private System.Windows.Forms.DataGridViewTextBoxColumn result;
        private System.Windows.Forms.DataGridViewTextBoxColumn agent_played;
        private System.Windows.Forms.DataGridViewTextBoxColumn map_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn player_id;
    }
}