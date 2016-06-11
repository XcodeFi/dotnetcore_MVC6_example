﻿using dotnetcore_MVC6_example.Entities;
using dotnetcore_MVC6_example.Infrastructure.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnetcore_MVC6_example.Infrastructure.Repositories
{
    public class ContactRepository:EntityBaseRepository<Contact>,IContactRepository
    {
        public ContactRepository(GreetingCardContext context) : base(context) { }
    }
}
