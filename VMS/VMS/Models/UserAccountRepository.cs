using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VMS.Models;

namespace VMS.Models
{
    public static class UserAccountRepository
    {
        private static List<UserAccount> input = new List<UserAccount>();
        public static IEnumerable<UserAccount> Input
        {
            get
            {
                return input;
            }
        }
        public static void AddInput(UserAccount user)
        {
            input.Add(user);
        }
    }
}
