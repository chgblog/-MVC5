using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CHG.Web.B_TongHua.Models
{
    public class e_TongHuaLeiBie
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TongHuaLeiBieID { get; set; }
        [Required]
        [StringLength(100)]
        [Display(Name = "童话标题")]
        public string TongHuaLeiBieMing { get; set; }

        public int PaiXu { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime TianJiaRiQi { get; set; }

        public int ZhuangTai { get; set; }
    }
}
