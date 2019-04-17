using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Araba Kiralama";
            tabPage1.BackgroundImage = Image.FromFile("../../Images/6063.jpeg");
            tabPage2.BackgroundImage = Image.FromFile("../../Images/wallpaper-ferrari-6518399.jpg");
            dtsonkullan.CustomFormat = "MM/yyyy";
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            comboBox2.Text = "";
            comboBox3.Items.Clear();
            comboBox3.Text = "";
            if(comboBox1.Text == "İstanbul")
            {
               
                comboBox2.Items.Add("Beşiktaş");
                comboBox2.Items.Add("Eminönü");
            }
            else if(comboBox1.Text == "Ankara")
            {
               
                comboBox2.Items.Add("Çankaya");               
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox3.Items.Clear();
            comboBox3.Text = "";
            if(comboBox2.Text == "Beşiktaş")
            {
             
                comboBox3.Items.Add("Özlem Oto Kiralama");
            }
            else if(comboBox2.Text == "Eminönü")
            {
             
                comboBox3.Items.Add("Özgül Oto Kiralama");
            }
            else if(comboBox2.Text == "Çankaya")
            {
              
                comboBox3.Items.Add("Mustafa Oto Kiralama");
            }
        }
      
        private void button1_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)//Secili satır varmı yokmu kontrol ediliyor.
            {
                DateTime bTarih = Convert.ToDateTime(dateTimePicker2.Text);
                DateTime kTarih = Convert.ToDateTime(dateTimePicker1.Text);
                TimeSpan Sonuc = bTarih - kTarih;
                label8.Text = Sonuc.TotalDays.ToString();
                textBox2.Text = listView1.SelectedItems[0].SubItems[8].Text;
                int a = Convert.ToInt32(label8.Text) * Convert.ToInt32(textBox2.Text);
                textBox2.Text = a.ToString();
            }
            else
            {
                MessageBox.Show("Lütfen önce seçim yapınız");
            }
        }
      
        private void button2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage3;            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            if(comboBox3.Text == "Özlem Oto Kiralama")
            {
                
                string[] a1 = new string[] { "Mercedes Benz", "S350", "2010", "Benzin", "Otomatik", "Var", "127.475", "3500", "300" };
                string[] a2 = new string[] { "Mercedes Benz", "C180", "2012", "Dizel", "Manuel", "Var", "173.472", "1800", "220" };
                string[] a3 = new string[] { "BMW", "5.40i", "2013", "Benzin", "Otomatik", "Var", "75.629", "4000", "275" };
                listView1.Items.Add(new ListViewItem(a1));
                listView1.Items.Add(new ListViewItem(a2));
                listView1.Items.Add(new ListViewItem(a3));
            }
            else if(comboBox3.Text== "Özgül Oto Kiralama")
            {
              
                string[] a4 = new string[] { "BMW", "3,20d", "2009", "Dizel", "Manuel", "Var", "205.436", "2000", "200" };
                string[] a5 = new string[] { "Audi", "A8", "2016", "Benzin", "Otomatik", "Var", "55.780", "3000", "325" };
                string[] a6 = new string[] { "Renault", "Fluence", "2014", "Dizel", "Manuel", "Yok", "139.470", "1400", "175" };
                listView1.Items.Add(new ListViewItem(a4));
                listView1.Items.Add(new ListViewItem(a5));
                listView1.Items.Add(new ListViewItem(a6));
            }
            else if(comboBox3.Text == "Mustafa Oto Kiralama")
            {
              
                string[] a7 = new string[] { "Opel", "Insignia", "2017", "Benzin", "Otomatik", "Var", "146,548", "1600", "270" };
                string[] a8 = new string[] { "Honda", "Accord", "2011", "Benzin", "Manuel", "Var", "89.627", "2000", "230" };
                string[] a9 = new string[] { "Jeep", "Grand Cheeroke", "2008", "Benzin", "Otomatik", "Var", "125.000", "4500", "210" };
                listView1.Items.Add(new ListViewItem(a7));
                listView1.Items.Add(new ListViewItem(a8));
                listView1.Items.Add(new ListViewItem(a9));
            }
            tabControl1.SelectedTab = tabPage2;
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        Giris g = new Giris();    //Hem Ödeme butonunda hem de yukarıda button3te admin girişi yaparken kullanmamız gerekiyordu. ikisindede ayrı ayrı Giris g = new Giris(); yazınca bize boş sayfa geliyordu.
                    //böyle genele yazarak boş sayfa açmasını önledik. hem form1 e "Giris g = new Giris();" yazıp, Giris ede "Form1 f = new Form1();" yazarsak sonsuz döngüye giriyordu.
        private void button4_Click(object sender, EventArgs e)
        {
            Musteri m = new Musteri();           
            m.Ad = textad.Text;
            m.Soyad = textsoyad.Text;
            m.Dogumtarihi = dtdogum.Value;
            m.Tcno = texttc.Text;
            m.Telefon = maskedTextBox1.Text;
            if (radioButton1.Checked)
                m.Cinsiyet = radioButton1.Text;
            else if (radioButton2.Checked)
                m.Cinsiyet = radioButton2.Text;
            m.Ehliyetalis = dateTimePicker4.Value;
            m.Adres = richTextBox1.Text;
            m.Kartadı = textkartisim.Text;
            m.Kartno = textkartno.Text;
            m.Sonkullanmatarihi = dtsonkullan.Value;
            m.Cvc = textcvv.Text;
            string a;
            a = listView1.SelectedItems[0].SubItems[0].Text+" "+ listView1.SelectedItems[0].SubItems[1].Text;
            string[] arabakayit = new string[] { m.Ad + " " + m.Soyad, m.Telefon, m.Adres, dateTimePicker1.Value.ToString(), dateTimePicker2.Value.ToString(), a};           
            if (!string.IsNullOrEmpty(m.Ad))
                if (!string.IsNullOrEmpty(m.Soyad))
                    if (!string.IsNullOrEmpty(m.Tcno))
                        if (!string.IsNullOrEmpty(m.Adres))
                            if (!string.IsNullOrEmpty(m.Kartadı))
                                if (!string.IsNullOrEmpty(m.Kartno))
                                    if (!string.IsNullOrEmpty(m.Cvc))
                                        if (checkBox1.Checked)
                                        {
                                            g.listView1.Items.Add(new ListViewItem(arabakayit));
                                            MessageBox.Show("Ödeme işlemi başarıyla gerçekleştirildi");
                                            Temizle1();
                                        }
                                        else
                                        {
                                            MessageBox.Show("Kiralama sözleşmesini okuyunuz");
                                        }
        }

        void Temizle1()
        {
            foreach (Control item in groupBox1.Controls)
            {
                if (item is TextBox)
                {
                    TextBox txt = (TextBox)item;
                    txt.Clear();
                }
                else if (item is DateTimePicker)
                {
                    DateTimePicker dt = (DateTimePicker)item;
                    dt.Value = DateTime.Now;
                }
                else if (item is RadioButton)
                {
                    RadioButton rd = (RadioButton)item;
                    rd.Checked = false;
                }
                else if (item is RichTextBox)
                {
                    RichTextBox rc = (RichTextBox)item;
                    rc.Clear();
                }
                else if (item is MaskedTextBox)
                {
                    MaskedTextBox mt = (MaskedTextBox)item;
                    mt.Clear();
                }


            }
            foreach (Control item in groupBox2.Controls)
            {
                if (item is TextBox)
                {
                    TextBox txt = (TextBox)item;
                    txt.Clear();
                }
                else if (item is DateTimePicker)
                {
                    DateTimePicker dt = (DateTimePicker)item;
                    dt.Value = DateTime.Now;
                }
                else if (item is RadioButton)
                {
                    RadioButton rd = (RadioButton)item;
                    rd.Checked = false;
                }
                else if (item is RichTextBox)
                {
                    RichTextBox rc = (RichTextBox)item;
                    rc.Clear();
                }
                if (item is CheckBox)
                {
                    CheckBox chc = (CheckBox)item;
                    chc.Checked = false;
                }

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Araba a = new Araba();
            a.Marka = textmarka.Text;
            a.Model = textmodel.Text;
            a.Yas = textyasyılı.Text;
            if (checkBox4.Checked)
            {
                a.Yakit = checkBox4.Text;
            }
            else if (checkBox3.Checked)
            {
                a.Yakit = checkBox3.Text;
            }
            a.Vites = comboBoxvites.Text;
            if (radioButton4.Checked)
            {
                a.Klima = radioButton4.Text;
            }
            else if (radioButton3.Checked)
            {
                a.Klima = radioButton3.Text;
            }
            a.Km = textkm.Text;
            a.MotorHacmi = texthacim.Text;
            a.Fiyat = Convert.ToInt32(textfiyat.Text);
            string[] arababilgileri = new string[] { a.Marka, a.Model, a.Yas, a.Yakit, a.Vites, a.Klima, a.Km, a.MotorHacmi, a.Fiyat.ToString() };

            string kullaniciadi, sifre;
            kullaniciadi = txtad.Text;
            sifre = txtsif.Text;
            
            if (kullaniciadi == "admin" && sifre == "123456")
            {
                if(!string.IsNullOrEmpty(a.Marka))
                    if(!string.IsNullOrEmpty(a.Model))
                        if(!string.IsNullOrEmpty(a.Yas))
                            if(!string.IsNullOrEmpty(a.Vites))
                                if(!string.IsNullOrEmpty(a.Km))
                                    if(!string.IsNullOrEmpty(a.MotorHacmi))                                        
                                    {
                                        listView1.Items.Add(new ListViewItem(arababilgileri));
                                        Temizle();
                                        MessageBox.Show("Başarıyla eklendi");
                                    }               
            }
            else
            {
                MessageBox.Show("Admin bilgileri hatalı");
            }
            
            
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                checkBox3.Enabled = false;
            }
            else
            {
                checkBox3.Enabled = true;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                checkBox4.Enabled = false;
            }
            else
            {
                checkBox4.Enabled = true;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage2;
        }
        void Temizle()
        {
            foreach (Control item in this.tabPage5.Controls)
            {
                if (item is TextBox)
                {
                    TextBox txt = (TextBox)item;
                    txt.Clear();
                }
                if (item is CheckBox)
                {
                    CheckBox chc = (CheckBox)item;
                    chc.Checked = false;
                }
                if (item is RadioButton)
                {
                    RadioButton rd = (RadioButton)item;
                    rd.Checked = false;
                }
                if (item is ComboBox)
                {
                    ComboBox cmb = (ComboBox)item;
                    cmb.Text = "";
                }
            }
        }

        private void buttongiris_Click_1(object sender, EventArgs e)
        {
            string kullaniciadi, sifre;
            kullaniciadi = textkul.Text;
            sifre = textsifre.Text;
            if (kullaniciadi == "admin" && sifre == "123456")
            {              
                g.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Admin bilgileri hatalı");
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Police p = new Police();
            if (checkBox1.Checked)
                p.Show();
            else
                p.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }

}
