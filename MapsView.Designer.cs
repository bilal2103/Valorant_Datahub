
namespace Valorant_Datahub
{
    partial class MapsView
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
            this.label5 = new System.Windows.Forms.Label();
            this.desctxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.locationtxt = new System.Windows.Forms.TextBox();
            this.weapontxt = new System.Windows.Forms.TextBox();
            this.picklbl = new System.Windows.Forms.Label();
            this.namelbl = new System.Windows.Forms.Label();
            this.sitestxt = new System.Windows.Forms.TextBox();
            this.nametxt = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spike_sites = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.suited_weapon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.location_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // updatebtn
            // 
            this.updatebtn.Location = new System.Drawing.Point(560, 568);
            this.updatebtn.Name = "updatebtn";
            this.updatebtn.Size = new System.Drawing.Size(184, 46);
            this.updatebtn.TabIndex = 44;
            this.updatebtn.Text = "Update";
            this.updatebtn.UseVisualStyleBackColor = true;
            // 
            // deletebtn
            // 
            this.deletebtn.Location = new System.Drawing.Point(295, 568);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Size = new System.Drawing.Size(185, 46);
            this.deletebtn.TabIndex = 43;
            this.deletebtn.Text = "Delete";
            this.deletebtn.UseVisualStyleBackColor = true;
            this.deletebtn.Click += new System.EventHandler(this.deletebtn_Click);
            // 
            // insert_btn
            // 
            this.insert_btn.Location = new System.Drawing.Point(36, 568);
            this.insert_btn.Name = "insert_btn";
            this.insert_btn.Size = new System.Drawing.Size(181, 46);
            this.insert_btn.TabIndex = 42;
            this.insert_btn.Text = "Insert";
            this.insert_btn.UseVisualStyleBackColor = true;
            this.insert_btn.Click += new System.EventHandler(this.insert_btn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 491);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 17);
            this.label5.TabIndex = 39;
            this.label5.Text = "Description:";
            // 
            // desctxt
            // 
            this.desctxt.Location = new System.Drawing.Point(36, 511);
            this.desctxt.Name = "desctxt";
            this.desctxt.Size = new System.Drawing.Size(708, 22);
            this.desctxt.TabIndex = 38;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(616, 430);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 17);
            this.label4.TabIndex = 37;
            this.label4.Text = "Location ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(406, 430);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 17);
            this.label3.TabIndex = 36;
            this.label3.Text = "Suited Weapon:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(505, 430);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 35;
            // 
            // locationtxt
            // 
            this.locationtxt.Location = new System.Drawing.Point(619, 450);
            this.locationtxt.Name = "locationtxt";
            this.locationtxt.Size = new System.Drawing.Size(125, 22);
            this.locationtxt.TabIndex = 33;
            // 
            // weapontxt
            // 
            this.weapontxt.Location = new System.Drawing.Point(401, 450);
            this.weapontxt.Name = "weapontxt";
            this.weapontxt.Size = new System.Drawing.Size(179, 22);
            this.weapontxt.TabIndex = 32;
            this.weapontxt.TextChanged += new System.EventHandler(this.weapontxt_TextChanged);
            // 
            // picklbl
            // 
            this.picklbl.AutoSize = true;
            this.picklbl.Location = new System.Drawing.Point(241, 430);
            this.picklbl.Name = "picklbl";
            this.picklbl.Size = new System.Drawing.Size(82, 17);
            this.picklbl.TabIndex = 28;
            this.picklbl.Text = "Spike Sites:";
            // 
            // namelbl
            // 
            this.namelbl.AutoSize = true;
            this.namelbl.Location = new System.Drawing.Point(33, 430);
            this.namelbl.Name = "namelbl";
            this.namelbl.Size = new System.Drawing.Size(49, 17);
            this.namelbl.TabIndex = 27;
            this.namelbl.Text = "Name:";
            // 
            // sitestxt
            // 
            this.sitestxt.Location = new System.Drawing.Point(237, 450);
            this.sitestxt.Name = "sitestxt";
            this.sitestxt.Size = new System.Drawing.Size(129, 22);
            this.sitestxt.TabIndex = 25;
            // 
            // nametxt
            // 
            this.nametxt.Location = new System.Drawing.Point(36, 450);
            this.nametxt.Name = "nametxt";
            this.nametxt.Size = new System.Drawing.Size(162, 22);
            this.nametxt.TabIndex = 24;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.spike_sites,
            this.suited_weapon,
            this.location_id,
            this.description});
            this.dataGridView1.Location = new System.Drawing.Point(27, 49);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(717, 356);
            this.dataGridView1.TabIndex = 23;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // name
            // 
            this.name.HeaderText = "Name";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            this.name.Width = 125;
            // 
            // spike_sites
            // 
            this.spike_sites.HeaderText = "Spike Sites";
            this.spike_sites.MinimumWidth = 6;
            this.spike_sites.Name = "spike_sites";
            this.spike_sites.Width = 125;
            // 
            // suited_weapon
            // 
            this.suited_weapon.HeaderText = "Suited Weapon";
            this.suited_weapon.MinimumWidth = 6;
            this.suited_weapon.Name = "suited_weapon";
            this.suited_weapon.Width = 125;
            // 
            // location_id
            // 
            this.location_id.HeaderText = "Location ID";
            this.location_id.MinimumWidth = 6;
            this.location_id.Name = "location_id";
            this.location_id.Width = 125;
            // 
            // description
            // 
            this.description.HeaderText = "Description";
            this.description.MinimumWidth = 6;
            this.description.Name = "description";
            this.description.Width = 125;
            // 
            // MapsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 650);
            this.Controls.Add(this.updatebtn);
            this.Controls.Add(this.deletebtn);
            this.Controls.Add(this.insert_btn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.desctxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.locationtxt);
            this.Controls.Add(this.weapontxt);
            this.Controls.Add(this.picklbl);
            this.Controls.Add(this.namelbl);
            this.Controls.Add(this.sitestxt);
            this.Controls.Add(this.nametxt);
            this.Controls.Add(this.dataGridView1);
            this.Name = "MapsView";
            this.Text = "MapsView";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button updatebtn;
        private System.Windows.Forms.Button deletebtn;
        private System.Windows.Forms.Button insert_btn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox desctxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox locationtxt;
        private System.Windows.Forms.TextBox weapontxt;
        private System.Windows.Forms.Label picklbl;
        private System.Windows.Forms.Label namelbl;
        private System.Windows.Forms.TextBox sitestxt;
        private System.Windows.Forms.TextBox nametxt;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn spike_sites;
        private System.Windows.Forms.DataGridViewTextBoxColumn suited_weapon;
        private System.Windows.Forms.DataGridViewTextBoxColumn location_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
    }
}