using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VolkwagenQuiz;
using Dapper;

namespace VolkswagenQuiz
{
    public class QuestionRepository : IQuestionRepository
    {
        private readonly IDbConnection _conn;

        public QuestionRepository(IDbConnection conn)
        {
            _conn = conn;
        }
        public IEnumerable<Question> GetAllQuestions()
        {
            return _conn.Query<Question>("SELECT * FROM questions;");
        }
    }
}
