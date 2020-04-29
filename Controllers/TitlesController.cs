using TitleSearchApi.Models;
using TitleSearchApi.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using MongoDB.Bson;

namespace TitleSearchApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TitlesController : ControllerBase
    {
        private readonly TitleService _titleService;

        public TitlesController(TitleService titleService)
        {
            _titleService = titleService;
        }

        [HttpGet]
        public ActionResult<List<Title>> Get() =>
            _titleService.Get();

        [HttpGet("{id:length(24)}", Name = "GetTitle")]
        public ActionResult<Title> Get(string id)
        {
            var title = _titleService.Get(id);

            if (title == null)
            {
                return NotFound();
            }

            return title;
        }
    }
}