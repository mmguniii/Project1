using System;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string input = password.Text;
            if (input.Length < 8)
            {
                MessageBox.Show("Şifrə ən azı 8 simvol olmalıdır");
                return;
            }

            string big = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string small = "abcdefghijklmnopqrstuvwxyz";
            string nums = "0123456789";
            string specials = "!@#$%^&*()-_=+[]{}|;:'\",.<>?/`~";

            bool hasBig = false, hasSmall = false, hasNum = false, hasSpec = false;
            bool tripleSeq = false;

            for (int i = 0; i < input.Length; i++)
            {
                char c = input[i];

                if (char.IsDigit(c)) hasNum = true;
                else if (char.IsUpper(c)) hasBig = true;
                else if (char.IsLower(c)) hasSmall = true;
                else if (specials.Contains(c)) hasSpec = true;

                if (i + 2 < input.Length)
                {
                    if ((char.IsDigit(c) && char.IsDigit(input[i + 1]) && char.IsDigit(input[i + 2])) ||
                        (char.IsUpper(c) && char.IsUpper(input[i + 1]) && char.IsUpper(input[i + 2])) ||
                        (char.IsLower(c) && char.IsLower(input[i + 1]) && char.IsLower(input[i + 2])) ||
                        (specials.Contains(c) && specials.Contains(input[i + 1]) && specials.Contains(input[i + 2])))
                    {
                        tripleSeq = true;
                    }
                }
            }

            if (hasBig && hasSmall && hasNum && hasSpec && !tripleSeq)
            {
                MessageBox.Show("Şifrə uğurla yaradıldı");
            }
            else
            {
                if (!hasBig) MessageBox.Show("Ən azı 1 böyük hərf olmalıdır");
                if (!hasSmall) MessageBox.Show("Ən azı 1 kiçik hərf olmalıdır");
                if (!hasNum) MessageBox.Show("Ən azı 1 rəqəm olmalıdır");
                if (!hasSpec) MessageBox.Show("Ən azı 1 xüsusi simvol olmalıdır");
                if (tripleSeq) MessageBox.Show("Eyni tip simvoldan ard-arda 3 dəfə istifadə olunmaz");
            }
        }
    }
}
