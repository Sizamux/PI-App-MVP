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
    public partial class f_inserir_Ord_Rec : Form
    {
        Form1 form1;
        public f_inserir_Ord_Rec(Form1 frm)
        {
            form1 = frm;
            InitializeComponent();
        }

        private void btn_Salvar_mod_Click(object sender, EventArgs e)
        {
            CRUD_Ord_Rec.insert_Ord_Rec(txt_nNF.Text, comboBox1.Text.ToString(), dateTimePicker1.Value.ToShortDateString());
            form1.updateTables();
            this.Close();
        }
    }
}
