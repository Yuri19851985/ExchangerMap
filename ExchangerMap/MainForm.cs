using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.WindowsForms.ToolTips;
using MudulExchange;
using MudulExchange.Context;
using MudulExchange.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExchangerMap
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            Load += MainForm_Load;
        }

        List<Bank> bankBestRates = new List<Bank>();

        void MainForm_Load(object sender, EventArgs e)
        {
            SetParamsMap();
        }

        void SetParamsMap()
        {
            gMapControl2.MapProvider = GMap.NET.MapProviders.GMapProviders.OpenStreetMap;
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerAndCache;
            gMapControl2.Position = new GMap.NET.PointLatLng(53.902800, 27.561759);
            splitContainer1.Panel1.Controls.Add(gMapControl2);
            gMapControl2.MarkersEnabled = true;
            gMapControl2.RoutesEnabled = true;

        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            using (ExchangeContext db = new ExchangeContext("ExchangeConnectionString"))
            {
                ShowBankMarkers(db.Banks);
            }
        }

        public void ShowBankMarkers(IEnumerable<Bank> banks)
        {
            GMapOverlay markers = new GMapOverlay("markers");
            gMapControl2.Overlays.Clear();
            foreach (var i in banks)
            {
                if (i.BankInfos.Count() != 0)
                {
                    foreach (var item in i.BankInfos)
                    {
                        if (i.usdSell != 0 && i.usdBuy != 0 && i.eurSell != 0 && i.eurBuy != 0 && i.rurSell != 0 && i.rurBuy != 0)
                        {
                            GMapMarker marker = new GMarkerGoogle(new PointLatLng(item.latitude, item.longitude),
                            GMarkerGoogleType.blue_pushpin);
                            marker.ToolTipText = i.Name + "\n" + item.Address.ToString() + "\n" + "USD: " + i.usdSell + "; " +
                                i.usdBuy + "\n" + "EUR: " + i.eurSell + "; " + i.eurBuy + "\n" + "RUR: " + i.rurSell + "; " + i.rurBuy;
                            markers.Markers.Add(marker);
                            gMapControl2.Overlays.Add(markers);
                        }
                    }
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            gMapControl2.Overlays.Clear();
            gMapControl2.Refresh();
            tbStartLat.Text = "";
            tbStartLong.Text = "";
            tbBestRate.Text = "";
            tbBestBank.Text = "";
        }

        private void StartPoint_Click(object sender, EventArgs e)
        {
            gMapControl2.MouseClick += gMapControl2_MouseClick;
        }

        void gMapControl2_MouseClick(object sender, MouseEventArgs e)
        {
            double X = gMapControl2.FromLocalToLatLng(e.X, e.Y).Lat;
            double Y = gMapControl2.FromLocalToLatLng(e.X, e.Y).Lng;
            GMapOverlay markerPoints = new GMapOverlay();
            GMapMarker markerClick = new GMarkerGoogle(new PointLatLng(X, Y),
                                GMarkerGoogleType.red_pushpin);

            markerClick.ToolTip = new GMapRoundedToolTip(markerClick);
            markerClick.ToolTipText = "Мое местоположение";
            markerPoints.Markers.Add(markerClick);
            gMapControl2.Overlays.Add(markerPoints);
            tbStartLat.Text = markerClick.Position.Lat.ToString();
            tbStartLong.Text = markerClick.Position.Lng.ToString();
            gMapControl2.MouseClick -= gMapControl2_MouseClick;
        }

        public int MaxRateSearch(List<int> rates)
        {
            return rates.Max();
        }
        public int MinRateSearch(List<int> rates)
        {
            return rates.Min();
        }

        private void UsdSaleBtn_Click(object sender, EventArgs e)
        {
            using (ExchangeContext db = new ExchangeContext("ExchangeConnectionString"))
            {
                bankBestRates.Clear();
                double max = db.Banks.Max(i => i.usdBuy);
                tbBestRate.Text = "Покупка \n1 USD = " + max + " BYN";
                foreach (var i in db.Banks)
                {
                    if (i.BankInfos.Count() != 0 && i.usdBuy == max)
                    {
                        bankBestRates.Add(i);
                    }
                }
                ShowBankMarkers(bankBestRates);
            }
        }

        private void UsdBuyBtn_Click(object sender, EventArgs e)
        {
            using (ExchangeContext db = new ExchangeContext("ExchangeConnectionString"))
            {
                bankBestRates.Clear();
                var min = (from i in db.Banks where i.usdSell > 0 select i).Min(k => k.usdSell);
                tbBestRate.Text = "Продажа \n1 USD = " + min + " BYN";
                foreach (var i in db.Banks)
                {
                    if (i.BankInfos.Count() != 0 && i.usdSell == min)
                    {
                        bankBestRates.Add(i);
                    }
                }
                ShowBankMarkers(bankBestRates);
            }
        }

        private void EurSaleBtn_Click(object sender, EventArgs e)
        {
            using (ExchangeContext db = new ExchangeContext("ExchangeConnectionString"))
            {
                bankBestRates.Clear();
                double max = db.Banks.Max(i => i.eurBuy);
                tbBestRate.Text = "Покупка \n1 EUR = " + max + " BYN";
                foreach (var i in db.Banks)
                {
                    if (i.BankInfos.Count() != 0 && i.eurBuy == max)
                    {
                        bankBestRates.Add(i);
                    }
                }
                ShowBankMarkers(bankBestRates);
            }
        }

        private void EurBuyBtn_Click(object sender, EventArgs e)
        {
            using (ExchangeContext db = new ExchangeContext("ExchangeConnectionString"))
            {
                bankBestRates.Clear();
                var min = (from i in db.Banks where i.eurSell > 0 select i).Min(k => k.eurSell);
                tbBestRate.Text = "Продажа \n1 EUR = " + min + " BYN";
                foreach (var i in db.Banks)
                {
                    if (i.BankInfos.Count() != 0 && i.eurSell == min)
                    {
                        bankBestRates.Add(i);
                    }
                }
                ShowBankMarkers(bankBestRates);
            }
        }

        private void RurSaleBtn_Click(object sender, EventArgs e)
        {
            using (ExchangeContext db = new ExchangeContext("ExchangeConnectionString"))
            {
                bankBestRates.Clear();
                double max = db.Banks.Max(i => i.rurBuy);
                tbBestRate.Text = "Покупка \n1 RUR = " + max + " BYN";
                foreach (var i in db.Banks)
                {
                    if (i.BankInfos.Count() != 0 && i.rurBuy == max)
                    {
                        bankBestRates.Add(i);
                    }
                }
                ShowBankMarkers(bankBestRates);
            }
        }

        private void RurBuyBtn_Click(object sender, EventArgs e)
        {
            using (ExchangeContext db = new ExchangeContext("ExchangeConnectionString"))
            {
                bankBestRates.Clear();

                var min = (from i in db.Banks where i.rurSell > 0 select i).Min(k => k.rurSell);
                tbBestRate.Text = "Продажа \n100 RUR = " + min + " BYN";
                bankBestRates.Clear();
                foreach (var i in db.Banks)
                {
                    if (i.BankInfos.Count() != 0 && i.rurSell == min)
                    {
                        bankBestRates.Add(i);
                    }
                }
                ShowBankMarkers(bankBestRates);
            }
        }

        private BankInfo MinWay(List<Bank> banks, PointLatLng startpoint)
        {
            double min=0;
            List<BankInfo> endpoint = new List<BankInfo>();
            foreach (var i in banks)
            {
                min = i.BankInfos.Min(k => (DistanceBetweenPoints(startpoint, 
                    new PointLatLng() { Lat = k.latitude, Lng = k.longitude })));
            }
            foreach(var i in banks)
            {
                 var bank = (from j in i.BankInfos where DistanceBetweenPoints(startpoint,
                    new PointLatLng() { Lat = j.latitude, Lng = j.longitude }) == min select j);
                endpoint = bank.ToList<BankInfo>();
            }
                return endpoint[0];
        }

        private double DistanceBetweenPoints(PointLatLng start, PointLatLng end)
        {
            List<PointLatLng> routes = new List<PointLatLng>() { start, end };
            GMapRoute r = new GMapRoute(routes, "My route");
            return r.Distance;
        }

        private void btnRouteBank_Click(object sender, EventArgs e)
        {
            if (tbStartLat == null || tbStartLong == null)
            {
                MessageBox.Show("не задано текущее местоположение");
                return;
            }
            PointLatLng start = new PointLatLng(Convert.ToDouble(tbStartLat.Text), Convert.ToDouble(tbStartLong.Text));
            BankInfo bank = MinWay(bankBestRates, start);
            PointLatLng end = new PointLatLng() { Lat=bank.latitude, Lng=bank.longitude };
            MapRoute route = new MapRoute("My route");
            route.Points.Add(start);
            route.Points.Add(end);
            GMapRoute r = new GMapRoute(route.Points, "My route");
            GMapOverlay routesOverlay = new GMapOverlay("routes");
            routesOverlay.Routes.Add(r);
            gMapControl2.Overlays.Add(routesOverlay);
            tbBestBank.Text = bank.Address + "\n " + "через " + String.Format("{0:0.00}",r.Distance * 1000) + " м";

        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Разработчик: Юрий Жураковский \nВерсия 1.0.0 \nоктябрь 2018г.");
        }
    }
}
