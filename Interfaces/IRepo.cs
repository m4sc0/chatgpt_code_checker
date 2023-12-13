using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Masco.ProjectManagement.Interfaces;

public interface IRepo<T>
{
    void Add(T item);
    void Remove(T item);
    void Update(T item);
    T Get(int id);
    IEnumerable<T> GetAll();
}
