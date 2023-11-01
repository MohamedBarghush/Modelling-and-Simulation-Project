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
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.listBox4 = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.clear_server = new System.Windows.Forms.Button();
            this.label21 = new System.Windows.Forms.Label();
            this.id_field = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.server_time_field = new System.Windows.Forms.TextBox();
            this.server_prob_field = new System.Windows.Forms.TextBox();
            this.server_add = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.numOfServersText = new System.Windows.Forms.TextBox();
            this.stoppinNumText = new System.Windows.Forms.TextBox();
            this.stoppingCriteriaText = new System.Windows.Forms.TextBox();
            this.selectionMethodText = new System.Windows.Forms.TextBox();
            this.Run = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.id_label = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.listBox5 = new System.Windows.Forms.ListBox();
            this.label23 = new System.Windows.Forms.Label();
            this.listBox6 = new System.Windows.Forms.ListBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.listBox7 = new System.Windows.Forms.ListBox();
            this.listBox8 = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(127, 111);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(75, 23);
            this.add.TabIndex = 3;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(23, 111);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(75, 23);
            this.clear.TabIndex = 1;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // inter_prop
            // 
            this.inter_prop.Location = new System.Drawing.Point(115, 85);
            this.inter_prop.Name = "inter_prop";
            this.inter_prop.Size = new System.Drawing.Size(100, 20);
            this.inter_prop.TabIndex = 2;
            // 
            // inter_time
            // 
            this.inter_time.Location = new System.Drawing.Point(115, 58);
            this.inter_time.Name = "inter_time";
            this.inter_time.Size = new System.Drawing.Size(100, 20);
            this.inter_time.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "Interarrival values";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 18);
            this.label5.TabIndex = 5;
            this.label5.Text = "Service time";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(22, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 18);
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
            this.groupBox1.Size = new System.Drawing.Size(230, 141);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Interarrival";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(263, 210);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(117, 108);
            this.listBox1.TabIndex = 8;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(390, 210);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(124, 108);
            this.listBox2.TabIndex = 9;
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.Location = new System.Drawing.Point(263, 380);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(117, 108);
            this.listBox3.TabIndex = 14;
            // 
            // listBox4
            // 
            this.listBox4.FormattingEnabled = true;
            this.listBox4.Location = new System.Drawing.Point(390, 380);
            this.listBox4.Name = "listBox4";
            this.listBox4.Size = new System.Drawing.Size(124, 108);
            this.listBox4.TabIndex = 13;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.clear_server);
            this.groupBox2.Controls.Add(this.label21);
            this.groupBox2.Controls.Add(this.id_field);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.server_time_field);
            this.groupBox2.Controls.Add(this.server_prob_field);
            this.groupBox2.Controls.Add(this.server_add);
            this.groupBox2.Location = new System.Drawing.Point(23, 333);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(230, 162);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Server";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // clear_server
            // 
            this.clear_server.Location = new System.Drawing.Point(25, 128);
            this.clear_server.Name = "clear_server";
            this.clear_server.Size = new System.Drawing.Size(75, 23);
            this.clear_server.TabIndex = 34;
            this.clear_server.Text = "Clear";
            this.clear_server.UseVisualStyleBackColor = true;
            this.clear_server.Click += new System.EventHandler(this.clear_server_Click);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(16, 20);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(147, 24);
            this.label21.TabIndex = 33;
            this.label21.Text = "Servers values";
            // 
            // id_field
            // 
            this.id_field.Location = new System.Drawing.Point(115, 49);
            this.id_field.Name = "id_field";
            this.id_field.Size = new System.Drawing.Size(100, 20);
            this.id_field.TabIndex = 1;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(20, 48);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(69, 18);
            this.label15.TabIndex = 7;
            this.label15.Text = "Server ID";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(22, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 18);
            this.label7.TabIndex = 6;
            this.label7.Text = "Probability";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(22, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 18);
            this.label8.TabIndex = 5;
            this.label8.Text = "Service time";
            // 
            // server_time_field
            // 
            this.server_time_field.Location = new System.Drawing.Point(115, 74);
            this.server_time_field.Name = "server_time_field";
            this.server_time_field.Size = new System.Drawing.Size(100, 20);
            this.server_time_field.TabIndex = 2;
            // 
            // server_prob_field
            // 
            this.server_prob_field.Location = new System.Drawing.Point(115, 102);
            this.server_prob_field.Name = "server_prob_field";
            this.server_prob_field.Size = new System.Drawing.Size(100, 20);
            this.server_prob_field.TabIndex = 3;
            // 
            // server_add
            // 
            this.server_add.Location = new System.Drawing.Point(127, 128);
            this.server_add.Name = "server_add";
            this.server_add.Size = new System.Drawing.Size(75, 23);
            this.server_add.TabIndex = 4;
            this.server_add.Text = "Add";
            this.server_add.UseVisualStyleBackColor = true;
            this.server_add.Click += new System.EventHandler(this.button3_Click);
            // 
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
            this.button2.Location = new System.Drawing.Point(508, 70);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Browse";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(95, 24);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(130, 17);
            this.label10.TabIndex = 17;
            this.label10.Text = "Number Of Servers";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(95, 59);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(118, 17);
            this.label11.TabIndex = 18;
            this.label11.Text = "Stopping Number";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(95, 98);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(113, 17);
            this.label12.TabIndex = 19;
            this.label12.Text = "Stopping Criteria";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(95, 141);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(117, 17);
            this.label13.TabIndex = 20;
            this.label13.Text = "Selection Method";
            // 
            // numOfServersText
            // 
            this.numOfServersText.Location = new System.Drawing.Point(262, 24);
            this.numOfServersText.Name = "numOfServersText";
            this.numOfServersText.Size = new System.Drawing.Size(100, 20);
            this.numOfServersText.TabIndex = 1;
            // 
            // stoppinNumText
            // 
            this.stoppinNumText.Location = new System.Drawing.Point(262, 59);
            this.stoppinNumText.Name = "stoppinNumText";
            this.stoppinNumText.Size = new System.Drawing.Size(100, 20);
            this.stoppinNumText.TabIndex = 2;
            // 
            // stoppingCriteriaText
            // 
            this.stoppingCriteriaText.Location = new System.Drawing.Point(262, 98);
            this.stoppingCriteriaText.Name = "stoppingCriteriaText";
            this.stoppingCriteriaText.Size = new System.Drawing.Size(100, 20);
            this.stoppingCriteriaText.TabIndex = 3;
            // 
            // selectionMethodText
            // 
            this.selectionMethodText.Location = new System.Drawing.Point(262, 141);
            this.selectionMethodText.Name = "selectionMethodText";
            this.selectionMethodText.Size = new System.Drawing.Size(100, 20);
            this.selectionMethodText.TabIndex = 4;
            // 
            // Run
            // 
            this.Run.Location = new System.Drawing.Point(311, 523);
            this.Run.Name = "Run";
            this.Run.Size = new System.Drawing.Size(154, 50);
            this.Run.TabIndex = 25;
            this.Run.Text = "Run";
            this.Run.UseVisualStyleBackColor = true;
            this.Run.Click += new System.EventHandler(this.button4_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(462, 30);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(184, 24);
            this.label14.TabIndex = 26;
            this.label14.Text = "Read data from file";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(260, 342);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(76, 16);
            this.label16.TabIndex = 27;
            this.label16.Text = "Server ID:";
            // 
            // id_label
            // 
            this.id_label.AutoSize = true;
            this.id_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_label.Location = new System.Drawing.Point(342, 342);
            this.id_label.Name = "id_label";
            this.id_label.Size = new System.Drawing.Size(0, 16);
            this.id_label.TabIndex = 28;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(258, 362);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(78, 15);
            this.label17.TabIndex = 29;
            this.label17.Text = "Service Time";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(387, 362);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(64, 15);
            this.label18.TabIndex = 30;
            this.label18.Text = "Probability";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(383, 192);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(64, 15);
            this.label19.TabIndex = 32;
            this.label19.Text = "Probability";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(259, 192);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(95, 15);
            this.label20.TabIndex = 31;
            this.label20.Text = "Interarrival Time";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(519, 192);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(111, 15);
            this.label22.TabIndex = 33;
            this.label22.Text = "Commu Probability";
            // 
            // listBox5
            // 
            this.listBox5.FormattingEnabled = true;
            this.listBox5.Location = new System.Drawing.Point(522, 210);
            this.listBox5.Name = "listBox5";
            this.listBox5.Size = new System.Drawing.Size(124, 108);
            this.listBox5.TabIndex = 34;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(649, 192);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(44, 15);
            this.label23.TabIndex = 35;
            this.label23.Text = "Range";
            // 
            // listBox6
            // 
            this.listBox6.FormattingEnabled = true;
            this.listBox6.Location = new System.Drawing.Point(652, 210);
            this.listBox6.Name = "listBox6";
            this.listBox6.Size = new System.Drawing.Size(124, 108);
            this.listBox6.TabIndex = 36;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(649, 363);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(44, 15);
            this.label24.TabIndex = 40;
            this.label24.Text = "Range";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(520, 363);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(111, 15);
            this.label25.TabIndex = 39;
            this.label25.Text = "Commu Probability";
            // 
            // listBox7
            // 
            this.listBox7.FormattingEnabled = true;
            this.listBox7.Location = new System.Drawing.Point(525, 381);
            this.listBox7.Name = "listBox7";
            this.listBox7.Size = new System.Drawing.Size(117, 108);
            this.listBox7.TabIndex = 38;
            // 
            // listBox8
            // 
            this.listBox8.FormattingEnabled = true;
            this.listBox8.Location = new System.Drawing.Point(652, 381);
            this.listBox8.Name = "listBox8";
            this.listBox8.Size = new System.Drawing.Size(124, 108);
            this.listBox8.TabIndex = 37;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(791, 585);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.listBox7);
            this.Controls.Add(this.listBox8);
            this.Controls.Add(this.listBox6);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.listBox5);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.id_label);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.Run);
            this.Controls.Add(this.selectionMethodText);
            this.Controls.Add(this.stoppingCriteriaText);
            this.Controls.Add(this.stoppinNumText);
            this.Controls.Add(this.numOfServersText);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.listBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label9);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
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
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.ListBox listBox4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox server_time_field;
        private System.Windows.Forms.TextBox server_prob_field;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button server_add;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox numOfServersText;
        private System.Windows.Forms.TextBox stoppinNumText;
        private System.Windows.Forms.TextBox stoppingCriteriaText;
        private System.Windows.Forms.TextBox selectionMethodText;
        private System.Windows.Forms.Button Run;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox id_field;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label id_label;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button clear_server;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.ListBox listBox5;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.ListBox listBox6;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.ListBox listBox7;
        private System.Windows.Forms.ListBox listBox8;
    }
}

