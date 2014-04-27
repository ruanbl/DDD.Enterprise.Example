﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Extenstions
{
    public static class ForEachExtensions
    {
        public static void ForEachWithLast<T>(this IList<T> list, Action<T, bool> action)
        {
            var i = 0;
            var count = list.Count;
            foreach (var x in list)
            {
                if (++i == count)
                    action(x, true);
                else
                    action(x, false);
            }
        }
    }
}