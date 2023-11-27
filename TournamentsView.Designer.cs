
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
            this.refreshbtn = new System.Windows.Forms.Button();
            this.rollbackbtn = new System.Windows.Forms.Button();
            this.commitbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(846, 417);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 16);
            this.label6.TabIndex = 93;
            // 
            // updatebtn
            // 
            this.updatebtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.updatebtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.updatebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updatebtn.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatebtn.Location = new System.Drawing.Point(544, 566);
            this.updatebtn.Name = "updatebtn";
            this.updatebtn.Size = new System.Drawing.Size(175, 60);
            this.updatebtn.TabIndex = 90;
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
            this.deletebtn.Location = new System.Drawing.Point(343, 566);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Size = new System.Drawing.Size(175, 60);
            this.deletebtn.TabIndex = 89;
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
            this.insert_btn.Location = new System.Drawing.Point(141, 567);
            this.insert_btn.Name = "insert_btn";
            this.insert_btn.Size = new System.Drawing.Size(175, 60);
            this.insert_btn.TabIndex = 88;
            this.insert_btn.Text = "Insert";
            this.insert_btn.UseVisualStyleBackColor = false;
            this.insert_btn.Click += new System.EventHandler(this.insert_btn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(766, 437);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 20);
            this.label4.TabIndex = 87;
            this.label4.Text = "Location ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(608, 437);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 20);
            this.label3.TabIndex = 86;
            this.label3.Text = "Prize Pool:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(747, 437);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 85;
            // 
            // locationtxt
            // 
            this.locationtxt.BackColor = System.Drawing.Color.White;
            this.locationtxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.locationtxt.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locationtxt.Location = new System.Drawing.Point(770, 472);
            this.locationtxt.Name = "locationtxt";
            this.locationtxt.Size = new System.Drawing.Size(127, 28);
            this.locationtxt.TabIndex = 84;
            // 
            // prizetxt
            // 
            this.prizetxt.BackColor = System.Drawing.Color.White;
            this.prizetxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.prizetxt.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prizetxt.Location = new System.Drawing.Point(612, 472);
            this.prizetxt.Name = "prizetxt";
            this.prizetxt.Size = new System.Drawing.Size(128, 28);
            this.prizetxt.TabIndex = 83;
            // 
            // picklbl
            // 
            this.picklbl.AutoSize = true;
            this.picklbl.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.picklbl.Location = new System.Drawing.Point(204, 437);
            this.picklbl.Name = "picklbl";
            this.picklbl.Size = new System.Drawing.Size(54, 20);
            this.picklbl.TabIndex = 82;
            this.picklbl.Text = "Title:";
            // 
            // namelbl
            // 
            this.namelbl.AutoSize = true;
            this.namelbl.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namelbl.Location = new System.Drawing.Point(30, 437);
            this.namelbl.Name = "namelbl";
            this.namelbl.Size = new System.Drawing.Size(132, 20);
            this.namelbl.TabIndex = 81;
            this.namelbl.Text = "TournamentID";
            // 
            // titletxt
            // 
            this.titletxt.BackColor = System.Drawing.Color.White;
            this.titletxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.titletxt.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titletxt.Location = new System.Drawing.Point(208, 472);
            this.titletxt.Name = "titletxt";
            this.titletxt.Size = new System.Drawing.Size(384, 28);
            this.titletxt.TabIndex = 80;
            // 
            // idtxt
            // 
            this.idtxt.BackColor = System.Drawing.Color.White;
            this.idtxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.idtxt.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idtxt.Location = new System.Drawing.Point(34, 472);
            this.idtxt.Name = "idtxt";
            this.idtxt.Size = new System.Drawing.Size(128, 28);
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
            this.dataGridView1.Size = new System.Drawing.Size(868, 346);
            this.dataGridView1.TabIndex = 78;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // tid
            // 
            this.tid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.tid.HeaderText = "Tournament ID";
            this.tid.MinimumWidth = 6;
            this.tid.Name = "tid";
            this.tid.Width = 114;
            // 
            // tournament_title
            // 
            this.tournament_title.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tournament_title.HeaderText = "Tournament Title";
            this.tournament_title.MinimumWidth = 6;
            this.tournament_title.Name = "tournament_title";
            // 
            // prize_pool
            // 
            this.prize_pool.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.prize_pool.HeaderText = "Prize Pool";
            this.prize_pool.MinimumWidth = 6;
            this.prize_pool.Name = "prize_pool";
            this.prize_pool.Width = 90;
            // 
            // location_id
            // 
            this.location_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.location_id.HeaderText = "Location ID";
            this.location_id.MinimumWidth = 6;
            this.location_id.Name = "location_id";
            this.location_id.Width = 95;
            // 
            // refreshbtn
            // 
            this.refreshbtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.refreshbtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.refreshbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refreshbtn.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshbtn.Location = new System.Drawing.Point(544, 661);
            this.refreshbtn.Name = "refreshbtn";
            this.refreshbtn.Size = new System.Drawing.Size(175, 60);
            this.refreshbtn.TabIndex = 94;
            this.refreshbtn.Text = "Refresh";
            this.refreshbtn.UseVisualStyleBackColor = false;
            this.refreshbtn.Click += new System.EventHandler(this.refreshbtn_Click);
            // 
            // rollbackbtn
            // 
            this.rollbackbtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.rollbackbtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.rollbackbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rollbackbtn.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rollbackbtn.Location = new System.Drawing.Point(343, 660);
            this.rollbackbtn.Name = "rollbackbtn";
            this.rollbackbtn.Size = new System.Drawing.Size(175, 60);
            this.rollbackbtn.TabIndex = 96;
            this.rollbackbtn.Text = "Rollback";
            this.rollbackbtn.UseVisualStyleBackColor = false;
            this.rollbackbtn.Click += new System.EventHandler(this.rollbackbtn_Click);
            // 
            // commitbtn
            // 
            this.commitbtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.commitbtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.commitbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.commitbtn.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.commitbtn.Location = new System.Drawing.Point(141, 661);
            this.commitbtn.Name = "commitbtn";
            this.commitbtn.Size = new System.Drawing.Size(175, 60);
            this.commitbtn.TabIndex = 95;
            this.commitbtn.Text = "Commit";
            this.commitbtn.UseVisualStyleBackColor = false;
            this.commitbtn.Click += new System.EventHandler(this.commitbtn_Click);
            // 
            // TournamentsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 747);
            this.Controls.Add(this.rollbackbtn);
            this.Controls.Add(this.commitbtn);
            this.Controls.Add(this.refreshbtn);
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
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TournamentsView_FormClosing);
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
        private System.Windows.Forms.Button refreshbtn;
        private System.Windows.Forms.Button rollbackbtn;
        private System.Windows.Forms.Button commitbtn;
    }
}