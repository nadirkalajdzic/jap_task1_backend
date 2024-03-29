﻿using AutoMapper;
using jap_task1_backend.DTO.Actor;
using jap_task1_backend.DTO.Category;
using jap_task1_backend.DTO.Rating;
using jap_task1_backend.DTO.Video;
using jap_task1_backend.Models;

namespace jap_task1_backend
{
    public class AutoMapperProfile: Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Video, GetVideoDTO>();
            CreateMap<Rating, GetRatingOnlyDTO>();
            CreateMap<Actor, GetActorForVideoDTO>();
            CreateMap<Category, GetCategoryForVideoDTO>();
            CreateMap<Video, GetVideoFullInfoDTO>();
        }
    }
}
