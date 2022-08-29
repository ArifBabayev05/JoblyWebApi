using System;
using Core.Entities;

namespace Entities.Concrete
{
    public class Vacancy : BaseEntity,IEntity
    {
        public string? Name { get; set; }
        public DateTime DeadlineDate { get; set; }
        public string Salary { get; set; }
        public string? TypeOfWork { get; set; }
        public string? Skills { get; set; }
        public Category Category { get; set; }
        public int CategoryId { get; set; }
        public City City { get; set; }
        public int CityId { get; set; }
        
    }
}

