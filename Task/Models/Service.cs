﻿namespace Task.Api.Models
{
    public class Service
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<VehicleServices> VehicleServices { get; set; }
    }
}
