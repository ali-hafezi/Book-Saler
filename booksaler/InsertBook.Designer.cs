namespace booksaler
{
    partial class InsertBook
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtbook = new System.Windows.Forms.TextBox();
            this.txtisbn = new System.Windows.Forms.TextBox();
            this.txtprice = new System.Windows.Forms.TextBox();
            this.txtquantity = new System.Windows.Forms.TextBox();
            this.cmbpublisher = new System.Windows.Forms.ComboBox();
            this.tpublisherBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbbooksalerDataSet = new booksaler.dbbooksalerDataSet();
            this.cmbauthor = new System.Windows.Forms.ComboBox();
            this.authorviewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.authorviewTableAdapter = new booksaler.dbbooksalerDataSetTableAdapters.authorviewTableAdapter();
            this.tpublisherTableAdapter = new booksaler.dbbooksalerDataSetTableAdapters.tpublisherTableAdapter();
            this.btninsert = new System.Windows.Forms.Button();
            this.lnkpublisher = new System.Windows.Forms.LinkLabel();
            this.lnkauthor = new System.Windows.Forms.LinkLabel();
            this.lnkdeletepublisher = new System.Windows.Forms.LinkLabel();
            this.lnkdeleteauthor = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.tpublisherBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbbooksalerDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.authorviewBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ISBN :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Book :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Price :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Quantity :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Publisher :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Author :";
            // 
            // txtbook
            // 
            this.txtbook.Location = new System.Drawing.Point(95, 30);
            this.txtbook.Name = "txtbook";
            this.txtbook.Size = new System.Drawing.Size(121, 20);
            this.txtbook.TabIndex = 1;
            // 
            // txtisbn
            // 
            this.txtisbn.Location = new System.Drawing.Point(95, 56);
            this.txtisbn.Name = "txtisbn";
            this.txtisbn.Size = new System.Drawing.Size(121, 20);
            this.txtisbn.TabIndex = 2;
            this.txtisbn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtisbn_KeyPress);
            // 
            // txtprice
            // 
            this.txtprice.Location = new System.Drawing.Point(95, 82);
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(121, 20);
            this.txtprice.TabIndex = 3;
            this.txtprice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtprice_KeyPress);
            // 
            // txtquantity
            // 
            this.txtquantity.Location = new System.Drawing.Point(95, 108);
            this.txtquantity.Name = "txtquantity";
            this.txtquantity.Size = new System.Drawing.Size(121, 20);
            this.txtquantity.TabIndex = 4;
            this.txtquantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtquantity_KeyPress);
            // 
            // cmbpublisher
            // 
            this.cmbpublisher.DataSource = this.tpublisherBindingSource;
            this.cmbpublisher.DisplayMember = "name";
            this.cmbpublisher.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbpublisher.FormattingEnabled = true;
            this.cmbpublisher.Location = new System.Drawing.Point(95, 134);
            this.cmbpublisher.Name = "cmbpublisher";
            this.cmbpublisher.Size = new System.Drawing.Size(121, 21);
            this.cmbpublisher.TabIndex = 5;
            this.cmbpublisher.ValueMember = "id";
            // 
            // tpublisherBindingSource
            // 
            this.tpublisherBindingSource.DataMember = "tpublisher";
            this.tpublisherBindingSource.DataSource = this.dbbooksalerDataSet;
            // 
            // dbbooksalerDataSet
            // 
            this.dbbooksalerDataSet.DataSetName = "dbbooksalerDataSet";
            this.dbbooksalerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbauthor
            // 
            this.cmbauthor.DataSource = this.authorviewBindingSource;
            this.cmbauthor.DisplayMember = "author";
            this.cmbauthor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbauthor.FormattingEnabled = true;
            this.cmbauthor.Location = new System.Drawing.Point(95, 161);
            this.cmbauthor.Name = "cmbauthor";
            this.cmbauthor.Size = new System.Drawing.Size(121, 21);
            this.cmbauthor.TabIndex = 6;
            this.cmbauthor.ValueMember = "id";
            // 
            // authorviewBindingSource
            // 
            this.authorviewBindingSource.DataMember = "authorview";
            this.authorviewBindingSource.DataSource = this.dbbooksalerDataSet;
            // 
            // authorviewTableAdapter
            // 
            this.authorviewTableAdapter.ClearBeforeFill = true;
            // 
            // tpublisherTableAdapter
            // 
            this.tpublisherTableAdapter.ClearBeforeFill = true;
            // 
            // btninsert
            // 
            this.btninsert.Location = new System.Drawing.Point(95, 226);
            this.btninsert.Name = "btninsert";
            this.btninsert.Size = new System.Drawing.Size(75, 23);
            this.btninsert.TabIndex = 7;
            this.btninsert.Text = "Save";
            this.btninsert.UseVisualStyleBackColor = true;
            this.btninsert.Click += new System.EventHandler(this.btninsert_Click);
            // 
            // lnkpublisher
            // 
            this.lnkpublisher.AutoSize = true;
            this.lnkpublisher.Location = new System.Drawing.Point(222, 137);
            this.lnkpublisher.Name = "lnkpublisher";
            this.lnkpublisher.Size = new System.Drawing.Size(76, 13);
            this.lnkpublisher.TabIndex = 13;
            this.lnkpublisher.TabStop = true;
            this.lnkpublisher.Text = "ADD Publisher";
            this.lnkpublisher.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkpublisher_LinkClicked);
            // 
            // lnkauthor
            // 
            this.lnkauthor.AutoSize = true;
            this.lnkauthor.Location = new System.Drawing.Point(222, 164);
            this.lnkauthor.Name = "lnkauthor";
            this.lnkauthor.Size = new System.Drawing.Size(64, 13);
            this.lnkauthor.TabIndex = 14;
            this.lnkauthor.TabStop = true;
            this.lnkauthor.Text = "ADD Author";
            this.lnkauthor.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkauthor_LinkClicked);
            // 
            // lnkdeletepublisher
            // 
            this.lnkdeletepublisher.AutoSize = true;
            this.lnkdeletepublisher.Location = new System.Drawing.Point(304, 137);
            this.lnkdeletepublisher.Name = "lnkdeletepublisher";
            this.lnkdeletepublisher.Size = new System.Drawing.Size(129, 13);
            this.lnkdeletepublisher.TabIndex = 15;
            this.lnkdeletepublisher.TabStop = true;
            this.lnkdeletepublisher.Text = "Delete Selected Publisher";
            this.lnkdeletepublisher.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkdeletepublisher_LinkClicked);
            // 
            // lnkdeleteauthor
            // 
            this.lnkdeleteauthor.AutoSize = true;
            this.lnkdeleteauthor.Location = new System.Drawing.Point(304, 164);
            this.lnkdeleteauthor.Name = "lnkdeleteauthor";
            this.lnkdeleteauthor.Size = new System.Drawing.Size(117, 13);
            this.lnkdeleteauthor.TabIndex = 16;
            this.lnkdeleteauthor.TabStop = true;
            this.lnkdeleteauthor.Text = "Delete Selected Author";
            this.lnkdeleteauthor.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkdeleteauthor_LinkClicked);
            // 
            // InsertBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 261);
            this.Controls.Add(this.lnkdeleteauthor);
            this.Controls.Add(this.lnkdeletepublisher);
            this.Controls.Add(this.lnkauthor);
            this.Controls.Add(this.lnkpublisher);
            this.Controls.Add(this.btninsert);
            this.Controls.Add(this.cmbauthor);
            this.Controls.Add(this.cmbpublisher);
            this.Controls.Add(this.txtquantity);
            this.Controls.Add(this.txtprice);
            this.Controls.Add(this.txtisbn);
            this.Controls.Add(this.txtbook);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "InsertBook";
            this.Text = "InsertBook";
            this.Load += new System.EventHandler(this.InsertBook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tpublisherBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbbooksalerDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.authorviewBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtbook;
        private System.Windows.Forms.TextBox txtisbn;
        private System.Windows.Forms.TextBox txtprice;
        private System.Windows.Forms.TextBox txtquantity;
        private System.Windows.Forms.ComboBox cmbpublisher;
        private System.Windows.Forms.ComboBox cmbauthor;
        private dbbooksalerDataSet dbbooksalerDataSet;
        private System.Windows.Forms.BindingSource authorviewBindingSource;
        private dbbooksalerDataSetTableAdapters.authorviewTableAdapter authorviewTableAdapter;
        private System.Windows.Forms.BindingSource tpublisherBindingSource;
        private dbbooksalerDataSetTableAdapters.tpublisherTableAdapter tpublisherTableAdapter;
        private System.Windows.Forms.Button btninsert;
        private System.Windows.Forms.LinkLabel lnkpublisher;
        private System.Windows.Forms.LinkLabel lnkauthor;
        private System.Windows.Forms.LinkLabel lnkdeletepublisher;
        private System.Windows.Forms.LinkLabel lnkdeleteauthor;
    }
}