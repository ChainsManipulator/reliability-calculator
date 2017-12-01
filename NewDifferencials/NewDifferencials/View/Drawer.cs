using System.Collections.Generic;
using System.Drawing;
using ZedGraph;

namespace NewDifferencials.View
{
    public static class Drawer
    {
        public static Color GetColor(int i)
        {
            List<Color> colors = new List<Color>();
            colors.Add(Color.Black);
            colors.Add(Color.Maroon);
            colors.Add(Color.Blue);
            colors.Add(Color.BlueViolet);
            colors.Add(Color.Brown);
            colors.Add(Color.Coral);
            colors.Add(Color.Cyan);
            colors.Add(Color.DarkGray);
            colors.Add(Color.DarkGreen);
            colors.Add(Color.DarkMagenta);
            colors.Add(Color.DarkOliveGreen);
            colors.Add(Color.DarkOrange);
            colors.Add(Color.DarkSalmon);
            colors.Add(Color.DarkViolet);
            colors.Add(Color.DeepPink);
            colors.Add(Color.ForestGreen);
            colors.Add(Color.Gray);
            colors.Add(Color.GreenYellow);
            colors.Add(Color.Indigo);
            colors.Add(Color.LimeGreen);
            colors.Add(Color.MediumPurple);
            colors.Add(Color.Olive);
            colors.Add(Color.OrangeRed);
            colors.Add(Color.Tomato);
            colors.Add(Color.YellowGreen);
            colors.Add(Color.Violet);
            return colors[i];
        }

        public static void DrawGraph(ZedGraphControl control, List<double> x, List<double> y, string name, string title, Color color)
        {
            GraphPane pane = control.GraphPane;     // ������� ������ ��� ���������
            double Xmax = pane.XAxis.Scale.Max;
            double Ymax = pane.YAxis.Scale.Max - 0.05;
            pane.Title.Text = title; // �������� ������ � ����
            pane.XAxis.Title.Text = "t";
            pane.YAxis.Title.Text = "P(t)";
            PointPairList list1 = new PointPairList();      // �������� ������ �����
            for (int i = 0; i < x.Count; i++)
            {
                list1.Add(x[i], y[i]); // ������� � ������ �����
                if (y[i] > Ymax)
                {
                    Ymax = y[i];
                }
            }
            if (x[x.Count - 1] > Xmax)
            {
                Xmax = x[x.Count - 1];
            }
            LineItem myCurve = pane.AddCurve(name, list1, color, SymbolType.None);
            myCurve.Line.Width = 2.0F; // ������� ��������
            pane.XAxis.Scale.Min = 0;
            pane.YAxis.Scale.Min = 0;
            pane.XAxis.Scale.Max = Xmax;
            pane.YAxis.Scale.Max = Ymax + 0.05;

            pane.XAxis.MajorGrid.IsVisible = true;  // �������� ����������� ����� �������� ������� ����� �� ��� X
            // ������ ��� ���������� ����� ��� ������� ����� �� ��� X:
            // ����� ������� ����� 10 ��������, ... 
            pane.XAxis.MajorGrid.DashOn = 10;
            // ����� 5 �������� - �������
            pane.XAxis.MajorGrid.DashOff = 5;
            // �������� ����������� ����� �������� ������� ����� �� ��� Y
            pane.YAxis.MajorGrid.IsVisible = true;
            // ���������� ������ ��� ���������� ����� ��� ������� ����� �� ��� Y
            pane.YAxis.MajorGrid.DashOn = 10;
            pane.YAxis.MajorGrid.DashOff = 5;
            // �������� ����������� ����� �������� ������ ����� �� ��� X
           /* pane.YAxis.MinorGrid.IsVisible = true;
            // ������ ��� ���������� ����� ��� ������ ����� �� ��� Y: 
            // ����� ������� ����� ������ �������, ... 
            pane.YAxis.MinorGrid.DashOn = 1;
            // ����� 2 ������� - �������
            pane.YAxis.MinorGrid.DashOff = 2;
            // �������� ����������� ����� �������� ������ ����� �� ��� Y
            pane.XAxis.MinorGrid.IsVisible = true;
            // ���������� ������ ��� ���������� ����� ��� ������ ����� �� ��� Y
            pane.XAxis.MinorGrid.DashOn = 1;
            pane.XAxis.MinorGrid.DashOff = 2;*/
            //���� �����
            pane.XAxis.MajorGrid.Color = Color.LightGray;
            pane.YAxis.MajorGrid.Color = Color.LightGray;
            //���
            pane.XAxis.MajorGrid.IsZeroLine = true;
            pane.YAxis.MajorGrid.IsZeroLine = true;
        }

        public static void Clear(ZedGraphControl control)
        {
            // ������� ������ ��� ���������
            GraphPane pane = control.GraphPane;

            pane.XAxis.Scale.Min = 0;
            pane.YAxis.Scale.Min = 0;
            pane.XAxis.Scale.Max = 0.00001;
            pane.YAxis.Scale.Max = 1.05;

            // ������� ������ ������
            pane.CurveList.Clear();

            // ��������� ������
            control.Invalidate();
        }
    }
}