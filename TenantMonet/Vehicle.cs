using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TenantMonet
{
    class Vehicles
    {
        private static string _Type;
        public string Type
        {
            get { return _Type; }
            set { _Type = value; }
        }
        private static string _ID;
        public string ID
        {
            get { return _ID; }
            set { _ID = value; }
        }
        private static int _Price;
        public int Price
        {
            get { return _Price; }
            set { _Price = value; }
        }
        public void inputkendaraan(string type, string id, int price)
        {
            _Type = type;
            _ID = id;
            _Price = price;
            Vehicle newvehicle = new Vehicle();
            newvehicle.Merek = type;
            newvehicle.PlatNomor = id;
            newvehicle.Harga = price;

            DataClassDataContext dbctx = new DataClassDataContext();
            dbctx.Vehicles.InsertOnSubmit(newvehicle);
            try
            {
                dbctx.SubmitChanges();
                MessageBox.Show("Berhasil");
            }
            catch
            {
                MessageBox.Show("Terjadi Kesalahan");
            }
        }
        public void ShowVehicle()
        {
            //menampilkan data dari database
        }
    }
}
