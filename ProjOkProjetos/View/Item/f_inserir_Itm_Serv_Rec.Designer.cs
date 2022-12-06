namespace ProjOkProjetos
{
    partial class f_inserir_Itm_Serv_Rec
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_nPO = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_valor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtR_DescItem = new System.Windows.Forms.RichTextBox();
            this.btn_Inserir_mod = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero de PO";
            // 
            // txt_nPO
            // 
            this.txt_nPO.Enabled = false;
            this.txt_nPO.Location = new System.Drawing.Point(13, 33);
            this.txt_nPO.Name = "txt_nPO";
            this.txt_nPO.Size = new System.Drawing.Size(244, 22);
            this.txt_nPO.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Descrição do Item";
            // 
            // txt_valor
            // 
            this.txt_valor.Location = new System.Drawing.Point(376, 77);
            this.txt_valor.Name = "txt_valor";
            this.txt_valor.Size = new System.Drawing.Size(131, 22);
            this.txt_valor.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(373, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Valor";
            // 
            // txtR_DescItem
            // 
            this.txtR_DescItem.Location = new System.Drawing.Point(13, 77);
            this.txtR_DescItem.Name = "txtR_DescItem";
            this.txtR_DescItem.Size = new System.Drawing.Size(357, 63);
            this.txtR_DescItem.TabIndex = 6;
            this.txtR_DescItem.Text = "";
            // 
            // btn_Inserir_mod
            // 
            this.btn_Inserir_mod.Location = new System.Drawing.Point(427, 117);
            this.btn_Inserir_mod.Name = "btn_Inserir_mod";
            this.btn_Inserir_mod.Size = new System.Drawing.Size(77, 23);
            this.btn_Inserir_mod.TabIndex = 27;
            this.btn_Inserir_mod.Text = "Inserir";
            this.btn_Inserir_mod.UseVisualStyleBackColor = true;
            this.btn_Inserir_mod.Click += new System.EventHandler(this.btn_Inserir_mod_Click);
            // 
            // f_inserir_Itm_Serv_Rec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(516, 148);
            this.Controls.Add(this.btn_Inserir_mod);
            this.Controls.Add(this.txtR_DescItem);
            this.Controls.Add(this.txt_valor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_nPO);
            this.Controls.Add(this.label1);
            this.Name = "f_inserir_Itm_Serv_Rec";
            this.Text = "Inserir novo item";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_nPO;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_valor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox txtR_DescItem;
        private System.Windows.Forms.Button btn_Inserir_mod;
    }
}