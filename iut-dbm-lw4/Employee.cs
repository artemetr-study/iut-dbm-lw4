using System;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iut_dbm_lw4
{
	internal class Employee : Model
	{
		public int Id { get; set; }
		public string Lastname { get; set; }
		public string Firstname { get; set; }
		public string Middlename { get; set; }
		public DateTime Birthday { get; set; }
		public DateTime HiringDate { get; set; }
		public DateTime DismissalDate { get; set; }
		public float Salary { get; set; }
		public Position Position { get; set; }
		public Crew Crew { get; set; }

		public static new Dictionary<int, Employee> Cache = new Dictionary<int, Employee>();

		public static T GetById<T>(int Id) where T : Employee
		{
			return Cache.ContainsKey(Id) ? (T)Cache[Id] : null;
		}

		public Employee(int Id, string Lastname, string Firstname, string Middlename, DateTime Birthday, DateTime HiringDate, DateTime DismissalDate, float Salary, Position Position, Crew Crew)
		{
			this.Id = Id;
			this.Lastname = Lastname;
			this.Firstname = Firstname;
			this.Middlename = Middlename;
			this.Birthday = Birthday;
			this.HiringDate = HiringDate;
			this.DismissalDate = DismissalDate;
			this.Salary = Salary;
			this.Position = Position;
			this.Crew = Crew;
			TryToCache(this);
		}

		public static Employee TryToCache(Employee model)
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
				list.Add(new string[2] { item.Id.ToString(), String.Format("{0} {1} {2}", item.Lastname, item.Firstname, item.Middlename) });
			}
			return list;
		}

		public static void CacheUpdate()
		{
			Cache.Clear();
			CheckConnection();
			using (MySqlCommand cmd = new MySqlCommand())
			{
				cmd.Connection = Connection;
				cmd.CommandText = "SELECT * FROM employees;";
				using (MySqlDataReader rd = cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection))
				{
					while (rd.Read())
					{
						new Employee(rd.GetInt32(0), rd.GetString(1), rd.GetString(2), rd.GetString(3), rd.GetDateTime(4), rd.GetDateTime(5), rd.GetDateTime(6), rd.GetFloat(7), Position.GetById<Position>(rd.GetInt32(8)), Crew.GetById<Crew>(rd.GetInt32(9)));
					}
				}
			}
		}

		public static Employee Create(string Lastname, string Firstname, string Middlename, DateTime Birthday, DateTime HiringDate, DateTime DismissalDate, float Salary, Position Position, Crew Crew)
		{
			CheckConnection();

			int Id;
			using (MySqlCommand cmd = new MySqlCommand())
			{
				cmd.Connection = Connection;
				cmd.CommandText = "INSERT INTO employees (lastname, firstname, middlename, birthday, hiring_date, dismissal_date, salary, position_id, crew_id) VALUES (@Lastname, @Firstname, @Middlename, @Birthday, @HiringDate, @DismissalDate, @Salary, @PositionId, @CrewId);";
				cmd.Parameters.AddWithValue("@Lastname", Lastname);
				cmd.Parameters.AddWithValue("@Firstname", Firstname);
				cmd.Parameters.AddWithValue("@Middlename", Middlename);
				cmd.Parameters.AddWithValue("@Birthday", Birthday);
				cmd.Parameters.AddWithValue("@HiringDate", HiringDate);
				cmd.Parameters.AddWithValue("@DismissalDate", DismissalDate);
				cmd.Parameters.AddWithValue("@Salary", Salary);
				if (Position != null)
                {
					cmd.Parameters.AddWithValue("@PositionId", Position.Id);
				} else
                {
					cmd.Parameters.AddWithValue("@PositionId", null);
				}
				if (Crew != null)
				{
					cmd.Parameters.AddWithValue("@CrewId", Crew.Id);
				}
				else
				{
					cmd.Parameters.AddWithValue("@CrewId", null);
				}
				cmd.ExecuteNonQuery();
				Id = (int)cmd.LastInsertedId;
			}

			return (Employee)TryToCache(new Employee(Id, Lastname, Firstname, Middlename, Birthday, HiringDate, DismissalDate, Salary, Position, Crew));
		}

		public void Update()
		{
			CheckConnection();

			using (MySqlCommand cmd = new MySqlCommand())
			{
				cmd.Connection = Connection;
				cmd.CommandText = "UPDATE employees SET lastname=@Lastname, firstname=@Firstname, middlename=@Middlename, birthday=@Birthday, hiring_date=@HiringDate, dismissal_date=@DismissalDate, salary=@Salary, position_id=@PositionId, crew_id=@CrewId WHERE id=@Id;";
				cmd.Parameters.AddWithValue("@Id", Id);
				cmd.Parameters.AddWithValue("@Lastname", Lastname);
				cmd.Parameters.AddWithValue("@Firstname", Firstname);
				cmd.Parameters.AddWithValue("@Middlename", Middlename);
				cmd.Parameters.AddWithValue("@Birthday", Birthday);
				cmd.Parameters.AddWithValue("@HiringDate", HiringDate);
				cmd.Parameters.AddWithValue("@DismissalDate", DismissalDate);
				cmd.Parameters.AddWithValue("@Salary", Salary);
				if (Position != null)
				{
					cmd.Parameters.AddWithValue("@PositionId", Position.Id);
				}
				else
				{
					cmd.Parameters.AddWithValue("@PositionId", null);
				}
				if (Crew != null)
				{
					cmd.Parameters.AddWithValue("@CrewId", Crew.Id);
				}
				else
				{
					cmd.Parameters.AddWithValue("@CrewId", null);
				}
				cmd.ExecuteNonQuery();
			}
		}

		public static void Delete(int Id)
		{
			CheckConnection();

			using (MySqlCommand cmd = new MySqlCommand())
			{
				cmd.Connection = Connection;
				cmd.CommandText = "DELETE FROM employees WHERE id=@Id;";
				cmd.Parameters.AddWithValue("@Id", Id);
				cmd.ExecuteNonQuery();
			}
		}
	}
}