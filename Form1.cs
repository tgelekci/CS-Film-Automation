using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Driver;
using MongoDB.Bson;



namespace FilmOtomasyonu
{
    public partial class FormFilmOtomasyonu : Form
    {

       
        public FormFilmOtomasyonu()
        {
            InitializeComponent();
        }

        

        public void Ekle()
        {


            var client = new MongoClient("mongodb://localhost:27017");
            var database = client.GetDatabase("movies");
            var collection = database.GetCollection<BsonDocument>("filmler");
            var document = new BsonDocument
            {
                {"Ad", txtFilmAdi.Text},
                {"Tür", txtFilmTuru.Text},
                {"Çıkış Yılı", txtCikisYili.Text},
                {"Kiralandı mı?", "Hayır"}
            };

            collection.InsertOneAsync(document);
            Console.Read();

            

        }

        public void Sil()
        {
            var client = new MongoClient("mongodb://localhost:27017");
            var database = client.GetDatabase("movies");
            var collection = database.GetCollection<BsonDocument>("filmler");
            
            var document = new BsonDocument
            {
                {"Ad", txtFilmSil.Text}
            };

            collection.DeleteOneAsync(document);
            Console.Read();
        }

        public void Hesapla()
        {
            double gunlukKira = 4.75;
            double gun = Convert.ToDouble(txtGun.Text);
            double toplamBedel = gun * gunlukKira;
            txtBedel.Text = toplamBedel.ToString();
           
        }

        public void Kirala()
        {
            var client = new MongoClient("mongodb://localhost:27017");
            var database = client.GetDatabase("movies");
            var collection = database.GetCollection<BsonDocument>("filmler");

            var filter = Builders<BsonDocument>.Filter.Eq("Ad", txtKirala.Text);

            var update = Builders<BsonDocument>.Update.Set("Kiralandı mı?", "Evet");

            var result = collection.UpdateOne(filter, update);

          
            MessageBox.Show("Film Kiralandı.");
            

        }

        public void TeslimEt()
        {
            var client = new MongoClient("mongodb://localhost:27017");
            var database = client.GetDatabase("movies");
            var collection = database.GetCollection<BsonDocument>("filmler");

            var filter = Builders<BsonDocument>.Filter.Eq("Ad", txtTeslim.Text);
            var update = Builders<BsonDocument>.Update.Set("Kiralandı mı?", "Hayır");
            
            var result = collection.UpdateOne(filter, update);

            MessageBox.Show("Film Geri Teslim Edildi.");
        }

        public void Guncelle()
        {

            var client = new MongoClient("mongodb://localhost:27017");
            var database = client.GetDatabase("movies");
            var collection = database.GetCollection<BsonDocument>("filmler");

            var filter = Builders<BsonDocument>.Filter.Eq("Ad", txtDegisen.Text);
           

            var update= Builders<BsonDocument>.Update.Set("Ad", txtYeniFilmAdi.Text).Set("Tür", txtYeniFilmTur.Text).Set("Çıkış Yılı", txtYeniFilmCikis.Text);
           

            var result = collection.UpdateOne(filter, update);

          
            
            MessageBox.Show("Film Bilgileri Güncellendi");
        }

        public void Bul()
        {
            
           

            dgvBul.AutoGenerateColumns = false;

       

            var client = new MongoClient("mongodb://localhost:27017");

            var database = client.GetDatabase("movies");
            var collection = database.GetCollection<BsonDocument>("filmler");

            List<FindMovie> meFind = new List<FindMovie>();

            foreach (var item in collection.Find(new BsonDocument()).ToList())
            {
                

                string isim = item[1].ToString();
                string tip = item[2].ToString();
                int yil = int.Parse(item[3].ToString());
                Boolean kira = item[4] == "Evet" ? true : false;

                meFind.Add(new FindMovie(isim, tip, yil, kira));

               
            }


            meFind.Sort();
            dgvBul.DataSource = meFind;
            
        }



        private void btnEkle_Click(object sender, EventArgs e)
        {
            Ekle();
            MessageBox.Show("Film Kategoriye Eklendi.");
           
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            Sil();
            MessageBox.Show("Film Kategoriden Başarıyla Silindi.");
        }

        private void btnKirala_Click(object sender, EventArgs e)
        {
            Kirala();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            Hesapla();
        }

        private void btnTeslim_Click(object sender, EventArgs e)
        {
            TeslimEt();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Guncelle();
        }

       
        private void btnGoster_Click(object sender, EventArgs e)
        {
            Bul();
        }
    }


}
