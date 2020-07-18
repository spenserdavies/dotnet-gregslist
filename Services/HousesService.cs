using System;
using System.Collections.Generic;
using fullstack_gregslist.Models;
using fullstack_gregslist.Repositories;

namespace fullstack_gregslist.Services
{
    public class HousesService
    {
        private readonly HousesRepository _repo;
        public HousesService(HousesRepository repo)
        {
            _repo = repo;
        }
        internal IEnumerable<House> GetAll()
        {
            return _repo.GetAll();
        }

        internal IEnumerable<House> GetByUserId(string userId)
        {
            return _repo.GetHousesByUserId(userId);
        }

        internal House GetById(int id)
        {
            House foundHouse = _repo.GetById(id);
            if(foundHouse == null)
            {
                throw new Exception("Invalid Id");
            }
            return foundHouse;
        }

        internal House Create(House newHouse)
        {
            return _repo.Create(newHouse);
        }

        internal House Edit(House houseToUpdate, string userId)
        {
            House foundHouse = GetById(houseToUpdate.Id);
            if(foundHouse.UserId != userId && foundHouse.Price < houseToUpdate.Price)
            {
                if(_repo.BidOnHouse(houseToUpdate))
                {
                    foundHouse.Price = houseToUpdate.Price;
                    return foundHouse;
                }
                throw new Exception("Could not Bid on that House");
            }
            if(foundHouse.UserId == userId && _repo.Edit(houseToUpdate, userId))
            {
                return houseToUpdate;
            }
            throw new Exception("You Can't Edit That!");
        }

        internal object Delete(int id, string userId)
        {
            House foundHouse = GetById(id);
            if(foundHouse.UserId != userId)
            {
                throw new Exception("This is not your house!");
            }
            if(_repo.Delete(id, userId))
            {
                return "Successfully Deleted.";
            }
            throw new Exception("uh oh spaghetti-o :p");
        }
    }
}