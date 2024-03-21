using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess {
    public class TestDetailDAO {
        public static void AddNewTestDetail(TestDetail testDetail) {
            try {
                TestDetail _testDetail = GetTestDetail(testDetail.TestId, 
                    testDetail.UserId, testDetail.QuestionId
                    );
                if (_testDetail == null) {
                    using var context = new Prn211ProjectContext();
                    context.TestDetails.Add(testDetail);
                    context.SaveChanges();
                }
                else {
                    throw new Exception("The TestDetail is already exists.");
                }
            }
            catch (Exception ex) {
                throw new Exception(ex.Message);
            }
        }


        public static int GetChoosenOption(int TestId, string userId, int questionId) {
            try {
                using Prn211ProjectContext context = new Prn211ProjectContext();

                if(GetTestDetail(TestId, userId, questionId).OptionChoosen != null) {
                    return (int)GetTestDetail(TestId, userId, questionId).OptionChoosen;
                }
            }
            catch (Exception ex) {

                throw new Exception(ex.Message);
            }

            return 0;
        }

        public static List<TestDetail> GetTestDetails(string userId, int testId) {
            List<TestDetail> testDetails = new List<TestDetail>();

            try {
                using Prn211ProjectContext context = new Prn211ProjectContext();
                testDetails = context.TestDetails.Where(td => td.UserId == userId && td.TestId == testId).ToList();
            }
            catch (Exception ex) {

                throw new Exception(ex.Message);
            }

            return testDetails;
        }

        public static List<int> GetListQuestionID(int TestId) {
            List<int> questionIds = new List<int> ();
            try {
                using Prn211ProjectContext context = new Prn211ProjectContext();
                questionIds = context.TestDetails.Where(td => td.TestId == TestId)
                    .Select(td => td.QuestionId).Distinct().ToList();
            }
            catch (Exception ex) {

                throw new Exception(ex.Message);
            }

            return questionIds;
        }

        public static List<Question> GetListQuestionInTestDetail(int TestId) {
            List<Question> questions = new List<Question>();

            try {
                using Prn211ProjectContext context = new Prn211ProjectContext();
                var questionIds = GetListQuestionID (TestId);
                foreach (var item in questionIds)
                {
                    questions.Add(QuestionDAO.getQuestionById(item));
                }
            }
            catch (Exception ex) {

                throw new Exception(ex.Message);
            }

            return questions;
        }

        public static void UpdateTestDetail(TestDetail testDetail) {
            try {
                using Prn211ProjectContext context = new Prn211ProjectContext();

                context.TestDetails.Update(testDetail);
                context.SaveChanges();
            }
            catch (Exception ex) {

                throw new Exception(ex.Message);
            }
        }

        public static TestDetail GetTestDetail(int TestId, string userId, int questionId) {
            TestDetail testDetail = null;
            try {
                using var context = new Prn211ProjectContext();
                testDetail = context.TestDetails.SingleOrDefault(o => o.TestId == TestId
                && o.UserId == userId && o.QuestionId == questionId
                );
            }
            catch (Exception ex) {

                throw new Exception(ex.Message);
            }
            return testDetail;
        }

        public static int GetNumberOfChoosen(int testId, string userID) {
            int numberOfChoosen = 0;
            try {
                using var context = new Prn211ProjectContext();
                numberOfChoosen = context.TestDetails.Count(x => x.OptionChoosen != 0);
            }
            catch (Exception ex) {

                throw new Exception(ex.Message);
            }


            return numberOfChoosen;
        }
    }
}
