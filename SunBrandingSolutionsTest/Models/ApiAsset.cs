using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SunBrandingSolutionsTest.Models
{
    public class ApiAsset
    {
        public int AssetId { get; set; }
        public IList<Annotation> Annotations { get; set; }
        public string Asset { get; set; }
    }

    public class Annotation
    {
        public int AnnotionId { get; set; }
        public string Annotator { get; set; }
        public string Contents { get; set; }
    }
}
