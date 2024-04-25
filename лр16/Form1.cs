using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace лр16
{
    public partial class Form1 : Form
    {
        // Абстрактный класс для автомобилей
        abstract class Car
        {
            // Абстрактный метод для управления автомобилем
            public abstract void Drive();
        }

        // Класс для седана
        class Sedan : Car
        {
            // Реализация метода Drive() для седана
            public override void Drive()
            {
                MessageBox.Show("Произведен седан");
            }
        }

        // Класс для внедорожника (SUV)
        class SUV : Car
        {
            // Реализация метода Drive() для внедорожника
            public override void Drive()
            {
                MessageBox.Show("Произведен внедорожник");
            }
        }

        // Класс для лимузина
        class Limousine : Car
        {
            // Реализация метода Drive() для лимузина
            public override void Drive()
            {
                MessageBox.Show("Произведен лимузин");
            }
        }

        // Абстрактная фабрика для создания автомобилей
        abstract class AbstractFactory
        {
            // Абстрактный метод для создания автомобиля
            public abstract Car CreateCar();
        }

        // Фабрика для производства седанов
        class SedanFactory : AbstractFactory
        {
            // Реализация метода CreateCar() для создания седана
            public override Car CreateCar()
            {
                return new Sedan();
            }
        }

        // Фабрика для производства внедорожников
        class SUVFactory : AbstractFactory
        {
            // Реализация метода CreateCar() для создания внедорожника
            public override Car CreateCar()
            {
                return new SUV();
            }
        }

        // Фабрика для производства лимузинов
        class LimousineFactory : AbstractFactory
        {
            // Реализация метода CreateCar() для создания лимузина
            public override Car CreateCar()
            {
                return new Limousine();
            }
        }

        // Конструктор формы
        public Form1()
        {
            InitializeComponent();
        }

        // Обработчик события нажатия кнопки "Создать седан"
        private void button1_Click(object sender, EventArgs e)
        {
            // Создание фабрики для седанов
            AbstractFactory sedanFactory = new SedanFactory();
            // Создание седана через фабрику
            Car car = sedanFactory.CreateCar();
            // Управление седаном
            car.Drive();
        }

        // Обработчик события нажатия кнопки "Создать внедорожник"
        private void button2_Click(object sender, EventArgs e)
        {
            // Создание фабрики для внедорожников
            AbstractFactory suvFactory = new SUVFactory();
            // Создание внедорожника через фабрику
            Car car = suvFactory.CreateCar();
            // Управление внедорожником
            car.Drive();
        }

        // Обработчик события нажатия кнопки "Создать лимузин"
        private void button3_Click(object sender, EventArgs e)
        {
            // Создание фабрики для лимузинов
            AbstractFactory limousineFactory = new LimousineFactory();
            // Создание лимузина через фабрику
            Car car = limousineFactory.CreateCar();
            // Управление лимузином
            car.Drive();
        }
    }
}