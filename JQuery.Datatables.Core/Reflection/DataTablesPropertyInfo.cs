﻿using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace JQuery.Datatables.Core.Reflection
{
    public class DataTablesPropertyInfo
    {
        public DataTablesPropertyInfo(PropertyInfo propertyInfo, DataTablesAttributeBase[] attributeses)
        {
            PropertyInfo = propertyInfo;
            Attributes = attributeses;
        }

        public System.Reflection.PropertyInfo PropertyInfo { get; private set; }
        public DataTablesAttributeBase[] Attributes { get; private set; }
        public Type Type
        {
            get { return this.PropertyInfo.PropertyType; }
        }
    }
}
