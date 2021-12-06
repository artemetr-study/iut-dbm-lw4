using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iut_dbm_lw4
{
    public partial class Form1 : Form
    {
        private MySqlConnection Connection;

        public Form1(MySqlConnection connection)
        {
            Connection = connection;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateAll();
        }

        public void UpdateAll()
        {
            Crew.SetConnection(Connection);
            Position.SetConnection(Connection);
            Employee.SetConnection(Connection);
            Crew.CacheUpdate();
            Position.CacheUpdate();
            Employee.CacheUpdate();

            if (crewsDataGridView.Columns.Count == 0 
                || positionsDataGridView.Columns.Count == 0 
                || employeesDataGridView.Columns.Count == 0)
            {
                return;
            }

            crewsDataGridView.Rows.Clear();
            List<string[]> crewsData = Crew.GetCachedLikeString();
            foreach (string[] crew in crewsData)
            {
                crewsDataGridView.Rows.Add(crew);
            }

            positionsDataGridView.Rows.Clear();
            List<string[]> positionsData = Position.GetCachedLikeString();
            foreach (string[] position in positionsData)
            {
                positionsDataGridView.Rows.Add(position);
            }

            employeesDataGridView.Rows.Clear();
            List<string[]> employeesData = Employee.GetCachedLikeString();
            foreach (string[] employee in employeesData)
            {
                employeesDataGridView.Rows.Add(employee);
            }
        }

        private void crewsDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < Crew.Cache.Count)
            {
                int Id = Convert.ToInt32(crewsDataGridView.Rows[e.RowIndex].Cells[0].Value);
                string Name = crewsDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                Crew crew = Crew.Cache.ContainsKey(Id) ? Crew.Cache[Id] : null;
                if (crew != null)
                {
                    if (crew.Name != Name)
                    {
                        crew.Name = Name;
                        crew.Update();
                    }
                }
            } else if (e.RowIndex == Crew.Cache.Count)
            {
                string Name = crewsDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                if (Name != "")
                {
                    Crew.Create(Name);
                }
            }
            UpdateAll();
        }

        private void crewsDataGridView_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
        }

        private void crewsDataGridView_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                crewsDataGridView.Rows[e.RowIndex].Selected = true;
                crewsDataGridView.CurrentCell = crewsDataGridView.Rows[e.RowIndex].Cells[1];
                crewsDataGridViewContextMenuStrip.Show(this.crewsDataGridView, e.Location);
                crewsDataGridViewContextMenuStrip.Show(Cursor.Position);
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int Id = Convert.ToInt32(crewsDataGridView.CurrentRow.Cells[0].Value);
            Crew.Delete(Id);
            UpdateAll();
        }

        private void positionsDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < Position.Cache.Count)
            {
                int Id = Convert.ToInt32(positionsDataGridView.Rows[e.RowIndex].Cells[0].Value);
                string Name = positionsDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                Position position = Position.Cache.ContainsKey(Id) ? Position.Cache[Id] : null;
                if (position != null)
                {
                    if (position.Name != Name)
                    {
                        position.Name = Name;
                        position.Update();
                    }
                }
            }
            else if (e.RowIndex == Position.Cache.Count)
            {
                string Name = positionsDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                if (Name != "")
                {
                    Position.Create(Name);
                }
            }
            UpdateAll();
        }

        private void positionsDataGridView_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                positionsDataGridView.Rows[e.RowIndex].Selected = true;
                positionsDataGridView.CurrentCell = positionsDataGridView.Rows[e.RowIndex].Cells[1];
                positionsDataGridViewContextMenuStrip.Show(this.positionsDataGridView, e.Location);
                positionsDataGridViewContextMenuStrip.Show(Cursor.Position);
            }
        }

        private void positionsDataGridViewContextMenuStrip_Click(object sender, EventArgs e)
        {
            int Id = Convert.ToInt32(positionsDataGridView.CurrentRow.Cells[0].Value);
            Position.Delete(Id);
            UpdateAll();
        }

        private void employeesDataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int Id = Convert.ToInt32(employeesDataGridView.Rows[e.RowIndex].Cells[0].Value);
            (new Form2(Employee.GetById<Employee>(Id), this)).Show();
            this.Hide();
        }

        private void employeesDataGridView_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                employeesDataGridView.Rows[e.RowIndex].Selected = true;
                employeesDataGridView.CurrentCell = employeesDataGridView.Rows[e.RowIndex].Cells[1];
                employeesDataGridViewContextMenuStrip.Show(this.employeesDataGridView, e.Location);
                employeesDataGridViewContextMenuStrip.Show(Cursor.Position);
            }
        }

        private void employeesDataGridViewContextMenuStrip_Click(object sender, EventArgs e)
        {
            int Id = Convert.ToInt32(employeesDataGridView.CurrentRow.Cells[0].Value);
            Employee.Delete(Id);
            UpdateAll();
        }
    }
}
