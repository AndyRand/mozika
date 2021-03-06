using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.EntityFrameworkCore;
using Mozika.Domain.Repositories;
using Mozika.Domain.Entities;
using Microsoft.Extensions.DependencyInjection;

namespace Mozika.EFCore.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly MozikaContext _context;

        public CustomerRepository(MozikaContext context)
        {
            _context = context;
        }

        private bool CustomerExists(int id) =>
            _context.Customer.Any(c => c.CustomerId == id);

        public void Dispose() => _context.Dispose();

        public List<Customer> GetAll() =>
            _context.Customer.AsNoTracking().ToList();

        public Customer GetById(int id) =>
            _context.Customer.Find(id);

        public Customer Add(Customer newCustomer)
        {
            _context.Customer.Add(newCustomer);
            _context.SaveChanges();
            return newCustomer;
        }

        public bool Update(Customer customer)
        {
            if (!CustomerExists(customer.CustomerId))
                return false;
            _context.Customer.Update(customer);
            _context.SaveChanges();
            return true;
        }

        public bool Delete(int id)
        {
            if (!CustomerExists(id))
                return false;
            var toRemove = _context.Customer.Find(id);
            _context.Customer.Remove(toRemove);
            _context.SaveChanges();
            return true;
        }

        public List<Customer> GetBySupportRepId(int id) => _context.Customer.Where(a => a.SupportRepId == id).ToList();
    }
}