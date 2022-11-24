using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TheMenu.Application.Recipe.Queries;

namespace TheMenu.Controllers
{
    [ApiController]
    [Route("api/recipes")]
    public class RecipesController : Controller
    {
        private readonly IMediator _mediator;
        public RecipesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [Route("{id}")]
        public ActionResult GetRecipeById(Guid id)
        {
            var result = _mediator.Send(new GetRecipeByIdQuery(id));

            if(result == null) return NotFound();

            return Ok(result);
        }

        [HttpGet]
        public ActionResult GetRecipeByCategoryId(Guid categoryId,string? categoryName) {
            var result = _mediator.Send(new GetRecipeByCategoryIdQuery(categoryId));

            if (result == null) return NotFound();

            return Ok(result);
        }
    }
}
