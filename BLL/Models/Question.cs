using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Models
{
    public class Question
    {
        public string QuestionId { get; }
        public string TestId { get; set; }
        public string Text { get; set; }
        public bool Type { get; set; }
        public float Point { get; set; }
        public string Choices { get; set; }
        public string CorrectAnswer { get; set; }

        public Question()
        {

        }
        public Question(string questionId, string testId, string text, bool type, float point, string choices, string correctAnswer)
        {
            QuestionId = questionId;
            TestId = testId;
            Text = text;
            Type = type;
            Point = point;
            Choices = choices;
            CorrectAnswer = correctAnswer;
        }
        public Question(DataRow row)
        {
            QuestionId = row["question_id"].ToString();
            TestId = row["test_id"].ToString();
            Text = row["text"].ToString();
            Type = (bool)row["type"];
            Point = (float)row["point"];
            Choices = row["choices"].ToString();
            CorrectAnswer = row["correct_answer"].ToString();
        }
    }
}
