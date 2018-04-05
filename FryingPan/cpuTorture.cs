﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace FryingPan
{
    public partial class cpuTorture : Form
    {
        public cpuTorture()
        {
            InitializeComponent();
        }

        public PerformanceCounter[] cpuCounter;
        public int coreCount = 0;
        public Series[] coreSeries;

        public Series cpuTempSeries;

        public long sampleTicks = 1;

        public Thread[] stressThreads;
        public ulong[] threadIterations;
        public Label[] threadLabels;

        public Stopwatch stressWatch = Stopwatch.StartNew();
        public long EndingAddress = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            int threadCoreCount = 0;
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("select * from Win32_Processor");

            foreach (ManagementObject share in searcher.Get())
            {
                threadCoreCount = int.Parse(share["ThreadCount"].ToString());
                cpuName.Text = share["Name"].ToString() + "\n" + share["NumberOfCores"].ToString() + " cores - " + share["ThreadCount"].ToString() + " threads\n\n";
            }

            searcher = new ManagementObjectSearcher("select * from Win32_PhysicalMemory");
            foreach (ManagementObject share in searcher.Get())
            {
                EndingAddress += long.Parse(share["Capacity"].ToString()) / 1024 / 1024;
                cpuName.Text += share["PartNumber"].ToString() + " " + share["DeviceLocator"].ToString() + " " + share["ConfiguredClockSpeed"].ToString() + "Mhz " + long.Parse(share["Capacity"].ToString()) / 1024 / 1024 / 1024 + "GB\n";
            }

            cpuName.Text += "\nTotal installed RAM " + EndingAddress / 1024 + "GB";

            cpuTempSeries = chart1.Series.Add("CPU Temperature");
            cpuTempSeries.ChartType = SeriesChartType.Line;

            cpuChart.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0;
            cpuChart.ChartAreas[0].AxisY.MajorGrid.LineWidth = 0;
            cpuChart.ChartAreas[0].AxisY.Maximum = 100;
            cpuChart.ChartAreas[0].AxisY.Title = "%";
            cpuChart.ChartAreas[0].AxisX.Title = "Time (Seconds)";

            chart1.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0;
            chart1.ChartAreas[0].AxisY.MajorGrid.LineWidth = 0;
            chart1.ChartAreas[0].AxisY.Maximum = 120;
            chart1.ChartAreas[0].AxisY.Title = "°C";
            chart1.ChartAreas[0].AxisX.Title = "Time (Seconds)";

            foreach (var item in new System.Management.ManagementObjectSearcher("Select * from Win32_Processor").Get())
            {
                coreCount += int.Parse(item["NumberOfCores"].ToString());
            }

            cpuCounter = new PerformanceCounter[coreCount];
            coreSeries = new Series[coreCount];

            for (int i = 0; i < coreCount; i++)
            {
                coreSeries[i] = cpuChart.Series.Add("CPU" + i);
                coreSeries[i].ChartType = SeriesChartType.Line;

                cpuCounter[i] = new PerformanceCounter("Processor", "% Processor Time", i.ToString());
                Console.WriteLine(cpuCounter[i].CounterName);
            }
        }

        public string getCurrentCpuUsage()
        {
            string s = "";
            int i = 0;

            foreach (PerformanceCounter pc in cpuCounter)
            {
                float perc = pc.NextValue();
                s += "CPU" + i + " - " + Math.Round(perc, 2) + "% \n";

                coreSeries[i].Points.AddXY(0, perc);
                i++;
            }

            return s;
        }


        public Int64 NextInt64(Random rnd)
        {
            var buffer = new byte[sizeof(Int64)];
            rnd.NextBytes(buffer);
            return BitConverter.ToInt64(buffer, 0);
        }

        public object RandomIntegerCalc()
        {
            Random r = new Random(Guid.NewGuid().GetHashCode());

            if (!powChk.Checked)
            {
                if (sqrtChck.Checked)
                    return Math.Sqrt(NextInt64(r) * NextInt64(r) + NextInt64(r) * NextInt64(r) - NextInt64(r) * NextInt64(r) + NextInt64(r) * NextInt64(r));
                else
                    return NextInt64(r) * NextInt64(r) + NextInt64(r) * NextInt64(r) - NextInt64(r) * NextInt64(r) + NextInt64(r) * NextInt64(r);
            }
            else
            {
                if (sqrtChck.Checked)
                    return Math.Sqrt(Math.Pow(r.NextDouble() * r.NextDouble(), r.NextDouble() * r.NextDouble()));
                else
                    return Math.Pow(r.NextDouble() * r.NextDouble(), r.NextDouble() * r.NextDouble());
            }
        }

        private void uiUpdater_Tick(object sender, EventArgs e)
        {
            cpuUsage.Text = getCurrentCpuUsage();

            sampleTicks++;

            cpuTempSeries.Points.AddXY(0, 0);

            if (threadLabels != null)
            {
                int i = 0;
                foreach (Label l in threadLabels)
                {
                    try
                    {
                        l.Text = "Thread #" + i.ToString() + " iterations : " + threadIterations[i].ToString() + " Performing " +
                      "" + (threadIterations[i] / (ulong)(stressWatch.Elapsed.Seconds)) + " Iterations/s";
                    }
                    catch (Exception ex) { }
                    i++;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "&Turn up the heater")
            {
                button1.Text = "&Stop making it cry";
                panel1.Controls.Clear();

                sqrtChck.Enabled = false;
                powChk.Enabled = false;
                threadCount.Enabled = false;

                stressWatch.Start();

                stressThreads = new Thread[int.Parse(threadCount.Value.ToString())];
                threadLabels = new Label[int.Parse(threadCount.Value.ToString())];
                threadIterations = new ulong[int.Parse(threadCount.Value.ToString())];

                for (int i = 0; i < threadCount.Value; i++)
                {
                    threadLabels[i] = new Label();
                    stressThreads[i] = new Thread(delegate () {
                        ulong iteration = 0;
                        int threadNum = i;

                        while (true)
                        {
                            threadIterations[threadNum] = iteration;
                            RandomIntegerCalc();

                            iteration++;
                        }
                    });

                    stressThreads[i].Start();

                    threadLabels[i].Size = new Size(512, 16);
                    threadLabels[i].Location = new Point(0, i * 16);

                    panel1.Controls.Add(threadLabels[i]);
                }
            }
            else
            {
                for (int i = 0; i < threadCount.Value; i++)
                {
                    stressThreads[i].Abort();
                }

                panel1.Controls.Clear();
                threadCount.Enabled = true;
                sqrtChck.Enabled = true;
                powChk.Enabled = true;
                stressWatch.Stop();

                stressThreads = null;
                threadLabels = null;
                threadIterations = null;

                GC.Collect();

                button1.Text = "&Turn up the heater";
            }
        }

        private void cpuName_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(cpuName.Text);
        }

        private void cpuTorture_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (button1.Text == "&Stop making it cry")
            {
                for (int i = 0; i < threadCount.Value; i++)
                {
                    stressThreads[i].Abort();
                }

                panel1.Controls.Clear();
                threadCount.Enabled = true;
                sqrtChck.Enabled = true;
                powChk.Enabled = true;
                stressWatch.Stop();

                stressThreads = null;
                threadLabels = null;
                threadIterations = null;

                GC.Collect();

                button1.Text = "&Turn up the heater";
            }
        }
    }
}
