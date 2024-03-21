using BusinessObject;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess {
    public class ExamDAO {
        public static List<Exam> getAllExams() {
            List<Exam> list = new List<Exam>();
            try {
                using Prn211ProjectContext context = new Prn211ProjectContext();
                list = context.Exams.ToList();
            }
            catch (Exception ex) {
                throw new Exception(ex.Message);
            }

            return list;

        }

        public static double GetScore(string userId, int ExamId, string subjectId) {
            int numberOfCorrect = 0;
            double score = 0;
            List<Test> tests = TestDAO.GetListTest(subjectId, ExamId);
            Test test = null; ;
            try {
                using Prn211ProjectContext context = new Prn211ProjectContext();

                foreach (var item in tests)
                {
                    TestDetail detail = context.TestDetails.FirstOrDefault(x => x.TestId == item.TestId && x.UserId == userId);
                    if(detail != null) {
                        test = item; break;
                    }
                }
                if(test != null) {
                    List<TestDetail> testDetails = TestDetailDAO.GetTestDetails(userId,test.TestId);
                    foreach (var item in testDetails)
                    {
                        int questionId = item.QuestionId;
                        int rightAnswer = OptionDAO.GetRightAnswer(questionId);
                        if(item.OptionChoosen == rightAnswer) {
                            numberOfCorrect++;
                        }
                    }

                    int numberOfQuestion = (int)test.NumberOfQuestion;
                    score = (numberOfQuestion / 10) * numberOfCorrect;
                    return Math.Round(score, 1);
                }
            }
            catch (Exception ex) {
                throw new Exception(ex.Message);
            }
            return score;
        }
    }
}
