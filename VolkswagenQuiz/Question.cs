using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VolkwagenQuiz
{
    public class Question
    {
        public int Question_ID { get; set; }
        public string Question_Text { get; set; }
        public string Answer_A { get; set; }
        public string Answer_B { get; set; }
        public string Answer_C { get; set; }
        public string Answer_D { get; set; }
        public string Correct_Answer { get; set; }


        // Tuples - Two things that are bound together
        // public List<(string, bool)> Answers { get; set; } = new List<(string, bool)>();

        //public void PrintQuestion()
        //{
        //    Console.WriteLine(QuestionText);
        //    Console.WriteLine($"{Answers[0].Item1}\n{Answers[1].Item1}\n{Answers[2].Item1}\n{Answers[3].Item1}\n");
        //}

        //public void PrintAnswer()
        //{
        //    var userAnswer = Console.ReadLine().ToLower();
        //    bool isCorrect = false;

        //    foreach (var answer in Answers)
        //    {
        //        if (answer.Item2 == true && answer.Item1.ToLower().StartsWith(userAnswer))
        //        { 
        //            isCorrect = true;
        //            break;
        //        }
        //        else
        //        {
        //            isCorrect = false;
        //        }
        //    }

        //    if (isCorrect)
        //    {
        //        Console.ForegroundColor = ConsoleColor.Green;
        //        Console.WriteLine("\nCorrect!\n");
        //    }
        //    else
        //    {
        //        Console.ForegroundColor = ConsoleColor.Red;
        //        Console.WriteLine("\nIncorrect!\n");
        //    }
        //}
    }
}
