using AutoMapper;

namespace ITWorkRequest.API.Helpers
{
   public class AutoMapperProfiles: Profile
    {
        public AutoMapperProfiles()
        {
            // CreateMap<User,UserForListDto>()
            // .ForMember(dest => dest.PhotoUrl , act => act.MapFrom( src => src.Photos.FirstOrDefault(p => p.IsMain ).Url))
            // .ForMember(dest => dest.Age , act => act.MapFrom( src => src.DateOfBirth.CalculateAge()))
            // ;
            
        
            // CreateMap<User,UserForDetailedDto>()
            // .ForMember(dest => dest.PhotoUrl , act => act.MapFrom( src => src.Photos.FirstOrDefault(p => p.IsMain).Url))
            // .ForMember(dest => dest.Age , act => act.MapFrom( src => src.DateOfBirth.CalculateAge() ))
            // ;
            
            // CreateMap<UserForUpdateDto , User>();
            
            // CreateMap<Photo, PhotosForDetailedDto>();            
            // CreateMap<Photo , PhotosFromReturnDto>();
            // CreateMap<PhotoForCreationDto , Photo>();

            // CreateMap<UserForRegisterDto, User>();
        }
        
    }
}