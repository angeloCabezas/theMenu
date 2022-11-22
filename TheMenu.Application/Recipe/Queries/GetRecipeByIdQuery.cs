using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheMenu.Domain.DTO;
using TheMenu.Domain.Interfaces.Repositories;

namespace TheMenu.Application.Recipe.Queries
{
    public record GetRecipeByIdQuery(Guid Id) : IRequest<RecipeDTOQuery>
    {
    }

    public class GetRecipeByIdQueryHandler : IRequestHandler<GetRecipeByIdQuery, RecipeDTOQuery>
    {
        private readonly IUnitOfWork _dbcontext;
        public GetRecipeByIdQueryHandler(IUnitOfWork dbcontext)
        {
            _dbcontext = dbcontext;
        }
        public Task<RecipeDTOQuery> Handle(GetRecipeByIdQuery request, CancellationToken cancellationToken)
        {
            var result = _dbcontext.recipeRepository.GetRecipe(request.Id);
            var dtoResult = new RecipeDTOQuery(result);
            return Task.FromResult(dtoResult);
        }
    }
}
