namespace CHG.Web.B_TongHua.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("temp.e_tonghuaxinxi")]
    public partial class e_tonghuaxinxi
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TongHuaID { get; set; }

        [Required]
        [StringLength(200)]
        [Display(Name = "Í¯»°±êÌâ")]
        public string TongHuaBiaoTi { get; set; }

        [Required]
        [Column(TypeName = "text")]
        public string TongHuaNeiRong { get; set; }

        public int TongHuaLeiBieID { get; set; }

        public int PaiXu { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime TianJiaRiQi { get; set; }

        public int ZhuangTai { get; set; }
    }
}
