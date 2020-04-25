using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;
using System.Data.SqlClient;

namespace MathTool
{
    public partial class Revision : Form
    {
        private Quiz q = new Quiz();
        private List<int> lst = new List<int>();
        private string ans;
        private int score = 0;
        private int number = 1;
        public Revision()
        {
            InitializeComponent();
        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            (new Login()).Show();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            (new Home()).Show();
        }

        private void btnMaterials_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            (new Materials()).Show();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {

            btnOut.Visible = false;
            btnHome.Visible = false;
            btnMaterials.Visible = false;
            btnOpt1.Visible = false;
            btnOpt2.Visible = false;
            btnOpt3.Visible = false;
            btnOpt4.Visible = false;
            txtInfo.Visible = false;
            btnRestart.Visible = false;


            btnStart.Visible = false;
            btnExit.Visible = true;
            scoreLbl.Visible = Visible;
            ans1.Visible = Visible;
            ans2.Visible = Visible;
            ans3.Visible = Visible;
            ans4.Visible = Visible;
            questLbl.Visible = Visible;


            int i = this.getRandom();
            questLbl.Text = q.getQuestion(i);
            //
            ans1.Text = q.getAnswer(i, 1);
            ans2.Text = q.getAnswer(i, 2);
            ans3.Text = q.getAnswer(i, 3);
            ans4.Text = q.getAnswer(i, 4);
            if (Convert.ToString(ans1.Text).StartsWith("*"))
            {
                this.ans = Convert.ToString(ans1.Text).Substring(1, Convert.ToString(ans1.Text).Length - 1);
                ans1.Text = Convert.ToString(ans1.Text).Substring(1, Convert.ToString(ans1.Text).Length - 1);
            }
            else
            {
                if (Convert.ToString(ans2.Text).StartsWith("*"))
                {
                    this.ans = Convert.ToString(ans2.Text).Substring(1, Convert.ToString(ans2.Text).Length - 1);
                    ans2.Text = Convert.ToString(ans2.Text).Substring(1, Convert.ToString(ans2.Text).Length - 1);
                }
                else
                {
                    if (Convert.ToString(ans3.Text).StartsWith("*"))
                    {
                        this.ans = Convert.ToString(ans3.Text).Substring(1, Convert.ToString(ans3.Text).Length - 1);
                        ans3.Text = Convert.ToString(ans3.Text).Substring(1, Convert.ToString(ans3.Text).Length - 1);
                    }
                    else
                    {
                        this.ans = Convert.ToString(ans4.Text).Substring(1, Convert.ToString(ans4.Text).Length - 1);
                        ans4.Text = Convert.ToString(ans4.Text).Substring(1, Convert.ToString(ans4.Text).Length - 1);
                    }
                }
            }


            lst.Add(i);
        }
        public int getRandom()
        {
            Random rnd = new Random();
            int i = rnd.Next(5);
            if (lst.Contains(i) && lst.Count() < 5)
                while (lst.Contains(i))
                    i = rnd.Next(0, 5);
            return i;
        }

        private void ans1_Click(object sender, EventArgs e)
        {
            if (this.number < 5)
            {
                this.number++;
                if (Convert.ToString(ans1.Text) == this.ans)
                    this.score++;
                int i = this.getRandom();
                questLbl.Text = q.getQuestion(i);
                //
                ans1.Text = q.getAnswer(i, 1);
                ans2.Text = q.getAnswer(i, 2);
                ans3.Text = q.getAnswer(i, 3);
                ans4.Text = q.getAnswer(i, 4);
                if (Convert.ToString(ans1.Text).StartsWith("*"))
                {
                    this.ans = Convert.ToString(ans1.Text).Substring(1, Convert.ToString(ans1.Text).Length - 1);
                    ans1.Text = Convert.ToString(ans1.Text).Substring(1, Convert.ToString(ans1.Text).Length - 1);
                }
                else
                {
                    if (Convert.ToString(ans2.Text).StartsWith("*"))
                    {
                        this.ans = Convert.ToString(ans2.Text).Substring(1, Convert.ToString(ans2.Text).Length - 1);
                        ans2.Text = Convert.ToString(ans2.Text).Substring(1, Convert.ToString(ans2.Text).Length - 1);
                    }
                    else
                    {
                        if (Convert.ToString(ans3.Text).StartsWith("*"))
                        {
                            this.ans = Convert.ToString(ans3.Text).Substring(1, Convert.ToString(ans3.Text).Length - 1);
                            ans3.Text = Convert.ToString(ans3.Text).Substring(1, Convert.ToString(ans3.Text).Length - 1);
                        }
                        else
                        {
                            this.ans = Convert.ToString(ans4.Text).Substring(1, Convert.ToString(ans4.Text).Length - 1);
                            ans4.Text = Convert.ToString(ans4.Text).Substring(1, Convert.ToString(ans4.Text).Length - 1);
                        }
                    }
                }
                lst.Add(i);
                scoreLbl.Text = "Score : " + this.score;
            }
            else
            {
                scoreLbl.Visible = false;
                questLbl.Visible = false;
                ans1.Visible = false;
                ans2.Visible = false;
                ans3.Visible = false;
                ans4.Visible = false;
                finalLbl.Visible = Visible;
                finalLbl.Text = "Your score is " + this.score + "/" + number;
                btnRestart.Visible = Visible;
            }
        }

        private void ans2_Click(object sender, EventArgs e)
        {
            if (this.number < 5)
            {
                this.number++;
                if (Convert.ToString(ans2.Text) == this.ans)
                    this.score++;
                int i = this.getRandom();
                questLbl.Text = q.getQuestion(i);
                //
                ans1.Text = q.getAnswer(i, 1);
                ans2.Text = q.getAnswer(i, 2);
                ans3.Text = q.getAnswer(i, 3);
                ans4.Text = q.getAnswer(i, 4);
                if (Convert.ToString(ans1.Text).StartsWith("*"))
                {
                    this.ans = Convert.ToString(ans1.Text).Substring(1, Convert.ToString(ans1.Text).Length - 1);
                    ans1.Text = Convert.ToString(ans1.Text).Substring(1, Convert.ToString(ans1.Text).Length - 1);
                }
                else
                {
                    if (Convert.ToString(ans2.Text).StartsWith("*"))
                    {
                        this.ans = Convert.ToString(ans2.Text).Substring(1, Convert.ToString(ans2.Text).Length - 1);
                        ans2.Text = Convert.ToString(ans2.Text).Substring(1, Convert.ToString(ans2.Text).Length - 1);
                    }
                    else
                    {
                        if (Convert.ToString(ans3.Text).StartsWith("*"))
                        {
                            this.ans = Convert.ToString(ans3.Text).Substring(1, Convert.ToString(ans3.Text).Length - 1);
                            ans3.Text = Convert.ToString(ans3.Text).Substring(1, Convert.ToString(ans3.Text).Length - 1);
                        }
                        else
                        {
                            this.ans = Convert.ToString(ans4.Text).Substring(1, Convert.ToString(ans4.Text).Length - 1);
                            ans4.Text = Convert.ToString(ans4.Text).Substring(1, Convert.ToString(ans4.Text).Length - 1);
                        }
                    }
                }
                lst.Add(i);
                scoreLbl.Text = "Score : " + this.score;
            }
            else
            {
                scoreLbl.Visible = false;
                questLbl.Visible = false;
                ans1.Visible = false;
                ans2.Visible = false;
                ans3.Visible = false;
                ans4.Visible = false;
                finalLbl.Visible = Visible;
                finalLbl.Text = "Your score is " + this.score + "/" + number;
                btnRestart.Visible = Visible;
            }
        }

        private void ans3_Click(object sender, EventArgs e)
        {
            if (this.number < 5)
            {
                this.number++;
                if (Convert.ToString(ans3.Text) == this.ans)
                    this.score++;
                int i = this.getRandom();
                questLbl.Text = q.getQuestion(i);
                //
                ans1.Text = q.getAnswer(i, 1);
                ans2.Text = q.getAnswer(i, 2);
                ans3.Text = q.getAnswer(i, 3);
                ans4.Text = q.getAnswer(i, 4);
                if (Convert.ToString(ans1.Text).StartsWith("*"))
                {
                    this.ans = Convert.ToString(ans1.Text).Substring(1, Convert.ToString(ans1.Text).Length - 1);
                    ans1.Text = Convert.ToString(ans1.Text).Substring(1, Convert.ToString(ans1.Text).Length - 1);
                }
                else
                {
                    if (Convert.ToString(ans2.Text).StartsWith("*"))
                    {
                        this.ans = Convert.ToString(ans2.Text).Substring(1, Convert.ToString(ans2.Text).Length - 1);
                        ans2.Text = Convert.ToString(ans2.Text).Substring(1, Convert.ToString(ans2.Text).Length - 1);
                    }
                    else
                    {
                        if (Convert.ToString(ans3.Text).StartsWith("*"))
                        {
                            this.ans = Convert.ToString(ans3.Text).Substring(1, Convert.ToString(ans3.Text).Length - 1);
                            ans3.Text = Convert.ToString(ans3.Text).Substring(1, Convert.ToString(ans3.Text).Length - 1);
                        }
                        else
                        {
                            this.ans = Convert.ToString(ans4.Text).Substring(1, Convert.ToString(ans4.Text).Length - 1);
                            ans4.Text = Convert.ToString(ans4.Text).Substring(1, Convert.ToString(ans4.Text).Length - 1);
                        }
                    }
                }
                lst.Add(i);
                scoreLbl.Text = "Score : " + this.score;
            }
            else
            {
                scoreLbl.Visible = false;
                questLbl.Visible = false;
                ans1.Visible = false;
                ans2.Visible = false;
                ans3.Visible = false;
                ans4.Visible = false;
                finalLbl.Visible = Visible;
                finalLbl.Text = "Your score is " + this.score + "/" + number;
                btnRestart.Visible = Visible;
            }
        }

        private void ans4_Click(object sender, EventArgs e)
        {
            if (this.number < 20)
            {
                this.number++;
                if (Convert.ToString(ans4.Text) == this.ans)
                    this.score++;
                int i = this.getRandom();
                questLbl.Text = q.getQuestion(i);
                //
                ans1.Text = q.getAnswer(i, 1);
                ans2.Text = q.getAnswer(i, 2);
                ans3.Text = q.getAnswer(i, 3);
                ans4.Text = q.getAnswer(i, 4);
                if (Convert.ToString(ans1.Text).StartsWith("*"))
                {
                    this.ans = Convert.ToString(ans1.Text).Substring(1, Convert.ToString(ans1.Text).Length - 1);
                    ans1.Text = Convert.ToString(ans1.Text).Substring(1, Convert.ToString(ans1.Text).Length - 1);
                }
                else
                {
                    if (Convert.ToString(ans2.Text).StartsWith("*"))
                    {
                        this.ans = Convert.ToString(ans2.Text).Substring(1, Convert.ToString(ans2.Text).Length - 1);
                        ans2.Text = Convert.ToString(ans2.Text).Substring(1, Convert.ToString(ans2.Text).Length - 1);
                    }
                    else
                    {
                        if (Convert.ToString(ans3.Text).StartsWith("*"))
                        {
                            this.ans = Convert.ToString(ans3.Text).Substring(1, Convert.ToString(ans3.Text).Length - 1);
                            ans3.Text = Convert.ToString(ans3.Text).Substring(1, Convert.ToString(ans3.Text).Length - 1);
                        }
                        else
                        {
                            this.ans = Convert.ToString(ans4.Text).Substring(1, Convert.ToString(ans4.Text).Length - 1);
                            ans4.Text = Convert.ToString(ans4.Text).Substring(1, Convert.ToString(ans4.Text).Length - 1);
                        }
                    }
                }
                lst.Add(i);
                scoreLbl.Text = "Score : " + this.score;
            }
            else
            {
                scoreLbl.Visible = false;
                questLbl.Visible = false;
                ans1.Visible = false;
                ans2.Visible = false;
                ans3.Visible = false;
                ans4.Visible = false;
                finalLbl.Visible = Visible;
                finalLbl.Text = "Your score is " + this.score + "/" + number;
                btnRestart.Visible = Visible;

            }
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {        

            this.score = 0;
            scoreLbl.Text = "Score : " + this.score;
            this.number = 1;
            finalLbl.Visible = false;
            lst.Clear();
            btnRestart.Visible = false;
            questLbl.Visible = Visible;
            ans1.Visible = Visible;
            ans2.Visible = Visible;
            ans3.Visible = Visible;
            ans4.Visible = Visible;
            scoreLbl.Visible = Visible;


            //
            int i = this.getRandom();
            questLbl.Text = q.getQuestion(i);
            //
            ans1.Text = q.getAnswer(i, 1);
            ans2.Text = q.getAnswer(i, 2);
            ans3.Text = q.getAnswer(i, 3);
            ans4.Text = q.getAnswer(i, 4);
            if (Convert.ToString(ans1.Text).StartsWith("*"))
            {
                this.ans = Convert.ToString(ans1.Text).Substring(1, Convert.ToString(ans1.Text).Length - 1);
                ans1.Text = Convert.ToString(ans1.Text).Substring(1, Convert.ToString(ans1.Text).Length - 1);
            }
            else
            {
                if (Convert.ToString(ans2.Text).StartsWith("*"))
                {
                    this.ans = Convert.ToString(ans2.Text).Substring(1, Convert.ToString(ans2.Text).Length - 1);
                    ans2.Text = Convert.ToString(ans2.Text).Substring(1, Convert.ToString(ans2.Text).Length - 1);
                }
                else
                {
                    if (Convert.ToString(ans3.Text).StartsWith("*"))
                    {
                        this.ans = Convert.ToString(ans3.Text).Substring(1, Convert.ToString(ans3.Text).Length - 1);
                        ans3.Text = Convert.ToString(ans3.Text).Substring(1, Convert.ToString(ans3.Text).Length - 1);
                    }
                    else
                    {
                        this.ans = Convert.ToString(ans4.Text).Substring(1, Convert.ToString(ans4.Text).Length - 1);
                        ans4.Text = Convert.ToString(ans4.Text).Substring(1, Convert.ToString(ans4.Text).Length - 1);
                    }
                }

                lst.Add(i);

            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            (new Revision()).Show();
        }

        private void btnOut_Click_1(object sender, EventArgs e)
        {
            this.Visible = false;
            (new Login()).Show();
        }
    }
}
