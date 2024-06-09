using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Models
{
    public class TakeQuestion
    {
        public string LearnerId { get; set; }
        public string QuestionId { get; set; }
        public double Point { get; set; }
        public string AnswerChoice { get; set; }
        public TakeQuestion()
        {

        }
        public TakeQuestion(string learnerId, string questionId, string answerChoice)
        {
            LearnerId = learnerId;
            QuestionId = questionId;
            AnswerChoice = answerChoice;
        }
        public TakeQuestion(DataRow row)
        {
            LearnerId = row["learner_id"].ToString();
            QuestionId = row["question_id"].ToString();
            AnswerChoice = row["answer_choice"].ToString();
        }
    }

}
