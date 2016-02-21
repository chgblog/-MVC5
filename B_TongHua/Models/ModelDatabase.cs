namespace CHG.Web.B_TongHua.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ModelDatabase : DbContext
    {
        public ModelDatabase()
            : base("name=ShuJuKuLianJieChuan")
        {
        }

        public virtual DbSet<e_tonghuaxinxi> e_tonghuaxinxi { get; set; }

        public virtual DbSet<e_TongHuaLeiBie> e_TongHuaLeiBie { get; set; }
    }
}
