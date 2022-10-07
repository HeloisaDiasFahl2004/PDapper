using PDapper.Model;
using PDapper.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDapper.Service
{
    public class ClienteService
    {
        private IClienteRepository _clienteRepository;

        public ClienteService()
        {
            _clienteRepository = new ClienteRepository();
        }

        public bool Add(Cliente cliente)
        {
            return _clienteRepository.Add(cliente); 
        }
        public List<Cliente> GetAll()
        {
            return _clienteRepository.GetAll();
        }
    }
}
