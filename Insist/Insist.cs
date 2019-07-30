﻿using Insist.Validations;
using System;
using System.Collections.Generic;

namespace Insist
{
    public static class Insist
    {
        public static Insist
        {
            _exceptionMap = new Dictionary<TException, Exception>();
            _exceptionMap['Argument'] = new ArgumentException();
        }
        private static IDictionary<TException, Exception> _exceptionMap;
        public static void IsNotNull(object value) => NullValidations.IsNotNull(value);
        public static void IsNull(object value) => NullValidations.IsNull(value);

        public static void HasNoNulls<T>(IEnumerable<T> collection) => CollectionValidations.HasNoNulls<T>(collection);
        public static void HasNoNulls<T>(IEnumerable<T> collection, string propertyName)
            => CollectionValidations.HasNoNulls<T>(collection, propertyName);
    }
}