using Lab3_2;

Console.WriteLine("Hello, World!");

Car car1 = new Car("mercedes", "maybach", 300);
Car car2 = new Car("bmw", "b38", 300);
Car car3 = new Car("mercedes", "maybach", 300);
Car car4 = new Car("wdfffd", "wee2rvv", 234);

List<Car> list_cars = [car1, car2, car3, car4];

Console.WriteLine(car1.Equals(car1));
CarsCatalog catalog = new CarsCatalog(list_cars);

for  (int i = 0; i < catalog.all_cars.Count; ++i)
{
    Console.WriteLine(catalog[i]);
}
