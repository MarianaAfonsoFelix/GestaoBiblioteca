Biblioteca biblioteca = new Biblioteca();

// Adicionando alguns livros para teste
biblioteca.AdicionarLivro("Harry Potter", "J.K. Rowling");
biblioteca.AdicionarLivro("The Lord of the Rings", "J.R.R. Tolkien");
biblioteca.AdicionarLivro("1984", "George Orwell");
biblioteca.AdicionarLivro("A Saga Crepúsculo", "Stephenie Meyer");
biblioteca.AdicionarLivro("Avatar a lenda de Aang", "Yee");

bool sequenciaSistemica = true;

Console.WriteLine("Bem vindo ao sistema de Gestão de Biblioteca do Desafio:");
Console.WriteLine("Desmistificando a Linguagem de Programação C#");

while(sequenciaSistemica)
{
    Console.WriteLine("\nEscolha uma opção:");
    Console.WriteLine("1. Criar um usuário?");
    Console.WriteLine("2. Emprestar um Livro");
    Console.WriteLine("3. Devolver um Livro");
    Console.WriteLine("4. Consultar Livro Disponivel");
    Console.WriteLine("5. Consultar Livro Emprestado");
    Console.WriteLine("6. Sair");

    string solicitacao = Console.ReadLine();


    Console.WriteLine("Digite o Nome do Usuário");
    string nomeUser = Console.ReadLine();

    switch (solicitacao)
    {
       case "1":
            biblioteca.AdicionarUsuario(nomeUser, DateTime.Now);
            break;
        case "2":
            Console.WriteLine("Digite o Nome do Livro:");
            string livro = Console.ReadLine();
            biblioteca.EmprestarLivro(livro, nomeUser);
            break;
        case "3":
            Console.WriteLine("Digite o Nome do Livro:");
            string nLivro = Console.ReadLine();
            biblioteca.DevolverLivro(nLivro, nomeUser);
            return;
        case "4":
            biblioteca.ConsultarLivrosEmprestados(nomeUser);
            return;
        case "5":
            biblioteca.ConsultarLivrosEmprestados(nomeUser);
            return;
        case "6":
            Console.WriteLine("Obrigada por fazer parte do club de livros :)");
            break;
        default:
            Console.WriteLine("Opção inválida. Tente novamente.");
            break;
      }
}
