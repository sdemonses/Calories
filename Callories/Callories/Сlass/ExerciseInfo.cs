using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Callories.Сlass
{
    class ExerciseInfo
    {
        public int Id { get; set; }
        public int? ExersiceId { get; set; }
        public virtual Exersice Exercise { get; set; }
        public int? DateForId { get; set; }
        public virtual DateFor DateFor { get; set; }
        public double Duration { get; set; }
        public double Calories { get { return Exercise.Calories * Duration/60.0; } }
    }
}
