using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Windows.Forms.DataVisualization.Charting;
using System.Threading.Tasks;

namespace Lab1
{
    class MyProg : Form
    {
        private GroupBox groupBox1;
        private GroupBox groupBox2;
		private TextBox textBox1;
		private Chart chart1;
		private Label label4;
		private Label label3;
		private Label label2;
		private Label label1;
		private TextBox textBox3;
		private TextBox textBox2;
		private TextBox textBox4;
		private TextBox textBox5;
		private TextBox textBox6;
		private Label label5;
		private Label label6;
		private Label label7;
		private TextBox textBox8;
		private TextBox textBox7;
		private Button button1;

        private void InitializeComponent()
        {
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label7 = new System.Windows.Forms.Label();
			this.textBox8 = new System.Windows.Forms.TextBox();
			this.textBox7 = new System.Windows.Forms.TextBox();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.textBox6 = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.textBox8);
			this.groupBox1.Controls.Add(this.textBox7);
			this.groupBox1.Controls.Add(this.textBox5);
			this.groupBox1.Controls.Add(this.textBox6);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.textBox4);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.textBox3);
			this.groupBox1.Controls.Add(this.textBox2);
			this.groupBox1.Controls.Add(this.textBox1);
			this.groupBox1.Controls.Add(this.button1);
			this.groupBox1.Location = new System.Drawing.Point(690, 13);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(219, 482);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Контроль";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(112, 127);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(44, 13);
			this.label7.TabIndex = 17;
			this.label7.Text = "T(крок)";
			// 
			// textBox8
			// 
			this.textBox8.Location = new System.Drawing.Point(6, 128);
			this.textBox8.Name = "textBox8";
			this.textBox8.Size = new System.Drawing.Size(100, 20);
			this.textBox8.TabIndex = 16;
			// 
			// textBox7
			// 
			this.textBox7.Location = new System.Drawing.Point(5, 105);
			this.textBox7.Name = "textBox7";
			this.textBox7.Size = new System.Drawing.Size(100, 20);
			this.textBox7.TabIndex = 15;
			// 
			// textBox5
			// 
			this.textBox5.Location = new System.Drawing.Point(6, 175);
			this.textBox5.Name = "textBox5";
			this.textBox5.Size = new System.Drawing.Size(100, 20);
			this.textBox5.TabIndex = 14;
			// 
			// textBox6
			// 
			this.textBox6.Location = new System.Drawing.Point(5, 201);
			this.textBox6.Name = "textBox6";
			this.textBox6.Size = new System.Drawing.Size(100, 20);
			this.textBox6.TabIndex = 13;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(112, 204);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(70, 13);
			this.label5.TabIndex = 12;
			this.label5.Text = "Права межа";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(112, 182);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(60, 13);
			this.label6.TabIndex = 11;
			this.label6.Text = "Ліва межа";
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(7, 227);
			this.textBox4.Multiline = true;
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(206, 124);
			this.textBox4.TabIndex = 10;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(112, 105);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(63, 13);
			this.label4.TabIndex = 8;
			this.label4.Text = "T(інтервал)";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(113, 75);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(13, 13);
			this.label3.TabIndex = 7;
			this.label3.Text = "u";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(113, 46);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(14, 13);
			this.label2.TabIndex = 6;
			this.label2.Text = "σ";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(113, 20);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(18, 13);
			this.label1.TabIndex = 5;
			this.label1.Text = "x0";
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(6, 72);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(100, 20);
			this.textBox3.TabIndex = 3;
			this.textBox3.Text = "1";
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(6, 46);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(100, 20);
			this.textBox2.TabIndex = 2;
			this.textBox2.Text = "0";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(6, 20);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(100, 20);
			this.textBox1.TabIndex = 1;
			this.textBox1.Text = "0";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(6, 429);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(207, 47);
			this.button1.TabIndex = 0;
			this.button1.Text = "Виконати";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.chart1);
			this.groupBox2.Location = new System.Drawing.Point(12, 13);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(672, 482);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Робоче поле";
			// 
			// chart1
			// 
			chartArea1.Name = "ChartArea1";
			this.chart1.ChartAreas.Add(chartArea1);
			legend1.Name = "Legend1";
			this.chart1.Legends.Add(legend1);
			this.chart1.Location = new System.Drawing.Point(7, 20);
			this.chart1.Name = "chart1";
			series1.ChartArea = "ChartArea1";
			series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
			series1.Legend = "Legend1";
			series1.Name = "Series1";
			this.chart1.Series.Add(series1);
			this.chart1.Size = new System.Drawing.Size(659, 456);
			this.chart1.TabIndex = 0;
			this.chart1.Text = "chart1";
			// 
			// MyProg
			// 
			this.ClientSize = new System.Drawing.Size(921, 507);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Name = "MyProg";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
			this.ResumeLayout(false);

        }

        public MyProg()
        {
            InitializeComponent();

        }

		private void button1_Click(object sender, EventArgs e)
		{
			double x0, sigma, u, lb,rb,tint, tstep;
			try
			{
				lb = Convert.ToDouble(textBox5.Text);
				rb = Convert.ToDouble(textBox6.Text);
				sigma = Convert.ToDouble(textBox2.Text);
				x0 = Convert.ToDouble(textBox1.Text);
				u = Convert.ToDouble(textBox3.Text);
				tint = Convert.ToDouble(textBox7.Text);
				tstep = Convert.ToDouble(textBox8.Text);
				if (tint <= 0 || tstep <= 0 || sigma <0 || lb>=rb )
				{
					throw new Exception();
				}
			}
			catch
			{
				textBox4.Text += "Wrong!" + Environment.NewLine;
				return;
			}
			double maxval = 0;
			double val;
			double temp;
			Func<double, double> func = (x) => { return Math.Exp(-1 * Math.Pow((x - x0), 2)); };
			for (double i = 0; i < tint; i+=tstep)
			{
				this.Refresh();
				Application.DoEvents();
				System.Threading.Thread.Sleep(850);
				chart1.Series[0].Points.Clear();
				for (temp = lb; temp <= rb; temp += (rb-lb)/500)
				{
					val = func(temp - u * i) * Math.Exp(-1 * sigma * i);
					if (val > maxval)
					{
						maxval = val;
						chart1.ChartAreas[0].Axes[1].Maximum = maxval;
					}
					chart1.Series[0].Points.AddXY(temp,func(temp-u*i)*Math.Exp(-1*sigma*i));
				}
			}
			textBox4.Text += "Done" + Environment.NewLine;
		}
	}
	class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            MyProg Prog = new MyProg();
            Application.Run(Prog);
        }
    }
}
