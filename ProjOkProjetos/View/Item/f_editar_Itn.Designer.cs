namespace ProjOkProjetos.View.Item
{
    partial class f_editar_Itn
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
            this.btn_editar_itn = new System.Windows.Forms.Button();
            this.txtR_DescItem = new System.Windows.Forms.RichTextBox();
            this.txt_valor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_editar_itn
            // 
            this.btn_editar_itn.Location = new System.Drawing.Point(426, 68);
            this.btn_editar_itn.Name = "btn_editar_itn";
            this.btn_editar_itn.Size = new System.Drawing.Size(77, 23);
            this.btn_editar_itn.TabIndex = 34;
            this.btn_editar_itn.Text = "Editar";
            this.btn_editar_itn.UseVisualStyleBackColor = true;
            this.btn_editar_itn.Click += new System.EventHandler(this.btn_editar_itn_Click);
            // 
            // txtR_DescItem
            // 
            this.txtR_DescItem.Location = new System.Drawing.Point(12, 28);
            this.txtR_DescItem.Name = "txtR_DescItem";
            this.txtR_DescItem.Size = new System.Drawing.Size(357, 63);
            this.txtR_DescItem.TabIndex = 33;
            this.txtR_DescItem.Text = "";
            // 
            // txt_valor
            // 
            this.txt_valor.Location = new System.Drawing.Point(375, 28);
            this.txt_valor.Name = "txt_valor";
            this.txt_valor.Size = new System.Drawing.Size(131, 22);
            this.txt_valor.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(372, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 16);
            this.label3.TabIndex = 31;
            this.label3.Text = "Valor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 16);
            this.label2.TabIndex = 30;
            this.label2.Text = "Descrição do Item";
            // 
            // f_editar_Itn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(518, 107);
            this.Controls.Add(this.btn_editar_itn);
            this.Controls.Add(this.txtR_DescItem);
            this.Controls.Add(this.txt_valor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "f_editar_Itn";
            this.Text = "Editar Item";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_editar_itn;
        private System.Windows.Forms.RichTextBox txtR_DescItem;
        private System.Windows.Forms.TextBox txt_valor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}