using System;
using System.Collections.Generic;
using System.Text;

namespace Proxy
{
    class ProxyPessoa: IPessoa
    {
        private String id;

        private IPessoa pessoa;

        public ProxyPessoa(String nome)
        {
            this.id = nome;
        }

        public String getNome()
        {
            if (pessoa == null)
                pessoa = PessoaDAO.getPessoaByID(this.id);
      
            /** Delega para o objeto real **/
            return pessoa.getNome();
        }

        public String getId()
        {
            return this.id;
        }
    }
}
