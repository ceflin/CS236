using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExampleClassLib;

namespace BinaryIntOpperatorUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        IBinaryIntOperator BuildOperator()
        {
            IBinaryIntOperator res;

            if (ui_radioButtonAdd.Checked)
            {
                res = new IntAddition();
            }
            else
            {
                res = new IntSubtraction();
            }

            return res;
        }

        private void ui_radioButtonAdd_CheckedChanged(object sender, EventArgs e)
        {
            if (ui_radioButtonAdd.Checked)
            {
                ui_labelOperator.Text = "+";
            }
            else
            {
                ui_labelOperator.Text = "-";
            }
        }

        private void ui_radioButtonSub_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ui_buttonOperate_Click(object sender, EventArgs e)
        {
            if(int.TryParse(ui_textBoxX.Text, out var x) && 
                int.TryParse(ui_textBoxY.Text, out var y))
            {
                ui_texBoxAnswer.Text = BuildOperator().Operate(x, y).ToString();
            }
        }
    }
}
