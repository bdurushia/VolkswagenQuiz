using VolkwagenQuiz;

namespace VolkswagenQuiz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Volkswagen Quiz!\nPress Enter to Start!");
            Console.ReadLine();

            var question1 = new Question()
            {
                QuestionText = "Question 1: Who designed the VW Beetle?\n"
            };

            question1.Answers.Add(("A. Ferdinand Porsche", true));
            question1.Answers.Add(("B. Josef Ganz", false));
            question1.Answers.Add(("C. Heinrich Stein", false));
            question1.Answers.Add(("D. Adolf Hitler", false));

            question1.PrintQuestion();
            question1.PrintAnswer();

            var question2 = new Question() 
            {
                QuestionText = "Question 2: When was Volkswagen founded?\n"
            };

            question2.Answers.Add(("A. 1942", false));
            question2.Answers.Add(("B. 1951", false));
            question2.Answers.Add(("C. 1937", true));
            question2.Answers.Add(("D. 1945", false));

            question2.PrintQuestion();
            question2.PrintAnswer();
        }
    }
}
