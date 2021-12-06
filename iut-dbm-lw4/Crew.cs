using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iut_dbm_lw4
{
    internal class Crew : Model
    {
		public static new Dictionary<int, Crew> Cache = new Dictionary<int, Crew>();

		public Crew(int Id, string Name)
		{
			this.Id = Id;
			this.Name = Name;
			TryToCache(this);
		}
		
		public string Name { get; set; }

		public static T GetById<T>(int Id) where T : Crew
		{
			return Cache.ContainsKey(Id) ? (T)Cache[Id] : null;
		}

		public static Crew TryToCache(Crew model)
		{
			if (!Cache.ContainsKey(model.Id))
			{
				Cache.Add(model.Id, model);
			}
			return Cache[model.Id];
		}

		public static List<string[]> GetCachedLikeString()
        {
			var list = new List<string[]>();
			foreach (var item in Cache.Values)
            {
				list.Add(new string[2] { item.Id.ToString(), item.Name });
            }
			return list;
        }

		public static Dictionary<string, string> GetCachedLikeDict()
		{
			var dict = new Dictionary<string, string>();
			foreach (var item in Cache.Values)
			{
				dict.Add(item.Id.ToString(), item.Name);
			}
			return dict;
		}

		public static void CacheUpdate()
        {
			Cache.Clear();
			CheckConnection();
			using (MySqlCommand cmd = new MySqlCommand())
			{
				cmd.Connection = Connection;
				cmd.CommandText = "SELECT * FROM crews;";
				using (MySqlDataReader rd = cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection))
				{
					while (rd.Read())
					{
						new Crew(rd.GetInt32(0), rd.GetString(1));
					}
				}
			}
		}

		public static Crew Create(string Name)
		{
			CheckConnection();

			int Id;
            using (MySqlCommand cmd = new MySqlCommand())
            {
                cmd.Connection = Connection;
                cmd.CommandText = "INSERT INTO crews (name) VALUES (@Name);";
                cmd.Parameters.AddWithValue("@Name", Name);
                cmd.ExecuteNonQuery();
				Id = (int) cmd.LastInsertedId;
            }

            return (Crew) TryToCache(new Crew(Id, Name));
		}

		public void Update()
        {
			CheckConnection();

			using (MySqlCommand cmd = new MySqlCommand())
			{
				cmd.Connection = Connection;
				cmd.CommandText = "UPDATE crews SET name=@Name WHERE id=@Id;";
				cmd.Parameters.AddWithValue("@Id", Id);
				cmd.Parameters.AddWithValue("@Name", Name);
				cmd.ExecuteNonQuery();
			}
		}

		public static void Delete(int Id)
        {
			CheckConnection();

			using (MySqlCommand cmd = new MySqlCommand())
			{
				cmd.Connection = Connection;
				cmd.CommandText = "DELETE FROM crews WHERE id=@Id;";
				cmd.Parameters.AddWithValue("@Id", Id);
				cmd.ExecuteNonQuery();
			}
		}
	}
}
