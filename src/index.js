import Vehicle from "./singleton_parttern.js";
import AnimalFactory from "./factory_method_pattern.js";

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
