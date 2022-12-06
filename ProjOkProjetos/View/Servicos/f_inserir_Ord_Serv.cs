using ProjOkProjetos.Crud;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjOkProjetos
{
    public partial class f_inserir_Ord_Serv : Form
    {
        Form1 form1;
        public f_inserir_Ord_Serv(Form1 frm)
        {
            form1 = frm;
            InitializeComponent();
        }

        private void btn_Salvar_mod_Click(object sender, EventArgs e)
        {
            //string numero_de_PO, string descricao_de_PO, string nome_operadora, string fase)
            CRUD_Ord_Ser.insert_Ord_Serv(txt_nPO.Text,txt_descPO.Text,txt_operadora.Text, comboBox1.Text.ToString());
            form1.updateTables();
            this.Close();
        }
    }
}
