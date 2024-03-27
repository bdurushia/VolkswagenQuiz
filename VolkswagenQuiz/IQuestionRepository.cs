using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VolkwagenQuiz;

namespace VolkswagenQuiz
{
    public interface IQuestionRepository
    {
        public IEnumerable<Question> GetAllQuestions();
    }
}
