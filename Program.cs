using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using NeuralNetwork;
using MySql;

namespace WindowsFormsApp_Expert_System
{ 
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        /// 

        public static bool Auth = false;
        public static bool Output = false;
        public static double Expertoutput = 0;
        public static double[] output = new double[6];
        static Network net = new Network();
        public static List<Human> HumanList = new List<Human>();
        public static List<int> Balls = new List<int>();


        static async void Trainasync()
        {
            await Task.Run(() => Network.Train(net));
        }

        [STAThread]
        static void Main()
        {
            //Thread thread = new Thread(()=>Network.Train(net));
            //thread.Start();
            //Обучение
            //Trainasync();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Regestr());

            foreach (var human in Program.HumanList)
            {
                Console.WriteLine(human.age.ToString() + "\t" + human.name + "\t" + human.profession + "\t" + human.gender);
            }
            

            if (Auth)
            Application.Run(new ExpertSystemForm());

            foreach(var ball in Balls)
            {
                //Console.WriteLine(ball.ToString());
            }
            if(Balls.Count < 53)
            {
                MessageBox.Show("Тестирование было прервано!");
                Application.Exit();
            }
            else
            {
                Expertoutput = Network.Test(net, Balls); //Тестирование
                if (Expertoutput > 0.6) MySQL.WriteToDB(HumanList);
                Console.WriteLine($"Вывод { Expertoutput}");
                Application.Run(new ExpertOutput());
            }
        }
    }
}
