﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Abstract
{


    public interface IEntity
    {
        public int ID { get; set; }

    }

    public class Entity : IEntity
    {
        public int ID { get; set; }
    }
}
