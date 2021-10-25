using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace WebApiProdutos.Shared.Extensions
{
    public static class EnumExtensions
    {
        public static string ToDescription<EnumType>(this EnumType EnumValue) where EnumType : struct
        {
            FieldInfo fi = EnumValue.GetType().GetField(EnumValue.ToString());
            DescriptionAttribute[] attributes = fi.GetCustomAttributes(typeof(DescriptionAttribute), false) as DescriptionAttribute[];

            if (attributes != null && attributes.Any())
                return attributes.First().Description;

            return EnumValue.ToString();
        }
    }
}
