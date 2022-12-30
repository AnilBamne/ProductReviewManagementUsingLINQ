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
        public void RetriveTopThreeRecords(List<ProductReview> list)
        {
            var top3Records=list.OrderByDescending(P=>P.Rating).Take(3).ToList();       //using lambda expression
            Program.DisplayProducts(top3Records);
        }
        /// <summary>
        /// UC3 Retrive All Records With Rating Greater Than 3 or id =1 or 4 or 9
        /// </summary>
        /// <param name="list"></param>
        public void RetriveRecordsWithRatingGreaterThan3(List<ProductReview> list)
        {
            var allRecords = list.Where(P => P.Rating > 3 && (P.ProductID == 1) || (P.ProductID == 4) || (P.ProductID == 9)).ToList();      //using lambda expression
            Program.DisplayProducts(allRecords);
        }
    }
}
