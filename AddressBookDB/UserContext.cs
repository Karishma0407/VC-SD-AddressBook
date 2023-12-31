﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookDB
{
    public class UserContext
    {
        AddressBookDBEntities1 _Ctx;

        public UserContext()
        {
            _Ctx = new AddressBookDBEntities1();
        }

        public AddressBookDBEntities1 Context
        {
            get
            {
                return this._Ctx;
            }
        }

        public void Dispose()
        {
            if (_Ctx != null)
                _Ctx.Dispose();
        }
    }
}
