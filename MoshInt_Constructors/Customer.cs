﻿using System.Collections.Generic;

namespace MoshInt_Constructors
{
    public class Customer
    {
        public int Id;
        public string Name;
        public List<Order> order;
        public Customer()
        {
            var orders = new List<Order>();
        }
        public Customer(int id)    : this()
        {
            this.Id = id;
        }
        public Customer(int id, string name) : this(id)
        {
            this.Name = name;
        }
    }
}
