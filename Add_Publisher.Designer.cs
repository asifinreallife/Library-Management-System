namespace csharpproject
{
    partial class Add_Publisher
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pubid = new System.Windows.Forms.TextBox();
            this.pubname = new System.Windows.Forms.TextBox();
            this.pubaddress = new System.Windows.Forms.TextBox();
            this.pubadd = new System.Windows.Forms.Button();
            this.backbtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.publisherIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publisherNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publisherAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pUBLISHERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.project1DataSet17 = new csharpproject.project1DataSet17();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pUBLISHERTableAdapter = new csharpproject.project1DataSet17TableAdapters.PUBLISHERTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pUBLISHERBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.project1DataSet17)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(720, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Publisher Id :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(689, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Publisher Name :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(672, 296);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Publisher Address :";
            // 
            // pubid
            // 
            this.pubid.Location = new System.Drawing.Point(854, 152);
            this.pubid.Name = "pubid";
            this.pubid.Size = new System.Drawing.Size(162, 26);
            this.pubid.TabIndex = 3;
            // 
            // pubname
            // 
            this.pubname.Location = new System.Drawing.Point(854, 218);
            this.pubname.Name = "pubname";
            this.pubname.Size = new System.Drawing.Size(162, 26);
            this.pubname.TabIndex = 4;
            this.pubname.TextChanged += new System.EventHandler(this.pubname_TextChanged);
            // 
            // pubaddress
            // 
            this.pubaddress.Location = new System.Drawing.Point(854, 293);
            this.pubaddress.Name = "pubaddress";
            this.pubaddress.Size = new System.Drawing.Size(162, 26);
            this.pubaddress.TabIndex = 5;
            // 
            // pubadd
            // 
            this.pubadd.Location = new System.Drawing.Point(911, 360);
            this.pubadd.Name = "pubadd";
            this.pubadd.Size = new System.Drawing.Size(66, 31);
            this.pubadd.TabIndex = 6;
            this.pubadd.Text = "Add";
            this.pubadd.UseVisualStyleBackColor = true;
            this.pubadd.Click += new System.EventHandler(this.pubadd_Click);
            // 
            // backbtn
            // 
            this.backbtn.Location = new System.Drawing.Point(12, 9);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(67, 32);
            this.backbtn.TabIndex = 7;
            this.backbtn.Text = "Back";
            this.backbtn.UseVisualStyleBackColor = true;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.publisherIDDataGridViewTextBoxColumn,
            this.publisherNameDataGridViewTextBoxColumn,
            this.publisherAddressDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.pUBLISHERBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 116);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(430, 301);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.TabStop = false;
            // 
            // publisherIDDataGridViewTextBoxColumn
            // 
            this.publisherIDDataGridViewTextBoxColumn.DataPropertyName = "Publisher_ID";
            this.publisherIDDataGridViewTextBoxColumn.HeaderText = "Publisher_ID";
            this.publisherIDDataGridViewTextBoxColumn.Name = "publisherIDDataGridViewTextBoxColumn";
            // 
            // publisherNameDataGridViewTextBoxColumn
            // 
            this.publisherNameDataGridViewTextBoxColumn.DataPropertyName = "Publisher_Name";
            this.publisherNameDataGridViewTextBoxColumn.HeaderText = "Publisher_Name";
            this.publisherNameDataGridViewTextBoxColumn.Name = "publisherNameDataGridViewTextBoxColumn";
            this.publisherNameDataGridViewTextBoxColumn.Width = 120;
            // 
            // publisherAddressDataGridViewTextBoxColumn
            // 
            this.publisherAddressDataGridViewTextBoxColumn.DataPropertyName = "Publisher_Address";
            this.publisherAddressDataGridViewTextBoxColumn.HeaderText = "Publisher_Address";
            this.publisherAddressDataGridViewTextBoxColumn.Name = "publisherAddressDataGridViewTextBoxColumn";
            this.publisherAddressDataGridViewTextBoxColumn.Width = 170;
            // 
            // pUBLISHERBindingSource
            // 
            this.pUBLISHERBindingSource.DataMember = "PUBLISHER";
            this.pUBLISHERBindingSource.DataSource = this.project1DataSet17;
            // 
            // project1DataSet17
            // 
            this.project1DataSet17.DataSetName = "project1DataSet17";
            this.project1DataSet17.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.pubaddress);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.pubname);
            this.panel2.Controls.Add(this.pubid);
            this.panel2.Controls.Add(this.backbtn);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.pubadd);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(0, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1063, 538);
            this.panel2.TabIndex = 11;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::csharpproject.Properties.Resources.thumb_COLOURBOX6445251;
            this.pictureBox1.Location = new System.Drawing.Point(500, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(158, 122);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // pUBLISHERTableAdapter
            // 
            this.pUBLISHERTableAdapter.ClearBeforeFill = true;
            // 
            // Add_Publisher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1064, 553);
            this.Controls.Add(this.panel2);
            this.Name = "Add_Publisher";
            this.Text = "Publisher";
            this.Load += new System.EventHandler(this.Add_Publisher_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pUBLISHERBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.project1DataSet17)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox pubid;
        private System.Windows.Forms.TextBox pubname;
        private System.Windows.Forms.TextBox pubaddress;
        private System.Windows.Forms.Button pubadd;
        private System.Windows.Forms.Button backbtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private project1DataSet17 project1DataSet17;
        private System.Windows.Forms.BindingSource pUBLISHERBindingSource;
        private project1DataSet17TableAdapters.PUBLISHERTableAdapter pUBLISHERTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn publisherIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn publisherNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn publisherAddressDataGridViewTextBoxColumn;
    }
}