using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace iut_dbm_lw4
{
    internal class Model
    {
        protected static MySqlConnection Connection = null;
        protected static Dictionary<int, Model> Cache = new Dictionary<int, Model>();
        public int Id { get; set; }

        public static Model TryToCache(Model model)
        {
            if (!Cache.ContainsKey(model.Id))
            {
                Cache.Add(model.Id, model);
            }
            return Cache[model.Id];
        }

        public static void SetConnection(MySqlConnection connection)
        {
            Connection = connection;
            CheckConnection();
        }

        public static T GetById<T>(int Id) where T : Model
        {
            return Cache.ContainsKey(Id) ? (T) Cache[Id] : null;
        }

        public static void CheckConnection()
        {
            if (Connection == null)
            {
                throw new Exception("Undefined connection");
            }
            if (Connection.State != ConnectionState.Open)
            {
                Connection.Open();
            }
        }
    }
}
