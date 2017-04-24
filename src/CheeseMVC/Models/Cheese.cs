﻿namespace CheeseMVC.Models
{
    public class Cheese
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int ID { get; set; }

        public CheeseCategory Category { get; set; }
        public int CategoryId { get; set; }
    }
}
