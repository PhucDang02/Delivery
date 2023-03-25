using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Delivery.Entities
{
    [Serializable]
    public class ChucNang
    {
        public int MaChucNang { get; set; }
        public string TenChucNang { get;set; }
        public string BieuTuong { get; set; }
    }
}