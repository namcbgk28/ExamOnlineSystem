using BusinessObject;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess {
    public class QuestionDAO {
        public static IEnumerable<Object> getListQuestions(int examId, string subjectId, string key) {
            using (Prn211ProjectContext context = new Prn211ProjectContext()) {
                var questions = (from qu in context.Questions
                                 join sub in context.Subjects on qu.SubjectId equals sub.SubjectId
                                 join ex in context.Exams on qu.ExamId equals ex.ExamId
                                 where qu.ExamId == examId && sub.SubjectId == subjectId && (qu.QuestionContent.Contains(key)
                                 || sub.SubjectId.Contains(key) || ex.ExamName.Contains(key)
                                 )
                                 select new {
                                     QuestionId = qu.QuestionId,
                                     Content = qu.QuestionContent,
                                     Subject = sub.SubjectId,
                                     ExamName = ex.ExamName
                                 }).ToList();

                return questions;
            }
        }

        public static List<Question> GetRandomNumberOfQuestion(int number, int examId, string subjectId) {
            List<Question> questions = new List<Question>();
            try {
                using var context = new Prn211ProjectContext();
                questions = context.Questions.
                    Where(q => q.SubjectId == subjectId && q.ExamId == examId).
                    OrderBy(x => Guid.NewGuid())
                                   .Take(number)
                                   .ToList();
            }
            catch (Exception ex) {

                throw new Exception(ex.Message);
            }
            return questions;
        }

        public static Question getQuestionById(int questionId) {
            Question question = null;
            try {
                using var context = new Prn211ProjectContext();
                question = context.Questions.SingleOrDefault(o => o.QuestionId == questionId);
            }
            catch (Exception ex) {

                throw new Exception(ex.Message);
            }
            return question;
        }
        public static int getMaxId() {
            try {
                using Prn211ProjectContext context = new Prn211ProjectContext();
                if (context.Questions.Any()) {
                    return context.Questions.Max(x => x.QuestionId);
                }
            }
            catch (Exception ex) {

                throw new Exception(ex.Message);
            }
            return 0;
        }

        

        public static void AddNewQuestion(Question question) {
            try {
                Question _question = getQuestionById(question.QuestionId);
                if (_question == null) {
                    using var context = new Prn211ProjectContext();
                    context.Questions.Add(question);
                    context.SaveChanges();
                }
                else {
                    throw new Exception("The question is already exists.");
                }
            }
            catch (Exception ex) {
                throw new Exception(ex.Message);
            }
        }

        public static void UpdateQuestion(Question question) {
            try {
                Question _question = getQuestionById(question.QuestionId);
                if (_question != null) {
                    using var context = new Prn211ProjectContext();
                    context.Questions.Update(question);
                    context.SaveChanges();
                }
                else {
                    throw new Exception("The question is not already exists.");
                }
            }
            catch (Exception ex) {
                throw new Exception(ex.Message);
            }
        }

    }
}
