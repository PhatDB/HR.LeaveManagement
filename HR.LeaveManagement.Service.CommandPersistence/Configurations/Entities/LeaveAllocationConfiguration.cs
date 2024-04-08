using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.LeaveManagement.Service.CommandPersistence.Configurations.Entities
{
    public class LeaveAllocationConfiguration : IEntityTypeConfiguration<LeaveAllocationConfiguration>
    {
        [Key]
        public int Id { get; set; }
        public void Configure(EntityTypeBuilder<LeaveAllocationConfiguration> builder)
        {
          
        }
    }
}
