namespace PlaceHoldr.Web.Tests;

public class WebTests : IClassFixture<WebApplicationFactory<Program>> {
	[Fact]
	public async Task Status_Endpoint_Returns_OK() {
		var factory = new WebApplicationFactory<Program>();
		var client = factory.CreateClient();
		var response = await client.GetAsync("/status");
		response.EnsureSuccessStatusCode();
	}
}