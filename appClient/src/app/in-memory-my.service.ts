import { Injectable } from '@angular/core';
import { InMemoryDbService } from 'angular-in-memory-web-api';
import Contacts from './models/contacts-model';

@Injectable()
export class InMemoryMyService implements InMemoryDbService {

  constructor() { }

  createDb() {
    return {
      Contacts
    };
  }

}
