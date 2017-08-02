﻿using Edux.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Edux.Data
{
    public static class ApplicationDbContextInitializer
    {
        public static void Initialize(ApplicationDbContext context)
        {
            context.Database.Migrate();

            // Look for any students.
            if (context.ComponentTypes.Any())
            {
                return;   // DB has been seeded
            }

            // Div bileşenini ekle
            var ct1 = new ComponentType() { Name = "DivComponent", DisplayName = "Div Bileşeni", CreateDate = DateTime.Parse("2017-07-26"), UpdateDate = DateTime.Parse("2017-07-26"), CreatedBy = "username", UpdatedBy = "username", AppTenantId = "1" };
            context.ComponentTypes.Add(ct1);
            context.SaveChanges();

            // Div bileşeninin parametrelerini ekle
            var p1 = new Parameter() { Name = "CssClass", DisplayName = "CssClass", CreateDate = DateTime.Parse("2017-07-26"), UpdateDate = DateTime.Parse("2017-07-26"), CreatedBy = "username", UpdatedBy = "username", ComponentTypeId = ct1.Id };
            context.Parameters.Add(p1);
            context.SaveChanges();

            // Link bileşenini ekle
            var ct2 = new ComponentType() { Name = "LinkComponent", DisplayName = "Link Bileşeni", CreateDate = DateTime.Parse("2017-07-26"), UpdateDate = DateTime.Parse("2017-07-26"), CreatedBy = "username", UpdatedBy = "username", AppTenantId = "1" };
            context.ComponentTypes.Add(ct2);
            context.SaveChanges();

            // link bileşeninin parametrelerini ekle
            var p2 = new Parameter() { Name = "CssClass", DisplayName = "CssClass", CreateDate = DateTime.Parse("2017-07-26"), UpdateDate = DateTime.Parse("2017-07-26"), CreatedBy = "username", UpdatedBy = "username", ComponentTypeId = ct2.Id };
            var p3 = new Parameter() { Name = "Href", DisplayName = "Href", CreateDate = DateTime.Parse("2017-07-26"), UpdateDate = DateTime.Parse("2017-07-26"), CreatedBy = "username", UpdatedBy = "username", ComponentTypeId = ct2.Id };
            var p4 = new Parameter() { Name = "Text", DisplayName = "Text", CreateDate = DateTime.Parse("2017-07-26"), UpdateDate = DateTime.Parse("2017-07-26"), CreatedBy = "username", UpdatedBy = "username", ComponentTypeId = ct2.Id };
            context.Parameters.Add(p2);
            context.Parameters.Add(p3);
            context.Parameters.Add(p4);
            context.SaveChanges();

            // Image bileşenini ekle
            var ct3 = new ComponentType() { Name = "ImageComponent", DisplayName = "Resim Bileşeni", CreateDate = DateTime.Parse("2017-07-26"), UpdateDate = DateTime.Parse("2017-07-26"), CreatedBy = "username", UpdatedBy = "username", AppTenantId = "1" };
            context.ComponentTypes.Add(ct3);
            context.SaveChanges();

            // link bileşeninin parametrelerini ekle
            var p5 = new Parameter() { Name = "Src", DisplayName = "Src", CreateDate = DateTime.Parse("2017-07-26"), UpdateDate = DateTime.Parse("2017-07-26"), CreatedBy = "username", UpdatedBy = "username", ComponentTypeId = ct3.Id };
            var p6 = new Parameter() { Name = "Width", DisplayName = "Width", CreateDate = DateTime.Parse("2017-07-26"), UpdateDate = DateTime.Parse("2017-07-26"), CreatedBy = "username", UpdatedBy = "username", ComponentTypeId = ct3.Id };
            var p7 = new Parameter() { Name = "Height", DisplayName = "Height", CreateDate = DateTime.Parse("2017-07-26"), UpdateDate = DateTime.Parse("2017-07-26"), CreatedBy = "username", UpdatedBy = "username", ComponentTypeId = ct3.Id };
            context.Parameters.Add(p5);
            context.Parameters.Add(p6);
            context.Parameters.Add(p7);
            context.SaveChanges();

            // veri tablosu bileşenini ekle
            var ct4 = new ComponentType { Name = "DataTableComponent", DisplayName = "Veri Tablosu Bileşeni", CreateDate = DateTime.Parse("2017-07-26"), UpdateDate = DateTime.Parse("2017-07-26"), CreatedBy = "username", UpdatedBy = "username", AppTenantId = "1" };
            context.ComponentTypes.Add(ct4);
            context.SaveChanges();

            // veri tablosu bileşeninin parametrelerini ekle
            var p8 = new Parameter() { Name = "EntityName", DisplayName = "EntityName", CreateDate = DateTime.Parse("2017-07-26"), UpdateDate = DateTime.Parse("2017-07-26"), CreatedBy = "username", UpdatedBy = "username", ComponentTypeId = ct4.Id };
            context.Parameters.Add(p8);
            context.SaveChanges();

            var ct5 = new ComponentType() { Name = "TextComponent", DisplayName = "Yazı Bileşeni", CreateDate = DateTime.Parse("2017-07-26"), UpdateDate = DateTime.Parse("2017-07-26"), CreatedBy = "username", UpdatedBy = "username", AppTenantId = "1" };
            context.ComponentTypes.Add(ct5);
            context.SaveChanges();

            // link bileşeninin parametrelerini ekle
            var p9 = new Parameter() { Name = "Content", DisplayName = "Content", CreateDate = DateTime.Parse("2017-07-26"), UpdateDate = DateTime.Parse("2017-07-26"), CreatedBy = "username", UpdatedBy = "username", ComponentTypeId = ct5.Id };
            context.Parameters.Add(p9);
            context.SaveChanges();
        }
    }
}
