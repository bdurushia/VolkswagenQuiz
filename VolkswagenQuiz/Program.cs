using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
using System.Data;
using VolkwagenQuiz;

namespace VolkswagenQuiz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            string connString = config.GetConnectionString("DefaultConnection");

            IDbConnection conn = new MySqlConnection(connString);

            var questionRepo = new QuestionRepository(conn);

            var questions = questionRepo.GetAllQuestions();

            foreach (Question question in questions)
            {
                Console.WriteLine($"Question {question.Question_ID}: {question.Question_Text}\n" +
                    $"A: {question.Answer_A}\nB: {question.Answer_B}\nC: {question.Answer_C}\nD: {question.Answer_D}");
            }

            //Console.WriteLine("Welcome to the Volkswagen Quiz!\nPress Enter to Start!");
            //Console.ReadLine();

            //var question1 = new Question()
            //{
            //    QuestionText = "Question 1: Who designed the VW Beetle?\n"
            //};

            //question1.Answers.Add(("A. Ferdinand Porsche", true));
            //question1.Answers.Add(("B. Josef Ganz", false));
            //question1.Answers.Add(("C. Heinrich Stein", false));
            //question1.Answers.Add(("D. Adolf Hitler", false));

            //question1.PrintQuestion();
            //question1.PrintAnswer();
            //NextQuestion();

            //var question2 = new Question()
            //{
            //    QuestionText = "Question 2: When was Volkswagen founded?\n"
            //};

            //question2.Answers.Add(("A. 1942", false));
            //question2.Answers.Add(("B. 1951", false));
            //question2.Answers.Add(("C. 1937", true));
            //question2.Answers.Add(("D. 1945", false));

            //question2.PrintQuestion();
            //question2.PrintAnswer();
            //NextQuestion();
        }

        public static void NextQuestion()
        {
            Console.ReadLine();
            Console.ResetColor();
            Console.Clear();
        }
    }
}
