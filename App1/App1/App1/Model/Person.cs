using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace App1.Model
{
    [Table("T_People")]
    public class Person
    {
        //miembro properties
        [PrimaryKey,AutoIncrement]
        public int Id { get; set; } 

        [MaxLength(50)]
        public string Name { get; set; }

    }
}
