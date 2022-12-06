namespace ProjOkProjetos.View.Receber
{
    partial class f_vizualizar_Itens
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
            this.btn_limpar_nf = new System.Windows.Forms.Button();
            this.dgv_itns = new System.Windows.Forms.DataGridView();
            this.btn_ItnServ_editar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_itns)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_limpar_nf
            // 
            this.btn_limpar_nf.Location = new System.Drawing.Point(470, 49);
            this.btn_limpar_nf.Margin = new System.Windows.Forms.Padding(4);
            this.btn_limpar_nf.Name = "btn_limpar_nf";
            this.btn_limpar_nf.Size = new System.Drawing.Size(177, 56);
            this.btn_limpar_nf.TabIndex = 43;
            this.btn_limpar_nf.Text = "Remover da Nota Fiscal";
            this.btn_limpar_nf.UseVisualStyleBackColor = true;
            this.btn_limpar_nf.Click += new System.EventHandler(this.btn_limpar_nf_Click);
            // 
            // dgv_itns
            // 
            this.dgv_itns.AllowUserToAddRows = false;
            this.dgv_itns.AllowUserToDeleteRows = false;
            this.dgv_itns.AllowUserToResizeRows = false;
            this.dgv_itns.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_itns.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_itns.Location = new System.Drawing.Point(12, 11);
            this.dgv_itns.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_itns.Name = "dgv_itns";
            this.dgv_itns.ReadOnly = true;
            this.dgv_itns.RowHeadersWidth = 51;
            this.dgv_itns.RowTemplate.Height = 24;
            this.dgv_itns.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_itns.Size = new System.Drawing.Size(451, 292);
            this.dgv_itns.TabIndex = 42;
            this.dgv_itns.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_itns_CellMouseClick);
            // 
            // btn_ItnServ_editar
            // 
            this.btn_ItnServ_editar.Location = new System.Drawing.Point(470, 13);
            this.btn_ItnServ_editar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_ItnServ_editar.Name = "btn_ItnServ_editar";
            this.btn_ItnServ_editar.Size = new System.Drawing.Size(177, 28);
            this.btn_ItnServ_editar.TabIndex = 44;
            this.btn_ItnServ_editar.Text = "Editar Item";
            this.btn_ItnServ_editar.UseVisualStyleBackColor = true;
            this.btn_ItnServ_editar.Click += new System.EventHandler(this.btn_ItnServ_editar_Click);
            // 
            // f_vizualizar_Itens
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(653, 313);
            this.Controls.Add(this.btn_ItnServ_editar);
            this.Controls.Add(this.btn_limpar_nf);
            this.Controls.Add(this.dgv_itns);
            this.Name = "f_vizualizar_Itens";
            this.Text = "Vizualização de itens da NF";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.f_vizualizar_Itens_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_itns)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_limpar_nf;
        private System.Windows.Forms.DataGridView dgv_itns;
        private System.Windows.Forms.Button btn_ItnServ_editar;
    }
}