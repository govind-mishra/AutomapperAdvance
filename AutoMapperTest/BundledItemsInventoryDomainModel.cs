using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMapperTest
{
    public class BundledItemsInventoryDomainModel
    {
        /// <summary>
        /// ItemId of the Constituent Items
        /// FK to ItemId in tblProducts table
        /// </summary>
        public string SkuId { get; set; }

        /// <summary>
        /// Name of the child Items in the BundledItems
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Quantity of a child item in a bundled item.
        /// </summary>
        public int CompositionNumber { get; set; }

    }
}
