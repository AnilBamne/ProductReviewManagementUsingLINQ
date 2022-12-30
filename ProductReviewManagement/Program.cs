﻿using System;
using System.Collections.Generic;

namespace ProductReviewManagement
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Product review management");
            
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
            try
            {
                ProductReview productReview = new ProductReview();
                while (true)
                {
                    Console.WriteLine("\nChoose option\n1: Display all records\n2: Top 3 records by rating\n3: display records whose rating > 3\n0: Exit \n");
                    int option = int.Parse(Console.ReadLine());
                    switch (option)
                    {
                        case 1:
                            Console.WriteLine("Displaying all records");
                            DisplayProducts(list);
                            break;
                        case 2:
                            // uc1 display top 3 records by rating
                            Console.WriteLine("\nTop 3 records are :");
                            ProductReviewManagement.RetriveTopThreeRecords(list);
                            break;
                        case 3:
                            break;
                        case 4:
                            break;
                        case 5:
                            break;
                        case 6:
                            break;
                        case 7:
                            break;
                        case 8:
                            break;
                        case 0:
                            Environment.Exit(0);
                            break;
                    }
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        /// <summary>
        /// Displaying all products
        /// </summary>
        /// <param name="list"></param>
        public static void DisplayProducts(List<ProductReview> list)
        {
            try
            {
                foreach (var lists in list)
                {
                    Console.WriteLine("Product id = " + lists.ProductID + "User id = " + lists.UserID + "Rating is = " + lists.Rating + " Review is = " + lists.Review + " isLike = " + lists.IsLike);
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
        }
    }
}
