using Microsoft.EntityFrameworkCore;
using CodersGrill.Models;

namespace CodersGrill.Data
{
    public static class ApplicationDbContextSeed
    {
        public static void Seed(IServiceProvider serviceProvider)
        {
            using var context = new ApplicationDbContext(
                serviceProvider.GetRequiredService<DbContextOptions<ApplicationDbContext>>());

            Console.WriteLine("Starting seeding...");

            var textContents = new[]

            {
                new TextContent(1, "Main Header", "<h1>The Coders' Grill</h1>"),
                new TextContent(1, "Navigation", "<a href='#'>Our Menu</a>"),
                new TextContent(1, "Navigation", "<a href='#'>About Us</a>"),
                new TextContent(1, "Navigation", "<a href='#'>Our Locations</a>"),
                new TextContent(1, "Navigation", "<a href='#'>Help & FAQs</a>"),
                                                
                new TextContent(2, "Header", "<h2>Chef's Recommendations</h2>"),
                new TextContent(2, "Name", "<h3>Sunday Roast</h3>"),
                new TextContent(2, "Description", "<p>Enjoy our traditional Sunday roast featuring succulent, slow-cooked beef, Yorkshire pudding, roasted potatoes, and seasonal vegetables, all served with a rich gravy</p>"),
                new TextContent(2, "Name", "<h3>Lamb Specialty</h3>"),
                new TextContent(2, "Description", "<p>Savor our tender, herb-crusted lamb chops, perfectly seared and paired with a rosemary demi-glace, served alongside garlic mashed potatoes and roasted root vegetables</p>"),
                new TextContent(2, "Name", "<h3>Duck Delicacy</h3>"),
                new TextContent(2, "Description", "<p>Delight in our pan-seared duck breast, drizzled with an orange-ginger glaze and accompanied by wild rice pilaf and sautéed baby greens</p>"),
                new TextContent(2, "Name", "<h3>Vegan Feast</h3>"),
                new TextContent(2, "Description", "<p>Experience our Vegan Feast: a vibrant medley of grilled portobello mushrooms, quinoa-stuffed bell peppers, and roasted vegetables, drizzled with a balsamic glaze and served with a side of tangy avocado salad</p>"),

                new TextContent(3, "Header", "<h2>Special Offers</h2>"),
                new TextContent(3, "Description", "<p>Burger Bonanza - 40% OFF during lunchtime hours!</p>"),
                new TextContent(3, "Description", "<p>BBQ Chow Down - 30% OFF on weekends!</p>"),
                new TextContent(3, "Description", "<p>Family Platters - 25% OFF on Sundays!</p>"),

                new TextContent(4, "Header", "<h2>Menu Categories</h2>"),
                new TextContent(4, "Name", "<h3>Starters</h3>"),
                new TextContent(4, "Name", "<h3>Mains</h3>"),
                new TextContent(4, "Name", "<h3>Desserts</h3>"),
                new TextContent(4, "Name", "<h3>Vegan/Vegetarian</h3>"),
                new TextContent(4, "Name", "<h3>Sides</h3>"),
                new TextContent(4, "Name", "<h3>Kids' Menu</h3>"),
                new TextContent(4, "Name", "<h3>Drinks & Beverages</h3>"),

                new TextContent(5, "Information", "<p><strong>Coders' Grill </strong> 4-5 New St, City Centre, Birmingham, B2 4RF</p>"),
                new TextContent(5, "Navigation", "<a href='#'>Site map</a>"),
                new TextContent(5, "Navigation", "<a href='#'>/Terms</a>"),
                new TextContent(5, "Navigation", "<a href='#'>/Privacy Policy</a>"),
                new TextContent(5, "Information", "<p>/Site By Verto</p>"),
                new TextContent(5, "Information", "<p>call <strong>01234 567890</strong></p>"),
                new TextContent(5, "Information", "<p>email us customer.support@codersgrill.co.uk</p>")
            };

            foreach (var content in textContents)
            {
                var existingContent = context.TextContents.FirstOrDefault(tc => tc.Id == content.Id);
                if (existingContent != null)
                {
                    existingContent.Section = content.Section;
                    existingContent.ContentType = content.ContentType;
                    existingContent.HtmlContent = content.HtmlContent;
                    context.TextContents.Update(existingContent);
                    Console.WriteLine($"Updated: {existingContent.Id}");
                }
                else
                {
                    context.TextContents.Add(content);
                    Console.WriteLine($"Added: {content.Id}");
                }
            }

            context.SaveChanges();
            Console.WriteLine("Seeding complete.");
        }
    }
}