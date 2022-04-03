using System.Globalization;
using BusinessTripAdmin.Infrastructure.Constants;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BusinessTripAdmin.Infrastructure.Data.Migrations
{
    public partial class DataSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "CountryName", "CreatedDate", "Currency", "CurrencyCode", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("054ae920-822c-4887-980b-2f90057be323"), "AZERBAIJAN", DateTime.ParseExact(DateTime.Now.ToString(FormatingConstants.FullTimeFormat), FormatingConstants.FullTimeFormat, CultureInfo.InvariantCulture), "US Dollar", 1, null },
                    { new Guid("0c7fc53a-d085-4250-ac2b-12c6e6714a08"), "UNITED STATES", DateTime.ParseExact(DateTime.Now.ToString(FormatingConstants.FullTimeFormat), FormatingConstants.FullTimeFormat, CultureInfo.InvariantCulture), "US Dollar", 1, null },
                    { new Guid("0de631d5-466d-40a8-ac06-08ef082cd1a0"), "CONGO", DateTime.ParseExact(DateTime.Now.ToString(FormatingConstants.FullTimeFormat), FormatingConstants.FullTimeFormat, CultureInfo.InvariantCulture), "US Dollar", 1, null },
                    { new Guid("12c08437-e23d-42ff-aa8e-c15cfc49cc1e"), "LITHUANIA", DateTime.ParseExact(DateTime.Now.ToString(FormatingConstants.FullTimeFormat), FormatingConstants.FullTimeFormat, CultureInfo.InvariantCulture), "Euro", 3, null },
                    { new Guid("14b0a82b-c9b7-4dd9-9ec1-6bdbadf3ae6e"), "EGYPT", DateTime.ParseExact(DateTime.Now.ToString(FormatingConstants.FullTimeFormat), FormatingConstants.FullTimeFormat, CultureInfo.InvariantCulture), "US Dollar", 1, null },
                    { new Guid("179bc570-ff28-4188-8062-8beca0674888"), "YEMEN", DateTime.ParseExact(DateTime.Now.ToString(FormatingConstants.FullTimeFormat), FormatingConstants.FullTimeFormat, CultureInfo.InvariantCulture), "US Dollar", 1, null },
                    { new Guid("17d16d90-0c4e-491a-979b-76a5146f2808"), "DENMARK", DateTime.ParseExact(DateTime.Now.ToString(FormatingConstants.FullTimeFormat), FormatingConstants.FullTimeFormat, CultureInfo.InvariantCulture), "Euro", 3, null },
                    { new Guid("2020a24b-88a3-4c46-ba40-bc64b81ce093"), "INDONESIA", DateTime.ParseExact(DateTime.Now.ToString(FormatingConstants.FullTimeFormat), FormatingConstants.FullTimeFormat, CultureInfo.InvariantCulture), "US Dollar", 1, null },
                    { new Guid("235d64bb-3fbf-4cc7-be87-89e1abef61cd"), "IRAQ", DateTime.ParseExact(DateTime.Now.ToString(FormatingConstants.FullTimeFormat), FormatingConstants.FullTimeFormat, CultureInfo.InvariantCulture), "US Dollar", 1, null },
                    { new Guid("25207346-2489-4abf-b00a-d3d46661212f"), "UNITED ARAB EMIRATES", DateTime.ParseExact(DateTime.Now.ToString(FormatingConstants.FullTimeFormat), FormatingConstants.FullTimeFormat, CultureInfo.InvariantCulture), "US Dollar", 1, null },
                    { new Guid("2d9af68d-e0c8-427f-9d40-b1631715f4e3"), "LUXEMBOURG", DateTime.ParseExact(DateTime.Now.ToString(FormatingConstants.FullTimeFormat), FormatingConstants.FullTimeFormat, CultureInfo.InvariantCulture), "Euro", 3, null },
                    { new Guid("2d9da4bb-fb82-4482-908a-6ac3b5bf2a4a"), "BRAZIL", DateTime.ParseExact(DateTime.Now.ToString(FormatingConstants.FullTimeFormat), FormatingConstants.FullTimeFormat, CultureInfo.InvariantCulture), "US Dollar", 1, null },
                    { new Guid("2faa1655-a4e0-49a3-a905-71eb08ae01ad"), "SAUDI ARABIA", DateTime.ParseExact(DateTime.Now.ToString(FormatingConstants.FullTimeFormat), FormatingConstants.FullTimeFormat, CultureInfo.InvariantCulture), "US Dollar", 1, null },
                    { new Guid("303f76e5-2460-4600-ae5c-795f084064a0"), "TURKEY", DateTime.ParseExact(DateTime.Now.ToString(FormatingConstants.FullTimeFormat), FormatingConstants.FullTimeFormat, CultureInfo.InvariantCulture), "US Dollar", 1, null },
                    { new Guid("34434a82-ec72-4a1c-94df-4f5b5032ac5e"), "SLOVAKIA", DateTime.ParseExact(DateTime.Now.ToString(FormatingConstants.FullTimeFormat), FormatingConstants.FullTimeFormat, CultureInfo.InvariantCulture), "Euro", 3, null },
                    { new Guid("347dc592-7e86-4c15-b59b-65d52e161a8d"), "RUSSIAN FEDERATION", DateTime.ParseExact(DateTime.Now.ToString(FormatingConstants.FullTimeFormat), FormatingConstants.FullTimeFormat, CultureInfo.InvariantCulture), "US Dollar", 1, null },
                    { new Guid("35c5cb44-9b8a-4fb9-9cfc-cec8eb0ac673"), "LEBANON", DateTime.ParseExact(DateTime.Now.ToString(FormatingConstants.FullTimeFormat), FormatingConstants.FullTimeFormat, CultureInfo.InvariantCulture), "US Dollar", 1, null },
                    { new Guid("3817ffcf-14b6-4898-90ae-ab52d0f2cab8"), "ALL OTHER COUNTRIES", DateTime.ParseExact(DateTime.Now.ToString(FormatingConstants.FullTimeFormat), FormatingConstants.FullTimeFormat, CultureInfo.InvariantCulture), "US Dollar", 1, null },
                    { new Guid("38f13134-269b-4918-b857-4b69f617063e"), "COLOMBIA", DateTime.ParseExact(DateTime.Now.ToString(FormatingConstants.FullTimeFormat), FormatingConstants.FullTimeFormat, CultureInfo.InvariantCulture), "US Dollar", 1, null },
                    { new Guid("3a3af9bc-3a9e-414c-831c-0b37bccc46ba"), "SOUTH AFRICA", DateTime.ParseExact(DateTime.Now.ToString(FormatingConstants.FullTimeFormat), FormatingConstants.FullTimeFormat, CultureInfo.InvariantCulture), "US Dollar", 1, null },
                    { new Guid("3c9bb88b-dff9-4c39-b7e5-6b3914f52ef4"), "ESTONIA", DateTime.ParseExact(DateTime.Now.ToString(FormatingConstants.FullTimeFormat), FormatingConstants.FullTimeFormat, CultureInfo.InvariantCulture), "Euro", 3, null },
                    { new Guid("3d68d5c0-ca83-49e4-adb0-548cadf9b465"), "KYRGYZSTAN", DateTime.ParseExact(DateTime.Now.ToString(FormatingConstants.FullTimeFormat), FormatingConstants.FullTimeFormat, CultureInfo.InvariantCulture), "US Dollar", 1, null },
                    { new Guid("3e022d17-2837-4a91-8850-8123889ebddd"), "MALAYSIA", DateTime.ParseExact(DateTime.Now.ToString(FormatingConstants.FullTimeFormat), FormatingConstants.FullTimeFormat, CultureInfo.InvariantCulture), "US Dollar", 1, null },
                    { new Guid("432a67c7-518a-4a2c-aa47-82252ba5e023"), "SERBIA", DateTime.ParseExact(DateTime.Now.ToString(FormatingConstants.FullTimeFormat), FormatingConstants.FullTimeFormat, CultureInfo.InvariantCulture), "Euro", 3, null },
                    { new Guid("49d80ff5-f4b3-4c99-99b8-6b9966b8d490"), "FINLAND", DateTime.ParseExact(DateTime.Now.ToString(FormatingConstants.FullTimeFormat), FormatingConstants.FullTimeFormat, CultureInfo.InvariantCulture), "Euro", 3, null },
                    { new Guid("4d072d95-9483-4be7-98da-344b52cdd0bb"), "MOROCCO", DateTime.ParseExact(DateTime.Now.ToString(FormatingConstants.FullTimeFormat), FormatingConstants.FullTimeFormat, CultureInfo.InvariantCulture), "Euro", 3, null },
                    { new Guid("4d9b9ffe-c165-428e-825e-dab1bb6b6bfd"), "NEW ZEALAND", DateTime.ParseExact(DateTime.Now.ToString(FormatingConstants.FullTimeFormat), FormatingConstants.FullTimeFormat, CultureInfo.InvariantCulture), "US Dollar", 1, null },
                    { new Guid("4e6d506c-87bd-460b-8756-c51ab4be2583"), "CROATIA", DateTime.ParseExact(DateTime.Now.ToString(FormatingConstants.FullTimeFormat), FormatingConstants.FullTimeFormat, CultureInfo.InvariantCulture), "Euro", 3, null },
                    { new Guid("4ee4e347-3026-4edb-b72f-280f0c286200"), "ICELAND", DateTime.ParseExact(DateTime.Now.ToString(FormatingConstants.FullTimeFormat), FormatingConstants.FullTimeFormat, CultureInfo.InvariantCulture), "Euro", 3, null },
                    { new Guid("565bce56-6751-4692-913b-d7605aa88843"), "CZECH REPUBLIC", DateTime.ParseExact(DateTime.Now.ToString(FormatingConstants.FullTimeFormat), FormatingConstants.FullTimeFormat, CultureInfo.InvariantCulture), "Euro", 3, null },
                    { new Guid("573b03c1-c997-4fa3-b46f-089fdad19cd5"), "ISRAEL", DateTime.ParseExact(DateTime.Now.ToString(FormatingConstants.FullTimeFormat), FormatingConstants.FullTimeFormat, CultureInfo.InvariantCulture), "US Dollar", 1, null },
                    { new Guid("5b297d8e-3ab4-4e03-aa63-667314c145fa"), "PORTUGAL", DateTime.ParseExact(DateTime.Now.ToString(FormatingConstants.FullTimeFormat), FormatingConstants.FullTimeFormat, CultureInfo.InvariantCulture), "Euro", 3, null },
                    { new Guid("5bebe8d1-1d0c-4294-a518-e07df509f201"), "ARGENTINA", DateTime.ParseExact(DateTime.Now.ToString(FormatingConstants.FullTimeFormat), FormatingConstants.FullTimeFormat, CultureInfo.InvariantCulture), "US Dollar", 1, null },
                    { new Guid("6d3afe47-e20b-4b61-b57d-274e55be1235"), "AUSTRIA", DateTime.ParseExact(DateTime.Now.ToString(FormatingConstants.FullTimeFormat), FormatingConstants.FullTimeFormat, CultureInfo.InvariantCulture), "Euro", 3, null },
                    { new Guid("6ebc7f7d-7181-4b75-a21b-5cc5a6bd8c07"), "COTE D'IVOIRE", DateTime.ParseExact(DateTime.Now.ToString(FormatingConstants.FullTimeFormat), FormatingConstants.FullTimeFormat, CultureInfo.InvariantCulture), "US Dollar", 1, null },
                    { new Guid("704886d4-45a9-49ad-990d-8e2f8db8bcc5"), "ALBANIA", DateTime.ParseExact(DateTime.Now.ToString(FormatingConstants.FullTimeFormat), FormatingConstants.FullTimeFormat, CultureInfo.InvariantCulture), "Euro", 3, null },
                    { new Guid("71e72b19-8639-4804-9f01-c00feb87cf03"), "VIETNAM", DateTime.ParseExact(DateTime.Now.ToString(FormatingConstants.FullTimeFormat), FormatingConstants.FullTimeFormat, CultureInfo.InvariantCulture), "US Dollar", 1, null },
                    { new Guid("7ad02002-d76c-4f78-bed8-6c77785ee068"), "NIGERIA", DateTime.ParseExact(DateTime.Now.ToString(FormatingConstants.FullTimeFormat), FormatingConstants.FullTimeFormat, CultureInfo.InvariantCulture), "US Dollar", 1, null },
                    { new Guid("7b6aace4-731b-4528-903f-45404a9b463c"), "JAPAN", DateTime.ParseExact(DateTime.Now.ToString(FormatingConstants.FullTimeFormat), FormatingConstants.FullTimeFormat, CultureInfo.InvariantCulture), "Yen", 7, null },
                    { new Guid("7d2804e7-e6ce-433d-bbf2-ea6fa21f3fb8"), "UKRAINE", DateTime.ParseExact(DateTime.Now.ToString(FormatingConstants.FullTimeFormat), FormatingConstants.FullTimeFormat, CultureInfo.InvariantCulture), "US Dollar", 1, null },
                    { new Guid("7d2abafc-d5b8-46b6-963a-5451bd3b5cb6"), "CUBA", DateTime.ParseExact(DateTime.Now.ToString(FormatingConstants.FullTimeFormat), FormatingConstants.FullTimeFormat, CultureInfo.InvariantCulture), "US Dollar", 1, null },
                    { new Guid("7e2a0d8e-bf3e-459c-a931-8f5895cf74eb"), "MONGOLIA", DateTime.ParseExact(DateTime.Now.ToString(FormatingConstants.FullTimeFormat), FormatingConstants.FullTimeFormat, CultureInfo.InvariantCulture), "US Dollar", 1, null }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "CountryName", "CreatedDate", "Currency", "CurrencyCode", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("81a795a3-1b74-4e10-89b1-7cd4081125f1"), "NORWAY", DateTime.ParseExact(DateTime.Now.ToString(FormatingConstants.FullTimeFormat), FormatingConstants.FullTimeFormat, CultureInfo.InvariantCulture), "Euro", 3, null },
                    { new Guid("81e490d8-8569-4872-8449-d00b917625b6"), "AFGHANISTAN", DateTime.ParseExact(DateTime.Now.ToString(FormatingConstants.FullTimeFormat), FormatingConstants.FullTimeFormat, CultureInfo.InvariantCulture), "US Dollar", 1, null },
                    { new Guid("83c2f7a4-f4e2-4e21-8826-dfca9112acf7"), "MALI", DateTime.ParseExact(DateTime.Now.ToString(FormatingConstants.FullTimeFormat), FormatingConstants.FullTimeFormat, CultureInfo.InvariantCulture), "US Dollar", 1, null },
                    { new Guid("83e0fe3e-bfa2-4bb3-8304-371bad7b4181"), "MONACO", DateTime.ParseExact(DateTime.Now.ToString(FormatingConstants.FullTimeFormat), FormatingConstants.FullTimeFormat, CultureInfo.InvariantCulture), "Euro", 3, null },
                    { new Guid("84b9a341-7615-42f3-9767-29e66db3e586"), "SWEDEN", DateTime.ParseExact(DateTime.Now.ToString(FormatingConstants.FullTimeFormat), FormatingConstants.FullTimeFormat, CultureInfo.InvariantCulture), "Euro", 3, null },
                    { new Guid("8b73da44-a5f8-4db4-9b36-92f9bad886d9"), "NORTH KOREA", DateTime.ParseExact(DateTime.Now.ToString(FormatingConstants.FullTimeFormat), FormatingConstants.FullTimeFormat, CultureInfo.InvariantCulture), "Euro", 3, null },
                    { new Guid("8bd41c75-33bb-41b4-b257-dd8e3ea6879c"), "UNITED KINGDOM", DateTime.ParseExact(DateTime.Now.ToString(FormatingConstants.FullTimeFormat), FormatingConstants.FullTimeFormat, CultureInfo.InvariantCulture), "Pound Sterling", 5, null },
                    { new Guid("8f0c2d33-34cf-4a70-8260-18e4c888247a"), "ANGOLA", DateTime.ParseExact(DateTime.Now.ToString(FormatingConstants.FullTimeFormat), FormatingConstants.FullTimeFormat, CultureInfo.InvariantCulture), "US Dollar", 1, null },
                    { new Guid("8ff5374a-0081-46f1-94d5-5e4e9525a223"), "IRAN", DateTime.ParseExact(DateTime.Now.ToString(FormatingConstants.FullTimeFormat), FormatingConstants.FullTimeFormat, CultureInfo.InvariantCulture), "US Dollar", 1, null },
                    { new Guid("928d8869-f99d-4496-b04c-9fa4e4806938"), "ROMANIA", DateTime.ParseExact(DateTime.Now.ToString(FormatingConstants.FullTimeFormat), FormatingConstants.FullTimeFormat, CultureInfo.InvariantCulture), "Euro", 3, null },
                    { new Guid("93c952ca-4dc7-412e-8578-ab870a18ef3f"), "SYRIAN ARAB REPUBLIC", DateTime.ParseExact(DateTime.Now.ToString(FormatingConstants.FullTimeFormat), FormatingConstants.FullTimeFormat, CultureInfo.InvariantCulture), "US Dollar", 1, null },
                    { new Guid("94440f56-8a73-4b2c-b63e-acd1126728ab"), "GREECE", DateTime.ParseExact(DateTime.Now.ToString(FormatingConstants.FullTimeFormat), FormatingConstants.FullTimeFormat, CultureInfo.InvariantCulture), "Euro", 3, null },
                    { new Guid("977f86b2-7ce2-4c89-8ace-f732dd7a8a14"), "LATVIA", DateTime.ParseExact(DateTime.Now.ToString(FormatingConstants.FullTimeFormat), FormatingConstants.FullTimeFormat, CultureInfo.InvariantCulture), "Euro", 3, null },
                    { new Guid("9de0b25e-09dd-4d3d-86a1-ed131a5624da"), "AUSTRALIA", DateTime.ParseExact(DateTime.Now.ToString(FormatingConstants.FullTimeFormat), FormatingConstants.FullTimeFormat, CultureInfo.InvariantCulture), "Australian Dollar", 4, null },
                    { new Guid("9ec06ecc-545a-466e-aed0-1c9f2dd100a8"), "BELGIUM", DateTime.ParseExact(DateTime.Now.ToString(FormatingConstants.FullTimeFormat), FormatingConstants.FullTimeFormat, CultureInfo.InvariantCulture), "Euro", 3, null },
                    { new Guid("9f30b544-8639-468b-b275-e79e45bf8137"), "UZBEKISTAN", DateTime.ParseExact(DateTime.Now.ToString(FormatingConstants.FullTimeFormat), FormatingConstants.FullTimeFormat, CultureInfo.InvariantCulture), "US Dollar", 1, null },
                    { new Guid("9f5432e9-7f39-4ec0-8d34-07dd0da15613"), "LIBYAN ARAB JAMAHIRIYA", DateTime.ParseExact(DateTime.Now.ToString(FormatingConstants.FullTimeFormat), FormatingConstants.FullTimeFormat, CultureInfo.InvariantCulture), "US Dollar", 1, null },
                    { new Guid("9fb2ceb7-9fcc-43fc-b645-4513247f10ef"), "KAZAKHSTAN", DateTime.ParseExact(DateTime.Now.ToString(FormatingConstants.FullTimeFormat), FormatingConstants.FullTimeFormat, CultureInfo.InvariantCulture), "US Dollar", 1, null },
                    { new Guid("a480ab84-5a04-4a16-b136-c4e8f2ede1e8"), "KENYA", DateTime.ParseExact(DateTime.Now.ToString(FormatingConstants.FullTimeFormat), FormatingConstants.FullTimeFormat, CultureInfo.InvariantCulture), "US Dollar", 1, null },
                    { new Guid("a79549a0-ab5d-4d4d-a5d0-a97f0cabd0d3"), "SAN MARINO", DateTime.ParseExact(DateTime.Now.ToString(FormatingConstants.FullTimeFormat), FormatingConstants.FullTimeFormat, CultureInfo.InvariantCulture), "Euro", 3, null },
                    { new Guid("ae11fa10-a146-4ddc-a914-6010a01604dd"), "ETHIOPIA", DateTime.ParseExact(DateTime.Now.ToString(FormatingConstants.FullTimeFormat), FormatingConstants.FullTimeFormat, CultureInfo.InvariantCulture), "US Dollar", 1, null },
                    { new Guid("b001e1c8-ec60-4d76-816c-00ca9befff02"), "TUNISIA", DateTime.ParseExact(DateTime.Now.ToString(FormatingConstants.FullTimeFormat), FormatingConstants.FullTimeFormat, CultureInfo.InvariantCulture), "US Dollar", 1, null },
                    { new Guid("b065dc2f-00aa-4af8-aca6-1d37905f15c4"), "SOUTH KOREA", DateTime.ParseExact(DateTime.Now.ToString(FormatingConstants.FullTimeFormat), FormatingConstants.FullTimeFormat, CultureInfo.InvariantCulture), "US Dollar", 1, null },
                    { new Guid("b08c34dc-e20b-41c6-a073-4293eaf01d3c"), "INDIA", DateTime.ParseExact(DateTime.Now.ToString(FormatingConstants.FullTimeFormat), FormatingConstants.FullTimeFormat, CultureInfo.InvariantCulture), "US Dollar", 1, null },
                    { new Guid("b1318e0a-d111-4822-9c1d-073cea549b5e"), "MOZAMBIQUE", DateTime.ParseExact(DateTime.Now.ToString(FormatingConstants.FullTimeFormat), FormatingConstants.FullTimeFormat, CultureInfo.InvariantCulture), "US Dollar", 1, null },
                    { new Guid("b6190653-e7ef-4de6-939f-3c03d39ce83d"), "HUNGARY", DateTime.ParseExact(DateTime.Now.ToString(FormatingConstants.FullTimeFormat), FormatingConstants.FullTimeFormat, CultureInfo.InvariantCulture), "Euro", 3, null },
                    { new Guid("b6c4a8fa-1f92-4c2a-b0d0-71c9db72a8be"), "CYPRUS", DateTime.ParseExact(DateTime.Now.ToString(FormatingConstants.FullTimeFormat), FormatingConstants.FullTimeFormat, CultureInfo.InvariantCulture), "Euro", 3, null },
                    { new Guid("b940f8d6-0a41-489a-aab5-d6d64c06dc7a"), "GERMANY", DateTime.ParseExact(DateTime.Now.ToString(FormatingConstants.FullTimeFormat), FormatingConstants.FullTimeFormat, CultureInfo.InvariantCulture), "Euro", 3, null },
                    { new Guid("bcfc73c4-277b-4479-9899-a934bdde2dee"), "SLOVENIA", DateTime.ParseExact(DateTime.Now.ToString(FormatingConstants.FullTimeFormat), FormatingConstants.FullTimeFormat, CultureInfo.InvariantCulture), "Euro", 3, null },
                    { new Guid("bfc163c9-f937-4ac1-97eb-7aac7a0689fd"), "IRELAND", DateTime.ParseExact(DateTime.Now.ToString(FormatingConstants.FullTimeFormat), FormatingConstants.FullTimeFormat, CultureInfo.InvariantCulture), "Euro", 3, null },
                    { new Guid("c0f550b1-1466-4fbc-b740-07737dbf74c7"), "CHINA", DateTime.ParseExact(DateTime.Now.ToString(FormatingConstants.FullTimeFormat), FormatingConstants.FullTimeFormat, CultureInfo.InvariantCulture), "US Dollar", 1, null },
                    { new Guid("c198fd37-7611-48d9-ad22-f0272cf05a25"), "ARMENIA", DateTime.ParseExact(DateTime.Now.ToString(FormatingConstants.FullTimeFormat), FormatingConstants.FullTimeFormat, CultureInfo.InvariantCulture), "US Dollar", 1, null },
                    { new Guid("c3089d50-167e-41dc-86d0-b629d10117e4"), "TAJIKISTAN", DateTime.ParseExact(DateTime.Now.ToString(FormatingConstants.FullTimeFormat), FormatingConstants.FullTimeFormat, CultureInfo.InvariantCulture), "US Dollar", 1, null },
                    { new Guid("c4918b22-f403-40c5-9e0f-98f793669206"), "SWITZERLAND", DateTime.ParseExact(DateTime.Now.ToString(FormatingConstants.FullTimeFormat), FormatingConstants.FullTimeFormat, CultureInfo.InvariantCulture), "Swiss Franc", 6, null },
                    { new Guid("c684b19b-f8b9-41fb-bda1-528ba876c2b0"), "PAKISTAN", DateTime.ParseExact(DateTime.Now.ToString(FormatingConstants.FullTimeFormat), FormatingConstants.FullTimeFormat, CultureInfo.InvariantCulture), "US Dollar", 1, null },
                    { new Guid("c989a377-4721-4829-81b6-7db047c32b1e"), "TURKMENISTAN", DateTime.ParseExact(DateTime.Now.ToString(FormatingConstants.FullTimeFormat), FormatingConstants.FullTimeFormat, CultureInfo.InvariantCulture), "US Dollar", 1, null },
                    { new Guid("cafa0d04-ca34-4e5b-8af2-e576d2dee32a"), "SPAIN", DateTime.ParseExact(DateTime.Now.ToString(FormatingConstants.FullTimeFormat), FormatingConstants.FullTimeFormat, CultureInfo.InvariantCulture), "Euro", 3, null },
                    { new Guid("ceb1d3f1-925e-49d9-9cb2-352ce3259711"), "MOLDOVA", DateTime.ParseExact(DateTime.Now.ToString(FormatingConstants.FullTimeFormat), FormatingConstants.FullTimeFormat, CultureInfo.InvariantCulture), "US Dollar", 1, null },
                    { new Guid("d2cad772-5120-4273-b42a-fa4239a15893"), "NORTH MACEDONIA", DateTime.ParseExact(DateTime.Now.ToString(FormatingConstants.FullTimeFormat), FormatingConstants.FullTimeFormat, CultureInfo.InvariantCulture), "Euro", 3, null },
                    { new Guid("d779b169-c84a-442a-9d15-ee6dd788c177"), "FRANCE", DateTime.ParseExact(DateTime.Now.ToString(FormatingConstants.FullTimeFormat), FormatingConstants.FullTimeFormat, CultureInfo.InvariantCulture), "Euro", 3, null },
                    { new Guid("d8c54bdb-8df1-478b-af21-06c5a10f21a8"), "LIECHTENSTEIN", DateTime.ParseExact(DateTime.Now.ToString(FormatingConstants.FullTimeFormat), FormatingConstants.FullTimeFormat, CultureInfo.InvariantCulture), "Euro", 3, null },
                    { new Guid("d994d35e-06b9-411d-bd13-7b706875d7d9"), "NICARAGUA", DateTime.ParseExact(DateTime.Now.ToString(FormatingConstants.FullTimeFormat), FormatingConstants.FullTimeFormat, CultureInfo.InvariantCulture), "US Dollar", 1, null }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "CountryName", "CreatedDate", "Currency", "CurrencyCode", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("e033413a-7eb6-4d9a-a731-d62fe5d6d62f"), "ALGERIA", DateTime.ParseExact(DateTime.Now.ToString(FormatingConstants.FullTimeFormat), FormatingConstants.FullTimeFormat, CultureInfo.InvariantCulture), "US Dollar", 1, null },
                    { new Guid("e0f992c6-39ed-436d-b2c9-c1e32fcfcc91"), "KUWAIT", DateTime.ParseExact(DateTime.Now.ToString(FormatingConstants.FullTimeFormat), FormatingConstants.FullTimeFormat, CultureInfo.InvariantCulture), "US Dollar", 1, null },
                    { new Guid("e2ce2fc4-efab-426e-b24f-ef235a21c7a8"), "GHANA", DateTime.ParseExact(DateTime.Now.ToString(FormatingConstants.FullTimeFormat), FormatingConstants.FullTimeFormat, CultureInfo.InvariantCulture), "US Dollar", 1, null },
                    { new Guid("e59c32c3-6b48-46f2-9d93-2753e3348812"), "BOSNIA AND HERZEGOVINA", DateTime.ParseExact(DateTime.Now.ToString(FormatingConstants.FullTimeFormat), FormatingConstants.FullTimeFormat, CultureInfo.InvariantCulture), "Euro", 3, null },
                    { new Guid("e92c981f-44f1-4879-8e69-bffb51b49d2f"), "PERU", DateTime.ParseExact(DateTime.Now.ToString(FormatingConstants.FullTimeFormat), FormatingConstants.FullTimeFormat, CultureInfo.InvariantCulture), "US Dollar", 1, null },
                    { new Guid("ebca05fb-0bd5-48b7-9c96-4864626f34a9"), "SINGAPORE", DateTime.ParseExact(DateTime.Now.ToString(FormatingConstants.FullTimeFormat), FormatingConstants.FullTimeFormat, CultureInfo.InvariantCulture), "US Dollar", 1, null },
                    { new Guid("eec177ce-7437-49f3-9918-da3694fcee5b"), "MALTA", DateTime.ParseExact(DateTime.Now.ToString(FormatingConstants.FullTimeFormat), FormatingConstants.FullTimeFormat, CultureInfo.InvariantCulture), "Euro", 3, null },
                    { new Guid("f06ff73b-a2c4-46f3-b33d-d6074a2a4731"), "GIBRALTAR", DateTime.ParseExact(DateTime.Now.ToString(FormatingConstants.FullTimeFormat), FormatingConstants.FullTimeFormat, CultureInfo.InvariantCulture), "Euro", 3, null },
                    { new Guid("f0ec1a1a-9cc1-4e20-b33f-841e95ba9515"), "ITALY", DateTime.ParseExact(DateTime.Now.ToString(FormatingConstants.FullTimeFormat), FormatingConstants.FullTimeFormat, CultureInfo.InvariantCulture), "Euro", 3, null },
                    { new Guid("f2d04b05-8b94-4cdb-9925-bc68ada21950"), "JORDAN", DateTime.ParseExact(DateTime.Now.ToString(FormatingConstants.FullTimeFormat), FormatingConstants.FullTimeFormat, CultureInfo.InvariantCulture), "US Dollar", 1, null },
                    { new Guid("f35f9a86-3653-40e7-88a7-8873fd960ee0"), "BANGLADESH", DateTime.ParseExact(DateTime.Now.ToString(FormatingConstants.FullTimeFormat), FormatingConstants.FullTimeFormat, CultureInfo.InvariantCulture), "US Dollar", 1, null },
                    { new Guid("f3bc7bbb-780f-460f-bf99-476736b8d5c0"), "POLAND", DateTime.ParseExact(DateTime.Now.ToString(FormatingConstants.FullTimeFormat), FormatingConstants.FullTimeFormat, CultureInfo.InvariantCulture), "Euro", 3, null },
                    { new Guid("f945938b-d3aa-4c55-b534-4be99a32ff17"), "CANADA", DateTime.ParseExact(DateTime.Now.ToString(FormatingConstants.FullTimeFormat), FormatingConstants.FullTimeFormat, CultureInfo.InvariantCulture), "US Dollar", 1, null },
                    { new Guid("f96eb017-5ace-4451-b93a-d6d3cc5a773e"), "GEORGIA", DateTime.ParseExact(DateTime.Now.ToString(FormatingConstants.FullTimeFormat), FormatingConstants.FullTimeFormat, CultureInfo.InvariantCulture), "US Dollar", 1, null },
                    { new Guid("fa448394-0b93-4935-bcfc-a29b6734b134"), "BELARUS", DateTime.ParseExact(DateTime.Now.ToString(FormatingConstants.FullTimeFormat), FormatingConstants.FullTimeFormat, CultureInfo.InvariantCulture), "US Dollar", 1, null },
                    { new Guid("fb634b20-aafa-409c-8a82-1325e5b26a3e"), "ZIMBABWE", DateTime.ParseExact(DateTime.Now.ToString(FormatingConstants.FullTimeFormat), FormatingConstants.FullTimeFormat, CultureInfo.InvariantCulture), "US Dollar", 1, null },
                    { new Guid("fbb90b66-e567-4d8c-8854-4deefca312fc"), "MEXICO", DateTime.ParseExact(DateTime.Now.ToString(FormatingConstants.FullTimeFormat), FormatingConstants.FullTimeFormat, CultureInfo.InvariantCulture), "US Dollar", 1, null },
                    { new Guid("fbe06a69-5a09-4d52-b766-7749cd7c6e35"), "CHILE", DateTime.ParseExact(DateTime.Now.ToString(FormatingConstants.FullTimeFormat), FormatingConstants.FullTimeFormat, CultureInfo.InvariantCulture), "US Dollar", 1, null },
                    { new Guid("ff0731c9-772f-428e-89fa-fe59fee1be85"), "NETHERLANDS", DateTime.ParseExact(DateTime.Now.ToString(FormatingConstants.FullTimeFormat), FormatingConstants.FullTimeFormat, CultureInfo.InvariantCulture), "Euro", 3, null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("054ae920-822c-4887-980b-2f90057be323"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("0c7fc53a-d085-4250-ac2b-12c6e6714a08"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("0de631d5-466d-40a8-ac06-08ef082cd1a0"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("12c08437-e23d-42ff-aa8e-c15cfc49cc1e"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("14b0a82b-c9b7-4dd9-9ec1-6bdbadf3ae6e"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("179bc570-ff28-4188-8062-8beca0674888"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("17d16d90-0c4e-491a-979b-76a5146f2808"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("2020a24b-88a3-4c46-ba40-bc64b81ce093"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("235d64bb-3fbf-4cc7-be87-89e1abef61cd"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("25207346-2489-4abf-b00a-d3d46661212f"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("2d9af68d-e0c8-427f-9d40-b1631715f4e3"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("2d9da4bb-fb82-4482-908a-6ac3b5bf2a4a"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("2faa1655-a4e0-49a3-a905-71eb08ae01ad"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("303f76e5-2460-4600-ae5c-795f084064a0"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("34434a82-ec72-4a1c-94df-4f5b5032ac5e"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("347dc592-7e86-4c15-b59b-65d52e161a8d"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("35c5cb44-9b8a-4fb9-9cfc-cec8eb0ac673"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("3817ffcf-14b6-4898-90ae-ab52d0f2cab8"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("38f13134-269b-4918-b857-4b69f617063e"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("3a3af9bc-3a9e-414c-831c-0b37bccc46ba"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("3c9bb88b-dff9-4c39-b7e5-6b3914f52ef4"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("3d68d5c0-ca83-49e4-adb0-548cadf9b465"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("3e022d17-2837-4a91-8850-8123889ebddd"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("432a67c7-518a-4a2c-aa47-82252ba5e023"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("49d80ff5-f4b3-4c99-99b8-6b9966b8d490"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("4d072d95-9483-4be7-98da-344b52cdd0bb"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("4d9b9ffe-c165-428e-825e-dab1bb6b6bfd"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("4e6d506c-87bd-460b-8756-c51ab4be2583"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("4ee4e347-3026-4edb-b72f-280f0c286200"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("565bce56-6751-4692-913b-d7605aa88843"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("573b03c1-c997-4fa3-b46f-089fdad19cd5"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("5b297d8e-3ab4-4e03-aa63-667314c145fa"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("5bebe8d1-1d0c-4294-a518-e07df509f201"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("6d3afe47-e20b-4b61-b57d-274e55be1235"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("6ebc7f7d-7181-4b75-a21b-5cc5a6bd8c07"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("704886d4-45a9-49ad-990d-8e2f8db8bcc5"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("71e72b19-8639-4804-9f01-c00feb87cf03"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("7ad02002-d76c-4f78-bed8-6c77785ee068"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("7b6aace4-731b-4528-903f-45404a9b463c"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("7d2804e7-e6ce-433d-bbf2-ea6fa21f3fb8"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("7d2abafc-d5b8-46b6-963a-5451bd3b5cb6"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("7e2a0d8e-bf3e-459c-a931-8f5895cf74eb"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("81a795a3-1b74-4e10-89b1-7cd4081125f1"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("81e490d8-8569-4872-8449-d00b917625b6"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("83c2f7a4-f4e2-4e21-8826-dfca9112acf7"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("83e0fe3e-bfa2-4bb3-8304-371bad7b4181"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("84b9a341-7615-42f3-9767-29e66db3e586"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("8b73da44-a5f8-4db4-9b36-92f9bad886d9"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("8bd41c75-33bb-41b4-b257-dd8e3ea6879c"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("8f0c2d33-34cf-4a70-8260-18e4c888247a"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("8ff5374a-0081-46f1-94d5-5e4e9525a223"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("928d8869-f99d-4496-b04c-9fa4e4806938"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("93c952ca-4dc7-412e-8578-ab870a18ef3f"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("94440f56-8a73-4b2c-b63e-acd1126728ab"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("977f86b2-7ce2-4c89-8ace-f732dd7a8a14"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("9de0b25e-09dd-4d3d-86a1-ed131a5624da"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("9ec06ecc-545a-466e-aed0-1c9f2dd100a8"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("9f30b544-8639-468b-b275-e79e45bf8137"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("9f5432e9-7f39-4ec0-8d34-07dd0da15613"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("9fb2ceb7-9fcc-43fc-b645-4513247f10ef"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a480ab84-5a04-4a16-b136-c4e8f2ede1e8"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a79549a0-ab5d-4d4d-a5d0-a97f0cabd0d3"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("ae11fa10-a146-4ddc-a914-6010a01604dd"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("b001e1c8-ec60-4d76-816c-00ca9befff02"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("b065dc2f-00aa-4af8-aca6-1d37905f15c4"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("b08c34dc-e20b-41c6-a073-4293eaf01d3c"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("b1318e0a-d111-4822-9c1d-073cea549b5e"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("b6190653-e7ef-4de6-939f-3c03d39ce83d"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("b6c4a8fa-1f92-4c2a-b0d0-71c9db72a8be"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("b940f8d6-0a41-489a-aab5-d6d64c06dc7a"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("bcfc73c4-277b-4479-9899-a934bdde2dee"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("bfc163c9-f937-4ac1-97eb-7aac7a0689fd"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("c0f550b1-1466-4fbc-b740-07737dbf74c7"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("c198fd37-7611-48d9-ad22-f0272cf05a25"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("c3089d50-167e-41dc-86d0-b629d10117e4"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("c4918b22-f403-40c5-9e0f-98f793669206"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("c684b19b-f8b9-41fb-bda1-528ba876c2b0"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("c989a377-4721-4829-81b6-7db047c32b1e"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("cafa0d04-ca34-4e5b-8af2-e576d2dee32a"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("ceb1d3f1-925e-49d9-9cb2-352ce3259711"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("d2cad772-5120-4273-b42a-fa4239a15893"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("d779b169-c84a-442a-9d15-ee6dd788c177"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("d8c54bdb-8df1-478b-af21-06c5a10f21a8"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("d994d35e-06b9-411d-bd13-7b706875d7d9"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("e033413a-7eb6-4d9a-a731-d62fe5d6d62f"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("e0f992c6-39ed-436d-b2c9-c1e32fcfcc91"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("e2ce2fc4-efab-426e-b24f-ef235a21c7a8"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("e59c32c3-6b48-46f2-9d93-2753e3348812"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("e92c981f-44f1-4879-8e69-bffb51b49d2f"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("ebca05fb-0bd5-48b7-9c96-4864626f34a9"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("eec177ce-7437-49f3-9918-da3694fcee5b"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f06ff73b-a2c4-46f3-b33d-d6074a2a4731"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f0ec1a1a-9cc1-4e20-b33f-841e95ba9515"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f2d04b05-8b94-4cdb-9925-bc68ada21950"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f35f9a86-3653-40e7-88a7-8873fd960ee0"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f3bc7bbb-780f-460f-bf99-476736b8d5c0"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f945938b-d3aa-4c55-b534-4be99a32ff17"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f96eb017-5ace-4451-b93a-d6d3cc5a773e"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("fa448394-0b93-4935-bcfc-a29b6734b134"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("fb634b20-aafa-409c-8a82-1325e5b26a3e"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("fbb90b66-e567-4d8c-8854-4deefca312fc"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("fbe06a69-5a09-4d52-b766-7749cd7c6e35"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("ff0731c9-772f-428e-89fa-fe59fee1be85"));
        }
    }
}
