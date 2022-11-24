using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheMenu.Domain.DTO;
using TheMenu.Domain.Interfaces.Repositories;

namespace TheMenu.Application.Recipe.Queries
{
    public record GetRecipeByCategoryIdQuery (Guid Id) : IRequest<IEnumerable<RecipeDTOQuery>>
    {
    }

    internal class GetRecipeByCategoryIdQueryHandler : IRequestHandler<GetRecipeByCategoryIdQuery, IEnumerable<RecipeDTOQuery>>
    {
        private readonly IUnitOfWork _dbContext;
        public GetRecipeByCategoryIdQueryHandler(IUnitOfWork dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<RecipeDTOQuery>> Handle(GetRecipeByCategoryIdQuery request, CancellationToken cancellationToken)
        {
            var result = await _dbContext.RecipeRepository.GetAllRecipesByCategory(request.Id);
            
            if (result != null) {
                var resultList = result.Select(x => new RecipeDTOQuery(x));
                return resultList;
            }

            return null;
        }
    }
}
