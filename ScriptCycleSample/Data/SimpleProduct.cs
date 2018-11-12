using System.ComponentModel.DataAnnotations;

namespace ScriptCycleSample.Data {

    public class SimpleProduct {

        [Key]
        public int Id { get; set; }

        [StringLength(50)]
        public string StockNumber { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(250)]
        public string Description { get; set; }
    }
}