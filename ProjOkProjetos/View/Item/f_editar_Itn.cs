using ProjOkProjetos.Crud;
using ProjOkProjetos.View.Receber;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjOkProjetos.View.Item
{
    public partial class f_editar_Itn : Form
    {
        public int id;
        f_vizualizar_Itens form1;
        public f_editar_Itn(f_vizualizar_Itens frm, int _id,string _desc, double _valor)
        {
            form1 = frm;
            InitializeComponent();
            id = _id;
            txtR_DescItem.Text = _desc;
            txt_valor.Text = _valor.ToString();
        }

        private void btn_editar_itn_Click(object sender, EventArgs e)
        {
 
            double valor;
            if (double.TryParse(txt_valor.Text, out valor))
            {
                CRUD_Itn_Serv_Rec.update_ItnServ(id, txtR_DescItem.Text, valor);
                form1.updateTable();
                this.Close();
            }
            else
            {
                MessageBox.Show("Valor do item deve ser escrito em numeros");
            }

        }
    }
}
