﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp
{
    class Chuoiketnoi
    {
        string str;
        public Chuoiketnoi()
        {
            str = @"Data Source=DESKTOP-LRQ8VCB\SQLEXPRESS;Initial Catalog=QLCuaHangThoiTrang;Integrated Security=True";
        }

        public SqlConnection sqlConnection()
        {
            return new SqlConnection(str);
        }
    }
}
