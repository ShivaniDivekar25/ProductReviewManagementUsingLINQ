using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductReviewManagementUsingLINQ
{
    public class Management
    {
        List<ProductReviewModel> productList = new List<ProductReviewModel>();
        public void AddProductReview(List<ProductReviewModel> productReviewList)
        {
            this.productList = productReviewList;
            Console.WriteLine("Review added successfully.");

        }
        public void DisplayProductReviewList(List<ProductReviewModel> productReviewListDisplay)
        {
            foreach (ProductReviewModel Product in productReviewListDisplay)
            {
                Console.WriteLine(Product.ProductId + " " + Product.UserId + " " + Product.Rating + " " + Product.Review + " " + Product.IsLike);
            }
        }
    }
}
