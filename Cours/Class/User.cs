using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cours.Class
{
    public class User
    {
        [PrimaryKey,AutoIncrement]
        public uint Id{ get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
    }
}
