using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba2.Model
{

    public class CarShop : IComparable
    {
        public uint numberOfDepartment { get; set; } = 2;//кол-во отделов
        public uint totalSalary { get; set; } = 20000;//зп расходы
        public int purchaseExpenses { get; set; } = 30000;//расходы на покупку
        public uint numberOfEmployees { get; set; } = 100;//кол-во сотрудников
        public uint numberOfItems { get; set; } = 200;//кол-во наименований товара
        public string name, adress;//адресс и название
        public int averageIncome { get; set; } = 50000;//средний доход  
        public int this[int index]
        {
            get
            {
                switch (index)
                {
                    case 1:
                        return averageIncome;
                        break;
                    case 2:
                        return (int)totalSalary;
                        break;
                    case 3:
                        return (int)purchaseExpenses;
                        break;
                    default:
                        return -0;
                        break;
                }
            }
            set
            {
                switch (index)
                {
                    case 1:
                        averageIncome = value;
                        break;
                    case 2:
                        if (value < 0)
                        {
                            break;
                        }
                        totalSalary = (uint)value;
                        break;
                    case 3:
                        if (value < 0)
                        {
                            break;
                        }
                        purchaseExpenses = (int)value;
                        break;
                    default:
                        break;
                }
            }
        }
        public CarShop(string name, string adress)
        {
            this.adress = adress;
            this.name = name;
        }
        public int getAnnualIncome()
        {
            return averageIncome * 12;
        }
        public int CompareTo(Object obj)
        {
            if (obj == null) { return 1; }
            CarShop carShop = obj as CarShop;
            if (carShop != null)
            {
                return this.numberOfEmployees.CompareTo(carShop.numberOfEmployees);
            }
            else throw new ArgumentException("объект не CarShop");
        }
        override public string ToString()
        {
            return (name + " " + adress);
        }

        public double getAnnualTax()
        {
            return (double)averageIncome * 0.83;
        }
        public void addEmployee()
        {
            numberOfEmployees++;
        }
        public void firingEmployee()
        {
            if (numberOfEmployees == 0)
            {
                Console.WriteLine("нет сотрудников, некого уволить");
            }
            else numberOfEmployees--;
        }
        public static CarShop operator ++(CarShop carShop)
        {
            carShop.numberOfEmployees++;
            return carShop;
        }
        public static CarShop operator --(CarShop carShop)
        {
            if (carShop.numberOfEmployees == 0)
            {
                Console.WriteLine("нет сотрудников, некого уволить");
            }
            else carShop.numberOfEmployees--;


            return carShop;
        }

    }
}
