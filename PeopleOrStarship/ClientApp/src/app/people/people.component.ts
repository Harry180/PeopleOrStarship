import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import {MatCardModule} from '@angular/material/card';
import {Person} from "../dto/Person";
import FightService from "../../utils/fightService";

@Component({
  selector: 'app-people-data',
  templateUrl: './people.component.html',
  styleUrls: ['./people.component.css']
})
export class PeopleComponent {
  private http:HttpClient;
  private baseUrl: string;
  public people: Person[];

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    this.http = http;
    this.baseUrl = baseUrl;
    this.extracted(http, baseUrl);
  }

  private extracted(http: HttpClient, baseUrl: string) {
    http.get<Person[]>(baseUrl + 'people').subscribe(result => {
      console.log(`people result: ${JSON.stringify(result)}`);
      this.people = result;
      var fightWinner = FightService.fight(result[0],result[1]);

      this.people.forEach((person,index) => {
        if(fightWinner.id === person.id){
          person.won = true;
        }
      });
    }, error => console.error(error));
  }

  fightAgain($event: MouseEvent) {
    this.people = null;
    this.extracted(this.http, this.baseUrl);
  }
}


