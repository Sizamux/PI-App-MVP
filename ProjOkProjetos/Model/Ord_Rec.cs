using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjOkProjetos.Model
{
    internal class Ord_Rec
    {
        public int id;
        public string nummero_de_NF;
        public string status;
        public DateTime data_de_recebimento;
        public DateTime data_de_criacao;
        public DateTime ultima_modificacao;

        public Ord_Rec(int id, string nummero_de_NF, string status, DateTime data_de_recebimento)
        {
            this.id = id;
            this.status = nummero_de_NF;
            this.status = status;
            this.data_de_recebimento = data_de_recebimento;
            this.data_de_criacao = DateTime.Now;
            this.ultima_modificacao = DateTime.Now;
        }
    }
}
