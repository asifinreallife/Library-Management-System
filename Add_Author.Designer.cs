namespace csharpproject
{
    partial class Add_Author
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
            this.backbtn = new System.Windows.Forms.Button();
            this.pubadd = new System.Windows.Forms.Button();
            this.authoridbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.authornamebox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.authorIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authorNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aUTHORBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.project1DataSet16 = new csharpproject.project1DataSet16();
            this.aUTHORTableAdapter = new csharpproject.project1DataSet16TableAdapters.AUTHORTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aUTHORBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.project1DataSet16)).BeginInit();
            this.SuspendLayout();
            // 
            // backbtn
            // 
            this.backbtn.Location = new System.Drawing.Point(8, 10);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(69, 31);
            this.backbtn.TabIndex = 15;
            this.backbtn.Text = "Back";
            this.backbtn.UseVisualStyleBackColor = true;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // pubadd
            // 
            this.pubadd.Location = new System.Drawing.Point(794, 281);
            this.pubadd.Name = "pubadd";
            this.pubadd.Size = new System.Drawing.Size(76, 30);
            this.pubadd.TabIndex = 14;
            this.pubadd.Text = "Add";
            this.pubadd.UseVisualStyleBackColor = true;
            this.pubadd.Click += new System.EventHandler(this.pubadd_Click);
            // 
            // authoridbox
            // 
            this.authoridbox.Location = new System.Drawing.Point(750, 81);
            this.authoridbox.Name = "authoridbox";
            this.authoridbox.Size = new System.Drawing.Size(152, 29);
            this.authoridbox.TabIndex = 11;
            this.authoridbox.TextChanged += new System.EventHandler(this.authoridbox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(647, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 21);
            this.label1.TabIndex = 8;
            this.label1.Text = "Author Id :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.authornamebox);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.backbtn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pubadd);
            this.panel1.Controls.Add(this.authoridbox);
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(4, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(988, 414);
            this.panel1.TabIndex = 16;
            // 
            // authornamebox
            // 
            this.authornamebox.Location = new System.Drawing.Point(750, 155);
            this.authornamebox.Name = "authornamebox";
            this.authornamebox.Size = new System.Drawing.Size(152, 29);
            this.authornamebox.TabIndex = 34;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(616, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 21);
            this.label5.TabIndex = 33;
            this.label5.Text = "Author Name :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.authorIDDataGridViewTextBoxColumn,
            this.authorNameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.aUTHORBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(103, 55);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(306, 272);
            this.dataGridView1.TabIndex = 16;
            // 
            // authorIDDataGridViewTextBoxColumn
            // 
            this.authorIDDataGridViewTextBoxColumn.DataPropertyName = "Author_ID";
            this.authorIDDataGridViewTextBoxColumn.HeaderText = "Author_ID";
            this.authorIDDataGridViewTextBoxColumn.Name = "authorIDDataGridViewTextBoxColumn";
            this.authorIDDataGridViewTextBoxColumn.Width = 130;
            // 
            // authorNameDataGridViewTextBoxColumn
            // 
            this.authorNameDataGridViewTextBoxColumn.DataPropertyName = "Author_Name";
            this.authorNameDataGridViewTextBoxColumn.HeaderText = "Author_Name";
            this.authorNameDataGridViewTextBoxColumn.Name = "authorNameDataGridViewTextBoxColumn";
            this.authorNameDataGridViewTextBoxColumn.Width = 130;
            // 
            // aUTHORBindingSource
            // 
            this.aUTHORBindingSource.DataMember = "AUTHOR";
            this.aUTHORBindingSource.DataSource = this.project1DataSet16;
            // 
            // project1DataSet16
            // 
            this.project1DataSet16.DataSetName = "project1DataSet16";
            this.project1DataSet16.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aUTHORTableAdapter
            // 
            this.aUTHORTableAdapter.ClearBeforeFill = true;
            // 
            // Add_Author
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1004, 412);
            this.Controls.Add(this.panel1);
            this.Name = "Add_Author";
            this.Text = "Add Author";
            this.Load += new System.EventHandler(this.Add_Author_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aUTHORBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.project1DataSet16)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button backbtn;
        private System.Windows.Forms.Button pubadd;
        private System.Windows.Forms.TextBox authoridbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox authornamebox;
        private project1DataSet16 project1DataSet16;
        private System.Windows.Forms.BindingSource aUTHORBindingSource;
        private project1DataSet16TableAdapters.AUTHORTableAdapter aUTHORTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn authorIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn authorNameDataGridViewTextBoxColumn;
    }
}