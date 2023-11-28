﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace UelitonCrud.DAL
{
    internal class Conexao
    {
        //propriedades para conectar ao banco de dados
        string conecta = "SERVER=localhost; DATABASE=pessoas; UID=root; PWD=SUPORTE99";

        protected MySqlConnection conexao = null;

        //metodo para conectar ao banco de dados
        public void AbrirConexao()
        {
            try
            {
                conexao = new MySqlConnection(conecta);
                conexao.Open();
            }
            catch (Exception erro)
            {

                throw erro;
            }
        }
        // metodo para fechar a conexão

        public void FecharConexao()
        {
            try
            {
                conexao = new MySqlConnection(conecta);
                conexao.Close(); 
            }
            catch (Exception erro)
            {

                throw erro;
            }
        }



    }
}
