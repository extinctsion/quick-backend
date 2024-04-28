using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.URLShortner
{
    /// <summary>
    /// Shortner db model
    /// </summary>
    public class Shortner
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        /// <summary>
        /// get or set Id
        /// </summary>
        public long Id { get; set; }
        /// <summary>
        /// get or set CreatedAt
        /// </summary>
        public DateTime? CreatedAt { get; set; }
        /// <summary>
        /// get or set LastUpdatedAt
        /// </summary>
        public DateTime? LastUpdatedAt { get; set; }
        /// <summary>
        /// get or set GeneratedKey
        /// </summary>
        public string? GeneratedKey { get; set; }
        /// <summary>
        /// get or set URL
        /// </summary>
        public string? URL {  get; set; }
    }
}
