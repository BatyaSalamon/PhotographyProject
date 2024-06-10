


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
            List<Photographer> dalAllPhotographer = dalManager.GetAllWithPrice();
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

        public BLCustomer GetCustomersByDate(DateTime? date, int id)
        {

            List<Photographer> c = dalManager.GetAllWithCustomer();
            Photographer p = c.FirstOrDefault(c => c.Id == id);
            Customer pc = p.Customers.FirstOrDefault(c=> c.WeddingDate==date);

       
            return mapper.Map<BLCustomer>(pc);


        }

        public List<BLCustomer> GetCustomersByMonth(int month, int id)
        {

            List<Photographer> c = dalManager.GetAllWithCustomer();
            Photographer p = c.FirstOrDefault(c => c.Id == id);
            var pc =p.Customers.Where(c => c.WeddingDate.Month == month);
            List<Customer> pp = pc.ToList();

            List < BLCustomer > cc=new List<BLCustomer >();
            for (int i = 0; i < pp.Count; i++)
            {
                cc.Add(mapper.Map<BLCustomer>(pp[i]));
            }

            return cc;


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
