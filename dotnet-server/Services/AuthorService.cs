// Services/AuthorService.cs

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Grpc.Core;
using Microsoft.Extensions.Logging;

namespace AuthorService
{
    public class AuthorServerService : AuthorService.AuthorServiceBase // Base class for server-side implementations of AuthorService
    {
        private readonly ILogger<AuthorServerService> _logger;
        // private static readonly Dictionary<string, Int32> customerTrustedCredit = new Dictionary<string, Int32>()
        // {
        //     {"id0201", 10000},
        //     {"id0417", 5000},
        //     {"id0306", 15000}
        // };

        Authors _authors = new Authors();

        // List<Author> _authors = new List<Author>();
        // Author a1 = new Author();

        public AuthorServerService(ILogger<AuthorServerService> logger)
        {
            _logger = logger;
        }

        public override Task<Authors> GetAuthors(EmptyRequest request, ServerCallContext context)
        {
            return Task.FromResult(_authors);
        }

        public override Task<Author> GetAuthorById(AuthorQuery request, ServerCallContext context)
        {
            return Task.FromResult(new Author
            {
                Name = "2"
            });
        }

        public override Task<EmptyResponse> CreateAuthor(Author request, ServerCallContext context)
        {
            return Task.FromResult(new EmptyResponse());
        }
    }
}