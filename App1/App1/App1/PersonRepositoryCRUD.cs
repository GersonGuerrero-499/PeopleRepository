using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using App1.Model;
namespace App1
{
   public class PersonRepositoryCRUD
    {
        SQLiteConnection conn;

        public string StatusMessage { get; set; }

        public PersonRepositoryCRUD(string dbPath)
        {
            //creamos la conexion
            conn = new SQLiteConnection(dbPath);
            conn.CreateTable<Person>();
         
        }
    }
}
