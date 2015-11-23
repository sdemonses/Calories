using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Callories.Сlass;

namespace Callories.Сlass
{
    class ProdutInfo
    {
        public int Id { get; set; }
        public int? ProductId { get; set; }
        public virtual Product Product { get; set; }
        public int? DateForId { get; set; }
        public virtual DateFor DateFor { get; set; }
        public double Weight { get; set; }
        public double Protein { get { return Product.Protein * Weight / 100.0; } }
        public double Calories { get { return Product.Calories * Weight / 100.0; } }
        public double Carbohydrate { get { return Product.Carbohydrate * Weight / 100.0; } }
        public double Fat { get { return Product.Fat * Weight / 100.0; } }
    }
}
