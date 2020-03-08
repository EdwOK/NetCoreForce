using Newtonsoft.Json;
using NetCoreForce.Client.Serializer;

namespace NetCoreForce.Client
{
    public static class JsonSerializer
    {
        /// <summary>
        /// Serializes an object into JSON including all non-null properties.
        /// <para>Not to be used for create and update calls</para>
        /// </summary>
        /// <param name="inputObject">Object to serialize</param>
        /// <param name="indented">use indented formatting, usually for readability</param>
        /// <returns>JSON string</returns>
        public static string SerializeComplete(object inputObject, bool indented)
        {
            var formatting = Formatting.None;
            if (indented)
            {
                formatting = Formatting.Indented;
            }

            var serializedJson = JsonConvert.SerializeObject(inputObject,
                   formatting,
                   new JsonSerializerSettings
                   {
                       NullValueHandling = NullValueHandling.Ignore,
                       DateFormatString = DateFormats.FullDateFormatString
                   });

            return serializedJson;
        }

        /// <summary>
        /// Serializes an object into JSON for SObject updates, using the UpdateableContractResolver
        /// </summary>
        /// <param name="inputObject">Object to serialize</param>
        /// <returns>JSON string, unformatted</returns>
        public static string SerializeForUpdate(object inputObject)
        {
            var serializedJson = JsonConvert.SerializeObject(inputObject,
                   Formatting.None,
                   new JsonSerializerSettings
                   {
                       NullValueHandling = NullValueHandling.Ignore,
                       ContractResolver = new UpdateableContractResolver(),
                       DateFormatString = DateFormats.FullDateFormatString
                   });

            return serializedJson;
        }

        /// <summary>
        /// Serializes an object into JSON for SObject creation, using the CreatableContractResolver
        /// </summary>
        /// <param name="inputObject">Object to serialize</param>
        /// <returns>JSON string, unformatted</returns>
        public static string SerializeForCreate(object inputObject)
        {
            var serializedJson = JsonConvert.SerializeObject(inputObject,
                   Formatting.None,
                   new JsonSerializerSettings
                   {
                       NullValueHandling = NullValueHandling.Ignore,
                       ContractResolver = new CreatableContractResolver(),
                       DateFormatString = DateFormats.FullDateFormatString
                   });

            return serializedJson;
        }
    }
}