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
    internal partial class Form2 : Form
    {
        public Employee Employee { get; set; }
        public Form1 form1;

        public Form2()
        {
            InitializeComponent();
        }

        public Form2(Employee Employee, Form1 form1)
        {
            this.Employee = Employee;
            this.form1 = form1;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            comboBoxPosition.DataSource = new BindingSource(Position.GetCachedLikeDict(), null);
            comboBoxPosition.DisplayMember = "Value";
            comboBoxPosition.ValueMember = "Key";

            comboBoxCrew.DataSource = new BindingSource(Crew.GetCachedLikeDict(), null);
            comboBoxCrew.DisplayMember = "Value";
            comboBoxCrew.ValueMember = "Key";

            if (Employee != null)
            {
                this.Text = String.Format("Employee editor for {0} {1} {2}", Employee.Lastname, Employee.Firstname, Employee.Middlename);
                textBoxLastname.Text = Employee.Lastname;
                textBoxFirstname.Text = Employee.Firstname;
                textBoxMiddlename.Text = Employee.Middlename;
                dateTimePickerBirthday.Value = Employee.Birthday;
                dateTimePickerHiringDate.Value = Employee.HiringDate;
                dateTimePickerDismissalDate.Value = Employee.DismissalDate;
                numericUpDownSalary.Value = Convert.ToInt32(Employee.Salary);
                if (Employee.Position != null)
                {
                    comboBoxPosition.SelectedIndex = comboBoxPosition.FindString(Employee.Position.Name);
                }
                if (Employee.Crew != null)
                {
                    comboBoxCrew.SelectedIndex = comboBoxCrew.FindString(Employee.Crew.Name);
                }
            } else
            {
                this.Text = "Employee editor for new employee";
            }
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            form1.Show();
            form1.UpdateAll();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (Employee != null)
            {
                Employee.Lastname = textBoxLastname.Text;
                Employee.Firstname = textBoxFirstname.Text;
                Employee.Middlename = textBoxMiddlename.Text;
                Employee.Birthday = dateTimePickerBirthday.Value;
                Employee.HiringDate = dateTimePickerHiringDate.Value;
                Employee.DismissalDate = dateTimePickerDismissalDate.Value;
                Employee.Salary = (float)Convert.ToDouble(numericUpDownSalary.Value);
                Employee.Position = Position.GetById<Position>(Convert.ToInt32(comboBoxPosition.SelectedValue));
                Employee.Crew = Crew.GetById<Crew>(Convert.ToInt32(comboBoxCrew.SelectedValue));
                Employee.Update();
            } else
            {
                Employee.Create(textBoxLastname.Text, textBoxFirstname.Text, textBoxFirstname.Text, dateTimePickerBirthday.Value, dateTimePickerHiringDate.Value, dateTimePickerDismissalDate.Value, (float)Convert.ToDouble(numericUpDownSalary.Value), Position.GetById<Position>(Convert.ToInt32(comboBoxPosition.SelectedValue)), Crew.GetById<Crew>(Convert.ToInt32(comboBoxCrew.SelectedValue)));
            }
            this.Close();
        }
    }
}
