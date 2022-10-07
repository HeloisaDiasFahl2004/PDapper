using PDapper.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDapper.Repository
{
    public interface IClienteRepository//Assinatura dos métodos
    {
        bool Add(Cliente cliente);//adicionar uma informação
        List<Cliente> GetAll();//consultar uma informação
    }
}
