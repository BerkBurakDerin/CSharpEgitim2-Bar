using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpEgıtım2.EFProject
{
    public partial class FrmStatistics: Form
    {
        public FrmStatistics()
        {
            InitializeComponent();
        }

        EgitimKampiEFTravelDbEntities db = new EgitimKampiEFTravelDbEntities();
        private void FrmStatistics_Load(object sender, EventArgs e)
        {
            lblLocationCount.Text = db.Location.Count().ToString();
            lblSumCapacity.Text = db.Location.Sum(x => x.Capacity).ToString();
            lblGuideCount.Text = db.Guide.Count().ToString();
            //lblAvgCapacity.Text = db.Location.Average(x=>x.Capacity).ToString();
            lblAvgCapacity.Text = ((int)db.Location.Average(x => x.Capacity)).ToString();
            //lblAvgLocationPrice.Text = ((int)db.Location.Average(x => x.Price)).ToString() + " TL";
            lblAvgLocationPrice.Text = string.Format("{0:0.00} TL", db.Location.Average(x => x.Price));
            
            int lastCountryId = db.Location.Max(x => x.LocationId);//En büyük ıd sahip ülke bulma
            lblLastCountryName.Text = db.Location.Where(x => x.LocationId == lastCountryId).Select(y => y.Country).FirstOrDefault();
            lblKapadokyaLocationCapacity.Text = db.Location.Where(x => x.City == "Kapadokya").Select(y => y.Capacity).FirstOrDefault().ToString();
            lblTurkiyeCapacityAvg.Text = db.Location.Where(x => x.Country == "Türkiye").Average(y => y.Capacity).ToString();

            var romaGuideId = db.Location.Where(x => x.City == "Roma").Select(y => y.GuideId).FirstOrDefault();
            lblRomaGuideName.Text = db.Guide.Where(x => x.GuideId == romaGuideId).Select(y => y.GuideName + " " +y.GuideSurname).FirstOrDefault().ToString();

            var highCapacity = db.Location.Max(x => x.Capacity);
            HighCapacityTour.Text = db.Location.Where(x => x.Capacity == highCapacity).Select(y => y.City).FirstOrDefault().ToString();

            var highPrice = db.Location.Max(x => x.Price);
            highPriceTour.Text = db.Location.Where(x => x.Price==highPrice).Select(y => y.City).FirstOrDefault().ToString();

            var veyselTourId = db.Guide.Where(x=>x.GuideName =="Veysel" && x.GuideSurname=="Polat").Select(y => y.GuideId).FirstOrDefault();
            lblVPTour.Text = db.Location.Where(x => x.GuideId == veyselTourId).Count().ToString();

        }

    }
}
