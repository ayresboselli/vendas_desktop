using Microsoft.EntityFrameworkCore;

namespace Vendas.Models.Produtos
{
    public class Marca : Model
    {
        public string Nome { get; set; }
        public ICollection<Produto> Produtos { get; }


        public static Marca Buscar(int id)
        {
            DataContext context = new();
            return context.Marcas
                .Include(m => m.Produtos)
                .FirstOrDefault(m => m.Id == id);
        }

        public static List<Marca> Listar()
        {
            DataContext context = new();
            return context.Marcas
                .Include(g => g.Produtos)
                .ToList();
        }

        public void Salvar()
        {
            DataContext context = new();
            var marca = new Marca
            {
                Id = Id,
                Nome = Nome
            };

            if (marca.Id == 0)
            {
                context.Marcas.Add(marca);
                context.Entry(marca).State = EntityState.Added;
            }
            else
            {
                context.Marcas.Update(marca);
                context.Entry(marca).State = EntityState.Modified;
            }

            context.SaveChanges();
        }

        public void Deletar()
        {
            DataContext context = new();

            Marca marca = context.Marcas.Find(Id);
            context.Marcas.Remove(marca);
            context.SaveChanges();
        }
    }
}
