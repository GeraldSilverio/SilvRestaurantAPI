﻿using SilvRestaurant.Core.Domain.Commons;

namespace SilvRestaurant.Core.Domain.Entities
{
    public class Table:AuditableBaseEntity
    {
        public int AmountOfPeople {  get; set; }
        public string Description { get; set; } = null!;
        public string StatusOfTable { get; set; } = null!;

        public ICollection<Order> Orders { get; set; }
    }
}
