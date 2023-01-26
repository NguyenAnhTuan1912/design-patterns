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

DP này cung cấp cho chúng ta một Creator (ở đây là Function Constructor) trong Creator chúng ta có phương thức ```Create()``` dùng để tạo các instance. Đúng như tên gọi thì nó giống như một cái nhà máy, mình đưa input vào và nó sẽ tạo ra và trả cho mình một instance tương ứng với input đó. Đến đây thì mình đã đấy sự thú vị của Design Pattern, mình có thể kết hợp Factory Method Pattern với Singleton Pattern.
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
Chưa học nên cập nhật sau

### Builder Pattern
Chưa học nên cập nhật sau

### Prototype Pattern
Chưa học nên cập nhật sau
<br>
## Structural Design Patterns
Chưa học nên cập nhật sau
<br>
## Behavioral Design Patterns
Chưa học nên cập nhật sau