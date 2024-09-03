using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K20_DienThoai
{
    internal class DienThoai
    {
        private string _maDT, _tenDT, _hangSX, _thongTin;
        private int _gia;

        public DienThoai() { }
        public DienThoai(string maDT, string tenDT, string hangSX, string thongTin, int gia)
        {
            _maDT = maDT;
            _tenDT = tenDT;
            _hangSX = hangSX;
            _thongTin = thongTin;
            _gia = gia;
        }
        public string MaDT {  get { return _maDT; } }
        public string TenDT {  get { return _tenDT; } }
        public string HangSX {  get { return _hangSX; } }
        public string ThongTin { get {  return _thongTin; } }
        public int Gia { get { return _gia; } }

    }
}
