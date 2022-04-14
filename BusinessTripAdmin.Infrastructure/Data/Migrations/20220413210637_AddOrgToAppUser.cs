using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BusinessTripAdmin.Infrastructure.Data.Migrations
{
    public partial class AddOrgToAppUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AddColumn<Guid>(
                name: "OrganizationId",
                table: "AspNetUsers",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "CountryName", "CreatedDate", "CurrencyCode", "Description", "LocalCurrency", "TripCurrency", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("010609fc-eda6-4eb7-a184-fe19752b4b7b"), "MOZAMBIQUE", new DateTime(2022, 4, 14, 0, 6, 36, 0, DateTimeKind.Unspecified), 1, null, null, "US Dollar", null },
                    { new Guid("0372be54-44b3-46f7-90ff-447715b8fdf8"), "UNITED ARAB EMIRATES", new DateTime(2022, 4, 14, 0, 6, 36, 0, DateTimeKind.Unspecified), 1, null, null, "US Dollar", null },
                    { new Guid("03c45c43-aee5-4c63-ad08-4b14ea96aa1a"), "SYRIAN ARAB REPUBLIC", new DateTime(2022, 4, 14, 0, 6, 36, 0, DateTimeKind.Unspecified), 1, null, null, "US Dollar", null },
                    { new Guid("06181fb6-24c0-48cf-984d-aa5aca1ca910"), "BELGIUM", new DateTime(2022, 4, 14, 0, 6, 36, 0, DateTimeKind.Unspecified), 3, null, null, "Euro", null },
                    { new Guid("06ff9de6-a658-40bc-9d6b-8eb415952caa"), "ITALY", new DateTime(2022, 4, 14, 0, 6, 36, 0, DateTimeKind.Unspecified), 3, null, null, "Euro", null },
                    { new Guid("071640a2-40c2-4679-9e51-3ac40189554c"), "BANGLADESH", new DateTime(2022, 4, 14, 0, 6, 36, 0, DateTimeKind.Unspecified), 1, null, null, "US Dollar", null },
                    { new Guid("07c76c47-bfb7-420f-9768-7ea33444d78e"), "MALTA", new DateTime(2022, 4, 14, 0, 6, 36, 0, DateTimeKind.Unspecified), 3, null, null, "Euro", null },
                    { new Guid("0af38e38-3eb7-4150-9d2a-f1067c1b6002"), "UZBEKISTAN", new DateTime(2022, 4, 14, 0, 6, 36, 0, DateTimeKind.Unspecified), 1, null, null, "US Dollar", null },
                    { new Guid("0db8ff0a-f208-4e5d-9857-1e074184706f"), "ANGOLA", new DateTime(2022, 4, 14, 0, 6, 36, 0, DateTimeKind.Unspecified), 1, null, null, "US Dollar", null },
                    { new Guid("0e143ebe-15b4-4e0d-ae42-85753593c66e"), "SLOVENIA", new DateTime(2022, 4, 14, 0, 6, 36, 0, DateTimeKind.Unspecified), 3, null, null, "Euro", null },
                    { new Guid("0e7e31cf-7a82-4454-9a33-1d0ea36339b1"), "CUBA", new DateTime(2022, 4, 14, 0, 6, 36, 0, DateTimeKind.Unspecified), 1, null, null, "US Dollar", null },
                    { new Guid("0f66e89e-b527-4277-8184-e92ef28d9c75"), "LIBYAN ARAB JAMAHIRIYA", new DateTime(2022, 4, 14, 0, 6, 36, 0, DateTimeKind.Unspecified), 1, null, null, "US Dollar", null },
                    { new Guid("10378996-da5b-4b29-b32a-53d33d0567f4"), "CANADA", new DateTime(2022, 4, 14, 0, 6, 36, 0, DateTimeKind.Unspecified), 1, null, null, "US Dollar", null },
                    { new Guid("13c251b0-73ff-4265-a4d6-1e5313bc63e6"), "ZIMBABWE", new DateTime(2022, 4, 14, 0, 6, 36, 0, DateTimeKind.Unspecified), 1, null, null, "US Dollar", null },
                    { new Guid("17e20300-feef-4828-8be6-0cf1ec82c86a"), "MOROCCO", new DateTime(2022, 4, 14, 0, 6, 36, 0, DateTimeKind.Unspecified), 3, null, null, "Euro", null },
                    { new Guid("1dd0b8e8-4fb2-4824-bdf9-5625e58e2703"), "FRANCE", new DateTime(2022, 4, 14, 0, 6, 36, 0, DateTimeKind.Unspecified), 3, null, null, "Euro", null },
                    { new Guid("1dd1803b-2f31-4705-a590-67d14b7de76a"), "IRAQ", new DateTime(2022, 4, 14, 0, 6, 36, 0, DateTimeKind.Unspecified), 1, null, null, "US Dollar", null },
                    { new Guid("221db3f7-c987-416e-8b79-7c950be80e0f"), "SWEDEN", new DateTime(2022, 4, 14, 0, 6, 36, 0, DateTimeKind.Unspecified), 3, null, null, "Euro", null },
                    { new Guid("229a5dc2-f61c-402d-8e09-1ba665fa3cc2"), "IRELAND", new DateTime(2022, 4, 14, 0, 6, 36, 0, DateTimeKind.Unspecified), 3, null, null, "Euro", null },
                    { new Guid("2a33b3f4-9165-4711-ac86-9fc514a231bc"), "LIECHTENSTEIN", new DateTime(2022, 4, 14, 0, 6, 36, 0, DateTimeKind.Unspecified), 3, null, null, "Euro", null },
                    { new Guid("2fd39f62-6c9d-4be1-bfa9-f031aa41732d"), "SAUDI ARABIA", new DateTime(2022, 4, 14, 0, 6, 36, 0, DateTimeKind.Unspecified), 1, null, null, "US Dollar", null },
                    { new Guid("33e65511-5f76-4029-8905-e190368dcb3e"), "MALAYSIA", new DateTime(2022, 4, 14, 0, 6, 36, 0, DateTimeKind.Unspecified), 1, null, null, "US Dollar", null },
                    { new Guid("38af8e8d-457d-4435-ac5e-2b93a79295bd"), "SOUTH KOREA", new DateTime(2022, 4, 14, 0, 6, 36, 0, DateTimeKind.Unspecified), 1, null, null, "US Dollar", null },
                    { new Guid("42a89973-feb3-4bdc-aa4e-5581bdbe44e2"), "COTE D'IVOIRE", new DateTime(2022, 4, 14, 0, 6, 36, 0, DateTimeKind.Unspecified), 1, null, null, "US Dollar", null },
                    { new Guid("455d5fe2-0e7d-49f7-9f6a-af55c5ca80e0"), "KUWAIT", new DateTime(2022, 4, 14, 0, 6, 36, 0, DateTimeKind.Unspecified), 1, null, null, "US Dollar", null },
                    { new Guid("456254ed-6015-4be0-8466-b824a473c649"), "UNITED KINGDOM", new DateTime(2022, 4, 14, 0, 6, 36, 0, DateTimeKind.Unspecified), 5, null, null, "Pound Sterling", null },
                    { new Guid("464005f0-fc2f-432b-9d78-1ae20c2229ec"), "ARGENTINA", new DateTime(2022, 4, 14, 0, 6, 36, 0, DateTimeKind.Unspecified), 1, null, null, "US Dollar", null },
                    { new Guid("4c2e3ac5-fb8d-40db-9018-76f0cf964ada"), "KYRGYZSTAN", new DateTime(2022, 4, 14, 0, 6, 36, 0, DateTimeKind.Unspecified), 1, null, null, "US Dollar", null },
                    { new Guid("51142fea-f061-43c8-ba9a-c129242896d0"), "EGYPT", new DateTime(2022, 4, 14, 0, 6, 36, 0, DateTimeKind.Unspecified), 1, null, null, "US Dollar", null },
                    { new Guid("551ca0f0-fd9f-4ce7-be8a-dc4c5185ee0e"), "RUSSIAN FEDERATION", new DateTime(2022, 4, 14, 0, 6, 36, 0, DateTimeKind.Unspecified), 1, null, null, "US Dollar", null },
                    { new Guid("56afd974-d086-4b2e-9a4f-edb6231b20d7"), "UKRAINE", new DateTime(2022, 4, 14, 0, 6, 36, 0, DateTimeKind.Unspecified), 1, null, null, "US Dollar", null },
                    { new Guid("57b3061c-fab4-4901-bdf6-ed8e89461c21"), "CYPRUS", new DateTime(2022, 4, 14, 0, 6, 36, 0, DateTimeKind.Unspecified), 3, null, null, "Euro", null },
                    { new Guid("5b74297f-3c5b-45e3-91db-3af4b747b27d"), "SERBIA", new DateTime(2022, 4, 14, 0, 6, 36, 0, DateTimeKind.Unspecified), 3, null, null, "Euro", null },
                    { new Guid("5bda40a0-fbcb-4572-a6f3-4867f91c6008"), "SPAIN", new DateTime(2022, 4, 14, 0, 6, 36, 0, DateTimeKind.Unspecified), 3, null, null, "Euro", null },
                    { new Guid("5e212ca0-5b40-4599-a720-08250aab973b"), "ALBANIA", new DateTime(2022, 4, 14, 0, 6, 36, 0, DateTimeKind.Unspecified), 3, null, null, "Euro", null },
                    { new Guid("65343279-c694-467a-99b6-98f0e82249ac"), "AFGHANISTAN", new DateTime(2022, 4, 14, 0, 6, 36, 0, DateTimeKind.Unspecified), 1, null, null, "US Dollar", null },
                    { new Guid("65f5f0bb-149d-4230-aa48-32b497a28a6f"), "UNITED STATES", new DateTime(2022, 4, 14, 0, 6, 36, 0, DateTimeKind.Unspecified), 1, null, null, "US Dollar", null },
                    { new Guid("72a1fadc-17be-48e9-b83e-4a313d153b1b"), "TUNISIA", new DateTime(2022, 4, 14, 0, 6, 36, 0, DateTimeKind.Unspecified), 1, null, null, "US Dollar", null },
                    { new Guid("78954108-64a9-466a-94ee-d0ddc0221369"), "GHANA", new DateTime(2022, 4, 14, 0, 6, 36, 0, DateTimeKind.Unspecified), 1, null, null, "US Dollar", null },
                    { new Guid("78d2606a-ceed-4a1d-94d7-909c2f74e72f"), "CONGO", new DateTime(2022, 4, 14, 0, 6, 36, 0, DateTimeKind.Unspecified), 1, null, null, "US Dollar", null },
                    { new Guid("790e0bee-bf86-44d5-b378-531d6ee73bcd"), "GEORGIA", new DateTime(2022, 4, 14, 0, 6, 36, 0, DateTimeKind.Unspecified), 1, null, null, "US Dollar", null },
                    { new Guid("7ca23889-1b4d-4edf-baa3-ef0a3de6ffd3"), "ROMANIA", new DateTime(2022, 4, 14, 0, 6, 36, 0, DateTimeKind.Unspecified), 3, null, null, "Euro", null }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "CountryName", "CreatedDate", "CurrencyCode", "Description", "LocalCurrency", "TripCurrency", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("7d5eeea6-17ac-44a6-9448-b842e49b2e23"), "MALI", new DateTime(2022, 4, 14, 0, 6, 36, 0, DateTimeKind.Unspecified), 1, null, null, "US Dollar", null },
                    { new Guid("7f637c97-8bf5-47f1-90bb-9cb0594a024b"), "GERMANY", new DateTime(2022, 4, 14, 0, 6, 36, 0, DateTimeKind.Unspecified), 3, null, null, "Euro", null },
                    { new Guid("83ebae76-a245-48be-800d-a20a8c0e7d40"), "COLOMBIA", new DateTime(2022, 4, 14, 0, 6, 36, 0, DateTimeKind.Unspecified), 1, null, null, "US Dollar", null },
                    { new Guid("83f967d6-fd80-4559-b17f-51cf3e11b1eb"), "AZERBAIJAN", new DateTime(2022, 4, 14, 0, 6, 36, 0, DateTimeKind.Unspecified), 1, null, null, "US Dollar", null },
                    { new Guid("84b90426-77d3-4d9b-b686-bdea7fc40c1e"), "ISRAEL", new DateTime(2022, 4, 14, 0, 6, 36, 0, DateTimeKind.Unspecified), 1, null, null, "US Dollar", null },
                    { new Guid("87b3b1e8-49a5-4398-9df8-82b50040a7a8"), "YEMEN", new DateTime(2022, 4, 14, 0, 6, 36, 0, DateTimeKind.Unspecified), 1, null, null, "US Dollar", null },
                    { new Guid("8a5d3a6d-0fb3-41d7-917a-6fdc18ddb2ce"), "IRAN", new DateTime(2022, 4, 14, 0, 6, 36, 0, DateTimeKind.Unspecified), 1, null, null, "US Dollar", null },
                    { new Guid("8b5a785a-9a15-443e-bb3f-b81296c9ef7a"), "CZECH REPUBLIC", new DateTime(2022, 4, 14, 0, 6, 36, 0, DateTimeKind.Unspecified), 3, null, null, "Euro", null },
                    { new Guid("8db10b59-6e5e-4987-bbf9-065b02a6b647"), "KENYA", new DateTime(2022, 4, 14, 0, 6, 36, 0, DateTimeKind.Unspecified), 1, null, null, "US Dollar", null },
                    { new Guid("8e024101-f633-49d6-b995-cfef9ad126a5"), "LATVIA", new DateTime(2022, 4, 14, 0, 6, 36, 0, DateTimeKind.Unspecified), 3, null, null, "Euro", null },
                    { new Guid("9436f353-11b2-4a8f-8857-42c798ce66ad"), "BRAZIL", new DateTime(2022, 4, 14, 0, 6, 36, 0, DateTimeKind.Unspecified), 1, null, null, "US Dollar", null },
                    { new Guid("95d91f47-c373-4f12-ba02-4444984fbaac"), "GIBRALTAR", new DateTime(2022, 4, 14, 0, 6, 36, 0, DateTimeKind.Unspecified), 3, null, null, "Euro", null },
                    { new Guid("9724de5e-0262-422e-bc08-4a95af11470e"), "PAKISTAN", new DateTime(2022, 4, 14, 0, 6, 36, 0, DateTimeKind.Unspecified), 1, null, null, "US Dollar", null },
                    { new Guid("97de9535-853e-4e5b-ad7e-b3225b189a87"), "MONACO", new DateTime(2022, 4, 14, 0, 6, 36, 0, DateTimeKind.Unspecified), 3, null, null, "Euro", null },
                    { new Guid("982cca6b-f18d-4c1d-aa9e-49f8bf0156a3"), "POLAND", new DateTime(2022, 4, 14, 0, 6, 36, 0, DateTimeKind.Unspecified), 3, null, null, "Euro", null },
                    { new Guid("a1332120-93d9-41af-b79d-c8fe50975c98"), "CROATIA", new DateTime(2022, 4, 14, 0, 6, 36, 0, DateTimeKind.Unspecified), 3, null, null, "Euro", null },
                    { new Guid("a166bb7a-13c0-40bc-942c-fdcf67215b92"), "ICELAND", new DateTime(2022, 4, 14, 0, 6, 36, 0, DateTimeKind.Unspecified), 3, null, null, "Euro", null },
                    { new Guid("a200c90f-c108-4cf3-9954-2c28f944f3e8"), "PERU", new DateTime(2022, 4, 14, 0, 6, 36, 0, DateTimeKind.Unspecified), 1, null, null, "US Dollar", null },
                    { new Guid("a2edf1c6-9a8d-4133-84f6-613fe94a542e"), "SAN MARINO", new DateTime(2022, 4, 14, 0, 6, 36, 0, DateTimeKind.Unspecified), 3, null, null, "Euro", null },
                    { new Guid("a428da7b-e12c-4d58-8b5f-17dde46b7dd5"), "DENMARK", new DateTime(2022, 4, 14, 0, 6, 36, 0, DateTimeKind.Unspecified), 3, null, null, "Euro", null },
                    { new Guid("a542f75e-f1cb-4328-b69e-4043aa5b3087"), "TURKEY", new DateTime(2022, 4, 14, 0, 6, 36, 0, DateTimeKind.Unspecified), 1, null, null, "US Dollar", null },
                    { new Guid("a61829ad-3dd9-4e50-b3e6-67a6faac5772"), "NEW ZEALAND", new DateTime(2022, 4, 14, 0, 6, 36, 0, DateTimeKind.Unspecified), 1, null, null, "US Dollar", null },
                    { new Guid("a90a7269-2228-4d1f-bb4c-a0caddbf8e27"), "TURKMENISTAN", new DateTime(2022, 4, 14, 0, 6, 36, 0, DateTimeKind.Unspecified), 1, null, null, "US Dollar", null },
                    { new Guid("a92cb692-f1a3-4076-bc31-60f45d5284ea"), "NORWAY", new DateTime(2022, 4, 14, 0, 6, 36, 0, DateTimeKind.Unspecified), 3, null, null, "Euro", null },
                    { new Guid("ae8b8faf-357b-4213-b286-9173a020b464"), "ARMENIA", new DateTime(2022, 4, 14, 0, 6, 36, 0, DateTimeKind.Unspecified), 1, null, null, "US Dollar", null },
                    { new Guid("b1aa35b5-69d8-42f0-be80-b5442aef01c1"), "MONGOLIA", new DateTime(2022, 4, 14, 0, 6, 36, 0, DateTimeKind.Unspecified), 1, null, null, "US Dollar", null },
                    { new Guid("b33a2ee4-29f8-4d22-b392-c7a83e97728b"), "LITHUANIA", new DateTime(2022, 4, 14, 0, 6, 36, 0, DateTimeKind.Unspecified), 3, null, null, "Euro", null },
                    { new Guid("b675bc74-b39d-4f7e-8dbd-39d75a5d0027"), "CHINA", new DateTime(2022, 4, 14, 0, 6, 36, 0, DateTimeKind.Unspecified), 1, null, null, "US Dollar", null },
                    { new Guid("b68c3a50-f04d-4698-8e6b-6064a7c152cf"), "SLOVAKIA", new DateTime(2022, 4, 14, 0, 6, 36, 0, DateTimeKind.Unspecified), 3, null, null, "Euro", null },
                    { new Guid("b84f5d11-3191-4e01-b057-8b87c7ef174e"), "VIETNAM", new DateTime(2022, 4, 14, 0, 6, 36, 0, DateTimeKind.Unspecified), 1, null, null, "US Dollar", null },
                    { new Guid("b94a951d-ad48-46d8-a520-f8f19a09d601"), "JAPAN", new DateTime(2022, 4, 14, 0, 6, 36, 0, DateTimeKind.Unspecified), 7, null, null, "Yen", null },
                    { new Guid("bbc5e980-61bd-4b1a-94a7-09694bf8af3f"), "CHILE", new DateTime(2022, 4, 14, 0, 6, 36, 0, DateTimeKind.Unspecified), 1, null, null, "US Dollar", null },
                    { new Guid("bca8ac88-9b46-4957-91a5-91c14c6efda0"), "NORTH MACEDONIA", new DateTime(2022, 4, 14, 0, 6, 36, 0, DateTimeKind.Unspecified), 3, null, null, "Euro", null },
                    { new Guid("bd633ce6-a327-45dd-9d76-89338e7c3bff"), "MEXICO", new DateTime(2022, 4, 14, 0, 6, 36, 0, DateTimeKind.Unspecified), 1, null, null, "US Dollar", null },
                    { new Guid("bdf2e51e-91ba-4cbf-b4b7-97362091cd2e"), "NORTH KOREA", new DateTime(2022, 4, 14, 0, 6, 36, 0, DateTimeKind.Unspecified), 3, null, null, "Euro", null },
                    { new Guid("c2401310-bddd-4f93-a0e6-407f6c82355d"), "INDIA", new DateTime(2022, 4, 14, 0, 6, 36, 0, DateTimeKind.Unspecified), 1, null, null, "US Dollar", null },
                    { new Guid("c462d47f-5898-4a70-a3fc-1369243f484a"), "INDONESIA", new DateTime(2022, 4, 14, 0, 6, 36, 0, DateTimeKind.Unspecified), 1, null, null, "US Dollar", null },
                    { new Guid("c6190450-9d62-4163-9470-5b7b2ebb71e6"), "SOUTH AFRICA", new DateTime(2022, 4, 14, 0, 6, 36, 0, DateTimeKind.Unspecified), 1, null, null, "US Dollar", null },
                    { new Guid("c8cde5e2-df86-49e5-a4cb-cdf5df5ac497"), "LEBANON", new DateTime(2022, 4, 14, 0, 6, 36, 0, DateTimeKind.Unspecified), 1, null, null, "US Dollar", null },
                    { new Guid("ca7deaf6-e998-4898-96e1-69d378662c52"), "SINGAPORE", new DateTime(2022, 4, 14, 0, 6, 36, 0, DateTimeKind.Unspecified), 1, null, null, "US Dollar", null },
                    { new Guid("ce8940bb-877e-4379-bcc4-ce6c8863f991"), "HUNGARY", new DateTime(2022, 4, 14, 0, 6, 36, 0, DateTimeKind.Unspecified), 3, null, null, "Euro", null },
                    { new Guid("d1943d0e-7ff8-419b-83b4-5ac8f7f86ae9"), "AUSTRALIA", new DateTime(2022, 4, 14, 0, 6, 36, 0, DateTimeKind.Unspecified), 4, null, null, "Australian Dollar", null }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "CountryName", "CreatedDate", "CurrencyCode", "Description", "LocalCurrency", "TripCurrency", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("d1c6118c-eb87-482e-a760-3c23d95a255e"), "ALGERIA", new DateTime(2022, 4, 14, 0, 6, 36, 0, DateTimeKind.Unspecified), 1, null, null, "US Dollar", null },
                    { new Guid("d9652f33-298c-4918-9479-c4c07c3ad69d"), "ALL OTHER COUNTRIES", new DateTime(2022, 4, 14, 0, 6, 36, 0, DateTimeKind.Unspecified), 1, null, null, "US Dollar", null },
                    { new Guid("db5b3ce1-b970-4c16-9fab-09d529b1cac0"), "PORTUGAL", new DateTime(2022, 4, 14, 0, 6, 36, 0, DateTimeKind.Unspecified), 3, null, null, "Euro", null },
                    { new Guid("dbf670e4-84bb-4ffb-8383-eeaa14640f15"), "FINLAND", new DateTime(2022, 4, 14, 0, 6, 36, 0, DateTimeKind.Unspecified), 3, null, null, "Euro", null },
                    { new Guid("dc4cbbfd-a927-4e8f-804c-16472a80a5fd"), "NIGERIA", new DateTime(2022, 4, 14, 0, 6, 36, 0, DateTimeKind.Unspecified), 1, null, null, "US Dollar", null },
                    { new Guid("e28f5662-29a3-4e15-ba0b-62a3ba80ca1c"), "NICARAGUA", new DateTime(2022, 4, 14, 0, 6, 36, 0, DateTimeKind.Unspecified), 1, null, null, "US Dollar", null },
                    { new Guid("e4ef12c2-daf0-42f4-aa1c-0c769f17742a"), "JORDAN", new DateTime(2022, 4, 14, 0, 6, 36, 0, DateTimeKind.Unspecified), 1, null, null, "US Dollar", null },
                    { new Guid("e7e556b2-489c-457d-94c4-15271d8cb1e2"), "SWITZERLAND", new DateTime(2022, 4, 14, 0, 6, 36, 0, DateTimeKind.Unspecified), 6, null, null, "Swiss Franc", null },
                    { new Guid("e86864bf-4cee-4076-b074-7511661eec00"), "BELARUS", new DateTime(2022, 4, 14, 0, 6, 36, 0, DateTimeKind.Unspecified), 1, null, null, "US Dollar", null },
                    { new Guid("e89a3e4a-7148-404c-ba88-981ae1926c1c"), "KAZAKHSTAN", new DateTime(2022, 4, 14, 0, 6, 36, 0, DateTimeKind.Unspecified), 1, null, null, "US Dollar", null },
                    { new Guid("e912a5c0-bb57-411c-be58-cc02437e0067"), "NETHERLANDS", new DateTime(2022, 4, 14, 0, 6, 36, 0, DateTimeKind.Unspecified), 3, null, null, "Euro", null },
                    { new Guid("eafd2dcd-e617-456d-b2d7-5d23a1913762"), "TAJIKISTAN", new DateTime(2022, 4, 14, 0, 6, 36, 0, DateTimeKind.Unspecified), 1, null, null, "US Dollar", null },
                    { new Guid("f13dd042-96ee-4d5b-b7e9-81505a2fa97d"), "ESTONIA", new DateTime(2022, 4, 14, 0, 6, 36, 0, DateTimeKind.Unspecified), 3, null, null, "Euro", null },
                    { new Guid("f27570da-8d09-44fa-8ff0-148deafe79f3"), "AUSTRIA", new DateTime(2022, 4, 14, 0, 6, 36, 0, DateTimeKind.Unspecified), 3, null, null, "Euro", null },
                    { new Guid("f2a6edb4-d393-4931-af92-b486472bfd47"), "ETHIOPIA", new DateTime(2022, 4, 14, 0, 6, 36, 0, DateTimeKind.Unspecified), 1, null, null, "US Dollar", null },
                    { new Guid("fbab591b-806e-4cff-9965-d70cd1dc2790"), "BOSNIA AND HERZEGOVINA", new DateTime(2022, 4, 14, 0, 6, 36, 0, DateTimeKind.Unspecified), 3, null, null, "Euro", null },
                    { new Guid("fc4b3470-46a5-45f8-b925-be3d73165c48"), "GREECE", new DateTime(2022, 4, 14, 0, 6, 36, 0, DateTimeKind.Unspecified), 3, null, null, "Euro", null },
                    { new Guid("fde06b7f-61ad-455a-9158-e8ae5184c00e"), "LUXEMBOURG", new DateTime(2022, 4, 14, 0, 6, 36, 0, DateTimeKind.Unspecified), 3, null, null, "Euro", null },
                    { new Guid("ffb0388c-4e72-4c48-b0cb-dd8fb947bf5e"), "MOLDOVA", new DateTime(2022, 4, 14, 0, 6, 36, 0, DateTimeKind.Unspecified), 1, null, null, "US Dollar", null }
                });

            migrationBuilder.InsertData(
                table: "Allowances",
                columns: new[] { "Id", "AccomodationAllowance", "CountryId", "CreatedDate", "DailyAllowance", "UpdatedDate", "ValidFrom", "ValidTo" },
                values: new object[,]
                {
                    { new Guid("02eb4299-8d3d-4917-9d83-edb1a80b87df"), 90m, new Guid("010609fc-eda6-4eb7-a184-fe19752b4b7b"), new DateTime(2022, 4, 14, 0, 6, 36, 0, DateTimeKind.Unspecified), 30m, null, new DateTime(2022, 4, 14, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("08c59096-f953-45dc-b29f-874838ed719d"), 100m, new Guid("9436f353-11b2-4a8f-8857-42c798ce66ad"), new DateTime(2022, 4, 14, 0, 6, 36, 0, DateTimeKind.Unspecified), 35m, null, new DateTime(2022, 4, 14, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("0d50fd6f-6bf3-40df-8b5f-7c87c6e87710"), 130m, new Guid("06ff9de6-a658-40bc-9d6b-8eb415952caa"), new DateTime(2022, 4, 14, 0, 6, 36, 0, DateTimeKind.Unspecified), 35m, null, new DateTime(2022, 4, 14, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("122867dd-7faf-4d66-a714-a9fc6a2d2d29"), 130m, new Guid("8e024101-f633-49d6-b995-cfef9ad126a5"), new DateTime(2022, 4, 14, 0, 6, 36, 0, DateTimeKind.Unspecified), 35m, null, new DateTime(2022, 4, 14, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("14681415-d9b2-49eb-97da-7b8c1397ae03"), 80m, new Guid("0db8ff0a-f208-4e5d-9857-1e074184706f"), new DateTime(2022, 4, 14, 0, 6, 36, 0, DateTimeKind.Unspecified), 35m, null, new DateTime(2022, 4, 14, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("17ca3a62-a59a-4f52-a345-bc0808a8ab17"), 130m, new Guid("f13dd042-96ee-4d5b-b7e9-81505a2fa97d"), new DateTime(2022, 4, 14, 0, 6, 36, 0, DateTimeKind.Unspecified), 35m, null, new DateTime(2022, 4, 14, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("1c6ddc74-9e60-4432-9965-4d72542052c7"), 110m, new Guid("c462d47f-5898-4a70-a3fc-1369243f484a"), new DateTime(2022, 4, 14, 0, 6, 36, 0, DateTimeKind.Unspecified), 30m, null, new DateTime(2022, 4, 14, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("203e79de-9c13-43ad-94ee-dd0b1fc09ccf"), 130m, new Guid("7ca23889-1b4d-4edf-baa3-ef0a3de6ffd3"), new DateTime(2022, 4, 14, 0, 6, 36, 0, DateTimeKind.Unspecified), 35m, null, new DateTime(2022, 4, 14, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("234189b0-57eb-4c9e-9bb5-4c6fbe235f3d"), 90m, new Guid("b675bc74-b39d-4f7e-8dbd-39d75a5d0027"), new DateTime(2022, 4, 14, 0, 6, 36, 0, DateTimeKind.Unspecified), 30m, null, new DateTime(2022, 4, 14, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("24c95272-9a9f-44d3-aeba-f92b122f11c1"), 80m, new Guid("03c45c43-aee5-4c63-ad08-4b14ea96aa1a"), new DateTime(2022, 4, 14, 0, 6, 36, 0, DateTimeKind.Unspecified), 30m, null, new DateTime(2022, 4, 14, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("25fa8722-f758-409f-9550-c180e78db543"), 120m, new Guid("455d5fe2-0e7d-49f7-9f6a-af55c5ca80e0"), new DateTime(2022, 4, 14, 0, 6, 36, 0, DateTimeKind.Unspecified), 35m, null, new DateTime(2022, 4, 14, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("26af20f4-2e7c-47b2-9cbd-b3fb7bf67808"), 90m, new Guid("4c2e3ac5-fb8d-40db-9018-76f0cf964ada"), new DateTime(2022, 4, 14, 0, 6, 36, 0, DateTimeKind.Unspecified), 30m, null, new DateTime(2022, 4, 14, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("26f487fd-6d50-4ec1-8691-6efbdaa101d8"), 80m, new Guid("e86864bf-4cee-4076-b074-7511661eec00"), new DateTime(2022, 4, 14, 0, 6, 36, 0, DateTimeKind.Unspecified), 30m, null, new DateTime(2022, 4, 14, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("287cad82-fb2b-4e80-a504-8589e28a4246"), 17000m, new Guid("b94a951d-ad48-46d8-a520-f8f19a09d601"), new DateTime(2022, 4, 14, 0, 6, 36, 0, DateTimeKind.Unspecified), 5500m, null, new DateTime(2022, 4, 14, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("28fb7fa2-9a2c-409f-8325-2f6d8faf443c"), 70m, new Guid("a200c90f-c108-4cf3-9954-2c28f944f3e8"), new DateTime(2022, 4, 14, 0, 6, 36, 0, DateTimeKind.Unspecified), 30m, null, new DateTime(2022, 4, 14, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("2956f699-1b25-4b0a-b288-54d1f40afffc"), 130m, new Guid("221db3f7-c987-416e-8b79-7c950be80e0f"), new DateTime(2022, 4, 14, 0, 6, 36, 0, DateTimeKind.Unspecified), 35m, null, new DateTime(2022, 4, 14, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("2b32c1d2-c061-4167-a444-9673bb994d6f"), 130m, new Guid("06181fb6-24c0-48cf-984d-aa5aca1ca910"), new DateTime(2022, 4, 14, 0, 6, 36, 0, DateTimeKind.Unspecified), 35m, null, new DateTime(2022, 4, 14, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("2b69e547-f1a7-4198-b8bf-2b0c0b26beb0"), 130m, new Guid("7f637c97-8bf5-47f1-90bb-9cb0594a024b"), new DateTime(2022, 4, 14, 0, 6, 36, 0, DateTimeKind.Unspecified), 35m, null, new DateTime(2022, 4, 14, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("3176c920-5108-47e4-a4f6-560779f84d1d"), 130m, new Guid("229a5dc2-f61c-402d-8e09-1ba665fa3cc2"), new DateTime(2022, 4, 14, 0, 6, 36, 0, DateTimeKind.Unspecified), 35m, null, new DateTime(2022, 4, 14, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("37157d6c-8fbb-4859-81e3-46833714b159"), 130m, new Guid("a1332120-93d9-41af-b79d-c8fe50975c98"), new DateTime(2022, 4, 14, 0, 6, 36, 0, DateTimeKind.Unspecified), 35m, null, new DateTime(2022, 4, 14, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("39b3c2a6-b477-48b7-8c54-8cf652407565"), 100m, new Guid("78954108-64a9-466a-94ee-d0ddc0221369"), new DateTime(2022, 4, 14, 0, 6, 36, 0, DateTimeKind.Unspecified), 30m, null, new DateTime(2022, 4, 14, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("3ba01c36-9322-4070-b6f8-5f9b91406f1d"), 90m, new Guid("9724de5e-0262-422e-bc08-4a95af11470e"), new DateTime(2022, 4, 14, 0, 6, 36, 0, DateTimeKind.Unspecified), 30m, null, new DateTime(2022, 4, 14, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("3cf47216-dd49-4f45-bd03-e7dbb65c8fb1"), 90m, new Guid("8a5d3a6d-0fb3-41d7-917a-6fdc18ddb2ce"), new DateTime(2022, 4, 14, 0, 6, 36, 0, DateTimeKind.Unspecified), 30m, null, new DateTime(2022, 4, 14, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("3e03dd9d-0957-4e49-8311-04b2c0869a83"), 90m, new Guid("c2401310-bddd-4f93-a0e6-407f6c82355d"), new DateTime(2022, 4, 14, 0, 6, 36, 0, DateTimeKind.Unspecified), 30m, null, new DateTime(2022, 4, 14, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("3f4529b7-4b92-49ea-9328-76a9af19efde"), 145m, new Guid("a92cb692-f1a3-4076-bc31-60f45d5284ea"), new DateTime(2022, 4, 14, 0, 6, 36, 0, DateTimeKind.Unspecified), 35m, null, new DateTime(2022, 4, 14, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("3ff570a0-4455-4a26-b8a3-4ed1cfcedfe7"), 80m, new Guid("33e65511-5f76-4029-8905-e190368dcb3e"), new DateTime(2022, 4, 14, 0, 6, 36, 0, DateTimeKind.Unspecified), 30m, null, new DateTime(2022, 4, 14, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("40cc3767-e240-41e0-a0e3-5b0490a83021"), 130m, new Guid("fde06b7f-61ad-455a-9158-e8ae5184c00e"), new DateTime(2022, 4, 14, 0, 6, 36, 0, DateTimeKind.Unspecified), 35m, null, new DateTime(2022, 4, 14, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("44a4067c-6bb2-4c5b-8aba-a63e61c0d125"), 90m, new Guid("d9652f33-298c-4918-9479-c4c07c3ad69d"), new DateTime(2022, 4, 14, 0, 6, 36, 0, DateTimeKind.Unspecified), 30m, null, new DateTime(2022, 4, 14, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("45cfd07a-71df-4ee8-86c2-ea642f04c652"), 90m, new Guid("bdf2e51e-91ba-4cbf-b4b7-97362091cd2e"), new DateTime(2022, 4, 14, 0, 6, 36, 0, DateTimeKind.Unspecified), 30m, null, new DateTime(2022, 4, 14, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("480d57b0-e598-4b22-b722-fefea296b398"), 100m, new Guid("c8cde5e2-df86-49e5-a4cb-cdf5df5ac497"), new DateTime(2022, 4, 14, 0, 6, 36, 0, DateTimeKind.Unspecified), 30m, null, new DateTime(2022, 4, 14, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("494708dd-dfae-4cc4-a9de-bebd494b5abb"), 80m, new Guid("a61829ad-3dd9-4e50-b3e6-67a6faac5772"), new DateTime(2022, 4, 14, 0, 6, 36, 0, DateTimeKind.Unspecified), 30m, null, new DateTime(2022, 4, 14, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("4c6b56c5-af25-499f-8bac-8d63bddf957d"), 85m, new Guid("bbc5e980-61bd-4b1a-94a7-09694bf8af3f"), new DateTime(2022, 4, 14, 0, 6, 36, 0, DateTimeKind.Unspecified), 30m, null, new DateTime(2022, 4, 14, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("53739a4c-b9ce-4926-839a-03c42898ce29"), 100m, new Guid("e89a3e4a-7148-404c-ba88-981ae1926c1c"), new DateTime(2022, 4, 14, 0, 6, 36, 0, DateTimeKind.Unspecified), 30m, null, new DateTime(2022, 4, 14, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("544af03d-b2b0-4b82-b219-7548ef287925"), 130m, new Guid("0e143ebe-15b4-4e0d-ae42-85753593c66e"), new DateTime(2022, 4, 14, 0, 6, 36, 0, DateTimeKind.Unspecified), 35m, null, new DateTime(2022, 4, 14, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("57d51291-fbac-4cc4-ae42-69876230fc55"), 130m, new Guid("fbab591b-806e-4cff-9965-d70cd1dc2790"), new DateTime(2022, 4, 14, 0, 6, 36, 0, DateTimeKind.Unspecified), 35m, null, new DateTime(2022, 4, 14, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("5ad323f7-d0dd-4ea4-966b-6bb59f982716"), 100m, new Guid("e4ef12c2-daf0-42f4-aa1c-0c769f17742a"), new DateTime(2022, 4, 14, 0, 6, 36, 0, DateTimeKind.Unspecified), 30m, null, new DateTime(2022, 4, 14, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("5b649ca1-e077-410f-a72c-3045a56b734e"), 130m, new Guid("a428da7b-e12c-4d58-8b5f-17dde46b7dd5"), new DateTime(2022, 4, 14, 0, 6, 36, 0, DateTimeKind.Unspecified), 35m, null, new DateTime(2022, 4, 14, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("5b8dcc45-231c-4567-bce4-ffe2c8d8f5c5"), 100m, new Guid("0f66e89e-b527-4277-8184-e92ef28d9c75"), new DateTime(2022, 4, 14, 0, 6, 36, 0, DateTimeKind.Unspecified), 30m, null, new DateTime(2022, 4, 14, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("5e610ef9-c837-4d03-8c0b-1f302893a6a2"), 100m, new Guid("84b90426-77d3-4d9b-b686-bdea7fc40c1e"), new DateTime(2022, 4, 14, 0, 6, 36, 0, DateTimeKind.Unspecified), 35m, null, new DateTime(2022, 4, 14, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("6208e0b5-43de-4cf4-916c-0f40865dd053"), 120m, new Guid("97de9535-853e-4e5b-ad7e-b3225b189a87"), new DateTime(2022, 4, 14, 0, 6, 36, 0, DateTimeKind.Unspecified), 35m, null, new DateTime(2022, 4, 14, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("66cf8e0d-940c-4780-a5e5-1a9e675640a7"), 130m, new Guid("07c76c47-bfb7-420f-9768-7ea33444d78e"), new DateTime(2022, 4, 14, 0, 6, 36, 0, DateTimeKind.Unspecified), 35m, null, new DateTime(2022, 4, 14, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("680876bc-012e-4890-af62-2a0d37119c6b"), 90m, new Guid("1dd1803b-2f31-4705-a590-67d14b7de76a"), new DateTime(2022, 4, 14, 0, 6, 36, 0, DateTimeKind.Unspecified), 30m, null, new DateTime(2022, 4, 14, 0, 0, 0, 0, DateTimeKind.Local), null }
                });

            migrationBuilder.InsertData(
                table: "Allowances",
                columns: new[] { "Id", "AccomodationAllowance", "CountryId", "CreatedDate", "DailyAllowance", "UpdatedDate", "ValidFrom", "ValidTo" },
                values: new object[,]
                {
                    { new Guid("684df637-ff2d-4d42-b3e3-ffb91000f043"), 130m, new Guid("5b74297f-3c5b-45e3-91db-3af4b747b27d"), new DateTime(2022, 4, 14, 0, 6, 36, 0, DateTimeKind.Unspecified), 35m, null, new DateTime(2022, 4, 14, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("6a66ac75-d12c-4a0d-9ad9-9405c1bdfeee"), 120m, new Guid("d1943d0e-7ff8-419b-83b4-5ac8f7f86ae9"), new DateTime(2022, 4, 14, 0, 6, 36, 0, DateTimeKind.Unspecified), 35m, null, new DateTime(2022, 4, 14, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("708ffb17-eee7-42dc-80c7-8182b941ab48"), 100m, new Guid("790e0bee-bf86-44d5-b378-531d6ee73bcd"), new DateTime(2022, 4, 14, 0, 6, 36, 0, DateTimeKind.Unspecified), 30m, null, new DateTime(2022, 4, 14, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("76e3e38b-78c0-4ad0-b11a-bc34f6267e06"), 110m, new Guid("56afd974-d086-4b2e-9a4f-edb6231b20d7"), new DateTime(2022, 4, 14, 0, 6, 36, 0, DateTimeKind.Unspecified), 30m, null, new DateTime(2022, 4, 14, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("7e74717c-1e11-4854-acda-75c93f29cbe9"), 90m, new Guid("dc4cbbfd-a927-4e8f-804c-16472a80a5fd"), new DateTime(2022, 4, 14, 0, 6, 36, 0, DateTimeKind.Unspecified), 30m, null, new DateTime(2022, 4, 14, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("7e8e386e-bc59-4553-b8a2-16846c06820b"), 100m, new Guid("ca7deaf6-e998-4898-96e1-69d378662c52"), new DateTime(2022, 4, 14, 0, 6, 36, 0, DateTimeKind.Unspecified), 30m, null, new DateTime(2022, 4, 14, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("7ffed670-c97c-4dc2-8bac-a7e0970b92d3"), 130m, new Guid("bca8ac88-9b46-4957-91a5-91c14c6efda0"), new DateTime(2022, 4, 14, 0, 6, 36, 0, DateTimeKind.Unspecified), 35m, null, new DateTime(2022, 4, 14, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("8011cd40-c644-42d3-87ad-72fb0c84c593"), 100m, new Guid("13c251b0-73ff-4265-a4d6-1e5313bc63e6"), new DateTime(2022, 4, 14, 0, 6, 36, 0, DateTimeKind.Unspecified), 30m, null, new DateTime(2022, 4, 14, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("80e693fb-4906-449c-9c60-859fac4d1875"), 80m, new Guid("72a1fadc-17be-48e9-b83e-4a313d153b1b"), new DateTime(2022, 4, 14, 0, 6, 36, 0, DateTimeKind.Unspecified), 30m, null, new DateTime(2022, 4, 14, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("820c6d35-5125-4f38-93b6-1fa52eaa311e"), 150m, new Guid("e7e556b2-489c-457d-94c4-15271d8cb1e2"), new DateTime(2022, 4, 14, 0, 6, 36, 0, DateTimeKind.Unspecified), 60m, null, new DateTime(2022, 4, 14, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("86c28801-d739-4a6b-b9c7-e70a72ce7b64"), 110m, new Guid("83f967d6-fd80-4559-b17f-51cf3e11b1eb"), new DateTime(2022, 4, 14, 0, 6, 36, 0, DateTimeKind.Unspecified), 30m, null, new DateTime(2022, 4, 14, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("87c3c609-66a2-4f8c-a388-20a826c474b8"), 90m, new Guid("e28f5662-29a3-4e15-ba0b-62a3ba80ca1c"), new DateTime(2022, 4, 14, 0, 6, 36, 0, DateTimeKind.Unspecified), 30m, null, new DateTime(2022, 4, 14, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("87f718c4-be20-4c5e-a509-555460e6afe3"), 130m, new Guid("b33a2ee4-29f8-4d22-b392-c7a83e97728b"), new DateTime(2022, 4, 14, 0, 6, 36, 0, DateTimeKind.Unspecified), 35m, null, new DateTime(2022, 4, 14, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("895c7704-1b24-4d3a-9283-c25699095b9b"), 130m, new Guid("fc4b3470-46a5-45f8-b925-be3d73165c48"), new DateTime(2022, 4, 14, 0, 6, 36, 0, DateTimeKind.Unspecified), 35m, null, new DateTime(2022, 4, 14, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("89c67f45-861e-4c66-8025-df09da730244"), 130m, new Guid("5bda40a0-fbcb-4572-a6f3-4867f91c6008"), new DateTime(2022, 4, 14, 0, 6, 36, 0, DateTimeKind.Unspecified), 35m, null, new DateTime(2022, 4, 14, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("8b7e118a-1b0c-4cf5-bffb-b23ed17488ec"), 80m, new Guid("5e212ca0-5b40-4599-a720-08250aab973b"), new DateTime(2022, 4, 14, 0, 6, 36, 0, DateTimeKind.Unspecified), 30m, null, new DateTime(2022, 4, 14, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("8d84b444-4d15-47ba-bd3b-b7a5ddc38364"), 100m, new Guid("42a89973-feb3-4bdc-aa4e-5581bdbe44e2"), new DateTime(2022, 4, 14, 0, 6, 36, 0, DateTimeKind.Unspecified), 30m, null, new DateTime(2022, 4, 14, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("8e8b5de3-a232-44f2-aac5-1616b17a8259"), 130m, new Guid("f27570da-8d09-44fa-8ff0-148deafe79f3"), new DateTime(2022, 4, 14, 0, 6, 36, 0, DateTimeKind.Unspecified), 35m, null, new DateTime(2022, 4, 14, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("8f3ebbfd-e7a9-42d4-9cc9-970906d27698"), 100m, new Guid("b1aa35b5-69d8-42f0-be80-b5442aef01c1"), new DateTime(2022, 4, 14, 0, 6, 36, 0, DateTimeKind.Unspecified), 30m, null, new DateTime(2022, 4, 14, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("91e5fb1f-71e8-45e1-95a0-f65fc5d081c1"), 80m, new Guid("65343279-c694-467a-99b6-98f0e82249ac"), new DateTime(2022, 4, 14, 0, 6, 36, 0, DateTimeKind.Unspecified), 30m, null, new DateTime(2022, 4, 14, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("936965f7-cdfb-4ad4-b3d5-4407528df098"), 80m, new Guid("f2a6edb4-d393-4931-af92-b486472bfd47"), new DateTime(2022, 4, 14, 0, 6, 36, 0, DateTimeKind.Unspecified), 30m, null, new DateTime(2022, 4, 14, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("9499bb78-8d98-4f23-8224-748f94ccc06a"), 80m, new Guid("eafd2dcd-e617-456d-b2d7-5d23a1913762"), new DateTime(2022, 4, 14, 0, 6, 36, 0, DateTimeKind.Unspecified), 30m, null, new DateTime(2022, 4, 14, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("96080377-b564-457c-b3cc-f63fc604f2e6"), 100m, new Guid("b84f5d11-3191-4e01-b057-8b87c7ef174e"), new DateTime(2022, 4, 14, 0, 6, 36, 0, DateTimeKind.Unspecified), 30m, null, new DateTime(2022, 4, 14, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("986134e3-e5ed-4bc1-857d-a0be18173752"), 100m, new Guid("456254ed-6015-4be0-8466-b824a473c649"), new DateTime(2022, 4, 14, 0, 6, 36, 0, DateTimeKind.Unspecified), 30m, null, new DateTime(2022, 4, 14, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("9b4aa11e-88c2-4201-93cd-3ae792756bf6"), 100m, new Guid("464005f0-fc2f-432b-9d78-1ae20c2229ec"), new DateTime(2022, 4, 14, 0, 6, 36, 0, DateTimeKind.Unspecified), 35m, null, new DateTime(2022, 4, 14, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("9bee9386-7ac6-4fe2-b02f-8760721d1221"), 100m, new Guid("10378996-da5b-4b29-b32a-53d33d0567f4"), new DateTime(2022, 4, 14, 0, 6, 36, 0, DateTimeKind.Unspecified), 35m, null, new DateTime(2022, 4, 14, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("a4a644ee-1057-43f9-b140-94d821566e79"), 90m, new Guid("a542f75e-f1cb-4328-b69e-4043aa5b3087"), new DateTime(2022, 4, 14, 0, 6, 36, 0, DateTimeKind.Unspecified), 30m, null, new DateTime(2022, 4, 14, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("a9814577-a343-470e-bf95-634ee749fbb3"), 130m, new Guid("a2edf1c6-9a8d-4133-84f6-613fe94a542e"), new DateTime(2022, 4, 14, 0, 6, 36, 0, DateTimeKind.Unspecified), 35m, null, new DateTime(2022, 4, 14, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("ab00abeb-7929-47b8-a169-9f2a91669645"), 130m, new Guid("db5b3ce1-b970-4c16-9fab-09d529b1cac0"), new DateTime(2022, 4, 14, 0, 6, 36, 0, DateTimeKind.Unspecified), 35m, null, new DateTime(2022, 4, 14, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("ab069eb2-e225-4f74-bcfa-7a743ba92a7e"), 100m, new Guid("0372be54-44b3-46f7-90ff-447715b8fdf8"), new DateTime(2022, 4, 14, 0, 6, 36, 0, DateTimeKind.Unspecified), 30m, null, new DateTime(2022, 4, 14, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("ac006b94-7208-4493-84e7-c3a3795b5da7"), 130m, new Guid("a166bb7a-13c0-40bc-942c-fdcf67215b92"), new DateTime(2022, 4, 14, 0, 6, 36, 0, DateTimeKind.Unspecified), 35m, null, new DateTime(2022, 4, 14, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("ae54c0ca-9b0d-4cf8-bad6-b20870aa6df9"), 150m, new Guid("65f5f0bb-149d-4230-aa48-32b497a28a6f"), new DateTime(2022, 4, 14, 0, 6, 36, 0, DateTimeKind.Unspecified), 35m, null, new DateTime(2022, 4, 14, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("b265318a-b106-4542-846b-7ddd1b7ef840"), 130m, new Guid("ce8940bb-877e-4379-bcc4-ce6c8863f991"), new DateTime(2022, 4, 14, 0, 6, 36, 0, DateTimeKind.Unspecified), 35m, null, new DateTime(2022, 4, 14, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("b3724691-558e-482d-961a-d79acf84d751"), 120m, new Guid("38af8e8d-457d-4435-ac5e-2b93a79295bd"), new DateTime(2022, 4, 14, 0, 6, 36, 0, DateTimeKind.Unspecified), 30m, null, new DateTime(2022, 4, 14, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("b44a5de9-c930-4620-86d5-3ff0981853cc"), 150m, new Guid("551ca0f0-fd9f-4ce7-be8a-dc4c5185ee0e"), new DateTime(2022, 4, 14, 0, 6, 36, 0, DateTimeKind.Unspecified), 35m, null, new DateTime(2022, 4, 14, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("b4770536-d93a-4137-b64a-cdc9920dcfb1"), 130m, new Guid("17e20300-feef-4828-8be6-0cf1ec82c86a"), new DateTime(2022, 4, 14, 0, 6, 36, 0, DateTimeKind.Unspecified), 30m, null, new DateTime(2022, 4, 14, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("b9af640f-e89a-4eb1-8fb4-9c09f3cda91e"), 110m, new Guid("ffb0388c-4e72-4c48-b0cb-dd8fb947bf5e"), new DateTime(2022, 4, 14, 0, 6, 36, 0, DateTimeKind.Unspecified), 30m, null, new DateTime(2022, 4, 14, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("be161793-a20a-495b-9331-38bfe5bc6c61"), 100m, new Guid("78d2606a-ceed-4a1d-94d7-909c2f74e72f"), new DateTime(2022, 4, 14, 0, 6, 36, 0, DateTimeKind.Unspecified), 30m, null, new DateTime(2022, 4, 14, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("be780da4-1995-4e22-b41b-8c97d693d299"), 130m, new Guid("95d91f47-c373-4f12-ba02-4444984fbaac"), new DateTime(2022, 4, 14, 0, 6, 36, 0, DateTimeKind.Unspecified), 35m, null, new DateTime(2022, 4, 14, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("c3eac574-4706-4c58-8f30-ee65c879b417"), 90m, new Guid("bd633ce6-a327-45dd-9d76-89338e7c3bff"), new DateTime(2022, 4, 14, 0, 6, 36, 0, DateTimeKind.Unspecified), 30m, null, new DateTime(2022, 4, 14, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("c61dfde4-fb4f-4b6f-9221-179d5e320ae8"), 130m, new Guid("8b5a785a-9a15-443e-bb3f-b81296c9ef7a"), new DateTime(2022, 4, 14, 0, 6, 36, 0, DateTimeKind.Unspecified), 35m, null, new DateTime(2022, 4, 14, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("cb580197-dc46-4fcd-ba26-e34e50bc6ef3"), 80m, new Guid("8db10b59-6e5e-4987-bbf9-065b02a6b647"), new DateTime(2022, 4, 14, 0, 6, 36, 0, DateTimeKind.Unspecified), 30m, null, new DateTime(2022, 4, 14, 0, 0, 0, 0, DateTimeKind.Local), null }
                });

            migrationBuilder.InsertData(
                table: "Allowances",
                columns: new[] { "Id", "AccomodationAllowance", "CountryId", "CreatedDate", "DailyAllowance", "UpdatedDate", "ValidFrom", "ValidTo" },
                values: new object[,]
                {
                    { new Guid("ce48bafb-f95f-450a-896d-955494fe3500"), 80m, new Guid("51142fea-f061-43c8-ba9a-c129242896d0"), new DateTime(2022, 4, 14, 0, 6, 36, 0, DateTimeKind.Unspecified), 30m, null, new DateTime(2022, 4, 14, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("cf61bcce-757a-439a-8b43-e5d225a4e6a0"), 130m, new Guid("dbf670e4-84bb-4ffb-8383-eeaa14640f15"), new DateTime(2022, 4, 14, 0, 6, 36, 0, DateTimeKind.Unspecified), 35m, null, new DateTime(2022, 4, 14, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("cf9b302e-c571-4b48-929c-4e68ac2b0995"), 130m, new Guid("1dd0b8e8-4fb2-4824-bdf9-5625e58e2703"), new DateTime(2022, 4, 14, 0, 6, 36, 0, DateTimeKind.Unspecified), 35m, null, new DateTime(2022, 4, 14, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("d1375a0d-e3c7-44ca-8d2b-1b30726dd61d"), 80m, new Guid("0af38e38-3eb7-4150-9d2a-f1067c1b6002"), new DateTime(2022, 4, 14, 0, 6, 36, 0, DateTimeKind.Unspecified), 30m, null, new DateTime(2022, 4, 14, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("d46a95f7-1a78-4ec1-81af-7463701c90c7"), 130m, new Guid("2a33b3f4-9165-4711-ac86-9fc514a231bc"), new DateTime(2022, 4, 14, 0, 6, 36, 0, DateTimeKind.Unspecified), 35m, null, new DateTime(2022, 4, 14, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("d750aded-fabe-4e76-b6cd-02b1b2d0683c"), 80m, new Guid("7d5eeea6-17ac-44a6-9448-b842e49b2e23"), new DateTime(2022, 4, 14, 0, 6, 36, 0, DateTimeKind.Unspecified), 30m, null, new DateTime(2022, 4, 14, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("d98c19f9-cbf5-48f3-a88d-24d44a0bf1e3"), 80m, new Guid("83ebae76-a245-48be-800d-a20a8c0e7d40"), new DateTime(2022, 4, 14, 0, 6, 36, 0, DateTimeKind.Unspecified), 30m, null, new DateTime(2022, 4, 14, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("da13c210-dcdd-4c45-aa68-8a43ad1cf747"), 100m, new Guid("071640a2-40c2-4679-9e51-3ac40189554c"), new DateTime(2022, 4, 14, 0, 6, 36, 0, DateTimeKind.Unspecified), 30m, null, new DateTime(2022, 4, 14, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("e05f5f65-1dcd-4601-be99-8a36fbff27d1"), 80m, new Guid("a90a7269-2228-4d1f-bb4c-a0caddbf8e27"), new DateTime(2022, 4, 14, 0, 6, 36, 0, DateTimeKind.Unspecified), 30m, null, new DateTime(2022, 4, 14, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("e491f84d-fe0e-4cc3-94f2-0e62aebb73b0"), 100m, new Guid("87b3b1e8-49a5-4398-9df8-82b50040a7a8"), new DateTime(2022, 4, 14, 0, 6, 36, 0, DateTimeKind.Unspecified), 30m, null, new DateTime(2022, 4, 14, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("e4a917cf-34d1-4645-a492-cad76bf1ef5f"), 130m, new Guid("982cca6b-f18d-4c1d-aa9e-49f8bf0156a3"), new DateTime(2022, 4, 14, 0, 6, 36, 0, DateTimeKind.Unspecified), 35m, null, new DateTime(2022, 4, 14, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("e77efeca-7d9b-4fda-8153-b6f4989be21b"), 100m, new Guid("0e7e31cf-7a82-4454-9a33-1d0ea36339b1"), new DateTime(2022, 4, 14, 0, 6, 36, 0, DateTimeKind.Unspecified), 35m, null, new DateTime(2022, 4, 14, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("e81cfdaf-c24c-4bf4-b6a0-826a9414de2a"), 130m, new Guid("b68c3a50-f04d-4698-8e6b-6064a7c152cf"), new DateTime(2022, 4, 14, 0, 6, 36, 0, DateTimeKind.Unspecified), 35m, null, new DateTime(2022, 4, 14, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("eb00e5ca-dd6c-483b-9884-3ccc58799b1b"), 100m, new Guid("2fd39f62-6c9d-4be1-bfa9-f031aa41732d"), new DateTime(2022, 4, 14, 0, 6, 36, 0, DateTimeKind.Unspecified), 30m, null, new DateTime(2022, 4, 14, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("eeae20a7-1ab2-4eb5-9a81-8e25387f3ac1"), 90m, new Guid("c6190450-9d62-4163-9470-5b7b2ebb71e6"), new DateTime(2022, 4, 14, 0, 6, 36, 0, DateTimeKind.Unspecified), 30m, null, new DateTime(2022, 4, 14, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("ef61e123-5865-47ba-8661-ea888596e948"), 80m, new Guid("ae8b8faf-357b-4213-b286-9173a020b464"), new DateTime(2022, 4, 14, 0, 6, 36, 0, DateTimeKind.Unspecified), 30m, null, new DateTime(2022, 4, 14, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("fa2afa83-c942-45d7-a746-43dc274a07b1"), 100m, new Guid("d1c6118c-eb87-482e-a760-3c23d95a255e"), new DateTime(2022, 4, 14, 0, 6, 36, 0, DateTimeKind.Unspecified), 35m, null, new DateTime(2022, 4, 14, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("fb7d5db4-4457-4f86-9dc8-bec9744b4035"), 130m, new Guid("e912a5c0-bb57-411c-be58-cc02437e0067"), new DateTime(2022, 4, 14, 0, 6, 36, 0, DateTimeKind.Unspecified), 35m, null, new DateTime(2022, 4, 14, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("ff0a154b-ba5f-4884-b509-e707ff1f7eea"), 130m, new Guid("57b3061c-fab4-4901-bdf6-ed8e89461c21"), new DateTime(2022, 4, 14, 0, 6, 36, 0, DateTimeKind.Unspecified), 35m, null, new DateTime(2022, 4, 14, 0, 0, 0, 0, DateTimeKind.Local), null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("02eb4299-8d3d-4917-9d83-edb1a80b87df"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("08c59096-f953-45dc-b29f-874838ed719d"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("0d50fd6f-6bf3-40df-8b5f-7c87c6e87710"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("122867dd-7faf-4d66-a714-a9fc6a2d2d29"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("14681415-d9b2-49eb-97da-7b8c1397ae03"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("17ca3a62-a59a-4f52-a345-bc0808a8ab17"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("1c6ddc74-9e60-4432-9965-4d72542052c7"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("203e79de-9c13-43ad-94ee-dd0b1fc09ccf"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("234189b0-57eb-4c9e-9bb5-4c6fbe235f3d"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("24c95272-9a9f-44d3-aeba-f92b122f11c1"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("25fa8722-f758-409f-9550-c180e78db543"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("26af20f4-2e7c-47b2-9cbd-b3fb7bf67808"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("26f487fd-6d50-4ec1-8691-6efbdaa101d8"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("287cad82-fb2b-4e80-a504-8589e28a4246"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("28fb7fa2-9a2c-409f-8325-2f6d8faf443c"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("2956f699-1b25-4b0a-b288-54d1f40afffc"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("2b32c1d2-c061-4167-a444-9673bb994d6f"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("2b69e547-f1a7-4198-b8bf-2b0c0b26beb0"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("3176c920-5108-47e4-a4f6-560779f84d1d"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("37157d6c-8fbb-4859-81e3-46833714b159"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("39b3c2a6-b477-48b7-8c54-8cf652407565"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("3ba01c36-9322-4070-b6f8-5f9b91406f1d"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("3cf47216-dd49-4f45-bd03-e7dbb65c8fb1"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("3e03dd9d-0957-4e49-8311-04b2c0869a83"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("3f4529b7-4b92-49ea-9328-76a9af19efde"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("3ff570a0-4455-4a26-b8a3-4ed1cfcedfe7"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("40cc3767-e240-41e0-a0e3-5b0490a83021"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("44a4067c-6bb2-4c5b-8aba-a63e61c0d125"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("45cfd07a-71df-4ee8-86c2-ea642f04c652"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("480d57b0-e598-4b22-b722-fefea296b398"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("494708dd-dfae-4cc4-a9de-bebd494b5abb"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("4c6b56c5-af25-499f-8bac-8d63bddf957d"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("53739a4c-b9ce-4926-839a-03c42898ce29"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("544af03d-b2b0-4b82-b219-7548ef287925"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("57d51291-fbac-4cc4-ae42-69876230fc55"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("5ad323f7-d0dd-4ea4-966b-6bb59f982716"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("5b649ca1-e077-410f-a72c-3045a56b734e"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("5b8dcc45-231c-4567-bce4-ffe2c8d8f5c5"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("5e610ef9-c837-4d03-8c0b-1f302893a6a2"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("6208e0b5-43de-4cf4-916c-0f40865dd053"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("66cf8e0d-940c-4780-a5e5-1a9e675640a7"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("680876bc-012e-4890-af62-2a0d37119c6b"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("684df637-ff2d-4d42-b3e3-ffb91000f043"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("6a66ac75-d12c-4a0d-9ad9-9405c1bdfeee"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("708ffb17-eee7-42dc-80c7-8182b941ab48"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("76e3e38b-78c0-4ad0-b11a-bc34f6267e06"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("7e74717c-1e11-4854-acda-75c93f29cbe9"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("7e8e386e-bc59-4553-b8a2-16846c06820b"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("7ffed670-c97c-4dc2-8bac-a7e0970b92d3"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("8011cd40-c644-42d3-87ad-72fb0c84c593"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("80e693fb-4906-449c-9c60-859fac4d1875"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("820c6d35-5125-4f38-93b6-1fa52eaa311e"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("86c28801-d739-4a6b-b9c7-e70a72ce7b64"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("87c3c609-66a2-4f8c-a388-20a826c474b8"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("87f718c4-be20-4c5e-a509-555460e6afe3"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("895c7704-1b24-4d3a-9283-c25699095b9b"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("89c67f45-861e-4c66-8025-df09da730244"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("8b7e118a-1b0c-4cf5-bffb-b23ed17488ec"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("8d84b444-4d15-47ba-bd3b-b7a5ddc38364"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("8e8b5de3-a232-44f2-aac5-1616b17a8259"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("8f3ebbfd-e7a9-42d4-9cc9-970906d27698"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("91e5fb1f-71e8-45e1-95a0-f65fc5d081c1"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("936965f7-cdfb-4ad4-b3d5-4407528df098"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("9499bb78-8d98-4f23-8224-748f94ccc06a"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("96080377-b564-457c-b3cc-f63fc604f2e6"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("986134e3-e5ed-4bc1-857d-a0be18173752"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("9b4aa11e-88c2-4201-93cd-3ae792756bf6"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("9bee9386-7ac6-4fe2-b02f-8760721d1221"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("a4a644ee-1057-43f9-b140-94d821566e79"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("a9814577-a343-470e-bf95-634ee749fbb3"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("ab00abeb-7929-47b8-a169-9f2a91669645"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("ab069eb2-e225-4f74-bcfa-7a743ba92a7e"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("ac006b94-7208-4493-84e7-c3a3795b5da7"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("ae54c0ca-9b0d-4cf8-bad6-b20870aa6df9"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("b265318a-b106-4542-846b-7ddd1b7ef840"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("b3724691-558e-482d-961a-d79acf84d751"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("b44a5de9-c930-4620-86d5-3ff0981853cc"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("b4770536-d93a-4137-b64a-cdc9920dcfb1"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("b9af640f-e89a-4eb1-8fb4-9c09f3cda91e"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("be161793-a20a-495b-9331-38bfe5bc6c61"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("be780da4-1995-4e22-b41b-8c97d693d299"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("c3eac574-4706-4c58-8f30-ee65c879b417"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("c61dfde4-fb4f-4b6f-9221-179d5e320ae8"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("cb580197-dc46-4fcd-ba26-e34e50bc6ef3"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("ce48bafb-f95f-450a-896d-955494fe3500"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("cf61bcce-757a-439a-8b43-e5d225a4e6a0"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("cf9b302e-c571-4b48-929c-4e68ac2b0995"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("d1375a0d-e3c7-44ca-8d2b-1b30726dd61d"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("d46a95f7-1a78-4ec1-81af-7463701c90c7"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("d750aded-fabe-4e76-b6cd-02b1b2d0683c"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("d98c19f9-cbf5-48f3-a88d-24d44a0bf1e3"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("da13c210-dcdd-4c45-aa68-8a43ad1cf747"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("e05f5f65-1dcd-4601-be99-8a36fbff27d1"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("e491f84d-fe0e-4cc3-94f2-0e62aebb73b0"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("e4a917cf-34d1-4645-a492-cad76bf1ef5f"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("e77efeca-7d9b-4fda-8153-b6f4989be21b"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("e81cfdaf-c24c-4bf4-b6a0-826a9414de2a"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("eb00e5ca-dd6c-483b-9884-3ccc58799b1b"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("eeae20a7-1ab2-4eb5-9a81-8e25387f3ac1"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("ef61e123-5865-47ba-8661-ea888596e948"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("fa2afa83-c942-45d7-a746-43dc274a07b1"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("fb7d5db4-4457-4f86-9dc8-bec9744b4035"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("ff0a154b-ba5f-4884-b509-e707ff1f7eea"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("010609fc-eda6-4eb7-a184-fe19752b4b7b"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("0372be54-44b3-46f7-90ff-447715b8fdf8"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("03c45c43-aee5-4c63-ad08-4b14ea96aa1a"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("06181fb6-24c0-48cf-984d-aa5aca1ca910"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("06ff9de6-a658-40bc-9d6b-8eb415952caa"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("071640a2-40c2-4679-9e51-3ac40189554c"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("07c76c47-bfb7-420f-9768-7ea33444d78e"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("0af38e38-3eb7-4150-9d2a-f1067c1b6002"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("0db8ff0a-f208-4e5d-9857-1e074184706f"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("0e143ebe-15b4-4e0d-ae42-85753593c66e"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("0e7e31cf-7a82-4454-9a33-1d0ea36339b1"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("0f66e89e-b527-4277-8184-e92ef28d9c75"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("10378996-da5b-4b29-b32a-53d33d0567f4"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("13c251b0-73ff-4265-a4d6-1e5313bc63e6"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("17e20300-feef-4828-8be6-0cf1ec82c86a"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("1dd0b8e8-4fb2-4824-bdf9-5625e58e2703"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("1dd1803b-2f31-4705-a590-67d14b7de76a"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("221db3f7-c987-416e-8b79-7c950be80e0f"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("229a5dc2-f61c-402d-8e09-1ba665fa3cc2"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("2a33b3f4-9165-4711-ac86-9fc514a231bc"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("2fd39f62-6c9d-4be1-bfa9-f031aa41732d"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("33e65511-5f76-4029-8905-e190368dcb3e"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("38af8e8d-457d-4435-ac5e-2b93a79295bd"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("42a89973-feb3-4bdc-aa4e-5581bdbe44e2"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("455d5fe2-0e7d-49f7-9f6a-af55c5ca80e0"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("456254ed-6015-4be0-8466-b824a473c649"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("464005f0-fc2f-432b-9d78-1ae20c2229ec"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("4c2e3ac5-fb8d-40db-9018-76f0cf964ada"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("51142fea-f061-43c8-ba9a-c129242896d0"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("551ca0f0-fd9f-4ce7-be8a-dc4c5185ee0e"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("56afd974-d086-4b2e-9a4f-edb6231b20d7"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("57b3061c-fab4-4901-bdf6-ed8e89461c21"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("5b74297f-3c5b-45e3-91db-3af4b747b27d"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("5bda40a0-fbcb-4572-a6f3-4867f91c6008"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("5e212ca0-5b40-4599-a720-08250aab973b"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("65343279-c694-467a-99b6-98f0e82249ac"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("65f5f0bb-149d-4230-aa48-32b497a28a6f"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("72a1fadc-17be-48e9-b83e-4a313d153b1b"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("78954108-64a9-466a-94ee-d0ddc0221369"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("78d2606a-ceed-4a1d-94d7-909c2f74e72f"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("790e0bee-bf86-44d5-b378-531d6ee73bcd"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("7ca23889-1b4d-4edf-baa3-ef0a3de6ffd3"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("7d5eeea6-17ac-44a6-9448-b842e49b2e23"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("7f637c97-8bf5-47f1-90bb-9cb0594a024b"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("83ebae76-a245-48be-800d-a20a8c0e7d40"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("83f967d6-fd80-4559-b17f-51cf3e11b1eb"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("84b90426-77d3-4d9b-b686-bdea7fc40c1e"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("87b3b1e8-49a5-4398-9df8-82b50040a7a8"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("8a5d3a6d-0fb3-41d7-917a-6fdc18ddb2ce"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("8b5a785a-9a15-443e-bb3f-b81296c9ef7a"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("8db10b59-6e5e-4987-bbf9-065b02a6b647"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("8e024101-f633-49d6-b995-cfef9ad126a5"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("9436f353-11b2-4a8f-8857-42c798ce66ad"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("95d91f47-c373-4f12-ba02-4444984fbaac"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("9724de5e-0262-422e-bc08-4a95af11470e"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("97de9535-853e-4e5b-ad7e-b3225b189a87"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("982cca6b-f18d-4c1d-aa9e-49f8bf0156a3"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a1332120-93d9-41af-b79d-c8fe50975c98"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a166bb7a-13c0-40bc-942c-fdcf67215b92"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a200c90f-c108-4cf3-9954-2c28f944f3e8"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a2edf1c6-9a8d-4133-84f6-613fe94a542e"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a428da7b-e12c-4d58-8b5f-17dde46b7dd5"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a542f75e-f1cb-4328-b69e-4043aa5b3087"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a61829ad-3dd9-4e50-b3e6-67a6faac5772"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a90a7269-2228-4d1f-bb4c-a0caddbf8e27"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a92cb692-f1a3-4076-bc31-60f45d5284ea"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("ae8b8faf-357b-4213-b286-9173a020b464"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("b1aa35b5-69d8-42f0-be80-b5442aef01c1"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("b33a2ee4-29f8-4d22-b392-c7a83e97728b"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("b675bc74-b39d-4f7e-8dbd-39d75a5d0027"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("b68c3a50-f04d-4698-8e6b-6064a7c152cf"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("b84f5d11-3191-4e01-b057-8b87c7ef174e"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("b94a951d-ad48-46d8-a520-f8f19a09d601"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("bbc5e980-61bd-4b1a-94a7-09694bf8af3f"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("bca8ac88-9b46-4957-91a5-91c14c6efda0"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("bd633ce6-a327-45dd-9d76-89338e7c3bff"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("bdf2e51e-91ba-4cbf-b4b7-97362091cd2e"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("c2401310-bddd-4f93-a0e6-407f6c82355d"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("c462d47f-5898-4a70-a3fc-1369243f484a"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("c6190450-9d62-4163-9470-5b7b2ebb71e6"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("c8cde5e2-df86-49e5-a4cb-cdf5df5ac497"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("ca7deaf6-e998-4898-96e1-69d378662c52"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("ce8940bb-877e-4379-bcc4-ce6c8863f991"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("d1943d0e-7ff8-419b-83b4-5ac8f7f86ae9"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("d1c6118c-eb87-482e-a760-3c23d95a255e"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("d9652f33-298c-4918-9479-c4c07c3ad69d"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("db5b3ce1-b970-4c16-9fab-09d529b1cac0"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("dbf670e4-84bb-4ffb-8383-eeaa14640f15"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("dc4cbbfd-a927-4e8f-804c-16472a80a5fd"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("e28f5662-29a3-4e15-ba0b-62a3ba80ca1c"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("e4ef12c2-daf0-42f4-aa1c-0c769f17742a"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("e7e556b2-489c-457d-94c4-15271d8cb1e2"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("e86864bf-4cee-4076-b074-7511661eec00"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("e89a3e4a-7148-404c-ba88-981ae1926c1c"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("e912a5c0-bb57-411c-be58-cc02437e0067"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("eafd2dcd-e617-456d-b2d7-5d23a1913762"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f13dd042-96ee-4d5b-b7e9-81505a2fa97d"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f27570da-8d09-44fa-8ff0-148deafe79f3"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f2a6edb4-d393-4931-af92-b486472bfd47"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("fbab591b-806e-4cff-9965-d70cd1dc2790"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("fc4b3470-46a5-45f8-b925-be3d73165c48"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("fde06b7f-61ad-455a-9158-e8ae5184c00e"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("ffb0388c-4e72-4c48-b0cb-dd8fb947bf5e"));

            migrationBuilder.DropColumn(
                name: "OrganizationId",
                table: "AspNetUsers");

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
        }
    }
}
