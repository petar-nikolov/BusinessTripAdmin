using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BusinessTripAdmin.Infrastructure.Data.Migrations
{
    public partial class ChangeCountryAndAllowanceReference : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Countries_Allowances_AllowanceId",
                table: "Countries");

            migrationBuilder.DropIndex(
                name: "IX_Countries_AllowanceId",
                table: "Countries");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("0171d43f-8c62-4768-9817-9e1f9ee4cf6b"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("03519c76-a907-4837-be51-05d2d6881b5c"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("04ea2746-2971-4157-bbe9-ffe261fb61ec"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("04efaed0-ed27-4787-a28c-fafc0951c013"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("072ecd10-d5e7-44be-b52a-315100450e9d"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("072f171f-118b-45ef-b9b4-7846b58097eb"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("07e70607-7278-4186-895b-f9c7a9839642"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("0c56bb71-576a-48be-bb07-e0266555508b"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("0d779a8a-3a97-460a-afac-f46b108dcefa"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("0f72aea7-4510-4c7f-83d3-44f46445cfeb"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("17ca8de5-0ef5-4df8-9fb9-bed1a007ae3d"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("19039f30-63ff-4607-8aac-62a4524a5439"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("19dd5bb1-8b94-4836-9136-0b3da6c767d3"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("1b8ada37-4d89-49a1-b22e-2de686ca9c9d"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("1c35e41d-c676-4b54-a146-fd9a4286bddd"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("1d09813c-071c-4af4-a808-86fa443b2e1f"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("25d38cca-99d9-4d1d-81b8-e7685d3fc9b6"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("26cf78d6-1112-4bd3-9ac2-caeb1ed1b35c"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("27492d74-1816-4e72-9228-ca4c14d61156"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("2b9d3936-f203-4464-bc05-87fc755c090c"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("34b9e323-3c96-446d-b102-b547517c8b33"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("3740c888-f4f3-400a-ad1f-c0e4503f3650"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("3b1d5651-3236-4bd5-a761-72dfc87e651d"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("3e43d43e-3968-445d-b6e5-dae6fae77ee5"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("4449d2d9-05a8-420c-b820-d27406d2ab3f"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("46971384-dffc-4569-b57a-46b517bc7189"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("487eae95-2b73-4b3e-bbad-22103ca1e105"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("4c7524b5-eb96-435c-b6b5-8debae8079de"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("4fece437-55c0-4834-a2f3-3b8d5cb24360"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("501fce34-ad8e-48a1-ad7d-c9053d1a59e0"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("51c253e5-88fe-4d5f-98b9-f58998d7225d"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("55a0b395-005a-4aff-bb13-d1f0eab0afa0"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("58b6fced-adf1-47e1-ad9c-7cca55f45239"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("5f72d977-ea98-4e79-b87a-c42a9b249564"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("5f7f8a40-ce63-4f6d-a54f-0311088fcb54"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("6151e537-6ef0-4096-9359-666b694f5177"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("6398a269-0718-4bdc-8c98-77a958335562"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("668574bd-69af-4252-9762-496ed50d9c2a"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("67ea1920-8d60-468b-b3d3-c85cd8bb72af"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("6816ad0d-692b-44fe-810e-e1065dd11702"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("6a33dc2f-1e13-4aee-94ec-46f30131dc58"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("6b86425e-0117-4255-b216-fb0cbca56497"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("6b8ce55e-54d1-41c9-8434-e8996fd73676"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("6e21024f-aaae-419b-9f7a-8a2ccf76475c"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("72907ea2-d49f-44c2-ae84-10a1175aa44a"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("739a8bc3-c915-4d5b-8bfb-02513b3889be"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("75a15105-3e44-4d6a-a9f7-31bf33accea2"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("77337043-d24d-458c-9eda-537e0c6c0360"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("7b8f9cd6-2137-4b42-9d9a-61b8a37c03ca"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("7e76511a-e060-4c60-954f-9aca820833bb"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("828bdf92-eb2f-4472-9007-4d5dacaac31e"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("838f0a41-7308-492d-b225-6dba3c578f4a"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("8615ec1b-02b8-4a6b-a2f1-dd16d1f76fd4"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("86c0ee4a-b5f6-4072-8ec7-8393a1a8fa89"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("8e948de8-3356-453d-a38b-e6a96f76ce9e"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("91424961-f77d-4d7e-ac0e-abff5290f677"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("929fa6da-935a-46b9-9d5b-8c27ebdfd530"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("9336478f-dadb-422e-9fa7-dbbea3c8e0e7"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("9405d658-596e-4df1-8cff-d8c4427cfdab"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("9442945e-52f4-40a4-a1a5-6a84d9614494"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("960684b3-f2cd-4cf2-b862-b4913622ae54"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("98a23067-cd74-40ac-9764-03a2cf4fbb1f"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("9a863eb0-e38a-4f2c-8c8c-ed7a95455e9d"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("9b2831b7-8b7b-4ca6-be2e-e9e26aa90d32"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("9bdb544c-8cb7-4f22-9b19-86e0a75c12a4"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("9c7946a1-4524-4757-94f1-f4cc4c6c93f1"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("9d656001-2c04-4bbe-822f-b87ca4c0e25d"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a1e22589-a877-4fc6-8801-bc5141496f2d"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a4799926-eef6-4e82-a81f-3aeb7820f0a9"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a4ce4203-53dc-42c4-a68e-ac716fd38c63"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a7c15a4b-4071-4298-8f1a-59d030cad703"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a9fd8eb0-3561-4942-bfd9-e1cc34faa42b"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("ac4c481d-819f-41b9-bd4c-4af0ae8c9a17"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("ac578b7f-0dc3-44a9-bdaf-ade125be47b4"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("b04b0ca1-0613-414e-88fe-637fb4da1b3a"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("b52db7b9-d4a2-4ffa-a46b-fe6b17feac3c"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("b6b82ed7-8bd1-4be1-b136-92983fca047e"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("c04651b9-2273-4879-836e-098d7dd4a0c2"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("c086ead6-652d-496a-a30c-0e0126f1bf44"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("c3d58132-68fd-4d48-aa51-cdd8345edac7"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("c4723281-e6ed-4704-89c9-e451e0a1942a"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("c5283b45-d9fe-41e9-90f6-9b7ef2896509"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("c8163e0a-f770-401d-9875-87a994859d33"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("c94834cf-a039-422d-9894-54a91d37112d"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("ca914db1-7265-48c8-8533-13d3e1347c2a"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("cd6a2ac3-1ad0-4b0e-b3f9-d9a886ff4375"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("cd9428c4-21eb-4f00-b45a-6cfc0336cf0f"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("daf60eca-fc2e-4c6f-bccb-90ef35a45986"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("db1315bc-a82b-44bd-bd81-0c7b284a5872"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("ddab0dde-2a0f-48c3-aa24-2aaa0c3c0107"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("ddd1dbad-8c82-4cd0-92ba-dde21677d976"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("e8370c66-1db9-4852-a085-f4ba0f804dd7"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("ebf2dbc3-7fb7-4896-a318-a15cc747985c"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("ee2b4ec1-c0bd-4e31-bb2a-c103cc091a10"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("ef5a6d75-d07b-480b-b7f2-a67ccb2e9253"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f36c4eb3-edb2-421b-8cb7-fb49988364df"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f533655d-ac23-498f-b6f3-9bf20a6cf288"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f8d13ffe-6d17-4cb4-9e50-466824e43dd6"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f91128f6-884f-4014-8a8e-a6e201cfff26"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f9cdc137-17d0-44ac-a685-43768c706e27"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f9d1b0c4-a721-4c0e-8673-9df7c4ef7d47"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("fcbb9384-8230-4944-bfb1-f80f857b0d35"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("ff53cc35-f1ad-4a85-920c-bc32015416e2"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("00ad8d4a-e72c-41d6-bb81-edf4f64acb8e"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("02970355-55c1-48f0-8bef-1a8be71523df"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("02d82f8f-dbda-404a-97f6-812a3d5067bf"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("0645fd2f-05bb-4f78-97ef-ebbcc8bcfcb8"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("0ea17996-d872-4964-a7a7-ced9202fae69"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("0f69d2de-b9ab-4ca8-9187-17e5b79547ec"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("10bda487-6683-4f67-993e-5c31db9e30ac"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("12a9bf58-2e44-4e2a-89b7-2f2b0305a270"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("13db70b1-f633-4c3f-b705-811f2f84a820"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("16c1a356-37f6-4ece-b94d-f258edfe759e"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("1d3c32c5-bf51-4a16-a6ac-c74fa33f6b69"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("1f73d32b-92e0-4241-85a9-5689af012327"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("20e5e3a5-b5c6-4b9f-8d44-99ff2e4fc37c"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("2371ea15-c84e-4788-b37c-ba9993a6e6fc"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("2517e37f-8de9-4999-bf65-da4f970e7b89"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("2939cb6d-2bf5-419c-b564-c85fcf225be0"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("2976c8d2-2ba1-4873-b230-c54f3cae1960"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("2bb67519-7b2d-47e0-8749-5c39fd432a1a"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("2c61ceba-1337-46bc-9196-7c837ffd0a87"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("3051ace1-3e51-476b-8122-4d80342f0527"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("30a98fed-3c5a-4122-b909-76322bf7da27"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("35d19bd9-c0ca-4868-8bcc-d9648b8c7d32"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("3885e322-4b2e-439e-9209-6079a6231f3b"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("3b3f219e-7407-4a6d-af78-e8a5874519f9"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("3ba1c271-d10b-4b99-8b71-514b278b1278"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("41edba2d-cd21-450f-ab00-6e2a340502a7"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("45d51c75-d2c8-49b8-9583-8afccd7e63c3"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("4766dfa9-edf6-49dd-808b-a4307482cd5d"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("4b2909bd-f643-423a-8d4e-097ba6ea23a1"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("4e13fa64-adeb-48bd-9848-e6d6f4fb412b"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("4febddc4-9b28-4fe1-889c-2daa5760b157"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("534b24b0-5ec3-4fee-9923-754174fba122"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("5401d1c7-04f7-4f4e-b8aa-8027e026ee3e"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("5416e64a-7c37-4d80-953a-f91007dce23b"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("5463c3f6-bdcd-4423-98de-b4a92926b446"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("58936f86-63bc-4f61-9702-d93e3c2206a8"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("5b4d0d03-a3d6-4180-9e79-635be3342215"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("6107aa1d-d4fa-44f4-aa84-c8b38aee7f51"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("64d065c7-8529-4a22-910f-a79402e90ff6"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("650c6e13-69d1-4171-b830-9e209078317d"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("65334cb4-873a-4a03-afd8-f07f7c2ccc42"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("66f74543-9c32-4484-88bf-0fe8e21d1626"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("67753716-6e68-4c9e-8362-c63837a48c72"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("69e09840-ba71-4757-9825-b1ad136fde1e"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("6a54dafb-3975-434d-8f35-f81eaa4e71bc"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("6bcf9b90-08ed-4c11-8a19-86b4a2da0608"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("6f9d9500-5ee8-4a1a-890e-2be26859aaa1"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("72cae632-8245-494d-a747-68c7ffccef57"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("77b352f6-96b2-441e-a1f3-030dc7723141"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("7ea3468d-8d53-4f8c-8519-5b128ca371f4"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("7ff60891-9204-4a03-a41a-fbe8f51ab8fd"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("8356ed9f-2867-4447-ac7e-8aa4c0aa3f33"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("895e574f-5fa8-4003-ba84-b3517170dd8a"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("8cf0dc78-9ff3-4718-8761-df4b482a1a80"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("8f640311-c97d-47b4-a7b8-61b1d7c074a4"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("8ff1dd7b-fda9-4d91-8669-8a5b5d81f6f2"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("8ffaf79d-fa43-4b5f-ab4a-7578e2a80621"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("920afa6b-444a-428c-b7bc-e3c848fcc290"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("9330554a-2fa6-43dd-a818-4ffc6b95e0e1"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("954a2a0b-a892-47fd-bba8-0b0ff927f879"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("973834d7-d00b-46f7-980f-efffbf3466ea"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("9ca42a61-39e4-42e7-af3b-e31e0decfc5f"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("9e26960c-bb43-48b6-940d-4d79b06ff775"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("9e49e28a-aa38-4c85-b834-6cf448100a07"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("aa4bc67d-f0fa-48b1-a09d-8a794d2a0151"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("ac770d6f-4cc0-4652-979a-cbf8092b40da"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("ae7f422b-c99d-4f5f-822f-0da96db4036b"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("b4651cb7-3215-4eb3-b3eb-766009e549c0"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("b90ef163-402c-4ca8-84e4-d1c5a9c2129e"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("b9d52c9b-19f9-447d-b453-f8f29dd7f54a"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("bd1d3160-73b9-49b9-99f8-4fcc4647859e"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("bd2fb50e-520d-4612-93a2-0e0f6a7e1de2"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("be04b946-d0e2-4884-a7fa-216d20e6cb54"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("be5ae145-839c-4b71-abe6-81e102c9361d"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("c10d3147-790a-457c-8bfd-7e7209d27bc4"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("c39c5c8e-246e-44f6-8f95-23ceb480986d"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("c4f90e0f-6d83-4676-a3db-f52de347742c"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("c64fabb5-8bda-4723-b80e-d2880b1b65dd"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("c9561369-3b44-4e16-a80b-2493be385bc5"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("cab9b92f-f902-486f-881b-cbf960c1d523"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("cb342ff9-eb1a-44f0-a744-3c88b9b449a3"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("cb91fdd8-f819-4427-a513-bafcc0aa764e"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("d313e13e-c737-4fe1-b08b-bdcf4b78ca65"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("d48d8567-fff5-4287-9183-6a69a5be649c"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("d652469c-9c0a-450d-a164-f4f1b3011353"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("d878154f-aa86-40e8-9b45-e0373302a241"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("d92c0c3e-0a05-4c2c-9480-65307ddc5df1"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("e0f776b7-1506-4545-8021-de020b5a01f2"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("e255cd0a-06c6-40c0-9c48-c3a15c993141"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("e3d66d56-e220-428c-820d-73ca94db334c"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("e49ea94b-f0dc-47e0-a76f-20f98f4c1cbb"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("e56e3eca-e1e1-4b53-b9b6-ce8710512c8c"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("eb48beb4-fe01-4657-b73f-0b7a4ba660f6"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("ee76912c-8c45-45f4-9301-a92906547f66"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("ee88d394-f6fb-4523-aa1a-b4dae8218ed0"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("f069d9df-4eb7-443a-b10b-9ecfbfa545d7"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("f22fea04-ce17-43e3-95d7-2b99ad4b0773"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("f59ca9bb-cf81-43de-96e1-8eafadc6c5f4"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("f5b8894b-4445-4a47-b957-b7de13df8d98"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("f87f9287-3fe4-4f45-a7fc-09e4e9fee017"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("fa25df3a-e3c5-48db-9e9a-b69dd0b41635"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("fa4ed1e3-afeb-4d4f-9a88-5ce93a29b1f0"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("fffcf1e8-f2cb-423c-8457-7f63615e449b"));

            migrationBuilder.DropColumn(
                name: "AllowanceId",
                table: "Countries");

            migrationBuilder.AddColumn<Guid>(
                name: "CountryId",
                table: "Allowances",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "CountryName", "CreatedDate", "CurrencyCode", "Description", "LocalCurrency", "TripCurrency", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("00c06fc7-1bfd-4d41-9685-184076bcbd45"), "LIECHTENSTEIN", new DateTime(2022, 4, 4, 11, 15, 59, 0, DateTimeKind.Unspecified), 3, null, null, "Euro", null },
                    { new Guid("00fc91a4-b045-4882-911c-e053eaf97386"), "SWITZERLAND", new DateTime(2022, 4, 4, 11, 15, 59, 0, DateTimeKind.Unspecified), 6, null, null, "Swiss Franc", null },
                    { new Guid("015490f3-7c44-404c-9984-57aa491a8e8e"), "INDIA", new DateTime(2022, 4, 4, 11, 15, 59, 0, DateTimeKind.Unspecified), 1, null, null, "US Dollar", null },
                    { new Guid("01be237e-2109-4e53-8439-d158fc52dfb6"), "UNITED STATES", new DateTime(2022, 4, 4, 11, 15, 59, 0, DateTimeKind.Unspecified), 1, null, null, "US Dollar", null },
                    { new Guid("03055f5b-21ec-4b58-bbde-ed31909ae41f"), "MEXICO", new DateTime(2022, 4, 4, 11, 15, 59, 0, DateTimeKind.Unspecified), 1, null, null, "US Dollar", null },
                    { new Guid("0339b38e-3249-47d2-a671-89d0e30a7087"), "FINLAND", new DateTime(2022, 4, 4, 11, 15, 59, 0, DateTimeKind.Unspecified), 3, null, null, "Euro", null },
                    { new Guid("0e2062e2-886d-4113-9f8f-10a6445a9448"), "SERBIA", new DateTime(2022, 4, 4, 11, 15, 59, 0, DateTimeKind.Unspecified), 3, null, null, "Euro", null },
                    { new Guid("10681bd7-1677-40a3-b789-966eb703ccea"), "LUXEMBOURG", new DateTime(2022, 4, 4, 11, 15, 59, 0, DateTimeKind.Unspecified), 3, null, null, "Euro", null },
                    { new Guid("115a365c-1d44-485e-861b-de29ecd605e2"), "NICARAGUA", new DateTime(2022, 4, 4, 11, 15, 59, 0, DateTimeKind.Unspecified), 1, null, null, "US Dollar", null },
                    { new Guid("12414a82-36b4-4224-8296-4b0dca96c342"), "PORTUGAL", new DateTime(2022, 4, 4, 11, 15, 59, 0, DateTimeKind.Unspecified), 3, null, null, "Euro", null },
                    { new Guid("19920de9-cc87-467d-9aab-76f88e71da71"), "SOUTH AFRICA", new DateTime(2022, 4, 4, 11, 15, 59, 0, DateTimeKind.Unspecified), 1, null, null, "US Dollar", null },
                    { new Guid("2124be6e-f056-4157-82c9-9be3e96b4aab"), "COTE D'IVOIRE", new DateTime(2022, 4, 4, 11, 15, 59, 0, DateTimeKind.Unspecified), 1, null, null, "US Dollar", null },
                    { new Guid("218522d4-2f31-4cbe-9dc3-70046ad8c378"), "BELARUS", new DateTime(2022, 4, 4, 11, 15, 59, 0, DateTimeKind.Unspecified), 1, null, null, "US Dollar", null },
                    { new Guid("262eadab-aa80-4424-8005-364349c19807"), "TURKMENISTAN", new DateTime(2022, 4, 4, 11, 15, 59, 0, DateTimeKind.Unspecified), 1, null, null, "US Dollar", null },
                    { new Guid("2b54175a-8b58-48f1-b8b7-25ca47b7cd3c"), "JORDAN", new DateTime(2022, 4, 4, 11, 15, 59, 0, DateTimeKind.Unspecified), 1, null, null, "US Dollar", null },
                    { new Guid("34b07072-37ea-4758-add5-a9147ae6251a"), "PERU", new DateTime(2022, 4, 4, 11, 15, 59, 0, DateTimeKind.Unspecified), 1, null, null, "US Dollar", null },
                    { new Guid("34ce1795-938a-46cd-881d-7dd56a2e9de7"), "SOUTH KOREA", new DateTime(2022, 4, 4, 11, 15, 59, 0, DateTimeKind.Unspecified), 1, null, null, "US Dollar", null },
                    { new Guid("36a4d56a-7fbb-4a92-991c-81dff2f90992"), "MOROCCO", new DateTime(2022, 4, 4, 11, 15, 59, 0, DateTimeKind.Unspecified), 3, null, null, "Euro", null },
                    { new Guid("36e238d7-59c2-494c-8f3f-be5db488c634"), "CHINA", new DateTime(2022, 4, 4, 11, 15, 59, 0, DateTimeKind.Unspecified), 1, null, null, "US Dollar", null },
                    { new Guid("37334fd7-fa74-40b6-bd53-112482408f98"), "ICELAND", new DateTime(2022, 4, 4, 11, 15, 59, 0, DateTimeKind.Unspecified), 3, null, null, "Euro", null },
                    { new Guid("39da0014-9229-4e0c-b49c-f5e92f74e27f"), "BOSNIA AND HERZEGOVINA", new DateTime(2022, 4, 4, 11, 15, 59, 0, DateTimeKind.Unspecified), 3, null, null, "Euro", null },
                    { new Guid("3c17f104-10d3-4ac8-98a1-febba02132e6"), "UZBEKISTAN", new DateTime(2022, 4, 4, 11, 15, 59, 0, DateTimeKind.Unspecified), 1, null, null, "US Dollar", null },
                    { new Guid("41122216-cdab-49e6-b515-29caa0906249"), "LIBYAN ARAB JAMAHIRIYA", new DateTime(2022, 4, 4, 11, 15, 59, 0, DateTimeKind.Unspecified), 1, null, null, "US Dollar", null },
                    { new Guid("41b2c732-f8a8-4e29-9269-bc43391f7def"), "NORWAY", new DateTime(2022, 4, 4, 11, 15, 59, 0, DateTimeKind.Unspecified), 3, null, null, "Euro", null },
                    { new Guid("41fcafc1-030d-41e2-abcb-d33ba5a1b8f0"), "SAUDI ARABIA", new DateTime(2022, 4, 4, 11, 15, 59, 0, DateTimeKind.Unspecified), 1, null, null, "US Dollar", null },
                    { new Guid("425feebd-555d-48e3-9e53-9f4c2fd37831"), "CANADA", new DateTime(2022, 4, 4, 11, 15, 59, 0, DateTimeKind.Unspecified), 1, null, null, "US Dollar", null },
                    { new Guid("4b5e4a58-a62a-49d9-aa1a-7c537768cf98"), "ETHIOPIA", new DateTime(2022, 4, 4, 11, 15, 59, 0, DateTimeKind.Unspecified), 1, null, null, "US Dollar", null },
                    { new Guid("4f0e9a3b-6823-4688-866d-e78298a4e61e"), "MOLDOVA", new DateTime(2022, 4, 4, 11, 15, 59, 0, DateTimeKind.Unspecified), 1, null, null, "US Dollar", null },
                    { new Guid("5270fc5c-1659-4b2d-872a-dff9a559242b"), "ALL OTHER COUNTRIES", new DateTime(2022, 4, 4, 11, 15, 59, 0, DateTimeKind.Unspecified), 1, null, null, "US Dollar", null },
                    { new Guid("548511c6-cb7c-4f76-be6a-c6df86e3e74a"), "MALAYSIA", new DateTime(2022, 4, 4, 11, 15, 59, 0, DateTimeKind.Unspecified), 1, null, null, "US Dollar", null },
                    { new Guid("5840c7e2-0f43-41c6-9cc7-1762ec7ef3f7"), "MONGOLIA", new DateTime(2022, 4, 4, 11, 15, 59, 0, DateTimeKind.Unspecified), 1, null, null, "US Dollar", null },
                    { new Guid("599ab63d-4375-4542-ab9e-84031d6b2ca6"), "CONGO", new DateTime(2022, 4, 4, 11, 15, 59, 0, DateTimeKind.Unspecified), 1, null, null, "US Dollar", null },
                    { new Guid("5c98b53b-0207-4285-9aaf-9f65e6c7d47d"), "TAJIKISTAN", new DateTime(2022, 4, 4, 11, 15, 59, 0, DateTimeKind.Unspecified), 1, null, null, "US Dollar", null },
                    { new Guid("5e6741a5-b71b-415d-a221-37ed8c247de0"), "MALTA", new DateTime(2022, 4, 4, 11, 15, 59, 0, DateTimeKind.Unspecified), 3, null, null, "Euro", null },
                    { new Guid("5f238cff-8271-41cf-b5ae-c60fe0a0b646"), "CHILE", new DateTime(2022, 4, 4, 11, 15, 59, 0, DateTimeKind.Unspecified), 1, null, null, "US Dollar", null },
                    { new Guid("61913cf9-4615-4149-bdf2-67f8d4f0200d"), "GHANA", new DateTime(2022, 4, 4, 11, 15, 59, 0, DateTimeKind.Unspecified), 1, null, null, "US Dollar", null },
                    { new Guid("656b7936-d631-44ea-88b7-45f6368f0d8b"), "GERMANY", new DateTime(2022, 4, 4, 11, 15, 59, 0, DateTimeKind.Unspecified), 3, null, null, "Euro", null },
                    { new Guid("65a77b64-41c7-497c-abdb-b06cdff185f9"), "KYRGYZSTAN", new DateTime(2022, 4, 4, 11, 15, 59, 0, DateTimeKind.Unspecified), 1, null, null, "US Dollar", null },
                    { new Guid("69e2cd08-b32f-4346-a578-8214980662a9"), "ITALY", new DateTime(2022, 4, 4, 11, 15, 59, 0, DateTimeKind.Unspecified), 3, null, null, "Euro", null },
                    { new Guid("6a632fba-765a-4a10-9159-72466736ee75"), "ANGOLA", new DateTime(2022, 4, 4, 11, 15, 59, 0, DateTimeKind.Unspecified), 1, null, null, "US Dollar", null },
                    { new Guid("6bc8e085-4481-445f-8856-c137b0546760"), "SINGAPORE", new DateTime(2022, 4, 4, 11, 15, 59, 0, DateTimeKind.Unspecified), 1, null, null, "US Dollar", null },
                    { new Guid("6c24042b-9af6-42b5-8944-d8caf7918dc4"), "BELGIUM", new DateTime(2022, 4, 4, 11, 15, 59, 0, DateTimeKind.Unspecified), 3, null, null, "Euro", null }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "CountryName", "CreatedDate", "CurrencyCode", "Description", "LocalCurrency", "TripCurrency", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("6f9bfb1d-bbd2-45dc-99ae-49385cba9c7a"), "NEW ZEALAND", new DateTime(2022, 4, 4, 11, 15, 59, 0, DateTimeKind.Unspecified), 1, null, null, "US Dollar", null },
                    { new Guid("710739da-4f0e-4f81-877b-96e66977173a"), "CYPRUS", new DateTime(2022, 4, 4, 11, 15, 59, 0, DateTimeKind.Unspecified), 3, null, null, "Euro", null },
                    { new Guid("7218bb3a-a464-4ee5-ab2a-aab7dab30002"), "SPAIN", new DateTime(2022, 4, 4, 11, 15, 59, 0, DateTimeKind.Unspecified), 3, null, null, "Euro", null },
                    { new Guid("74ea1ef1-7738-4f40-bcc8-c9f9df1deca2"), "IRAN", new DateTime(2022, 4, 4, 11, 15, 59, 0, DateTimeKind.Unspecified), 1, null, null, "US Dollar", null },
                    { new Guid("75105562-9b3b-4d04-8a4e-514ecc3d1381"), "KENYA", new DateTime(2022, 4, 4, 11, 15, 59, 0, DateTimeKind.Unspecified), 1, null, null, "US Dollar", null },
                    { new Guid("756975e2-cd52-4af7-8832-9d7ef69be2c9"), "AFGHANISTAN", new DateTime(2022, 4, 4, 11, 15, 59, 0, DateTimeKind.Unspecified), 1, null, null, "US Dollar", null },
                    { new Guid("76bacd95-374b-4cdb-bc78-1702085a6470"), "CZECH REPUBLIC", new DateTime(2022, 4, 4, 11, 15, 59, 0, DateTimeKind.Unspecified), 3, null, null, "Euro", null },
                    { new Guid("7d7e1d57-f21c-4b7d-9899-325ba373664e"), "AUSTRALIA", new DateTime(2022, 4, 4, 11, 15, 59, 0, DateTimeKind.Unspecified), 4, null, null, "Australian Dollar", null },
                    { new Guid("7fdd7a1b-b3fb-4917-8964-b4c698410d0f"), "NIGERIA", new DateTime(2022, 4, 4, 11, 15, 59, 0, DateTimeKind.Unspecified), 1, null, null, "US Dollar", null },
                    { new Guid("825d75d1-2b94-471b-822d-4ba628ee6aa8"), "ZIMBABWE", new DateTime(2022, 4, 4, 11, 15, 59, 0, DateTimeKind.Unspecified), 1, null, null, "US Dollar", null },
                    { new Guid("86a72990-ea87-4079-8384-f3b0ec76d06e"), "UNITED ARAB EMIRATES", new DateTime(2022, 4, 4, 11, 15, 59, 0, DateTimeKind.Unspecified), 1, null, null, "US Dollar", null },
                    { new Guid("8c57527f-b0ec-42ed-9ed0-8dca4b03ed67"), "SYRIAN ARAB REPUBLIC", new DateTime(2022, 4, 4, 11, 15, 59, 0, DateTimeKind.Unspecified), 1, null, null, "US Dollar", null },
                    { new Guid("8da9b5dc-9bda-4c91-a3de-5f3b01488923"), "ALGERIA", new DateTime(2022, 4, 4, 11, 15, 59, 0, DateTimeKind.Unspecified), 1, null, null, "US Dollar", null },
                    { new Guid("8f607b90-c24e-405f-97d3-3c9ec5dfceff"), "NORTH KOREA", new DateTime(2022, 4, 4, 11, 15, 59, 0, DateTimeKind.Unspecified), 3, null, null, "Euro", null },
                    { new Guid("9214cc44-741b-4b62-a51d-93745e742c83"), "AZERBAIJAN", new DateTime(2022, 4, 4, 11, 15, 59, 0, DateTimeKind.Unspecified), 1, null, null, "US Dollar", null },
                    { new Guid("92bd5eaa-295b-482f-9d92-c725de38a4b1"), "UNITED KINGDOM", new DateTime(2022, 4, 4, 11, 15, 59, 0, DateTimeKind.Unspecified), 5, null, null, "Pound Sterling", null },
                    { new Guid("93d5a42e-e620-4d8b-a8fa-8f71ab5b6c62"), "LATVIA", new DateTime(2022, 4, 4, 11, 15, 59, 0, DateTimeKind.Unspecified), 3, null, null, "Euro", null },
                    { new Guid("99ff12eb-06a3-4b87-81d2-61ac882ee6eb"), "BANGLADESH", new DateTime(2022, 4, 4, 11, 15, 59, 0, DateTimeKind.Unspecified), 1, null, null, "US Dollar", null },
                    { new Guid("9a391a0b-4f56-43f4-a370-bd42175bbbd5"), "SLOVENIA", new DateTime(2022, 4, 4, 11, 15, 59, 0, DateTimeKind.Unspecified), 3, null, null, "Euro", null },
                    { new Guid("9caa448d-677c-4c45-ac9e-4bd38071e0ce"), "ISRAEL", new DateTime(2022, 4, 4, 11, 15, 59, 0, DateTimeKind.Unspecified), 1, null, null, "US Dollar", null },
                    { new Guid("9d4da082-51c0-434a-b340-6a427100350c"), "KAZAKHSTAN", new DateTime(2022, 4, 4, 11, 15, 59, 0, DateTimeKind.Unspecified), 1, null, null, "US Dollar", null },
                    { new Guid("9d612cdd-b6d8-44a2-b623-deafcf091503"), "EGYPT", new DateTime(2022, 4, 4, 11, 15, 59, 0, DateTimeKind.Unspecified), 1, null, null, "US Dollar", null },
                    { new Guid("a5fe49e6-db27-4f7a-a135-0cb0452572a3"), "LITHUANIA", new DateTime(2022, 4, 4, 11, 15, 59, 0, DateTimeKind.Unspecified), 3, null, null, "Euro", null },
                    { new Guid("a6a8c3f1-03cb-4131-aa4c-78c3e673ee96"), "GREECE", new DateTime(2022, 4, 4, 11, 15, 59, 0, DateTimeKind.Unspecified), 3, null, null, "Euro", null },
                    { new Guid("a9087435-5c10-4871-88cf-3b8f18d1a98b"), "MONACO", new DateTime(2022, 4, 4, 11, 15, 59, 0, DateTimeKind.Unspecified), 3, null, null, "Euro", null },
                    { new Guid("aa10ec4b-16ef-403b-81b5-c68cf3976a11"), "MALI", new DateTime(2022, 4, 4, 11, 15, 59, 0, DateTimeKind.Unspecified), 1, null, null, "US Dollar", null },
                    { new Guid("aac3c372-102c-4acd-b070-1f08643de572"), "NORTH MACEDONIA", new DateTime(2022, 4, 4, 11, 15, 59, 0, DateTimeKind.Unspecified), 3, null, null, "Euro", null },
                    { new Guid("ab4e9c2f-1b62-48cd-a6e1-943384947f4b"), "MOZAMBIQUE", new DateTime(2022, 4, 4, 11, 15, 59, 0, DateTimeKind.Unspecified), 1, null, null, "US Dollar", null },
                    { new Guid("ac691082-93f9-4d88-9f35-bcdc4564bb83"), "ARMENIA", new DateTime(2022, 4, 4, 11, 15, 59, 0, DateTimeKind.Unspecified), 1, null, null, "US Dollar", null },
                    { new Guid("b7fbf291-894c-4dbd-88c4-12bcee6172ca"), "POLAND", new DateTime(2022, 4, 4, 11, 15, 59, 0, DateTimeKind.Unspecified), 3, null, null, "Euro", null },
                    { new Guid("b99ee5a9-41df-4803-ab81-10bdf0c4dffe"), "FRANCE", new DateTime(2022, 4, 4, 11, 15, 59, 0, DateTimeKind.Unspecified), 3, null, null, "Euro", null },
                    { new Guid("c25fc851-f96b-41f8-b270-fe2f8e5da1c6"), "KUWAIT", new DateTime(2022, 4, 4, 11, 15, 59, 0, DateTimeKind.Unspecified), 1, null, null, "US Dollar", null },
                    { new Guid("c2b13821-83ad-4fab-bbe1-85bf7266964b"), "IRAQ", new DateTime(2022, 4, 4, 11, 15, 59, 0, DateTimeKind.Unspecified), 1, null, null, "US Dollar", null },
                    { new Guid("c64566fc-124e-40a8-a281-a3b058a48d2a"), "BRAZIL", new DateTime(2022, 4, 4, 11, 15, 59, 0, DateTimeKind.Unspecified), 1, null, null, "US Dollar", null },
                    { new Guid("c6ac481f-c102-4941-a052-f8dda3dda1e9"), "AUSTRIA", new DateTime(2022, 4, 4, 11, 15, 59, 0, DateTimeKind.Unspecified), 3, null, null, "Euro", null },
                    { new Guid("c898ea68-3bcc-4e86-9335-b75b7cd8129e"), "VIETNAM", new DateTime(2022, 4, 4, 11, 15, 59, 0, DateTimeKind.Unspecified), 1, null, null, "US Dollar", null },
                    { new Guid("c97ecfdc-bb14-4dee-8590-da2a36e24f78"), "YEMEN", new DateTime(2022, 4, 4, 11, 15, 59, 0, DateTimeKind.Unspecified), 1, null, null, "US Dollar", null },
                    { new Guid("cd4eaf6d-c983-4d4a-9ddb-745ecaff2047"), "IRELAND", new DateTime(2022, 4, 4, 11, 15, 59, 0, DateTimeKind.Unspecified), 3, null, null, "Euro", null },
                    { new Guid("d396c12d-39a3-4a66-9acc-433f97988241"), "ALBANIA", new DateTime(2022, 4, 4, 11, 15, 59, 0, DateTimeKind.Unspecified), 3, null, null, "Euro", null },
                    { new Guid("d5c15929-8e99-438a-8c1a-d3706f748e27"), "DENMARK", new DateTime(2022, 4, 4, 11, 15, 59, 0, DateTimeKind.Unspecified), 3, null, null, "Euro", null },
                    { new Guid("d7af0e44-e8d5-45e6-8ac0-f85007ccaa14"), "LEBANON", new DateTime(2022, 4, 4, 11, 15, 59, 0, DateTimeKind.Unspecified), 1, null, null, "US Dollar", null },
                    { new Guid("d9c465da-6f39-4b37-b46d-b1ace9bb814f"), "RUSSIAN FEDERATION", new DateTime(2022, 4, 4, 11, 15, 59, 0, DateTimeKind.Unspecified), 1, null, null, "US Dollar", null }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "CountryName", "CreatedDate", "CurrencyCode", "Description", "LocalCurrency", "TripCurrency", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("da7ee2eb-c755-4bea-9e04-2c9b42c4b8f3"), "INDONESIA", new DateTime(2022, 4, 4, 11, 15, 59, 0, DateTimeKind.Unspecified), 1, null, null, "US Dollar", null },
                    { new Guid("dc581d44-3d53-4ea9-8a56-c6fb0cc11c39"), "JAPAN", new DateTime(2022, 4, 4, 11, 15, 59, 0, DateTimeKind.Unspecified), 7, null, null, "Yen", null },
                    { new Guid("dd541b68-a0b7-4907-8c05-a080c7227b8c"), "GEORGIA", new DateTime(2022, 4, 4, 11, 15, 59, 0, DateTimeKind.Unspecified), 1, null, null, "US Dollar", null },
                    { new Guid("e0430294-eecc-493c-9628-85bb91ac8c97"), "SWEDEN", new DateTime(2022, 4, 4, 11, 15, 59, 0, DateTimeKind.Unspecified), 3, null, null, "Euro", null },
                    { new Guid("e5302020-c497-4f4b-b61a-4c3a56db56cb"), "HUNGARY", new DateTime(2022, 4, 4, 11, 15, 59, 0, DateTimeKind.Unspecified), 3, null, null, "Euro", null },
                    { new Guid("e545ed4f-1670-4c03-b59f-9dc8e15315c8"), "TURKEY", new DateTime(2022, 4, 4, 11, 15, 59, 0, DateTimeKind.Unspecified), 1, null, null, "US Dollar", null },
                    { new Guid("ed69dc78-225a-47ae-8478-09a988c2a61c"), "CROATIA", new DateTime(2022, 4, 4, 11, 15, 59, 0, DateTimeKind.Unspecified), 3, null, null, "Euro", null },
                    { new Guid("ee3bad6f-1d39-44b2-a8dd-76eccedf6ecd"), "ROMANIA", new DateTime(2022, 4, 4, 11, 15, 59, 0, DateTimeKind.Unspecified), 3, null, null, "Euro", null },
                    { new Guid("efa07730-262f-4574-ae1c-61be7938fc32"), "PAKISTAN", new DateTime(2022, 4, 4, 11, 15, 59, 0, DateTimeKind.Unspecified), 1, null, null, "US Dollar", null },
                    { new Guid("f04e3eaa-1a7f-4968-bc35-43231a4c6b4e"), "ESTONIA", new DateTime(2022, 4, 4, 11, 15, 59, 0, DateTimeKind.Unspecified), 3, null, null, "Euro", null },
                    { new Guid("f1bd84b6-39b8-467e-be2c-f97fd5538adc"), "CUBA", new DateTime(2022, 4, 4, 11, 15, 59, 0, DateTimeKind.Unspecified), 1, null, null, "US Dollar", null },
                    { new Guid("f23ae627-2960-4b34-ba67-7fc3e31e2f5a"), "TUNISIA", new DateTime(2022, 4, 4, 11, 15, 59, 0, DateTimeKind.Unspecified), 1, null, null, "US Dollar", null },
                    { new Guid("f34f5330-1faa-4fba-944f-144621478027"), "GIBRALTAR", new DateTime(2022, 4, 4, 11, 15, 59, 0, DateTimeKind.Unspecified), 3, null, null, "Euro", null },
                    { new Guid("f5f01c36-fe49-4940-9e91-26126233f607"), "NETHERLANDS", new DateTime(2022, 4, 4, 11, 15, 59, 0, DateTimeKind.Unspecified), 3, null, null, "Euro", null },
                    { new Guid("f6311684-9e7e-4851-89f2-4fd8b0b43530"), "SLOVAKIA", new DateTime(2022, 4, 4, 11, 15, 59, 0, DateTimeKind.Unspecified), 3, null, null, "Euro", null },
                    { new Guid("f9531d8c-a9db-4a53-b841-4b5cdd1c83d8"), "UKRAINE", new DateTime(2022, 4, 4, 11, 15, 59, 0, DateTimeKind.Unspecified), 1, null, null, "US Dollar", null },
                    { new Guid("fc92b0b1-2867-4755-885c-bdbc8ba3389c"), "SAN MARINO", new DateTime(2022, 4, 4, 11, 15, 59, 0, DateTimeKind.Unspecified), 3, null, null, "Euro", null },
                    { new Guid("fd6dfe43-5ab7-4726-bc03-b70d0c5f5fd7"), "ARGENTINA", new DateTime(2022, 4, 4, 11, 15, 59, 0, DateTimeKind.Unspecified), 1, null, null, "US Dollar", null },
                    { new Guid("fde7ea55-28e8-44e0-87ce-1a53b9a95bce"), "COLOMBIA", new DateTime(2022, 4, 4, 11, 15, 59, 0, DateTimeKind.Unspecified), 1, null, null, "US Dollar", null }
                });

            migrationBuilder.InsertData(
                table: "Allowances",
                columns: new[] { "Id", "AccomodationAllowance", "CountryId", "CreatedDate", "DailyAllowance", "UpdatedDate", "ValidFrom", "ValidTo" },
                values: new object[,]
                {
                    { new Guid("02b89e59-c25f-4b24-afda-e1ba2ab03070"), 80m, new Guid("4b5e4a58-a62a-49d9-aa1a-7c537768cf98"), new DateTime(2022, 4, 4, 11, 15, 59, 0, DateTimeKind.Unspecified), 30m, null, new DateTime(2022, 4, 4, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("04627752-af51-4928-8ef9-17956db6a5f1"), 80m, new Guid("d396c12d-39a3-4a66-9acc-433f97988241"), new DateTime(2022, 4, 4, 11, 15, 59, 0, DateTimeKind.Unspecified), 30m, null, new DateTime(2022, 4, 4, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("060320da-2ce3-4e29-9ff2-851b60413247"), 120m, new Guid("c25fc851-f96b-41f8-b270-fe2f8e5da1c6"), new DateTime(2022, 4, 4, 11, 15, 59, 0, DateTimeKind.Unspecified), 35m, null, new DateTime(2022, 4, 4, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("07105240-1198-43eb-8e1a-ff1a352e08d1"), 130m, new Guid("710739da-4f0e-4f81-877b-96e66977173a"), new DateTime(2022, 4, 4, 11, 15, 59, 0, DateTimeKind.Unspecified), 35m, null, new DateTime(2022, 4, 4, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("09c52f1c-5032-4e40-9a43-4de25ff5e7d4"), 90m, new Guid("36e238d7-59c2-494c-8f3f-be5db488c634"), new DateTime(2022, 4, 4, 11, 15, 59, 0, DateTimeKind.Unspecified), 30m, null, new DateTime(2022, 4, 4, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("09f27370-3a37-43fb-ba62-31481c506f91"), 130m, new Guid("a5fe49e6-db27-4f7a-a135-0cb0452572a3"), new DateTime(2022, 4, 4, 11, 15, 59, 0, DateTimeKind.Unspecified), 35m, null, new DateTime(2022, 4, 4, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("0c168beb-6efb-4b1a-bffd-61360e2802fe"), 130m, new Guid("9a391a0b-4f56-43f4-a370-bd42175bbbd5"), new DateTime(2022, 4, 4, 11, 15, 59, 0, DateTimeKind.Unspecified), 35m, null, new DateTime(2022, 4, 4, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("0f548432-bfd9-47a2-bc15-acb0625bf7b2"), 17000m, new Guid("dc581d44-3d53-4ea9-8a56-c6fb0cc11c39"), new DateTime(2022, 4, 4, 11, 15, 59, 0, DateTimeKind.Unspecified), 5500m, null, new DateTime(2022, 4, 4, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("13632978-64e6-4565-97e0-82bf3b5f3d76"), 90m, new Guid("65a77b64-41c7-497c-abdb-b06cdff185f9"), new DateTime(2022, 4, 4, 11, 15, 59, 0, DateTimeKind.Unspecified), 30m, null, new DateTime(2022, 4, 4, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("1551b839-0a04-4125-9813-0deca1bc5374"), 100m, new Guid("d7af0e44-e8d5-45e6-8ac0-f85007ccaa14"), new DateTime(2022, 4, 4, 11, 15, 59, 0, DateTimeKind.Unspecified), 30m, null, new DateTime(2022, 4, 4, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("1a221115-75da-4fc3-bb08-9674c499bacb"), 130m, new Guid("7218bb3a-a464-4ee5-ab2a-aab7dab30002"), new DateTime(2022, 4, 4, 11, 15, 59, 0, DateTimeKind.Unspecified), 35m, null, new DateTime(2022, 4, 4, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("1b664c55-e45b-4f87-b2c8-8e73d743d55a"), 130m, new Guid("0e2062e2-886d-4113-9f8f-10a6445a9448"), new DateTime(2022, 4, 4, 11, 15, 59, 0, DateTimeKind.Unspecified), 35m, null, new DateTime(2022, 4, 4, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("1bf42a46-aa71-4940-9ef7-7b4631d0a565"), 130m, new Guid("5e6741a5-b71b-415d-a221-37ed8c247de0"), new DateTime(2022, 4, 4, 11, 15, 59, 0, DateTimeKind.Unspecified), 35m, null, new DateTime(2022, 4, 4, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("1cce5312-1ea7-424c-b955-32b2a64f263b"), 130m, new Guid("c6ac481f-c102-4941-a052-f8dda3dda1e9"), new DateTime(2022, 4, 4, 11, 15, 59, 0, DateTimeKind.Unspecified), 35m, null, new DateTime(2022, 4, 4, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("1d490e1e-89bf-4649-bca1-74cd9d24cf16"), 80m, new Guid("6a632fba-765a-4a10-9159-72466736ee75"), new DateTime(2022, 4, 4, 11, 15, 59, 0, DateTimeKind.Unspecified), 35m, null, new DateTime(2022, 4, 4, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("1d5840d7-331a-4bbd-b505-cc6ce4121fb5"), 130m, new Guid("aac3c372-102c-4acd-b070-1f08643de572"), new DateTime(2022, 4, 4, 11, 15, 59, 0, DateTimeKind.Unspecified), 35m, null, new DateTime(2022, 4, 4, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("1dc7b714-acad-4656-b0a3-1544ad9b107e"), 100m, new Guid("825d75d1-2b94-471b-822d-4ba628ee6aa8"), new DateTime(2022, 4, 4, 11, 15, 59, 0, DateTimeKind.Unspecified), 30m, null, new DateTime(2022, 4, 4, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("221a6479-f800-46a4-a349-180247750877"), 90m, new Guid("5270fc5c-1659-4b2d-872a-dff9a559242b"), new DateTime(2022, 4, 4, 11, 15, 59, 0, DateTimeKind.Unspecified), 30m, null, new DateTime(2022, 4, 4, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("242efa8e-6854-47e9-afcf-d25a3b4195fd"), 100m, new Guid("5840c7e2-0f43-41c6-9cc7-1762ec7ef3f7"), new DateTime(2022, 4, 4, 11, 15, 59, 0, DateTimeKind.Unspecified), 30m, null, new DateTime(2022, 4, 4, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("247ed75a-bd8c-4830-9614-4fcec1e128da"), 100m, new Guid("61913cf9-4615-4149-bdf2-67f8d4f0200d"), new DateTime(2022, 4, 4, 11, 15, 59, 0, DateTimeKind.Unspecified), 30m, null, new DateTime(2022, 4, 4, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("298b3416-cd6a-474b-ad5d-310c574e2873"), 130m, new Guid("f04e3eaa-1a7f-4968-bc35-43231a4c6b4e"), new DateTime(2022, 4, 4, 11, 15, 59, 0, DateTimeKind.Unspecified), 35m, null, new DateTime(2022, 4, 4, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("2b666356-e067-4524-beda-7f7f4eebc684"), 80m, new Guid("6f9bfb1d-bbd2-45dc-99ae-49385cba9c7a"), new DateTime(2022, 4, 4, 11, 15, 59, 0, DateTimeKind.Unspecified), 30m, null, new DateTime(2022, 4, 4, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("2c5a2611-e136-4bbf-b287-ba89a014837c"), 100m, new Guid("9d4da082-51c0-434a-b340-6a427100350c"), new DateTime(2022, 4, 4, 11, 15, 59, 0, DateTimeKind.Unspecified), 30m, null, new DateTime(2022, 4, 4, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("2dbb7c8a-a9ca-4da5-8381-ed8e157685d0"), 100m, new Guid("41fcafc1-030d-41e2-abcb-d33ba5a1b8f0"), new DateTime(2022, 4, 4, 11, 15, 59, 0, DateTimeKind.Unspecified), 30m, null, new DateTime(2022, 4, 4, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("36d1b456-5e6b-423f-8556-71908cdce004"), 80m, new Guid("3c17f104-10d3-4ac8-98a1-febba02132e6"), new DateTime(2022, 4, 4, 11, 15, 59, 0, DateTimeKind.Unspecified), 30m, null, new DateTime(2022, 4, 4, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("3b0b6d4e-dc5e-4874-b2a3-e8fe7752181e"), 80m, new Guid("756975e2-cd52-4af7-8832-9d7ef69be2c9"), new DateTime(2022, 4, 4, 11, 15, 59, 0, DateTimeKind.Unspecified), 30m, null, new DateTime(2022, 4, 4, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("3c6b540e-80f9-44b6-a6e8-29c5669ea1b2"), 130m, new Guid("12414a82-36b4-4224-8296-4b0dca96c342"), new DateTime(2022, 4, 4, 11, 15, 59, 0, DateTimeKind.Unspecified), 35m, null, new DateTime(2022, 4, 4, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("3f25c606-4f06-4a75-b9ae-d75c066ea852"), 150m, new Guid("01be237e-2109-4e53-8439-d158fc52dfb6"), new DateTime(2022, 4, 4, 11, 15, 59, 0, DateTimeKind.Unspecified), 35m, null, new DateTime(2022, 4, 4, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("3f871589-788b-441a-944a-6eb5d335a572"), 130m, new Guid("f5f01c36-fe49-4940-9e91-26126233f607"), new DateTime(2022, 4, 4, 11, 15, 59, 0, DateTimeKind.Unspecified), 35m, null, new DateTime(2022, 4, 4, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("41379c98-913e-40f7-8e35-63030be1149d"), 110m, new Guid("f9531d8c-a9db-4a53-b841-4b5cdd1c83d8"), new DateTime(2022, 4, 4, 11, 15, 59, 0, DateTimeKind.Unspecified), 30m, null, new DateTime(2022, 4, 4, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("4152580e-4750-438c-8c20-c8ac04dc7c9b"), 100m, new Guid("c64566fc-124e-40a8-a281-a3b058a48d2a"), new DateTime(2022, 4, 4, 11, 15, 59, 0, DateTimeKind.Unspecified), 35m, null, new DateTime(2022, 4, 4, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("480f4f96-59e3-4fee-bbf2-10fa3ad793b0"), 130m, new Guid("b99ee5a9-41df-4803-ab81-10bdf0c4dffe"), new DateTime(2022, 4, 4, 11, 15, 59, 0, DateTimeKind.Unspecified), 35m, null, new DateTime(2022, 4, 4, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("4a774f49-4642-4daf-8a30-3586b68d7718"), 100m, new Guid("425feebd-555d-48e3-9e53-9f4c2fd37831"), new DateTime(2022, 4, 4, 11, 15, 59, 0, DateTimeKind.Unspecified), 35m, null, new DateTime(2022, 4, 4, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("4bf5ec84-998e-4408-8f7f-d2362efce4e4"), 130m, new Guid("cd4eaf6d-c983-4d4a-9ddb-745ecaff2047"), new DateTime(2022, 4, 4, 11, 15, 59, 0, DateTimeKind.Unspecified), 35m, null, new DateTime(2022, 4, 4, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("5fa2c5da-63ae-4602-b615-4206a0db3755"), 130m, new Guid("00c06fc7-1bfd-4d41-9685-184076bcbd45"), new DateTime(2022, 4, 4, 11, 15, 59, 0, DateTimeKind.Unspecified), 35m, null, new DateTime(2022, 4, 4, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("630d6a87-f8f6-4ce5-b0df-f8ff54f9baf4"), 100m, new Guid("dd541b68-a0b7-4907-8c05-a080c7227b8c"), new DateTime(2022, 4, 4, 11, 15, 59, 0, DateTimeKind.Unspecified), 30m, null, new DateTime(2022, 4, 4, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("6370af5f-e155-4585-8737-f2a1e867821b"), 145m, new Guid("41b2c732-f8a8-4e29-9269-bc43391f7def"), new DateTime(2022, 4, 4, 11, 15, 59, 0, DateTimeKind.Unspecified), 35m, null, new DateTime(2022, 4, 4, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("66ddab61-331b-4051-9440-0e96ddfad3ad"), 90m, new Guid("8f607b90-c24e-405f-97d3-3c9ec5dfceff"), new DateTime(2022, 4, 4, 11, 15, 59, 0, DateTimeKind.Unspecified), 30m, null, new DateTime(2022, 4, 4, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("671bc9bb-ff2e-4d06-987d-bd6f4f29dc66"), 130m, new Guid("69e2cd08-b32f-4346-a578-8214980662a9"), new DateTime(2022, 4, 4, 11, 15, 59, 0, DateTimeKind.Unspecified), 35m, null, new DateTime(2022, 4, 4, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("67d50c61-77ae-45fe-936a-406333b787c2"), 130m, new Guid("e5302020-c497-4f4b-b61a-4c3a56db56cb"), new DateTime(2022, 4, 4, 11, 15, 59, 0, DateTimeKind.Unspecified), 35m, null, new DateTime(2022, 4, 4, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("6b0e3ca9-5040-44bd-9429-6c90aff99613"), 120m, new Guid("34ce1795-938a-46cd-881d-7dd56a2e9de7"), new DateTime(2022, 4, 4, 11, 15, 59, 0, DateTimeKind.Unspecified), 30m, null, new DateTime(2022, 4, 4, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("6b6f4ff7-d16b-4562-b2ae-b5cdbf0f0284"), 80m, new Guid("9d612cdd-b6d8-44a2-b623-deafcf091503"), new DateTime(2022, 4, 4, 11, 15, 59, 0, DateTimeKind.Unspecified), 30m, null, new DateTime(2022, 4, 4, 0, 0, 0, 0, DateTimeKind.Local), null }
                });

            migrationBuilder.InsertData(
                table: "Allowances",
                columns: new[] { "Id", "AccomodationAllowance", "CountryId", "CreatedDate", "DailyAllowance", "UpdatedDate", "ValidFrom", "ValidTo" },
                values: new object[,]
                {
                    { new Guid("6fb410e1-d08d-465f-bf29-7ede0174c6e9"), 90m, new Guid("015490f3-7c44-404c-9984-57aa491a8e8e"), new DateTime(2022, 4, 4, 11, 15, 59, 0, DateTimeKind.Unspecified), 30m, null, new DateTime(2022, 4, 4, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("6ffa2b53-ce4d-4090-a1f5-8d5f4c7f18c1"), 120m, new Guid("a9087435-5c10-4871-88cf-3b8f18d1a98b"), new DateTime(2022, 4, 4, 11, 15, 59, 0, DateTimeKind.Unspecified), 35m, null, new DateTime(2022, 4, 4, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("701f8498-ab66-4b67-9a8a-3305c39febc9"), 80m, new Guid("5c98b53b-0207-4285-9aaf-9f65e6c7d47d"), new DateTime(2022, 4, 4, 11, 15, 59, 0, DateTimeKind.Unspecified), 30m, null, new DateTime(2022, 4, 4, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("70a7e05a-f6ce-41ca-aa5a-970ba6654a22"), 100m, new Guid("6bc8e085-4481-445f-8856-c137b0546760"), new DateTime(2022, 4, 4, 11, 15, 59, 0, DateTimeKind.Unspecified), 30m, null, new DateTime(2022, 4, 4, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("714bf03c-4bba-45ed-8f1d-38a331ab7cac"), 90m, new Guid("19920de9-cc87-467d-9aab-76f88e71da71"), new DateTime(2022, 4, 4, 11, 15, 59, 0, DateTimeKind.Unspecified), 30m, null, new DateTime(2022, 4, 4, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("724444a1-ec57-42ae-96cb-77d7aad14ee8"), 150m, new Guid("00fc91a4-b045-4882-911c-e053eaf97386"), new DateTime(2022, 4, 4, 11, 15, 59, 0, DateTimeKind.Unspecified), 60m, null, new DateTime(2022, 4, 4, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("7302b6c6-d9b9-4371-b27e-33778d8c3615"), 100m, new Guid("c898ea68-3bcc-4e86-9335-b75b7cd8129e"), new DateTime(2022, 4, 4, 11, 15, 59, 0, DateTimeKind.Unspecified), 30m, null, new DateTime(2022, 4, 4, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("79bc7404-eec4-4a56-a2c2-5454273cad70"), 150m, new Guid("d9c465da-6f39-4b37-b46d-b1ace9bb814f"), new DateTime(2022, 4, 4, 11, 15, 59, 0, DateTimeKind.Unspecified), 35m, null, new DateTime(2022, 4, 4, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("79cd9d22-a9b6-4ba1-9c27-d876435f5b10"), 100m, new Guid("99ff12eb-06a3-4b87-81d2-61ac882ee6eb"), new DateTime(2022, 4, 4, 11, 15, 59, 0, DateTimeKind.Unspecified), 30m, null, new DateTime(2022, 4, 4, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("7ad678d1-a33e-4ed7-b8cb-64bedc08389e"), 130m, new Guid("ed69dc78-225a-47ae-8478-09a988c2a61c"), new DateTime(2022, 4, 4, 11, 15, 59, 0, DateTimeKind.Unspecified), 35m, null, new DateTime(2022, 4, 4, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("7b4ef0da-423e-4627-b551-6041a5fdb6d7"), 100m, new Guid("92bd5eaa-295b-482f-9d92-c725de38a4b1"), new DateTime(2022, 4, 4, 11, 15, 59, 0, DateTimeKind.Unspecified), 30m, null, new DateTime(2022, 4, 4, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("80b17ee8-f622-420a-9f67-10d184bcac5e"), 110m, new Guid("da7ee2eb-c755-4bea-9e04-2c9b42c4b8f3"), new DateTime(2022, 4, 4, 11, 15, 59, 0, DateTimeKind.Unspecified), 30m, null, new DateTime(2022, 4, 4, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("815b2c76-0771-40d1-9ff6-80d6488357b2"), 130m, new Guid("a6a8c3f1-03cb-4131-aa4c-78c3e673ee96"), new DateTime(2022, 4, 4, 11, 15, 59, 0, DateTimeKind.Unspecified), 35m, null, new DateTime(2022, 4, 4, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("83a30854-6c75-4f66-a057-4f234ec64871"), 130m, new Guid("39da0014-9229-4e0c-b49c-f5e92f74e27f"), new DateTime(2022, 4, 4, 11, 15, 59, 0, DateTimeKind.Unspecified), 35m, null, new DateTime(2022, 4, 4, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("842d1f1e-4f2e-4cc2-ac82-88bb42ecb640"), 130m, new Guid("76bacd95-374b-4cdb-bc78-1702085a6470"), new DateTime(2022, 4, 4, 11, 15, 59, 0, DateTimeKind.Unspecified), 35m, null, new DateTime(2022, 4, 4, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("86b2ce77-471f-48a6-bae1-77031483d37d"), 100m, new Guid("fd6dfe43-5ab7-4726-bc03-b70d0c5f5fd7"), new DateTime(2022, 4, 4, 11, 15, 59, 0, DateTimeKind.Unspecified), 35m, null, new DateTime(2022, 4, 4, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("8c38f38c-26d0-4a0b-8718-34a96ebf62aa"), 100m, new Guid("9caa448d-677c-4c45-ac9e-4bd38071e0ce"), new DateTime(2022, 4, 4, 11, 15, 59, 0, DateTimeKind.Unspecified), 35m, null, new DateTime(2022, 4, 4, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("8cf3f2bc-76c5-4222-bbc7-36e285ff97a7"), 130m, new Guid("0339b38e-3249-47d2-a671-89d0e30a7087"), new DateTime(2022, 4, 4, 11, 15, 59, 0, DateTimeKind.Unspecified), 35m, null, new DateTime(2022, 4, 4, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("8d9cfcc7-9803-4a50-97b0-f0ed6abaaf8f"), 80m, new Guid("ac691082-93f9-4d88-9f35-bcdc4564bb83"), new DateTime(2022, 4, 4, 11, 15, 59, 0, DateTimeKind.Unspecified), 30m, null, new DateTime(2022, 4, 4, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("91dcefae-3590-4f69-88ec-149b2d5dc0c9"), 100m, new Guid("c97ecfdc-bb14-4dee-8590-da2a36e24f78"), new DateTime(2022, 4, 4, 11, 15, 59, 0, DateTimeKind.Unspecified), 30m, null, new DateTime(2022, 4, 4, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("986bb132-76de-4d7e-b978-ddd2db3a7222"), 100m, new Guid("f1bd84b6-39b8-467e-be2c-f97fd5538adc"), new DateTime(2022, 4, 4, 11, 15, 59, 0, DateTimeKind.Unspecified), 35m, null, new DateTime(2022, 4, 4, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("9905be75-4da9-4398-9ae2-9a6bbf294519"), 80m, new Guid("548511c6-cb7c-4f76-be6a-c6df86e3e74a"), new DateTime(2022, 4, 4, 11, 15, 59, 0, DateTimeKind.Unspecified), 30m, null, new DateTime(2022, 4, 4, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("9917264a-bf7d-4667-a12a-857f6dc3c784"), 130m, new Guid("fc92b0b1-2867-4755-885c-bdbc8ba3389c"), new DateTime(2022, 4, 4, 11, 15, 59, 0, DateTimeKind.Unspecified), 35m, null, new DateTime(2022, 4, 4, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("9946fa25-1e51-4e84-b909-b3dbdea94fc8"), 130m, new Guid("b7fbf291-894c-4dbd-88c4-12bcee6172ca"), new DateTime(2022, 4, 4, 11, 15, 59, 0, DateTimeKind.Unspecified), 35m, null, new DateTime(2022, 4, 4, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("9f5c9cf9-1a5b-4b32-9a05-fb458b6039a3"), 80m, new Guid("aa10ec4b-16ef-403b-81b5-c68cf3976a11"), new DateTime(2022, 4, 4, 11, 15, 59, 0, DateTimeKind.Unspecified), 30m, null, new DateTime(2022, 4, 4, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("a1aa512c-2765-40ff-abaa-f16b61844f04"), 130m, new Guid("6c24042b-9af6-42b5-8944-d8caf7918dc4"), new DateTime(2022, 4, 4, 11, 15, 59, 0, DateTimeKind.Unspecified), 35m, null, new DateTime(2022, 4, 4, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("a2062544-5389-48a6-957d-7bf33ba56738"), 100m, new Guid("86a72990-ea87-4079-8384-f3b0ec76d06e"), new DateTime(2022, 4, 4, 11, 15, 59, 0, DateTimeKind.Unspecified), 30m, null, new DateTime(2022, 4, 4, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("a619e3e5-8feb-4191-8b56-2cc59c7f0b79"), 130m, new Guid("f6311684-9e7e-4851-89f2-4fd8b0b43530"), new DateTime(2022, 4, 4, 11, 15, 59, 0, DateTimeKind.Unspecified), 35m, null, new DateTime(2022, 4, 4, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("a6336e0d-33a9-4570-bbb1-ab080c759b20"), 80m, new Guid("262eadab-aa80-4424-8005-364349c19807"), new DateTime(2022, 4, 4, 11, 15, 59, 0, DateTimeKind.Unspecified), 30m, null, new DateTime(2022, 4, 4, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("a8da22bd-ce79-4776-8216-01eed8a980db"), 80m, new Guid("8c57527f-b0ec-42ed-9ed0-8dca4b03ed67"), new DateTime(2022, 4, 4, 11, 15, 59, 0, DateTimeKind.Unspecified), 30m, null, new DateTime(2022, 4, 4, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("aaa6243f-a5dd-49da-90ba-5c9f3abcd445"), 130m, new Guid("e0430294-eecc-493c-9628-85bb91ac8c97"), new DateTime(2022, 4, 4, 11, 15, 59, 0, DateTimeKind.Unspecified), 35m, null, new DateTime(2022, 4, 4, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("ada630bd-148e-44ef-807c-d73771530ad9"), 100m, new Guid("41122216-cdab-49e6-b515-29caa0906249"), new DateTime(2022, 4, 4, 11, 15, 59, 0, DateTimeKind.Unspecified), 30m, null, new DateTime(2022, 4, 4, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("ae2473a0-dc63-4b93-81a8-ba47ebc8aa78"), 70m, new Guid("34b07072-37ea-4758-add5-a9147ae6251a"), new DateTime(2022, 4, 4, 11, 15, 59, 0, DateTimeKind.Unspecified), 30m, null, new DateTime(2022, 4, 4, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("b149b7b3-f375-4766-a5f0-a22476c67c7e"), 80m, new Guid("218522d4-2f31-4cbe-9dc3-70046ad8c378"), new DateTime(2022, 4, 4, 11, 15, 59, 0, DateTimeKind.Unspecified), 30m, null, new DateTime(2022, 4, 4, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("b1ad8425-e1b4-4bf6-b4ae-b5fdc2f450f5"), 100m, new Guid("2124be6e-f056-4157-82c9-9be3e96b4aab"), new DateTime(2022, 4, 4, 11, 15, 59, 0, DateTimeKind.Unspecified), 30m, null, new DateTime(2022, 4, 4, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("b87887d6-60e2-4207-a659-b10c35bc8a82"), 85m, new Guid("5f238cff-8271-41cf-b5ae-c60fe0a0b646"), new DateTime(2022, 4, 4, 11, 15, 59, 0, DateTimeKind.Unspecified), 30m, null, new DateTime(2022, 4, 4, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("b9978699-cfed-4958-aa75-f240217b92d5"), 90m, new Guid("efa07730-262f-4574-ae1c-61be7938fc32"), new DateTime(2022, 4, 4, 11, 15, 59, 0, DateTimeKind.Unspecified), 30m, null, new DateTime(2022, 4, 4, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("c41a3535-7bba-438f-906e-7ccedb3a2a0f"), 130m, new Guid("36a4d56a-7fbb-4a92-991c-81dff2f90992"), new DateTime(2022, 4, 4, 11, 15, 59, 0, DateTimeKind.Unspecified), 30m, null, new DateTime(2022, 4, 4, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("c6adbbda-476b-4079-b340-5d06238aad1c"), 130m, new Guid("93d5a42e-e620-4d8b-a8fa-8f71ab5b6c62"), new DateTime(2022, 4, 4, 11, 15, 59, 0, DateTimeKind.Unspecified), 35m, null, new DateTime(2022, 4, 4, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("c8bc1746-c753-4587-87e1-1afad9d7e521"), 110m, new Guid("9214cc44-741b-4b62-a51d-93745e742c83"), new DateTime(2022, 4, 4, 11, 15, 59, 0, DateTimeKind.Unspecified), 30m, null, new DateTime(2022, 4, 4, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("cb74004f-806d-4288-aa48-aafd1d7a72bc"), 90m, new Guid("c2b13821-83ad-4fab-bbe1-85bf7266964b"), new DateTime(2022, 4, 4, 11, 15, 59, 0, DateTimeKind.Unspecified), 30m, null, new DateTime(2022, 4, 4, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("cf6924bd-0eed-49a4-834d-20d0880be6a4"), 130m, new Guid("10681bd7-1677-40a3-b789-966eb703ccea"), new DateTime(2022, 4, 4, 11, 15, 59, 0, DateTimeKind.Unspecified), 35m, null, new DateTime(2022, 4, 4, 0, 0, 0, 0, DateTimeKind.Local), null }
                });

            migrationBuilder.InsertData(
                table: "Allowances",
                columns: new[] { "Id", "AccomodationAllowance", "CountryId", "CreatedDate", "DailyAllowance", "UpdatedDate", "ValidFrom", "ValidTo" },
                values: new object[,]
                {
                    { new Guid("d0d7dfc8-f7d1-4c57-800e-f93fc7410d4a"), 110m, new Guid("4f0e9a3b-6823-4688-866d-e78298a4e61e"), new DateTime(2022, 4, 4, 11, 15, 59, 0, DateTimeKind.Unspecified), 30m, null, new DateTime(2022, 4, 4, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("d1f02df5-d9df-4ed0-9ee5-39e2e3c7bb70"), 90m, new Guid("ab4e9c2f-1b62-48cd-a6e1-943384947f4b"), new DateTime(2022, 4, 4, 11, 15, 59, 0, DateTimeKind.Unspecified), 30m, null, new DateTime(2022, 4, 4, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("d3f09b87-f7f7-4d7e-be4a-c44d8104fc1b"), 80m, new Guid("fde7ea55-28e8-44e0-87ce-1a53b9a95bce"), new DateTime(2022, 4, 4, 11, 15, 59, 0, DateTimeKind.Unspecified), 30m, null, new DateTime(2022, 4, 4, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("d5ff5a55-85e7-4b78-9320-ae93babb98ca"), 130m, new Guid("37334fd7-fa74-40b6-bd53-112482408f98"), new DateTime(2022, 4, 4, 11, 15, 59, 0, DateTimeKind.Unspecified), 35m, null, new DateTime(2022, 4, 4, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("d9b98b65-761d-47d7-82cc-937664233454"), 80m, new Guid("f23ae627-2960-4b34-ba67-7fc3e31e2f5a"), new DateTime(2022, 4, 4, 11, 15, 59, 0, DateTimeKind.Unspecified), 30m, null, new DateTime(2022, 4, 4, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("d9f89784-2fc7-4585-a0d8-579c97855b09"), 90m, new Guid("e545ed4f-1670-4c03-b59f-9dc8e15315c8"), new DateTime(2022, 4, 4, 11, 15, 59, 0, DateTimeKind.Unspecified), 30m, null, new DateTime(2022, 4, 4, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("da9762f1-b647-4b1e-85af-77d8ebff1a87"), 100m, new Guid("8da9b5dc-9bda-4c91-a3de-5f3b01488923"), new DateTime(2022, 4, 4, 11, 15, 59, 0, DateTimeKind.Unspecified), 35m, null, new DateTime(2022, 4, 4, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("deea7293-bce9-4b52-9424-05974e2526b7"), 100m, new Guid("599ab63d-4375-4542-ab9e-84031d6b2ca6"), new DateTime(2022, 4, 4, 11, 15, 59, 0, DateTimeKind.Unspecified), 30m, null, new DateTime(2022, 4, 4, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("e15a8054-9c6c-437f-aaf3-dd82f4b57e51"), 80m, new Guid("75105562-9b3b-4d04-8a4e-514ecc3d1381"), new DateTime(2022, 4, 4, 11, 15, 59, 0, DateTimeKind.Unspecified), 30m, null, new DateTime(2022, 4, 4, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("e3954ce3-7503-49c5-bbab-f5272e43fe64"), 90m, new Guid("03055f5b-21ec-4b58-bbde-ed31909ae41f"), new DateTime(2022, 4, 4, 11, 15, 59, 0, DateTimeKind.Unspecified), 30m, null, new DateTime(2022, 4, 4, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("eefa0fda-61d9-495a-b309-bd3789b1981b"), 120m, new Guid("7d7e1d57-f21c-4b7d-9899-325ba373664e"), new DateTime(2022, 4, 4, 11, 15, 59, 0, DateTimeKind.Unspecified), 35m, null, new DateTime(2022, 4, 4, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("f0fe4706-0642-4d94-a4d9-583dd599ab5e"), 130m, new Guid("d5c15929-8e99-438a-8c1a-d3706f748e27"), new DateTime(2022, 4, 4, 11, 15, 59, 0, DateTimeKind.Unspecified), 35m, null, new DateTime(2022, 4, 4, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("f2c1288c-7726-45c7-b8b5-080984cba6fe"), 130m, new Guid("f34f5330-1faa-4fba-944f-144621478027"), new DateTime(2022, 4, 4, 11, 15, 59, 0, DateTimeKind.Unspecified), 35m, null, new DateTime(2022, 4, 4, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("f37e0164-d5d1-4118-9a73-2d65e276c85c"), 90m, new Guid("115a365c-1d44-485e-861b-de29ecd605e2"), new DateTime(2022, 4, 4, 11, 15, 59, 0, DateTimeKind.Unspecified), 30m, null, new DateTime(2022, 4, 4, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("f6a90176-3873-4878-90f1-879d2c60a0c5"), 100m, new Guid("2b54175a-8b58-48f1-b8b7-25ca47b7cd3c"), new DateTime(2022, 4, 4, 11, 15, 59, 0, DateTimeKind.Unspecified), 30m, null, new DateTime(2022, 4, 4, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("f9cc54a2-3be7-4df5-8f04-1780a96b062d"), 90m, new Guid("7fdd7a1b-b3fb-4917-8964-b4c698410d0f"), new DateTime(2022, 4, 4, 11, 15, 59, 0, DateTimeKind.Unspecified), 30m, null, new DateTime(2022, 4, 4, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("fb71a136-9bc9-4db9-81a8-ba7cb5ed6854"), 130m, new Guid("656b7936-d631-44ea-88b7-45f6368f0d8b"), new DateTime(2022, 4, 4, 11, 15, 59, 0, DateTimeKind.Unspecified), 35m, null, new DateTime(2022, 4, 4, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("fc30553b-62b5-4cda-807b-0b08010bdeab"), 90m, new Guid("74ea1ef1-7738-4f40-bcc8-c9f9df1deca2"), new DateTime(2022, 4, 4, 11, 15, 59, 0, DateTimeKind.Unspecified), 30m, null, new DateTime(2022, 4, 4, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("fcba7cc5-f7dd-4fac-a2bf-f93fc5bd973a"), 130m, new Guid("ee3bad6f-1d39-44b2-a8dd-76eccedf6ecd"), new DateTime(2022, 4, 4, 11, 15, 59, 0, DateTimeKind.Unspecified), 35m, null, new DateTime(2022, 4, 4, 0, 0, 0, 0, DateTimeKind.Local), null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Allowances_CountryId",
                table: "Allowances",
                column: "CountryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Allowances_Countries_CountryId",
                table: "Allowances",
                column: "CountryId",
                principalTable: "Countries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Allowances_Countries_CountryId",
                table: "Allowances");

            migrationBuilder.DropIndex(
                name: "IX_Allowances_CountryId",
                table: "Allowances");

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("02b89e59-c25f-4b24-afda-e1ba2ab03070"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("04627752-af51-4928-8ef9-17956db6a5f1"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("060320da-2ce3-4e29-9ff2-851b60413247"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("07105240-1198-43eb-8e1a-ff1a352e08d1"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("09c52f1c-5032-4e40-9a43-4de25ff5e7d4"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("09f27370-3a37-43fb-ba62-31481c506f91"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("0c168beb-6efb-4b1a-bffd-61360e2802fe"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("0f548432-bfd9-47a2-bc15-acb0625bf7b2"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("13632978-64e6-4565-97e0-82bf3b5f3d76"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("1551b839-0a04-4125-9813-0deca1bc5374"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("1a221115-75da-4fc3-bb08-9674c499bacb"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("1b664c55-e45b-4f87-b2c8-8e73d743d55a"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("1bf42a46-aa71-4940-9ef7-7b4631d0a565"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("1cce5312-1ea7-424c-b955-32b2a64f263b"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("1d490e1e-89bf-4649-bca1-74cd9d24cf16"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("1d5840d7-331a-4bbd-b505-cc6ce4121fb5"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("1dc7b714-acad-4656-b0a3-1544ad9b107e"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("221a6479-f800-46a4-a349-180247750877"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("242efa8e-6854-47e9-afcf-d25a3b4195fd"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("247ed75a-bd8c-4830-9614-4fcec1e128da"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("298b3416-cd6a-474b-ad5d-310c574e2873"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("2b666356-e067-4524-beda-7f7f4eebc684"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("2c5a2611-e136-4bbf-b287-ba89a014837c"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("2dbb7c8a-a9ca-4da5-8381-ed8e157685d0"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("36d1b456-5e6b-423f-8556-71908cdce004"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("3b0b6d4e-dc5e-4874-b2a3-e8fe7752181e"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("3c6b540e-80f9-44b6-a6e8-29c5669ea1b2"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("3f25c606-4f06-4a75-b9ae-d75c066ea852"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("3f871589-788b-441a-944a-6eb5d335a572"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("41379c98-913e-40f7-8e35-63030be1149d"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("4152580e-4750-438c-8c20-c8ac04dc7c9b"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("480f4f96-59e3-4fee-bbf2-10fa3ad793b0"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("4a774f49-4642-4daf-8a30-3586b68d7718"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("4bf5ec84-998e-4408-8f7f-d2362efce4e4"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("5fa2c5da-63ae-4602-b615-4206a0db3755"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("630d6a87-f8f6-4ce5-b0df-f8ff54f9baf4"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("6370af5f-e155-4585-8737-f2a1e867821b"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("66ddab61-331b-4051-9440-0e96ddfad3ad"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("671bc9bb-ff2e-4d06-987d-bd6f4f29dc66"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("67d50c61-77ae-45fe-936a-406333b787c2"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("6b0e3ca9-5040-44bd-9429-6c90aff99613"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("6b6f4ff7-d16b-4562-b2ae-b5cdbf0f0284"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("6fb410e1-d08d-465f-bf29-7ede0174c6e9"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("6ffa2b53-ce4d-4090-a1f5-8d5f4c7f18c1"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("701f8498-ab66-4b67-9a8a-3305c39febc9"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("70a7e05a-f6ce-41ca-aa5a-970ba6654a22"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("714bf03c-4bba-45ed-8f1d-38a331ab7cac"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("724444a1-ec57-42ae-96cb-77d7aad14ee8"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("7302b6c6-d9b9-4371-b27e-33778d8c3615"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("79bc7404-eec4-4a56-a2c2-5454273cad70"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("79cd9d22-a9b6-4ba1-9c27-d876435f5b10"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("7ad678d1-a33e-4ed7-b8cb-64bedc08389e"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("7b4ef0da-423e-4627-b551-6041a5fdb6d7"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("80b17ee8-f622-420a-9f67-10d184bcac5e"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("815b2c76-0771-40d1-9ff6-80d6488357b2"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("83a30854-6c75-4f66-a057-4f234ec64871"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("842d1f1e-4f2e-4cc2-ac82-88bb42ecb640"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("86b2ce77-471f-48a6-bae1-77031483d37d"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("8c38f38c-26d0-4a0b-8718-34a96ebf62aa"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("8cf3f2bc-76c5-4222-bbc7-36e285ff97a7"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("8d9cfcc7-9803-4a50-97b0-f0ed6abaaf8f"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("91dcefae-3590-4f69-88ec-149b2d5dc0c9"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("986bb132-76de-4d7e-b978-ddd2db3a7222"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("9905be75-4da9-4398-9ae2-9a6bbf294519"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("9917264a-bf7d-4667-a12a-857f6dc3c784"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("9946fa25-1e51-4e84-b909-b3dbdea94fc8"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("9f5c9cf9-1a5b-4b32-9a05-fb458b6039a3"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("a1aa512c-2765-40ff-abaa-f16b61844f04"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("a2062544-5389-48a6-957d-7bf33ba56738"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("a619e3e5-8feb-4191-8b56-2cc59c7f0b79"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("a6336e0d-33a9-4570-bbb1-ab080c759b20"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("a8da22bd-ce79-4776-8216-01eed8a980db"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("aaa6243f-a5dd-49da-90ba-5c9f3abcd445"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("ada630bd-148e-44ef-807c-d73771530ad9"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("ae2473a0-dc63-4b93-81a8-ba47ebc8aa78"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("b149b7b3-f375-4766-a5f0-a22476c67c7e"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("b1ad8425-e1b4-4bf6-b4ae-b5fdc2f450f5"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("b87887d6-60e2-4207-a659-b10c35bc8a82"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("b9978699-cfed-4958-aa75-f240217b92d5"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("c41a3535-7bba-438f-906e-7ccedb3a2a0f"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("c6adbbda-476b-4079-b340-5d06238aad1c"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("c8bc1746-c753-4587-87e1-1afad9d7e521"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("cb74004f-806d-4288-aa48-aafd1d7a72bc"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("cf6924bd-0eed-49a4-834d-20d0880be6a4"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("d0d7dfc8-f7d1-4c57-800e-f93fc7410d4a"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("d1f02df5-d9df-4ed0-9ee5-39e2e3c7bb70"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("d3f09b87-f7f7-4d7e-be4a-c44d8104fc1b"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("d5ff5a55-85e7-4b78-9320-ae93babb98ca"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("d9b98b65-761d-47d7-82cc-937664233454"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("d9f89784-2fc7-4585-a0d8-579c97855b09"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("da9762f1-b647-4b1e-85af-77d8ebff1a87"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("deea7293-bce9-4b52-9424-05974e2526b7"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("e15a8054-9c6c-437f-aaf3-dd82f4b57e51"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("e3954ce3-7503-49c5-bbab-f5272e43fe64"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("eefa0fda-61d9-495a-b309-bd3789b1981b"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("f0fe4706-0642-4d94-a4d9-583dd599ab5e"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("f2c1288c-7726-45c7-b8b5-080984cba6fe"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("f37e0164-d5d1-4118-9a73-2d65e276c85c"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("f6a90176-3873-4878-90f1-879d2c60a0c5"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("f9cc54a2-3be7-4df5-8f04-1780a96b062d"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("fb71a136-9bc9-4db9-81a8-ba7cb5ed6854"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("fc30553b-62b5-4cda-807b-0b08010bdeab"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("fcba7cc5-f7dd-4fac-a2bf-f93fc5bd973a"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("00c06fc7-1bfd-4d41-9685-184076bcbd45"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("00fc91a4-b045-4882-911c-e053eaf97386"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("015490f3-7c44-404c-9984-57aa491a8e8e"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("01be237e-2109-4e53-8439-d158fc52dfb6"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("03055f5b-21ec-4b58-bbde-ed31909ae41f"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("0339b38e-3249-47d2-a671-89d0e30a7087"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("0e2062e2-886d-4113-9f8f-10a6445a9448"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("10681bd7-1677-40a3-b789-966eb703ccea"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("115a365c-1d44-485e-861b-de29ecd605e2"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("12414a82-36b4-4224-8296-4b0dca96c342"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("19920de9-cc87-467d-9aab-76f88e71da71"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("2124be6e-f056-4157-82c9-9be3e96b4aab"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("218522d4-2f31-4cbe-9dc3-70046ad8c378"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("262eadab-aa80-4424-8005-364349c19807"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("2b54175a-8b58-48f1-b8b7-25ca47b7cd3c"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("34b07072-37ea-4758-add5-a9147ae6251a"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("34ce1795-938a-46cd-881d-7dd56a2e9de7"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("36a4d56a-7fbb-4a92-991c-81dff2f90992"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("36e238d7-59c2-494c-8f3f-be5db488c634"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("37334fd7-fa74-40b6-bd53-112482408f98"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("39da0014-9229-4e0c-b49c-f5e92f74e27f"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("3c17f104-10d3-4ac8-98a1-febba02132e6"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("41122216-cdab-49e6-b515-29caa0906249"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("41b2c732-f8a8-4e29-9269-bc43391f7def"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("41fcafc1-030d-41e2-abcb-d33ba5a1b8f0"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("425feebd-555d-48e3-9e53-9f4c2fd37831"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("4b5e4a58-a62a-49d9-aa1a-7c537768cf98"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("4f0e9a3b-6823-4688-866d-e78298a4e61e"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("5270fc5c-1659-4b2d-872a-dff9a559242b"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("548511c6-cb7c-4f76-be6a-c6df86e3e74a"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("5840c7e2-0f43-41c6-9cc7-1762ec7ef3f7"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("599ab63d-4375-4542-ab9e-84031d6b2ca6"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("5c98b53b-0207-4285-9aaf-9f65e6c7d47d"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("5e6741a5-b71b-415d-a221-37ed8c247de0"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("5f238cff-8271-41cf-b5ae-c60fe0a0b646"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("61913cf9-4615-4149-bdf2-67f8d4f0200d"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("656b7936-d631-44ea-88b7-45f6368f0d8b"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("65a77b64-41c7-497c-abdb-b06cdff185f9"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("69e2cd08-b32f-4346-a578-8214980662a9"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("6a632fba-765a-4a10-9159-72466736ee75"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("6bc8e085-4481-445f-8856-c137b0546760"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("6c24042b-9af6-42b5-8944-d8caf7918dc4"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("6f9bfb1d-bbd2-45dc-99ae-49385cba9c7a"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("710739da-4f0e-4f81-877b-96e66977173a"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("7218bb3a-a464-4ee5-ab2a-aab7dab30002"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("74ea1ef1-7738-4f40-bcc8-c9f9df1deca2"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("75105562-9b3b-4d04-8a4e-514ecc3d1381"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("756975e2-cd52-4af7-8832-9d7ef69be2c9"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("76bacd95-374b-4cdb-bc78-1702085a6470"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("7d7e1d57-f21c-4b7d-9899-325ba373664e"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("7fdd7a1b-b3fb-4917-8964-b4c698410d0f"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("825d75d1-2b94-471b-822d-4ba628ee6aa8"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("86a72990-ea87-4079-8384-f3b0ec76d06e"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("8c57527f-b0ec-42ed-9ed0-8dca4b03ed67"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("8da9b5dc-9bda-4c91-a3de-5f3b01488923"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("8f607b90-c24e-405f-97d3-3c9ec5dfceff"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("9214cc44-741b-4b62-a51d-93745e742c83"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("92bd5eaa-295b-482f-9d92-c725de38a4b1"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("93d5a42e-e620-4d8b-a8fa-8f71ab5b6c62"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("99ff12eb-06a3-4b87-81d2-61ac882ee6eb"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("9a391a0b-4f56-43f4-a370-bd42175bbbd5"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("9caa448d-677c-4c45-ac9e-4bd38071e0ce"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("9d4da082-51c0-434a-b340-6a427100350c"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("9d612cdd-b6d8-44a2-b623-deafcf091503"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a5fe49e6-db27-4f7a-a135-0cb0452572a3"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a6a8c3f1-03cb-4131-aa4c-78c3e673ee96"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a9087435-5c10-4871-88cf-3b8f18d1a98b"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("aa10ec4b-16ef-403b-81b5-c68cf3976a11"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("aac3c372-102c-4acd-b070-1f08643de572"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("ab4e9c2f-1b62-48cd-a6e1-943384947f4b"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("ac691082-93f9-4d88-9f35-bcdc4564bb83"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("b7fbf291-894c-4dbd-88c4-12bcee6172ca"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("b99ee5a9-41df-4803-ab81-10bdf0c4dffe"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("c25fc851-f96b-41f8-b270-fe2f8e5da1c6"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("c2b13821-83ad-4fab-bbe1-85bf7266964b"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("c64566fc-124e-40a8-a281-a3b058a48d2a"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("c6ac481f-c102-4941-a052-f8dda3dda1e9"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("c898ea68-3bcc-4e86-9335-b75b7cd8129e"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("c97ecfdc-bb14-4dee-8590-da2a36e24f78"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("cd4eaf6d-c983-4d4a-9ddb-745ecaff2047"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("d396c12d-39a3-4a66-9acc-433f97988241"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("d5c15929-8e99-438a-8c1a-d3706f748e27"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("d7af0e44-e8d5-45e6-8ac0-f85007ccaa14"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("d9c465da-6f39-4b37-b46d-b1ace9bb814f"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("da7ee2eb-c755-4bea-9e04-2c9b42c4b8f3"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("dc581d44-3d53-4ea9-8a56-c6fb0cc11c39"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("dd541b68-a0b7-4907-8c05-a080c7227b8c"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("e0430294-eecc-493c-9628-85bb91ac8c97"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("e5302020-c497-4f4b-b61a-4c3a56db56cb"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("e545ed4f-1670-4c03-b59f-9dc8e15315c8"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("ed69dc78-225a-47ae-8478-09a988c2a61c"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("ee3bad6f-1d39-44b2-a8dd-76eccedf6ecd"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("efa07730-262f-4574-ae1c-61be7938fc32"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f04e3eaa-1a7f-4968-bc35-43231a4c6b4e"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f1bd84b6-39b8-467e-be2c-f97fd5538adc"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f23ae627-2960-4b34-ba67-7fc3e31e2f5a"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f34f5330-1faa-4fba-944f-144621478027"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f5f01c36-fe49-4940-9e91-26126233f607"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f6311684-9e7e-4851-89f2-4fd8b0b43530"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f9531d8c-a9db-4a53-b841-4b5cdd1c83d8"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("fc92b0b1-2867-4755-885c-bdbc8ba3389c"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("fd6dfe43-5ab7-4726-bc03-b70d0c5f5fd7"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("fde7ea55-28e8-44e0-87ce-1a53b9a95bce"));

            migrationBuilder.DropColumn(
                name: "CountryId",
                table: "Allowances");

            migrationBuilder.AddColumn<Guid>(
                name: "AllowanceId",
                table: "Countries",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.InsertData(
                table: "Allowances",
                columns: new[] { "Id", "AccomodationAllowance", "CreatedDate", "DailyAllowance", "UpdatedDate", "ValidFrom", "ValidTo" },
                values: new object[,]
                {
                    { new Guid("00ad8d4a-e72c-41d6-bb81-edf4f64acb8e"), 100m, new DateTime(2022, 4, 4, 10, 5, 39, 0, DateTimeKind.Unspecified), 35m, null, new DateTime(2022, 4, 4, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("02970355-55c1-48f0-8bef-1a8be71523df"), 100m, new DateTime(2022, 4, 4, 10, 5, 39, 0, DateTimeKind.Unspecified), 30m, null, new DateTime(2022, 4, 4, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("02d82f8f-dbda-404a-97f6-812a3d5067bf"), 130m, new DateTime(2022, 4, 4, 10, 5, 39, 0, DateTimeKind.Unspecified), 35m, null, new DateTime(2022, 4, 4, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("0645fd2f-05bb-4f78-97ef-ebbcc8bcfcb8"), 110m, new DateTime(2022, 4, 4, 10, 5, 39, 0, DateTimeKind.Unspecified), 30m, null, new DateTime(2022, 4, 4, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("0ea17996-d872-4964-a7a7-ced9202fae69"), 150m, new DateTime(2022, 4, 4, 10, 5, 39, 0, DateTimeKind.Unspecified), 35m, null, new DateTime(2022, 4, 4, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("0f69d2de-b9ab-4ca8-9187-17e5b79547ec"), 130m, new DateTime(2022, 4, 4, 10, 5, 39, 0, DateTimeKind.Unspecified), 35m, null, new DateTime(2022, 4, 4, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("10bda487-6683-4f67-993e-5c31db9e30ac"), 130m, new DateTime(2022, 4, 4, 10, 5, 39, 0, DateTimeKind.Unspecified), 35m, null, new DateTime(2022, 4, 4, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("12a9bf58-2e44-4e2a-89b7-2f2b0305a270"), 130m, new DateTime(2022, 4, 4, 10, 5, 39, 0, DateTimeKind.Unspecified), 35m, null, new DateTime(2022, 4, 4, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("13db70b1-f633-4c3f-b705-811f2f84a820"), 100m, new DateTime(2022, 4, 4, 10, 5, 39, 0, DateTimeKind.Unspecified), 30m, null, new DateTime(2022, 4, 4, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("16c1a356-37f6-4ece-b94d-f258edfe759e"), 120m, new DateTime(2022, 4, 4, 10, 5, 39, 0, DateTimeKind.Unspecified), 30m, null, new DateTime(2022, 4, 4, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("1d3c32c5-bf51-4a16-a6ac-c74fa33f6b69"), 120m, new DateTime(2022, 4, 4, 10, 5, 39, 0, DateTimeKind.Unspecified), 35m, null, new DateTime(2022, 4, 4, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("1f73d32b-92e0-4241-85a9-5689af012327"), 80m, new DateTime(2022, 4, 4, 10, 5, 39, 0, DateTimeKind.Unspecified), 30m, null, new DateTime(2022, 4, 4, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("20e5e3a5-b5c6-4b9f-8d44-99ff2e4fc37c"), 100m, new DateTime(2022, 4, 4, 10, 5, 39, 0, DateTimeKind.Unspecified), 30m, null, new DateTime(2022, 4, 4, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("2371ea15-c84e-4788-b37c-ba9993a6e6fc"), 110m, new DateTime(2022, 4, 4, 10, 5, 39, 0, DateTimeKind.Unspecified), 30m, null, new DateTime(2022, 4, 4, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("2517e37f-8de9-4999-bf65-da4f970e7b89"), 80m, new DateTime(2022, 4, 4, 10, 5, 39, 0, DateTimeKind.Unspecified), 30m, null, new DateTime(2022, 4, 4, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("2939cb6d-2bf5-419c-b564-c85fcf225be0"), 80m, new DateTime(2022, 4, 4, 10, 5, 39, 0, DateTimeKind.Unspecified), 30m, null, new DateTime(2022, 4, 4, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("2976c8d2-2ba1-4873-b230-c54f3cae1960"), 90m, new DateTime(2022, 4, 4, 10, 5, 39, 0, DateTimeKind.Unspecified), 30m, null, new DateTime(2022, 4, 4, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("2bb67519-7b2d-47e0-8749-5c39fd432a1a"), 130m, new DateTime(2022, 4, 4, 10, 5, 39, 0, DateTimeKind.Unspecified), 35m, null, new DateTime(2022, 4, 4, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("2c61ceba-1337-46bc-9196-7c837ffd0a87"), 90m, new DateTime(2022, 4, 4, 10, 5, 39, 0, DateTimeKind.Unspecified), 30m, null, new DateTime(2022, 4, 4, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("3051ace1-3e51-476b-8122-4d80342f0527"), 100m, new DateTime(2022, 4, 4, 10, 5, 39, 0, DateTimeKind.Unspecified), 35m, null, new DateTime(2022, 4, 4, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("30a98fed-3c5a-4122-b909-76322bf7da27"), 90m, new DateTime(2022, 4, 4, 10, 5, 39, 0, DateTimeKind.Unspecified), 30m, null, new DateTime(2022, 4, 4, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("35d19bd9-c0ca-4868-8bcc-d9648b8c7d32"), 130m, new DateTime(2022, 4, 4, 10, 5, 39, 0, DateTimeKind.Unspecified), 35m, null, new DateTime(2022, 4, 4, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("3885e322-4b2e-439e-9209-6079a6231f3b"), 80m, new DateTime(2022, 4, 4, 10, 5, 39, 0, DateTimeKind.Unspecified), 30m, null, new DateTime(2022, 4, 4, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("3b3f219e-7407-4a6d-af78-e8a5874519f9"), 150m, new DateTime(2022, 4, 4, 10, 5, 39, 0, DateTimeKind.Unspecified), 35m, null, new DateTime(2022, 4, 4, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("3ba1c271-d10b-4b99-8b71-514b278b1278"), 130m, new DateTime(2022, 4, 4, 10, 5, 39, 0, DateTimeKind.Unspecified), 35m, null, new DateTime(2022, 4, 4, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("41edba2d-cd21-450f-ab00-6e2a340502a7"), 130m, new DateTime(2022, 4, 4, 10, 5, 39, 0, DateTimeKind.Unspecified), 35m, null, new DateTime(2022, 4, 4, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("45d51c75-d2c8-49b8-9583-8afccd7e63c3"), 130m, new DateTime(2022, 4, 4, 10, 5, 39, 0, DateTimeKind.Unspecified), 35m, null, new DateTime(2022, 4, 4, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("4766dfa9-edf6-49dd-808b-a4307482cd5d"), 70m, new DateTime(2022, 4, 4, 10, 5, 39, 0, DateTimeKind.Unspecified), 30m, null, new DateTime(2022, 4, 4, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("4b2909bd-f643-423a-8d4e-097ba6ea23a1"), 90m, new DateTime(2022, 4, 4, 10, 5, 39, 0, DateTimeKind.Unspecified), 30m, null, new DateTime(2022, 4, 4, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("4e13fa64-adeb-48bd-9848-e6d6f4fb412b"), 80m, new DateTime(2022, 4, 4, 10, 5, 39, 0, DateTimeKind.Unspecified), 30m, null, new DateTime(2022, 4, 4, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("4febddc4-9b28-4fe1-889c-2daa5760b157"), 90m, new DateTime(2022, 4, 4, 10, 5, 39, 0, DateTimeKind.Unspecified), 30m, null, new DateTime(2022, 4, 4, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("534b24b0-5ec3-4fee-9923-754174fba122"), 100m, new DateTime(2022, 4, 4, 10, 5, 39, 0, DateTimeKind.Unspecified), 30m, null, new DateTime(2022, 4, 4, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("5401d1c7-04f7-4f4e-b8aa-8027e026ee3e"), 100m, new DateTime(2022, 4, 4, 10, 5, 39, 0, DateTimeKind.Unspecified), 30m, null, new DateTime(2022, 4, 4, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("5416e64a-7c37-4d80-953a-f91007dce23b"), 100m, new DateTime(2022, 4, 4, 10, 5, 39, 0, DateTimeKind.Unspecified), 30m, null, new DateTime(2022, 4, 4, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("5463c3f6-bdcd-4423-98de-b4a92926b446"), 80m, new DateTime(2022, 4, 4, 10, 5, 39, 0, DateTimeKind.Unspecified), 30m, null, new DateTime(2022, 4, 4, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("58936f86-63bc-4f61-9702-d93e3c2206a8"), 17000m, new DateTime(2022, 4, 4, 10, 5, 39, 0, DateTimeKind.Unspecified), 5500m, null, new DateTime(2022, 4, 4, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("5b4d0d03-a3d6-4180-9e79-635be3342215"), 100m, new DateTime(2022, 4, 4, 10, 5, 39, 0, DateTimeKind.Unspecified), 30m, null, new DateTime(2022, 4, 4, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("6107aa1d-d4fa-44f4-aa84-c8b38aee7f51"), 90m, new DateTime(2022, 4, 4, 10, 5, 39, 0, DateTimeKind.Unspecified), 30m, null, new DateTime(2022, 4, 4, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("64d065c7-8529-4a22-910f-a79402e90ff6"), 130m, new DateTime(2022, 4, 4, 10, 5, 39, 0, DateTimeKind.Unspecified), 35m, null, new DateTime(2022, 4, 4, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("650c6e13-69d1-4171-b830-9e209078317d"), 100m, new DateTime(2022, 4, 4, 10, 5, 39, 0, DateTimeKind.Unspecified), 30m, null, new DateTime(2022, 4, 4, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("65334cb4-873a-4a03-afd8-f07f7c2ccc42"), 100m, new DateTime(2022, 4, 4, 10, 5, 39, 0, DateTimeKind.Unspecified), 30m, null, new DateTime(2022, 4, 4, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("66f74543-9c32-4484-88bf-0fe8e21d1626"), 100m, new DateTime(2022, 4, 4, 10, 5, 39, 0, DateTimeKind.Unspecified), 30m, null, new DateTime(2022, 4, 4, 0, 0, 0, 0, DateTimeKind.Local), null }
                });

            migrationBuilder.InsertData(
                table: "Allowances",
                columns: new[] { "Id", "AccomodationAllowance", "CreatedDate", "DailyAllowance", "UpdatedDate", "ValidFrom", "ValidTo" },
                values: new object[,]
                {
                    { new Guid("67753716-6e68-4c9e-8362-c63837a48c72"), 100m, new DateTime(2022, 4, 4, 10, 5, 39, 0, DateTimeKind.Unspecified), 30m, null, new DateTime(2022, 4, 4, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("69e09840-ba71-4757-9825-b1ad136fde1e"), 80m, new DateTime(2022, 4, 4, 10, 5, 39, 0, DateTimeKind.Unspecified), 30m, null, new DateTime(2022, 4, 4, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("6a54dafb-3975-434d-8f35-f81eaa4e71bc"), 130m, new DateTime(2022, 4, 4, 10, 5, 39, 0, DateTimeKind.Unspecified), 35m, null, new DateTime(2022, 4, 4, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("6bcf9b90-08ed-4c11-8a19-86b4a2da0608"), 130m, new DateTime(2022, 4, 4, 10, 5, 39, 0, DateTimeKind.Unspecified), 35m, null, new DateTime(2022, 4, 4, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("6f9d9500-5ee8-4a1a-890e-2be26859aaa1"), 80m, new DateTime(2022, 4, 4, 10, 5, 39, 0, DateTimeKind.Unspecified), 30m, null, new DateTime(2022, 4, 4, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("72cae632-8245-494d-a747-68c7ffccef57"), 90m, new DateTime(2022, 4, 4, 10, 5, 39, 0, DateTimeKind.Unspecified), 30m, null, new DateTime(2022, 4, 4, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("77b352f6-96b2-441e-a1f3-030dc7723141"), 80m, new DateTime(2022, 4, 4, 10, 5, 39, 0, DateTimeKind.Unspecified), 30m, null, new DateTime(2022, 4, 4, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("7ea3468d-8d53-4f8c-8519-5b128ca371f4"), 130m, new DateTime(2022, 4, 4, 10, 5, 39, 0, DateTimeKind.Unspecified), 35m, null, new DateTime(2022, 4, 4, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("7ff60891-9204-4a03-a41a-fbe8f51ab8fd"), 80m, new DateTime(2022, 4, 4, 10, 5, 39, 0, DateTimeKind.Unspecified), 35m, null, new DateTime(2022, 4, 4, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("8356ed9f-2867-4447-ac7e-8aa4c0aa3f33"), 100m, new DateTime(2022, 4, 4, 10, 5, 39, 0, DateTimeKind.Unspecified), 35m, null, new DateTime(2022, 4, 4, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("895e574f-5fa8-4003-ba84-b3517170dd8a"), 120m, new DateTime(2022, 4, 4, 10, 5, 39, 0, DateTimeKind.Unspecified), 35m, null, new DateTime(2022, 4, 4, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("8cf0dc78-9ff3-4718-8761-df4b482a1a80"), 100m, new DateTime(2022, 4, 4, 10, 5, 39, 0, DateTimeKind.Unspecified), 35m, null, new DateTime(2022, 4, 4, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("8f640311-c97d-47b4-a7b8-61b1d7c074a4"), 130m, new DateTime(2022, 4, 4, 10, 5, 39, 0, DateTimeKind.Unspecified), 35m, null, new DateTime(2022, 4, 4, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("8ff1dd7b-fda9-4d91-8669-8a5b5d81f6f2"), 100m, new DateTime(2022, 4, 4, 10, 5, 39, 0, DateTimeKind.Unspecified), 30m, null, new DateTime(2022, 4, 4, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("8ffaf79d-fa43-4b5f-ab4a-7578e2a80621"), 80m, new DateTime(2022, 4, 4, 10, 5, 39, 0, DateTimeKind.Unspecified), 30m, null, new DateTime(2022, 4, 4, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("920afa6b-444a-428c-b7bc-e3c848fcc290"), 80m, new DateTime(2022, 4, 4, 10, 5, 39, 0, DateTimeKind.Unspecified), 30m, null, new DateTime(2022, 4, 4, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("9330554a-2fa6-43dd-a818-4ffc6b95e0e1"), 130m, new DateTime(2022, 4, 4, 10, 5, 39, 0, DateTimeKind.Unspecified), 35m, null, new DateTime(2022, 4, 4, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("954a2a0b-a892-47fd-bba8-0b0ff927f879"), 130m, new DateTime(2022, 4, 4, 10, 5, 39, 0, DateTimeKind.Unspecified), 35m, null, new DateTime(2022, 4, 4, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("973834d7-d00b-46f7-980f-efffbf3466ea"), 145m, new DateTime(2022, 4, 4, 10, 5, 39, 0, DateTimeKind.Unspecified), 35m, null, new DateTime(2022, 4, 4, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("9ca42a61-39e4-42e7-af3b-e31e0decfc5f"), 130m, new DateTime(2022, 4, 4, 10, 5, 39, 0, DateTimeKind.Unspecified), 35m, null, new DateTime(2022, 4, 4, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("9e26960c-bb43-48b6-940d-4d79b06ff775"), 90m, new DateTime(2022, 4, 4, 10, 5, 39, 0, DateTimeKind.Unspecified), 30m, null, new DateTime(2022, 4, 4, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("9e49e28a-aa38-4c85-b834-6cf448100a07"), 100m, new DateTime(2022, 4, 4, 10, 5, 39, 0, DateTimeKind.Unspecified), 30m, null, new DateTime(2022, 4, 4, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("aa4bc67d-f0fa-48b1-a09d-8a794d2a0151"), 90m, new DateTime(2022, 4, 4, 10, 5, 39, 0, DateTimeKind.Unspecified), 30m, null, new DateTime(2022, 4, 4, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("ac770d6f-4cc0-4652-979a-cbf8092b40da"), 80m, new DateTime(2022, 4, 4, 10, 5, 39, 0, DateTimeKind.Unspecified), 30m, null, new DateTime(2022, 4, 4, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("ae7f422b-c99d-4f5f-822f-0da96db4036b"), 90m, new DateTime(2022, 4, 4, 10, 5, 39, 0, DateTimeKind.Unspecified), 30m, null, new DateTime(2022, 4, 4, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("b4651cb7-3215-4eb3-b3eb-766009e549c0"), 90m, new DateTime(2022, 4, 4, 10, 5, 39, 0, DateTimeKind.Unspecified), 30m, null, new DateTime(2022, 4, 4, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("b90ef163-402c-4ca8-84e4-d1c5a9c2129e"), 150m, new DateTime(2022, 4, 4, 10, 5, 39, 0, DateTimeKind.Unspecified), 60m, null, new DateTime(2022, 4, 4, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("b9d52c9b-19f9-447d-b453-f8f29dd7f54a"), 130m, new DateTime(2022, 4, 4, 10, 5, 39, 0, DateTimeKind.Unspecified), 35m, null, new DateTime(2022, 4, 4, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("bd1d3160-73b9-49b9-99f8-4fcc4647859e"), 130m, new DateTime(2022, 4, 4, 10, 5, 39, 0, DateTimeKind.Unspecified), 35m, null, new DateTime(2022, 4, 4, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("bd2fb50e-520d-4612-93a2-0e0f6a7e1de2"), 100m, new DateTime(2022, 4, 4, 10, 5, 39, 0, DateTimeKind.Unspecified), 30m, null, new DateTime(2022, 4, 4, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("be04b946-d0e2-4884-a7fa-216d20e6cb54"), 130m, new DateTime(2022, 4, 4, 10, 5, 39, 0, DateTimeKind.Unspecified), 35m, null, new DateTime(2022, 4, 4, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("be5ae145-839c-4b71-abe6-81e102c9361d"), 130m, new DateTime(2022, 4, 4, 10, 5, 39, 0, DateTimeKind.Unspecified), 35m, null, new DateTime(2022, 4, 4, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("c10d3147-790a-457c-8bfd-7e7209d27bc4"), 80m, new DateTime(2022, 4, 4, 10, 5, 39, 0, DateTimeKind.Unspecified), 30m, null, new DateTime(2022, 4, 4, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("c39c5c8e-246e-44f6-8f95-23ceb480986d"), 100m, new DateTime(2022, 4, 4, 10, 5, 39, 0, DateTimeKind.Unspecified), 30m, null, new DateTime(2022, 4, 4, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("c4f90e0f-6d83-4676-a3db-f52de347742c"), 100m, new DateTime(2022, 4, 4, 10, 5, 39, 0, DateTimeKind.Unspecified), 30m, null, new DateTime(2022, 4, 4, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("c64fabb5-8bda-4723-b80e-d2880b1b65dd"), 80m, new DateTime(2022, 4, 4, 10, 5, 39, 0, DateTimeKind.Unspecified), 30m, null, new DateTime(2022, 4, 4, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("c9561369-3b44-4e16-a80b-2493be385bc5"), 130m, new DateTime(2022, 4, 4, 10, 5, 39, 0, DateTimeKind.Unspecified), 35m, null, new DateTime(2022, 4, 4, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("cab9b92f-f902-486f-881b-cbf960c1d523"), 90m, new DateTime(2022, 4, 4, 10, 5, 39, 0, DateTimeKind.Unspecified), 30m, null, new DateTime(2022, 4, 4, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("cb342ff9-eb1a-44f0-a744-3c88b9b449a3"), 130m, new DateTime(2022, 4, 4, 10, 5, 39, 0, DateTimeKind.Unspecified), 35m, null, new DateTime(2022, 4, 4, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("cb91fdd8-f819-4427-a513-bafcc0aa764e"), 80m, new DateTime(2022, 4, 4, 10, 5, 39, 0, DateTimeKind.Unspecified), 30m, null, new DateTime(2022, 4, 4, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("d313e13e-c737-4fe1-b08b-bdcf4b78ca65"), 110m, new DateTime(2022, 4, 4, 10, 5, 39, 0, DateTimeKind.Unspecified), 30m, null, new DateTime(2022, 4, 4, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("d48d8567-fff5-4287-9183-6a69a5be649c"), 100m, new DateTime(2022, 4, 4, 10, 5, 39, 0, DateTimeKind.Unspecified), 35m, null, new DateTime(2022, 4, 4, 0, 0, 0, 0, DateTimeKind.Local), null }
                });

            migrationBuilder.InsertData(
                table: "Allowances",
                columns: new[] { "Id", "AccomodationAllowance", "CreatedDate", "DailyAllowance", "UpdatedDate", "ValidFrom", "ValidTo" },
                values: new object[,]
                {
                    { new Guid("d652469c-9c0a-450d-a164-f4f1b3011353"), 130m, new DateTime(2022, 4, 4, 10, 5, 39, 0, DateTimeKind.Unspecified), 35m, null, new DateTime(2022, 4, 4, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("d878154f-aa86-40e8-9b45-e0373302a241"), 90m, new DateTime(2022, 4, 4, 10, 5, 39, 0, DateTimeKind.Unspecified), 30m, null, new DateTime(2022, 4, 4, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("d92c0c3e-0a05-4c2c-9480-65307ddc5df1"), 130m, new DateTime(2022, 4, 4, 10, 5, 39, 0, DateTimeKind.Unspecified), 35m, null, new DateTime(2022, 4, 4, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("e0f776b7-1506-4545-8021-de020b5a01f2"), 110m, new DateTime(2022, 4, 4, 10, 5, 39, 0, DateTimeKind.Unspecified), 30m, null, new DateTime(2022, 4, 4, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("e255cd0a-06c6-40c0-9c48-c3a15c993141"), 120m, new DateTime(2022, 4, 4, 10, 5, 39, 0, DateTimeKind.Unspecified), 35m, null, new DateTime(2022, 4, 4, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("e3d66d56-e220-428c-820d-73ca94db334c"), 130m, new DateTime(2022, 4, 4, 10, 5, 39, 0, DateTimeKind.Unspecified), 35m, null, new DateTime(2022, 4, 4, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("e49ea94b-f0dc-47e0-a76f-20f98f4c1cbb"), 100m, new DateTime(2022, 4, 4, 10, 5, 39, 0, DateTimeKind.Unspecified), 30m, null, new DateTime(2022, 4, 4, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("e56e3eca-e1e1-4b53-b9b6-ce8710512c8c"), 130m, new DateTime(2022, 4, 4, 10, 5, 39, 0, DateTimeKind.Unspecified), 35m, null, new DateTime(2022, 4, 4, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("eb48beb4-fe01-4657-b73f-0b7a4ba660f6"), 130m, new DateTime(2022, 4, 4, 10, 5, 39, 0, DateTimeKind.Unspecified), 35m, null, new DateTime(2022, 4, 4, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("ee76912c-8c45-45f4-9301-a92906547f66"), 80m, new DateTime(2022, 4, 4, 10, 5, 39, 0, DateTimeKind.Unspecified), 30m, null, new DateTime(2022, 4, 4, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("ee88d394-f6fb-4523-aa1a-b4dae8218ed0"), 90m, new DateTime(2022, 4, 4, 10, 5, 39, 0, DateTimeKind.Unspecified), 30m, null, new DateTime(2022, 4, 4, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("f069d9df-4eb7-443a-b10b-9ecfbfa545d7"), 100m, new DateTime(2022, 4, 4, 10, 5, 39, 0, DateTimeKind.Unspecified), 35m, null, new DateTime(2022, 4, 4, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("f22fea04-ce17-43e3-95d7-2b99ad4b0773"), 130m, new DateTime(2022, 4, 4, 10, 5, 39, 0, DateTimeKind.Unspecified), 35m, null, new DateTime(2022, 4, 4, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("f59ca9bb-cf81-43de-96e1-8eafadc6c5f4"), 85m, new DateTime(2022, 4, 4, 10, 5, 39, 0, DateTimeKind.Unspecified), 30m, null, new DateTime(2022, 4, 4, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("f5b8894b-4445-4a47-b957-b7de13df8d98"), 130m, new DateTime(2022, 4, 4, 10, 5, 39, 0, DateTimeKind.Unspecified), 35m, null, new DateTime(2022, 4, 4, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("f87f9287-3fe4-4f45-a7fc-09e4e9fee017"), 130m, new DateTime(2022, 4, 4, 10, 5, 39, 0, DateTimeKind.Unspecified), 35m, null, new DateTime(2022, 4, 4, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("fa25df3a-e3c5-48db-9e9a-b69dd0b41635"), 130m, new DateTime(2022, 4, 4, 10, 5, 39, 0, DateTimeKind.Unspecified), 35m, null, new DateTime(2022, 4, 4, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("fa4ed1e3-afeb-4d4f-9a88-5ce93a29b1f0"), 130m, new DateTime(2022, 4, 4, 10, 5, 39, 0, DateTimeKind.Unspecified), 35m, null, new DateTime(2022, 4, 4, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("fffcf1e8-f2cb-423c-8457-7f63615e449b"), 130m, new DateTime(2022, 4, 4, 10, 5, 39, 0, DateTimeKind.Unspecified), 30m, null, new DateTime(2022, 4, 4, 0, 0, 0, 0, DateTimeKind.Local), null }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "AllowanceId", "CountryName", "CreatedDate", "CurrencyCode", "Description", "LocalCurrency", "TripCurrency", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("0171d43f-8c62-4768-9817-9e1f9ee4cf6b"), new Guid("6bcf9b90-08ed-4c11-8a19-86b4a2da0608"), "CROATIA", new DateTime(2022, 4, 4, 10, 5, 39, 0, DateTimeKind.Unspecified), 3, null, null, "Euro", null },
                    { new Guid("03519c76-a907-4837-be51-05d2d6881b5c"), new Guid("2939cb6d-2bf5-419c-b564-c85fcf225be0"), "UZBEKISTAN", new DateTime(2022, 4, 4, 10, 5, 39, 0, DateTimeKind.Unspecified), 1, null, null, "US Dollar", null },
                    { new Guid("04ea2746-2971-4157-bbe9-ffe261fb61ec"), new Guid("be5ae145-839c-4b71-abe6-81e102c9361d"), "CZECH REPUBLIC", new DateTime(2022, 4, 4, 10, 5, 39, 0, DateTimeKind.Unspecified), 3, null, null, "Euro", null },
                    { new Guid("04efaed0-ed27-4787-a28c-fafc0951c013"), new Guid("69e09840-ba71-4757-9825-b1ad136fde1e"), "ALBANIA", new DateTime(2022, 4, 4, 10, 5, 39, 0, DateTimeKind.Unspecified), 3, null, null, "Euro", null },
                    { new Guid("072ecd10-d5e7-44be-b52a-315100450e9d"), new Guid("6f9d9500-5ee8-4a1a-890e-2be26859aaa1"), "ETHIOPIA", new DateTime(2022, 4, 4, 10, 5, 39, 0, DateTimeKind.Unspecified), 1, null, null, "US Dollar", null },
                    { new Guid("072f171f-118b-45ef-b9b4-7846b58097eb"), new Guid("5b4d0d03-a3d6-4180-9e79-635be3342215"), "LEBANON", new DateTime(2022, 4, 4, 10, 5, 39, 0, DateTimeKind.Unspecified), 1, null, null, "US Dollar", null },
                    { new Guid("07e70607-7278-4186-895b-f9c7a9839642"), new Guid("f5b8894b-4445-4a47-b957-b7de13df8d98"), "LITHUANIA", new DateTime(2022, 4, 4, 10, 5, 39, 0, DateTimeKind.Unspecified), 3, null, null, "Euro", null },
                    { new Guid("0c56bb71-576a-48be-bb07-e0266555508b"), new Guid("9e49e28a-aa38-4c85-b834-6cf448100a07"), "COTE D'IVOIRE", new DateTime(2022, 4, 4, 10, 5, 39, 0, DateTimeKind.Unspecified), 1, null, null, "US Dollar", null },
                    { new Guid("0d779a8a-3a97-460a-afac-f46b108dcefa"), new Guid("6107aa1d-d4fa-44f4-aa84-c8b38aee7f51"), "PAKISTAN", new DateTime(2022, 4, 4, 10, 5, 39, 0, DateTimeKind.Unspecified), 1, null, null, "US Dollar", null },
                    { new Guid("0f72aea7-4510-4c7f-83d3-44f46445cfeb"), new Guid("d878154f-aa86-40e8-9b45-e0373302a241"), "NIGERIA", new DateTime(2022, 4, 4, 10, 5, 39, 0, DateTimeKind.Unspecified), 1, null, null, "US Dollar", null },
                    { new Guid("17ca8de5-0ef5-4df8-9fb9-bed1a007ae3d"), new Guid("9ca42a61-39e4-42e7-af3b-e31e0decfc5f"), "NETHERLANDS", new DateTime(2022, 4, 4, 10, 5, 39, 0, DateTimeKind.Unspecified), 3, null, null, "Euro", null },
                    { new Guid("19039f30-63ff-4607-8aac-62a4524a5439"), new Guid("64d065c7-8529-4a22-910f-a79402e90ff6"), "DENMARK", new DateTime(2022, 4, 4, 10, 5, 39, 0, DateTimeKind.Unspecified), 3, null, null, "Euro", null },
                    { new Guid("19dd5bb1-8b94-4836-9136-0b3da6c767d3"), new Guid("2976c8d2-2ba1-4873-b230-c54f3cae1960"), "NORTH KOREA", new DateTime(2022, 4, 4, 10, 5, 39, 0, DateTimeKind.Unspecified), 3, null, null, "Euro", null },
                    { new Guid("1b8ada37-4d89-49a1-b22e-2de686ca9c9d"), new Guid("920afa6b-444a-428c-b7bc-e3c848fcc290"), "BELARUS", new DateTime(2022, 4, 4, 10, 5, 39, 0, DateTimeKind.Unspecified), 1, null, null, "US Dollar", null },
                    { new Guid("1c35e41d-c676-4b54-a146-fd9a4286bddd"), new Guid("b9d52c9b-19f9-447d-b453-f8f29dd7f54a"), "SPAIN", new DateTime(2022, 4, 4, 10, 5, 39, 0, DateTimeKind.Unspecified), 3, null, null, "Euro", null },
                    { new Guid("1d09813c-071c-4af4-a808-86fa443b2e1f"), new Guid("8f640311-c97d-47b4-a7b8-61b1d7c074a4"), "FRANCE", new DateTime(2022, 4, 4, 10, 5, 39, 0, DateTimeKind.Unspecified), 3, null, null, "Euro", null },
                    { new Guid("25d38cca-99d9-4d1d-81b8-e7685d3fc9b6"), new Guid("c39c5c8e-246e-44f6-8f95-23ceb480986d"), "MONGOLIA", new DateTime(2022, 4, 4, 10, 5, 39, 0, DateTimeKind.Unspecified), 1, null, null, "US Dollar", null },
                    { new Guid("26cf78d6-1112-4bd3-9ac2-caeb1ed1b35c"), new Guid("ee76912c-8c45-45f4-9301-a92906547f66"), "ARMENIA", new DateTime(2022, 4, 4, 10, 5, 39, 0, DateTimeKind.Unspecified), 1, null, null, "US Dollar", null },
                    { new Guid("27492d74-1816-4e72-9228-ca4c14d61156"), new Guid("2517e37f-8de9-4999-bf65-da4f970e7b89"), "TUNISIA", new DateTime(2022, 4, 4, 10, 5, 39, 0, DateTimeKind.Unspecified), 1, null, null, "US Dollar", null },
                    { new Guid("2b9d3936-f203-4464-bc05-87fc755c090c"), new Guid("7ff60891-9204-4a03-a41a-fbe8f51ab8fd"), "ANGOLA", new DateTime(2022, 4, 4, 10, 5, 39, 0, DateTimeKind.Unspecified), 1, null, null, "US Dollar", null },
                    { new Guid("34b9e323-3c96-446d-b102-b547517c8b33"), new Guid("eb48beb4-fe01-4657-b73f-0b7a4ba660f6"), "BELGIUM", new DateTime(2022, 4, 4, 10, 5, 39, 0, DateTimeKind.Unspecified), 3, null, null, "Euro", null },
                    { new Guid("3740c888-f4f3-400a-ad1f-c0e4503f3650"), new Guid("c4f90e0f-6d83-4676-a3db-f52de347742c"), "UNITED ARAB EMIRATES", new DateTime(2022, 4, 4, 10, 5, 39, 0, DateTimeKind.Unspecified), 1, null, null, "US Dollar", null },
                    { new Guid("3b1d5651-3236-4bd5-a761-72dfc87e651d"), new Guid("fa4ed1e3-afeb-4d4f-9a88-5ce93a29b1f0"), "POLAND", new DateTime(2022, 4, 4, 10, 5, 39, 0, DateTimeKind.Unspecified), 3, null, null, "Euro", null },
                    { new Guid("3e43d43e-3968-445d-b6e5-dae6fae77ee5"), new Guid("bd2fb50e-520d-4612-93a2-0e0f6a7e1de2"), "KAZAKHSTAN", new DateTime(2022, 4, 4, 10, 5, 39, 0, DateTimeKind.Unspecified), 1, null, null, "US Dollar", null },
                    { new Guid("4449d2d9-05a8-420c-b820-d27406d2ab3f"), new Guid("8356ed9f-2867-4447-ac7e-8aa4c0aa3f33"), "ISRAEL", new DateTime(2022, 4, 4, 10, 5, 39, 0, DateTimeKind.Unspecified), 1, null, null, "US Dollar", null },
                    { new Guid("46971384-dffc-4569-b57a-46b517bc7189"), new Guid("9e26960c-bb43-48b6-940d-4d79b06ff775"), "IRAN", new DateTime(2022, 4, 4, 10, 5, 39, 0, DateTimeKind.Unspecified), 1, null, null, "US Dollar", null },
                    { new Guid("487eae95-2b73-4b3e-bbad-22103ca1e105"), new Guid("3b3f219e-7407-4a6d-af78-e8a5874519f9"), "RUSSIAN FEDERATION", new DateTime(2022, 4, 4, 10, 5, 39, 0, DateTimeKind.Unspecified), 1, null, null, "US Dollar", null },
                    { new Guid("4c7524b5-eb96-435c-b6b5-8debae8079de"), new Guid("3ba1c271-d10b-4b99-8b71-514b278b1278"), "PORTUGAL", new DateTime(2022, 4, 4, 10, 5, 39, 0, DateTimeKind.Unspecified), 3, null, null, "Euro", null },
                    { new Guid("4fece437-55c0-4834-a2f3-3b8d5cb24360"), new Guid("f22fea04-ce17-43e3-95d7-2b99ad4b0773"), "ICELAND", new DateTime(2022, 4, 4, 10, 5, 39, 0, DateTimeKind.Unspecified), 3, null, null, "Euro", null },
                    { new Guid("501fce34-ad8e-48a1-ad7d-c9053d1a59e0"), new Guid("bd1d3160-73b9-49b9-99f8-4fcc4647859e"), "SLOVENIA", new DateTime(2022, 4, 4, 10, 5, 39, 0, DateTimeKind.Unspecified), 3, null, null, "Euro", null },
                    { new Guid("51c253e5-88fe-4d5f-98b9-f58998d7225d"), new Guid("ee88d394-f6fb-4523-aa1a-b4dae8218ed0"), "MEXICO", new DateTime(2022, 4, 4, 10, 5, 39, 0, DateTimeKind.Unspecified), 1, null, null, "US Dollar", null },
                    { new Guid("55a0b395-005a-4aff-bb13-d1f0eab0afa0"), new Guid("67753716-6e68-4c9e-8362-c63837a48c72"), "CONGO", new DateTime(2022, 4, 4, 10, 5, 39, 0, DateTimeKind.Unspecified), 1, null, null, "US Dollar", null },
                    { new Guid("58b6fced-adf1-47e1-ad9c-7cca55f45239"), new Guid("b4651cb7-3215-4eb3-b3eb-766009e549c0"), "IRAQ", new DateTime(2022, 4, 4, 10, 5, 39, 0, DateTimeKind.Unspecified), 1, null, null, "US Dollar", null },
                    { new Guid("5f72d977-ea98-4e79-b87a-c42a9b249564"), new Guid("954a2a0b-a892-47fd-bba8-0b0ff927f879"), "LIECHTENSTEIN", new DateTime(2022, 4, 4, 10, 5, 39, 0, DateTimeKind.Unspecified), 3, null, null, "Euro", null },
                    { new Guid("5f7f8a40-ce63-4f6d-a54f-0311088fcb54"), new Guid("6a54dafb-3975-434d-8f35-f81eaa4e71bc"), "GIBRALTAR", new DateTime(2022, 4, 4, 10, 5, 39, 0, DateTimeKind.Unspecified), 3, null, null, "Euro", null },
                    { new Guid("6151e537-6ef0-4096-9359-666b694f5177"), new Guid("d313e13e-c737-4fe1-b08b-bdcf4b78ca65"), "UKRAINE", new DateTime(2022, 4, 4, 10, 5, 39, 0, DateTimeKind.Unspecified), 1, null, null, "US Dollar", null },
                    { new Guid("6398a269-0718-4bdc-8c98-77a958335562"), new Guid("e56e3eca-e1e1-4b53-b9b6-ce8710512c8c"), "MALTA", new DateTime(2022, 4, 4, 10, 5, 39, 0, DateTimeKind.Unspecified), 3, null, null, "Euro", null },
                    { new Guid("668574bd-69af-4252-9762-496ed50d9c2a"), new Guid("5416e64a-7c37-4d80-953a-f91007dce23b"), "YEMEN", new DateTime(2022, 4, 4, 10, 5, 39, 0, DateTimeKind.Unspecified), 1, null, null, "US Dollar", null },
                    { new Guid("67ea1920-8d60-468b-b3d3-c85cd8bb72af"), new Guid("d48d8567-fff5-4287-9183-6a69a5be649c"), "CANADA", new DateTime(2022, 4, 4, 10, 5, 39, 0, DateTimeKind.Unspecified), 1, null, null, "US Dollar", null },
                    { new Guid("6816ad0d-692b-44fe-810e-e1065dd11702"), new Guid("16c1a356-37f6-4ece-b94d-f258edfe759e"), "SOUTH KOREA", new DateTime(2022, 4, 4, 10, 5, 39, 0, DateTimeKind.Unspecified), 1, null, null, "US Dollar", null },
                    { new Guid("6a33dc2f-1e13-4aee-94ec-46f30131dc58"), new Guid("d92c0c3e-0a05-4c2c-9480-65307ddc5df1"), "IRELAND", new DateTime(2022, 4, 4, 10, 5, 39, 0, DateTimeKind.Unspecified), 3, null, null, "Euro", null },
                    { new Guid("6b86425e-0117-4255-b216-fb0cbca56497"), new Guid("35d19bd9-c0ca-4868-8bcc-d9648b8c7d32"), "SERBIA", new DateTime(2022, 4, 4, 10, 5, 39, 0, DateTimeKind.Unspecified), 3, null, null, "Euro", null }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "AllowanceId", "CountryName", "CreatedDate", "CurrencyCode", "Description", "LocalCurrency", "TripCurrency", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("6b8ce55e-54d1-41c9-8434-e8996fd73676"), new Guid("12a9bf58-2e44-4e2a-89b7-2f2b0305a270"), "LATVIA", new DateTime(2022, 4, 4, 10, 5, 39, 0, DateTimeKind.Unspecified), 3, null, null, "Euro", null },
                    { new Guid("6e21024f-aaae-419b-9f7a-8a2ccf76475c"), new Guid("fa25df3a-e3c5-48db-9e9a-b69dd0b41635"), "SAN MARINO", new DateTime(2022, 4, 4, 10, 5, 39, 0, DateTimeKind.Unspecified), 3, null, null, "Euro", null },
                    { new Guid("72907ea2-d49f-44c2-ae84-10a1175aa44a"), new Guid("e49ea94b-f0dc-47e0-a76f-20f98f4c1cbb"), "GHANA", new DateTime(2022, 4, 4, 10, 5, 39, 0, DateTimeKind.Unspecified), 1, null, null, "US Dollar", null },
                    { new Guid("739a8bc3-c915-4d5b-8bfb-02513b3889be"), new Guid("c64fabb5-8bda-4723-b80e-d2880b1b65dd"), "AFGHANISTAN", new DateTime(2022, 4, 4, 10, 5, 39, 0, DateTimeKind.Unspecified), 1, null, null, "US Dollar", null },
                    { new Guid("75a15105-3e44-4d6a-a9f7-31bf33accea2"), new Guid("2c61ceba-1337-46bc-9196-7c837ffd0a87"), "NICARAGUA", new DateTime(2022, 4, 4, 10, 5, 39, 0, DateTimeKind.Unspecified), 1, null, null, "US Dollar", null },
                    { new Guid("77337043-d24d-458c-9eda-537e0c6c0360"), new Guid("00ad8d4a-e72c-41d6-bb81-edf4f64acb8e"), "ALGERIA", new DateTime(2022, 4, 4, 10, 5, 39, 0, DateTimeKind.Unspecified), 1, null, null, "US Dollar", null },
                    { new Guid("7b8f9cd6-2137-4b42-9d9a-61b8a37c03ca"), new Guid("2371ea15-c84e-4788-b37c-ba9993a6e6fc"), "MOLDOVA", new DateTime(2022, 4, 4, 10, 5, 39, 0, DateTimeKind.Unspecified), 1, null, null, "US Dollar", null },
                    { new Guid("7e76511a-e060-4c60-954f-9aca820833bb"), new Guid("1f73d32b-92e0-4241-85a9-5689af012327"), "TURKMENISTAN", new DateTime(2022, 4, 4, 10, 5, 39, 0, DateTimeKind.Unspecified), 1, null, null, "US Dollar", null },
                    { new Guid("828bdf92-eb2f-4472-9007-4d5dacaac31e"), new Guid("13db70b1-f633-4c3f-b705-811f2f84a820"), "UNITED KINGDOM", new DateTime(2022, 4, 4, 10, 5, 39, 0, DateTimeKind.Unspecified), 5, null, null, "Pound Sterling", null },
                    { new Guid("838f0a41-7308-492d-b225-6dba3c578f4a"), new Guid("30a98fed-3c5a-4122-b909-76322bf7da27"), "CHINA", new DateTime(2022, 4, 4, 10, 5, 39, 0, DateTimeKind.Unspecified), 1, null, null, "US Dollar", null },
                    { new Guid("8615ec1b-02b8-4a6b-a2f1-dd16d1f76fd4"), new Guid("8ffaf79d-fa43-4b5f-ab4a-7578e2a80621"), "SYRIAN ARAB REPUBLIC", new DateTime(2022, 4, 4, 10, 5, 39, 0, DateTimeKind.Unspecified), 1, null, null, "US Dollar", null },
                    { new Guid("86c0ee4a-b5f6-4072-8ec7-8393a1a8fa89"), new Guid("e255cd0a-06c6-40c0-9c48-c3a15c993141"), "AUSTRALIA", new DateTime(2022, 4, 4, 10, 5, 39, 0, DateTimeKind.Unspecified), 4, null, null, "Australian Dollar", null },
                    { new Guid("8e948de8-3356-453d-a38b-e6a96f76ce9e"), new Guid("d652469c-9c0a-450d-a164-f4f1b3011353"), "SLOVAKIA", new DateTime(2022, 4, 4, 10, 5, 39, 0, DateTimeKind.Unspecified), 3, null, null, "Euro", null },
                    { new Guid("91424961-f77d-4d7e-ac0e-abff5290f677"), new Guid("cb342ff9-eb1a-44f0-a744-3c88b9b449a3"), "ITALY", new DateTime(2022, 4, 4, 10, 5, 39, 0, DateTimeKind.Unspecified), 3, null, null, "Euro", null },
                    { new Guid("929fa6da-935a-46b9-9d5b-8c27ebdfd530"), new Guid("c9561369-3b44-4e16-a80b-2493be385bc5"), "FINLAND", new DateTime(2022, 4, 4, 10, 5, 39, 0, DateTimeKind.Unspecified), 3, null, null, "Euro", null },
                    { new Guid("9336478f-dadb-422e-9fa7-dbbea3c8e0e7"), new Guid("7ea3468d-8d53-4f8c-8519-5b128ca371f4"), "ESTONIA", new DateTime(2022, 4, 4, 10, 5, 39, 0, DateTimeKind.Unspecified), 3, null, null, "Euro", null },
                    { new Guid("9405d658-596e-4df1-8cff-d8c4427cfdab"), new Guid("66f74543-9c32-4484-88bf-0fe8e21d1626"), "JORDAN", new DateTime(2022, 4, 4, 10, 5, 39, 0, DateTimeKind.Unspecified), 1, null, null, "US Dollar", null },
                    { new Guid("9442945e-52f4-40a4-a1a5-6a84d9614494"), new Guid("8ff1dd7b-fda9-4d91-8669-8a5b5d81f6f2"), "SINGAPORE", new DateTime(2022, 4, 4, 10, 5, 39, 0, DateTimeKind.Unspecified), 1, null, null, "US Dollar", null },
                    { new Guid("960684b3-f2cd-4cf2-b862-b4913622ae54"), new Guid("4766dfa9-edf6-49dd-808b-a4307482cd5d"), "PERU", new DateTime(2022, 4, 4, 10, 5, 39, 0, DateTimeKind.Unspecified), 1, null, null, "US Dollar", null },
                    { new Guid("98a23067-cd74-40ac-9764-03a2cf4fbb1f"), new Guid("4e13fa64-adeb-48bd-9848-e6d6f4fb412b"), "EGYPT", new DateTime(2022, 4, 4, 10, 5, 39, 0, DateTimeKind.Unspecified), 1, null, null, "US Dollar", null },
                    { new Guid("9a863eb0-e38a-4f2c-8c8c-ed7a95455e9d"), new Guid("4febddc4-9b28-4fe1-889c-2daa5760b157"), "SOUTH AFRICA", new DateTime(2022, 4, 4, 10, 5, 39, 0, DateTimeKind.Unspecified), 1, null, null, "US Dollar", null },
                    { new Guid("9b2831b7-8b7b-4ca6-be2e-e9e26aa90d32"), new Guid("b90ef163-402c-4ca8-84e4-d1c5a9c2129e"), "SWITZERLAND", new DateTime(2022, 4, 4, 10, 5, 39, 0, DateTimeKind.Unspecified), 6, null, null, "Swiss Franc", null },
                    { new Guid("9bdb544c-8cb7-4f22-9b19-86e0a75c12a4"), new Guid("895e574f-5fa8-4003-ba84-b3517170dd8a"), "MONACO", new DateTime(2022, 4, 4, 10, 5, 39, 0, DateTimeKind.Unspecified), 3, null, null, "Euro", null },
                    { new Guid("9c7946a1-4524-4757-94f1-f4cc4c6c93f1"), new Guid("e3d66d56-e220-428c-820d-73ca94db334c"), "BOSNIA AND HERZEGOVINA", new DateTime(2022, 4, 4, 10, 5, 39, 0, DateTimeKind.Unspecified), 3, null, null, "Euro", null },
                    { new Guid("9d656001-2c04-4bbe-822f-b87ca4c0e25d"), new Guid("4b2909bd-f643-423a-8d4e-097ba6ea23a1"), "MOZAMBIQUE", new DateTime(2022, 4, 4, 10, 5, 39, 0, DateTimeKind.Unspecified), 1, null, null, "US Dollar", null },
                    { new Guid("a1e22589-a877-4fc6-8801-bc5141496f2d"), new Guid("41edba2d-cd21-450f-ab00-6e2a340502a7"), "HUNGARY", new DateTime(2022, 4, 4, 10, 5, 39, 0, DateTimeKind.Unspecified), 3, null, null, "Euro", null },
                    { new Guid("a4799926-eef6-4e82-a81f-3aeb7820f0a9"), new Guid("1d3c32c5-bf51-4a16-a6ac-c74fa33f6b69"), "KUWAIT", new DateTime(2022, 4, 4, 10, 5, 39, 0, DateTimeKind.Unspecified), 1, null, null, "US Dollar", null },
                    { new Guid("a4ce4203-53dc-42c4-a68e-ac716fd38c63"), new Guid("77b352f6-96b2-441e-a1f3-030dc7723141"), "TAJIKISTAN", new DateTime(2022, 4, 4, 10, 5, 39, 0, DateTimeKind.Unspecified), 1, null, null, "US Dollar", null },
                    { new Guid("a7c15a4b-4071-4298-8f1a-59d030cad703"), new Guid("0ea17996-d872-4964-a7a7-ced9202fae69"), "UNITED STATES", new DateTime(2022, 4, 4, 10, 5, 39, 0, DateTimeKind.Unspecified), 1, null, null, "US Dollar", null },
                    { new Guid("a9fd8eb0-3561-4942-bfd9-e1cc34faa42b"), new Guid("8cf0dc78-9ff3-4718-8761-df4b482a1a80"), "CUBA", new DateTime(2022, 4, 4, 10, 5, 39, 0, DateTimeKind.Unspecified), 1, null, null, "US Dollar", null },
                    { new Guid("ac4c481d-819f-41b9-bd4c-4af0ae8c9a17"), new Guid("fffcf1e8-f2cb-423c-8457-7f63615e449b"), "MOROCCO", new DateTime(2022, 4, 4, 10, 5, 39, 0, DateTimeKind.Unspecified), 3, null, null, "Euro", null },
                    { new Guid("ac578b7f-0dc3-44a9-bdaf-ade125be47b4"), new Guid("0645fd2f-05bb-4f78-97ef-ebbcc8bcfcb8"), "AZERBAIJAN", new DateTime(2022, 4, 4, 10, 5, 39, 0, DateTimeKind.Unspecified), 1, null, null, "US Dollar", null },
                    { new Guid("b04b0ca1-0613-414e-88fe-637fb4da1b3a"), new Guid("973834d7-d00b-46f7-980f-efffbf3466ea"), "NORWAY", new DateTime(2022, 4, 4, 10, 5, 39, 0, DateTimeKind.Unspecified), 3, null, null, "Euro", null },
                    { new Guid("b52db7b9-d4a2-4ffa-a46b-fe6b17feac3c"), new Guid("f069d9df-4eb7-443a-b10b-9ecfbfa545d7"), "BRAZIL", new DateTime(2022, 4, 4, 10, 5, 39, 0, DateTimeKind.Unspecified), 1, null, null, "US Dollar", null },
                    { new Guid("b6b82ed7-8bd1-4be1-b136-92983fca047e"), new Guid("2bb67519-7b2d-47e0-8749-5c39fd432a1a"), "GERMANY", new DateTime(2022, 4, 4, 10, 5, 39, 0, DateTimeKind.Unspecified), 3, null, null, "Euro", null },
                    { new Guid("c04651b9-2273-4879-836e-098d7dd4a0c2"), new Guid("20e5e3a5-b5c6-4b9f-8d44-99ff2e4fc37c"), "SAUDI ARABIA", new DateTime(2022, 4, 4, 10, 5, 39, 0, DateTimeKind.Unspecified), 1, null, null, "US Dollar", null },
                    { new Guid("c086ead6-652d-496a-a30c-0e0126f1bf44"), new Guid("f59ca9bb-cf81-43de-96e1-8eafadc6c5f4"), "CHILE", new DateTime(2022, 4, 4, 10, 5, 39, 0, DateTimeKind.Unspecified), 1, null, null, "US Dollar", null },
                    { new Guid("c3d58132-68fd-4d48-aa51-cdd8345edac7"), new Guid("58936f86-63bc-4f61-9702-d93e3c2206a8"), "JAPAN", new DateTime(2022, 4, 4, 10, 5, 39, 0, DateTimeKind.Unspecified), 7, null, null, "Yen", null },
                    { new Guid("c4723281-e6ed-4704-89c9-e451e0a1942a"), new Guid("ac770d6f-4cc0-4652-979a-cbf8092b40da"), "MALI", new DateTime(2022, 4, 4, 10, 5, 39, 0, DateTimeKind.Unspecified), 1, null, null, "US Dollar", null },
                    { new Guid("c5283b45-d9fe-41e9-90f6-9b7ef2896509"), new Guid("9330554a-2fa6-43dd-a818-4ffc6b95e0e1"), "LUXEMBOURG", new DateTime(2022, 4, 4, 10, 5, 39, 0, DateTimeKind.Unspecified), 3, null, null, "Euro", null },
                    { new Guid("c8163e0a-f770-401d-9875-87a994859d33"), new Guid("10bda487-6683-4f67-993e-5c31db9e30ac"), "GREECE", new DateTime(2022, 4, 4, 10, 5, 39, 0, DateTimeKind.Unspecified), 3, null, null, "Euro", null },
                    { new Guid("c94834cf-a039-422d-9894-54a91d37112d"), new Guid("f87f9287-3fe4-4f45-a7fc-09e4e9fee017"), "SWEDEN", new DateTime(2022, 4, 4, 10, 5, 39, 0, DateTimeKind.Unspecified), 3, null, null, "Euro", null }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "AllowanceId", "CountryName", "CreatedDate", "CurrencyCode", "Description", "LocalCurrency", "TripCurrency", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("ca914db1-7265-48c8-8533-13d3e1347c2a"), new Guid("534b24b0-5ec3-4fee-9923-754174fba122"), "BANGLADESH", new DateTime(2022, 4, 4, 10, 5, 39, 0, DateTimeKind.Unspecified), 1, null, null, "US Dollar", null },
                    { new Guid("cd6a2ac3-1ad0-4b0e-b3f9-d9a886ff4375"), new Guid("c10d3147-790a-457c-8bfd-7e7209d27bc4"), "NEW ZEALAND", new DateTime(2022, 4, 4, 10, 5, 39, 0, DateTimeKind.Unspecified), 1, null, null, "US Dollar", null },
                    { new Guid("cd9428c4-21eb-4f00-b45a-6cfc0336cf0f"), new Guid("cab9b92f-f902-486f-881b-cbf960c1d523"), "TURKEY", new DateTime(2022, 4, 4, 10, 5, 39, 0, DateTimeKind.Unspecified), 1, null, null, "US Dollar", null },
                    { new Guid("daf60eca-fc2e-4c6f-bccb-90ef35a45986"), new Guid("3885e322-4b2e-439e-9209-6079a6231f3b"), "KENYA", new DateTime(2022, 4, 4, 10, 5, 39, 0, DateTimeKind.Unspecified), 1, null, null, "US Dollar", null },
                    { new Guid("db1315bc-a82b-44bd-bd81-0c7b284a5872"), new Guid("5463c3f6-bdcd-4423-98de-b4a92926b446"), "COLOMBIA", new DateTime(2022, 4, 4, 10, 5, 39, 0, DateTimeKind.Unspecified), 1, null, null, "US Dollar", null },
                    { new Guid("ddab0dde-2a0f-48c3-aa24-2aaa0c3c0107"), new Guid("5401d1c7-04f7-4f4e-b8aa-8027e026ee3e"), "GEORGIA", new DateTime(2022, 4, 4, 10, 5, 39, 0, DateTimeKind.Unspecified), 1, null, null, "US Dollar", null },
                    { new Guid("ddd1dbad-8c82-4cd0-92ba-dde21677d976"), new Guid("e0f776b7-1506-4545-8021-de020b5a01f2"), "INDONESIA", new DateTime(2022, 4, 4, 10, 5, 39, 0, DateTimeKind.Unspecified), 1, null, null, "US Dollar", null },
                    { new Guid("e8370c66-1db9-4852-a085-f4ba0f804dd7"), new Guid("0f69d2de-b9ab-4ca8-9187-17e5b79547ec"), "NORTH MACEDONIA", new DateTime(2022, 4, 4, 10, 5, 39, 0, DateTimeKind.Unspecified), 3, null, null, "Euro", null },
                    { new Guid("ebf2dbc3-7fb7-4896-a318-a15cc747985c"), new Guid("72cae632-8245-494d-a747-68c7ffccef57"), "KYRGYZSTAN", new DateTime(2022, 4, 4, 10, 5, 39, 0, DateTimeKind.Unspecified), 1, null, null, "US Dollar", null },
                    { new Guid("ee2b4ec1-c0bd-4e31-bb2a-c103cc091a10"), new Guid("cb91fdd8-f819-4427-a513-bafcc0aa764e"), "MALAYSIA", new DateTime(2022, 4, 4, 10, 5, 39, 0, DateTimeKind.Unspecified), 1, null, null, "US Dollar", null },
                    { new Guid("ef5a6d75-d07b-480b-b7f2-a67ccb2e9253"), new Guid("be04b946-d0e2-4884-a7fa-216d20e6cb54"), "CYPRUS", new DateTime(2022, 4, 4, 10, 5, 39, 0, DateTimeKind.Unspecified), 3, null, null, "Euro", null },
                    { new Guid("f36c4eb3-edb2-421b-8cb7-fb49988364df"), new Guid("650c6e13-69d1-4171-b830-9e209078317d"), "ZIMBABWE", new DateTime(2022, 4, 4, 10, 5, 39, 0, DateTimeKind.Unspecified), 1, null, null, "US Dollar", null },
                    { new Guid("f533655d-ac23-498f-b6f3-9bf20a6cf288"), new Guid("02d82f8f-dbda-404a-97f6-812a3d5067bf"), "ROMANIA", new DateTime(2022, 4, 4, 10, 5, 39, 0, DateTimeKind.Unspecified), 3, null, null, "Euro", null },
                    { new Guid("f8d13ffe-6d17-4cb4-9e50-466824e43dd6"), new Guid("aa4bc67d-f0fa-48b1-a09d-8a794d2a0151"), "INDIA", new DateTime(2022, 4, 4, 10, 5, 39, 0, DateTimeKind.Unspecified), 1, null, null, "US Dollar", null },
                    { new Guid("f91128f6-884f-4014-8a8e-a6e201cfff26"), new Guid("ae7f422b-c99d-4f5f-822f-0da96db4036b"), "ALL OTHER COUNTRIES", new DateTime(2022, 4, 4, 10, 5, 39, 0, DateTimeKind.Unspecified), 1, null, null, "US Dollar", null },
                    { new Guid("f9cdc137-17d0-44ac-a685-43768c706e27"), new Guid("45d51c75-d2c8-49b8-9583-8afccd7e63c3"), "AUSTRIA", new DateTime(2022, 4, 4, 10, 5, 39, 0, DateTimeKind.Unspecified), 3, null, null, "Euro", null },
                    { new Guid("f9d1b0c4-a721-4c0e-8673-9df7c4ef7d47"), new Guid("02970355-55c1-48f0-8bef-1a8be71523df"), "VIETNAM", new DateTime(2022, 4, 4, 10, 5, 39, 0, DateTimeKind.Unspecified), 1, null, null, "US Dollar", null },
                    { new Guid("fcbb9384-8230-4944-bfb1-f80f857b0d35"), new Guid("65334cb4-873a-4a03-afd8-f07f7c2ccc42"), "LIBYAN ARAB JAMAHIRIYA", new DateTime(2022, 4, 4, 10, 5, 39, 0, DateTimeKind.Unspecified), 1, null, null, "US Dollar", null },
                    { new Guid("ff53cc35-f1ad-4a85-920c-bc32015416e2"), new Guid("3051ace1-3e51-476b-8122-4d80342f0527"), "ARGENTINA", new DateTime(2022, 4, 4, 10, 5, 39, 0, DateTimeKind.Unspecified), 1, null, null, "US Dollar", null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Countries_AllowanceId",
                table: "Countries",
                column: "AllowanceId");

            migrationBuilder.AddForeignKey(
                name: "FK_Countries_Allowances_AllowanceId",
                table: "Countries",
                column: "AllowanceId",
                principalTable: "Allowances",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
