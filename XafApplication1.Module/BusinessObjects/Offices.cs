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
    public class Offices : BaseObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        public Offices(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
            // Place your initialization code here (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112834.aspx).
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
    }
}