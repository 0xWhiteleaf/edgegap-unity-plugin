using Newtonsoft.Json;

namespace Edgegap.Editor.Api.Models.Results
{
    /// <summary>
    /// Result model for `[DELETE] v1/app`.
    /// DELETE API Doc | https://docs.edgegap.com/api/#tag/Applications/operation/application-delete
    /// </summary>
    public class DeleteAppResult
    {
        [JsonProperty("message")]
        public string Message { get; set; }
    }
}
