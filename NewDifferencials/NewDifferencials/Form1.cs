using System;
using System.ComponentModel;
using System.Windows.Forms;
using NewDifferencials.Controller;
using NewDifferencials.Model;
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

        private ModelType type;
        private ResultContainer Result;
        private IDataContainer Source;
        private int ColorCounter = 0;

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker Worker = sender as BackgroundWorker;
            IController calc = ControllerFactory.CreateController(type);
            e.Result = calc.Calculate((IDataContainer)e.Argument);
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
                    if(i!=0)
                    {
                        AverageLifeTime += (Result.Values[i] - Result.Values[i - 1])*Result.Times[i];
                    }
                    
                }
                label15.Text = AverageLifeTime.ToString("N6");
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

        private IDataContainer ParseData()
        {
            switch (comboBox1.Text)
            {
                case "Первая модель":
                {
                    type = ModelType.First;
                    break;
                }
                case "Вторая модель":
                {
                    type = ModelType.Second;
                    break;
                }
                case "Третья модель":
                {
                    type = ModelType.Third;
                    break;
                }
                default:
                    throw new Exception("Неизвестный тип модели");
            }
            IDataContainer Temp = ContainerFactory.CreateContainer(type);
            
            double interval = Convert.ToDouble(textBox6.Text);
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

            double Intensity = Convert.ToDouble(textBox1.Text);
            if (Intensity < 0)
            {
                throw new Exception("Ни одна из интенсивностей не должна быть меньше нуля");
            }
            Temp.Mu = Intensity;

            Intensity = Convert.ToDouble(textBox2.Text);
            if (Intensity < 0)
            {
                throw new Exception("Ни одна из интенсивностей не должна быть меньше нуля");
            }
            Temp.Lambda = Intensity;

            switch (type)
            {
                case ModelType.First:
                    FirstParse((FirstDataContainer)Temp);
                    break;
                case ModelType.Second:
                    SecondParse((SecondDataContainer)Temp);
                    break;
                case ModelType.Third:
                    ThirdParse((ThirdDataContainer)Temp);
                    break;
                default: throw new Exception("Неизвестный тип модели");
            }

            return Temp;
        }

        private void FirstParse(FirstDataContainer dataContainer)
        {
            double Intensity = Convert.ToDouble(textBox3.Text);
            if (Intensity < 0)
            {
                throw new Exception("Ни одна из интенсивностей не должна быть меньше нуля");
            }
            dataContainer.Mui = Intensity;
        }

        private void SecondParse(SecondDataContainer dataContainer)
        {
            double Intensity = Convert.ToDouble(textBox3.Text);
            if (Intensity < 0)
            {
                throw new Exception("Ни одна из интенсивностей не должна быть меньше нуля");
            }
            dataContainer.Mui = Intensity;

            Intensity = Convert.ToDouble(textBox5.Text);
            if (Intensity < 0)
            {
                throw new Exception("Ни одна из интенсивностей не должна быть меньше нуля");
            }
            dataContainer.e = Intensity;

            Intensity = Convert.ToDouble(textBox4.Text);
            if (Intensity < 0)
            {
                throw new Exception("Ни одна из интенсивностей не должна быть меньше нуля");
            }
            dataContainer.v = Intensity;
        }

        private void ThirdParse(ThirdDataContainer dataContainer)
        {
            double Intensity = Convert.ToDouble(textBox5.Text);
            if (Intensity < 0)
            {
                throw new Exception("Ни одна из интенсивностей не должна быть меньше нуля");
            }
            dataContainer.e = Intensity;

            Intensity = Convert.ToDouble(textBox4.Text);
            if (Intensity < 0)
            {
                throw new Exception("Ни одна из интенсивностей не должна быть меньше нуля");
            }
            dataContainer.v = Intensity;

            Intensity = Convert.ToDouble(textBox3.Text);
            if (Intensity < 0)
            {
                throw new Exception("Ни одна из интенсивностей не должна быть меньше нуля");
            }
            dataContainer.Mu1 = Intensity;

            Intensity = Convert.ToDouble(textBox9.Text);
            if (Intensity < 0)
            {
                throw new Exception("Ни одна из интенсивностей не должна быть меньше нуля");
            }
            dataContainer.Mu2 = Intensity;

            Intensity = Convert.ToDouble(textBox11.Text);
            if (Intensity < 0)
            {
                throw new Exception("Ни одна из интенсивностей не должна быть меньше нуля");
            }
            dataContainer.Mu3 = Intensity;

            Intensity = Convert.ToDouble(textBox10.Text);
            if (Intensity < 0)
            {
                throw new Exception("Ни одна из интенсивностей не должна быть меньше нуля");
            }
            dataContainer.Mu4 = Intensity;
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
                    label8.Text = "Размер шага: " + step.ToString();
                }
                else
                {
                    label8.Text = "Размер шага неизвестен";
                }
            }
            catch (Exception)
            {
                label8.Text = "Размер шага неизвестен";
                return;
            }
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            switch (comboBox1.Text)
            {
                case "Первая модель":
                    SetFirstModel();
                    break;
                case "Вторая модель":
                    SetSecondModel();
                    break;
                case "Третья модель":
                    SetThirdModel();
                    break;
            }
        }

        private void SetFirstModel()
        {
            textBox4.Visible = false;
            textBox5.Visible = false;
            textBox9.Visible = false;
            textBox10.Visible = false;
            textBox11.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label11.Visible = false;
            label12.Visible = false;
            label13.Visible = false;
            label3.Text = "μ i";
        }

        private void SetSecondModel()
        {
            textBox4.Visible = true;
            textBox5.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label11.Visible = false;
            label12.Visible = false;
            label13.Visible = false;
            textBox9.Visible = false;
            textBox10.Visible = false;
            textBox11.Visible = false;
            label3.Text = "μ i";
        }

        private void SetThirdModel()
        {
            textBox4.Visible = true;
            textBox5.Visible = true;
            textBox9.Visible = true;
            textBox10.Visible = true;
            textBox11.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label11.Visible = true;
            label12.Visible = true;
            label13.Visible = true;
            label3.Text = "μ 1";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
