//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace lithium.core.lib.net45.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Model
    {
        public Model()
        {
            this.Devices = new HashSet<Device>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public string Line { get; set; }
        public string Trim { get; set; }
        public int DeviceTypeId { get; set; }
        public int MfgrId { get; set; }
    
        public virtual DeviceType DeviceType { get; set; }
        public virtual Mfgr Mfgr { get; set; }
        public virtual ICollection<Device> Devices { get; set; }
    }
}