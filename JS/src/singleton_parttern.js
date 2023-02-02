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