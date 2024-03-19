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
    [ImageName("BO_Contact")]
    [DefaultProperty("Parking")]
    [DefaultListViewOptions(MasterDetailMode.ListViewOnly, false, NewItemRowPosition.None)]
    [Persistent("Parking")]
    public class Parking : BaseObject
    {
        public Parking(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }

        private int _parkingSpotNumber;
        public int ParkingSpotNumber
        {
            get { return _parkingSpotNumber; }
            set { SetPropertyValue(nameof(ParkingSpotNumber), ref _parkingSpotNumber, value); }
        }

        [Association("Office-Parking")]
        public Offices Renter { get; set; }

        private DateTime _occupiedDate;
        public DateTime OccupiedDate
        {
            get { return _occupiedDate; }
            set { SetPropertyValue(nameof(OccupiedDate), ref _occupiedDate, value); }
        }
        private DateTime _availableDate;
        public DateTime AvailableDate
        {
            get { return _availableDate; }
            set { SetPropertyValue(nameof(AvailableDate), ref _availableDate, value); }
        }
    }
}