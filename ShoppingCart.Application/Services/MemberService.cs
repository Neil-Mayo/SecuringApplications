using ShoppingCart.Application.Interfaces;
using ShoppingCart.Application.ViewModels;
using ShoppingCart.Domain.Interfaces;
using ShoppingCart.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCart.Application.Services
{
    public class MemberService : IMembersService
    {
        IMembersRepository _membersRepo;
        public MemberService(IMembersRepository repo)
        {

            _membersRepo = repo;
        }
        public void AddMember(MemberViewModel m)
        {
            Member member = new Member()
            {
                Email = m.Email,
                FirstName = m.FirstName,
                LastName = m.LastName

            };
            _membersRepo.AddMember(member);
        }
    }
}
