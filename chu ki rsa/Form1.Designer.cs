namespace chu_ki_rsa
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
            this.btnFile = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSHA1 = new System.Windows.Forms.TextBox();
            this.txtSHA2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.txtp = new System.Windows.Forms.TextBox();
            this.txtn = new System.Windows.Forms.TextBox();
            this.txtn2 = new System.Windows.Forms.TextBox();
            this.txtq = new System.Windows.Forms.TextBox();
            this.txte = new System.Windows.Forms.TextBox();
            this.txtd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btntaokhoa = new System.Windows.Forms.Button();
            this.btntaokhoamoi = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_banma = new System.Windows.Forms.TextBox();
            this.txt_banro = new System.Windows.Forms.TextBox();
            this.txt_ma_ban_ma = new System.Windows.Forms.TextBox();
            this.btnmahoamoi = new System.Windows.Forms.Button();
            this.btnmahoa = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_ma_ban_ro = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.txt_banro2 = new System.Windows.Forms.TextBox();
            this.txt_giaima = new System.Windows.Forms.TextBox();
            this.txt_banma2 = new System.Windows.Forms.TextBox();
            this.btngiaima = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.txt_ma_giai_ma = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnFile
            // 
            this.btnFile.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnFile.Location = new System.Drawing.Point(137, 29);
            this.btnFile.Margin = new System.Windows.Forms.Padding(4);
            this.btnFile.Name = "btnFile";
            this.btnFile.Size = new System.Drawing.Size(161, 28);
            this.btnFile.TabIndex = 0;
            this.btnFile.Text = "Chọn File";
            this.btnFile.UseVisualStyleBackColor = true;
            this.btnFile.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 796);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Băm SHA-1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtSHA1
            // 
            this.txtSHA1.Location = new System.Drawing.Point(148, 772);
            this.txtSHA1.Margin = new System.Windows.Forms.Padding(4);
            this.txtSHA1.Multiline = true;
            this.txtSHA1.Name = "txtSHA1";
            this.txtSHA1.Size = new System.Drawing.Size(132, 58);
            this.txtSHA1.TabIndex = 2;
            this.txtSHA1.TextChanged += new System.EventHandler(this.txtSHA1_TextChanged);
            // 
            // txtSHA2
            // 
            this.txtSHA2.Location = new System.Drawing.Point(328, 774);
            this.txtSHA2.Margin = new System.Windows.Forms.Padding(4);
            this.txtSHA2.Multiline = true;
            this.txtSHA2.Name = "txtSHA2";
            this.txtSHA2.Size = new System.Drawing.Size(132, 56);
            this.txtSHA2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(288, 796);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "==>";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(105, 33);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(90, 21);
            this.radioButton1.TabIndex = 3;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Tùy Chọn";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(332, 33);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(84, 21);
            this.radioButton2.TabIndex = 3;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Tự Động";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged_1);
            // 
            // txtp
            // 
            this.txtp.Location = new System.Drawing.Point(105, 92);
            this.txtp.Margin = new System.Windows.Forms.Padding(4);
            this.txtp.Name = "txtp";
            this.txtp.Size = new System.Drawing.Size(132, 22);
            this.txtp.TabIndex = 4;
            this.txtp.TextChanged += new System.EventHandler(this.txtp_TextChanged);
            // 
            // txtn
            // 
            this.txtn.Location = new System.Drawing.Point(105, 151);
            this.txtn.Margin = new System.Windows.Forms.Padding(4);
            this.txtn.Name = "txtn";
            this.txtn.Size = new System.Drawing.Size(132, 22);
            this.txtn.TabIndex = 4;
            // 
            // txtn2
            // 
            this.txtn2.Location = new System.Drawing.Point(105, 213);
            this.txtn2.Margin = new System.Windows.Forms.Padding(4);
            this.txtn2.Name = "txtn2";
            this.txtn2.Size = new System.Drawing.Size(132, 22);
            this.txtn2.TabIndex = 4;
            // 
            // txtq
            // 
            this.txtq.Location = new System.Drawing.Point(344, 92);
            this.txtq.Margin = new System.Windows.Forms.Padding(4);
            this.txtq.Name = "txtq";
            this.txtq.Size = new System.Drawing.Size(115, 22);
            this.txtq.TabIndex = 4;
            // 
            // txte
            // 
            this.txte.Location = new System.Drawing.Point(344, 151);
            this.txte.Margin = new System.Windows.Forms.Padding(4);
            this.txte.Name = "txte";
            this.txte.Size = new System.Drawing.Size(115, 22);
            this.txte.TabIndex = 4;
            // 
            // txtd
            // 
            this.txtd.Location = new System.Drawing.Point(344, 213);
            this.txtd.Margin = new System.Windows.Forms.Padding(4);
            this.txtd.Name = "txtd";
            this.txtd.Size = new System.Drawing.Size(115, 22);
            this.txtd.TabIndex = 4;
            this.txtd.TextChanged += new System.EventHandler(this.txtd_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 97);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "p=";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(73, 156);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "n=";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(57, 216);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Phi-n";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(312, 97);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "q=";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(312, 156);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 17);
            this.label7.TabIndex = 1;
            this.label7.Text = "e=";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(312, 216);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 17);
            this.label8.TabIndex = 1;
            this.label8.Text = "d=";
            // 
            // btntaokhoa
            // 
            this.btntaokhoa.Location = new System.Drawing.Point(79, 290);
            this.btntaokhoa.Margin = new System.Windows.Forms.Padding(4);
            this.btntaokhoa.Name = "btntaokhoa";
            this.btntaokhoa.Size = new System.Drawing.Size(159, 28);
            this.btntaokhoa.TabIndex = 5;
            this.btntaokhoa.Text = "Tạo Khóa";
            this.btntaokhoa.UseVisualStyleBackColor = true;
            this.btntaokhoa.Click += new System.EventHandler(this.btntaokhoa_Click);
            // 
            // btntaokhoamoi
            // 
            this.btntaokhoamoi.Location = new System.Drawing.Point(300, 290);
            this.btntaokhoamoi.Margin = new System.Windows.Forms.Padding(4);
            this.btntaokhoamoi.Name = "btntaokhoamoi";
            this.btntaokhoamoi.Size = new System.Drawing.Size(159, 28);
            this.btntaokhoamoi.TabIndex = 5;
            this.btntaokhoamoi.Text = "Nhập Khóa Mới";
            this.btntaokhoamoi.UseVisualStyleBackColor = true;
            this.btntaokhoamoi.Click += new System.EventHandler(this.btntaokhoamoi_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtq);
            this.groupBox1.Controls.Add(this.btntaokhoamoi);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btntaokhoa);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtd);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtn2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txte);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.txtn);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.txtp);
            this.groupBox1.Location = new System.Drawing.Point(13, 196);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(480, 522);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tạo Khóa";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_banma);
            this.groupBox2.Controls.Add(this.txt_banro);
            this.groupBox2.Controls.Add(this.txt_ma_ban_ma);
            this.groupBox2.Controls.Add(this.btnmahoamoi);
            this.groupBox2.Controls.Add(this.btnmahoa);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txt_ma_ban_ro);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.btnFile);
            this.groupBox2.Location = new System.Drawing.Point(511, 196);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(425, 522);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Mã hóa";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // txt_banma
            // 
            this.txt_banma.Location = new System.Drawing.Point(137, 226);
            this.txt_banma.Margin = new System.Windows.Forms.Padding(4);
            this.txt_banma.Multiline = true;
            this.txt_banma.Name = "txt_banma";
            this.txt_banma.Size = new System.Drawing.Size(269, 124);
            this.txt_banma.TabIndex = 4;
            // 
            // txt_banro
            // 
            this.txt_banro.Location = new System.Drawing.Point(137, 92);
            this.txt_banro.Margin = new System.Windows.Forms.Padding(4);
            this.txt_banro.Multiline = true;
            this.txt_banro.Name = "txt_banro";
            this.txt_banro.Size = new System.Drawing.Size(269, 124);
            this.txt_banro.TabIndex = 4;
            this.txt_banro.TextChanged += new System.EventHandler(this.txt_banro_TextChanged);
            // 
            // txt_ma_ban_ma
            // 
            this.txt_ma_ban_ma.Enabled = false;
            this.txt_ma_ban_ma.Location = new System.Drawing.Point(291, 290);
            this.txt_ma_ban_ma.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ma_ban_ma.Name = "txt_ma_ban_ma";
            this.txt_ma_ban_ma.Size = new System.Drawing.Size(101, 22);
            this.txt_ma_ban_ma.TabIndex = 4;
            // 
            // btnmahoamoi
            // 
            this.btnmahoamoi.Location = new System.Drawing.Point(233, 400);
            this.btnmahoamoi.Margin = new System.Windows.Forms.Padding(4);
            this.btnmahoamoi.Name = "btnmahoamoi";
            this.btnmahoamoi.Size = new System.Drawing.Size(159, 28);
            this.btnmahoamoi.TabIndex = 9;
            this.btnmahoamoi.Text = "Nhập Mới";
            this.btnmahoamoi.UseVisualStyleBackColor = true;
            this.btnmahoamoi.Click += new System.EventHandler(this.btnmahoamoi_Click);
            // 
            // btnmahoa
            // 
            this.btnmahoa.Location = new System.Drawing.Point(37, 400);
            this.btnmahoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnmahoa.Name = "btnmahoa";
            this.btnmahoa.Size = new System.Drawing.Size(159, 28);
            this.btnmahoa.TabIndex = 5;
            this.btnmahoa.Text = "Mã Hóa";
            this.btnmahoa.UseVisualStyleBackColor = true;
            this.btnmahoa.Click += new System.EventHandler(this.btnmahoa_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(42, 246);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 17);
            this.label10.TabIndex = 1;
            this.label10.Text = "Bản Mã Hóa";
            // 
            // txt_ma_ban_ro
            // 
            this.txt_ma_ban_ro.Enabled = false;
            this.txt_ma_ban_ro.Location = new System.Drawing.Point(291, 101);
            this.txt_ma_ban_ro.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ma_ban_ro.Name = "txt_ma_ban_ro";
            this.txt_ma_ban_ro.Size = new System.Drawing.Size(97, 22);
            this.txt_ma_ban_ro.TabIndex = 4;
            this.txt_ma_ban_ro.TextChanged += new System.EventHandler(this.txt_ma_ban_ro_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 101);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 17);
            this.label9.TabIndex = 1;
            this.label9.Text = "Nhập vào Bản Rõ";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.txt_banro2);
            this.groupBox3.Controls.Add(this.txt_giaima);
            this.groupBox3.Controls.Add(this.txt_banma2);
            this.groupBox3.Controls.Add(this.btngiaima);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label21);
            this.groupBox3.Controls.Add(this.txt_ma_giai_ma);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Location = new System.Drawing.Point(957, 196);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(513, 522);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Xác thực";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(230, 23);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(154, 28);
            this.button2.TabIndex = 6;
            this.button2.Text = "Chọn File";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txt_banro2
            // 
            this.txt_banro2.Location = new System.Drawing.Point(230, 88);
            this.txt_banro2.Margin = new System.Windows.Forms.Padding(4);
            this.txt_banro2.Multiline = true;
            this.txt_banro2.Name = "txt_banro2";
            this.txt_banro2.Size = new System.Drawing.Size(269, 128);
            this.txt_banro2.TabIndex = 4;
            // 
            // txt_giaima
            // 
            this.txt_giaima.Location = new System.Drawing.Point(230, 358);
            this.txt_giaima.Margin = new System.Windows.Forms.Padding(4);
            this.txt_giaima.Multiline = true;
            this.txt_giaima.Name = "txt_giaima";
            this.txt_giaima.Size = new System.Drawing.Size(269, 75);
            this.txt_giaima.TabIndex = 4;
            this.txt_giaima.TextChanged += new System.EventHandler(this.txt_giaima_TextChanged);
            // 
            // txt_banma2
            // 
            this.txt_banma2.Location = new System.Drawing.Point(230, 224);
            this.txt_banma2.Margin = new System.Windows.Forms.Padding(4);
            this.txt_banma2.Multiline = true;
            this.txt_banma2.Name = "txt_banma2";
            this.txt_banma2.Size = new System.Drawing.Size(269, 126);
            this.txt_banma2.TabIndex = 4;
            // 
            // btngiaima
            // 
            this.btngiaima.Location = new System.Drawing.Point(230, 475);
            this.btngiaima.Margin = new System.Windows.Forms.Padding(4);
            this.btngiaima.Name = "btngiaima";
            this.btngiaima.Size = new System.Drawing.Size(154, 28);
            this.btngiaima.TabIndex = 5;
            this.btngiaima.Text = "Xác thực chữ ký";
            this.btngiaima.UseVisualStyleBackColor = true;
            this.btngiaima.Click += new System.EventHandler(this.btngiaima_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(56, 246);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(147, 17);
            this.label11.TabIndex = 1;
            this.label11.Text = "Nhập Lại Bản Mã Hóa";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(56, 101);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(116, 17);
            this.label21.TabIndex = 1;
            this.label21.Text = "Nhập Lại Bản Rõ";
            // 
            // txt_ma_giai_ma
            // 
            this.txt_ma_giai_ma.Enabled = false;
            this.txt_ma_giai_ma.Location = new System.Drawing.Point(282, 314);
            this.txt_ma_giai_ma.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ma_giai_ma.Name = "txt_ma_giai_ma";
            this.txt_ma_giai_ma.Size = new System.Drawing.Size(104, 22);
            this.txt_ma_giai_ma.TabIndex = 4;
            this.txt_ma_giai_ma.TextChanged += new System.EventHandler(this.txt_ma_giai_ma_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(56, 400);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 17);
            this.label12.TabIndex = 1;
            this.label12.Text = "Giải Mã";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.Tomato;
            this.label13.Location = new System.Drawing.Point(532, 442);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(0, 17);
            this.label13.TabIndex = 10;
            this.label13.MouseHover += new System.EventHandler(this.label13_MouseHover);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(259, 473);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(0, 17);
            this.label14.TabIndex = 11;
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(259, 513);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(0, 17);
            this.label15.TabIndex = 11;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(545, 31);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(306, 17);
            this.label16.TabIndex = 12;
            this.label16.Text = "CHƯƠNG TRÌNH DEMO CHỮ KÝ ĐIỆN TỬ RSA";
            this.label16.Click += new System.EventHandler(this.label16_Click_1);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(622, 74);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(309, 17);
            this.label17.TabIndex = 13;
            this.label17.Text = "Giảng viên hướng dẫn: ThS.Nguyễn Xuân Thảo";
            this.label17.Click += new System.EventHandler(this.label17_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(622, 101);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(171, 17);
            this.label18.TabIndex = 14;
            this.label18.Text = "Nhóm sinh viên thực hiện:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(799, 101);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(209, 34);
            this.label19.TabIndex = 15;
            this.label19.Text = "1.Phạm Quang Thuận - 646020\r\n2. Đỗ Hải Việt - 645895\r\n";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(1121, 101);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(0, 17);
            this.label20.TabIndex = 16;
            this.label20.Click += new System.EventHandler(this.label20_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1483, 843);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtSHA2);
            this.Controls.Add(this.txtSHA1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Chữ ký điện tử RSA";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSHA1;
        private System.Windows.Forms.TextBox txtSHA2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.TextBox txtp;
        private System.Windows.Forms.TextBox txtn;
        private System.Windows.Forms.TextBox txtn2;
        private System.Windows.Forms.TextBox txtq;
        private System.Windows.Forms.TextBox txte;
        private System.Windows.Forms.TextBox txtd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btntaokhoa;
        private System.Windows.Forms.Button btntaokhoamoi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_banma;
        private System.Windows.Forms.TextBox txt_banro;
        private System.Windows.Forms.TextBox txt_ma_ban_ma;
        private System.Windows.Forms.Button btnmahoa;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txt_giaima;
        private System.Windows.Forms.TextBox txt_banma2;
        private System.Windows.Forms.Button btngiaima;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_ma_giai_ma;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnmahoamoi;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txt_banro2;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txt_ma_ban_ro;
    }
}

