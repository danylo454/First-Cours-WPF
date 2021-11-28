using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cours
{
    public class NotebookClass
    {
        public enum Сategories { Red = 3, Blue = 2, Green = 1 };
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string NameNotebook { get; set; }
        public DateTime StartDo { get; set; }
        public DateTime EndDo { get; set; }
        public string Comment { get; set; }
        public string Login { get; set; }
        public Сategories Priority { get; set; }
        public override string ToString()
        {
            return $"Name: {NameNotebook} You will end: {EndDo.ToString("d")}";
        }

    }
}
