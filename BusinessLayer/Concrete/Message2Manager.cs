using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class Message2Manager : IMessage2Service
    {
        IMessage2Dal _messageDal;
        public Message2Manager(IMessage2Dal messageDal)
        {
            _messageDal = messageDal;
        }
        public Message2 GetById(int id)
        {
            return _messageDal.Get(x => x.MessageID == id);
        }
        public Message2 GetWriterNameWithId(int id)
        {
            return _messageDal.GetWriterNameWithId(id);
        }

        public List<Message2> GetList()
        {
            return _messageDal.GetListAll();
        }

        public List<Message2> GetInboxListWriter(int id)
        {
            return _messageDal.GetInboxListWithMessageByWriter(id);
        }

        public void TAdd(Message2 t)
        {
            _messageDal.Insert(t);
        }

        public void TDelete(Message2 t)
        {
            _messageDal.Delete(t);
        }

        public void TUpdate(Message2 t)
        {
            _messageDal.Update(t);
        }

        public List<Message2> GetInboxListByWriter(int id)
        {
            return _messageDal.GetInboxListWithMessageByWriter(id);
        }
        public List<Message2> GetSendBoxListByWriter(int id)
        {
            return _messageDal.GetSendBoxWithMessageByWriter(id);
        }
    }
}
