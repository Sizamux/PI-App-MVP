using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjOkProjetos.Model
{
    internal class Itn_Serv_Rec
    {
        public int id;
        public int id_OrdServ;
        public int id_OrdRec;
        public string descricao;
        public double valor;

        public Itn_Serv_Rec(int id, int id_OrdServ, int id_OrdRec, string descricao, double valor)
        {
            this.id = id;
            this.id_OrdServ = id_OrdServ;
            this.id_OrdRec = id_OrdRec;
            this.descricao = descricao;
            this.valor = valor;
        }
    }
}
