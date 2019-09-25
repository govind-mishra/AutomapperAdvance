using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMapperTest
{
    public class CsvItemProductDomainModel
    {
      
       
        public string ItemId { get; set; }

        /// <summary>
        /// Item name
        /// </summary>
       
        public string Name { get; set; }

        /// <summary>
        /// Item Categories Name / 商品カテゴリ名
        /// </summary>
       
        public string CategoryName { get; set; }


        /// <summary>
        /// Weight in grams
        /// </summary>

        public string WeightUnit { get; set; }

        /// <summary>
        /// SPIN Number
        /// </summary>
        public string SPINNumber { get; set; }

        /// <summary>
        /// Misc Bar code
        /// </summary>
        public string MiscBarcode { get; set; }

        /// <summary>
        /// Is material hazardous
        /// </summary>
        public bool? IsHazMat { get; set; }


        public int BundledItemFlag { get; set; }

        /// <summary>
        /// List of BundledItemDetails for item
        /// </summary>
      
        public IEnumerable<CsvItemBundledItemDomainModel> CsvBundledItemDetails { get; set; }

    }
}
