﻿namespace Swashbuckle.TestApp.Api.Models
{
    public class Order
    {
        public int Id { get; set; }

        public string Description { get; set; }

        public decimal Total { get; set; }
    }
}