using Microsoft.AspNetCore.Mvc;
using RedDown.ViewModels;
using RedDown.Data;
using RedDown.Data.Entities;
using AutoMapper;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RedDown.Controllers
{
    public class RegistryQueryController : Controller
    {
        private readonly IRedDownRepository _repository;
        private readonly ILogger<RegistryQueryController> _logger;
        private readonly IMapper _mapper;

        public RegistryQueryController(IRedDownRepository repository, ILogger<RegistryQueryController> logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult Registries()
        {
            var records = _mapper.Map<IEnumerable<RegistryDown>, IEnumerable<RegistryDownViewModel>>(_repository.GetRedDownRegistrys());

            return View(records);
        }
    }
}
