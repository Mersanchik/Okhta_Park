//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ConsoleApp1
{
    using System;
    using System.Collections.Generic;
    
    public partial class Order
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Order()
        {
            this.ServicesOrders = new HashSet<ServicesOrder>();
        }
    
        public int ID { get; set; }
        public string CodeOrder { get; set; }
        public System.DateTime DateСreation { get; set; }
        public System.TimeSpan TimeOrder { get; set; }
        public int id_CodeClient { get; set; }
        public string Status { get; set; }
        public Nullable<System.DateTime> DateClosing { get; set; }
        public string TimeRental { get; set; }
    
        public virtual Client Client { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ServicesOrder> ServicesOrders { get; set; }
    }
}
