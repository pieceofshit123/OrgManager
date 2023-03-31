using OrganisationManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace OrganisationManager.Helpers
{
    internal class EntityHelper
    {
        public static TbAdmin? Admin { get; set; }
        public static TbBuyer? Customer { get; set; }
        public static TbProductSold? SoldProduct { get; set; }
        public static TbAvailableProduct? AvailableProduct { get; set; }
        public static TbSupplierProduct? SupplierProduct { get; set; }
        public static TbOutlet? Outlet { get; set; }
        public static TbOrder? Order { get; set; }
        public static TbEmployee? Employee { get; set; }
        public static TbProductType? ProductType { get; set; }
        public static TbProvider? Provider { get; set; }
        public static TbStore? Store { get; set; }
        public static TbOutletAdvanced? OutletAdv { get; set; }
        public static TbSection? Section { get; set; }
        public static TbShopingRoom? ShopRoom { get; set; }

        public static List<TbSupplierProduct> SupProducts = new List<TbSupplierProduct>();
        public static List<TbProductSold> SoldProducts = new List<TbProductSold>();
        public static List<TbAvailableProduct> AvailableProducts = new List<TbAvailableProduct>();
    }
}
