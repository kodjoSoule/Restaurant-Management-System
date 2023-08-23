using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_RMS_Final.Dao
{
        public interface IDao<T>
        {
            void Create(T entity);
            T Read(int id);
            List<T> List();
            void Update(T entity);
            void Delete(int id);
        }
    
}
