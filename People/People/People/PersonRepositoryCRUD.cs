using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using People.Models;

namespace People
{
    class PersonRepositoryCRUD
    {
        SQLiteConnection conn;
        public string StatusMessage { get; set; }
        public PersonRepositoryCRUD(string dbPath)
        {
            //Creamos La Conexion
            conn = new SQLiteConnection(dbPath);
            conn.CreateTable<Person>();
        }

        //Method Create
        public void CreatePerson(Person newPerson)
        {
            //Creamos el Metodo para Intertar Personas
            int result;
            result = conn.Insert(newPerson);
            if (result == 1)
            {
                StatusMessage =
                    $"{result} registro agregado [Nombre: " +
                    $"{newPerson.name}, ID:{newPerson.Id}";
            }
            else
            {
                StatusMessage = "Registro No Insertado";
            }
        }
    }
    
}
