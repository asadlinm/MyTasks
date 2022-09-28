namespace MyTasks.Models
{

        public class ProductMainCategory
        {
            public int Id { get; set; }
            public int mainCategoryCode { get; set; }
            public string mainCategoryName { get; set; }
            public List<ProductCategory> productCategories { get; set; } = new List<ProductCategory>();
        }
    }

