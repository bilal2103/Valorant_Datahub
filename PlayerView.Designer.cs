namespace Valorant_Datahub
{
    partial class PlayerView
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.agentxt = new System.Windows.Forms.TextBox();
            this.agetxt = new System.Windows.Forms.TextBox();
            this.gendertxt = new System.Windows.Forms.TextBox();
            this.winlbl = new System.Windows.Forms.Label();
            this.uname = new System.Windows.Forms.Label();
            this.namelbl = new System.Windows.Forms.Label();
            this.nametxt = new System.Windows.Forms.TextBox();
            this.unametxt = new System.Windows.Forms.TextBox();
            this.idtxt = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.team = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.agent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mmr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kills = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deaths = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.location = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.mmrtxt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.killstxt = new System.Windows.Forms.TextBox();
            this.deathstxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.locationtxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tidtxt = new System.Windows.Forms.TextBox();
            this.rollback_btn = new System.Windows.Forms.Button();
            this.commit_btn = new System.Windows.Forms.Button();
            this.refreshbtn = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.querytb = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // updatebtn
            // 
            this.updatebtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.updatebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updatebtn.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatebtn.Location = new System.Drawing.Point(723, 599);
            this.updatebtn.Name = "updatebtn";
            this.updatebtn.Size = new System.Drawing.Size(175, 60);
            this.updatebtn.TabIndex = 44;
            this.updatebtn.Text = "Update";
            this.updatebtn.UseVisualStyleBackColor = true;
            this.updatebtn.Click += new System.EventHandler(this.updatebtn_Click);
            // 
            // deletebtn
            // 
            this.deletebtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.deletebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deletebtn.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletebtn.Location = new System.Drawing.Point(473, 599);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Size = new System.Drawing.Size(175, 60);
            this.deletebtn.TabIndex = 43;
            this.deletebtn.Text = "Delete";
            this.deletebtn.UseVisualStyleBackColor = true;
            this.deletebtn.Click += new System.EventHandler(this.deletebtn_Click);
            // 
            // insert_btn
            // 
            this.insert_btn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.insert_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.insert_btn.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insert_btn.Location = new System.Drawing.Point(233, 599);
            this.insert_btn.Name = "insert_btn";
            this.insert_btn.Size = new System.Drawing.Size(175, 60);
            this.insert_btn.TabIndex = 42;
            this.insert_btn.Text = "Insert";
            this.insert_btn.UseVisualStyleBackColor = true;
            this.insert_btn.Click += new System.EventHandler(this.insert_btn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(819, 417);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 20);
            this.label3.TabIndex = 36;
            this.label3.Text = "Favorite Agent";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(719, 417);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 20);
            this.label2.TabIndex = 35;
            this.label2.Text = "Age";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(608, 417);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 34;
            this.label1.Text = "Gender";
            // 
            // agentxt
            // 
            this.agentxt.BackColor = System.Drawing.Color.White;
            this.agentxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.agentxt.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agentxt.Location = new System.Drawing.Point(823, 451);
            this.agentxt.Name = "agentxt";
            this.agentxt.Size = new System.Drawing.Size(142, 28);
            this.agentxt.TabIndex = 32;
            // 
            // agetxt
            // 
            this.agetxt.BackColor = System.Drawing.Color.White;
            this.agetxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.agetxt.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agetxt.Location = new System.Drawing.Point(723, 451);
            this.agetxt.Name = "agetxt";
            this.agetxt.Size = new System.Drawing.Size(56, 28);
            this.agetxt.TabIndex = 31;
            // 
            // gendertxt
            // 
            this.gendertxt.BackColor = System.Drawing.Color.White;
            this.gendertxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gendertxt.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gendertxt.Location = new System.Drawing.Point(612, 451);
            this.gendertxt.Name = "gendertxt";
            this.gendertxt.Size = new System.Drawing.Size(75, 28);
            this.gendertxt.TabIndex = 30;
            // 
            // winlbl
            // 
            this.winlbl.AutoSize = true;
            this.winlbl.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.winlbl.Location = new System.Drawing.Point(313, 417);
            this.winlbl.Name = "winlbl";
            this.winlbl.Size = new System.Drawing.Size(59, 20);
            this.winlbl.TabIndex = 29;
            this.winlbl.Text = "Name";
            // 
            // uname
            // 
            this.uname.AutoSize = true;
            this.uname.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uname.Location = new System.Drawing.Point(115, 417);
            this.uname.Name = "uname";
            this.uname.Size = new System.Drawing.Size(95, 20);
            this.uname.TabIndex = 28;
            this.uname.Text = "Username";
            // 
            // namelbl
            // 
            this.namelbl.AutoSize = true;
            this.namelbl.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namelbl.Location = new System.Drawing.Point(26, 418);
            this.namelbl.Name = "namelbl";
            this.namelbl.Size = new System.Drawing.Size(88, 20);
            this.namelbl.TabIndex = 27;
            this.namelbl.Text = "Player ID";
            // 
            // nametxt
            // 
            this.nametxt.BackColor = System.Drawing.Color.White;
            this.nametxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nametxt.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nametxt.Location = new System.Drawing.Point(317, 451);
            this.nametxt.Name = "nametxt";
            this.nametxt.Size = new System.Drawing.Size(151, 28);
            this.nametxt.TabIndex = 26;
            // 
            // unametxt
            // 
            this.unametxt.BackColor = System.Drawing.Color.White;
            this.unametxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.unametxt.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unametxt.Location = new System.Drawing.Point(119, 452);
            this.unametxt.Name = "unametxt";
            this.unametxt.Size = new System.Drawing.Size(170, 28);
            this.unametxt.TabIndex = 25;
            // 
            // idtxt
            // 
            this.idtxt.BackColor = System.Drawing.Color.White;
            this.idtxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.idtxt.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idtxt.Location = new System.Drawing.Point(30, 452);
            this.idtxt.Name = "idtxt";
            this.idtxt.Size = new System.Drawing.Size(62, 28);
            this.idtxt.TabIndex = 24;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.username,
            this.name,
            this.team,
            this.gender,
            this.age,
            this.agent,
            this.mmr,
            this.kills,
            this.deaths,
            this.location});
            this.dataGridView1.Location = new System.Drawing.Point(30, 46);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1095, 328);
            this.dataGridView1.TabIndex = 23;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // id
            // 
            this.id.HeaderText = "Player ID";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.Width = 91;
            // 
            // username
            // 
            this.username.HeaderText = "Username";
            this.username.MinimumWidth = 6;
            this.username.Name = "username";
            this.username.Width = 99;
            // 
            // name
            // 
            this.name.HeaderText = "Full Name";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            this.name.Width = 97;
            // 
            // team
            // 
            this.team.HeaderText = "Team ID";
            this.team.MinimumWidth = 6;
            this.team.Name = "team";
            this.team.ReadOnly = true;
            this.team.Width = 88;
            // 
            // gender
            // 
            this.gender.HeaderText = "Gender";
            this.gender.MinimumWidth = 6;
            this.gender.Name = "gender";
            this.gender.Width = 81;
            // 
            // age
            // 
            this.age.HeaderText = "Age";
            this.age.MinimumWidth = 6;
            this.age.Name = "age";
            this.age.Width = 61;
            // 
            // agent
            // 
            this.agent.HeaderText = "Favorite Agent";
            this.agent.MinimumWidth = 6;
            this.agent.Name = "agent";
            this.agent.Width = 123;
            // 
            // mmr
            // 
            this.mmr.HeaderText = "MMR";
            this.mmr.MinimumWidth = 6;
            this.mmr.Name = "mmr";
            this.mmr.Width = 68;
            // 
            // kills
            // 
            this.kills.HeaderText = "Kills";
            this.kills.MinimumWidth = 6;
            this.kills.Name = "kills";
            this.kills.Width = 60;
            // 
            // deaths
            // 
            this.deaths.HeaderText = "Deaths";
            this.deaths.MinimumWidth = 6;
            this.deaths.Name = "deaths";
            this.deaths.Width = 79;
            // 
            // location
            // 
            this.location.HeaderText = "Location ID";
            this.location.MinimumWidth = 6;
            this.location.Name = "location";
            this.location.ReadOnly = true;
            this.location.Width = 103;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(27, 491);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 20);
            this.label7.TabIndex = 45;
            this.label7.Text = "MMR";
            // 
            // mmrtxt
            // 
            this.mmrtxt.BackColor = System.Drawing.Color.White;
            this.mmrtxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mmrtxt.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mmrtxt.Location = new System.Drawing.Point(30, 526);
            this.mmrtxt.Name = "mmrtxt";
            this.mmrtxt.Size = new System.Drawing.Size(56, 28);
            this.mmrtxt.TabIndex = 46;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(114, 491);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 20);
            this.label8.TabIndex = 47;
            this.label8.Text = "Kills";
            // 
            // killstxt
            // 
            this.killstxt.BackColor = System.Drawing.Color.White;
            this.killstxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.killstxt.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.killstxt.Location = new System.Drawing.Point(118, 526);
            this.killstxt.Name = "killstxt";
            this.killstxt.Size = new System.Drawing.Size(56, 28);
            this.killstxt.TabIndex = 48;
            // 
            // deathstxt
            // 
            this.deathstxt.BackColor = System.Drawing.Color.White;
            this.deathstxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.deathstxt.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deathstxt.Location = new System.Drawing.Point(206, 526);
            this.deathstxt.Name = "deathstxt";
            this.deathstxt.Size = new System.Drawing.Size(56, 28);
            this.deathstxt.TabIndex = 50;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(202, 491);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.TabIndex = 49;
            this.label4.Text = "Deaths";
            // 
            // locationtxt
            // 
            this.locationtxt.BackColor = System.Drawing.Color.White;
            this.locationtxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.locationtxt.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locationtxt.Location = new System.Drawing.Point(301, 526);
            this.locationtxt.Name = "locationtxt";
            this.locationtxt.Size = new System.Drawing.Size(71, 28);
            this.locationtxt.TabIndex = 52;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(299, 491);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 20);
            this.label5.TabIndex = 51;
            this.label5.Text = "Location ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(490, 417);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 20);
            this.label6.TabIndex = 54;
            this.label6.Text = "Team ID";
            // 
            // tidtxt
            // 
            this.tidtxt.BackColor = System.Drawing.Color.White;
            this.tidtxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tidtxt.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tidtxt.Location = new System.Drawing.Point(494, 451);
            this.tidtxt.Name = "tidtxt";
            this.tidtxt.Size = new System.Drawing.Size(75, 28);
            this.tidtxt.TabIndex = 53;
            // 
            // rollback_btn
            // 
            this.rollback_btn.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.rollback_btn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.rollback_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rollback_btn.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rollback_btn.Location = new System.Drawing.Point(473, 686);
            this.rollback_btn.Name = "rollback_btn";
            this.rollback_btn.Size = new System.Drawing.Size(175, 60);
            this.rollback_btn.TabIndex = 106;
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
            this.commit_btn.Location = new System.Drawing.Point(233, 686);
            this.commit_btn.Name = "commit_btn";
            this.commit_btn.Size = new System.Drawing.Size(175, 60);
            this.commit_btn.TabIndex = 105;
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
            this.refreshbtn.Location = new System.Drawing.Point(723, 686);
            this.refreshbtn.Name = "refreshbtn";
            this.refreshbtn.Size = new System.Drawing.Size(175, 60);
            this.refreshbtn.TabIndex = 107;
            this.refreshbtn.Text = "Refresh";
            this.refreshbtn.UseVisualStyleBackColor = false;
            this.refreshbtn.Click += new System.EventHandler(this.refreshbtn_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(27, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 16);
            this.label9.TabIndex = 109;
            this.label9.Text = "Enter query here:";
            // 
            // querytb
            // 
            this.querytb.Location = new System.Drawing.Point(141, 6);
            this.querytb.Name = "querytb";
            this.querytb.Size = new System.Drawing.Size(984, 22);
            this.querytb.TabIndex = 108;
            this.querytb.Text = "select * from maps where ";
            this.querytb.TextChanged += new System.EventHandler(this.querytb_TextChanged);
            this.querytb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.querytb_KeyPress);
            // 
            // PlayerView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1163, 779);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.querytb);
            this.Controls.Add(this.refreshbtn);
            this.Controls.Add(this.rollback_btn);
            this.Controls.Add(this.commit_btn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tidtxt);
            this.Controls.Add(this.locationtxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.deathstxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.killstxt);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.mmrtxt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.updatebtn);
            this.Controls.Add(this.deletebtn);
            this.Controls.Add(this.insert_btn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.agentxt);
            this.Controls.Add(this.agetxt);
            this.Controls.Add(this.gendertxt);
            this.Controls.Add(this.winlbl);
            this.Controls.Add(this.uname);
            this.Controls.Add(this.namelbl);
            this.Controls.Add(this.nametxt);
            this.Controls.Add(this.unametxt);
            this.Controls.Add(this.idtxt);
            this.Controls.Add(this.dataGridView1);
            this.Name = "PlayerView";
            this.Text = "PlayerView";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button updatebtn;
        private System.Windows.Forms.Button deletebtn;
        private System.Windows.Forms.Button insert_btn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox agentxt;
        private System.Windows.Forms.TextBox agetxt;
        private System.Windows.Forms.TextBox gendertxt;
        private System.Windows.Forms.Label winlbl;
        private System.Windows.Forms.Label uname;
        private System.Windows.Forms.Label namelbl;
        private System.Windows.Forms.TextBox nametxt;
        private System.Windows.Forms.TextBox unametxt;
        private System.Windows.Forms.TextBox idtxt;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox mmrtxt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox killstxt;
        private System.Windows.Forms.TextBox deathstxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox locationtxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn username;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn team;
        private System.Windows.Forms.DataGridViewTextBoxColumn gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn age;
        private System.Windows.Forms.DataGridViewTextBoxColumn agent;
        private System.Windows.Forms.DataGridViewTextBoxColumn mmr;
        private System.Windows.Forms.DataGridViewTextBoxColumn kills;
        private System.Windows.Forms.DataGridViewTextBoxColumn deaths;
        private System.Windows.Forms.DataGridViewTextBoxColumn location;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tidtxt;
        private System.Windows.Forms.Button rollback_btn;
        private System.Windows.Forms.Button commit_btn;
        private System.Windows.Forms.Button refreshbtn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox querytb;
    }
}