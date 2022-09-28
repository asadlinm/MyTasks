namespace MyTasks.Models
{
    public class ProductCategory
    {
        public int Id { get; set; }
        public int categoryCode { get; set; }
        public string categoryName { get; set; }
        public int MainCategoryId { get; set; }
        public virtual ProductMainCategory MainCategory { get; set; }
        public List<ProductSubCategory> productSubCategories { get; set; } = new List<ProductSubCategory>();
    }
}
