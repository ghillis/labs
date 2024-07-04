using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFPostgres
{
    [Table("MetaAccountType")]
    public partial class MetaAccountType
    {
        [Key]
        public string AccountType { get; set; }
        public string DisplayName { get; set; }
        public string Description { get; set; }
        public int DisplayOrder { get; set; }
        public bool FlagIsActive { get; set; }
    }
}