using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
 

namespace CompetencePlus.Outils
{
    class MyConnection
    {   
        public static OleDbConnection Connection;
        public static OleDbCommand Command;
        

        public static void ExecuteNonQuery(string Requete) {
           string ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\CompétencePlus.accdb;Persist Security Info=True";
            Connection = new OleDbConnection(ConnectionString);
        Command=Connection.CreateCommand();
        Command.CommandText = Requete;
        Connection.Open();
         Command.ExecuteNonQuery();
         Connection.Close();
        }

        public static OleDbDataReader ExecuteReader(string Requete) {
           string ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\CompétencePlus.accdb;Persist Security Info=True";
            Connection = new OleDbConnection(ConnectionString);
           Command = Connection.CreateCommand();
            Command.CommandText = Requete;
            Connection.Open();
            OleDbDataReader read = Command.ExecuteReader();
            return read;
        
        }

        public static void Close (){
            Connection.Close();
          }
    }
}
