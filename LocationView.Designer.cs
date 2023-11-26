
namespace Valorant_Datahub
{
    partial class LocationView
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.updatebtn = new System.Windows.Forms.Button();
            this.deletebtn = new System.Windows.Forms.Button();
            this.insert_btn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.citytxt = new System.Windows.Forms.TextBox();
            this.regiontxt = new System.Windows.Forms.TextBox();
            this.picklbl = new System.Windows.Forms.Label();
            this.namelbl = new System.Windows.Forms.Label();
            this.countrytxt = new System.Windows.Forms.TextBox();
            this.locationtxt = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.location_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.country = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.region = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.city = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // updatebtn
            // 
            this.updatebtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.updatebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updatebtn.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatebtn.Location = new System.Drawing.Point(583, 538);
            this.updatebtn.Name = "updatebtn";
            this.updatebtn.Size = new System.Drawing.Size(155, 55);
            this.updatebtn.TabIndex = 59;
            this.updatebtn.Text = "Update";
            this.updatebtn.UseVisualStyleBackColor = true;
            this.updatebtn.Click += new System.EventHandler(this.updatebtn_Click);
            // 
            // deletebtn
            // 
            this.deletebtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.deletebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deletebtn.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletebtn.Location = new System.Drawing.Point(330, 538);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Size = new System.Drawing.Size(163, 55);
            this.deletebtn.TabIndex = 58;
            this.deletebtn.Text = "Delete";
            this.deletebtn.UseVisualStyleBackColor = true;
            this.deletebtn.Click += new System.EventHandler(this.deletebtn_Click);
            // 
            // insert_btn
            // 
            this.insert_btn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.insert_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.insert_btn.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insert_btn.Location = new System.Drawing.Point(93, 538);
            this.insert_btn.Name = "insert_btn";
            this.insert_btn.Size = new System.Drawing.Size(161, 55);
            this.insert_btn.TabIndex = 57;
            this.insert_btn.Text = "Insert";
            this.insert_btn.UseVisualStyleBackColor = true;
            this.insert_btn.Click += new System.EventHandler(this.insert_btn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(628, 416);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 54;
            this.label4.Text = "City:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(404, 416);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 53;
            this.label3.Text = "Region:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(628, 416);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 52;
            // 
            // citytxt
            // 
            this.citytxt.BackColor = System.Drawing.Color.White;
            this.citytxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.citytxt.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.citytxt.Location = new System.Drawing.Point(632, 450);
            this.citytxt.Name = "citytxt";
            this.citytxt.Size = new System.Drawing.Size(117, 28);
            this.citytxt.TabIndex = 51;
            // 
            // regiontxt
            // 
            this.regiontxt.BackColor = System.Drawing.Color.White;
            this.regiontxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.regiontxt.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regiontxt.Location = new System.Drawing.Point(408, 450);
            this.regiontxt.Name = "regiontxt";
            this.regiontxt.Size = new System.Drawing.Size(177, 28);
            this.regiontxt.TabIndex = 50;
            // 
            // picklbl
            // 
            this.picklbl.AutoSize = true;
            this.picklbl.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.picklbl.Location = new System.Drawing.Point(192, 416);
            this.picklbl.Name = "picklbl";
            this.picklbl.Size = new System.Drawing.Size(85, 20);
            this.picklbl.TabIndex = 49;
            this.picklbl.Text = "Country:";
            // 
            // namelbl
            // 
            this.namelbl.AutoSize = true;
            this.namelbl.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namelbl.Location = new System.Drawing.Point(38, 416);
            this.namelbl.Name = "namelbl";
            this.namelbl.Size = new System.Drawing.Size(115, 20);
            this.namelbl.TabIndex = 48;
            this.namelbl.Text = "Location ID:";
            // 
            // countrytxt
            // 
            this.countrytxt.BackColor = System.Drawing.Color.White;
            this.countrytxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.countrytxt.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countrytxt.Location = new System.Drawing.Point(196, 450);
            this.countrytxt.Name = "countrytxt";
            this.countrytxt.Size = new System.Drawing.Size(177, 28);
            this.countrytxt.TabIndex = 47;
            // 
            // locationtxt
            // 
            this.locationtxt.BackColor = System.Drawing.Color.White;
            this.locationtxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.locationtxt.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locationtxt.Location = new System.Drawing.Point(41, 450);
            this.locationtxt.Name = "locationtxt";
            this.locationtxt.Size = new System.Drawing.Size(112, 28);
            this.locationtxt.TabIndex = 46;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.location_id,
            this.country,
            this.region,
            this.city});
            this.dataGridView1.Location = new System.Drawing.Point(41, 35);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(724, 354);
            this.dataGridView1.TabIndex = 45;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // location_id
            // 
            this.location_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.location_id.HeaderText = "Location ID";
            this.location_id.MinimumWidth = 6;
            this.location_id.Name = "location_id";
            // 
            // country
            // 
            this.country.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.country.HeaderText = "Country";
            this.country.MinimumWidth = 6;
            this.country.Name = "country";
            // 
            // region
            // 
            this.region.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.region.HeaderText = "Region";
            this.region.MinimumWidth = 6;
            this.region.Name = "region";
            // 
            // city
            // 
            this.city.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.city.HeaderText = "City";
            this.city.MinimumWidth = 6;
            this.city.Name = "city";
            // 
            // LocationView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 642);
            this.Controls.Add(this.updatebtn);
            this.Controls.Add(this.deletebtn);
            this.Controls.Add(this.insert_btn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.citytxt);
            this.Controls.Add(this.regiontxt);
            this.Controls.Add(this.picklbl);
            this.Controls.Add(this.namelbl);
            this.Controls.Add(this.countrytxt);
            this.Controls.Add(this.locationtxt);
            this.Controls.Add(this.dataGridView1);
            this.Name = "LocationView";
            this.Text = "LocationView";
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
        private System.Windows.Forms.TextBox citytxt;
        private System.Windows.Forms.TextBox regiontxt;
        private System.Windows.Forms.Label picklbl;
        private System.Windows.Forms.Label namelbl;
        private System.Windows.Forms.TextBox countrytxt;
        private System.Windows.Forms.TextBox locationtxt;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn location_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn country;
        private System.Windows.Forms.DataGridViewTextBoxColumn region;
        private System.Windows.Forms.DataGridViewTextBoxColumn city;
    }
}