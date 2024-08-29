﻿using HiddenVilla_Client.Service.IService;
using Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace HiddenVilla_Client.Service
{
    public class HotelRoomService : IHotelRoomService
    {


        private readonly HttpClient _client;

        public HotelRoomService(HttpClient client)
        {
            _client = client;
        }

        public Task<HotelRoomDTO> GetHotelRoomById(int roomId, string checkInDate, string checkOutDate)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<HotelRoomDTO>> GetHotelRooms(string checkInDate, string checkOutDate)
        {

            var response = await _client.GetAsync($"api/hotelroom?checkIn={checkInDate}&checkOut={checkInDate}");
            var content = await response.Content.ReadAsStringAsync();
            var rooms = JsonConvert.DeserializeObject<IEnumerable<HotelRoomDTO>>(content);
            return rooms;
        }
    }
}
