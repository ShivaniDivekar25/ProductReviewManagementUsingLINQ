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
                new ProductReviewModel() {ProductId=8, UserId=17, Rating=6, Review="Good", IsLike=true},
                new ProductReviewModel() {ProductId=9, UserId=18, Rating=7, Review="Good", IsLike=true},
                new ProductReviewModel() {ProductId=10, UserId=19, Rating=3, Review="Average", IsLike=true},
                new ProductReviewModel() {ProductId=11, UserId=20, Rating=5, Review="Average", IsLike=true},
                new ProductReviewModel() {ProductId=12, UserId=21, Rating=6, Review="Good", IsLike=true},
                new ProductReviewModel() {ProductId=13, UserId=22, Rating=4, Review="Average", IsLike=true},
                new ProductReviewModel() {ProductId=14, UserId=12, Rating=2, Review="Bad", IsLike=true},
                new ProductReviewModel() {ProductId=15, UserId=14, Rating=7, Review="Good", IsLike=true},
                new ProductReviewModel() {ProductId=16, UserId=10, Rating=8, Review="Good", IsLike=true},
                new ProductReviewModel() {ProductId=17, UserId=11, Rating=9, Review="Best", IsLike=true},
                new ProductReviewModel() {ProductId=18, UserId=12, Rating=9, Review="Best", IsLike=true},
                new ProductReviewModel() {ProductId=19, UserId=13, Rating=6, Review="Good", IsLike=true},
                new ProductReviewModel() {ProductId=20, UserId=14, Rating=7, Review="Good", IsLike=true},
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
                Console.WriteLine("1:Add product review\n2:Display product review list\n3:Exit");
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