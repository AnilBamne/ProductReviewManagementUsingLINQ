using System;
using System.Collections.Generic;

namespace ProductReviewManagement
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Product review management");

            ProductReview productReview=new ProductReview();
            List<ProductReview> list = new List<ProductReview>()
            {
            new ProductReview() { ProductID = 1, UserID = 1, Rating = 5.5, Review = "Good", IsLike=true},
            new ProductReview() { ProductID = 1, UserID = 1, Rating = 4.5, Review = "Good", IsLike=true },
            new ProductReview() { ProductID = 2, UserID = 1, Rating = 6, Review = "Good", IsLike=true },
            new ProductReview() { ProductID = 2, UserID = 1, Rating = 5, Review = "Good", IsLike=true },
            new ProductReview() { ProductID = 4, UserID = 1, Rating = 5, Review = "Nice", IsLike=true },
            new ProductReview() { ProductID = 5, UserID = 1, Rating = 5, Review = "Nice", IsLike=true },
            new ProductReview() { ProductID = 6, UserID = 1, Rating = 5, Review = "Good", IsLike=true },
            new ProductReview() { ProductID = 7, UserID = 1, Rating = 7.5, Review = "Good", IsLike=false},
            new ProductReview() { ProductID = 4, UserID = 1, Rating = 1.5, Review = "Good", IsLike=false },
            new ProductReview() { ProductID = 9, UserID = 1, Rating = 6.5, Review = "Bad", IsLike=false },
            new ProductReview() { ProductID = 10, UserID = 1, Rating = 5, Review = "Bad", IsLike=false },
            new ProductReview() { ProductID = 11, UserID = 1, Rating = 5, Review = "Good", IsLike=true },
            new ProductReview() { ProductID = 12, UserID = 1, Rating = 5, Review = "Good", IsLike=true },
            new ProductReview() { ProductID = 13, UserID = 1, Rating = 5, Review = "Bad", IsLike=true },
            new ProductReview() { ProductID = 14, UserID = 1, Rating = 5, Review = "Good", IsLike=true },
            new ProductReview() { ProductID = 15, UserID = 1, Rating = 5, Review = "Good", IsLike=true }
            };
            Console.WriteLine("Rows in the table = ");
            foreach (var lists in list)
            {
                Console.WriteLine("Product id = " + lists.ProductID + "User id = " + lists.UserID + "Rating is = " + lists.Rating + " Review is = " + lists.Review + " isLike = " + lists.IsLike);
            }
        }
    }
}
