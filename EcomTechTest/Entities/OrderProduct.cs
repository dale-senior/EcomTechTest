﻿namespace EcomTechTest.Entities
{
    public class OrderProduct
    {
        public int ID { get; set; }
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
