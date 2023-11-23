
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
            this.updatebtn = new System.Windows.Forms.Button();
            this.deletebtn = new System.Windows.Forms.Button();
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // updatebtn
            // 
            this.updatebtn.Location = new System.Drawing.Point(532, 491);
            this.updatebtn.Name = "updatebtn";
            this.updatebtn.Size = new System.Drawing.Size(195, 46);
            this.updatebtn.TabIndex = 103;
            this.updatebtn.Text = "Update";
            this.updatebtn.UseVisualStyleBackColor = true;
            this.updatebtn.Click += new System.EventHandler(this.updatebtn_Click);
            // 
            // deletebtn
            // 
            this.deletebtn.Location = new System.Drawing.Point(284, 491);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Size = new System.Drawing.Size(208, 46);
            this.deletebtn.TabIndex = 102;
            this.deletebtn.Text = "Delete";
            this.deletebtn.UseVisualStyleBackColor = true;
            this.deletebtn.Click += new System.EventHandler(this.deletebtn_Click);
            // 
            // insert_btn
            // 
            this.insert_btn.Location = new System.Drawing.Point(51, 491);
            this.insert_btn.Name = "insert_btn";
            this.insert_btn.Size = new System.Drawing.Size(203, 46);
            this.insert_btn.TabIndex = 101;
            this.insert_btn.Text = "Insert";
            this.insert_btn.UseVisualStyleBackColor = true;
            this.insert_btn.Click += new System.EventHandler(this.insert_btn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(548, 416);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 17);
            this.label4.TabIndex = 100;
            this.label4.Text = "Match Tag:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(529, 416);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 98;
            // 
            // tagtxt
            // 
            this.tagtxt.Location = new System.Drawing.Point(546, 436);
            this.tagtxt.Name = "tagtxt";
            this.tagtxt.Size = new System.Drawing.Size(176, 22);
            this.tagtxt.TabIndex = 97;
            // 
            // midtxt
            // 
            this.midtxt.Location = new System.Drawing.Point(284, 436);
            this.midtxt.Name = "midtxt";
            this.midtxt.Size = new System.Drawing.Size(177, 22);
            this.midtxt.TabIndex = 96;
            // 
            // picklbl
            // 
            this.picklbl.AutoSize = true;
            this.picklbl.Location = new System.Drawing.Point(288, 416);
            this.picklbl.Name = "picklbl";
            this.picklbl.Size = new System.Drawing.Size(67, 17);
            this.picklbl.TabIndex = 95;
            this.picklbl.Text = "Match ID:";
            // 
            // namelbl
            // 
            this.namelbl.AutoSize = true;
            this.namelbl.Location = new System.Drawing.Point(59, 416);
            this.namelbl.Name = "namelbl";
            this.namelbl.Size = new System.Drawing.Size(34, 17);
            this.namelbl.TabIndex = 94;
            this.namelbl.Text = "TID:";
            // 
            // tidtxt
            // 
            this.tidtxt.Location = new System.Drawing.Point(58, 436);
            this.tidtxt.Name = "tidtxt";
            this.tidtxt.Size = new System.Drawing.Size(144, 22);
            this.tidtxt.TabIndex = 92;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tournament_id,
            this.match_id,
            this.match_tag});
            this.dataGridView1.Location = new System.Drawing.Point(51, 35);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(676, 356);
            this.dataGridView1.TabIndex = 91;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // tournament_id
            // 
            this.tournament_id.HeaderText = "Tournament ID";
            this.tournament_id.MinimumWidth = 6;
            this.tournament_id.Name = "tournament_id";
            this.tournament_id.Width = 125;
            // 
            // match_id
            // 
            this.match_id.HeaderText = "Match ID";
            this.match_id.MinimumWidth = 6;
            this.match_id.Name = "match_id";
            this.match_id.Width = 125;
            // 
            // match_tag
            // 
            this.match_tag.HeaderText = "Match Tag";
            this.match_tag.MinimumWidth = 6;
            this.match_tag.Name = "match_tag";
            this.match_tag.Width = 125;
            // 
            // TournamentHistoryView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 669);
            this.Controls.Add(this.updatebtn);
            this.Controls.Add(this.deletebtn);
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button updatebtn;
        private System.Windows.Forms.Button deletebtn;
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
    }
}