using Dapper;
using PDapper.Config;
using PDapper.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDapper.Repository
{
    public class ClienteRepository : IClienteRepository
    {
        private string _conn; // _ serve pra indicar atributos privados

        public ClienteRepository()
        {
            _conn = DatabaseConfiguration.Get(); //pega a string de conexão pra gerar a configuração
            //pra passar direto, poderia excluir appsettings.json e DatabaseConfiguration(pasta config)
        }
        public bool Add(Cliente cliente)
        {
            bool result = false;

            using (var db = new SqlConnection(_conn))
            {
                db.Open();//propriedade do sql
                db.Execute(Cliente.INSERT, cliente);//propriedade do dapper
                result = true;
                db.Close();//mas não é obrigatório pois só está aberta dentro do using
            }
            return result;
        }

        public List<Cliente> GetAll()
        {
            using (var db = new SqlConnection(_conn))
            {
                db.Open();
                var clientes = db.Query<Cliente>(Cliente.SELECT);
                return (List<Cliente>)clientes;
            }
        }
    }
}
