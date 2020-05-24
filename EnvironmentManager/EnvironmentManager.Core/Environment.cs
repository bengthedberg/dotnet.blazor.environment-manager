using System.ComponentModel.DataAnnotations;

namespace EnvironmentManager.Core
{
    public class Environment
    {
        [Key]
        public int EnvironmentId;

        [Required]
        [StringLength(50, ErrorMessage = "Environment name is too long.")]
        public string Name;

        public string Description;

        public Group Owner;


    }
}
