using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SurveyBase1.Models;

namespace SurveyBase1.Logic
{
    public class AddGates
    {
        public void AddGate(string gateID, string surveyID)
        {
            var thisGate = new Gate();
            thisGate.QuestionGateID = gateID;
            thisGate.SurveyID = surveyID;

            using (SurveyContext _db = new SurveyContext())
            {
                // Add Survey to DB
                _db.Gates.Add(thisGate);
                _db.SaveChanges();
            }
        }
    }
}