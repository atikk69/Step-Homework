﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trendyol.Services.Interfaces
{
    public interface IDataService
    {
        public void SendData(object data);
        public void SendDatas(object[] data);
    }
}
