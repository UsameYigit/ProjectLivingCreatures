using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectLivingCreatures
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSeeHuman_Click(object sender, EventArgs e)
        {
            Human human = new Human("Adam", 15000, 79.5, 1.75, 11, 2, 34.5);
            MessageBox.Show(human.ToString());
            MessageBox.Show(human.Digest());
            MessageBox.Show(human.Breath());
            MessageBox.Show(human.Move());
            MessageBox.Show(human.Reproduce());
            MessageBox.Show(human.Walk());
        }
    }
}
