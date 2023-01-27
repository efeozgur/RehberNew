using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rehber.SINIFLAR
{
    public class GorevYeriDal
    {
        public List<GorevYeri> GetAll()
        {
            using (var dbcontext = new RehberContext())
            {
                return dbcontext.GorevYeris.ToList();
            }
        }
    }
}
