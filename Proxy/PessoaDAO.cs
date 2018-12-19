using System;
using System.Collections.Generic;
using System.Text;

namespace Proxy
{
    class PessoaDAO
    {
        public static IPessoa getPessoaByID(String id)
        {
            Console.WriteLine("select * from PESSOA where id=" + id);
            return new PessoaImpl(id, "Pessoa " + id);
        }
    }
}
