﻿using System;
using System.Collections.Generic;
using System.Text;

namespace EventBusRabbitMQ.Events
{
    public class BasketCheckoutEvent
    {
        public Guid RequestId { get; set; }
        public string UserName { get; set; }
        public decimal TotalPrice { get; set; }

        //For Billing
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAdress { get; set; }
        public string AdressLine { get; set; }
        public string Country { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }


        //For Payment
        public string CardName { get; set; }
        public string CardNumber { get; set; }
        public string Expiration { get; set; }
        public string CVV { get; set; }
        public int PaymentMethod { get; set; }
    }
}
