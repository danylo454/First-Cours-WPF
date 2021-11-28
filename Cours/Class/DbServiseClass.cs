using Cours.Class;
using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cours
{
    public class DbServiseClass
    {
        private const string databaseName = "ListWorkDatabase.db";
        private const string usersDatabaseName = "UserListWorkDatabase.db";
        private static string dbPath = Path.Combine(Environment.CurrentDirectory, databaseName);
        private static string dbPathUsers = Path.Combine(Environment.CurrentDirectory, usersDatabaseName);
        public static void AddNotebook(NotebookClass list)
        {
            using (SQLiteConnection connection = new SQLiteConnection(DbServiseClass.dbPath))
            {
                connection.CreateTable<NotebookClass>();
                connection.Insert(list);
            }
        }
        public static void DeleteNotebook(NotebookClass list)
        {
            using (SQLiteConnection connection = new SQLiteConnection(dbPath))
            {
                connection.CreateTable<NotebookClass>();
                connection.Delete(list);
            }
        }
        public static void UpdateNotebook(NotebookClass list)
        {
            using (SQLiteConnection connection = new SQLiteConnection(dbPath))
            {
                connection.CreateTable<NotebookClass>();
                connection.Update(list);
            }
        }
        public static List<NotebookClass> GetAllNotebooks()
        {
            List<NotebookClass> list = new List<NotebookClass>();
            using (SQLiteConnection connection = new SQLiteConnection(dbPath))
            {
                connection.CreateTable<NotebookClass>();
                list = connection.Table<NotebookClass>().ToList();
            }
            return list;
        }
        public static void AddUser(User user)
        {
            using (SQLiteConnection connection = new SQLiteConnection(DbServiseClass.dbPathUsers))
            {
                connection.CreateTable<User>();
                connection.Insert(user);
            }
        }
        public static List<User> GetAllUsers()
        {
            List<User> list = new List<User>();
            using (SQLiteConnection connection = new SQLiteConnection(DbServiseClass.dbPathUsers))
            {
                connection.CreateTable<User>();
                list = connection.Table<User>().ToList();
            }
            return list;
        }
        public static User LoadUser(string login, string passwd)
        {
            User user = new User();
            using (SQLiteConnection connection = new SQLiteConnection(DbServiseClass.dbPathUsers))
            {
                connection.CreateTable<User>();
                user = connection.Table<User>().ToList().Where(i => i.Login == login && i.Password == passwd).FirstOrDefault();
            }
            return user;
        }
    }
}
