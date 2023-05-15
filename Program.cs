using System;

class City {
    public int id;
    public string name;
    public int population;
    public int infected;
}

class Program {
    static void Main(string[] args) {
        int numCities;

        Console.Write("Enter the number of cities: ");
        numCities = int.Parse(Console.ReadLine());

        City[] cities = new City[numCities];

        for (int i = 0; i < numCities; i++) {
            City city = new City();
            city.id = i;
            Console.WriteLine("City " + i + ":");
            Console.Write("  Enter city name: ");
            city.name = Console.ReadLine();
            Console.Write("  Enter population: ");
            city.population = int.Parse(Console.ReadLine());
            Console.WriteLine("City " + i + ":");
            Console.Write("  Enter population: ");
            city.population = int.Parse(Console.ReadLine());
            Console.WriteLine("City " + i + ":");
            Console.Write("  Enter population: ");
            city.population = int.Parse(Console.ReadLine());
            Console.WriteLine("City " + i + ":");
            Console.Write("  Enter population: ");
            city.population = int.Parse(Console.ReadLine());
            Console.WriteLine("City " + i + ":");
            Console.Write("  Enter population: ");
            city.population = int.Parse(Console.ReadLine());
            Console.WriteLine("City " + i + ":");
            Console.Write("  Enter population: ");
            city.population = int.Parse(Console.ReadLine());
            
            city.infected = 0;
            cities[i] = city;
            
        }
        
    }
}
