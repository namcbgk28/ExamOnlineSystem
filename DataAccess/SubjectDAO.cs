using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess {
    public class SubjectDAO {
        public static List<Subject> getAllSubjects() {
            List<Subject> list = new List<Subject>();
            try {
                using Prn211ProjectContext context = new Prn211ProjectContext();
                list = context.Subjects.ToList();
            }
            catch (Exception ex) {
                throw new Exception(ex.Message);
            }
            
            return list;

        }
    }
}
