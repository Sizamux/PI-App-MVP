namespace ProjOkProjetos
{
    partial class Form1
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
            this.label2 = new System.Windows.Forms.Label();
            this.btn_OrdServ_modif = new System.Windows.Forms.Button();
            this.cb_OrdServ_conluido = new System.Windows.Forms.CheckBox();
            this.btn_OrdServ_edit = new System.Windows.Forms.Button();
            this.btn_OrdServ_insert = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_ItnServ_Insert = new System.Windows.Forms.Button();
            this.btn_OrdRec_modif = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_OrdRec_edit = new System.Windows.Forms.Button();
            this.txtB_pesquisa = new System.Windows.Forms.TextBox();
            this.btn_OrdServ_search = new System.Windows.Forms.Button();
            this.btn_OrdServ_vizualizar = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.btn_ItnServ_editar = new System.Windows.Forms.Button();
            this.dgv_rec = new System.Windows.Forms.DataGridView();
            this.dgv_itns = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btn_limpar_nf = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.btn_OrdServ_remover = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dgv_serv = new System.Windows.Forms.DataGridView();
            this.btn_ItnServ_remover = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.brn_vItnVincRec = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_rec)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_itns)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_serv)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Contas a Receber";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 7);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Serviços em Progresso";
            // 
            // btn_OrdServ_modif
            // 
            this.btn_OrdServ_modif.Location = new System.Drawing.Point(1024, 47);
            this.btn_OrdServ_modif.Margin = new System.Windows.Forms.Padding(4);
            this.btn_OrdServ_modif.Name = "btn_OrdServ_modif";
            this.btn_OrdServ_modif.Size = new System.Drawing.Size(176, 28);
            this.btn_OrdServ_modif.TabIndex = 4;
            this.btn_OrdServ_modif.Text = "Modificar Fase";
            this.btn_OrdServ_modif.UseVisualStyleBackColor = true;
            this.btn_OrdServ_modif.Click += new System.EventHandler(this.btn_OrdServ_modif_Click);
            // 
            // cb_OrdServ_conluido
            // 
            this.cb_OrdServ_conluido.AutoSize = true;
            this.cb_OrdServ_conluido.Location = new System.Drawing.Point(166, 7);
            this.cb_OrdServ_conluido.Margin = new System.Windows.Forms.Padding(4);
            this.cb_OrdServ_conluido.Name = "cb_OrdServ_conluido";
            this.cb_OrdServ_conluido.Size = new System.Drawing.Size(96, 20);
            this.cb_OrdServ_conluido.TabIndex = 8;
            this.cb_OrdServ_conluido.Text = "Concluidos";
            this.cb_OrdServ_conluido.UseVisualStyleBackColor = true;
            // 
            // btn_OrdServ_edit
            // 
            this.btn_OrdServ_edit.Location = new System.Drawing.Point(1024, 83);
            this.btn_OrdServ_edit.Margin = new System.Windows.Forms.Padding(4);
            this.btn_OrdServ_edit.Name = "btn_OrdServ_edit";
            this.btn_OrdServ_edit.Size = new System.Drawing.Size(176, 28);
            this.btn_OrdServ_edit.TabIndex = 9;
            this.btn_OrdServ_edit.Text = "Editar Serviço";
            this.btn_OrdServ_edit.UseVisualStyleBackColor = true;
            this.btn_OrdServ_edit.Click += new System.EventHandler(this.btn_OrdServ_edit_Click);
            // 
            // btn_OrdServ_insert
            // 
            this.btn_OrdServ_insert.Location = new System.Drawing.Point(1024, 119);
            this.btn_OrdServ_insert.Margin = new System.Windows.Forms.Padding(4);
            this.btn_OrdServ_insert.Name = "btn_OrdServ_insert";
            this.btn_OrdServ_insert.Size = new System.Drawing.Size(176, 28);
            this.btn_OrdServ_insert.TabIndex = 10;
            this.btn_OrdServ_insert.Text = "Inserir Serviço";
            this.btn_OrdServ_insert.UseVisualStyleBackColor = true;
            this.btn_OrdServ_insert.Click += new System.EventHandler(this.btn_OrdServ_insert_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 378);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Itens";
            // 
            // btn_ItnServ_Insert
            // 
            this.btn_ItnServ_Insert.Location = new System.Drawing.Point(1024, 173);
            this.btn_ItnServ_Insert.Margin = new System.Windows.Forms.Padding(4);
            this.btn_ItnServ_Insert.Name = "btn_ItnServ_Insert";
            this.btn_ItnServ_Insert.Size = new System.Drawing.Size(177, 56);
            this.btn_ItnServ_Insert.TabIndex = 14;
            this.btn_ItnServ_Insert.Text = "Adicionar Item ao Serviço";
            this.btn_ItnServ_Insert.UseVisualStyleBackColor = true;
            this.btn_ItnServ_Insert.Click += new System.EventHandler(this.btn_ItnServ_Insert_Click);
            // 
            // btn_OrdRec_modif
            // 
            this.btn_OrdRec_modif.Location = new System.Drawing.Point(1023, 50);
            this.btn_OrdRec_modif.Margin = new System.Windows.Forms.Padding(4);
            this.btn_OrdRec_modif.Name = "btn_OrdRec_modif";
            this.btn_OrdRec_modif.Size = new System.Drawing.Size(177, 28);
            this.btn_OrdRec_modif.TabIndex = 13;
            this.btn_OrdRec_modif.Text = "Modificar Status";
            this.btn_OrdRec_modif.UseVisualStyleBackColor = true;
            this.btn_OrdRec_modif.Click += new System.EventHandler(this.btn_OrdRec_modif_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1020, 30);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 16);
            this.label5.TabIndex = 16;
            this.label5.Text = "Quick";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1021, 27);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 16);
            this.label6.TabIndex = 17;
            this.label6.Text = "Quick";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1024, 153);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 16);
            this.label7.TabIndex = 18;
            this.label7.Text = "Serviço Selecionado";
            // 
            // btn_OrdRec_edit
            // 
            this.btn_OrdRec_edit.Location = new System.Drawing.Point(1023, 86);
            this.btn_OrdRec_edit.Margin = new System.Windows.Forms.Padding(4);
            this.btn_OrdRec_edit.Name = "btn_OrdRec_edit";
            this.btn_OrdRec_edit.Size = new System.Drawing.Size(177, 28);
            this.btn_OrdRec_edit.TabIndex = 19;
            this.btn_OrdRec_edit.Text = "Editar Contas a Receber";
            this.btn_OrdRec_edit.UseVisualStyleBackColor = true;
            this.btn_OrdRec_edit.Click += new System.EventHandler(this.btn_OrdRec_edit_Click);
            // 
            // txtB_pesquisa
            // 
            this.txtB_pesquisa.Location = new System.Drawing.Point(386, 4);
            this.txtB_pesquisa.Margin = new System.Windows.Forms.Padding(4);
            this.txtB_pesquisa.Name = "txtB_pesquisa";
            this.txtB_pesquisa.Size = new System.Drawing.Size(261, 22);
            this.txtB_pesquisa.TabIndex = 24;
            // 
            // btn_OrdServ_search
            // 
            this.btn_OrdServ_search.Location = new System.Drawing.Point(656, 2);
            this.btn_OrdServ_search.Margin = new System.Windows.Forms.Padding(4);
            this.btn_OrdServ_search.Name = "btn_OrdServ_search";
            this.btn_OrdServ_search.Size = new System.Drawing.Size(100, 28);
            this.btn_OrdServ_search.TabIndex = 25;
            this.btn_OrdServ_search.Text = "Pesquisar";
            this.btn_OrdServ_search.UseVisualStyleBackColor = true;
            this.btn_OrdServ_search.Click += new System.EventHandler(this.btn_OrdServ_search_Click);
            // 
            // btn_OrdServ_vizualizar
            // 
            this.btn_OrdServ_vizualizar.Location = new System.Drawing.Point(278, 1);
            this.btn_OrdServ_vizualizar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_OrdServ_vizualizar.Name = "btn_OrdServ_vizualizar";
            this.btn_OrdServ_vizualizar.Size = new System.Drawing.Size(100, 28);
            this.btn_OrdServ_vizualizar.TabIndex = 26;
            this.btn_OrdServ_vizualizar.Text = "Vizualizar";
            this.btn_OrdServ_vizualizar.UseVisualStyleBackColor = true;
            this.btn_OrdServ_vizualizar.Click += new System.EventHandler(this.btn_OrdServ_vizualizar_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1021, 417);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 16);
            this.label11.TabIndex = 30;
            this.label11.Text = "Quick";
            // 
            // btn_ItnServ_editar
            // 
            this.btn_ItnServ_editar.Location = new System.Drawing.Point(1024, 437);
            this.btn_ItnServ_editar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_ItnServ_editar.Name = "btn_ItnServ_editar";
            this.btn_ItnServ_editar.Size = new System.Drawing.Size(177, 28);
            this.btn_ItnServ_editar.TabIndex = 32;
            this.btn_ItnServ_editar.Text = "Editar Item";
            this.btn_ItnServ_editar.UseVisualStyleBackColor = true;
            this.btn_ItnServ_editar.Click += new System.EventHandler(this.btn_ItnServ_editar_Click);
            // 
            // dgv_rec
            // 
            this.dgv_rec.AllowUserToAddRows = false;
            this.dgv_rec.AllowUserToDeleteRows = false;
            this.dgv_rec.AllowUserToResizeRows = false;
            this.dgv_rec.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_rec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_rec.Location = new System.Drawing.Point(6, 32);
            this.dgv_rec.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_rec.Name = "dgv_rec";
            this.dgv_rec.ReadOnly = true;
            this.dgv_rec.RowHeadersWidth = 51;
            this.dgv_rec.RowTemplate.Height = 24;
            this.dgv_rec.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_rec.Size = new System.Drawing.Size(1009, 553);
            this.dgv_rec.TabIndex = 33;
            this.dgv_rec.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_rec_CellMouseClick);
            this.dgv_rec.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgv_rec_DataBindingComplete);
            // 
            // dgv_itns
            // 
            this.dgv_itns.AllowUserToAddRows = false;
            this.dgv_itns.AllowUserToDeleteRows = false;
            this.dgv_itns.AllowUserToResizeRows = false;
            this.dgv_itns.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_itns.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_itns.Location = new System.Drawing.Point(6, 348);
            this.dgv_itns.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_itns.Name = "dgv_itns";
            this.dgv_itns.ReadOnly = true;
            this.dgv_itns.RowHeadersWidth = 51;
            this.dgv_itns.RowTemplate.Height = 24;
            this.dgv_itns.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_itns.Size = new System.Drawing.Size(1011, 218);
            this.dgv_itns.TabIndex = 34;
            this.dgv_itns.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgv_itns_DataBindingComplete);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1242, 621);
            this.tabControl1.TabIndex = 35;
            this.tabControl1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tabControl1_MouseClick);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btn_limpar_nf);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.btn_OrdServ_remover);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.dgv_serv);
            this.tabPage1.Controls.Add(this.btn_ItnServ_remover);
            this.tabPage1.Controls.Add(this.cb_OrdServ_conluido);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.btn_ItnServ_Insert);
            this.tabPage1.Controls.Add(this.dgv_itns);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.btn_ItnServ_editar);
            this.tabPage1.Controls.Add(this.btn_OrdServ_vizualizar);
            this.tabPage1.Controls.Add(this.txtB_pesquisa);
            this.tabPage1.Controls.Add(this.btn_OrdServ_search);
            this.tabPage1.Controls.Add(this.btn_OrdServ_modif);
            this.tabPage1.Controls.Add(this.btn_OrdServ_edit);
            this.tabPage1.Controls.Add(this.btn_OrdServ_insert);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1234, 592);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Serviços";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btn_limpar_nf
            // 
            this.btn_limpar_nf.Location = new System.Drawing.Point(1024, 502);
            this.btn_limpar_nf.Margin = new System.Windows.Forms.Padding(4);
            this.btn_limpar_nf.Name = "btn_limpar_nf";
            this.btn_limpar_nf.Size = new System.Drawing.Size(177, 28);
            this.btn_limpar_nf.TabIndex = 41;
            this.btn_limpar_nf.Text = "Limpar relação NF ";
            this.btn_limpar_nf.UseVisualStyleBackColor = true;
            this.btn_limpar_nf.Click += new System.EventHandler(this.btn_limpar_nf_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1025, 482);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 16);
            this.label10.TabIndex = 40;
            this.label10.Text = "Avançado";
            // 
            // btn_OrdServ_remover
            // 
            this.btn_OrdServ_remover.Location = new System.Drawing.Point(1024, 237);
            this.btn_OrdServ_remover.Margin = new System.Windows.Forms.Padding(4);
            this.btn_OrdServ_remover.Name = "btn_OrdServ_remover";
            this.btn_OrdServ_remover.Size = new System.Drawing.Size(176, 28);
            this.btn_OrdServ_remover.TabIndex = 36;
            this.btn_OrdServ_remover.Text = "Remover Serviço";
            this.btn_OrdServ_remover.UseVisualStyleBackColor = true;
            this.btn_OrdServ_remover.Click += new System.EventHandler(this.btn_OrdServ_remover_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1022, 348);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 16);
            this.label3.TabIndex = 38;
            this.label3.Text = "Selecione 1 ou + itens";
            // 
            // dgv_serv
            // 
            this.dgv_serv.AllowUserToAddRows = false;
            this.dgv_serv.AllowUserToDeleteRows = false;
            this.dgv_serv.AllowUserToResizeRows = false;
            this.dgv_serv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_serv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_serv.Location = new System.Drawing.Point(6, 32);
            this.dgv_serv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_serv.Name = "dgv_serv";
            this.dgv_serv.ReadOnly = true;
            this.dgv_serv.RowHeadersWidth = 51;
            this.dgv_serv.RowTemplate.Height = 24;
            this.dgv_serv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_serv.Size = new System.Drawing.Size(1011, 309);
            this.dgv_serv.TabIndex = 0;
            this.dgv_serv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dgv_serv.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_serv_CellMouseClick);
            this.dgv_serv.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgv_serv_DataBindingComplete);
            // 
            // btn_ItnServ_remover
            // 
            this.btn_ItnServ_remover.Location = new System.Drawing.Point(1025, 538);
            this.btn_ItnServ_remover.Margin = new System.Windows.Forms.Padding(4);
            this.btn_ItnServ_remover.Name = "btn_ItnServ_remover";
            this.btn_ItnServ_remover.Size = new System.Drawing.Size(176, 28);
            this.btn_ItnServ_remover.TabIndex = 39;
            this.btn_ItnServ_remover.Text = "Remover Item";
            this.btn_ItnServ_remover.UseVisualStyleBackColor = true;
            this.btn_ItnServ_remover.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1022, 368);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(177, 28);
            this.button2.TabIndex = 37;
            this.button2.Text = "Gerar Conta a Receber";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.brn_vItnVincRec);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.dgv_rec);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.btn_OrdRec_modif);
            this.tabPage2.Controls.Add(this.btn_OrdRec_edit);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1234, 592);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Contas a Receber";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1022, 161);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 16);
            this.label9.TabIndex = 38;
            // 
            // brn_vItnVincRec
            // 
            this.brn_vItnVincRec.Location = new System.Drawing.Point(1023, 307);
            this.brn_vItnVincRec.Margin = new System.Windows.Forms.Padding(4);
            this.brn_vItnVincRec.Name = "brn_vItnVincRec";
            this.brn_vItnVincRec.Size = new System.Drawing.Size(177, 58);
            this.brn_vItnVincRec.TabIndex = 37;
            this.brn_vItnVincRec.Text = "Ver Itens vinculados";
            this.brn_vItnVincRec.UseVisualStyleBackColor = true;
            this.brn_vItnVincRec.Click += new System.EventHandler(this.brn_vItnVincRec_Click);
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(1022, 557);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(177, 28);
            this.button1.TabIndex = 35;
            this.button1.Text = "Remover Cnt a Receber";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1021, 537);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 16);
            this.label8.TabIndex = 34;
            this.label8.Text = "Avançado";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1264, 625);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label4);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Ok_Projetos Finançeiro=Serviços";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_rec)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_itns)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_serv)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_OrdServ_modif;
        private System.Windows.Forms.CheckBox cb_OrdServ_conluido;
        private System.Windows.Forms.Button btn_OrdServ_edit;
        private System.Windows.Forms.Button btn_OrdServ_insert;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_ItnServ_Insert;
        private System.Windows.Forms.Button btn_OrdRec_modif;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_OrdRec_edit;
        private System.Windows.Forms.TextBox txtB_pesquisa;
        private System.Windows.Forms.Button btn_OrdServ_search;
        private System.Windows.Forms.Button btn_OrdServ_vizualizar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btn_ItnServ_editar;
        private System.Windows.Forms.DataGridView dgv_rec;
        private System.Windows.Forms.DataGridView dgv_itns;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgv_serv;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_OrdServ_remover;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btn_ItnServ_remover;
        private System.Windows.Forms.Button btn_limpar_nf;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button brn_vItnVincRec;
    }
}

