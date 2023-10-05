using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSorveteriaSimples.Models
{
    internal class Produto
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Descricao { get; set; }

        public decimal Preco { get; set; }

        public string Foto { get; set; }

        public DateTime CreatedDate { get; set; } = DateTime.Now;
    }
}
