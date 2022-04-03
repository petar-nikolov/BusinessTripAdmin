using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BusinessTripAdmin.Infrastructure.Data.Migrations
{
    public partial class DataSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Allowances",
                columns: new[] { "Id", "AccomodationAllowance", "CreatedDate", "DailyAllowance", "UpdatedDate", "ValidFrom", "ValidTo" },
                values: new object[,]
                {
                    { new Guid("0381f4de-2df1-4ea8-9709-c22bb982d87b"), 100m, new DateTime(2022, 4, 3, 11, 2, 58, 0, DateTimeKind.Unspecified), 35m, null, new DateTime(2022, 4, 3, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("06188f4c-c990-4840-8d70-6aa2fc702b8c"), 100m, new DateTime(2022, 4, 3, 11, 2, 58, 0, DateTimeKind.Unspecified), 30m, null, new DateTime(2022, 4, 3, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("06f65e0f-fd1e-427f-bc71-69ac4aae26ec"), 130m, new DateTime(2022, 4, 3, 11, 2, 58, 0, DateTimeKind.Unspecified), 35m, null, new DateTime(2022, 4, 3, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("075be393-82d8-4053-a824-b415e8ff457a"), 150m, new DateTime(2022, 4, 3, 11, 2, 58, 0, DateTimeKind.Unspecified), 35m, null, new DateTime(2022, 4, 3, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("07960376-aca8-4de6-92af-c5d7a32bc2f1"), 130m, new DateTime(2022, 4, 3, 11, 2, 58, 0, DateTimeKind.Unspecified), 35m, null, new DateTime(2022, 4, 3, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("07a8b13e-3285-420d-93d0-102f6e79dcc4"), 90m, new DateTime(2022, 4, 3, 11, 2, 58, 0, DateTimeKind.Unspecified), 30m, null, new DateTime(2022, 4, 3, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("07b93164-df72-4222-9387-6763c9a633a8"), 80m, new DateTime(2022, 4, 3, 11, 2, 58, 0, DateTimeKind.Unspecified), 30m, null, new DateTime(2022, 4, 3, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("0bcecf97-9c8d-4ea4-9376-118cdd0e2acf"), 130m, new DateTime(2022, 4, 3, 11, 2, 58, 0, DateTimeKind.Unspecified), 35m, null, new DateTime(2022, 4, 3, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("0cfbfd8d-31b3-4ce2-adb1-df6ec51390e7"), 130m, new DateTime(2022, 4, 3, 11, 2, 58, 0, DateTimeKind.Unspecified), 35m, null, new DateTime(2022, 4, 3, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("205cc739-aaae-4260-a9c9-1b3b6d8e8fde"), 100m, new DateTime(2022, 4, 3, 11, 2, 58, 0, DateTimeKind.Unspecified), 30m, null, new DateTime(2022, 4, 3, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("215d5827-4c18-4e47-86fc-e9dada62aa13"), 130m, new DateTime(2022, 4, 3, 11, 2, 58, 0, DateTimeKind.Unspecified), 30m, null, new DateTime(2022, 4, 3, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("2322697a-711b-4b64-9343-9d9ab7cb08a0"), 110m, new DateTime(2022, 4, 3, 11, 2, 58, 0, DateTimeKind.Unspecified), 30m, null, new DateTime(2022, 4, 3, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("267bbf07-3804-4198-bfe6-7fcaaa920d75"), 100m, new DateTime(2022, 4, 3, 11, 2, 58, 0, DateTimeKind.Unspecified), 30m, null, new DateTime(2022, 4, 3, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("280623a8-8538-4fe1-85c1-5f0e16687c64"), 80m, new DateTime(2022, 4, 3, 11, 2, 58, 0, DateTimeKind.Unspecified), 30m, null, new DateTime(2022, 4, 3, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("2c84fee3-4ac1-45f0-98c2-ae071fb6ee1b"), 80m, new DateTime(2022, 4, 3, 11, 2, 58, 0, DateTimeKind.Unspecified), 30m, null, new DateTime(2022, 4, 3, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("2f1d6224-f422-4181-b51f-04d2956e7ed6"), 130m, new DateTime(2022, 4, 3, 11, 2, 58, 0, DateTimeKind.Unspecified), 35m, null, new DateTime(2022, 4, 3, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("3108f154-0448-4596-bb44-4c4454979c33"), 80m, new DateTime(2022, 4, 3, 11, 2, 58, 0, DateTimeKind.Unspecified), 30m, null, new DateTime(2022, 4, 3, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("33adfc4b-886a-490e-a1e1-84d788caba94"), 100m, new DateTime(2022, 4, 3, 11, 2, 58, 0, DateTimeKind.Unspecified), 30m, null, new DateTime(2022, 4, 3, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("3403f93a-cca9-4d30-8729-8f6c36eed868"), 130m, new DateTime(2022, 4, 3, 11, 2, 58, 0, DateTimeKind.Unspecified), 35m, null, new DateTime(2022, 4, 3, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("34c4689c-b06a-4983-b117-a91a4da95e17"), 85m, new DateTime(2022, 4, 3, 11, 2, 58, 0, DateTimeKind.Unspecified), 30m, null, new DateTime(2022, 4, 3, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("36110429-73f4-48c5-b431-bcbeae044da1"), 130m, new DateTime(2022, 4, 3, 11, 2, 58, 0, DateTimeKind.Unspecified), 35m, null, new DateTime(2022, 4, 3, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("3a2836b6-f413-4fa0-be92-c40a929804ea"), 100m, new DateTime(2022, 4, 3, 11, 2, 58, 0, DateTimeKind.Unspecified), 35m, null, new DateTime(2022, 4, 3, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("42c16b8d-30f6-41a9-a8f5-139a099e4c5f"), 80m, new DateTime(2022, 4, 3, 11, 2, 58, 0, DateTimeKind.Unspecified), 30m, null, new DateTime(2022, 4, 3, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("43af42f2-a4a6-4ab9-b88c-9c6c98be72ca"), 120m, new DateTime(2022, 4, 3, 11, 2, 58, 0, DateTimeKind.Unspecified), 35m, null, new DateTime(2022, 4, 3, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("46c33940-9b79-4583-ab49-7a45bc3361ba"), 90m, new DateTime(2022, 4, 3, 11, 2, 58, 0, DateTimeKind.Unspecified), 30m, null, new DateTime(2022, 4, 3, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("48116ed4-22cc-4389-b07b-99edc996c80f"), 130m, new DateTime(2022, 4, 3, 11, 2, 58, 0, DateTimeKind.Unspecified), 35m, null, new DateTime(2022, 4, 3, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("4934b112-7e8f-43e4-a1a8-6a80dd22e7db"), 90m, new DateTime(2022, 4, 3, 11, 2, 58, 0, DateTimeKind.Unspecified), 30m, null, new DateTime(2022, 4, 3, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("4b322493-3bca-4556-9725-4c7c0e442de8"), 80m, new DateTime(2022, 4, 3, 11, 2, 58, 0, DateTimeKind.Unspecified), 30m, null, new DateTime(2022, 4, 3, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("4d227097-40ba-4f5b-9b46-9c11febddcfe"), 100m, new DateTime(2022, 4, 3, 11, 2, 58, 0, DateTimeKind.Unspecified), 35m, null, new DateTime(2022, 4, 3, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("53013957-6d13-4c3f-8cc2-2b8597e83b85"), 80m, new DateTime(2022, 4, 3, 11, 2, 58, 0, DateTimeKind.Unspecified), 30m, null, new DateTime(2022, 4, 3, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("54eaffea-ccaa-4cfd-906b-f92d73aff7f5"), 100m, new DateTime(2022, 4, 3, 11, 2, 58, 0, DateTimeKind.Unspecified), 30m, null, new DateTime(2022, 4, 3, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("559d0763-11f0-462e-a09f-d2b2e16c31c8"), 80m, new DateTime(2022, 4, 3, 11, 2, 58, 0, DateTimeKind.Unspecified), 30m, null, new DateTime(2022, 4, 3, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("5ab3855d-aea0-45d5-a96e-e0e3eaec4b57"), 80m, new DateTime(2022, 4, 3, 11, 2, 58, 0, DateTimeKind.Unspecified), 30m, null, new DateTime(2022, 4, 3, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("5d390506-1c65-4588-b0c2-f21f18480b8d"), 80m, new DateTime(2022, 4, 3, 11, 2, 58, 0, DateTimeKind.Unspecified), 30m, null, new DateTime(2022, 4, 3, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("5efb83f0-4787-47e9-b35c-aafcf07f00d9"), 130m, new DateTime(2022, 4, 3, 11, 2, 58, 0, DateTimeKind.Unspecified), 35m, null, new DateTime(2022, 4, 3, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("5f0f7811-ed1b-4cee-b21a-3529c951b431"), 100m, new DateTime(2022, 4, 3, 11, 2, 58, 0, DateTimeKind.Unspecified), 35m, null, new DateTime(2022, 4, 3, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("5fae555f-acc5-43dc-b194-05f75dc5cf50"), 130m, new DateTime(2022, 4, 3, 11, 2, 58, 0, DateTimeKind.Unspecified), 35m, null, new DateTime(2022, 4, 3, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("60a10652-1374-4734-8296-e7bd3b42b5b4"), 100m, new DateTime(2022, 4, 3, 11, 2, 58, 0, DateTimeKind.Unspecified), 30m, null, new DateTime(2022, 4, 3, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("65616998-0a22-4d61-9fd7-e9bc710b5d51"), 100m, new DateTime(2022, 4, 3, 11, 2, 58, 0, DateTimeKind.Unspecified), 30m, null, new DateTime(2022, 4, 3, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("65dcd295-8419-4707-a386-69ebeb13d97a"), 130m, new DateTime(2022, 4, 3, 11, 2, 58, 0, DateTimeKind.Unspecified), 35m, null, new DateTime(2022, 4, 3, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("6a0662f7-1781-47a4-b241-5ac11cd9c0da"), 130m, new DateTime(2022, 4, 3, 11, 2, 58, 0, DateTimeKind.Unspecified), 35m, null, new DateTime(2022, 4, 3, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("6aa565b7-a236-4ed5-8d79-4a28c6bbb277"), 80m, new DateTime(2022, 4, 3, 11, 2, 58, 0, DateTimeKind.Unspecified), 30m, null, new DateTime(2022, 4, 3, 0, 0, 0, 0, DateTimeKind.Local), null }
                });

            migrationBuilder.InsertData(
                table: "Allowances",
                columns: new[] { "Id", "AccomodationAllowance", "CreatedDate", "DailyAllowance", "UpdatedDate", "ValidFrom", "ValidTo" },
                values: new object[,]
                {
                    { new Guid("6f405f8b-8a0a-4dff-8dba-76bee9019df2"), 150m, new DateTime(2022, 4, 3, 11, 2, 58, 0, DateTimeKind.Unspecified), 60m, null, new DateTime(2022, 4, 3, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("6f82d9e5-04a8-4625-9a81-16c209ce9bd7"), 130m, new DateTime(2022, 4, 3, 11, 2, 58, 0, DateTimeKind.Unspecified), 35m, null, new DateTime(2022, 4, 3, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("74d942a7-0f06-46f9-bfc7-fefe7c2fb63c"), 90m, new DateTime(2022, 4, 3, 11, 2, 58, 0, DateTimeKind.Unspecified), 30m, null, new DateTime(2022, 4, 3, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("751f57b6-b681-417f-a52c-bdd3c13eaa89"), 145m, new DateTime(2022, 4, 3, 11, 2, 58, 0, DateTimeKind.Unspecified), 35m, null, new DateTime(2022, 4, 3, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("77e2793d-cde6-4028-8201-8fffbd1eb7f6"), 100m, new DateTime(2022, 4, 3, 11, 2, 58, 0, DateTimeKind.Unspecified), 30m, null, new DateTime(2022, 4, 3, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("7be2e05b-ddd4-4190-bd49-e29efc5399d2"), 120m, new DateTime(2022, 4, 3, 11, 2, 58, 0, DateTimeKind.Unspecified), 35m, null, new DateTime(2022, 4, 3, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("7da732b3-902f-4a45-adc5-8b8f4a45d243"), 100m, new DateTime(2022, 4, 3, 11, 2, 58, 0, DateTimeKind.Unspecified), 30m, null, new DateTime(2022, 4, 3, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("7e1982b4-80a0-457e-b03b-70183152aebd"), 100m, new DateTime(2022, 4, 3, 11, 2, 58, 0, DateTimeKind.Unspecified), 30m, null, new DateTime(2022, 4, 3, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("7f0fc5fb-c71e-4b4d-8a36-9cdc9d60301e"), 90m, new DateTime(2022, 4, 3, 11, 2, 58, 0, DateTimeKind.Unspecified), 30m, null, new DateTime(2022, 4, 3, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("7ff87bf3-b607-4aa8-9d88-5c1e58b5e8b2"), 80m, new DateTime(2022, 4, 3, 11, 2, 58, 0, DateTimeKind.Unspecified), 30m, null, new DateTime(2022, 4, 3, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("8024fa2a-5afe-4c30-9200-715dd98f8eda"), 100m, new DateTime(2022, 4, 3, 11, 2, 58, 0, DateTimeKind.Unspecified), 30m, null, new DateTime(2022, 4, 3, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("87d96942-4fe4-4cf6-a268-9570e0a74720"), 80m, new DateTime(2022, 4, 3, 11, 2, 58, 0, DateTimeKind.Unspecified), 35m, null, new DateTime(2022, 4, 3, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("8eb45d6f-818f-42f9-9abf-ee80b1f433e4"), 110m, new DateTime(2022, 4, 3, 11, 2, 58, 0, DateTimeKind.Unspecified), 30m, null, new DateTime(2022, 4, 3, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("90cac223-9150-4889-b181-1abd9230878a"), 80m, new DateTime(2022, 4, 3, 11, 2, 58, 0, DateTimeKind.Unspecified), 30m, null, new DateTime(2022, 4, 3, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("9104808c-a173-47ff-a39d-a28fdda080f1"), 100m, new DateTime(2022, 4, 3, 11, 2, 58, 0, DateTimeKind.Unspecified), 30m, null, new DateTime(2022, 4, 3, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("9407c492-137d-4a7a-997f-9ff3f57f3823"), 80m, new DateTime(2022, 4, 3, 11, 2, 58, 0, DateTimeKind.Unspecified), 30m, null, new DateTime(2022, 4, 3, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("9e88b0b0-61c0-4512-9e83-a370e5337736"), 90m, new DateTime(2022, 4, 3, 11, 2, 58, 0, DateTimeKind.Unspecified), 30m, null, new DateTime(2022, 4, 3, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("9f1ee65a-e34a-4a5b-b9fb-7bff1efcb498"), 17000m, new DateTime(2022, 4, 3, 11, 2, 58, 0, DateTimeKind.Unspecified), 5500m, null, new DateTime(2022, 4, 3, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("a0202664-50f2-45b2-bf40-69a87e91394f"), 130m, new DateTime(2022, 4, 3, 11, 2, 58, 0, DateTimeKind.Unspecified), 35m, null, new DateTime(2022, 4, 3, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("a0778bf4-fa45-490f-a731-553767485ca7"), 90m, new DateTime(2022, 4, 3, 11, 2, 58, 0, DateTimeKind.Unspecified), 30m, null, new DateTime(2022, 4, 3, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("a1d2d8e0-50fa-4b44-ab2d-61c21c121331"), 150m, new DateTime(2022, 4, 3, 11, 2, 58, 0, DateTimeKind.Unspecified), 35m, null, new DateTime(2022, 4, 3, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("a70cf61a-ddf2-43aa-8461-ebe6a3e84dfb"), 90m, new DateTime(2022, 4, 3, 11, 2, 58, 0, DateTimeKind.Unspecified), 30m, null, new DateTime(2022, 4, 3, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("a72de33d-122e-43f0-bc66-f09cbd088d47"), 100m, new DateTime(2022, 4, 3, 11, 2, 58, 0, DateTimeKind.Unspecified), 30m, null, new DateTime(2022, 4, 3, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("a94eea2e-dcd6-442c-b933-6e1887d27431"), 130m, new DateTime(2022, 4, 3, 11, 2, 58, 0, DateTimeKind.Unspecified), 35m, null, new DateTime(2022, 4, 3, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("aad704b4-e7f3-47ab-85ba-1ad534bf2156"), 90m, new DateTime(2022, 4, 3, 11, 2, 58, 0, DateTimeKind.Unspecified), 30m, null, new DateTime(2022, 4, 3, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("ad005b98-bc60-4899-9698-674f42f58ad0"), 90m, new DateTime(2022, 4, 3, 11, 2, 58, 0, DateTimeKind.Unspecified), 30m, null, new DateTime(2022, 4, 3, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("b025bd7a-07c7-4c8f-9fdf-c39f655d49f4"), 100m, new DateTime(2022, 4, 3, 11, 2, 58, 0, DateTimeKind.Unspecified), 30m, null, new DateTime(2022, 4, 3, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("b16b0bf6-10d9-4fd1-bc46-81c1a1c36004"), 80m, new DateTime(2022, 4, 3, 11, 2, 58, 0, DateTimeKind.Unspecified), 30m, null, new DateTime(2022, 4, 3, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("b19dd793-d70b-4f44-ae4b-7ceb9acaec6b"), 130m, new DateTime(2022, 4, 3, 11, 2, 58, 0, DateTimeKind.Unspecified), 35m, null, new DateTime(2022, 4, 3, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("b361e17b-6932-4cd9-8867-dd9db97b9b07"), 100m, new DateTime(2022, 4, 3, 11, 2, 58, 0, DateTimeKind.Unspecified), 30m, null, new DateTime(2022, 4, 3, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("b48500d3-f158-4f7a-9066-e68ef62856c0"), 130m, new DateTime(2022, 4, 3, 11, 2, 58, 0, DateTimeKind.Unspecified), 35m, null, new DateTime(2022, 4, 3, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("b63ac7e9-cf73-48e3-b8f5-7d1a6f30aa20"), 130m, new DateTime(2022, 4, 3, 11, 2, 58, 0, DateTimeKind.Unspecified), 35m, null, new DateTime(2022, 4, 3, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("b86f8a7c-c953-4c7c-840e-22661454cbcd"), 130m, new DateTime(2022, 4, 3, 11, 2, 58, 0, DateTimeKind.Unspecified), 35m, null, new DateTime(2022, 4, 3, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("be2e5eab-4ba6-41fc-bee8-bfb81ee0bb6a"), 130m, new DateTime(2022, 4, 3, 11, 2, 58, 0, DateTimeKind.Unspecified), 35m, null, new DateTime(2022, 4, 3, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("be513a88-1896-45ed-9e0f-a361174c5b68"), 100m, new DateTime(2022, 4, 3, 11, 2, 58, 0, DateTimeKind.Unspecified), 35m, null, new DateTime(2022, 4, 3, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("bf312263-02ec-4d1b-8698-591ce5fcf97b"), 130m, new DateTime(2022, 4, 3, 11, 2, 58, 0, DateTimeKind.Unspecified), 35m, null, new DateTime(2022, 4, 3, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("c0a26908-c300-4cda-8890-eb67ddb91c36"), 100m, new DateTime(2022, 4, 3, 11, 2, 58, 0, DateTimeKind.Unspecified), 35m, null, new DateTime(2022, 4, 3, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("c2997ea7-b6bb-4143-a2f8-722cd7391e2a"), 90m, new DateTime(2022, 4, 3, 11, 2, 58, 0, DateTimeKind.Unspecified), 30m, null, new DateTime(2022, 4, 3, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("c453ec44-36e4-4279-a609-2fa825f65d5f"), 130m, new DateTime(2022, 4, 3, 11, 2, 58, 0, DateTimeKind.Unspecified), 35m, null, new DateTime(2022, 4, 3, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("c91cf61b-1aaf-4a0e-bb06-fedc57a7a3ed"), 90m, new DateTime(2022, 4, 3, 11, 2, 58, 0, DateTimeKind.Unspecified), 30m, null, new DateTime(2022, 4, 3, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("cba0b4b9-0fa1-4b0a-ae2a-ae6575b6698d"), 130m, new DateTime(2022, 4, 3, 11, 2, 58, 0, DateTimeKind.Unspecified), 35m, null, new DateTime(2022, 4, 3, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("d0d9bd04-c3e0-4f71-85c8-1bf63e8fb1b1"), 120m, new DateTime(2022, 4, 3, 11, 2, 58, 0, DateTimeKind.Unspecified), 30m, null, new DateTime(2022, 4, 3, 0, 0, 0, 0, DateTimeKind.Local), null }
                });

            migrationBuilder.InsertData(
                table: "Allowances",
                columns: new[] { "Id", "AccomodationAllowance", "CreatedDate", "DailyAllowance", "UpdatedDate", "ValidFrom", "ValidTo" },
                values: new object[,]
                {
                    { new Guid("d1905e97-53b9-4eb0-93f6-4e2127057695"), 130m, new DateTime(2022, 4, 3, 11, 2, 58, 0, DateTimeKind.Unspecified), 35m, null, new DateTime(2022, 4, 3, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("d210c79a-1c7e-4496-bb04-eaf5a42e2b9f"), 110m, new DateTime(2022, 4, 3, 11, 2, 58, 0, DateTimeKind.Unspecified), 30m, null, new DateTime(2022, 4, 3, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("d3b97b82-cca0-4794-937e-c6e6052e9a96"), 110m, new DateTime(2022, 4, 3, 11, 2, 58, 0, DateTimeKind.Unspecified), 30m, null, new DateTime(2022, 4, 3, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("d62a2a0e-17e5-4403-bbec-3f30fbf3e257"), 130m, new DateTime(2022, 4, 3, 11, 2, 58, 0, DateTimeKind.Unspecified), 35m, null, new DateTime(2022, 4, 3, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("dcd98293-b2a9-4b12-8ed9-03f6b21cafc9"), 130m, new DateTime(2022, 4, 3, 11, 2, 58, 0, DateTimeKind.Unspecified), 35m, null, new DateTime(2022, 4, 3, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("dda2c2ab-22cf-453f-a63f-f673350e9f60"), 70m, new DateTime(2022, 4, 3, 11, 2, 58, 0, DateTimeKind.Unspecified), 30m, null, new DateTime(2022, 4, 3, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("df9e81d3-aa61-4ac2-a231-bc8fe6840e0e"), 130m, new DateTime(2022, 4, 3, 11, 2, 58, 0, DateTimeKind.Unspecified), 35m, null, new DateTime(2022, 4, 3, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("e3216f86-4a89-42ab-88a9-d8f5306a69ab"), 100m, new DateTime(2022, 4, 3, 11, 2, 58, 0, DateTimeKind.Unspecified), 30m, null, new DateTime(2022, 4, 3, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("e3cecc2b-8815-41ee-8d70-60dc6cf08108"), 130m, new DateTime(2022, 4, 3, 11, 2, 58, 0, DateTimeKind.Unspecified), 35m, null, new DateTime(2022, 4, 3, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("e90a9b26-a33c-4fd5-a63a-351890a48a21"), 130m, new DateTime(2022, 4, 3, 11, 2, 58, 0, DateTimeKind.Unspecified), 35m, null, new DateTime(2022, 4, 3, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("ea6b5032-e15b-4006-be18-f005dc0a5708"), 80m, new DateTime(2022, 4, 3, 11, 2, 58, 0, DateTimeKind.Unspecified), 30m, null, new DateTime(2022, 4, 3, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("f3e06554-625e-4700-94e9-d882970cb5d7"), 130m, new DateTime(2022, 4, 3, 11, 2, 58, 0, DateTimeKind.Unspecified), 35m, null, new DateTime(2022, 4, 3, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("f50cc541-5f07-4880-8d08-4c5f5da8b04e"), 90m, new DateTime(2022, 4, 3, 11, 2, 58, 0, DateTimeKind.Unspecified), 30m, null, new DateTime(2022, 4, 3, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("f9e3d3e5-8e92-44e3-bc45-2020d333d773"), 130m, new DateTime(2022, 4, 3, 11, 2, 58, 0, DateTimeKind.Unspecified), 35m, null, new DateTime(2022, 4, 3, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("fb5024d4-dc34-41d3-a9cb-c46f60b1c8c5"), 120m, new DateTime(2022, 4, 3, 11, 2, 58, 0, DateTimeKind.Unspecified), 35m, null, new DateTime(2022, 4, 3, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("fc976bc0-596d-48cd-a6e0-8c4e75a94d32"), 90m, new DateTime(2022, 4, 3, 11, 2, 58, 0, DateTimeKind.Unspecified), 30m, null, new DateTime(2022, 4, 3, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("fed1edf6-12a6-41e5-9c29-c53eb3d9ef3e"), 130m, new DateTime(2022, 4, 3, 11, 2, 58, 0, DateTimeKind.Unspecified), 35m, null, new DateTime(2022, 4, 3, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("ff9cc286-092e-4536-a8e4-46635dcc7327"), 100m, new DateTime(2022, 4, 3, 11, 2, 58, 0, DateTimeKind.Unspecified), 30m, null, new DateTime(2022, 4, 3, 0, 0, 0, 0, DateTimeKind.Local), null },
                    { new Guid("ffa04673-a956-45f8-b2dc-9919001a9ac4"), 130m, new DateTime(2022, 4, 3, 11, 2, 58, 0, DateTimeKind.Unspecified), 35m, null, new DateTime(2022, 4, 3, 0, 0, 0, 0, DateTimeKind.Local), null }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "AllowanceId", "CountryName", "CreatedDate", "Currency", "CurrencyCode", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("0011487d-6bb5-45e6-98b3-98c160b03101"), new Guid("a0778bf4-fa45-490f-a731-553767485ca7"), "IRAQ", new DateTime(2022, 4, 3, 11, 2, 58, 0, DateTimeKind.Unspecified), "US Dollar", 1, null },
                    { new Guid("0201d1ae-ddd3-48e8-9f90-f23b5a5864f3"), new Guid("b63ac7e9-cf73-48e3-b8f5-7d1a6f30aa20"), "FRANCE", new DateTime(2022, 4, 3, 11, 2, 58, 0, DateTimeKind.Unspecified), "Euro", 3, null },
                    { new Guid("02cb26a5-ea09-4ae5-a55f-e8504b95d26d"), new Guid("a70cf61a-ddf2-43aa-8461-ebe6a3e84dfb"), "IRAN", new DateTime(2022, 4, 3, 11, 2, 58, 0, DateTimeKind.Unspecified), "US Dollar", 1, null },
                    { new Guid("033577fb-43d6-44e7-bdb4-44a6cc907c20"), new Guid("dda2c2ab-22cf-453f-a63f-f673350e9f60"), "PERU", new DateTime(2022, 4, 3, 11, 2, 58, 0, DateTimeKind.Unspecified), "US Dollar", 1, null },
                    { new Guid("0acce479-8ebc-4c0c-9286-01d50ec593b9"), new Guid("3a2836b6-f413-4fa0-be92-c40a929804ea"), "ARGENTINA", new DateTime(2022, 4, 3, 11, 2, 58, 0, DateTimeKind.Unspecified), "US Dollar", 1, null },
                    { new Guid("0be75521-538f-4d66-8b72-b1be87b47268"), new Guid("07a8b13e-3285-420d-93d0-102f6e79dcc4"), "NIGERIA", new DateTime(2022, 4, 3, 11, 2, 58, 0, DateTimeKind.Unspecified), "US Dollar", 1, null },
                    { new Guid("12f5e20a-129b-48b7-8345-d726491fb8be"), new Guid("267bbf07-3804-4198-bfe6-7fcaaa920d75"), "CONGO", new DateTime(2022, 4, 3, 11, 2, 58, 0, DateTimeKind.Unspecified), "US Dollar", 1, null },
                    { new Guid("1880a185-1a98-43f2-bc07-cc4b76d3c551"), new Guid("7e1982b4-80a0-457e-b03b-70183152aebd"), "UNITED KINGDOM", new DateTime(2022, 4, 3, 11, 2, 58, 0, DateTimeKind.Unspecified), "Pound Sterling", 5, null },
                    { new Guid("1b3761ff-f775-4f8f-a396-4c291faad90b"), new Guid("74d942a7-0f06-46f9-bfc7-fefe7c2fb63c"), "MOZAMBIQUE", new DateTime(2022, 4, 3, 11, 2, 58, 0, DateTimeKind.Unspecified), "US Dollar", 1, null },
                    { new Guid("1bb793a9-861e-4ab3-b8c4-405d45962b40"), new Guid("0381f4de-2df1-4ea8-9709-c22bb982d87b"), "ISRAEL", new DateTime(2022, 4, 3, 11, 2, 58, 0, DateTimeKind.Unspecified), "US Dollar", 1, null },
                    { new Guid("2059e331-fbd9-4d02-91dd-03e775d40dca"), new Guid("075be393-82d8-4053-a824-b415e8ff457a"), "RUSSIAN FEDERATION", new DateTime(2022, 4, 3, 11, 2, 58, 0, DateTimeKind.Unspecified), "US Dollar", 1, null },
                    { new Guid("217c9e54-babe-469e-93ca-2fbdc24ffded"), new Guid("42c16b8d-30f6-41a9-a8f5-139a099e4c5f"), "ARMENIA", new DateTime(2022, 4, 3, 11, 2, 58, 0, DateTimeKind.Unspecified), "US Dollar", 1, null },
                    { new Guid("26489fc8-1c90-49ec-a7f6-b37c73446458"), new Guid("ffa04673-a956-45f8-b2dc-9919001a9ac4"), "MALTA", new DateTime(2022, 4, 3, 11, 2, 58, 0, DateTimeKind.Unspecified), "Euro", 3, null },
                    { new Guid("266f5b88-3fb8-4d0f-9f34-ca30e8d2af58"), new Guid("5fae555f-acc5-43dc-b194-05f75dc5cf50"), "BELGIUM", new DateTime(2022, 4, 3, 11, 2, 58, 0, DateTimeKind.Unspecified), "Euro", 3, null },
                    { new Guid("271d9138-50a5-4530-a198-eb2a540eb19a"), new Guid("3403f93a-cca9-4d30-8729-8f6c36eed868"), "GIBRALTAR", new DateTime(2022, 4, 3, 11, 2, 58, 0, DateTimeKind.Unspecified), "Euro", 3, null },
                    { new Guid("27b6bee9-3b84-4583-9402-4296e5ccae80"), new Guid("a0202664-50f2-45b2-bf40-69a87e91394f"), "ESTONIA", new DateTime(2022, 4, 3, 11, 2, 58, 0, DateTimeKind.Unspecified), "Euro", 3, null },
                    { new Guid("29e388b3-4644-4473-b4c0-63f0f34fb81c"), new Guid("6aa565b7-a236-4ed5-8d79-4a28c6bbb277"), "UZBEKISTAN", new DateTime(2022, 4, 3, 11, 2, 58, 0, DateTimeKind.Unspecified), "US Dollar", 1, null },
                    { new Guid("2f617137-5cb4-4a43-a10e-ba432af2a36b"), new Guid("fc976bc0-596d-48cd-a6e0-8c4e75a94d32"), "KYRGYZSTAN", new DateTime(2022, 4, 3, 11, 2, 58, 0, DateTimeKind.Unspecified), "US Dollar", 1, null },
                    { new Guid("2f742b43-f5aa-4d73-b107-34560d4f7c3d"), new Guid("7be2e05b-ddd4-4190-bd49-e29efc5399d2"), "AUSTRALIA", new DateTime(2022, 4, 3, 11, 2, 58, 0, DateTimeKind.Unspecified), "Australian Dollar", 4, null },
                    { new Guid("2fd1ccaa-3c62-4c9b-8657-3f6a565b2ec4"), new Guid("c0a26908-c300-4cda-8890-eb67ddb91c36"), "CUBA", new DateTime(2022, 4, 3, 11, 2, 58, 0, DateTimeKind.Unspecified), "US Dollar", 1, null },
                    { new Guid("32754dc0-6c4a-455e-95fe-9d0d0ba59829"), new Guid("b361e17b-6932-4cd9-8867-dd9db97b9b07"), "LIBYAN ARAB JAMAHIRIYA", new DateTime(2022, 4, 3, 11, 2, 58, 0, DateTimeKind.Unspecified), "US Dollar", 1, null },
                    { new Guid("32c23fa0-20f7-4e53-9467-6e47dd9ae626"), new Guid("0cfbfd8d-31b3-4ce2-adb1-df6ec51390e7"), "AUSTRIA", new DateTime(2022, 4, 3, 11, 2, 58, 0, DateTimeKind.Unspecified), "Euro", 3, null },
                    { new Guid("34800bf5-3ad4-4078-aeca-d7034c3a4629"), new Guid("d210c79a-1c7e-4496-bb04-eaf5a42e2b9f"), "INDONESIA", new DateTime(2022, 4, 3, 11, 2, 58, 0, DateTimeKind.Unspecified), "US Dollar", 1, null },
                    { new Guid("34cf679d-e0ac-4e34-b51b-bafac4c846bc"), new Guid("77e2793d-cde6-4028-8201-8fffbd1eb7f6"), "LEBANON", new DateTime(2022, 4, 3, 11, 2, 58, 0, DateTimeKind.Unspecified), "US Dollar", 1, null },
                    { new Guid("3708f618-0a33-4b01-8d8c-c5ce21e38ed4"), new Guid("2c84fee3-4ac1-45f0-98c2-ae071fb6ee1b"), "AFGHANISTAN", new DateTime(2022, 4, 3, 11, 2, 58, 0, DateTimeKind.Unspecified), "US Dollar", 1, null },
                    { new Guid("3f0d17d2-e84a-4b21-be01-375006decb6f"), new Guid("be2e5eab-4ba6-41fc-bee8-bfb81ee0bb6a"), "ICELAND", new DateTime(2022, 4, 3, 11, 2, 58, 0, DateTimeKind.Unspecified), "Euro", 3, null },
                    { new Guid("3ffab1d8-87a6-49d8-a0a1-f3fb2eb6e52d"), new Guid("b86f8a7c-c953-4c7c-840e-22661454cbcd"), "SLOVAKIA", new DateTime(2022, 4, 3, 11, 2, 58, 0, DateTimeKind.Unspecified), "Euro", 3, null },
                    { new Guid("422117d7-c537-4ab1-a3e2-8377377ed70c"), new Guid("65dcd295-8419-4707-a386-69ebeb13d97a"), "NETHERLANDS", new DateTime(2022, 4, 3, 11, 2, 58, 0, DateTimeKind.Unspecified), "Euro", 3, null },
                    { new Guid("47b3b30d-d15f-45ad-a65b-fe408dd6f1b7"), new Guid("5d390506-1c65-4588-b0c2-f21f18480b8d"), "NEW ZEALAND", new DateTime(2022, 4, 3, 11, 2, 58, 0, DateTimeKind.Unspecified), "US Dollar", 1, null },
                    { new Guid("48569a7d-ce76-4e3d-8356-8a5e872b0f7d"), new Guid("c91cf61b-1aaf-4a0e-bb06-fedc57a7a3ed"), "INDIA", new DateTime(2022, 4, 3, 11, 2, 58, 0, DateTimeKind.Unspecified), "US Dollar", 1, null },
                    { new Guid("4964375b-562b-45a7-9826-9fc0c98f629c"), new Guid("7ff87bf3-b607-4aa8-9d88-5c1e58b5e8b2"), "EGYPT", new DateTime(2022, 4, 3, 11, 2, 58, 0, DateTimeKind.Unspecified), "US Dollar", 1, null },
                    { new Guid("4e712c3f-3446-4424-b786-4cadf58455ad"), new Guid("7da732b3-902f-4a45-adc5-8b8f4a45d243"), "KAZAKHSTAN", new DateTime(2022, 4, 3, 11, 2, 58, 0, DateTimeKind.Unspecified), "US Dollar", 1, null },
                    { new Guid("4f47f65e-7984-4dd6-82c7-ef7a3dad9267"), new Guid("3108f154-0448-4596-bb44-4c4454979c33"), "ETHIOPIA", new DateTime(2022, 4, 3, 11, 2, 58, 0, DateTimeKind.Unspecified), "US Dollar", 1, null },
                    { new Guid("51ba5434-858c-44e9-9214-55e957f82b55"), new Guid("c453ec44-36e4-4279-a609-2fa825f65d5f"), "SWEDEN", new DateTime(2022, 4, 3, 11, 2, 58, 0, DateTimeKind.Unspecified), "Euro", 3, null },
                    { new Guid("556529b5-83c0-4400-b7cb-d67f08135ddc"), new Guid("8024fa2a-5afe-4c30-9200-715dd98f8eda"), "GEORGIA", new DateTime(2022, 4, 3, 11, 2, 58, 0, DateTimeKind.Unspecified), "US Dollar", 1, null },
                    { new Guid("556c19a5-d0f7-4258-a18e-cf02a8a282fe"), new Guid("f3e06554-625e-4700-94e9-d882970cb5d7"), "ITALY", new DateTime(2022, 4, 3, 11, 2, 58, 0, DateTimeKind.Unspecified), "Euro", 3, null },
                    { new Guid("56d4b034-064b-4313-86b8-8ccc39d41a42"), new Guid("9f1ee65a-e34a-4a5b-b9fb-7bff1efcb498"), "JAPAN", new DateTime(2022, 4, 3, 11, 2, 58, 0, DateTimeKind.Unspecified), "Yen", 7, null },
                    { new Guid("58905a7c-8b71-496e-b9b9-527982313f05"), new Guid("e3216f86-4a89-42ab-88a9-d8f5306a69ab"), "GHANA", new DateTime(2022, 4, 3, 11, 2, 58, 0, DateTimeKind.Unspecified), "US Dollar", 1, null },
                    { new Guid("5a00aca7-b834-4870-9426-e9f050323799"), new Guid("f9e3d3e5-8e92-44e3-bc45-2020d333d773"), "SLOVENIA", new DateTime(2022, 4, 3, 11, 2, 58, 0, DateTimeKind.Unspecified), "Euro", 3, null },
                    { new Guid("5ace7207-5c09-4640-a749-6f277b53aa1a"), new Guid("07b93164-df72-4222-9387-6763c9a633a8"), "MALAYSIA", new DateTime(2022, 4, 3, 11, 2, 58, 0, DateTimeKind.Unspecified), "US Dollar", 1, null },
                    { new Guid("5b6e3c0c-2e61-4fab-b7bc-fb415256ab57"), new Guid("60a10652-1374-4734-8296-e7bd3b42b5b4"), "UNITED ARAB EMIRATES", new DateTime(2022, 4, 3, 11, 2, 58, 0, DateTimeKind.Unspecified), "US Dollar", 1, null },
                    { new Guid("65f06dbb-f26d-4823-a6b7-195fcb0579b3"), new Guid("c2997ea7-b6bb-4143-a2f8-722cd7391e2a"), "ALL OTHER COUNTRIES", new DateTime(2022, 4, 3, 11, 2, 58, 0, DateTimeKind.Unspecified), "US Dollar", 1, null }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "AllowanceId", "CountryName", "CreatedDate", "Currency", "CurrencyCode", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("672c9407-72ae-4d3a-88df-94b73d81298d"), new Guid("280623a8-8538-4fe1-85c1-5f0e16687c64"), "BELARUS", new DateTime(2022, 4, 3, 11, 2, 58, 0, DateTimeKind.Unspecified), "US Dollar", 1, null },
                    { new Guid("67c31d6e-e163-482e-8a4f-db266425d251"), new Guid("4b322493-3bca-4556-9725-4c7c0e442de8"), "TURKMENISTAN", new DateTime(2022, 4, 3, 11, 2, 58, 0, DateTimeKind.Unspecified), "US Dollar", 1, null },
                    { new Guid("73da67f8-acc5-4d44-81e2-3b58decf3e5d"), new Guid("46c33940-9b79-4583-ab49-7a45bc3361ba"), "NORTH KOREA", new DateTime(2022, 4, 3, 11, 2, 58, 0, DateTimeKind.Unspecified), "Euro", 3, null },
                    { new Guid("74b515ee-003a-4e61-a65c-78b745b6f2d8"), new Guid("751f57b6-b681-417f-a52c-bdd3c13eaa89"), "NORWAY", new DateTime(2022, 4, 3, 11, 2, 58, 0, DateTimeKind.Unspecified), "Euro", 3, null },
                    { new Guid("75a3b42f-c0e8-46b8-93d1-44bcf2abe806"), new Guid("e3cecc2b-8815-41ee-8d70-60dc6cf08108"), "CYPRUS", new DateTime(2022, 4, 3, 11, 2, 58, 0, DateTimeKind.Unspecified), "Euro", 3, null },
                    { new Guid("79de3d2e-cbcb-4cda-8ff7-d5123c653d47"), new Guid("be513a88-1896-45ed-9e0f-a361174c5b68"), "CANADA", new DateTime(2022, 4, 3, 11, 2, 58, 0, DateTimeKind.Unspecified), "US Dollar", 1, null },
                    { new Guid("7ae9925a-9597-4a10-a73f-c667d9a67f64"), new Guid("7f0fc5fb-c71e-4b4d-8a36-9cdc9d60301e"), "PAKISTAN", new DateTime(2022, 4, 3, 11, 2, 58, 0, DateTimeKind.Unspecified), "US Dollar", 1, null },
                    { new Guid("7b7f9f7c-8c05-4c19-861d-e8449576b940"), new Guid("a72de33d-122e-43f0-bc66-f09cbd088d47"), "MONGOLIA", new DateTime(2022, 4, 3, 11, 2, 58, 0, DateTimeKind.Unspecified), "US Dollar", 1, null },
                    { new Guid("7e9342aa-9ffd-41f1-9f6f-ab1ce04c1e8e"), new Guid("a1d2d8e0-50fa-4b44-ab2d-61c21c121331"), "UNITED STATES", new DateTime(2022, 4, 3, 11, 2, 58, 0, DateTimeKind.Unspecified), "US Dollar", 1, null },
                    { new Guid("7f8a5349-5ea9-4c1a-ac6c-ef65cc1ead29"), new Guid("6f405f8b-8a0a-4dff-8dba-76bee9019df2"), "SWITZERLAND", new DateTime(2022, 4, 3, 11, 2, 58, 0, DateTimeKind.Unspecified), "Swiss Franc", 6, null },
                    { new Guid("83309cbf-5f25-47ff-bf48-216f2ec525d4"), new Guid("6a0662f7-1781-47a4-b241-5ac11cd9c0da"), "IRELAND", new DateTime(2022, 4, 3, 11, 2, 58, 0, DateTimeKind.Unspecified), "Euro", 3, null },
                    { new Guid("8382b6e9-b3d3-476d-b8bf-66a7b3631fcb"), new Guid("b16b0bf6-10d9-4fd1-bc46-81c1a1c36004"), "SYRIAN ARAB REPUBLIC", new DateTime(2022, 4, 3, 11, 2, 58, 0, DateTimeKind.Unspecified), "US Dollar", 1, null },
                    { new Guid("8de905c9-c765-4e4e-aadb-8bb7b24e5438"), new Guid("b025bd7a-07c7-4c8f-9fdf-c39f655d49f4"), "COTE D'IVOIRE", new DateTime(2022, 4, 3, 11, 2, 58, 0, DateTimeKind.Unspecified), "US Dollar", 1, null },
                    { new Guid("930e68ee-8ce3-4e07-9045-1216fe513224"), new Guid("fb5024d4-dc34-41d3-a9cb-c46f60b1c8c5"), "MONACO", new DateTime(2022, 4, 3, 11, 2, 58, 0, DateTimeKind.Unspecified), "Euro", 3, null },
                    { new Guid("9477cdbb-0a84-4560-99e5-9a68b882d30c"), new Guid("43af42f2-a4a6-4ab9-b88c-9c6c98be72ca"), "KUWAIT", new DateTime(2022, 4, 3, 11, 2, 58, 0, DateTimeKind.Unspecified), "US Dollar", 1, null },
                    { new Guid("975817cd-0d79-463b-9f5c-b1e59f88754f"), new Guid("f50cc541-5f07-4880-8d08-4c5f5da8b04e"), "TURKEY", new DateTime(2022, 4, 3, 11, 2, 58, 0, DateTimeKind.Unspecified), "US Dollar", 1, null },
                    { new Guid("976a5c6c-2e7c-4d54-9a53-24c0b37a5383"), new Guid("90cac223-9150-4889-b181-1abd9230878a"), "TAJIKISTAN", new DateTime(2022, 4, 3, 11, 2, 58, 0, DateTimeKind.Unspecified), "US Dollar", 1, null },
                    { new Guid("97914dca-7674-4b4e-8391-0073760cbec2"), new Guid("4d227097-40ba-4f5b-9b46-9c11febddcfe"), "BRAZIL", new DateTime(2022, 4, 3, 11, 2, 58, 0, DateTimeKind.Unspecified), "US Dollar", 1, null },
                    { new Guid("9913934f-7949-45e3-be68-727e1f85875d"), new Guid("53013957-6d13-4c3f-8cc2-2b8597e83b85"), "ALBANIA", new DateTime(2022, 4, 3, 11, 2, 58, 0, DateTimeKind.Unspecified), "Euro", 3, null },
                    { new Guid("99d82816-bfd5-47e6-8cd7-4a8b3e3c596c"), new Guid("dcd98293-b2a9-4b12-8ed9-03f6b21cafc9"), "SPAIN", new DateTime(2022, 4, 3, 11, 2, 58, 0, DateTimeKind.Unspecified), "Euro", 3, null },
                    { new Guid("9b7338f9-25d9-4d0a-87e9-493300953aec"), new Guid("2322697a-711b-4b64-9343-9d9ab7cb08a0"), "AZERBAIJAN", new DateTime(2022, 4, 3, 11, 2, 58, 0, DateTimeKind.Unspecified), "US Dollar", 1, null },
                    { new Guid("9c175577-761e-495f-935b-56442c4ef234"), new Guid("fed1edf6-12a6-41e5-9c29-c53eb3d9ef3e"), "GERMANY", new DateTime(2022, 4, 3, 11, 2, 58, 0, DateTimeKind.Unspecified), "Euro", 3, null },
                    { new Guid("9ce41b69-6d5e-4de2-b7d6-2e380d5cad1a"), new Guid("9104808c-a173-47ff-a39d-a28fdda080f1"), "VIETNAM", new DateTime(2022, 4, 3, 11, 2, 58, 0, DateTimeKind.Unspecified), "US Dollar", 1, null },
                    { new Guid("9ee7521d-9540-40af-9806-30b6c880ff91"), new Guid("d3b97b82-cca0-4794-937e-c6e6052e9a96"), "UKRAINE", new DateTime(2022, 4, 3, 11, 2, 58, 0, DateTimeKind.Unspecified), "US Dollar", 1, null },
                    { new Guid("a19e18b0-f63e-4869-89e5-195dbbce97e3"), new Guid("cba0b4b9-0fa1-4b0a-ae2a-ae6575b6698d"), "GREECE", new DateTime(2022, 4, 3, 11, 2, 58, 0, DateTimeKind.Unspecified), "Euro", 3, null },
                    { new Guid("a499e729-221a-4965-888d-ed9c575fa35e"), new Guid("ea6b5032-e15b-4006-be18-f005dc0a5708"), "MALI", new DateTime(2022, 4, 3, 11, 2, 58, 0, DateTimeKind.Unspecified), "US Dollar", 1, null },
                    { new Guid("ad0b01c5-485e-4f60-9e08-c1c86b8ab7a7"), new Guid("9407c492-137d-4a7a-997f-9ff3f57f3823"), "COLOMBIA", new DateTime(2022, 4, 3, 11, 2, 58, 0, DateTimeKind.Unspecified), "US Dollar", 1, null },
                    { new Guid("b1f95e74-dca4-41d5-b575-8ce7d8776106"), new Guid("205cc739-aaae-4260-a9c9-1b3b6d8e8fde"), "SINGAPORE", new DateTime(2022, 4, 3, 11, 2, 58, 0, DateTimeKind.Unspecified), "US Dollar", 1, null },
                    { new Guid("b757ef05-599e-44fb-a033-a44da5a62716"), new Guid("87d96942-4fe4-4cf6-a268-9570e0a74720"), "ANGOLA", new DateTime(2022, 4, 3, 11, 2, 58, 0, DateTimeKind.Unspecified), "US Dollar", 1, null },
                    { new Guid("b96659af-5ebf-44cc-866e-547467bf4f69"), new Guid("215d5827-4c18-4e47-86fc-e9dada62aa13"), "MOROCCO", new DateTime(2022, 4, 3, 11, 2, 58, 0, DateTimeKind.Unspecified), "Euro", 3, null },
                    { new Guid("bb43277f-19b0-40d2-bc7f-2a13f6747052"), new Guid("36110429-73f4-48c5-b431-bcbeae044da1"), "NORTH MACEDONIA", new DateTime(2022, 4, 3, 11, 2, 58, 0, DateTimeKind.Unspecified), "Euro", 3, null },
                    { new Guid("bc6f2c12-8301-46d3-87a9-9558c394b351"), new Guid("6f82d9e5-04a8-4625-9a81-16c209ce9bd7"), "PORTUGAL", new DateTime(2022, 4, 3, 11, 2, 58, 0, DateTimeKind.Unspecified), "Euro", 3, null },
                    { new Guid("bfc79fb1-aac0-48d9-92a7-af3596769f12"), new Guid("ad005b98-bc60-4899-9698-674f42f58ad0"), "CHINA", new DateTime(2022, 4, 3, 11, 2, 58, 0, DateTimeKind.Unspecified), "US Dollar", 1, null },
                    { new Guid("cf0629ca-e41a-45e9-8bd3-65fa07f76ae3"), new Guid("8eb45d6f-818f-42f9-9abf-ee80b1f433e4"), "MOLDOVA", new DateTime(2022, 4, 3, 11, 2, 58, 0, DateTimeKind.Unspecified), "US Dollar", 1, null },
                    { new Guid("d0e93c5e-2785-4d4e-9e02-7ed9c837b0a9"), new Guid("d1905e97-53b9-4eb0-93f6-4e2127057695"), "LATVIA", new DateTime(2022, 4, 3, 11, 2, 58, 0, DateTimeKind.Unspecified), "Euro", 3, null },
                    { new Guid("d12dc078-1967-4f9c-b49e-e1bc62f459d3"), new Guid("e90a9b26-a33c-4fd5-a63a-351890a48a21"), "LUXEMBOURG", new DateTime(2022, 4, 3, 11, 2, 58, 0, DateTimeKind.Unspecified), "Euro", 3, null },
                    { new Guid("d3990463-d5d6-4f89-a6d8-52ef4ac843c8"), new Guid("65616998-0a22-4d61-9fd7-e9bc710b5d51"), "YEMEN", new DateTime(2022, 4, 3, 11, 2, 58, 0, DateTimeKind.Unspecified), "US Dollar", 1, null },
                    { new Guid("d3abb9d2-1559-4c07-a874-d586b1bb44d6"), new Guid("aad704b4-e7f3-47ab-85ba-1ad534bf2156"), "MEXICO", new DateTime(2022, 4, 3, 11, 2, 58, 0, DateTimeKind.Unspecified), "US Dollar", 1, null },
                    { new Guid("d5fb82ca-cf51-4d6f-8599-a577adced8ac"), new Guid("b19dd793-d70b-4f44-ae4b-7ceb9acaec6b"), "SAN MARINO", new DateTime(2022, 4, 3, 11, 2, 58, 0, DateTimeKind.Unspecified), "Euro", 3, null },
                    { new Guid("d70edd38-0036-459e-a88d-01370efb0548"), new Guid("06f65e0f-fd1e-427f-bc71-69ac4aae26ec"), "LIECHTENSTEIN", new DateTime(2022, 4, 3, 11, 2, 58, 0, DateTimeKind.Unspecified), "Euro", 3, null },
                    { new Guid("d73c492f-ffbc-4ae9-80bc-929d5612258e"), new Guid("06188f4c-c990-4840-8d70-6aa2fc702b8c"), "SAUDI ARABIA", new DateTime(2022, 4, 3, 11, 2, 58, 0, DateTimeKind.Unspecified), "US Dollar", 1, null },
                    { new Guid("db3c8e78-69fa-477c-9c3d-236cc3f018b2"), new Guid("9e88b0b0-61c0-4512-9e83-a370e5337736"), "NICARAGUA", new DateTime(2022, 4, 3, 11, 2, 58, 0, DateTimeKind.Unspecified), "US Dollar", 1, null }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "AllowanceId", "CountryName", "CreatedDate", "Currency", "CurrencyCode", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("dd64064f-bfc0-4e7b-a20a-06438ea57204"), new Guid("5efb83f0-4787-47e9-b35c-aafcf07f00d9"), "ROMANIA", new DateTime(2022, 4, 3, 11, 2, 58, 0, DateTimeKind.Unspecified), "Euro", 3, null },
                    { new Guid("ddd1accd-dd6d-43bc-be0c-d13277d0cb0d"), new Guid("b48500d3-f158-4f7a-9066-e68ef62856c0"), "BOSNIA AND HERZEGOVINA", new DateTime(2022, 4, 3, 11, 2, 58, 0, DateTimeKind.Unspecified), "Euro", 3, null },
                    { new Guid("ddd7facf-05f0-4545-8768-1050bfb7d3f9"), new Guid("559d0763-11f0-462e-a09f-d2b2e16c31c8"), "TUNISIA", new DateTime(2022, 4, 3, 11, 2, 58, 0, DateTimeKind.Unspecified), "US Dollar", 1, null },
                    { new Guid("e33b6ab9-6479-44bd-9cef-309c3fa25c1b"), new Guid("48116ed4-22cc-4389-b07b-99edc996c80f"), "FINLAND", new DateTime(2022, 4, 3, 11, 2, 58, 0, DateTimeKind.Unspecified), "Euro", 3, null },
                    { new Guid("e7656bf4-ca7b-422f-adc1-b6a52121c215"), new Guid("ff9cc286-092e-4536-a8e4-46635dcc7327"), "ZIMBABWE", new DateTime(2022, 4, 3, 11, 2, 58, 0, DateTimeKind.Unspecified), "US Dollar", 1, null },
                    { new Guid("e848fc47-5e05-4b1a-a2be-80389d9c6892"), new Guid("d0d9bd04-c3e0-4f71-85c8-1bf63e8fb1b1"), "SOUTH KOREA", new DateTime(2022, 4, 3, 11, 2, 58, 0, DateTimeKind.Unspecified), "US Dollar", 1, null },
                    { new Guid("ea9f282a-9e13-4616-877c-5c81f436fd71"), new Guid("d62a2a0e-17e5-4403-bbec-3f30fbf3e257"), "POLAND", new DateTime(2022, 4, 3, 11, 2, 58, 0, DateTimeKind.Unspecified), "Euro", 3, null },
                    { new Guid("ebba669a-cf70-4a24-b4ff-5f9b300242ec"), new Guid("a94eea2e-dcd6-442c-b933-6e1887d27431"), "HUNGARY", new DateTime(2022, 4, 3, 11, 2, 58, 0, DateTimeKind.Unspecified), "Euro", 3, null },
                    { new Guid("ef459bdd-5613-4764-bb4b-bdd4931a7512"), new Guid("33adfc4b-886a-490e-a1e1-84d788caba94"), "BANGLADESH", new DateTime(2022, 4, 3, 11, 2, 58, 0, DateTimeKind.Unspecified), "US Dollar", 1, null },
                    { new Guid("ef599607-5684-404e-8964-92b6511cafc2"), new Guid("bf312263-02ec-4d1b-8698-591ce5fcf97b"), "DENMARK", new DateTime(2022, 4, 3, 11, 2, 58, 0, DateTimeKind.Unspecified), "Euro", 3, null },
                    { new Guid("f08766c5-584f-4611-8be3-da436a7a96b6"), new Guid("2f1d6224-f422-4181-b51f-04d2956e7ed6"), "CZECH REPUBLIC", new DateTime(2022, 4, 3, 11, 2, 58, 0, DateTimeKind.Unspecified), "Euro", 3, null },
                    { new Guid("f4423668-cb92-42a3-a3f3-94e8ce5d6915"), new Guid("34c4689c-b06a-4983-b117-a91a4da95e17"), "CHILE", new DateTime(2022, 4, 3, 11, 2, 58, 0, DateTimeKind.Unspecified), "US Dollar", 1, null },
                    { new Guid("f7b85049-9889-422c-91fc-879677ed8b53"), new Guid("5ab3855d-aea0-45d5-a96e-e0e3eaec4b57"), "KENYA", new DateTime(2022, 4, 3, 11, 2, 58, 0, DateTimeKind.Unspecified), "US Dollar", 1, null },
                    { new Guid("fa632855-998a-4c2a-a8a5-c5002ca8bfb2"), new Guid("4934b112-7e8f-43e4-a1a8-6a80dd22e7db"), "SOUTH AFRICA", new DateTime(2022, 4, 3, 11, 2, 58, 0, DateTimeKind.Unspecified), "US Dollar", 1, null },
                    { new Guid("fb804427-a8da-458d-ae76-4350c92c53ed"), new Guid("54eaffea-ccaa-4cfd-906b-f92d73aff7f5"), "JORDAN", new DateTime(2022, 4, 3, 11, 2, 58, 0, DateTimeKind.Unspecified), "US Dollar", 1, null },
                    { new Guid("fd594d9f-7b61-4a0c-9b02-2f4cf6193e8e"), new Guid("07960376-aca8-4de6-92af-c5d7a32bc2f1"), "LITHUANIA", new DateTime(2022, 4, 3, 11, 2, 58, 0, DateTimeKind.Unspecified), "Euro", 3, null },
                    { new Guid("fd969b4a-da14-4370-9614-505970972c91"), new Guid("5f0f7811-ed1b-4cee-b21a-3529c951b431"), "ALGERIA", new DateTime(2022, 4, 3, 11, 2, 58, 0, DateTimeKind.Unspecified), "US Dollar", 1, null },
                    { new Guid("fe795d37-c21c-4dc1-a7a5-48e7e4bd4987"), new Guid("df9e81d3-aa61-4ac2-a231-bc8fe6840e0e"), "CROATIA", new DateTime(2022, 4, 3, 11, 2, 58, 0, DateTimeKind.Unspecified), "Euro", 3, null },
                    { new Guid("ffc0fbaa-e84e-4a43-95f5-7bbbc9ac2edb"), new Guid("0bcecf97-9c8d-4ea4-9376-118cdd0e2acf"), "SERBIA", new DateTime(2022, 4, 3, 11, 2, 58, 0, DateTimeKind.Unspecified), "Euro", 3, null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("0011487d-6bb5-45e6-98b3-98c160b03101"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("0201d1ae-ddd3-48e8-9f90-f23b5a5864f3"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("02cb26a5-ea09-4ae5-a55f-e8504b95d26d"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("033577fb-43d6-44e7-bdb4-44a6cc907c20"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("0acce479-8ebc-4c0c-9286-01d50ec593b9"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("0be75521-538f-4d66-8b72-b1be87b47268"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("12f5e20a-129b-48b7-8345-d726491fb8be"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("1880a185-1a98-43f2-bc07-cc4b76d3c551"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("1b3761ff-f775-4f8f-a396-4c291faad90b"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("1bb793a9-861e-4ab3-b8c4-405d45962b40"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("2059e331-fbd9-4d02-91dd-03e775d40dca"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("217c9e54-babe-469e-93ca-2fbdc24ffded"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("26489fc8-1c90-49ec-a7f6-b37c73446458"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("266f5b88-3fb8-4d0f-9f34-ca30e8d2af58"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("271d9138-50a5-4530-a198-eb2a540eb19a"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("27b6bee9-3b84-4583-9402-4296e5ccae80"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("29e388b3-4644-4473-b4c0-63f0f34fb81c"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("2f617137-5cb4-4a43-a10e-ba432af2a36b"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("2f742b43-f5aa-4d73-b107-34560d4f7c3d"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("2fd1ccaa-3c62-4c9b-8657-3f6a565b2ec4"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("32754dc0-6c4a-455e-95fe-9d0d0ba59829"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("32c23fa0-20f7-4e53-9467-6e47dd9ae626"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("34800bf5-3ad4-4078-aeca-d7034c3a4629"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("34cf679d-e0ac-4e34-b51b-bafac4c846bc"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("3708f618-0a33-4b01-8d8c-c5ce21e38ed4"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("3f0d17d2-e84a-4b21-be01-375006decb6f"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("3ffab1d8-87a6-49d8-a0a1-f3fb2eb6e52d"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("422117d7-c537-4ab1-a3e2-8377377ed70c"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("47b3b30d-d15f-45ad-a65b-fe408dd6f1b7"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("48569a7d-ce76-4e3d-8356-8a5e872b0f7d"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("4964375b-562b-45a7-9826-9fc0c98f629c"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("4e712c3f-3446-4424-b786-4cadf58455ad"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("4f47f65e-7984-4dd6-82c7-ef7a3dad9267"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("51ba5434-858c-44e9-9214-55e957f82b55"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("556529b5-83c0-4400-b7cb-d67f08135ddc"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("556c19a5-d0f7-4258-a18e-cf02a8a282fe"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("56d4b034-064b-4313-86b8-8ccc39d41a42"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("58905a7c-8b71-496e-b9b9-527982313f05"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("5a00aca7-b834-4870-9426-e9f050323799"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("5ace7207-5c09-4640-a749-6f277b53aa1a"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("5b6e3c0c-2e61-4fab-b7bc-fb415256ab57"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("65f06dbb-f26d-4823-a6b7-195fcb0579b3"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("672c9407-72ae-4d3a-88df-94b73d81298d"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("67c31d6e-e163-482e-8a4f-db266425d251"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("73da67f8-acc5-4d44-81e2-3b58decf3e5d"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("74b515ee-003a-4e61-a65c-78b745b6f2d8"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("75a3b42f-c0e8-46b8-93d1-44bcf2abe806"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("79de3d2e-cbcb-4cda-8ff7-d5123c653d47"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("7ae9925a-9597-4a10-a73f-c667d9a67f64"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("7b7f9f7c-8c05-4c19-861d-e8449576b940"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("7e9342aa-9ffd-41f1-9f6f-ab1ce04c1e8e"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("7f8a5349-5ea9-4c1a-ac6c-ef65cc1ead29"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("83309cbf-5f25-47ff-bf48-216f2ec525d4"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("8382b6e9-b3d3-476d-b8bf-66a7b3631fcb"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("8de905c9-c765-4e4e-aadb-8bb7b24e5438"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("930e68ee-8ce3-4e07-9045-1216fe513224"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("9477cdbb-0a84-4560-99e5-9a68b882d30c"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("975817cd-0d79-463b-9f5c-b1e59f88754f"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("976a5c6c-2e7c-4d54-9a53-24c0b37a5383"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("97914dca-7674-4b4e-8391-0073760cbec2"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("9913934f-7949-45e3-be68-727e1f85875d"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("99d82816-bfd5-47e6-8cd7-4a8b3e3c596c"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("9b7338f9-25d9-4d0a-87e9-493300953aec"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("9c175577-761e-495f-935b-56442c4ef234"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("9ce41b69-6d5e-4de2-b7d6-2e380d5cad1a"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("9ee7521d-9540-40af-9806-30b6c880ff91"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a19e18b0-f63e-4869-89e5-195dbbce97e3"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a499e729-221a-4965-888d-ed9c575fa35e"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("ad0b01c5-485e-4f60-9e08-c1c86b8ab7a7"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("b1f95e74-dca4-41d5-b575-8ce7d8776106"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("b757ef05-599e-44fb-a033-a44da5a62716"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("b96659af-5ebf-44cc-866e-547467bf4f69"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("bb43277f-19b0-40d2-bc7f-2a13f6747052"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("bc6f2c12-8301-46d3-87a9-9558c394b351"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("bfc79fb1-aac0-48d9-92a7-af3596769f12"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("cf0629ca-e41a-45e9-8bd3-65fa07f76ae3"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("d0e93c5e-2785-4d4e-9e02-7ed9c837b0a9"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("d12dc078-1967-4f9c-b49e-e1bc62f459d3"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("d3990463-d5d6-4f89-a6d8-52ef4ac843c8"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("d3abb9d2-1559-4c07-a874-d586b1bb44d6"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("d5fb82ca-cf51-4d6f-8599-a577adced8ac"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("d70edd38-0036-459e-a88d-01370efb0548"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("d73c492f-ffbc-4ae9-80bc-929d5612258e"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("db3c8e78-69fa-477c-9c3d-236cc3f018b2"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("dd64064f-bfc0-4e7b-a20a-06438ea57204"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("ddd1accd-dd6d-43bc-be0c-d13277d0cb0d"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("ddd7facf-05f0-4545-8768-1050bfb7d3f9"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("e33b6ab9-6479-44bd-9cef-309c3fa25c1b"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("e7656bf4-ca7b-422f-adc1-b6a52121c215"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("e848fc47-5e05-4b1a-a2be-80389d9c6892"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("ea9f282a-9e13-4616-877c-5c81f436fd71"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("ebba669a-cf70-4a24-b4ff-5f9b300242ec"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("ef459bdd-5613-4764-bb4b-bdd4931a7512"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("ef599607-5684-404e-8964-92b6511cafc2"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f08766c5-584f-4611-8be3-da436a7a96b6"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f4423668-cb92-42a3-a3f3-94e8ce5d6915"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f7b85049-9889-422c-91fc-879677ed8b53"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("fa632855-998a-4c2a-a8a5-c5002ca8bfb2"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("fb804427-a8da-458d-ae76-4350c92c53ed"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("fd594d9f-7b61-4a0c-9b02-2f4cf6193e8e"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("fd969b4a-da14-4370-9614-505970972c91"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("fe795d37-c21c-4dc1-a7a5-48e7e4bd4987"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("ffc0fbaa-e84e-4a43-95f5-7bbbc9ac2edb"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("0381f4de-2df1-4ea8-9709-c22bb982d87b"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("06188f4c-c990-4840-8d70-6aa2fc702b8c"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("06f65e0f-fd1e-427f-bc71-69ac4aae26ec"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("075be393-82d8-4053-a824-b415e8ff457a"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("07960376-aca8-4de6-92af-c5d7a32bc2f1"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("07a8b13e-3285-420d-93d0-102f6e79dcc4"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("07b93164-df72-4222-9387-6763c9a633a8"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("0bcecf97-9c8d-4ea4-9376-118cdd0e2acf"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("0cfbfd8d-31b3-4ce2-adb1-df6ec51390e7"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("205cc739-aaae-4260-a9c9-1b3b6d8e8fde"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("215d5827-4c18-4e47-86fc-e9dada62aa13"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("2322697a-711b-4b64-9343-9d9ab7cb08a0"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("267bbf07-3804-4198-bfe6-7fcaaa920d75"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("280623a8-8538-4fe1-85c1-5f0e16687c64"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("2c84fee3-4ac1-45f0-98c2-ae071fb6ee1b"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("2f1d6224-f422-4181-b51f-04d2956e7ed6"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("3108f154-0448-4596-bb44-4c4454979c33"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("33adfc4b-886a-490e-a1e1-84d788caba94"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("3403f93a-cca9-4d30-8729-8f6c36eed868"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("34c4689c-b06a-4983-b117-a91a4da95e17"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("36110429-73f4-48c5-b431-bcbeae044da1"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("3a2836b6-f413-4fa0-be92-c40a929804ea"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("42c16b8d-30f6-41a9-a8f5-139a099e4c5f"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("43af42f2-a4a6-4ab9-b88c-9c6c98be72ca"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("46c33940-9b79-4583-ab49-7a45bc3361ba"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("48116ed4-22cc-4389-b07b-99edc996c80f"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("4934b112-7e8f-43e4-a1a8-6a80dd22e7db"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("4b322493-3bca-4556-9725-4c7c0e442de8"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("4d227097-40ba-4f5b-9b46-9c11febddcfe"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("53013957-6d13-4c3f-8cc2-2b8597e83b85"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("54eaffea-ccaa-4cfd-906b-f92d73aff7f5"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("559d0763-11f0-462e-a09f-d2b2e16c31c8"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("5ab3855d-aea0-45d5-a96e-e0e3eaec4b57"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("5d390506-1c65-4588-b0c2-f21f18480b8d"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("5efb83f0-4787-47e9-b35c-aafcf07f00d9"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("5f0f7811-ed1b-4cee-b21a-3529c951b431"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("5fae555f-acc5-43dc-b194-05f75dc5cf50"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("60a10652-1374-4734-8296-e7bd3b42b5b4"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("65616998-0a22-4d61-9fd7-e9bc710b5d51"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("65dcd295-8419-4707-a386-69ebeb13d97a"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("6a0662f7-1781-47a4-b241-5ac11cd9c0da"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("6aa565b7-a236-4ed5-8d79-4a28c6bbb277"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("6f405f8b-8a0a-4dff-8dba-76bee9019df2"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("6f82d9e5-04a8-4625-9a81-16c209ce9bd7"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("74d942a7-0f06-46f9-bfc7-fefe7c2fb63c"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("751f57b6-b681-417f-a52c-bdd3c13eaa89"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("77e2793d-cde6-4028-8201-8fffbd1eb7f6"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("7be2e05b-ddd4-4190-bd49-e29efc5399d2"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("7da732b3-902f-4a45-adc5-8b8f4a45d243"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("7e1982b4-80a0-457e-b03b-70183152aebd"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("7f0fc5fb-c71e-4b4d-8a36-9cdc9d60301e"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("7ff87bf3-b607-4aa8-9d88-5c1e58b5e8b2"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("8024fa2a-5afe-4c30-9200-715dd98f8eda"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("87d96942-4fe4-4cf6-a268-9570e0a74720"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("8eb45d6f-818f-42f9-9abf-ee80b1f433e4"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("90cac223-9150-4889-b181-1abd9230878a"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("9104808c-a173-47ff-a39d-a28fdda080f1"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("9407c492-137d-4a7a-997f-9ff3f57f3823"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("9e88b0b0-61c0-4512-9e83-a370e5337736"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("9f1ee65a-e34a-4a5b-b9fb-7bff1efcb498"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("a0202664-50f2-45b2-bf40-69a87e91394f"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("a0778bf4-fa45-490f-a731-553767485ca7"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("a1d2d8e0-50fa-4b44-ab2d-61c21c121331"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("a70cf61a-ddf2-43aa-8461-ebe6a3e84dfb"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("a72de33d-122e-43f0-bc66-f09cbd088d47"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("a94eea2e-dcd6-442c-b933-6e1887d27431"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("aad704b4-e7f3-47ab-85ba-1ad534bf2156"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("ad005b98-bc60-4899-9698-674f42f58ad0"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("b025bd7a-07c7-4c8f-9fdf-c39f655d49f4"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("b16b0bf6-10d9-4fd1-bc46-81c1a1c36004"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("b19dd793-d70b-4f44-ae4b-7ceb9acaec6b"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("b361e17b-6932-4cd9-8867-dd9db97b9b07"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("b48500d3-f158-4f7a-9066-e68ef62856c0"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("b63ac7e9-cf73-48e3-b8f5-7d1a6f30aa20"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("b86f8a7c-c953-4c7c-840e-22661454cbcd"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("be2e5eab-4ba6-41fc-bee8-bfb81ee0bb6a"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("be513a88-1896-45ed-9e0f-a361174c5b68"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("bf312263-02ec-4d1b-8698-591ce5fcf97b"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("c0a26908-c300-4cda-8890-eb67ddb91c36"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("c2997ea7-b6bb-4143-a2f8-722cd7391e2a"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("c453ec44-36e4-4279-a609-2fa825f65d5f"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("c91cf61b-1aaf-4a0e-bb06-fedc57a7a3ed"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("cba0b4b9-0fa1-4b0a-ae2a-ae6575b6698d"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("d0d9bd04-c3e0-4f71-85c8-1bf63e8fb1b1"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("d1905e97-53b9-4eb0-93f6-4e2127057695"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("d210c79a-1c7e-4496-bb04-eaf5a42e2b9f"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("d3b97b82-cca0-4794-937e-c6e6052e9a96"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("d62a2a0e-17e5-4403-bbec-3f30fbf3e257"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("dcd98293-b2a9-4b12-8ed9-03f6b21cafc9"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("dda2c2ab-22cf-453f-a63f-f673350e9f60"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("df9e81d3-aa61-4ac2-a231-bc8fe6840e0e"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("e3216f86-4a89-42ab-88a9-d8f5306a69ab"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("e3cecc2b-8815-41ee-8d70-60dc6cf08108"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("e90a9b26-a33c-4fd5-a63a-351890a48a21"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("ea6b5032-e15b-4006-be18-f005dc0a5708"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("f3e06554-625e-4700-94e9-d882970cb5d7"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("f50cc541-5f07-4880-8d08-4c5f5da8b04e"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("f9e3d3e5-8e92-44e3-bc45-2020d333d773"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("fb5024d4-dc34-41d3-a9cb-c46f60b1c8c5"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("fc976bc0-596d-48cd-a6e0-8c4e75a94d32"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("fed1edf6-12a6-41e5-9c29-c53eb3d9ef3e"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("ff9cc286-092e-4536-a8e4-46635dcc7327"));

            migrationBuilder.DeleteData(
                table: "Allowances",
                keyColumn: "Id",
                keyValue: new Guid("ffa04673-a956-45f8-b2dc-9919001a9ac4"));
        }
    }
}
