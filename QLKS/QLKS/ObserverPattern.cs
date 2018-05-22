using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QLKS
{
    public interface ObserverPattern
    {
        void onSubmit(string dsDichVu, int tongChiPhiDichVu,string idPhong);
    }
}
