using ProjOkProjetos.Crud;
using ProjOkProjetos.Model;
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
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProjOkProjetos
{
    public partial class f_inserir_Itm_Serv_Rec : Form
    {
        public int id;
        Form1 form1;
        public f_inserir_Itm_Serv_Rec(Form1 frm, int _id, string nPO)
        {
            form1 = frm;
            InitializeComponent();
            id = _id;
            txt_nPO.Text = nPO;
        }

        private void btn_Inserir_mod_Click(object sender, EventArgs e)
        {
            double valor;
            if (double.TryParse(txt_valor.Text, out valor))
            {
                CRUD_Itn_Serv_Rec.insert_ItnServ_referenciaAServ(txtR_DescItem.Text, valor, id);
                form1.updateTables();
                this.Close();
            }
            else
            {
                MessageBox.Show("Valor do item deve ser escrito em numeros");
            }

        }
    }
}
