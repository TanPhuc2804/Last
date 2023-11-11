namespace ThuatToan
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            process_name = new TextBox();
            burst_time = new TextBox();
            arrival_time = new TextBox();
            QUANTUM_TIME = new Label();
            label5 = new Label();
            PRIORITY = new TextBox();
            quantum = new TextBox();
            dataGridView1 = new DataGridView();
            ADD = new Button();
            FCFS = new Button();
            SJF_PRE = new Button();
            SJF_NON = new Button();
            PRIO = new Button();
            RR = new Button();
            RES = new TextBox();
            result = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 27);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 0;
            label1.Text = "INPUT";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 95);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 1;
            label2.Text = "PROCESS";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 152);
            label3.Name = "label3";
            label3.Size = new Size(90, 20);
            label3.TabIndex = 2;
            label3.Text = "BURST TIME";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 205);
            label4.Name = "label4";
            label4.Size = new Size(103, 20);
            label4.TabIndex = 3;
            label4.Text = "ARRIVAL TIME";
            // 
            // process_name
            // 
            process_name.Location = new Point(126, 84);
            process_name.Margin = new Padding(3, 4, 3, 4);
            process_name.Name = "process_name";
            process_name.Size = new Size(114, 27);
            process_name.TabIndex = 5;
            // 
            // burst_time
            // 
            burst_time.Location = new Point(126, 141);
            burst_time.Margin = new Padding(3, 4, 3, 4);
            burst_time.Name = "burst_time";
            burst_time.Size = new Size(114, 27);
            burst_time.TabIndex = 6;
            // 
            // arrival_time
            // 
            arrival_time.Location = new Point(126, 195);
            arrival_time.Margin = new Padding(3, 4, 3, 4);
            arrival_time.Name = "arrival_time";
            arrival_time.Size = new Size(114, 27);
            arrival_time.TabIndex = 7;
            // 
            // QUANTUM_TIME
            // 
            QUANTUM_TIME.AutoSize = true;
            QUANTUM_TIME.Location = new Point(497, 95);
            QUANTUM_TIME.Name = "QUANTUM_TIME";
            QUANTUM_TIME.Size = new Size(121, 20);
            QUANTUM_TIME.TabIndex = 8;
            QUANTUM_TIME.Text = "QUANTUM_TIME";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(15, 257);
            label5.Name = "label5";
            label5.Size = new Size(70, 20);
            label5.TabIndex = 9;
            label5.Text = "PRIORITY";
            // 
            // PRIORITY
            // 
            PRIORITY.Location = new Point(126, 247);
            PRIORITY.Margin = new Padding(3, 4, 3, 4);
            PRIORITY.Name = "PRIORITY";
            PRIORITY.Size = new Size(114, 27);
            PRIORITY.TabIndex = 10;
            // 
            // quantum
            // 
            quantum.Location = new Point(634, 84);
            quantum.Margin = new Padding(3, 4, 3, 4);
            quantum.Name = "quantum";
            quantum.Size = new Size(114, 27);
            quantum.TabIndex = 11;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(14, 408);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(518, 361);
            dataGridView1.TabIndex = 12;
            // 
            // ADD
            // 
            ADD.Location = new Point(15, 299);
            ADD.Margin = new Padding(3, 4, 3, 4);
            ADD.Name = "ADD";
            ADD.Size = new Size(86, 31);
            ADD.TabIndex = 13;
            ADD.Text = "ADD";
            ADD.UseVisualStyleBackColor = true;
            ADD.Click += ADD_Click;
            // 
            // FCFS
            // 
            FCFS.Location = new Point(15, 353);
            FCFS.Margin = new Padding(3, 4, 3, 4);
            FCFS.Name = "FCFS";
            FCFS.Size = new Size(86, 31);
            FCFS.TabIndex = 14;
            FCFS.Text = "FCFS";
            FCFS.UseVisualStyleBackColor = true;
            FCFS.Click += FCFS_Click;
            // 
            // SJF_PRE
            // 
            SJF_PRE.Location = new Point(126, 353);
            SJF_PRE.Margin = new Padding(3, 4, 3, 4);
            SJF_PRE.Name = "SJF_PRE";
            SJF_PRE.Size = new Size(139, 31);
            SJF_PRE.TabIndex = 15;
            SJF_PRE.Text = "SJF-PREEMPTIVE";
            SJF_PRE.UseVisualStyleBackColor = true;
            // 
            // SJF_NON
            // 
            SJF_NON.Location = new Point(291, 353);
            SJF_NON.Margin = new Padding(3, 4, 3, 4);
            SJF_NON.Name = "SJF_NON";
            SJF_NON.Size = new Size(161, 31);
            SJF_NON.TabIndex = 16;
            SJF_NON.Text = "SJF_NONPREEMPTIVE";
            SJF_NON.UseVisualStyleBackColor = true;
            // 
            // PRIO
            // 
            PRIO.Location = new Point(479, 353);
            PRIO.Margin = new Padding(3, 4, 3, 4);
            PRIO.Name = "PRIO";
            PRIO.Size = new Size(86, 31);
            PRIO.TabIndex = 17;
            PRIO.Text = "PRIORITY";
            PRIO.UseVisualStyleBackColor = true;
            // 
            // RR
            // 
            RR.Location = new Point(583, 353);
            RR.Margin = new Padding(3, 4, 3, 4);
            RR.Name = "RR";
            RR.Size = new Size(121, 31);
            RR.TabIndex = 18;
            RR.Text = "ROUND ROBIN";
            RR.UseVisualStyleBackColor = true;
            // 
            // RES
            // 
            RES.Location = new Point(14, 791);
            RES.Margin = new Padding(3, 4, 3, 4);
            RES.Name = "RES";
            RES.Size = new Size(818, 27);
            RES.TabIndex = 19;
            // 
            // result
            // 
            result.Location = new Point(610, 408);
            result.Multiline = true;
            result.Name = "result";
            result.Size = new Size(546, 361);
            result.TabIndex = 21;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1214, 908);
            Controls.Add(result);
            Controls.Add(RES);
            Controls.Add(RR);
            Controls.Add(PRIO);
            Controls.Add(SJF_NON);
            Controls.Add(SJF_PRE);
            Controls.Add(FCFS);
            Controls.Add(ADD);
            Controls.Add(dataGridView1);
            Controls.Add(quantum);
            Controls.Add(PRIORITY);
            Controls.Add(label5);
            Controls.Add(QUANTUM_TIME);
            Controls.Add(arrival_time);
            Controls.Add(burst_time);
            Controls.Add(process_name);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox process_name;
        private TextBox burst_time;
        private TextBox arrival_time;
        private Label QUANTUM_TIME;
        private Label label5;
        private TextBox PRIORITY;
        private TextBox quantum;
        private DataGridView dataGridView1;
        private Button ADD;
        private Button FCFS;
        private Button SJF_PRE;
        private Button SJF_NON;
        private Button PRIO;
        private Button RR;
        private TextBox RES;
        private TextBox result;
    }
}