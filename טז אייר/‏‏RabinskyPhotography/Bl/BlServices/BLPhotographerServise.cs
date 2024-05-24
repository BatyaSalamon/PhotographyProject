

using AutoMapper;

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

        public BLPhotographer Post(BLPhotographer t)
        {
            Photographer p = mapper.Map<Photographer>(t);
            dalManager.Post(p);
            return mapper.Map<BLPhotographer>(p);
        }

        public BLPhotographer Put(int id)
        {
            throw new NotImplementedException();
        }
        public BLPhotographer Delete(int id)
        {
            throw new NotImplementedException();
        }
       
    }
}
