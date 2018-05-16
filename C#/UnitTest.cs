[TestClass]
    public class ApiDataInterfaceControllerTest
    {
        #region Test create.

        /// <summary>
        /// Test create datainterface success and test connection success.
        /// </summary>
        /// <param name="filePath"></param>
        [DataTestMethod]
        [DataRow("DataInterface_Create_Success")]
        public void ApiDataInterfaceCreateSuccess(string filePath)
        {
            string result = RequestCongiguration("Create");

            string requestUrl = Path.Combine(Directory.GetCurrentDirectory(), "TestData", filePath + ".json");
            ApiDataInterfaceModelTest datainterfaceRequest = Com.Serializer.FromJsonFile<ApiDataInterfaceModelTest>(requestUrl);

            HttpClient client = new HttpClient();
            var httpContent = new StringContent(JsonConvert.SerializeObject(datainterfaceRequest), Encoding.UTF8, "application/json");
            var response = client.PostAsync(result, httpContent).Result;

            var json = response.Content.ReadAsStringAsync().Result;

            var objJson = Newtonsoft.Json.Linq.JObject.Parse(json).ToObject<ApiDataInterfaceResponseTest>();
            if (objJson.ResponseStatus.Status != APIStatus.Success)
            {
                ApiDataInterfaceResponseTest datainterfaceResponse = Com.Serializer.FromJson<ApiDataInterfaceResponseTest>(json);
                Assert.IsNotNull(datainterfaceResponse.ResponseStatus.Status);
            }

            Assert.AreEqual(objJson.ResponseStatus.Status, APIStatus.Success);
        }