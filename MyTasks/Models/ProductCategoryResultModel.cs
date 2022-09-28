namespace MyTasks.Models
{
    public class ProductCategoryResultModel
    {
        public int Id { get; set; }
        public int mainCategoryId { get; set; }
        public int categoryCode { get; set; }
        public string categoryName { get; set; }
        public List<SubCategoryResultModel> subCategories { get; set; }
        public ProductCategoryResultModel(ProductCategory productCategory)
        {
            Id = productCategory.Id;
            mainCategoryId = productCategory.MainCategoryId;
            categoryCode = productCategory.categoryCode;
            categoryName = productCategory.categoryName;
            subCategories = new List<SubCategoryResultModel>();
            foreach (var subCategory in productCategory.productSubCategories)
            {
                subCategories.Add(new SubCategoryResultModel(subCategory));
            }
        }
    }
}
