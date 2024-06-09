


using Dal.Do;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Bl.BlServices
{
    public class BLPhotographerServise : IBLPhotographer
    {
        IDalPhotographer dalManager;
        IMapper mapper;
        public BLPhotographerServise(DalManager dalManager, IMapper mapper)
        {
            this.dalManager = dalManager.Photographer;
            this.mapper = mapper;
        }


        public List<BLPhotographer> GetAll()
        {
            List<Photographer> dalAllPhotographer = dalManager.GetAll();
            List<BLPhotographer> blAllPhotographer = new List<BLPhotographer>();
            for (int i = 0; i < dalAllPhotographer.Count(); i++)
            {
                blAllPhotographer.Add(mapper.Map<BLPhotographer>(dalAllPhotographer[i]));
            }
            return blAllPhotographer;
        }

        public BLPhotographer Get(int id)
        {
            return mapper.Map<BLPhotographer>(dalManager.Get(id));
        }

        public List<BLCustomer> GetCustomersByDate(DateTime? date, int id)
        {

            Photographer p = dalManager.Get(id);
            //List<Customer> c=p.Customers.Where(c=>c.WeddingDate==date).ToList();
            List<Customer> c = p.Customers.ToList();
            List<BLCustomer> n = new List<BLCustomer>();
            for (int i = 0; i < c.Count; i++)
            {
                n.Add(mapper.Map<BLCustomer>(c[i]));
            }
            return n;


        }

        public BLPhotographer Post(BLPhotographer t)
        {
            Photographer p = mapper.Map<Photographer>(t);
            dalManager.Post(p);
            return mapper.Map<BLPhotographer>(p);
        }

        public BLPhotographer Put(BLPhotographer t)
        {
            throw new NotImplementedException();
        }
        public BLPhotographer Delete(int id)
        {
            throw new NotImplementedException();
        }

    }
}
