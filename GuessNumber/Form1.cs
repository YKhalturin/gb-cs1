using System;
using System.Drawing;
using System.Windows.Forms;

namespace GuessNumber
{
    public partial class Form1 : Form
    {
        private int _randomNumber;
        private int _tryCount;
        private int _maxCount = 5;

        public Form1()
        {
            InitializeComponent();
        }

        void InitGame()
        {
            Random rnd = new Random();
            _randomNumber = rnd.Next(1, 101);
            _tryCount = 0;
            lblResult.ForeColor = DefaultForeColor;
            lblResult.Text = $@"Попробуйте угадать случайное число от 1 до 100. У вас {_maxCount} попыток";
            btnCheck.Enabled = true;
            tbInputNumber.Text = "";
        }

        void RestartGameDialog()
        {
            if (MessageBox.Show(@"Хотите сыграть еще раз?", @"Новая игра", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                InitGame();
            }
        }

        private void CheckNumber(int number)
        {
            _tryCount++;
            if (number < _randomNumber && _tryCount < _maxCount)
            {
                lblResult.Text = $@"Вы не угадали. Загаданное число больше. Осталось попыток {_maxCount-_tryCount}";
            }
            else if (number > _randomNumber && _tryCount < _maxCount)
            {
                lblResult.Text = $@"Вы не угадали. Загаданное число меньше. Осталось попыток {_maxCount-_tryCount}";
            }
            else if (number == _randomNumber && _tryCount <= _maxCount)
            {
                lblResult.ForeColor = Color.Green;
                lblResult.Text = $@"Поздравляем вы угадали за {_tryCount} попыток";
                btnCheck.Enabled = false;
                RestartGameDialog();
            }
            else
            {
                lblResult.ForeColor = Color.Red;
                lblResult.Text = $@"Вы проиграли. Загадано было число: {_randomNumber}";
                btnCheck.Enabled = false;
                RestartGameDialog();
            }
        }
        

        private void btnCheck_Click(object sender, EventArgs e)
        {
            try
            {
                CheckNumber(Convert.ToInt32(tbInputNumber.Text));
            }
            catch (Exception)
            {
                lblResult.Text = $@"Введите положительное целое число от 1 до 100";
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitGame();
        }
    }
}
