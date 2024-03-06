using System;
using System.Collections.Generic;
using System.Text;
using Core.DataAccess;
using Core.Entities;

namespace Entities.Concrete
{
    public class Car: IEntity
    {
        // Id, BrandId, ColorId, ModelYear, DailyPrice, Description alanlarını ekleyiniz. (Brand = Marka)

        public int CarId { get; set; }
        public int BrandId { get; set; }
        public int ColorId { get; set; }
        public string CarName { get; set; }
        public int ModelYear { get; set; }
        public int DailyPrice { get; set; }
        public string Description { get; set; }
        public bool CarState { get; set; }

    }
}
