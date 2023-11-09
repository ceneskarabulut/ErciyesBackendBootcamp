using System;
namespace BootcampCografyaProje.Models
{
	public class Main
	{
        private static readonly List<Cografya> _cografya = new();

        static Main()
        {
            _cografya = new List<Cografya>()
            {

                new Cografya()
                {
                    Id = 1,
                    title = "Akarsular",
                    description = "Bir yatak içerisinde eğime bağlı olarak akan sulara akarsu denir. " +
                    "Akarsunun doğduğu yere kaynak, göle veya denize döküldüğü yere ağız, aktığı ve izlediği yola ise akarsu yatağı denir." +
                    "Akarsuların kolları ile aktığı yere ise havza denir. Akarsunun bir bölümünden saniyede geçen su miktarına debi " +
                    "denirken yıl içindeki akım düzenine de rejim denir. " ,
                    example="Kırgıbayır, Peribacası, Şelale, Vadi, Menderes",
                    image = "1.jpg",
                    tags = new string[]{"Çay","Öz","Irmak","Nehir"}

                },


                new Cografya()
                {
                    Id = 2,
                    title = "Rüzgarlar",
                    description = "Kurak veya yarı kurak iklim bölgelerinde en çok etkili olan dış kuvvet rüzgârlardır." +
                    " Rüzgârlar kopardıkları parçaları havalandırıp çarptırır, böylelikle aşındırma faaliyetini gerçekleştirmiş olur. " +
                    "Rüzgârlar hızlarının azaldığı yerlerde ise biriktirme faaliyetleri yaparlar",
                    example="Mantar Kaya, Şahit Kaya, Tafoni, Lös, Kumul",
                    image = "2.jpg",
                    tags = new string[]{"Karayel","Yıldız","Poyraz","Samyeli","Kıble","Lodos"}

                },

                new Cografya()
                {
                     Id=3,                     
                     title="Dalgalar",
                     description="Dalga ve akıntılar kıyıların zamanla değişip farklı görünümler almasına neden olurlar.",
                     example="Falez, Aşınım Platformu, Kıyı Oku, Lagün",
                     image="3.jpg",
                     tags = new string[]{"Rüzgar dalgası","Tsunami"}

                 },
                  new Cografya()
                  {
                     Id=4,                       
                     title="Yer Altı Suları",
                     description="Kalker, jips ve kaya tuzu gibi kolayca eriyebilen maddelerin bulundukları alanlara karstik alanlar " +
                     "denir, karstik arazilerde suların etkisiyle oluşan şekillere de karstik şekiller denir. " +
                     "Karstik şekillerin oluşumunda kayaç yapısı ile iklim özellikleri etkilidir.",
                     example="Lapya, Dolin, Uvala, Polye",
                     image="4.jpg",
                     tags = new string[]{"Yağış","Okyanus","Irmak","Göl","Bataklık"}

                    },
                   new Cografya()
                   {
                     Id=5,                       
                     title="Buzullar",
                     description="Soğuk iklim bölgelerinde etkili olan dış kuvvetlerdendir.",
                     example="Sirk(Buzul Çanağı), Moren",
                     image="5.jpg",
                     tags = new string[]{"Tatlı su","%98,5"}

                      },

        };
        }
        public static List<Cografya> Cografyas
        {
            get
            {
                return _cografya;
            }
        }

        public static Cografya? GetById(int? id)
        {
            return _cografya.FirstOrDefault(c => c.Id == id);
        }
    }
}

