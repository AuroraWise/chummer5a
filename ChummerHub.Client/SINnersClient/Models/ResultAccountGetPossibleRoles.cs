// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace SINners.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class ResultAccountGetPossibleRoles
    {
        /// <summary>
        /// Initializes a new instance of the ResultAccountGetPossibleRoles
        /// class.
        /// </summary>
        public ResultAccountGetPossibleRoles()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ResultAccountGetPossibleRoles
        /// class.
        /// </summary>
        public ResultAccountGetPossibleRoles(IList<string> allRoles = default(IList<string>), object myException = default(object), bool? callSuccess = default(bool?), string errorText = default(string))
        {
            AllRoles = allRoles;
            MyException = myException;
            CallSuccess = callSuccess;
            ErrorText = errorText;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "allRoles")]
        public IList<string> AllRoles { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "myException")]
        public object MyException { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "callSuccess")]
        public bool? CallSuccess { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "errorText")]
        public string ErrorText { get; set; }

    }
}
