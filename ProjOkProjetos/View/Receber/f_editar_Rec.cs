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
    public partial class f_editar_Rec : Form
    {
        public int id;
        Form1 form1;
        public f_editar_Rec(Form1 frm, int _id)
        {
            form1 = frm;
            InitializeComponent();
            id = _id;
            DataTable result = CRUD_Ord_Rec.read_Ord_Rec_One(id);
            txt_nNF.Text = result.Rows[0]["numero_de_NF"].ToString();
            comboBox1.SelectedIndex = comboBox1.FindStringExact(result.Rows[0]["status"].ToString());
            dateTimePicker1.Value = DateTime.Parse(result.Rows[0]["data_de_recebimento"].ToString());
        }

        private void btn_Salvar_mod_Click(object sender, EventArgs e)
        {
            Console.WriteLine(dateTimePicker1.Value.ToShortDateString());

            CRUD_Ord_Rec.update_Ord_Rec_modstatus(id,txt_nNF.Text, comboBox1.Text.ToString(), dateTimePicker1.Value.ToShortDateString());
            form1.updateTables();
            this.Close();
        }
    }
}
