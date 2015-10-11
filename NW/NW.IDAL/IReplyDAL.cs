﻿using NW.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NW.IDAL
{
    public interface  IReplyDAL:IBaseDAL<Reply>
    {
        IEnumerable<Reply> GetReplyAllFather(string whereStr);
    }
}
