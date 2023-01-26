import Vehicle from "./singleton_parttern.js";

/// Creational Design Patterns
///
/// Singleton Pattern
const car = new Vehicle(4, 'Red', 220, "GRUUUUUUUUUUUUUU");
const bike = new Vehicle();
const motorbike = new Vehicle(2, 'Green', 180, "GRENNNNNNNNNN");

car.ignite();
bike.ignite();
motorbike.ignite();

console.log("Is car's instance is bike's instance? ", car === bike);
console.log("Is bike's instance is motorbike's instance? ", motorbike === bike);
///
///
///
// Factory Method Pattern