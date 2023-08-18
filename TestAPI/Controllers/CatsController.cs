using Microsoft.AspNetCore.Mvc;
using TestAPI.Enums;
using TestAPI.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TestAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CatsController : ControllerBase
    {
        private readonly List<Cat> cats;
        public CatsController()
        {
            Owner owner1 = new Owner(1, "Vasile");
            Owner owner2 = new Owner(2, "Mihai");
            Owner owner3 = new Owner(3, "Adrian");
            Owner owner4 = new Owner(4, "Roxana");

            List<Cat> myCatsList = new List<Cat>();
            Cat cat1 = new Cat(1, "Tom", EyeColors.Hazel, owner1);
            Cat cat2 = new Cat(2, "Maronica", EyeColors.Gray, owner3);
            Cat cat3 = new Cat(3, "Cole", EyeColors.Gray, owner2);
            Cat cat4 = new Cat(4, "Astrid", EyeColors.Blue, owner4);

            myCatsList.Add(cat1);
            myCatsList.Add(cat2);
            myCatsList.Add(cat3);
            myCatsList.Add(cat4);

            cats = myCatsList;
        }

        // GET: api/<CatsController>
        [HttpGet]
        public List<Cat> Get()
        {
            return cats;
        }

        // GET api/<CatsController>/5
        [HttpGet("{id}")]
        public Cat Get(int id)
        {
            var cat = cats.FirstOrDefault(cat => cat.Id == id);
            return cat;
        }

        // POST api/<CatsController>
        [HttpPost]
        public List<Cat> Post([FromBody] CatForPost model)
        {
            Owner owner5 = new Owner(model.OwnerId, model.OwnerName);

            Cat cat5 = new Cat(model.Id, model.Name, model.EyeColors, owner5);

            List<Cat> newCatsList = cats;
            newCatsList.Add(cat5);

            return newCatsList;
        }
        //works with something like this in the body: {
        //                                            "id": 10,
        //                                            "name": "Fluffy",
        //                                            "eyeColors": "3",
        //                                            "ownerId": 7,
        //                                            "ownerName": "Ionut"
        //                                            }

        // PUT api/<CatsController>/5
        [HttpPut("{id}")]
        public List<Cat> Put(int id, [FromBody] string value)
        {
            foreach (var cat in cats)
            {
                if (id == cat.Id)
                {
                    cat.Name = value;
                }
            }
            return cats;
        }

        // DELETE api/<CatsController>/5
        [HttpDelete("{id}")]
        public List<Cat> Delete(int id)
        {
            cats.RemoveAll(cat => cat.Id == id);
            return cats;
        }
    }
}
