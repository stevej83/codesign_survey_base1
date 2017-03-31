using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using SurveyBase1.Models;

namespace SurveyBase1.Logic
{
    public class AddSurveys
    {
        public bool AddSurvey(string surveyID, string clientID, string userID)
        {
            var thisSurvey = new Survey();
            thisSurvey.SurveyID = surveyID;
            thisSurvey.ClientID = clientID;
            thisSurvey.UserID = userID;
            thisSurvey.SurveyStart = DateTime.Now;
            thisSurvey.SurveyEnd = DateTime.MinValue;
            thisSurvey.SurveyLastUpdate = DateTime.MinValue;
            thisSurvey.Q1Ans = "";
            thisSurvey.Q1Pt = 0;
            thisSurvey.Q2Ans = "";
            thisSurvey.Q2Pt = 0;

            using (SurveyContext _db = new SurveyContext())
            {
                // Add Survey to DB
                _db.Surveys.Add(thisSurvey);
                _db.SaveChanges();
            }

            // Success.
            return true;
        }
    }
}