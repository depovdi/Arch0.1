using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;

namespace Rf.Web.Extensions
{
    public static class AutoMapperExtensions
    {
        public static TModel ToModel<TModel>(this object source)
        {
            return Mapper.Map<TModel>(source);
        }

        public static TModel ToModel<TModel>(this object source, TModel destination)
        {
            return Mapper.Map<object, TModel>(source, destination);
        }

        public static IEnumerable<TModel> ToModel<TModel>(this IEnumerable<object> source)
        {
            return Mapper.Map<IEnumerable<TModel>>(source);
        }
    }
}