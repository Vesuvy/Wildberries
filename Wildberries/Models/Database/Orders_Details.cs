using System;

namespace Wildberries.Models.Database
{
    internal class Orders_Details
    {
        public int Id { get; set; }
        public Products FK_Product { get; set; }
        public Orders FK_Order { get; set; }
    }
}
