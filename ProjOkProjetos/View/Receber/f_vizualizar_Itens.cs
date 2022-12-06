using ProjOkProjetos.Crud;
using ProjOkProjetos.View.Item;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjOkProjetos.View.Receber
{

    public partial class f_vizualizar_Itens : Form
    {
        public int id;
        Form1 form1;
        int? _selectedItn;
        public f_vizualizar_Itens(Form1 frm, int _id)
        {
            form1 = frm;
            id = _id;
            InitializeComponent();
            updateTable();
        }
        public void updateTable() {
            DataTable resultItm = CRUD_Itn_Serv_Rec.select_ItnServ_referenciaARec(Convert.ToInt32(id));
            dgv_itns.DataSource = resultItm;
            dgv_itns.Columns["id"].Visible = false;
            dgv_itns.Columns["id_OrdServ"].Visible = false;
            dgv_itns.Columns["id_OrdRec"].Visible = false;
            dgv_itns.Columns["descricao"].HeaderText = "Descrição";
            dgv_itns.Columns["valor"].HeaderText = "Valor";
        }

        private void dgv_itns_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int Rowid = dgv_itns.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dgv_itns.Rows[Rowid];
            int value = Convert.ToInt32(selectedRow.Cells["id"].Value);
            _selectedItn = value;
        }

        private void btn_ItnServ_editar_Click(object sender, EventArgs e)
        {
            int Rowid = dgv_itns.SelectedRows[0].Index;
            DataGridViewRow selectedRow = dgv_itns.Rows[Rowid];
            f_editar_Itn f2 = new f_editar_Itn(this, Convert.ToInt32( _selectedItn), selectedRow.Cells["descricao"].Value.ToString(), Convert.ToDouble(selectedRow.Cells["valor"].Value));
            f2.ShowDialog();

            updateTable();
        }

        private void btn_limpar_nf_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Tem certeza que gostaria de remover as relações do item com a conta a receber? (Lembre-se de deletar a ultima conta a receber, em caso de erro)",
                "Aviso", MessageBoxButtons.OKCancel);
            switch (dr)
            {
                case DialogResult.OK:
                    CRUD_Itn_Serv_Rec.update_ItnServ_limparrecId(Convert.ToInt32(_selectedItn));
                    updateTable();
                    break;
                case DialogResult.Cancel:
                    break;
            }
        }

        private void f_vizualizar_Itens_FormClosed(object sender, FormClosedEventArgs e)
        {
            form1.updateTables();
        }
    }
}
