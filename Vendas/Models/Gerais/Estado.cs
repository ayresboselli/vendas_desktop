using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Vendas.Models.Gerais
{
    public class Estado
    {
        public int Id { get; set; }
        public string Sigla { get; set; }
        public string Nome { get; set; }
    }
}
