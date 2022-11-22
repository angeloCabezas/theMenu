using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TheMenu.Application.Recipe.Queries;

namespace TheMenu.Controllers
{
    [ApiController]
    public class RecipeController : Controller
    {
        private readonly IMediator _mediator;
        public RecipeController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [Route("{id}")]
        public ActionResult GetRecipeById(Guid id)
        {
            var result = _mediator.Send(new GetRecipeByIdQuery(id));
            return Ok(result);
        }

    }
}
