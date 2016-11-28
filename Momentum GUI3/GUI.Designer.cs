namespace Momentum_GUI3
{
    partial class GUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUI));
            this.medlemmer = new System.Windows.Forms.Button();
            this.vis_medlemmer = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.kommentar = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.by = new System.Windows.Forms.TextBox();
            this.postnr = new System.Windows.Forms.TextBox();
            this.adresse = new System.Windows.Forms.TextBox();
            this.efternavn = new System.Windows.Forms.TextBox();
            this.tlf_nr = new System.Windows.Forms.TextBox();
            this.korttype = new System.Windows.Forms.TextBox();
            this.accepter = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.email = new System.Windows.Forms.TextBox();
            this.tilbage_tilføj = new System.Windows.Forms.Button();
            this.fornavn = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.fornavncolumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.efternavnColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mailColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fødselsdatoColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postnummerColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tlf_nrColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.købtColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.indløstColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.udløbsdatoColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.årskorttypeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gentegningColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.andetColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tilbage_vis = new System.Windows.Forms.Button();
            this.forny = new System.Windows.Forms.Button();
            this.søg = new System.Windows.Forms.Button();
            this.mail_medlemmer = new System.Windows.Forms.Button();
            this.rediger = new System.Windows.Forms.Button();
            this.andet = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // medlemmer
            // 
            resources.ApplyResources(this.medlemmer, "medlemmer");
            this.medlemmer.Name = "medlemmer";
            this.medlemmer.UseVisualStyleBackColor = true;
            this.medlemmer.Click += new System.EventHandler(this.button1_Click);
            // 
            // vis_medlemmer
            // 
            resources.ApplyResources(this.vis_medlemmer, "vis_medlemmer");
            this.vis_medlemmer.Name = "vis_medlemmer";
            this.vis_medlemmer.UseVisualStyleBackColor = true;
            this.vis_medlemmer.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.kommentar);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.by);
            this.panel1.Controls.Add(this.postnr);
            this.panel1.Controls.Add(this.adresse);
            this.panel1.Controls.Add(this.efternavn);
            this.panel1.Controls.Add(this.tlf_nr);
            this.panel1.Controls.Add(this.korttype);
            this.panel1.Controls.Add(this.accepter);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.email);
            this.panel1.Controls.Add(this.tilbage_tilføj);
            this.panel1.Controls.Add(this.fornavn);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.Name = "label10";
            // 
            // kommentar
            // 
            resources.ApplyResources(this.kommentar, "kommentar");
            this.kommentar.Name = "kommentar";
            this.kommentar.TextChanged += new System.EventHandler(this.kommentar_TextChanged_1);
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // by
            // 
            resources.ApplyResources(this.by, "by");
            this.by.Name = "by";
            this.by.TextChanged += new System.EventHandler(this.by_TextChanged);
            // 
            // postnr
            // 
            resources.ApplyResources(this.postnr, "postnr");
            this.postnr.Name = "postnr";
            this.postnr.TextChanged += new System.EventHandler(this.postnr_TextChanged);
            // 
            // adresse
            // 
            resources.ApplyResources(this.adresse, "adresse");
            this.adresse.Name = "adresse";
            this.adresse.TextChanged += new System.EventHandler(this.adresse_TextChanged);
            // 
            // efternavn
            // 
            resources.ApplyResources(this.efternavn, "efternavn");
            this.efternavn.Name = "efternavn";
            this.efternavn.TextChanged += new System.EventHandler(this.efternavn_TextChanged);
            // 
            // tlf_nr
            // 
            resources.ApplyResources(this.tlf_nr, "tlf_nr");
            this.tlf_nr.Name = "tlf_nr";
            this.tlf_nr.TextChanged += new System.EventHandler(this.tlf_nr_TextChanged);
            // 
            // korttype
            // 
            resources.ApplyResources(this.korttype, "korttype");
            this.korttype.Name = "korttype";
            this.korttype.TextChanged += new System.EventHandler(this.korttype_TextChanged);
            // 
            // accepter
            // 
            resources.ApplyResources(this.accepter, "accepter");
            this.accepter.Name = "accepter";
            this.accepter.UseVisualStyleBackColor = true;
            this.accepter.Click += new System.EventHandler(this.accepter_Click);
            // 
            // dateTimePicker1
            // 
            resources.ApplyResources(this.dateTimePicker1, "dateTimePicker1");
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Value = new System.DateTime(2016, 11, 25, 10, 8, 25, 0);
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // email
            // 
            resources.ApplyResources(this.email, "email");
            this.email.Name = "email";
            this.email.TextChanged += new System.EventHandler(this.email_TextChanged);
            // 
            // tilbage_tilføj
            // 
            resources.ApplyResources(this.tilbage_tilføj, "tilbage_tilføj");
            this.tilbage_tilføj.Name = "tilbage_tilføj";
            this.tilbage_tilføj.UseVisualStyleBackColor = true;
            this.tilbage_tilføj.Click += new System.EventHandler(this.tilbage_tilføj_Click);
            // 
            // fornavn
            // 
            resources.ApplyResources(this.fornavn, "fornavn");
            this.fornavn.Name = "fornavn";
            this.fornavn.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.tilbage_vis);
            this.panel2.Controls.Add(this.forny);
            this.panel2.Controls.Add(this.søg);
            this.panel2.Controls.Add(this.mail_medlemmer);
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fornavncolumn,
            this.efternavnColumn,
            this.mailColumn,
            this.fødselsdatoColumn,
            this.postnummerColumn,
            this.tlf_nrColumn,
            this.købtColumn,
            this.indløstColumn,
            this.udløbsdatoColumn,
            this.årskorttypeColumn,
            this.gentegningColumn,
            this.andetColumn});
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            resources.ApplyResources(this.dataGridView1, "dataGridView1");
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // fornavncolumn
            // 
            resources.ApplyResources(this.fornavncolumn, "fornavncolumn");
            this.fornavncolumn.Name = "fornavncolumn";
            this.fornavncolumn.ReadOnly = true;
            // 
            // efternavnColumn
            // 
            resources.ApplyResources(this.efternavnColumn, "efternavnColumn");
            this.efternavnColumn.Name = "efternavnColumn";
            this.efternavnColumn.ReadOnly = true;
            // 
            // mailColumn
            // 
            resources.ApplyResources(this.mailColumn, "mailColumn");
            this.mailColumn.Name = "mailColumn";
            this.mailColumn.ReadOnly = true;
            // 
            // fødselsdatoColumn
            // 
            resources.ApplyResources(this.fødselsdatoColumn, "fødselsdatoColumn");
            this.fødselsdatoColumn.Name = "fødselsdatoColumn";
            this.fødselsdatoColumn.ReadOnly = true;
            // 
            // postnummerColumn
            // 
            resources.ApplyResources(this.postnummerColumn, "postnummerColumn");
            this.postnummerColumn.Name = "postnummerColumn";
            this.postnummerColumn.ReadOnly = true;
            // 
            // tlf_nrColumn
            // 
            resources.ApplyResources(this.tlf_nrColumn, "tlf_nrColumn");
            this.tlf_nrColumn.Name = "tlf_nrColumn";
            this.tlf_nrColumn.ReadOnly = true;
            // 
            // købtColumn
            // 
            resources.ApplyResources(this.købtColumn, "købtColumn");
            this.købtColumn.Name = "købtColumn";
            this.købtColumn.ReadOnly = true;
            // 
            // indløstColumn
            // 
            resources.ApplyResources(this.indløstColumn, "indløstColumn");
            this.indløstColumn.Name = "indløstColumn";
            this.indløstColumn.ReadOnly = true;
            // 
            // udløbsdatoColumn
            // 
            resources.ApplyResources(this.udløbsdatoColumn, "udløbsdatoColumn");
            this.udløbsdatoColumn.Name = "udløbsdatoColumn";
            this.udløbsdatoColumn.ReadOnly = true;
            // 
            // årskorttypeColumn
            // 
            resources.ApplyResources(this.årskorttypeColumn, "årskorttypeColumn");
            this.årskorttypeColumn.Name = "årskorttypeColumn";
            this.årskorttypeColumn.ReadOnly = true;
            // 
            // gentegningColumn
            // 
            resources.ApplyResources(this.gentegningColumn, "gentegningColumn");
            this.gentegningColumn.Name = "gentegningColumn";
            this.gentegningColumn.ReadOnly = true;
            // 
            // andetColumn
            // 
            resources.ApplyResources(this.andetColumn, "andetColumn");
            this.andetColumn.Name = "andetColumn";
            this.andetColumn.ReadOnly = true;
            // 
            // tilbage_vis
            // 
            resources.ApplyResources(this.tilbage_vis, "tilbage_vis");
            this.tilbage_vis.Name = "tilbage_vis";
            this.tilbage_vis.UseVisualStyleBackColor = true;
            this.tilbage_vis.Click += new System.EventHandler(this.tilbage_vis_Click);
            // 
            // forny
            // 
            resources.ApplyResources(this.forny, "forny");
            this.forny.Name = "forny";
            this.forny.UseVisualStyleBackColor = true;
            // 
            // søg
            // 
            resources.ApplyResources(this.søg, "søg");
            this.søg.Name = "søg";
            this.søg.UseVisualStyleBackColor = true;
            // 
            // mail_medlemmer
            // 
            resources.ApplyResources(this.mail_medlemmer, "mail_medlemmer");
            this.mail_medlemmer.Name = "mail_medlemmer";
            this.mail_medlemmer.UseVisualStyleBackColor = true;
            // 
            // rediger
            // 
            resources.ApplyResources(this.rediger, "rediger");
            this.rediger.Name = "rediger";
            this.rediger.UseVisualStyleBackColor = true;
            // 
            // andet
            // 
            resources.ApplyResources(this.andet, "andet");
            this.andet.Name = "andet";
            this.andet.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Name = "label11";
            // 
            // GUI
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.vis_medlemmer);
            this.Controls.Add(this.medlemmer);
            this.Controls.Add(this.rediger);
            this.Controls.Add(this.andet);
            this.Name = "GUI";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button medlemmer;
        private System.Windows.Forms.Button vis_medlemmer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox fornavn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button tilbage_tilføj;
        private System.Windows.Forms.Button tilbage_vis;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.TextBox efternavn;
        private System.Windows.Forms.TextBox tlf_nr;
        private System.Windows.Forms.TextBox korttype;
        private System.Windows.Forms.Button accepter;
        private System.Windows.Forms.TextBox adresse;
        private System.Windows.Forms.TextBox by;
        private System.Windows.Forms.TextBox postnr;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn fornavncolumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn efternavnColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mailColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fødselsdatoColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn postnummerColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tlf_nrColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn købtColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn indløstColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn udløbsdatoColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn årskorttypeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gentegningColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn andetColumn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button rediger;
        private System.Windows.Forms.Button forny;
        private System.Windows.Forms.Button søg;
        private System.Windows.Forms.Button mail_medlemmer;
        private System.Windows.Forms.Button andet;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox kommentar;
        private System.Windows.Forms.Label label11;
    }
}

