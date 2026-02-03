using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpBootCamp301.EFPProject
{
    public partial class FrmStatistics : Form
    {
        public FrmStatistics()
        {
            InitializeComponent();
        }

        EgitimKampiEfTravelDbEntities db = new EgitimKampiEfTravelDbEntities();
        private void FrmStatistics_Load(object sender, EventArgs e)
        {
            lblLocationCount.Text = db.Location.Count().ToString();
            lblSumCapacity.Text= db.Location.Sum(x => x.Capacity).ToString();
            lblGuideCount.Text = db.Guide.Count().ToString();
            lblAvgCapacity.Text = db.Location.Average(x => x.Capacity).ToString();
            lblAvgLocationPrice.Text = db.Location.Average(x => x.Price).ToString();

            int lastCountryId = db.Location.Max(x => x.LocationId);
            lblLastCountyName.Text = db.Location.Where(x => x.LocationId == lastCountryId).Select(y => y.Country).FirstOrDefault();

            lblCappadociaLocationCapacity.Text = db.Location.Where(x => x.City == "Kapadokya").Select(y => y.Capacity).FirstOrDefault().ToString();
            lblTurkiyeCapacityAvg.Text = db.Location.Where(x=>x.Country == "Turkiye").Average(y=>y.Capacity).ToString();

            var romaGuideId = db.Location.Where(x => x.City == "Roma").Select(y=>y.GuideId).FirstOrDefault();

            lblRomaGuideName.Text = db.Guide.Where(x=> x.GuideId == romaGuideId ).Select(y=>y.GuideName).FirstOrDefault().ToString();

            var maxCapacityLocation = db.Location.Max(x => x.Capacity);
            lblMaxCapacityLocation.Text= db.Location.Where(x=>x.Capacity == maxCapacityLocation).Select(y=>y.City).FirstOrDefault().ToString();

            var maxPriceLocation = db.Location.Max(x => x.Price);
            lblMaxPriceLocation.Text = db.Location.Where(x=>x.Price == maxPriceLocation ).Select(y=>y.City).FirstOrDefault().ToString();

            var veliYilmazId = db.Guide.Where(x => x.GuideName == "Veli" && x.GuideSurname == "Yilmaz" ).Select(y => y.GuideId).FirstOrDefault();
            lblVeliYilmazLocationCount.Text = db.Location.Count(x => x.GuideId == veliYilmazId).ToString();


        }


    }
}
