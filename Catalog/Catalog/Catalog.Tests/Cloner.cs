using System;
using System.Collections.Generic;
using System.Text;

namespace Catalog.Tests
{
    public static class Cloner
    {
        public static T Clone<T>(T originalObject) {
            var serialized = Newtonsoft.Json.JsonConvert.SerializeObject(originalObject);

            T newObject = Newtonsoft.Json.JsonConvert.DeserializeObject<T>(serialized);

            return newObject;
        }
    }
}
