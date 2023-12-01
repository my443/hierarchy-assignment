using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HierarchyAssignmentWebApp.Models
{
    public class Entity
    {
        public int Id { get; set; }
        public string? EntityName { get; set; }
        public string? EntityCode { get; set; }


        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DataType(DataType.DateTime)]
        public DateTime DateAdded { get; set; }

        
        //[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [DataType(DataType.DateTime)]
        public DateTime Modified { get; set; }

    }
}
