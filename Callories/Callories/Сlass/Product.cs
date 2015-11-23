using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Callories.Сlass
{
    class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Protein { get; set; }
        public double Fat { get; set; }
        public double Carbohydrate { get; set; }
        public double Calories { get; set; }
        public virtual ICollection<ProdutInfo> ProdutInfos { get; set; }

    }
}
