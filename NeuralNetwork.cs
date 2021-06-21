using System.Xml;
using static System.Math;
using static System.Console;
using System.IO;
using System.Collections.Generic;
using System.Xml.Serialization;
using static DataSet.DataSet;
using static System.Threading.Monitor;
using System.Threading;
using System.Threading.Tasks;
using System;

enum MemoryMode { GET, SET }
enum NeuronType { Hidden, Output }

namespace NeuralNetwork
{
    class InputLayer
    {
        private (double[], double[])[] _trainset = new (double[], double[])[]//да-да, массив кортежей из 2 массивов
        {
            (CsvWriterToArray(0,"DataSet.xml"), CsvWriterToArray(0,"DataSetResult.xml")),
            (CsvWriterToArray(1,"DataSet.xml"), CsvWriterToArray(1,"DataSetResult.xml")),
            (CsvWriterToArray(2,"DataSet.xml"), CsvWriterToArray(2,"DataSetResult.xml")),
            (CsvWriterToArray(3,"DataSet.xml"), CsvWriterToArray(3,"DataSetResult.xml")),
            (CsvWriterToArray(4,"DataSet.xml"), CsvWriterToArray(4,"DataSetResult.xml")),
            (CsvWriterToArray(5,"DataSet.xml"), CsvWriterToArray(5,"DataSetResult.xml")),
            (CsvWriterToArray(6,"DataSet.xml"), CsvWriterToArray(6,"DataSetResult.xml")),
            (CsvWriterToArray(7,"DataSet.xml"), CsvWriterToArray(7,"DataSetResult.xml")),
            (CsvWriterToArray(8,"DataSet.xml"), CsvWriterToArray(8,"DataSetResult.xml")),
            (CsvWriterToArray(9,"DataSet.xml"), CsvWriterToArray(9,"DataSetResult.xml")),
            (CsvWriterToArray(10,"DataSet.xml"), CsvWriterToArray(10,"DataSetResult.xml")),
            (CsvWriterToArray(11,"DataSet.xml"), CsvWriterToArray(11,"DataSetResult.xml")),
            (CsvWriterToArray(12,"DataSet.xml"), CsvWriterToArray(12,"DataSetResult.xml")),
            (CsvWriterToArray(13,"DataSet.xml"), CsvWriterToArray(13,"DataSetResult.xml")),
            (CsvWriterToArray(14,"DataSet.xml"), CsvWriterToArray(14,"DataSetResult.xml")),
            (CsvWriterToArray(15,"DataSet.xml"), CsvWriterToArray(15,"DataSetResult.xml")),
            (CsvWriterToArray(16,"DataSet.xml"), CsvWriterToArray(16,"DataSetResult.xml")),
            (CsvWriterToArray(17,"DataSet.xml"), CsvWriterToArray(17,"DataSetResult.xml")),
            (CsvWriterToArray(18,"DataSet.xml"), CsvWriterToArray(18,"DataSetResult.xml")),
            (CsvWriterToArray(19,"DataSet.xml"), CsvWriterToArray(19,"DataSetResult.xml")),
            (CsvWriterToArray(20,"DataSet.xml"), CsvWriterToArray(20,"DataSetResult.xml")),
            (CsvWriterToArray(21,"DataSet.xml"), CsvWriterToArray(21,"DataSetResult.xml")),
            (CsvWriterToArray(22,"DataSet.xml"), CsvWriterToArray(22,"DataSetResult.xml")),
            (CsvWriterToArray(23,"DataSet.xml"), CsvWriterToArray(23,"DataSetResult.xml")),
            (CsvWriterToArray(24,"DataSet.xml"), CsvWriterToArray(24,"DataSetResult.xml")),
            (CsvWriterToArray(25,"DataSet.xml"), CsvWriterToArray(25,"DataSetResult.xml")),
            (CsvWriterToArray(26,"DataSet.xml"), CsvWriterToArray(26,"DataSetResult.xml")),
            (CsvWriterToArray(27,"DataSet.xml"), CsvWriterToArray(27,"DataSetResult.xml")),
            (CsvWriterToArray(28,"DataSet.xml"), CsvWriterToArray(28,"DataSetResult.xml")),
            (CsvWriterToArray(29,"DataSet.xml"), CsvWriterToArray(29,"DataSetResult.xml")),
            (CsvWriterToArray(30,"DataSet.xml"), CsvWriterToArray(30,"DataSetResult.xml")),
            (CsvWriterToArray(31,"DataSet.xml"), CsvWriterToArray(31,"DataSetResult.xml")),
            (CsvWriterToArray(32,"DataSet.xml"), CsvWriterToArray(32,"DataSetResult.xml")),
            (CsvWriterToArray(33,"DataSet.xml"), CsvWriterToArray(33,"DataSetResult.xml")),
            (CsvWriterToArray(34,"DataSet.xml"), CsvWriterToArray(34,"DataSetResult.xml")),
            (CsvWriterToArray(35,"DataSet.xml"), CsvWriterToArray(35,"DataSetResult.xml")),
            (CsvWriterToArray(36,"DataSet.xml"), CsvWriterToArray(36,"DataSetResult.xml")),
            (CsvWriterToArray(37,"DataSet.xml"), CsvWriterToArray(37,"DataSetResult.xml")),
            (CsvWriterToArray(38,"DataSet.xml"), CsvWriterToArray(38,"DataSetResult.xml")),
            (CsvWriterToArray(39,"DataSet.xml"), CsvWriterToArray(39,"DataSetResult.xml")),
            (CsvWriterToArray(40,"DataSet.xml"), CsvWriterToArray(40,"DataSetResult.xml")),
            (CsvWriterToArray(41,"DataSet.xml"), CsvWriterToArray(41,"DataSetResult.xml")),
            (CsvWriterToArray(42,"DataSet.xml"), CsvWriterToArray(42,"DataSetResult.xml")),
            (CsvWriterToArray(43,"DataSet.xml"), CsvWriterToArray(43,"DataSetResult.xml")),
            (CsvWriterToArray(44,"DataSet.xml"), CsvWriterToArray(44,"DataSetResult.xml")),
            (CsvWriterToArray(45,"DataSet.xml"), CsvWriterToArray(45,"DataSetResult.xml")),
            (CsvWriterToArray(46,"DataSet.xml"), CsvWriterToArray(46,"DataSetResult.xml")),
            (CsvWriterToArray(47,"DataSet.xml"), CsvWriterToArray(47,"DataSetResult.xml")),
            (CsvWriterToArray(48,"DataSet.xml"), CsvWriterToArray(48,"DataSetResult.xml")),
            (CsvWriterToArray(49,"DataSet.xml"), CsvWriterToArray(49,"DataSetResult.xml")),
            (CsvWriterToArray(50,"DataSet.xml"), CsvWriterToArray(50,"DataSetResult.xml")),
            (CsvWriterToArray(51,"DataSet.xml"), CsvWriterToArray(51,"DataSetResult.xml")),
            (CsvWriterToArray(52,"DataSet.xml"), CsvWriterToArray(52,"DataSetResult.xml")),
            (CsvWriterToArray(53,"DataSet.xml"), CsvWriterToArray(53,"DataSetResult.xml")),
            (CsvWriterToArray(54,"DataSet.xml"), CsvWriterToArray(54,"DataSetResult.xml")),
            (CsvWriterToArray(55,"DataSet.xml"), CsvWriterToArray(55,"DataSetResult.xml")),
            (CsvWriterToArray(56,"DataSet.xml"), CsvWriterToArray(56,"DataSetResult.xml")),
            (CsvWriterToArray(57,"DataSet.xml"), CsvWriterToArray(57,"DataSetResult.xml")),
            (CsvWriterToArray(58,"DataSet.xml"), CsvWriterToArray(58,"DataSetResult.xml")),
            (CsvWriterToArray(59,"DataSet.xml"), CsvWriterToArray(59,"DataSetResult.xml")),
            (CsvWriterToArray(60,"DataSet.xml"), CsvWriterToArray(60,"DataSetResult.xml")),
            (CsvWriterToArray(61,"DataSet.xml"), CsvWriterToArray(61,"DataSetResult.xml")),
            (CsvWriterToArray(62,"DataSet.xml"), CsvWriterToArray(62,"DataSetResult.xml")),
            (CsvWriterToArray(63,"DataSet.xml"), CsvWriterToArray(63,"DataSetResult.xml")),
            (CsvWriterToArray(64,"DataSet.xml"), CsvWriterToArray(64,"DataSetResult.xml")),
            (CsvWriterToArray(65,"DataSet.xml"), CsvWriterToArray(65,"DataSetResult.xml")),
            (CsvWriterToArray(66,"DataSet.xml"), CsvWriterToArray(66,"DataSetResult.xml")),
            (CsvWriterToArray(67,"DataSet.xml"), CsvWriterToArray(67,"DataSetResult.xml")),
            (CsvWriterToArray(68,"DataSet.xml"), CsvWriterToArray(68,"DataSetResult.xml")),
            (CsvWriterToArray(69,"DataSet.xml"), CsvWriterToArray(69,"DataSetResult.xml")),
            (CsvWriterToArray(70,"DataSet.xml"), CsvWriterToArray(70,"DataSetResult.xml")),
            (CsvWriterToArray(71,"DataSet.xml"), CsvWriterToArray(71,"DataSetResult.xml")),
            (CsvWriterToArray(72,"DataSet.xml"), CsvWriterToArray(72,"DataSetResult.xml")),
            (CsvWriterToArray(73,"DataSet.xml"), CsvWriterToArray(73,"DataSetResult.xml")),
            (CsvWriterToArray(74,"DataSet.xml"), CsvWriterToArray(74,"DataSetResult.xml")),
            (CsvWriterToArray(75,"DataSet.xml"), CsvWriterToArray(75,"DataSetResult.xml")),
            (CsvWriterToArray(76,"DataSet.xml"), CsvWriterToArray(76,"DataSetResult.xml")),
            (CsvWriterToArray(77,"DataSet.xml"), CsvWriterToArray(77,"DataSetResult.xml")),
            (CsvWriterToArray(78,"DataSet.xml"), CsvWriterToArray(78,"DataSetResult.xml")),
            (CsvWriterToArray(79,"DataSet.xml"), CsvWriterToArray(79,"DataSetResult.xml")),
            (CsvWriterToArray(80,"DataSet.xml"), CsvWriterToArray(80,"DataSetResult.xml")),
            (CsvWriterToArray(81,"DataSet.xml"), CsvWriterToArray(81,"DataSetResult.xml")),
            (CsvWriterToArray(82,"DataSet.xml"), CsvWriterToArray(82,"DataSetResult.xml")),
            (CsvWriterToArray(83,"DataSet.xml"), CsvWriterToArray(83,"DataSetResult.xml")),
            (CsvWriterToArray(84,"DataSet.xml"), CsvWriterToArray(84,"DataSetResult.xml")),
            (CsvWriterToArray(85,"DataSet.xml"), CsvWriterToArray(85,"DataSetResult.xml")),
            (CsvWriterToArray(86,"DataSet.xml"), CsvWriterToArray(86,"DataSetResult.xml")),
            (CsvWriterToArray(87,"DataSet.xml"), CsvWriterToArray(87,"DataSetResult.xml")),
            (CsvWriterToArray(88,"DataSet.xml"), CsvWriterToArray(88,"DataSetResult.xml")),
            (CsvWriterToArray(89,"DataSet.xml"), CsvWriterToArray(89,"DataSetResult.xml")),
            (CsvWriterToArray(90,"DataSet.xml"), CsvWriterToArray(90,"DataSetResult.xml")),
            (CsvWriterToArray(91,"DataSet.xml"), CsvWriterToArray(91,"DataSetResult.xml")),
            (CsvWriterToArray(92,"DataSet.xml"), CsvWriterToArray(92,"DataSetResult.xml")),
            (CsvWriterToArray(93,"DataSet.xml"), CsvWriterToArray(93,"DataSetResult.xml")),
            (CsvWriterToArray(94,"DataSet.xml"), CsvWriterToArray(94,"DataSetResult.xml")),
            (CsvWriterToArray(95,"DataSet.xml"), CsvWriterToArray(95,"DataSetResult.xml")),
            (CsvWriterToArray(96,"DataSet.xml"), CsvWriterToArray(96,"DataSetResult.xml")),
            (CsvWriterToArray(97,"DataSet.xml"), CsvWriterToArray(97,"DataSetResult.xml")),
            (CsvWriterToArray(98,"DataSet.xml"), CsvWriterToArray(98,"DataSetResult.xml")),
            (CsvWriterToArray(99,"DataSet.xml"), CsvWriterToArray(99,"DataSetResult.xml")),
        };
        //инкапсуляция едрид-мадрид
        public (double[], double[])[] Trainset { get => _trainset; }//такие няшные свойства нынче в C# 7
    }

    class Neuron
    {
        public Neuron(double[] inputs, double[] weights, NeuronType type)
        {
            _type = type;
            _weights = weights;
            _inputs = inputs;
        }
        private NeuronType _type;
        private double[] _weights;
        private double[] _inputs;
        public double[] Weights { get => _weights; set => _weights = value; }
        public double[] Inputs { get => _inputs; set => _inputs = value; }
        public double Output { get => Activator(_inputs, _weights); }

        private double Activator(double[] i, double[] w)//преобразования
        {
            double sum = 0;
            for (int l = 0; l < i.Length; ++l)
                sum += i[l] * w[l];//линейные
            return Pow(1 + Exp(-sum), -1);//нелинейные
        }
        public double Derivativator(double outsignal) => outsignal * (1 - outsignal);//формула производной для текущей функции активации уже выведена в ранее упомянутой книге
        public double Gradientor(double error, double dif, double g_sum) => (_type == NeuronType.Output) ? error * dif : g_sum * dif;//g_sum - это сумма градиентов следующего слоя
    }
    abstract class Layer//модификаторы protected стоят для внутрииерархического использования членов класса
    {//type используется для связи с одноимённым полю слоя файлом памяти

        protected Layer(int non, int nopn, NeuronType nt, string type)
        {//увидите это в WeightInitialize
            numofneurons = non;
            numofprevneurons = nopn;
            Neurons = new Neuron[non];
            double[,] Weights = WeightInitialize(MemoryMode.GET, type);
            for (int i = 0; i < non; ++i)
            {
                double[] temp_weights = new double[nopn];
                for (int j = 0; j < nopn; ++j)
                    temp_weights[j] = Weights[i, j];
                Neurons[i] = new Neuron(null, temp_weights, nt);//про подачу null на входы ниже
            }
        }
        protected int numofneurons;//число нейронов текущего слоя
        protected int numofprevneurons;//число нейронов предыдущего слоя
        protected const double learningrate = 0.1d;//скорость обучения
        Neuron[] _neurons;
        public Neuron[] Neurons { get => _neurons; set => _neurons = value; }
        public double[] Data
        {
            set
            {
                for (int i = 0; i < Neurons.Length; ++i)
                    Neurons[i].Inputs = value;
            }
        }

        public double[,] WeightInitialize(MemoryMode mm, string type)
        {
            double[,] _weights = new double[numofneurons, numofprevneurons];
            WriteLine($"{type} weights are being initialized...");
            XmlDocument memory_doc = new XmlDocument();
            memory_doc.Load($"{type}_memory.xml");
            XmlElement memory_el = memory_doc.DocumentElement;
            switch (mm)
            {
                case MemoryMode.GET:
                    for (int l = 0; l < _weights.GetLength(0); ++l)
                        for (int k = 0; k < _weights.GetLength(1); ++k)
                            _weights[l, k] = double.Parse(memory_el.ChildNodes.Item(k + _weights.GetLength(1) * l).InnerText.Replace(',', '.'), System.Globalization.CultureInfo.InvariantCulture);
                    break;
                case MemoryMode.SET:
                    for (int l = 0; l < Neurons.Length; ++l)
                        for (int k = 0; k < numofprevneurons; ++k)
                            memory_el.ChildNodes.Item(k + numofprevneurons * l).InnerText = Neurons[l].Weights[k].ToString();
                    break;
            }
            memory_doc.Save($"{type}_memory.xml");
            WriteLine($"{type} weights have been initialized...");
            return _weights;
        }
        abstract public void Recognize(Network net, Layer nextLayer);//для прямых проходов
        abstract public double[] BackwardPass(double[] stuff);//и обратных
    }
    class HiddenLayer : Layer
    {
        public HiddenLayer(int non, int nopn, NeuronType nt, string type) : base(non, nopn, nt, type) { }
        public override void Recognize(Network net, Layer nextLayer)
        {
            double[] hidden_out = new double[Neurons.Length];
            for (int i = 0; i < Neurons.Length; ++i)
                hidden_out[i] = Neurons[i].Output;
            nextLayer.Data = hidden_out;
        }

        public override double[] BackwardPass(double[] gr_sums)
        {
            double[] gr_sum = null;

            for (int i = 0; i < numofneurons; ++i)
                for (int n = 0; n < numofprevneurons; ++n)
                    Neurons[i].Weights[n] += learningrate * Neurons[i].Inputs[n] * Neurons[i].Gradientor(0, Neurons[i].Derivativator(Neurons[i].Output), gr_sums[i]);//коррекция весов
            return gr_sum;
        }
    }
    class OutputLayer : Layer
    {
        public OutputLayer(int non, int nopn, NeuronType nt, string type) : base(non, nopn, nt, type) { }
        public override void Recognize(Network net, Layer nextLayer)
        {
            for (int i = 0; i < Neurons.Length; ++i)
                net.fact[i] = Neurons[i].Output;
        }

        public override double[] BackwardPass(double[] errors)
        {
            double[] gr_sum = new double[numofprevneurons];
            for (int j = 0; j < gr_sum.Length; ++j)//вычисление градиентных сумм выходного слоя
            {
                double sum = 0;
                for (int k = 0; k < Neurons.Length; ++k)
                    sum += Neurons[k].Weights[j] * Neurons[k].Gradientor(errors[k], Neurons[k].Derivativator(Neurons[k].Output), 0);//через ошибку и производную
                gr_sum[j] = sum;
            }
            for (int i = 0; i < numofneurons; ++i)
                for (int n = 0; n < numofprevneurons; ++n)
                    Neurons[i].Weights[n] += learningrate * Neurons[i].Inputs[n] * Neurons[i].Gradientor(errors[i], Neurons[i].Derivativator(Neurons[i].Output), 0);//коррекция весов
            return gr_sum;
        }
    }
    public class Network
    {
        //все слои сети
        InputLayer input_layer = new InputLayer();
        private HiddenLayer hidden_layer = new HiddenLayer(9, 54, NeuronType.Hidden, nameof(hidden_layer));
        private OutputLayer output_layer = new OutputLayer(1, 9, NeuronType.Output, nameof(output_layer));
        //массив для хранения выхода сети
        public double[] fact = new double[1];//не ругайте за 2 пожалуйста, БЫЛО 6

        //ошибка одной итерации обучения  //Сумма квадратов ошибок
        double GetMSE(double[] errors)
        {
            double sum = 0;
            for (int i = 0; i < errors.Length; ++i)
                sum += Pow(errors[i], 2);
            return 0.5d * sum;
        }

        //ошибка эпохи
        double GetCost(double[] mses)
        {
            double sum = 0;
            for (int i = 0; i < mses.Length; ++i)
                sum += mses[i];
            return (sum / mses.Length);
        }
        //обучение
        public static void Train(Network net)//Алгоритм обратного распространения
        {

            const double threshold = 0.02;//порог ошибки
            double[] temp_mses = new double[100];//массив для хранения ошибок итераций БЫЛО 4
            double temp_cost = 0;//текущее значение ошибки по эпохе
            int iteration = 0;
            do
            {
                for (int i = 0; i < net.input_layer.Trainset.Length; ++i)
                {
                    //прямой проход
                    net.hidden_layer.Data = net.input_layer.Trainset[i].Item1;
                    net.hidden_layer.Recognize(null, net.output_layer);
                    net.output_layer.Recognize(net, null);
                    //вычисление ошибки по итерации
                    double[] errors = new double[net.input_layer.Trainset[i].Item2.Length];
                    for (int x = 0; x < errors.Length; ++x)
                        errors[x] = net.input_layer.Trainset[i].Item2[x] - net.fact[x];
                    temp_mses[i] = net.GetMSE(errors);
                    //WriteLine($"-------------------------------------------------------------------{temp_mses[i]}");
                    //обратный проход и коррекция весов
                    double[] temp_gsums = net.output_layer.BackwardPass(errors);
                    net.hidden_layer.BackwardPass(temp_gsums);
                }
                temp_cost = net.GetCost(temp_mses);//вычисление ошибки по эпохе
                //debugging
                iteration++;

                if (iteration % 1000 == 1) WriteLine($"{temp_cost}");

            } while (temp_cost > threshold);
            //загрузка скорректированных весов в "память"
            //lock (block)
            //{
            net.hidden_layer.WeightInitialize(MemoryMode.SET, nameof(hidden_layer));
            net.output_layer.WeightInitialize(MemoryMode.SET, nameof(output_layer));
            //}
            //WriteToFile(net);

            //return true;
        }
        //тестирование сети
        public static double Test(Network net, List<int> list)
        {
            double sum = 0;
            double[] Inputs = { 0, 0, 0, 0, 1, 1, 0, 1, 1, 0, 1, 0, 1, 1, 1, 0, 0, 1, 1, 0, 0, 0, 1, 0, 0, 1, 0, 1, 1, 0, 1, 0, 1, 1, 1, 1, 0, 1, 0, 0, 0, 1, 1, 0, 1, 1, 0, 1, 1, 1, 1, 1, 1, 1 };
            //WriteLine("Тестирование нейронной сети");
            //double[] Inputs = new double[list.Count];
            //for (int i = 0; i < Inputs.Length; i++) Inputs[i] = list[i];
            for (int i = 0; i < Inputs.Length; i++) sum += Inputs[i];

            net.hidden_layer.Data = Inputs;
            net.hidden_layer.Recognize(null, net.output_layer);
            net.output_layer.Recognize(net, null);
            //for (int j = 0; j < net.fact.Length; ++j) WriteLine($"{net.fact[j]}");
            double output = 0;

            for (int j = 0; j < net.fact.Length; ++j) output = net.fact[j];

            Console.WriteLine(sum.ToString());
            return output;
        }

        public static object block = new object();
        static void ThreadTrain(Network net)
        {
            lock (block)
            {
                WriteLine($"Работает поток № {Thread.CurrentThread.GetHashCode()}");
                Train(net);
                //Thread.Sleep(100);
                WriteLine(new string('-', 30));
            }
            WriteToFile(net);

        }

        #region Monitor
        //bool m_condition = false; 
        //public void ThreadOne(Network net)
        //{
        //    Monitor.Enter(net); //Взаимоисключающие запирание
        //    while(!m_condition) //Атомарная проверка сложного уровня запирания
        //    {//Если условие не соблюдается, ждем, что его поменяет другой поток
        //        Monitor.Wait(net); //Делаем отпирание, чтобы другой поток мог запереться
        //    }
        //    //Обрабатываем данные
        //    Monitor.Exit(net);  //Отпирание
        //}
        #endregion

        static void WriteToFile(Network net)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Network));

            using (FileStream fileStream = new FileStream("hidden_layer_WeigthInitialize.xml", FileMode.OpenOrCreate))
            {
                xmlSerializer.Serialize(fileStream, net);
            }
        }

        static void LoadFromFile(Network net)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Network));
            using (FileStream fileStream = new FileStream("hidden_layer_WeigthInitialize.xml", FileMode.OpenOrCreate))
            {
                xmlSerializer.Deserialize(fileStream);
            }
        }

    }
}
