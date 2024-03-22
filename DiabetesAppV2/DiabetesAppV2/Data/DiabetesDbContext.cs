using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace DiabetesAppV2.Data;

public class DiabetesDbContext: DbContext
{
    public DiabetesDbContext(DbContextOptions<DiabetesDbContext> options) : base(options)
    { }


}
