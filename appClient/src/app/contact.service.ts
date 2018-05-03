import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable()
export class ContactService {

  constactsURL = 'api/contacts';
  constructor(private http: HttpClient) { }

  getContactById(id: number) {
    return this.http.get(`${this.constactsURL}/${id}`);
  }

  getContactByName(name: string) {
    return this.http.get(`${this.constactsURL}?name=${name}`);
  }

  getContacts() {
    return this.http.get(this.constactsURL);
  }
}
