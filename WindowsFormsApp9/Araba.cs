using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp9
{
    public class Araba
    {
        private string marka;
        private string model;
        private string yas;
        private string yakit;

        public string Yakit
        {
          get { return yakit; }
          set { yakit = value; }
        }
                private string vites;
        
        public string Vites
        {
          get { return vites; }
          set { vites = value; }
        }
                private string klima;
        
        public string Klima
        {
          get { return klima; }
          set { klima = value; }
        }
        private string km;
        private string motorHacmi;
        private int fiyat;

        public int Fiyat
        {
            get { return fiyat; }
            set { fiyat = value; }
        }
                       
        public string Yas
        {
            get
            {
                return yas;
            }
            set
            {
                if (string.IsNullOrEmpty(value.Trim()))
                {
                    System.Windows.Forms.MessageBox.Show("Yaş giriniz");                   
                }
                yas = value;
            }
        }
        public string Model
        {
            get
            {
                return model;
            }
            set
            {
                if (string.IsNullOrEmpty(value.Trim()))
                {
                    System.Windows.Forms.MessageBox.Show("Model giriniz");                   
                }
                model = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(value);
            }
        }
        public string Marka
        {                  
            get
            {
                return marka;
            }
            set
            {
                if (string.IsNullOrEmpty(value.Trim()))
                {
                    System.Windows.Forms.MessageBox.Show("Marka giriniz");                    
                }
                marka = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(value);
            }
        }
  
        public string Km
        {
            get
            {
                return km;
            }
            set
            {
                if (string.IsNullOrEmpty(value.Trim()))
                {
                    System.Windows.Forms.MessageBox.Show("Km giriniz");
                }
                km = value;
            }
        }
        public string MotorHacmi
        {
            get
            {
                return motorHacmi;
            }
            set
            {
                if (string.IsNullOrEmpty(value.Trim()))
                {
                    System.Windows.Forms.MessageBox.Show("Motor hacmi giriniz");
                }
                motorHacmi =value;
            }
        }
       
    }
    
}
