namespace Dentaire.Forms.Calendrier
{
    partial class UserJours
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
            this.components = new System.ComponentModel.Container();
            this.jrslabel = new System.Windows.Forms.Label();
            this.rv_number = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // jrslabel
            // 
            this.jrslabel.AutoSize = true;
            this.jrslabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.jrslabel.Location = new System.Drawing.Point(67, 0);
            this.jrslabel.Name = "jrslabel";
            this.jrslabel.Size = new System.Drawing.Size(27, 20);
            this.jrslabel.TabIndex = 0;
            this.jrslabel.Text = "00";
            // 
            // rv_number
            // 
            this.rv_number.AutoSize = true;
            this.rv_number.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rv_number.Location = new System.Drawing.Point(19, 42);
            this.rv_number.Name = "rv_number";
            this.rv_number.Size = new System.Drawing.Size(66, 20);
            this.rv_number.TabIndex = 1;
            this.rv_number.Text = "Patients";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // UserJours
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.rv_number);
            this.Controls.Add(this.jrslabel);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "UserJours";
            this.Size = new System.Drawing.Size(100, 80);
            this.Load += new System.EventHandler(this.UserJours_Load);
            this.Click += new System.EventHandler(this.ClikOnDy);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label jrslabel;
        private Label rv_number;
        private System.Windows.Forms.Timer timer1;
    }
}
