using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.Xpo;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Actions;
using DevExpress.Persistent.Base;
using DevExpress.ExpressApp.Editors;
using ComplexDialogSample.Module.BusinessObjects;

namespace ComplexDialogSample.Module.Controllers {

    [NonPersistent]
    public class OrderTemplate {
        public OrderTemplate(Session s) {
            _Services = new XPCollection<Service>(s);
        }
        public DateTime DueDate { get; set; }
        public Team Team { get; set; }
        private XPCollection<Service> _Services;
        public XPCollection<Service> Services { get { return _Services; } }
    }

    public class MyController : ViewController {
        public MyController() {
            TargetObjectType = typeof(Office);
            TargetViewType = ViewType.ListView;
            PopupWindowShowAction action = new PopupWindowShowAction(this, "AssignJobs", PredefinedCategory.RecordEdit);
            action.SelectionDependencyType = SelectionDependencyType.RequireMultipleObjects;
            action.CustomizePopupWindowParams += new CustomizePopupWindowParamsEventHandler(action_CustomizePopupWindowParams);
            action.Execute += new PopupWindowShowActionExecuteEventHandler(action_Execute);
        }
        void action_CustomizePopupWindowParams(object sender, CustomizePopupWindowParamsEventArgs e) {
            IObjectSpace os = Application.CreateObjectSpace();
            e.Context = TemplateContext.PopupWindow;
            e.View = Application.CreateDetailView(os, new OrderTemplate(((DevExpress.ExpressApp.Xpo.XPObjectSpace)os).Session));
            ((DetailView)e.View).ViewEditMode = ViewEditMode.Edit;
        }
        void action_Execute(object sender, PopupWindowShowActionExecuteEventArgs e) {
            OrderTemplate parameters = e.PopupWindow.View.CurrentObject as OrderTemplate;
            ListPropertyEditor listPropertyEditor = ((DetailView)e.PopupWindow.View).FindItem("Services") as ListPropertyEditor;
            IObjectSpace os = Application.CreateObjectSpace();
            foreach (Office b in e.SelectedObjects) {
                Team team = os.GetObject<Team>(parameters.Team);
                foreach (Service service in listPropertyEditor.ListView.SelectedObjects) {
                    Order order = os.CreateObject<Order>();
                    order.DueDate = parameters.DueDate;
                    order.Team = team;
                    order.Office = os.GetObject<Office>(b);
                    order.Service = os.GetObject<Service>(service);
                    order.Save();
                }
            }
            os.CommitChanges();
        }
    }
}
