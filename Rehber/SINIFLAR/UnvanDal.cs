using System.Collections.Generic;
using System.Linq;

namespace Rehber.SINIFLAR
{
    public class UnvanDal
    {

        public List<Unvan> GetAll ()
        {
            using (var dbcontext = new RehberContext())
            {
                return dbcontext.Unvani.ToList();
            }
        }
    }
}
