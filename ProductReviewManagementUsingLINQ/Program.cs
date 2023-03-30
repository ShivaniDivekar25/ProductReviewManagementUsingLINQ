namespace ProductReviewManagementUsingLINQ
{
    internal class Program
    {
        //LINQ - It is Language Integrated Query. It is use for grouping, sorting, and ordering data.
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Product Review Management System Using LINQ");
            List<ProductReviewModel> list = new List<ProductReviewModel>()
            {
                new ProductReviewModel() {ProductId=1, UserId=10, Rating=4, Review="Average", IsLike=true},
                new ProductReviewModel() {ProductId=2, UserId=11, Rating=3, Review="Bad", IsLike=true},
                new ProductReviewModel() {ProductId=3, UserId=12, Rating=2, Review="Bad", IsLike=true},
                new ProductReviewModel() {ProductId=4, UserId=13, Rating=5, Review="Average", IsLike=true},
                new ProductReviewModel() {ProductId=5, UserId=14, Rating=7, Review="Good", IsLike=true},
                new ProductReviewModel() {ProductId=6, UserId=15, Rating=1, Review="Bad", IsLike=true},
                new ProductReviewModel() {ProductId=7, UserId=16, Rating=3, Review="Bad", IsLike=true},
                new ProductReviewModel() {ProductId=5, UserId=17, Rating=6, Review="Good", IsLike=true},
                new ProductReviewModel() {ProductId=9, UserId=18, Rating=7, Review="Good", IsLike=true},
                new ProductReviewModel() {ProductId=10, UserId=19, Rating=3, Review="Average", IsLike=true},
                new ProductReviewModel() {ProductId=11, UserId=20, Rating=5, Review="Average", IsLike=true},
                new ProductReviewModel() {ProductId=10, UserId=21, Rating=6, Review="Good", IsLike=true},
                new ProductReviewModel() {ProductId=13, UserId=22, Rating=4, Review="Average", IsLike=true},
                new ProductReviewModel() {ProductId=14, UserId=12, Rating=2, Review="Bad", IsLike=true},
                new ProductReviewModel() {ProductId=15, UserId=14, Rating=7, Review="Good", IsLike=true},
                new ProductReviewModel() {ProductId=10, UserId=10, Rating=8, Review="Good", IsLike=true},
                new ProductReviewModel() {ProductId=17, UserId=11, Rating=9, Review="Best", IsLike=true},
                new ProductReviewModel() {ProductId=18, UserId=12, Rating=9, Review="Best", IsLike=true},
                new ProductReviewModel() {ProductId=19, UserId=13, Rating=6, Review="Good", IsLike=true},
                new ProductReviewModel() {ProductId=12, UserId=14, Rating=7, Review="Good", IsLike=true},
                new ProductReviewModel() {ProductId=21, UserId=15, Rating=1, Review="Bad", IsLike=true},
                new ProductReviewModel() {ProductId=22, UserId=16, Rating=3, Review="bad", IsLike=true},
                new ProductReviewModel() {ProductId=23, UserId=17, Rating=6, Review="Good", IsLike=true},
                new ProductReviewModel() {ProductId=24, UserId=18, Rating=7, Review="Good", IsLike=true},
                new ProductReviewModel() {ProductId=25, UserId=19, Rating=3, Review="Bad", IsLike=true},
            };
            Management management = new Management();
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Enter an option");
                Console.WriteLine("1:Add product review\n2:Display product review list\n3:Retrieve top 3 records\n4:Retrieve records based on product Id and rating\n5:Count of review based on productId\n6:Skip top 5 records\n7:Retrieve records for productId and review\n8:Average of each productId based on rating\n9:Retrive records based on specific review\n10:Create datatable\n11:Display datatable\n12:Exit");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        management.AddProductReview(list);
                        break;
                    case 2:
                        management.DisplayProductReviewList(list);
                        break;
                    case 3:
                        management.RritreiveTop3Records(list);
                        break;
                    case 4:
                        management.RetriveRecordsBasedOnProductIDAndRating(list);
                        break;
                    case 5:
                        management.CountOfReviewBasedOnProductId(list);
                        break;
                    case 6:
                        management.SkipTop5Records(list);
                        break;
                    case 7:
                        management.RetrieveRecordsForProductIdAndReview(list);
                        break;
                    case 8:
                        management.AvgOfEachProductIdBasedOnRating(list);
                        break;
                    case 9:
                        management.RetriveRecordsBasedOnSpecificReview(list);
                        break;
                    case 10:
                        management.CreatingDataTable(list);
                        break;
                    case 11:
                        var result = management.CreatingDataTable(list);
                        management.PrintDataTable(result);
                        break;
                    case 12:
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("Enter right option");
                        break;
                }
            }
        }
    }
}