using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Containerschip
{
    public partial class Form1 : Form
    {
        Dock dock = new Dock();
        public Form1()
        {
            InitializeComponent();
        }

        public void CreateContainer_Click(object sender, EventArgs e)
        {
            if (Normal.Checked)
            {
                dock.containers.Add(new Container(Cargo.Normal, Convert.ToInt32(Weight.Text)));
            }
            if (Cooled.Checked)
            {
                dock.containers.Add(new Container(Cargo.Cooled, Convert.ToInt32(Weight.Text)));
            }
            else
            {
                dock.containers.Add(new Container(Cargo.Valuable, Convert.ToInt32(Weight.Text)));
            }
        }

        private void Sort_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            for (int i = 0; i < 14; i++)
            {
                dock.containers.Add(new Container(Cargo.Cooled, Convert.ToInt32(random.Next(4000,30000))));
            }
            for (int i = 0; i < 22; i++)
            {
                dock.containers.Add(new Container(Cargo.Normal, Convert.ToInt32(random.Next(4000, 30000))));
            }
            for (int i = 0; i < 15; i++)
            {
                dock.containers.Add(new Container(Cargo.Valuable, Convert.ToInt32(random.Next(4000, 30000))));
            }
            Output.Text = dock.PlaceContainersOnShip(Convert.ToInt32(Width.Text), Convert.ToInt32(Length.Text));
        }
    }
}
