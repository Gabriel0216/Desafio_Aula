using System;
using System.Threading.Tasks;
using Desafio_Aula.Server;
using Desafio_Aula.Shared;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

[ApiController]
[Route("api/[controller]")]
public class ProdutoController : Controller{
    private readonly AppDbContext banco;

    public ProdutoController(AppDbContext db){
        this.banco = db;
    }

    [HttpGet]
    [Route("List")]
    public async Task<IActionResult> Get(){
        var produtos = await banco.Produtos.ToListAsync();
        return Ok(produtos);
    }

    [HttpGet]
    [Route("GetById/{id}")]
    public async Task<IActionResult> Get([FromRoute] int id){
        var produtos = await banco.Produtos.FindAsync(id);
        return Ok(produtos);
    }

    [HttpPost]
    [Route("Create")]
    public async Task<ActionResult> Post([FromBody] Produto prod){
        try
        {
            var novoProduto = new Produto{
                Nome = prod.Nome,
                Descricao = prod.Descricao,
                Preco = prod.Preco
            };

            banco.Add(novoProduto);
            await banco.SaveChangesAsync();
            return Ok();
        }
        catch (Exception e)
        {
            return View(e);
        }
    }

    [HttpPut]
    [Route("Edit/")]
    public async Task<IActionResult> Put([FromBody] Produto prod){
        if(!ModelState.IsValid){
            return BadRequest(ModelState);
        }

        banco.Entry(prod).State = EntityState.Modified;

        try
        {
            await banco.SaveChangesAsync();
            return Ok();
        }
        catch (Exception e)
        {
            return View(e);
        }
    }

    [HttpDelete]
    [Route("Delete/{id}")]
    public async Task<IActionResult> Delete([FromRoute] int id){
        var produto = await banco.Produtos.FindAsync(id);
        if(produto == null){
            return NotFound();
        }

        banco.Produtos.Remove(produto);
        await banco.SaveChangesAsync();
        return Ok();
    }

}