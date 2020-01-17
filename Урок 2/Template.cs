using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Урок_2
{
    public partial class Template : Form
    {
        public Template()
        {
            InitializeComponent();
        }

        //тип_функции имя_функции(аргументы)(){
        // команды\код.....
        //}

            void sayHello(string name)
        {

            MessageBox.Show("alohomora " + name);
        }
            int matem(int num1, int num2)
        {
            return num1 + num2;
        }
        private void button1_Click(object sender, EventArgs e)
        {


            all += matem(Convert.ToInt32(textBox1.Text));
            MessageBox.Show(Convert.ToString(all));
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
