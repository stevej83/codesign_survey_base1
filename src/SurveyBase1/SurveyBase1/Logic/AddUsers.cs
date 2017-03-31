using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SurveyBase1.Models;

namespace SurveyBase1.Logic
{
    public class AddUsers
    {
        public bool AddUser(string userID)
        {
            var thisUser = new User();
            thisUser.UserID = userID;
            thisUser.UserName = "";
            thisUser.Phone = "";
            thisUser.Email = "";
            thisUser.Wechat = "";
            thisUser.DOB = DateTime.MinValue;
            thisUser.IsBachelor = false;
            thisUser.BachelorUniversity = "";
            thisUser.BachelorDegreeDetail = "";

            using (SurveyContext _db = new SurveyContext())
            {
                // Add user to DB
                _db.Users.Add(thisUser);
                _db.SaveChanges();
            }

            // Success.
            return true;
        }
    }
}