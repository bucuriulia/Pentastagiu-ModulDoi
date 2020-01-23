using System.Collections.Generic;
using System.Linq;

namespace Modul2_Saptamana1
{
    public abstract class IRestaurant
    {
        protected List<MenuItem> menuItems;
        public abstract bool Create(MenuItem item);
        public abstract bool Delete(int id);
        public abstract bool Edit(MenuItem item);
        public abstract MenuItem GetById(int id);
        public abstract List<MenuItem> GetAll();
    }
}
