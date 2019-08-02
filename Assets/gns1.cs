using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class gns1 : MonoBehaviour
{
    public Text a,aciksec;
    private string sec;
    public GameObject gunes, g1, g2, g3, g4, g5, g6, g7, g8, g9,ay,acikpanel;
    public AudioClip gü1, m1, v2, d1, m2, j1, s1, u1, n1, p1, a1;
    public AudioSource kaynak;
    
    public void geridönme()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void tus()
    {
        sec = a.text;
            Debug.Log(sec);
        if (sec == "GÜNEŞ") 
        {
            gunes.SetActive(true);
            g1.SetActive(false);
            g2.SetActive(false);
            g3.SetActive(false);
            g4.SetActive(false);
            g5.SetActive(false);
            g6.SetActive(false);
            g7.SetActive(false);
            g8.SetActive(false);
            g9.SetActive(false);
            ay.SetActive(false);
            acikpanel.SetActive(true);
            gunes.transform.localScale = new Vector3(1f,1f,1f);
            gunes.transform.localPosition = new Vector3(0,-2,0);
            aciksec.text = "Güneş: \n •	Güneş bir yıldızdır.\n•	Kendi ekseni etrafında döner.\n•	Küre biçiminde ve Dünya`mızdan çok çok büyük olan ısı ve ışık kaynağıdır.\n•	Güneş’in yapısı Hidrojen, Helyum gibi çeşitli gazlardan oluşur.\n•	Güneş`in yapısındaki hidrojen atomlarının helyuma dönüşmesi sırasında enerji açığa çıkar.";
        }
        if (sec == "MERKÜR")
        {
            ay.SetActive(false);
            gunes.SetActive(false);
            g1.SetActive(true);
            g2.SetActive(false);
            g3.SetActive(false);
            g4.SetActive(false);
            g5.SetActive(false);
            g6.SetActive(false);
            g7.SetActive(false);
            g8.SetActive(false);
            g9.SetActive(false);
            acikpanel.SetActive(true);
            g1.transform.localScale = new Vector3(1f,1f,1f);
            g1.transform.localPosition = new Vector3(0,-2,0);
            aciksec.text = "Merkür: \n•	Güneş`e en yakın olan gezegendir.\n•	Güneş etrafındaki dönüşünü 88 günde tamamlar.\n•	Merkür`ün herhangi bir doğal uydusu yoktur. \n•	Hidrojen, helyum ve neon gazlarından oluşan ince bir atmosferi vardır.\n•	Merkür`ün yüzeyinde Ay`ın yüzeyindekilere benzeyen kraterler vardır.\n•	Merkür`de canlıların yaşayabilmesini olanaklı kılacak koşullar bulunmamaktadır.Çünkü gezegenin Güneş`e dönük yüzünde sıcaklık, 400 dereceye kadar çıkar, buna karşılık karanlık yüzünde -173 dereceye kadar düşer.";
        }
        if (sec == "VENÜS")
        {
            ay.SetActive(false);
            gunes.SetActive(false);
            g1.SetActive(false);
            g2.SetActive(true);
            g3.SetActive(false);
            g4.SetActive(false);
            g5.SetActive(false);
            g6.SetActive(false);
            g7.SetActive(false);
            g8.SetActive(false);
            g9.SetActive(false);
            acikpanel.SetActive(true);
            g2.transform.localScale = new Vector3(1f,1f,1f);
            g2.transform.localPosition = new Vector3(0,-2,0);
            aciksec.text = "Venüs: \n•	Güneş çevresinde, ondan ortalama 107,5 milyon km uzaklıkta bir yörünge üzerinde dolanır.\n•	Güneş çevresindeki dolanma süresi 225 gündür.\n•	Venüs`ün kendi ekseni çevresindeki dönüşü geriye doğru, yani doğudan batıya doğrudur. \n•	Venüs`ün herhangi bir doğal uydusu yoktur. \n•	Yoğun atmosferinin yüzde 96`dan fazlası karbondioksitten, yüzde 3,5`i azottan, kalan kısmı da su buharı, argon ve neondan oluşur.\n•	Yüzeyinde sıcaklık yaklaşık 460 derecedir.Güneş Sistemi’nin en sıcak gezegenidir.";
        }
        if (sec == "DÜNYA")
        {
            ay.SetActive(false);
            gunes.SetActive(false);
            g1.SetActive(false);
            g2.SetActive(false);
            g3.SetActive(true);
            g4.SetActive(false);
            g5.SetActive(false);
            g6.SetActive(false);
            g7.SetActive(false);
            g8.SetActive(false);
            g9.SetActive(false);
            acikpanel.SetActive(true);
            g3.transform.localScale = new Vector3(1f,1f,1f);
            g3.transform.localPosition = new Vector3(0,-2,0);
            aciksec.text = "Dünya:\n•	Dünya, kutuplardan basık ekvatordan şişkin kendine has bir şekle sahiptir.\n•	Dünya, Güneş çevresindeki dönüşünü, elips şeklindeki yörüngesi üzerinde, 365 gün 6 saatte tamamlar.\n•	Dünya kendi ekseni etrafındaki dönüşünü, batıdan doğuya doğru 24 saatte tamamlar(Atmosferi ile döndüğünden, bu dönüş hissedilmez.)\n•	Dünya`mız kutup noktalarından geçen bir eksen etrafında döner.\n Dünya`nın dönme ekseni ile destek ekseni arasında 23,5 derecelik bir açı vardır.\n Bu eğiklik mevsimlerin oluşmasına, gece ile gündüz arasındaki farkın ekvatordan kutuplara doğru gittikçe artmasına sebep olur.\n•	Atmosferi, yaklaşık % 78'i azot, %21'i oksijen, % 1 su buharı ve kalan kısmı diğer bazı gazların karışımından oluşmuştur.\n•	Dünya`nın tek uydusu ve ona en yakın gök cismi Ay`dır.";
        }
        if (sec == "MARS")
        {
            ay.SetActive(false);
            gunes.SetActive(false);
            g1.SetActive(false);
            g2.SetActive(false);
            g3.SetActive(false);
            g4.SetActive(true);
            g5.SetActive(false);
            g6.SetActive(false);
            g7.SetActive(false);
            g8.SetActive(false);
            g9.SetActive(false);
            acikpanel.SetActive(true);
            g4.transform.localScale = new Vector3(1f,1f,1f);
            g4.transform.localPosition = new Vector3(0,-2,0);
            aciksec.text = "Mars: \n•	Güneş`ten ortalama uzaklığı yaklaşık 228 milyon km`dir.\n•	Güneş çevresinde bir tam dolanımı 687 günde tamamladığından bu gezegende mevsimler Dünya`dan yaklaşık iki kat daha uzundur. \n•	Mars`ın atmosferi çok incedir. Hemen hemen bütünüyle karbondioksitten oluşur.Ayrıca yaklaşık yüzde 2 azot ve yüzde 1 - 2 arasında değişen oranlarda argon içerdiği saptanmıştır. \n•	Kırmızı renkli bir gezegendir.\n•	Mars`ın iki küçük uydusu vardır; bunlar Phobos ve Deimos`tur.Phobos, Deimos ile kıyaslandığında hem daha büyük hem de Mars’a daha yakındır.Güneş sistemindeki diğer tüm uydular içinde gezegenine en yakın konumlanmış uydudur.";
        }
        if (sec == "JUPİTER")
        {
            ay.SetActive(false);
            gunes.SetActive(false);
            g1.SetActive(false);
            g2.SetActive(false);
            g3.SetActive(false);
            g4.SetActive(false);
            g5.SetActive(true);
            g6.SetActive(false);
            g7.SetActive(false);
            g8.SetActive(false);
            g9.SetActive(false);
            acikpanel.SetActive(true);
            g5.transform.localScale = new Vector3(1f,1f,1f);
            g5.transform.localPosition = new Vector3(0,-2,0);
            aciksec.text = "Jüpiter: \n•	Güneş sistemindeki en büyük gezegendir.\n•	Güneş`ten ortalama uzaklığı 777 milyon km`dir.\n•	Güneş çevresindeki bir tam dolanımını 11,86 yılda, kendi etrafındaki bir tam dönüşünü ise 9 saat 55 dakikada tamamlar. \n•	Venüs`ten sonra en parlak gezegendir.\n•	Atmosferi büyük ölçüde hidrojenden oluşmuştur, ayrıca az miktarda helyum, metan, amonyak, etan, su, karbonmonoksit, asetilen ve hidrojen siyanür içerir. \n•	Jüpiter son derece ince bir toz halkaya sahiptir. Güneş ışığını yansıtma konusunda çok zayıftır ve Yer’den gözlenemez.\n•	Bugüne kadar çevresinde dolanan 16 uydu keşfedilmiştir. Bunlardan en büyükleri Ganymede, Callisto, İo ve Europa`dır.Bu uydular Galileo tarafından, teleskopla birlikte keşfedildiler. Bu sebeple, Galileo uyduları olarak bilinirler.\n•	Sistemdeki en büyük uydu Ganymede’dir.Ortalama 5200 kilometre çapıyla Merkür’den daha büyüktür.";
        }
        if (sec == "SATÜRN")
        {
            ay.SetActive(false);
            gunes.SetActive(false);
            g1.SetActive(false);
            g2.SetActive(false);
            g3.SetActive(false);
            g4.SetActive(false);
            g5.SetActive(false);
            g6.SetActive(true);
            g7.SetActive(false);
            g8.SetActive(false);
            g9.SetActive(false);
            acikpanel.SetActive(true);
            g6.transform.localScale = new Vector3(1f,1f,1f);
            g6.transform.localPosition = new Vector3(0,-2,0);
            aciksec.text = "Satürn: \n•	Jüpiter`den sonra Güneş sistemindeki en büyük gezegendir.\n•	Güneşten ortalama uzaklığı 1.472 milyon km dir.\n•	Satürn’ün etrafında çok sayıda ve belirgin halkası vardır. Satürn’ün ilk olarak yaklaşık 400 yıl önce Galileo tarafından gözlemlenen halkaları buz ve kayaç parçacıklarından oluşuyor.\n•	Güneş Sistemindeki en düşük yoğunluğa sahip olan gezegen Satürn’dür. 0,69 g / cm3 yoğunluğa sahiptir.\n•	Satürn’ün bilinen en az 60 uydusu vardır. Satürn’ün isimlerinden 53 tanesinin ismi vardır, diğerleri keşif yıllarına dayanan sayılarla ifade edilir.Satürn’ün en büyük sekiz uydusunun adlar: Titan, Dione, Enceladus, Hyperion, Iapetus, Mimas, Rhea ve Tethys’tir.";
        }
        if (sec == "URANÜS")
        {
            ay.SetActive(false);
            gunes.SetActive(false);
            g1.SetActive(false);
            g2.SetActive(false);
            g3.SetActive(false);
            g4.SetActive(false);
            g5.SetActive(false);
            g6.SetActive(false);
            g7.SetActive(true);
            g8.SetActive(false);
            g9.SetActive(false);
            acikpanel.SetActive(true);
            g7.transform.localScale = new Vector3(1f,1f,1f);
            g7.transform.localPosition = new Vector3(0,-2,0);
            aciksec.text = "Uranüs: \n•	Güneş çevresindeki dolanım süresi 84.01 yıl, Güneş`e ortalama uzaklığı ise 2 milyar 870 milyon km civarındadır.\n•	Metandan oluşan bir atmosferi olduğu sanılmaktadır.\n•	Uranüs atmosferinin % 82.5’i hidrojen, % 15.2’si helyum ve % 2.3’ü metandır.\n•	Gezegene bakıldığında pürüzsüz bir yüzey gibi görünen atmosferin üst katmanlarında sıcaklık - 218° C’dir.\n•	Uranüs, ekseni etrafında, kutup bölgesi Güneş’e dönük şekilde dönen ilginç bir gezegendir.Uranüs’te ekvatorun yörüngeye eğikliği 98°dir.Yani gezegen, diğerlerine kıyasla yan yatmış gibi görünür.\n•	Satürn gibi, Uranüs de bir halka sistemine sahiptir.Ancak bu halkalar ince ve sönük olduğundan pek görülmezler.\n•	Uranüs’ün bilinen 27 tane uydusu vardır.En bilinen uyduları: Miranda, Ariel, Umbriel, Titania ve Oberon’dur.";
        }
        if (sec == "NEPTÜN")
        {
            ay.SetActive(false);
            gunes.SetActive(false);
            g1.SetActive(false);
            g2.SetActive(false);
            g3.SetActive(false);
            g4.SetActive(false);
            g5.SetActive(false);
            g6.SetActive(false);
            g7.SetActive(false);
            g8.SetActive(true);
            g9.SetActive(false);
            acikpanel.SetActive(true);
            g8.transform.localScale = new Vector3(1f,1f,1f);
            g8.transform.localPosition = new Vector3(0,-2,0);
            aciksec.text= "Neptün: \n•	Güneşin çevresindeki bir tam dolanımını 164.79 yılda tamamlar. \n•	Güneşten ortalama uzaklığı 4 milyar 494 km.dir.\n•	Atmosfer bileşimi olarak da Uranüs’e benzemektedir. Atmosferinin en üst bölümünde metan gazı bulutları vardır. \n•	Diğer gezegenlerin aksine gözlemle değil, matematiksel tahminlerle 1846 yılında keşfedilerek sistemdeki yerini almıştır.\n•	Sistemde Güneş’e en uzak ve en soğuk gezegen Neptün’dür.Ortalama - 200 derece sıcaklığa sahip olan gezegen Güneş’ten 4.5 milyar kilometre uzaklıkta yer alır.\n•	Neptün de bir halka sistemine sahiptir. \n•	Şu an ise bilinen uydularının sayısı 14’tür.Bunlardan Triton, asteroid kökenli uydular arasında en büyük olandır ve Güneş Sistemi objeleri içinde, ölçülen en düşük sıcaklığa sahip olan cisimdir(-235°C).\n•	Çıplak gözle görülmeyecek kadar soluktur.";
        }
        if (sec == "PLÜTON")
        {
            ay.SetActive(false);
            gunes.SetActive(false);
            g1.SetActive(false);
            g2.SetActive(false);
            g3.SetActive(false);
            g4.SetActive(false);
            g5.SetActive(false);
            g6.SetActive(false);
            g7.SetActive(false);
            g8.SetActive(false);
            g9.SetActive(true);
            acikpanel.SetActive(true);
            g9.transform.localScale = new Vector3(1f,1f,1f);
            g9.transform.localPosition = new Vector3(0,-2,0);
            aciksec.text = "Plüto: \n•	Keşfedildiği 1930 yılından bu yana yaklaşık 76 yıl boyunca sistemin 9.gezegeni olan Plüto, 2006 yılında Uluslararası Astronomi Birliği tarafından konulan gezegen kriterlerine uymadığı için gezegenlikten çıkarılmıştır.\n•	Gezegen tanımının yapılması dışında Plüto’nun gezegenlikten atılmasına neden olacak Bazı keşifler daha yapılmıştır:\n•	Yaklaşık - 223 C° olan atmosferinde donmuş metan gazı bulunduğu tahmin edilmektedir.\n•	Kendisine ait irili ufaklı 5 tane uydusu vardır.En büyük uydusu olan Charon Plüto’nun çap olarak % 66’sı kadardır.";
        }
        if (sec == "AY")
        {
            gunes.SetActive(false);
            g1.SetActive(false);
            g2.SetActive(false);
            g3.SetActive(false);
            g4.SetActive(false);
            g5.SetActive(false);
            g6.SetActive(false);
            g7.SetActive(false);
            g8.SetActive(false);
            g9.SetActive(false);
            ay.SetActive(true);
            acikpanel.SetActive(true);
            ay.transform.localScale = new Vector3(1f,1f,1f);
            ay.transform.localPosition = new Vector3(0,-2,0);
           
            aciksec.text = "Ay: \n•	Ay Dünya`nın çevresinde hareket eder. \n•	Kendi ekseni etrafında döner. \n•	Ayın yüzeyinde, “atmosfer” olarak nitelendirebileceğimiz oldukça ince bir gaz tabakası da bulunur.Atmosferinde helyum, oksijen, metan, nitrojen, karbon monoksit ve karbon dioksit gibi birçok elementin varlığı keşfedildi.\n•	Ay’ın büyüklüğü Dünya`nın 50 de biri kadardır.\n•	Ay`ın Dünya`ya olan ortalama uzaklığı 384000 km dir.";
        }


    }
    public void sestus() {
        sec = a.text;
        if (sec=="GÜNEŞ")
        {
            kaynak.clip = gü1;
            kaynak.Play();
        }
        if (sec == "MERKÜR")
        {
            kaynak.clip = m1;
            kaynak.Play();
        }
        if (sec == "VENÜS")
        {
            kaynak.clip = v2;
            kaynak.Play();
        }
        if (sec == "DÜNYA")
        {
            kaynak.clip = d1;
            kaynak.Play();
        }
        if (sec == "AY")
        {
            kaynak.clip = a1;
            kaynak.Play();
        }
        if (sec == "MARS")
        {
            kaynak.clip = m1;
            kaynak.Play();
        }
        if (sec == "JUPİTER")
        {
            kaynak.clip = j1;
            kaynak.Play();
        }
        if (sec == "SATÜRN")
        {
            kaynak.clip = s1;
            kaynak.Play();
        }
        if (sec == "URANÜS")
        {
            kaynak.clip = u1;
            kaynak.Play();
        }
        if (sec == "NEPTÜN")
        {
            kaynak.clip = n1;
            kaynak.Play();
        }
        if (sec == "PLÜTON")
        {
            kaynak.clip = p1;
            kaynak.Play();
        }


    }
}
