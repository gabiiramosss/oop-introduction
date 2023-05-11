using car_oop;

Console.WriteLine($"Car Program");
Console.WriteLine($"Type any car brand of your preference:");
string brand = Console.ReadLine();
Console.WriteLine($"Type a color of your preference:");
string color = Console.ReadLine();

List<Car> car = new List<Car>();

car.Add(
    new Car(brand, color)
);

foreach (var item in car)
{
    Console.WriteLine($"Brand: {item.Brand}, Color: {item.Color}");  
}








