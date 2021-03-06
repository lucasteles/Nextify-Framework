﻿using Nextify.Abstraction.DAO;
using Nextify.App.Models;
using Nextify.DAO;
using Nextify.DAO.Abstraction;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using System.Linq;

namespace Nextify.App.DAO
{

    public interface ICoursesRepository : IRepository<Course>
    {

    }

    public class CoursesRepository : BaseRepository<Course>, ICoursesRepository
    {

        public CoursesRepository(IContext context) : base(context)
        {
            IncludeForEdit(
                    e => e.Author,
                    e => e.Tags
                );


        }


        public override IQueryable<Course> Get()
        {
            return base.Get()
                .Include(e => e.Tags)
                .Include(a => a.Author);
        }



        protected override void OnModelConfiguration(EntityTypeConfiguration<Course> modelConfig)
        {
            modelConfig.Property(c => c.Description)
                .IsRequired()
                .HasMaxLength(2000);

            modelConfig.Property(c => c.Name)
                .IsRequired()
                .HasMaxLength(255);

            modelConfig.HasRequired(c => c.Author)
                .WithMany(a => a.Courses)
                .HasForeignKey(c => c.AuthorId)
                .WillCascadeOnDelete(false);

            modelConfig.HasMany(c => c.Tags)
                .WithMany(t => t.Courses)
                .Map(m =>
                {
                    m.ToTable("CourseTags");
                    m.MapLeftKey("CourseId");
                    m.MapRightKey("TagId");
                });
        }
    }




}
