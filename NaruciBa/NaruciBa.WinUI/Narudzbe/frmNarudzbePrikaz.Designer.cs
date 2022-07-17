
namespace NaruciBa.WinUI.Narudzbe
{
    partial class frmNarudzbePrikaz
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvNarudzbe = new System.Windows.Forms.DataGridView();
            this.NarudzbaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Poslovnica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dostavljac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSendMessage = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.txtNarudzbaId = new System.Windows.Forms.TextBox();
            this.txtStatusId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNarudzbe)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.dgvNarudzbe);
            this.panel1.Location = new System.Drawing.Point(0, 75);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(20, 0, 20, 20);
            this.panel1.Size = new System.Drawing.Size(800, 375);
            this.panel1.TabIndex = 1;
            // 
            // dgvNarudzbe
            // 
            this.dgvNarudzbe.AllowUserToAddRows = false;
            this.dgvNarudzbe.AllowUserToDeleteRows = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvNarudzbe.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvNarudzbe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNarudzbe.BackgroundColor = System.Drawing.Color.White;
            this.dgvNarudzbe.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvNarudzbe.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvNarudzbe.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle10.Padding = new System.Windows.Forms.Padding(0, 15, 0, 15);
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvNarudzbe.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvNarudzbe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNarudzbe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NarudzbaId,
            this.Poslovnica,
            this.Adresa,
            this.Status,
            this.Dostavljac});
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Montserrat Light", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNarudzbe.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgvNarudzbe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNarudzbe.EnableHeadersVisualStyles = false;
            this.dgvNarudzbe.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvNarudzbe.Location = new System.Drawing.Point(20, 0);
            this.dgvNarudzbe.Name = "dgvNarudzbe";
            this.dgvNarudzbe.ReadOnly = true;
            this.dgvNarudzbe.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgvNarudzbe.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvNarudzbe.RowHeadersWidth = 20;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvNarudzbe.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvNarudzbe.RowTemplate.DividerHeight = 1;
            this.dgvNarudzbe.RowTemplate.Height = 40;
            this.dgvNarudzbe.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvNarudzbe.Size = new System.Drawing.Size(760, 355);
            this.dgvNarudzbe.TabIndex = 1;
            this.dgvNarudzbe.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNarudzbe_CellClick);
            // 
            // NarudzbaId
            // 
            this.NarudzbaId.DataPropertyName = "narudzbaId";
            this.NarudzbaId.HeaderText = "Id";
            this.NarudzbaId.Name = "NarudzbaId";
            this.NarudzbaId.ReadOnly = true;
            // 
            // Poslovnica
            // 
            this.Poslovnica.DataPropertyName = "poslovnica";
            this.Poslovnica.HeaderText = "Poslovnica";
            this.Poslovnica.Name = "Poslovnica";
            this.Poslovnica.ReadOnly = true;
            // 
            // Adresa
            // 
            this.Adresa.DataPropertyName = "adresa";
            this.Adresa.HeaderText = "Adresa";
            this.Adresa.Name = "Adresa";
            this.Adresa.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "statusNarudzbe";
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // Dostavljac
            // 
            this.Dostavljac.DataPropertyName = "dostavljac";
            this.Dostavljac.HeaderText = "Dostavljac";
            this.Dostavljac.Name = "Dostavljac";
            this.Dostavljac.ReadOnly = true;
            // 
            // btnSendMessage
            // 
            this.btnSendMessage.Location = new System.Drawing.Point(110, 23);
            this.btnSendMessage.Name = "btnSendMessage";
            this.btnSendMessage.Size = new System.Drawing.Size(75, 23);
            this.btnSendMessage.TabIndex = 2;
            this.btnSendMessage.Text = "Send Message";
            this.btnSendMessage.UseVisualStyleBackColor = true;
            this.btnSendMessage.Click += new System.EventHandler(this.btnSendMessage_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(29, 23);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 3;
            this.btnConnect.Text = "connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // txtNarudzbaId
            // 
            this.txtNarudzbaId.Location = new System.Drawing.Point(204, 25);
            this.txtNarudzbaId.Name = "txtNarudzbaId";
            this.txtNarudzbaId.Size = new System.Drawing.Size(100, 20);
            this.txtNarudzbaId.TabIndex = 4;
            // 
            // txtStatusId
            // 
            this.txtStatusId.Location = new System.Drawing.Point(335, 24);
            this.txtStatusId.Name = "txtStatusId";
            this.txtStatusId.Size = new System.Drawing.Size(100, 20);
            this.txtStatusId.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(204, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "NarudzbaId";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(335, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "stautsId";
            // 
            // frmNarudzbePrikaz
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtStatusId);
            this.Controls.Add(this.txtNarudzbaId);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.btnSendMessage);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmNarudzbePrikaz";
            this.Text = "frmNarudzbePrikaz";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmNarudzbePrikaz_LoadAsync);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNarudzbe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvNarudzbe;
        private System.Windows.Forms.DataGridViewTextBoxColumn NarudzbaId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Poslovnica;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dostavljac;
        private System.Windows.Forms.Button btnSendMessage;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox txtNarudzbaId;
        private System.Windows.Forms.TextBox txtStatusId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}