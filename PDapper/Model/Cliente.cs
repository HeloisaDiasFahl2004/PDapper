using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDapper.Model
{
    public class Cliente
    {
        #region Constante
        public readonly static string INSERT = "INSERT INTO TB_CLIENTE (Nome,Telefone) VALUES(@Nome,@Telefone)"; //criando uma constante publica, somente de leitura, já passando o comando do banco de dados
        //serve pra já inserir no bd

        public readonly static string SELECT = "SELECT Id,Nome,Telefone FROM TB_CLIENTE";
        #endregion

        #region Propriedade
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        #endregion

        #region Método


        public override string ToString()
        {
            return "Id: " + this.Id +
            "\nNome: " + this.Nome +
            "\nTelefone: " + this.Telefone;

        }
        #endregion
    }
}
