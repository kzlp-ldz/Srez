using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace Srez.BD
{
    [Table("User")]
    public class User
    {
        [PrimaryKey, AutoIncrement, Column("_id")]
        public int Id { get; set; }
        public string Login { get; set; }
        [Unique]
        public string Password { get; set; }
        [Unique]
        public string FIO { get; set; }
        public bool IsAdmin { get; set; }
    }
}
