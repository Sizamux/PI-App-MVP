    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjOkProjetos.Model
{
    internal class Ord_Serv
    {
        public int id;
        public string nome_operadora;
        public string numero_de_PO;
        public string descricao_de_PO;
        public string fase_atual;
        public DateTime data_de_criacao;
        public DateTime ultima_modificacao;

        public Ord_Serv(int id, string nome_operadora, string numero_de_PO, string descricao_de_PO, string fase_atual)
        {
            this.id = id;
            this.nome_operadora = nome_operadora;
            this.numero_de_PO = numero_de_PO;
            this.descricao_de_PO = descricao_de_PO;
            this.fase_atual = fase_atual;
            this.data_de_criacao = DateTime.Now;
            this.ultima_modificacao = DateTime.Now;
        }
    }
}
