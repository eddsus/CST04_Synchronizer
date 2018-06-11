﻿using DataManagement.DataBases;
using SharedDataTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataManagement.SharedTypeConverter
{
    public class SharedConverter
    {

        public SharedDataTypes.Order ConvertToSharedOrder(DataBases.Order p)
        {
            return new SharedDataTypes.Order()
            {
                OrderId = p.ID_Order,
                DateOfOrder = p.DateOfOrder,
                DateOfDelivery = p.DateOfDelivery,
                Customer = ConvertToSharedCustomer(p.Customer),
                Status = ConvertToSharedOrderStatus(p.OrderStatus),
                Note = p.Note,
                Content = new List<SharedDataTypes.OrderContent>()
            };
        }

        public SharedDataTypes.Chocolate ConvertToSharedChocolate(DataBases.Chocolate choco)
        {
            return new SharedDataTypes.Chocolate
            {
                ChocolateId = choco.ID_Chocolate,
                Name = choco.Name,
                Description = choco.Description,
                Shape = ConvertToSharedShape(choco.Shape),
                Image = new Uri(choco.Image),
                Wrapping = ConvertToSharedWrapping(choco.Wrapping.First()),
                Ingredients = new List<Ingredient>()
            };

        }

         

        //private static List<SharedDataTypes.OrderContent> ConvertToSharedOrderContentList(List<DataBases.OrderContent> oc)
        //{
        //    List<SharedDataTypes.OrderContent> tempList = new List<SharedDataTypes.OrderContent>();
        //    foreach (var item in oc)
        //    {
        //        if (item.OrderContent_has_Chocolate.Count > 0)
        //        {
        //            //I'm a choclolate
        //            tempList.Add(new SharedDataTypes.OrderContentChocolate() {
        //                OrderContentId = item.OrderContent_has_Chocolate.i
        //            });
        //        } else
        //        {
        //            //I'm a package
        //        }
        //        tempList.Add(new SharedDataTypes.OrderContent() {

        //        });
        //    }
        //    return tempList;
        //}

        public SharedDataTypes.Ingredient ConvertToSharedIngredient(Ingredients DBIngredient)
        {
            return new Ingredient
            {
                IngredientId = Guid.Parse(DBIngredient.ToString()),
                Name = DBIngredient.Name,
                Description = DBIngredient.Description,
                Available = DBIngredient.Availability,
                Type = DBIngredient.Type,
                Price = DBIngredient.Price,
                UnitType = DBIngredient.UnitType,
                Modified = DBIngredient.ModifyDate

            };
        }

        private static SharedDataTypes.OrderStatus ConvertToSharedOrderStatus(DataBases.OrderStatus os)
        {
            return new SharedDataTypes.OrderStatus()
            {
                Decription = os.StatusDescription
            };
        }

        public static SharedDataTypes.Customer ConvertToSharedCustomer(DataBases.Customer c)
        {
            return new SharedDataTypes.Customer()
            {
                CustomerId = c.ID_Customer,
                FirstName = c.FirstName,
                LastName = c.LastName,
                Address = ConvertToSharedAddress(c.Address.First()),
                Mail = c.Mail,
                PhoneNumber = c.PhoneNumber,
            };
        }

        public static SharedDataTypes.Address ConvertToSharedAddress(DataBases.Address a)
        {
            return new SharedDataTypes.Address()
            {
                AdressId = a.ID_Address,
                City = a.City,
                HouseNumber = a.HouseNumber,
                StreetName = a.StreetName,
                Zip = a.ZIP
            };
        }

        public SharedDataTypes.Wrapping ConvertToSharedWrapping(DataBases.Wrapping DBWrapping)
        {
            return new SharedDataTypes.Wrapping
            {
                WrappingId = DBWrapping.ID_Wrapping,
                Name = DBWrapping.Name,
                ImgPath = DBWrapping.Image
            };
        }

        public SharedDataTypes.Shape ConvertToSharedShape(DataBases.Shape shape)
        {
            return new SharedDataTypes.Shape
            {
                ShapeId = shape.ID_Shape,
                Name = shape.Name,
                Image = new Uri(shape.Image)
            };
        }
    }
}
