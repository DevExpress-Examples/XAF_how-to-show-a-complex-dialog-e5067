using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Xpo;
using System;
using System.ComponentModel;

namespace ComplexDialogSample.Module.BusinessObjects {
    [NavigationItem("Resources")]
    public class Team : BaseObject {
        public Team(Session session) : base(session) { }
        public string Name { get { return GetPropertyValue<string>("Name"); } set { SetPropertyValue<string>("Name", value); } }
    }
    [NavigationItem("Process")]
    [DefaultProperty("Index")]
    public class Office : BaseObject {
        public Office(Session session) : base(session) { }
        public string Index { get { return GetPropertyValue<string>("Index"); } set { SetPropertyValue<string>("Index", value); } }
        public string OccupiedBy { get { return GetPropertyValue<string>("OccupiedBy"); } set { SetPropertyValue<string>("OccupiedBy", value); } }
    }
    [NavigationItem("Process")]
    public class Order : BaseObject {
        public Order(Session session) : base(session) { }
        public Team Team { get { return GetPropertyValue<Team>("Team"); } set { SetPropertyValue<Team>("Team", value); } }
        public Office Office { get { return GetPropertyValue<Office>("Office"); } set { SetPropertyValue<Office>("Office", value); } }
        public Service Service { get { return GetPropertyValue<Service>("Service"); } set { SetPropertyValue<Service>("Service", value); } }
        public DateTime DueDate { get { return GetPropertyValue<DateTime>("DueDate"); } set { SetPropertyValue<DateTime>("DueDate", value); } }
    }
    [NavigationItem("Resources")]
    [DefaultProperty("Description")]
    public class Service : BaseObject {
        public Service(Session session) : base(session) { }
        public string Description { get { return GetPropertyValue<string>("Description"); } set { SetPropertyValue<string>("Description", value); } }
    }
}
