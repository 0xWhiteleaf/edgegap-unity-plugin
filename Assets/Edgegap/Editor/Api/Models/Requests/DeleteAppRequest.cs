using Newtonsoft.Json;

namespace Edgegap.Editor.Api.Models.Requests
{
    /// <summary>
    /// Request model for https://docs.edgegap.com/api/#tag/Applications/operation/application-delete
    /// </summary>
    public class DeleteAppRequest
    {
        #region Required
        /// <summary>*The application name.</summary>
        [JsonProperty("app_name")]
        public string AppName { get; set; }
        #endregion // Required

        /// <summary>Used by Newtonsoft</summary>
        public DeleteAppRequest()
        {
        }

        /// <summary>Init with required info</summary>
        /// <param name="appName">The application name</param>
        public DeleteAppRequest(
            string appName)
        {
            this.AppName = appName;
        }

        /// <summary>Parse to json str</summary>
        public override string ToString() =>
            JsonConvert.SerializeObject(this);
    }
}
