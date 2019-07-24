using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rodjenihm.MojBroj
{
    public partial class SolveForm : Form
    {
        private string oldText = string.Empty;
        private List<TextBox> txtInput;

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
            oldText = inputNumber.Text;
        }

        private void BtnSolve_Click(object sender, EventArgs e)
        {

        }
    }
}
