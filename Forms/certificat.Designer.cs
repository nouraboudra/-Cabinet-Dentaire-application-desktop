namespace Dentaire.Forms
{
    partial class certificat
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.certficat_grid = new System.Windows.Forms.DataGridView();
            this.rehercheCertificat = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.date_consult = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cin_patient = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.impression_certificat = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.add_certi = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.codeC = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.certficat_grid)).BeginInit();
            this.SuspendLayout();
            // 
            // certficat_grid
            // 
            this.certficat_grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.certficat_grid.BackgroundColor = System.Drawing.Color.White;
            this.certficat_grid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.certficat_grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.certficat_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.certficat_grid.DefaultCellStyle = dataGridViewCellStyle2;
            this.certficat_grid.Location = new System.Drawing.Point(106, 214);
            this.certficat_grid.MultiSelect = false;
            this.certficat_grid.Name = "certficat_grid";
            this.certficat_grid.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.certficat_grid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.certficat_grid.RowHeadersWidth = 51;
            this.certficat_grid.RowTemplate.Height = 29;
            this.certficat_grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.certficat_grid.Size = new System.Drawing.Size(995, 355);
            this.certficat_grid.StandardTab = true;
            this.certficat_grid.TabIndex = 42;
            this.certficat_grid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.certficat_grid_CellClick);
            // 
            // rehercheCertificat
            // 
            this.rehercheCertificat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(203)))), ((int)(((byte)(52)))));
            this.rehercheCertificat.FlatAppearance.BorderSize = 0;
            this.rehercheCertificat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rehercheCertificat.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rehercheCertificat.ForeColor = System.Drawing.Color.White;
            this.rehercheCertificat.Location = new System.Drawing.Point(441, 125);
            this.rehercheCertificat.Name = "rehercheCertificat";
            this.rehercheCertificat.Size = new System.Drawing.Size(100, 27);
            this.rehercheCertificat.TabIndex = 41;
            this.rehercheCertificat.Text = "Rechercher";
            this.rehercheCertificat.UseVisualStyleBackColor = false;
            this.rehercheCertificat.Click += new System.EventHandler(this.rehercheCertificat_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(181)))), ((int)(((byte)(246)))));
            this.panel3.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panel3.Location = new System.Drawing.Point(507, 88);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(198, 2);
            this.panel3.TabIndex = 40;
            // 
            // date_consult
            // 
            this.date_consult.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.date_consult.Location = new System.Drawing.Point(564, 60);
            this.date_consult.Name = "date_consult";
            this.date_consult.PlaceholderText = "2021-01-01";
            this.date_consult.Size = new System.Drawing.Size(136, 20);
            this.date_consult.TabIndex = 39;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(507, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 20);
            this.label1.TabIndex = 38;
            this.label1.Text = "Date";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(181)))), ((int)(((byte)(246)))));
            this.panel2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panel2.Location = new System.Drawing.Point(305, 88);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(198, 2);
            this.panel2.TabIndex = 37;
            // 
            // cin_patient
            // 
            this.cin_patient.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cin_patient.Location = new System.Drawing.Point(362, 60);
            this.cin_patient.Name = "cin_patient";
            this.cin_patient.PlaceholderText = "XX908897";
            this.cin_patient.Size = new System.Drawing.Size(136, 20);
            this.cin_patient.TabIndex = 36;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label.Location = new System.Drawing.Point(305, 60);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(35, 20);
            this.label.TabIndex = 35;
            this.label.Text = "CIN";
            // 
            // impression_certificat
            // 
            this.impression_certificat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(181)))), ((int)(((byte)(246)))));
            this.impression_certificat.FlatAppearance.BorderSize = 0;
            this.impression_certificat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.impression_certificat.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.impression_certificat.ForeColor = System.Drawing.Color.White;
            this.impression_certificat.Location = new System.Drawing.Point(706, 125);
            this.impression_certificat.Name = "impression_certificat";
            this.impression_certificat.Size = new System.Drawing.Size(100, 27);
            this.impression_certificat.TabIndex = 34;
            this.impression_certificat.Text = "Imprimer";
            this.impression_certificat.UseVisualStyleBackColor = false;
            this.impression_certificat.Click += new System.EventHandler(this.impression_certificat_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(106, 179);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 20);
            this.label8.TabIndex = 43;
            this.label8.Text = "Liste Certficats";
            // 
            // add_certi
            // 
            this.add_certi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(203)))), ((int)(((byte)(52)))));
            this.add_certi.FlatAppearance.BorderSize = 0;
            this.add_certi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_certi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.add_certi.ForeColor = System.Drawing.Color.White;
            this.add_certi.Location = new System.Drawing.Point(568, 125);
            this.add_certi.Name = "add_certi";
            this.add_certi.Size = new System.Drawing.Size(100, 27);
            this.add_certi.TabIndex = 33;
            this.add_certi.Text = "Ajouter";
            this.add_certi.UseVisualStyleBackColor = false;
            this.add_certi.Click += new System.EventHandler(this.add_certi_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(706, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 20);
            this.label2.TabIndex = 38;
            this.label2.Text = "Code Consultation";
            // 
            // codeC
            // 
            this.codeC.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.codeC.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.codeC.Location = new System.Drawing.Point(849, 62);
            this.codeC.Name = "codeC";
            this.codeC.ReadOnly = true;
            this.codeC.Size = new System.Drawing.Size(55, 20);
            this.codeC.TabIndex = 39;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(181)))), ((int)(((byte)(246)))));
            this.panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panel1.Location = new System.Drawing.Point(706, 88);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(198, 2);
            this.panel1.TabIndex = 40;
            // 
            // certificat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1182, 615);
            this.Controls.Add(this.certficat_grid);
            this.Controls.Add(this.rehercheCertificat);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.codeC);
            this.Controls.Add(this.date_consult);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.cin_patient);
            this.Controls.Add(this.label);
            this.Controls.Add(this.impression_certificat);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.add_certi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "certificat";
            this.Text = "certificat";
            this.Load += new System.EventHandler(this.certificat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.certficat_grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView certficat_grid;
        private Button rehercheCertificat;
        private Panel panel3;
        private TextBox date_consult;
        private Label label1;
        private Panel panel2;
        private TextBox cin_patient;
        private Label label;
        private Button impression_certificat;
        private Label label8;
        private Button add_certi;
        private Label label2;
        private TextBox codeC;
        private Panel panel1;
    }
}