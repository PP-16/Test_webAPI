using Microsoft.EntityFrameworkCore;
using SchoolSync.DAL.Entities;

namespace SchoolSync.DAL.EFCore;

public class SchoolSyncDbContext : DbContext
{
	public DbSet<Division> Division {get; set;}
	public DbSet<Documents> Documents {get;set;}
	public DbSet<DocumentType> DocumentType {get;set;}
	public DbSet<DocumentAutorun> DocumentAutorun {get;set;}
	public DbSet<Position> Position {get;set;}
	public DbSet<Employees> Employees {get;set;}
	public SchoolSyncDbContext(DbContextOptions<SchoolSyncDbContext> options) : base(options)
	{

	}
}
