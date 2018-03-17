using System.Linq;
using System.Threading.Tasks;
using FluentAssertions;
using Github.Users.Common.Concrete;
using Xunit;

namespace Github.Users.Common.IntegrationTests.Concrete
{
    public class UsersRepositoryTests
    {
        private UsersRepository _sut;

        [Fact]
        public async Task GetAll_ReturnsUsers()
        {
            // arrange
            _sut = new UsersRepository();

            // act
            var result = await _sut.GetAllAsync();

            // assert
            result.Should().NotBeNull("Returned collection shouldn't be null");
            result.Any().Should().BeTrue("Colection should contains elements");
        }
    }
}
