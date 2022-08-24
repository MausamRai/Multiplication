// See https://aka.ms/new-console-template for more information

using System;



    public interface vehicle
    {
        double speed(int distance, int hours);
        void applyBrakes();


    }

    class car : vehicle
    {
    private string Color;
    private int mileage;
    private int seats;
    

    public car(string Color,    int mileage,    int seats)
    {
        this.Color = Color;
        this.mileage = mileage;
        this.seats = seats;
    }
    public string getColor()
    {
        return this.Color;

    }
    public int getmileage()
    {
        return this.mileage;

    }
    public int getseats()
    {
        return this.seats;
    }


    public void reverse()
    {
        Console.WriteLine("car is reversed.");
    }
        public double speed(int distance, int hours)
        {
            return distance / hours;
        }
        public void applyBrakes()
        {
            Console.WriteLine("Brake is applied to car.");
        }
    }

class bike : vehicle
{
    private string color;
    private int mileage;
    public bike(string color, int mileage)
    {
        this.color = color;
        this.mileage = mileage;
    }
    public string getColor()
    {
        return this.color;
    
    }
    public int getmileage()
    { 
        return this.mileage; 
    }

    public double speed(int distance, int hours)
    {
        return (distance / hours);
    }

    public void applyBrakes()
    {
        Console.WriteLine("Brake is applied to bike.");
    }

   
}
    
    class demo
    {
        public static void Main(string[] args)
        {
        car C = new car("Black",40,4);
        Console.WriteLine("Color of car:"+C.getColor());
        Console.WriteLine("Mileage of car:"+C.getmileage());
        Console.WriteLine("Seats of Car:"+C.getseats());
        C.applyBrakes();
        Console.WriteLine("speed of car is: "+C.speed(120, 10));
        C.reverse();

        bike B = new bike("Red",50);
        Console.WriteLine("speed of bike is:" + B.speed(140, 10));
        Console.WriteLine("the color of bike is:" + B.getColor());
        Console.WriteLine("Mileage of bike is " + B.getmileage());
        B.applyBrakes();
        
        }
    }
