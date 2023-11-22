namespace Valorant_Datahub
{
    partial class Tournament_Alternate
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.title_tb = new System.Windows.Forms.TextBox();
            this.prize_tb = new System.Windows.Forms.TextBox();
            this.location_tb = new System.Windows.Forms.TextBox();
            this.search_btn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Tournament_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tournament_Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.Control;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Location = new System.Drawing.Point(12, 23);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(278, 44);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "Fill Atleast One Of The Following:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter Prize Pool: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Enter Tournament\'s Title: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(243, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Enter Tournament\'s Hosting Location";
            // 
            // title_tb
            // 
            this.title_tb.Location = new System.Drawing.Point(279, 77);
            this.title_tb.Name = "title_tb";
            this.title_tb.Size = new System.Drawing.Size(239, 22);
            this.title_tb.TabIndex = 4;
            // 
            // prize_tb
            // 
            this.prize_tb.Location = new System.Drawing.Point(279, 134);
            this.prize_tb.Name = "prize_tb";
            this.prize_tb.Size = new System.Drawing.Size(239, 22);
            this.prize_tb.TabIndex = 5;
            // 
            // location_tb
            // 
            this.location_tb.Location = new System.Drawing.Point(279, 194);
            this.location_tb.Name = "location_tb";
            this.location_tb.Size = new System.Drawing.Size(239, 22);
            this.location_tb.TabIndex = 6;
            // 
            // search_btn
            // 
            this.search_btn.Location = new System.Drawing.Point(211, 270);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(170, 46);
            this.search_btn.TabIndex = 7;
            this.search_btn.Text = "Search";
            this.search_btn.UseVisualStyleBackColor = true;
            this.search_btn.Click += new System.EventHandler(this.search_btn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Tournament_ID,
            this.Tournament_Title});
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ButtonShadow;
            this.dataGridView1.Location = new System.Drawing.Point(543, 59);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 2.8F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.RowHeadersWidth = 40;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(557, 511);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.Visible = false;
            // 
            // Tournament_ID
            // 
            this.Tournament_ID.HeaderText = "Tournament_ID";
            this.Tournament_ID.MinimumWidth = 6;
            this.Tournament_ID.Name = "Tournament_ID";
            this.Tournament_ID.ReadOnly = true;
            this.Tournament_ID.Width = 135;
            // 
            // Tournament_Title
            // 
            this.Tournament_Title.HeaderText = "Tournament_Title";
            this.Tournament_Title.MinimumWidth = 6;
            this.Tournament_Title.Name = "Tournament_Title";
            this.Tournament_Title.ReadOnly = true;
            this.Tournament_Title.Width = 149;
            // 
            // Tournament_Alternate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1203, 582);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.search_btn);
            this.Controls.Add(this.location_tb);
            this.Controls.Add(this.prize_tb);
            this.Controls.Add(this.title_tb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Tournament_Alternate";
            this.Text = "Tournament_Alternate";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox title_tb;
        private System.Windows.Forms.TextBox prize_tb;
        private System.Windows.Forms.TextBox location_tb;
        private System.Windows.Forms.Button search_btn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tournament_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tournament_Title;
    }
}