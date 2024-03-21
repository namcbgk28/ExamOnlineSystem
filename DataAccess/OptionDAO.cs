using BusinessObject;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess {
    public class OptionDAO {
        public static List<Option> getListAnswers(int questionId) {
            using (Prn211ProjectContext context = new Prn211ProjectContext()) {
                var options = (from o in context.Options
                               where o.QuestionId == questionId
                               select new Option {
                                   QuestionId = o.QuestionId,
                                   OptionContent = o.OptionContent,
                                   RightAnswer = o.RightAnswer,
                                   OptionId = o.OptionId
                               }).ToList();

                return options;
            }
        }

        public static int GetRightAnswer(int questionId) {
            int answer = 0;

            try {
                using Prn211ProjectContext context = new Prn211ProjectContext();
                answer = (int)context.Options.FirstOrDefault(o => o.QuestionId == questionId 
                && o.RightAnswer == true).OptionId;
            }
            catch (Exception ex) {

                throw new Exception(ex.Message);
            }

            return answer;
        }


        public static Option GetOptionById(int optionId) {
            Option option = null;
            try {
                using Prn211ProjectContext context = new Prn211ProjectContext();
                option = context.Options.SingleOrDefault(option => option.OptionId == optionId);
            }
            catch (Exception ex) {

                throw new Exception(ex.Message);
            }
            return option;
        }

        public static int getMaxId() {
            try {
                using Prn211ProjectContext context = new Prn211ProjectContext();
                if (context.Options.Any()) {
                    return context.Options.Max(x => x.OptionId);
                }
            }
            catch (Exception ex) {

                throw new Exception(ex.Message);
            }
            return 0;
        }


        public static void AddNewOption(Option option) {
            try {
                using var context = new Prn211ProjectContext();
                context.Options.Add(option);
                context.SaveChanges();
            }
            catch (Exception ex) {
                throw new Exception(ex.Message);
            }
        }

        public static void Update(Option option) {
            try {
                using var context = new Prn211ProjectContext();
                context.Options.Update(option);
                context.SaveChanges();
            }
            catch (Exception ex) {
                throw new Exception(ex.Message);
            }
        }
    }
}
