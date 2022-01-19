using System;
using System.Collections.Generic;

namespace REntalKendaraan.Models
{
    public partial class Customer
    {
        public Customer()
        {
            Peminjaman = new HashSet<Peminjaman>();
        }

        public int IdCustomer { get; set; }
        public string NamaCustomer { get; set; }
        public byte[] Nik { get; set; }
        public byte[] Alamat { get; set; }
        public string NoHp { get; set; }
        public int? IdGender { get; set; }

        public Gender IdGenderNavigation { get; set; }
        public ICollection<Peminjaman> Peminjaman { get; set; }
    }
}
