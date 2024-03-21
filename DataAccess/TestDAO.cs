using BusinessObject;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace DataAccess {
    public class TestDAO {
        public static int GetMaxId() {
            try {
                using Prn211ProjectContext context = new Prn211ProjectContext();
                if (context.Tests.Any()) {
                    return context.Tests.Max(x => x.TestId);
                }
            }
            catch (Exception ex) {

                throw new Exception(ex.Message);
            }
            return 0;
        }

        public static IEnumerable<Object> GetListTest(int examId, string subjectId, DateTime fromSearch, DateTime toSearch) {
            using (Prn211ProjectContext context = new Prn211ProjectContext()) {
                var tests = (from t in context.Tests
                                 join e in context.Exams on t.ExamId equals e.ExamId
                                 where e.ExamId == examId && t.SubjectId == subjectId && t.CreatedDate >= fromSearch.Date
                                    && t.CreatedDate <= toSearch.Date
                                 select new {
                                    TestID = t.TestId,
                                    TestCode = t.TestCode,
                                    Subject = t.SubjectId,
                                    Exam = e.ExamName,
                                    PaperNo = t.PaperNo,
                                    Status = t.Status == true ? "ON":"OFF",
                                    TestTime = t.TestTime,
                                    NumberOfQuestion = t.NumberOfQuestion,
                                    CreatedDate = t.CreatedDate,
                                 }).ToList();
                return tests;
            }
        }

        public static bool isTestHaveQuestion(string testCode) {
            Test thisTest = GetTestByCode(testCode);

            int examId = (int)thisTest.ExamId;
            string subjectId = thisTest.SubjectId;
            List<Question> questions = null;
            try {
                using var context = new Prn211ProjectContext();
                questions = context.Questions.
                    Where(q => q.SubjectId == subjectId && q.ExamId == examId).ToList();
            }
            catch (Exception ex) {

                throw new Exception(ex.Message);
            }

            if(questions != null && questions.Count() >= thisTest.NumberOfQuestion) {
                return true;
            }

            return false;
        }


        public static Test GetTestByCode(string code) {
            Test test = null;
            try {
                using var context = new Prn211ProjectContext();
                test = context.Tests.SingleOrDefault(o => o.TestCode == code);
            }
            catch (Exception ex) {

                throw new Exception(ex.Message);
            }
            return test;
        }

        public static List<Test> GetListTest(string subjectId, int examId) {
            List<Test> tests = new List<Test>();
            try {
                using var context = new Prn211ProjectContext();
                tests = context.Tests.Where(t => t.SubjectId == subjectId && t.ExamId ==  examId).ToList();
            }
            catch (Exception ex) {

                throw new Exception(ex.Message);
            }
            return tests;
        }

        public static bool isTestDoneByAnother(int testID) {
            TestDetail testDetail = null;
            try {
                using var context = new Prn211ProjectContext();
                testDetail = context.TestDetails.FirstOrDefault(o => o.TestId == testID);
                if(testDetail != null) {
                    return true;
                }
            }
            catch (Exception ex) {

                throw new Exception(ex.Message);
            }
            return false;
        }

        public static bool isUserDoneThisTest(string userID, string testCode) {
            Test test = GetTestByCode(testCode);
            TestDetail testDetail = null;
            try {
                using var context = new Prn211ProjectContext();
                testDetail = context.TestDetails.FirstOrDefault(o => o.UserId == userID && o.TestId == test.TestId);
                if (testDetail != null) {
                    return true;
                }
            }
            catch (Exception ex) {

                throw new Exception(ex.Message);
            }
            return false;
        }

        public static bool isUserDoneThisExam(string userId, int examId, string subjectId) {
            List<Test> tests = TestDAO.GetListTest(subjectId, examId);
            foreach (var item in tests)
            {
                if(isUserDoneThisTest(userId, item.TestCode)) {
                    return true;
                }
            }
            return false;
        }

        public static Test GetTestById(int TestId) {
            Test test = null;
            try {
                using var context = new Prn211ProjectContext();
                test = context.Tests.SingleOrDefault(o => o.TestId == TestId);
            }
            catch (Exception ex) {

                throw new Exception(ex.Message);
            }
            return test;
        }

        public static void AddNewTest(Test test) {
            try {
                Test _test = GetTestById(test.TestId);
                if (_test == null && !isTestCodeExist(test.TestCode) && !isPaperNoExist(test)) {
                    using var context = new Prn211ProjectContext();
                    context.Tests.Add(test);
                    context.SaveChanges();
                }
                else {
                    throw new Exception("The test is already exists.");
                }
            }
            catch (Exception ex) {
                throw new Exception(ex.Message);
            }
        }

        public static void UpdateTest(Test test) {
            try {
                if (!isPaperNoExist(test)) {
                    using var context = new Prn211ProjectContext();
                    context.Tests.Update(test);
                    context.SaveChanges();
                }
                else {
                    throw new Exception("Update Fail! Duplicate Test");
                }
            }
            catch (Exception ex) {
                throw;
            }
        }

        public static bool isTestCodeExist(string code) {
            try {
                using var context = new Prn211ProjectContext();
                Test test = context.Tests.FirstOrDefault(x => x.TestCode == code);
                if (test != null) {
                    return true;
                }
            }
            catch (Exception ex) {
                throw new Exception(ex.Message);
            }
            return false;
        }

        public static bool isTestCodeOff(string code) {
            try {
                using var context = new Prn211ProjectContext();
                Test test = context.Tests.FirstOrDefault(x => x.TestCode == code);
                if (test != null && test.Status == false) {
                    return true;
                }
            }
            catch (Exception ex) {
                throw new Exception(ex.Message);
            }
            return false;
        }


        public static bool isPaperNoExist(Test test) {
            try {
                using var context = new Prn211ProjectContext();
                Test _test = context.Tests.FirstOrDefault(x => x.PaperNo == test.PaperNo && x.ExamId == test.ExamId
                && x.SubjectId == test.SubjectId);
                if (_test != null && _test.TestId != test.TestId) {
                    return true;
                }
            }
            catch (Exception ex) {
                throw new Exception(ex.Message);
            }
            return false;
        }
    }

   
}
