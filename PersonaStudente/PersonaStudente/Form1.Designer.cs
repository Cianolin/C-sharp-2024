namespace PersonaStudente
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.LB_nome = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.opziniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.creaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visualizzaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LB_cognome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.LB_cognomeStudente = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.LB_nomeStudente = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.LT_matricolaStudente = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LB_nome
            // 
            this.LB_nome.Location = new System.Drawing.Point(12, 269);
            this.LB_nome.Name = "LB_nome";
            this.LB_nome.Size = new System.Drawing.Size(100, 20);
            this.LB_nome.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opziniToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            // 
            // opziniToolStripMenuItem
            // 
            this.opziniToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.creaToolStripMenuItem,
            this.visualizzaToolStripMenuItem});
            this.opziniToolStripMenuItem.Name = "opziniToolStripMenuItem";
            this.opziniToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.opziniToolStripMenuItem.Text = "Opzini";
            // 
            // creaToolStripMenuItem
            // 
            this.creaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personaToolStripMenuItem,
            this.studenteToolStripMenuItem});
            this.creaToolStripMenuItem.Name = "creaToolStripMenuItem";
            this.creaToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.creaToolStripMenuItem.Text = "Crea";
            // 
            // personaToolStripMenuItem
            // 
            this.personaToolStripMenuItem.Name = "personaToolStripMenuItem";
            this.personaToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.personaToolStripMenuItem.Text = "Persona";
            // 
            // studenteToolStripMenuItem
            // 
            this.studenteToolStripMenuItem.Name = "studenteToolStripMenuItem";
            this.studenteToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.studenteToolStripMenuItem.Text = "Studente";
            // 
            // visualizzaToolStripMenuItem
            // 
            this.visualizzaToolStripMenuItem.Name = "visualizzaToolStripMenuItem";
            this.visualizzaToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.visualizzaToolStripMenuItem.Text = "Visualizza";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 253);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 292);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cognome";
            // 
            // LB_cognome
            // 
            this.LB_cognome.Location = new System.Drawing.Point(12, 308);
            this.LB_cognome.Name = "LB_cognome";
            this.LB_cognome.Size = new System.Drawing.Size(100, 20);
            this.LB_cognome.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(163, 292);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Cognome";
            // 
            // LB_cognomeStudente
            // 
            this.LB_cognomeStudente.Location = new System.Drawing.Point(163, 308);
            this.LB_cognomeStudente.Name = "LB_cognomeStudente";
            this.LB_cognomeStudente.Size = new System.Drawing.Size(100, 20);
            this.LB_cognomeStudente.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(163, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Nome";
            // 
            // LB_nomeStudente
            // 
            this.LB_nomeStudente.Location = new System.Drawing.Point(163, 269);
            this.LB_nomeStudente.Name = "LB_nomeStudente";
            this.LB_nomeStudente.Size = new System.Drawing.Size(100, 20);
            this.LB_nomeStudente.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(160, 331);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Matricola";
            // 
            // LT_matricolaStudente
            // 
            this.LT_matricolaStudente.Location = new System.Drawing.Point(160, 347);
            this.LT_matricolaStudente.Name = "LT_matricolaStudente";
            this.LT_matricolaStudente.Size = new System.Drawing.Size(100, 20);
            this.LT_matricolaStudente.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.LT_matricolaStudente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LB_cognomeStudente);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LB_nomeStudente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LB_cognome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LB_nome);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox LB_nome;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem opziniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem creaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visualizzaToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox LB_cognome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox LB_cognomeStudente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox LB_nomeStudente;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox LT_matricolaStudente;
    }
}

