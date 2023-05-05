﻿using FleetFlow.Service.DTOs.Carts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FleetFlow.Service.Interfaces
{
    public interface ICartService
    {
        ValueTask<CartItemResultDto> AddItemAsync(long productId, int amount);

        /// <summary>
        /// Removes cartitem by entering cartItemId
        /// </summary>
        /// <param name="cartItemId"></param>
        /// <returns></returns>
        /// <exception cref="FleetFlowException"></exception>
        ValueTask<object> RemoveItemAsync(long cartItemId);

        /// <summary>
        /// Change amount of cartItem.amount with input amount
        /// </summary>
        /// <param name="cartItemId"></param>
        /// <param name="amount"></param>
        /// <returns></returns>
        ValueTask<object> UpdateItemAsync(long cartItemId, int amount);
    }
}
