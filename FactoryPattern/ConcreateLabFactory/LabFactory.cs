using FactoryPattern.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.ConcreateLabFactory
{
    public abstract class LabFactory
    {
        public abstract IFactory GetLab(string labName);
    }
}
