﻿using AutoMapper;
using Persistence.Entities;
using Persistence.ViewModel.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Mapper
{
	public class MapperConfig : Profile
	{
		public MapperConfig()
		{
			CreateMap<Customer, CustomerViewModel>();
			CreateMap<Product, ProductViewModel>();
			CreateMap<Category, CategoryViewModel>();
			CreateMap<ProductImage, ProductImageViewModel>();
			CreateMap<Cart, CartViewModel>();
			CreateMap<CartItem, CartItemViewModel>();
			CreateMap<Product, ProductCartItemViewModel>().ForMember(x => x.ProductImages, x => x.MapFrom(x => x.ProductImages.FirstOrDefault()));
			CreateMap<Order, OrderViewModel>();
			CreateMap<OrderDetail, OrderDetailViewModel>();
		}
	}
}
