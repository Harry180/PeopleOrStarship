import {Person} from "../app/dto/Person";
import {Starship} from "../app/dto/Starship";

export default class FightService {
  static fight = (left: Person, right: Person) => {
    if (left.mass === right.mass) {
      return null;
    }
    return left.mass > right.mass ? left : right;
  }
  static starshipBattle = (left: Starship, right: Starship) => {
    if (left.crew === right.crew) {
      return null;
    }
    return left.crew > right.crew ? left : right;
  }
}
