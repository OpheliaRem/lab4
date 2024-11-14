using ScottPlot.Interactivity;
using ScottPlot.Panels;

namespace lab4
{
    public partial class DiffuseForm : Form
    {
        private struct Q
        {
            public int x;
            public int y;
            public double value;

            public Q(int x, int y, double value)
            {
                this.x = x;
                this.y = y;
                this.value = value;
            }

            public override string ToString()
            {
                return $"Q({x},{y}) = {value}";
            }
        }

        private struct Vector
        {
            public double x;
            public double y;

            public Vector(double r, double phi)
            {
                x = r * Math.Cos(phi);
                y = r * Math.Sin(phi);
            }

            public double Abs() => Math.Sqrt(x * x + y * y);

            public double Angle() => Math.Atan(y / x);
        }

        double[,]? rhoCurrent;
        double[,]? rhoNext;
        double[,]? q;
        const int n = 100;
        const int a = 0;
        const int b = 100000;
        double tau;
        const double deltaX = (b - a) / n;
        const double deltaY = (b - a) / n;

        double r;
        double phi; 
        Vector windSpeed;

        ColorBar? colorbar;


        public DiffuseForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            formsPlot.Plot.Axes.SetLimits(0, 100, 0, 100);
        }

        private void buttonAddQ_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxX.Text) || String.IsNullOrEmpty(textBoxY.Text) ||
                String.IsNullOrEmpty(textBoxQ.Text))
            {
                return;
            }

            int x = Convert.ToInt32(textBoxX.Text) * 1000;
            int y = Convert.ToInt32(textBoxY.Text) * 1000;
            double q = Convert.ToDouble(textBoxQ.Text);

            listBox.Items.Add(new Q(x, y, q));
        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonDelete.Enabled = true;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            listBox.Items.Remove(listBox.SelectedItem!);
            buttonDelete.Enabled = false;
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            listBox.Items.Clear();
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            bool rIsEmpty = String.IsNullOrEmpty(textBoxWindAbs.Text);
            bool phiIsEmpty = String.IsNullOrEmpty(textBoxWindPhi.Text);
            bool alphaIsEmpty = String.IsNullOrEmpty(textBoxAlpha.Text);
            bool dIsEmpty = String.IsNullOrEmpty(textBoxD.Text);

            tau = Convert.ToDouble(textBoxTimeStep.Text);

            if (rIsEmpty || phiIsEmpty || alphaIsEmpty || dIsEmpty)
                return;

            rhoCurrent = new double[n, n];
            rhoNext = new double[n, n];

            for (int i = 0; i < n; ++i)
                for (int j = 0; j < n; ++j)
                    rhoCurrent[i, j] = 0.0;

            q = new double[n, n];

            for (int i = 0; i < n; ++i)
                for (int j = 0; j < n; ++j)
                    q[i, j] = 0.0;

            foreach (Q element in listBox.Items)
            {
                q[element.x / 1000, element.y / 1000] = element.value;
            }

            r = Convert.ToDouble(textBoxWindAbs.Text);
            phi = Convert.ToDouble(textBoxWindPhi.Text);

            windSpeed = new Vector(r, phi);

            var heatmap = formsPlot.Plot.Add.Heatmap(rhoCurrent!);
            heatmap.ManualRange = new ScottPlot.Range(0, 100000);

            if (colorbar is not null)
                formsPlot.Plot.Remove(colorbar);
            colorbar = formsPlot.Plot.Add.ColorBar(heatmap);

            timer.Enabled = true;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            formsPlot.Plot.Clear();

            var heatmap = formsPlot.Plot.Add.Heatmap(rhoCurrent!);
            heatmap.ManualRange = new ScottPlot.Range(0, 100000);
            //formsPlot.Plot.Add.ColorBar(heatmap);


            double alpha = Convert.ToDouble(textBoxAlpha.Text);

            var d = (double arg) => Convert.ToDouble(textBoxD.Text);

            var mIPlusHalf = (int i, int j) =>
            {
                if (windSpeed.x > 0)
                    return deltaY * tau * rhoCurrent![i, j] * windSpeed.x;
                else
                    return deltaY * tau * rhoCurrent![i + 1, j] * windSpeed.x;
            };

            var mIMinusHalf = (int i, int j) =>
            {
                if (windSpeed.x < 0)
                    return deltaY * tau * rhoCurrent![i, j] * windSpeed.x;
                else
                    return deltaY * tau * rhoCurrent![i - 1, j] * windSpeed.x;
            };

            var mJPlusHalf = (int i, int j) =>
            {
                if (windSpeed.y > 0)
                    return deltaX * tau * rhoCurrent![i, j] * windSpeed.y;
                else
                    return deltaX * tau * rhoCurrent![i, j + 1] * windSpeed.y;
            };

            var mJMinusHalf = (int i, int j) =>
            {
                if (windSpeed.y < 0)
                    return deltaX * tau * rhoCurrent![i, j] * windSpeed.y;
                else
                    return deltaX * tau * rhoCurrent![i, j - 1] * windSpeed.y;
            };

            for (int i = 1; i < n - 1; ++i)
            {
                for (int j = 1; j < n - 1; ++j)
                {
                    double m = (mIPlusHalf(i, j) - mIMinusHalf(i, j) + mJPlusHalf(i, j) - mJMinusHalf(i, j));

                    double d1 = (d(0) * (rhoCurrent[i + 1, j] - rhoCurrent[i, j])
                        - d(0) * (rhoCurrent[i, j] - rhoCurrent[i - 1, j]));

                    double d2 = (d(0) * (rhoCurrent[i, j + 1] - rhoCurrent[i, j])
                        - d(0) * (rhoCurrent[i, j] - rhoCurrent[i, j - 1]));

                    rhoNext![i, j] = rhoCurrent![i, j]
                    - 1.0 / (deltaX * deltaY) * m + tau / (deltaX * deltaX) * d1
                    + tau / (deltaY * deltaY) * d2
                    + tau * (q![i, j] - alpha * rhoCurrent[i, j]);
                }
            }

            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; j < n; ++j)
                {
                    rhoCurrent![i, j] = rhoNext![i, j];
                }
            }

            for (int i = 0; i < n; ++i)
            {
                rhoCurrent![0, i] = rhoCurrent[1, i];
                rhoCurrent[n - 1, i] = rhoCurrent[n - 2, i];
            }

            for (int i = 0; i < n; ++i)
            {
                rhoCurrent![i, 0] = rhoCurrent[i, 1];
                rhoCurrent[i, n - 1] = rhoCurrent[1, n - 2];
            }

            formsPlot.Refresh();
        }
    }
}
