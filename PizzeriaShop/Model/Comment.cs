using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class Comment
    {
        public Guid Id { get; set; }
        public string Text { get; set; }
        public int Puntuation { get; set; }
        public DateTime Date { get; set; }
        public User User { get; set; }
        public Pizza Pizza { get; set; }
        public int Dbr { get; set; }
    }
}
