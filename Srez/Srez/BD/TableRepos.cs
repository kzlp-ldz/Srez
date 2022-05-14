using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace Srez.BD
{
    public class TableRepos
    {
        SQLiteConnection database;

        public TableRepos(string dbPath)
        {
            database = new SQLiteConnection(dbPath);
            database.CreateTable<User>();
            database.CreateTable<Project>();
        }
        public IEnumerable<Project> GetProjects()
        {
            return database.Table<Project>().ToList();
        }
        public IEnumerable<Project> GetProjectId(int id)
        {
            return database.Table<Project>().Where(a => a.User_id == id);
        }
        public Project GetProject(int id)
        {
            return database.Get<Project>(id);
        }

        public int DeleteProject(int id)
        {
            return database.Delete<Project>(id);
        }

        public int SaveProject(Project item)
        {
            if (item.Id != 0)
            {
                database.Update(item);
                return item.Id;
            }
            else
            {
                return database.Insert(item);
            }
        }
        public IEnumerable<User> GetUsers()
        {
            return database.Table<User>().ToList();
        }
        public User GetUser(int id)
        {
            return database.Get<User>(id);
        }
        public int SaveUser(User item)
        {
            if (item.Id != 0)
            {
                database.Update(item);
                return item.Id;
            }
            else
            {
                return database.Insert(item);
            }
        }
    }
}
