using Microsoft.EntityFrameworkCore;

namespace Vendas.Models.Produtos
{
    public class Produto : Model
    {
        public int GrupoId { get; set; }
        public int MarcaId { get; set; }
        public string SKU { get; set; }
        public string Nome { get; set; }
        public decimal UltimoCusto { get; set; }
        public decimal CustoMedio { get; set; }
        public decimal? PrecoVenda { get; set; }
        public int Quantidade { get; set; }

        public GrupoProduto Grupo { get; set; }
        public Marca Marca { get; set; }



        public static Produto Buscar(int id)
        {
            DataContext context = new();
            return context.Produtos.Find(id);
        }

        public static List<Produto> Listar()
        {
            DataContext context = new();
            return context.Produtos
                .Include(p => p.Marca)
                .Include(p => p.Grupo)
                .ToList();
        }

        public void Salvar()
        {
            DataContext context = new();

            var produto = new Produto {
                Id = Id,
                GrupoId = GrupoId,
                MarcaId = MarcaId,
                SKU = SKU,
                Nome = Nome,
                UltimoCusto = UltimoCusto,
                CustoMedio = CustoMedio,
                PrecoVenda = PrecoVenda,
                Quantidade = Quantidade
            };

            if (Id == 0)
            {
                context.Produtos.Add(produto);
                context.Entry(produto).State = EntityState.Added;
            }
            else
            {
                context.Produtos.Update(produto);
                context.Entry(produto).State = EntityState.Modified;
            }

            context.SaveChanges();
        }

        public void Deletar()
        {
            DataContext context = new();

            Produto produto = context.Produtos.Find(Id);
            context.Produtos.Remove(produto);
            context.SaveChanges();
        }
    }
}
