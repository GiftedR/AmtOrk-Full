using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AmtOrkFull.Server.Migrations
{
    /// <inheritdoc />
    public partial class AddedLandSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Land",
                columns: new[] { "Id", "ChampionId", "GMRId", "KingdomId", "LandDescription", "LandIconPath", "LandLocation", "LandName", "MonarchId", "PrimeMinisterId", "RegentId" },
                values: new object[,]
                {
                    { 1, null, null, 13, "Blade's Edge meets three times a week:\nTuesday @ 4:00pm -Fighter Practice\nFriday @ 4:00pm - Fighter Practice\nSaturday @ 1:00pm -Park Day", "https://ork.amtgard.com/assets/heraldry/park/00825.jpg", "2729 Jackson Ave SE, Port Orchard, WA 98366, USA", "Blade's Edge", null, null, null },
                    { 2, null, null, 13, "The Dragons of Fire Valley was formed in 2007 in Chehalis, Washington. The land started with three people searching for a new home. Finding a land rich with tree's and resources in Washington, they had found a new area to set up home. Voting and making it official, the land started its long journey towards prosperity, and are growing constantly each year. Finding a solid support structure within the Northern Lights, the Dragons of Fire Valley have become hosts to several large scale travel days and provide a great group of people for future growth of the Northern Lights and Dragons of Fire Valley itself.", "https://ork.amtgard.com/assets/heraldry/park/00355.jpg", "We meet at noon on Saturdays in Borst Park located in Centralia, Wa.", "Dragons of Fire Valley", null, null, null },
                    { 3, null, null, 13, "We are the Dutchy of Greenwood Keep. We meet at Wonderwood Park in Lacey at 11:00am on Sundays. We enjoy fast paced games, and adventures in the woods. Come out and see us! Very kid friendly, our few smokers are respectful of others, and we often have food! http://www.greenwoodkeep.com/", "https://ork.amtgard.com/assets/heraldry/park/00076.jpg", "Take College to 31st, turning East, then follow the signs for Wonderwood Park.For Fighter Practice, please check on Discord or Facebook as the location and time may change!", "Greenwood Keep", null, null, null },
                    { 4, null, null, 13, "Welcome to Inland Ocean! We play at Marymoor Park in Redmond, WA, Saturdays starting at 12! We are typically at one of the shelters near the Dog Wash in Lot D. If you are looking for us, head towards the dog park, and look for the banner and players, or check our Facebook page, as someone typically posts our exact location. We have Fighter Practice at Frank Love Elementry in the covered basketball court, in Bothell WA. 6-8pm every Thursday.", "https://ork.amtgard.com/assets/heraldry/park/00074.jpg", "", "Inland Ocean", null, null, null },
                    { 5, null, null, 13, "Parksville Community Park, at the gazebo by the stage\n\n(Monday fighter practice is at the Qualicum Beach community park, near Ravensong Aquatic Center)", "https://ork.amtgard.com/assets/heraldry/park/01043.jpg", "", "Lost Cove", null, null, null },
                    { 6, null, null, 13, "We play every Sunday, starting at Noon at Tam O'Shanter Park in Kelso.", "https://ork.amtgard.com/assets/heraldry/park/00124.jpg", "Directions to Parkn1)Take exit 39 for WA-4 W/Allen Street toward Kelson2)Turn left onto WA-4 W/Allen Stn3)Continue straight onto Allen Stn4)Turn right onto S Kelso Drn5)Turn left onto Tam O'Shanter Wayn6)Continue straight into park", "Mithril Hills", null, null, null },
                    { 7, null, null, 13, "", "https://ork.amtgard.com/assets/heraldry/park/01042.jpg", "", "Oceans Alley", null, null, null },
                    { 8, null, null, 13, "Our main Park is Central Park in Burnaby. Park days meet at the Band Stand by Swangard Stadium. We also meet regularly for crafting nights, fight practice and special events", "https://ork.amtgard.com/assets/heraldry/park/01006.jpg", "", "Seaside Keep", null, null, null },
                    { 9, null, null, 13, "We are an Amtgard land in the Kingdom of Northern Lights. Created in 1988, we meet every Sunday around noon at Sprinker Recreational Park next to Breseman Forest near the Rock Climbing structure (orginally behind the baseball fields). We hope to see you there!", "https://ork.amtgard.com/assets/heraldry/park/00118.jpg", "", "Shrouding Mist", null, null, null },
                    { 10, null, null, 13, "The Hollow Discord:\nhttps://discord.com/invite/jxQntTxenS\nFacebook Group:\nhttps://www.facebook.com/groups/120371818682/?ref=share\nFacebook Page:\nhttps://www.facebook.com/share/DZHscqVKJaRhH3QJ/?mibextid=qi2Omg\nInstagram:\nhttps://www.instagram.com/amtgard.thehollow?igsh=YWh6MnhpeHd1d3dt\nKingdom Discord:\nhttps://discord.com/invite/hxWAUQZHMs", "https://ork.amtgard.com/assets/heraldry/park/00343.jpg", "Sundays at noon. Take exit 186 off Interstate 5. Head East on 128th St. SE. McCollum Park will be on your Right in about a half mile. We meet at the North end of the Forest Loop Trail.", "The Hollow", null, null, null },
                    { 11, null, null, 13, "We meet Saturdays at 12:00pm at Vance Creek Park in Elma (Wenzel Slough Rd, Elma, WA 98541)", "https://ork.amtgard.com/assets/heraldry/park/01050.jpg", "", "Three Lakes", null, null, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Land",
                keyColumn: "Id",
                keyValue: 11);
        }
    }
}
