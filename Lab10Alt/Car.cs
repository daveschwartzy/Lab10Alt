using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10Alt
{
    class Car
    {
        //data members
        private string make;
        private string model;
        private int year;
        private double price;
        //constructors
        public Car()
        {
            make = "";
            model = "";
            year = 0;
            price = 0;
        }
        public Car(string make, string model, int year, double price)
        {
            this.make = make;
            this.model = model;
            this.year = year;
            this.price = price;

        }
        //getters
        public string GetMake()
        {
            return make;
        }

        public string GetModel()
        {
            return model; ;
        }

        public int GetYear()
        {
            return year;
        }

        public double GetPrice()
        {
            return price;
        }

        //setters
        public void setMake(string make)
        {
            this.make = make;
        }

        public void setModel(string model)
        {
            this.model = model;
        }

        public void setYear(int year)
        {
            this.year = year;
        }
        
        public void setPrice(double price)
        {
            this.price = price;
        }

        public override string ToString()
        {
            return $"{make,-12} {model,-10} {year, -5} {price, -5}   ";
        }
    }
}
