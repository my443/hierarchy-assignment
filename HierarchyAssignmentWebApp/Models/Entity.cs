using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HierarchyAssignmentWebApp.Models
{
    public class Entity
    {
        public int Id { get; set; }
        public string? EntityName { get; set; }
        public string? EntityCode { get; set; }


        //[DataType(DataType.Date)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime DateAdded { get; set; }


//        [DataType(DataType.Date)]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime Modified { get; set; }

    }
}
