using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spice.Extensions
{
    public static class IEnumerableExtension
    {
        public static IEnumerable<SelectListItem> ToSelectListItem<T>(this IEnumerable<T> items, int selectedValue)
        {
            return items.Select(item => new SelectListItem
            {
                Text = item.GetPropertyValue("Name"),
                Value = item.GetPropertyValue("Id"),
                Selected = item.GetPropertyValue("Id").Equals(selectedValue.ToString())
            });
        }
    }
}
