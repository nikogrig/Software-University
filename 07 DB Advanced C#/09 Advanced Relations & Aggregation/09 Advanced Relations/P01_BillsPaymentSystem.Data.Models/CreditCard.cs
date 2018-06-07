﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01_BillsPaymentSystem.Data.Models
{
    public class CreditCard
    {
        public CreditCard()
        {
            
        }

        public CreditCard(decimal limit, decimal moneyOwed, DateTime expirationDate)
        {
            Limit = limit;
            MoneyOwed = moneyOwed;
            ExpirationDate = expirationDate;
        }

        public int CreditCardId { get; set; }

        public DateTime ExpirationDate { get; set; }

        public decimal Limit { get; set; }

        public decimal MoneyOwed { get; set; }

        public decimal LimitLeft => Limit - MoneyOwed;

        public int PaymentMethodId { get; set; }
        public PaymentMethod PaymentMethod { get; set; }

        public void Withdraw(decimal amount)
        {
            if (amount > this.LimitLeft)
            {
                throw new ArgumentException("Insufficient funds!");
            }

            this.MoneyOwed += amount;
        }

        public void Deposit(decimal amount)
        {
            if (amount < 0)
            {
                throw new AggregateException("Number can not be negative");
            }

            if (amount <= this.MoneyOwed)
            {
                this.MoneyOwed += amount;
                return;
            }

            this.Limit += amount - this.MoneyOwed;
            this.MoneyOwed = 0;
        }
    }
}
