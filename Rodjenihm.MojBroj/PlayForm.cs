using Rodjenihm.Lib.MojBroj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Rodjenihm.MojBroj
{
    public partial class PlayForm : Form
    {
        private List<TextBox> txtInput;
        private List<TextBox> txtTarget;
        private readonly Random random = new Random();

        public PlayForm()
        {
            InitializeComponent();
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            btnRandomize.Enabled = false;
            btnReset.Enabled = true;
        }

        private void PlayForm_Load(object sender, EventArgs e)
        {
            txtInput = new List<TextBox> { txtInput1, txtInput2, txtInput3, txtInput4, txtInput5, txtInput6 };
            txtTarget = new List<TextBox> { txtTarget1, txtTarget2, txtTarget3 };
            timer.Tick += (o, ev) =>
            {
                var nextTime = pgElapsedTime.Value + pgElapsedTime.Step;
                if (nextTime <= pgElapsedTime.Maximum)
                {
                    pgElapsedTime.Value = nextTime;
                }
                else
                {
                    txtInput.ForEach(i => i.Clear());
                    txtTarget.ForEach(i => i.Clear());
                    txtInfo.Clear();
                    btnSubmit.Enabled = false;
                    btnRandomize.Enabled = true;
                    btnReset.Enabled = true;
                    timer.Enabled = false;
                    pgElapsedTime.Value = pgElapsedTime.Minimum;
                    MessageBox.Show("Vreme je isteklo!");
                }
            };
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            ResetUI();
        }

        private void BtnRandomize_Click(object sender, EventArgs e)
        {
            txtInput.ForEach(i => i.Text = random.Next(1, 10).ToString());
            txtTarget.ForEach(i => i.Text = random.Next(1, 10).ToString());
            txtInput5.Text = (10 + 5 * random.Next(0, 3)).ToString();
            txtInput6.Text = (25 * random.Next(1, 5)).ToString();

            pgElapsedTime.Value = pgElapsedTime.Minimum;
            txtAnswer.Clear();
            txtInfo.Clear();
            btnSubmit.Enabled = true;
            btnRandomize.Enabled = false;
            btnReset.Enabled = false;
            timer.Enabled = true;
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            timer.Enabled = false;
            btnReset.Enabled = true;
            btnRandomize.Enabled = true;

            var inputNumbers = txtInput.Select(i => i.Text).ToList();
            var answerInfix = txtAnswer.Text;
            var split = answerInfix.Split(new char[] { '*', '+', '-', '/', '(', ')', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (var token in split)
            {
                if (inputNumbers.Contains(token))
                {
                    inputNumbers.Remove(token);
                }
                else
                {
                    MessageBox.Show("Iskoristili ste broj koji nije ponudjen");
                    return;
                }
            }

            if (Equation.TryConvertInfixToPostfix(answerInfix, out var answerPostfix))
            {
                if (Equation.TryEvaluatePostfixExpression(answerPostfix, out var result))
                {
                    var target = int.Parse(txtTarget1.Text + txtTarget2.Text + txtTarget3.Text);
                    if (result == target)
                    {
                        txtInfo.Text = "Svaka čast. Pronašli ste tačan broj";
                    }
                    else
                    {
                        txtInfo.Text = $"Pronašli ste broj {result}. Ovo nije tačan broj";
                    }
                }
                else
                {
                    txtInfo.Text = "Uneli ste neispravan izraz";
                }
            }
            else
            {
                txtInfo.Text = "Uneli ste neispravan izraz";
            }
        }

        private void ResetUI()
        {
            txtInput.ForEach(i => i.Clear());
            txtTarget.ForEach(i => i.Clear());
            txtAnswer.Clear();
            txtInfo.Clear();
            pgElapsedTime.Value = pgElapsedTime.Minimum;
        }
    }
}
