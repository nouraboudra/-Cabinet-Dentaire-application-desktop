namespace Dentaire.Forms
{
    partial class FormOrdonnance
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.date_o = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ords = new System.Windows.Forms.DataGridView();
            this.rehercheOrd = new System.Windows.Forms.Button();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.remarque = new System.Windows.Forms.TextBox();
            this.label00 = new System.Windows.Forms.Label();
            this.codeConsult = new System.Windows.Forms.TextBox();
            this.cin_patient = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.delete_ord = new System.Windows.Forms.Button();
            this.imprimerOrd = new System.Windows.Forms.Button();
            this.add_ord = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.medicament = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.codeOrd = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.add_det = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.supp_det = new System.Windows.Forms.Button();
            this.quantite = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.utilisation = new System.Windows.Forms.TextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.detOrds = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ords)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detOrds)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.date_o);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.ords);
            this.panel1.Controls.Add(this.rehercheOrd);
            this.panel1.Controls.Add(this.panel9);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel10);
            this.panel1.Controls.Add(this.remarque);
            this.panel1.Controls.Add(this.label00);
            this.panel1.Controls.Add(this.codeConsult);
            this.panel1.Controls.Add(this.cin_patient);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label);
            this.panel1.Controls.Add(this.delete_ord);
            this.panel1.Controls.Add(this.imprimerOrd);
            this.panel1.Controls.Add(this.add_ord);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(661, 709);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(181)))), ((int)(((byte)(246)))));
            this.panel3.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panel3.Location = new System.Drawing.Point(342, 243);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(291, 2);
            this.panel3.TabIndex = 51;
            // 
            // date_o
            // 
            this.date_o.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.date_o.Location = new System.Drawing.Point(390, 215);
            this.date_o.Multiline = true;
            this.date_o.Name = "date_o";
            this.date_o.PlaceholderText = "2020-01-01";
            this.date_o.Size = new System.Drawing.Size(238, 27);
            this.date_o.TabIndex = 50;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(342, 215);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 20);
            this.label1.TabIndex = 49;
            this.label1.Text = "Date";
            // 
            // ords
            // 
            this.ords.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ords.BackgroundColor = System.Drawing.Color.White;
            this.ords.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ords.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.ords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ords.DefaultCellStyle = dataGridViewCellStyle8;
            this.ords.Location = new System.Drawing.Point(12, 326);
            this.ords.MultiSelect = false;
            this.ords.Name = "ords";
            this.ords.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ords.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.ords.RowHeadersWidth = 51;
            this.ords.RowTemplate.Height = 29;
            this.ords.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ords.Size = new System.Drawing.Size(634, 360);
            this.ords.StandardTab = true;
            this.ords.TabIndex = 48;
            this.ords.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ords_CellClick);
            // 
            // rehercheOrd
            // 
            this.rehercheOrd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(203)))), ((int)(((byte)(52)))));
            this.rehercheOrd.FlatAppearance.BorderSize = 0;
            this.rehercheOrd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rehercheOrd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rehercheOrd.ForeColor = System.Drawing.Color.White;
            this.rehercheOrd.Location = new System.Drawing.Point(54, 181);
            this.rehercheOrd.Name = "rehercheOrd";
            this.rehercheOrd.Size = new System.Drawing.Size(100, 27);
            this.rehercheOrd.TabIndex = 47;
            this.rehercheOrd.Text = "Rechercher";
            this.rehercheOrd.UseVisualStyleBackColor = false;
            this.rehercheOrd.Click += new System.EventHandler(this.rehercheOrd_Click);
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(181)))), ((int)(((byte)(246)))));
            this.panel9.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panel9.Location = new System.Drawing.Point(345, 58);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(280, 2);
            this.panel9.TabIndex = 43;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(181)))), ((int)(((byte)(246)))));
            this.panel5.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panel5.Location = new System.Drawing.Point(54, 144);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(198, 2);
            this.panel5.TabIndex = 42;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(181)))), ((int)(((byte)(246)))));
            this.panel10.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panel10.Location = new System.Drawing.Point(345, 181);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(288, 2);
            this.panel10.TabIndex = 41;
            // 
            // remarque
            // 
            this.remarque.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.remarque.Location = new System.Drawing.Point(345, 116);
            this.remarque.Multiline = true;
            this.remarque.Name = "remarque";
            this.remarque.PlaceholderText = "Affectation..";
            this.remarque.Size = new System.Drawing.Size(272, 59);
            this.remarque.TabIndex = 40;
            // 
            // label00
            // 
            this.label00.AutoSize = true;
            this.label00.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label00.Location = new System.Drawing.Point(342, 82);
            this.label00.Name = "label00";
            this.label00.Size = new System.Drawing.Size(164, 23);
            this.label00.TabIndex = 39;
            this.label00.Text = "Ajouter Remarques";
            // 
            // codeConsult
            // 
            this.codeConsult.BackColor = System.Drawing.Color.White;
            this.codeConsult.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.codeConsult.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.codeConsult.Location = new System.Drawing.Point(488, 26);
            this.codeConsult.Multiline = true;
            this.codeConsult.Name = "codeConsult";
            this.codeConsult.PlaceholderText = "0";
            this.codeConsult.ReadOnly = true;
            this.codeConsult.Size = new System.Drawing.Size(137, 27);
            this.codeConsult.TabIndex = 38;
            this.codeConsult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cin_patient
            // 
            this.cin_patient.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cin_patient.Location = new System.Drawing.Point(111, 116);
            this.cin_patient.Name = "cin_patient";
            this.cin_patient.PlaceholderText = "XX908897";
            this.cin_patient.Size = new System.Drawing.Size(136, 20);
            this.cin_patient.TabIndex = 37;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(345, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 20);
            this.label7.TabIndex = 36;
            this.label7.Text = "Code Consultation";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label.Location = new System.Drawing.Point(54, 116);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(35, 20);
            this.label.TabIndex = 35;
            this.label.Text = "CIN";
            // 
            // delete_ord
            // 
            this.delete_ord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(181)))), ((int)(((byte)(246)))));
            this.delete_ord.FlatAppearance.BorderSize = 0;
            this.delete_ord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete_ord.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.delete_ord.ForeColor = System.Drawing.Color.White;
            this.delete_ord.Location = new System.Drawing.Point(448, 272);
            this.delete_ord.Name = "delete_ord";
            this.delete_ord.Size = new System.Drawing.Size(100, 27);
            this.delete_ord.TabIndex = 33;
            this.delete_ord.Text = "Supprimer";
            this.delete_ord.UseVisualStyleBackColor = false;
            this.delete_ord.Click += new System.EventHandler(this.delete_ord_Click);
            // 
            // imprimerOrd
            // 
            this.imprimerOrd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(203)))), ((int)(((byte)(52)))));
            this.imprimerOrd.FlatAppearance.BorderSize = 0;
            this.imprimerOrd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.imprimerOrd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.imprimerOrd.ForeColor = System.Drawing.Color.White;
            this.imprimerOrd.Location = new System.Drawing.Point(554, 272);
            this.imprimerOrd.Name = "imprimerOrd";
            this.imprimerOrd.Size = new System.Drawing.Size(100, 27);
            this.imprimerOrd.TabIndex = 34;
            this.imprimerOrd.Text = "imprimer";
            this.imprimerOrd.UseVisualStyleBackColor = false;
            this.imprimerOrd.Click += new System.EventHandler(this.imprimerOrd_Click);
            // 
            // add_ord
            // 
            this.add_ord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(203)))), ((int)(((byte)(52)))));
            this.add_ord.FlatAppearance.BorderSize = 0;
            this.add_ord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_ord.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.add_ord.ForeColor = System.Drawing.Color.White;
            this.add_ord.Location = new System.Drawing.Point(342, 272);
            this.add_ord.Name = "add_ord";
            this.add_ord.Size = new System.Drawing.Size(100, 27);
            this.add_ord.TabIndex = 32;
            this.add_ord.Text = "Ajouter";
            this.add_ord.UseVisualStyleBackColor = false;
            this.add_ord.Click += new System.EventHandler(this.add_ord_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(17, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 20);
            this.label4.TabIndex = 49;
            this.label4.Text = "Médicament";
            // 
            // medicament
            // 
            this.medicament.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.medicament.Location = new System.Drawing.Point(119, 78);
            this.medicament.Name = "medicament";
            this.medicament.PlaceholderText = "text";
            this.medicament.Size = new System.Drawing.Size(151, 20);
            this.medicament.TabIndex = 52;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(17, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 48;
            this.label2.Text = "Code Ordon";
            // 
            // codeOrd
            // 
            this.codeOrd.BackColor = System.Drawing.Color.White;
            this.codeOrd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.codeOrd.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.codeOrd.Location = new System.Drawing.Point(119, 24);
            this.codeOrd.Multiline = true;
            this.codeOrd.Name = "codeOrd";
            this.codeOrd.PlaceholderText = "0";
            this.codeOrd.ReadOnly = true;
            this.codeOrd.Size = new System.Drawing.Size(151, 33);
            this.codeOrd.TabIndex = 51;
            this.codeOrd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(181)))), ((int)(((byte)(246)))));
            this.panel6.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panel6.Location = new System.Drawing.Point(17, 103);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(253, 2);
            this.panel6.TabIndex = 55;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(181)))), ((int)(((byte)(246)))));
            this.panel4.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panel4.Location = new System.Drawing.Point(17, 58);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(253, 2);
            this.panel4.TabIndex = 54;
            // 
            // add_det
            // 
            this.add_det.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(203)))), ((int)(((byte)(52)))));
            this.add_det.FlatAppearance.BorderSize = 0;
            this.add_det.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_det.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.add_det.ForeColor = System.Drawing.Color.White;
            this.add_det.Location = new System.Drawing.Point(17, 243);
            this.add_det.Name = "add_det";
            this.add_det.Size = new System.Drawing.Size(116, 27);
            this.add_det.TabIndex = 50;
            this.add_det.Text = "Ajouter";
            this.add_det.UseVisualStyleBackColor = false;
            this.add_det.Click += new System.EventHandler(this.add_det_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(37, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 20);
            this.label5.TabIndex = 57;
            this.label5.Text = "Quantite";
            // 
            // supp_det
            // 
            this.supp_det.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(181)))), ((int)(((byte)(246)))));
            this.supp_det.FlatAppearance.BorderSize = 0;
            this.supp_det.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.supp_det.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.supp_det.ForeColor = System.Drawing.Color.White;
            this.supp_det.Location = new System.Drawing.Point(139, 243);
            this.supp_det.Name = "supp_det";
            this.supp_det.Size = new System.Drawing.Size(124, 27);
            this.supp_det.TabIndex = 47;
            this.supp_det.Text = "Supprimer";
            this.supp_det.UseVisualStyleBackColor = false;
            this.supp_det.Click += new System.EventHandler(this.supp_det_Click);
            // 
            // quantite
            // 
            this.quantite.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.quantite.Location = new System.Drawing.Point(113, 125);
            this.quantite.Name = "quantite";
            this.quantite.PlaceholderText = "0";
            this.quantite.Size = new System.Drawing.Size(157, 20);
            this.quantite.TabIndex = 59;
            this.quantite.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(306, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 23);
            this.label6.TabIndex = 53;
            this.label6.Text = "Utilisation";
            // 
            // utilisation
            // 
            this.utilisation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.utilisation.Location = new System.Drawing.Point(306, 68);
            this.utilisation.Multiline = true;
            this.utilisation.Name = "utilisation";
            this.utilisation.PlaceholderText = "3 fois..";
            this.utilisation.Size = new System.Drawing.Size(273, 114);
            this.utilisation.TabIndex = 56;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(181)))), ((int)(((byte)(246)))));
            this.panel7.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panel7.Location = new System.Drawing.Point(17, 151);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(253, 2);
            this.panel7.TabIndex = 60;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(181)))), ((int)(((byte)(246)))));
            this.panel8.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panel8.Location = new System.Drawing.Point(306, 191);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(274, 2);
            this.panel8.TabIndex = 58;
            // 
            // detOrds
            // 
            this.detOrds.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.detOrds.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.detOrds.BackgroundColor = System.Drawing.Color.White;
            this.detOrds.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.detOrds.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.detOrds.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.detOrds.DefaultCellStyle = dataGridViewCellStyle11;
            this.detOrds.Location = new System.Drawing.Point(17, 293);
            this.detOrds.Name = "detOrds";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.detOrds.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.detOrds.RowHeadersWidth = 51;
            this.detOrds.RowTemplate.Height = 29;
            this.detOrds.Size = new System.Drawing.Size(561, 393);
            this.detOrds.TabIndex = 61;
            this.detOrds.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SelectDet);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.detOrds);
            this.panel2.Controls.Add(this.panel8);
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Controls.Add(this.utilisation);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.quantite);
            this.panel2.Controls.Add(this.supp_det);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.add_det);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.codeOrd);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.medicament);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(667, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(590, 709);
            this.panel2.TabIndex = 1;
            // 
            // FormOrdonnance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1257, 709);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormOrdonnance";
            this.Text = "FormOrdonnance";
            this.Load += new System.EventHandler(this.FormOrdonnance_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ords)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detOrds)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private DataGridView ords;
        private Button rehercheOrd;
        private Panel panel9;
        private Panel panel5;
        private Panel panel10;
        private TextBox remarque;
        private Label label00;
        private TextBox codeConsult;
        private TextBox cin_patient;
        private Label label7;
        private Label label;
        private Button delete_ord;
        private Button imprimerOrd;
        private Button add_ord;
        private Label label4;
        private TextBox medicament;
        private Label label2;
        private TextBox codeOrd;
        private Panel panel6;
        private Panel panel4;
        private Button add_det;
        private Label label5;
        private Button supp_det;
        private TextBox quantite;
        private Label label6;
        private TextBox utilisation;
        private Panel panel7;
        private Panel panel8;
        private DataGridView detOrds;
        private Panel panel2;
        private Panel panel3;
        private TextBox date_o;
        private Label label1;
    }
}