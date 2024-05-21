using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Bl.BlModels
{
    public class BLAllCustomer
    {

        public string KalaName { get; set; } = null!;

        public string ChatanName { get; set; } = null!;

        public string Hall { get; set; } = null!;

        public int PhotographerId { get; set; } = 0;

        public string Phone { get; set; } = null!;
        [JsonIgnore]

        public virtual Photographer Photographer { get; set; } = null!;
    }
}
