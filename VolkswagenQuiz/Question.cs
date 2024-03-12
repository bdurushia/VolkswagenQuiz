using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VolkwagenQuiz
{
    public class Question
    {
        public string QuestionText { get; set; }
        
        // Tuples - Two things that are bound together
        public List<(string, bool)> Answers { get; set; } = new List<(string, bool)>();

        public void PrintQuestion()
        {
            Console.WriteLine(QuestionText);
            Console.WriteLine($"{Answers[0]}\n{Answers[1]}\n{Answers[2]}\n{Answers[3]}\n");
        }

        public void PrintAnswer(string correctAnswer)
        {
            var userAnswer = Console.ReadLine().ToLower();
            Console.WriteLine(userAnswer == correctAnswer ? "Correct!" : "Incorrect");
        }
    }
}
