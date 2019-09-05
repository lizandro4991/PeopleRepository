using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace People.Models
{
    [Table("Tbl_People")]
    public class Person
    {
        //Miembro Property
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        [MaxLength(50)]
        public string name { get; set; }
    }
}
