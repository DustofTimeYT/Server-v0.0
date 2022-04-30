using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Server_v0._0.Models
{
    public class Computer
    {
        public int ComputerId { get; set; }
        [Required]
        [StringLength(30)]
        public string Title { get; set; }
        [Required]
        [StringLength(80)]
        public string CPU { get; set; }
        public string GraphicsCard { get; set; }
        public string RAM { get; set; }
        public string Motherboars { get; set; }
        public string PowerSupply { get; set; }
        public string HardDrive { get; set; }
        public string SSD_Disk { get; set; }
        public string Body { get; set; }
        public string Price { get; set; }
        public bool IsDeleted { get; set; } = false;
        public ICollection<ComputerOrder> ComputerOrders { get; set; }
    }
}
