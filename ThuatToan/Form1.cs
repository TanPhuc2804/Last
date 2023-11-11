using System.Data;
using System.Diagnostics;

namespace ThuatToan
{
    public partial class Form1 : Form
    {
        List<MyProcess> processes = new List<MyProcess>();
        public Form1()
        {
            MyProcess process = new MyProcess();
            InitializeComponent();
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }
        DataTable table = new DataTable();
        private void Form1_Load(object sender, EventArgs e)
        {
            table.Columns.Add("Process");
            table.Columns.Add("Burst time");
            table.Columns.Add("Arrival time");
            table.Columns.Add("Priority");

            dataGridView1.DataSource = table;
        }

        private void ADD_Click(object sender, EventArgs e)
        {
            string name = "P" + process_name.Text;
            double bt = double.Parse(burst_time.Text);
            double at = double.Parse(arrival_time.Text);
            double pir = double.Parse(PRIORITY.Text);
            double qt = double.Parse(quantum.Text);

            MyProcess myProcess = new MyProcess(name, bt, at, pir);
            processes.Add(myProcess);
            table.Rows.Add(name, bt, at, pir);

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        public void Swap(ref MyProcess p1, ref MyProcess p2)
        {
            MyProcess temp = p1;
            p1 = p2;
            p2 = temp;
        }
        public void SwapProcess(ref List<MyProcess> list)
        {
            list.Sort((x, t) => x.Arrival_time.CompareTo(t.Arrival_time));


        }
        public void FCFS_Scheduling(List<MyProcess> list)
        {
            List<MyProcess> temp = list;
            double[] res_bt = new double[list.Count];
            double[] res_at = new double[list.Count];
            double t = 0;//thoi gian hien tai
                         //luu vao bien tam

            string sque = "";
            SwapProcess(ref list);
            for (int i = 0; i < res_at.Length; i++)
            {
                res_at[i] = temp[i].Arrival_time;
                res_bt[i] = temp[i].Burst_time;
            }
            while (true)
            {
                bool flag = false;
                for (int i = 0; i < temp.Count; i++)
                {
                    if (res_at[i] <= t)
                    {
                        if (res_bt[i] > 0)
                        {
                            flag = true;
                            temp[i].waiting_time = t - temp[i].Arrival_time;
                            t += res_bt[i];
                            temp[i].turn_around_time = t - temp[i].Burst_time;
                            res_bt[i] = 0;
                            RES.Text += "->" + temp[i].Name_process + " Waiting Time=" + temp[i].waiting_time + " Turn around time=" + temp[i].turn_around_time + " ";


                        }
                    }
                    else
                    {
                        t++;
                        i--;
                    }

                }

                if (flag == false)
                {
                    break;
                }
            }


        }
        private void FCFS_Click(object sender, EventArgs e)
        {
            FCFS_Scheduling(processes);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}