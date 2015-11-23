using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Callories.Сlass
{
    class Exersice
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Calories { get; set; }
        public double Duration { get; set; }
        public virtual ICollection<ExerciseInfo> ExerciseInfos { get; set; }
    }
}
