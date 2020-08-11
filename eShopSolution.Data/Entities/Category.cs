using eShopSolution.Data.Enums;

namespace eShopSolution.Data.Entities
{
    public class Category
    {
        public int Id { set; get; }
        public int SortOder { set; get; }
        public bool IsShowOnHome { set; get; }
        public int ParentId { set; get; }
        public Status Status { set; get; }
    }
}
