using Rodjenihm.Lib.MojBroj;
using Rodjenihm.Lib.MojBroj.Solver;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Rodjenihm.MojBroj
{
    public partial class SolveForm : Form
    {
        private string previousText = string.Empty;
        private List<TextBox> txtInput;
        private readonly int smallInputCount = 4;
        private readonly StringBuilder solutionStringBuilder = new StringBuilder();

        public SolveForm()
        {
            InitializeComponent();
        }

        private void SolveForm_Load(object sender, EventArgs e)
        {
            txtInput = new List<TextBox> { txtInput1, txtInput2, txtInput3, txtInput4, txtInput5, txtInput6 };
            txtInput.ForEach(i => i.GotFocus += TxtInput_GotFocus);
        }

        private void TxtInput_GotFocus(object sender, EventArgs e)
        {
            var inputNumber = sender as TextBox;
            previousText = inputNumber.Text;
        }

        private void BtnSolve_Click(object sender, EventArgs e)
        {
            if (IsValidInput())
            {
                var numbers = txtInput.Select(i => int.Parse(i.Text));
                var target = int.Parse(txtTarget.Text);

                ThreadPool.QueueUserWorkItem(o =>
                {
                    var sw = new Stopwatch();
                    sw.Start();
                    var mojBrojSolver = new MojBrojSolver(new SolverEngine3());
                    var solutions = mojBrojSolver.Solve(numbers, target);
                    sw.Stop();
                    txtInfo.Text = $"Broj rešenja: {solutions.Count()}; Vreme izvršavanja: {sw.ElapsedMilliseconds} ms";
                    solutionStringBuilder.Clear();
                    foreach (var solution in solutions)
                    {
                        solutionStringBuilder.Append(solution.Infix + "\r\n");
                    }
                    txtSolutions.Text = solutionStringBuilder.ToString();
                });
            }
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            txtInput.ForEach(i => i.Clear());
            txtTarget.Clear();
            txtSolutions.Clear();
            txtInfo.Clear();
        }

        private bool IsValidInput()
        {
            bool isValid = true;
            int temp;

            for (int i = 0; i < smallInputCount; i++)
            {
                isValid &= int.TryParse(txtInput[i].Text, out temp);
                isValid &= temp >= 1 && temp <= 9;
            }
            if (!isValid)
            {
                MessageBox.Show("Mali brojevi moraju biti u opsegu 1-9!");
                return false;
            }

            isValid &= int.TryParse(txtInput[4].Text, out temp);
            isValid &= temp == 10 || temp == 15 || temp == 20;
            if (!isValid)
            {
                MessageBox.Show("Srednji broj mora biti 10, 15 ili 20");
                return false;
            }

            isValid &= int.TryParse(txtInput[5].Text, out temp);
            isValid &= temp == 25 || temp == 50 || temp == 75 || temp == 100;
            if (!isValid)
            {
                MessageBox.Show("Veliki broj mora biti 25, 50, 75 ili 100");
                return false;
            }

            isValid &= int.TryParse(txtTarget.Text, out temp);
            isValid &= temp >= 1 && temp <= 999;
            if (!isValid)
            {
                MessageBox.Show("Traženi broj mora biti u opsegu 1-999");
                return false;
            }

            return true;
        }
    }
}
