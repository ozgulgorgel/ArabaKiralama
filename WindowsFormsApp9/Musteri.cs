using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp9
{
    public class Musteri
    {
        private string ad;
        private string soyad;
        private DateTime dogumtarihi;
        private string tcno;
        private string telefon;
        private string cinsiyet;
        private DateTime ehliyetalis;

        public DateTime Ehliyetalis
        {
            get
            {
                return ehliyetalis;
            }
            set 
            {
                ehliyetalis = value; 
            }
        }
        private string adres;
        private string kartadı;
        private string kartno;
        private DateTime sonkullanmatarihi;
        private string cvc;

        public string Kartadı
        {
            get
            {
                return kartadı;
            }
            set
            {
                if (string.IsNullOrEmpty(value.Trim()))
                {
                    System.Windows.Forms.MessageBox.Show("Kart üzerindeki ismi giriniz");
                }
                kartadı = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(value);
            }
        }

      
        public string Ad
        {
            get
            {
                return ad;
            }
            set
            {
                if (string.IsNullOrEmpty(value.Trim()))
                {
                    System.Windows.Forms.MessageBox.Show("Adınızı giriniz");
                }
                ad = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(value);
            }
        }

        public string Soyad
        {
            get
            {
                return soyad;
            }
            set
            {
                if (string.IsNullOrEmpty(value.Trim()))
                {
                    System.Windows.Forms.MessageBox.Show("Soyadınızı giriniz");
                }
                soyad = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(value);
            }
        }

        public DateTime Dogumtarihi
        { 
            get
            {
                return dogumtarihi;
            }
            set
            {
                dogumtarihi = value;
            }
        }
        public string Tcno
        {
            get
            {
                return tcno;
            }
            set
            {
                if (!string.IsNullOrEmpty(value.Trim()))
                {
                    if (value.Length == 11)
                    {
                        if (!value.StartsWith("0"))
                        {
                            tcno = value;
                        }
                        else
                        {
                            System.Windows.Forms.MessageBox.Show("Tc no 0 ile başlayamaz");
                        }
                    }
                    else
                    {
                        System.Windows.Forms.MessageBox.Show("11 haneli Tc nizi giriniz");
                    }
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("TCno giriniz");
                }                              
            }
        }

        public string Telefon
        {
            get
            {
                return telefon;
            }
            set
            {
                if (string.IsNullOrEmpty(value.Trim()))
                {
                    System.Windows.Forms.MessageBox.Show("Telefon giriniz");
                }
                telefon = value;
            }
        }

        public string Cinsiyet
        {
            get
            {
                return cinsiyet;
            }
            set
            {
                cinsiyet = value;
            }
        }
      
        public string Adres
        {
            get
            {
                return adres;
            }
            set
            {
                if (string.IsNullOrEmpty(value.Trim()))
                {
                    System.Windows.Forms.MessageBox.Show("Adres giriniz");
                }
                adres = value;
            }
            
        }

        public string Kartno
        {
            get
            {
                return kartno;
            }
            set
            {
                if (!string.IsNullOrEmpty(value.Trim()))
                {
                    if(value.Length==16)
                    {
                        kartno = value;
                    }
                    else
                    {
                        System.Windows.Forms.MessageBox.Show("Kart no doğru giriniz");
                    }

                    
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Kart no giriniz");
                }
             
            }
        }
        public DateTime Sonkullanmatarihi
        { 
            get
            {
                return sonkullanmatarihi;
            }
            set 
            {
                sonkullanmatarihi = value; 
            }
        }
        public string Cvc
        {
            get
            {
                return cvc;
            }
            set
            {
                if(value.Length==3)
                {
                    cvc = value;
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Cvc kodunu doğru giriniz");
                }
            }
        }
    }
}
