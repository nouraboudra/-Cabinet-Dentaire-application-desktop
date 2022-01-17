namespace Dentaire.Forms
{
    partial class consultations
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.consults_grid = new System.Windows.Forms.DataGridView();
            this.rehercheOrd = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.date_consult = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cin_patient = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.delete_Consult = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.add_ord = new System.Windows.Forms.Button();
            this.intervs_grid = new System.Windows.Forms.DataGridView();
            this.supp_inter = new System.Windows.Forms.Button();
            this.add_det = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.codeConsult = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dent = new System.Windows.Forms.TextBox();
            this.radioButton17 = new System.Windows.Forms.RadioButton();
            this.radioButton32 = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.inter = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.consults_grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.intervs_grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // consults_grid
            // 
            this.consults_grid.AllowUserToAddRows = false;
            this.consults_grid.AllowUserToDeleteRows = false;
            this.consults_grid.AllowUserToResizeColumns = false;
            this.consults_grid.AllowUserToResizeRows = false;
            this.consults_grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.consults_grid.BackgroundColor = System.Drawing.Color.White;
            this.consults_grid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.consults_grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.consults_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.consults_grid.DefaultCellStyle = dataGridViewCellStyle2;
            this.consults_grid.GridColor = System.Drawing.SystemColors.Control;
            this.consults_grid.Location = new System.Drawing.Point(42, 270);
            this.consults_grid.MultiSelect = false;
            this.consults_grid.Name = "consults_grid";
            this.consults_grid.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.consults_grid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.consults_grid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.consults_grid.RowTemplate.Height = 29;
            this.consults_grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.consults_grid.Size = new System.Drawing.Size(509, 322);
            this.consults_grid.StandardTab = true;
            this.consults_grid.TabIndex = 31;
            this.consults_grid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.consults_grid_CellClick);
            // 
            // rehercheOrd
            // 
            this.rehercheOrd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(203)))), ((int)(((byte)(52)))));
            this.rehercheOrd.FlatAppearance.BorderSize = 0;
            this.rehercheOrd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rehercheOrd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rehercheOrd.ForeColor = System.Drawing.Color.White;
            this.rehercheOrd.Location = new System.Drawing.Point(61, 201);
            this.rehercheOrd.Name = "rehercheOrd";
            this.rehercheOrd.Size = new System.Drawing.Size(100, 27);
            this.rehercheOrd.TabIndex = 30;
            this.rehercheOrd.Text = "Rechercher";
            this.rehercheOrd.UseVisualStyleBackColor = false;
            this.rehercheOrd.Click += new System.EventHandler(this.rehercheOrd_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(181)))), ((int)(((byte)(246)))));
            this.panel3.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panel3.Location = new System.Drawing.Point(197, 164);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(198, 2);
            this.panel3.TabIndex = 29;
            // 
            // date_consult
            // 
            this.date_consult.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.date_consult.Location = new System.Drawing.Point(254, 136);
            this.date_consult.Name = "date_consult";
            this.date_consult.PlaceholderText = "2021-01-01";
            this.date_consult.Size = new System.Drawing.Size(136, 20);
            this.date_consult.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(197, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 20);
            this.label1.TabIndex = 27;
            this.label1.Text = "Date";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(181)))), ((int)(((byte)(246)))));
            this.panel2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panel2.Location = new System.Drawing.Point(197, 95);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(198, 2);
            this.panel2.TabIndex = 25;
            // 
            // cin_patient
            // 
            this.cin_patient.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cin_patient.Location = new System.Drawing.Point(254, 67);
            this.cin_patient.Name = "cin_patient";
            this.cin_patient.PlaceholderText = "XX908897";
            this.cin_patient.Size = new System.Drawing.Size(136, 20);
            this.cin_patient.TabIndex = 20;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label.Location = new System.Drawing.Point(197, 67);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(35, 20);
            this.label.TabIndex = 18;
            this.label.Text = "CIN";
            // 
            // delete_Consult
            // 
            this.delete_Consult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(181)))), ((int)(((byte)(246)))));
            this.delete_Consult.FlatAppearance.BorderSize = 0;
            this.delete_Consult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete_Consult.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.delete_Consult.ForeColor = System.Drawing.Color.White;
            this.delete_Consult.Location = new System.Drawing.Point(361, 201);
            this.delete_Consult.Name = "delete_Consult";
            this.delete_Consult.Size = new System.Drawing.Size(100, 27);
            this.delete_Consult.TabIndex = 17;
            this.delete_Consult.Text = "Supprimer";
            this.delete_Consult.UseVisualStyleBackColor = false;
            this.delete_Consult.Click += new System.EventHandler(this.delete_Consult_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(42, 247);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(142, 20);
            this.label8.TabIndex = 32;
            this.label8.Text = "Liste Consultations";
            // 
            // add_ord
            // 
            this.add_ord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(203)))), ((int)(((byte)(52)))));
            this.add_ord.FlatAppearance.BorderSize = 0;
            this.add_ord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_ord.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.add_ord.ForeColor = System.Drawing.Color.White;
            this.add_ord.Location = new System.Drawing.Point(207, 201);
            this.add_ord.Name = "add_ord";
            this.add_ord.Size = new System.Drawing.Size(100, 27);
            this.add_ord.TabIndex = 16;
            this.add_ord.Text = "Ajouter";
            this.add_ord.UseVisualStyleBackColor = false;
            this.add_ord.Click += new System.EventHandler(this.add_ord_Click);
            // 
            // intervs_grid
            // 
            this.intervs_grid.AllowUserToAddRows = false;
            this.intervs_grid.AllowUserToDeleteRows = false;
            this.intervs_grid.AllowUserToResizeRows = false;
            this.intervs_grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.intervs_grid.BackgroundColor = System.Drawing.Color.White;
            this.intervs_grid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.intervs_grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.intervs_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.intervs_grid.DefaultCellStyle = dataGridViewCellStyle5;
            this.intervs_grid.Location = new System.Drawing.Point(564, 440);
            this.intervs_grid.Name = "intervs_grid";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.intervs_grid.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.intervs_grid.RowHeadersWidth = 51;
            this.intervs_grid.RowTemplate.Height = 29;
            this.intervs_grid.Size = new System.Drawing.Size(658, 216);
            this.intervs_grid.TabIndex = 48;
            this.intervs_grid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.intervs_grid_CellClick);
            // 
            // supp_inter
            // 
            this.supp_inter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(181)))), ((int)(((byte)(246)))));
            this.supp_inter.FlatAppearance.BorderSize = 0;
            this.supp_inter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.supp_inter.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.supp_inter.ForeColor = System.Drawing.Color.White;
            this.supp_inter.Location = new System.Drawing.Point(849, 377);
            this.supp_inter.Name = "supp_inter";
            this.supp_inter.Size = new System.Drawing.Size(124, 27);
            this.supp_inter.TabIndex = 33;
            this.supp_inter.Text = "Supprimer";
            this.supp_inter.UseVisualStyleBackColor = false;
            this.supp_inter.Click += new System.EventHandler(this.supp_inter_Click);
            // 
            // add_det
            // 
            this.add_det.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(203)))), ((int)(((byte)(52)))));
            this.add_det.FlatAppearance.BorderSize = 0;
            this.add_det.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_det.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.add_det.ForeColor = System.Drawing.Color.White;
            this.add_det.Location = new System.Drawing.Point(727, 377);
            this.add_det.Name = "add_det";
            this.add_det.Size = new System.Drawing.Size(116, 27);
            this.add_det.TabIndex = 37;
            this.add_det.Text = "Ajouter";
            this.add_det.UseVisualStyleBackColor = false;
            this.add_det.Click += new System.EventHandler(this.add_det_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(181)))), ((int)(((byte)(246)))));
            this.panel4.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panel4.Location = new System.Drawing.Point(565, 118);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(193, 2);
            this.panel4.TabIndex = 41;
            // 
            // codeConsult
            // 
            this.codeConsult.BackColor = System.Drawing.Color.White;
            this.codeConsult.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.codeConsult.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.codeConsult.Location = new System.Drawing.Point(716, 90);
            this.codeConsult.Name = "codeConsult";
            this.codeConsult.PlaceholderText = "0";
            this.codeConsult.ReadOnly = true;
            this.codeConsult.Size = new System.Drawing.Size(42, 25);
            this.codeConsult.TabIndex = 38;
            this.codeConsult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(564, 417);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 20);
            this.label3.TabIndex = 35;
            this.label3.Text = "Liste Interventions";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(564, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 20);
            this.label2.TabIndex = 49;
            this.label2.Text = "Code Consultation";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(618, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 20);
            this.label4.TabIndex = 52;
            this.label4.Text = "Dent";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(181)))), ((int)(((byte)(246)))));
            this.panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panel1.Location = new System.Drawing.Point(565, 175);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(193, 2);
            this.panel1.TabIndex = 51;
            // 
            // dent
            // 
            this.dent.BackColor = System.Drawing.Color.White;
            this.dent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dent.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dent.Location = new System.Drawing.Point(716, 147);
            this.dent.Name = "dent";
            this.dent.PlaceholderText = "0";
            this.dent.Size = new System.Drawing.Size(42, 25);
            this.dent.TabIndex = 50;
            this.dent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // radioButton17
            // 
            this.radioButton17.AutoSize = true;
            this.radioButton17.Location = new System.Drawing.Point(1109, -26);
            this.radioButton17.Name = "radioButton17";
            this.radioButton17.Size = new System.Drawing.Size(17, 16);
            this.radioButton17.TabIndex = 55;
            this.radioButton17.TabStop = true;
            this.radioButton17.UseVisualStyleBackColor = true;
            // 
            // radioButton32
            // 
            this.radioButton32.AutoSize = true;
            this.radioButton32.Location = new System.Drawing.Point(833, -22);
            this.radioButton32.Name = "radioButton32";
            this.radioButton32.Size = new System.Drawing.Size(17, 16);
            this.radioButton32.TabIndex = 70;
            this.radioButton32.TabStop = true;
            this.radioButton32.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Dentaire.Properties.Resources.dents2;
            this.pictureBox1.Location = new System.Drawing.Point(802, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(383, 364);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 53;
            this.pictureBox1.TabStop = false;
            // 
            // inter
            // 
            this.inter.BackColor = System.Drawing.Color.White;
            this.inter.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inter.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.inter.Location = new System.Drawing.Point(564, 243);
            this.inter.Multiline = true;
            this.inter.Name = "inter";
            this.inter.PlaceholderText = "Netoyyage";
            this.inter.Size = new System.Drawing.Size(196, 83);
            this.inter.TabIndex = 50;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(181)))), ((int)(((byte)(246)))));
            this.panel5.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panel5.Location = new System.Drawing.Point(565, 327);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(193, 2);
            this.panel5.TabIndex = 51;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(565, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 20);
            this.label5.TabIndex = 52;
            this.label5.Text = "Intervention";
            // 
            // consultations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1257, 709);
            this.Controls.Add(this.radioButton17);
            this.Controls.Add(this.radioButton32);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.inter);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dent);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.intervs_grid);
            this.Controls.Add(this.supp_inter);
            this.Controls.Add(this.add_det);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.codeConsult);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.consults_grid);
            this.Controls.Add(this.rehercheOrd);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.date_consult);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.cin_patient);
            this.Controls.Add(this.label);
            this.Controls.Add(this.delete_Consult);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.add_ord);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "consultations";
            this.Text = "consultations";
            this.Load += new System.EventHandler(this.consultations_Load);
            ((System.ComponentModel.ISupportInitialize)(this.consults_grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.intervs_grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView consults_grid;
        private Button rehercheOrd;
        private Panel panel3;
        private TextBox date_consult;
        private Label label1;
        private Panel panel2;
        private TextBox cin_patient;
        private Label label;
        private Button delete_Consult;
        private Label label8;
        private Button add_ord;
        private DataGridView intervs_grid;
        private Button supp_inter;
        private Button add_det;
        private Panel panel4;
        private TextBox codeConsult;
        private Label label3;
        private Label label2;
        private Label label4;
        private Panel panel1;
        private TextBox dent;
        private RadioButton radioButton17;
        private RadioButton radioButton32;
        private PictureBox pictureBox1;
        private TextBox inter;
        private Panel panel5;
        private Label label5;
    }
}