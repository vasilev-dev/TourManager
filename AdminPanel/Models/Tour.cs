//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AdminPanel.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tour
    {
        public int TourId { get; set; }
        public decimal Price { get; set; }
        public System.DateTime StartDate { get; set; }
        public System.DateTime EndDate { get; set; }
        public int FromCityId { get; set; }
        public int ToCityId { get; set; }
        public byte[] Image { get; set; }
    
        public virtual City City { get; set; }
        public virtual City City1 { get; set; }
    }
}
