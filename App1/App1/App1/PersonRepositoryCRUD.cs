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

        //CRUD OPERATIONS O METODOS

        //CREAR

        public void CreatePerson(Person newPerson)
            {
               
                int result = 0;
                result=conn.Insert(newPerson);
            if(result==1)
                {
                    StatusMessage= $"{result} registro agregados [Nombre:" + 
                    $"{newPerson.Name}, ID:{newPerson.Id}]";

                // un registro agregado[Nombre: Juan , Id:1]
                }
            else
                {
                     StatusMessage= $" registro no agregado!";
                }

            }
    }
}
