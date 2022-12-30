using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductReviewManagement
{
    public class ProductReviewManagement
    {
        /// <summary>
        /// Retriving Top ThreeRecords by passing object of list of product review
        /// </summary>
        /// <param name="list"></param>
        public static void RetriveTopThreeRecords(List<ProductReview> list)
        {
            var top3Records=list.OrderByDescending(P=>P.Rating).Take(3).ToList();       //using lambda expression
            Program.DisplayProducts(top3Records);
        }

    }
}
