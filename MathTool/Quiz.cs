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

            questions[5, 0] = "2 + 2 = _";
            questions[5, 1] = "*4";
            questions[5, 2] = "3";
            questions[5, 3] = "2";
            questions[5, 4] = "1";
            //
            questions[6, 0] = "5 / 5 + (20-5) = _";
            questions[6, 1] = "4";
            questions[6, 2] = "*16";
            questions[6, 3] = "10";
            questions[6, 4] = "20";
            //
            questions[7, 0] = "5 x 5 + 10 = _";
            questions[7, 1] = "*35";
            questions[7, 2] = "250";
            questions[7, 3] = "50";
            questions[7, 4] = "25";
            //
            questions[8, 0] = "5 - 10 = _";
            questions[8, 1] = "*-5";
            questions[8, 2] = "-4";
            questions[8, 3] = "5";
            questions[8, 4] = "0";
            //
            questions[9, 0] = "50 x 50 = _";
            questions[9, 1] = "250";
            questions[9, 2] = "5000";
            questions[9, 3] = "*2500";
            questions[9, 4] = "2000";

            questions[10, 0] = "2 + 2 = _";
            questions[10, 1] = "*4";
            questions[10, 2] = "3";
            questions[10, 3] = "2";
            questions[10, 4] = "1";
            //
            questions[11, 0] = "5 / 5 + (20-5) = _";
            questions[11, 1] = "4";
            questions[11, 2] = "*16";
            questions[11, 3] = "10";
            questions[11, 4] = "20";
            //
            questions[12, 0] = "5 x 5 + 10 = _";
            questions[12, 1] = "*35";
            questions[12, 2] = "250";
            questions[12, 3] = "50";
            questions[12, 4] = "25";
            //
            questions[13, 0] = "5 - 10 = _";
            questions[13, 1] = "*-5";
            questions[13, 2] = "-4";
            questions[13, 3] = "5";
            questions[13, 4] = "0";
            //
            questions[14, 0] = "50 x 50 = _";
            questions[14, 1] = "250";
            questions[14, 2] = "5000";
            questions[14, 3] = "*2500";
            questions[14, 4] = "2000";


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
