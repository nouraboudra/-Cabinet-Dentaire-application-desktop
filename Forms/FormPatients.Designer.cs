namespace Dentaire.Forms
{
    partial class FormPatients
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
            this.search = new System.Windows.Forms.Button();
            this.value = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.edit = new System.Windows.Forms.Button();
            this.col = new System.Windows.Forms.ComboBox();
            this.dataPatients = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataPatients)).BeginInit();
            this.SuspendLayout();
            // 
            // search
            // 
            this.search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(181)))), ((int)(((byte)(246)))));
            this.search.FlatAppearance.BorderSize = 0;
            this.search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.search.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.search.Location = new System.Drawing.Point(263, 45);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(122, 29);
            this.search.TabIndex = 0;
            this.search.Text = "Chercher";
            this.search.UseVisualStyleBackColor = false;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // value
            // 
            this.value.Location = new System.Drawing.Point(32, 45);
            this.value.Name = "value";
            this.value.PlaceholderText = "Chercher un patient";
            this.value.Size = new System.Drawing.Size(149, 27);
            this.value.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(203)))), ((int)(((byte)(52)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(978, 43);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 29);
            this.button2.TabIndex = 4;
            this.button2.Text = "Ajouter";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // edit
            // 
            this.edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(203)))), ((int)(((byte)(52)))));
            this.edit.FlatAppearance.BorderSize = 0;
            this.edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.edit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.edit.Location = new System.Drawing.Point(1106, 43);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(122, 29);
            this.edit.TabIndex = 6;
            this.edit.Text = "Editer";
            this.edit.UseVisualStyleBackColor = false;
            this.edit.Click += new System.EventHandler(this.edit_Click);
            // 
            // col
            // 
            this.col.FormattingEnabled = true;
            this.col.Items.AddRange(new object[] {
            "nom",
            "cin"});
            this.col.Location = new System.Drawing.Point(187, 45);
            this.col.Name = "col";
            this.col.Size = new System.Drawing.Size(59, 28);
            this.col.TabIndex = 9;
            this.col.Text = "par";
            // 
            // dataPatients
            // 
            this.dataPatients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataPatients.BackgroundColor = System.Drawing.Color.White;
            this.dataPatients.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataPatients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataPatients.Location = new System.Drawing.Point(30, 98);
            this.dataPatients.MultiSelect = false;
            this.dataPatients.Name = "dataPatients";
            this.dataPatients.ReadOnly = true;
            this.dataPatients.RowHeadersWidth = 51;
            this.dataPatients.RowTemplate.Height = 29;
            this.dataPatients.Size = new System.Drawing.Size(1198, 572);
            this.dataPatients.TabIndex = 10;
            this.dataPatients.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataPatients_CellClick);
            // 
            // FormPatients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1257, 709);
            this.Controls.Add(this.dataPatients);
            this.Controls.Add(this.col);
            this.Controls.Add(this.edit);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.value);
            this.Controls.Add(this.search);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPatients";
            this.Text = "FormPatients";
            this.Load += new System.EventHandler(this.FormPatients_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataPatients)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button search;
        private TextBox value;
        private Button button2;
        private Button edit;
        private ComboBox col;
        public DataGridView dataPatients;
    }
}