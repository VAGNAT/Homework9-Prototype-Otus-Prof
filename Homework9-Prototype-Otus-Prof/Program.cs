using Homework9_Prototype_Otus_Prof;

var veh = new Vehicle("Jaguar", 10);
var myCloneVeh = veh.MyClone();
var cloneVeh = veh.Clone() as Vehicle;

var car = new Car("Audi", 5, 3, "CR");
var myCloneCar = car.MyClone();
var cloneCar = car.Clone() as Car;

var electricCar = new ElectricCar("Tesla", 2, 5, "VH", 1500);
var myCloneElectricCar = electricCar.MyClone();
var cloneElectricCar = electricCar.Clone() as ElectricCar;

Console.WriteLine("Vehicle:");
Console.WriteLine("\tOriginal:");
Console.WriteLine($"\t\tHash: {veh.GetHashCode()}, Brand: {veh.Brand}, Year: {veh.Year}");
Console.WriteLine("\tMy clone:");
Console.WriteLine($"\t\tHash: {myCloneVeh!.GetHashCode()}, Brand: {myCloneVeh.Brand}, Year: {myCloneVeh.Year}");
Console.WriteLine("\tClone:");
Console.WriteLine($"\t\tHash: {cloneVeh!.GetHashCode()}, Brand: {cloneVeh.Brand}, Year: {cloneVeh.Year}");

Console.WriteLine(new string('-',100));
Console.WriteLine("Car:");
Console.WriteLine("\tOriginal:");
Console.WriteLine($"\t\tHash: {car.GetHashCode()}, Brand: {car.Brand}, Year: {car.Year}, Doors: {car.Doors}, Engine Type: {car.EngineType}");
Console.WriteLine("\tMy clone:");
Console.WriteLine($"\t\tHash: {myCloneCar.GetHashCode()}, Brand: {myCloneCar.Brand}, Year: {myCloneCar.Year}, Doors: {myCloneCar.Doors}, Engine Type: {myCloneCar.EngineType}");
Console.WriteLine("\tClone:");
Console.WriteLine($"\t\tHash: {cloneCar!.GetHashCode()}, Brand: {cloneCar.Brand}, Year: {cloneCar.Year}, Doors: {cloneCar.Doors}, Engine Type: {cloneCar.EngineType}");

Console.WriteLine(new string('-', 100));
Console.WriteLine("Electric car:");
Console.WriteLine("\tOriginal:");
Console.WriteLine($"\t\tHash: {electricCar.GetHashCode()}, Brand: {electricCar.Brand}, Year: {electricCar.Year}, Doors: {electricCar.Doors}, Engine Type: {electricCar.EngineType}, Battery capacity: {electricCar.BatteryCapacity}");
Console.WriteLine("\tMy clone:");
Console.WriteLine($"\t\tHash: {myCloneElectricCar.GetHashCode()}, Brand: {myCloneElectricCar.Brand}, Year: {myCloneElectricCar.Year}, Doors: {myCloneElectricCar.Doors}, Engine Type: {myCloneElectricCar.EngineType}, Battery capacity: {myCloneElectricCar.BatteryCapacity}");
Console.WriteLine("\tClone:");
Console.WriteLine($"\t\tHash: {cloneElectricCar!.GetHashCode()}, Brand: {cloneElectricCar.Brand}, Year: {cloneElectricCar.Year}, Doors: {cloneElectricCar.Doors}, Engine Type: {cloneElectricCar.EngineType}, Battery capacity: {cloneElectricCar.BatteryCapacity}");
Console.WriteLine();
