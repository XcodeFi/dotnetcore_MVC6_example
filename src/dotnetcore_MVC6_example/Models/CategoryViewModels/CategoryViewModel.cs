﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnetcore_MVC6_example.Models.CategoryViewModels
{
    public class CategoryViewModel
    {
        public int Id { get; set; }
        public int? ParentId { get; set; }
        public byte Level { get; set; }
        public string Name { get; set; }
        public string UrlSlug { get; set; }
        public string ImageUrl { get; set; }
        public DateTime DateCreated { get; set; }
        public string Description { get; set; }
        public byte IsPublish { get; set; }
        public byte IsDelete { get; set; }
        public bool IsMainMenu { get; set; }
        public byte Status { get; set; }
        public int TotalCard { get; set; }
    }
}
