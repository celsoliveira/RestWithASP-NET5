﻿using System.ComponentModel.DataAnnotations.Schema;

namespace RestWithASPNET.data.VO
{

    public class BookVO
    {
        public long Id { get; set; }
        public string Author { get; set; }
        public DateTime LaunchDate { get; set; }
        public double Price { get; set; }
        public string Title { get; set; }

    }
}
