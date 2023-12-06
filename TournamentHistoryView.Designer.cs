
namespace Valorant_Datahub
{
    partial class TournamentHistoryView
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
            this.label2 = new System.Windows.Forms.Label();
            this.tagtxt = new System.Windows.Forms.TextBox();
            this.midtxt = new System.Windows.Forms.TextBox();
            this.picklbl = new System.Windows.Forms.Label();
            this.namelbl = new System.Windows.Forms.Label();
            this.tidtxt = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tournament_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.match_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.match_tag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rollback_btn = new System.Windows.Forms.Button();
            this.commitbtn = new System.Windows.Forms.Button();
            this.refreshbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.querytb = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // insert_btn
            // 
            this.insert_btn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.insert_btn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.insert_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.insert_btn.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insert_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.insert_btn.Location = new System.Drawing.Point(80, 535);
            this.insert_btn.Name = "insert_btn";
            this.insert_btn.Size = new System.Drawing.Size(175, 60);
            this.insert_btn.TabIndex = 101;
            this.insert_btn.Text = "Insert";
            this.insert_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.insert_btn.UseVisualStyleBackColor = false;
            this.insert_btn.Click += new System.EventHandler(this.insert_btn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(548, 421);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 20);
            this.label4.TabIndex = 100;
            this.label4.Text = "Match Tag:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(529, 421);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 98;
            // 
            // tagtxt
            // 
            this.tagtxt.BackColor = System.Drawing.Color.White;
            this.tagtxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tagtxt.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tagtxt.Location = new System.Drawing.Point(551, 458);
            this.tagtxt.Name = "tagtxt";
            this.tagtxt.Size = new System.Drawing.Size(176, 28);
            this.tagtxt.TabIndex = 97;
            // 
            // midtxt
            // 
            this.midtxt.BackColor = System.Drawing.Color.White;
            this.midtxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.midtxt.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.midtxt.Location = new System.Drawing.Point(289, 458);
            this.midtxt.Name = "midtxt";
            this.midtxt.Size = new System.Drawing.Size(177, 28);
            this.midtxt.TabIndex = 96;
            // 
            // picklbl
            // 
            this.picklbl.AutoSize = true;
            this.picklbl.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.picklbl.Location = new System.Drawing.Point(288, 421);
            this.picklbl.Name = "picklbl";
            this.picklbl.Size = new System.Drawing.Size(95, 20);
            this.picklbl.TabIndex = 95;
            this.picklbl.Text = "Match ID:";
            // 
            // namelbl
            // 
            this.namelbl.AutoSize = true;
            this.namelbl.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namelbl.Location = new System.Drawing.Point(47, 421);
            this.namelbl.Name = "namelbl";
            this.namelbl.Size = new System.Drawing.Size(146, 20);
            this.namelbl.TabIndex = 94;
            this.namelbl.Text = "Tournament ID:";
            // 
            // tidtxt
            // 
            this.tidtxt.BackColor = System.Drawing.Color.White;
            this.tidtxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tidtxt.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tidtxt.Location = new System.Drawing.Point(51, 458);
            this.tidtxt.Name = "tidtxt";
            this.tidtxt.Size = new System.Drawing.Size(144, 28);
            this.tidtxt.TabIndex = 92;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tournament_id,
            this.match_id,
            this.match_tag});
            this.dataGridView1.Location = new System.Drawing.Point(51, 46);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(775, 354);
            this.dataGridView1.TabIndex = 91;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // tournament_id
            // 
            this.tournament_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tournament_id.HeaderText = "Tournament ID";
            this.tournament_id.MinimumWidth = 6;
            this.tournament_id.Name = "tournament_id";
            // 
            // match_id
            // 
            this.match_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.match_id.HeaderText = "Match ID";
            this.match_id.MinimumWidth = 6;
            this.match_id.Name = "match_id";
            // 
            // match_tag
            // 
            this.match_tag.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.match_tag.HeaderText = "Match Tag";
            this.match_tag.MinimumWidth = 6;
            this.match_tag.Name = "match_tag";
            // 
            // rollback_btn
            // 
            this.rollback_btn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rollback_btn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.rollback_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rollback_btn.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rollback_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rollback_btn.Location = new System.Drawing.Point(326, 535);
            this.rollback_btn.Name = "rollback_btn";
            this.rollback_btn.Size = new System.Drawing.Size(175, 60);
            this.rollback_btn.TabIndex = 102;
            this.rollback_btn.Text = "Rollback";
            this.rollback_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.rollback_btn.UseVisualStyleBackColor = false;
            this.rollback_btn.Click += new System.EventHandler(this.rollback_btn_Click);
            // 
            // commitbtn
            // 
            this.commitbtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.commitbtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.commitbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.commitbtn.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.commitbtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.commitbtn.Location = new System.Drawing.Point(579, 535);
            this.commitbtn.Name = "commitbtn";
            this.commitbtn.Size = new System.Drawing.Size(175, 60);
            this.commitbtn.TabIndex = 103;
            this.commitbtn.Text = "Commit";
            this.commitbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.commitbtn.UseVisualStyleBackColor = false;
            this.commitbtn.Click += new System.EventHandler(this.commitbtn_Click);
            // 
            // refreshbtn
            // 
            this.refreshbtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.refreshbtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.refreshbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refreshbtn.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshbtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.refreshbtn.Location = new System.Drawing.Point(326, 632);
            this.refreshbtn.Name = "refreshbtn";
            this.refreshbtn.Size = new System.Drawing.Size(175, 60);
            this.refreshbtn.TabIndex = 104;
            this.refreshbtn.Text = "Refresh";
            this.refreshbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.refreshbtn.UseVisualStyleBackColor = false;
            this.refreshbtn.Click += new System.EventHandler(this.refreshbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 16);
            this.label1.TabIndex = 109;
            this.label1.Text = "Enter query here:";
            // 
            // querytb
            // 
            this.querytb.Location = new System.Drawing.Point(187, 4);
            this.querytb.Name = "querytb";
            this.querytb.Size = new System.Drawing.Size(639, 22);
            this.querytb.TabIndex = 108;
            this.querytb.Text = "select * from maps where ";
            this.querytb.TextChanged += new System.EventHandler(this.querytb_TextChanged);
            this.querytb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.querytb_KeyPress);
            // 
            // TournamentHistoryView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 713);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.querytb);
            this.Controls.Add(this.refreshbtn);
            this.Controls.Add(this.commitbtn);
            this.Controls.Add(this.rollback_btn);
            this.Controls.Add(this.insert_btn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tagtxt);
            this.Controls.Add(this.midtxt);
            this.Controls.Add(this.picklbl);
            this.Controls.Add(this.namelbl);
            this.Controls.Add(this.tidtxt);
            this.Controls.Add(this.dataGridView1);
            this.Name = "TournamentHistoryView";
            this.Text = "TournamentHistoryView";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TournamentHistoryView_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button insert_btn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tagtxt;
        private System.Windows.Forms.TextBox midtxt;
        private System.Windows.Forms.Label picklbl;
        private System.Windows.Forms.Label namelbl;
        private System.Windows.Forms.TextBox tidtxt;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tournament_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn match_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn match_tag;
        private System.Windows.Forms.Button rollback_btn;
        private System.Windows.Forms.Button commitbtn;
        private System.Windows.Forms.Button refreshbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox querytb;
    }
}