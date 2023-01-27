using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;

namespace Rehber.SINIFLAR
{
    public class RehberDal
    {
        public List<Rehber> GetAll()
        {
            using (var dbcontext=new RehberContext())
            {
                
                return dbcontext.Rehber.ToList();
            }
        }
        public void Add(Rehber rehber)
        {
            using (var dbcontext= new RehberContext())
            {
                dbcontext.Rehber.Add(rehber);
                dbcontext.SaveChanges();
            }
        }
        public void Delete(int id)
        {
            using (var dbcontext=new RehberContext())
            {
                var kimlik = dbcontext.Rehber.First(p=>p.ID == id);
                dbcontext.Entry(kimlik).State =EntityState.Deleted;                
                dbcontext.SaveChanges();
            }
        }

        public void Update(Rehber rehber)
        {
            using (var dbcontext=new RehberContext())
            {
                dbcontext.Entry(rehber).State = EntityState.Modified;
                dbcontext.SaveChanges();
            }
        }
    }
}
