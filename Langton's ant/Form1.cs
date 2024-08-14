using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Threading;

namespace Langton_s_ant
{
    public partial class Form1 : Form
    {
        private static int[] AntPosition;
        private static int length = 5;
        private static int numberOfCells = 150;
        private static bool[,] colorStorage;
        private bool ok = true;
        private int iterations = 0;
        private static int[] oldPosition;
        private char direction = 's';
        private delegate void EmptyDelegate();

        public Form1()
        {
            InitializeComponent();


            AntPosition = new int[2];
            AntPosition[0] = numberOfCells / 2;
            AntPosition[1] = numberOfCells / 2;
            oldPosition = new int[2];
            oldPosition[0] = AntPosition[0];
            oldPosition[1] = AntPosition[1];

            colorStorage = new bool[numberOfCells, numberOfCells];

            for (int i = 0; i < numberOfCells; i++)
            {
                for (int j = 0; j < numberOfCells; j++)
                {
                    colorStorage[i, j] = true;
                }
            }
        }

        protected void DoEvents()
        {
            Dispatcher.CurrentDispatcher.Invoke(new EmptyDelegate(delegate { }), DispatcherPriority.Background);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen myPen = new Pen(Color.LightGray);
            Brush myBrushTrue = new SolidBrush(Color.White);
            Brush myBrushFalse = new SolidBrush(Color.Black);
            Brush ant = new SolidBrush(Color.Red);

            for (int i = 0; i < numberOfCells; i++)
            {
                for (int j = 0; j < numberOfCells; j++)
                {
                    if (i == AntPosition[0] && j == AntPosition[1])
                    {
                        //g.DrawRectangle(myPen, 40 + i * length, 40 + j * length, length, length);
                        //g.FillRectangle(ant, (40 + i * length) + 1, (40 + j * length) + 1, length - 2, length - 2);
                        g.FillRectangle(ant, (40 + i * length), (40 + j * length), length, length);
                    }
                    else if (colorStorage[i, j])
                    {
                        //g.DrawRectangle(myPen, 40 + i * length, 40 + j * length, length, length);
                        //g.FillRectangle(myBrushTrue, (40 + i * length) + 1, (40 + j * length) + 1, length - 2, length - 2);
                        g.FillRectangle(myBrushTrue, (40 + i * length), (40 + j * length), length, length);
                    }
                    else
                    {
                        //g.DrawRectangle(myPen, 40 + i * length, 40 + j * length, length, length);
                        //g.FillRectangle(myBrushFalse, (40 + i * length) + 1, (40 + j * length) + 1, length - 2, length - 2);
                        g.FillRectangle(myBrushFalse, (40 + i * length), (40 + j * length), length, length);
                    }
                }
            }
        }

        private void mbStart_Click(object sender, EventArgs e)
        {
            if (!ok)
            {
                ok = true;
                mbStart.Text = "Start";
            }

            while (ok)
            {
                Counter.Text = "Steps: " + Convert.ToString(iterations);

                MovingOfTheAnt();
                //System.Threading.Thread.Sleep(1000);

                Refresh();

                DoEvents();

                iterations++;
            }
        }

        private void MovingOfTheAnt()
        {

            if (AntPosition[0] >= numberOfCells || AntPosition[1] >= numberOfCells)
            {
                MessageBox.Show("You've reached the border of the table.");
                mbStart.Enabled = false;
                mbStop.Enabled = false;
                mbNext.Enabled = false;
                ok = false;
                return;
            }

            oldPosition[0] = AntPosition[0];
            oldPosition[1] = AntPosition[1];

            if (colorStorage[AntPosition[0], AntPosition[1]])
            {
                colorStorage[AntPosition[0], AntPosition[1]] = false;
                
                switch (direction)
                {
                    case 'n':
                        direction = 'e';
                        AntPosition[1] += 1;
                        break;
                    case 'e':
                        direction = 's';
                        AntPosition[0] -= 1;
                        break;
                    case 's':
                        direction = 'w';
                        AntPosition[1] -= 1;
                        break;
                    case 'w':
                        direction = 'n';
                        AntPosition[0] += 1;
                        break;
                }
            }
            else
            {
                colorStorage[AntPosition[0], AntPosition[1]] = true;

                switch (direction)
                {
                    case 'n':
                        direction = 'w';
                        AntPosition[1] -= 1;
                        break;
                    case 'w':
                        direction = 's';
                        AntPosition[0] -= 1;
                        break;
                    case 's':
                        direction = 'e';
                        AntPosition[1] += 1;
                        break;
                    case 'e':
                        direction = 'n';
                        AntPosition[0] += 1;
                        break;
                }
            }
        }

        private void mbStop_Click(object sender, EventArgs e)
        {
            ok = false;
            mbStart.Text = "Continue";
        }

        private void mbNewGame_Click(object sender, EventArgs e)
        {
            AntPosition[0] = numberOfCells / 2;
            AntPosition[1] = numberOfCells / 2;
            oldPosition[0] = AntPosition[0];
            oldPosition[1] = AntPosition[1];
            iterations = 0;
            mbStart.Text = "Start";

            for (int i = 0; i < numberOfCells; i++)
            {
                for (int j = 0; j < numberOfCells; j++)
                {
                    colorStorage[i, j] = true;
                }
            }

            Counter.Text = "Steps: " + Convert.ToString(iterations);

            mbStart.Enabled = true;
            mbStop.Enabled = true;

            Refresh();
        }

        private void mbNext_Click(object sender, EventArgs e)
        {
                MovingOfTheAnt();

                iterations++;
                Counter.Text = "Steps: " + Convert.ToString(iterations);

                Refresh();
        }
    }
}
