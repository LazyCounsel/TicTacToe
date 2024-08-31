using System;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Name = "The TiC TaC Toe";
            this.Size = new Size(520, 520);

            {

                Button button1 = new Button();
                Button button2 = new Button();
                Button button3 = new Button();
                Button button4 = new Button();
                Button button5 = new Button();
                Button button6 = new Button();
                Button button7 = new Button();
                Button button8 = new Button();
                Button button9 = new Button();

                bool PCTurn = false;

                // Расставляем кнопки (расставлено кодом без драгндропа)
                button1.Text = " ";
                button1.Size = new System.Drawing.Size(100, 100);
                button1.Location = new System.Drawing.Point(100, 100);

                button2.Text = " ";
                button2.Size = new System.Drawing.Size(100, 100);
                button2.Location = new System.Drawing.Point(200, 100);

                button3.Text = " ";
                button3.Size = new System.Drawing.Size(100, 100);
                button3.Location = new System.Drawing.Point(300, 100);

                button4.Text = " ";
                button4.Size = new System.Drawing.Size(100, 100);
                button4.Location = new System.Drawing.Point(100, 200);

                button5.Text = " ";
                button5.Size = new System.Drawing.Size(100, 100);
                button5.Location = new System.Drawing.Point(200, 200);

                button6.Text = " ";
                button6.Size = new System.Drawing.Size(100, 100);
                button6.Location = new System.Drawing.Point(300, 200);

                button7.Text = " ";
                button7.Size = new System.Drawing.Size(100, 100);
                button7.Location = new System.Drawing.Point(100, 300);

                button8.Text = " ";
                button8.Size = new System.Drawing.Size(100, 100);
                button8.Location = new System.Drawing.Point(200, 300);

                button9.Text = " ";
                button9.Size = new System.Drawing.Size(100, 100);
                button9.Location = new System.Drawing.Point(300, 300);

                button1.Click += new EventHandler(Button1_Click);
                button2.Click += new EventHandler(Button2_Click);
                button3.Click += new EventHandler(Button3_Click);
                button4.Click += new EventHandler(Button4_Click);
                button5.Click += new EventHandler(Button5_Click);
                button6.Click += new EventHandler(Button6_Click);
                button7.Click += new EventHandler(Button7_Click);
                button8.Click += new EventHandler(Button8_Click);
                button9.Click += new EventHandler(Button9_Click);

                this.Controls.Add(button1);
                this.Controls.Add(button2);
                this.Controls.Add(button3);
                this.Controls.Add(button4);
                this.Controls.Add(button5);
                this.Controls.Add(button6);
                this.Controls.Add(button7);
                this.Controls.Add(button8);
                this.Controls.Add(button9);

                void WinCheck()
                {
                    if (((button1.Text == "X") && (button2.Text == "X") && (button3.Text == "X")) ||
                       ((button4.Text == "X") && (button5.Text == "X") && (button6.Text == "X")) ||
                       ((button7.Text == "X") && (button8.Text == "X") && (button9.Text == "X")) ||
                       ((button1.Text == "X") && (button4.Text == "X") && (button7.Text == "X")) ||
                       ((button2.Text == "X") && (button5.Text == "X") && (button8.Text == "X")) ||
                       ((button3.Text == "X") && (button6.Text == "X") && (button9.Text == "X")) ||
                       ((button1.Text == "X") && (button5.Text == "X") && (button9.Text == "X")) ||
                       ((button3.Text == "X") && (button5.Text == "X") && (button7.Text == "X")))

                    {
                        MessageBox.Show("The Winner Is You!");
                        Application.Exit();
                    }
                }

                void LoseCheck()
                {

                    if (((button1.Text == "O") && (button2.Text == "O") && (button3.Text == "O")) ||
                       ((button4.Text == "O") && (button5.Text == "O") && (button6.Text == "O")) ||
                       ((button7.Text == "O") && (button8.Text == "O") && (button9.Text == "O")) ||
                       ((button1.Text == "O") && (button4.Text == "O") && (button7.Text == "O")) ||
                       ((button2.Text == "O") && (button5.Text == "O") && (button8.Text == "O")) ||
                       ((button3.Text == "O") && (button6.Text == "O") && (button9.Text == "O")) ||
                       ((button1.Text == "O") && (button5.Text == "O") && (button9.Text == "O")) ||
                       ((button3.Text == "O") && (button5.Text == "O") && (button7.Text == "O")))

                    {
                        MessageBox.Show("Вы проиграли");
                        Application.Exit();
                    }
                }
                void Draw() { 

                       if ((button1.Text != " ") && (button2.Text != " ") && (button3.Text != " ")&&
                       ((button4.Text != " ") && (button5.Text != " ") && (button6.Text != " "))&&
                       ((button7.Text != " ") && (button8.Text != " ") && (button9.Text != " ")))
                     
                    {
                        MessageBox.Show("Ничья");
                        Application.Exit();
                    }
                }

                void ArtificalIdiot()
                {
                    //Занимаем центральную позицию, если игрок ее не взял
                    if ((button5.Text != "X") && (button5.Text != "O"))
                    {
                        button5.Text = "O";
                        PCTurn = false;
                    }

                    //Победные ходы
                    if ((button1.Text == "O") && (button2.Text == "O") && (button3.Text == " ") && (PCTurn == true))
                    {
                        button3.Text = "O";
                        PCTurn = false;
                    }

                    if ((button2.Text == "O") && (button3.Text == "O") && (button1.Text == " ") && (PCTurn == true))
                    {
                        button1.Text = "O";
                        PCTurn = false;
                    }

                    if ((button1.Text == "O") && (button3.Text == "O") && (button2.Text == " ") && (PCTurn == true))
                    {
                        button2.Text = "O";
                        PCTurn = false;
                    }

                    if ((button4.Text == "O") && (button5.Text == "O") && (button6.Text == " ") && (PCTurn == true))
                    {
                        button6.Text = "O";
                        PCTurn = false;
                    }

                    if ((button5.Text == "O") && (button6.Text == "O") && (button4.Text == " ") && (PCTurn == true))
                    {
                        button4.Text = "O";
                        PCTurn = false;
                    }

                    if ((button7.Text == "O") && (button8.Text == "O") && (button9.Text == " ") && (PCTurn == true))
                    {
                        button9.Text = "O";
                        PCTurn = false;
                    }

                    if ((button8.Text == "O") && (button9.Text == "O") && (button7.Text == " ") && (PCTurn == true))
                    {
                        button7.Text = "O";
                        PCTurn = false;
                    }

                    if ((button7.Text == "O") && (button9.Text == "O") && (button8.Text == " ") && (PCTurn == true))
                    {
                        button8.Text = "O";
                        PCTurn = false;
                    }

                    if ((button1.Text == "O") && (button4.Text == "O") && (button7.Text == " ") && (PCTurn == true))
                    {
                        button7.Text = "O";
                        PCTurn = false;
                    }

                    if ((button1.Text == "O") && (button7.Text == "O") && (button4.Text == " ") && (PCTurn == true))
                    {
                        button4.Text = "O";
                        PCTurn = false;
                    }

                    if ((button4.Text == "O") && (button7.Text == "O") && (button1.Text == " ") && (PCTurn == true))
                    {
                        button1.Text = "O";
                        PCTurn = false;
                    }

                    if ((button8.Text == "O") && (button5.Text == "O") && (button2.Text == " ") && (PCTurn == true))
                    {
                        button2.Text = "O";
                        PCTurn = false;
                    }

                    if ((button5.Text == "O") && (button2.Text == "O") && (button8.Text == " ") && (PCTurn == true))
                    {
                        button8.Text = "O";
                        PCTurn = false;
                    }

                    if ((button9.Text == "O") && (button6.Text == "O") && (button3.Text == " ") && (PCTurn == true))
                    {
                        button3.Text = "O";
                        PCTurn = false;
                    }

                    if ((button9.Text == "O") && (button3.Text == "O") && (button6.Text == " ") && (PCTurn == true))
                    {
                        button6.Text = "O";
                        PCTurn = false;
                    }

                    if ((button3.Text == "O") && (button6.Text == "O") && (button9.Text == " ") && (PCTurn == true))
                    {
                        button9.Text = "O";
                        PCTurn = false;
                    }

                    if ((button7.Text == "O") && (button5.Text == "O") && (button3.Text == " ") && (PCTurn == true))
                    {
                        button3.Text = "O";
                        PCTurn = false;
                    }

                    if ((button1.Text == "O") && (button5.Text == "O") && (button9.Text == " ") && (PCTurn == true))
                    {
                        button9.Text = "O";
                        PCTurn = false;
                    }

                    if ((button5.Text == "O") && (button9.Text == "O") && (button1.Text == " ") && (PCTurn == true))
                    {
                        button1.Text = "O";
                        PCTurn = false;
                    }

                    if ((button3.Text == "O") && (button5.Text == "O") && (button7.Text == " ") && (PCTurn == true))
                    {
                        button7.Text = "O";
                        PCTurn = false;
                    }

                    //Защитные ходы
                    if ((button1.Text == "X") && (button2.Text == "X") && (button3.Text == " ") && (PCTurn == true))
                    {
                        button3.Text = "O";
                        PCTurn = false;
                    }

                    if ((button2.Text == "X") && (button3.Text == "X") && (button1.Text == " ") && (PCTurn == true))
                    {
                        button1.Text = "O";
                        PCTurn = false;
                    }

                    if ((button1.Text == "X") && (button3.Text == "X") && (button2.Text == " ") && (PCTurn == true))
                    {
                        button2.Text = "O";
                        PCTurn = false;
                    }

                    if ((button4.Text == "X") && (button5.Text == "X") && (button6.Text == " ") && (PCTurn == true))
                    {
                        button6.Text = "O";
                        PCTurn = false;
                    }

                    if ((button5.Text == "X") && (button6.Text == "X") && (button4.Text == " ") && (PCTurn == true))
                    {
                        button4.Text = "O";
                        PCTurn = false;
                    }

                    if ((button7.Text == "X") && (button8.Text == "X") && (button9.Text == " ") && (PCTurn == true))
                    {
                        button9.Text = "O";
                        PCTurn = false;
                    }

                    if ((button8.Text == "X") && (button9.Text == "X") && (button7.Text == " ") && (PCTurn == true))
                    {
                        button7.Text = "O";
                        PCTurn = false;
                    }

                    if ((button7.Text == "X") && (button9.Text == "X") && (button8.Text == " ") && (PCTurn == true))
                    {
                        button8.Text = "O";
                        PCTurn = false;
                    }

                    if ((button1.Text == "X") && (button4.Text == "X") && (button7.Text == " ") && (PCTurn == true))
                    {
                        button7.Text = "O";
                        PCTurn = false;
                    }

                    if ((button1.Text == "X") && (button7.Text == "X") && (button4.Text == " ") && (PCTurn == true))
                    {
                        button4.Text = "O";
                        PCTurn = false;
                    }

                    if ((button4.Text == "X") && (button7.Text == "X") && (button1.Text == " ") && (PCTurn == true))
                    {
                        button1.Text = "O";
                        PCTurn = false;
                    }

                    if ((button8.Text == "X") && (button5.Text == "X") && (button2.Text == " ") && (PCTurn == true))
                    {
                        button2.Text = "O";
                        PCTurn = false;
                    }

                    if ((button5.Text == "X") && (button2.Text == "X") && (button8.Text == " ") && (PCTurn == true))
                    {
                        button8.Text = "O";
                        PCTurn = false;
                    }

                    if ((button9.Text == "X") && (button6.Text == "X") && (button3.Text == " ") && (PCTurn == true))
                    {
                        button3.Text = "O";
                        PCTurn = false;
                    }

                    if ((button9.Text == "X") && (button3.Text == "X") && (button6.Text == " ") && (PCTurn == true))
                    {
                        button6.Text = "O";
                        PCTurn = false;
                    }

                    if ((button3.Text == "X") && (button6.Text == "X") && (button9.Text == " ") && (PCTurn == true))
                    {
                        button9.Text = "O";
                        PCTurn = false;
                    }

                    if ((button7.Text == "X") && (button5.Text == "X") && (button3.Text == " ") && (PCTurn == true))
                    {
                        button3.Text = "O";
                        PCTurn = false;
                    }

                    if ((button1.Text == "X") && (button5.Text == "X") && (button9.Text == " ") && (PCTurn == true))
                    {
                        button9.Text = "O";
                        PCTurn = false;
                    }

                    if ((button5.Text == "X") && (button9.Text == "X") && (button1.Text == " ") && (PCTurn == true))
                    {
                        button1.Text = "O";
                        PCTurn = false;
                    }

                    if ((button3.Text == "X") && (button5.Text == "X") && (button7.Text == " ") && (PCTurn == true))
                    {
                        button7.Text = "O";
                        PCTurn = false;
                    }

                    //ходы, когда явных позиций нет

                    if ((button1.Text == " ") && (PCTurn == true))
                    {
                        button1.Text = "O";
                        PCTurn = false;
                    }

                    if ((button2.Text == " ") && (PCTurn == true))
                    {
                        button2.Text = "O";
                        PCTurn = false;
                    }

                    if ((button3.Text == " ") && (PCTurn == true))
                    {
                        button3.Text = "O";
                        PCTurn = false;
                    }

                    if ((button4.Text == " ") && (PCTurn == true))
                    {
                        button4.Text = "O";
                        PCTurn = false;
                    }

                    if ((button5.Text == " ") && (PCTurn == true))
                    {
                        button5.Text = "O";
                        PCTurn = false;
                    }

                    if ((button6.Text == " ") && (PCTurn == true))
                    {
                        button6.Text = "O";
                        PCTurn = false;
                    }

                    if ((button7.Text == " ") && (PCTurn == true))
                    {
                        button7.Text = "O";
                        PCTurn = false;
                    }

                    if ((button8.Text == " ") && (PCTurn == true))
                    {
                        button8.Text = "O";
                        PCTurn = false;
                    }

                    if ((button9.Text == " ") && (PCTurn == true))
                    {
                        button9.Text = "O";
                        PCTurn = false;
                    }

                }

                void Button1_Click(object sender, EventArgs e)
                {
                    if ((button1.Text != "X")&&(button1.Text != "O"))
                    {
                        button1.Text = "X";
                        PCTurn = true;
                        ArtificalIdiot();
                    }
                    WinCheck();
                    LoseCheck();
                    Draw();
                }

                void Button2_Click(object sender, EventArgs e)
                {
                    if ((button2.Text != "X") && (button2.Text != "O"))
                    {
                        button2.Text = "X";
                        PCTurn = true;
                        ArtificalIdiot();
                    }
                    WinCheck();
                    LoseCheck();
                    Draw();
                }

                void Button3_Click(object sender, EventArgs e)
                {
                    if ((button3.Text != "X") && (button3.Text != "O"))
                    {
                        button3.Text = "X";
                        PCTurn = true;
                        ArtificalIdiot();
                    }
                    WinCheck();
                    LoseCheck();
                    Draw();
                }

                void Button4_Click(object sender, EventArgs e)
                {
                    if ((button4.Text != "X") && (button4.Text != "O"))
                    {
                        button4.Text = "X";
                        PCTurn = true;
                        ArtificalIdiot();
                    }
                    WinCheck();
                    LoseCheck();
                    Draw();
                }

                void Button5_Click(object sender, EventArgs e)
                {
                    if ((button5.Text != "X") && (button5.Text != "O"))
                    {
                        button5.Text = "X";
                        PCTurn = true;
                        ArtificalIdiot();
                    }
                    WinCheck();
                    LoseCheck();
                    Draw();
                }

                void Button6_Click(object sender, EventArgs e)
                {
                    if ((button6.Text != "X") && (button6.Text != "O"))
                    {
                        button6.Text = "X";
                        PCTurn = true;
                        ArtificalIdiot();
                    }
                    WinCheck();
                    LoseCheck();
                    Draw();
                }

                void Button7_Click(object sender, EventArgs e)
                {
                    if ((button7.Text != "X") && (button7.Text != "O"))
                    {
                        button7.Text = "X";
                        PCTurn = true;
                        ArtificalIdiot();
                    }
                    WinCheck();
                    LoseCheck();
                    Draw();
                }

                void Button8_Click(object sender, EventArgs e)
                {
                    if ((button8.Text != "X") && (button8.Text != "O"))
                    {
                        button8.Text = "X";
                        PCTurn = true;
                        ArtificalIdiot();
                    }
                    WinCheck();
                    LoseCheck();
                    Draw();
                }

                void Button9_Click(object sender, EventArgs e)
                {
                    if ((button9.Text != "X") && (button9.Text != "O"))
                    {
                        button9.Text = "X";
                        PCTurn = true;
                        ArtificalIdiot();
                    }
                    WinCheck();
                    LoseCheck();
                    Draw();
                }

            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
