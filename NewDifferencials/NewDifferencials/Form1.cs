using System;
using System.ComponentModel;
using System.Globalization;
using System.Windows.Forms;
using NewDifferencials.Controller;
using NewDifferencials.View;

namespace NewDifferencials
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Drawer.Clear(zedGraphControl2);
        }

        private ResultContainer Result;
        private DataContainer Source;
        private int ColorCounter;

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker Worker = sender as BackgroundWorker;
            Controller.Controller calc = new Controller.Controller();
            e.Result = calc.Calculate((DataContainer)e.Argument);
            if (Worker.CancellationPending)
            {
                e.Cancel = true;
            }
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                MessageBox.Show("Исследование отменено", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (e.Error != null)
            {
                MessageBox.Show(e.Error.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                Result = (ResultContainer)e.Result;
                dataGridView1.Rows.Clear();
                double AverageLifeTime = 0;
                for (int i = 0; i < Result.Values.Count; i++)
                {
                    dataGridView1.Rows.Add();
                    dataGridView1.Rows[i].Cells[0].Value = Result.Times[i];
                    dataGridView1.Rows[i].Cells[1].Value = Result.Values[i];
                    dataGridView1.Rows[i].Cells[2].Value = Result.Errors[i];
                    if (i != 0)
                    {
                        AverageLifeTime += (Result.Values[i] - Result.Values[i - 1]) * Result.Times[i];
                    }

                }
                textBox5.Text = AverageLifeTime.ToString("N6");
                Drawer.DrawGraph(zedGraphControl2, Result.Times, Result.Values, "Исследование " + (ColorCounter + 1).ToString(), "Вероятность безотказной работы системы", Drawer.GetColor(ColorCounter));
                ColorCounter++;
            }
            groupBox1.Enabled = true;
            button1.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Drawer.Clear(zedGraphControl2);
            ColorCounter = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = false;
            button1.Enabled = false;
            try
            {
                Source = ParseData();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                button1.Enabled = true;
                groupBox1.Enabled = true;
            }
            backgroundWorker1.RunWorkerAsync(Source);
        }

        private DataContainer ParseData()
        {
            DataContainer Temp = new DataContainer();

            double interval = Convert.ToDouble(textBox6.Text, CultureInfo.InvariantCulture);
            if (interval < 0)
            {
                throw new Exception("Интервал времени должен быть положительным");
            }
            Temp.Time = interval;

            int points = Convert.ToInt32(textBox7.Text);
            if (points < 1)
            {
                throw new Exception("Нужна хотя бы одна точка для рассчётов");
            }
            Temp.TimeSteps = points;

            int components = Convert.ToInt32(textBox8.Text);
            if (components < 1)
            {
                throw new Exception("Должно быть не меньше одной итерации восстановления системы");
            }
            Temp.ModelComponents = components;

            double Intensity = Convert.ToDouble(textBox1.Text, CultureInfo.InvariantCulture);
            if (Intensity < 0)
            {
                throw new Exception("Ни одна из интенсивностей не должна быть меньше нуля");
            }
            Temp.Mu = Intensity;

            Intensity = Convert.ToDouble(textBox2.Text, CultureInfo.InvariantCulture);
            if (Intensity < 0)
            {
                throw new Exception("Ни одна из интенсивностей не должна быть меньше нуля");
            }
            Temp.Lambda = Intensity;

            FirstParse(Temp);

            return Temp;
        }

        private void FirstParse(DataContainer dataContainer)
        {
            double Intensity = Convert.ToDouble(textBox3.Text);
            if (Intensity < 0)
            {
                throw new Exception("Ни одна из интенсивностей не должна быть меньше нуля");
            }
            dataContainer.Mui = Intensity;
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            CalculateStep();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            CalculateStep();
        }

        private void CalculateStep()
        {
            int steps;
            double period;

            try
            {
                steps = Convert.ToInt32(textBox7.Text);
                period = Convert.ToDouble(textBox6.Text);
                if ((period > 0) && (steps > 0))
                {
                    double step = period / steps;
                    textBox4.Text = step.ToString();
                }
                else
                {
                    textBox4.Text = "Неизвестен";
                }
            }
            catch (Exception)
            {
                textBox4.Text = "Неизвестен";
            }
        }
    }
}
