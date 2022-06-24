using DomainLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReprositryLayer.Reprositry
{
    public interface IReprositry<T> where T : BaseEntity
    {
        IEnumerable<T> GetAll();
        T Get(int id);
        void Insert(T entity);
        void Update(T entity);
        void Delete(T entity);
        void Remove(T entity);
        void SaveChanges();

        //void Delete(int id);
        //void DeleteAll();
        //void UpdateAll(IEnumerable<T> entities);
        //void DeleteAll(IEnumerable<T> entities);
        //void UpdateAll(IEnumerable<T> entities, int count);
        //void UpdateAll(IEnumerable<T> entities, int count, int max);
        //T GetById(int id);

    }
}
