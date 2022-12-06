namespace ProjOkProjetos
{
    partial class f_inserir_Ord_Serv
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btn_Salvar_mod = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_descPO = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_operadora = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_nPO = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "Concluido"});
            this.comboBox1.Location = new System.Drawing.Point(255, 72);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(115, 24);
            this.comboBox1.TabIndex = 18;
            // 
            // btn_Salvar_mod
            // 
            this.btn_Salvar_mod.Location = new System.Drawing.Point(376, 72);
            this.btn_Salvar_mod.Name = "btn_Salvar_mod";
            this.btn_Salvar_mod.Size = new System.Drawing.Size(77, 23);
            this.btn_Salvar_mod.TabIndex = 17;
            this.btn_Salvar_mod.Text = "Inserir";
            this.btn_Salvar_mod.UseVisualStyleBackColor = true;
            this.btn_Salvar_mod.Click += new System.EventHandler(this.btn_Salvar_mod_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(252, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 16);
            this.label4.TabIndex = 16;
            this.label4.Text = "Fase";
            // 
            // txt_descPO
            // 
            this.txt_descPO.Location = new System.Drawing.Point(166, 29);
            this.txt_descPO.Name = "txt_descPO";
            this.txt_descPO.Size = new System.Drawing.Size(287, 22);
            this.txt_descPO.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(166, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "Descrição de PO";
            // 
            // txt_operadora
            // 
            this.txt_operadora.Location = new System.Drawing.Point(12, 74);
            this.txt_operadora.Name = "txt_operadora";
            this.txt_operadora.Size = new System.Drawing.Size(234, 22);
            this.txt_operadora.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Operdora";
            // 
            // txt_nPO
            // 
            this.txt_nPO.Location = new System.Drawing.Point(12, 29);
            this.txt_nPO.Name = "txt_nPO";
            this.txt_nPO.Size = new System.Drawing.Size(148, 22);
            this.txt_nPO.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Nº de PO";
            // 
            // f_inserir_Ord_Serv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(462, 105);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btn_Salvar_mod);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_descPO);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_operadora);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_nPO);
            this.Controls.Add(this.label1);
            this.Name = "f_inserir_Ord_Serv";
            this.Text = "Adicionar Ordem de Servico, Registar nova PO";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btn_Salvar_mod;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_descPO;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_operadora;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_nPO;
        private System.Windows.Forms.Label label1;
    }
}