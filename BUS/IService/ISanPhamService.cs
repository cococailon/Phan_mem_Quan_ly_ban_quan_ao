﻿using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.IService
{
    public interface ISanPhamService
    {

        public List<Sanpham> GetSanphams();
        public List<Thuonghieu> GetThuonghieus();

        public string Add(Sanpham sp);

        public string Delete(Sanpham sanpham);
    }
}
