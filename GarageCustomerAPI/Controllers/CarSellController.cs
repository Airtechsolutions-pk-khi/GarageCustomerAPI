﻿using BAL.Repositories;
using DAL.DBEntities;
using DAL.DBEntities2;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace GarageCustomerAPI.Controllers
{
    /// <summary>
    /// Sell Car
    /// </summary>
    [RoutePrefix("api")]
    public class CarSellController : ApiController
    {
        /// <summary>
        /// Sell Car
        /// </summary>
        carSellRepository carSellRepo;
        /// <summary>
        /// Sell Car
        /// </summary>
        public CarSellController()
        {
            carSellRepo = new carSellRepository(new Garage_Entities());
        }

        /// <summary>
        /// Settings for Carsell
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("carsellsetting/all")]
		[Authorize]
		public async Task<CarSellRsp> CarSellList()
        {
            return await carSellRepo.GetCarSellList(null);
        }

        /// <summary>
        /// Add Car Sell
        /// </summary>
        /// <param name="carSell"></param>
        /// <returns></returns>
        [Route("sell/car")]
		[Authorize]
		public async Task<CarSellInsertRsp> AddCarSell(CarSellList carSell)
        {
            var rsp = carSellRepo.InsertCarSell(carSell);
            var rspcarsell = await carSellRepo.GetCarSellList(carSell.CarSellID);
            rsp.CarSell = rspcarsell.CarSellList.FirstOrDefault();
            return rsp;
        }

        /// <summary>
        /// Edit Car Sell 
        /// </summary>
        /// <param name="carSell">Images: Delete Images will be sent with Status ID 2, and for new Images Base64 Image object is required</param>
        /// <returns></returns>
        [Route("sell/car/edit")]
        [HttpPut]
		[Authorize]
		public async Task<CarSellInsertRsp> EditCarSell(CarSellList carSell)
        {
            var rsp = carSellRepo.InsertCarSell(carSell);
            var rspcarsell = await carSellRepo.GetCarSellList(carSell.CarSellID);
            rsp.CarSell = rspcarsell.CarSellList.FirstOrDefault();
            return rsp;
        }

        /// <summary>
        /// Add Car to Favourite
        /// </summary>
        /// <param name="obj">CarSellID for the Identity || Status Id (1 Add and 2 for Remove)</param>
        /// <returns></returns>
        [Route("favourite/car")]
		[Authorize]
		public Rsp FavouriteCar(CarFavouriteList obj)
        {
            return carSellRepo.InsertCarFavourite(obj);
        }

        /// <summary>
        /// Ads Car Sell
        /// </summary>
        /// <param name="carSell"></param>
        /// <returns></returns>
        [Route("sell/car/ads")]
		[Authorize]
		public async Task<CarSellRsp> AdsCarSell(CarSellAds carSell)
        {
            return await carSellRepo.GetCarSellAdsList(carSell);
        }
    }
}
