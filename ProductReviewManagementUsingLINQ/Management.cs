using System;
using System.Collections.Generic;
using System.Data;
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
        public void CountOfReviewBasedOnProductId(List<ProductReviewModel> productReviewList)
        { 
            var result = productReviewList.GroupBy(p => p.ProductId).Select(p => new { ProductId = p.Key, Count = p.Count() });
            foreach(var product in result)
            {
                Console.WriteLine("ProductID" + " " + product.ProductId + " " + "Count" + " "+ product.Count);
            }
        }
        public void SkipTop5Records(List<ProductReviewModel> productReviewList)
        {
            var result = productReviewList.OrderByDescending(p => p.Rating).Skip(5);
            DisplayProductReviewList(result.ToList());
            Console.WriteLine("--------------------------------------");
            var result1 = productReviewList.OrderByDescending(p => p.Review).Skip(5);
            DisplayProductReviewList(result1.ToList());
        }
        public void RetrieveRecordsForProductIdAndReview(List<ProductReviewModel> productReviewList)
        {   
            var input = productReviewList.Select(p => new { ProductId = p.ProductId, Review = p.Review });
            foreach (var product in input)
            {
                Console.WriteLine(product.ProductId + " " + product.Review);
            }
        }
        public void AvgOfEachProductIdBasedOnRating(List<ProductReviewModel> productReviewList)
        {
            var result = productReviewList.GroupBy(p => p.ProductId).Select(p => new { ProductId = p.Key, AverageRating = p.Average(x => x.Rating) }); ;
            foreach (var product in result)
            {
                Console.WriteLine(product.ProductId + " " + product.AverageRating);
            }
        }
        public void RetriveRecordsBasedOnSpecificReview(List<ProductReviewModel> productReviewList)
        {
            var result = productReviewList.Where(x => x.Review == "Best");
            foreach (var product in result)
            {
                Console.WriteLine("ProductId: {0} UserId:{1} Review: {2} Rating: {3} IsLike: {4}",product.ProductId, product.UserId,product.Review,product.Rating,product.IsLike);
            }
        }
        public DataTable CreatingDataTable(List<ProductReviewModel> productReviewModels)
        {
            DataTable dataTable = new DataTable();

            dataTable.Columns.Add("ProductId", typeof(int));
            dataTable.Columns.Add("UserId", typeof(int));
            dataTable.Columns.Add("Rating", typeof(int));
            dataTable.Columns.Add("Review", typeof(string));
            dataTable.Columns.Add("IsLike", typeof(string));

            foreach (var data in productReviewModels)
            {
                dataTable.Rows.Add(data.ProductId, data.UserId, data.Rating, data.Review, data.IsLike);
            }
            Console.WriteLine("Data successfully added in datatable.");
            return dataTable;
        }
        public void PrintDataTable(DataTable dataTable)
        {
            Console.Write("ProductId" + " " + "UserId" +" "+ "Review" +" "+ "Rating" +" "+ "IsLike");
            foreach (DataRow dataRow in dataTable.Rows)
            {
                Console.WriteLine("");
                for (int i = 0; i < dataRow.ItemArray.Length; i++)
                {
                    Console.Write(dataRow.ItemArray[i] + "     ");
                }
            }
        }
        public void RetrieveRecordsFromDatatableForIsLike(DataTable dataTable)
        {
            DataRow[] dataRows = dataTable.Select("IsLike = true");
            foreach(DataRow row in dataRows)
            {
                Console.WriteLine("");
                for (int i = 0; i < row.ItemArray.Length; i++)
                {
                    Console.Write(row.ItemArray[i] + "     ");
                }
            }
        }
        public void RetrieveRecordsSpecificUserIdBasedOnRating(List<ProductReviewModel> productReviewList)
        {
            var result = productReviewList.OrderByDescending(x => x.Rating).Where(x => x.UserId == 10);
            foreach(var product in result)
            {
                Console.WriteLine("UserId:{0}  ProductId: {1}  Review: {2}  Rating: {3}  IsLike: {4}", product.UserId, product.ProductId, product.Review, product.Rating, product.IsLike);
            }
        }
    }
}
