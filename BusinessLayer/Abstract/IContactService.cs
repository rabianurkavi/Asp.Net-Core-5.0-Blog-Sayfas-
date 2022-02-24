using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IContactService
    {
        void ContactAdd(Contact contact);
        void ContacttDelete(Contact contact);
        void ContactUpdate(Contact contact);
        Contact GetById(int id);
        List<Contact> GetList();
    }
}
