using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration.Configuration;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Project.Pizzaria.Infra.Data.Convetions
{
    public class TableLowerCaseConvention 
    {
        public void Apply(MemberInfo memberInfo, Func<PrimitivePropertyConfiguration> configuration)
        {
            
        }
    }
}