using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace jap_task1_backend.Migrations
{
    public partial class InitialMigrate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Actors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Actors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Salt = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    Hash = table.Column<byte[]>(type: "varbinary(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Videos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image_Url = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Type = table.Column<short>(type: "smallint", nullable: false),
                    ReleaseDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Videos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ActorVideos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ActorId = table.Column<int>(type: "int", nullable: false),
                    VideoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActorVideos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ActorVideos_Actors_ActorId",
                        column: x => x.ActorId,
                        principalTable: "Actors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ActorVideos_Videos_VideoId",
                        column: x => x.VideoId,
                        principalTable: "Videos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CategoryVideos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    VideoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryVideos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CategoryVideos_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CategoryVideos_Videos_VideoId",
                        column: x => x.VideoId,
                        principalTable: "Videos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ratings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Value = table.Column<double>(type: "float", nullable: false),
                    VideoId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ratings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ratings_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ratings_Videos_VideoId",
                        column: x => x.VideoId,
                        principalTable: "Videos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Actors",
                columns: new[] { "Id", "Name", "Surname" },
                values: new object[,]
                {
                    { 1, "Morgan", "Freeman" },
                    { 51, "Lance", "Reddick" },
                    { 50, "Dominic", "West" },
                    { 49, "Jessie", "Buckley" },
                    { 48, "Stellan", "Skarsgard" },
                    { 47, "Jared", "Harris" },
                    { 46, "Jessie", "Buckley" },
                    { 52, "Sonja", "Sohn" },
                    { 45, "Ron", "Livingston" },
                    { 43, "Scott", "Grimes" },
                    { 42, "Anna", "Gunn" },
                    { 41, "Aaron", "Paul" },
                    { 40, "Bryan", "Cranston" },
                    { 39, "Nikolay", "Drozdov" },
                    { 38, "Sigourney", "Weaver" },
                    { 44, "Damian", "Lewis" },
                    { 37, "David", "Attenborough" },
                    { 53, "Peter", "Drost" },
                    { 55, "Neil", "deGrasse Tyson" },
                    { 70, "Eddie", "Falco" },
                    { 69, "Lorraine", "Bracco" },
                    { 68, "James", "Gandolfini" },
                    { 67, "Kit", "Harington" },
                    { 66, "Peter", "Dinklage" },
                    { 65, "Emilia", "Clarke" },
                    { 54, "Roger", "Horrocks" },
                    { 64, "Jonathan", "Fahn" },
                    { 62, "Carl", "Sagan" },
                    { 61, "Mae", "Whitman" },
                    { 60, "Zach", "Tyler" },
                    { 59, "Dee", "Bradley Baker" },
                    { 58, "Neil", "deGrasse Tyson" },
                    { 57, "Piotr", "Michael" },
                    { 63, "Jaromir", "Hanzlik" },
                    { 36, "Elliot", "Page" },
                    { 56, "Stoney", "Emshwiller" },
                    { 34, "Leonardo", "DiCaprio" },
                    { 14, "Martin", "Balsam" },
                    { 13, "Lee", "J. Cobb" },
                    { 12, "Henry", "Fonda" },
                    { 11, "Aaron", "Eckhart" },
                    { 10, "Heath", "Ledger" }
                });

            migrationBuilder.InsertData(
                table: "Actors",
                columns: new[] { "Id", "Name", "Surname" },
                values: new object[,]
                {
                    { 9, "Christian", "Bale" },
                    { 16, "Ralph", "Fiennes" },
                    { 8, "Robert", "Duvall" },
                    { 6, "James", "Caan" },
                    { 5, "Al", "Pacino" },
                    { 4, "Marlon", "Brando" },
                    { 3, "Tim", "Robbins" },
                    { 2, "Bob", "Gunton" },
                    { 35, "Joseph", "Gordon-Levitt" },
                    { 7, "Robert", "De Niro" },
                    { 17, "Ben", "Kingsley" },
                    { 15, "Liam", "Neeson" },
                    { 19, "Viggo", "Mortensen" },
                    { 33, "Gary", "Sinise" },
                    { 32, "Robin", "Wright" },
                    { 31, "Tom", "Hanks" },
                    { 30, "Meat", "Loaf" },
                    { 29, "Edward", "Norton" },
                    { 18, "Elijah", "Wood" },
                    { 27, "Orlando", "Bloom" },
                    { 26, "Lee", "Van Cleef" },
                    { 28, "Brad", "Pitt" },
                    { 24, "Clint", "Eastwood" },
                    { 23, "Samuel", "L. Jackson" },
                    { 22, "Uma", "Thurman" },
                    { 21, "John", "Travolta" },
                    { 20, "Ian", "McKellen" },
                    { 25, "Eli", "Wallach" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 10, "BIOGRAPHY" },
                    { 14, "HISTORY" },
                    { 13, "DOCUMENTARY" },
                    { 12, "SCI-FI" },
                    { 15, "ANIMATION" },
                    { 11, "ROMANCE" },
                    { 9, "WESTERN" },
                    { 4, "DRAMA" },
                    { 7, "BIOGRAPHY" },
                    { 6, "CRIME" },
                    { 5, "TRAGEDY" },
                    { 3, "THRILLER" },
                    { 2, "COMEDY" },
                    { 1, "ACTION" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[] { 8, "ADVENTURE" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "Hash", "Name", "Salt", "Surname" },
                values: new object[] { 1, "admin@gmail.com", new byte[] { 128, 243, 51, 181, 78, 213, 189, 222, 202, 101, 130, 223, 151, 221, 107, 73, 216, 35, 32, 241, 36, 81, 204, 95, 39, 149, 121, 163, 145, 175, 229, 173, 177, 190, 12, 29, 162, 207, 210, 219, 66, 94, 127, 140, 184, 128, 104, 233, 14, 242, 168, 172, 158, 16, 233, 244, 190, 66, 86, 144, 184, 153, 124, 236 }, "Admin", new byte[] { 237, 51, 75, 74, 106, 233, 134, 83, 89, 182, 151, 113, 187, 254, 195, 40, 230, 88, 203, 40, 65, 138, 187, 22, 150, 213, 55, 29, 183, 85, 75, 76, 100, 31, 11, 71, 203, 179, 72, 69, 71, 130, 172, 110, 73, 159, 0, 137, 145, 90, 233, 229, 255, 45, 246, 131, 152, 87, 24, 114, 60, 105, 189, 111, 245, 141, 194, 155, 0, 52, 156, 60, 143, 187, 235, 87, 196, 36, 140, 222, 87, 231, 111, 2, 254, 238, 77, 58, 140, 152, 5, 14, 39, 116, 29, 46, 40, 3, 139, 8, 112, 87, 2, 163, 160, 49, 100, 147, 243, 248, 85, 45, 175, 99, 67, 82, 251, 171, 148, 49, 88, 164, 24, 33, 91, 239, 62, 132 }, "Admin" });

            migrationBuilder.InsertData(
                table: "Videos",
                columns: new[] { "Id", "Description", "Image_Url", "ReleaseDate", "Title", "Type" },
                values: new object[,]
                {
                    { 15, "Emmy Award-winning, 11 episodes, five years in the making, the most expensive nature documentary series ever commissioned by the BBC, and the first to be filmed in high definition.", "https://m.media-amazon.com/images/I/91X9p6+58KL._SY445_.jpg", new DateTime(2010, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Planet Earth", (short)1 },
                    { 16, "A high school chemistry teacher diagnosed with inoperable lung cancer turns to manufacturing and selling methamphetamine in order to secure his family's future.", "https://www.themoviedb.org/t/p/w600_and_h900_bestv2/ggFHVNu6YYI5L9pCfOacjizRGt.jpg", new DateTime(2008, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Breaking Bad", (short)1 },
                    { 17, "The story of Easy Company of the U.S. Army 101st Airborne Division and their mission in World War II Europe, from Operation Overlord to V-J Day.", "http://www.impawards.com/tv/posters/band_of_brothers_ver4.jpg", new DateTime(2001, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Band of Brothers", (short)1 },
                    { 18, "In April 1986, an explosion at the Chernobyl nuclear power plant in the Union of Soviet Socialist Republics becomes one of the world's worst man-made catastrophes.", "https://i.redd.it/bv5isr69yr531.png", new DateTime(1986, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Chernobyl", (short)1 },
                    { 22, "An exploration of our discovery of the laws of nature and coordinates in space and time.", "https://pisces.bbystatic.com/image2/BestBuy_US/images/products/5945/5945188_sa.jpg;maxHeight=640;maxWidth=550", new DateTime(2014, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cosmos: A Spacetime Odyssey", (short)1 },
                    { 20, "David Attenborough returns to the world's oceans in this sequel to the acclaimed documentary filming rare and unusual creatures of the deep, as well as documenting the problems our oceans face.", "https://cdn.shopify.com/s/files/1/0747/3829/products/mL1006_1024x1024.jpg?v=1571445246", new DateTime(2017, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Blue Planet II", (short)1 },
                    { 21, "Documentary series focusing on the breadth of the diversity of habitats around the world, from the remote Arctic wilderness and mysterious deep oceans to the vast landscapes of Africa and diverse jungles of South America.", "https://www.penguin.co.uk/content/dam/prh/books/111/1115210/9780593079768.jpg.transform/PRHDesktopWide_small/image.jpg", new DateTime(2019, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Our Planet", (short)1 },
                    { 14, "Wildlife documentary series with David Attenborough, beginning with a look at the remote islands which offer sanctuary to some of the planet's rarest creatures, to the beauty of cities, which are home to humans, and animals..", "https://blackwells.co.uk/jacket/l/9781785943041.jpg", new DateTime(2016, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Planet Earth II", (short)1 },
                    { 23, "In a war-torn world of elemental magic, a young boy reawakens to undertake a dangerous mystic quest to fulfill his destiny as the Avatar, and bring peace to the world.", "https://images-na.ssl-images-amazon.com/images/I/914eUC4XPML.jpg", new DateTime(2005, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Avatar: The Last Airbender", (short)1 },
                    { 24, "Astronomer Carl Sagan leads us on an engaging guided tour of the various elements and cosmological theories of the universe.", "https://www.themoviedb.org/t/p/original/4WJ9kNejI8apl3f8hMNwo8V3hGT.jpg", new DateTime(1980, 12, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cosmos", (short)1 },
                    { 19, "The Baltimore drug scene, as seen through the eyes of drug dealers and law enforcement.", "https://tvshows.today/wp-content/uploads/the-wire-season-1-poster.jpg", new DateTime(2008, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Wire", (short)1 },
                    { 13, "A thief who steals corporate secrets through the use of dream-sharing technology is given the inverse task of planting an idea into the mind of a C.E.O.", "https://m.media-amazon.com/images/I/81p+xe8cbnL._SY445_.jpg", new DateTime(2010, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Inception", (short)0 },
                    { 9, "A bounty hunting scam joins two men in an uneasy alliance against a third in a race to find a fortune in gold buried in a remote cemetery.", "https://upload.wikimedia.org/wikipedia/en/4/45/Good_the_bad_and_the_ugly_poster.jpg", new DateTime(1996, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Good, the Bad and the Ugly", (short)0 },
                    { 11, "An insomniac office worker and a devil-may-care soap maker form an underground fight club that evolves into much more.", "https://m.media-amazon.com/images/I/51v5ZpFyaFL._AC_.jpg", new DateTime(1999, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fight Club", (short)0 },
                    { 10, "A meek Hobbit from the Shire and eight companions set out on a journey to destroy the powerful One Ring and save Middle-earth from the Dark Lord Sauron.", "https://images.moviesanywhere.com/198e228b071c60f5ad57e5f62fe60029/ff22cad6-2218-414d-b853-3f95d76905c7.jpg?h=375&resize=fit&w=250", new DateTime(2001, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Lord of the Rings: The Fellowship of the Ring", (short)0 },
                    { 8, "The lives of two mob hitmen, a boxer, a gangster and his wife, and a pair of diner bandits intertwine in four tales of violence and redemption.", "https://prod.miramax.digital/media/assets/Pulp-Fiction1.png", new DateTime(1994, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pulp Fiction", (short)0 },
                    { 7, "Gandalf and Aragorn lead the World of Men against Sauron's army to draw his gaze from Frodo and Sam as they approach Mount Doom with the One Ring.", "https://img.discogs.com/MsgjJVAxVCXb1w86ffIbaNRr2BY=/fit-in/600x600/filters:strip_icc():format(jpeg):mode_rgb():quality(90)/discogs-images/R-728620-1512923411-4779.jpeg.jpg", new DateTime(2003, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Lord of the Rings: The Return of the King", (short)0 },
                    { 6, "In German-occupied Poland during World War II, industrialist Oskar Schindler gradually becomes concerned for his Jewish workforce after witnessing their persecution by the Nazis.", "https://mir-s3-cdn-cf.behance.net/project_modules/max_1200/c617e634647543.56d846b10d56f.jpg", new DateTime(1994, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Schindler's List", (short)0 },
                    { 5, "A jury holdout attempts to prevent a miscarriage of justice by forcing his colleagues to reconsider the evidence.", "https://upload.wikimedia.org/wikipedia/commons/b/b5/12_Angry_Men_%281957_film_poster%29.jpg", new DateTime(1957, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "12 Angry Men", (short)0 },
                    { 4, "When the menace known as the Joker wreaks havoc and chaos on the people of Gotham, Batman must accept one of the greatest psychological and physical tests of his ability to fight injustice.", "https://upload.wikimedia.org/wikipedia/sh/8/83/Dark_knight_rises_poster.jpg", new DateTime(2008, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Dark Knight", (short)0 },
                    { 3, "The early life and career of Vito Corleone in 1920s New York City is portrayed, while his son, Michael, expands and tightens his grip on the family crime syndicate.", "https://shotonwhat.com/images/0071562-med.jpg", new DateTime(1974, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Godfather: Part II", (short)0 },
                    { 2, "An organized crime dynasty's aging patriarch transfers control of his clandestine empire to his reluctant son.", "https://www.reelviews.net/resources/img/posters/thumbs/godfather_poster.jpg", new DateTime(1972, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Godfather", (short)0 },
                    { 1, "Two imprisoned men bond over a number of years, finding solace and eventual redemption through acts of common decency.", "https://swank.azureedge.net/swank/prod-film/3560cd8a-9491-4ab9-876c-8a8d6b84a6dd/f8e7c904-669a-4c9f-ac29-d19b64b43e33/one-sheet.jpg?width=335&height=508&mode=crop", new DateTime(1994, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Shawshank Redemption", (short)0 },
                    { 25, "Nine noble families fight for control over the lands of Westeros, while an ancient enemy returns after being dormant for millennia.", "https://m.media-amazon.com/images/M/MV5BYTRiNDQwYzAtMzVlZS00NTI5LWJjYjUtMzkwNTUzMWMxZTllXkEyXkFqcGdeQXVyNDIzMzcwNjc@._V1_FMjpg_UX1000_.jpg", new DateTime(2011, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Game of Thrones", (short)1 },
                    { 12, "The presidencies of Kennedy and Johnson, the Vietnam War, the Watergate scandal and other historical events unfold from the perspective of an Alabama man with an IQ of 75, whose only desire is to be reunited with his childhood sweetheart.", "https://mir-s3-cdn-cf.behance.net/project_modules/max_1200/37a5b434647543.56d846b10ca45.jpg", new DateTime(1994, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Forrest Gump", (short)0 },
                    { 26, "New Jersey mob boss Tony Soprano deals with personal and professional issues in his home and business life that affect his mental state, leading him to seek professional psychiatric counseling.", "https://m.media-amazon.com/images/M/MV5BZGJjYzhjYTYtMDBjYy00OWU1LTg5OTYtNmYwOTZmZjE3ZDdhXkEyXkFqcGdeQXVyNTAyODkwOQ@@._V1_FMjpg_UX1000_.jpg", new DateTime(1999, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Sopranos", (short)1 }
                });

            migrationBuilder.InsertData(
                table: "ActorVideos",
                columns: new[] { "Id", "ActorId", "VideoId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 32, 29, 11 },
                    { 31, 28, 11 },
                    { 56, 37, 20 },
                    { 57, 53, 20 },
                    { 30, 27, 10 },
                    { 29, 20, 10 },
                    { 28, 18, 10 },
                    { 33, 30, 11 },
                    { 58, 54, 20 },
                    { 26, 25, 9 },
                    { 25, 24, 9 },
                    { 59, 37, 21 },
                    { 60, 56, 22 },
                    { 48, 44, 17 },
                    { 23, 22, 8 },
                    { 22, 21, 8 },
                    { 27, 26, 9 },
                    { 55, 52, 19 },
                    { 34, 31, 12 },
                    { 35, 32, 12 },
                    { 49, 45, 17 },
                    { 46, 42, 16 },
                    { 45, 41, 16 },
                    { 44, 40, 16 },
                    { 50, 46, 18 },
                    { 43, 39, 15 },
                    { 42, 38, 15 },
                    { 41, 37, 15 },
                    { 51, 47, 18 },
                    { 52, 48, 18 },
                    { 40, 37, 14 },
                    { 39, 36, 13 },
                    { 38, 35, 13 },
                    { 37, 34, 13 },
                    { 53, 50, 19 },
                    { 54, 51, 19 },
                    { 36, 33, 12 },
                    { 61, 57, 22 },
                    { 62, 58, 22 },
                    { 24, 23, 8 },
                    { 12, 11, 4 }
                });

            migrationBuilder.InsertData(
                table: "ActorVideos",
                columns: new[] { "Id", "ActorId", "VideoId" },
                values: new object[,]
                {
                    { 70, 66, 25 },
                    { 63, 59, 23 },
                    { 11, 10, 4 },
                    { 10, 9, 4 },
                    { 71, 67, 25 },
                    { 9, 8, 3 },
                    { 8, 7, 3 },
                    { 69, 65, 25 },
                    { 7, 5, 3 },
                    { 73, 69, 26 },
                    { 6, 6, 2 },
                    { 5, 5, 2 },
                    { 4, 4, 2 },
                    { 74, 70, 26 },
                    { 3, 3, 1 },
                    { 2, 2, 1 },
                    { 72, 68, 26 },
                    { 68, 64, 24 },
                    { 47, 43, 17 },
                    { 20, 19, 7 },
                    { 13, 12, 5 },
                    { 21, 20, 7 },
                    { 14, 13, 5 },
                    { 18, 17, 6 },
                    { 15, 14, 5 },
                    { 67, 63, 24 },
                    { 66, 62, 24 },
                    { 65, 61, 23 },
                    { 64, 60, 23 },
                    { 19, 18, 7 },
                    { 16, 15, 6 },
                    { 17, 16, 6 }
                });

            migrationBuilder.InsertData(
                table: "CategoryVideos",
                columns: new[] { "Id", "CategoryId", "VideoId" },
                values: new object[,]
                {
                    { 34, 14, 17 },
                    { 39, 6, 19 },
                    { 44, 15, 23 },
                    { 33, 1, 17 },
                    { 32, 4, 17 },
                    { 51, 4, 26 },
                    { 42, 13, 21 },
                    { 35, 4, 18 },
                    { 50, 4, 25 },
                    { 40, 3, 19 }
                });

            migrationBuilder.InsertData(
                table: "CategoryVideos",
                columns: new[] { "Id", "CategoryId", "VideoId" },
                values: new object[,]
                {
                    { 36, 14, 18 },
                    { 37, 3, 18 },
                    { 49, 8, 25 },
                    { 48, 1, 25 },
                    { 41, 13, 20 },
                    { 46, 8, 23 },
                    { 38, 4, 19 },
                    { 47, 13, 24 },
                    { 45, 1, 23 },
                    { 43, 13, 22 },
                    { 25, 4, 13 },
                    { 31, 3, 16 },
                    { 9, 4, 5 },
                    { 17, 4, 8 },
                    { 8, 1, 4 },
                    { 18, 6, 8 },
                    { 14, 4, 7 },
                    { 7, 6, 4 },
                    { 19, 9, 9 },
                    { 6, 4, 4 },
                    { 20, 4, 10 },
                    { 21, 8, 10 },
                    { 11, 4, 6 },
                    { 22, 1, 10 },
                    { 5, 6, 3 },
                    { 16, 1, 7 },
                    { 23, 4, 11 },
                    { 24, 4, 12 },
                    { 10, 6, 5 },
                    { 13, 14, 6 },
                    { 52, 6, 26 },
                    { 26, 11, 13 },
                    { 3, 4, 2 },
                    { 27, 13, 14 },
                    { 2, 6, 2 },
                    { 28, 13, 15 },
                    { 12, 7, 6 },
                    { 1, 4, 1 },
                    { 29, 4, 16 },
                    { 30, 6, 16 },
                    { 4, 4, 3 },
                    { 15, 8, 7 }
                });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "UserId", "Value", "VideoId" },
                values: new object[,]
                {
                    { 3, 1, 4.5, 3 },
                    { 24, 1, 4.0999999999999996, 24 },
                    { 2, 1, 4.5, 2 },
                    { 25, 1, 4.0, 25 },
                    { 1, 1, 4.5999999999999996, 1 },
                    { 4, 1, 4.5, 4 },
                    { 23, 1, 4.0999999999999996, 23 },
                    { 7, 1, 4.2999999999999998, 7 },
                    { 6, 1, 4.3499999999999996, 6 },
                    { 15, 1, 4.5999999999999996, 15 },
                    { 17, 1, 4.5999999999999996, 17 },
                    { 14, 1, 4.7000000000000002, 14 },
                    { 13, 1, 4.0999999999999996, 13 },
                    { 18, 1, 4.5, 18 },
                    { 12, 1, 4.0999999999999996, 12 },
                    { 11, 1, 4.2000000000000002, 11 },
                    { 10, 1, 4.2000000000000002, 10 },
                    { 19, 1, 4.4000000000000004, 19 },
                    { 9, 1, 4.2000000000000002, 9 },
                    { 20, 1, 4.2999999999999998, 20 },
                    { 8, 1, 4.2000000000000002, 8 },
                    { 21, 1, 4.2000000000000002, 21 },
                    { 16, 1, 4.5999999999999996, 16 },
                    { 22, 1, 4.0999999999999996, 22 },
                    { 5, 1, 4.4000000000000004, 5 },
                    { 26, 1, 3.8999999999999999, 26 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ActorVideos_ActorId",
                table: "ActorVideos",
                column: "ActorId");

            migrationBuilder.CreateIndex(
                name: "IX_ActorVideos_VideoId",
                table: "ActorVideos",
                column: "VideoId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoryVideos_CategoryId",
                table: "CategoryVideos",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoryVideos_VideoId",
                table: "CategoryVideos",
                column: "VideoId");

            migrationBuilder.CreateIndex(
                name: "IX_Ratings_UserId",
                table: "Ratings",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Ratings_VideoId",
                table: "Ratings",
                column: "VideoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ActorVideos");

            migrationBuilder.DropTable(
                name: "CategoryVideos");

            migrationBuilder.DropTable(
                name: "Ratings");

            migrationBuilder.DropTable(
                name: "Actors");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Videos");
        }
    }
}
