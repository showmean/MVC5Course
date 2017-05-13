using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace MVC5Course.Models.ValidationAttribute
{
    //[AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    public class 商品名稱必須包含will字串 : DataTypeAttribute
    {
        //private static Regex _regex = new Regex("PATTERN", RegexOptions.IgnoreCase);
        public 商品名稱必須包含will字串() : base(DataType.Text)
        {
        }
        public override bool IsValid(object value)
        {
            var str = (string)value;
            return str.Contains("Will");
            //if (value == null) return true;
            ////return base.IsValid(value);
            //string valueAsString = value as string;
            //return valueAsString 1 = null && _regex.Match(valueAsString).Length > 0;
        }

    }

    
    
}