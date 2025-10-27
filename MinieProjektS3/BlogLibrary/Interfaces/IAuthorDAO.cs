using BlogDAO.Library.Model;

namespace BlogDAO.Library.Interfaces
{
    public interface IAuthorDAO
    {
        Author? GetOneAuthor(int id); //Returnere null hvis ikke fundet. Dette giver en advarsel ved brug af nullable reference types 'Author?'
        IEnumerable<Author> GetAllAuthors();
        bool DeleteAuthor(int id);
        bool UpdateAuthor(Author author);
        int CreateAuthor(Author author); //Return den nøgle der er oprettet
    }
}