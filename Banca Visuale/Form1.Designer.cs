namespace Banca_Visuale
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
            this.components = new System.ComponentModel.Container();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.Conto = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.creaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.movimentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.creaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.contoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.movimentoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.visualizzaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TB_NOME = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.TB_COGNOME = new System.Windows.Forms.TextBox();
            this.TB_SALDO = new System.Windows.Forms.TextBox();
            this.TB_ID = new System.Windows.Forms.TextBox();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.LB_ID = new System.Windows.Forms.TextBox();
            this.LB_NOME = new System.Windows.Forms.TextBox();
            this.LB_COGNOME = new System.Windows.Forms.TextBox();
            this.LB_SALDO = new System.Windows.Forms.TextBox();
            this.Conto.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Location = new System.Drawing.Point(12, 105);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(305, 251);
            this.listBox1.TabIndex = 4;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Conto
            // 
            this.Conto.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.creaToolStripMenuItem,
            this.movimentoToolStripMenuItem});
            this.Conto.Name = "Conto";
            this.Conto.Size = new System.Drawing.Size(68, 48);
            this.Conto.Text = "Conto";
            this.Conto.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // creaToolStripMenuItem
            // 
            this.creaToolStripMenuItem.Name = "creaToolStripMenuItem";
            this.creaToolStripMenuItem.Size = new System.Drawing.Size(67, 22);
            // 
            // movimentoToolStripMenuItem
            // 
            this.movimentoToolStripMenuItem.Name = "movimentoToolStripMenuItem";
            this.movimentoToolStripMenuItem.Size = new System.Drawing.Size(67, 22);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.creaToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked_1);
            // 
            // creaToolStripMenuItem1
            // 
            this.creaToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contoToolStripMenuItem,
            this.movimentoToolStripMenuItem1,
            this.visualizzaToolStripMenuItem});
            this.creaToolStripMenuItem1.Name = "creaToolStripMenuItem1";
            this.creaToolStripMenuItem1.Size = new System.Drawing.Size(52, 20);
            this.creaToolStripMenuItem1.Text = "Conto";
            // 
            // contoToolStripMenuItem
            // 
            this.contoToolStripMenuItem.Name = "contoToolStripMenuItem";
            this.contoToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.contoToolStripMenuItem.Text = "Crea";
            this.contoToolStripMenuItem.Click += new System.EventHandler(this.creaToolStripMenuItem_Click);
            // 
            // movimentoToolStripMenuItem1
            // 
            this.movimentoToolStripMenuItem1.Name = "movimentoToolStripMenuItem1";
            this.movimentoToolStripMenuItem1.Size = new System.Drawing.Size(136, 22);
            this.movimentoToolStripMenuItem1.Text = "Movimento";
            this.movimentoToolStripMenuItem1.Click += new System.EventHandler(this.movimentoToolStripMenuItem1_Click);
            // 
            // visualizzaToolStripMenuItem
            // 
            this.visualizzaToolStripMenuItem.Name = "visualizzaToolStripMenuItem";
            this.visualizzaToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.visualizzaToolStripMenuItem.Text = "Visualizza";
            this.visualizzaToolStripMenuItem.Click += new System.EventHandler(this.visualizzaToolStripMenuItem_Click);
            // 
            // TB_NOME
            // 
            this.TB_NOME.Location = new System.Drawing.Point(323, 207);
            this.TB_NOME.Name = "TB_NOME";
            this.TB_NOME.Size = new System.Drawing.Size(100, 20);
            this.TB_NOME.TabIndex = 5;
            this.TB_NOME.TextChanged += new System.EventHandler(this.TB_NOME_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // TB_COGNOME
            // 
            this.TB_COGNOME.Location = new System.Drawing.Point(323, 274);
            this.TB_COGNOME.Name = "TB_COGNOME";
            this.TB_COGNOME.Size = new System.Drawing.Size(100, 20);
            this.TB_COGNOME.TabIndex = 7;
            this.TB_COGNOME.TextChanged += new System.EventHandler(this.TB_COGNONE_TextChanged);
            // 
            // TB_SALDO
            // 
            this.TB_SALDO.Location = new System.Drawing.Point(323, 335);
            this.TB_SALDO.Name = "TB_SALDO";
            this.TB_SALDO.Size = new System.Drawing.Size(100, 20);
            this.TB_SALDO.TabIndex = 8;
            this.TB_SALDO.TextChanged += new System.EventHandler(this.TB_SALDO_TextChanged);
            // 
            // TB_ID
            // 
            this.TB_ID.Location = new System.Drawing.Point(323, 155);
            this.TB_ID.Name = "TB_ID";
            this.TB_ID.Size = new System.Drawing.Size(100, 20);
            this.TB_ID.TabIndex = 10;
            this.TB_ID.TextChanged += new System.EventHandler(this.TB_ID_TextChanged);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            this.contextMenuStrip2.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip2_Opening);
            // 
            // LB_ID
            // 
            this.LB_ID.BackColor = System.Drawing.SystemColors.Control;
            this.LB_ID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LB_ID.Location = new System.Drawing.Point(323, 129);
            this.LB_ID.Name = "LB_ID";
            this.LB_ID.Size = new System.Drawing.Size(24, 13);
            this.LB_ID.TabIndex = 12;
            this.LB_ID.Text = "ID";
            // 
            // LB_NOME
            // 
            this.LB_NOME.BackColor = System.Drawing.SystemColors.Control;
            this.LB_NOME.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LB_NOME.Location = new System.Drawing.Point(323, 181);
            this.LB_NOME.Name = "LB_NOME";
            this.LB_NOME.Size = new System.Drawing.Size(37, 13);
            this.LB_NOME.TabIndex = 13;
            this.LB_NOME.Text = "Nome";
            // 
            // LB_COGNOME
            // 
            this.LB_COGNOME.BackColor = System.Drawing.SystemColors.Control;
            this.LB_COGNOME.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LB_COGNOME.Location = new System.Drawing.Point(323, 255);
            this.LB_COGNOME.Name = "LB_COGNOME";
            this.LB_COGNOME.Size = new System.Drawing.Size(49, 13);
            this.LB_COGNOME.TabIndex = 14;
            this.LB_COGNOME.Text = "Cognome";
            // 
            // LB_SALDO
            // 
            this.LB_SALDO.BackColor = System.Drawing.SystemColors.Control;
            this.LB_SALDO.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LB_SALDO.Location = new System.Drawing.Point(323, 316);
            this.LB_SALDO.Name = "LB_SALDO";
            this.LB_SALDO.Size = new System.Drawing.Size(37, 13);
            this.LB_SALDO.TabIndex = 15;
            this.LB_SALDO.Text = "Saldo";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LB_SALDO);
            this.Controls.Add(this.LB_COGNOME);
            this.Controls.Add(this.LB_NOME);
            this.Controls.Add(this.LB_ID);
            this.Controls.Add(this.TB_ID);
            this.Controls.Add(this.TB_SALDO);
            this.Controls.Add(this.TB_COGNOME);
            this.Controls.Add(this.TB_NOME);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Banca";
            this.Conto.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ContextMenuStrip Conto;
        private System.Windows.Forms.ToolStripMenuItem creaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem movimentoToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem creaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem contoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem movimentoToolStripMenuItem1;
        private System.Windows.Forms.TextBox TB_NOME;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox TB_COGNOME;
        private System.Windows.Forms.TextBox TB_SALDO;
        private System.Windows.Forms.TextBox TB_ID;
        private System.Windows.Forms.ToolStripMenuItem visualizzaToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.TextBox LB_ID;
        private System.Windows.Forms.TextBox LB_NOME;
        private System.Windows.Forms.TextBox LB_COGNOME;
        private System.Windows.Forms.TextBox LB_SALDO;
    }
}

