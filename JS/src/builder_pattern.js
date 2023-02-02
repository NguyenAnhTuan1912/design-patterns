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