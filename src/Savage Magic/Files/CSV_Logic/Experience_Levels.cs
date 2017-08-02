﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRepublic.Magic.Files.CSV_Helpers;
using CRepublic.Magic.Files.CSV_Reader;

namespace CRepublic.Magic.Files.CSV_Logic
{
    internal class Experience_Levels : Data
    {
        public Experience_Levels(Row _Row, DataTable _DataTable) : base(_Row, _DataTable)
        {
            Load(_Row);
        }
        public string Name { get; set; }
        public int ExpPoints { get; set; }
    }
}
