using MenuItemListingWebApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MenuItemListingWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MenuItemController : ControllerBase
    {
        [HttpGet]
        public List<MenuItem> GetItem()
        {
            List<MenuItem> MenuList = new List<MenuItem>()
            {
                new MenuItem() {Id=1, Name="Dosa", FreeDelivery=false, Price=40, DateOfLaunch=new DateTime(2022,06,07),Active=true },
                new MenuItem() {Id=2, Name="Chapathi", FreeDelivery=false,Price=20,DateOfLaunch=new DateTime(2022,06,08),Active=false},
                new MenuItem() {Id=2, Name="Idly", FreeDelivery=false, Price=10,DateOfLaunch=new DateTime(2022,06,09),Active=false}
            };
            return MenuList;
        }

        [HttpGet("{id}")]
        public MenuItem GetItemById(int id)
        {
            List<MenuItem> MenuList = new List<MenuItem>()
            {
                new MenuItem() {Id=1, Name="Dosa", FreeDelivery=false, Price=40, DateOfLaunch=new DateTime(2022,06,07),Active=true },
                new MenuItem() {Id=2, Name="Chapathi", FreeDelivery=false,Price=20,DateOfLaunch=new DateTime(2022,06,08),Active=false},
                new MenuItem() {Id=2, Name="Idly", FreeDelivery=false, Price=10, DateOfLaunch=new DateTime(2022,06,09),Active=false}

            };
            MenuItem obj = MenuList.SingleOrDefault(item => item.Id == id);
            return obj;
        }
    }
}
