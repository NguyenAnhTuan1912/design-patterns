function AnimalFactory() {
  this.CreateAnimal = (type) => {
    let newAnimal;

    switch(type) {
      case "Cat": {
        newAnimal = new Cat();
        break;
      }
      case "Dog": {
        newAnimal = new Dog();
        break;
      }
      case "Duck": {
        newAnimal = new Duck();
        break;
      }
      default: {
        break;
      }
    }

    newAnimal.type = type;
    newAnimal.say = () => {
      console.log(`${newAnimal.$name} says "${newAnimal.$sound}"`);
    }

    return newAnimal;
  }
}

function Cat(name = "") {
  this.$name = name;
  this.$sound = "Meo";
}

function Dog(name = "") {
  this.$name = name;
  this.$sound = "Gau";
}

function Duck(name = "") {
  this.$name = name;
  this.$sound = "Quac";
}

export default AnimalFactory;