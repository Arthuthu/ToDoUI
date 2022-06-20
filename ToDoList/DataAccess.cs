using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Dapper;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList
{
    public class DataAccess
    {
        public List<Goals> SearchShortTermGoals()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("ToDoDB")))
            {
                var output = connection.Query<Goals>("dbo.ShortTerm_SearchList").ToList();
                return output;
            }
        }

        public List<Goals> SearchMidTermGoals()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("ToDoDB")))
            {
                var output = connection.Query<Goals>("dbo.MidTerm_SearchList").ToList();
                return output;
            }
        }

        public List<Goals> SearchLongTermGoals()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("ToDoDB")))
            {
                var output = connection.Query<Goals>("dbo.LongTerm_SearchList").ToList();
                return output;
            }
        }

        public List<Goals> SearchAllGoals()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("ToDoDB")))
            {
                var output = connection.Query<Goals>("dbo.SearchAllGoals").ToList();
                return output;
            }
        }

        public List<Goals> SearchCompletedGoals()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("ToDoDB")))
            {
                var output = connection.Query<Goals>("dbo.CompletedGoal_SearchList").ToList();
                return output;
            }
        }

        public void InserShortTermGoal(string goal)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("ToDoDB")))
            {
                List<Goals> newShortTermGoal = new List<Goals>();

                newShortTermGoal.Add(new Goals { Goal = goal });

                connection.Execute("dbo.InsertShortTermGoal @Goal", newShortTermGoal);
            }
        }

        public void InserMidTermGoal(string goal)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("ToDoDB")))
            {
                List<Goals> newMidTermGoal = new List<Goals>();

                newMidTermGoal.Add(new Goals { Goal = goal });

                connection.Execute("dbo.InsertMidTermGoal @Goal", newMidTermGoal);
            }
        }

        public void InserLongTermGoal(string goal)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("ToDoDB")))
            {
                List<Goals> newLongTermGoal = new List<Goals>();

                newLongTermGoal.Add(new Goals { Goal = goal });

                connection.Execute("dbo.InsertLongTermGoal @Goal", newLongTermGoal);
            }
        }
        public void DeleteGoal(string goal)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("ToDoDB")))
            {
                List<Goals> newCompletedGoal = new List<Goals>();

                newCompletedGoal.Add(new Goals { Goal = goal });

                connection.Execute("dbo.insertCompletedGoal @Goal", newCompletedGoal);

                connection.Execute($"dbo.deleteGoal @Goal = '{goal}'");
            }
        }

        public void DeletCompletedeGoal(string goal)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("ToDoDB")))
            {

                connection.Execute($"dbo.deleteCompletedGoal @Goal = '{goal}'");
            }
        }
    }
}
    