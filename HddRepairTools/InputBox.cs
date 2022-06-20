using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HddRepairTools
{
    public partial class InputBox : Form
    {

        public String Input
        {
            get { return textInput.Text; }
        }

        public InputBox()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void InputBox_Load(object sender, EventArgs e)
        {
            this.ActiveControl = textInput;
        }

        public static DialogResult Show(String title, String message, String inputTitle, out String inputValue)
        {
            InputBox inputBox = null;
            DialogResult results = DialogResult.None;

            using (inputBox = new InputBox() { Text = title })
            {
                inputBox.labelMessage.Text = message;
                inputBox.splitContainer2.SplitterDistance = inputBox.labelMessage.Width;
                inputBox.labelInput.Text = inputTitle;
                inputBox.splitContainer1.SplitterDistance = inputBox.labelInput.Width;
                inputBox.Size = new Size(
                    inputBox.Width,
                    8 + inputBox.labelMessage.Height + inputBox.splitContainer2.SplitterWidth + inputBox.splitContainer1.Height + 8 + inputBox.button2.Height + 12 + (50));
                results = inputBox.ShowDialog();
                inputValue = inputBox.Input;
            }

            return results;
        }

        void labelInput_TextChanged(object sender, System.EventArgs e)
        {
        }
    }
}
