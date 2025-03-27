using Microsoft.EntityFrameworkCore;

namespace Vendas.Models.Clientes
{
    public class Cliente : Model
    {
        public int GrupoId { get; set; }
        public char TipoPessoa { get; set; } = 'F';
        public string? Documento { get; set; }
        public string Nome { get; set; }
        public string? Apelido { get; set; }
        public DateOnly? DataNascimento { get; set; }
        public string? EMail { get; set; }
        public string? Telefone { get; set; }
        public string? Cep { get; set; }
        public string? Logradouro { get; set; }
        public int? Numero { get; set; }
        public string? Complemento { get; set; }
        public string? Bairro { get; set; }
        public string? Cidade { get; set; }
        public string? Estado { get; set; }
        public bool Ativo { get; set; } = true;
        public  GrupoCliente Grupo { get; set; }


        public static Cliente? Buscar(int id)
        {
            DataContext context = new();
            return context.Clientes
                .Include(m => m.Grupo)
                .FirstOrDefault(m => m.Id == id); ;
        }

        public static List<Cliente> Listar()
        {
            DataContext context = new();
            return context.Clientes
                .Include(g => g.Grupo)
                .ToList();
        }

        public void Salvar()
        {
            DataContext context = new();

            var cliente = new Cliente
            {
                Id = Id,
                GrupoId = GrupoId,
                TipoPessoa = TipoPessoa,
                Documento = Documento,
                Nome = Nome,
                Apelido = Apelido,
                DataNascimento = DataNascimento,
                EMail = EMail,
                Telefone = Telefone,
                Cep = Cep,
                Logradouro = Logradouro,
                Numero = Numero,
                Complemento = Complemento,
                Bairro = Bairro,
                Cidade = Cidade,
                Estado = Estado,
                Ativo = Ativo
            };

            if (Id == 0)
            {
                context.Clientes.Add(cliente);
                context.Entry(cliente).State = EntityState.Added;
            }
            else
            {
                context.Clientes.Update(cliente);
                context.Entry(cliente).State = EntityState.Modified;
            }

            context.SaveChanges();
        }

        public void Deletar()
        {
            DataContext context = new();

            Cliente cliente = context.Clientes.Find(Id);
            context.Clientes.Remove(cliente);
            context.SaveChanges();
        }
    }
}
