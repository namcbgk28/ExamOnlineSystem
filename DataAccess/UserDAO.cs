using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject;

namespace DataAccess {

    public class UserDAO {
        private static UserDAO instance = null;
        private static readonly object instanceLock = new object();

        public static UserDAO Instance {
            get {
                lock (instanceLock) {
                    if (instance == null) {
                        instance = new UserDAO();
                    }
                }
                return instance;
            }
        }

        public IEnumerable<User> GetMembersList() {
            var members = new List<User>();
            try {
                using var context = new Prn211ProjectContext();
                members = context.Users.ToList();
            }
            catch (Exception ex) {

                throw new Exception(ex.Message);
            }
            return members;
        }

        public User GetUserByID(string userId) {
            User user = null;
            try {
                using var context = new Prn211ProjectContext();
                user = context.Users.SingleOrDefault(m => m.UserId == userId);
            }
            catch (Exception ex) {

                throw new Exception(ex.Message);
            }
            return user;
        }

        public User GetUserByEmailAndPassword(string email, string password) {
            User user = null;
            try {
                using var context = new Prn211ProjectContext();
                user = context.Users.SingleOrDefault(m => m.Email == email && m.Password == password);
            }
            catch (Exception ex) {

                throw new Exception(ex.Message);
            }
            return user;
        }
    }
}
