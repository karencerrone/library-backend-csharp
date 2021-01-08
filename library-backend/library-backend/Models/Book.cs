using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace library_backend.Models
{
    public class Book
    {
        private int id;
        private string title;
        private bool isBorrowed;
        private DateTime lastUpdated;

        public Book()
        {
        }

        public Book(int id, string title, bool isBorrowed, DateTime lastUpdated)
        {
            this.id = id;
            this.title = title;
            this.isBorrowed = isBorrowed;
            this.lastUpdated = lastUpdated;
        }

        public int Id { get => id; set => id = value; }
        public string Title { get => title; set => title = value; }
        public bool IsBorrowed { get => isBorrowed; set => isBorrowed = value; }
        public DateTime LastUpdated { get => lastUpdated; set => lastUpdated = value; }

    }
}