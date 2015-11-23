using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Callories.Сlass
{
    class DateFor
    {
        public int Id { get; set; }
        public DateTime Date {get;set;}
        public virtual ICollection<ProdutInfo> ProdutInfos { get; set; }
        public virtual ICollection<ExerciseInfo> ExerciseInfos { get; set; }
    }
}
