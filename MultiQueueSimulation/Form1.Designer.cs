namespace MultiQueueSimulation
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.add = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.inter_prop = new System.Windows.Forms.TextBox();
            this.inter_time = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();

            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.listBox4 = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.serviceTimeServer = new System.Windows.Forms.TextBox();
            this.probabilityServer = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.numOfServersText = new System.Windows.Forms.TextBox();
            this.stoppinNumText = new System.Windows.Forms.TextBox();
            this.stoppingCriteriaText = new System.Windows.Forms.TextBox();
            this.selectionMethodText = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();

            this.label9 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();

            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(168, 146);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(75, 23);
            this.add.TabIndex = 3;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(76, 146);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(75, 23);
            this.clear.TabIndex = 1;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // inter_prop
            // 
            this.inter_prop.Location = new System.Drawing.Point(179, 109);
            this.inter_prop.Name = "inter_prop";
            this.inter_prop.Size = new System.Drawing.Size(100, 22);
            this.inter_prop.TabIndex = 2;
            // 
            // inter_time
            // 
            this.inter_time.Location = new System.Drawing.Point(179, 81);
            this.inter_time.Name = "inter_time";
           
            this.inter_time.Size = new System.Drawing.Size(100, 20);
            this.inter_time.TabIndex = 1;

            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(56, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(219, 29);
            this.label4.TabIndex = 4;
            this.label4.Text = "Interarrival values";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(22, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 24);
            this.label5.TabIndex = 5;
            this.label5.Text = "Service time";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(22, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 24);
            this.label6.TabIndex = 6;
            this.label6.Text = "Probability";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.inter_time);
            this.groupBox1.Controls.Add(this.inter_prop);
            this.groupBox1.Controls.Add(this.clear);
            this.groupBox1.Controls.Add(this.add);
            this.groupBox1.Location = new System.Drawing.Point(23, 186);
            this.groupBox1.Name = "groupBox1";

            this.groupBox1.Size = new System.Drawing.Size(354, 175);

            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Interarrival";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 

            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(392, 229);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(57, 132);
            this.listBox1.TabIndex = 8;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(522, 229);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(58, 132);
            this.listBox2.TabIndex = 9;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(383, 201);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(117, 22);
            this.textBox1.TabIndex = 10;
            this.textBox1.Text = "Interarrival  Time";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(522, 201);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(73, 22);
            this.textBox2.TabIndex = 11;
            this.textBox2.Text = "Probability";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(522, 384);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(73, 22);
            this.textBox3.TabIndex = 16;
            this.textBox3.Text = "Probability";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(383, 384);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(105, 22);
            this.textBox4.TabIndex = 15;
            this.textBox4.Text = "Interarrival  Time";
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 16;
            this.listBox3.Location = new System.Drawing.Point(392, 406);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(57, 132);
            this.listBox3.TabIndex = 14;
            // 
            // listBox4
            // 
            this.listBox4.FormattingEnabled = true;
            this.listBox4.ItemHeight = 16;
            this.listBox4.Location = new System.Drawing.Point(522, 406);
            this.listBox4.Name = "listBox4";
            this.listBox4.Size = new System.Drawing.Size(58, 132);
            this.listBox4.TabIndex = 13;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.serviceTimeServer);
            this.groupBox2.Controls.Add(this.probabilityServer);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Location = new System.Drawing.Point(26, 366);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(351, 172);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Interarrival";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 24);
            this.label7.TabIndex = 6;
            this.label7.Text = "Probability";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 57);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 24);
            this.label8.TabIndex = 5;
            this.label8.Text = "Service time";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(53, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(172, 29);
            this.label9.TabIndex = 4;
            this.label9.Text = "Server values";
            // 
            // serviceTimeServer
            // 
            this.serviceTimeServer.Location = new System.Drawing.Point(176, 57);
            this.serviceTimeServer.Name = "serviceTimeServer";
            this.serviceTimeServer.Size = new System.Drawing.Size(100, 22);
            this.serviceTimeServer.TabIndex = 3;
            // 
            // probabilityServer
            // 
            this.probabilityServer.Location = new System.Drawing.Point(176, 85);
            this.probabilityServer.Name = "probabilityServer";
            this.probabilityServer.Size = new System.Drawing.Size(100, 22);
            this.probabilityServer.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(73, 129);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(165, 129);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 0;
            this.button3.Text = "Add";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(95, 24);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(154, 20);
            this.label10.TabIndex = 17;
            this.label10.Text = "Number Of Servers";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(95, 59);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(138, 20);
            this.label11.TabIndex = 18;
            this.label11.Text = "Stopping Number";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(95, 98);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(134, 20);
            this.label12.TabIndex = 19;
            this.label12.Text = "Stopping Criteria";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(95, 141);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(138, 20);
            this.label13.TabIndex = 20;
            this.label13.Text = "Selection Method";
            // 
            // numOfServersText
            // 
            this.numOfServersText.Location = new System.Drawing.Point(262, 24);
            this.numOfServersText.Name = "numOfServersText";
            this.numOfServersText.Size = new System.Drawing.Size(100, 22);
            this.numOfServersText.TabIndex = 21;
            // 
            // stoppinNumText
            // 
            this.stoppinNumText.Location = new System.Drawing.Point(262, 59);
            this.stoppinNumText.Name = "stoppinNumText";
            this.stoppinNumText.Size = new System.Drawing.Size(100, 22);
            this.stoppinNumText.TabIndex = 22;
            // 
            // stoppingCriteriaText
            // 
            this.stoppingCriteriaText.Location = new System.Drawing.Point(262, 98);
            this.stoppingCriteriaText.Name = "stoppingCriteriaText";
            this.stoppingCriteriaText.Size = new System.Drawing.Size(100, 22);
            this.stoppingCriteriaText.TabIndex = 23;
            // 
            // selectionMethodText
            // 
            this.selectionMethodText.Location = new System.Drawing.Point(262, 141);
            this.selectionMethodText.Name = "selectionMethodText";
            this.selectionMethodText.Size = new System.Drawing.Size(100, 22);
            this.selectionMethodText.TabIndex = 24;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(282, 549);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(154, 50);
            this.button4.TabIndex = 25;
            this.button4.Text = "Run";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(693, 746);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.selectionMethodText);
            this.Controls.Add(this.stoppingCriteriaText);
            this.Controls.Add(this.stoppinNumText);
            this.Controls.Add(this.numOfServersText);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.listBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(100, 234);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 18);
            this.label9.TabIndex = 9;
            this.label9.Text = "Read from file";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(100, 255);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Browse";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(835, 588);
            this.Controls.Add(this.button2);

            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label9);
            this.Name = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox inter_prob;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inter_service_time;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.TextBox inter_prop;
        private System.Windows.Forms.TextBox inter_time;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.ListBox listBox4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox serviceTimeServer;
        private System.Windows.Forms.TextBox probabilityServer;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox numOfServersText;
        private System.Windows.Forms.TextBox stoppinNumText;
        private System.Windows.Forms.TextBox stoppingCriteriaText;
        private System.Windows.Forms.TextBox selectionMethodText;
        private System.Windows.Forms.Button button4;

    }
}

