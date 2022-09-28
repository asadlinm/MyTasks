namespace MyTasks.Models
{
    public class MainCategoryResultModel
    {
        public int Id { get; set; }
        public int categoryCode { get; set; }
        public string categoryName { get; set; }
        public List<ProductCategoryResultModel> productCategories { get; set; } = new List<ProductCategoryResultModel>();
        public MainCategoryResultModel(ProductMainCategory mainCategory)
        {
            Id = mainCategory.Id;
            categoryCode = mainCategory.mainCategoryCode;
            categoryName = mainCategory.mainCategoryName;
            productCategories = new List<ProductCategoryResultModel>();
            foreach (var prodCategory in mainCategory.productCategories)
            {
                productCategories.Add(new ProductCategoryResultModel(prodCategory));
            }
        }
    }
}
