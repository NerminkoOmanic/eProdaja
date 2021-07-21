
namespace eProdaja.WinUI
{
    partial class frmCovidPasos
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
            this.cmbKupac = new System.Windows.Forms.ComboBox();
            this.dtpPocetak = new System.Windows.Forms.DateTimePicker();
            this.dtpKraj = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvCovidPasosi = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.Kupac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumPocetak = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kraj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCovidPasosi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbKupac
            // 
            this.cmbKupac.FormattingEnabled = true;
            this.cmbKupac.Location = new System.Drawing.Point(128, 27);
            this.cmbKupac.Name = "cmbKupac";
            this.cmbKupac.Size = new System.Drawing.Size(200, 21);
            this.cmbKupac.TabIndex = 0;
            this.cmbKupac.Validating += new System.ComponentModel.CancelEventHandler(this.cmbKupac_Validating);
            // 
            // dtpPocetak
            // 
            this.dtpPocetak.Location = new System.Drawing.Point(128, 66);
            this.dtpPocetak.Name = "dtpPocetak";
            this.dtpPocetak.Size = new System.Drawing.Size(200, 20);
            this.dtpPocetak.TabIndex = 1;
            // 
            // dtpKraj
            // 
            this.dtpKraj.Location = new System.Drawing.Point(128, 108);
            this.dtpKraj.Name = "dtpKraj";
            this.dtpKraj.Size = new System.Drawing.Size(200, 20);
            this.dtpKraj.TabIndex = 2;
            this.dtpKraj.Validating += new System.ComponentModel.CancelEventHandler(this.dtpKraj_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Izaberite kupca : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Pocetak :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(84, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Kraj :";
            // 
            // dgvCovidPasosi
            // 
            this.dgvCovidPasosi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCovidPasosi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCovidPasosi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Kupac,
            this.DatumPocetak,
            this.Kraj});
            this.dgvCovidPasosi.Location = new System.Drawing.Point(29, 187);
            this.dgvCovidPasosi.Name = "dgvCovidPasosi";
            this.dgvCovidPasosi.Size = new System.Drawing.Size(387, 242);
            this.dgvCovidPasosi.TabIndex = 6;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(159, 147);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(169, 23);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Dodaj novi Covid Pasos";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Kupac
            // 
            this.Kupac.DataPropertyName = "ImePrezime";
            this.Kupac.HeaderText = "Ime i prezime";
            this.Kupac.Name = "Kupac";
            // 
            // DatumPocetak
            // 
            this.DatumPocetak.DataPropertyName = "DatumPocetak";
            this.DatumPocetak.HeaderText = "Pocetak";
            this.DatumPocetak.Name = "DatumPocetak";
            // 
            // Kraj
            // 
            this.Kraj.DataPropertyName = "DatumKraj";
            this.Kraj.HeaderText = "Kraj";
            this.Kraj.Name = "Kraj";
            // 
            // frmCovidPasos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 450);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvCovidPasosi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpKraj);
            this.Controls.Add(this.dtpPocetak);
            this.Controls.Add(this.cmbKupac);
            this.Name = "frmCovidPasos";
            this.Text = "frmCovidPasos";
            this.Load += new System.EventHandler(this.frmCovidPasos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCovidPasosi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbKupac;
        private System.Windows.Forms.DateTimePicker dtpPocetak;
        private System.Windows.Forms.DateTimePicker dtpKraj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvCovidPasosi;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kupac;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumPocetak;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kraj;
    }
}