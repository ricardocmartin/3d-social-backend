using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using _3dSocial.Application.DTO;
using Xunit;

namespace _3dSocial.Api.Test
{
    public class DemandControllerTest : TestBase
    {
        public DemandControllerTest()
        {
            _controllerPath = "/api/Demand";
        }


        [Fact]
        public async Task TestPost()
        {
            if (string.IsNullOrEmpty(_controllerPath))
            {
                Assert.True(true);
                return;
            }

            //Arrange
            int projectId = new Application.Facades.ProjectFacade().List().Take(1).FirstOrDefault().Id;

            var demandDTO = new DemandDTO() { 
                AllowShowInfo = true,
                CenterAddressNumber = "100",
                CenterCity = "São Paulo",
                CenterDistrict = "Vila teste",
                CenterDocument = "00.000.0000/00-0",
                CenterId = 0,
                CenterName = "Centro do teste",
                CenterStreet = "Rua de teste",
                CenterZipCode = "00000-000",
                Ddd = "011",
                DemandId = 0,
                Email = "teste@email.com",
                Observations = "teste teste teste",
                Phone = "988887777",
                ProjectId = projectId,
                State = "SP",
                TotalDelivered = 0,
                TotalNeed = 500
            };
            var payload = JsonSerializer.Serialize(demandDTO); ;
            HttpContent c = new StringContent(payload, Encoding.UTF8, "application/json");
            
            // Act
            var response = await _client.PostAsync(_controllerPath + "/1", c);

            // Assert
            response.EnsureSuccessStatusCode();
            Assert.NotNull(response);
        }
    }
}
