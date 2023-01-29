# DESIGN PATTERNS

Design Patterns là các giải pháp về thiết kế phần mềm, hay thiết kế các đối tượng trong APP, các vấn đề cần tái sử dụng. Thường DP sẽ giải quyết một vấn đề gì đó. Cụ thể như thế nào thì đi đến từng ví dụ. Hầu hết công dụng của DP là làm code dễ đọc, hạn chế một số thứ, code dễ bảo trì, nâng cấp. Design Patterns không phải là thuật toán, nó giống như kĩ thuật, quy tắc khi tiết kế phần mềm. Vì đây là Javascript nên mình sẽ lấy ví dụ, cách hiểu của Javascript.

Design Pattern được chia thành 3 loại:
* Creational Design Patterns
* Structural Design Patterns
* Behavioral Design Patterns
<br>
## Creational Design Patterns
Là các design pattern dùng để TẠO, giống như cái tên của nó. DP này cung cấp cho chúng ta các giải pháp về tạo các đối tượng trong phần mềm. Tuỳ theo vai trò và chức năng của đối tượng thì chúng ta sẽ ứng dụng từng loại Creational DP khác nhau.

Trong Creational Design Patterns còn chia ra 5 loại khác nhau:
* Singleton Pattern
* Factory Method Pattern
* Abstract Factory Pattern
* Builder Pattern
* Prototype Pattern

### Singleton Pattern
Trong javascript không có accessibility cho class và method. Cho nên mình sẽ dùng những kiến thức đã được học trong javascript để ví dụ

Một Function Constructor, sẽ trả về một object, object này có phương thức là ```GetInstance()``` dùng để tạo intance của Function đó. ```GetInstance()``` sẽ trả về instance đã được tạo khi được gọi lần đầu và trả lại đúng instance đó trong các lần gọi tiếp theo. Bằng kĩ thuật closure chúng ta có thể làm điều này.

```
const Vehicle = (function() {
  let instance = null;
  const VehicleConstructor = function(numberOfSeats, color, topSpeed, sound) {
    this.$numberOfSeats = numberOfSeats;
    this.$color = color;
    this.$topSpeed = topSpeed;
    this.$sound = sound;

    this.ignite = () => {
      console.log("This vehicle is igniting... ", this.$sound);
    }
  }

  return {
    GetInstance: (numberOfSeats, color, topSpeed, sound) => {
      if(instance === null) {
        instance = new VehicleConstructor(numberOfSeats, color, topSpeed, sound);
      }
      return instance;
    }
  }
})();

export default Vehicle;
```

### Factory Method Pattern
Trong javascript không có interface, cho nên mình sẽ tiếp tục dùng Function Constructor thay thế cho interface.

DP này cung cấp cho chúng ta một Creator (ở đây là Function Constructor) trong Creator chúng ta có phương thức ```Create(type)``` dùng để tạo các instance. Đúng như tên gọi thì nó giống như một cái nhà máy, mình đưa input vào và nó sẽ tạo ra và trả cho mình một instance tương ứng với input đó. Đến đây thì mình đã đấy sự thú vị của Design Pattern, mình có thể kết hợp Factory Method Pattern với Singleton Pattern.

```
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
```

### Abstract Factory Pattern
AFP không khác gì với FMP là mấy, qua thời gian thì người ta cũng gộp 2 thứ này là một và gọi tên nó là Factory, các Factory không còn là một thứ gì cụ thể nữa, mà nó sẽ trở nên trừu tượng hơn.

```
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
```

### Builder Pattern
Như tên gọi của nó thì nó sẽ thực hiện các chuỗi công việc có liên quan để tạo nên một object phức tạp. Về cơ bản thì nó là một DP dùng để gom lại các bước (function) để tạo ra một object hoàn chỉnh.

Pattern này sẽ giúp chúng ta tạo ra một Default Object, và Từ DO đó chúng ta sẽ mod nó lại phù hợp với ngữ cảnh sử dụng.

```
function HouseDirector() {
  this.construct = (houseBuilder) => {
    houseBuilder.createNewHouseDesign();
    if(houseBuilder.hasHouseDesign()) {
      houseBuilder.buildRoom();
      houseBuilder.buildFloor();
      houseBuilder.paintHouse();
      houseBuilder.AddFurnitures();
      return houseBuilder.getCompleteHouse();
    } else {
      return null;
    }
  }
}

function HouseBuilder() {
  let _instance;

  this.hasHouseDesign = () => {
    return _instance !== undefined;
  }

  this.createNewHouseDesign = () => {
    _instance = new House();
  }

  this.buildFloor = () => {
    _instance.floors = 1;
  }

  this.buildRoom = () => {
    _instance.rooms = 4;
  }

  this.paintHouse = () => {
    _instance.color = 'white';
  }

  this.AddFurnitures = () => {
    _instance.furnitures = ['Table', 'Bed'];
  }

  this.getCompleteHouse = () => {
    return _instance;
  }
}

function House() {
  this.floors = 0;
  this.color = '';
  this.rooms = 0;
  this.furnitures = [];
}

export {
  HouseDirector,
  HouseBuilder
}
```

### Prototype Pattern
Pattern này giúp chúng ta tạo một object, mà object này là một object đã được clone lại từ một object từ trước đó (object mặc định).

DP này giúp chúng ta clone lại một default object mà không cần phải lặp lại code ở các function khác. Ví dụ như chúng ta có một Product, thì Product này cần phải được tạo một số default properties để làm gì? Để khi mà người bán họ không có gì chỉnh sửa thì họ có thể lưu nó lại hoặc dùng để làm khuôn cho các Product khác.

```
function WeaponPrototype(prototype) {
  const _prototype = prototype;

  this.clone = () => {
    let cloneOfPrototype = new Weapon();
    cloneOfPrototype.damage = _prototype.damage;
    cloneOfPrototype.type = _prototype.type;
    cloneOfPrototype.madeIn = _prototype.madeIn;
    return cloneOfPrototype;
  };
}

function Weapon(damage, type, madeIn) {
  this.damage = damage;
  this.type = type;
  this.madeIn = madeIn;
}

function getVNWeapon() {
  const defaultVNMeleeWeapon = new Weapon(300, "Melee", "Viet Nam");
  const prototype = new WeaponPrototype(defaultVNMeleeWeapon);
  const cloneOfDefaultVNMeleeWeapon = prototype.clone();
  return cloneOfDefaultVNMeleeWeapon;
}

function getUSAWeapon() {
  const defaultUSAMeleeWeapon = new Weapon(100, "Range", "United States");
  const prototype = new WeaponPrototype(defaultUSAMeleeWeapon);
  const cloneOfDefaultUSAMeleeWeapon = prototype.clone();
  return cloneOfDefaultUSAMeleeWeapon;
}

export {
  getVNWeapon,
  getUSAWeapon
}
```
<br>

## Structural Design Patterns
Chưa học nên cập nhật sau
<br>

## Behavioral Design Patterns
Chưa học nên cập nhật sau
<br>