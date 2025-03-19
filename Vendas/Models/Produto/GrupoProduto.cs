using Microsoft.EntityFrameworkCore;

namespace Vendas.Models.Produtos
{
    public class GrupoProduto : Model
    {
        public string Nome { get; set; }
        public ICollection<Produto> Produtos { get; }


        public static GrupoProduto? Buscar(int id)
        {
            DataContext context = new();
            return context.GrupoProdutos
                .Include(m => m.Produtos)
                .FirstOrDefault(m => m.Id == id); ;
        }

        public static List<GrupoProduto> Listar()
        {
            DataContext context = new();
            return context.GrupoProdutos
                .Include(g => g.Produtos)
                .ToList();
        }

        public void Salvar()
        {
            DataContext context = new();

            var grupo = new GrupoProduto { 
                Id = Id,
                Nome = Nome
            };

            if (Id == 0)
            {
                context.GrupoProdutos.Add(grupo);
                context.Entry(grupo).State = EntityState.Added;
            }
            else
            {
                context.GrupoProdutos.Update(grupo);
                context.Entry(grupo).State = EntityState.Modified;
            }

            context.SaveChanges();
        }

        public void Deletar()
        {
            DataContext context = new();

            GrupoProduto grupo = context.GrupoProdutos.Find(Id);
            context.GrupoProdutos.Remove(grupo);
            context.SaveChanges();
        }
    }
}
