using FactoryPattern.Factory;
using FactoryPattern.LabFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.ConcreateLabFactory
{
    public class ConcreteLabFactory : LabFactory
    {
        public override IFactory GetLab(string labName)
        {
            switch (labName)
            {
                case "CRL":
                    return new ClinicalReferenceLab();
                case "OM":
                    return new Omega();
                default:
                    throw new NotImplementedException();
            }
        }
    }
}
