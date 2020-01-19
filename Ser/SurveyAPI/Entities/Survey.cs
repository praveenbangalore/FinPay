using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinTechAPI.Entities
{
    public class Survey
    {
        public int Id { get; set; }
        public string SurveyName { get; set; }
        public string SurveyDesc { get; set; }
        public int OwnerId { get; set; }
        public DateTime CreatedOn { get; set; }
        public string Category { get; set; }
        
    }
}
