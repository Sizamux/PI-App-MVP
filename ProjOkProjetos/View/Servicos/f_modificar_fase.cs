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
    public partial class f_modificar_fase : Form 
    {
        public int id;
        Form1 form1;

        public f_modificar_fase(Form1 frm,int _id)
        {
            form1 = frm;
            InitializeComponent();
            id = _id;
            DataTable result = CRUD_Ord_Ser.read_Ord_Serv_One(id);
            txt_nPO.Text = result.Rows[0]["numero_de_PO"].ToString();
            txt_descPO.Text = result.Rows[0]["descricao_de_PO"].ToString();
            txt_operadora.Text = result.Rows[0]["nome_operadora"].ToString();
            comboBox1.SelectedIndex = comboBox1.FindStringExact(result.Rows[0]["fase_atual"].ToString());
        }

        private void btn_Salvar_mod_Click(object sender, EventArgs e)
        {
            //Debug
            //Console.WriteLine(id +" "+comboBox1.Text.ToString());
            CRUD_Ord_Ser.update_Ord_Serv_modfase(id, comboBox1.Text.ToString(), txt_nPO.Text, txt_operadora.Text, txt_descPO.Text);
            form1.updateTables();
            this.Close();
        }
    }
}
