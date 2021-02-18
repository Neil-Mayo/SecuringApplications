using ShoppingCart.Data.Context;
using ShoppingCart.Domain.Interfaces;
using ShoppingCart.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCart.Data.Repositories
{
    public class MembersRepository : IMembersRepository
    {
        ShoppingCartDbContext _context;
        public MembersRepository(ShoppingCartDbContext context)
        { _context = context; }
        public void AddMember(Member m)
        {
            _context.Members.Add(m);
            _context.SaveChanges();
        }
    }
}
