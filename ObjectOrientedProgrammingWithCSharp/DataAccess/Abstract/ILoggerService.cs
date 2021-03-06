﻿using System;
using System.Collections.Generic;
using System.Text;
using ObjectOrientedProgrammingWithCSharp.Interfaces;
using ObjectOrientedProgrammingWithCSharp.Properties;

namespace ObjectOrientedProgrammingWithCSharp.DataAccess
{
    interface ILoggerService
    {
        void Add(IEntity entity );
        void Update(IEntity entity);
        void Delete(IEntity entity);



    }
}
