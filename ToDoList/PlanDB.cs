using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList
{
    [Serializable]
    public class PlanDB
    {
        private List<PlanItems> job;

        public List<PlanItems> Job { get => job; set => job = value; }
    }
}
