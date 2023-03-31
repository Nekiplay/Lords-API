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
            Console.WriteLine("==== Watchtower info ====");
            Console.WriteLine("Attacked: " + lordsAPI.user.isAttacked);

            Console.WriteLine("==== Colisium info ====");
            Console.WriteLine("Rank: " + lordsAPI.colisium.Rank);

            Console.WriteLine("==== User Info ====");
            Console.WriteLine("Power: " + lordsAPI.user.Power);
            Console.WriteLine("Stamina: " + lordsAPI.user.Stamina);
            Console.WriteLine("Gems: " + lordsAPI.user.Gems);
            Console.WriteLine("==== Resources info ====");

            Console.WriteLine("\t==== Food ====");
            Console.WriteLine("\tCurrent: " + Math.Round(lordsAPI.resources.food.Current, 0) + "/" + lordsAPI.resources.food.Maximum);
            Console.WriteLine("\tPer hour: " + lordsAPI.resources.food.PerHour);

            Console.WriteLine("\t==== Stone ====");
            Console.WriteLine("\tCurrent: " + Math.Round(lordsAPI.resources.stone.Current, 0) + "/" + lordsAPI.resources.stone.Maximum);
            Console.WriteLine("\tPer hour: " + lordsAPI.resources.stone.PerHour);

            Console.WriteLine("\t==== Ore ====");
            Console.WriteLine("\tCurrent: " + Math.Round(lordsAPI.resources.ore.Current, 0) + "/" + lordsAPI.resources.ore.Maximum);
            Console.WriteLine("\tPer hour: " + lordsAPI.resources.ore.PerHour);

            Console.WriteLine("\t==== Wood ====");
            Console.WriteLine("\tCurrent: " + Math.Round(lordsAPI.resources.wood.Current, 0) + "/" + lordsAPI.resources.wood.Maximum);
            Console.WriteLine("\tPer hour: " + lordsAPI.resources.wood.PerHour);

            Console.WriteLine("\t==== Gold ====");
            Console.WriteLine("\tCurrent: " + Math.Round(lordsAPI.resources.gold.Current, 0) + "/" + lordsAPI.resources.gold.Maximum);
            Console.WriteLine("\tPer hour: " + lordsAPI.resources.gold.PerHour);

            Console.WriteLine("==== Barrack info ====");
            Console.WriteLine("Army: " + lordsAPI.barrack.Army);

            Console.WriteLine("==== Guild Info ====");
            Console.WriteLine("Help's: " + lordsAPI.guild.Help);
            Console.WriteLine("Gifts: " + lordsAPI.guild.Gifts);
            Console.WriteLine("Money: " + lordsAPI.guild.Money);
        }
    }
}
