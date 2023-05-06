using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtusEducationHomework6
{
    public static class ClassGetMax<T> where T : class
    {
        public static T GetMax(IEnumerable e, Func<T, float> getParameter)
        {
            T? maxItem = null;
            foreach (var item in e) 
            {
                if (maxItem == null || getParameter(maxItem) < getParameter((T)item))
                    maxItem = (T)item;
            }
            return (T)maxItem;
        }
    }
}
