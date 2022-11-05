﻿using Floricultura.Domain.DTOs.Produto;
using Floricultura.Domain.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.Net;

namespace Floricultura.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProdutoController : Controller
    {
        private readonly IProdutoService _produtoService;
        public ProdutoController(IProdutoService produtoService)
        {
            _produtoService = produtoService;
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public async Task<IActionResult> Post([FromForm] ProdutoRequest request, CancellationToken cancellationToken = default)
        {
            await _produtoService.IncluirAsync(request, cancellationToken);
            return Ok(HttpStatusCode.Created);
        }
    }
}