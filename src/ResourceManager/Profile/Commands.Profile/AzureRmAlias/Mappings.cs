// ----------------------------------------------------------------------------------
//
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the 'License');
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an 'AS IS' BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace Microsoft.Azure.Commands.Profile.AzureRmAlias
{
    public class Mappings
    {
        public static Dictionary<string, object> GetCaseInsensitiveMapping()
        {
            string jsonmapping = GetJsonMapping();
            Dictionary<string, object> caseSensitiveMapping = (Dictionary<string, object>)JsonConvert.DeserializeObject(jsonmapping, typeof(Dictionary<string, object>));
            var mapping = new Dictionary<string, object>(StringComparer.CurrentCultureIgnoreCase);
            foreach (var key in caseSensitiveMapping.Keys)
            {
                mapping.Add(key, caseSensitiveMapping[key]);
            }

            return mapping;
        }

        public static string GetJsonMapping()
        {
            using (StreamReader r = new StreamReader("./Mappings.json"))
            {
                return r.ReadToEnd();
            }
        }
    }
}
