using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Space_Game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }

    public class player
    {
        int health, age;
        string name;
        List<item> inventory;
        Image avatar;
        player(int h, int a, string n, item w)
        {
            health = h;
            age = a;
            name = n;
            inventory.Add(w);
        }
        
    }

    public class merchant
    {
        string name;
        item holding;
        Image avatar;
        merchant(string n, item h)
        {
            name = n;
            holding = h;
        }

    }

    public class monster
    {
        int health;
        string name;
        Image avatar;
        monster(int h, string n)
        {
            health = h;
            name = n;
        }

    }

    public class planet
    {
        string name;
        merchant local;
        monster baddie;
        Image icon;
        planet(string n, merchant l, monster b)
        {
            name = n;
            local = l;
            baddie = b;
        }
    }

    public class item
    {
        string name;
        Image icon;
        item(string n, Image i)
        {
            name = n;
            icon = i;
        }
    }




}
