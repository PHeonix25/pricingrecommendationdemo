namespace ConsoleApplication
{
    public class PricingRecommendation
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int ProductTypeId { get; set; }
        public int ProductGroupId { get; set; }
        public int BrandId { get; set; }
        public decimal RecommendedPrice { get; set; }
        public int ActionStatus { get; set; }
    }
}