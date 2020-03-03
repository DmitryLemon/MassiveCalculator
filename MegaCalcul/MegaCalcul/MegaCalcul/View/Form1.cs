using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ninject;

namespace View
{
    public partial class Form1 : Form, IView
    {
        private IKernel kernel;
        private IPresenter presenter;

        public Form1(IKernel kernel)
        {
            this.kernel = kernel;
            this.presenter = kernel.Get<IPresenter>();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void statusShow(double percentage, string status)
        {
            progressBar1.Value = (int)percentage;
            textBox2.Text = status;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            presenter.doAction(1, textBox1.Text);
        }


        private void button2_Click(object sender, EventArgs e)
        {
            presenter.doAction(2, textBox1.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            presenter.doAction(3, textBox1.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            presenter.doAction(4, textBox1.Text);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            presenter.doAction(5, textBox1.Text);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            presenter.doAction(6, textBox1.Text);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            presenter.doAction(7, textBox1.Text);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            presenter.doAction(8, textBox1.Text);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            presenter.doAction(9, textBox1.Text);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            presenter.doAction(10, textBox1.Text);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            presenter.doAction(11, textBox1.Text);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            presenter.doAction(12, textBox1.Text);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
