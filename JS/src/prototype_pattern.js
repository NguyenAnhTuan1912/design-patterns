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