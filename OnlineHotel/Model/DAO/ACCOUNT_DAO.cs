using Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.DAO
{
    public class ACCOUNT_DAO
    {
        OnlineHotelDbContext db = null;

        public ACCOUNT_DAO()
        {
            db = new OnlineHotelDbContext();
        }
        public int Insert(ACCOUNT entity)
        {
            db.ACCOUNTs.Add(entity);
            db.SaveChanges();
            return entity.ID;
        }

        public int Login(string userName, string passWord)
        {
            var result = db.ACCOUNTs.SingleOrDefault(x => x.UserName == userName && x.Password == passWord);
            if (result == null)
            {
                return 0;
            }
            else
            {
                if (result.Password == passWord)
                {
                    return 1;
                }
                else
                {
                    return -1;
                }
            }
        }
        public ACCOUNT GetById(string userName)
        {
            return db.ACCOUNTs.SingleOrDefault(x => x.UserName == userName);
        }
    }
}
