using System.ComponentModel.DataAnnotations;

namespace GenerateQRCode_Demo.Models
{
    public class Product
    {
        //[Display(Name ="Enter QR Code Text")]
        //public string group_id { get; set; }
        //public string group_name { get; set; }
        [Display(Name = "Metars")]

        public float Unit { get; set; }
        //public string[] documents { get; set; }
        //public string item_type { get; set; }
        //public string product_type { get; set; }
        //public bool is_taxable { get; set; }
        //public string tax_id { get; set; }
        //public string description { get; set; }
        //public string inventory_account_id { get; set; }
        //public string purchase_account_id { get; set; }
        //public string attribute_name1 { get; set; }
        [Display(Name = "Product Name")]
        public string Name { get; set; }
        public string Color { get; set; }
        //public string rate { get; set; }
        //public string purchase_rate { get; set; }
        //public string reorder_level { get; set; }
        //public string initial_stock { get; set; }
        //public string initial_stock_rate { get; set; }
        //public string vendor_id { get; set; }
        //public string vendor_name { get; set; }
        public string SKU { get; set; }
        //public string upc { get; set; }
        //public string ean { get; set; }
        //public string isbn { get; set; }
        //public string part_number { get; set; }
        //public string attribute_option_name1 { get; set; }
        //public string purchase_description { get; set; }
        //public string item_tax_preferences { get; set; }


    }
}
