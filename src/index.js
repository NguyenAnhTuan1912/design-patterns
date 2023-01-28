import Vehicle from "./singleton_parttern.js";
import AnimalFactory from "./factory_method_pattern.js";
import { HumanFactory } from "./abstract_factory_pattern.js";
import { HouseDirector, HouseBuilder } from "./builder_pattern.js";

/// Creational Design Patterns
///
/// Singleton Pattern
const car = Vehicle.GetInstance(4, 'Red', 220, "GRUUUUUUUUUUUUUU");
const bike = Vehicle.GetInstance();
const motorbike = Vehicle.GetInstance(2, 'Green', 180, "GRENNNNNNNNNN");

car.ignite();
bike.ignite();
motorbike.ignite();

console.log("Is car's instance is bike's instance? ", car === bike);
console.log("Is bike's instance is motorbike's instance? ", motorbike === bike);
///
///
///
// Factory Method Pattern
const animalFactory = new AnimalFactory();
const lab = animalFactory.CreateAnimal("Cat");
lab.$name = "Lab";
const dot = animalFactory.CreateAnimal("Dog");
dot.$name = "Dot";
const donald = animalFactory.CreateAnimal("Duck");
donald.$name = "Donald";

lab.say();
dot.say();
donald.say();

console.log(`Type of ${lab.$name}: ${lab.type}`);
console.log(`Type of ${dot.$name}: ${dot.type}`);
console.log(`Type of ${donald.$name}: ${donald.type}`);
///
///
///
/// Abstract Factory Pattern
const hFactory = new HumanFactory();
const s = hFactory.CreateStudent("Nguyen Anh Tuan", 20, 9.2);
const w = hFactory.CreateWorker("Tran Tuan", 67, 15000000);
s.say();
w.say();
///
///
///
/// Builder Pattern
const houseDirector = new HouseDirector();
const houseBuilder = new HouseBuilder();
const house = houseDirector.construct(houseBuilder);
console.log(house);