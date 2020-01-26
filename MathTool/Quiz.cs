using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathTool
{
    class Quiz
    {
        private string[,] questions = new string[20, 5];
        public Quiz()
        {
            questions[0, 0] = "2 + 2 = _";
            questions[0, 1] = "*4";
            questions[0, 2] = "3";
            questions[0, 3] = "2";
            questions[0, 4] = "1";
            //
            questions[1, 0] = "5 / 5 + (20-5) = _";
            questions[1, 1] = "4";
            questions[1, 2] = "*16";
            questions[1, 3] = "10";
            questions[1, 4] = "20";
            //
            questions[2, 0] = "5 x 5 + 10 = _";
            questions[2, 1] = "*35";
            questions[2, 2] = "250";
            questions[2, 3] = "50";
            questions[2, 4] = "25";
            //
            questions[3, 0] = "5 - 10 = _";
            questions[3, 1] = "*-5";
            questions[3, 2] = "-4";
            questions[3, 3] = "5";
            questions[3, 4] = "0";
            //
            questions[4, 0] = "50 x 50 = _";
            questions[4, 1] = "250";
            questions[4, 2] = "5000";
            questions[4, 3] = "*2500";
            questions[4, 4] = "2000";

        }
        public string getQuestion(int i)
        {
            return questions[i, 0];
        }
        public string getAnswer(int i, int j)
        {
            return questions[i, j];
        }
    }
}
