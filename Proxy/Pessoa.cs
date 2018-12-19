using System;
using System.Collections.Generic;
using System.Text;

namespace Proxy
{
    class PessoaImpl: IPessoa
    {
      private String nome;
    private String id;

    public PessoaImpl(String id, String nome)
    {
        this.id = id;
        this.nome = nome;
            // apenas para simular algo...
        Console.WriteLine("Retornou a pessoa do banco de dados ->  " + nome);
    }

    public String getNome()
    {
        return nome;
    }
    public String getId()
    {
        return this.id;
    }
}
}
