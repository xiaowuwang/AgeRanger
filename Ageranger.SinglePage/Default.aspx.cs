using AgeRanger.Core.Interfaces;
using AgeRanger.Core.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AgeRanger.SinglePage
{
    public partial class Default : BasePage
    {
        private Person _person = new Person();

        public IPersonService personService { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                this.BindGridView();
            }
        }

        private void BindGridView()
        {
            GridView1.DataSource = personService.ListPerson();
            GridView1.DataBind();
        }

        protected void EditButton_Click(object sender, EventArgs e)
        {
            if (((LinkButton)sender).Text == "Cancel")
            {
                AssignPersonTextBox("", "", "", "");
                ((LinkButton)sender).Text = "Edit";
                SaveButton.Text = "Add";
            }
            else
            {
                string[] commandArgs = ((LinkButton)sender).CommandArgument.ToString().Split(new char[] { ',' });
                AssignPersonTextBox(commandArgs[0], commandArgs[1], commandArgs[2], commandArgs[3]);
                AssignPersonObjectForEdit(Convert.ToInt32(commandArgs[0]), commandArgs[1], commandArgs[2], Convert.ToInt32(commandArgs[3]));
                ((LinkButton)sender).Text = "Cancel";
                SaveButton.Text = "Edit";
            }
        }

        private void AssignPersonObjectForEdit(int personId, string firstName, string lastName, int age)
        {
            _person.Id = personId;
            _person.FirstName = firstName;
            _person.LastName = lastName;
            _person.Age = age;
        }

        private void AssignPersonTextBox(string id, string firstName, string lastName, string age)
        {
            IdLabel.Text = id;
            FirstNameTextBox.Text = firstName;
            LastNameTextBox.Text = lastName;
            AgeTextBox.Text = age;
        }

        protected void SaveButton_Click(object sender, EventArgs e)
        {

            if (SaveButton.Text == "Edit")
            {
                AssignPersonObjectForEdit(Convert.ToInt32(IdLabel.Text), FirstNameTextBox.Text, LastNameTextBox.Text, Convert.ToInt32(AgeTextBox.Text));
                personService.Edit(_person);

            }
            else
            if (SaveButton.Text == "Add")
            {
                personService.Add(FirstNameTextBox.Text, LastNameTextBox.Text, Convert.ToInt32(AgeTextBox.Text));
            }
            AssignPersonTextBox("ID","","","");
            GridView1.EditIndex = -1;
            SaveButton.Text = "Add";
        }

        protected void SearchButton_Click(object sender, EventArgs e)
        {
            var person = personService.GetPersonByName(SearchNameTextBox.Text);
            if (person != null)
            {
                rFirstNameLabel.Text = person.FirstName;
                rLastNameLabel.Text = person.LastName;
                rAgeLabel.Text = Convert.ToString(person.Age);
                rAgeGroupLabel.Text = person.PersonAgeGroup;
            }
            else
            {
                rFirstNameLabel.Text = "NOT Found";
                rLastNameLabel.Text  = "";
                rAgeLabel.Text       = "";
                rAgeGroupLabel.Text  = "";
            }
        }
    }
}