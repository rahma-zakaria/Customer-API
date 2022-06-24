﻿using DomainLayer.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.EntityMapper
{
    public class CustomerMap : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.HasKey(x => x.Id).HasName("pk_customerId");
            builder.Property(x => x.Id).ValueGeneratedOnAdd()
                .HasColumnName("id").HasColumnType("int");

            builder.Property(x=> x.PurchasesProduct)
                .HasColumnName("purchased_product")
                .HasColumnType("nvarchar(100)").IsRequired();

            builder.Property(x => x.PaymentType)
                .HasColumnName("payment_type")
                .HasColumnType("nvarchar(50)").IsRequired();

            builder.Property(x => x.CreatedDate)
                .HasColumnName("created_date")
                .HasColumnType("datetime");

            builder.Property(x => x.ModifiedDate)
                .HasColumnName("modified_date")
                .HasColumnType("datetime");

            builder.Property(x => x.IsActive)
                .HasColumnName("is_active")
                .HasColumnType("bit");


        }
    }
}
