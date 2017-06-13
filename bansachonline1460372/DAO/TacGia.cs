﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class TacGia
    {
        public static IEnumerable<BanSachOnlineConnection.TacGium> get()
        {
            using (var db = new BanSachOnlineConnection.BanSachOnlineConnectionDB())
            {
                return db.Query<BanSachOnlineConnection.TacGium>("select * from TacGia");
            }
        }

        public static PetaPoco.Page<BanSachOnlineConnection.TacGium> get(int pageIndex, int itemPer)
        {
            using (var db = new BanSachOnlineConnection.BanSachOnlineConnectionDB())
            {
                return db.Page<BanSachOnlineConnection.TacGium>(pageIndex, itemPer, "select * from TacGia");
            }
        }
    }
}