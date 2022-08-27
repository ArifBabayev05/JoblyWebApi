using System;
using Core.Entities;

namespace Entities.Concrete
{
    public class Company : BaseEntity,IEntity
    {
        public string Name { get; set; }
        public City City { get; set; }
        public int CityId { get; set; }
        public string Mail { get; set; }
        public string TelNumber { get; set; }
        public Image Image { get; set; }
        public int ImageId { get; set; }

    }
}

