﻿

namespace Bl.BlApi
{
    public interface IBLCroud<T>
    {
        List<T> GetAll();
        T Get(int id);
        T Post(T t);
        T Put(T t);
        T Delete(int id);
    }
}
