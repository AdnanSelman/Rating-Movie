using Microsoft.EntityFrameworkCore;
using MovieRatingTask.Data.Models;
using System;

namespace MovieRatingTask.Data.Context
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Actor>().HasData(
                new Actor
                {
                    Id = new Guid("a0428c66-9fa7-46ce-968a-c57923c8a8da"),
                    FirstName = "Brad",
                    LastName = "Pit",
                },
                new Actor
                {
                    Id = new Guid("29e8943c-468b-4058-bf5e-1f2ccee01021"),
                    FirstName = "Peter",
                    LastName = "Dinklage",
                },
                new Actor
                {
                    Id = new Guid("525684fc-a004-4cf3-b2c3-3a1fe3e4ddcc"),
                    FirstName = "Lena",
                    LastName = "Headey",
                },
                new Actor
                {
                    Id = new Guid("383be908-1dae-49e6-b2fb-c05afd7d0ecd"),
                    FirstName = "Emilia",
                    LastName = "Clarke",
                },
                new Actor
                {
                    Id = new Guid("8303949e-d1cb-4c82-9300-c6925009ffb3"),
                    FirstName = "Kit",
                    LastName = "Harington",
                },
                new Actor
                {
                    Id = new Guid("d4e4ec8b-fea7-4892-a372-c31081c163b6"),
                    FirstName = "Sophie",
                    LastName = "Turner",
                }
            );

            modelBuilder.Entity<MovieShowType>().HasData(
                new MovieShowType
                {
                    Id = new Guid("7945162a-95e4-4fc8-8aad-1e99fbc850c0"),
                    Name = "Movie"
                },
                new MovieShowType
                {
                    Id = new Guid("a999e831-978f-49b6-8c1c-ff82bb3231f3"),
                    Name = "Show"
                }
            );

            modelBuilder.Entity<MovieShow>().HasData(
                new MovieShow
                {
                    Id = new Guid("1aee9219-d85d-424c-adf9-a504a1b1f698"),
                    Title = " The Shawshank Redemption",
                    ReleaseDate = new DateTime(1994, 9, 14),
                    Description = "Two imprisoned men bond over a number of years, finding solace and eventual redemption through acts of common decency.",
                    CoverImageUrl = "https://taskformistral.blob.core.windows.net/mistral/TheShawshankRedemption.jpg",
                    TypeId = new Guid("7945162a-95e4-4fc8-8aad-1e99fbc850c0")
                },
                new MovieShow
                {
                    Id = new Guid("c2e8e0e4-d27a-4053-9510-51f3a14d3a1c"),
                    Title = "The Godfather",
                    ReleaseDate = new DateTime(1972, 2, 4),
                    CoverImageUrl = "https://taskformistral.blob.core.windows.net/mistral/TheGodfather.jpg",
                    Description = "An organized crime dynasty's aging patriarch transfers control of his clandestine empire to his reluctant son.",
                    TypeId = new Guid("7945162a-95e4-4fc8-8aad-1e99fbc850c0")
                },
                new MovieShow
                {
                    Id = new Guid("db03a785-ffbb-4599-9add-763ae9156d83"),
                    Title = "The Godfather: Part II",
                    ReleaseDate = new DateTime(1972, 2, 4),
                    CoverImageUrl = "https://taskformistral.blob.core.windows.net/mistral/TheGodfatherPartII.jpg",
                    Description = "The early life and career of Vito Corleone in 1920s New York City is portrayed, while his son, Michael, expands and tightens his grip on the family crime syndicate.",
                    TypeId = new Guid("7945162a-95e4-4fc8-8aad-1e99fbc850c0")
                },
                new MovieShow
                {
                    Id = new Guid("1f921843-87da-476b-8dfb-4ab892977ba1"),
                    Title = "The Dark Knight",
                    ReleaseDate = new DateTime(2008, 10, 21),
                    CoverImageUrl = "https://taskformistral.blob.core.windows.net/mistral/TheDarkKnight.jpg",
                    Description = "When the menace known as the Joker wreaks havoc and chaos on the people of Gotham, Batman must accept one of the greatest psychological and physical tests of his ability to fight injustice.",
                    TypeId = new Guid("7945162a-95e4-4fc8-8aad-1e99fbc850c0")
                },
                new MovieShow
                {
                    Id = new Guid("de0d2ad7-d56e-41c5-9dbd-23fec0f11fa2"),
                    Title = "12 Angry Men",
                    ReleaseDate = new DateTime(1957, 3, 31),
                    CoverImageUrl = "https://taskformistral.blob.core.windows.net/mistral/12AngryMen.jpg",
                    Description = "A jury holdout attempts to prevent a miscarriage of justice by forcing his colleagues to reconsider the evidence.",
                    TypeId = new Guid("7945162a-95e4-4fc8-8aad-1e99fbc850c0")
                },
                new MovieShow
                {
                    Id = new Guid("1f37fef0-edd9-444c-920f-804d95a43fb8"),
                    Title = "Schindler's List",
                    ReleaseDate = new DateTime(1993, 12, 1),
                    CoverImageUrl = "https://taskformistral.blob.core.windows.net/mistral/SchindlerList.jpg",
                    Description = "A jury holdout attempts to prevent a miscarriage of justice by forcing his colleagues to reconsider the evidence.",
                    TypeId = new Guid("7945162a-95e4-4fc8-8aad-1e99fbc850c0")
                },
                new MovieShow
                {
                    Id = new Guid("15a5b405-4f7f-4a67-9899-eb52326860ba"),
                    Title = "Pulp Fiction",
                    ReleaseDate = new DateTime(1994, 12, 1),
                    CoverImageUrl = "https://taskformistral.blob.core.windows.net/mistral/PulpFiction.jpg",
                    Description = "In German-occupied Poland during World War II, industrialist Oskar Schindler gradually becomes concerned for his Jewish workforce after witnessing their persecution by the Nazis.",
                    TypeId = new Guid("7945162a-95e4-4fc8-8aad-1e99fbc850c0")
                },
                new MovieShow
                {
                    Id = new Guid("a01b2cf7-9496-4bb5-80ba-d475723897a7"),
                    Title = "The Lord of the Rings: The Return of the King",
                    ReleaseDate = new DateTime(2003, 2, 17),
                    CoverImageUrl = "https://taskformistral.blob.core.windows.net/mistral/TheLordoftheRingsTheReturnoftheKing.jpg",
                    Description = "Gandalf and Aragorn lead the World of Men against Sauron's army to draw his gaze from Frodo and Sam as they approach Mount Doom with the One Ring.",
                    TypeId = new Guid("7945162a-95e4-4fc8-8aad-1e99fbc850c0")
                },
                new MovieShow
                {
                    Id = new Guid("33f381f4-c54f-4e97-8ba5-9a1e27c9472c"),
                    Title = "The Good, the Bad and the Ugly",
                    ReleaseDate = new DateTime(1966, 4, 22),
                    CoverImageUrl = "https://taskformistral.blob.core.windows.net/mistral/TheGoodtheBadandtheUgly.jpg",
                    Description = "The lives of two mob hitmen, a boxer, a gangster and his wife, and a pair of diner bandits intertwine in four tales of violence and redemption.",
                    TypeId = new Guid("7945162a-95e4-4fc8-8aad-1e99fbc850c0")
                },
                new MovieShow
                {
                    Id = new Guid("4d973b27-50a9-4262-8389-81a8d905d4e4"),
                    Title = "The Lord of the Rings: The Fellowship of the Ring",
                    ReleaseDate = new DateTime(2001, 4, 19),
                    CoverImageUrl = "https://taskformistral.blob.core.windows.net/mistral/TheLordoftheRingsTheFellowshipoftheRing.jpg",
                    Description = "A bounty hunting scam joins two men in an uneasy alliance against a third in a race to find a fortune in gold buried in a remote cemetery.",
                    TypeId = new Guid("7945162a-95e4-4fc8-8aad-1e99fbc850c0")
                },
                new MovieShow
                {
                    Id = new Guid("6654e2e5-7446-48c0-8522-bd9d7284cb7a"),
                    Title = "Fight Club",
                    ReleaseDate = new DateTime(1999, 1, 22),
                    CoverImageUrl = "https://taskformistral.blob.core.windows.net/mistral/FightClub.jpg",
                    Description = "A meek Hobbit from the Shire and eight companions set out on a journey to destroy the powerful One Ring and save Middle-earth from the Dark Lord Sauron.",
                    TypeId = new Guid("7945162a-95e4-4fc8-8aad-1e99fbc850c0")
                },
                new MovieShow
                {
                    Id = new Guid("b96c8fd6-bf44-4a57-b8fe-64a62a951655"),
                    Title = "Forrest Gump",
                    ReleaseDate = new DateTime(1994, 5, 26),
                    CoverImageUrl = "https://taskformistral.blob.core.windows.net/mistral/ForrestGump.jpg",
                    Description = "The presidencies of Kennedy and Johnson, the Vietnam War, the Watergate scandal and other historical events unfold from the perspective of an Alabama man with an IQ of 75, whose only desire is to be reunited with his childhood sweetheart.",
                    TypeId = new Guid("7945162a-95e4-4fc8-8aad-1e99fbc850c0")
                },
                new MovieShow
                {
                    Id = new Guid("d47d40dd-fd8c-48df-a766-7c9c2309f682"),
                    Title = "The Lord of the Rings: The Two Towers",
                    ReleaseDate = new DateTime(2002, 7, 27),
                    CoverImageUrl = "https://taskformistral.blob.core.windows.net/mistral/TheLordoftheRingsTheTwoTowers.jpg",
                    Description = "While Frodo and Sam edge closer to Mordor with the help of the shifty Gollum, the divided fellowship makes a stand against Sauron's new ally, Saruman, and his hordes of Isengard.",
                    TypeId = new Guid("7945162a-95e4-4fc8-8aad-1e99fbc850c0")
                },
                new MovieShow
                {
                    Id = new Guid("d482111e-da32-40a8-a69f-39c4b7fb7909"),
                    Title = "Planet Earth II",
                    Description = "Wildlife documentary series with David Attenborough, beginning with a look at the remote islands which offer sanctuary to some of the planet's rarest creatures, to the beauty of cities, which are home to humans, and animals.",
                    ReleaseDate = new DateTime(2016, 3, 3),
                    CoverImageUrl = "https://taskformistral.blob.core.windows.net/mistral/PlanetEarthII.jpg",
                    TypeId = new Guid("7945162a-95e4-4fc8-8aad-1e99fbc850c0")
                },
                new MovieShow
                {
                    Id = new Guid("f9815ea5-301c-4f6c-ac4a-6238b300d7a8"),
                    Title = "Planet Earth",
                    Description =
                        "Emmy Award-winning, 11 episodes, five years in the making, the most expensive nature documentary series ever commissioned by the BBC, and the first to be filmed in high definition.",
                    ReleaseDate = new DateTime(2006, 1, 3),
                    CoverImageUrl = "https://taskformistral.blob.core.windows.net/mistral/PlanetEarth.jpg",
                    TypeId = new Guid("a999e831-978f-49b6-8c1c-ff82bb3231f3")
                },
                new MovieShow
                {
                    Id = new Guid("2b9ee3c4-f5b1-4adf-948d-2a45c3378ecc"),
                    Title = "Band of Brothers",
                    Description = "The story of Easy Company of the U.S. Army 101st Airborne Division, and their mission in World War II Europe, from Operation Overlord, through V-J Day.",
                    ReleaseDate = new DateTime(2001, 4, 29),
                    CoverImageUrl = "https://taskformistral.blob.core.windows.net/mistral/BandofBrothers.jpg",
                    TypeId = new Guid("a999e831-978f-49b6-8c1c-ff82bb3231f3")
                },
                new MovieShow
                {
                    Id = new Guid("60f9b3bd-c044-4a3b-ae88-f61f104d2431"),
                    Title = "Breaking Bad",
                    Description = "A high school chemistry teacher diagnosed with inoperable lung cancer turns to manufacturing and selling methamphetamine in order to secure his family's future.",
                    ReleaseDate = new DateTime(2008, 6, 3),
                    CoverImageUrl = "https://taskformistral.blob.core.windows.net/mistral/BreakingBad.jpg",
                    TypeId = new Guid("a999e831-978f-49b6-8c1c-ff82bb3231f3")
                },
                new MovieShow
                {
                    Id = new Guid("3599f98a-553b-43ad-8f13-b0e2fb2a074f"),
                    Title = "Blue Planet II",
                    Description =
                        "David Attenborough returns to the world's oceans in this sequel to the acclaimed documentary filming rare and unusual creatures of the deep, as well as documenting the problems our oceans face.",
                    ReleaseDate = new DateTime(2017, 3, 3),
                    CoverImageUrl = "https://taskformistral.blob.core.windows.net/mistral/BluePlanetII.jpg",
                    TypeId = new Guid("a999e831-978f-49b6-8c1c-ff82bb3231f3")
                },
                new MovieShow
                {
                    Id = new Guid("a9e59dad-c473-49aa-a25b-f6a5cc3eac3c"),
                    Title = "The Wire",
                    Description = "The Baltimore drug scene, as seen through the eyes of drug dealers and law enforcement.",
                    ReleaseDate = new DateTime(2002, 8, 3),
                    CoverImageUrl = "https://taskformistral.blob.core.windows.net/mistral/theWire.jpeg",
                    TypeId = new Guid("a999e831-978f-49b6-8c1c-ff82bb3231f3")
                },
                new MovieShow
                {

                    Id = new Guid("5e47a903-c741-4c69-a946-576a62178499"),
                    Title = "Our Planet",
                    Description = "Documentary series focusing on the breadth of the diversity of habitats around the world, from the remote Arctic wilderness and mysterious deep oceans to the vast landscapes of Africa and diverse jungles of South America.",
                    ReleaseDate = new DateTime(2019, 8, 3),
                    CoverImageUrl = "https://taskformistral.blob.core.windows.net/mistral/OurPlanet.jpg",
                    TypeId = new Guid("a999e831-978f-49b6-8c1c-ff82bb3231f3")
                },
                new MovieShow
                {
                    Id = new Guid("00a2b97f-d0d8-4893-aea9-853dbf08919d"),
                    Title = "Cosmos",
                    Description = "An exploration of our discovery of the laws of nature and coordinates in space and time.",
                    ReleaseDate = new DateTime(2014, 6, 3),
                    CoverImageUrl = "https://taskformistral.blob.core.windows.net/mistral/Cosmos1980.jpg",
                    TypeId = new Guid("a999e831-978f-49b6-8c1c-ff82bb3231f3")
                },
                new MovieShow
                {
                    Id = new Guid("13e56c4e-44c5-4a6c-9c4a-575e0f9ae9c5"),
                    Title = "Cosmos",
                    Description = "Astronomer Carl Sagan leads us on an engaging guided tour of the various elements and cosmological theories of the universe.",
                    ReleaseDate = new DateTime(1980, 8, 3),
                    CoverImageUrl = "https://taskformistral.blob.core.windows.net/mistral/Cosmos1980.jpg",
                    TypeId = new Guid("a999e831-978f-49b6-8c1c-ff82bb3231f3")
                },
                new MovieShow
                {
                    Id = new Guid("461ebff3-59c6-4a46-b309-0775bf3f61ce"),
                    Title = "Avatar: The Last Airbender",
                    Description = "In a war-torn world of elemental magic, a young boy reawakens to undertake a dangerous mystic quest to fulfill his destiny as the Avatar, and bring peace to the world.",
                    ReleaseDate = new DateTime(2005, 12, 12),
                    CoverImageUrl = "https://taskformistral.blob.core.windows.net/mistral/AvatarTheLastAirbender.jpg",
                    TypeId = new Guid("a999e831-978f-49b6-8c1c-ff82bb3231f3")
                },
                new MovieShow
                {
                    Id = new Guid("34a59d35-558c-4183-99b9-0457652f8663"),
                    Title = "Game of Thrones",
                    Description = "Nine noble families fight for control over the lands of Westeros, while an ancient enemy returns after being dormant for millennia.",
                    ReleaseDate = new DateTime(2011, 4, 3),
                    CoverImageUrl = "https://taskformistral.blob.core.windows.net/mistral/GameofThrones.jpg",
                    TypeId = new Guid("a999e831-978f-49b6-8c1c-ff82bb3231f3")
                },
                new MovieShow
                {
                    Id = new Guid("30568f06-0d8f-4b4e-99a4-40f2e811f74d"),
                    Title = "Fight Club",
                    ReleaseDate = new DateTime(1999, 1, 22),
                    CoverImageUrl = "https://taskformistral.blob.core.windows.net/mistral/FightClub.jpg",
                    Description = "A meek Hobbit from the Shire and eight companions set out on a journey to destroy the powerful One Ring and save Middle-earth from the Dark Lord Sauron.",
                    TypeId = new Guid("a999e831-978f-49b6-8c1c-ff82bb3231f3")
                }
            );

            modelBuilder.Entity<Rating>().HasData(
               new Rating
               {
                   Id = new Guid("a0912ca9-95c6-41a4-b0de-576140d28ebd"),
                   MovieShowId = new Guid("1aee9219-d85d-424c-adf9-a504a1b1f698"),
                   Stars = 10
               },
               new Rating
               {
                   Id = new Guid("0409ecf4-eeae-4e95-8e95-b616b53a0906"),
                   MovieShowId = new Guid("1aee9219-d85d-424c-adf9-a504a1b1f698"),
                   Stars = 9
               },
               new Rating
               {
                   Id = new Guid("e670875d-a509-4044-9505-6ea9324ebaf4"),
                   MovieShowId = new Guid("1aee9219-d85d-424c-adf9-a504a1b1f698"),
                   Stars = 10
               },
               new Rating
               {
                   Id = new Guid("a08e5f84-b0ba-4feb-9f9d-7168670681ad"),
                   MovieShowId = new Guid("c2e8e0e4-d27a-4053-9510-51f3a14d3a1c"),
                   Stars = 9
               },
               new Rating
               {
                   Id = new Guid("c4528aa3-4d62-4726-b66e-14e914375350"),
                   MovieShowId = new Guid("c2e8e0e4-d27a-4053-9510-51f3a14d3a1c"),
                   Stars = 7
               }
           );

            modelBuilder.Entity<Cast>().HasData(
               new Cast
               {
                   Id = new Guid("3d5531dd-f2cc-4922-8f3c-8ca1918a294b")
               },
                new Cast
                {
                    Id = new Guid("c32c6133-977a-4a86-a95b-293861f58fd5")
                },
                new Cast
                {
                    Id = new Guid("907c9c63-ac99-4832-a28a-20291ebdec56")
                },
                new Cast
                {
                    Id = new Guid("4e9bbba5-cb2c-444e-83bc-fc10c8e8c8c4")
                },
                new Cast
                {
                    Id = new Guid("d964f7e3-5cb7-43c5-9b4d-4065dd0dcdcd")
                },
                new Cast
                {
                    Id = new Guid("7792a1fe-efc3-4dd6-80b6-31ffcd4d03ce")
                },
                new Cast
                {
                    Id = new Guid("a97998dd-bf9a-4ca7-85f2-c7456ca54794")
                },
                new Cast
                {
                    Id = new Guid("bc2b5e6f-4aaa-4998-af0f-6de2c8aa1ae9")
                },
                new Cast
                {
                    Id = new Guid("8f059533-25f4-4465-90b0-2ca13b6bb155")
                },
                new Cast
                {
                    Id = new Guid("271c2f40-0b27-4526-b8a4-00d77508865e")
                },
                new Cast
                {
                    Id = new Guid("71033605-948c-4cdd-af69-9f026440105d")
                },
                new Cast
                {
                    Id = new Guid("570c996a-bf38-4bee-b6bb-38ecae712770")
                },
                new Cast
                {
                    Id = new Guid("5ee2a634-9f8e-4f81-b7c3-a9107e865581")
                },
                new Cast
                {
                    Id = new Guid("d5dd94bd-ede9-45bf-9110-62717e8741ad")
                },
                new Cast
                {
                    Id = new Guid("c19e03dd-3e0f-4ddd-98b7-803661dd7571")
                },
                new Cast
                {
                    Id = new Guid("66c0cc53-4fb1-4766-8c16-71878631edfd")
                },
                new Cast
                {
                    Id = new Guid("c5b1985a-0172-401f-851d-adcbc3ec9a8c")
                },
                new Cast
                {
                    Id = new Guid("45712daf-7f0e-47a4-8116-d84268109177")
                },
                new Cast
                {
                    Id = new Guid("83d8c637-5f15-44cb-b85e-458e2a2c0456")
                },
                new Cast
                {
                    Id = new Guid("d2825a1a-651d-49b2-81d1-d0a0bc5d41bf")
                },
                new Cast
                {
                    Id = new Guid("f6d4319b-9e39-455e-824d-12dc96297d95")
                },
                new Cast
                {
                    Id = new Guid("af6d1289-7ad6-4a99-809a-60e22d4e0c06")
                },
                new Cast
                {
                    Id = new Guid("8cf034a8-3ff3-4266-b279-aa9f721fd9f2")
                },
                new Cast
                {
                    Id = new Guid("32504dad-86d8-4ae0-b44d-bbf2398901e7")
                },
                new Cast
                {
                    Id = new Guid("aa7dc370-8635-4f04-9d53-b729bf21627a")
                },
                new Cast
                {
                    Id = new Guid("2c81786e-bca7-4ee0-9bb1-634a5ed42899")
                },
                new Cast
                {
                    Id = new Guid("650904b3-9bf1-4b6f-afe0-f491a23cdd8a")
                }
            );

            modelBuilder.Entity<CastMovie>().HasData(
                new CastMovie
                {
                    Id = new Guid("f55f1898-3a6f-44ce-aee9-219dab718c3c"),
                    CastId = new Guid("3d5531dd-f2cc-4922-8f3c-8ca1918a294b"),
                    MovieShowId = new Guid("1aee9219-d85d-424c-adf9-a504a1b1f698")
                },
                new CastMovie
                {
                    Id = new Guid("200a9565-0135-41c9-9943-9c5adf40abf0"),
                    CastId = new Guid("c32c6133-977a-4a86-a95b-293861f58fd5"),
                    MovieShowId = new Guid("db03a785-ffbb-4599-9add-763ae9156d83")
                },
                new CastMovie
                {
                    Id = new Guid("b4462faf-1d7c-403a-9d93-c2bc6db50aad"),
                    CastId = new Guid("907c9c63-ac99-4832-a28a-20291ebdec56"),
                    MovieShowId = new Guid("1f921843-87da-476b-8dfb-4ab892977ba1")
                },
                new CastMovie
                {
                    Id = new Guid("13cd344a-fc86-4974-9924-ab91fff0fd79"),
                    CastId = new Guid("d964f7e3-5cb7-43c5-9b4d-4065dd0dcdcd"),
                    MovieShowId = new Guid("de0d2ad7-d56e-41c5-9dbd-23fec0f11fa2")
                },
                new CastMovie
                {
                    Id = new Guid("4db6c2ae-66ac-4700-aeae-38c179715b2d"),
                    CastId = new Guid("7792a1fe-efc3-4dd6-80b6-31ffcd4d03ce"),
                    MovieShowId = new Guid("1f37fef0-edd9-444c-920f-804d95a43fb8")
                },
                new CastMovie
                {
                    Id = new Guid("49cf59b0-9233-40a4-b693-de1c38e2522c"),
                    CastId = new Guid("a97998dd-bf9a-4ca7-85f2-c7456ca54794"),
                    MovieShowId = new Guid("15a5b405-4f7f-4a67-9899-eb52326860ba")
                },
                new CastMovie
                {
                    Id = new Guid("c5f9b948-7a86-4a76-8237-a7eee1ed8da8"),
                    CastId = new Guid("bc2b5e6f-4aaa-4998-af0f-6de2c8aa1ae9"),
                    MovieShowId = new Guid("a01b2cf7-9496-4bb5-80ba-d475723897a7")
                },
                new CastMovie
                {
                    Id = new Guid("870e522a-bef6-47fd-bf00-05ce6b7de7e4"),
                    CastId = new Guid("8f059533-25f4-4465-90b0-2ca13b6bb155"),
                    MovieShowId = new Guid("33f381f4-c54f-4e97-8ba5-9a1e27c9472c")
                },
                new CastMovie
                {
                    Id = new Guid("a654414c-61fa-4f78-aab0-fbec2bc09943"),
                    CastId = new Guid("271c2f40-0b27-4526-b8a4-00d77508865e"),
                    MovieShowId = new Guid("4d973b27-50a9-4262-8389-81a8d905d4e4")
                },
                new CastMovie
                {
                    Id = new Guid("0690e320-10dd-4588-9d09-d6f6445ad7c9"),
                    CastId = new Guid("71033605-948c-4cdd-af69-9f026440105d"),
                    MovieShowId = new Guid("6654e2e5-7446-48c0-8522-bd9d7284cb7a")
                },
                new CastMovie
                {
                    Id = new Guid("73060af6-648b-4e45-ab1f-c5532ddf4aab"),
                    CastId = new Guid("570c996a-bf38-4bee-b6bb-38ecae712770"),
                    MovieShowId = new Guid("b96c8fd6-bf44-4a57-b8fe-64a62a951655")
                },
                new CastMovie
                {
                    Id = new Guid("61286443-8e8f-47ff-9b78-08004ea81505"),
                    CastId = new Guid("d5dd94bd-ede9-45bf-9110-62717e8741ad"),
                    MovieShowId = new Guid("d47d40dd-fd8c-48df-a766-7c9c2309f682")
                }
            );

            modelBuilder.Entity<CastActor>().HasData(
                new CastActor
                {
                    Id = new Guid("ff32b3af-86d3-469a-85ec-672c1c35d9f7"),
                    CastId = new Guid("c32c6133-977a-4a86-a95b-293861f58fd5"),
                    ActorId = new Guid("8303949e-d1cb-4c82-9300-c6925009ffb3")
                },
                new CastActor
                {
                    Id = new Guid("42e7caab-53e9-4bfd-833b-e7fb500496c8"),
                    CastId = new Guid("907c9c63-ac99-4832-a28a-20291ebdec56"),
                    ActorId = new Guid("383be908-1dae-49e6-b2fb-c05afd7d0ecd")
                },
                new CastActor
                {
                    Id = new Guid("7a7f7be3-4180-4135-8e47-59db5c732bab"),
                    CastId = new Guid("907c9c63-ac99-4832-a28a-20291ebdec56"),
                    ActorId = new Guid("525684fc-a004-4cf3-b2c3-3a1fe3e4ddcc")
                },
                new CastActor
                {
                    Id = new Guid("4b2be462-483f-4461-9a86-da56cadde57c"),
                    CastId = new Guid("4e9bbba5-cb2c-444e-83bc-fc10c8e8c8c4"),
                    ActorId = new Guid("d4e4ec8b-fea7-4892-a372-c31081c163b6")
                },
                new CastActor
                {
                    Id = new Guid("5049774f-6377-4f4b-9504-ce8e8de3232a"),
                    CastId = new Guid("d964f7e3-5cb7-43c5-9b4d-4065dd0dcdcd"),
                    ActorId = new Guid("383be908-1dae-49e6-b2fb-c05afd7d0ecd")
                },
                new CastActor
                {
                    Id = new Guid("c104d562-dc9f-496d-b096-a367e7d6b3cc"),
                    CastId = new Guid("d964f7e3-5cb7-43c5-9b4d-4065dd0dcdcd"),
                    ActorId = new Guid("525684fc-a004-4cf3-b2c3-3a1fe3e4ddcc")
                },
                new CastActor
                {
                    Id = new Guid("8e054f5c-f4fa-4935-8dc8-5b1f99bfb595"),
                    CastId = new Guid("7792a1fe-efc3-4dd6-80b6-31ffcd4d03ce"),
                    ActorId = new Guid("d4e4ec8b-fea7-4892-a372-c31081c163b6")
                },
                new CastActor
                {
                    Id = new Guid("0d7fedf7-6ed3-4e0b-a27d-0a6d44609c29"),
                    CastId = new Guid("a97998dd-bf9a-4ca7-85f2-c7456ca54794"),
                    ActorId = new Guid("8303949e-d1cb-4c82-9300-c6925009ffb3")
                },
                new CastActor
                {
                    Id = new Guid("ed24b6ab-1ff2-426c-8762-36a4997b4e5e"),
                    CastId = new Guid("bc2b5e6f-4aaa-4998-af0f-6de2c8aa1ae9"),
                    ActorId = new Guid("525684fc-a004-4cf3-b2c3-3a1fe3e4ddcc")
                },
                new CastActor
                {
                    Id = new Guid("7196c793-950e-46a2-8332-a295017ce800"),
                    CastId = new Guid("bc2b5e6f-4aaa-4998-af0f-6de2c8aa1ae9"),
                    ActorId = new Guid("383be908-1dae-49e6-b2fb-c05afd7d0ecd")
                },
                new CastActor
                {
                    Id = new Guid("f64bd797-5acc-4c94-afcd-f2c16ede5f6c"),
                    CastId = new Guid("8f059533-25f4-4465-90b0-2ca13b6bb155"),
                    ActorId = new Guid("8303949e-d1cb-4c82-9300-c6925009ffb3")
                },
                new CastActor
                {
                    Id = new Guid("9d4e86cd-2ce3-4c36-9ed5-b154e790d6b8"),
                    CastId = new Guid("271c2f40-0b27-4526-b8a4-00d77508865e"),
                    ActorId = new Guid("383be908-1dae-49e6-b2fb-c05afd7d0ecd")
                },
                new CastActor
                {
                    Id = new Guid("e0ba1d15-30c4-426a-9a21-8e1693a02a94"),
                    CastId = new Guid("71033605-948c-4cdd-af69-9f026440105d"),
                    ActorId = new Guid("d4e4ec8b-fea7-4892-a372-c31081c163b6")
                },
                new CastActor
                {
                    Id = new Guid("a70e1e7a-6c78-4254-aa9e-5c257780b0e5"),
                    CastId = new Guid("570c996a-bf38-4bee-b6bb-38ecae712770"),
                    ActorId = new Guid("383be908-1dae-49e6-b2fb-c05afd7d0ecd")
                },
                new CastActor
                {
                    Id = new Guid("cf1f291a-ff8f-4adc-acf1-2b99d91f5eb2"),
                    CastId = new Guid("5ee2a634-9f8e-4f81-b7c3-a9107e865581"),
                    ActorId = new Guid("8303949e-d1cb-4c82-9300-c6925009ffb3")
                },
                new CastActor
                {
                    Id = new Guid("76f4d432-738c-42cc-a9ac-8b38dc8ed585"),
                    CastId = new Guid("d5dd94bd-ede9-45bf-9110-62717e8741ad"),
                    ActorId = new Guid("383be908-1dae-49e6-b2fb-c05afd7d0ecd")
                },
                new CastActor
                {
                    Id = new Guid("a4b9c47a-b530-4f6f-84af-7e7981085618"),
                    CastId = new Guid("c19e03dd-3e0f-4ddd-98b7-803661dd7571"),
                    ActorId = new Guid("8303949e-d1cb-4c82-9300-c6925009ffb3")
                },
                new CastActor
                {
                    Id = new Guid("198e0698-5965-4ee6-8a5a-8dffca9f514a"),
                    CastId = new Guid("c5b1985a-0172-401f-851d-adcbc3ec9a8c"),
                    ActorId = new Guid("383be908-1dae-49e6-b2fb-c05afd7d0ecd")
                },
                new CastActor
                {
                    Id = new Guid("77b6d180-8e8d-4f50-846d-174415ce2eee"),
                    CastId = new Guid("c5b1985a-0172-401f-851d-adcbc3ec9a8c"),
                    ActorId = new Guid("d4e4ec8b-fea7-4892-a372-c31081c163b6")
                },
                new CastActor
                {
                    Id = new Guid("c40ccfef-9b7e-4d79-859f-bc61c1e30e0f"),
                    CastId = new Guid("45712daf-7f0e-47a4-8116-d84268109177"),
                    ActorId = new Guid("8303949e-d1cb-4c82-9300-c6925009ffb3")
                },
                new CastActor
                {
                    Id = new Guid("ddd42203-0439-49fb-8ffa-e527c0478e41"),
                    CastId = new Guid("45712daf-7f0e-47a4-8116-d84268109177"),
                    ActorId = new Guid("525684fc-a004-4cf3-b2c3-3a1fe3e4ddcc")
                },
                new CastActor
                {
                    Id = new Guid("a2a1e81f-c63d-4e74-bbe1-1557533bea84"),
                    CastId = new Guid("83d8c637-5f15-44cb-b85e-458e2a2c0456"),
                    ActorId = new Guid("383be908-1dae-49e6-b2fb-c05afd7d0ecd")
                },
                new CastActor
                {
                    Id = new Guid("7ba4a07e-abc0-4e3d-8cf6-7f3a6564c657"),
                    CastId = new Guid("d2825a1a-651d-49b2-81d1-d0a0bc5d41bf"),
                    ActorId = new Guid("525684fc-a004-4cf3-b2c3-3a1fe3e4ddcc")
                },
                new CastActor
                {
                    Id = new Guid("1bfb8dd8-f700-4c69-8e4f-fc1dc8d76ca2"),
                    CastId = new Guid("f6d4319b-9e39-455e-824d-12dc96297d95"),
                    ActorId = new Guid("383be908-1dae-49e6-b2fb-c05afd7d0ecd")
                },
                new CastActor
                {
                    Id = new Guid("35a861fc-5328-4178-9299-3d19407ba451"),
                    CastId = new Guid("f6d4319b-9e39-455e-824d-12dc96297d95"),
                    ActorId = new Guid("d4e4ec8b-fea7-4892-a372-c31081c163b6")
                },
                new CastActor
                {
                    Id = new Guid("432bf952-a3f3-4174-96e1-4994969f219b"),
                    CastId = new Guid("af6d1289-7ad6-4a99-809a-60e22d4e0c06"),
                    ActorId = new Guid("8303949e-d1cb-4c82-9300-c6925009ffb3")
                },
                new CastActor
                {
                    Id = new Guid("c949749a-a7f1-4fa0-a616-330d9a4362d6"),
                    CastId = new Guid("af6d1289-7ad6-4a99-809a-60e22d4e0c06"),
                    ActorId = new Guid("525684fc-a004-4cf3-b2c3-3a1fe3e4ddcc")
                },
                new CastActor
                {
                    Id = new Guid("b40311b4-cee0-4df1-a8f4-bc6104369e52"),
                    CastId = new Guid("8cf034a8-3ff3-4266-b279-aa9f721fd9f2"),
                    ActorId = new Guid("d4e4ec8b-fea7-4892-a372-c31081c163b6")
                },
                new CastActor
                {
                    Id = new Guid("df600a1d-a9c4-4255-8076-ab9e225573e9"),
                    CastId = new Guid("32504dad-86d8-4ae0-b44d-bbf2398901e7"),
                    ActorId = new Guid("525684fc-a004-4cf3-b2c3-3a1fe3e4ddcc")
                },
                new CastActor
                {
                    Id = new Guid("d76f0119-dd08-437a-b018-f3ec8c2a52cc"),
                    CastId = new Guid("32504dad-86d8-4ae0-b44d-bbf2398901e7"),
                    ActorId = new Guid("383be908-1dae-49e6-b2fb-c05afd7d0ecd")
                },
                new CastActor
                {
                    Id = new Guid("cec6e9e5-94bb-49d5-bc85-ae050cfd8f2d"),
                    CastId = new Guid("2c81786e-bca7-4ee0-9bb1-634a5ed42899"),
                    ActorId = new Guid("8303949e-d1cb-4c82-9300-c6925009ffb3")
                },
                new CastActor
                {
                    Id = new Guid("1d6a882f-7d0a-4b93-ad87-d89807320db5"),
                    CastId = new Guid("2c81786e-bca7-4ee0-9bb1-634a5ed42899"),
                    ActorId = new Guid("383be908-1dae-49e6-b2fb-c05afd7d0ecd")
                },
                new CastActor
                {
                    Id = new Guid("08ab9542-30cd-4b17-8084-5a2e23ac3ca9"),
                    CastId = new Guid("650904b3-9bf1-4b6f-afe0-f491a23cdd8a"),
                    ActorId = new Guid("d4e4ec8b-fea7-4892-a372-c31081c163b6")
                }
            );
        }
    }
}