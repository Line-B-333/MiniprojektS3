using BlogDAO.Library.Interfaces;
using BlogDAO.Library.sqlserver;

namespace BlogSharp.TestProject
{
    public class Tests
    {
        private const string connectionString = "Data Source=localhost;Initial Catalog=BlogSharp;User ID=sa;Password=@12tf56so;Trust Server Certificate=True";
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void GetAll_ReturnThreeAuthors()
        {
            // - Arrange - //
            //Insert test data into the database

            //Bruger en interface, kan den skiftes ud med en stub 
            //IAurthorDAO aurthorDAO = new AurthorDAOStub(connectionString);
            IAuthorDAO authorDAO = new AuthorDAO(connectionString);

            // - Act - //
            var authors = authorDAO.GetAllAuthors();

            // - Assert - //
            //Assert.That(authors.Count(), Is.EqualTo(3));
            Assert.That(3, Is.EqualTo(authors.Count()));
        }
    }
}