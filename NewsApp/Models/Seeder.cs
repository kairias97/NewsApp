using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewsApp.Models
{
    public static class Seeder
    {
        public static void SeedInitialNews(IServiceProvider serviceProvider)
        {
            using (var context = new NewsDbContext(
                serviceProvider.GetRequiredService<DbContextOptions<NewsDbContext>>()))
            {
                // Look for any news before seeding.
                if (context.News.Any())
                {
                    return;   // DB has already been seeded
                }

                context.News.AddRange(
                     new News
                     {
                         Title = "Wikimedia Commons media of the day for December 10",
                         PublishedDate = DateTime.UtcNow.Date,
                         ImageURL = "https://upload.wikimedia.org/wikipedia/commons/thumb/3/35/European_Balcony_Project_-_Declaration_of_the_European_Republic_-_Reading_of_the_Manifesto_at_Rotes_Rathaus_10_November_2018_16_00.webm/300px--European_Balcony_Project_-_Declaration_of_the_European_Republic_-_Reading_of_the_Manifesto_at_Rotes_Rathaus_10_November_2018_16_00.webm.jpg",
                         Content = "A month ago Ulrike Guérot's and Robert Menasse's European Balcony Project declared the European Republic by reading its manifesto from balconies all over Europe. At Rotes Rathaus in Berlin the declaration was made in German, English, French and Italian."
                     },
                     new News
                     {
                         Title = "Wikimedia Commons media of the day for December 6",
                         PublishedDate = DateTime.UtcNow.Date.AddDays(-2),
                         ImageURL = "https://upload.wikimedia.org/wikipedia/commons/thumb/9/99/Kundati_Chamundi_-_Purappaatu%28Large%29.ogv/300px--Kundati_Chamundi_-_Purappaatu%28Large%29.ogv.jpg",
                         Content = "Kundati Chamundi theyyam's preparation in Anakkeel Temple, Mukkunnu, Kannur."

                     },
                     new News
                     {
                         Title = "Wikimedia Commons media of the day for December 5",
                         PublishedDate = DateTime.UtcNow.Date.AddDays(-5),
                         ImageURL = "https://upload.wikimedia.org/wikipedia/commons/thumb/e/e9/Indian_Sign_Language_Council_%281930%29.webm/300px-seek%3D1-Indian_Sign_Language_Council_%281930%29.webm.jpg",
                         Content = "<strong>Fragments of an American documentary on the Plains Indians sign language, filmed during an intertribal meeting organized in 1930 by general Hugh L. Scott in Browning, Montana. </strong>"

                     },
                     new News
                     {
                         Title = "Subnautica will be free on the Epic Store for a limited time",
                         PublishedDate = DateTime.UtcNow.Date.AddMonths(-1),
                         ImageURL = "https://cdn.mos.cms.futurecdn.net/KBcm4o9cBs8tNdcCFsybMn-650-80.jpg",
                         Content = "After building a spectacularly large audience with Fornite, Epic is turning its game " +
                            "launcher into a Steam-like store—though one that offers developers a larger revenue share. " +
                            "The first games it's offering are now visible on the Epic Store ."
                     },
                     new News
                     {
                         Title = "Wikimedia Commons media of the day for December 3",
                         PublishedDate = DateTime.UtcNow.Date.AddMonths(-1),
                         ImageURL = "https://upload.wikimedia.org/wikipedia/commons/thumb/3/38/Robinet_chauffeur_myope_%281914%29.webm/300px-seek%3D1-Robinet_chauffeur_myope_%281914%29.webm.jpg",
                         Content = "Robinet chauffeur miope is a 1914 Italian silent film by <a href='https://en.wikipedia.org/wiki/Marcel_Perez'>Marcel Perez</a>. "

                     },
                     new News
                     {
                         Title = "Wikimedia Commons media of the day for December 2",
                         PublishedDate = DateTime.UtcNow.Date.AddMonths(-1),
                         ImageURL = "https://upload.wikimedia.org/wikipedia/commons/thumb/f/f7/Bell-ringer_yaroslavl_2012.ogv/300px--Bell-ringer_yaroslavl_2012.ogv.jpg",
                         Content = "Bell-ringer, Savior Transfiguration Monastery, <a href='https://en.wikipedia.org/wiki/Yaroslavl'>Yaroslavl</a>, 2012. "

                     },
                     new News
                     {
                         Title = "Wikimedia Commons media of the day for December 1",
                         PublishedDate = DateTime.UtcNow.Date.AddMonths(-2),
                         ImageURL = "https://upload.wikimedia.org/wikipedia/commons/thumb/e/e2/Neuberger_M%C3%BCnster_Innenraum_01.jpg/500px-Neuberger_M%C3%BCnster_Innenraum_01.jpg",
                         Content = "<p>This <strong>concept animation</strong> shows just one of many potential concepts for how " +
                            "the first human landing site on Mars might evolve throughout the course of multiple human " +
                            "expeditions to the Red Planet over a decade or more. </p>"

                     },
                     new News
                     {
                         Title = "Hands-on with the new pirate MMO from the creators of ARK",
                         PublishedDate = DateTime.UtcNow.Date.AddMonths(-2),
                         ImageURL = "https://cdn.mos.cms.futurecdn.net/RPkMiUCTvY5s7252wek2UK-650-80.jpg",
                         Content = "Arriving on December 13, Atlas combines EVE Online and ARK for something altogether different."

                     },
                     new News
                     {
                         Title = "The Game Awards 2018: All the trailers and announcements",
                         PublishedDate = DateTime.UtcNow.Date.AddMonths(-2),
                         ImageURL = "https://cdn.mos.cms.futurecdn.net/nYe3aKPB3HzXhgu44tcWJL-650-80.jpg",
                         Content = "That’s The Game Awards over for another year. It was a roller coaster. " +
                            "SonicFox made us cry; Reggie Fils-Aimé, Phil Spencer, and that guy from PlayStation were " +
                            "in the same room at the same time (woah!); and some games won awards. There were also a few " +
                            "game announcements, which is what you’re really here for. "

                     },
                     new News
                     {
                         Title = "Obsidian's The Outer Worlds blends Firefly and Fallout into a bold, open-ended sci-fi RPG",
                         PublishedDate = DateTime.UtcNow.Date.AddMonths(-2),
                         ImageURL = "https://cdn.mos.cms.futurecdn.net/WFJrCBahBbczhWVU7U7UCU-650-80.jpg",
                         Content = "<p>Obsidian's new RPG The Outer Worlds is not just sci-fi: it is exuberantly sci-fi. " +
                            "Blood red trees pepper valleys of strange cylindrical rocks and alien shrubs. " +
                            "A spaceship rumbles overhead, coming in for a landing at the nearest spaceport. " +
                            "Rings grander than Saturn's carve an arc across the horizon, and a field of stars shine " +
                            "impossibly bright in the afternoon sky. It's a world I already know I want to explore: the colorful " +
                            "vistas of No Man's Sky, but in an RPG that looks and feels very Fallout, just a million miles away and pre-nuclear armageddon.</p>"

                     }


                );
                context.SaveChanges();
            }
        }
    }
}
