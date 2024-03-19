using DevExpress.Data.Filtering;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.DC;
using DevExpress.ExpressApp.Model;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.Validation;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace XafApplication1.Module.BusinessObjects
{
    [DefaultClassOptions]
    [DefaultProperty(nameof(Renter))]
    [ImageName("BO_Contact")]
    public class Offices : BaseObject
    {
        public Offices(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
        [Association("Office-Parking")]
        public XPCollection<Parking> ParkingSpots 
        {
            get
            {
                return GetCollection<Parking>(nameof(ParkingSpots));
            } 
        }
        private string _renter;
        public string Renter
        {
            get { return _renter; }
            set { SetPropertyValue(nameof(Renter), ref _renter, value); }
        }
        private int _cabinet;
        public int Cabinet
        {
            get { return _cabinet; }
            set { SetPropertyValue(nameof(Cabinet), ref _cabinet, value); }
        }
        [VisibleInDetailView(false)]
        public string ParkingList
        {
            get
            {
                return string.Join(", ", ParkingSpots.Select(x => x.ParkingSpotNumber));
            }
        }
    }
}