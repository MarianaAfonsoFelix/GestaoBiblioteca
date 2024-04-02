public class Usuario
{
    public string Nome { get; set; }
    public DateTime DataNascimento { get; set; }
    public List<Livro> LivrosEmprestados { get; set; }

    public Usuario(string nome, DateTime date)
    {
        Nome = nome;
        DataNascimento = date;
        LivrosEmprestados = new List<Livro>();
    }
}