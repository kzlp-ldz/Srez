using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace Srez.BD
{
    [Table("Project")]
    public class Project
    {
        [PrimaryKey, AutoIncrement, Column("_id")]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Descrip { get; set; }
        public DateTime date { get; set; }
        public int User_id { get; set; }
    }
}
