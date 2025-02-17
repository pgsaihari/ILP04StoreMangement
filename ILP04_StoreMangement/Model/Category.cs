﻿using System.ComponentModel.DataAnnotations.Schema;

namespace ILP04_StoreMangement.Model
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ImageUrl { get; set; }

        [NotMapped]
        public IFormFile Image {  get; set; }

        public ICollection<Product> Products { get; set; }

    }
}
