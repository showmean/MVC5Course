using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC5Course.Models.ViewModels
{
    public class ProductListVM
    {
        [Required]
        public int ProductId { get; set; }

        [StringLength(80, ErrorMessage = "欄位長度不得大於 80 個字元")]
        [Required(ErrorMessage = "不可空白")]
        [DisplayName("商品名稱")]
        public string ProductName { get; set; }
        [DisplayFormat(DataFormatString = "{0:0}", ApplyFormatInEditMode = true)]
        [DisplayName("單價")]
        // [Display()]

        public Nullable<decimal> Price { get; set; }
        public Nullable<bool> Active { get; set; }
        public Nullable<decimal> Stock { get; set; }

        public ICollection<Product> ProductList { get; set; }
      //  public virtual ICollection<OrderLine> OrderLine { get; set; }

        //public Product ProductId { get; set; }
        //public Product ProductName { get; set; }
        //public Product Price { get; set; }
        //public Product Active { get; set; }
        //public Product Stock { get; set; }
    }
}