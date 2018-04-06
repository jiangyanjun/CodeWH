﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Model;
using DAL;

namespace BLL
{
    public class B_S_Menu : BaseBLL<S_Menu>
    {
        public override void SetCurrentDAL()
        {
            base.CurrentDAL = new D_S_Menu();
        }
    }
}