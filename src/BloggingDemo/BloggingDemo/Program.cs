using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BloggingDemo.Entities;
using System.Data.Entity;

namespace BloggingDemo
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }

    namespace Entities
    {
        public class Blog
        {
            //Primary Key by convention
            public int BlogId { get; set; }
            public string Name { get; set; }
            //Navigation Property
            public virtual ICollection<Post> Posts { get; set; }
        }

        public class Post
        {
            public int PostId { get; set; }
            public string Title { get; set; }
            public string Content { get; set; }
            public int BlogId { get; set; }
            //Navigation Property
            public virtual Blog Blog { get; set; }
        } //Post
    } //Entities

    namespace DAL
    {
        public class BloggingContext : DbContext
        {
            public BloggingContext() : base("name=BlogDb")
            {

            }

            public DbSet<Blog> Blogs { get; set; }
            public DbSet<Post> Posts { get; set; }
        }
    }
}

