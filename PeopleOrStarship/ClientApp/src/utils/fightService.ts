import {Person} from "../app/dto/Person";

export default class FightService {
    static fight = (personLeft: Person, personRight:Person) => {
    if(personLeft.massCount === personRight.massCount){
      return null;
    }
    return personLeft.massCount > personRight.massCount ? personLeft: personRight;
  }
}
