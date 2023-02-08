using Microsoft.EntityFrameworkCore.Migrations;

namespace Mission_06_briggsm2.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "responces",
                columns: table => new
                {
                    MovieId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Category = table.Column<string>(nullable: false),
                    Title = table.Column<string>(nullable: false),
                    Year = table.Column<int>(nullable: false),
                    Director = table.Column<string>(nullable: false),
                    Rating = table.Column<string>(nullable: false),
                    Edited = table.Column<bool>(nullable: false),
                    Lent_To = table.Column<string>(nullable: true),
                    Notes = table.Column<string>(maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_responces", x => x.MovieId);
                });

            migrationBuilder.InsertData(
                table: "responces",
                columns: new[] { "MovieId", "Category", "Director", "Edited", "Lent_To", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 1, "Action/Adventure", "Ruben Fleischer", false, null, null, "PG-13", "Uncharted", 2022 });

            migrationBuilder.InsertData(
                table: "responces",
                columns: new[] { "MovieId", "Category", "Director", "Edited", "Lent_To", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 2, "Action/Adventure", "Joseph Kosinski", false, null, null, "PG-13", "Top Gun: Maverick", 2022 });

            migrationBuilder.InsertData(
                table: "responces",
                columns: new[] { "MovieId", "Category", "Director", "Edited", "Lent_To", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 3, "Horor/Action", "Marc Forster", false, null, "This is my most favorite", "PG-13", "World War Z", 2013 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "responces");
        }
    }
}
