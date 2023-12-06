
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
            this.rollback_btn = new System.Windows.Forms.Button();
            this.commit_btn = new System.Windows.Forms.Button();
            this.refreshbtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.querytb = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // insert_btn
            // 
            this.insert_btn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.insert_btn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.insert_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.insert_btn.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insert_btn.Location = new System.Drawing.Point(124, 534);
            this.insert_btn.Name = "insert_btn";
            this.insert_btn.Size = new System.Drawing.Size(175, 60);
            this.insert_btn.TabIndex = 42;
            this.insert_btn.Text = "Insert";
            this.insert_btn.UseVisualStyleBackColor = false;
            this.insert_btn.Click += new System.EventHandler(this.insert_btn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(781, 427);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 20);
            this.label4.TabIndex = 37;
            this.label4.Text = "Player ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(622, 427);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 20);
            this.label3.TabIndex = 36;
            this.label3.Text = "Map Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(481, 427);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 20);
            this.label2.TabIndex = 35;
            this.label2.Text = "Agent Played:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(349, 427);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 34;
            this.label1.Text = "Result:";
            // 
            // pidtxt
            // 
            this.pidtxt.BackColor = System.Drawing.Color.White;
            this.pidtxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pidtxt.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pidtxt.Location = new System.Drawing.Point(777, 464);
            this.pidtxt.Name = "pidtxt";
            this.pidtxt.Size = new System.Drawing.Size(100, 28);
            this.pidtxt.TabIndex = 33;
            // 
            // maptxt
            // 
            this.maptxt.BackColor = System.Drawing.Color.White;
            this.maptxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.maptxt.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maptxt.Location = new System.Drawing.Point(626, 464);
            this.maptxt.Name = "maptxt";
            this.maptxt.Size = new System.Drawing.Size(127, 28);
            this.maptxt.TabIndex = 32;
            // 
            // agenttxt
            // 
            this.agenttxt.BackColor = System.Drawing.Color.White;
            this.agenttxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.agenttxt.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agenttxt.Location = new System.Drawing.Point(485, 464);
            this.agenttxt.Name = "agenttxt";
            this.agenttxt.Size = new System.Drawing.Size(126, 28);
            this.agenttxt.TabIndex = 31;
            // 
            // resulttxt
            // 
            this.resulttxt.BackColor = System.Drawing.Color.White;
            this.resulttxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.resulttxt.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resulttxt.Location = new System.Drawing.Point(353, 464);
            this.resulttxt.Name = "resulttxt";
            this.resulttxt.Size = new System.Drawing.Size(100, 28);
            this.resulttxt.TabIndex = 30;
            // 
            // winlbl
            // 
            this.winlbl.AutoSize = true;
            this.winlbl.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.winlbl.Location = new System.Drawing.Point(254, 427);
            this.winlbl.Name = "winlbl";
            this.winlbl.Size = new System.Drawing.Size(77, 20);
            this.winlbl.TabIndex = 29;
            this.winlbl.Text = "Deaths:";
            // 
            // picklbl
            // 
            this.picklbl.AutoSize = true;
            this.picklbl.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.picklbl.Location = new System.Drawing.Point(167, 427);
            this.picklbl.Name = "picklbl";
            this.picklbl.Size = new System.Drawing.Size(53, 20);
            this.picklbl.TabIndex = 28;
            this.picklbl.Text = "Kills:";
            // 
            // namelbl
            // 
            this.namelbl.AutoSize = true;
            this.namelbl.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namelbl.Location = new System.Drawing.Point(42, 427);
            this.namelbl.Name = "namelbl";
            this.namelbl.Size = new System.Drawing.Size(95, 20);
            this.namelbl.TabIndex = 27;
            this.namelbl.Text = "Match ID:";
            // 
            // deathstxt
            // 
            this.deathstxt.BackColor = System.Drawing.Color.White;
            this.deathstxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.deathstxt.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deathstxt.Location = new System.Drawing.Point(258, 464);
            this.deathstxt.Name = "deathstxt";
            this.deathstxt.Size = new System.Drawing.Size(60, 28);
            this.deathstxt.TabIndex = 26;
            // 
            // killstxt
            // 
            this.killstxt.BackColor = System.Drawing.Color.White;
            this.killstxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.killstxt.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.killstxt.Location = new System.Drawing.Point(162, 464);
            this.killstxt.Name = "killstxt";
            this.killstxt.Size = new System.Drawing.Size(58, 28);
            this.killstxt.TabIndex = 25;
            // 
            // midtxt
            // 
            this.midtxt.BackColor = System.Drawing.Color.White;
            this.midtxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.midtxt.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.midtxt.Location = new System.Drawing.Point(38, 464);
            this.midtxt.Name = "midtxt";
            this.midtxt.Size = new System.Drawing.Size(100, 28);
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
            this.dataGridView1.Location = new System.Drawing.Point(38, 46);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(913, 361);
            this.dataGridView1.TabIndex = 23;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // match_id
            // 
            this.match_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.match_id.HeaderText = "Match ID";
            this.match_id.MinimumWidth = 6;
            this.match_id.Name = "match_id";
            this.match_id.Width = 88;
            // 
            // kills
            // 
            this.kills.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.kills.HeaderText = "Kills";
            this.kills.MinimumWidth = 6;
            this.kills.Name = "kills";
            this.kills.Width = 60;
            // 
            // deaths
            // 
            this.deaths.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.deaths.HeaderText = "Deaths";
            this.deaths.MinimumWidth = 6;
            this.deaths.Name = "deaths";
            this.deaths.Width = 79;
            // 
            // result
            // 
            this.result.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.result.HeaderText = "Result";
            this.result.MinimumWidth = 6;
            this.result.Name = "result";
            this.result.Width = 74;
            // 
            // agent_played
            // 
            this.agent_played.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.agent_played.HeaderText = "Agent Played";
            this.agent_played.MinimumWidth = 6;
            this.agent_played.Name = "agent_played";
            // 
            // map_name
            // 
            this.map_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.map_name.HeaderText = "Map Name";
            this.map_name.MinimumWidth = 6;
            this.map_name.Name = "map_name";
            // 
            // player_id
            // 
            this.player_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.player_id.HeaderText = "Player ID";
            this.player_id.MinimumWidth = 6;
            this.player_id.Name = "player_id";
            // 
            // rollback_btn
            // 
            this.rollback_btn.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.rollback_btn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.rollback_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rollback_btn.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rollback_btn.Location = new System.Drawing.Point(685, 534);
            this.rollback_btn.Name = "rollback_btn";
            this.rollback_btn.Size = new System.Drawing.Size(175, 60);
            this.rollback_btn.TabIndex = 108;
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
            this.commit_btn.Location = new System.Drawing.Point(403, 534);
            this.commit_btn.Name = "commit_btn";
            this.commit_btn.Size = new System.Drawing.Size(175, 60);
            this.commit_btn.TabIndex = 107;
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
            this.refreshbtn.Location = new System.Drawing.Point(403, 627);
            this.refreshbtn.Name = "refreshbtn";
            this.refreshbtn.Size = new System.Drawing.Size(175, 60);
            this.refreshbtn.TabIndex = 112;
            this.refreshbtn.Text = "Refresh";
            this.refreshbtn.UseVisualStyleBackColor = false;
            this.refreshbtn.Click += new System.EventHandler(this.refreshbtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 16);
            this.label5.TabIndex = 114;
            this.label5.Text = "Enter query here:";
            // 
            // querytb
            // 
            this.querytb.Location = new System.Drawing.Point(173, 7);
            this.querytb.Name = "querytb";
            this.querytb.Size = new System.Drawing.Size(789, 22);
            this.querytb.TabIndex = 113;
            this.querytb.Text = "select * from maps where ";
            this.querytb.TextChanged += new System.EventHandler(this.querytb_TextChanged);
            this.querytb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.querytb_KeyPress);
            // 
            // SoloMatchesView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 709);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.querytb);
            this.Controls.Add(this.refreshbtn);
            this.Controls.Add(this.rollback_btn);
            this.Controls.Add(this.commit_btn);
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
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SoloMatchesView_FormClosing);
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
        private System.Windows.Forms.Button rollback_btn;
        private System.Windows.Forms.Button commit_btn;
        private System.Windows.Forms.Button refreshbtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox querytb;
    }
}