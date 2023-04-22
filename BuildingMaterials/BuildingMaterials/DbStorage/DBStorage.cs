using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingMaterials.DbStorage
{
    public static class DBStorage
    {
        public static TradeEntities DB_s { get; set; } = new TradeEntities();
    }
}
