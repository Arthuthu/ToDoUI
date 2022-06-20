using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDoList
{
    public partial class Dashboard : Form
    {
        List<Goals> shortTermSearch = new List<Goals>();
        List<Goals> midTermSearch = new List<Goals>();
        List<Goals> longTermSearch = new List<Goals>();
        List<Goals> searchAllGoals = new List<Goals>();
        List<Goals> searchCompletedGoals = new List<Goals>();
        public Dashboard()
        {
            InitializeComponent();

            UpdateShortTermsBinding();
            UpdateMidTermsBinding();
            UpdateLongTermsBinding();
            UpdateSearchAllBinding();
            UpdateSearchCompletedBinding();
        }

        private void UpdateShortTermsBinding()
        {
            goalsListbox.DataSource = shortTermSearch;
            goalsListbox.DisplayMember = "Goal";
        }

        private void UpdateMidTermsBinding()
        {
            goalsListbox.DataSource = midTermSearch;
            goalsListbox.DisplayMember = "Goal";
        }

        private void UpdateLongTermsBinding()
        {
            goalsListbox.DataSource = longTermSearch;
            goalsListbox.DisplayMember = "Goal";
        }
        private void UpdateSearchAllBinding()
        {
            goalsListbox.DataSource = searchAllGoals;
            goalsListbox.DisplayMember = "Goal";
        }

        private void UpdateSearchCompletedBinding()
        {
            goalsListbox.DataSource = searchCompletedGoals;
            goalsListbox.DisplayMember = "Goal";
        }

        private void shortTermSearchButton_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();

            shortTermSearch = db.SearchShortTermGoals();

            displayListNameButton.Text = "Short Term Goals";

            UpdateShortTermsBinding();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void midTermSearchButton_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();

            midTermSearch = db.SearchMidTermGoals();

            displayListNameButton.Text = "Mid Term Goals";

            UpdateMidTermsBinding();
        }

        private void longTermSearchButton_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();

            longTermSearch = db.SearchLongTermGoals();

            displayListNameButton.Text = "Long Term Goals";

            UpdateLongTermsBinding();
        }

        private void searchAllButton_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();

            searchAllGoals = db.SearchAllGoals();

            displayListNameButton.Text = "All Goals";

            UpdateSearchAllBinding();
        }

        private void longTermAddButton_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            if (String.IsNullOrEmpty(shortTermTexBox.Text))
            {
                MessageBox.Show("The text box is empty.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                db.InserShortTermGoal(shortTermTexBox.Text);
                shortTermTexBox.Text = "";

                shortTermSearch = db.SearchShortTermGoals();

                UpdateShortTermsBinding();
            }

            displayListNameButton.Text = "Short Term Goals";
        }

        private void midTermAddButton_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();

            if (String.IsNullOrEmpty(midTermTexBox.Text))
            {
                MessageBox.Show("The text box is empty.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                db.InserMidTermGoal(midTermTexBox.Text);
                midTermTexBox.Text = "";

                midTermSearch = db.SearchMidTermGoals();

                UpdateMidTermsBinding();
            }

            displayListNameButton.Text = "Mid Term Goals";
        }

        private void shortTermAddButton_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();

            if (String.IsNullOrEmpty(longTermTexBox.Text))
            {
                MessageBox.Show("The text box is empty.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                db.InserLongTermGoal(longTermTexBox.Text);
                longTermTexBox.Text = "";

                longTermSearch = db.SearchLongTermGoals();

                UpdateLongTermsBinding();
            }

            displayListNameButton.Text = "Short Term Goals";
        }

        private void searchCompletedGoalsButton_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();

            searchCompletedGoals = db.SearchCompletedGoals();

            displayListNameButton.Text = "Completed Goals";

            UpdateSearchCompletedBinding();
        }

        private void deletedCompletedGoalButton_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();

            db.DeletCompletedeGoal(goalsListbox.GetItemText(goalsListbox.SelectedItem));

            searchCompletedGoals = db.SearchCompletedGoals();

            UpdateSearchCompletedBinding();
        }

        private void deleteButton_Click_1(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();

            db.DeleteGoal(goalsListbox.GetItemText(goalsListbox.SelectedItem));

            searchCompletedGoals = db.SearchCompletedGoals();

            displayListNameButton.Text = "Completed Goals";

            UpdateSearchCompletedBinding();
        }

        private void topPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void goalsListbox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void goalsListbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void displayLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
