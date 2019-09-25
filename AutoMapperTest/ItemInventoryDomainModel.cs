using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMapperTest
{
    public class ItemInventoryDomainModel
    {
        /// <summary>
        /// Item Identifier 商品ID
        /// </summary>
        public string ItemId { get; set; }


        public bool BundledItemFlag { get; set; }

        

        /// <summary>
        /// Item Category Name カテゴリー
        /// </summary>
        public string ItemCategoryName { get; set; }

        /// <summary>
        /// Item Name 商品名
        /// </summary>
        public string Name { get; set; }



        /// <summary>
        /// List of BundledItemDetails for an item
        /// Should only have value if BundledItemFlag = 1
        /// </summary>
        public IEnumerable<BundledItemsInventoryDomainModel> BundledItemDetails { get; set; }
    }
}
