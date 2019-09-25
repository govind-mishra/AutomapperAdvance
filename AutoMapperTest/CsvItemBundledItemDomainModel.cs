using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMapperTest
{
    public class CsvItemBundledItemDomainModel
    {
        /// <summary>
        /// セット商品ID of Bundled Items
        /// </summary>
  
        public string ItemId { get; set; }
        /// <summary>
        /// セット構成品商品ID of Child of a Bundled Items
        /// </summary>
    
        public string SkuId { get; set; }

        /// <summary>
        /// 商品名 Product Name of the child Items in the Bundled Items
        /// </summary>
      
        public string Name { get; set; }

        /// <summary>
        /// 構成品数 # of Children in a Bundled Items
        /// </summary>
      
        public int? CompositionNumber { get; set; }

        /// <summary>
        /// セット構成品削除 # of Children in a Bundled Items
        /// </summary>
        
        public int? BundleItemDeleteFlag { get; set; }
    }
}
