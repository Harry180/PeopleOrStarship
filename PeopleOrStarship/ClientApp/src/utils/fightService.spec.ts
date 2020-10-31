import {Person} from "../app/dto/Person";
import {Starship} from "../app/dto/Starship";
import FightService from "./fightService";

describe('fightService', () => {
  let peopleList: Array<Person>;
  let starshipList: Array<Starship>;

  beforeEach(() => {
    peopleList = new Array<Person>();
    starshipList = new Array<Starship>();

    let person1: Person = {name:'name', id: 1, birthYear: '',eyeColor: '', hairColor: '', height:160, gender: 'n/a', skinColor: '', mass: 10, won: false, winCount: 0};
    let person2: Person = {name:'name2', id: 2, birthYear: '',eyeColor: '', hairColor: '', height:160, gender: 'n/a', skinColor: '', mass: 100, won: false, winCount: 0};
    peopleList.push(person1);
    peopleList.push(person2);
  });

  it('when person has bigger mass on account then it should be returned', () => {
    let result = FightService.fight(peopleList[0], peopleList[1]);
    expect(peopleList[1]).toBe(result);
  });
});
