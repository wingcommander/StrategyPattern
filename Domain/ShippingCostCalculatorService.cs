﻿using System;

public class ShippingCostCalculatorService
{

   

    public double CalculateShippingCost(Order order, Func<Order, double> shippingCostStrategy)
    {
        return shippingCostStrategy(order);
    }
}