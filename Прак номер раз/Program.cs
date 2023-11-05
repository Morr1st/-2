class program
{
    static void Main(string[] args)
    {
        Car car1 = new Car(1500, "Vaz2114");
        Car car2 = new Car(350, "Lamborghini Aventador SVJ");
        Car car3 = new Car(490, "Bugatti Chiron Supersport 300+");
        Car car4 = new Car(403, "McLaren Speedtail");
        Console.WriteLine("-------Гонка-------");
        Console.WriteLine("Нажмите любую кнопку");
        Console.ReadKey();
        if (car1.maxSpeed > car2.maxSpeed)
        {
            if (car1.maxSpeed > car3.maxSpeed)
            {
                if (car1.maxSpeed > car4.maxSpeed)
                {
                    Console.WriteLine("");
                    Console.WriteLine(car1.name + " победила");
                }
            }
        }

        if (car2.maxSpeed > car1.maxSpeed)
        {
            if (car2.maxSpeed > car3.maxSpeed)
            {
                if (car2.maxSpeed > car4.maxSpeed)
                {
                    Console.WriteLine("");
                    Console.WriteLine(car2.name + " победила");
                }
            }
        }

        if (car3.maxSpeed > car1.maxSpeed)
        {
            if (car3.maxSpeed > car2.maxSpeed)
            {
                if (car3.maxSpeed > car4.maxSpeed)
                {
                    Console.WriteLine("");
                    Console.WriteLine(car3.name + " победила");
                }
            }
        }
        else
        {
            Console.WriteLine("");
            Console.WriteLine(car4.name + " победила");
        }
        
        Console.ReadKey();
    }

    class Car
    {
        public double maxSpeed;
        public const double distance = 402;
        public string name;
        public Car(double maxSpeed, string name)
        {
            this.maxSpeed = maxSpeed;
            this.name = name;
            Console.WriteLine(maxSpeed + "km/h - " + name);
        }
        public double CalculateTime(double distance)
        {
            return distance / maxSpeed;
        }
    }
}

