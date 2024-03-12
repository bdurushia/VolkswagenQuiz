namespace VolkwagenQuiz
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

            var correctAnswer = question1.Answers[0];

            // Console.WriteLine(correctAnswer.Item1);
            // Console.WriteLine(correctAnswer.Item2);

            // ToDo - Find Correct Answer - Loop?

            question1.PrintQuestion();
            //question1.PrintAnswer(correctAnswer);

            var question2 = new Question() {QuestionText = "Question 2"};

            //question2.Answers.Add("Q2 Answer");

            //Console.WriteLine(question2.Answers[0]);
        }
    }
}
