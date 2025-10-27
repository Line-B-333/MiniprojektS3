using BlogDAO.Library.Interfaces;
using BlogDAO.Library.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper; //Added Dapper package. Made 'Query<Author>(query)' work in GetAllAuthors

namespace BlogDAO.Library.sqlserver;

public class AuthorDAO : BaseDAO, IAuthorDAO
{
    //base (connectionstring) kalder konstruktøren i BaseDAO. Det betyder super.
    //Det er nødvendigt fordi BaseDAO ikke har en tom konstruktør.
    //Contructor which passed the connection string to the base class
    public AuthorDAO(string connectionstring) : base(connectionstring)
    {
        
    }

    public int CreateAuthor(Author author)
    {
        throw new NotImplementedException();
    }

    public bool DeleteAuthor(int id)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Author> GetAllAuthors()
    {
        //public <IEnumerable>Author GetAll ()​

        var query = "SELECT * FROM Author";
        using var connection = CreateConnection();
        return connection.Query<Author>(query).ToList();
    }

    public Author? GetOneAuthor(int id)
    {
        throw new NotImplementedException();
    }

    public bool UpdateAuthor(Author author)
    {
        throw new NotImplementedException();
    }
}

