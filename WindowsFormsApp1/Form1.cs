using Lords_API;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Process game = Process.GetProcessesByName("Lords Mobile").First();
            LordsAPI lordsAPI = new LordsAPI(game);
            Console.WriteLine("==== User Info ====");
            Console.WriteLine("Power: " + lordsAPI.user.Power);
            Console.WriteLine("Stamina: " + lordsAPI.user.Stamina);
            Console.WriteLine("Gems: " + lordsAPI.user.Gems);
            Console.WriteLine("==== Guild Info ====");
            Console.WriteLine("Help's: " + lordsAPI.guild.Help);
            Console.WriteLine("Gifts: " + lordsAPI.guild.Gifts);
            Console.WriteLine("Money: " + lordsAPI.guild.Money);
        }
    }
}
