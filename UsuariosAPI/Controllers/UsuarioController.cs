﻿using Microsoft.AspNetCore.Mvc;
using UsuariosAPI.Data.Dtos;

namespace UsuariosAPI.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class UsuarioController : ControllerBase
    {
        [HttpPost]
        public IActionResult CadastraUsuario(CreateUsuarioDto dto)
        {
            throw new NotImplementedException();
        }
    }
}
