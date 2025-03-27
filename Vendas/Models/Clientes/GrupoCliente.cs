using Microsoft.EntityFrameworkCore;

namespace Vendas.Models.Clientes
{
    public class GrupoCliente : Model
    {
        public string Nome { get; set; }
        public ICollection<Cliente> Clientes { get; }


        public static GrupoCliente? Buscar(int id)
        {
            DataContext context = new();
            return context.GrupoClientes
                .Include(m => m.Clientes)
                .FirstOrDefault(m => m.Id == id); ;
        }

        public static List<GrupoCliente> Listar()
        {
            DataContext context = new();
            return context.GrupoClientes
                .Include(g => g.Clientes)
                .ToList();
        }

        public void Salvar()
        {
            DataContext context = new();

            var grupo = new GrupoCliente
            {
                Id = Id,
                Nome = Nome
            };

            if (Id == 0)
            {
                context.GrupoClientes.Add(grupo);
                context.Entry(grupo).State = EntityState.Added;
            }
            else
            {
                context.GrupoClientes.Update(grupo);
                context.Entry(grupo).State = EntityState.Modified;
            }

            context.SaveChanges();
        }

        public void Deletar()
        {
            DataContext context = new();

            GrupoCliente grupo = context.GrupoClientes.Find(Id);
            context.GrupoClientes.Remove(grupo);
            context.SaveChanges();
        }
    }
}
