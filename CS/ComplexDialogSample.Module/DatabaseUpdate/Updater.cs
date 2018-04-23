using System;
using System.Linq;
using DevExpress.Xpo;
using DevExpress.ExpressApp;
using DevExpress.Data.Filtering;
using DevExpress.ExpressApp.Xpo;
using DevExpress.Persistent.Base;
using DevExpress.ExpressApp.Updating;
using DevExpress.Persistent.BaseImpl;
using DevExpress.ExpressApp.Security;
using ComplexDialogSample.Module.BusinessObjects;
//using DevExpress.ExpressApp.Reports;
//using DevExpress.ExpressApp.PivotChart;
//using DevExpress.ExpressApp.Security.Strategy;
//using ComplexDialogSample.Module.BusinessObjects;

namespace ComplexDialogSample.Module.DatabaseUpdate {
    // For more typical usage scenarios, be sure to check out http://documentation.devexpress.com/#Xaf/clsDevExpressExpressAppUpdatingModuleUpdatertopic
    public class Updater : ModuleUpdater {
        public Updater(IObjectSpace objectSpace, Version currentDBVersion) :
            base(objectSpace, currentDBVersion) {
        }
        public override void UpdateDatabaseAfterUpdateSchema() {
            base.UpdateDatabaseAfterUpdateSchema();

            if (ObjectSpace.FindObject<Team>(null) == null) {
                var team = ObjectSpace.CreateObject<Team>();
                team.Name = "Violet";
                team = ObjectSpace.CreateObject<Team>();
                team.Name = "Green";
                team = ObjectSpace.CreateObject<Team>();
                team.Name = "Orange";
            }
            Random rnd = new Random();
            int n = 1;
            if (ObjectSpace.FindObject<Office>(null) == null) {
                for (int floor = 1; floor < 5; floor++) {
                    for (int i = 0; i < 40; i++) {
                        var office = ObjectSpace.CreateObject<Office>();
                        office.Index = string.Format("{0:d3}", floor * 100 + i);
                        office.OccupiedBy = rnd.Next(20) == 0 ? null : string.Format("somebody{0:d3}", n++);
                    }
                }
            }
            if (ObjectSpace.FindObject<Service>(null) == null) {
                var s = ObjectSpace.CreateObject<Service>();
                s.Description = "Clean";
                s = ObjectSpace.CreateObject<Service>();
                s.Description = "Refill";
                s = ObjectSpace.CreateObject<Service>();
                s.Description = "Secure";
                s = ObjectSpace.CreateObject<Service>();
                s.Description = "Inspect";
            }
        }
        public override void UpdateDatabaseBeforeUpdateSchema() {
            base.UpdateDatabaseBeforeUpdateSchema();
            //if(CurrentDBVersion < new Version("1.1.0.0") && CurrentDBVersion > new Version("0.0.0.0")) {
            //    RenameColumn("DomainObject1Table", "OldColumnName", "NewColumnName");
            //}
        }
    }
}
