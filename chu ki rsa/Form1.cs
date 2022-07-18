using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace chu_ki_rsa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private bool active_key = false;
        private bool decryptable = true;
        int p, q, n, e, d, phi_n;

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog oFile = new OpenFileDialog();
            string ma = "";
           
            if (oFile.ShowDialog() == DialogResult.OK)
            {

                string a = oFile.FileName;
                byte[] by = System.IO.File.ReadAllBytes(a);
                for (int i = 0; i < by.Length; i++)
                {
                    ma += by[i].ToString();
                }
                MessageBox.Show(by.Length.ToString());
                txtSHA1.Text = ma;
                label2_Click(sender, e);
                txt_banro.Text = txtSHA2.Text;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            radioButton1.Checked = true;

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btntaokhoa_Click(object sender, EventArgs e)
        {
            if (txtp.Text == "" || txtq.Text == "")
                MessageBox.Show("Bạn phải nhập đủ 2 số ", "Thông Báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                p = Convert.ToInt16(txtp.Text);
                q = Convert.ToInt16(txtq.Text);
                if (p == q)
                {
                    MessageBox.Show("Bạn phải nhập 2 số khác nhau ", " Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtq.Focus();
                }
                else
                {
                    if (!kiemTraNguyenTo(p) || p <= 1)
                    {
                        MessageBox.Show("Bạn phải nhập số nguyên  tố [p] lớn hơn 1 ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtp.Focus();
                    }
                    else
                    {
                        if (!kiemTraNguyenTo(q) || q <= 1)
                        {
                            MessageBox.Show("Bạn phải nhập số nguyên  tố [q] lớn hơn 1 ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtq.Focus();
                        }
                        else
                        {
                            taoKhoa();
                            txtp.Text = "" + p;
                            txtq.Text = "" + q;
                            txtn.Text = "" + n;
                            txtn2.Text = "" + phi_n;
                            txtd.Text = "" + d;
                            active_key = true;
                        }
                    }
                }
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            btntaokhoa.Enabled = true;
            btntaokhoamoi.Enabled = true;
            
            btntaokhoamoi.Show();
            reset();
        }

        private void radioButton2_CheckedChanged_1(object sender, EventArgs e)
        {
            btntaokhoa.Enabled = false;
            btntaokhoamoi.Enabled = false;
            btntaokhoamoi.Hide();
            
            reset_tudong();
            p = q = 0;
            do
            {
                p = soNgauNhien();
                q = soNgauNhien();
            }
            while (p == q || !kiemTraNguyenTo(p) || !kiemTraNguyenTo(q));
            taoKhoa();
            txtp.Text = "" + p;
            txtq.Text = "" + q;
            txtn.Text = "" + n;
            txtn2.Text = "" + phi_n;
            txtd.Text = "" + d;

            active_key = true;
        }
        private void reset()
        {
            txtq.Text = "";
            txtp.Text = "";
            txtn2.Text = "";
            txtn.Text = "";
            txte.Text = "";
            txtd.Text = "";

            txtd.Enabled = false;
            txte.Enabled = false;
            txtn.Enabled = false;
            txtn2.Enabled = false;
            txtp.Enabled = true;
            txtq.Enabled = true;
            q = p = 0;
        }
        private void reset_tudong()
        {
            txtq.Text = "";
            txtp.Text = "";
            txtn2.Text = "";
            txtn.Text = "";
            txte.Text = "";
            txtd.Text = "";
            txtd.Enabled = false;
            txte.Enabled = false;
            txtn.Enabled = false;
            txtn2.Enabled = false;
            txtp.Enabled = false;
            txtq.Enabled = false;

        }
        private int soNgauNhien()
        {
            Random rd = new Random();
            return rd.Next(11, 101);
        }
        private bool kiemTraNguyenTo(int i)
        {
            bool kiemtra = true;
            for (int j = 2; j < i; j++)
                if (i % j == 0)
                {
                    kiemtra = false;
                    break;
                }
            return kiemtra;
        }
        private bool nguyenToCungNhau(int a, int b)
        {
            bool kiemtra = true;
            for (int i = 2; i <= a; i++)
                if (a % i == 0 && b % i == 0)
                    kiemtra = false;
            return kiemtra;
        }
        private void taoKhoa()
        {
            //Tinh n=p*q
            n = p * q;

            //Tính Phi(n)=(p-1)*(q-1)
            phi_n = (p - 1) * (q - 1);

            //Tính e là một số ngẫu nhiên có giá trị 0< e <phi(n) và là số nguyên tố cùng nhau với Phi(n)
            do
            {
                Random rd = new Random();
                e = rd.Next(2, phi_n);
            }
            while (!nguyenToCungNhau(e, phi_n));
            txte.Text = Convert.ToString(e);
            //Tính d
            d = 0;
            int i = 2;
            while (((1 + i * phi_n) % e) != 0 || d <= 0)
            {
                i++;
                d = (1 + i * phi_n) / e;
            }
            txtd.Text = Convert.ToString(d);

        }
        public int mod(int m, int e, int n)
        {


            //Sử dụng thuật toán "bình phương nhân"
            //Chuyển e sang hệ nhị phân
            int[] a = new int[100];
            int k = 0;
            do
            {
                a[k] = e % 2;
                k++;
                e = e / 2;
            }
            while (e != 0);
            //Quá trình lấy dư
            int kq = 1;
            for (int i = k - 1; i >= 0; i--)
            {
                kq = (kq * kq) % n;
                if (a[i] == 1)
                    kq = (kq * m) % n;
            }
            return kq;



            /* cách khác
             * int kq = 1;
             * while ( e > 0)
             * {
             *    if((e & 1) == 1)
             *     {
             *         kq = (kq + m)%n;
             *     }
             *     e = e >> 1;
             *     m = (m * m) % n;
             * }
             * return kq
             * */
        }
        public string chuoi(int[] a) //Lấy chuỗi từ mảng ra xâu S
        {
            string s = "";


            for (int i = 0; i < a.Length - 1; i++)
            {
                s = s + a[i].ToString() + "-";
            }
            s = s + a[a.Length - 1].ToString();
            return s;
        }
        public void MaHoa(string s) // mã hóa
        {
            taoKhoa();
            // Chuyen xau thanh ma Unicode
            int[] nguyen = new int[s.Length];
            for (int i = 0; i < s.Length; i++)
            {
                nguyen[i] = (int)s[i];
            }
            txt_ma_ban_ro.Text = chuoi(nguyen);
            //Mảng a chứa các kí tự đã mã hóa
            int[] a = new int[nguyen.Length];
            for (int i = 0; i < nguyen.Length; i++)
            {
                a[i] = mod(nguyen[i], d, n);
            }
            txt_ma_ban_ma.Text = chuoi(a);
            //Chuyển sang kiểu kí tự trong bảng mã Unicode
            string str = "";
            for (int i = 0; i < nguyen.Length; i++)
            {
                str = str + (char)a[i];
            }
            byte[] data = Encoding.Unicode.GetBytes(str);
            txt_banma.Text = Convert.ToBase64String(data);
        }
        public void GiaiMa(string s)
        {
            //Lấy mã Unicode của từng kí tự mã hóa
            string giaima = Encoding.Unicode.GetString(Convert.FromBase64String(s));
            int[] b = new int[giaima.Length];
            for (int i = 0; i < giaima.Length; i++)
            {
                b[i] = (int)giaima[i];
            }
            //Giải mã
            int[] c = new int[b.Length];
            for (int i = 0; i < c.Length; i++)
            {
                c[i] = mod(b[i], e, n);
            }
            txt_ma_giai_ma.Text = chuoi(c);
            string str = "";
            for (int i = 0; i < c.Length; i++)
            {
                str = str + (char)c[i];
            }
            txt_giaima.Text = str;
        }

        private void btnkhoatudongmoi_Click(object sender, EventArgs e)
        {
            reset_tudong();
            p = q = 0;
            do
            {
                p = soNgauNhien();
                q = soNgauNhien();
            }
            while (p == q || !kiemTraNguyenTo(p) || !kiemTraNguyenTo(q));
            taoKhoa();
            txtp.Text = "" + p;
            txtq.Text = "" + q;
            txtn.Text = "" + n;
            txtn2.Text = "" + phi_n;
            txtd.Text = "" + d;

            active_key = true;
        }

        private void btntaokhoamoi_Click(object sender, EventArgs e)
        {
            reset();
            this.btnmahoamoi_Click(sender, e);
        }

        private void btnmahoamoi_Click(object sender, EventArgs e)
        {
            txt_banma.Text = "";
            txt_banro.Text = "";
            txt_giaima.Text = "";
            txt_ma_ban_ma.Text = "";
            txt_ma_ban_ro.Text = "";
            txt_ma_giai_ma.Text = "";
            decryptable = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            string a = txtSHA1.Text;
            txtSHA2.Text = EncodeSHA1(a);
        }
        public string EncodeSHA1 (string pass)
        {

            SHA1CryptoServiceProvider sha1 = new SHA1CryptoServiceProvider();
            //Chuyen pass tu chuoi ra mang byte
            byte[] bs = System.Text.Encoding.UTF8.GetBytes(pass);

            //Bam mang byte cua pass
            bs = sha1.ComputeHash(bs);

            //Chuyen ket qua tu byte sang string
            System.Text.StringBuilder s = new System.Text.StringBuilder();

            //x1 viet thuong, X1 viet hoa
            foreach (byte b in bs)
            {

                s.Append(b.ToString("x1").ToLower());

            }

            pass = s.ToString();

            return pass;

        }

        private void btnmahoa_Click(object sender, EventArgs e)
        {
            if (active_key == false)
                MessageBox.Show("Bạn phải tạo khóa trước ", "Thông Báo", MessageBoxButtons.OK,MessageBoxIcon.Error);
            else
                try
                {
                    MaHoa(txt_banro.Text);
                    decryptable = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }

        private void txtp_TextChanged(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void txt_ma_ban_ro_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_banro_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSHA1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txt_ma_giai_ma_TextChanged(object sender, EventArgs e)
        {

        }

        private void label16_Click_1(object sender, EventArgs e)
        {

        }

        private void label20_Click_1(object sender, EventArgs e)
        {

        }

        private void txt_giaima_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtd_TextChanged(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void btngiaima_Click(object sender, EventArgs e)
        {
            if (txt_banma2.Text == "")
                MessageBox.Show("Bạn phải nhập khóa trước ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                try
                {
                    GiaiMa(txt_banma2.Text);
                    if (txt_banro2.Text == txt_giaima.Text)
                    {
                        MessageBox.Show("chữ kí đúng !");
                    }
                    else MessageBox.Show("chữ kí sai hoặc là không đúng người gửi, hoặc là nội dung đã bị sửa hoặc cả 2");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int a1 = 3;
            string a = "";
             a +=   (char)a1;
            MessageBox.Show(a);
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label13_MouseHover(object sender, EventArgs e)
        {
            label13.ForeColor = Color.LightBlue;
        }

        private void button2_Click(object sender, EventArgs e)
        {
             OpenFileDialog oFile = new OpenFileDialog();
            string ma = "";
           
            if (oFile.ShowDialog() == DialogResult.OK)
            {

                string a = oFile.FileName;
                byte[] by = System.IO.File.ReadAllBytes(a);
                for (int i = 0; i < by.Length; i++)
                {
                    ma += by[i].ToString();
                }
                MessageBox.Show(by.Length.ToString());
                txtSHA1.Text = ma;
                label2_Click(sender, e);
                txt_banro2.Text = txtSHA2.Text;
            }
        }

    }
}
