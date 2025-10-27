namespace BlogDAO.Library.Model;

public class Author
{
    #region Properties
    public int Id { get; set; }
    public string Email { get; set; }
    public string PasswordHash { get; set; }
    public string BlogTitle { get; set; }

    #endregion

    #region Construtor
    public Author(int id, string email, string passwordHash, string blogTitle)
    {
        Id = id;
        Email = email;
        PasswordHash = passwordHash;
        BlogTitle = blogTitle;
    }
    public Author(string email, string passwordHash, string blogTitle)
    {
        Email = email;
        PasswordHash = passwordHash;
        BlogTitle = blogTitle;
    } 
    #endregion
}