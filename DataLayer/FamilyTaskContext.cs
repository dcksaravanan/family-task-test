﻿using Core.Abstractions;
using Domain.DataModels;
using Microsoft.EntityFrameworkCore;
using System;

namespace DataLayer
{
    public class FamilyTaskContext : DbContext
    {

        public FamilyTaskContext(DbContextOptions<FamilyTaskContext> options) : base(options)
        {

        }

        public DbSet<Member> Members { get; set; }
        public DbSet<Task> Tasks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Member>(entity =>
            {
                entity.HasKey(k => k.Id);
                entity.ToTable(nameof(Member));
            });
            modelBuilder.Entity<Task>(entity =>
            {
                entity.HasKey(k => k.Id);
                entity.ToTable(nameof(Task));
            });
            modelBuilder.Entity<Task>()
            .HasOne<Member>(s => s.AssignedMember)
            .WithMany(g => g.Tasks)
            .HasForeignKey(s => s.AssignedMemberId);
        }
    }
}