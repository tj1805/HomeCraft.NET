using HomeCraft.Core.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeCraft.Data
{
    public class HomeCraftDbContext : DbContext
    {
        public HomeCraftDbContext(DbContextOptions<HomeCraftDbContext> options) : base(options)
        {

        }
        public DbSet<Product> Products { get; set; }
        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product()
                {
                    Id = Guid.Parse("d28888e9-2ba9-473a-a40f-e38cb54f9b35"),
                    Name = "Testing One",
                    ShortDescription = "Lorem ipsum dolor sit amet.",
                    LongDescription = "Donec tempus, sem a sollicitudin cursus, lectus quam vulputate risus, id hendrerit lorem eros varius ipsum. Nunc posuere ac arcu consequat suscipit. Proin turpis erat, ornare id nisl vel, rhoncus accumsan nibh. Sed fringilla odio vel interdum blandit. Proin nec mi et massa efficitur consequat non quis enim. Praesent dignissim mollis enim, sit amet pulvinar orci hendrerit vel. Aenean ac dapibus sapien, a lacinia sem. Ut maximus et nibh sit amet volutpat. In venenatis urna a neque dapibus faucibus.",
                    Price = 30.20,
                    ImageUrl = "https://cdn.pixabay.com/photo/2016/04/18/13/53/room-1336497_960_720.jpg",
                },
                new Product()
                {
                    Id = Guid.Parse("d28888e9-2ba3-473a-a40f-e38cb57f9b31"),
                    Name = "Cras rhoncus",
                    ShortDescription = "Molestie aliquam in quis magna",
                    LongDescription = "Etiam lorem neque, ultrices vitae nibh venenatis, vehicula posuere velit. Mauris in faucibus justo. Donec nec risus in massa consequat ultricies. Nam sagittis lorem erat, in aliquet tellus egestas sed. Vestibulum in tellus id augue molestie aliquam in quis magna. Curabitur finibus eu ipsum in ullamcorper.",
                    Price = 45.86,
                    ImageUrl = "https://cdn.pixabay.com/photo/2014/09/15/21/46/couch-447484_960_720.jpg"
                },
                new Product()
                {
                    Id = Guid.Parse("d28888e9-2ba9-473a-a42f-e38cb54f9b33"),
                    Name = "Nunc semper",
                    ShortDescription = "Duis posuere lorem lorem",
                    LongDescription = "Duis posuere lorem lorem, non cursus sem bibendum nec. Donec pellentesque ex non augue egestas ultrices.",
                    Price = 74.96,
                    ImageUrl = "https://cdn.pixabay.com/photo/2017/03/28/12/13/chairs-2181968_960_720.jpg"
                },
                 new Product()
                 {
                     Id = Guid.Parse("d28888e9-2ba9-473a-a41f-e38cb54f9b32"),
                     Name = "vulputate",
                     ShortDescription = "nisl vel pretium vulputate",
                     LongDescription = "nisl vel pretium vulputate, sem leo aliquet eros, fermentum imperdiet ex purus in urna. Aenean non nisi semper, rhoncus neque nec, lobortis orci. Pellentesque sit amet porta est. Mauris arcu nulla, placerat eget nulla id,",
                     Price = 85.85,
                     ImageUrl = "https://cdn.pixabay.com/photo/2016/11/22/23/38/apartment-1851201_960_720.jpg"
                 },
                 new Product()
                 {
                     Id = Guid.Parse("d28888e9-2ba9-473a-a40f-e38cb54f9b34"),
                     Name = "Aenean elementum",
                     ShortDescription = "Aenean elementum placerat interdum",
                     LongDescription = "Aenean elementum placerat interdum. Fusce faucibus elit mauris, quis malesuada ex commodo nec. Quisque eu neque felis. Integer vulputate, diam et laoreet eleifend, dolor purus tempor ex, vitae porta enim justo ut ipsum. Etiam justo risus, varius ornare nunc vitae, hendrerit vestibulum arcu",
                     Price = 85.85,
                     ImageUrl = "https://cdn.pixabay.com/photo/2018/01/26/08/15/dining-room-3108037_960_720.jpg"
                 },
                new Product()
                {
                    Id = Guid.Parse("d28888e9-2ba9-473a-a42f-e38cb54f9b37"),
                    Name = "Fusce ornare",
                    ShortDescription = "Fusce ornare velit in egestas ultricies",
                    LongDescription = "Fusce ornare velit in egestas ultricies. Nunc ligula augue, tristique vitae viverra eget, semper ut nibh. Duis fermentum lorem risus, et viverra nisl efficitur id. Nulla vulputate, magna et venenatis bibendum, sapien erat malesuada urna, et aliquet libero mi eget quam",
                    Price = 65.15,
                    ImageUrl = "https://cdn.pixabay.com/photo/2017/09/27/02/47/throne-2790789_960_720.png"
                },
                new Product()
                {
                    Id = Guid.Parse("d28888e9-2ba9-473a-a42f-e38cb54f9b38"),
                    Name = "Morbi a nibh",
                    ShortDescription = "Morbi a nibh faucibus orci gravida dapibus",
                    LongDescription = "Morbi a nibh faucibus orci gravida dapibus. Duis eu lorem quis felis ornare dapibus non a orci. Pellentesque et tincidunt lectus. Pellentesque feugiat magna sit amet ligula dignissim, eu congue eros eleifend. Mauris a turpis quis sem molestie placerat. Maecenas non nibh eu odio consequat molestie vel id ante. Lorem ipsum dolor",
                    Price = 24.75,
                    ImageUrl = "https://cdn.pixabay.com/photo/2017/03/19/01/18/living-room-2155353_960_720.jpg"
                },
                new Product()
                {
                    Id = Guid.Parse("d28888e9-2ba9-473a-a42f-e38cb54f9b39"),
                    Name = "Ut tempus ",
                    ShortDescription = "Ut tempus lacus quis tortor scelerisque",
                    LongDescription = "Maecenas non nibh eu odio consequat molestie vel id ante. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut tempus lacus quis tortor scelerisque, sit amet maximus ligula suscipit. In sed tortor eros.",
                    Price = 65.05,
                    ImageUrl = "https://cdn.pixabay.com/photo/2017/08/02/01/01/living-room-2569325_960_720.jpg"
                }
                );
            base.OnModelCreating(modelBuilder);
        }
    }
}
