using MySql.Data.MySqlClient;
using Newtonsoft.Json.Linq;
using ProjOkProjetos.Crud;
using ProjOkProjetos.Model;
using ProjOkProjetos.View.Receber;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace ProjOkProjetos
{
    public partial class Form1 : Form
    {
        int? _SelectRec;
        int? _SelectServ;
        //int? _SelectItnServRec;

        public Form1()
        {
            InitializeComponent();
            //set value
            _SelectRec  =       null;
            _SelectServ =       null;
            //_SelectItnServRec = null;
            updateTables();
        }
        private void dt_serv_Config(){
            dgv_serv.Columns["id"].Visible = false;
            dgv_serv.Columns["numero_de_PO"].HeaderText = "nº de PO";
            dgv_serv.Columns["nome_operadora"].HeaderText = "Operadora";
            dgv_serv.Columns["descricao_de_PO"].HeaderText = "Descricao";
            dgv_serv.Columns["fase_atual"].HeaderText = "Fase";
            dgv_serv.Columns["data_de_criacao"].HeaderText = "Criação";
            dgv_serv.Columns["ultima_modificacao"].HeaderText = "Ultima Modificação";
        }
        private void dt_rec_Config()
        {
            dgv_rec.Columns["id"].Visible = false;
            dgv_rec.Columns["numero_de_NF"].HeaderText = "nº de NF";
            dgv_rec.Columns["status"].HeaderText = "Pago";
            dgv_rec.Columns["data_de_recebimento"].HeaderText = "Data de Pagamento";
            dgv_rec.Columns["data_de_criacao"].HeaderText = "Criação";
            dgv_rec.Columns["ultima_modificacao"].HeaderText = "Ultima Modificação";
            foreach (DataGridViewRow row in dgv_rec.Rows)
            {
                if ((row.Cells["status"].Value.ToString() == "Pago"))
                {
                    row.DefaultCellStyle.BackColor = Color.LightGreen;
                }
            }
        }
        private void dt_itn_Config()
        {
            dgv_itns.Columns["id"].Visible = false;
            dgv_itns.Columns["id_OrdServ"].Visible = false;
            dgv_itns.Columns["id_OrdRec"].Visible = false;
            dgv_itns.Columns["descricao"].HeaderText = "Descrição";
            dgv_itns.Columns["valor"].HeaderText = "Valor";
            if (!dgv_itns.Columns.Contains("possui_NF"))
            {
                dgv_itns.Columns.Add("possui_NF", "Possui NF");
            }

            foreach (DataGridViewRow row in dgv_itns.Rows) {
                if (!String.IsNullOrEmpty(row.Cells["id_OrdRec"].Value.ToString()))
                {
                    row.DefaultCellStyle.BackColor = Color.LightGreen;
                    row.Cells["possui_NF"].Value = "Sim";
                    //Console.WriteLine("teste"+row.DefaultCellStyle.BackColor.ToString());
                }
                else
                {
                    row.Cells["possui_NF"].Value = "Não";
                }
            }
        }
        public void updateTables()
        {
            //Popula DataTableView de Servicos
            DataTable resultServ;
            if (cb_OrdServ_conluido.Checked)
            {
                resultServ = CRUD_Ord_Ser.read_Ord_Serv_All();
            }
            else
            {
                resultServ = CRUD_Ord_Ser.read_Ord_Serv_emProgresso_List();
            }
            dgv_serv.DataSource = resultServ;
            dt_serv_Config();
            //Popula DataTableView de Recebimento
            DataTable resultRec = CRUD_Ord_Rec.read_Ord_Rec_AllwInnerJoin();
            dgv_rec.DataSource = resultRec;
            dt_rec_Config();
            //Popula DataTableView de Itens
            if (_SelectServ  >= 0) {
                DataTable resultItm = CRUD_Itn_Serv_Rec.select_ItnServ_referenciaAServ(Convert.ToInt32(_SelectServ));
                dgv_itns.DataSource = resultItm;
            }
            else
            {
                DataTable resultItm = CRUD_Itn_Serv_Rec.select_ItnServ_referenciaAServ(0);
                dgv_itns.DataSource = resultItm;
            }

            dt_itn_Config();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_OrdServ_vizualizar_Click(object sender, EventArgs e)
        {
            updateTables();
        }

        private void btn_OrdServ_search_Click(object sender, EventArgs e)
        {
            DataTable result = CRUD_Ord_Ser.read_Ord_Serv_Pesquisa_List(txtB_pesquisa.Text);

            dgv_serv.DataSource = result;
            dt_serv_Config();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void btn_OrdRec_modif_Click(object sender, EventArgs e)
        {
            int Rowid = dgv_rec.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dgv_rec.Rows[Rowid];
            int value = Convert.ToInt32(selectedRow.Cells["id"].Value);

            //Console.WriteLine(Rowid + " " + value);
            f_modificar_status f2 = new f_modificar_status(this, value);
            f2.ShowDialog();
        }

        private void btn_OrdServ_modif_Click(object sender, EventArgs e)
        {
            int Rowid = dgv_serv.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dgv_serv.Rows[Rowid];
            int value = Convert.ToInt32(selectedRow.Cells["id"].Value);

            //Console.WriteLine(Rowid+" "+ value);
            f_modificar_fase f2 = new f_modificar_fase(this,value);
            f2.ShowDialog();
        }

        private void btn_OrdServ_insert_Click(object sender, EventArgs e)
        {
            f_inserir_Ord_Serv f2 = new f_inserir_Ord_Serv(this);
            f2.ShowDialog();
        }

        private void btn_OrdRec_insert_Click(object sender, EventArgs e)
        {
            f_inserir_Ord_Rec f2 = new f_inserir_Ord_Rec(this);
            f2.ShowDialog();
        }

        private void btn_OrdServ_edit_Click(object sender, EventArgs e)
        {
            int Rowid = dgv_serv.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dgv_serv.Rows[Rowid];
            int value = Convert.ToInt32(selectedRow.Cells["id"].Value);

            //Console.WriteLine(Rowid + " " + value);
            f_editar_Serv f2 = new f_editar_Serv(this, value);
            f2.ShowDialog();
        }

        private void btn_OrdRec_edit_Click(object sender, EventArgs e)
        {
            int Rowid = dgv_rec.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dgv_rec.Rows[Rowid];
            int value = Convert.ToInt32(selectedRow.Cells["id"].Value);

            //Console.WriteLine(Rowid + " " + value);
            f_editar_Rec f2 = new f_editar_Rec(this, value);
            f2.ShowDialog();
        }

        private void btn_OrdServ_remover_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Tem certeza que gostaria de remover o serviço selecionado?",
                            "Aviso", MessageBoxButtons.OKCancel);
            switch (dr)
            {
                case DialogResult.OK:
                    int Rowid = dgv_serv.SelectedRows[0].Index;
                    DataGridViewRow selectedRow = dgv_serv.Rows[Rowid];
                    CRUD_Ord_Ser.delete_Ord_Serv(Convert.ToInt32(selectedRow.Cells["id"].Value));
                    updateTables();
                    break;
                case DialogResult.Cancel:
                    break;
            }
        }

        private void btn_ItnServ_Insert_Click(object sender, EventArgs e)
        {
            int Rowid = dgv_serv.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dgv_serv.Rows[Rowid];
            int value = Convert.ToInt32(selectedRow.Cells["id"].Value);
            //Console.WriteLine("Teste id=" + value);

            Ord_Serv servReferencia = new Ord_Serv(value, null, selectedRow.Cells["numero_de_PO"].Value.ToString(), null, null);
            //Console.WriteLine("Teste2 numPo=" + servReferencia.numero_de_PO);

            f_inserir_Itm_Serv_Rec f2 = new f_inserir_Itm_Serv_Rec(this, servReferencia.id, servReferencia.numero_de_PO);
            f2.ShowDialog();
        }

        private void dgv_serv_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int Rowid = dgv_serv.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dgv_serv.Rows[Rowid];
            int value = Convert.ToInt32(selectedRow.Cells["id"].Value);
            _SelectServ = value;
            DataTable resultItm = CRUD_Itn_Serv_Rec.select_ItnServ_referenciaAServ(Convert.ToInt32(_SelectServ));
            dgv_itns.DataSource = resultItm;

            dt_itn_Config();
        }

        private void tabControl1_MouseClick(object sender, MouseEventArgs e)
        {
            dt_rec_Config();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<int> ids = new List<int>();
            List<string> descricao = new List<string>();
            double valorTotal=0; 
            int selectedRowCount = dgv_itns.SelectedRows.Count;
            //debug
            //Console.WriteLine("Teste " + dgv_itns.SelectedRows.Count);
            for (int i = 0 ; i < selectedRowCount ; i++){
                int Rowid = dgv_itns.SelectedRows[i].Index;
                DataGridViewRow selectedRow = dgv_itns.Rows[Rowid];
                ids.Add(Convert.ToInt32(selectedRow.Cells["id"].Value));
                descricao.Add(selectedRow.Cells["descricao"].Value.ToString());
                valorTotal += Convert.ToDouble(selectedRow.Cells["valor"].Value);
                //debug
                //Console.WriteLine("Rowid " + Rowid + " Value "+ value);
            }

            f_gerar_cReceber_1_ou_mais_ID f2 = new f_gerar_cReceber_1_ou_mais_ID(this, ids, descricao, valorTotal);
            f2.ShowDialog();
        }

        private void btn_limpar_nf_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Tem certeza que gostaria de remover as relações do item com a conta a receber? (Lembre-se de deletar a ultima conta a receber, em caso de erro)",
                      "Aviso", MessageBoxButtons.OKCancel);
            switch (dr)
            {
                case DialogResult.OK:
                    int selectedRowCount = dgv_itns.SelectedRows.Count;
                    for (int i = 0; i < selectedRowCount; i++)
                    {
                        int Rowid = dgv_itns.SelectedRows[i].Index;
                        DataGridViewRow selectedRow = dgv_itns.Rows[Rowid];
                        CRUD_Itn_Serv_Rec.update_ItnServ_limparrecId(Convert.ToInt32(selectedRow.Cells["id"].Value));
                    }
                    updateTables();
                    break;
                case DialogResult.Cancel:
                    break;
            }

        }

        private void dgv_itns_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (dgv_itns.RowCount > 0)
            {
                btn_OrdServ_remover.Enabled = false;
                btn_ItnServ_editar.Enabled = true;
                button2.Enabled = true;
                btn_ItnServ_remover.Enabled = true;
                btn_limpar_nf.Enabled = true;
            }
            else
            {
                btn_OrdServ_remover.Enabled = true;
                btn_ItnServ_editar.Enabled = false;
                button2.Enabled = false;
                btn_ItnServ_remover.Enabled = false;
                btn_limpar_nf.Enabled = false;
            }
            if (dgv_serv.RowCount > 0)
            {
                btn_ItnServ_Insert.Enabled = true;
            }
            else
            {
                btn_ItnServ_Insert.Enabled = false;
            }
        }

        private void dgv_serv_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {


        }

        private void button3_Click(object sender, EventArgs e)
        {

            DialogResult dr = MessageBox.Show("Tem certeza que gostaria de remover o Item de Serviço selecionado?",
                            "Aviso", MessageBoxButtons.OKCancel);
            switch (dr)
            {
                case DialogResult.OK:
                    int Rowid = dgv_itns.SelectedRows[0].Index;
                    DataGridViewRow selectedRow = dgv_itns.Rows[Rowid];
                    CRUD_Itn_Serv_Rec.delete_Itn_Serv(Convert.ToInt32(selectedRow.Cells["id"].Value));
                    updateTables();
                    break;
                case DialogResult.Cancel:
                    break;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Tem certeza que gostaria de remover a Conta a Receber selecionada?",
                "Aviso", MessageBoxButtons.OKCancel);
            switch (dr)
            {
                case DialogResult.OK:
                    int Rowid = dgv_rec.SelectedRows[0].Index;
                    DataGridViewRow selectedRow = dgv_rec.Rows[Rowid];
                    CRUD_Ord_Rec.delete_Ord_Rec(Convert.ToInt32(selectedRow.Cells["id"].Value));
                    updateTables();
                    break;
                case DialogResult.Cancel:
                    break;
            }
        }

        private void brn_vItnVincRec_Click(object sender, EventArgs e)
        {
            f_vizualizar_Itens f2 = new f_vizualizar_Itens(this, Convert.ToInt32(_SelectRec));
            f2.ShowDialog();
        }

        private void dgv_rec_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int Rowid = dgv_rec.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dgv_rec.Rows[Rowid];
            int value = Convert.ToInt32(selectedRow.Cells["id"].Value);
            _SelectRec = value;
        }

        private void btn_ItnServ_editar_Click(object sender, EventArgs e)
        {

        }

        private void dgv_rec_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (dgv_rec.RowCount > 0)
            {
                if (dgv_rec.SelectedRows.Count > 0)
                {
                    int Rowid = dgv_rec.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = dgv_rec.Rows[Rowid];
                    int value = Convert.ToInt32(selectedRow.Cells["quantidade_de_itens"].Value);
                    if (value == 0)
                    {
                        btn_ItnServ_Insert.Enabled = true;
                    }   
                }
            }
            else
            {
                btn_ItnServ_Insert.Enabled = false;
            }
        }
    }
}
