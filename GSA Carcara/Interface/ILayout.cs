﻿using GSA_Carcara.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GSA_Carcara.Interface
{
    interface IStatusDatabase
    {
        void SetStatusDatabase(Label status);
        void DatabaseLoading(Label status);
    }
    interface IListView
    {
        void setListView(ListView listView1);
        void AddToListView(ListView listView1, List<Vehicle> CarFiltred);
    }
}
