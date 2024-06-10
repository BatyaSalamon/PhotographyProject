

using AutoMapper;

namespace Bl.BlServices
{
    public class BLPriceServise : IBLPrice
    {
        IDalPrice dalManager;
        IMapper mapper;
        public BLPriceServise(DalManager dalManager, IMapper mapper)
        {
            this.dalManager = dalManager.Price;      
            this.mapper = mapper;
        }

        public List<BLPrice> GetAll()
        {
            {
                List<Price> dalAllPrice = dalManager.GetAll();
                List<BLPrice> blAllPrice = new List<BLPrice>();
                for (int i = 0; i < dalAllPrice.Count(); i++)
                {
                    blAllPrice.Add(mapper.Map<BLPrice>(dalAllPrice[i]));
                }
                return blAllPrice;
            }
        }

        public BLPrice Get(int id)
        {
            return mapper.Map<BLPrice>(dalManager.Get(id));
        }

        public BLPrice Post(BLPrice t)
        {
            Price p = mapper.Map<Price>(t);
            dalManager.Post(p);
            return mapper.Map<BLPrice>(p);
        }

        public BLPrice Put(int id, BLPrice t)
        {
            Price p = mapper.Map<Price>(t);
            dalManager.Put(id,p);
            return mapper.Map<BLPrice>(p);
        }

        public BLPrice Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
