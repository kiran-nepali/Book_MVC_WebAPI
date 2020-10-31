using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using MVCapi.DataRepository;
using MVCapi.Models;

namespace MVCapi.Controllers{
    
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController:ControllerBase{

        private readonly IBookRepo _repo;

        public BooksController(IBookRepo repo){
            _repo = repo;
        }

        [HttpGet]
        public ActionResult <IEnumerable<Book>> GetAllBooks(){
            return Ok(_repo.GetAllBooks());
        }
        
        [HttpGet("{id}")]
        public ActionResult <Book> GetBookById(int id){
            return Ok(_repo.GetBookById(id));
        }
    }
}