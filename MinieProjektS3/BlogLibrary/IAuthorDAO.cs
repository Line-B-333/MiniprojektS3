using BlogDAO.Library.Model;

namespace BlogDAO.Library;

public interface IAuthorDAO
{
    Author GetOneAuthor(int id);
    IEnumerable<Author> GetAllAuthors();
    bool DeleteAuthor(int id);
    bool UpdateAuthor(Author author);
    int CreateAuthor(Author author); //Return den nøgle der er oprettet
}
