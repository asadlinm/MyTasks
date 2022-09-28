namespace MyTasks.Models
{
    public class SubCategoryResultModel
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public int subCategoryCode { get; set; }
        public string subCategoryName { get; set; }
        public SubCategoryResultModel(ProductSubCategory subCategory)
        {
            Id = subCategory.Id;
            CategoryId = subCategory.CategoryId;
            subCategoryCode = subCategory.subCategoryCode;
            subCategoryName = subCategory.subCategoryName;

        }
    }
}
