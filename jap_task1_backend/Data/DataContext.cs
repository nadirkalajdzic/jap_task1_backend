using jap_task1_backend.Models;
using jap_task1_backend.Services.AuthService;
using Microsoft.EntityFrameworkCore;
using System;

namespace jap_task1_backend.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Actor> Actors { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Rating> Ratings { get; set; }
        public DbSet<Video> Videos { get; set; }
        public DbSet<ActorVideo> ActorVideos { get; set; }
        public DbSet<CategoryVideo> CategoryVideos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Category static data
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "ACTION"},
                new Category { Id = 2, Name = "COMEDY" },
                new Category { Id = 3, Name = "THRILLER" },
                new Category { Id = 4, Name = "DRAMA" },
                new Category { Id = 5, Name = "TRAGEDY" },
                new Category { Id = 6, Name = "CRIME" },
                new Category { Id = 7, Name = "BIOGRAPHY" },
                new Category { Id = 8, Name = "ADVENTURE" },
                new Category { Id = 9, Name = "WESTERN" },
                new Category { Id = 10, Name = "BIOGRAPHY" },
                new Category { Id = 11, Name = "ROMANCE" },
                new Category { Id = 12, Name = "SCI-FI" },
                new Category { Id = 13, Name = "DOCUMENTARY" },
                new Category { Id = 14, Name = "HISTORY" },
                new Category { Id = 15, Name = "ANIMATION" }
            );
            #endregion

            #region Actor static data
            modelBuilder.Entity<Actor>().HasData(
                new Actor { Id = 1, Name = "Morgan", Surname= "Freeman" },
                new Actor { Id = 2, Name = "Bob", Surname = "Gunton" },
                new Actor { Id = 3, Name = "Tim", Surname = "Robbins" },
                new Actor { Id = 4, Name = "Marlon", Surname = "Brando" },
                new Actor { Id = 5, Name = "Al", Surname = "Pacino" },
                new Actor { Id = 6, Name = "James", Surname = "Caan" },
                new Actor { Id = 7, Name = "Robert", Surname = "De Niro" },
                new Actor { Id = 8, Name = "Robert", Surname = "Duvall" },
                new Actor { Id = 9, Name = "Christian", Surname = "Bale" },
                new Actor { Id = 10, Name = "Heath", Surname = "Ledger" },
                new Actor { Id = 11, Name = "Aaron", Surname = "Eckhart" },
                new Actor { Id = 12, Name = "Henry", Surname = "Fonda" },
                new Actor { Id = 13, Name = "Lee", Surname = "J. Cobb" },
                new Actor { Id = 14, Name = "Martin", Surname = "Balsam" },
                new Actor { Id = 15, Name = "Liam", Surname = "Neeson" },
                new Actor { Id = 16, Name = "Ralph", Surname = "Fiennes" },
                new Actor { Id = 17, Name = "Ben", Surname = "Kingsley" },
                new Actor { Id = 18, Name = "Elijah", Surname = "Wood" },
                new Actor { Id = 19, Name = "Viggo", Surname = "Mortensen" },
                new Actor { Id = 20, Name = "Ian", Surname = "McKellen" },
                new Actor { Id = 21, Name = "John", Surname = "Travolta" },
                new Actor { Id = 22, Name = "Uma", Surname = "Thurman" },
                new Actor { Id = 23, Name = "Samuel", Surname = "L. Jackson" },
                new Actor { Id = 24, Name = "Clint", Surname = "Eastwood" },
                new Actor { Id = 25, Name = "Eli", Surname = "Wallach" },
                new Actor { Id = 26, Name = "Lee", Surname = "Van Cleef" },
                new Actor { Id = 27, Name = "Orlando", Surname = "Bloom" },
                new Actor { Id = 28, Name = "Brad", Surname = "Pitt" },
                new Actor { Id = 29, Name = "Edward", Surname = "Norton" },
                new Actor { Id = 30, Name = "Meat", Surname = "Loaf" },
                new Actor { Id = 31, Name = "Tom", Surname = "Hanks" },
                new Actor { Id = 32, Name = "Robin", Surname = "Wright" },
                new Actor { Id = 33, Name = "Gary", Surname = "Sinise" },
                new Actor { Id = 34, Name = "Leonardo", Surname = "DiCaprio" },
                new Actor { Id = 35, Name = "Joseph", Surname = "Gordon-Levitt" },
                new Actor { Id = 36, Name = "Elliot", Surname = "Page" },
                new Actor { Id = 37, Name = "David", Surname = "Attenborough" },
                new Actor { Id = 38, Name = "Sigourney", Surname = "Weaver" },
                new Actor { Id = 39, Name = "Nikolay", Surname = "Drozdov" },
                new Actor { Id = 40, Name = "Bryan", Surname = "Cranston" },
                new Actor { Id = 41, Name = "Aaron", Surname = "Paul" },
                new Actor { Id = 42, Name = "Anna", Surname = "Gunn" },
                new Actor { Id = 43, Name = "Scott", Surname = "Grimes" },
                new Actor { Id = 44, Name = "Damian", Surname = "Lewis" },
                new Actor { Id = 45, Name = "Ron", Surname = "Livingston" },
                new Actor { Id = 46, Name = "Jessie", Surname = "Buckley" },
                new Actor { Id = 47, Name = "Jared", Surname = "Harris" },
                new Actor { Id = 48, Name = "Stellan", Surname = "Skarsgard" },
                new Actor { Id = 49, Name = "Jessie", Surname = "Buckley" },
                new Actor { Id = 50, Name = "Dominic", Surname = "West" },
                new Actor { Id = 51, Name = "Lance", Surname = "Reddick" },
                new Actor { Id = 52, Name = "Sonja", Surname = "Sohn" },
                new Actor { Id = 53, Name = "Peter", Surname = "Drost" },
                new Actor { Id = 54, Name = "Roger", Surname = "Horrocks" },
                new Actor { Id = 55, Name = "Neil", Surname = "deGrasse Tyson" },
                new Actor { Id = 56, Name = "Stoney", Surname = "Emshwiller" },
                new Actor { Id = 57, Name = "Piotr", Surname = "Michael" },
                new Actor { Id = 58, Name = "Neil", Surname = "deGrasse Tyson" },
                new Actor { Id = 59, Name = "Dee", Surname = "Bradley Baker" },
                new Actor { Id = 60, Name = "Zach", Surname = "Tyler" },
                new Actor { Id = 61, Name = "Mae", Surname = "Whitman" },
                new Actor { Id = 62, Name = "Carl", Surname = "Sagan" },
                new Actor { Id = 63, Name = "Jaromir", Surname = "Hanzlik" },
                new Actor { Id = 64, Name = "Jonathan", Surname = "Fahn" },
                new Actor { Id = 65, Name = "Emilia", Surname = "Clarke" },
                new Actor { Id = 66, Name = "Peter", Surname = "Dinklage" },
                new Actor { Id = 67, Name = "Kit", Surname = "Harington" },
                new Actor { Id = 68, Name = "James", Surname = "Gandolfini" },
                new Actor { Id = 69, Name = "Lorraine", Surname = "Bracco" },
                new Actor { Id = 70, Name = "Eddie", Surname = "Falco" }
            );
            #endregion

            #region Movies and Series static data
            modelBuilder.Entity<Video>().HasData(
                //movies
                new Video 
                { 
                    Id = 1, Title = "The Shawshank Redemption",
                    Description = "Two imprisoned men bond over a number of years, finding solace and eventual redemption through acts of common decency.", 
                    Image_Url= "https://swank.azureedge.net/swank/prod-film/3560cd8a-9491-4ab9-876c-8a8d6b84a6dd/f8e7c904-669a-4c9f-ac29-d19b64b43e33/one-sheet.jpg?width=335&height=508&mode=crop", 
                    Type=0, 
                    ReleaseDate=new DateTime(1994, 9, 22) 
                },
                new Video
                {
                    Id = 2,
                    Title = "The Godfather",
                    Description = "An organized crime dynasty's aging patriarch transfers control of his clandestine empire to his reluctant son.",
                    Image_Url = "https://www.reelviews.net/resources/img/posters/thumbs/godfather_poster.jpg",
                    Type = 0,
                    ReleaseDate = new DateTime(1972, 3, 24)
                },
                new Video
                {
                    Id = 3,
                    Title = "The Godfather: Part II",
                    Description = "The early life and career of Vito Corleone in 1920s New York City is portrayed, while his son, Michael, expands and tightens his grip on the family crime syndicate.",
                    Image_Url = "https://shotonwhat.com/images/0071562-med.jpg",
                    Type = 0,
                    ReleaseDate = new DateTime(1974, 12, 20)
                },
                new Video
                {
                    Id = 4,
                    Title = "The Dark Knight",
                    Description = "When the menace known as the Joker wreaks havoc and chaos on the people of Gotham, Batman must accept one of the greatest psychological and physical tests of his ability to fight injustice.",
                    Image_Url = "https://upload.wikimedia.org/wikipedia/sh/8/83/Dark_knight_rises_poster.jpg",
                    Type = 0,
                    ReleaseDate = new DateTime(2008, 7, 18)
                },
                new Video
                {
                    Id = 5,
                    Title = "12 Angry Men",
                    Description = "A jury holdout attempts to prevent a miscarriage of justice by forcing his colleagues to reconsider the evidence.",
                    Image_Url = "https://upload.wikimedia.org/wikipedia/commons/b/b5/12_Angry_Men_%281957_film_poster%29.jpg",
                    Type = 0,
                    ReleaseDate = new DateTime(1957, 4, 1)
                },
                new Video
                {
                    Id = 6,
                    Title = "Schindler's List",
                    Description = "In German-occupied Poland during World War II, industrialist Oskar Schindler gradually becomes concerned for his Jewish workforce after witnessing their persecution by the Nazis.",
                    Image_Url = "https://mir-s3-cdn-cf.behance.net/project_modules/max_1200/c617e634647543.56d846b10d56f.jpg",
                    Type = 0,
                    ReleaseDate = new DateTime(1994, 2, 4)
                },
                new Video
                {
                    Id = 7,
                    Title = "The Lord of the Rings: The Return of the King",
                    Description = "Gandalf and Aragorn lead the World of Men against Sauron's army to draw his gaze from Frodo and Sam as they approach Mount Doom with the One Ring.",
                    Image_Url = "https://img.discogs.com/MsgjJVAxVCXb1w86ffIbaNRr2BY=/fit-in/600x600/filters:strip_icc():format(jpeg):mode_rgb():quality(90)/discogs-images/R-728620-1512923411-4779.jpeg.jpg",
                    Type = 0,
                    ReleaseDate = new DateTime(2003, 12, 1)
                },
                new Video
                {
                    Id = 8,
                    Title = "Pulp Fiction",
                    Description = "The lives of two mob hitmen, a boxer, a gangster and his wife, and a pair of diner bandits intertwine in four tales of violence and redemption.",
                    Image_Url = "https://prod.miramax.digital/media/assets/Pulp-Fiction1.png",
                    Type = 0,
                    ReleaseDate = new DateTime(1994, 10, 14)
                },
                new Video
                {
                    Id = 9,
                    Title = "The Good, the Bad and the Ugly",
                    Description = "A bounty hunting scam joins two men in an uneasy alliance against a third in a race to find a fortune in gold buried in a remote cemetery.",
                    Image_Url = "https://upload.wikimedia.org/wikipedia/en/4/45/Good_the_bad_and_the_ugly_poster.jpg",
                    Type = 0,
                    ReleaseDate = new DateTime(1996, 12, 23)
                },
                new Video
                {
                    Id = 10,
                    Title = "The Lord of the Rings: The Fellowship of the Ring",
                    Description = "A meek Hobbit from the Shire and eight companions set out on a journey to destroy the powerful One Ring and save Middle-earth from the Dark Lord Sauron.",
                    Image_Url = "https://images.moviesanywhere.com/198e228b071c60f5ad57e5f62fe60029/ff22cad6-2218-414d-b853-3f95d76905c7.jpg?h=375&resize=fit&w=250",
                    Type = 0,
                    ReleaseDate = new DateTime(2001, 12, 19)
                },
                new Video
                {
                    Id = 11,
                    Title = "Fight Club",
                    Description = "An insomniac office worker and a devil-may-care soap maker form an underground fight club that evolves into much more.",
                    Image_Url = "https://m.media-amazon.com/images/I/51v5ZpFyaFL._AC_.jpg",
                    Type = 0,
                    ReleaseDate = new DateTime(1999, 11, 11)
                },
                new Video
                {
                    Id = 12,
                    Title = "Forrest Gump",
                    Description = "The presidencies of Kennedy and Johnson, the Vietnam War, the Watergate scandal and other historical events unfold from the perspective of an Alabama man with an IQ of 75, whose only desire is to be reunited with his childhood sweetheart.",
                    Image_Url = "https://mir-s3-cdn-cf.behance.net/project_modules/max_1200/37a5b434647543.56d846b10ca45.jpg",
                    Type = 0,
                    ReleaseDate = new DateTime(1994, 7, 6)
                },
                new Video
                {
                    Id = 13,
                    Title = "Inception",
                    Description = "A thief who steals corporate secrets through the use of dream-sharing technology is given the inverse task of planting an idea into the mind of a C.E.O.",
                    Image_Url = "https://m.media-amazon.com/images/I/81p+xe8cbnL._SY445_.jpg",
                    Type = 0,
                    ReleaseDate = new DateTime(2010, 7, 22)
                },

                // series
                new Video
                {
                    Id = 14,
                    Title = "Planet Earth II",
                    Description = "Wildlife documentary series with David Attenborough, beginning with a look at the remote islands which offer sanctuary to some of the planet's rarest creatures, to the beauty of cities, which are home to humans, and animals..",
                    Image_Url = "https://blackwells.co.uk/jacket/l/9781785943041.jpg",
                    Type = 1,
                    ReleaseDate = new DateTime(2016, 11, 6)
                },
                new Video
                {
                    Id = 15,
                    Title = "Planet Earth",
                    Description = "Emmy Award-winning, 11 episodes, five years in the making, the most expensive nature documentary series ever commissioned by the BBC, and the first to be filmed in high definition.",
                    Image_Url = "https://m.media-amazon.com/images/I/91X9p6+58KL._SY445_.jpg",
                    Type = 1,
                    ReleaseDate = new DateTime(2010, 4, 5)
                },
                new Video
                {
                    Id = 16,
                    Title = "Breaking Bad",
                    Description = "A high school chemistry teacher diagnosed with inoperable lung cancer turns to manufacturing and selling methamphetamine in order to secure his family's future.",
                    Image_Url = "https://www.themoviedb.org/t/p/w600_and_h900_bestv2/ggFHVNu6YYI5L9pCfOacjizRGt.jpg",
                    Type = 1,
                    ReleaseDate = new DateTime(2008, 1, 20)
                },
                new Video
                {
                    Id = 17,
                    Title = "Band of Brothers",
                    Description = "The story of Easy Company of the U.S. Army 101st Airborne Division and their mission in World War II Europe, from Operation Overlord to V-J Day.",
                    Image_Url = "http://www.impawards.com/tv/posters/band_of_brothers_ver4.jpg",
                    Type = 1,
                    ReleaseDate = new DateTime(2001, 9, 9)
                },
                new Video
                {
                    Id = 18,
                    Title = "Chernobyl",
                    Description = "In April 1986, an explosion at the Chernobyl nuclear power plant in the Union of Soviet Socialist Republics becomes one of the world's worst man-made catastrophes.",
                    Image_Url = "https://i.redd.it/bv5isr69yr531.png",
                    Type = 1,
                    ReleaseDate = new DateTime(1986, 4, 26)
                },
                new Video
                {
                    Id = 19,
                    Title = "The Wire",
                    Description = "The Baltimore drug scene, as seen through the eyes of drug dealers and law enforcement.",
                    Image_Url = "https://tvshows.today/wp-content/uploads/the-wire-season-1-poster.jpg",
                    Type = 1,
                    ReleaseDate = new DateTime(2008, 4, 9)
                },
                new Video
                {
                    Id = 20,
                    Title = "Blue Planet II",
                    Description = "David Attenborough returns to the world's oceans in this sequel to the acclaimed documentary filming rare and unusual creatures of the deep, as well as documenting the problems our oceans face.",
                    Image_Url = "https://cdn.shopify.com/s/files/1/0747/3829/products/mL1006_1024x1024.jpg?v=1571445246",
                    Type = 1,
                    ReleaseDate = new DateTime(2017, 10, 29)
                },
                new Video
                {
                    Id = 21,
                    Title = "Our Planet",
                    Description = "Documentary series focusing on the breadth of the diversity of habitats around the world, from the remote Arctic wilderness and mysterious deep oceans to the vast landscapes of Africa and diverse jungles of South America.",
                    Image_Url = "https://www.penguin.co.uk/content/dam/prh/books/111/1115210/9780593079768.jpg.transform/PRHDesktopWide_small/image.jpg",
                    Type = 1,
                    ReleaseDate = new DateTime(2019, 4, 5)
                },
                new Video
                {
                    Id = 22,
                    Title = "Cosmos: A Spacetime Odyssey",
                    Description = "An exploration of our discovery of the laws of nature and coordinates in space and time.",
                    Image_Url = "https://pisces.bbystatic.com/image2/BestBuy_US/images/products/5945/5945188_sa.jpg;maxHeight=640;maxWidth=550",
                    Type = 1,
                    ReleaseDate = new DateTime(2014, 4, 9)
                },
                new Video
                {
                    Id = 23,
                    Title = "Avatar: The Last Airbender",
                    Description = "In a war-torn world of elemental magic, a young boy reawakens to undertake a dangerous mystic quest to fulfill his destiny as the Avatar, and bring peace to the world.",
                    Image_Url = "https://images-na.ssl-images-amazon.com/images/I/914eUC4XPML.jpg",
                    Type = 1,
                    ReleaseDate = new DateTime(2005, 2, 21)
                },
                new Video
                {
                    Id = 24,
                    Title = "Cosmos",
                    Description = "Astronomer Carl Sagan leads us on an engaging guided tour of the various elements and cosmological theories of the universe.",
                    Image_Url = "https://www.themoviedb.org/t/p/original/4WJ9kNejI8apl3f8hMNwo8V3hGT.jpg",
                    Type = 1,
                    ReleaseDate = new DateTime(1980, 12, 21)
                },
                new Video
                {
                    Id = 25,
                    Title = "Game of Thrones",
                    Description = "Nine noble families fight for control over the lands of Westeros, while an ancient enemy returns after being dormant for millennia.",
                    Image_Url = "https://m.media-amazon.com/images/M/MV5BYTRiNDQwYzAtMzVlZS00NTI5LWJjYjUtMzkwNTUzMWMxZTllXkEyXkFqcGdeQXVyNDIzMzcwNjc@._V1_FMjpg_UX1000_.jpg",
                    Type = 1,
                    ReleaseDate = new DateTime(2011, 4, 17)
                },
                new Video
                {
                    Id = 26,
                    Title = "The Sopranos",
                    Description = "New Jersey mob boss Tony Soprano deals with personal and professional issues in his home and business life that affect his mental state, leading him to seek professional psychiatric counseling.",
                    Image_Url = "https://m.media-amazon.com/images/M/MV5BZGJjYzhjYTYtMDBjYy00OWU1LTg5OTYtNmYwOTZmZjE3ZDdhXkEyXkFqcGdeQXVyNTAyODkwOQ@@._V1_FMjpg_UX1000_.jpg",
                    Type = 1,
                    ReleaseDate = new DateTime(1999, 1, 10)
                }
            );
            #endregion

            #region Actor and Video relation
            modelBuilder.Entity<ActorVideo>().HasData(
                new ActorVideo { Id = 1, ActorId = 1, VideoId = 1 },
                new ActorVideo { Id = 2, ActorId = 2, VideoId = 1 },
                new ActorVideo { Id = 3, ActorId = 3, VideoId = 1 },
                new ActorVideo { Id = 4, ActorId = 4, VideoId = 2 },
                new ActorVideo { Id = 5, ActorId = 5, VideoId = 2 },
                new ActorVideo { Id = 6, ActorId = 6, VideoId = 2 },
                new ActorVideo { Id = 7, ActorId = 5, VideoId = 3 },
                new ActorVideo { Id = 8, ActorId = 7, VideoId = 3 },
                new ActorVideo { Id = 9, ActorId = 8, VideoId = 3 },
                new ActorVideo { Id = 10, ActorId = 9, VideoId = 4 },
                new ActorVideo { Id = 11, ActorId = 10, VideoId = 4 },
                new ActorVideo { Id = 12, ActorId = 11, VideoId = 4 },
                new ActorVideo { Id = 13, ActorId = 12, VideoId = 5 },
                new ActorVideo { Id = 14, ActorId = 13, VideoId = 5 },
                new ActorVideo { Id = 15, ActorId = 14, VideoId = 5 },
                new ActorVideo { Id = 16, ActorId = 15, VideoId = 6 },
                new ActorVideo { Id = 17, ActorId = 16, VideoId = 6 },
                new ActorVideo { Id = 18, ActorId = 17, VideoId = 6 },
                new ActorVideo { Id = 19, ActorId = 18, VideoId = 7 },
                new ActorVideo { Id = 20, ActorId = 19, VideoId = 7 },
                new ActorVideo { Id = 21, ActorId = 20, VideoId = 7 },
                new ActorVideo { Id = 22, ActorId = 21, VideoId = 8 },
                new ActorVideo { Id = 23, ActorId = 22, VideoId = 8 },
                new ActorVideo { Id = 24, ActorId = 23, VideoId = 8 },
                new ActorVideo { Id = 25, ActorId = 24, VideoId = 9 },
                new ActorVideo { Id = 26, ActorId = 25, VideoId = 9 },
                new ActorVideo { Id = 27, ActorId = 26, VideoId = 9 },
                new ActorVideo { Id = 28, ActorId = 18, VideoId = 10 },
                new ActorVideo { Id = 29, ActorId = 20, VideoId = 10 },
                new ActorVideo { Id = 30, ActorId = 27, VideoId = 10 },
                new ActorVideo { Id = 31, ActorId = 28, VideoId = 11 },
                new ActorVideo { Id = 32, ActorId = 29, VideoId = 11 },
                new ActorVideo { Id = 33, ActorId = 30, VideoId = 11 },
                new ActorVideo { Id = 34, ActorId = 31, VideoId = 12 },
                new ActorVideo { Id = 35, ActorId = 32, VideoId = 12 },
                new ActorVideo { Id = 36, ActorId = 33, VideoId = 12 },
                new ActorVideo { Id = 37, ActorId = 34, VideoId = 13 },
                new ActorVideo { Id = 38, ActorId = 35, VideoId = 13 },
                new ActorVideo { Id = 39, ActorId = 36, VideoId = 13 },
                new ActorVideo { Id = 40, ActorId = 37, VideoId = 14 },
                new ActorVideo { Id = 41, ActorId = 37, VideoId = 15 },
                new ActorVideo { Id = 42, ActorId = 38, VideoId = 15 },
                new ActorVideo { Id = 43, ActorId = 39, VideoId = 15 },
                new ActorVideo { Id = 44, ActorId = 40, VideoId = 16 },
                new ActorVideo { Id = 45, ActorId = 41, VideoId = 16 },
                new ActorVideo { Id = 46, ActorId = 42, VideoId = 16 },
                new ActorVideo { Id = 47, ActorId = 43, VideoId = 17 },
                new ActorVideo { Id = 48, ActorId = 44, VideoId = 17 },
                new ActorVideo { Id = 49, ActorId = 45, VideoId = 17 },
                new ActorVideo { Id = 50, ActorId = 46, VideoId = 18 },
                new ActorVideo { Id = 51, ActorId = 47, VideoId = 18 },
                new ActorVideo { Id = 52, ActorId = 48, VideoId = 18 },
                new ActorVideo { Id = 53, ActorId = 50, VideoId = 19 },
                new ActorVideo { Id = 54, ActorId = 51, VideoId = 19 },
                new ActorVideo { Id = 55, ActorId = 52, VideoId = 19 },
                new ActorVideo { Id = 56, ActorId = 37, VideoId = 20 },
                new ActorVideo { Id = 57, ActorId = 53, VideoId = 20 },
                new ActorVideo { Id = 58, ActorId = 54, VideoId = 20 },
                new ActorVideo { Id = 59, ActorId = 37, VideoId = 21 },
                new ActorVideo { Id = 60, ActorId = 56, VideoId = 22 },
                new ActorVideo { Id = 61, ActorId = 57, VideoId = 22 },
                new ActorVideo { Id = 62, ActorId = 58, VideoId = 22 },
                new ActorVideo { Id = 63, ActorId = 59, VideoId = 23 },
                new ActorVideo { Id = 64, ActorId = 60, VideoId = 23 },
                new ActorVideo { Id = 65, ActorId = 61, VideoId = 23 },
                new ActorVideo { Id = 66, ActorId = 62, VideoId = 24 },
                new ActorVideo { Id = 67, ActorId = 63, VideoId = 24 },
                new ActorVideo { Id = 68, ActorId = 64, VideoId = 24 },
                new ActorVideo { Id = 69, ActorId = 65, VideoId = 25 },
                new ActorVideo { Id = 70, ActorId = 66, VideoId = 25 },
                new ActorVideo { Id = 71, ActorId = 67, VideoId = 25 },
                new ActorVideo { Id = 72, ActorId = 68, VideoId = 26 },
                new ActorVideo { Id = 73, ActorId = 69, VideoId = 26 },
                new ActorVideo { Id = 74, ActorId = 70, VideoId = 26 }

            );
            #endregion

            #region Category and Video relation
            modelBuilder.Entity<CategoryVideo>().HasData(
                new CategoryVideo { Id = 1, CategoryId = 4, VideoId = 1 },
                new CategoryVideo { Id = 2, CategoryId = 6, VideoId = 2 },
                new CategoryVideo { Id = 3, CategoryId = 4, VideoId = 2 },
                new CategoryVideo { Id = 4, CategoryId = 4, VideoId = 3 },
                new CategoryVideo { Id = 5, CategoryId = 6, VideoId = 3 },
                new CategoryVideo { Id = 6, CategoryId = 4, VideoId = 4 },
                new CategoryVideo { Id = 7, CategoryId = 6, VideoId = 4 },
                new CategoryVideo { Id = 8, CategoryId = 1, VideoId = 4 },
                new CategoryVideo { Id = 9, CategoryId = 4, VideoId = 5 },
                new CategoryVideo { Id = 10, CategoryId = 6, VideoId = 5 },
                new CategoryVideo { Id = 11, CategoryId = 4, VideoId = 6 },
                new CategoryVideo { Id = 12, CategoryId = 7, VideoId = 6 },
                new CategoryVideo { Id = 13, CategoryId = 14, VideoId = 6 },
                new CategoryVideo { Id = 14, CategoryId = 4, VideoId = 7 },
                new CategoryVideo { Id = 15, CategoryId = 8, VideoId = 7 },
                new CategoryVideo { Id = 16, CategoryId = 1, VideoId = 7 },
                new CategoryVideo { Id = 17, CategoryId = 4, VideoId = 8 },
                new CategoryVideo { Id = 18, CategoryId = 6, VideoId = 8 },
                new CategoryVideo { Id = 19, CategoryId = 9, VideoId = 9 },
                new CategoryVideo { Id = 20, CategoryId = 4, VideoId = 10 },
                new CategoryVideo { Id = 21, CategoryId = 8, VideoId = 10 },
                new CategoryVideo { Id = 22, CategoryId = 1, VideoId = 10 },
                new CategoryVideo { Id = 23, CategoryId = 4, VideoId = 11 },
                new CategoryVideo { Id = 24, CategoryId = 4, VideoId = 12 },
                new CategoryVideo { Id = 25, CategoryId = 4, VideoId = 13 },
                new CategoryVideo { Id = 26, CategoryId = 11, VideoId = 13 },
                new CategoryVideo { Id = 27, CategoryId = 13, VideoId = 14 },
                new CategoryVideo { Id = 28, CategoryId = 13, VideoId = 15 },
                new CategoryVideo { Id = 29, CategoryId = 4, VideoId = 16 },
                new CategoryVideo { Id = 30, CategoryId = 6, VideoId = 16 },
                new CategoryVideo { Id = 31, CategoryId = 3, VideoId = 16 },
                new CategoryVideo { Id = 32, CategoryId = 4, VideoId = 17 },
                new CategoryVideo { Id = 33, CategoryId = 1, VideoId = 17 },
                new CategoryVideo { Id = 34, CategoryId = 14, VideoId = 17 },
                new CategoryVideo { Id = 35, CategoryId = 4, VideoId = 18 },
                new CategoryVideo { Id = 36, CategoryId = 14, VideoId = 18 },
                new CategoryVideo { Id = 37, CategoryId = 3, VideoId = 18 },
                new CategoryVideo { Id = 38, CategoryId = 4, VideoId = 19 },
                new CategoryVideo { Id = 39, CategoryId = 6, VideoId = 19 },
                new CategoryVideo { Id = 40, CategoryId = 3, VideoId = 19 },
                new CategoryVideo { Id = 41, CategoryId = 13, VideoId = 20 },
                new CategoryVideo { Id = 42, CategoryId = 13, VideoId = 21 },
                new CategoryVideo { Id = 43, CategoryId = 13, VideoId = 22 },
                new CategoryVideo { Id = 44, CategoryId = 15, VideoId = 23 },
                new CategoryVideo { Id = 45, CategoryId = 1, VideoId = 23 },
                new CategoryVideo { Id = 46, CategoryId = 8, VideoId = 23 },
                new CategoryVideo { Id = 47, CategoryId = 13, VideoId = 24 },
                new CategoryVideo { Id = 48, CategoryId = 1, VideoId = 25 },
                new CategoryVideo { Id = 49, CategoryId = 8, VideoId = 25 },
                new CategoryVideo { Id = 50, CategoryId = 4, VideoId = 25 },
                new CategoryVideo { Id = 51, CategoryId = 4, VideoId = 26 },
                new CategoryVideo { Id = 52, CategoryId = 6, VideoId = 26 }
            );
            #endregion

            #region Admin user
            AuthService.CreatePasswordHash("admin", out byte[] passHash, out byte[] passSalt);
            modelBuilder.Entity<User>().HasData(
                new User { Id = 1, Name = "Admin", Surname="Admin", Email="admin@gmail.com",  Salt = passSalt, Hash= passHash}
                
            );
            #endregion

            #region Ratings
            modelBuilder.Entity<Rating>().HasData(
                new Rating { Id = 1, Value = 4.6, VideoId = 1, UserId = 1 },
                new Rating { Id = 2, Value = 4.5, VideoId = 2, UserId = 1 },
                new Rating { Id = 3, Value = 4.5, VideoId = 3, UserId = 1 },
                new Rating { Id = 4, Value = 4.5, VideoId = 4, UserId = 1 },
                new Rating { Id = 5, Value = 4.4, VideoId = 5, UserId = 1 },
                new Rating { Id = 6, Value = 4.35, VideoId = 6, UserId = 1 },
                new Rating { Id = 7, Value = 4.3, VideoId = 7, UserId = 1 },
                new Rating { Id = 8, Value = 4.2, VideoId = 8, UserId = 1 },
                new Rating { Id = 9, Value = 4.2, VideoId = 9, UserId = 1 },
                new Rating { Id = 10, Value = 4.2, VideoId = 10, UserId = 1 },
                new Rating { Id = 11, Value = 4.2, VideoId = 11, UserId = 1 },
                new Rating { Id = 12, Value = 4.1, VideoId = 12, UserId = 1 },
                new Rating { Id = 13, Value = 4.1, VideoId = 13, UserId = 1 },
                new Rating { Id = 14, Value = 4.7, VideoId = 14, UserId = 1 },
                new Rating { Id = 15, Value = 4.6, VideoId = 15, UserId = 1 },
                new Rating { Id = 16, Value = 4.6, VideoId = 16, UserId = 1 },
                new Rating { Id = 17, Value = 4.6, VideoId = 17, UserId = 1 },
                new Rating { Id = 18, Value = 4.5, VideoId = 18, UserId = 1 },
                new Rating { Id = 19, Value = 4.4, VideoId = 19, UserId = 1 },
                new Rating { Id = 20, Value = 4.3, VideoId = 20, UserId = 1 },
                new Rating { Id = 21, Value = 4.2, VideoId = 21, UserId = 1 },
                new Rating { Id = 22, Value = 4.1, VideoId = 22, UserId = 1 },
                new Rating { Id = 23, Value = 4.1, VideoId = 23, UserId = 1 },
                new Rating { Id = 24, Value = 4.1, VideoId = 24, UserId = 1 },
                new Rating { Id = 25, Value = 4, VideoId = 25, UserId = 1 },
                new Rating { Id = 26, Value = 3.9, VideoId = 26, UserId = 1 }
            );
            #endregion
        }
    }
}
