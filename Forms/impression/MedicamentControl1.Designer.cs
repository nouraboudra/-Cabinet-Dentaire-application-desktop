namespace Dentaire.Forms.impression
{
    partial class MedicamentControl1
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.Medicament = new MaterialSkin.Controls.MaterialLabel();
            this.Quantite = new MaterialSkin.Controls.MaterialLabel();
            this.utilisation = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // Medicament
            // 
            this.Medicament.AutoSize = true;
            this.Medicament.Depth = 0;
            this.Medicament.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Medicament.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Medicament.Location = new System.Drawing.Point(7, 3);
            this.Medicament.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Medicament.MouseState = MaterialSkin.MouseState.HOVER;
            this.Medicament.Name = "Medicament";
            this.Medicament.Size = new System.Drawing.Size(51, 24);
            this.Medicament.TabIndex = 0;
            this.Medicament.Text = "label";
            // 
            // Quantite
            // 
            this.Quantite.AutoSize = true;
            this.Quantite.Depth = 0;
            this.Quantite.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Quantite.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Quantite.Location = new System.Drawing.Point(473, 3);
            this.Quantite.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Quantite.MouseState = MaterialSkin.MouseState.HOVER;
            this.Quantite.Name = "Quantite";
            this.Quantite.Size = new System.Drawing.Size(21, 24);
            this.Quantite.TabIndex = 0;
            this.Quantite.Text = "0";
            // 
            // utilisation
            // 
            this.utilisation.AutoSize = true;
            this.utilisation.Depth = 0;
            this.utilisation.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.utilisation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.utilisation.Location = new System.Drawing.Point(547, 3);
            this.utilisation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.utilisation.MouseState = MaterialSkin.MouseState.HOVER;
            this.utilisation.Name = "utilisation";
            this.utilisation.Size = new System.Drawing.Size(136, 24);
            this.utilisation.TabIndex = 0;
            this.utilisation.Text = "materialLabel1";
            // 
            // MedicamentControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.utilisation);
            this.Controls.Add(this.Quantite);
            this.Controls.Add(this.Medicament);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 1, 4, 1);
            this.Name = "MedicamentControl1";
            this.Size = new System.Drawing.Size(833, 32);
            this.Load += new System.EventHandler(this.MedicamentControl1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel Medicament;
        private MaterialSkin.Controls.MaterialLabel Quantite;
        private MaterialSkin.Controls.MaterialLabel utilisation;
    }
}
