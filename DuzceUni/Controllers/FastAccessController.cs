using DuzceUni.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DuzceUni.Controllers
{
    public class FastAccessController : Controller
    {
        Context c = new Context();
        public IActionResult Index()
        {
            return View();
        }
        //üniversitemiz Başlangıç
        public IActionResult Duzce()
        {
            return View();
        }
        public IActionResult Kurulus()
        {
            return View();
        }
        //yönetim başlangıç
        public IActionResult Rektor()
        {
            return View();
        }
        public IActionResult RektorYardimcilari()
        {
            return View();
        }
        public IActionResult SenatoKurulu()
        {
            var degerler = c.SenateBoards.Include(x => x.Work).ToList();

            return View(degerler);
        }
        public IActionResult YonetimKurulu()
        {
            var degerler = c.DirectorBoards.Include(x => x.Work).ToList();

            return View(degerler);
        }
        public IActionResult GenelSekreter()
        {
            return View();
        }
        public IActionResult Rektorlerimiz()
        {
            return View();
        }
        // yönetim bitiş
        //sayılarla dü başlangıç
        public IActionResult ProjeSayilari()
        {
            return View();
        }
        public IActionResult FikriMulkiyet()
        {
            return View();
        }
        public IActionResult Derslik()
        {
            return View();
        }
        public IActionResult UIveDR()
        {
            return View();
        }
        public IActionResult Butce()
        {
            return View();
        }
        //sayılarla dü bitiş
        //sıralamalar başlangıç
        public IActionResult URAP()
        {
            return View();
        }
        public IActionResult THE()
        {
            return View();
        }
        public IActionResult GirisimcilikEndeksi()
        {
            return View();
        }
        public IActionResult GreenMetric()
        {
            return View();
        }
        public IActionResult InnovaLic()
        {
            return View();
        }
        //sıralamalar bitiş
        //kurumsal strateji başlangıç
        public IActionResult StratejikPlan()
        {
            return View();
        }
        public IActionResult KalitePolitikasi()
        {
            return View();
        }
        public IActionResult SurekliIyilestirmeKoordinatorlugu()
        {
            return View();
        }
        public IActionResult KİDR()
        {
            return View();
        }
        //Sürdürülebilirlik Raporu linki boş
        //kurumsal strateji bitiş
        //Kampüs yaşamı başlangıç
        public IActionResult BeslenmeHizmetleri()
        {
            return View();
        }
        public IActionResult SporMerkezleri()
        {
            return View();
        }
        public IActionResult Barinma()
        {
            return View();
        }
        //kampüs yaşamı bitiş
        public IActionResult ProtokolImzalananFirmalar()
        {
            var values = c.Cooperations.ToList();
            return View(values);
        }
        public IActionResult YonetmelikVeYonergeler() //yapılmadı
        {
            return View();
        }
        public IActionResult BGYSPolitikamiz()
        {
            return View();
        }
        // üniversitemiz Bitiş

        //akademik başlangıç
        public IActionResult Kurullar()
        {
            return View();
        }
        //Bölüm başkanlıkları içindeki iki sayfada link boş
        //akademik bitiş

        //araştırma başlangıç
        public IActionResult ArastirmaMerkezleri()
        {
            return View();
        }
        //laboratuvar envanteri link verildi
        //yayınlanan projeler ve hakemli dergiler linki boş
        public IActionResult TeknolojiTransferOfisi()
        {
            return View();
        }
        //araştırma bitiş

        // İhtisaslaşma Başlangıç
        public IActionResult ProgramKapsami()
        {
            return View();
        }
        public IActionResult TibbiBitkiYetistiriciligi()
        {
            return View();
        }
        public IActionResult UrunlerMarkalar()
        {
            return View();
        }
        public IActionResult UretimMerkezi()
        {
            return View();
        }
        public IActionResult GelenekselVeTamamlayiciTipFaaliyetleri()
        {
            return View();
        }
        public IActionResult TarimsalAtiklarinGeriKazanimiFaaliyetleri()
        {
            return View();
        }
        public IActionResult AricilikAriUrunleri()
        {
            return View();
        }
        public IActionResult BilimselYayinlar()
        {
            return View();
        }
        public IActionResult IsBirligiProtokolleri()
        {
            var values = c.Cooperations.ToList();
            return View(values);
        }
        public IActionResult Etkinlikler()
        {
            return View();
        }
        // İhtisaslaşma Bitiş
    }
}
