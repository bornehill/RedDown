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
    public class AppController : Controller
    {
        private readonly IRedDownRepository _repository;
        private readonly ILogger<AppController> _logger;
        private readonly IMapper _mapper;

        public AppController(IRedDownRepository repository, ILogger<AppController> logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Registry()
        {
            ViewBag.ActionName = "Registrar";
            return View(new RegistryDownViewModel());
        }

        [HttpGet("Registry/{id:int}")]
        public IActionResult Registry(int id)
        {
            var result = _mapper.Map<RegistryDown, RegistryDownViewModel>(_repository.GetRedDownById(id));
            ViewBag.ActionName = "Editar";
            return View(result);
        }

        [HttpPost]
        public IActionResult Registry(RegistryDownViewModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var registry =_mapper.Map<RegistryDownViewModel, RegistryDown>(model);

                    _repository.AddEntity(registry);
                    if (_repository.SaveAll())
                    {
                        ModelState.Clear();
                        ViewBag.registryMessage = "Registro realizado satisfactoriamente.";
                    }

                }
                else
                {
                    ViewBag.registryMessage = "Revise el formulario de registro y capture la información solicitada correctamente.";
                }
                ViewBag.ActionName = "Registrar";
                return View();
            }
            catch (Exception ex)
            {
                _logger.LogError($"Failed to save a new registry down : {ex.Message}");
            }
            return BadRequest($"Failed to save a new registry down");
        }

        [HttpPost("Registry/{id:int}")]
        public IActionResult Registry(int id, RegistryDownViewModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var registry = _mapper.Map<RegistryDownViewModel, RegistryDown>(model);
                    registry.Id = id;
                    _repository.UpdateRegistry(registry);
                    if (_repository.SaveAll())
                    {
                        ModelState.Clear();
                        ViewBag.registryMessage = "Registro actualizado satisfactoriamente.";
                    }

                }
                else
                {
                    ViewBag.registryMessage = "Revise el formulario de registro y capture la información solicitada correctamente.";
                }
                ViewBag.ActionName = "Registrar";
                return View();
            }
            catch (Exception ex)
            {
                _logger.LogError($"Failed to update a registry down : {ex.Message}");
            }
            return BadRequest($"Failed to update a registry down");
        }
    }
}
