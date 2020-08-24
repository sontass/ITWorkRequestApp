using System.ComponentModel.DataAnnotations.Schema;

namespace ITWorkRequest.API.Models
{
     public class StatusList
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int StatusCode { get; set; }
        public string StatusName { get; set; }
    }
}