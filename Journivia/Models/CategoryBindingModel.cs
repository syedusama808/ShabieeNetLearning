using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Journivia.Models
{
    public class CategoryBindingModel
    {
        public int ID { get; set; }
        public string CategoryName { get; set; }
        public string CategoryDescription { get; set; }
        public int? CategoryId { get; set; }
        public bool Active { get; set; }
    }

    public class CreateCategoryModel
    {
        public string CategoryName { get; set; }
        public string CategoryDescription { get; set; }
        public string CategoryId { get; set; }
    }
}