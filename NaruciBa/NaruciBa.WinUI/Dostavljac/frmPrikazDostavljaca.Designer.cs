
namespace NaruciBa.WinUI.Dostavljac
{
    partial class frmPrikazDostavljaca
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
            this.btnDodijeli = new System.Windows.Forms.Button();
            this.lblStatusText = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cbDostavljaci = new System.Windows.Forms.ComboBox();
            this.lblImeText = new System.Windows.Forms.Label();
            this.lblIme = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDodijeli
            // 
            this.btnDodijeli.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnDodijeli.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Bold);
            this.btnDodijeli.ForeColor = System.Drawing.Color.White;
            this.btnDodijeli.Location = new System.Drawing.Point(42, 193);
            this.btnDodijeli.Name = "btnDodijeli";
            this.btnDodijeli.Size = new System.Drawing.Size(191, 35);
            this.btnDodijeli.TabIndex = 0;
            this.btnDodijeli.Text = "Dodijeli dostavljaca";
            this.btnDodijeli.UseVisualStyleBackColor = false;
            this.btnDodijeli.Click += new System.EventHandler(this.btnDodaj_ClickAsync);
            // 
            // lblStatusText
            // 
            this.lblStatusText.AutoSize = true;
            this.lblStatusText.Font = new System.Drawing.Font("Montserrat Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatusText.Location = new System.Drawing.Point(47, 128);
            this.lblStatusText.Name = "lblStatusText";
            this.lblStatusText.Size = new System.Drawing.Size(63, 22);
            this.lblStatusText.TabIndex = 1;
            this.lblStatusText.Text = "Status:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblStatus.Location = new System.Drawing.Point(116, 130);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(86, 20);
            this.lblStatus.TabIndex = 2;
            this.lblStatus.Text = "U narudzbi";
            // 
            // cbDostavljaci
            // 
            this.cbDostavljaci.FormattingEnabled = true;
            this.cbDostavljaci.Location = new System.Drawing.Point(42, 31);
            this.cbDostavljaci.Name = "cbDostavljaci";
            this.cbDostavljaci.Size = new System.Drawing.Size(191, 21);
            this.cbDostavljaci.TabIndex = 3;
            this.cbDostavljaci.SelectedIndexChanged += new System.EventHandler(this.cbDostavljaci_SelectedIndexChanged);
            // 
            // lblImeText
            // 
            this.lblImeText.AutoSize = true;
            this.lblImeText.Font = new System.Drawing.Font("Montserrat Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImeText.Location = new System.Drawing.Point(47, 88);
            this.lblImeText.Name = "lblImeText";
            this.lblImeText.Size = new System.Drawing.Size(45, 22);
            this.lblImeText.TabIndex = 4;
            this.lblImeText.Text = "Ime:";
            // 
            // lblIme
            // 
            this.lblIme.AutoSize = true;
            this.lblIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblIme.Location = new System.Drawing.Point(116, 90);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(117, 20);
            this.lblIme.TabIndex = 5;
            this.lblIme.Text = "Mujo Mujanovic";
            // 
            // frmPrikazDostavljaca
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(275, 283);
            this.Controls.Add(this.lblIme);
            this.Controls.Add(this.lblImeText);
            this.Controls.Add(this.cbDostavljaci);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblStatusText);
            this.Controls.Add(this.btnDodijeli);
            this.MaximizeBox = false;
            this.Name = "frmPrikazDostavljaca";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPrikazDostavljaca";
            this.Load += new System.EventHandler(this.frmPrikazDostavljaca_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDodijeli;
        private System.Windows.Forms.Label lblStatusText;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cbDostavljaci;
        private System.Windows.Forms.Label lblImeText;
        private System.Windows.Forms.Label lblIme;
    }
}