public class Livro
{
    public string Titulo { get; set; }
    public string NomeAutor { get; set; }
    public bool Emprestado { get; set; }

    public Livro(string titulo, string nomeAutor)
    {
        Titulo = titulo;
        NomeAutor = nomeAutor;
        Emprestado = false;
    }
}