﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLot
{
    public interface ICarMethod
    {
        public List<Car> FetchCar(List<int?> ticket);
    }
}
