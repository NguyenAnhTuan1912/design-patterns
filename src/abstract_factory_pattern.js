class AbstractHuman {
  name = "";
  age = 0;

  constructor() {
    if(this.constructor === AbstractHuman) {
      throw new Error("Abstract classes can't be instantiated.");
    }
  }

  say() {}
}

class Student extends AbstractHuman {
  point = 1.0;

  constructor(name, age, point) {
    super();
    this.name = name;
    this.age = age;
    this.point = point
  }

  say() {
    console.log(`My name is ${this.name}, I'm a student. I got ${this.point} in the final Exam.`);
  }
}

class Worker extends AbstractHuman {
  salary = 0;

  constructor(name, age, salary) {
    super();
    this.name = name;
    this.age = age;
    this.salary = salary
  }

  say() {
    console.log(`My name is ${this.name}, I'm a worker. My current salary is ${this.salary}`);
  }
}

class AbstractHumanFactory {
  CreateStudent(name, age, point) {};
  CreateWorker(name, age, salary) {};
}

class HumanFactory extends AbstractHumanFactory {
  CreateStudent(name, age, point) {
    return new Student(name, age, point);
  };
  CreateWorker(name, age, salary) {
    return new Worker(name, age, salary);
  };
}

export {
  HumanFactory
}