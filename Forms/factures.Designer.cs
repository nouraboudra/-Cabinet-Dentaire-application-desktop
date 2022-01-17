namespace Dentaire.Forms
{
    partial class factures
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
            this.facture_grid = new System.Windows.Forms.DataGridView();
            this.rehercheFacture = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.codeC = new System.Windows.Forms.TextBox();
            this.date_consult = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cin_patient = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.impression_facture = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.add_facture = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.prixF = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.facture_grid)).BeginInit();
            this.SuspendLayout();
            // 
            // facture_grid
            // 
            this.facture_grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.facture_grid.BackgroundColor = System.Drawing.Color.White;
            this.facture_grid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.facture_grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.facture_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.facture_grid.DefaultCellStyle = dataGridViewCellStyle2;
            this.facture_grid.Location = new System.Drawing.Point(90, 245);
            this.facture_grid.MultiSelect = false;
            this.facture_grid.Name = "facture_grid";
            this.facture_grid.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.facture_grid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.facture_grid.RowHeadersWidth = 51;
            this.facture_grid.RowTemplate.Height = 29;
            this.facture_grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.facture_grid.Size = new System.Drawing.Size(1020, 286);
            this.facture_grid.StandardTab = true;
            this.facture_grid.TabIndex = 56;
            this.facture_grid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.facture_grid_CellClick);
            // 
            // rehercheFacture
            // 
            this.rehercheFacture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(203)))), ((int)(((byte)(52)))));
            this.rehercheFacture.FlatAppearance.BorderSize = 0;
            this.rehercheFacture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rehercheFacture.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rehercheFacture.ForeColor = System.Drawing.Color.White;
            this.rehercheFacture.Location = new System.Drawing.Point(441, 180);
            this.rehercheFacture.Name = "rehercheFacture";
            this.rehercheFacture.Size = new System.Drawing.Size(100, 27);
            this.rehercheFacture.TabIndex = 55;
            this.rehercheFacture.Text = "Rechercher";
            this.rehercheFacture.UseVisualStyleBackColor = false;
            this.rehercheFacture.Click += new System.EventHandler(this.rehercheFacture_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(181)))), ((int)(((byte)(246)))));
            this.panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panel1.Location = new System.Drawing.Point(651, 76);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(198, 2);
            this.panel1.TabIndex = 53;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(181)))), ((int)(((byte)(246)))));
            this.panel3.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panel3.Location = new System.Drawing.Point(372, 127);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(198, 2);
            this.panel3.TabIndex = 54;
            // 
            // codeC
            // 
            this.codeC.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.codeC.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.codeC.Location = new System.Drawing.Point(794, 50);
            this.codeC.Name = "codeC";
            this.codeC.Size = new System.Drawing.Size(55, 20);
            this.codeC.TabIndex = 51;
            // 
            // date_consult
            // 
            this.date_consult.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.date_consult.Location = new System.Drawing.Point(429, 99);
            this.date_consult.Name = "date_consult";
            this.date_consult.PlaceholderText = "2021-01-01";
            this.date_consult.Size = new System.Drawing.Size(136, 20);
            this.date_consult.TabIndex = 52;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(651, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 20);
            this.label2.TabIndex = 49;
            this.label2.Text = "Code Consultation";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(372, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 20);
            this.label1.TabIndex = 50;
            this.label1.Text = "Date";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(181)))), ((int)(((byte)(246)))));
            this.panel2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panel2.Location = new System.Drawing.Point(372, 68);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(198, 2);
            this.panel2.TabIndex = 48;
            // 
            // cin_patient
            // 
            this.cin_patient.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cin_patient.Location = new System.Drawing.Point(429, 40);
            this.cin_patient.Name = "cin_patient";
            this.cin_patient.PlaceholderText = "XX908897";
            this.cin_patient.Size = new System.Drawing.Size(136, 20);
            this.cin_patient.TabIndex = 47;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label.Location = new System.Drawing.Point(372, 40);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(35, 20);
            this.label.TabIndex = 46;
            this.label.Text = "CIN";
            // 
            // impression_facture
            // 
            this.impression_facture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(181)))), ((int)(((byte)(246)))));
            this.impression_facture.FlatAppearance.BorderSize = 0;
            this.impression_facture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.impression_facture.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.impression_facture.ForeColor = System.Drawing.Color.White;
            this.impression_facture.Location = new System.Drawing.Point(700, 180);
            this.impression_facture.Name = "impression_facture";
            this.impression_facture.Size = new System.Drawing.Size(100, 27);
            this.impression_facture.TabIndex = 45;
            this.impression_facture.Text = "Imprimer";
            this.impression_facture.UseVisualStyleBackColor = false;
            this.impression_facture.Click += new System.EventHandler(this.impression_facture_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(90, 222);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(135, 20);
            this.label8.TabIndex = 57;
            this.label8.Text = "Liste Des Factures";
            // 
            // add_facture
            // 
            this.add_facture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(203)))), ((int)(((byte)(52)))));
            this.add_facture.FlatAppearance.BorderSize = 0;
            this.add_facture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_facture.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.add_facture.ForeColor = System.Drawing.Color.White;
            this.add_facture.Location = new System.Drawing.Point(571, 180);
            this.add_facture.Name = "add_facture";
            this.add_facture.Size = new System.Drawing.Size(100, 27);
            this.add_facture.TabIndex = 44;
            this.add_facture.Text = "Ajouter";
            this.add_facture.UseVisualStyleBackColor = false;
            this.add_facture.Click += new System.EventHandler(this.add_facture_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(651, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 20);
            this.label3.TabIndex = 46;
            this.label3.Text = "prix";
            // 
            // prixF
            // 
            this.prixF.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.prixF.Location = new System.Drawing.Point(708, 99);
            this.prixF.Name = "prixF";
            this.prixF.PlaceholderText = "300,00";
            this.prixF.Size = new System.Drawing.Size(136, 20);
            this.prixF.TabIndex = 47;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(181)))), ((int)(((byte)(246)))));
            this.panel4.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panel4.Location = new System.Drawing.Point(651, 127);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(198, 2);
            this.panel4.TabIndex = 48;
            // 
            // factures
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1182, 615);
            this.Controls.Add(this.facture_grid);
            this.Controls.Add(this.rehercheFacture);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.codeC);
            this.Controls.Add(this.date_consult);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.prixF);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cin_patient);
            this.Controls.Add(this.label);
            this.Controls.Add(this.impression_facture);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.add_facture);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "factures";
            this.Text = "facture";
            this.Load += new System.EventHandler(this.facture_Load);
            ((System.ComponentModel.ISupportInitialize)(this.facture_grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView facture_grid;
        private Button rehercheFacture;
        private Panel panel1;
        private Panel panel3;
        private TextBox codeC;
        private TextBox date_consult;
        private Label label2;
        private Label label1;
        private Panel panel2;
        private TextBox cin_patient;
        private Label label;
        private Button impression_facture;
        private Label label8;
        private Button add_facture;
        private Label label3;
        private TextBox prixF;
        private Panel panel4;
    }
}