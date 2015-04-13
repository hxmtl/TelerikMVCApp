﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using TelerikMvcApp.DataAccess.Seeds;
using TelerikMvcApp.Models;

namespace TelerikMvcApp.DataAccess
{
    public class CardnoContext : BaseContext<CardnoContext>, ICardnoContext
    {
        public DbSet<Candidate> Candidates { get; set; }

        public DbSet<Qualification> Qualifications { get; set; }

        public CardnoContext()
        {
           // Database.SetInitializer(new InitializeDBWithSeedData());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Configurations.Add(new CandidateMappings());
            modelBuilder.Configurations.Add(new QualificationsMappings());

        }

    }
}