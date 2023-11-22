
namespace Valorant_Datahub
{
    partial class TournamentsView
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
            this.label6 = new System.Windows.Forms.Label();
            this.updatebtn = new System.Windows.Forms.Button();
            this.deletebtn = new System.Windows.Forms.Button();
            this.insert_btn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.locationtxt = new System.Windows.Forms.TextBox();
            this.prizetxt = new System.Windows.Forms.TextBox();
            this.picklbl = new System.Windows.Forms.Label();
            this.namelbl = new System.Windows.Forms.Label();
            this.titletxt = new System.Windows.Forms.TextBox();
            this.idtxt = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tournament_title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prize_pool = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.location_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(799, 417);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 17);
            this.label6.TabIndex = 93;
            // 
            // updatebtn
            // 
            this.updatebtn.Location = new System.Drawing.Point(499, 512);
            this.updatebtn.Name = "updatebtn";
            this.updatebtn.Size = new System.Drawing.Size(161, 46);
            this.updatebtn.TabIndex = 90;
            this.updatebtn.Text = "Update";
            this.updatebtn.UseVisualStyleBackColor = true;
            this.updatebtn.Click += new System.EventHandler(this.updatebtn_Click);
            // 
            // deletebtn
            // 
            this.deletebtn.Location = new System.Drawing.Point(259, 512);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Size = new System.Drawing.Size(174, 46);
            this.deletebtn.TabIndex = 89;
            this.deletebtn.Text = "Delete";
            this.deletebtn.UseVisualStyleBackColor = true;
            this.deletebtn.Click += new System.EventHandler(this.deletebtn_Click);
            // 
            // insert_btn
            // 
            this.insert_btn.Location = new System.Drawing.Point(33, 512);
            this.insert_btn.Name = "insert_btn";
            this.insert_btn.Size = new System.Drawing.Size(169, 46);
            this.insert_btn.TabIndex = 88;
            this.insert_btn.Text = "Insert";
            this.insert_btn.UseVisualStyleBackColor = true;
            this.insert_btn.Click += new System.EventHandler(this.insert_btn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(530, 437);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 17);
            this.label4.TabIndex = 87;
            this.label4.Text = "Location ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(372, 437);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 17);
            this.label3.TabIndex = 86;
            this.label3.Text = "Prize Pool:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(511, 437);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 85;
            // 
            // locationtxt
            // 
            this.locationtxt.Location = new System.Drawing.Point(533, 457);
            this.locationtxt.Name = "locationtxt";
            this.locationtxt.Size = new System.Drawing.Size(127, 22);
            this.locationtxt.TabIndex = 84;
            // 
            // prizetxt
            // 
            this.prizetxt.Location = new System.Drawing.Point(369, 457);
            this.prizetxt.Name = "prizetxt";
            this.prizetxt.Size = new System.Drawing.Size(128, 22);
            this.prizetxt.TabIndex = 83;
            // 
            // picklbl
            // 
            this.picklbl.AutoSize = true;
            this.picklbl.Location = new System.Drawing.Point(155, 437);
            this.picklbl.Name = "picklbl";
            this.picklbl.Size = new System.Drawing.Size(39, 17);
            this.picklbl.TabIndex = 82;
            this.picklbl.Text = "Title:";
            // 
            // namelbl
            // 
            this.namelbl.AutoSize = true;
            this.namelbl.Location = new System.Drawing.Point(30, 437);
            this.namelbl.Name = "namelbl";
            this.namelbl.Size = new System.Drawing.Size(34, 17);
            this.namelbl.TabIndex = 81;
            this.namelbl.Text = "TID:";
            // 
            // titletxt
            // 
            this.titletxt.Location = new System.Drawing.Point(152, 457);
            this.titletxt.Name = "titletxt";
            this.titletxt.Size = new System.Drawing.Size(184, 22);
            this.titletxt.TabIndex = 80;
            // 
            // idtxt
            // 
            this.idtxt.Location = new System.Drawing.Point(33, 457);
            this.idtxt.Name = "idtxt";
            this.idtxt.Size = new System.Drawing.Size(86, 22);
            this.idtxt.TabIndex = 79;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tid,
            this.tournament_title,
            this.prize_pool,
            this.location_id});
            this.dataGridView1.Location = new System.Drawing.Point(33, 56);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(627, 356);
            this.dataGridView1.TabIndex = 78;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // tid
            // 
            this.tid.HeaderText = "Tournament ID";
            this.tid.MinimumWidth = 6;
            this.tid.Name = "tid";
            this.tid.Width = 125;
            // 
            // tournament_title
            // 
            this.tournament_title.HeaderText = "Tournament Title";
            this.tournament_title.MinimumWidth = 6;
            this.tournament_title.Name = "tournament_title";
            this.tournament_title.Width = 125;
            // 
            // prize_pool
            // 
            this.prize_pool.HeaderText = "Prize Pool";
            this.prize_pool.MinimumWidth = 6;
            this.prize_pool.Name = "prize_pool";
            this.prize_pool.Width = 125;
            // 
            // location_id
            // 
            this.location_id.HeaderText = "Location ID";
            this.location_id.MinimumWidth = 6;
            this.location_id.Name = "location_id";
            this.location_id.Width = 125;
            // 
            // TournamentsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 597);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.updatebtn);
            this.Controls.Add(this.deletebtn);
            this.Controls.Add(this.insert_btn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.locationtxt);
            this.Controls.Add(this.prizetxt);
            this.Controls.Add(this.picklbl);
            this.Controls.Add(this.namelbl);
            this.Controls.Add(this.titletxt);
            this.Controls.Add(this.idtxt);
            this.Controls.Add(this.dataGridView1);
            this.Name = "TournamentsView";
            this.Text = "TournamentsView";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button updatebtn;
        private System.Windows.Forms.Button deletebtn;
        private System.Windows.Forms.Button insert_btn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox locationtxt;
        private System.Windows.Forms.TextBox prizetxt;
        private System.Windows.Forms.Label picklbl;
        private System.Windows.Forms.Label namelbl;
        private System.Windows.Forms.TextBox titletxt;
        private System.Windows.Forms.TextBox idtxt;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tid;
        private System.Windows.Forms.DataGridViewTextBoxColumn tournament_title;
        private System.Windows.Forms.DataGridViewTextBoxColumn prize_pool;
        private System.Windows.Forms.DataGridViewTextBoxColumn location_id;
    }
}