﻿using System;
using System.Linq;
using System.Reflection;

namespace Cooperchip.ITDeveloper.Mvc.Extensions.ExtensionsMethods
{
    public static class GenericEnumExtensionDescription
    {
        public static string getDescription(this Enum _enum)
        {
            Type generEnumType = _enum.GetType();
            MemberInfo[] memberInfo = generEnumType.GetMember(name: _enum.ToString());
            if ((memberInfo.Length <= 0)) return _enum.ToString();

            var attribs = memberInfo[0].GetCustomAttributes(typeof(System.ComponentModel
                .DescriptionAttribute), false);

            return attribs.Any() ? ((System.ComponentModel.DescriptionAttribute) attribs
                    .ElementAt(0)).Description : _enum.ToString();

        }
    }
}
