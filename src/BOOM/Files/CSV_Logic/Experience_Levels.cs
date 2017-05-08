﻿namespace BL.Servers.BB.Files.CSV_Logic
{
    using BL.Servers.BB.Files.CSV_Helpers;
    using BL.Servers.BB.Files.CSV_Reader;

    internal class Experience_Levels : Data
    {
        public Experience_Levels(Row _Row, DataTable _DataTable) : base(_Row, _DataTable)
        {
            Load(_Row);
           // LoadData(this, this.GetType(), _Row);
        }

        public string Name { get; set; }

        public int ExpPoints { get; set; }

        public int MaxOutposts { get; set; }
    }
}
