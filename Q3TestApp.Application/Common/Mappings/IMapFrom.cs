using AutoMapper;
using System.Collections.Generic;
using System.Text;

namespace Q3TestApp.Application.Common.Mappings
{
    public interface IMapFrom<T>
    {
        void Mapping(Profile profile) => profile.CreateMap(typeof(T), GetType());
    }
}
