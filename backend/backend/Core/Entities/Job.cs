﻿using backend.Core.Enums;

namespace backend.Core.Entities
{
    public class Job : BaseEntity
    {
        public string Name { get; set; }
/*        public JobLevel Level{ get; set; }
*/
        public string Description { get; set; }
        // Relations
        public ICollection<Employee> Employees { get; set; }

        public ICollection<CompanyDepartementJob> CompanyDepartementJobs { get; set; }

    }
}
