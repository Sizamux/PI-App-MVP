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

namespace ProjOkProjetos.View.Receber
{
    public partial class f_gerar_cReceber_1_ou_mais_ID : Form
    {
        Form1 form1;
        List<int> _ids;
        List<string> _descricao;
        double _valortotal;
        public f_gerar_cReceber_1_ou_mais_ID(Form1 frm, List<int> ids,List<String> descricao, double valortotal)
        {
            form1 = frm;
            _ids = ids;
            _descricao = descricao;
            _valortotal= valortotal;
            InitializeComponent();
            foreach (string itn in _descricao)
            {
                list_Itns.Items.Add(itn);
            }
            txtb_valorTotal.Text = _valortotal.ToString();
        }

        private void btn_Salvar_mod_Click(object sender, EventArgs e)
        {
            int Recid = CRUD_Ord_Rec.insert_Ord_Rec_wScopeReturn(txt_nNF.Text, comboBox1.Text.ToString(), dateTimePicker1.Value.ToShortDateString());
            Console.WriteLine(Recid+ "test");
            foreach (int itn in _ids) {
                CRUD_Itn_Serv_Rec.update_ItnServ_recId(itn, Recid);
            }
            form1.updateTables();
            this.Close();
        }
    }
}
