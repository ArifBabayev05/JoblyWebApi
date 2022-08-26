using System;
using Core.Entities;

namespace Entities.Concrete
{
    public class Vacancy : IEntity
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime DeadlineDate { get; set; }
        public float Salary { get; set; }
        public string? TypeOfWork { get; set; }
        public string? Skills { get; set; }
        public bool IsDeleted { get; set; }

    }
}

