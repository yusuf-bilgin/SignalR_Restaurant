﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR_Restaurant.DataAccessLayer.Abstract
{
    public interface IRestaurantTableDal
    {
        int TotalTableCount();
    }
}
