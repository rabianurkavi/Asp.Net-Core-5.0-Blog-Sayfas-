using EntityLayer.Concrete;

namespace BusinessLayer.Abstract
{
    public interface ICategoryService:IGenericService<Category>
    {
        // Eğer benim dal'dan başka bir metot'a ihtiyacım varsa bunu manager'dan yönetebilirim.
        bool UpdateRecordState(int id, bool state);
    }
}
