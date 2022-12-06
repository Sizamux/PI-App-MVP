namespace ProjOkProjetos.View.Receber
{
    partial class f_gerar_cReceber_1_ou_mais_ID
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
            this.list_Itns = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btn_Salvar_mod = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_nNF = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtb_valorTotal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // list_Itns
            // 
            this.list_Itns.Enabled = false;
            this.list_Itns.FormattingEnabled = true;
            this.list_Itns.ItemHeight = 16;
            this.list_Itns.Location = new System.Drawing.Point(15, 28);
            this.list_Itns.Name = "list_Itns";
            this.list_Itns.Size = new System.Drawing.Size(177, 148);
            this.list_Itns.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Itens que serão adicionados";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(198, 73);
            this.dateTimePicker1.MaxDate = new System.DateTime(3000, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(237, 22);
            this.dateTimePicker1.TabIndex = 35;
            // 
            // comboBox1
            // 
            this.comboBox1.DisplayMember = "Não Pago";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Não Pago",
            "Pago"});
            this.comboBox1.Location = new System.Drawing.Point(441, 71);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(115, 24);
            this.comboBox1.TabIndex = 34;
            // 
            // btn_Salvar_mod
            // 
            this.btn_Salvar_mod.Location = new System.Drawing.Point(562, 71);
            this.btn_Salvar_mod.Name = "btn_Salvar_mod";
            this.btn_Salvar_mod.Size = new System.Drawing.Size(77, 23);
            this.btn_Salvar_mod.TabIndex = 33;
            this.btn_Salvar_mod.Text = "Inserir";
            this.btn_Salvar_mod.UseVisualStyleBackColor = true;
            this.btn_Salvar_mod.Click += new System.EventHandler(this.btn_Salvar_mod_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(438, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 32;
            this.label4.Text = "Status";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(198, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 16);
            this.label2.TabIndex = 31;
            this.label2.Text = "Data de Pagamento";
            // 
            // txt_nNF
            // 
            this.txt_nNF.Location = new System.Drawing.Point(198, 28);
            this.txt_nNF.Name = "txt_nNF";
            this.txt_nNF.Size = new System.Drawing.Size(441, 22);
            this.txt_nNF.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(198, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 16);
            this.label3.TabIndex = 29;
            this.label3.Text = "Nº de Nota Fiscal";
            // 
            // txtb_valorTotal
            // 
            this.txtb_valorTotal.Enabled = false;
            this.txtb_valorTotal.Location = new System.Drawing.Point(201, 152);
            this.txtb_valorTotal.Name = "txtb_valorTotal";
            this.txtb_valorTotal.Size = new System.Drawing.Size(125, 22);
            this.txtb_valorTotal.TabIndex = 36;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(198, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 16);
            this.label5.TabIndex = 37;
            this.label5.Text = "Valor Total";
            // 
            // f_gerar_cReceber_1_ou_mais_ID
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(647, 186);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtb_valorTotal);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btn_Salvar_mod);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_nNF);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.list_Itns);
            this.Name = "f_gerar_cReceber_1_ou_mais_ID";
            this.Text = "Gerar NF - contas a receber";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox list_Itns;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btn_Salvar_mod;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_nNF;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtb_valorTotal;
        private System.Windows.Forms.Label label5;
    }
}