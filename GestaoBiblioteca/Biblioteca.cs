using System;
using System.Collections.Generic;
public class Biblioteca
{
    private List<Livro> livros;
    private List<Usuario> usuarios;

    public Biblioteca()
    {
        livros = new List<Livro>();
        usuarios = new List<Usuario>();
    }

    public void AdicionarLivro(string titulo, string autor)
    {
        livros.Add(new Livro(titulo, autor));
    }

    public void AdicionarUsuario(string nome, DateTime date)
    {
        usuarios.Add(new Usuario(nome, date));
    }

    public void EmprestarLivro(string titulo, string nomeUsuario)
    {
        Livro livro = livros.Find(l => l.Titulo == titulo && !l.Emprestado);
        if (livro != null)
        {
            Usuario usuario = usuarios.Find(u => u.Nome == nomeUsuario);
            if (usuario != null)
            {
                livro.Emprestado = true;
                usuario.LivrosEmprestados.Add(livro);
                Console.WriteLine("Livro emprestado com sucesso!");
            }
            else
            {
                Console.WriteLine("Usuário não encontrado.");
            }
        }
        else
        {
            Console.WriteLine("Livro não disponível para empréstimo.");
        }
    }

    public void DevolverLivro(string titulo, string nomeUsuario)
    {
        Livro livro = livros.Find(l => l.Titulo == titulo && l.Emprestado);
        if (livro != null)
        {
            Usuario usuario = usuarios.Find(u => u.Nome == nomeUsuario);
            if (usuario != null)
            {
                livro.Emprestado = false;
                usuario.LivrosEmprestados.Remove(livro);
                Console.WriteLine("Livro devolvido com sucesso!");
            }
            else
            {
                Console.WriteLine("Usuário não encontrado.");
            }
        }
        else
        {
            Console.WriteLine("Livro não encontrado ou não emprestado.");
        }
    }

    public void ConsultarLivrosDisponiveis()
    {
        Console.WriteLine("Livros disponíveis:");
        foreach (Livro livro in livros)
        {
            if (!livro.Emprestado)
            {
                Console.WriteLine($"Título: {livro.Titulo}, Autor: {livro.NomeAutor}");
            }
        }
    }

    public void ConsultarLivrosEmprestados(string nomeUsuario)
    {
        Usuario usuario = usuarios.Find(u => u.Nome == nomeUsuario);
        if (usuario != null)
        {
            Console.WriteLine($"Livros emprestados para {usuario.Nome}:");
            foreach (Livro livro in usuario.LivrosEmprestados)
            {
                Console.WriteLine($"Título: {livro.Titulo}, Autor: {livro.NomeAutor}");
            }
        }
        else
        {
            Console.WriteLine("Usuário não encontrado.");
        }
    }
}