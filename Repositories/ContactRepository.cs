using marinaTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace marinaTest.Repositories
{
  public class ContactRepository
  {

    public Contact[] GetContacts()
    {
      return new Contact[] { new Contact(10, "Marina", "marina@mail.ru"), new Contact(5, "Andrey", "andrey@mail.ru") };
    }

    public Contact[] GetContactByName(string Name)
    {
      return new Contact[] { new Contact(10, Name, "marina@mail.ru") };
    }

    public Contact GetContactById(int Id)
    {
      return new Contact(Id, "Andrey", "andrey@mail.ru");
    }
  }
}
