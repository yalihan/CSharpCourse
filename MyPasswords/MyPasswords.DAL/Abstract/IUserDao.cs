﻿using MyPasswords.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPasswords.DAL.Abstract
{
    public interface IUserDao : IEntityDao<User>
    {
    }
}