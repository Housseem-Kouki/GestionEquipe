using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GE.Infrastructure.Configurations
{
    public class MembreConfigruration : IEntityTypeConfiguration<MembreConfigruration>
    {
        public void Configure(EntityTypeBuilder<MembreConfigruration> builder)
        {
           
        }
    }
}
