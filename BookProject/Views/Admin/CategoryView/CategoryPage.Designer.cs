namespace BookProject.Views.Admin.CategoryView
{
    partial class CategoryPage
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
            this.grpadd = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textadd = new System.Windows.Forms.TextBox();
            this.textdecad = new System.Windows.Forms.TextBox();
            this.btncatadd = new System.Windows.Forms.Button();
            this.grplist = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonup = new System.Windows.Forms.Button();
            this.textdeup = new System.Windows.Forms.TextBox();
            this.textnameaup = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttondel = new System.Windows.Forms.Button();
            this.textdel = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.grpadd.SuspendLayout();
            this.grplist.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpadd
            // 
            this.grpadd.Controls.Add(this.btncatadd);
            this.grpadd.Controls.Add(this.textdecad);
            this.grpadd.Controls.Add(this.textadd);
            this.grpadd.Controls.Add(this.label2);
            this.grpadd.Controls.Add(this.label1);
            this.grpadd.Location = new System.Drawing.Point(12, 12);
            this.grpadd.Name = "grpadd";
            this.grpadd.Size = new System.Drawing.Size(277, 221);
            this.grpadd.TabIndex = 0;
            this.grpadd.TabStop = false;
            this.grpadd.Text = "Category Add";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Description :";
            // 
            // textadd
            // 
            this.textadd.Location = new System.Drawing.Point(72, 37);
            this.textadd.Multiline = true;
            this.textadd.Name = "textadd";
            this.textadd.Size = new System.Drawing.Size(184, 32);
            this.textadd.TabIndex = 2;
            // 
            // textdecad
            // 
            this.textdecad.Location = new System.Drawing.Point(72, 83);
            this.textdecad.Multiline = true;
            this.textdecad.Name = "textdecad";
            this.textdecad.Size = new System.Drawing.Size(184, 62);
            this.textdecad.TabIndex = 3;
            // 
            // btncatadd
            // 
            this.btncatadd.Location = new System.Drawing.Point(118, 161);
            this.btncatadd.Name = "btncatadd";
            this.btncatadd.Size = new System.Drawing.Size(75, 38);
            this.btncatadd.TabIndex = 4;
            this.btncatadd.Text = "Submit";
            this.btncatadd.UseVisualStyleBackColor = true;
            this.btncatadd.Click += new System.EventHandler(this.btncatadd_Click);
            // 
            // grplist
            // 
            this.grplist.Controls.Add(this.dataGridView1);
            this.grplist.Location = new System.Drawing.Point(12, 239);
            this.grplist.Name = "grplist";
            this.grplist.Size = new System.Drawing.Size(801, 199);
            this.grplist.TabIndex = 1;
            this.grplist.TabStop = false;
            this.grplist.Text = "Category List";
            this.grplist.Enter += new System.EventHandler(this.grplist_Enter);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(787, 174);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonup);
            this.groupBox1.Controls.Add(this.textdeup);
            this.groupBox1.Controls.Add(this.textnameaup);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(322, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(272, 221);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Category Update";
            // 
            // buttonup
            // 
            this.buttonup.Location = new System.Drawing.Point(122, 161);
            this.buttonup.Name = "buttonup";
            this.buttonup.Size = new System.Drawing.Size(75, 38);
            this.buttonup.TabIndex = 4;
            this.buttonup.Text = "Submit";
            this.buttonup.UseVisualStyleBackColor = true;
            this.buttonup.Click += new System.EventHandler(this.buttonup_Click);
            // 
            // textdeup
            // 
            this.textdeup.Location = new System.Drawing.Point(72, 86);
            this.textdeup.Multiline = true;
            this.textdeup.Name = "textdeup";
            this.textdeup.Size = new System.Drawing.Size(169, 62);
            this.textdeup.TabIndex = 3;
            // 
            // textnameaup
            // 
            this.textnameaup.Location = new System.Drawing.Point(72, 40);
            this.textnameaup.Multiline = true;
            this.textnameaup.Name = "textnameaup";
            this.textnameaup.Size = new System.Drawing.Size(169, 32);
            this.textnameaup.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Description :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Name :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttondel);
            this.groupBox2.Controls.Add(this.textdel);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(600, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(213, 221);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Category Delete";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // buttondel
            // 
            this.buttondel.Location = new System.Drawing.Point(78, 161);
            this.buttondel.Name = "buttondel";
            this.buttondel.Size = new System.Drawing.Size(75, 38);
            this.buttondel.TabIndex = 4;
            this.buttondel.Text = "Submit";
            this.buttondel.UseVisualStyleBackColor = true;
            this.buttondel.Click += new System.EventHandler(this.buttondel_Click);
            // 
            // textdel
            // 
            this.textdel.Location = new System.Drawing.Point(55, 37);
            this.textdel.Multiline = true;
            this.textdel.Name = "textdel";
            this.textdel.Size = new System.Drawing.Size(119, 32);
            this.textdel.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "ID :";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // CategoryPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(822, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grplist);
            this.Controls.Add(this.grpadd);
            this.Name = "CategoryPage";
            this.Text = "CategoryPage";
            this.Load += new System.EventHandler(this.CategoryPage_Load);
            this.grpadd.ResumeLayout(false);
            this.grpadd.PerformLayout();
            this.grplist.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpadd;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btncatadd;
        private System.Windows.Forms.TextBox textdecad;
        private System.Windows.Forms.TextBox textadd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grplist;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonup;
        private System.Windows.Forms.TextBox textdeup;
        private System.Windows.Forms.TextBox textnameaup;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttondel;
        private System.Windows.Forms.TextBox textdel;
        private System.Windows.Forms.Label label6;
    }
}