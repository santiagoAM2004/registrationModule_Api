using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using apiSAM.Models;
using Dapper;


namespace apiSAM.Controllers
{
    [ApiController]
    [Route("users")]
    public class UsersControllers:ControllerBase
    {
        private db database;
        public UsersControllers()
        {
            database = new db();
        }

        [HttpPost]
        public IActionResult Create(User users)
        {
            string query = $"INSERT INTO login(Names, LastNames, Password, DocumentID) VALUES ('{users.Names}', '{users.LastNames}', '{users.Password}', '{users.DocumentID}')";
            database.connection.Execute(query);
            return Ok();
        }

        [HttpGet]
        public ActionResult<IEnumerable<User>> Read()
        {
            IEnumerable<User> users = null;
            string query = "SELECT * FROM login";
            users = database.connection.Query<User>(query);
            return Ok(users);
        }
        [HttpPut("{Id}")]
        public IActionResult Update(int Id, User user)
        {
            string query = $"UPDATE login SET Names='{user.Names}', LastNames='{user.LastNames}', Password='{user.Password}', DocumentID='{user.DocumentID}' WHERE Id = '{Id}'";
            database.connection.Execute(query);
            return Ok();
        }

        [HttpDelete("{Id}")]
        public IActionResult Delete(int Id)
        {
            string query = $"DELETE FROM login WHERE Id = '{Id}'";
            database.connection.Execute(query);
            return Ok();
        }

    }
}