using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SurveyBase1.Logic;


namespace SurveyBase1
{
    public partial class _Default : Page
    {
        private string SurveyID = "Survey-" + Guid.NewGuid().ToString();
        private string ClientID = "CL0001";
        private string UserID = "User-" + Guid.NewGuid().ToString();
        private string GateID = "Gate-" + Guid.NewGuid().ToString();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void startSurveyButton_Click(object sender, EventArgs e)
        {
            initialSurveyDB();
        }


        public void initialSurveyDB()
        {
            // Add survey data to DB.
            AddSurveys surveys = new AddSurveys();
            bool addSurveySuccess = surveys.AddSurvey(SurveyID, ClientID, UserID);
            if (addSurveySuccess)
            {
                //print success.
            }

            else
            {
                // print error.

            }
        }
    }
}