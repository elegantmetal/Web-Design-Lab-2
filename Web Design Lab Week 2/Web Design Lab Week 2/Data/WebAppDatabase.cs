using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Web_Design_Lab_Week_2.Models;

namespace Web_Design_Lab_Week_2.Data
{
    public static class WebAppDatabase
    {

        public static List<User> m_users { get; set; }

        static WebAppDatabase()
        {
            m_users = new List<User>();
        }

    }
}