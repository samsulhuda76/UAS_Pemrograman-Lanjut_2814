using System;
using System.Collections.Generic;
using System.Text;
using UAS_PemrogramanLanjut_2814.Model;

namespace UAS_PemrogramanLanjut_2814.Controller
{
    class PromoController
    {
        public List<Diskon> diskon;

        public PromoController()
        {
            diskon = new List<Diskon>();
        }

        public void addPromo(Diskon diskon)
        {
            this.diskon.Add(diskon);
        }

        public List<Diskon> getDiskon()
        {
            return this.diskon;
        }
    }
}