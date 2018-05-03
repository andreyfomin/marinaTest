import { ContactService } from './../contact.service';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-contact',
  templateUrl: './contact.component.html',
  styleUrls: ['./contact.component.css'],
  providers: [ContactService]
})
export class ContactComponent implements OnInit {
  contactByName: any;
  contactById: any;
  contacts: any;

  constructor(private cs: ContactService) { }

  ngOnInit() {
    this.cs.getContactByName('Marina')
      .subscribe(
        data => this.contactByName = data,
        error => {
          console.error(error);
          this.contactByName = { error: `${error}` };
        }
      );

    this.cs.getContactById(5)
      .subscribe(
        data => this.contactById = data,
        error => {
          console.error(error);
          this.contactById = { error: `${error}` };
        }
      );

      this.cs.getContacts()
      .subscribe(
        data => this.contacts = data,
        error => {
          console.error(error);
          this.contactById = { error: `${error}` };
        }
      );
  }
}
