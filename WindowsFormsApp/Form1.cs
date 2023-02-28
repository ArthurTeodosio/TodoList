using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Data_Click(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox.Items.Add($"{dateTimePicker1.Value:d} - {textBox.Text}");
            textBox.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox.SelectedIndex > -1)
                listBox.Items.RemoveAt(listBox.SelectedIndex);
            else
                MessageBox.Show("Selecione um item na Listbox");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
