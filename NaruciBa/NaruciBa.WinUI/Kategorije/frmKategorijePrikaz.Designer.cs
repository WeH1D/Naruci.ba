
namespace NaruciBa.WinUI.Kategorije
{
    partial class frmKategorijePrikaz
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.flpKategorije = new System.Windows.Forms.FlowLayoutPanel();
            this.dgvIdk = new System.Windows.Forms.DataGridView();
            this.DgvMain = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlFlow = new System.Windows.Forms.Panel();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.pnlEditKategorija = new System.Windows.Forms.Panel();
            this.pnlAddKategorija = new System.Windows.Forms.Panel();
            this.pnlKategorijaAddForm = new System.Windows.Forms.Panel();
            this.pnlDodajPodkategoriju = new System.Windows.Forms.Panel();
            this.btnDodajPodkateogrija = new System.Windows.Forms.Button();
            this.txtPodkategorijaNaziv = new System.Windows.Forms.TextBox();
            this.lblNazivPodkategorija = new System.Windows.Forms.Label();
            this.cbKategorija = new System.Windows.Forms.ComboBox();
            this.lblKategorija = new System.Windows.Forms.Label();
            this.lblDodajPodkategoriju = new System.Windows.Forms.Label();
            this.pnlDodajKategorjiu = new System.Windows.Forms.Panel();
            this.lblDodajKategoriju = new System.Windows.Forms.Label();
            this.lblNazivkategorije = new System.Windows.Forms.Label();
            this.btnDodajKategoriju = new System.Windows.Forms.Button();
            this.txtDodajKategoriju = new System.Windows.Forms.TextBox();
            this.lblIzabranaKategorija = new System.Windows.Forms.Label();
            this.pnlUrediKategoriju = new System.Windows.Forms.Panel();
            this.lblIzabranaKategorijaNaziv = new System.Windows.Forms.Label();
            this.txtOdabranaKategorija = new System.Windows.Forms.TextBox();
            this.btnIzbrisiKategoriju = new System.Windows.Forms.Button();
            this.txtOdabranaPodkategorija = new System.Windows.Forms.TextBox();
            this.lblPodkategorijaNaziv = new System.Windows.Forms.Label();
            this.btnIzbrisiPodkategoriju = new System.Windows.Forms.Button();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.flpKategorije.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIdk)).BeginInit();
            this.pnlFlow.SuspendLayout();
            this.pnlLeft.SuspendLayout();
            this.pnlEditKategorija.SuspendLayout();
            this.pnlAddKategorija.SuspendLayout();
            this.pnlKategorijaAddForm.SuspendLayout();
            this.pnlDodajPodkategoriju.SuspendLayout();
            this.pnlDodajKategorjiu.SuspendLayout();
            this.pnlUrediKategoriju.SuspendLayout();
            this.SuspendLayout();
            // 
            // flpKategorije
            // 
            this.flpKategorije.AutoScroll = true;
            this.flpKategorije.AutoSize = true;
            this.flpKategorije.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flpKategorije.BackColor = System.Drawing.Color.Transparent;
            this.flpKategorije.Controls.Add(this.dgvIdk);
            this.flpKategorije.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpKategorije.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpKategorije.Location = new System.Drawing.Point(10, 10);
            this.flpKategorije.Name = "flpKategorije";
            this.flpKategorije.Size = new System.Drawing.Size(493, 507);
            this.flpKategorije.TabIndex = 3;
            this.flpKategorije.WrapContents = false;
            this.flpKategorije.Layout += new System.Windows.Forms.LayoutEventHandler(this.flpKategorije_Layout);
            // 
            // dgvIdk
            // 
            this.dgvIdk.AllowUserToAddRows = false;
            this.dgvIdk.AllowUserToDeleteRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Transparent;
            this.dgvIdk.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvIdk.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvIdk.BackgroundColor = System.Drawing.Color.White;
            this.dgvIdk.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvIdk.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvIdk.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle8.Padding = new System.Windows.Forms.Padding(0, 15, 0, 15);
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvIdk.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvIdk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIdk.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DgvMain});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Montserrat Light", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvIdk.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgvIdk.EnableHeadersVisualStyles = false;
            this.dgvIdk.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvIdk.Location = new System.Drawing.Point(3, 3);
            this.dgvIdk.Name = "dgvIdk";
            this.dgvIdk.ReadOnly = true;
            this.dgvIdk.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgvIdk.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvIdk.RowHeadersWidth = 20;
            this.dgvIdk.RowTemplate.DividerHeight = 1;
            this.dgvIdk.RowTemplate.Height = 40;
            this.dgvIdk.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvIdk.Size = new System.Drawing.Size(754, 0);
            this.dgvIdk.TabIndex = 1;
            // 
            // DgvMain
            // 
            this.DgvMain.DataPropertyName = "trgovackiLanacID";
            this.DgvMain.HeaderText = "Kategorija";
            this.DgvMain.Name = "DgvMain";
            this.DgvMain.ReadOnly = true;
            // 
            // pnlFlow
            // 
            this.pnlFlow.BackColor = System.Drawing.Color.White;
            this.pnlFlow.Controls.Add(this.flpKategorije);
            this.pnlFlow.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlFlow.Location = new System.Drawing.Point(481, 20);
            this.pnlFlow.Name = "pnlFlow";
            this.pnlFlow.Padding = new System.Windows.Forms.Padding(10);
            this.pnlFlow.Size = new System.Drawing.Size(513, 527);
            this.pnlFlow.TabIndex = 4;
            // 
            // pnlLeft
            // 
            this.pnlLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlLeft.BackColor = System.Drawing.Color.Transparent;
            this.pnlLeft.Controls.Add(this.pnlEditKategorija);
            this.pnlLeft.Controls.Add(this.pnlAddKategorija);
            this.pnlLeft.Location = new System.Drawing.Point(23, 20);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(438, 527);
            this.pnlLeft.TabIndex = 5;
            // 
            // pnlEditKategorija
            // 
            this.pnlEditKategorija.BackColor = System.Drawing.Color.White;
            this.pnlEditKategorija.Controls.Add(this.pnlUrediKategoriju);
            this.pnlEditKategorija.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlEditKategorija.Location = new System.Drawing.Point(0, 259);
            this.pnlEditKategorija.Name = "pnlEditKategorija";
            this.pnlEditKategorija.Size = new System.Drawing.Size(438, 268);
            this.pnlEditKategorija.TabIndex = 1;
            // 
            // pnlAddKategorija
            // 
            this.pnlAddKategorija.BackColor = System.Drawing.Color.White;
            this.pnlAddKategorija.Controls.Add(this.pnlKategorijaAddForm);
            this.pnlAddKategorija.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlAddKategorija.Location = new System.Drawing.Point(0, 0);
            this.pnlAddKategorija.Name = "pnlAddKategorija";
            this.pnlAddKategorija.Size = new System.Drawing.Size(438, 253);
            this.pnlAddKategorija.TabIndex = 0;
            // 
            // pnlKategorijaAddForm
            // 
            this.pnlKategorijaAddForm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlKategorijaAddForm.Controls.Add(this.pnlDodajPodkategoriju);
            this.pnlKategorijaAddForm.Controls.Add(this.pnlDodajKategorjiu);
            this.pnlKategorijaAddForm.Location = new System.Drawing.Point(12, 13);
            this.pnlKategorijaAddForm.Name = "pnlKategorijaAddForm";
            this.pnlKategorijaAddForm.Size = new System.Drawing.Size(414, 226);
            this.pnlKategorijaAddForm.TabIndex = 0;
            // 
            // pnlDodajPodkategoriju
            // 
            this.pnlDodajPodkategoriju.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDodajPodkategoriju.BackColor = System.Drawing.Color.Transparent;
            this.pnlDodajPodkategoriju.Controls.Add(this.btnDodajPodkateogrija);
            this.pnlDodajPodkategoriju.Controls.Add(this.txtPodkategorijaNaziv);
            this.pnlDodajPodkategoriju.Controls.Add(this.lblNazivPodkategorija);
            this.pnlDodajPodkategoriju.Controls.Add(this.cbKategorija);
            this.pnlDodajPodkategoriju.Controls.Add(this.lblKategorija);
            this.pnlDodajPodkategoriju.Controls.Add(this.lblDodajPodkategoriju);
            this.pnlDodajPodkategoriju.Location = new System.Drawing.Point(6, 97);
            this.pnlDodajPodkategoriju.Name = "pnlDodajPodkategoriju";
            this.pnlDodajPodkategoriju.Size = new System.Drawing.Size(405, 126);
            this.pnlDodajPodkategoriju.TabIndex = 6;
            // 
            // btnDodajPodkateogrija
            // 
            this.btnDodajPodkateogrija.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnDodajPodkateogrija.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnDodajPodkateogrija.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDodajPodkateogrija.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajPodkateogrija.ForeColor = System.Drawing.Color.White;
            this.btnDodajPodkateogrija.Location = new System.Drawing.Point(320, 87);
            this.btnDodajPodkateogrija.Name = "btnDodajPodkateogrija";
            this.btnDodajPodkateogrija.Size = new System.Drawing.Size(82, 29);
            this.btnDodajPodkateogrija.TabIndex = 5;
            this.btnDodajPodkateogrija.Text = "Dodaj";
            this.btnDodajPodkateogrija.UseVisualStyleBackColor = false;
            this.btnDodajPodkateogrija.Click += new System.EventHandler(this.btnDodajPodkateogrija_Click);
            // 
            // txtPodkategorijaNaziv
            // 
            this.txtPodkategorijaNaziv.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPodkategorijaNaziv.Font = new System.Drawing.Font("Montserrat Light", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPodkategorijaNaziv.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPodkategorijaNaziv.Location = new System.Drawing.Point(29, 92);
            this.txtPodkategorijaNaziv.Name = "txtPodkategorijaNaziv";
            this.txtPodkategorijaNaziv.Size = new System.Drawing.Size(264, 21);
            this.txtPodkategorijaNaziv.TabIndex = 5;
            // 
            // lblNazivPodkategorija
            // 
            this.lblNazivPodkategorija.AutoSize = true;
            this.lblNazivPodkategorija.Font = new System.Drawing.Font("Montserrat Light", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNazivPodkategorija.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblNazivPodkategorija.Location = new System.Drawing.Point(26, 74);
            this.lblNazivPodkategorija.Name = "lblNazivPodkategorija";
            this.lblNazivPodkategorija.Size = new System.Drawing.Size(39, 15);
            this.lblNazivPodkategorija.TabIndex = 4;
            this.lblNazivPodkategorija.Text = "Naziv:";
            // 
            // cbKategorija
            // 
            this.cbKategorija.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbKategorija.Font = new System.Drawing.Font("Montserrat Light", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbKategorija.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cbKategorija.FormattingEnabled = true;
            this.cbKategorija.Location = new System.Drawing.Point(29, 50);
            this.cbKategorija.Name = "cbKategorija";
            this.cbKategorija.Size = new System.Drawing.Size(264, 23);
            this.cbKategorija.TabIndex = 3;
            // 
            // lblKategorija
            // 
            this.lblKategorija.AutoSize = true;
            this.lblKategorija.Font = new System.Drawing.Font("Montserrat Light", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKategorija.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblKategorija.Location = new System.Drawing.Point(26, 32);
            this.lblKategorija.Name = "lblKategorija";
            this.lblKategorija.Size = new System.Drawing.Size(65, 15);
            this.lblKategorija.TabIndex = 2;
            this.lblKategorija.Text = "Kategorija:";
            // 
            // lblDodajPodkategoriju
            // 
            this.lblDodajPodkategoriju.AutoSize = true;
            this.lblDodajPodkategoriju.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDodajPodkategoriju.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblDodajPodkategoriju.Location = new System.Drawing.Point(3, 0);
            this.lblDodajPodkategoriju.Name = "lblDodajPodkategoriju";
            this.lblDodajPodkategoriju.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblDodajPodkategoriju.Size = new System.Drawing.Size(137, 16);
            this.lblDodajPodkategoriju.TabIndex = 1;
            this.lblDodajPodkategoriju.Text = "Dodaj podkategoriju";
            // 
            // pnlDodajKategorjiu
            // 
            this.pnlDodajKategorjiu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDodajKategorjiu.BackColor = System.Drawing.Color.Transparent;
            this.pnlDodajKategorjiu.Controls.Add(this.lblDodajKategoriju);
            this.pnlDodajKategorjiu.Controls.Add(this.lblNazivkategorije);
            this.pnlDodajKategorjiu.Controls.Add(this.btnDodajKategoriju);
            this.pnlDodajKategorjiu.Controls.Add(this.txtDodajKategoriju);
            this.pnlDodajKategorjiu.Location = new System.Drawing.Point(6, 12);
            this.pnlDodajKategorjiu.Name = "pnlDodajKategorjiu";
            this.pnlDodajKategorjiu.Size = new System.Drawing.Size(405, 69);
            this.pnlDodajKategorjiu.TabIndex = 5;
            // 
            // lblDodajKategoriju
            // 
            this.lblDodajKategoriju.AutoSize = true;
            this.lblDodajKategoriju.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDodajKategoriju.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDodajKategoriju.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblDodajKategoriju.Location = new System.Drawing.Point(0, 0);
            this.lblDodajKategoriju.Name = "lblDodajKategoriju";
            this.lblDodajKategoriju.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblDodajKategoriju.Size = new System.Drawing.Size(113, 16);
            this.lblDodajKategoriju.TabIndex = 0;
            this.lblDodajKategoriju.Text = "Dodaj kategoriju";
            // 
            // lblNazivkategorije
            // 
            this.lblNazivkategorije.AutoSize = true;
            this.lblNazivkategorije.Font = new System.Drawing.Font("Montserrat Light", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNazivkategorije.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblNazivkategorije.Location = new System.Drawing.Point(26, 20);
            this.lblNazivkategorije.Name = "lblNazivkategorije";
            this.lblNazivkategorije.Size = new System.Drawing.Size(39, 15);
            this.lblNazivkategorije.TabIndex = 3;
            this.lblNazivkategorije.Text = "Naziv:";
            // 
            // btnDodajKategoriju
            // 
            this.btnDodajKategoriju.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnDodajKategoriju.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnDodajKategoriju.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDodajKategoriju.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajKategoriju.ForeColor = System.Drawing.Color.White;
            this.btnDodajKategoriju.Location = new System.Drawing.Point(320, 33);
            this.btnDodajKategoriju.Name = "btnDodajKategoriju";
            this.btnDodajKategoriju.Size = new System.Drawing.Size(82, 29);
            this.btnDodajKategoriju.TabIndex = 4;
            this.btnDodajKategoriju.Text = "Dodaj";
            this.btnDodajKategoriju.UseVisualStyleBackColor = false;
            this.btnDodajKategoriju.Click += new System.EventHandler(this.btnDodajKategoriju_Click);
            // 
            // txtDodajKategoriju
            // 
            this.txtDodajKategoriju.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDodajKategoriju.Font = new System.Drawing.Font("Montserrat Light", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDodajKategoriju.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDodajKategoriju.Location = new System.Drawing.Point(29, 38);
            this.txtDodajKategoriju.Name = "txtDodajKategoriju";
            this.txtDodajKategoriju.Size = new System.Drawing.Size(264, 21);
            this.txtDodajKategoriju.TabIndex = 2;
            // 
            // lblIzabranaKategorija
            // 
            this.lblIzabranaKategorija.AutoSize = true;
            this.lblIzabranaKategorija.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIzabranaKategorija.Location = new System.Drawing.Point(12, 12);
            this.lblIzabranaKategorija.Name = "lblIzabranaKategorija";
            this.lblIzabranaKategorija.Size = new System.Drawing.Size(128, 16);
            this.lblIzabranaKategorija.TabIndex = 0;
            this.lblIzabranaKategorija.Text = "Izabrana kategorija";
            // 
            // pnlUrediKategoriju
            // 
            this.pnlUrediKategoriju.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlUrediKategoriju.Controls.Add(this.btnSacuvaj);
            this.pnlUrediKategoriju.Controls.Add(this.btnIzbrisiPodkategoriju);
            this.pnlUrediKategoriju.Controls.Add(this.txtOdabranaPodkategorija);
            this.pnlUrediKategoriju.Controls.Add(this.lblPodkategorijaNaziv);
            this.pnlUrediKategoriju.Controls.Add(this.btnIzbrisiKategoriju);
            this.pnlUrediKategoriju.Controls.Add(this.txtOdabranaKategorija);
            this.pnlUrediKategoriju.Controls.Add(this.lblIzabranaKategorijaNaziv);
            this.pnlUrediKategoriju.Controls.Add(this.lblIzabranaKategorija);
            this.pnlUrediKategoriju.Location = new System.Drawing.Point(12, 12);
            this.pnlUrediKategoriju.Name = "pnlUrediKategoriju";
            this.pnlUrediKategoriju.Size = new System.Drawing.Size(408, 246);
            this.pnlUrediKategoriju.TabIndex = 1;
            // 
            // lblIzabranaKategorijaNaziv
            // 
            this.lblIzabranaKategorijaNaziv.AutoSize = true;
            this.lblIzabranaKategorijaNaziv.Font = new System.Drawing.Font("Montserrat Light", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIzabranaKategorijaNaziv.Location = new System.Drawing.Point(32, 47);
            this.lblIzabranaKategorijaNaziv.Name = "lblIzabranaKategorijaNaziv";
            this.lblIzabranaKategorijaNaziv.Size = new System.Drawing.Size(65, 15);
            this.lblIzabranaKategorijaNaziv.TabIndex = 1;
            this.lblIzabranaKategorijaNaziv.Text = "Kategorija:";
            // 
            // txtOdabranaKategorija
            // 
            this.txtOdabranaKategorija.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOdabranaKategorija.Font = new System.Drawing.Font("Montserrat Light", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOdabranaKategorija.Location = new System.Drawing.Point(35, 66);
            this.txtOdabranaKategorija.Name = "txtOdabranaKategorija";
            this.txtOdabranaKategorija.Size = new System.Drawing.Size(264, 21);
            this.txtOdabranaKategorija.TabIndex = 2;
            // 
            // btnIzbrisiKategoriju
            // 
            this.btnIzbrisiKategoriju.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnIzbrisiKategoriju.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnIzbrisiKategoriju.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIzbrisiKategoriju.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzbrisiKategoriju.ForeColor = System.Drawing.Color.White;
            this.btnIzbrisiKategoriju.Location = new System.Drawing.Point(334, 62);
            this.btnIzbrisiKategoriju.Name = "btnIzbrisiKategoriju";
            this.btnIzbrisiKategoriju.Size = new System.Drawing.Size(71, 29);
            this.btnIzbrisiKategoriju.TabIndex = 3;
            this.btnIzbrisiKategoriju.Text = "Izbrisi";
            this.btnIzbrisiKategoriju.UseVisualStyleBackColor = false;
            // 
            // txtOdabranaPodkategorija
            // 
            this.txtOdabranaPodkategorija.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOdabranaPodkategorija.Font = new System.Drawing.Font("Montserrat Light", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOdabranaPodkategorija.Location = new System.Drawing.Point(35, 123);
            this.txtOdabranaPodkategorija.Name = "txtOdabranaPodkategorija";
            this.txtOdabranaPodkategorija.Size = new System.Drawing.Size(264, 21);
            this.txtOdabranaPodkategorija.TabIndex = 5;
            // 
            // lblPodkategorijaNaziv
            // 
            this.lblPodkategorijaNaziv.AutoSize = true;
            this.lblPodkategorijaNaziv.Font = new System.Drawing.Font("Montserrat Light", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPodkategorijaNaziv.Location = new System.Drawing.Point(32, 104);
            this.lblPodkategorijaNaziv.Name = "lblPodkategorijaNaziv";
            this.lblPodkategorijaNaziv.Size = new System.Drawing.Size(85, 15);
            this.lblPodkategorijaNaziv.TabIndex = 4;
            this.lblPodkategorijaNaziv.Text = "Podkategorija:";
            // 
            // btnIzbrisiPodkategoriju
            // 
            this.btnIzbrisiPodkategoriju.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnIzbrisiPodkategoriju.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnIzbrisiPodkategoriju.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIzbrisiPodkategoriju.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzbrisiPodkategoriju.ForeColor = System.Drawing.Color.White;
            this.btnIzbrisiPodkategoriju.Location = new System.Drawing.Point(334, 119);
            this.btnIzbrisiPodkategoriju.Name = "btnIzbrisiPodkategoriju";
            this.btnIzbrisiPodkategoriju.Size = new System.Drawing.Size(70, 29);
            this.btnIzbrisiPodkategoriju.TabIndex = 6;
            this.btnIzbrisiPodkategoriju.Text = "Izbrisi";
            this.btnIzbrisiPodkategoriju.UseVisualStyleBackColor = false;
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnSacuvaj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnSacuvaj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSacuvaj.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSacuvaj.ForeColor = System.Drawing.Color.White;
            this.btnSacuvaj.Location = new System.Drawing.Point(227, 171);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(177, 29);
            this.btnSacuvaj.TabIndex = 7;
            this.btnSacuvaj.Text = "Sacuvaj Izmjene";
            this.btnSacuvaj.UseVisualStyleBackColor = false;
            // 
            // frmKategorijePrikaz
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1014, 567);
            this.ControlBox = false;
            this.Controls.Add(this.pnlLeft);
            this.Controls.Add(this.pnlFlow);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmKategorijePrikaz";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.Text = "frmKategorijePrikaz";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmKategorijePrikaz_Load);
            this.SizeChanged += new System.EventHandler(this.frmKategorijePrikaz_SizeChanged);
            this.flpKategorije.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIdk)).EndInit();
            this.pnlFlow.ResumeLayout(false);
            this.pnlFlow.PerformLayout();
            this.pnlLeft.ResumeLayout(false);
            this.pnlEditKategorija.ResumeLayout(false);
            this.pnlAddKategorija.ResumeLayout(false);
            this.pnlKategorijaAddForm.ResumeLayout(false);
            this.pnlDodajPodkategoriju.ResumeLayout(false);
            this.pnlDodajPodkategoriju.PerformLayout();
            this.pnlDodajKategorjiu.ResumeLayout(false);
            this.pnlDodajKategorjiu.PerformLayout();
            this.pnlUrediKategoriju.ResumeLayout(false);
            this.pnlUrediKategoriju.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.FlowLayoutPanel flpKategorije;
        private System.Windows.Forms.Panel pnlFlow;
        private System.Windows.Forms.DataGridView dgvIdk;
        private System.Windows.Forms.DataGridViewTextBoxColumn DgvMain;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Panel pnlEditKategorija;
        private System.Windows.Forms.Panel pnlAddKategorija;
        private System.Windows.Forms.Panel pnlKategorijaAddForm;
        private System.Windows.Forms.Label lblDodajPodkategoriju;
        private System.Windows.Forms.Label lblDodajKategoriju;
        private System.Windows.Forms.Button btnDodajKategoriju;
        private System.Windows.Forms.Label lblNazivkategorije;
        private System.Windows.Forms.TextBox txtDodajKategoriju;
        private System.Windows.Forms.Panel pnlDodajKategorjiu;
        private System.Windows.Forms.Panel pnlDodajPodkategoriju;
        private System.Windows.Forms.Button btnDodajPodkateogrija;
        private System.Windows.Forms.TextBox txtPodkategorijaNaziv;
        private System.Windows.Forms.Label lblNazivPodkategorija;
        private System.Windows.Forms.ComboBox cbKategorija;
        private System.Windows.Forms.Label lblKategorija;
        private System.Windows.Forms.Panel pnlUrediKategoriju;
        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.Button btnIzbrisiPodkategoriju;
        private System.Windows.Forms.TextBox txtOdabranaPodkategorija;
        private System.Windows.Forms.Label lblPodkategorijaNaziv;
        private System.Windows.Forms.Button btnIzbrisiKategoriju;
        private System.Windows.Forms.TextBox txtOdabranaKategorija;
        private System.Windows.Forms.Label lblIzabranaKategorijaNaziv;
        private System.Windows.Forms.Label lblIzabranaKategorija;
    }
}