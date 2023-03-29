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
        public void RritreiveTop3Records(List<ProductReviewModel> productReviewList)
        {
            var result = productReviewList.OrderByDescending(p => p.Rating).Take(3);
            DisplayProductReviewList(result.ToList());
        }
        public void RetriveRecordsBasedOnProductIDAndRating(List<ProductReviewModel> productReviewList)
        {
            var result = productReviewList.Where(p => p.Rating > 3 && (p.ProductId == 1 || p.ProductId == 3 || p.ProductId == 9));
            DisplayProductReviewList(result.ToList());
        }
    }
}
