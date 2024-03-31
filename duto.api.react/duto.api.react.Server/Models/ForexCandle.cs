using Microsoft.Extensions.Hosting;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Metadata;

namespace duto.api.react.Server.Models
{
    public class ForexCandle
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ForexCandleID { get; set; }


        //The trading volume of the symbol in the given time period.
        public string v { get; set; }
        //The volume weighted average price.
        public string vw { get; set; }
        //The open price for the symbol in the given time period.
        public string o { get; set; }
        //The close price for the symbol in the given time period.
        public string c { get; set; }
        //The highest price for the symbol in the given time period.
        public string h { get; set; }
        //The lowest price for the symbol in the given time period.
        public string l { get; set; }
        //The Unix Msec timestamp for the start of the aggregate window.
        public string t { get; set; }
        //The number of transactions in the aggregate window.
        public string n { get; set; }
    }
}
