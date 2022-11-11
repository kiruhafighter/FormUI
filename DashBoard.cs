using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormUI
{
    public partial class DashBoard : Form
    {

        List<Person> peopleSearch = new List<Person>();
        List<Person> allPeople = new List<Person>();
        private void UpdateBinding(List<Person> persons)
        {
            peopleFoundListbox.DataSource = persons;
            peopleFoundListbox.DisplayMember = "FullInfo";
        }
        public DashBoard()
        {
            InitializeComponent();
            allPeople = DataAccess.GetAllPeople();
            UpdateBinding(allPeople);
        }
        private void searchButton_Click(object sender, EventArgs e)
        {
            peopleSearch = DataAccess.GetPeople(lastNameText.Text);
            UpdateBinding(peopleSearch);
        }

        private void InsertButton_Click(object sender, EventArgs e)
        {
            DataAccess.InsertPerson(firstNameText.Text, lastNameTextBox.Text, emailAddressText.Text, phoneText.Text);
            firstNameText.Text = "";
            lastNameTextBox.Text = "";
            emailAddressText.Text = "";
            phoneText.Text = "";
        }
    }
}
