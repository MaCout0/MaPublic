using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;
using Projeto.Models;
using Renci.SshNet.Security.Cryptography;
using System;
using System.Collections.Generic;


namespace ContactWeb.Models
{
    public class UserModel : IDisposable
    {
        private MySqlConnection connection;

        //open connection to database
        private bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                //When handling errors, you can your application's response based 
                //on the error number.
                //The two most common error numbers when connecting are as follows:
                //0: Cannot connect to server.
                //1045: Invalid user name and/or password.
                switch (ex.Number)
                {
                    case 0:
                        Console.Write("Cannot connect to server.  Contact administrator");
                        break;

                    case 1045:
                        Console.Write("Invalid username/password, please try again");
                        break;
                }
                return false;
            }
        }

        //Close connection
        private bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                Console.Write(ex.Message);
                return false;
            }
        }

        public UserModel()
        {
            string strConn = "SERVER=localhost;DATABASE=fullStackC;User id=root;password=;";
            connection = new MySqlConnection(strConn);
            connection.Open();
        }

        public void Dispose()
        {
            connection.Close();
        }

        public void Create(User contato)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = connection;
            cmd.CommandText = @"INSERT INTO user (name, email, senha) VALUES (@name, @email, @senha)";

            cmd.Parameters.AddWithValue("@name", contato.name);
            cmd.Parameters.AddWithValue("@email", contato.email);
            cmd.Parameters.AddWithValue("@senha", contato.senha);

            cmd.ExecuteNonQuery();
        }


        public string codificaSenha(string Senha)
        {
            try
            {
                System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create();
                byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(Senha);
                byte[] hash = md5.ComputeHash(inputBytes);
                System.Text.StringBuilder sb = new System.Text.StringBuilder();
                for (int i = 0; i < hash.Length; i++)
                {
                    sb.Append(hash[i].ToString("X2"));
                }
                return sb.ToString(); // Retorna senha criptografada 
            }
            catch (Exception)
            {
                return null; // Caso encontre erro retorna nulo
            }
        }
    



    public int Login (User contato)
        {
            int verify = 0;
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = connection;
            cmd.CommandText = @"SELECT * FROM user WHERE name=@name and senha=@senha ";

            cmd.Parameters.AddWithValue("@name", contato.name );
            cmd.Parameters.AddWithValue("@senha", contato.senha);

            MySqlDataReader reader1 = cmd.ExecuteReader();

            while (reader1.Read())
            {
                contato.Id = (int)reader1["Id"];
                contato.name = (string)reader1["name"];
                contato.email = (string)reader1["email"];
                contato.senha = (string)reader1["senha"];
                verify = 1;
            }

            cmd.ExecuteNonQuery();

            return verify;
        }

        public void Update(User contato)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = connection;
            cmd.CommandText = @"UPDATE Contato SET name=@name, email=@email, senha=@senha WHERE Id=@id";

            cmd.Parameters.AddWithValue("@name", contato.name);
            cmd.Parameters.AddWithValue("@email", contato.email);
            cmd.Parameters.AddWithValue("@senha", contato.senha);
            cmd.Parameters.AddWithValue("@id", contato.Id);

            cmd.ExecuteNonQuery();
        }

        public void Delete(int id)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = connection;
            cmd.CommandText = @"DELETE FROM user WHERE Ido=@id";

            cmd.Parameters.AddWithValue("@id", id);

            cmd.ExecuteNonQuery();
        }

        public List<User> Read()
        {
            List<User> lista = new List<User>();

            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = connection;
            cmd.CommandText = @"SELECT * FROM user";

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {

                User contato = new User();
                contato.Id = (int)reader["id"];
                contato.name = (string)reader["name"];
                contato.email = (string)reader["email"];
                contato.senha = (string)reader["senha"];

                lista.Add(contato);
            }
            return lista;
        }

    }
}
