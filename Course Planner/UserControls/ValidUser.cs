using Course_Planner.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Course_Planner.UserControls
{
    

    public class ValidUser
    {
       

        private ApplicationDbContext _context;

        public ValidUser()
        {
            _context = new ApplicationDbContext();
        }

        public int FindId(string username)
        {
            int currentId = checkforid(username);
            //check if this email is in the db
            //int currentId = 0;
            //foreach (var thisuser in _context.User)
            //{
            //    if (thisuser.Email == username)
            //    {
            //        currentId = thisuser.UserId;
            //    }
                
            //}
            // if currentId is still 0 after checking each row then user doesnt exist and a new user needs to added
            if (currentId == 0 && username != "")
            {
              
                Users NewUser = new Users();
                NewUser.Email = username;
                NewUser.DOB = DateTime.Now;
                _context.User.Add(NewUser);
                _context.SaveChanges();
                currentId = checkforid(username);
            }
            return currentId;
        }

        private int checkforid(string UserEmail)
        {
            int currentId = 0;
            foreach (var thisuser in _context.User)
            {
                if (thisuser.Email == UserEmail && thisuser.Email !="")
                {
                    currentId = thisuser.UserId;
                }

            }
            return currentId;
        }


        
    }
}