using FactoryPattern.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.LabFactory
{
    public class ClinicalReferenceLab : IFactory
    {
        public string GetUDF()
        {
            return "CRL";
        }
    }
}
