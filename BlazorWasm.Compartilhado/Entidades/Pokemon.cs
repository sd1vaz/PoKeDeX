using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorWasm.Compartilhado.Entidades
{
    public class Pokemon : IEntity
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Tipo { get; set; }
        //public string Ataques { get; set; }
        //public int HP { get; set; }
        //public int ATK { get; set; }
        //public int DFS { get; set; }
        public int CategoriaId { get; set; }
        public virtual Categoria Categoria { get; set; }

    }
}
